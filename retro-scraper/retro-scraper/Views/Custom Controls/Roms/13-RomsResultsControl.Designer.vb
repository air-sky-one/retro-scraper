<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _13_RomsResultsControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ScrapedRomsPanel = New System.Windows.Forms.Panel()
        Me.ScrapedRomsListBox = New System.Windows.Forms.ListBox()
        Me.SSRomsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RomsDataSet = New retro_scraper.RomsDataSet()
        Me.ScrapedRomsLabel = New System.Windows.Forms.Label()
        Me.ErrorLoadingPanel = New System.Windows.Forms.Panel()
        Me.ErrorLoadingListBox = New System.Windows.Forms.ListBox()
        Me.ErrorsSSRomsLoadingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ErrorLoadingLabel = New System.Windows.Forms.Label()
        Me.ErrorDownloadPanel = New System.Windows.Forms.Panel()
        Me.ErrorDonwloadListBox = New System.Windows.Forms.ListBox()
        Me.ErrorDonwloadLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        Me.ScrapedRomsPanel.SuspendLayout()
        CType(Me.SSRomsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RomsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ErrorLoadingPanel.SuspendLayout()
        CType(Me.ErrorsSSRomsLoadingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ErrorDownloadPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.HeaderPanel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ScrapedRomsPanel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ErrorLoadingPanel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ErrorDownloadPanel, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(878, 727)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'HeaderPanel
        '
        Me.HeaderPanel.Controls.Add(Me.DescriptionLabel)
        Me.HeaderPanel.Controls.Add(Me.HeaderLabel)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderPanel.Location = New System.Drawing.Point(3, 3)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(872, 64)
        Me.HeaderPanel.TabIndex = 0
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescriptionLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(-2, 35)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(880, 35)
        Me.DescriptionLabel.TabIndex = 21
        Me.DescriptionLabel.Text = "Your scrap is over, here are the results"
        Me.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HeaderLabel
        '
        Me.HeaderLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HeaderLabel.Font = New System.Drawing.Font("Ubuntu", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.Location = New System.Drawing.Point(-4, 0)
        Me.HeaderLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Padding = New System.Windows.Forms.Padding(3)
        Me.HeaderLabel.Size = New System.Drawing.Size(880, 35)
        Me.HeaderLabel.TabIndex = 20
        Me.HeaderLabel.Text = "Congratulations !"
        Me.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ScrapedRomsPanel
        '
        Me.ScrapedRomsPanel.Controls.Add(Me.ScrapedRomsListBox)
        Me.ScrapedRomsPanel.Controls.Add(Me.ScrapedRomsLabel)
        Me.ScrapedRomsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScrapedRomsPanel.Location = New System.Drawing.Point(3, 73)
        Me.ScrapedRomsPanel.Name = "ScrapedRomsPanel"
        Me.ScrapedRomsPanel.Size = New System.Drawing.Size(872, 351)
        Me.ScrapedRomsPanel.TabIndex = 1
        '
        'ScrapedRomsListBox
        '
        Me.ScrapedRomsListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScrapedRomsListBox.DataSource = Me.SSRomsBindingSource
        Me.ScrapedRomsListBox.DisplayMember = "filename"
        Me.ScrapedRomsListBox.FormattingEnabled = True
        Me.ScrapedRomsListBox.Location = New System.Drawing.Point(6, 28)
        Me.ScrapedRomsListBox.Name = "ScrapedRomsListBox"
        Me.ScrapedRomsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ScrapedRomsListBox.Size = New System.Drawing.Size(863, 316)
        Me.ScrapedRomsListBox.TabIndex = 27
        Me.ScrapedRomsListBox.ValueMember = "filename"
        '
        'SSRomsBindingSource
        '
        Me.SSRomsBindingSource.DataMember = "SSRoms"
        Me.SSRomsBindingSource.DataSource = Me.RomsDataSet
        '
        'RomsDataSet
        '
        Me.RomsDataSet.DataSetName = "RomsDataSet"
        Me.RomsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ScrapedRomsLabel
        '
        Me.ScrapedRomsLabel.AutoSize = True
        Me.ScrapedRomsLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScrapedRomsLabel.Location = New System.Drawing.Point(3, 9)
        Me.ScrapedRomsLabel.Name = "ScrapedRomsLabel"
        Me.ScrapedRomsLabel.Size = New System.Drawing.Size(111, 16)
        Me.ScrapedRomsLabel.TabIndex = 26
        Me.ScrapedRomsLabel.Text = "Your scrapped roms"
        '
        'ErrorLoadingPanel
        '
        Me.ErrorLoadingPanel.Controls.Add(Me.ErrorLoadingListBox)
        Me.ErrorLoadingPanel.Controls.Add(Me.ErrorLoadingLabel)
        Me.ErrorLoadingPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ErrorLoadingPanel.Location = New System.Drawing.Point(3, 430)
        Me.ErrorLoadingPanel.Name = "ErrorLoadingPanel"
        Me.ErrorLoadingPanel.Size = New System.Drawing.Size(872, 144)
        Me.ErrorLoadingPanel.TabIndex = 2
        '
        'ErrorLoadingListBox
        '
        Me.ErrorLoadingListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ErrorLoadingListBox.DataSource = Me.ErrorsSSRomsLoadingBindingSource
        Me.ErrorLoadingListBox.FormattingEnabled = True
        Me.ErrorLoadingListBox.Location = New System.Drawing.Point(6, 28)
        Me.ErrorLoadingListBox.Name = "ErrorLoadingListBox"
        Me.ErrorLoadingListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ErrorLoadingListBox.Size = New System.Drawing.Size(863, 108)
        Me.ErrorLoadingListBox.TabIndex = 31
        '
        'ErrorsSSRomsLoadingBindingSource
        '
        Me.ErrorsSSRomsLoadingBindingSource.DataMember = "ErrorsSSRomsLoading"
        Me.ErrorsSSRomsLoadingBindingSource.DataSource = Me.RomsDataSet
        '
        'ErrorLoadingLabel
        '
        Me.ErrorLoadingLabel.AutoSize = True
        Me.ErrorLoadingLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorLoadingLabel.Location = New System.Drawing.Point(3, 9)
        Me.ErrorLoadingLabel.Name = "ErrorLoadingLabel"
        Me.ErrorLoadingLabel.Size = New System.Drawing.Size(226, 16)
        Me.ErrorLoadingLabel.TabIndex = 30
        Me.ErrorLoadingLabel.Text = "Errors during screenscraper.fr loading data"
        '
        'ErrorDownloadPanel
        '
        Me.ErrorDownloadPanel.Controls.Add(Me.ErrorDonwloadListBox)
        Me.ErrorDownloadPanel.Controls.Add(Me.ErrorDonwloadLabel)
        Me.ErrorDownloadPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ErrorDownloadPanel.Location = New System.Drawing.Point(3, 580)
        Me.ErrorDownloadPanel.Name = "ErrorDownloadPanel"
        Me.ErrorDownloadPanel.Size = New System.Drawing.Size(872, 144)
        Me.ErrorDownloadPanel.TabIndex = 3
        '
        'ErrorDonwloadListBox
        '
        Me.ErrorDonwloadListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ErrorDonwloadListBox.DataSource = Me.ErrorsSSRomsLoadingBindingSource
        Me.ErrorDonwloadListBox.FormattingEnabled = True
        Me.ErrorDonwloadListBox.Location = New System.Drawing.Point(6, 28)
        Me.ErrorDonwloadListBox.Name = "ErrorDonwloadListBox"
        Me.ErrorDonwloadListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ErrorDonwloadListBox.Size = New System.Drawing.Size(863, 108)
        Me.ErrorDonwloadListBox.TabIndex = 32
        '
        'ErrorDonwloadLabel
        '
        Me.ErrorDonwloadLabel.AutoSize = True
        Me.ErrorDonwloadLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorDonwloadLabel.Location = New System.Drawing.Point(3, 9)
        Me.ErrorDonwloadLabel.Name = "ErrorDonwloadLabel"
        Me.ErrorDonwloadLabel.Size = New System.Drawing.Size(131, 16)
        Me.ErrorDonwloadLabel.TabIndex = 31
        Me.ErrorDonwloadLabel.Text = "Errors during download"
        '
        '_13_RomsResultsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "_13_RomsResultsControl"
        Me.Size = New System.Drawing.Size(878, 727)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.HeaderPanel.ResumeLayout(False)
        Me.ScrapedRomsPanel.ResumeLayout(False)
        Me.ScrapedRomsPanel.PerformLayout()
        CType(Me.SSRomsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RomsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ErrorLoadingPanel.ResumeLayout(False)
        Me.ErrorLoadingPanel.PerformLayout()
        CType(Me.ErrorsSSRomsLoadingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ErrorDownloadPanel.ResumeLayout(False)
        Me.ErrorDownloadPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents ScrapedRomsPanel As Panel
    Friend WithEvents ScrapedRomsListBox As ListBox
    Friend WithEvents SSRomsBindingSource As BindingSource
    Friend WithEvents RomsDataSet As RomsDataSet
    Friend WithEvents ScrapedRomsLabel As Label
    Friend WithEvents ErrorLoadingPanel As Panel
    Friend WithEvents ErrorLoadingListBox As ListBox
    Friend WithEvents ErrorsSSRomsLoadingBindingSource As BindingSource
    Friend WithEvents ErrorLoadingLabel As Label
    Friend WithEvents ErrorDownloadPanel As Panel
    Friend WithEvents ErrorDonwloadListBox As ListBox
    Friend WithEvents ErrorDonwloadLabel As Label
End Class
