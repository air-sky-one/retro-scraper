<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _1_RomsScreenScraperSystemSelectControl
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
        Me.LoadBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.ActionPanel = New System.Windows.Forms.Panel()
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
        Me.DescriptionLabel.Size = New System.Drawing.Size(375, 16)
        Me.DescriptionLabel.TabIndex = 2
        Me.DescriptionLabel.Text = "Please select in the list below the associated system in screenscraper.fr"
        '
        'ListLabel
        '
        Me.ListLabel.AutoSize = True
        Me.ListLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListLabel.Location = New System.Drawing.Point(17, 42)
        Me.ListLabel.Name = "ListLabel"
        Me.ListLabel.Size = New System.Drawing.Size(81, 16)
        Me.ListLabel.TabIndex = 3
        Me.ListLabel.Text = "Selected System"
        '
        'SystemsListComboBox
        '
        Me.SystemsListComboBox.BackColor = System.Drawing.Color.White
        Me.SystemsListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SystemsListComboBox.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemsListComboBox.FormattingEnabled = True
        Me.SystemsListComboBox.Location = New System.Drawing.Point(104, 39)
        Me.SystemsListComboBox.Name = "SystemsListComboBox"
        Me.SystemsListComboBox.Size = New System.Drawing.Size(288, 24)
        Me.SystemsListComboBox.TabIndex = 4
        '
        'LoadBackgroundWorker
        '
        Me.LoadBackgroundWorker.WorkerReportsProgress = True
        Me.LoadBackgroundWorker.WorkerSupportsCancellation = True
        '
        'ActionPanel
        '
        Me.ActionPanel.Controls.Add(Me.SystemsListComboBox)
        Me.ActionPanel.Controls.Add(Me.DescriptionLabel)
        Me.ActionPanel.Controls.Add(Me.ListLabel)
        Me.ActionPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ActionPanel.Location = New System.Drawing.Point(0, 0)
        Me.ActionPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ActionPanel.Name = "ActionPanel"
        Me.ActionPanel.Size = New System.Drawing.Size(878, 82)
        Me.ActionPanel.TabIndex = 5
        '
        'ActionWaitingControl
        '
        Me.ActionWaitingControl.BackColor = System.Drawing.Color.White
        Me.ActionWaitingControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActionWaitingControl.Location = New System.Drawing.Point(0, 82)
        Me.ActionWaitingControl.Name = "ActionWaitingControl"
        Me.ActionWaitingControl.Size = New System.Drawing.Size(878, 645)
        Me.ActionWaitingControl.TabIndex = 6
        '
        '_1_RomsScreenScraperSystemSelectControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ActionWaitingControl)
        Me.Controls.Add(Me.ActionPanel)
        Me.Name = "_1_RomsScreenScraperSystemSelectControl"
        Me.Size = New System.Drawing.Size(878, 727)
        Me.ActionPanel.ResumeLayout(False)
        Me.ActionPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents ListLabel As Label
    Friend WithEvents SystemsListComboBox As ComboBox
    Friend WithEvents LoadBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ActionPanel As Panel
    Friend WithEvents ActionWaitingControl As WaitingControl
End Class
