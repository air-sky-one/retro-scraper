Public Class _4_RomListChoiceControl

    ''' <summary>
    ''' Parent con tainer control
    ''' </summary>
    Private _parent As RomsContainerControl

    ''' <summary>
    ''' Component initialization
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _4_RomListChoiceControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me._parent = TryCast(Me.Parent.Parent, RomsContainerControl)

            If Me._parent Is Nothing Then Throw New Exception("Unexpected error")
        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Choice made by radio button : (un)display the folder path selector
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UpdateFileRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles UpdateFileRadioButton.CheckedChanged
        If Me.UpdateFileRadioButton.Checked = True Then
            Me.FolderPathPanel.Visible = True
            Me._parent.IsRomListNewFile = False
            Me._parent.ButtonNext.Enabled = False
        Else
            Me.FolderPathPanel.Visible = False
            Me._parent.IsRomListNewFile = True
            Me._parent.ButtonNext.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Open OpenFolderDialog window
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FolderPathButton_Click(sender As Object, e As EventArgs) Handles FolderPathButton.Click
        Dim path As String = String.Empty
        Dim searchPattern As String = String.Empty

        Try

            Me.RomlistFileBrowserDialog.Filter = "Text Files (*.txt)|*.txt"
            Me.RomlistFileBrowserDialog.ShowDialog()
            path = Me.RomlistFileBrowserDialog.FileName

            If Not path = String.Empty Then
                Me._parent.RomlistFilePath = path
                Me.FolderPathTextBox.Text = path
                Me._parent.ButtonNext.Enabled = True
            Else
                Me._parent.ButtonNext.Enabled = False
            End If

        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

End Class
