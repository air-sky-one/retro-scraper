<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _4_RomListChoiceControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ActionPanel = New System.Windows.Forms.Panel()
        Me.ChoiceFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.UseFilenameForTitleCheckBox = New System.Windows.Forms.CheckBox()
        Me.IncludeGamesNotFoundCheckBox = New System.Windows.Forms.CheckBox()
        Me.NewFileRadioButton = New System.Windows.Forms.RadioButton()
        Me.NewRomlistFilePathPanel = New System.Windows.Forms.Panel()
        Me.NewRomlistFilePathButton = New System.Windows.Forms.Button()
        Me.NewRomlistFilePathTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateFileRadioButton = New System.Windows.Forms.RadioButton()
        Me.UpdatedRomlistFilePathPanel = New System.Windows.Forms.Panel()
        Me.UpdatedRomlistFilePathButton = New System.Windows.Forms.Button()
        Me.UpdatedRomlistFilePathTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.UpdatedRomlistFilePathOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.NewRomlistFilePathFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.ActionPanel.SuspendLayout()
        Me.ChoiceFlowLayoutPanel.SuspendLayout()
        Me.NewRomlistFilePathPanel.SuspendLayout()
        Me.UpdatedRomlistFilePathPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ActionPanel
        '
        Me.ActionPanel.Controls.Add(Me.ChoiceFlowLayoutPanel)
        Me.ActionPanel.Controls.Add(Me.DescriptionLabel)
        Me.ActionPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ActionPanel.Location = New System.Drawing.Point(0, 0)
        Me.ActionPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ActionPanel.Name = "ActionPanel"
        Me.ActionPanel.Size = New System.Drawing.Size(878, 212)
        Me.ActionPanel.TabIndex = 8
        '
        'ChoiceFlowLayoutPanel
        '
        Me.ChoiceFlowLayoutPanel.AutoSize = True
        Me.ChoiceFlowLayoutPanel.Controls.Add(Me.UseFilenameForTitleCheckBox)
        Me.ChoiceFlowLayoutPanel.Controls.Add(Me.IncludeGamesNotFoundCheckBox)
        Me.ChoiceFlowLayoutPanel.Controls.Add(Me.NewFileRadioButton)
        Me.ChoiceFlowLayoutPanel.Controls.Add(Me.NewRomlistFilePathPanel)
        Me.ChoiceFlowLayoutPanel.Controls.Add(Me.UpdateFileRadioButton)
        Me.ChoiceFlowLayoutPanel.Controls.Add(Me.UpdatedRomlistFilePathPanel)
        Me.ChoiceFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.ChoiceFlowLayoutPanel.Location = New System.Drawing.Point(20, 38)
        Me.ChoiceFlowLayoutPanel.Name = "ChoiceFlowLayoutPanel"
        Me.ChoiceFlowLayoutPanel.Size = New System.Drawing.Size(861, 168)
        Me.ChoiceFlowLayoutPanel.TabIndex = 5
        '
        'UseFilenameForTitleCheckBox
        '
        Me.UseFilenameForTitleCheckBox.AutoSize = True
        Me.UseFilenameForTitleCheckBox.Checked = True
        Me.UseFilenameForTitleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UseFilenameForTitleCheckBox.Font = New System.Drawing.Font("Ubuntu Light", 8.25!)
        Me.UseFilenameForTitleCheckBox.Location = New System.Drawing.Point(3, 3)
        Me.UseFilenameForTitleCheckBox.Name = "UseFilenameForTitleCheckBox"
        Me.UseFilenameForTitleCheckBox.Size = New System.Drawing.Size(545, 20)
        Me.UseFilenameForTitleCheckBox.TabIndex = 7
        Me.UseFilenameForTitleCheckBox.Text = "Use filename for game's title (HyperSpin naming convention is recommended for rom" &
    "/iso's filenames) "
        Me.UseFilenameForTitleCheckBox.UseVisualStyleBackColor = True
        '
        'IncludeGamesNotFoundCheckBox
        '
        Me.IncludeGamesNotFoundCheckBox.AutoSize = True
        Me.IncludeGamesNotFoundCheckBox.Checked = True
        Me.IncludeGamesNotFoundCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.IncludeGamesNotFoundCheckBox.Font = New System.Drawing.Font("Ubuntu Light", 8.25!)
        Me.IncludeGamesNotFoundCheckBox.Location = New System.Drawing.Point(3, 29)
        Me.IncludeGamesNotFoundCheckBox.Name = "IncludeGamesNotFoundCheckBox"
        Me.IncludeGamesNotFoundCheckBox.Size = New System.Drawing.Size(657, 20)
        Me.IncludeGamesNotFoundCheckBox.TabIndex = 8
        Me.IncludeGamesNotFoundCheckBox.Text = "Include games which were not found on screenscraper.fr in the romlist (rom/iso's " &
    "filename will be used for the game's title)"
        Me.IncludeGamesNotFoundCheckBox.UseVisualStyleBackColor = True
        '
        'NewFileRadioButton
        '
        Me.NewFileRadioButton.AutoSize = True
        Me.NewFileRadioButton.Checked = True
        Me.NewFileRadioButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewFileRadioButton.Location = New System.Drawing.Point(3, 55)
        Me.NewFileRadioButton.Name = "NewFileRadioButton"
        Me.NewFileRadioButton.Size = New System.Drawing.Size(173, 20)
        Me.NewFileRadioButton.TabIndex = 3
        Me.NewFileRadioButton.TabStop = True
        Me.NewFileRadioButton.Text = "Generate a new romlist file ?"
        Me.NewFileRadioButton.UseVisualStyleBackColor = True
        '
        'NewRomlistFilePathPanel
        '
        Me.NewRomlistFilePathPanel.Controls.Add(Me.NewRomlistFilePathButton)
        Me.NewRomlistFilePathPanel.Controls.Add(Me.NewRomlistFilePathTextBox)
        Me.NewRomlistFilePathPanel.Location = New System.Drawing.Point(3, 81)
        Me.NewRomlistFilePathPanel.Name = "NewRomlistFilePathPanel"
        Me.NewRomlistFilePathPanel.Size = New System.Drawing.Size(855, 26)
        Me.NewRomlistFilePathPanel.TabIndex = 11
        '
        'NewRomlistFilePathButton
        '
        Me.NewRomlistFilePathButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRomlistFilePathButton.Location = New System.Drawing.Point(399, 1)
        Me.NewRomlistFilePathButton.Margin = New System.Windows.Forms.Padding(0)
        Me.NewRomlistFilePathButton.Name = "NewRomlistFilePathButton"
        Me.NewRomlistFilePathButton.Size = New System.Drawing.Size(25, 20)
        Me.NewRomlistFilePathButton.TabIndex = 10
        Me.NewRomlistFilePathButton.Text = "..."
        Me.NewRomlistFilePathButton.UseVisualStyleBackColor = True
        '
        'NewRomlistFilePathTextBox
        '
        Me.NewRomlistFilePathTextBox.Location = New System.Drawing.Point(3, 3)
        Me.NewRomlistFilePathTextBox.Name = "NewRomlistFilePathTextBox"
        Me.NewRomlistFilePathTextBox.ReadOnly = True
        Me.NewRomlistFilePathTextBox.Size = New System.Drawing.Size(393, 20)
        Me.NewRomlistFilePathTextBox.TabIndex = 9
        '
        'UpdateFileRadioButton
        '
        Me.UpdateFileRadioButton.AutoSize = True
        Me.UpdateFileRadioButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateFileRadioButton.Location = New System.Drawing.Point(3, 113)
        Me.UpdateFileRadioButton.Name = "UpdateFileRadioButton"
        Me.UpdateFileRadioButton.Size = New System.Drawing.Size(188, 20)
        Me.UpdateFileRadioButton.TabIndex = 4
        Me.UpdateFileRadioButton.Text = "Update an existing romlist file ?"
        Me.UpdateFileRadioButton.UseVisualStyleBackColor = True
        '
        'UpdatedRomlistFilePathPanel
        '
        Me.UpdatedRomlistFilePathPanel.Controls.Add(Me.UpdatedRomlistFilePathButton)
        Me.UpdatedRomlistFilePathPanel.Controls.Add(Me.UpdatedRomlistFilePathTextBox)
        Me.UpdatedRomlistFilePathPanel.Location = New System.Drawing.Point(3, 139)
        Me.UpdatedRomlistFilePathPanel.Name = "UpdatedRomlistFilePathPanel"
        Me.UpdatedRomlistFilePathPanel.Size = New System.Drawing.Size(855, 26)
        Me.UpdatedRomlistFilePathPanel.TabIndex = 5
        Me.UpdatedRomlistFilePathPanel.Visible = False
        '
        'UpdatedRomlistFilePathButton
        '
        Me.UpdatedRomlistFilePathButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdatedRomlistFilePathButton.Location = New System.Drawing.Point(399, 1)
        Me.UpdatedRomlistFilePathButton.Margin = New System.Windows.Forms.Padding(0)
        Me.UpdatedRomlistFilePathButton.Name = "UpdatedRomlistFilePathButton"
        Me.UpdatedRomlistFilePathButton.Size = New System.Drawing.Size(25, 20)
        Me.UpdatedRomlistFilePathButton.TabIndex = 10
        Me.UpdatedRomlistFilePathButton.Text = "..."
        Me.UpdatedRomlistFilePathButton.UseVisualStyleBackColor = True
        '
        'UpdatedRomlistFilePathTextBox
        '
        Me.UpdatedRomlistFilePathTextBox.Location = New System.Drawing.Point(3, 3)
        Me.UpdatedRomlistFilePathTextBox.Name = "UpdatedRomlistFilePathTextBox"
        Me.UpdatedRomlistFilePathTextBox.ReadOnly = True
        Me.UpdatedRomlistFilePathTextBox.Size = New System.Drawing.Size(393, 20)
        Me.UpdatedRomlistFilePathTextBox.TabIndex = 9
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(17, 19)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(75, 16)
        Me.DescriptionLabel.TabIndex = 2
        Me.DescriptionLabel.Text = "Do want to :"
        '
        'UpdatedRomlistFilePathOpenFileDialog
        '
        Me.UpdatedRomlistFilePathOpenFileDialog.FileName = "romlist.txt"
        Me.UpdatedRomlistFilePathOpenFileDialog.Title = "Please select the desired romlist file you want to update"
        '
        '_4_RomListChoiceControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ActionPanel)
        Me.Name = "_4_RomListChoiceControl"
        Me.Size = New System.Drawing.Size(878, 727)
        Me.ActionPanel.ResumeLayout(False)
        Me.ActionPanel.PerformLayout()
        Me.ChoiceFlowLayoutPanel.ResumeLayout(False)
        Me.ChoiceFlowLayoutPanel.PerformLayout()
        Me.NewRomlistFilePathPanel.ResumeLayout(False)
        Me.NewRomlistFilePathPanel.PerformLayout()
        Me.UpdatedRomlistFilePathPanel.ResumeLayout(False)
        Me.UpdatedRomlistFilePathPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ActionPanel As Panel
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents UpdateFileRadioButton As RadioButton
    Friend WithEvents NewFileRadioButton As RadioButton
    Friend WithEvents ChoiceFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents UpdatedRomlistFilePathPanel As Panel
    Friend WithEvents UpdatedRomlistFilePathButton As Button
    Friend WithEvents UpdatedRomlistFilePathTextBox As TextBox
    Friend WithEvents UpdatedRomlistFilePathOpenFileDialog As OpenFileDialog
    Friend WithEvents UseFilenameForTitleCheckBox As CheckBox
    Friend WithEvents IncludeGamesNotFoundCheckBox As CheckBox
    Friend WithEvents NewRomlistFilePathPanel As Panel
    Friend WithEvents NewRomlistFilePathButton As Button
    Friend WithEvents NewRomlistFilePathTextBox As TextBox
    Friend WithEvents NewRomlistFilePathFolderBrowserDialog As FolderBrowserDialog
End Class
