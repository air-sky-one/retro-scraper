<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RescrapRomlistFileForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.FolderPathButton = New System.Windows.Forms.Button()
        Me.FolderPathTextBox = New System.Windows.Forms.TextBox()
        Me.ResultsLabel = New System.Windows.Forms.Label()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.RomlistOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'FolderPathButton
        '
        Me.FolderPathButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FolderPathButton.Location = New System.Drawing.Point(411, 26)
        Me.FolderPathButton.Margin = New System.Windows.Forms.Padding(0)
        Me.FolderPathButton.Name = "FolderPathButton"
        Me.FolderPathButton.Size = New System.Drawing.Size(25, 20)
        Me.FolderPathButton.TabIndex = 12
        Me.FolderPathButton.Text = "..."
        Me.FolderPathButton.UseVisualStyleBackColor = True
        '
        'FolderPathTextBox
        '
        Me.FolderPathTextBox.Location = New System.Drawing.Point(15, 28)
        Me.FolderPathTextBox.Name = "FolderPathTextBox"
        Me.FolderPathTextBox.ReadOnly = True
        Me.FolderPathTextBox.Size = New System.Drawing.Size(393, 20)
        Me.FolderPathTextBox.TabIndex = 11
        '
        'ResultsLabel
        '
        Me.ResultsLabel.AutoSize = True
        Me.ResultsLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultsLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ResultsLabel.Location = New System.Drawing.Point(12, 51)
        Me.ResultsLabel.Name = "ResultsLabel"
        Me.ResultsLabel.Size = New System.Drawing.Size(41, 16)
        Me.ResultsLabel.TabIndex = 10
        Me.ResultsLabel.Text = "Results"
        Me.ResultsLabel.Visible = False
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(12, 9)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(207, 16)
        Me.DescriptionLabel.TabIndex = 9
        Me.DescriptionLabel.Text = "Please select the romlist file to rescrap"
        '
        'RomlistOpenFileDialog
        '
        Me.RomlistOpenFileDialog.FileName = "OpenFileDialog1"
        '
        'RescrapRomlistFileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 599)
        Me.Controls.Add(Me.FolderPathButton)
        Me.Controls.Add(Me.FolderPathTextBox)
        Me.Controls.Add(Me.ResultsLabel)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Name = "RescrapRomlistFileForm"
        Me.Text = "RescrapRomlistFileForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FolderPathButton As Button
    Friend WithEvents FolderPathTextBox As TextBox
    Friend WithEvents ResultsLabel As Label
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents RomlistOpenFileDialog As OpenFileDialog
End Class
