<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeControl))
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IntroLabel = New System.Windows.Forms.Label()
        Me.RetroScraperPictureBox = New System.Windows.Forms.PictureBox()
        Me.ScreenScraperPictureBox = New System.Windows.Forms.PictureBox()
        Me.AttractModePictureBox = New System.Windows.Forms.PictureBox()
        Me.DisclaimerLabel = New System.Windows.Forms.Label()
        CType(Me.RetroScraperPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScreenScraperPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttractModePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeaderLabel
        '
        Me.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderLabel.Font = New System.Drawing.Font("Ubuntu", 45.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(878, 150)
        Me.HeaderLabel.TabIndex = 3
        Me.HeaderLabel.Text = "Welcome to retro-scraper !"
        Me.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 150)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(878, 5)
        Me.Panel1.TabIndex = 4
        '
        'IntroLabel
        '
        Me.IntroLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.IntroLabel.Font = New System.Drawing.Font("Ubuntu", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntroLabel.Location = New System.Drawing.Point(0, 155)
        Me.IntroLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.IntroLabel.Name = "IntroLabel"
        Me.IntroLabel.Padding = New System.Windows.Forms.Padding(50, 20, 50, 20)
        Me.IntroLabel.Size = New System.Drawing.Size(878, 128)
        Me.IntroLabel.TabIndex = 5
        Me.IntroLabel.Text = "retro-scraper is a dedicated tool for scraping systems and games data and media f" &
    "or attract-mode front end from screenscraper.fr amazing database."
        Me.IntroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RetroScraperPictureBox
        '
        Me.RetroScraperPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RetroScraperPictureBox.Image = CType(resources.GetObject("RetroScraperPictureBox.Image"), System.Drawing.Image)
        Me.RetroScraperPictureBox.Location = New System.Drawing.Point(0, 283)
        Me.RetroScraperPictureBox.Name = "RetroScraperPictureBox"
        Me.RetroScraperPictureBox.Size = New System.Drawing.Size(439, 168)
        Me.RetroScraperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RetroScraperPictureBox.TabIndex = 6
        Me.RetroScraperPictureBox.TabStop = False
        '
        'ScreenScraperPictureBox
        '
        Me.ScreenScraperPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ScreenScraperPictureBox.Image = CType(resources.GetObject("ScreenScraperPictureBox.Image"), System.Drawing.Image)
        Me.ScreenScraperPictureBox.Location = New System.Drawing.Point(445, 260)
        Me.ScreenScraperPictureBox.Name = "ScreenScraperPictureBox"
        Me.ScreenScraperPictureBox.Size = New System.Drawing.Size(433, 100)
        Me.ScreenScraperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ScreenScraperPictureBox.TabIndex = 7
        Me.ScreenScraperPictureBox.TabStop = False
        '
        'AttractModePictureBox
        '
        Me.AttractModePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AttractModePictureBox.Image = CType(resources.GetObject("AttractModePictureBox.Image"), System.Drawing.Image)
        Me.AttractModePictureBox.Location = New System.Drawing.Point(445, 366)
        Me.AttractModePictureBox.Name = "AttractModePictureBox"
        Me.AttractModePictureBox.Size = New System.Drawing.Size(433, 62)
        Me.AttractModePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AttractModePictureBox.TabIndex = 10
        Me.AttractModePictureBox.TabStop = False
        '
        'DisclaimerLabel
        '
        Me.DisclaimerLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DisclaimerLabel.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisclaimerLabel.Location = New System.Drawing.Point(0, 530)
        Me.DisclaimerLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.DisclaimerLabel.Name = "DisclaimerLabel"
        Me.DisclaimerLabel.Padding = New System.Windows.Forms.Padding(50, 0, 50, 20)
        Me.DisclaimerLabel.Size = New System.Drawing.Size(878, 120)
        Me.DisclaimerLabel.TabIndex = 11
        Me.DisclaimerLabel.Text = resources.GetString("DisclaimerLabel.Text")
        Me.DisclaimerLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'HomeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.DisclaimerLabel)
        Me.Controls.Add(Me.AttractModePictureBox)
        Me.Controls.Add(Me.ScreenScraperPictureBox)
        Me.Controls.Add(Me.RetroScraperPictureBox)
        Me.Controls.Add(Me.IntroLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.HeaderLabel)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "HomeControl"
        Me.Size = New System.Drawing.Size(878, 650)
        CType(Me.RetroScraperPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScreenScraperPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttractModePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HeaderLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IntroLabel As Label
    Friend WithEvents RetroScraperPictureBox As PictureBox
    Friend WithEvents ScreenScraperPictureBox As PictureBox
    Friend WithEvents AttractModePictureBox As PictureBox
    Friend WithEvents DisclaimerLabel As Label
End Class
