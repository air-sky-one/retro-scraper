<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _6_RomsBuildScrapGamesSelectionControl
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
        Me.SelectAllCheckBox = New System.Windows.Forms.CheckBox()
        Me.ContentDataGridView = New System.Windows.Forms.DataGridView()
        Me.IsCheckedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FilenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.ActionPanel.Controls.Add(Me.SelectAllCheckBox)
        Me.ActionPanel.Controls.Add(Me.ContentDataGridView)
        Me.ActionPanel.Controls.Add(Me.DescriptionLabel)
        Me.ActionPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActionPanel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActionPanel.Location = New System.Drawing.Point(0, 0)
        Me.ActionPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ActionPanel.Name = "ActionPanel"
        Me.ActionPanel.Size = New System.Drawing.Size(878, 727)
        Me.ActionPanel.TabIndex = 6
        '
        'SelectAllCheckBox
        '
        Me.SelectAllCheckBox.AutoSize = True
        Me.SelectAllCheckBox.Location = New System.Drawing.Point(20, 38)
        Me.SelectAllCheckBox.Name = "SelectAllCheckBox"
        Me.SelectAllCheckBox.Size = New System.Drawing.Size(109, 20)
        Me.SelectAllCheckBox.TabIndex = 4
        Me.SelectAllCheckBox.Text = "Select all games"
        Me.SelectAllCheckBox.UseVisualStyleBackColor = True
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
        Me.ContentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IsCheckedDataGridViewCheckBoxColumn, Me.FilenameDataGridViewTextBoxColumn})
        Me.ContentDataGridView.DataSource = Me.SSRomsBindingSource
        Me.ContentDataGridView.Location = New System.Drawing.Point(20, 64)
        Me.ContentDataGridView.Name = "ContentDataGridView"
        Me.ContentDataGridView.Size = New System.Drawing.Size(839, 647)
        Me.ContentDataGridView.TabIndex = 3
        '
        'IsCheckedDataGridViewCheckBoxColumn
        '
        Me.IsCheckedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IsCheckedDataGridViewCheckBoxColumn.DataPropertyName = "IsChecked"
        Me.IsCheckedDataGridViewCheckBoxColumn.HeaderText = ""
        Me.IsCheckedDataGridViewCheckBoxColumn.Name = "IsCheckedDataGridViewCheckBoxColumn"
        Me.IsCheckedDataGridViewCheckBoxColumn.Width = 5
        '
        'FilenameDataGridViewTextBoxColumn
        '
        Me.FilenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FilenameDataGridViewTextBoxColumn.DataPropertyName = "filename"
        Me.FilenameDataGridViewTextBoxColumn.HeaderText = "Game's filename"
        Me.FilenameDataGridViewTextBoxColumn.Name = "FilenameDataGridViewTextBoxColumn"
        Me.FilenameDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.DescriptionLabel.Size = New System.Drawing.Size(326, 16)
        Me.DescriptionLabel.TabIndex = 2
        Me.DescriptionLabel.Text = "Please select the games you want to scrap in the list bellow :"
        '
        '_6_RomsBuildScrapGamesSelectionControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ActionPanel)
        Me.Name = "_6_RomsBuildScrapGamesSelectionControl"
        Me.Size = New System.Drawing.Size(878, 727)
        Me.ActionPanel.ResumeLayout(False)
        Me.ActionPanel.PerformLayout()
        CType(Me.ContentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSRomsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RomsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ActionPanel As Panel
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents ContentDataGridView As DataGridView
    Friend WithEvents SSRomsBindingSource As BindingSource
    Friend WithEvents RomsDataSet As RomsDataSet
    Friend WithEvents IsCheckedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FilenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SelectAllCheckBox As CheckBox
End Class
