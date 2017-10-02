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
        Me.ContentDataGridView = New System.Windows.Forms.DataGridView()
        Me.MediaTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RomsDataSet = New retro_scraper.RomsDataSet()
        Me.ArtworksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameDataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ButtonReset = New System.Windows.Forms.Button()
        CType(Me.ContentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ContentDataGridView
        '
        Me.ContentDataGridView.AllowUserToAddRows = False
        Me.ContentDataGridView.AllowUserToDeleteRows = False
        Me.ContentDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContentDataGridView.AutoGenerateColumns = False
        Me.ContentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ContentDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ContentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ContentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewComboBoxColumn, Me.AssociatedMediaTypeDataGridViewComboBoxColumn})
        Me.ContentDataGridView.DataSource = Me.ArtworksBindingSource
        Me.ContentDataGridView.Location = New System.Drawing.Point(20, 45)
        Me.ContentDataGridView.Name = "ContentDataGridView"
        Me.ContentDataGridView.Size = New System.Drawing.Size(839, 188)
        Me.ContentDataGridView.TabIndex = 4
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
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.DataPropertyName = "AssociatedMediaType"
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.DataSource = Me.MediaTypesBindingSource
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.DisplayMember = "Name"
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.HeaderText = "Associated Media Type"
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.Name = "AssociatedMediaTypeDataGridViewComboBoxColumn"
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.ValueMember = "Name"
        Me.AssociatedMediaTypeDataGridViewComboBoxColumn.Width = 250
        '
        'ButtonReset
        '
        Me.ButtonReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonReset.Location = New System.Drawing.Point(784, 16)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(75, 23)
        Me.ButtonReset.TabIndex = 5
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        '_10_RomsBuildScrapArtworksControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ContentDataGridView)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "_10_RomsBuildScrapArtworksControl"
        Me.Size = New System.Drawing.Size(878, 727)
        CType(Me.ContentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RomsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtworksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents ContentDataGridView As DataGridView
    Friend WithEvents ArtworksBindingSource As BindingSource
    Friend WithEvents RomsDataSet As RomsDataSet
    Friend WithEvents MediaTypesBindingSource As BindingSource
    Friend WithEvents NameDataGridViewComboBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssociatedMediaTypeDataGridViewComboBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents ButtonReset As Button
End Class
