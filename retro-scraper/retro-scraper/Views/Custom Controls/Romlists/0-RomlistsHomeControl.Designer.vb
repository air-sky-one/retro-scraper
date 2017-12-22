<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _0_RomlistsHomeControl
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
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.ChoiceFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.MergeRadioButton = New System.Windows.Forms.RadioButton()
        Me.RemoveRadioButton = New System.Windows.Forms.RadioButton()
        Me.AdjustRadioButton = New System.Windows.Forms.RadioButton()
        Me.CollectionRadioButton = New System.Windows.Forms.RadioButton()
        Me.ConfigFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.MergePanel = New System.Windows.Forms.Panel()
        Me.MergeFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.MergeFolderPathDescriptionLabel = New System.Windows.Forms.Label()
        Me.MergeFolderPathPanel = New System.Windows.Forms.Panel()
        Me.MergeFolderPathTextBox = New System.Windows.Forms.TextBox()
        Me.MergeFolderPathButton = New System.Windows.Forms.Button()
        Me.MergeFolderPathResultsLabel = New System.Windows.Forms.Label()
        Me.MergeChoiceResultFileFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.MergeNewFileRadioButton = New System.Windows.Forms.RadioButton()
        Me.MergeExistingFileRadioButton = New System.Windows.Forms.RadioButton()
        Me.MergeNewFilePanel = New System.Windows.Forms.Panel()
        Me.MergeNewFileDestinationFolderLabel = New System.Windows.Forms.Label()
        Me.MergeNewFileDestinationFolderTextBox = New System.Windows.Forms.TextBox()
        Me.MergeNewFileDestinationFolderButton = New System.Windows.Forms.Button()
        Me.MergeNewFileNameTextBox = New System.Windows.Forms.TextBox()
        Me.MergeNewFileNameLabel = New System.Windows.Forms.Label()
        Me.MergeExistingFilePanel = New System.Windows.Forms.Panel()
        Me.MergeExistingFileTextBox = New System.Windows.Forms.TextBox()
        Me.MergeExistingFileButton = New System.Windows.Forms.Button()
        Me.MergeExecuteButton = New System.Windows.Forms.Button()
        Me.MergeFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.MergeExistingFileOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.MergeErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ChoiceFlowLayoutPanel.SuspendLayout()
        Me.ConfigFlowLayoutPanel.SuspendLayout()
        Me.MergePanel.SuspendLayout()
        Me.MergeFlowLayoutPanel.SuspendLayout()
        Me.MergeFolderPathPanel.SuspendLayout()
        Me.MergeChoiceResultFileFlowLayoutPanel.SuspendLayout()
        Me.MergeNewFilePanel.SuspendLayout()
        Me.MergeExistingFilePanel.SuspendLayout()
        CType(Me.MergeErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(20, 20)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(413, 80)
        Me.DescriptionLabel.TabIndex = 2
        Me.DescriptionLabel.Text = "This section allows to (re)work your Romlitst files. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You will have to follow " &
    "a few steps. Let's the soft guide you. Good (re)work !" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please choose your act" &
    "ion :"
        '
        'ChoiceFlowLayoutPanel
        '
        Me.ChoiceFlowLayoutPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChoiceFlowLayoutPanel.Controls.Add(Me.MergeRadioButton)
        Me.ChoiceFlowLayoutPanel.Controls.Add(Me.RemoveRadioButton)
        Me.ChoiceFlowLayoutPanel.Controls.Add(Me.AdjustRadioButton)
        Me.ChoiceFlowLayoutPanel.Controls.Add(Me.CollectionRadioButton)
        Me.ChoiceFlowLayoutPanel.Location = New System.Drawing.Point(23, 103)
        Me.ChoiceFlowLayoutPanel.Name = "ChoiceFlowLayoutPanel"
        Me.ChoiceFlowLayoutPanel.Size = New System.Drawing.Size(855, 27)
        Me.ChoiceFlowLayoutPanel.TabIndex = 3
        '
        'MergeRadioButton
        '
        Me.MergeRadioButton.AutoSize = True
        Me.MergeRadioButton.Checked = True
        Me.MergeRadioButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MergeRadioButton.Location = New System.Drawing.Point(3, 3)
        Me.MergeRadioButton.Name = "MergeRadioButton"
        Me.MergeRadioButton.Size = New System.Drawing.Size(161, 20)
        Me.MergeRadioButton.TabIndex = 0
        Me.MergeRadioButton.TabStop = True
        Me.MergeRadioButton.Text = "Merge several romlist files"
        Me.MergeRadioButton.UseVisualStyleBackColor = True
        '
        'RemoveRadioButton
        '
        Me.RemoveRadioButton.AutoSize = True
        Me.RemoveRadioButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveRadioButton.Location = New System.Drawing.Point(170, 3)
        Me.RemoveRadioButton.Name = "RemoveRadioButton"
        Me.RemoveRadioButton.Size = New System.Drawing.Size(241, 20)
        Me.RemoveRadioButton.TabIndex = 3
        Me.RemoveRadioButton.TabStop = True
        Me.RemoveRadioButton.Text = "Remove duplicate content in a romlist file"
        Me.RemoveRadioButton.UseVisualStyleBackColor = True
        '
        'AdjustRadioButton
        '
        Me.AdjustRadioButton.AutoSize = True
        Me.AdjustRadioButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdjustRadioButton.Location = New System.Drawing.Point(417, 3)
        Me.AdjustRadioButton.Name = "AdjustRadioButton"
        Me.AdjustRadioButton.Size = New System.Drawing.Size(126, 20)
        Me.AdjustRadioButton.TabIndex = 2
        Me.AdjustRadioButton.TabStop = True
        Me.AdjustRadioButton.Text = "Adjust a romlist file"
        Me.AdjustRadioButton.UseVisualStyleBackColor = True
        '
        'CollectionRadioButton
        '
        Me.CollectionRadioButton.AutoSize = True
        Me.CollectionRadioButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CollectionRadioButton.Location = New System.Drawing.Point(549, 3)
        Me.CollectionRadioButton.Name = "CollectionRadioButton"
        Me.CollectionRadioButton.Size = New System.Drawing.Size(216, 20)
        Me.CollectionRadioButton.TabIndex = 1
        Me.CollectionRadioButton.TabStop = True
        Me.CollectionRadioButton.Text = "Create a collection from a romlist file"
        Me.CollectionRadioButton.UseVisualStyleBackColor = True
        '
        'ConfigFlowLayoutPanel
        '
        Me.ConfigFlowLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConfigFlowLayoutPanel.Controls.Add(Me.MergePanel)
        Me.ConfigFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.ConfigFlowLayoutPanel.Location = New System.Drawing.Point(23, 132)
        Me.ConfigFlowLayoutPanel.Name = "ConfigFlowLayoutPanel"
        Me.ConfigFlowLayoutPanel.Size = New System.Drawing.Size(855, 595)
        Me.ConfigFlowLayoutPanel.TabIndex = 4
        '
        'MergePanel
        '
        Me.MergePanel.Controls.Add(Me.MergeFlowLayoutPanel)
        Me.MergePanel.Location = New System.Drawing.Point(0, 0)
        Me.MergePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MergePanel.Name = "MergePanel"
        Me.MergePanel.Size = New System.Drawing.Size(849, 196)
        Me.MergePanel.TabIndex = 0
        '
        'MergeFlowLayoutPanel
        '
        Me.MergeFlowLayoutPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MergeFlowLayoutPanel.Controls.Add(Me.MergeFolderPathDescriptionLabel)
        Me.MergeFlowLayoutPanel.Controls.Add(Me.MergeFolderPathPanel)
        Me.MergeFlowLayoutPanel.Controls.Add(Me.MergeChoiceResultFileFlowLayoutPanel)
        Me.MergeFlowLayoutPanel.Controls.Add(Me.MergeNewFilePanel)
        Me.MergeFlowLayoutPanel.Controls.Add(Me.MergeExistingFilePanel)
        Me.MergeFlowLayoutPanel.Controls.Add(Me.MergeExecuteButton)
        Me.MergeFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.MergeFlowLayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.MergeFlowLayoutPanel.Name = "MergeFlowLayoutPanel"
        Me.MergeFlowLayoutPanel.Size = New System.Drawing.Size(846, 192)
        Me.MergeFlowLayoutPanel.TabIndex = 17
        '
        'MergeFolderPathDescriptionLabel
        '
        Me.MergeFolderPathDescriptionLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MergeFolderPathDescriptionLabel.AutoSize = True
        Me.MergeFolderPathDescriptionLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MergeFolderPathDescriptionLabel.Location = New System.Drawing.Point(3, 0)
        Me.MergeFolderPathDescriptionLabel.Name = "MergeFolderPathDescriptionLabel"
        Me.MergeFolderPathDescriptionLabel.Size = New System.Drawing.Size(565, 16)
        Me.MergeFolderPathDescriptionLabel.TabIndex = 5
        Me.MergeFolderPathDescriptionLabel.Text = "Select the folder containing the romlist files you want to merge in a new one or " &
    "to merge to an existing one"
        '
        'MergeFolderPathPanel
        '
        Me.MergeFolderPathPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MergeFolderPathPanel.Controls.Add(Me.MergeFolderPathTextBox)
        Me.MergeFolderPathPanel.Controls.Add(Me.MergeFolderPathButton)
        Me.MergeFolderPathPanel.Controls.Add(Me.MergeFolderPathResultsLabel)
        Me.MergeFolderPathPanel.Location = New System.Drawing.Point(0, 16)
        Me.MergeFolderPathPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MergeFolderPathPanel.Name = "MergeFolderPathPanel"
        Me.MergeFolderPathPanel.Size = New System.Drawing.Size(571, 47)
        Me.MergeFolderPathPanel.TabIndex = 6
        '
        'MergeFolderPathTextBox
        '
        Me.MergeFolderPathTextBox.Location = New System.Drawing.Point(3, 3)
        Me.MergeFolderPathTextBox.Name = "MergeFolderPathTextBox"
        Me.MergeFolderPathTextBox.ReadOnly = True
        Me.MergeFolderPathTextBox.Size = New System.Drawing.Size(393, 20)
        Me.MergeFolderPathTextBox.TabIndex = 10
        '
        'MergeFolderPathButton
        '
        Me.MergeFolderPathButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MergeFolderPathButton.Location = New System.Drawing.Point(399, 2)
        Me.MergeFolderPathButton.Margin = New System.Windows.Forms.Padding(0)
        Me.MergeFolderPathButton.Name = "MergeFolderPathButton"
        Me.MergeFolderPathButton.Size = New System.Drawing.Size(25, 20)
        Me.MergeFolderPathButton.TabIndex = 11
        Me.MergeFolderPathButton.Text = "..."
        Me.MergeFolderPathButton.UseVisualStyleBackColor = True
        '
        'MergeFolderPathResultsLabel
        '
        Me.MergeFolderPathResultsLabel.AutoSize = True
        Me.MergeFolderPathResultsLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MergeFolderPathResultsLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MergeFolderPathResultsLabel.Location = New System.Drawing.Point(6, 26)
        Me.MergeFolderPathResultsLabel.Name = "MergeFolderPathResultsLabel"
        Me.MergeFolderPathResultsLabel.Size = New System.Drawing.Size(135, 16)
        Me.MergeFolderPathResultsLabel.TabIndex = 9
        Me.MergeFolderPathResultsLabel.Text = "X roms where detected in Y"
        Me.MergeFolderPathResultsLabel.Visible = False
        '
        'MergeChoiceResultFileFlowLayoutPanel
        '
        Me.MergeChoiceResultFileFlowLayoutPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MergeChoiceResultFileFlowLayoutPanel.Controls.Add(Me.MergeNewFileRadioButton)
        Me.MergeChoiceResultFileFlowLayoutPanel.Controls.Add(Me.MergeExistingFileRadioButton)
        Me.MergeChoiceResultFileFlowLayoutPanel.Location = New System.Drawing.Point(0, 63)
        Me.MergeChoiceResultFileFlowLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MergeChoiceResultFileFlowLayoutPanel.Name = "MergeChoiceResultFileFlowLayoutPanel"
        Me.MergeChoiceResultFileFlowLayoutPanel.Size = New System.Drawing.Size(571, 26)
        Me.MergeChoiceResultFileFlowLayoutPanel.TabIndex = 7
        Me.MergeChoiceResultFileFlowLayoutPanel.Visible = False
        '
        'MergeNewFileRadioButton
        '
        Me.MergeNewFileRadioButton.AutoSize = True
        Me.MergeNewFileRadioButton.Checked = True
        Me.MergeNewFileRadioButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MergeNewFileRadioButton.Location = New System.Drawing.Point(3, 3)
        Me.MergeNewFileRadioButton.Name = "MergeNewFileRadioButton"
        Me.MergeNewFileRadioButton.Size = New System.Drawing.Size(114, 20)
        Me.MergeNewFileRadioButton.TabIndex = 12
        Me.MergeNewFileRadioButton.TabStop = True
        Me.MergeNewFileRadioButton.Text = "Create a new file"
        Me.MergeNewFileRadioButton.UseVisualStyleBackColor = True
        '
        'MergeExistingFileRadioButton
        '
        Me.MergeExistingFileRadioButton.AutoSize = True
        Me.MergeExistingFileRadioButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MergeExistingFileRadioButton.Location = New System.Drawing.Point(123, 3)
        Me.MergeExistingFileRadioButton.Name = "MergeExistingFileRadioButton"
        Me.MergeExistingFileRadioButton.Size = New System.Drawing.Size(238, 20)
        Me.MergeExistingFileRadioButton.TabIndex = 13
        Me.MergeExistingFileRadioButton.Text = "Merge the result in an existing romlist file"
        Me.MergeExistingFileRadioButton.UseVisualStyleBackColor = True
        '
        'MergeNewFilePanel
        '
        Me.MergeNewFilePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MergeNewFilePanel.Controls.Add(Me.MergeNewFileDestinationFolderLabel)
        Me.MergeNewFilePanel.Controls.Add(Me.MergeNewFileDestinationFolderTextBox)
        Me.MergeNewFilePanel.Controls.Add(Me.MergeNewFileDestinationFolderButton)
        Me.MergeNewFilePanel.Controls.Add(Me.MergeNewFileNameTextBox)
        Me.MergeNewFilePanel.Controls.Add(Me.MergeNewFileNameLabel)
        Me.MergeNewFilePanel.Location = New System.Drawing.Point(0, 89)
        Me.MergeNewFilePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MergeNewFilePanel.Name = "MergeNewFilePanel"
        Me.MergeNewFilePanel.Size = New System.Drawing.Size(571, 54)
        Me.MergeNewFilePanel.TabIndex = 9
        Me.MergeNewFilePanel.Visible = False
        '
        'MergeNewFileDestinationFolderLabel
        '
        Me.MergeNewFileDestinationFolderLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MergeNewFileDestinationFolderLabel.AutoSize = True
        Me.MergeNewFileDestinationFolderLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MergeNewFileDestinationFolderLabel.Location = New System.Drawing.Point(3, 31)
        Me.MergeNewFileDestinationFolderLabel.Name = "MergeNewFileDestinationFolderLabel"
        Me.MergeNewFileDestinationFolderLabel.Size = New System.Drawing.Size(104, 16)
        Me.MergeNewFileDestinationFolderLabel.TabIndex = 14
        Me.MergeNewFileDestinationFolderLabel.Text = "Destination Folder"
        '
        'MergeNewFileDestinationFolderTextBox
        '
        Me.MergeNewFileDestinationFolderTextBox.Location = New System.Drawing.Point(113, 29)
        Me.MergeNewFileDestinationFolderTextBox.Name = "MergeNewFileDestinationFolderTextBox"
        Me.MergeNewFileDestinationFolderTextBox.ReadOnly = True
        Me.MergeNewFileDestinationFolderTextBox.Size = New System.Drawing.Size(283, 20)
        Me.MergeNewFileDestinationFolderTextBox.TabIndex = 12
        '
        'MergeNewFileDestinationFolderButton
        '
        Me.MergeNewFileDestinationFolderButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MergeNewFileDestinationFolderButton.Location = New System.Drawing.Point(399, 28)
        Me.MergeNewFileDestinationFolderButton.Margin = New System.Windows.Forms.Padding(0)
        Me.MergeNewFileDestinationFolderButton.Name = "MergeNewFileDestinationFolderButton"
        Me.MergeNewFileDestinationFolderButton.Size = New System.Drawing.Size(25, 20)
        Me.MergeNewFileDestinationFolderButton.TabIndex = 13
        Me.MergeNewFileDestinationFolderButton.Text = "..."
        Me.MergeNewFileDestinationFolderButton.UseVisualStyleBackColor = True
        '
        'MergeNewFileNameTextBox
        '
        Me.MergeNewFileNameTextBox.Location = New System.Drawing.Point(229, 3)
        Me.MergeNewFileNameTextBox.Name = "MergeNewFileNameTextBox"
        Me.MergeNewFileNameTextBox.Size = New System.Drawing.Size(195, 20)
        Me.MergeNewFileNameTextBox.TabIndex = 11
        '
        'MergeNewFileNameLabel
        '
        Me.MergeNewFileNameLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MergeNewFileNameLabel.AutoSize = True
        Me.MergeNewFileNameLabel.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MergeNewFileNameLabel.Location = New System.Drawing.Point(3, 4)
        Me.MergeNewFileNameLabel.Name = "MergeNewFileNameLabel"
        Me.MergeNewFileNameLabel.Size = New System.Drawing.Size(220, 16)
        Me.MergeNewFileNameLabel.TabIndex = 10
        Me.MergeNewFileNameLabel.Text = "Name of the new file (without extension)"
        '
        'MergeExistingFilePanel
        '
        Me.MergeExistingFilePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MergeExistingFilePanel.Controls.Add(Me.MergeExistingFileTextBox)
        Me.MergeExistingFilePanel.Controls.Add(Me.MergeExistingFileButton)
        Me.MergeExistingFilePanel.Location = New System.Drawing.Point(0, 143)
        Me.MergeExistingFilePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MergeExistingFilePanel.Name = "MergeExistingFilePanel"
        Me.MergeExistingFilePanel.Size = New System.Drawing.Size(571, 26)
        Me.MergeExistingFilePanel.TabIndex = 8
        Me.MergeExistingFilePanel.Visible = False
        '
        'MergeExistingFileTextBox
        '
        Me.MergeExistingFileTextBox.Location = New System.Drawing.Point(3, 3)
        Me.MergeExistingFileTextBox.Name = "MergeExistingFileTextBox"
        Me.MergeExistingFileTextBox.ReadOnly = True
        Me.MergeExistingFileTextBox.Size = New System.Drawing.Size(393, 20)
        Me.MergeExistingFileTextBox.TabIndex = 14
        '
        'MergeExistingFileButton
        '
        Me.MergeExistingFileButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MergeExistingFileButton.Location = New System.Drawing.Point(399, 2)
        Me.MergeExistingFileButton.Margin = New System.Windows.Forms.Padding(0)
        Me.MergeExistingFileButton.Name = "MergeExistingFileButton"
        Me.MergeExistingFileButton.Size = New System.Drawing.Size(25, 20)
        Me.MergeExistingFileButton.TabIndex = 15
        Me.MergeExistingFileButton.Text = "..."
        Me.MergeExistingFileButton.UseVisualStyleBackColor = True
        '
        'MergeExecuteButton
        '
        Me.MergeExecuteButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MergeExecuteButton.Location = New System.Drawing.Point(0, 169)
        Me.MergeExecuteButton.Margin = New System.Windows.Forms.Padding(0)
        Me.MergeExecuteButton.Name = "MergeExecuteButton"
        Me.MergeExecuteButton.Size = New System.Drawing.Size(114, 21)
        Me.MergeExecuteButton.TabIndex = 16
        Me.MergeExecuteButton.Text = "Execute"
        Me.MergeExecuteButton.UseVisualStyleBackColor = True
        Me.MergeExecuteButton.Visible = False
        '
        'MergeExistingFileOpenFileDialog
        '
        Me.MergeExistingFileOpenFileDialog.FileName = "romlist.txt"
        '
        'MergeErrorProvider
        '
        Me.MergeErrorProvider.ContainerControl = Me
        '
        '_0_RomlistsHomeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ConfigFlowLayoutPanel)
        Me.Controls.Add(Me.ChoiceFlowLayoutPanel)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Name = "_0_RomlistsHomeControl"
        Me.Size = New System.Drawing.Size(878, 727)
        Me.ChoiceFlowLayoutPanel.ResumeLayout(False)
        Me.ChoiceFlowLayoutPanel.PerformLayout()
        Me.ConfigFlowLayoutPanel.ResumeLayout(False)
        Me.MergePanel.ResumeLayout(False)
        Me.MergeFlowLayoutPanel.ResumeLayout(False)
        Me.MergeFlowLayoutPanel.PerformLayout()
        Me.MergeFolderPathPanel.ResumeLayout(False)
        Me.MergeFolderPathPanel.PerformLayout()
        Me.MergeChoiceResultFileFlowLayoutPanel.ResumeLayout(False)
        Me.MergeChoiceResultFileFlowLayoutPanel.PerformLayout()
        Me.MergeNewFilePanel.ResumeLayout(False)
        Me.MergeNewFilePanel.PerformLayout()
        Me.MergeExistingFilePanel.ResumeLayout(False)
        Me.MergeExistingFilePanel.PerformLayout()
        CType(Me.MergeErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents ChoiceFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents MergeRadioButton As RadioButton
    Friend WithEvents AdjustRadioButton As RadioButton
    Friend WithEvents CollectionRadioButton As RadioButton
    Friend WithEvents ConfigFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents MergePanel As Panel
    Friend WithEvents MergeFolderPathDescriptionLabel As Label
    Friend WithEvents MergeFolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents MergeFolderPathButton As Button
    Friend WithEvents MergeFolderPathTextBox As TextBox
    Friend WithEvents MergeFolderPathResultsLabel As Label
    Friend WithEvents RemoveRadioButton As RadioButton
    Friend WithEvents MergeExecuteButton As Button
    Friend WithEvents MergeExistingFileButton As Button
    Friend WithEvents MergeExistingFileTextBox As TextBox
    Friend WithEvents MergeExistingFileRadioButton As RadioButton
    Friend WithEvents MergeNewFileRadioButton As RadioButton
    Friend WithEvents MergeExistingFileOpenFileDialog As OpenFileDialog
    Friend WithEvents MergeErrorProvider As ErrorProvider
    Friend WithEvents MergeFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents MergeFolderPathPanel As Panel
    Friend WithEvents MergeChoiceResultFileFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents MergeExistingFilePanel As Panel
    Friend WithEvents MergeNewFilePanel As Panel
    Friend WithEvents MergeNewFileDestinationFolderLabel As Label
    Friend WithEvents MergeNewFileDestinationFolderTextBox As TextBox
    Friend WithEvents MergeNewFileDestinationFolderButton As Button
    Friend WithEvents MergeNewFileNameTextBox As TextBox
    Friend WithEvents MergeNewFileNameLabel As Label
End Class
