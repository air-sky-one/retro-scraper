<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _3_RomsPathControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ActionPanel = New System.Windows.Forms.Panel()
        Me.FolderPathButton = New System.Windows.Forms.Button()
        Me.FolderPathTextBox = New System.Windows.Forms.TextBox()
        Me.ResultsLabel = New System.Windows.Forms.Label()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.RomsFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ActionPanel
        '
        Me.ActionPanel.Controls.Add(Me.FolderPathButton)
        Me.ActionPanel.Controls.Add(Me.FolderPathTextBox)
        Me.ActionPanel.Controls.Add(Me.ResultsLabel)
        Me.ActionPanel.Controls.Add(Me.DescriptionLabel)
        Me.ActionPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ActionPanel.Location = New System.Drawing.Point(0, 0)
        Me.ActionPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ActionPanel.Name = "ActionPanel"
        Me.ActionPanel.Size = New System.Drawing.Size(878, 85)
        Me.ActionPanel.TabIndex = 7
        '
        'FolderPathButton
        '
        Me.FolderPathButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FolderPathButton.Location = New System.Drawing.Point(416, 36)
        Me.FolderPathButton.Margin = New System.Windows.Forms.Padding(0)
        Me.FolderPathButton.Name = "FolderPathButton"
        Me.FolderPathButton.Size = New System.Drawing.Size(25, 20)
        Me.FolderPathButton.TabIndex = 8
        Me.FolderPathButton.Text = "..."
        Me.FolderPathButton.UseVisualStyleBackColor = True
        '
        'FolderPathTextBox
        '
        Me.FolderPathTextBox.Location = New System.Drawing.Point(20, 38)
        Me.FolderPathTextBox.Name = "FolderPathTextBox"
        Me.FolderPathTextBox.ReadOnly = True
        Me.FolderPathTextBox.Size = New System.Drawing.Size(393, 20)
        Me.FolderPathTextBox.TabIndex = 7
        '
        'ResultsLabel
        '
        Me.ResultsLabel.AutoSize = True
        Me.ResultsLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultsLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ResultsLabel.Location = New System.Drawing.Point(17, 61)
        Me.ResultsLabel.Name = "ResultsLabel"
        Me.ResultsLabel.Size = New System.Drawing.Size(135, 16)
        Me.ResultsLabel.TabIndex = 6
        Me.ResultsLabel.Text = "X roms where detected in Y"
        Me.ResultsLabel.Visible = False
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(17, 19)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(423, 16)
        Me.DescriptionLabel.TabIndex = 2
        Me.DescriptionLabel.Text = "Please select the folder containing the roms for the desired system and emulator"
        '
        'RomsFolderBrowserDialog
        '
        Me.RomsFolderBrowserDialog.ShowNewFolderButton = False
        '
        '_3_RomsPathControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ActionPanel)
        Me.Name = "_3_RomsPathControl"
        Me.Size = New System.Drawing.Size(878, 727)
        Me.ActionPanel.ResumeLayout(False)
        Me.ActionPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ActionPanel As Panel
    Friend WithEvents ResultsLabel As Label
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents FolderPathButton As Button
    Friend WithEvents FolderPathTextBox As TextBox
    Friend WithEvents RomsFolderBrowserDialog As FolderBrowserDialog
End Class
