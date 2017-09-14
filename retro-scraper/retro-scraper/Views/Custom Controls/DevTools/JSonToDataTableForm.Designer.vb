<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JSonToDataTableForm
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
        Me.ResultsDataGridView = New System.Windows.Forms.DataGridView()
        Me.TablesComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ResultsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ResultsDataGridView
        '
        Me.ResultsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResultsDataGridView.Location = New System.Drawing.Point(16, 42)
        Me.ResultsDataGridView.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ResultsDataGridView.Name = "ResultsDataGridView"
        Me.ResultsDataGridView.Size = New System.Drawing.Size(1069, 507)
        Me.ResultsDataGridView.TabIndex = 0
        '
        'TablesComboBox
        '
        Me.TablesComboBox.FormattingEnabled = True
        Me.TablesComboBox.Location = New System.Drawing.Point(97, 12)
        Me.TablesComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TablesComboBox.Name = "TablesComboBox"
        Me.TablesComboBox.Size = New System.Drawing.Size(168, 24)
        Me.TablesComboBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "List of tables"
        '
        'JSonToDataTableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 561)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TablesComboBox)
        Me.Controls.Add(Me.ResultsDataGridView)
        Me.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "JSonToDataTableForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create DataTable from JSon Result "
        CType(Me.ResultsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ResultsDataGridView As DataGridView
    Friend WithEvents TablesComboBox As ComboBox
    Friend WithEvents Label1 As Label
End Class
