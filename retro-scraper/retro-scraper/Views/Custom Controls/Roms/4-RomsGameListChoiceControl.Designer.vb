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
        Me.NewFileRadioButton = New System.Windows.Forms.RadioButton()
        Me.UpdateFileRadioButton = New System.Windows.Forms.RadioButton()
        Me.FolderPathPanel = New System.Windows.Forms.Panel()
        Me.FolderPathButton = New System.Windows.Forms.Button()
        Me.FolderPathTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.RomlistFileBrowserDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ActionPanel.SuspendLayout()
        Me.ChoiceFlowLayoutPanel.SuspendLayout()
        Me.FolderPathPanel.SuspendLayout()
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
        Me.ActionPanel.Size = New System.Drawing.Size(878, 128)
        Me.ActionPanel.TabIndex = 8
        '
        'ChoiceFlowLayoutPanel
        '
        Me.ChoiceFlowLayoutPanel.AutoSize = True
        Me.ChoiceFlowLayoutPanel.Controls.Add(Me.NewFileRadioButton)
        Me.ChoiceFlowLayoutPanel.Controls.Add(Me.UpdateFileRadioButton)
        Me.ChoiceFlowLayoutPanel.Controls.Add(Me.FolderPathPanel)
        Me.ChoiceFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.ChoiceFlowLayoutPanel.Location = New System.Drawing.Point(20, 38)
        Me.ChoiceFlowLayoutPanel.Name = "ChoiceFlowLayoutPanel"
        Me.ChoiceFlowLayoutPanel.Size = New System.Drawing.Size(861, 85)
        Me.ChoiceFlowLayoutPanel.TabIndex = 5
        '
        'NewFileRadioButton
        '
        Me.NewFileRadioButton.AutoSize = True
        Me.NewFileRadioButton.Checked = True
        Me.NewFileRadioButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewFileRadioButton.Location = New System.Drawing.Point(3, 3)
        Me.NewFileRadioButton.Name = "NewFileRadioButton"
        Me.NewFileRadioButton.Size = New System.Drawing.Size(173, 20)
        Me.NewFileRadioButton.TabIndex = 3
        Me.NewFileRadioButton.TabStop = True
        Me.NewFileRadioButton.Text = "Generate a new romlist file ?"
        Me.NewFileRadioButton.UseVisualStyleBackColor = True
        '
        'UpdateFileRadioButton
        '
        Me.UpdateFileRadioButton.AutoSize = True
        Me.UpdateFileRadioButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateFileRadioButton.Location = New System.Drawing.Point(3, 29)
        Me.UpdateFileRadioButton.Name = "UpdateFileRadioButton"
        Me.UpdateFileRadioButton.Size = New System.Drawing.Size(188, 20)
        Me.UpdateFileRadioButton.TabIndex = 4
        Me.UpdateFileRadioButton.Text = "Update an existing romlist file ?"
        Me.UpdateFileRadioButton.UseVisualStyleBackColor = True
        '
        'FolderPathPanel
        '
        Me.FolderPathPanel.Controls.Add(Me.FolderPathButton)
        Me.FolderPathPanel.Controls.Add(Me.FolderPathTextBox)
        Me.FolderPathPanel.Location = New System.Drawing.Point(3, 55)
        Me.FolderPathPanel.Name = "FolderPathPanel"
        Me.FolderPathPanel.Size = New System.Drawing.Size(855, 26)
        Me.FolderPathPanel.TabIndex = 5
        Me.FolderPathPanel.Visible = False
        '
        'FolderPathButton
        '
        Me.FolderPathButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FolderPathButton.Location = New System.Drawing.Point(399, 1)
        Me.FolderPathButton.Margin = New System.Windows.Forms.Padding(0)
        Me.FolderPathButton.Name = "FolderPathButton"
        Me.FolderPathButton.Size = New System.Drawing.Size(25, 20)
        Me.FolderPathButton.TabIndex = 10
        Me.FolderPathButton.Text = "..."
        Me.FolderPathButton.UseVisualStyleBackColor = True
        '
        'FolderPathTextBox
        '
        Me.FolderPathTextBox.Location = New System.Drawing.Point(3, 3)
        Me.FolderPathTextBox.Name = "FolderPathTextBox"
        Me.FolderPathTextBox.ReadOnly = True
        Me.FolderPathTextBox.Size = New System.Drawing.Size(393, 20)
        Me.FolderPathTextBox.TabIndex = 9
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
        'RomlistFileBrowserDialog
        '
        Me.RomlistFileBrowserDialog.FileName = "romlist.txt"
        Me.RomlistFileBrowserDialog.Title = "Please select the desired romlist file you want to update"
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
        Me.FolderPathPanel.ResumeLayout(False)
        Me.FolderPathPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ActionPanel As Panel
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents UpdateFileRadioButton As RadioButton
    Friend WithEvents NewFileRadioButton As RadioButton
    Friend WithEvents ChoiceFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents FolderPathPanel As Panel
    Friend WithEvents FolderPathButton As Button
    Friend WithEvents FolderPathTextBox As TextBox
    Friend WithEvents RomlistFileBrowserDialog As OpenFileDialog
End Class
