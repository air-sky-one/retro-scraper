Imports System.ComponentModel
Imports System.IO

Public Class _3_AnalysisLoadingProcessControl

    ''' <summary>
    ''' Parent con tainer control
    ''' </summary>
    Private _parent As AnalysisContainerControl

    ''' <summary>
    ''' Main progress Text to display
    ''' </summary>
    Private _mainProgressText As String

    ''' <summary>
    ''' Last line of waiting details to display
    ''' </summary>
    Private _workerDetailsLastLine As String = String.Empty

    ''' <summary>
    ''' Indicates if the background worker's job is done
    ''' </summary>
    Private _isJobDone As Boolean = False

    ''' <summary>
    ''' Component initialization
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>s
    Private Sub _3_AnalysisLoadingProcessControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me._parent = TryCast(Me.Parent.Parent, AnalysisContainerControl)

            If Me._parent Is Nothing Then Throw New Exception("Unexpected error")

            'Dim collection = From fi In New DirectoryInfo(Me._parent.RomsPath).GetFiles()
            '                 Where Me._parent.RomsExtensions.Contains(fi.Extension.ToUpper())
            Dim collection As List(Of String) = GetFilesAssociatedToExtensions(Me._parent.RomsPath, Me._parent.RomsExtensions)

            If collection.Count > 0 Then
                With Me.ActionWaitingControl
                    .Visible = True
                    .HeaderLabel.Text = "Please wait while retro-scraper analyse your roms"
                    .DetailsTextBox.Visible = True
                    .DetailsProgressBar.Visible = True
                    .MainProgressLabel.Visible = True

                    .MainWaitingProgressBar.Style = ProgressBarStyle.Continuous
                    .MainWaitingProgressBar.Maximum = collection.Count
                End With

                Me._parent.RomsData.Clear()

                Me._parent.ButtonNext.Enabled = False
                Me._parent.ButtonPrevious.Enabled = False

                ' start asynchrone screenscraper system list loading
                LoadBackgroundWorker.RunWorkerAsync()
            Else
                Throw New Exception("Oups ! It seems that your roms have disapeared from the selected folder.")
            End If

            If Me._parent.RomsData.Columns.Count > 0 Then Me._parent.RomsData.Columns.Clear()

            Me._parent.RomsData.Columns.Add("Filename")
            For Each art As RomsDataSet.ArtworksRow In Me._parent.RomsArtworks
                Dim c As New DataColumn With {.ColumnName = art.Name,
                                              .DataType = True.GetType}
                Me._parent.RomsData.Columns.Add(c)
            Next

        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Retrieve the games data
    ''' </summary>
    ''' <param name="worker"></param>
    ''' <param name="e"></param>
    ''' <returns></returns>
    Private Function GetGamesData(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Boolean
        Dim result As Boolean = False
        Dim cpt As Integer = 0

        Dim collection As List(Of String) = GetFilesAssociatedToExtensions(Me._parent.RomsPath, Me._parent.RomsExtensions)

        Me._mainProgressText = String.Empty

        If collection.Count > 0 Then
            For Each file As String In collection
                Dim isFind As Boolean = False

                Dim r As DataRow = Me._parent.RomsData.NewRow
                file = file.Substring(0, file.Length - 4)
                r("Filename") = file.Substring(file.LastIndexOf("\") + 1)

                Me._mainProgressText = r("Filename")

                For Each art As RomsDataSet.ArtworksRow In Me._parent.RomsArtworks
                    isFind = False

                    If Directory.Exists(Me._parent.RomsPath & "\" & art.Name) Then
                        For Each f As FileInfo In New DirectoryInfo(Me._parent.RomsPath & "\" & art.Name).GetFiles()
                            If f.Name.Contains(r("Filename")) Then
                                isFind = True
                                Exit For
                            End If
                        Next
                    End If
                    r(art.Name) = isFind
                Next
                Me._parent.RomsData.Rows.Add(r)

                cpt = cpt + 1
                worker.ReportProgress(cpt)
            Next
        End If

        If Me._parent.RomsData.Select.Count > 0 Then
            result = True
        End If

        Return result

    End Function

    ''' <summary>
    ''' Defines the asynchronous Job for loading Screen Scraper data
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LoadBackgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles LoadBackgroundWorker.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        e.Result = GetGamesData(worker, e)
    End Sub

    ''' <summary>
    ''' Update waiting progress update
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LoadBackgroundWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles LoadBackgroundWorker.ProgressChanged
        With Me.ActionWaitingControl
            .MainProgressLabel.Text = Me._mainProgressText
            .MainWaitingProgressBar.Value = e.ProgressPercentage

            .DetailsTextBox.AppendText(Me._workerDetailsLastLine)
        End With
    End Sub

    ''' <summary>
    ''' Is triggered when Screen Scraper Games data loading is finished
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LoadBackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles LoadBackgroundWorker.RunWorkerCompleted
        If (e.Error Is Nothing) Or Not e.Cancelled Then
            Me.ActionWaitingControl.DetailsProgressBar.Visible = False
            Me.ActionWaitingControl.MainProgressLabel.Visible = False
            Me.ActionWaitingControl.HeaderLabel.Text = "Finished !"


            Me.ActionWaitingControl.DetailsTextBox.Visible = False

            Me._parent.ButtonPrevious.Enabled = True
             Me._parent.ButtonNext.Enabled = True
        End If
    End Sub

End Class
