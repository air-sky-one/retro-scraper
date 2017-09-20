Public Class _10_RomsBuildScrapArtworksControl

    ''' <summary>
    ''' Parent con tainer control
    ''' </summary>
    Private _parent As RomsContainerControl

    ''' <summary>
    ''' Datagrids
    ''' </summary>
    Private _contentDatagrids As New List(Of DataGridView)
    Public Property Datagrids() As List(Of DataGridView)
        Get
            Return Me._contentDatagrids
        End Get
        Set(ByVal value As List(Of DataGridView))
            Me._contentDatagrids = value
        End Set
    End Property

    ''' <summary>
    ''' Component initialization
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _10_RomsBuildScrapArtworksControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me._parent = TryCast(Me.Parent.Parent, RomsContainerControl)

            If Me._parent Is Nothing Then Throw New Exception("Unexpected error")

            Me.ActionFlowLayoutPanel.SuspendLayout()
            Me.SuspendLayout()

            ' TODO : à mettre sous forme de fonction ?
            For Each artType As RomsDataSet.ArtworksRow In Me._parent.RomsArtworks
                ' data
#Region "data"
                Dim mediaTypes As New List(Of String)
                mediaTypes.Add("Screenshots")
                mediaTypes.Add("Fanarts")
                mediaTypes.Add("Video")
                mediaTypes.Add("Screenshots")
                mediaTypes.Add("Wheels")
                mediaTypes.Add("Carbon Wheels")
                mediaTypes.Add("Steel Wheels")
                mediaTypes.Add("Box Textures (all sides of the jacket")
                mediaTypes.Add("Box 2D (Front side of the jacket)")
                mediaTypes.Add("Box 2D Side")
                mediaTypes.Add("Box 2D Back")
                mediaTypes.Add("Box 3D")
                mediaTypes.Add("Support Texture (Cartridge label)")
                mediaTypes.Add("Support 2D (Cartridge)")
#End Region

                ' Declarations
#Region "declarations"
                Dim components As New ComponentModel.Container()

                '*********************
                Dim mainContent As New FlowLayoutPanel

                Dim headerPanel As New FlowLayoutPanel
                Dim collapseButton As New Button
                Dim titleLabel As New Label
                '*********************

                Dim contentFlowPanel As New FlowLayoutPanel
                Dim descriptionLabel As New Label
                Dim mediaTypeSelectComboBox As New ComboBox

                Dim selectAllFlowLayoutPanel As New FlowLayoutPanel

#Region "declarations : checkbox selectAll"
                Dim ckScreenShotInGame As New CheckBox
                Dim ckScreenShotTitle As New CheckBox
                Dim ckFanart As New CheckBox
                Dim ckVideo As New CheckBox
                Dim ckWheelUS As New CheckBox
                Dim ckWheelJP As New CheckBox
                Dim ckWheelWOR As New CheckBox
                Dim ckWheelCarbonUS As New CheckBox
                Dim ckWheelCarbonJP As New CheckBox
                Dim ckWheelCarbonWOR As New CheckBox
                Dim ckWheelSteelUS As New CheckBox
                Dim ckWheelSteelJP As New CheckBox
                Dim ckWheelSteelWOR As New CheckBox
                Dim ckBoxTextureUS As New CheckBox
                Dim ckBoxTextureJP As New CheckBox
                Dim ckBoxTextureEU As New CheckBox
                Dim ckBox2dUS As New CheckBox
                Dim ckBox2dJP As New CheckBox
                Dim ckBox2dEU As New CheckBox
                Dim ckBox2dSideUS As New CheckBox
                Dim ckBox2dSideJP As New CheckBox
                Dim ckBox2dSideEU As New CheckBox
                Dim ckBox2dBackUS As New CheckBox
                Dim ckBox2dBackJP As New CheckBox
                Dim ckBox2dBackEU As New CheckBox
                Dim ckBox3dUS As New CheckBox
                Dim ckBox3dJP As New CheckBox
                Dim ckBox3dEU As New CheckBox
                Dim ckSupportTextureUS As New CheckBox
                Dim ckSupportTextureJP As New CheckBox
                Dim ckSupportTextureEU As New CheckBox
                Dim ckSupport2dUS As New CheckBox
                Dim ckSupport2dJP As New CheckBox
                Dim ckSupport2dEU As New CheckBox
#End Region

#Region "declarations : dataGridViewColumns"
                Dim filenameDataGridViewTextBoxColumn As New DataGridViewTextBoxColumn
                Dim isScreenShotInGameDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isScreenShotTitleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isFanartDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isVideoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isWheelUSDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isWheelJPDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isWheelWORDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isWheelCarbonUSDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isWheelCarbonJPDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isWheelCarbonWORDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isWheelSteelUSDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isWheelSteelJPDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isWheelSteelWORDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isBoxTextureUSDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isBoxTextureJPDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isBoxTextureEUDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isBox2dUSDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isBox2dJPDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isBox2dEUDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isBox2dSideUSDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isBox2dSideJPDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isBox2dSideEUDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isBox2dBackUSDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isBox2dBackJPDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isBox2dBackEUDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isBox3dUSDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isBox3dJPDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isBox3dEUDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isSupportTextureUSDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isSupportTextureJPDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isSupportTextureEUDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isSupport2dUSDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isSupport2dJPDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
                Dim isSupport2dEUDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
#End Region

                Dim b As New BindingSource(components)
                Dim g As New DataGridView
                Dim data As New RomsDataSet
#End Region

                Me._contentDatagrids.Add(g)

                mainContent.SuspendLayout()
                headerPanel.SuspendLayout()

                contentFlowPanel.SuspendLayout()
                mediaTypeSelectComboBox.SuspendLayout()
                selectAllFlowLayoutPanel.SuspendLayout()
                CType(g, System.ComponentModel.ISupportInitialize).BeginInit()
                CType(b, System.ComponentModel.ISupportInitialize).BeginInit()
                CType(data, System.ComponentModel.ISupportInitialize).BeginInit()
                Me.SuspendLayout()

                '
                'MainPanel
                '
                mainContent.FlowDirection = FlowDirection.TopDown
                mainContent.Controls.Add(headerPanel)
                mainContent.Controls.Add(contentFlowPanel)
                mainContent.Font = ReturnFont()
                mainContent.Location = New Point(0, 0)
                mainContent.Margin = New Padding(0)
                mainContent.Name = artType.Name & "MainPanel"
                mainContent.AutoSize = True
                '
                'HeaderPanel
                '
                headerPanel.FlowDirection = FlowDirection.LeftToRight
                headerPanel.Controls.Add(collapseButton)
                headerPanel.Controls.Add(titleLabel)
                headerPanel.Name = artType.Name & "HeaderPanel"
                headerPanel.AutoSize = True
                '  headerPanel.BackColor = Color.DarkGray
                '
                'CollapseButton
                '
                collapseButton.FlatAppearance.BorderSize = 0
                collapseButton.FlatStyle = FlatStyle.Flat
                collapseButton.ImageList = Me.CollaspeImageList
                collapseButton.Name = artType.Name & "CollapseButton"
                collapseButton.Size = New Size(25, 25)
                collapseButton.UseVisualStyleBackColor = True
                collapseButton.Tag = "expand"
                collapseButton.Image = Me.CollaspeImageList.Images(0)
                AddHandler collapseButton.Click, AddressOf CollapseButton_Click
                '
                'TitleLabel
                '
                titleLabel.AutoSize = True
                titleLabel.Font = ReturnHeaderFont()
                titleLabel.Name = artType.Name & "TitleLabel"
                titleLabel.Text = artType.Name
                titleLabel.Margin = New Padding(5)
                '
                'ActionPanel
                '
                contentFlowPanel.FlowDirection = FlowDirection.TopDown
                contentFlowPanel.Controls.Add(descriptionLabel)
                contentFlowPanel.Controls.Add(mediaTypeSelectComboBox)
                contentFlowPanel.Controls.Add(selectAllFlowLayoutPanel)
                contentFlowPanel.Controls.Add(g)
                contentFlowPanel.Font = ReturnFont()
                contentFlowPanel.Location = New Point(0, 0)
                contentFlowPanel.Margin = New Padding(0)
                contentFlowPanel.Name = artType.Name & "ActionPanel"
                contentFlowPanel.AutoSize = True
                'contentFlowPanel.Size = New Size(878, 350)
                '
                'CheckboxFlowLayoutPanel
                '
                selectAllFlowLayoutPanel.Controls.Add(ckScreenShotInGame)
                selectAllFlowLayoutPanel.Controls.Add(ckScreenShotTitle)
                selectAllFlowLayoutPanel.Controls.Add(ckFanart)
                selectAllFlowLayoutPanel.Controls.Add(ckVideo)
                selectAllFlowLayoutPanel.Controls.Add(ckWheelUS)
                selectAllFlowLayoutPanel.Controls.Add(ckWheelJP)
                selectAllFlowLayoutPanel.Controls.Add(ckWheelWOR)
                selectAllFlowLayoutPanel.Controls.Add(ckWheelCarbonUS)
                selectAllFlowLayoutPanel.Controls.Add(ckWheelCarbonJP)
                selectAllFlowLayoutPanel.Controls.Add(ckWheelCarbonWOR)
                selectAllFlowLayoutPanel.Controls.Add(ckWheelSteelUS)
                selectAllFlowLayoutPanel.Controls.Add(ckWheelSteelJP)
                selectAllFlowLayoutPanel.Controls.Add(ckWheelSteelWOR)
                selectAllFlowLayoutPanel.Controls.Add(ckBoxTextureUS)
                selectAllFlowLayoutPanel.Controls.Add(ckBoxTextureJP)
                selectAllFlowLayoutPanel.Controls.Add(ckBoxTextureEU)
                selectAllFlowLayoutPanel.Controls.Add(ckBox2dUS)
                selectAllFlowLayoutPanel.Controls.Add(ckBox2dJP)
                selectAllFlowLayoutPanel.Controls.Add(ckBox2dEU)
                selectAllFlowLayoutPanel.Controls.Add(ckBox2dSideUS)
                selectAllFlowLayoutPanel.Controls.Add(ckBox2dSideJP)
                selectAllFlowLayoutPanel.Controls.Add(ckBox2dSideEU)
                selectAllFlowLayoutPanel.Controls.Add(ckBox2dBackUS)
                selectAllFlowLayoutPanel.Controls.Add(ckBox2dBackJP)
                selectAllFlowLayoutPanel.Controls.Add(ckBox2dBackEU)
                selectAllFlowLayoutPanel.Controls.Add(ckBox3dUS)
                selectAllFlowLayoutPanel.Controls.Add(ckBox3dJP)
                selectAllFlowLayoutPanel.Controls.Add(ckBox3dEU)
                selectAllFlowLayoutPanel.Controls.Add(ckSupportTextureUS)
                selectAllFlowLayoutPanel.Controls.Add(ckSupportTextureJP)
                selectAllFlowLayoutPanel.Controls.Add(ckSupportTextureEU)
                selectAllFlowLayoutPanel.Controls.Add(ckSupport2dUS)
                selectAllFlowLayoutPanel.Controls.Add(ckSupport2dJP)
                selectAllFlowLayoutPanel.Controls.Add(ckSupport2dEU)
                selectAllFlowLayoutPanel.Location = New Point(20, 35)
                selectAllFlowLayoutPanel.Margin = New Padding(0)
                selectAllFlowLayoutPanel.Name = artType.Name & "CheckboxFlowLayoutPanel"
                selectAllFlowLayoutPanel.AutoSize = True
                '
                'SelectArtTypeComboBox
                '
                mediaTypeSelectComboBox.BackColor = Color.White
                mediaTypeSelectComboBox.DropDownStyle = ComboBoxStyle.DropDownList
                mediaTypeSelectComboBox.Font = ReturnFont()
                mediaTypeSelectComboBox.FormattingEnabled = True
                mediaTypeSelectComboBox.AutoSize = True
                mediaTypeSelectComboBox.Size = New Size(288, 24)
                mediaTypeSelectComboBox.Location = New Point(20, 38)
                mediaTypeSelectComboBox.Name = artType.Name & "SelectArtTypeComboBox"
                mediaTypeSelectComboBox.Text = "Please select the associated type of available Artwork for " & artType.Name
                mediaTypeSelectComboBox.DataSource = mediaTypes
                AddHandler mediaTypeSelectComboBox.SelectedIndexChanged, AddressOf mediaTypeSelectComboBox_SelectedIndexChanged
                '
                'SelectAllScreenShotInGameCheckBox
                '
                ckScreenShotInGame.AutoSize = True
                ckScreenShotInGame.Name = artType.Name & "SelectAllScreenShotInGameCheckBox"
                ckScreenShotInGame.Text = "Select in game screenshots for all games"
                '
                'SelectAllScreenShotTitleCheckBox
                '
                ckScreenShotTitle.AutoSize = True
                ckScreenShotTitle.Name = artType.Name & "SelectAllScreenShotTitleCheckBox"
                ckScreenShotTitle.Text = "Select title screenshots for all games"
                '
                'SelectAllFanartCheckBox
                '
                ckFanart.AutoSize = True
                ckFanart.Name = artType.Name & "SelectAllFanartCheckBox"
                ckFanart.Text = "Select fanarts for all games"
                '
                'SelectAllVideoCheckBox
                '
                ckVideo.AutoSize = True
                ckVideo.Name = artType.Name & "SelectAllVideoCheckBox"
                ckVideo.Text = "Select video for all games"
                '
                'SelectAllWheelUSCheckBox
                '
                ckWheelUS.AutoSize = True
                ckWheelUS.Name = artType.Name & "SelectAllWheelUSCheckBox"
                ckWheelUS.Text = "Select US wheels for all games"
                '
                'SelectAllWheelJPCheckBox
                '
                ckWheelJP.AutoSize = True
                ckWheelJP.Name = artType.Name & "SelectAllWheelJPCheckBox"
                ckWheelJP.Text = "Select JP wheels for all games"
                '
                'SelectAllWheelWORCheckBox
                '
                ckWheelWOR.AutoSize = True
                ckWheelWOR.Name = artType.Name & "SelectAllWheelWORCheckBox"
                ckWheelWOR.Text = "Select WORLD wheels for all games"
                '
                'SelectAllCarbonWheelUSCheckBox
                '
                ckWheelCarbonUS.AutoSize = True
                ckWheelCarbonUS.Name = artType.Name & "SelectAllCarbonWheelUSCheckBox"
                ckWheelCarbonUS.Text = "Select US carbon wheels for all games"
                '
                'SelectAllCarbonWheelJPCheckBox
                '
                ckWheelCarbonJP.AutoSize = True
                ckWheelCarbonJP.Name = artType.Name & "SelectAllCarbonWheelJPCheckBox"
                ckWheelCarbonJP.Text = "Select JP carbon wheels for all games"
                '
                'SelectAllCarbonWheelWORCheckBox
                '
                ckWheelCarbonWOR.AutoSize = True
                ckWheelCarbonWOR.Name = artType.Name & "SelectAllCarbonWheelWORCheckBox"
                ckWheelCarbonWOR.Text = "Select WORLD carbon wheels for all games"
                '
                'SelectAllSteelWheelUSCheckBox
                '
                ckWheelSteelUS.AutoSize = True
                ckWheelSteelUS.Name = artType.Name & "SelectAllSteelWheelUSCheckBox"
                ckWheelSteelUS.Text = "Select US steel wheels for all games"
                '
                'SelectAllSteelWheelJPCheckBox
                '
                ckWheelSteelJP.AutoSize = True
                ckWheelSteelJP.Name = artType.Name & "SelectAllSteelWheelJPCheckBox"
                ckWheelSteelJP.Text = "Select JP steel wheels for all games"
                '
                'SelectAllSteelWheelWORCheckBox
                '
                ckWheelSteelWOR.AutoSize = True
                ckWheelSteelWOR.Name = artType.Name & "SelectAllSteelWheelWORCheckBox"
                ckWheelSteelWOR.Text = "Select WORLD steel wheels for all games"
                '
                'SelectAllBoxTextureUSCheckBox
                '
                ckBoxTextureUS.AutoSize = True
                ckBoxTextureUS.Name = artType.Name & "SelectAllBoxTextureUSCheckBox"
                ckBoxTextureUS.Text = "Select US box texture for all games"
                '
                'SelectAllBoxTextureJPCheckBox
                '
                ckBoxTextureJP.AutoSize = True
                ckBoxTextureJP.Name = artType.Name & "SelectAllBoxTextureJPCheckBox"
                ckBoxTextureJP.Text = "Select JP box texture for all games"
                '
                'SelectAllBoxTextureEUCheckBox
                '
                ckBoxTextureEU.AutoSize = True
                ckBoxTextureEU.Name = artType.Name & "SelectAllBoxTextureEUCheckBox"
                ckBoxTextureEU.Text = "Select EU box texture for all games"
                '
                'SelectAllBox2dUSCheckBox
                '
                ckBox2dUS.AutoSize = True
                ckBox2dUS.Name = artType.Name & "SelectAllBox2dUSCheckBox"
                ckBox2dUS.Text = "Select US box 2d for all games"
                '
                'SelectAllBox2dJPCheckBox
                '
                ckBox2dJP.AutoSize = True
                ckBox2dJP.Name = artType.Name & "SelectAllBox2dJPCheckBox"
                ckBox2dJP.Text = "Select JP box 2d for all games"
                '
                'SelectAllBox2dEUCheckBox
                '
                ckBox2dEU.AutoSize = True
                ckBox2dEU.Name = artType.Name & "SelectAllBox2dEUCheckBox"
                ckBox2dEU.Text = "Select EU box 2d for all games"
                '
                'SelectAllBox2dSideUSCheckBox
                '
                ckBox2dSideUS.AutoSize = True
                ckBox2dSideUS.Name = artType.Name & "SelectAllBox2dSideUSCheckBox"
                ckBox2dSideUS.Text = "Select US box 2d side for all games"
                '
                'SelectAllBox2dSideJPCheckBox
                '
                ckBox2dSideJP.AutoSize = True
                ckBox2dSideJP.Name = artType.Name & "SelectAllBox2dSideJPCheckBox"
                ckBox2dSideJP.Text = "Select JP box 2d side for all games"
                '
                'SelectAllBox2dSideEUCheckBox
                '
                ckBox2dSideEU.AutoSize = True
                ckBox2dSideEU.Name = artType.Name & "SelectAllBox2dSideEUCheckBox"
                ckBox2dSideEU.Text = "Select EU box 2d side for all games"
                '
                'SelectAllBox2dBackUSCheckBox
                '
                ckBox2dBackUS.AutoSize = True
                ckBox2dBackUS.Name = artType.Name & "SelectAllBox2dBackUSCheckBox"
                ckBox2dBackUS.Text = "Select US box 2d back for all games"
                '
                'SelectAllBox2dBackJPCheckBox
                '
                ckBox2dBackJP.AutoSize = True
                ckBox2dBackJP.Name = artType.Name & "SelectAllBox2dBackJPCheckBox"
                ckBox2dBackJP.Text = "Select JP box 2d back for all games"
                '
                'SelectAllBox2dBackEUCheckBox
                '
                ckBox2dBackEU.AutoSize = True
                ckBox2dBackEU.Name = artType.Name & "SelectAllBox2dBackEUCheckBox"
                ckBox2dBackEU.Text = "Select EU box 2d back for all games"
                '
                'SelectAllBox3dUSCheckBox
                '
                ckBox3dUS.AutoSize = True
                ckBox3dUS.Name = artType.Name & "SelectAllBox3dUSCheckBox"
                ckBox3dUS.Text = "Select US box 3d for all games"
                '
                'SelectAllBox3dJPCheckBox
                '
                ckBox3dJP.AutoSize = True
                ckBox3dJP.Name = artType.Name & "SelectAllBox3dJPCheckBox"
                ckBox3dJP.Text = "Select JP box 3d for all games"
                '
                'SelectAllBox3dEUCheckBox
                '
                ckBox3dEU.AutoSize = True
                ckBox3dEU.Name = artType.Name & "SelectAllBox3dEUCheckBox"
                ckBox3dEU.Text = "Select EU box 3d for all games"
                '
                'SelectAllSupportTextureUSCheckBox
                '
                ckSupportTextureUS.AutoSize = True
                ckSupportTextureUS.Name = artType.Name & "SelectAllSupportTextureUSCheckBox"
                ckSupportTextureUS.Text = "Select US cartridge sticker for all games"
                '
                'SelectAllSupportTextureJPCheckBox
                '
                ckSupportTextureJP.AutoSize = True
                ckSupportTextureJP.Name = artType.Name & "SelectAllSupportTextureJPCheckBox"
                ckSupportTextureJP.Text = "Select JP cartridge sticker for all games"
                '
                'SelectAllSupportTextureEUCheckBox
                '
                ckSupportTextureEU.AutoSize = True
                ckSupportTextureEU.Name = artType.Name & "SelectAllSupportTextureEUCheckBox"
                ckSupportTextureEU.Text = "Select EU cartridge sticker for all games"
                '
                'SelectAllSupport2dUSCheckBox
                '
                ckSupport2dUS.AutoSize = True
                ckSupport2dUS.Name = artType.Name & "SelectAllSupport2dUSCheckBox"
                ckSupport2dUS.Text = "Select US cartridge for all games"
                '
                'SelectAllSupport2dJPCheckBox
                '
                ckSupport2dJP.AutoSize = True
                ckSupport2dJP.Name = artType.Name & "SelectAllSupport2dJPCheckBox"
                ckSupport2dJP.Text = "Select JP cartridge for all games"
                '
                'SelectAllSupport2dEUCheckBox
                '
                ckSupport2dEU.AutoSize = True
                ckSupport2dEU.Name = artType.Name & "SelectAllSupport2dEUCheckBox"
                ckSupport2dEU.Text = "Select EU cartridge for all games"
                '
                'ContentDataGridView
                '
                g.AllowUserToAddRows = False
                g.AllowUserToDeleteRows = False
                g.Anchor = CType((((AnchorStyles.Top _
                                    Or AnchorStyles.Bottom) _
                                    Or AnchorStyles.Left) _
                                    Or AnchorStyles.Right),
                                    AnchorStyles)
                g.AutoGenerateColumns = False
                g.BackgroundColor = Color.White
                g.BorderStyle = BorderStyle.None
                g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                g.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {filenameDataGridViewTextBoxColumn,
                                                                                  isScreenShotInGameDataGridViewCheckBoxColumn,
                                                                                  isScreenShotTitleDataGridViewCheckBoxColumn,
                                                                                  isFanartDataGridViewCheckBoxColumn,
                                                                                  isVideoDataGridViewCheckBoxColumn,
                                                                                  isWheelUSDataGridViewCheckBoxColumn,
                                                                                  isWheelJPDataGridViewCheckBoxColumn,
                                                                                  isWheelWORDataGridViewCheckBoxColumn,
                                                                                  isWheelCarbonUSDataGridViewCheckBoxColumn,
                                                                                  isWheelCarbonJPDataGridViewCheckBoxColumn,
                                                                                  isWheelCarbonWORDataGridViewCheckBoxColumn,
                                                                                  isWheelSteelUSDataGridViewCheckBoxColumn,
                                                                                  isWheelSteelJPDataGridViewCheckBoxColumn,
                                                                                  isWheelSteelWORDataGridViewCheckBoxColumn,
                                                                                  isBoxTextureUSDataGridViewCheckBoxColumn,
                                                                                  isBoxTextureJPDataGridViewCheckBoxColumn,
                                                                                  isBoxTextureEUDataGridViewCheckBoxColumn,
                                                                                  isBox2dUSDataGridViewCheckBoxColumn,
                                                                                  isBox2dJPDataGridViewCheckBoxColumn,
                                                                                  isBox2dEUDataGridViewCheckBoxColumn,
                                                                                  isBox2dSideUSDataGridViewCheckBoxColumn,
                                                                                  isBox2dSideJPDataGridViewCheckBoxColumn,
                                                                                  isBox2dSideEUDataGridViewCheckBoxColumn,
                                                                                  isBox2dBackUSDataGridViewCheckBoxColumn,
                                                                                  isBox2dBackJPDataGridViewCheckBoxColumn,
                                                                                  isBox2dBackEUDataGridViewCheckBoxColumn,
                                                                                  isBox3dUSDataGridViewCheckBoxColumn,
                                                                                  isBox3dJPDataGridViewCheckBoxColumn,
                                                                                  isBox3dEUDataGridViewCheckBoxColumn,
                                                                                  isSupportTextureUSDataGridViewCheckBoxColumn,
                                                                                  isSupportTextureJPDataGridViewCheckBoxColumn,
                                                                                  isSupportTextureEUDataGridViewCheckBoxColumn,
                                                                                  isSupport2dUSDataGridViewCheckBoxColumn,
                                                                                  isSupport2dJPDataGridViewCheckBoxColumn,
                                                                                  isSupport2dEUDataGridViewCheckBoxColumn})
                g.DataSource = b
                g.Location = New Point(20, 88)
                g.Name = artType.Name & "ContentDataGridView"
                g.AutoSize = False
                g.MaximumSize = New Size(1900, 350)
                '
                'filenameDataGridViewTextBoxColumn
                '
                filenameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                filenameDataGridViewTextBoxColumn.DataPropertyName = "filename"
                filenameDataGridViewTextBoxColumn.HeaderText = "Game's filename"
                filenameDataGridViewTextBoxColumn.Name = "filenameDataGridViewTextBoxColumn"
                '
                'isScreenShotInGameDataGridViewCheckBoxColumn
                '
                isScreenShotInGameDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isScreenShotInGameDataGridViewCheckBoxColumn.DataPropertyName = "ingame"
                isScreenShotInGameDataGridViewCheckBoxColumn.HeaderText = "In Game ?"
                isScreenShotInGameDataGridViewCheckBoxColumn.Name = "isScreenShotInGameDataGridViewCheckBoxColumn"
                '
                'isScreenShotTitleDataGridViewCheckBoxColumn
                '
                isScreenShotTitleDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isScreenShotTitleDataGridViewCheckBoxColumn.DataPropertyName = "title"
                isScreenShotTitleDataGridViewCheckBoxColumn.HeaderText = "Title ?"
                isScreenShotTitleDataGridViewCheckBoxColumn.Name = "isScreenShotTitleDataGridViewCheckBoxColumn"
                '
                'isFanartDataGridViewCheckBoxColumn
                '
                isFanartDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isFanartDataGridViewCheckBoxColumn.DataPropertyName = "fanart"
                isFanartDataGridViewCheckBoxColumn.HeaderText = "Fanart ?"
                isFanartDataGridViewCheckBoxColumn.Name = "isFanartDataGridViewCheckBoxColumn"
                '
                'isVideoDataGridViewCheckBoxColumn
                '
                isVideoDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isVideoDataGridViewCheckBoxColumn.DataPropertyName = "video"
                isVideoDataGridViewCheckBoxColumn.HeaderText = "Video ?"
                isVideoDataGridViewCheckBoxColumn.Name = "isVideoDataGridViewCheckBoxColumn"
                '
                'isWheelUSDataGridViewCheckBoxColumn
                '
                isWheelUSDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isWheelUSDataGridViewCheckBoxColumn.DataPropertyName = "us"
                isWheelUSDataGridViewCheckBoxColumn.HeaderText = "US ?"
                isWheelUSDataGridViewCheckBoxColumn.Name = "isWheelUSDataGridViewCheckBoxColumn"
                '
                'isWheelJPDataGridViewCheckBoxColumn
                '
                isWheelJPDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isWheelJPDataGridViewCheckBoxColumn.DataPropertyName = "JP"
                isWheelJPDataGridViewCheckBoxColumn.HeaderText = "JP ?"
                isWheelJPDataGridViewCheckBoxColumn.Name = "isWheelJPDataGridViewCheckBoxColumn"
                '
                'isWheelWORDataGridViewCheckBoxColumn
                '
                isWheelWORDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isWheelWORDataGridViewCheckBoxColumn.DataPropertyName = "WOR"
                isWheelWORDataGridViewCheckBoxColumn.HeaderText = "WOR ?"
                isWheelWORDataGridViewCheckBoxColumn.Name = "isWheelWORDataGridViewCheckBoxColumn"
                '
                'isWheelCarbonUSDataGridViewCheckBoxColumn
                '
                isWheelCarbonUSDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isWheelCarbonUSDataGridViewCheckBoxColumn.DataPropertyName = "us"
                isWheelCarbonUSDataGridViewCheckBoxColumn.HeaderText = "US ?"
                isWheelCarbonUSDataGridViewCheckBoxColumn.Name = "isWheelCarbonUSDataGridViewCheckBoxColumn"
                '
                'isWheelCarbonJPDataGridViewCheckBoxColumn
                '
                isWheelCarbonJPDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isWheelCarbonJPDataGridViewCheckBoxColumn.DataPropertyName = "JP"
                isWheelCarbonJPDataGridViewCheckBoxColumn.HeaderText = "JP ?"
                isWheelCarbonJPDataGridViewCheckBoxColumn.Name = "isWheelCarbonJPDataGridViewCheckBoxColumn"
                '
                'isWheelCarbonWORDataGridViewCheckBoxColumn
                '
                isWheelCarbonWORDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isWheelCarbonWORDataGridViewCheckBoxColumn.DataPropertyName = "WOR"
                isWheelCarbonWORDataGridViewCheckBoxColumn.HeaderText = "WOR ?"
                isWheelCarbonWORDataGridViewCheckBoxColumn.Name = "isWheelCarbonWORDataGridViewCheckBoxColumn"
                '
                'isWheelSteelUSDataGridViewCheckBoxColumn
                '
                isWheelSteelUSDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isWheelSteelUSDataGridViewCheckBoxColumn.DataPropertyName = "us"
                isWheelSteelUSDataGridViewCheckBoxColumn.HeaderText = "US ?"
                isWheelSteelUSDataGridViewCheckBoxColumn.Name = "isWheelSteelUSDataGridViewCheckBoxColumn"
                '
                'isWheelSteelJPDataGridViewCheckBoxColumn
                '
                isWheelSteelJPDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isWheelSteelJPDataGridViewCheckBoxColumn.DataPropertyName = "JP"
                isWheelSteelJPDataGridViewCheckBoxColumn.HeaderText = "JP ?"
                isWheelSteelJPDataGridViewCheckBoxColumn.Name = "isWheelSteelJPDataGridViewCheckBoxColumn"
                '
                'isWheelSteelWORDataGridViewCheckBoxColumn
                '
                isWheelSteelWORDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isWheelSteelWORDataGridViewCheckBoxColumn.DataPropertyName = "WOR"
                isWheelSteelWORDataGridViewCheckBoxColumn.HeaderText = "WOR ?"
                isWheelSteelWORDataGridViewCheckBoxColumn.Name = "isWheelSteelWORDataGridViewCheckBoxColumn"
                '
                'isBoxTextureUSDataGridViewCheckBoxColumn
                '
                isBoxTextureUSDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isBoxTextureUSDataGridViewCheckBoxColumn.DataPropertyName = "us"
                isBoxTextureUSDataGridViewCheckBoxColumn.HeaderText = "US ?"
                isBoxTextureUSDataGridViewCheckBoxColumn.Name = "isBoxTextureUSDataGridViewCheckBoxColumn"
                '
                'isBoxTextureJPDataGridViewCheckBoxColumn
                '
                isBoxTextureJPDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isBoxTextureJPDataGridViewCheckBoxColumn.DataPropertyName = "JP"
                isBoxTextureJPDataGridViewCheckBoxColumn.HeaderText = "JP ?"
                isBoxTextureJPDataGridViewCheckBoxColumn.Name = "isBoxTextureJPDataGridViewCheckBoxColumn"
                '
                'isBoxTextureEUDataGridViewCheckBoxColumn
                '
                isBoxTextureEUDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isBoxTextureEUDataGridViewCheckBoxColumn.DataPropertyName = "EU"
                isBoxTextureEUDataGridViewCheckBoxColumn.HeaderText = "EU ?"
                isBoxTextureEUDataGridViewCheckBoxColumn.Name = "isBoxTextureEUDataGridViewCheckBoxColumn"
                '
                'isBox2dUSDataGridViewCheckBoxColumn
                '
                isBox2dUSDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isBox2dUSDataGridViewCheckBoxColumn.DataPropertyName = "us"
                isBox2dUSDataGridViewCheckBoxColumn.HeaderText = "US ?"
                isBox2dUSDataGridViewCheckBoxColumn.Name = "isBox2dUSDataGridViewCheckBoxColumn"
                '
                'isBox2dJPDataGridViewCheckBoxColumn
                '
                isBox2dJPDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isBox2dJPDataGridViewCheckBoxColumn.DataPropertyName = "JP"
                isBox2dJPDataGridViewCheckBoxColumn.HeaderText = "JP ?"
                isBox2dJPDataGridViewCheckBoxColumn.Name = "isBox2dJPDataGridViewCheckBoxColumn"
                '
                'isBox2dEUDataGridViewCheckBoxColumn
                '
                isBox2dEUDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isBox2dEUDataGridViewCheckBoxColumn.DataPropertyName = "EU"
                isBox2dEUDataGridViewCheckBoxColumn.HeaderText = "EU ?"
                isBox2dEUDataGridViewCheckBoxColumn.Name = "isBox2dEUDataGridViewCheckBoxColumn"
                '
                'isBox2dSideUSDataGridViewCheckBoxColumn
                '
                isBox2dSideUSDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isBox2dSideUSDataGridViewCheckBoxColumn.DataPropertyName = "us"
                isBox2dSideUSDataGridViewCheckBoxColumn.HeaderText = "US ?"
                isBox2dSideUSDataGridViewCheckBoxColumn.Name = "isBox2dSideUSDataGridViewCheckBoxColumn"
                '
                'isBox2dSideJPDataGridViewCheckBoxColumn
                '
                isBox2dSideJPDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isBox2dSideJPDataGridViewCheckBoxColumn.DataPropertyName = "JP"
                isBox2dSideJPDataGridViewCheckBoxColumn.HeaderText = "JP ?"
                isBox2dSideJPDataGridViewCheckBoxColumn.Name = "isBox2dSideJPDataGridViewCheckBoxColumn"
                '
                'isBox2dSideEUDataGridViewCheckBoxColumn
                '
                isBox2dSideEUDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isBox2dSideEUDataGridViewCheckBoxColumn.DataPropertyName = "EU"
                isBox2dSideEUDataGridViewCheckBoxColumn.HeaderText = "EU ?"
                isBox2dSideEUDataGridViewCheckBoxColumn.Name = "isBox2dSideEUDataGridViewCheckBoxColumn"
                '
                'isBox2dBackUSDataGridViewCheckBoxColumn
                '
                isBox2dBackUSDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isBox2dBackUSDataGridViewCheckBoxColumn.DataPropertyName = "us"
                isBox2dBackUSDataGridViewCheckBoxColumn.HeaderText = "US ?"
                isBox2dBackUSDataGridViewCheckBoxColumn.Name = "isBox2dBackUSDataGridViewCheckBoxColumn"
                '
                'isBox2dBackJPDataGridViewCheckBoxColumn
                '
                isBox2dBackJPDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isBox2dBackJPDataGridViewCheckBoxColumn.DataPropertyName = "JP"
                isBox2dBackJPDataGridViewCheckBoxColumn.HeaderText = "JP ?"
                isBox2dBackJPDataGridViewCheckBoxColumn.Name = "isBox2dBackJPDataGridViewCheckBoxColumn"
                '
                'isBox2dBackEUDataGridViewCheckBoxColumn
                '
                isBox2dBackEUDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isBox2dBackEUDataGridViewCheckBoxColumn.DataPropertyName = "EU"
                isBox2dBackEUDataGridViewCheckBoxColumn.HeaderText = "EU ?"
                isBox2dBackEUDataGridViewCheckBoxColumn.Name = "isBox2dBackEUDataGridViewCheckBoxColumn"
                '
                'isBox3dUSDataGridViewCheckBoxColumn
                '
                isBox3dUSDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isBox3dUSDataGridViewCheckBoxColumn.DataPropertyName = "us"
                isBox3dUSDataGridViewCheckBoxColumn.HeaderText = "US ?"
                isBox3dUSDataGridViewCheckBoxColumn.Name = "isBox3dUSDataGridViewCheckBoxColumn"
                '
                'isBox3dJPDataGridViewCheckBoxColumn
                '
                isBox3dJPDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isBox3dJPDataGridViewCheckBoxColumn.DataPropertyName = "JP"
                isBox3dJPDataGridViewCheckBoxColumn.HeaderText = "JP ?"
                isBox3dJPDataGridViewCheckBoxColumn.Name = "isBox3dJPDataGridViewCheckBoxColumn"
                '
                'isBox3dEUDataGridViewCheckBoxColumn
                '
                isBox3dEUDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isBox3dEUDataGridViewCheckBoxColumn.DataPropertyName = "EU"
                isBox3dEUDataGridViewCheckBoxColumn.HeaderText = "EU ?"
                isBox3dEUDataGridViewCheckBoxColumn.Name = "isBox3dEUDataGridViewCheckBoxColumn"
                '
                'isSupportTextureUSDataGridViewCheckBoxColumn
                '
                isSupportTextureUSDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isSupportTextureUSDataGridViewCheckBoxColumn.DataPropertyName = "us"
                isSupportTextureUSDataGridViewCheckBoxColumn.HeaderText = "US ?"
                isSupportTextureUSDataGridViewCheckBoxColumn.Name = "isSupportTextureUSDataGridViewCheckBoxColumn"
                '
                'isSupportTextureJPDataGridViewCheckBoxColumn
                '
                isSupportTextureJPDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isSupportTextureJPDataGridViewCheckBoxColumn.DataPropertyName = "JP"
                isSupportTextureJPDataGridViewCheckBoxColumn.HeaderText = "JP ?"
                isSupportTextureJPDataGridViewCheckBoxColumn.Name = "isSupportTextureJPDataGridViewCheckBoxColumn"
                '
                'isSupportTextureEUDataGridViewCheckBoxColumn
                '
                isSupportTextureEUDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isSupportTextureEUDataGridViewCheckBoxColumn.DataPropertyName = "EU"
                isSupportTextureEUDataGridViewCheckBoxColumn.HeaderText = "EU ?"
                isSupportTextureEUDataGridViewCheckBoxColumn.Name = "isSupportTextureEUDataGridViewCheckBoxColumn"
                '
                'isSupport2dUSDataGridViewCheckBoxColumn
                '
                isSupport2dUSDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isSupport2dUSDataGridViewCheckBoxColumn.DataPropertyName = "us"
                isSupport2dUSDataGridViewCheckBoxColumn.HeaderText = "US ?"
                isSupport2dUSDataGridViewCheckBoxColumn.Name = "isSupport2dUSDataGridViewCheckBoxColumn"
                '
                'isSupport2dJPDataGridViewCheckBoxColumn
                '
                isSupport2dJPDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isSupport2dJPDataGridViewCheckBoxColumn.DataPropertyName = "JP"
                isSupport2dJPDataGridViewCheckBoxColumn.HeaderText = "JP ?"
                isSupport2dJPDataGridViewCheckBoxColumn.Name = "isSupport2dJPDataGridViewCheckBoxColumn"
                '
                'isSupport2dEUDataGridViewCheckBoxColumn
                '
                isSupport2dEUDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                isSupport2dEUDataGridViewCheckBoxColumn.DataPropertyName = "EU"
                isSupport2dEUDataGridViewCheckBoxColumn.HeaderText = "EU ?"
                isSupport2dEUDataGridViewCheckBoxColumn.Name = "isSupport2dEUDataGridViewCheckBoxColumn"
                '
                'BindingSource
                '
                b.DataMember = "SSRoms"
                b.DataSource = data
                '
                'RomsDataSet
                '
                data.DataSetName = "RomsDataSet"
                data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema

                g.DataSource = Me._parent.RomsData
                '                '
                'DescriptionLabel
                '
                descriptionLabel.AutoSize = True
                descriptionLabel.Font = ReturnFont()
                descriptionLabel.Location = New Point(17, 19)
                descriptionLabel.Name = artType.Name & "DescriptionLabel"
                descriptionLabel.Text = "Please select the associated type of available Artwork for " & artType.Name

                CType(g, ComponentModel.ISupportInitialize).EndInit()
                CType(b, ComponentModel.ISupportInitialize).EndInit()
                CType(data, ComponentModel.ISupportInitialize).EndInit()

                Me.ActionFlowLayoutPanel.Controls.Add(mainContent)

                contentFlowPanel.Visible = False
                selectAllFlowLayoutPanel.Visible = False
                g.Visible = False
            Next

            For Each c As Control In Me.ActionFlowLayoutPanel.Controls
                If c.Name.Contains("MainPanel") Then
                    c.ResumeLayout(False)
                    c.PerformLayout()

                    For Each innerC As Control In c.Controls
                        If innerC.Name.Contains("HeaderPanel") Then
                            innerC.ResumeLayout(False)
                            innerC.PerformLayout()
                        ElseIf innerC.Name.Contains("ActionPanel") Then
                            innerC.ResumeLayout(False)
                            innerC.PerformLayout()
                        ElseIf innerC.Name.Contains("SelectArtTypeComboBox") Then
                            innerC.ResumeLayout(False)
                            innerC.PerformLayout()
                        ElseIf innerC.Name.Contains("CheckboxFlowLayoutPanel") Then
                            innerC.ResumeLayout(False)
                            innerC.PerformLayout()
                        End If
                    Next
                End If
            Next

            Me.ActionFlowLayoutPanel.ResumeLayout(False)
            Me.ActionFlowLayoutPanel.PerformLayout()

        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    ''' <summary>
    ''' return Font for controls init
    ''' </summary>
    ''' <returns></returns>
    Private Function ReturnFont() As Font
        Return New Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Function

    ''' <summary>
    ''' return font for header
    ''' </summary>
    ''' <returns></returns>
    Private Function ReturnHeaderFont() As Font
        Return New Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Function

    ''' <summary>
    ''' manage resize
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _10_RomsBuildScrapArtworksControl_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.ActionFlowLayoutPanel.Width = Me.Width
        Me.ActionFlowLayoutPanel.Height = Me.Height
    End Sub

    ''' <summary>
    ''' (Un)Collapse ArtType content
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CollapseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim b As Button = CType(sender, Button)

        If b.Tag.ToString = "expand" Then
            b.Image = Me.CollaspeImageList.Images(1)
            b.Tag = "reduce"

            b.Parent.Parent.Controls(1).Visible = True
            CType(b.Parent.Parent.Controls(1).Controls(1), ComboBox).SelectedIndex = -1
        Else
            b.Image = Me.CollaspeImageList.Images(0)
            b.Tag = "expand"

            b.Parent.Parent.Controls(1).Visible = False
        End If
    End Sub

    Private Sub mediaTypeSelectComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim cb As ComboBox = CType(sender, ComboBox)

        Stop
        Select Case cb.SelectedValue
            Case "Screenshots"
            Case "Fanarts"
            Case "Video"
                Stop

                'make only the associated checkboxes accessibles
                For Each ck As CheckBox In cb.Parent.Controls(2).Controls
                    If ck.Name.Contains("SelectAllVideoCheckBox") Then
                        ck.Visible = True
                    Else
                        ck.Visible = False
                    End If
                Next
                'make visible the checkboxes
                cb.Parent.Controls(2).Visible = True

                'make only the associated datagridcolumns accessibles
                For Each col As DataGridViewColumn In CType(cb.Parent.Controls(3), DataGridView).Columns
                    If col.Name = "filenameDataGridViewTextBoxColumn" Or col.Name = "isVideoDataGridViewCheckBoxColumn" Then
                        col.Visible = True
                    Else
                        col.Visible = False
                    End If
                Next
                'make visible the datagridview
                cb.Parent.Controls(3).Visible = True

                CType(cb.Parent.Controls(3), DataGridView).Width = cb.Parent.Parent.Parent.Width

                cb.Parent.Parent.Controls(0).Width = 800
                cb.Parent.Parent.Controls(1).Width = 800
                cb.Parent.Controls(2).Width = 800
                cb.Parent.Controls(3).Width = 800
                'cb.Parent.Parent.Width = cb.Parent.Parent.Parent.Width
                cb.Parent.Parent.Dock = DockStyle.Fill


                ' disable the collapsed button to avoid a reset config
                cb.Parent.Parent.Controls(0).Controls(0).Enabled = False

            Case "Screenshots"
            Case "Wheels"
            Case "Carbon Wheels"
            Case "Steel Wheels"
            Case "Box Textures (all sides of the jacket"
            Case "Box 2D (Front side of the jacket)"
            Case "Box 2D Side"
            Case "Box 2D Back"
            Case "Box 3D"
            Case "Support Texture (Cartridge label)"
            Case "Support 2D (Cartridge)"
            Case Else

        End Select

    End Sub
End Class
