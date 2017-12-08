<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.LicenceGroupBox = New System.Windows.Forms.GroupBox()
        Me.LicenceGenerateButton = New System.Windows.Forms.Button()
        Me.LicencePasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LicenceUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.LicencePasswordLabel = New System.Windows.Forms.Label()
        Me.LicenceUsernameLabel = New System.Windows.Forms.Label()
        Me.LicenceGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'LicenceGroupBox
        '
        Me.LicenceGroupBox.Controls.Add(Me.LicenceGenerateButton)
        Me.LicenceGroupBox.Controls.Add(Me.LicencePasswordTextBox)
        Me.LicenceGroupBox.Controls.Add(Me.LicenceUsernameTextBox)
        Me.LicenceGroupBox.Controls.Add(Me.LicencePasswordLabel)
        Me.LicenceGroupBox.Controls.Add(Me.LicenceUsernameLabel)
        Me.LicenceGroupBox.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicenceGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.LicenceGroupBox.Name = "LicenceGroupBox"
        Me.LicenceGroupBox.Size = New System.Drawing.Size(235, 148)
        Me.LicenceGroupBox.TabIndex = 0
        Me.LicenceGroupBox.TabStop = False
        Me.LicenceGroupBox.Text = "Licence"
        '
        'LicenceGenerateButton
        '
        Me.LicenceGenerateButton.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicenceGenerateButton.Location = New System.Drawing.Point(9, 117)
        Me.LicenceGenerateButton.Name = "LicenceGenerateButton"
        Me.LicenceGenerateButton.Size = New System.Drawing.Size(220, 23)
        Me.LicenceGenerateButton.TabIndex = 8
        Me.LicenceGenerateButton.Text = "&Generate Licence File"
        '
        'LicencePasswordTextBox
        '
        Me.LicencePasswordTextBox.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicencePasswordTextBox.Location = New System.Drawing.Point(9, 91)
        Me.LicencePasswordTextBox.Name = "LicencePasswordTextBox"
        Me.LicencePasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.LicencePasswordTextBox.Size = New System.Drawing.Size(220, 20)
        Me.LicencePasswordTextBox.TabIndex = 7
        Me.LicencePasswordTextBox.UseSystemPasswordChar = True
        '
        'LicenceUsernameTextBox
        '
        Me.LicenceUsernameTextBox.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicenceUsernameTextBox.Location = New System.Drawing.Point(9, 42)
        Me.LicenceUsernameTextBox.Name = "LicenceUsernameTextBox"
        Me.LicenceUsernameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.LicenceUsernameTextBox.TabIndex = 5
        '
        'LicencePasswordLabel
        '
        Me.LicencePasswordLabel.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicencePasswordLabel.Location = New System.Drawing.Point(6, 65)
        Me.LicencePasswordLabel.Name = "LicencePasswordLabel"
        Me.LicencePasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.LicencePasswordLabel.TabIndex = 6
        Me.LicencePasswordLabel.Text = "&Password"
        Me.LicencePasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LicenceUsernameLabel
        '
        Me.LicenceUsernameLabel.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicenceUsernameLabel.Location = New System.Drawing.Point(6, 16)
        Me.LicenceUsernameLabel.Name = "LicenceUsernameLabel"
        Me.LicenceUsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.LicenceUsernameLabel.TabIndex = 4
        Me.LicenceUsernameLabel.Text = "&User name"
        Me.LicenceUsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(262, 168)
        Me.Controls.Add(Me.LicenceGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(278, 207)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(278, 207)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Urukai's Retro Scraper Tool"
        Me.LicenceGroupBox.ResumeLayout(False)
        Me.LicenceGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LicenceGroupBox As GroupBox
    Friend WithEvents LicencePasswordTextBox As TextBox
    Friend WithEvents LicenceUsernameTextBox As TextBox
    Friend WithEvents LicencePasswordLabel As Label
    Friend WithEvents LicenceUsernameLabel As Label
    Friend WithEvents LicenceGenerateButton As Button
End Class
