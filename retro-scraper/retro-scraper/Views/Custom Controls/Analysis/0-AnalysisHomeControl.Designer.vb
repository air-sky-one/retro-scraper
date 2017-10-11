<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _0_AnalysisHomeControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_0_AnalysisHomeControl))
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(20, 20)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(848, 80)
        Me.DescriptionLabel.TabIndex = 2
        Me.DescriptionLabel.Text = resources.GetString("DescriptionLabel.Text")
        '
        '_0_AnalysisHomeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Name = "_0_AnalysisHomeControl"
        Me.Size = New System.Drawing.Size(878, 727)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DescriptionLabel As Label
End Class
