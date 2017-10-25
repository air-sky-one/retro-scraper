Imports System.ComponentModel
Imports System.IO
Imports System.Text

Public Class _2_EmulatorSelectControl

    ''' <summary>
    ''' Parent con tainer control
    ''' </summary>
    Private _parent As RomsContainerControl

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
    ''' <param name="e"></param>
    Private Sub _2_EmulatorSelectControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me._parent = TryCast(Me.Parent.Parent, RomsContainerControl)

            If Me._parent Is Nothing Then Throw New Exception("Unexpected error")

            Me.ActionPanel.Visible = False
            Me.ActionWaitingControl.Visible = True
            Me.ActionWaitingControl.HeaderLabel.Text = "Please wait while emulators config files are loading"
            Me.ActionWaitingControl.DetailsTextBox.Visible = True
            Me.ActionWaitingControl.DetailsProgressBar.Visible = False
            Me.ActionWaitingControl.MainProgressLabel.Visible = False

            Me._parent.ButtonNext.Enabled = False
            Me._parent.ButtonPrevious.Enabled = False

            ' start asynchrone screenscraper system list loading
            LoadBackgroundWorker.RunWorkerAsync()
        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try

    End Sub

    ''' <summary>
    ''' Retrieve the emulators list
    ''' </summary>
    ''' <param name="worker"></param>
    ''' <param name="e"></param>
    ''' <returns></returns>
    Private Function GetEmulatorsList(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Boolean
        Dim result As Boolean = False

        Try
            result = ScrapEmulatorHelper.GetEmulatorsList(Me._parent.AttractModeEmulatorsList, Me._workerDetailsLastLine)
        Catch ex As Exception
            Throw ex
        End Try

        Return result
    End Function

    ''' <summary>
    ''' Defines the asynchronous Job for loading Emulators List loading
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EmulatorsLoadBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoadBackgroundWorker.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        e.Result = GetEmulatorsList(worker, e)
    End Sub

    ''' <summary>
    ''' Update waiting progress update
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EmulatorsLoadBackgroundWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles LoadBackgroundWorker.ProgressChanged
        Me.ActionWaitingControl.DetailsTextBox.AppendText(Me._workerDetailsLastLine)
    End Sub

    ''' <summary>
    ''' Is triggered when Emulators List loading is finished
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EmulatorsLoadBackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles LoadBackgroundWorker.RunWorkerCompleted
        If (e.Error Is Nothing) Or Not e.Cancelled Then
            Me.EmulatorsListComboBox.DataSource = Me._parent.AttractModeEmulatorsList.Select("", "Name ASC")
            Me.EmulatorsListComboBox.DisplayMember = Me._parent.AttractModeEmulatorsList.Columns("Name").ToString
            Me.EmulatorsListComboBox.ValueMember = Me._parent.AttractModeEmulatorsList.Columns("path").ToString

            Me.EmulatorsListComboBox.SelectedIndex = -1

            Me.ActionPanel.Visible = True
            Me.ActionWaitingControl.Visible = False

            Me._parent.ButtonPrevious.Enabled = True

            Me._isJobDone = True
        End If
    End Sub

    ''' <summary>
    ''' Load the accepted roms extensions files by the emulator
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EmulatorsListComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EmulatorsListComboBox.SelectedIndexChanged
        Dim path As String = String.Empty
        Dim content As String = String.Empty
        Dim cpt As Integer = 0
        Dim isErr As Boolean = False

        Try
            If Me._isJobDone Then

                Me.SuspendLayout()
                Cursor.Current = Cursors.WaitCursor

                path = Me.EmulatorsListComboBox.SelectedValue.ToString

                ' Get accepted roms files extension
                ScrapEmulatorHelper.SetRomFilesExtensions(path, Me._parent.RomsExtensions, cpt)

                ' Get type of artworks and their associated folder path
                ScrapEmulatorHelper.SetArtworksTypesAndFolders(path, Me._parent.RomsArtworks)

                If cpt = 0 Then
                    Dim err As New Exception("The selected emulator file doesn't contain roms extensions definition. Please choose a valid emulator config file.")

                    isErr = True
                    ShowErrorMessage(err)
                Else
                    cpt = Me._parent.RomsExtensions.Count

                    If cpt > 0 Then
                        Me.RomsExtensionsLabel.Text = "Accepted roms extension files : "
                        Me.RomsExtensionsLabel.Visible = True

                        For Each ext As String In Me._parent.RomsExtensions
                            Me.RomsExtensionsLabel.Text = Me.RomsExtensionsLabel.Text & ext & ", "
                        Next
                        Me.RomsExtensionsLabel.Text = Me.RomsExtensionsLabel.Text.Substring(0, Me.RomsExtensionsLabel.Text.Length - 2)

                        Dim artworksBuilder As New StringBuilder
                        Me.ArtworksLabel.Text = "Artworks :"
                        artworksBuilder.Append(Me.ArtworksLabel.Text & vbCrLf)
                        For Each a As RomsDataSet.ArtworksRow In Me._parent.RomsArtworks
                            artworksBuilder.Append("- Name : '" & a.Name & "'    Folder Name : '" & a.Path & "'" & vbCrLf)
                        Next
                        Me.ArtworksLabel.Text = artworksBuilder.ToString
                        Me.ArtworksLabel.Visible = True
                    Else
                        Dim err As New Exception("The selected emulator file accept no specific roms files extensions. Please select another emulator in the list or update the emulator file.")

                        isErr = True
                        ShowErrorMessage(err)
                    End If
                End If

                If Not isErr Then
                    Me._parent.ButtonNext.Enabled = True
                    Me._parent.AttractModeSelectedSystem = TryCast(Me.EmulatorsListComboBox.SelectedItem, RomsDataSet.EmulatorsRow).Name.ToString
                End If

                Cursor.Current = Cursors.Default
            End If
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            ShowErrorMessage(ex)
        End Try
    End Sub
End Class
