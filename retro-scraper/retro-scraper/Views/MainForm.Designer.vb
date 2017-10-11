<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.HeaderPictureBox = New System.Windows.Forms.PictureBox()
        Me.MainFormTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.MainMenuFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.MainButtonHome = New System.Windows.Forms.Button()
        Me.MainButtonRoms = New System.Windows.Forms.Button()
        Me.MainButtonSystems = New System.Windows.Forms.Button()
        Me.MainButtonGameLists = New System.Windows.Forms.Button()
        Me.MainButtonSettings = New System.Windows.Forms.Button()
        Me.MainButtonDevTools = New System.Windows.Forms.Button()
        Me.MainHomeControl = New retro_scraper.HomeControl()
        Me.MainButtonAnalysis = New System.Windows.Forms.Button()
        Me.HeaderPanel.SuspendLayout()
        CType(Me.HeaderPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainFormTableLayoutPanel.SuspendLayout()
        Me.MainMenuFlowLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.DimGray
        Me.HeaderPanel.Controls.Add(Me.HeaderPictureBox)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(1008, 144)
        Me.HeaderPanel.TabIndex = 1
        '
        'HeaderPictureBox
        '
        Me.HeaderPictureBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HeaderPictureBox.Image = CType(resources.GetObject("HeaderPictureBox.Image"), System.Drawing.Image)
        Me.HeaderPictureBox.Location = New System.Drawing.Point(56, 3)
        Me.HeaderPictureBox.Name = "HeaderPictureBox"
        Me.HeaderPictureBox.Size = New System.Drawing.Size(391, 138)
        Me.HeaderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HeaderPictureBox.TabIndex = 0
        Me.HeaderPictureBox.TabStop = False
        '
        'MainFormTableLayoutPanel
        '
        Me.MainFormTableLayoutPanel.ColumnCount = 2
        Me.MainFormTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.MainFormTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainFormTableLayoutPanel.Controls.Add(Me.MainMenuFlowLayoutPanel, 0, 0)
        Me.MainFormTableLayoutPanel.Controls.Add(Me.MainHomeControl, 1, 0)
        Me.MainFormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainFormTableLayoutPanel.Location = New System.Drawing.Point(0, 144)
        Me.MainFormTableLayoutPanel.Name = "MainFormTableLayoutPanel"
        Me.MainFormTableLayoutPanel.RowCount = 1
        Me.MainFormTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainFormTableLayoutPanel.Size = New System.Drawing.Size(1008, 753)
        Me.MainFormTableLayoutPanel.TabIndex = 2
        '
        'MainMenuFlowLayoutPanel
        '
        Me.MainMenuFlowLayoutPanel.BackColor = System.Drawing.Color.DimGray
        Me.MainMenuFlowLayoutPanel.Controls.Add(Me.MainButtonHome)
        Me.MainMenuFlowLayoutPanel.Controls.Add(Me.MainButtonAnalysis)
        Me.MainMenuFlowLayoutPanel.Controls.Add(Me.MainButtonRoms)
        Me.MainMenuFlowLayoutPanel.Controls.Add(Me.MainButtonSystems)
        Me.MainMenuFlowLayoutPanel.Controls.Add(Me.MainButtonGameLists)
        Me.MainMenuFlowLayoutPanel.Controls.Add(Me.MainButtonSettings)
        Me.MainMenuFlowLayoutPanel.Controls.Add(Me.MainButtonDevTools)
        Me.MainMenuFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainMenuFlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuFlowLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MainMenuFlowLayoutPanel.Name = "MainMenuFlowLayoutPanel"
        Me.MainMenuFlowLayoutPanel.Size = New System.Drawing.Size(130, 753)
        Me.MainMenuFlowLayoutPanel.TabIndex = 1
        '
        'MainButtonHome
        '
        Me.MainButtonHome.BackColor = System.Drawing.Color.White
        Me.MainButtonHome.FlatAppearance.BorderSize = 0
        Me.MainButtonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.MainButtonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.MainButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainButtonHome.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainButtonHome.Location = New System.Drawing.Point(0, 0)
        Me.MainButtonHome.Margin = New System.Windows.Forms.Padding(0)
        Me.MainButtonHome.Name = "MainButtonHome"
        Me.MainButtonHome.Size = New System.Drawing.Size(130, 36)
        Me.MainButtonHome.TabIndex = 0
        Me.MainButtonHome.Text = "   &Home"
        Me.MainButtonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainButtonHome.UseVisualStyleBackColor = False
        '
        'MainButtonRoms
        '
        Me.MainButtonRoms.BackColor = System.Drawing.Color.DimGray
        Me.MainButtonRoms.FlatAppearance.BorderSize = 0
        Me.MainButtonRoms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.MainButtonRoms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.MainButtonRoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainButtonRoms.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainButtonRoms.Location = New System.Drawing.Point(0, 72)
        Me.MainButtonRoms.Margin = New System.Windows.Forms.Padding(0)
        Me.MainButtonRoms.Name = "MainButtonRoms"
        Me.MainButtonRoms.Size = New System.Drawing.Size(130, 36)
        Me.MainButtonRoms.TabIndex = 1
        Me.MainButtonRoms.Text = "   &Roms"
        Me.MainButtonRoms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainButtonRoms.UseVisualStyleBackColor = False
        '
        'MainButtonSystems
        '
        Me.MainButtonSystems.BackColor = System.Drawing.Color.DimGray
        Me.MainButtonSystems.FlatAppearance.BorderSize = 0
        Me.MainButtonSystems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.MainButtonSystems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.MainButtonSystems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainButtonSystems.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainButtonSystems.Location = New System.Drawing.Point(0, 108)
        Me.MainButtonSystems.Margin = New System.Windows.Forms.Padding(0)
        Me.MainButtonSystems.Name = "MainButtonSystems"
        Me.MainButtonSystems.Size = New System.Drawing.Size(130, 36)
        Me.MainButtonSystems.TabIndex = 2
        Me.MainButtonSystems.Text = "   &Systems"
        Me.MainButtonSystems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainButtonSystems.UseVisualStyleBackColor = False
        '
        'MainButtonGameLists
        '
        Me.MainButtonGameLists.BackColor = System.Drawing.Color.DimGray
        Me.MainButtonGameLists.FlatAppearance.BorderSize = 0
        Me.MainButtonGameLists.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.MainButtonGameLists.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.MainButtonGameLists.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainButtonGameLists.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainButtonGameLists.Location = New System.Drawing.Point(0, 144)
        Me.MainButtonGameLists.Margin = New System.Windows.Forms.Padding(0)
        Me.MainButtonGameLists.Name = "MainButtonGameLists"
        Me.MainButtonGameLists.Size = New System.Drawing.Size(130, 36)
        Me.MainButtonGameLists.TabIndex = 3
        Me.MainButtonGameLists.Text = "   &GameLists"
        Me.MainButtonGameLists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainButtonGameLists.UseVisualStyleBackColor = False
        '
        'MainButtonSettings
        '
        Me.MainButtonSettings.BackColor = System.Drawing.Color.DimGray
        Me.MainButtonSettings.FlatAppearance.BorderSize = 0
        Me.MainButtonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.MainButtonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.MainButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainButtonSettings.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainButtonSettings.Location = New System.Drawing.Point(0, 180)
        Me.MainButtonSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.MainButtonSettings.Name = "MainButtonSettings"
        Me.MainButtonSettings.Size = New System.Drawing.Size(130, 36)
        Me.MainButtonSettings.TabIndex = 4
        Me.MainButtonSettings.Text = "   &Settings"
        Me.MainButtonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainButtonSettings.UseVisualStyleBackColor = False
        '
        'MainButtonDevTools
        '
        Me.MainButtonDevTools.BackColor = System.Drawing.Color.DimGray
        Me.MainButtonDevTools.FlatAppearance.BorderSize = 0
        Me.MainButtonDevTools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.MainButtonDevTools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.MainButtonDevTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainButtonDevTools.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainButtonDevTools.Location = New System.Drawing.Point(0, 216)
        Me.MainButtonDevTools.Margin = New System.Windows.Forms.Padding(0)
        Me.MainButtonDevTools.Name = "MainButtonDevTools"
        Me.MainButtonDevTools.Size = New System.Drawing.Size(130, 36)
        Me.MainButtonDevTools.TabIndex = 5
        Me.MainButtonDevTools.Text = "   &Dev Tools"
        Me.MainButtonDevTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainButtonDevTools.UseVisualStyleBackColor = False
        Me.MainButtonDevTools.Visible = False
        '
        'MainHomeControl
        '
        Me.MainHomeControl.BackColor = System.Drawing.Color.White
        Me.MainHomeControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainHomeControl.Location = New System.Drawing.Point(130, 0)
        Me.MainHomeControl.Margin = New System.Windows.Forms.Padding(0)
        Me.MainHomeControl.Name = "MainHomeControl"
        Me.MainHomeControl.Size = New System.Drawing.Size(878, 753)
        Me.MainHomeControl.TabIndex = 2
        '
        'MainButtonAnalysis
        '
        Me.MainButtonAnalysis.BackColor = System.Drawing.Color.DimGray
        Me.MainButtonAnalysis.FlatAppearance.BorderSize = 0
        Me.MainButtonAnalysis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.MainButtonAnalysis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.MainButtonAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainButtonAnalysis.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainButtonAnalysis.Location = New System.Drawing.Point(0, 36)
        Me.MainButtonAnalysis.Margin = New System.Windows.Forms.Padding(0)
        Me.MainButtonAnalysis.Name = "MainButtonAnalysis"
        Me.MainButtonAnalysis.Size = New System.Drawing.Size(130, 36)
        Me.MainButtonAnalysis.TabIndex = 6
        Me.MainButtonAnalysis.Text = "   &Local Analysis"
        Me.MainButtonAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainButtonAnalysis.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 897)
        Me.Controls.Add(Me.MainFormTableLayoutPanel)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(1024, 936)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Urukai's Retro Scraper"
        Me.HeaderPanel.ResumeLayout(False)
        CType(Me.HeaderPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainFormTableLayoutPanel.ResumeLayout(False)
        Me.MainMenuFlowLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents HeaderPictureBox As PictureBox
    Friend WithEvents MainFormTableLayoutPanel As TableLayoutPanel
    Friend WithEvents MainMenuFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents MainButtonRoms As Button
    Friend WithEvents MainButtonSystems As Button
    Friend WithEvents MainButtonGameLists As Button
    Friend WithEvents MainButtonSettings As Button
    Friend WithEvents MainButtonHome As Button
    Friend WithEvents MainHomeControl As HomeControl
    Friend WithEvents MainButtonDevTools As Button
    Friend WithEvents MainButtonAnalysis As Button
End Class
