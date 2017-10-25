Imports System.ComponentModel
Imports Newtonsoft.Json.Linq

Public Class _1_RomsScreenScraperSystemSelectControl

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
    Private Sub _1_RomsScreenScraperSystemSelectControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me._parent = TryCast(Me.Parent.Parent, RomsContainerControl)

            If Me._parent Is Nothing Then Throw New Exception("Unexpected error")

            Me.ActionPanel.Visible = False
            Me.ActionWaitingControl.Visible = True
            Me.ActionWaitingControl.HeaderLabel.Text = "Please wait for screenscraper.fr"
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
    ''' Retrieve Screen Scraper systems list
    ''' </summary>
    Private Function GetScreenScraperSystems(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Boolean
        Dim result = False

        Try
            result = ScrapSystemsHelper.GetScreenScraperSystems(Me._parent.ScreenScraperSystemsList, Me._workerDetailsLastLine)
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
    Private Sub ScreenScraperSystemsLoadBackgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles LoadBackgroundWorker.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        e.Result = GetScreenScraperSystems(worker, e)
    End Sub

    ''' <summary>
    ''' Update waiting progress update
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScreenScraperSystemsLoadBackgroundWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles LoadBackgroundWorker.ProgressChanged
        Me.ActionWaitingControl.DetailsTextBox.AppendText(Me._workerDetailsLastLine)
    End Sub

    ''' <summary>
    ''' Is triggered when Screen Scraper Systems List loading is finished
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScreenScraperSystemsLoadBackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles LoadBackgroundWorker.RunWorkerCompleted
        If (e.Error Is Nothing) Or Not e.Cancelled Then
            Me.SystemsListComboBox.DataSource = Me._parent.ScreenScraperSystemsList.Select("", "Name ASC")
            Me.SystemsListComboBox.DisplayMember = Me._parent.ScreenScraperSystemsList.Columns("Name").ToString
            Me.SystemsListComboBox.ValueMember = Me._parent.ScreenScraperSystemsList.Columns("Id").ToString

            Me.SystemsListComboBox.SelectedIndex = -1

            Me.ActionPanel.Visible = True
            Me.ActionWaitingControl.Visible = False

            Me._parent.ButtonPrevious.Enabled = True

            Me._isJobDone = True
        End If
    End Sub

    ''' <summary>
    ''' Set the selected system's id
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SystemsListComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SystemsListComboBox.SelectedIndexChanged
        Try
            If Me._isJobDone Then
                Me._parent.ScreenScraperSelectedSystem = Me.SystemsListComboBox.SelectedValue

                Me._parent.ButtonNext.Enabled = True
                Me._parent.ButtonPrevious.Enabled = True
            End If
        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub
End Class
