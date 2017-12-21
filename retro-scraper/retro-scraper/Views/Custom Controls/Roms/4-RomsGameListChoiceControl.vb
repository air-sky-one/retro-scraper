Imports System.IO

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

            If String.IsNullOrEmpty(Me._parent.RomlistFilePath) Then Me._parent.RomlistFilePath = Me._parent.RomsPath & "\" & Me._parent.AttractModeSelectedSystem & ".cfg"

            Me.NewRomlistFilePathTextBox.Text = Me._parent.RomlistFilePath

        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Indicate if the game's title will be the same as the associated rom/iso file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UseFilenameForTitleCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles UseFilenameForTitleCheckBox.CheckedChanged
        If Me._parent IsNot Nothing Then
            If Me.UseFilenameForTitleCheckBox.Checked = True Then
                Me._parent.IsUseFileNameForGameTitle = True
            Else
                Me._parent.IsUseFileNameForGameTitle = False
            End If
        End If
    End Sub

    ''' <summary>
    ''' Indicate if the rom/iso's files whiche were not found on screenscraper have to be included in the romlist
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub IncludeGamesNotFoundCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles IncludeGamesNotFoundCheckBox.CheckedChanged
        If Me._parent IsNot Nothing Then
            If Me.IncludeGamesNotFoundCheckBox.Checked = True Then
                Me._parent.IsIncludeNotFoundGames = True
            Else
                Me._parent.IsIncludeNotFoundGames = False
            End If
        End If
    End Sub

    ''' <summary>
    ''' Choice made by radio button : (un)display the folder path selector
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UpdateFileRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles UpdateFileRadioButton.CheckedChanged
        If Me.UpdateFileRadioButton.Checked = True Then
            Me._parent.IsRomListNewFile = False
            Me.UpdatedRomlistFilePathPanel.Visible = True
            Me.NewRomlistFilePathPanel.Visible = False

            If File.Exists(Me.UpdatedRomlistFilePathTextBox.Text) Then
                Me._parent.ButtonNext.Enabled = True
            Else
                Me._parent.ButtonNext.Enabled = False
            End If
        Else
            Me.UpdatedRomlistFilePathPanel.Visible = False
            Me._parent.IsRomListNewFile = True
            Me.UpdatedRomlistFilePathPanel.Visible = False
            Me.NewRomlistFilePathPanel.Visible = True

            If Not String.IsNullOrEmpty(Me.NewRomlistFilePathTextBox.Text) Then
                Me._parent.ButtonNext.Enabled = True
            Else
                Me._parent.ButtonNext.Enabled = False
            End If
        End If
    End Sub

    ''' <summary>
    ''' Open FolderBrowserDialog fom Romlist path to create
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NewRomlistFilePathButton_Click(sender As Object, e As EventArgs) Handles NewRomlistFilePathButton.Click
        Dim path As String = String.Empty

        Me.NewRomlistFilePathFolderBrowserDialog.ShowDialog()
        If Not String.IsNullOrEmpty(Me.NewRomlistFilePathFolderBrowserDialog.SelectedPath) Then
            path = Me.NewRomlistFilePathFolderBrowserDialog.SelectedPath & "\" & Me._parent.AttractModeSelectedSystem & ".cfg"
        Else
            path = String.Empty
        End If

        Try
            If Not path = String.Empty Then
                Me._parent.RomlistFilePath = path
                Me.NewRomlistFilePathTextBox.Text = path
                Me._parent.ButtonNext.Enabled = True
            Else
                Me.NewRomlistFilePathTextBox.Text = String.Empty
                Me._parent.ButtonNext.Enabled = False
            End If

        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try

    End Sub

    ''' <summary>
    ''' Open OpenFileDialog window for Romlist file path to update
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UpdatedRomlistFilePath_Click(sender As Object, e As EventArgs) Handles UpdatedRomlistFilePathButton.Click
        Dim path As String = String.Empty
        Dim searchPattern As String = String.Empty

        Try

            Me.UpdatedRomlistFilePathOpenFileDialog.Filter = "Text Files (*.txt)|*.txt"
            Me.UpdatedRomlistFilePathOpenFileDialog.ShowDialog()
            If Not Me.UpdatedRomlistFilePathOpenFileDialog.FileName = "romlist.txt" Then
                path = Me.UpdatedRomlistFilePathOpenFileDialog.FileName
            Else
                path = String.Empty
            End If

            If Not path = String.Empty Then
                Me._parent.RomlistFilePath = path
                Me.UpdatedRomlistFilePathTextBox.Text = path
                Me._parent.ButtonNext.Enabled = True
            Else
                Me.UpdatedRomlistFilePathTextBox.Text = String.Empty
                Me._parent.ButtonNext.Enabled = False
            End If

        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

End Class
