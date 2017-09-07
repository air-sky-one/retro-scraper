<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _2_ScreenScraperSystemSelectControl
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
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.ListLabel = New System.Windows.Forms.Label()
        Me.SystemsListComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(20, 20)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(375, 16)
        Me.DescriptionLabel.TabIndex = 2
        Me.DescriptionLabel.Text = "Please select in the list below the associated system in screenscraper.fr"
        '
        'ListLabel
        '
        Me.ListLabel.AutoSize = True
        Me.ListLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListLabel.Location = New System.Drawing.Point(20, 41)
        Me.ListLabel.Name = "ListLabel"
        Me.ListLabel.Size = New System.Drawing.Size(81, 16)
        Me.ListLabel.TabIndex = 3
        Me.ListLabel.Text = "Selected System"
        '
        'SystemsListComboBox
        '
        Me.SystemsListComboBox.FormattingEnabled = True
        Me.SystemsListComboBox.Location = New System.Drawing.Point(107, 40)
        Me.SystemsListComboBox.Name = "SystemsListComboBox"
        Me.SystemsListComboBox.Size = New System.Drawing.Size(288, 21)
        Me.SystemsListComboBox.TabIndex = 4
        '
        '_2_ScreenScraperSystemSelectControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.SystemsListComboBox)
        Me.Controls.Add(Me.ListLabel)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Name = "_2_ScreenScraperSystemSelectControl"
        Me.Size = New System.Drawing.Size(878, 727)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents ListLabel As Label
    Friend WithEvents SystemsListComboBox As ComboBox
End Class
