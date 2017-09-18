<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _9_RomsBuildScrapCategoryControl
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
        Me.CheckboxFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SelectAllENCategoryCheckBox = New System.Windows.Forms.CheckBox()
        Me.SelectAllFRCategoryCheckBox = New System.Windows.Forms.CheckBox()
        Me.SelectAllDECategoryCheckBox = New System.Windows.Forms.CheckBox()
        Me.SelectAllESCategoryCheckBox = New System.Windows.Forms.CheckBox()
        Me.SelectAllPTCategoryCheckBox = New System.Windows.Forms.CheckBox()
        Me.ContentDataGridView = New System.Windows.Forms.DataGridView()
        Me.FilenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsgenresenDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GenresenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsgenresfrDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GenresfrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsgenresdeDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GenresdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsgenresesDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GenresesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsgenresptDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GenresptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSRomsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RomsDataSet = New retro_scraper.RomsDataSet()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.ActionPanel.SuspendLayout()
        Me.CheckboxFlowLayoutPanel.SuspendLayout()
        CType(Me.ContentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSRomsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RomsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActionPanel
        '
        Me.ActionPanel.Controls.Add(Me.CheckboxFlowLayoutPanel)
        Me.ActionPanel.Controls.Add(Me.ContentDataGridView)
        Me.ActionPanel.Controls.Add(Me.DescriptionLabel)
        Me.ActionPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActionPanel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActionPanel.Location = New System.Drawing.Point(0, 0)
        Me.ActionPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ActionPanel.Name = "ActionPanel"
        Me.ActionPanel.Size = New System.Drawing.Size(878, 727)
        Me.ActionPanel.TabIndex = 9
        '
        'CheckboxFlowLayoutPanel
        '
        Me.CheckboxFlowLayoutPanel.Controls.Add(Me.SelectAllENCategoryCheckBox)
        Me.CheckboxFlowLayoutPanel.Controls.Add(Me.SelectAllFRCategoryCheckBox)
        Me.CheckboxFlowLayoutPanel.Controls.Add(Me.SelectAllDECategoryCheckBox)
        Me.CheckboxFlowLayoutPanel.Controls.Add(Me.SelectAllESCategoryCheckBox)
        Me.CheckboxFlowLayoutPanel.Controls.Add(Me.SelectAllPTCategoryCheckBox)
        Me.CheckboxFlowLayoutPanel.Location = New System.Drawing.Point(20, 35)
        Me.CheckboxFlowLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckboxFlowLayoutPanel.Name = "CheckboxFlowLayoutPanel"
        Me.CheckboxFlowLayoutPanel.Size = New System.Drawing.Size(839, 50)
        Me.CheckboxFlowLayoutPanel.TabIndex = 9
        '
        'SelectAllENCategoryCheckBox
        '
        Me.SelectAllENCategoryCheckBox.AutoSize = True
        Me.SelectAllENCategoryCheckBox.Location = New System.Drawing.Point(3, 3)
        Me.SelectAllENCategoryCheckBox.Name = "SelectAllENCategoryCheckBox"
        Me.SelectAllENCategoryCheckBox.Size = New System.Drawing.Size(190, 20)
        Me.SelectAllENCategoryCheckBox.TabIndex = 4
        Me.SelectAllENCategoryCheckBox.Text = "Select all available EN category"
        Me.SelectAllENCategoryCheckBox.UseVisualStyleBackColor = True
        '
        'SelectAllFRCategoryCheckBox
        '
        Me.SelectAllFRCategoryCheckBox.AutoSize = True
        Me.SelectAllFRCategoryCheckBox.Location = New System.Drawing.Point(199, 3)
        Me.SelectAllFRCategoryCheckBox.Name = "SelectAllFRCategoryCheckBox"
        Me.SelectAllFRCategoryCheckBox.Size = New System.Drawing.Size(189, 20)
        Me.SelectAllFRCategoryCheckBox.TabIndex = 5
        Me.SelectAllFRCategoryCheckBox.Text = "Select all available FR category"
        Me.SelectAllFRCategoryCheckBox.UseVisualStyleBackColor = True
        '
        'SelectAllDECategoryCheckBox
        '
        Me.SelectAllDECategoryCheckBox.AutoSize = True
        Me.SelectAllDECategoryCheckBox.Location = New System.Drawing.Point(394, 3)
        Me.SelectAllDECategoryCheckBox.Name = "SelectAllDECategoryCheckBox"
        Me.SelectAllDECategoryCheckBox.Size = New System.Drawing.Size(190, 20)
        Me.SelectAllDECategoryCheckBox.TabIndex = 6
        Me.SelectAllDECategoryCheckBox.Text = "Select all available DE category"
        Me.SelectAllDECategoryCheckBox.UseVisualStyleBackColor = True
        '
        'SelectAllESCategoryCheckBox
        '
        Me.SelectAllESCategoryCheckBox.AutoSize = True
        Me.SelectAllESCategoryCheckBox.Location = New System.Drawing.Point(590, 3)
        Me.SelectAllESCategoryCheckBox.Name = "SelectAllESCategoryCheckBox"
        Me.SelectAllESCategoryCheckBox.Size = New System.Drawing.Size(188, 20)
        Me.SelectAllESCategoryCheckBox.TabIndex = 7
        Me.SelectAllESCategoryCheckBox.Text = "Select all available ES category"
        Me.SelectAllESCategoryCheckBox.UseVisualStyleBackColor = True
        '
        'SelectAllPTCategoryCheckBox
        '
        Me.SelectAllPTCategoryCheckBox.AutoSize = True
        Me.SelectAllPTCategoryCheckBox.Location = New System.Drawing.Point(3, 29)
        Me.SelectAllPTCategoryCheckBox.Name = "SelectAllPTCategoryCheckBox"
        Me.SelectAllPTCategoryCheckBox.Size = New System.Drawing.Size(190, 20)
        Me.SelectAllPTCategoryCheckBox.TabIndex = 8
        Me.SelectAllPTCategoryCheckBox.Text = "Select all available PT category"
        Me.SelectAllPTCategoryCheckBox.UseVisualStyleBackColor = True
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
        Me.ContentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FilenameDataGridViewTextBoxColumn, Me.IsgenresenDataGridViewCheckBoxColumn, Me.GenresenDataGridViewTextBoxColumn, Me.IsgenresfrDataGridViewCheckBoxColumn, Me.GenresfrDataGridViewTextBoxColumn, Me.IsgenresdeDataGridViewCheckBoxColumn, Me.GenresdeDataGridViewTextBoxColumn, Me.IsgenresesDataGridViewCheckBoxColumn, Me.GenresesDataGridViewTextBoxColumn, Me.IsgenresptDataGridViewCheckBoxColumn, Me.GenresptDataGridViewTextBoxColumn})
        Me.ContentDataGridView.DataSource = Me.SSRomsBindingSource
        Me.ContentDataGridView.Location = New System.Drawing.Point(20, 88)
        Me.ContentDataGridView.Name = "ContentDataGridView"
        Me.ContentDataGridView.Size = New System.Drawing.Size(839, 623)
        Me.ContentDataGridView.TabIndex = 3
        '
        'FilenameDataGridViewTextBoxColumn
        '
        Me.FilenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FilenameDataGridViewTextBoxColumn.DataPropertyName = "filename"
        Me.FilenameDataGridViewTextBoxColumn.HeaderText = "filename"
        Me.FilenameDataGridViewTextBoxColumn.Name = "FilenameDataGridViewTextBoxColumn"
        Me.FilenameDataGridViewTextBoxColumn.Width = 76
        '
        'IsgenresenDataGridViewCheckBoxColumn
        '
        Me.IsgenresenDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IsgenresenDataGridViewCheckBoxColumn.DataPropertyName = "is_genres_en"
        Me.IsgenresenDataGridViewCheckBoxColumn.HeaderText = "EN ?"
        Me.IsgenresenDataGridViewCheckBoxColumn.Name = "IsgenresenDataGridViewCheckBoxColumn"
        Me.IsgenresenDataGridViewCheckBoxColumn.Width = 36
        '
        'GenresenDataGridViewTextBoxColumn
        '
        Me.GenresenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GenresenDataGridViewTextBoxColumn.DataPropertyName = "genres_en"
        Me.GenresenDataGridViewTextBoxColumn.HeaderText = "Category EN"
        Me.GenresenDataGridViewTextBoxColumn.Name = "GenresenDataGridViewTextBoxColumn"
        Me.GenresenDataGridViewTextBoxColumn.Width = 99
        '
        'IsgenresfrDataGridViewCheckBoxColumn
        '
        Me.IsgenresfrDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IsgenresfrDataGridViewCheckBoxColumn.DataPropertyName = "is_genres_fr"
        Me.IsgenresfrDataGridViewCheckBoxColumn.HeaderText = "FR ?"
        Me.IsgenresfrDataGridViewCheckBoxColumn.Name = "IsgenresfrDataGridViewCheckBoxColumn"
        Me.IsgenresfrDataGridViewCheckBoxColumn.Width = 35
        '
        'GenresfrDataGridViewTextBoxColumn
        '
        Me.GenresfrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GenresfrDataGridViewTextBoxColumn.DataPropertyName = "genres_fr"
        Me.GenresfrDataGridViewTextBoxColumn.HeaderText = "Category FR"
        Me.GenresfrDataGridViewTextBoxColumn.Name = "GenresfrDataGridViewTextBoxColumn"
        Me.GenresfrDataGridViewTextBoxColumn.Width = 98
        '
        'IsgenresdeDataGridViewCheckBoxColumn
        '
        Me.IsgenresdeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IsgenresdeDataGridViewCheckBoxColumn.DataPropertyName = "is_genres_de"
        Me.IsgenresdeDataGridViewCheckBoxColumn.HeaderText = "DE ?"
        Me.IsgenresdeDataGridViewCheckBoxColumn.Name = "IsgenresdeDataGridViewCheckBoxColumn"
        Me.IsgenresdeDataGridViewCheckBoxColumn.Width = 36
        '
        'GenresdeDataGridViewTextBoxColumn
        '
        Me.GenresdeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GenresdeDataGridViewTextBoxColumn.DataPropertyName = "genres_de"
        Me.GenresdeDataGridViewTextBoxColumn.HeaderText = "Category DE"
        Me.GenresdeDataGridViewTextBoxColumn.Name = "GenresdeDataGridViewTextBoxColumn"
        Me.GenresdeDataGridViewTextBoxColumn.Width = 99
        '
        'IsgenresesDataGridViewCheckBoxColumn
        '
        Me.IsgenresesDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IsgenresesDataGridViewCheckBoxColumn.DataPropertyName = "is_genres_es"
        Me.IsgenresesDataGridViewCheckBoxColumn.HeaderText = "ES ?"
        Me.IsgenresesDataGridViewCheckBoxColumn.Name = "IsgenresesDataGridViewCheckBoxColumn"
        Me.IsgenresesDataGridViewCheckBoxColumn.Width = 34
        '
        'GenresesDataGridViewTextBoxColumn
        '
        Me.GenresesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GenresesDataGridViewTextBoxColumn.DataPropertyName = "genres_es"
        Me.GenresesDataGridViewTextBoxColumn.HeaderText = "Category ES"
        Me.GenresesDataGridViewTextBoxColumn.Name = "GenresesDataGridViewTextBoxColumn"
        Me.GenresesDataGridViewTextBoxColumn.Width = 97
        '
        'IsgenresptDataGridViewCheckBoxColumn
        '
        Me.IsgenresptDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IsgenresptDataGridViewCheckBoxColumn.DataPropertyName = "is_genres_pt"
        Me.IsgenresptDataGridViewCheckBoxColumn.HeaderText = "PT ?"
        Me.IsgenresptDataGridViewCheckBoxColumn.Name = "IsgenresptDataGridViewCheckBoxColumn"
        Me.IsgenresptDataGridViewCheckBoxColumn.Width = 36
        '
        'GenresptDataGridViewTextBoxColumn
        '
        Me.GenresptDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GenresptDataGridViewTextBoxColumn.DataPropertyName = "genres_pt"
        Me.GenresptDataGridViewTextBoxColumn.HeaderText = "Category PT"
        Me.GenresptDataGridViewTextBoxColumn.Name = "GenresptDataGridViewTextBoxColumn"
        Me.GenresptDataGridViewTextBoxColumn.Width = 99
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
        Me.DescriptionLabel.Size = New System.Drawing.Size(288, 16)
        Me.DescriptionLabel.TabIndex = 2
        Me.DescriptionLabel.Text = "Please select the category to associate to each game :"
        '
        '_9_RomsBuildScrapCategoryControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ActionPanel)
        Me.Name = "_9_RomsBuildScrapCategoryControl"
        Me.Size = New System.Drawing.Size(878, 727)
        Me.ActionPanel.ResumeLayout(False)
        Me.ActionPanel.PerformLayout()
        Me.CheckboxFlowLayoutPanel.ResumeLayout(False)
        Me.CheckboxFlowLayoutPanel.PerformLayout()
        CType(Me.ContentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSRomsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RomsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ActionPanel As Panel
    Friend WithEvents SelectAllESCategoryCheckBox As CheckBox
    Friend WithEvents SelectAllDECategoryCheckBox As CheckBox
    Friend WithEvents SelectAllFRCategoryCheckBox As CheckBox
    Friend WithEvents SelectAllENCategoryCheckBox As CheckBox
    Friend WithEvents ContentDataGridView As DataGridView
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents SSRomsBindingSource As BindingSource
    Friend WithEvents RomsDataSet As RomsDataSet
    Friend WithEvents SelectAllPTCategoryCheckBox As CheckBox
    Friend WithEvents FilenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsgenresenDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents GenresenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsgenresfrDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents GenresfrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsgenresdeDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents GenresdeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsgenresesDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents GenresesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsgenresptDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents GenresptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheckboxFlowLayoutPanel As FlowLayoutPanel
End Class
