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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RetroScraperPictureBox = New System.Windows.Forms.PictureBox()
        Me.ScreenScraperPictureBox = New System.Windows.Forms.PictureBox()
        Me.AttractModePictureBox = New System.Windows.Forms.PictureBox()
        Me.IntroLabel = New System.Windows.Forms.Label()
        Me.DisclaimerLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.RetroScraperPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScreenScraperPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttractModePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 150)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(878, 5)
        Me.Panel1.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.IntroLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.HeaderLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DisclaimerLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(878, 700)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'HeaderLabel
        '
        Me.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderLabel.Font = New System.Drawing.Font("Ubuntu", 45.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(878, 150)
        Me.HeaderLabel.TabIndex = 5
        Me.HeaderLabel.Text = "Welcome to retro-scraper !"
        Me.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RetroScraperPictureBox)
        Me.Panel2.Controls.Add(Me.ScreenScraperPictureBox)
        Me.Panel2.Controls.Add(Me.AttractModePictureBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 285)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(878, 200)
        Me.Panel2.TabIndex = 7
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
        'IntroLabel
        '
        Me.IntroLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IntroLabel.Font = New System.Drawing.Font("Ubuntu", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntroLabel.Location = New System.Drawing.Point(0, 155)
        Me.IntroLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.IntroLabel.Name = "IntroLabel"
        Me.IntroLabel.Padding = New System.Windows.Forms.Padding(50, 20, 50, 20)
        Me.IntroLabel.Size = New System.Drawing.Size(878, 130)
        Me.IntroLabel.TabIndex = 8
        Me.IntroLabel.Text = "retro-scraper is a dedicated tool for scraping systems and games data and media f" &
    "or attract-mode front end from screenscraper.fr amazing database."
        Me.IntroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DisclaimerLabel
        '
        Me.DisclaimerLabel.AutoSize = True
        Me.DisclaimerLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DisclaimerLabel.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisclaimerLabel.Location = New System.Drawing.Point(3, 627)
        Me.DisclaimerLabel.Name = "DisclaimerLabel"
        Me.DisclaimerLabel.Size = New System.Drawing.Size(872, 20)
        Me.DisclaimerLabel.TabIndex = 9
        Me.DisclaimerLabel.Text = "Disclaimer"
        Me.DisclaimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 647)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(872, 33)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "This software is open source under GNU Licence. It's not affiliate to screenscrap" &
    "er.fr and attract-mode. This software is distrubuted for free and is in beta ver" &
    "sion. Use it at your own risks."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 680)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(872, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "All Rights Reserved - Copyright 2017"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.RetroScraperPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScreenScraperPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttractModePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents IntroLabel As Label
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RetroScraperPictureBox As PictureBox
    Friend WithEvents ScreenScraperPictureBox As PictureBox
    Friend WithEvents AttractModePictureBox As PictureBox
    Friend WithEvents DisclaimerLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
