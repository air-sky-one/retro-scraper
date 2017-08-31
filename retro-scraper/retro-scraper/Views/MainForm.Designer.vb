﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MainMenuPanel = New System.Windows.Forms.Panel()
        Me.HeaderPanel.SuspendLayout()
        CType(Me.HeaderPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MainMenuPanel, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 144)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1008, 753)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'MainMenuPanel
        '
        Me.MainMenuPanel.BackColor = System.Drawing.Color.DimGray
        Me.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainMenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MainMenuPanel.Name = "MainMenuPanel"
        Me.MainMenuPanel.Size = New System.Drawing.Size(250, 753)
        Me.MainMenuPanel.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 897)
        Me.Controls.Add(Me.TableLayoutPanel1)
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
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents HeaderPictureBox As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MainMenuPanel As Panel
End Class
