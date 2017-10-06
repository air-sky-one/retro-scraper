<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckAlreadyAvailableMediaForm
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
        Me.EmulatorFileLabel = New System.Windows.Forms.Label()
        Me.RomsFolderButton = New System.Windows.Forms.Button()
        Me.RomsFolderTextBox = New System.Windows.Forms.TextBox()
        Me.RomsFolderLabel = New System.Windows.Forms.Label()
        Me.RomsFolderFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.EmulatorsListComboBox = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CheckButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmulatorFileLabel
        '
        Me.EmulatorFileLabel.AutoSize = True
        Me.EmulatorFileLabel.Location = New System.Drawing.Point(0, 9)
        Me.EmulatorFileLabel.Name = "EmulatorFileLabel"
        Me.EmulatorFileLabel.Size = New System.Drawing.Size(96, 13)
        Me.EmulatorFileLabel.TabIndex = 0
        Me.EmulatorFileLabel.Text = "Select emulator file"
        '
        'RomsFolderButton
        '
        Me.RomsFolderButton.Location = New System.Drawing.Point(396, 29)
        Me.RomsFolderButton.Name = "RomsFolderButton"
        Me.RomsFolderButton.Size = New System.Drawing.Size(23, 23)
        Me.RomsFolderButton.TabIndex = 5
        Me.RomsFolderButton.Text = "..."
        Me.RomsFolderButton.UseVisualStyleBackColor = True
        '
        'RomsFolderTextBox
        '
        Me.RomsFolderTextBox.Location = New System.Drawing.Point(102, 32)
        Me.RomsFolderTextBox.Name = "RomsFolderTextBox"
        Me.RomsFolderTextBox.ReadOnly = True
        Me.RomsFolderTextBox.Size = New System.Drawing.Size(288, 20)
        Me.RomsFolderTextBox.TabIndex = 4
        '
        'RomsFolderLabel
        '
        Me.RomsFolderLabel.AutoSize = True
        Me.RomsFolderLabel.Location = New System.Drawing.Point(0, 35)
        Me.RomsFolderLabel.Name = "RomsFolderLabel"
        Me.RomsFolderLabel.Size = New System.Drawing.Size(91, 13)
        Me.RomsFolderLabel.TabIndex = 3
        Me.RomsFolderLabel.Text = "Select roms folder"
        '
        'EmulatorsListComboBox
        '
        Me.EmulatorsListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EmulatorsListComboBox.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmulatorsListComboBox.FormattingEnabled = True
        Me.EmulatorsListComboBox.Location = New System.Drawing.Point(102, 2)
        Me.EmulatorsListComboBox.Name = "EmulatorsListComboBox"
        Me.EmulatorsListComboBox.Size = New System.Drawing.Size(288, 24)
        Me.EmulatorsListComboBox.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(760, 491)
        Me.DataGridView1.TabIndex = 7
        '
        'CheckButton
        '
        Me.CheckButton.Location = New System.Drawing.Point(435, 29)
        Me.CheckButton.Name = "CheckButton"
        Me.CheckButton.Size = New System.Drawing.Size(75, 23)
        Me.CheckButton.TabIndex = 8
        Me.CheckButton.Text = "Check"
        Me.CheckButton.UseVisualStyleBackColor = True
        '
        'CheckAlreadyAvailableMediaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.CheckButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.EmulatorsListComboBox)
        Me.Controls.Add(Me.RomsFolderButton)
        Me.Controls.Add(Me.RomsFolderTextBox)
        Me.Controls.Add(Me.RomsFolderLabel)
        Me.Controls.Add(Me.EmulatorFileLabel)
        Me.Name = "CheckAlreadyAvailableMediaForm"
        Me.Text = "Form to check already available media for a specific system"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmulatorFileLabel As Label
    Friend WithEvents RomsFolderButton As Button
    Friend WithEvents RomsFolderTextBox As TextBox
    Friend WithEvents RomsFolderLabel As Label
    Friend WithEvents RomsFolderFolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents EmulatorsListComboBox As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CheckButton As Button
End Class
