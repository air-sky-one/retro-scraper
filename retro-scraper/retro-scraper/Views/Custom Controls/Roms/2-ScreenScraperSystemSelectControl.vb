Imports System.ComponentModel
Imports Newtonsoft.Json.Linq

Public Class _2_ScreenScraperSystemSelectControl

    ''' <summary>
    ''' Parent con tainer control
    ''' </summary>
    Private _parent As RomsContainerControl

    ''' <summary>
    ''' Component initialization
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _2_ScreenScraperSystemSelectControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me._parent = TryCast(Me.Parent.Parent, RomsContainerControl)

            If Me._parent Is Nothing Then Throw New Exception("Unexpected error")

            Me.ActionPanel.Visible = False
            Me.ActionWaitingControl.Visible = True
            Me.ActionWaitingControl.WaitingTitle.Text = "Please wait for screenscraper.fr"
            Me.ActionWaitingControl.DetailsText.Visible = True

            ' start asynchrone screenscraper system list loading
            ScreenScraperSystemsLoadBackgroundWorker.RunWorkerAsync()
        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try

    End Sub

    ''' <summary>
    ''' Retrieve Screen Scraper systems list
    ''' </summary>
    Private Function GetScreenScraperSystems(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Boolean
        Dim result = False
        Dim webClient As New System.Net.WebClient()
        Dim query As String = String.Empty
        Dim json As String = String.Empty

        Try
            Me._parent.ScreenScraperSystemsList.Clear()

            query = BuildGenericURL("systemesListe.php")
            json = webClient.DownloadString(query)

            If Not String.IsNullOrEmpty(json) Then
                Dim o As JObject = JObject.Parse(json)
                Dim cpt As Integer = 0

                For Each s As JToken In o.SelectToken("response.systemes")
                    Dim r As RomsDataSet.ScreenScraperSystemsRow

                    cpt = cpt + 1

                    r = Me._parent.ScreenScraperSystemsList.NewRow

                    If s.SelectToken("id", False) IsNot Nothing Then r.Id = s.SelectToken("id", False) Else r.Id = String.Empty

                    If Not String.IsNullOrEmpty(r.Id) Then
                        If s.SelectToken("noms.nom_eu", False) IsNot Nothing Then r.Name_EU = s.SelectToken("noms.nom_eu", False) Else r.Name_EU = String.Empty
                        If s.SelectToken("noms.nom_us", False) IsNot Nothing Then r.Name_US = s.SelectToken("noms.nom_us", False) Else r.Name_US = String.Empty
                        If s.SelectToken("noms.nom_jp", False) IsNot Nothing Then r.Name_JP = s.SelectToken("noms.nom_jp", False) Else r.Name_JP = String.Empty

                        ' TODO : preferred language
                        Select Case AppGlobals.user(0).favregion
                            Case Else
                                r.Name = r.Name_EU
                        End Select

                        Me._parent.ScreenScraperSystemsList.AddScreenScraperSystemsRow(r)
                        AddLogs(LogsLevel._Info_, "Add ScreenScraper system to list", "")
                    Else
                        AddLogs(LogsLevel._Warning_, "ScreenScraper system with no identifier", "no details")
                    End If

                    worker.ReportProgress(cpt)
                Next

                result = True
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return result
    End Function

    ''' <summary>
    ''' Defines the asynchronous Job for loading Screen Scraper Systems List loading
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScreenScraperSystemsLoadBackgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles ScreenScraperSystemsLoadBackgroundWorker.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        e.Result = GetScreenScraperSystems(worker, e)
    End Sub

    ''' <summary>
    ''' Is triggered when Screen Scraper Systems List loading is finished
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScreenScraperSystemsLoadBackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles ScreenScraperSystemsLoadBackgroundWorker.RunWorkerCompleted
        If (e.Error Is Nothing) Or Not e.Cancelled Then
            Me.SystemsListComboBox.DataSource = Me._parent.ScreenScraperSystemsList.Select("", "Name ASC")
            Me.SystemsListComboBox.DisplayMember = Me._parent.ScreenScraperSystemsList.Columns("Name").ToString
            Me.SystemsListComboBox.ValueMember = Me._parent.ScreenScraperSystemsList.Columns("Id").ToString

            Me.ActionPanel.Visible = True
            Me.ActionWaitingControl.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Set the selected system's id
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SystemsListComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SystemsListComboBox.SelectedIndexChanged
        Try
            If Me._parent.ScreenScraperSelectedSystem IsNot Nothing Then
                Me._parent.ScreenScraperSelectedSystem = Me.SystemsListComboBox.SelectedValue
            End If
        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try

    End Sub

    Private Sub ScreenScraperSystemsLoadBackgroundWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles ScreenScraperSystemsLoadBackgroundWorker.ProgressChanged
        Me.ActionWaitingControl.DetailsText.AppendText(e.ProgressPercentage & " : " & Me._parent.ScreenScraperSystemsList.Last.Name & vbCrLf)
    End Sub
End Class
