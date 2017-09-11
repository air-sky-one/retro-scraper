<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WaitingControl
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
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.MainWaitingProgressBar = New System.Windows.Forms.ProgressBar()
        Me.DetailsTextBox = New System.Windows.Forms.TextBox()
        Me.MainProgressLabel = New System.Windows.Forms.Label()
        Me.DetailsProgressBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'HeaderLabel
        '
        Me.HeaderLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HeaderLabel.Font = New System.Drawing.Font("Ubuntu", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Padding = New System.Windows.Forms.Padding(3)
        Me.HeaderLabel.Size = New System.Drawing.Size(878, 35)
        Me.HeaderLabel.TabIndex = 10
        Me.HeaderLabel.Text = "Please wait for screenscraper.fr"
        Me.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainWaitingProgressBar
        '
        Me.MainWaitingProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MainWaitingProgressBar.Location = New System.Drawing.Point(265, 38)
        Me.MainWaitingProgressBar.Name = "MainWaitingProgressBar"
        Me.MainWaitingProgressBar.Size = New System.Drawing.Size(346, 10)
        Me.MainWaitingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.MainWaitingProgressBar.TabIndex = 12
        '
        'DetailsTextBox
        '
        Me.DetailsTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetailsTextBox.BackColor = System.Drawing.Color.White
        Me.DetailsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetailsTextBox.Enabled = False
        Me.DetailsTextBox.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsTextBox.Location = New System.Drawing.Point(3, 81)
        Me.DetailsTextBox.Multiline = True
        Me.DetailsTextBox.Name = "DetailsTextBox"
        Me.DetailsTextBox.ReadOnly = True
        Me.DetailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DetailsTextBox.Size = New System.Drawing.Size(872, 116)
        Me.DetailsTextBox.TabIndex = 13
        '
        'MainProgressLabel
        '
        Me.MainProgressLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MainProgressLabel.AutoSize = True
        Me.MainProgressLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainProgressLabel.Location = New System.Drawing.Point(262, 51)
        Me.MainProgressLabel.Name = "MainProgressLabel"
        Me.MainProgressLabel.Size = New System.Drawing.Size(95, 16)
        Me.MainProgressLabel.TabIndex = 14
        Me.MainProgressLabel.Text = "MainProgressLabel"
        '
        'DetailsProgressBar
        '
        Me.DetailsProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DetailsProgressBar.Location = New System.Drawing.Point(265, 70)
        Me.DetailsProgressBar.Name = "DetailsProgressBar"
        Me.DetailsProgressBar.Size = New System.Drawing.Size(346, 5)
        Me.DetailsProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.DetailsProgressBar.TabIndex = 15
        '
        'WaitingControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.DetailsProgressBar)
        Me.Controls.Add(Me.MainProgressLabel)
        Me.Controls.Add(Me.DetailsTextBox)
        Me.Controls.Add(Me.MainWaitingProgressBar)
        Me.Controls.Add(Me.HeaderLabel)
        Me.Name = "WaitingControl"
        Me.Size = New System.Drawing.Size(878, 200)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HeaderLabel As Label
    Friend WithEvents MainWaitingProgressBar As ProgressBar
    Friend WithEvents DetailsTextBox As TextBox
    Friend WithEvents MainProgressLabel As Label
    Friend WithEvents DetailsProgressBar As ProgressBar
End Class
