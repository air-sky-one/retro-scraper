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
        Me.SeparatorPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.IntroLabel = New System.Windows.Forms.Label()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.PicturePanel = New System.Windows.Forms.Panel()
        Me.RetroScraperPictureBox = New System.Windows.Forms.PictureBox()
        Me.ScreenScraperPictureBox = New System.Windows.Forms.PictureBox()
        Me.AttractModePictureBox = New System.Windows.Forms.PictureBox()
        Me.DisclaimerHeaderLabel = New System.Windows.Forms.Label()
        Me.DisclaimerDetailsLabel = New System.Windows.Forms.Label()
        Me.DisclaimerCopyrightLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PicturePanel.SuspendLayout()
        CType(Me.RetroScraperPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScreenScraperPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttractModePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SeparatorPanel
        '
        Me.SeparatorPanel.BackColor = System.Drawing.Color.DimGray
        Me.SeparatorPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SeparatorPanel.Location = New System.Drawing.Point(0, 120)
        Me.SeparatorPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.SeparatorPanel.Name = "SeparatorPanel"
        Me.SeparatorPanel.Size = New System.Drawing.Size(878, 5)
        Me.SeparatorPanel.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.IntroLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.HeaderLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SeparatorPanel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PicturePanel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DisclaimerHeaderLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.DisclaimerDetailsLabel, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.DisclaimerCopyrightLabel, 0, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(878, 700)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'IntroLabel
        '
        Me.IntroLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IntroLabel.Font = New System.Drawing.Font("Ubuntu", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntroLabel.Location = New System.Drawing.Point(0, 125)
        Me.IntroLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.IntroLabel.Name = "IntroLabel"
        Me.IntroLabel.Padding = New System.Windows.Forms.Padding(50, 20, 50, 20)
        Me.IntroLabel.Size = New System.Drawing.Size(878, 130)
        Me.IntroLabel.TabIndex = 8
        Me.IntroLabel.Text = "retro-scraper is a dedicated tool for scraping systems and games data and media f" &
    "or attract-mode front end from screenscraper.fr amazing database."
        Me.IntroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HeaderLabel
        '
        Me.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderLabel.Font = New System.Drawing.Font("Ubuntu", 45.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(878, 120)
        Me.HeaderLabel.TabIndex = 5
        Me.HeaderLabel.Text = "Welcome to retro-scraper !"
        Me.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicturePanel
        '
        Me.PicturePanel.Controls.Add(Me.RetroScraperPictureBox)
        Me.PicturePanel.Controls.Add(Me.ScreenScraperPictureBox)
        Me.PicturePanel.Controls.Add(Me.AttractModePictureBox)
        Me.PicturePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicturePanel.Location = New System.Drawing.Point(0, 255)
        Me.PicturePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.PicturePanel.Name = "PicturePanel"
        Me.PicturePanel.Size = New System.Drawing.Size(878, 200)
        Me.PicturePanel.TabIndex = 7
        '
        'RetroScraperPictureBox
        '
        Me.RetroScraperPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RetroScraperPictureBox.Image = CType(resources.GetObject("RetroScraperPictureBox.Image"), System.Drawing.Image)
        Me.RetroScraperPictureBox.Location = New System.Drawing.Point(0, 20)
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
        Me.ScreenScraperPictureBox.Location = New System.Drawing.Point(445, -2)
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
        Me.AttractModePictureBox.Location = New System.Drawing.Point(445, 104)
        Me.AttractModePictureBox.Name = "AttractModePictureBox"
        Me.AttractModePictureBox.Size = New System.Drawing.Size(433, 62)
        Me.AttractModePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AttractModePictureBox.TabIndex = 10
        Me.AttractModePictureBox.TabStop = False
        '
        'DisclaimerHeaderLabel
        '
        Me.DisclaimerHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DisclaimerHeaderLabel.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisclaimerHeaderLabel.Location = New System.Drawing.Point(3, 610)
        Me.DisclaimerHeaderLabel.Name = "DisclaimerHeaderLabel"
        Me.DisclaimerHeaderLabel.Size = New System.Drawing.Size(872, 20)
        Me.DisclaimerHeaderLabel.TabIndex = 9
        Me.DisclaimerHeaderLabel.Text = "Disclaimer"
        Me.DisclaimerHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DisclaimerDetailsLabel
        '
        Me.DisclaimerDetailsLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DisclaimerDetailsLabel.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisclaimerDetailsLabel.Location = New System.Drawing.Point(3, 630)
        Me.DisclaimerDetailsLabel.Name = "DisclaimerDetailsLabel"
        Me.DisclaimerDetailsLabel.Size = New System.Drawing.Size(872, 35)
        Me.DisclaimerDetailsLabel.TabIndex = 12
        Me.DisclaimerDetailsLabel.Text = "This software is open source under GNU Licence. It's not affiliate to screenscrap" &
    "er.fr and attract-mode. This software is distrubuted for free and is in beta ver" &
    "sion. Use it at your own risks."
        Me.DisclaimerDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DisclaimerCopyrightLabel
        '
        Me.DisclaimerCopyrightLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DisclaimerCopyrightLabel.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisclaimerCopyrightLabel.Location = New System.Drawing.Point(3, 665)
        Me.DisclaimerCopyrightLabel.Name = "DisclaimerCopyrightLabel"
        Me.DisclaimerCopyrightLabel.Size = New System.Drawing.Size(872, 20)
        Me.DisclaimerCopyrightLabel.TabIndex = 13
        Me.DisclaimerCopyrightLabel.Text = "All Rights Reserved - Copyright 2017"
        Me.DisclaimerCopyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HomeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "HomeControl"
        Me.Size = New System.Drawing.Size(878, 700)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PicturePanel.ResumeLayout(False)
        CType(Me.RetroScraperPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScreenScraperPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttractModePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SeparatorPanel As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents IntroLabel As Label
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents PicturePanel As Panel
    Friend WithEvents RetroScraperPictureBox As PictureBox
    Friend WithEvents ScreenScraperPictureBox As PictureBox
    Friend WithEvents AttractModePictureBox As PictureBox
    Friend WithEvents DisclaimerHeaderLabel As Label
    Friend WithEvents DisclaimerDetailsLabel As Label
    Friend WithEvents DisclaimerCopyrightLabel As Label
End Class
