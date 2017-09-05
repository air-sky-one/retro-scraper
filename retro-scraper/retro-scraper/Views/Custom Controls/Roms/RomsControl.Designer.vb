<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RomsControl
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
        Me.MainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.MainTableLayoutPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainTableLayoutPanel
        '
        Me.MainTableLayoutPanel.ColumnCount = 3
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.MainTableLayoutPanel.Controls.Add(Me.Panel1, 0, 0)
        Me.MainTableLayoutPanel.Controls.Add(Me.ButtonNext, 2, 1)
        Me.MainTableLayoutPanel.Controls.Add(Me.ButtonPrevious, 0, 1)
        Me.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainTableLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MainTableLayoutPanel.Name = "MainTableLayoutPanel"
        Me.MainTableLayoutPanel.RowCount = 2
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTableLayoutPanel.Size = New System.Drawing.Size(878, 753)
        Me.MainTableLayoutPanel.TabIndex = 0
        '
        'Panel1
        '
        Me.MainTableLayoutPanel.SetColumnSpan(Me.Panel1, 3)
        Me.Panel1.Controls.Add(Me.HeaderLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(878, 50)
        Me.Panel1.TabIndex = 0
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(831, 53)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(44, 23)
        Me.ButtonNext.TabIndex = 1
        Me.ButtonNext.Text = "Button1"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.Location = New System.Drawing.Point(3, 53)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(44, 23)
        Me.ButtonPrevious.TabIndex = 2
        Me.ButtonPrevious.Text = "Button2"
        Me.ButtonPrevious.UseVisualStyleBackColor = True
        '
        'HeaderLabel
        '
        Me.HeaderLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HeaderLabel.Font = New System.Drawing.Font("Ubuntu", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.Location = New System.Drawing.Point(50, 0)
        Me.HeaderLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(779, 50)
        Me.HeaderLabel.TabIndex = 4
        Me.HeaderLabel.Text = "Welcome to retro-scraper !"
        Me.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RomsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MainTableLayoutPanel)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "RomsControl"
        Me.Size = New System.Drawing.Size(878, 753)
        Me.MainTableLayoutPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ButtonPrevious As Button
    Friend WithEvents HeaderLabel As Label
End Class
