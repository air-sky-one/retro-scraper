<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _2_EmulatorSelectControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_2_EmulatorSelectControl))
        Me.ActionPanel = New System.Windows.Forms.Panel()
        Me.ArtworksLabel = New System.Windows.Forms.Label()
        Me.RomsExtensionsLabel = New System.Windows.Forms.Label()
        Me.EmulatorsListComboBox = New System.Windows.Forms.ComboBox()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.ListLabel = New System.Windows.Forms.Label()
        Me.ActionWaitingControl = New retro_scraper.WaitingControl()
        Me.LoadBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.ActionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ActionPanel
        '
        Me.ActionPanel.Controls.Add(Me.ArtworksLabel)
        Me.ActionPanel.Controls.Add(Me.RomsExtensionsLabel)
        Me.ActionPanel.Controls.Add(Me.EmulatorsListComboBox)
        Me.ActionPanel.Controls.Add(Me.DescriptionLabel)
        Me.ActionPanel.Controls.Add(Me.ListLabel)
        Me.ActionPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ActionPanel.Location = New System.Drawing.Point(0, 0)
        Me.ActionPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ActionPanel.Name = "ActionPanel"
        Me.ActionPanel.Size = New System.Drawing.Size(878, 426)
        Me.ActionPanel.TabIndex = 6
        '
        'ArtworksLabel
        '
        Me.ArtworksLabel.AutoSize = True
        Me.ArtworksLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArtworksLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ArtworksLabel.Location = New System.Drawing.Point(17, 136)
        Me.ArtworksLabel.Name = "ArtworksLabel"
        Me.ArtworksLabel.Size = New System.Drawing.Size(56, 16)
        Me.ArtworksLabel.TabIndex = 7
        Me.ArtworksLabel.Text = "Artworks :"
        Me.ArtworksLabel.Visible = False
        '
        'RomsExtensionsLabel
        '
        Me.RomsExtensionsLabel.AutoSize = True
        Me.RomsExtensionsLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RomsExtensionsLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RomsExtensionsLabel.Location = New System.Drawing.Point(17, 120)
        Me.RomsExtensionsLabel.Name = "RomsExtensionsLabel"
        Me.RomsExtensionsLabel.Size = New System.Drawing.Size(151, 16)
        Me.RomsExtensionsLabel.TabIndex = 6
        Me.RomsExtensionsLabel.Text = "Accepted roms extension files :"
        Me.RomsExtensionsLabel.Visible = False
        '
        'EmulatorsListComboBox
        '
        Me.EmulatorsListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EmulatorsListComboBox.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmulatorsListComboBox.FormattingEnabled = True
        Me.EmulatorsListComboBox.Location = New System.Drawing.Point(116, 93)
        Me.EmulatorsListComboBox.Name = "EmulatorsListComboBox"
        Me.EmulatorsListComboBox.Size = New System.Drawing.Size(288, 24)
        Me.EmulatorsListComboBox.TabIndex = 4
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(17, 19)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(841, 71)
        Me.DescriptionLabel.TabIndex = 2
        Me.DescriptionLabel.Text = resources.GetString("DescriptionLabel.Text")
        '
        'ListLabel
        '
        Me.ListLabel.AutoSize = True
        Me.ListLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListLabel.Location = New System.Drawing.Point(17, 96)
        Me.ListLabel.Name = "ListLabel"
        Me.ListLabel.Size = New System.Drawing.Size(93, 16)
        Me.ListLabel.TabIndex = 3
        Me.ListLabel.Text = "Selected Emulator"
        '
        'ActionWaitingControl
        '
        Me.ActionWaitingControl.BackColor = System.Drawing.Color.White
        Me.ActionWaitingControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActionWaitingControl.Location = New System.Drawing.Point(0, 426)
        Me.ActionWaitingControl.Name = "ActionWaitingControl"
        Me.ActionWaitingControl.Size = New System.Drawing.Size(878, 301)
        Me.ActionWaitingControl.TabIndex = 7
        '
        'LoadBackgroundWorker
        '
        Me.LoadBackgroundWorker.WorkerReportsProgress = True
        Me.LoadBackgroundWorker.WorkerSupportsCancellation = True
        '
        '_2_EmulatorSelectControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ActionWaitingControl)
        Me.Controls.Add(Me.ActionPanel)
        Me.Name = "_2_EmulatorSelectControl"
        Me.Size = New System.Drawing.Size(878, 727)
        Me.ActionPanel.ResumeLayout(False)
        Me.ActionPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ActionPanel As Panel
    Friend WithEvents EmulatorsListComboBox As ComboBox
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents ListLabel As Label
    Friend WithEvents ActionWaitingControl As WaitingControl
    Friend WithEvents LoadBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents RomsExtensionsLabel As Label
    Friend WithEvents ArtworksLabel As Label
End Class
