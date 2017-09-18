<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _8_RomsBuildScrapDateControl
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
        Me.SelectAllEurDateCheckBox = New System.Windows.Forms.CheckBox()
        Me.SelectAllWorDateCheckBox = New System.Windows.Forms.CheckBox()
        Me.SelectAllJPDateCheckBox = New System.Windows.Forms.CheckBox()
        Me.SelectAllUSDateCheckBox = New System.Windows.Forms.CheckBox()
        Me.ContentDataGridView = New System.Windows.Forms.DataGridView()
        Me.FilenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsdateusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DateusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsdatejpDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DatejpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsdateworDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DateworDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsdateeuDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DateeuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.ActionPanel.Controls.Add(Me.SelectAllEurDateCheckBox)
        Me.ActionPanel.Controls.Add(Me.SelectAllWorDateCheckBox)
        Me.ActionPanel.Controls.Add(Me.SelectAllJPDateCheckBox)
        Me.ActionPanel.Controls.Add(Me.SelectAllUSDateCheckBox)
        Me.ActionPanel.Controls.Add(Me.ContentDataGridView)
        Me.ActionPanel.Controls.Add(Me.DescriptionLabel)
        Me.ActionPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActionPanel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActionPanel.Location = New System.Drawing.Point(0, 0)
        Me.ActionPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ActionPanel.Name = "ActionPanel"
        Me.ActionPanel.Size = New System.Drawing.Size(878, 727)
        Me.ActionPanel.TabIndex = 8
        '
        'SelectAllEurDateCheckBox
        '
        Me.SelectAllEurDateCheckBox.AutoSize = True
        Me.SelectAllEurDateCheckBox.Location = New System.Drawing.Point(563, 38)
        Me.SelectAllEurDateCheckBox.Name = "SelectAllEurDateCheckBox"
        Me.SelectAllEurDateCheckBox.Size = New System.Drawing.Size(194, 20)
        Me.SelectAllEurDateCheckBox.TabIndex = 7
        Me.SelectAllEurDateCheckBox.Text = "Select all available Europe dates"
        Me.SelectAllEurDateCheckBox.UseVisualStyleBackColor = True
        '
        'SelectAllWorDateCheckBox
        '
        Me.SelectAllWorDateCheckBox.AutoSize = True
        Me.SelectAllWorDateCheckBox.Location = New System.Drawing.Point(369, 38)
        Me.SelectAllWorDateCheckBox.Name = "SelectAllWorDateCheckBox"
        Me.SelectAllWorDateCheckBox.Size = New System.Drawing.Size(190, 20)
        Me.SelectAllWorDateCheckBox.TabIndex = 6
        Me.SelectAllWorDateCheckBox.Text = "Select all available World dates"
        Me.SelectAllWorDateCheckBox.UseVisualStyleBackColor = True
        '
        'SelectAllJPDateCheckBox
        '
        Me.SelectAllJPDateCheckBox.AutoSize = True
        Me.SelectAllJPDateCheckBox.Location = New System.Drawing.Point(195, 38)
        Me.SelectAllJPDateCheckBox.Name = "SelectAllJPDateCheckBox"
        Me.SelectAllJPDateCheckBox.Size = New System.Drawing.Size(170, 20)
        Me.SelectAllJPDateCheckBox.TabIndex = 5
        Me.SelectAllJPDateCheckBox.Text = "Select all available JP dates"
        Me.SelectAllJPDateCheckBox.UseVisualStyleBackColor = True
        '
        'SelectAllUSDateCheckBox
        '
        Me.SelectAllUSDateCheckBox.AutoSize = True
        Me.SelectAllUSDateCheckBox.Location = New System.Drawing.Point(20, 38)
        Me.SelectAllUSDateCheckBox.Name = "SelectAllUSDateCheckBox"
        Me.SelectAllUSDateCheckBox.Size = New System.Drawing.Size(171, 20)
        Me.SelectAllUSDateCheckBox.TabIndex = 4
        Me.SelectAllUSDateCheckBox.Text = "Select all available US dates"
        Me.SelectAllUSDateCheckBox.UseVisualStyleBackColor = True
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
        Me.ContentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FilenameDataGridViewTextBoxColumn, Me.IsdateusDataGridViewCheckBoxColumn, Me.DateusDataGridViewTextBoxColumn, Me.IsdatejpDataGridViewCheckBoxColumn, Me.DatejpDataGridViewTextBoxColumn, Me.IsdateworDataGridViewCheckBoxColumn, Me.DateworDataGridViewTextBoxColumn, Me.IsdateeuDataGridViewCheckBoxColumn, Me.DateeuDataGridViewTextBoxColumn})
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
        'IsdateusDataGridViewCheckBoxColumn
        '
        Me.IsdateusDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IsdateusDataGridViewCheckBoxColumn.DataPropertyName = "is_date_us"
        Me.IsdateusDataGridViewCheckBoxColumn.HeaderText = "US ?"
        Me.IsdateusDataGridViewCheckBoxColumn.Name = "IsdateusDataGridViewCheckBoxColumn"
        Me.IsdateusDataGridViewCheckBoxColumn.Width = 35
        '
        'DateusDataGridViewTextBoxColumn
        '
        Me.DateusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DateusDataGridViewTextBoxColumn.DataPropertyName = "date_us"
        Me.DateusDataGridViewTextBoxColumn.HeaderText = "date US"
        Me.DateusDataGridViewTextBoxColumn.Name = "DateusDataGridViewTextBoxColumn"
        Me.DateusDataGridViewTextBoxColumn.Width = 73
        '
        'IsdatejpDataGridViewCheckBoxColumn
        '
        Me.IsdatejpDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IsdatejpDataGridViewCheckBoxColumn.DataPropertyName = "is_date_jp"
        Me.IsdatejpDataGridViewCheckBoxColumn.HeaderText = "JP ?"
        Me.IsdatejpDataGridViewCheckBoxColumn.Name = "IsdatejpDataGridViewCheckBoxColumn"
        Me.IsdatejpDataGridViewCheckBoxColumn.Width = 34
        '
        'DatejpDataGridViewTextBoxColumn
        '
        Me.DatejpDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DatejpDataGridViewTextBoxColumn.DataPropertyName = "date_jp"
        Me.DatejpDataGridViewTextBoxColumn.HeaderText = "date JP"
        Me.DatejpDataGridViewTextBoxColumn.Name = "DatejpDataGridViewTextBoxColumn"
        Me.DatejpDataGridViewTextBoxColumn.Width = 72
        '
        'IsdateworDataGridViewCheckBoxColumn
        '
        Me.IsdateworDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IsdateworDataGridViewCheckBoxColumn.DataPropertyName = "is_date_wor"
        Me.IsdateworDataGridViewCheckBoxColumn.HeaderText = "WOR ?"
        Me.IsdateworDataGridViewCheckBoxColumn.Name = "IsdateworDataGridViewCheckBoxColumn"
        Me.IsdateworDataGridViewCheckBoxColumn.Width = 49
        '
        'DateworDataGridViewTextBoxColumn
        '
        Me.DateworDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DateworDataGridViewTextBoxColumn.DataPropertyName = "date_wor"
        Me.DateworDataGridViewTextBoxColumn.HeaderText = "Date World"
        Me.DateworDataGridViewTextBoxColumn.Name = "DateworDataGridViewTextBoxColumn"
        Me.DateworDataGridViewTextBoxColumn.Width = 93
        '
        'IsdateeuDataGridViewCheckBoxColumn
        '
        Me.IsdateeuDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IsdateeuDataGridViewCheckBoxColumn.DataPropertyName = "is_date_eu"
        Me.IsdateeuDataGridViewCheckBoxColumn.HeaderText = "EU ?"
        Me.IsdateeuDataGridViewCheckBoxColumn.Name = "IsdateeuDataGridViewCheckBoxColumn"
        Me.IsdateeuDataGridViewCheckBoxColumn.Width = 35
        '
        'DateeuDataGridViewTextBoxColumn
        '
        Me.DateeuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DateeuDataGridViewTextBoxColumn.DataPropertyName = "date_eu"
        Me.DateeuDataGridViewTextBoxColumn.HeaderText = "Date EU"
        Me.DateeuDataGridViewTextBoxColumn.Name = "DateeuDataGridViewTextBoxColumn"
        Me.DateeuDataGridViewTextBoxColumn.Width = 74
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
        Me.DescriptionLabel.Size = New System.Drawing.Size(265, 16)
        Me.DescriptionLabel.TabIndex = 2
        Me.DescriptionLabel.Text = "Please select the date to associate to each game :"
        '
        '_8_RomsBuildScrapDateControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ActionPanel)
        Me.Name = "_8_RomsBuildScrapDateControl"
        Me.Size = New System.Drawing.Size(878, 727)
        Me.ActionPanel.ResumeLayout(False)
        Me.ActionPanel.PerformLayout()
        CType(Me.ContentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSRomsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RomsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ActionPanel As Panel
    Friend WithEvents SelectAllEurDateCheckBox As CheckBox
    Friend WithEvents SelectAllWorDateCheckBox As CheckBox
    Friend WithEvents SelectAllJPDateCheckBox As CheckBox
    Friend WithEvents SelectAllUSDateCheckBox As CheckBox
    Friend WithEvents ContentDataGridView As DataGridView
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents SSRomsBindingSource As BindingSource
    Friend WithEvents RomsDataSet As RomsDataSet
    Friend WithEvents FilenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsdateusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DateusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsdatejpDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DatejpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsdateworDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DateworDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsdateeuDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DateeuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
