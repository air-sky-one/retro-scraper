Imports System.IO
Imports System.Text

Public Class _3_RomsPathControl

    ''' <summary>
    ''' Parent con tainer control
    ''' </summary>
    Private _parent As RomsContainerControl

    ''' <summary>
    ''' Indicates if the background worker's job is done
    ''' </summary>
    Private _isJobDone As Boolean = False

    ''' <summary>
    ''' Component initialization
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _3_RomsPathControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me._parent = TryCast(Me.Parent.Parent, RomsContainerControl)

            If Me._parent Is Nothing Then Throw New Exception("Unexpected error")

            Me._parent.ButtonNext.Enabled = False

        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Open OpenFolderDialog window
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FolderPathButton_Click(sender As Object, e As EventArgs) Handles FolderPathButton.Click
        Dim path As String = String.Empty
        Dim searchPattern As New StringBuilder
        Dim isErr As Boolean = False
        Dim cpt As Integer = 0

        Try
            Me.RomsFolderBrowserDialog.ShowDialog()
            path = Me.RomsFolderBrowserDialog.SelectedPath

            If Not path = String.Empty Then
                For Each ext As String In Me._parent.RomsExtensions
                    searchPattern.Append("*" & ext & ",")
                Next

                Dim collection As List(Of String) = GetFilesAssociatedToExtensions(path, Me._parent.RomsExtensions)

                If collection.Count > 0 Then
                    Me.FolderPathTextBox.Text = path
                    Me._parent.RomsPath = path
                    Me.ResultsLabel.Text = collection.Count.ToString & " roms where detected in " & path
                    Me.ResultsLabel.Visible = True

                    Me._parent.ButtonNext.Enabled = True
                Else
                    Dim err As New Exception("The selected folder doesn't contain any roms accepted by the selected emulator. Please select another folder or populate this folder with roms with extensions that are accepted by the selected emulator.")
                    Me.ResultsLabel.Visible = False

                    isErr = True
                    ShowErrorMessage(err)
                End If
            End If
        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub
End Class
