<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _4_AnalysisResultControl
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
        Me.ContentDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.ContentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContentDataGridView
        '
        Me.ContentDataGridView.AllowUserToAddRows = False
        Me.ContentDataGridView.AllowUserToDeleteRows = False
        Me.ContentDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContentDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ContentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContentDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ContentDataGridView.Name = "ContentDataGridView"
        Me.ContentDataGridView.ReadOnly = True
        Me.ContentDataGridView.Size = New System.Drawing.Size(872, 681)
        Me.ContentDataGridView.TabIndex = 0
        '
        '_4_AnalysisResultControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ContentDataGridView)
        Me.Name = "_4_AnalysisResultControl"
        Me.Size = New System.Drawing.Size(878, 727)
        CType(Me.ContentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ContentDataGridView As DataGridView
End Class
