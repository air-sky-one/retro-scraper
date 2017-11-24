<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainConfigForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.ScraperProviderGroupBox = New System.Windows.Forms.GroupBox()
        Me.ScraperProviderComboBox = New System.Windows.Forms.ComboBox()
        Me.MainConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Configs = New retro_scraper.Configs()
        Me.ScraperAPIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScraperProviderLabel = New System.Windows.Forms.Label()
        Me.ScraperProviderGroupBox.SuspendLayout()
        CType(Me.MainConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Configs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScraperAPIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScraperProviderGroupBox
        '
        Me.ScraperProviderGroupBox.Controls.Add(Me.ScraperProviderComboBox)
        Me.ScraperProviderGroupBox.Controls.Add(Me.ScraperProviderLabel)
        Me.ScraperProviderGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.ScraperProviderGroupBox.Name = "ScraperProviderGroupBox"
        Me.ScraperProviderGroupBox.Size = New System.Drawing.Size(509, 100)
        Me.ScraperProviderGroupBox.TabIndex = 0
        Me.ScraperProviderGroupBox.TabStop = False
        Me.ScraperProviderGroupBox.Text = "Scraper Provider"
        '
        'ScraperProviderComboBox
        '
        Me.ScraperProviderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MainConfigBindingSource, "Scraper", True))
        Me.ScraperProviderComboBox.DataSource = Me.ScraperAPIBindingSource
        Me.ScraperProviderComboBox.DisplayMember = "ScraperName"
        Me.ScraperProviderComboBox.FormattingEnabled = True
        Me.ScraperProviderComboBox.Location = New System.Drawing.Point(126, 19)
        Me.ScraperProviderComboBox.Name = "ScraperProviderComboBox"
        Me.ScraperProviderComboBox.Size = New System.Drawing.Size(231, 21)
        Me.ScraperProviderComboBox.TabIndex = 1
        Me.ScraperProviderComboBox.ValueMember = "ScraperName"
        '
        'MainConfigBindingSource
        '
        Me.MainConfigBindingSource.DataMember = "MainConfig"
        Me.MainConfigBindingSource.DataSource = Me.Configs
        '
        'Configs
        '
        Me.Configs.DataSetName = "Configs"
        Me.Configs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ScraperAPIBindingSource
        '
        Me.ScraperAPIBindingSource.DataMember = "ScraperAPI"
        Me.ScraperAPIBindingSource.DataSource = Me.Configs
        '
        'ScraperProviderLabel
        '
        Me.ScraperProviderLabel.AutoSize = True
        Me.ScraperProviderLabel.Location = New System.Drawing.Point(6, 22)
        Me.ScraperProviderLabel.Name = "ScraperProviderLabel"
        Me.ScraperProviderLabel.Size = New System.Drawing.Size(114, 13)
        Me.ScraperProviderLabel.TabIndex = 0
        Me.ScraperProviderLabel.Text = "Used Scraper Provider"
        '
        'MainConfigForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 665)
        Me.Controls.Add(Me.ScraperProviderGroupBox)
        Me.Name = "MainConfigForm"
        Me.Text = "MainConfigForm"
        Me.ScraperProviderGroupBox.ResumeLayout(False)
        Me.ScraperProviderGroupBox.PerformLayout()
        CType(Me.MainConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Configs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScraperAPIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ScraperProviderGroupBox As GroupBox
    Friend WithEvents ScraperProviderComboBox As ComboBox
    Friend WithEvents ScraperProviderLabel As Label
    Friend WithEvents MainConfigBindingSource As BindingSource
    Friend WithEvents Configs As Configs
    Friend WithEvents ScraperAPIBindingSource As BindingSource
End Class
