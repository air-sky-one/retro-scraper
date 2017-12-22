Imports System.IO

Public Class _0_RomlistsHomeControl

#Region "Merge"



#End Region

#Region "Main selection"

    ''' <summary>
    ''' (Un)Select the Merge action
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MergeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MergeRadioButton.CheckedChanged
        If Me.MergeRadioButton.Checked = True Then
            Me.MergePanel.Visible = True
        Else
            Me.MergePanel.Visible = False
        End If
    End Sub

#End Region

#Region "Merge"

    ''' <summary>
    ''' Path to folder containning the romlist files to merge
    ''' </summary>
    Private _mergeRomlistFolderPath As String

    ''' <summary>
    ''' List of romlist files
    ''' </summary>
    Private _mergeRomlistFiles As New List(Of String)

    ''' <summary>
    ''' Select the folder containing the romlist files to merge
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MergeFolderPathButton_Click(sender As Object, e As EventArgs) Handles MergeFolderPathButton.Click
        Try
            ' Show Folder Browser Dialog Form
            Me.MergeFolderBrowserDialog.ShowDialog()

            ' if the user selected a valid folder
            If Not String.IsNullOrEmpty(Me.MergeFolderBrowserDialog.SelectedPath) _
                And Directory.Exists(Me.MergeFolderBrowserDialog.SelectedPath) Then

                ' display the selected folder
                Me.MergeFolderPathTextBox.Text = Me.MergeFolderBrowserDialog.SelectedPath
                ' save the location
                Me._mergeRomlistFolderPath = Me.MergeFolderBrowserDialog.SelectedPath
                ' get the files with a correct extension in this folder
                Me._mergeRomlistFiles.Clear()
                Me._mergeRomlistFiles = GetFilesAssociatedToExtensions(Me._mergeRomlistFolderPath, {".txt"})

                ' if there is at least 1 file, continue process
                If Me._mergeRomlistFiles.Count > 0 Then
                    ' display the number of files with the correct extension in the selected folder
                    Me.MergeFolderPathResultsLabel.Text = Me._mergeRomlistFiles.Count & "acceptable files found in this folder"
                    Me.MergeFolderPathResultsLabel.Visible = True

                    Me.MergeChoiceResultFileFlowLayoutPanel.Visible = True

                    If Me.MergeNewFileRadioButton.Checked = True Then : Me.MergeNewFilePanel.Visible = True
                    ElseIf Me.MergeExistingFileRadioButton.Checked = True Then : Me.MergeExistingFilePanel.Visible = True
                    End If

                    Me.MergeExecuteButton.Visible = True
                Else
                    ' no files with a correct extension in the selected folder, hide next steps
                    Me.MergeChoiceResultFileFlowLayoutPanel.Visible = False
                    Me.MergeNewFilePanel.Visible = False
                    Me.MergeExistingFilePanel.Visible = False
                    Me.MergeExecuteButton.Visible = False
                    Me.MergeExecuteButton.Visible = False

                    ' Me.MergeFolderPathResultsLabel.Text = "The selected folder doesn't contain files with the right extenstion (.txt)."
                    Me.MergeErrorProvider.SetError(Me.MergeFolderPathTextBox, "The selected folder doesn't contain files with the right extenstion (.txt).")
                    Me.MergeFolderPathResultsLabel.Visible = True
                End If
            End If
        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    ''' <summary>
    ''' (Un)Select creation of a new file for the selected merged romlist files
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MergeNewFileRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MergeNewFileRadioButton.CheckedChanged
        If Me.MergeNewFileRadioButton.Checked = True Then
            Me.MergeNewFilePanel.Visible = True
        Else
            Me.MergeNewFilePanel.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' (Un)Select merge into an existing file for the selected merged romlist files
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MergeExistingFileRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MergeExistingFileRadioButton.CheckedChanged
        If Me.MergeExistingFileRadioButton.Checked = True Then
            Me.MergeExistingFilePanel.Visible = True
        Else
            Me.MergeExistingFilePanel.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Select the folder containing the new romlist file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MergeNewFileDestinationFolderButton_Click(sender As Object, e As EventArgs) Handles MergeNewFileDestinationFolderButton.Click
        ' Show Folder Browser Dialog Form
        Me.MergeFolderBrowserDialog.ShowDialog()

        ' if the user selected a valid folder
        If Not String.IsNullOrEmpty(Me.MergeFolderBrowserDialog.SelectedPath) _
                And Directory.Exists(Me.MergeFolderBrowserDialog.SelectedPath) Then

            Me.MergeNewFileDestinationFolderTextBox.Text = Me.MergeFolderBrowserDialog.SelectedPath
        Else
            Me.MergeNewFileDestinationFolderTextBox.Text = String.Empty
            Me.MergeErrorProvider.SetError(Me.MergeNewFileDestinationFolderTextBox, "Please select a correct destination folder.")
        End If
    End Sub

    ''' <summary>
    ''' Select the the romlist file to merge into
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MergeExistingFileButton_Click(sender As Object, e As EventArgs) Handles MergeExistingFileButton.Click
        ' Show Folder Browser Dialog Form
        Me.MergeExistingFileOpenFileDialog.Filter = "Text Files (*.txt)|*.txt"
        Me.MergeExistingFileOpenFileDialog.ShowDialog()

        If Me.MergeExistingFileOpenFileDialog.FileName = "romlist.txt" Then Me.MergeExistingFileTextBox.Text = String.Empty

        If Not String.IsNullOrEmpty(Me.MergeExistingFileOpenFileDialog.FileName) And File.Exists(Me.MergeExistingFileOpenFileDialog.FileName) Then
            Me.MergeExistingFileTextBox.Text = Me.MergeExistingFileOpenFileDialog.FileName
        Else
            Me.MergeExistingFileTextBox.Text = String.Empty
            Me.MergeErrorProvider.SetError(Me.MergeExistingFileTextBox, "Please select a correct destination romlist file.")
        End If
    End Sub

    ''' <summary>
    ''' Merge all th correct romlist files into one
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MergeExecuteButton_Click(sender As Object, e As EventArgs) Handles MergeExecuteButton.Click
        ' operation for saving the result in a new file
        If Me.MergeNewFileRadioButton.Checked Then
            If Me.MergeNewFileNameTextBox.Text.Length > 0 And Directory.Exists(Me.MergeNewFileDestinationFolderTextBox.Text) Then
                Me._mergeRomlistFiles.Clear()
                Me._mergeRomlistFiles = GetFilesAssociatedToExtensions(Me._mergeRomlistFolderPath, {".txt"})
                Dim content As String = ExportRomlistDataTableToString(MergeRomlistFiles(Me._mergeRomlistFiles), True)
                If File.Exists(Me.MergeNewFileDestinationFolderTextBox.Text & "\" & Me.MergeNewFileNameTextBox.Text & ".txt") Then
                    File.Delete(Me.MergeNewFileDestinationFolderTextBox.Text & "\" & Me.MergeNewFileNameTextBox.Text & ".txt")
                End If
                File.WriteAllText(Me.MergeNewFileDestinationFolderTextBox.Text & "\" & Me.MergeNewFileNameTextBox.Text & ".txt", content)
            Else
                ' operation for saving the result in an extisting file
                If Me.MergeNewFileNameTextBox.Text.Length = 0 Then Me.MergeErrorProvider.SetError(Me.MergeNewFileNameTextBox, "Please enter a correct file name.")
                If Not Directory.Exists(Me.MergeNewFileDestinationFolderTextBox.Text) Then Me.MergeErrorProvider.SetError(Me.MergeNewFileDestinationFolderTextBox, "Please select a correct destination folder.")
            End If
        ElseIf Me.MergeExistingFileRadioButton.Checked Then
            If Me.MergeExistingFileTextBox.Text.Length > 0 And File.Exists(Me.MergeExistingFileTextBox.Text) Then
                Me._mergeRomlistFiles.Clear()
                Me._mergeRomlistFiles = GetFilesAssociatedToExtensions(Me._mergeRomlistFolderPath, {".txt"})
                Me._mergeRomlistFiles.Add(Me.MergeExistingFileTextBox.Text)

                Dim content As String = ExportRomlistDataTableToString(MergeRomlistFiles(Me._mergeRomlistFiles), True)
                If File.Exists(Me.MergeExistingFileTextBox.Text) Then
                    File.Delete(Me.MergeExistingFileTextBox.Text)
                End If
                File.WriteAllText(Me.MergeExistingFileTextBox.Text, content)
            Else
                If Me.MergeExistingFileTextBox.Text.Length = 0 Then Me.MergeErrorProvider.SetError(Me.MergeExistingFileTextBox, "Please enter a romlist file.")
            End If
        End If
    End Sub

#End Region

End Class
