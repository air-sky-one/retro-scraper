<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _12_RomsDownloadControl
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
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.ActionPanel = New System.Windows.Forms.Panel()
        Me.LoadBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.ActionWaitingControl = New retro_scraper.WaitingControl()
        Me.ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(17, 19)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(184, 16)
        Me.DescriptionLabel.TabIndex = 2
        Me.DescriptionLabel.Text = "Data and media are downloaded !"
        '
        'ActionPanel
        '
        Me.ActionPanel.Controls.Add(Me.DescriptionLabel)
        Me.ActionPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ActionPanel.Location = New System.Drawing.Point(0, 0)
        Me.ActionPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ActionPanel.Name = "ActionPanel"
        Me.ActionPanel.Size = New System.Drawing.Size(878, 43)
        Me.ActionPanel.TabIndex = 9
        '
        'LoadBackgroundWorker
        '
        Me.LoadBackgroundWorker.WorkerReportsProgress = True
        Me.LoadBackgroundWorker.WorkerSupportsCancellation = True
        '
        'ActionWaitingControl
        '
        Me.ActionWaitingControl.BackColor = System.Drawing.Color.White
        Me.ActionWaitingControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActionWaitingControl.Location = New System.Drawing.Point(0, 43)
        Me.ActionWaitingControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ActionWaitingControl.Name = "ActionWaitingControl"
        Me.ActionWaitingControl.Size = New System.Drawing.Size(878, 684)
        Me.ActionWaitingControl.TabIndex = 10
        '
        '_12_RomsDownloadControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ActionWaitingControl)
        Me.Controls.Add(Me.ActionPanel)
        Me.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "_12_RomsDownloadControl"
        Me.Size = New System.Drawing.Size(878, 727)
        Me.ActionPanel.ResumeLayout(False)
        Me.ActionPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents ActionPanel As Panel
    Friend WithEvents LoadBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ActionWaitingControl As WaitingControl
End Class
