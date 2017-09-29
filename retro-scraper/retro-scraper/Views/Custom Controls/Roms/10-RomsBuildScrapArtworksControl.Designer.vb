<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _10_RomsBuildScrapArtworksControl
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
        Me.components = New System.ComponentModel.Container()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.CheckboxFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ArtworkDataGridView = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MediaTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RomsDataSet = New retro_scraper.RomsDataSet()
        Me.ArtworksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ArtworkDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RomsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtworksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Location = New System.Drawing.Point(17, 19)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(279, 16)
        Me.DescriptionLabel.TabIndex = 0
        Me.DescriptionLabel.Text = "Associate in front of each artwork the type of media" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CheckboxFlowLayoutPanel
        '
        Me.CheckboxFlowLayoutPanel.AutoSize = True
        Me.CheckboxFlowLayoutPanel.Location = New System.Drawing.Point(20, 651)
        Me.CheckboxFlowLayoutPanel.Name = "CheckboxFlowLayoutPanel"
        Me.CheckboxFlowLayoutPanel.Size = New System.Drawing.Size(839, 28)
        Me.CheckboxFlowLayoutPanel.TabIndex = 1
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(20, 685)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(75, 23)
        Me.ButtonReset.TabIndex = 2
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(101, 685)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(159, 23)
        Me.ButtonStart.TabIndex = 3
        Me.ButtonStart.Text = "Define media scraping"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ArtworkDataGridView
        '
        Me.ArtworkDataGridView.AllowUserToAddRows = False
        Me.ArtworkDataGridView.AllowUserToDeleteRows = False
        Me.ArtworkDataGridView.AutoGenerateColumns = False
        Me.ArtworkDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ArtworkDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ArtworkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArtworkDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewComboBoxColumn, Me.AssociatedMediaTypeDataGridViewComboBoxColumn})
        Me.ArtworkDataGridView.DataSource = Me.ArtworksBindingSource
        Me.ArtworkDataGridView.Location = New System.Drawing.Point(20, 38)
        Me.ArtworkDataGridView.Name = "ArtworkDataGridView"
        Me.ArtworkDataGridView.Size = New System.Drawing.Size(839, 213)
        Me.ArtworkDataGridView.TabIndex = 4
        '
        'NameDataGridViewComboBoxColumn
        '
        Me.NameDataGridViewComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NameDataGridViewComboBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewComboBoxColumn.HeaderText = "Artwork"
        Me.NameDataGridViewComboBoxColumn.Name = "NameDataGridViewComboBoxColumn"
        Me.NameDataGridViewComboBoxColumn.ReadOnly = True
        Me.NameDataGridViewComboBoxColumn.Width = 76
        '
        'AssociatedMediaTypeDataGridViewComboBoxColumn
        '
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.DataPropertyName = "AssociatedMediaType"
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.DataSource = Me.MediaTypesBindingSource
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.DisplayMember = "Name"
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.HeaderText = "Associated Media Type"
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.Name = "AssociatedMediaTypeDataGridViewComboBoxColumn"
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.ValueMember = "Name"
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.Width = 115
        '
        'MediaTypesBindingSource
        '
        Me.MediaTypesBindingSource.DataMember = "MediaTypes"
        Me.MediaTypesBindingSource.DataSource = Me.RomsDataSet
        '
        'RomsDataSet
        '
        Me.RomsDataSet.DataSetName = "RomsDataSet"
        Me.RomsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArtworksBindingSource
        '
        Me.ArtworksBindingSource.DataMember = "Artworks"
        Me.ArtworksBindingSource.DataSource = Me.RomsDataSet
        '
        '_10_RomsBuildScrapArtworksControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ArtworkDataGridView)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.CheckboxFlowLayoutPanel)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "_10_RomsBuildScrapArtworksControl"
        Me.Size = New System.Drawing.Size(878, 727)
        CType(Me.ArtworkDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RomsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtworksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents CheckboxFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents ButtonReset As Button
    Friend WithEvents ButtonStart As Button
    Friend WithEvents ArtworkDataGridView As DataGridView
    Friend WithEvents ArtworksBindingSource As BindingSource
    Friend WithEvents RomsDataSet As RomsDataSet
    Friend WithEvents NameDataGridViewComboBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssociatedMediaTypeDataGridViewComboBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents MediaTypesBindingSource As BindingSource
End Class
