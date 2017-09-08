Imports System.ComponentModel
Imports System.IO

Public Class _3_EmulatorSelectControl

    ''' <summary>
    ''' Parent con tainer control
    ''' </summary>
    Private _parent As RomsContainerControl

    ''' <summary>
    ''' Last line of waiting details to display
    ''' </summary>
    Private _workerDetailsLastLine As String = String.Empty

    ''' <summary>
    ''' Component initialization
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _3_EmulatorSelectControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me._parent = TryCast(Me.Parent.Parent, RomsContainerControl)

            If Me._parent Is Nothing Then Throw New Exception("Unexpected error")

            Me.ActionPanel.Visible = False
            Me.ActionWaitingControl.Visible = True
            Me.ActionWaitingControl.WaitingTitle.Text = "Please wait while emulators config files are loading"
            Me.ActionWaitingControl.DetailsText.Visible = True

            Me._parent.ButtonNext.Enabled = False
            Me._parent.ButtonPrevious.Enabled = False

            ' start asynchrone screenscraper system list loading
            EmulatorsLoadBackgroundWorker.RunWorkerAsync()
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
        Dim cpt As Integer = 0

        Try
            For Each path As String In Directory.EnumerateFiles(Application.StartupPath() & "\emulators")
                Dim extension As String = path.Substring(path.LastIndexOf("\") + 1) : extension = extension.Substring(extension.IndexOf(".") + 1, 3)

                cpt = cpt + 1

                If extension = "cfg" Then
                    Dim emul As RomsDataSet.EmulatorsRow = Me._parent.AttractModeEmulatorsList.NewEmulatorsRow
                    Dim name As String

                    name = path.Substring(path.LastIndexOf("\") + 1) : name = name.Substring(0, name.IndexOf("."))

                    emul.Name = name
                    emul.Path = path

                    Me._parent.AttractModeEmulatorsList.AddEmulatorsRow(emul)
                    Me._workerDetailsLastLine = cpt.ToString & " : " & emul.Name & vbCrLf
                Else
                    Me._workerDetailsLastLine = cpt.ToString & " : a file config with a wrong extension was found (" & path.Substring(path.LastIndexOf("\") + 1) & ". Not added to list." & vbCrLf
                End If

                ' worker.ReportProgress(cpt)
            Next

            result = True
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
    Private Sub EmulatorsLoadBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles EmulatorsLoadBackgroundWorker.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        e.Result = GetEmulatorsList(worker, e)
    End Sub

    ''' <summary>
    ''' Update waiting progress update
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EmulatorsLoadBackgroundWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles EmulatorsLoadBackgroundWorker.ProgressChanged
        Me.ActionWaitingControl.DetailsText.AppendText(Me._workerDetailsLastLine)
    End Sub

    ''' <summary>
    ''' Is triggered when Emulators List loading is finished
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EmulatorsLoadBackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles EmulatorsLoadBackgroundWorker.RunWorkerCompleted
        If (e.Error Is Nothing) Or Not e.Cancelled Then
            Me.EmulatorsListComboBox.DataSource = Me._parent.AttractModeEmulatorsList.Select("", "Name ASC")
            Me.EmulatorsListComboBox.DisplayMember = Me._parent.AttractModeEmulatorsList.Columns("Name").ToString
            Me.EmulatorsListComboBox.ValueMember = Me._parent.AttractModeEmulatorsList.Columns("path").ToString

            Me.ActionPanel.Visible = True
            Me.ActionWaitingControl.Visible = False

            Me._parent.ButtonNext.Enabled = True
            Me._parent.ButtonPrevious.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EmulatorsListComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EmulatorsListComboBox.SelectedIndexChanged

    End Sub
End Class
