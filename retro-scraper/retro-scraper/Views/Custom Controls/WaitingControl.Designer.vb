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
        Me._waitingLabel = New System.Windows.Forms.Label()
        Me._waitingProgressBar = New System.Windows.Forms.ProgressBar()
        Me._detailsTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        '_waitingLabel
        '
        Me._waitingLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._waitingLabel.Font = New System.Drawing.Font("Ubuntu", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._waitingLabel.Location = New System.Drawing.Point(0, 0)
        Me._waitingLabel.Margin = New System.Windows.Forms.Padding(0)
        Me._waitingLabel.Name = "_waitingLabel"
        Me._waitingLabel.Padding = New System.Windows.Forms.Padding(3)
        Me._waitingLabel.Size = New System.Drawing.Size(878, 35)
        Me._waitingLabel.TabIndex = 10
        Me._waitingLabel.Text = "Please wait for screenscraper.fr"
        Me._waitingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_waitingProgressBar
        '
        Me._waitingProgressBar.Location = New System.Drawing.Point(265, 38)
        Me._waitingProgressBar.Name = "_waitingProgressBar"
        Me._waitingProgressBar.Size = New System.Drawing.Size(346, 10)
        Me._waitingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me._waitingProgressBar.TabIndex = 12
        '
        '_detailsTextBox
        '
        Me._detailsTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._detailsTextBox.BackColor = System.Drawing.Color.White
        Me._detailsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._detailsTextBox.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._detailsTextBox.Location = New System.Drawing.Point(3, 54)
        Me._detailsTextBox.Multiline = True
        Me._detailsTextBox.Name = "_detailsTextBox"
        Me._detailsTextBox.ReadOnly = True
        Me._detailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me._detailsTextBox.Size = New System.Drawing.Size(872, 64)
        Me._detailsTextBox.TabIndex = 13
        Me._detailsTextBox.Visible = False
        '
        'WaitingControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me._detailsTextBox)
        Me.Controls.Add(Me._waitingProgressBar)
        Me.Controls.Add(Me._waitingLabel)
        Me.Name = "WaitingControl"
        Me.Size = New System.Drawing.Size(878, 121)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _waitingLabel As Label
    Friend WithEvents _waitingProgressBar As ProgressBar
    Friend WithEvents _detailsTextBox As TextBox
End Class
