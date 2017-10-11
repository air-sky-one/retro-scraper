<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _3_AnalysisLoadingProcessControl
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
        Me.ActionWaitingControl = New retro_scraper.WaitingControl()
        Me.LoadBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'ActionWaitingControl
        '
        Me.ActionWaitingControl.BackColor = System.Drawing.Color.White
        Me.ActionWaitingControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActionWaitingControl.Location = New System.Drawing.Point(0, 0)
        Me.ActionWaitingControl.Name = "ActionWaitingControl"
        Me.ActionWaitingControl.Size = New System.Drawing.Size(878, 727)
        Me.ActionWaitingControl.TabIndex = 10
        '
        'LoadBackgroundWorker
        '
        Me.LoadBackgroundWorker.WorkerReportsProgress = True
        Me.LoadBackgroundWorker.WorkerSupportsCancellation = True
        '
        '_3_AnalysisLoadingProcessControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ActionWaitingControl)
        Me.Name = "_3_AnalysisLoadingProcessControl"
        Me.Size = New System.Drawing.Size(878, 727)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ActionWaitingControl As WaitingControl
    Friend WithEvents LoadBackgroundWorker As System.ComponentModel.BackgroundWorker
End Class
