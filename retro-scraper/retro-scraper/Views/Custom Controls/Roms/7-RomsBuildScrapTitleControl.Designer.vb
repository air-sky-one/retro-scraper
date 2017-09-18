<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _7_RomsBuildScrapTitleControl
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
        Me.ActionPanel = New System.Windows.Forms.Panel()
        Me.SelectAllEurTitleCheckBox = New System.Windows.Forms.CheckBox()
        Me.SelectAllWorTitleCheckBox = New System.Windows.Forms.CheckBox()
        Me.SelectAllJPTitleCheckBox = New System.Windows.Forms.CheckBox()
        Me.SelectAllUSTitleCheckBox = New System.Windows.Forms.CheckBox()
        Me.ContentDataGridView = New System.Windows.Forms.DataGridView()
        Me.FilenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsnomusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NomusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsnomjpDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NomjpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsnomworDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NomworDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsnomeuDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NomeuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSRomsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RomsDataSet = New retro_scraper.RomsDataSet()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.ActionPanel.SuspendLayout()
        CType(Me.ContentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSRomsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RomsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActionPanel
        '
        Me.ActionPanel.Controls.Add(Me.SelectAllEurTitleCheckBox)
        Me.ActionPanel.Controls.Add(Me.SelectAllWorTitleCheckBox)
        Me.ActionPanel.Controls.Add(Me.SelectAllJPTitleCheckBox)
        Me.ActionPanel.Controls.Add(Me.SelectAllUSTitleCheckBox)
        Me.ActionPanel.Controls.Add(Me.ContentDataGridView)
        Me.ActionPanel.Controls.Add(Me.DescriptionLabel)
        Me.ActionPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActionPanel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActionPanel.Location = New System.Drawing.Point(0, 0)
        Me.ActionPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ActionPanel.Name = "ActionPanel"
        Me.ActionPanel.Size = New System.Drawing.Size(878, 727)
        Me.ActionPanel.TabIndex = 7
        '
        'SelectAllEurTitleCheckBox
        '
        Me.SelectAllEurTitleCheckBox.AutoSize = True
        Me.SelectAllEurTitleCheckBox.Location = New System.Drawing.Point(563, 38)
        Me.SelectAllEurTitleCheckBox.Name = "SelectAllEurTitleCheckBox"
        Me.SelectAllEurTitleCheckBox.Size = New System.Drawing.Size(192, 20)
        Me.SelectAllEurTitleCheckBox.TabIndex = 7
        Me.SelectAllEurTitleCheckBox.Text = "Select all available Europe titles"
        Me.SelectAllEurTitleCheckBox.UseVisualStyleBackColor = True
        '
        'SelectAllWorTitleCheckBox
        '
        Me.SelectAllWorTitleCheckBox.AutoSize = True
        Me.SelectAllWorTitleCheckBox.Location = New System.Drawing.Point(369, 38)
        Me.SelectAllWorTitleCheckBox.Name = "SelectAllWorTitleCheckBox"
        Me.SelectAllWorTitleCheckBox.Size = New System.Drawing.Size(188, 20)
        Me.SelectAllWorTitleCheckBox.TabIndex = 6
        Me.SelectAllWorTitleCheckBox.Text = "Select all available World titles"
        Me.SelectAllWorTitleCheckBox.UseVisualStyleBackColor = True
        '
        'SelectAllJPTitleCheckBox
        '
        Me.SelectAllJPTitleCheckBox.AutoSize = True
        Me.SelectAllJPTitleCheckBox.Location = New System.Drawing.Point(195, 38)
        Me.SelectAllJPTitleCheckBox.Name = "SelectAllJPTitleCheckBox"
        Me.SelectAllJPTitleCheckBox.Size = New System.Drawing.Size(168, 20)
        Me.SelectAllJPTitleCheckBox.TabIndex = 5
        Me.SelectAllJPTitleCheckBox.Text = "Select all available JP titles"
        Me.SelectAllJPTitleCheckBox.UseVisualStyleBackColor = True
        '
        'SelectAllUSTitleCheckBox
        '
        Me.SelectAllUSTitleCheckBox.AutoSize = True
        Me.SelectAllUSTitleCheckBox.Location = New System.Drawing.Point(20, 38)
        Me.SelectAllUSTitleCheckBox.Name = "SelectAllUSTitleCheckBox"
        Me.SelectAllUSTitleCheckBox.Size = New System.Drawing.Size(169, 20)
        Me.SelectAllUSTitleCheckBox.TabIndex = 4
        Me.SelectAllUSTitleCheckBox.Text = "Select all available US titles"
        Me.SelectAllUSTitleCheckBox.UseVisualStyleBackColor = True
        '
        'ContentDataGridView
        '
        Me.ContentDataGridView.AllowUserToAddRows = False
        Me.ContentDataGridView.AllowUserToDeleteRows = False
        Me.ContentDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContentDataGridView.AutoGenerateColumns = False
        Me.ContentDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ContentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ContentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FilenameDataGridViewTextBoxColumn, Me.IsnomusDataGridViewCheckBoxColumn, Me.NomusDataGridViewTextBoxColumn, Me.IsnomjpDataGridViewCheckBoxColumn, Me.NomjpDataGridViewTextBoxColumn, Me.IsnomworDataGridViewCheckBoxColumn, Me.NomworDataGridViewTextBoxColumn, Me.IsnomeuDataGridViewCheckBoxColumn, Me.NomeuDataGridViewTextBoxColumn})
        Me.ContentDataGridView.DataSource = Me.SSRomsBindingSource
        Me.ContentDataGridView.Location = New System.Drawing.Point(20, 64)
        Me.ContentDataGridView.Name = "ContentDataGridView"
        Me.ContentDataGridView.Size = New System.Drawing.Size(839, 647)
        Me.ContentDataGridView.TabIndex = 3
        '
        'FilenameDataGridViewTextBoxColumn
        '
        Me.FilenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FilenameDataGridViewTextBoxColumn.DataPropertyName = "filename"
        Me.FilenameDataGridViewTextBoxColumn.HeaderText = "Game's filename"
        Me.FilenameDataGridViewTextBoxColumn.Name = "FilenameDataGridViewTextBoxColumn"
        Me.FilenameDataGridViewTextBoxColumn.Width = 115
        '
        'IsnomusDataGridViewCheckBoxColumn
        '
        Me.IsnomusDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IsnomusDataGridViewCheckBoxColumn.DataPropertyName = "is_nom_us"
        Me.IsnomusDataGridViewCheckBoxColumn.HeaderText = "US ?"
        Me.IsnomusDataGridViewCheckBoxColumn.Name = "IsnomusDataGridViewCheckBoxColumn"
        Me.IsnomusDataGridViewCheckBoxColumn.Width = 35
        '
        'NomusDataGridViewTextBoxColumn
        '
        Me.NomusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NomusDataGridViewTextBoxColumn.DataPropertyName = "nom_us"
        Me.NomusDataGridViewTextBoxColumn.HeaderText = "Title US"
        Me.NomusDataGridViewTextBoxColumn.Name = "NomusDataGridViewTextBoxColumn"
        Me.NomusDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomusDataGridViewTextBoxColumn.Width = 73
        '
        'IsnomjpDataGridViewCheckBoxColumn
        '
        Me.IsnomjpDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IsnomjpDataGridViewCheckBoxColumn.DataPropertyName = "is_nom_jp"
        Me.IsnomjpDataGridViewCheckBoxColumn.HeaderText = "JP ?"
        Me.IsnomjpDataGridViewCheckBoxColumn.Name = "IsnomjpDataGridViewCheckBoxColumn"
        Me.IsnomjpDataGridViewCheckBoxColumn.Width = 34
        '
        'NomjpDataGridViewTextBoxColumn
        '
        Me.NomjpDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NomjpDataGridViewTextBoxColumn.DataPropertyName = "nom_jp"
        Me.NomjpDataGridViewTextBoxColumn.HeaderText = "Title JP"
        Me.NomjpDataGridViewTextBoxColumn.Name = "NomjpDataGridViewTextBoxColumn"
        Me.NomjpDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomjpDataGridViewTextBoxColumn.Width = 72
        '
        'IsnomworDataGridViewCheckBoxColumn
        '
        Me.IsnomworDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IsnomworDataGridViewCheckBoxColumn.DataPropertyName = "is_nom_wor"
        Me.IsnomworDataGridViewCheckBoxColumn.HeaderText = "WOR ?"
        Me.IsnomworDataGridViewCheckBoxColumn.Name = "IsnomworDataGridViewCheckBoxColumn"
        Me.IsnomworDataGridViewCheckBoxColumn.Width = 49
        '
        'NomworDataGridViewTextBoxColumn
        '
        Me.NomworDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NomworDataGridViewTextBoxColumn.DataPropertyName = "nom_wor"
        Me.NomworDataGridViewTextBoxColumn.HeaderText = "Title World"
        Me.NomworDataGridViewTextBoxColumn.Name = "NomworDataGridViewTextBoxColumn"
        Me.NomworDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomworDataGridViewTextBoxColumn.Width = 92
        '
        'IsnomeuDataGridViewCheckBoxColumn
        '
        Me.IsnomeuDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IsnomeuDataGridViewCheckBoxColumn.DataPropertyName = "is_nom_eu"
        Me.IsnomeuDataGridViewCheckBoxColumn.HeaderText = "EU ?"
        Me.IsnomeuDataGridViewCheckBoxColumn.Name = "IsnomeuDataGridViewCheckBoxColumn"
        Me.IsnomeuDataGridViewCheckBoxColumn.Width = 35
        '
        'NomeuDataGridViewTextBoxColumn
        '
        Me.NomeuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NomeuDataGridViewTextBoxColumn.DataPropertyName = "nom_eu"
        Me.NomeuDataGridViewTextBoxColumn.HeaderText = "Title Europe"
        Me.NomeuDataGridViewTextBoxColumn.Name = "NomeuDataGridViewTextBoxColumn"
        Me.NomeuDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomeuDataGridViewTextBoxColumn.Width = 96
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
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(17, 19)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(263, 16)
        Me.DescriptionLabel.TabIndex = 2
        Me.DescriptionLabel.Text = "Please select the title to associate to each game :"
        '
        '_7_RomsBuildScrapTitleControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ActionPanel)
        Me.Name = "_7_RomsBuildScrapTitleControl"
        Me.Size = New System.Drawing.Size(878, 727)
        Me.ActionPanel.ResumeLayout(False)
        Me.ActionPanel.PerformLayout()
        CType(Me.ContentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSRomsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RomsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ActionPanel As Panel
    Friend WithEvents ContentDataGridView As DataGridView
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents SelectAllUSTitleCheckBox As CheckBox
    Friend WithEvents SSRomsBindingSource As BindingSource
    Friend WithEvents RomsDataSet As RomsDataSet
    Friend WithEvents FilenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsnomusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents NomusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsnomjpDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents NomjpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsnomworDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents NomworDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsnomeuDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents NomeuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SelectAllEurTitleCheckBox As CheckBox
    Friend WithEvents SelectAllWorTitleCheckBox As CheckBox
    Friend WithEvents SelectAllJPTitleCheckBox As CheckBox
End Class
