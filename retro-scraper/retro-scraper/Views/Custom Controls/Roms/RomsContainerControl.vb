Public Class RomsContainerControl

#Region "Main Attributes"

    ''' <summary>
    ''' Actual step of the process
    ''' </summary>
    Private _actualStep As Steps = Steps.Home

    ''' <summary>
    ''' 1- Home screen
    ''' </summary>
    Private _homeControl As New _0_RomsHomeControl

#End Region

#Region "Step 1 : ScreenScraper System Selection Attributes"

    ''' <summary>
    ''' 1- ScreenScraper system Selection screen
    ''' </summary>
    Private _screenScraperSystemSelect As New _1_RomsScreenScraperSystemSelectControl

    ''' <summary>
    ''' Screen Scraper Systems List
    ''' </summary>
    Private _screenScraperSystemsList As New RomsDataSet.ScreenScraperSystemsDataTable
    Public Property ScreenScraperSystemsList() As RomsDataSet.ScreenScraperSystemsDataTable
        Get
            Return _screenScraperSystemsList
        End Get
        Set(ByVal value As RomsDataSet.ScreenScraperSystemsDataTable)
            _screenScraperSystemsList = value
        End Set
    End Property

    ''' <summary>
    ''' ScreenScraper Selected System
    ''' </summary>
    Private _screenScraperSelectedSystem As String
    Public Property ScreenScraperSelectedSystem() As String
        Get
            Return _screenScraperSelectedSystem
        End Get
        Set(ByVal value As String)
            _screenScraperSelectedSystem = value
        End Set
    End Property

#End Region

#Region "Step 2 : Attract Mode Emulator Selection Attributes"

    ''' <summary>
    ''' 2- Attract Mode Emulator Selection screen
    ''' </summary>
    Private _attractModeEmulatorSelect As New _2_EmulatorSelectControl

    ''' <summary>
    ''' Attract Mode Emulators List
    ''' </summary>
    Private _attractModeEmulatorsList As New RomsDataSet.EmulatorsDataTable
    Public Property AttractModeEmulatorsList() As RomsDataSet.EmulatorsDataTable
        Get
            Return _attractModeEmulatorsList
        End Get
        Set(ByVal value As RomsDataSet.EmulatorsDataTable)
            _attractModeEmulatorsList = value
        End Set
    End Property

    ''' <summary>
    ''' attract Mode Selected System
    ''' </summary>
    Private _attractModeSelectedSystem As String
    Public Property AttractModeSelectedSystem() As String
        Get
            Return _attractModeSelectedSystem
        End Get
        Set(ByVal value As String)
            _attractModeSelectedSystem = value
        End Set
    End Property

    ''' <summary>
    ''' Accepted emulator's roms extension
    ''' </summary>
    Private _romsExtensions As String()
    Public Property RomsExtensions() As String()
        Get
            Return _romsExtensions
        End Get
        Set(ByVal value As String())
            _romsExtensions = value
        End Set
    End Property

    ''' <summary>
    ''' Roms artworks (name and path)
    ''' </summary>
    Private _romsArtworks As New RomsDataSet.ArtworksDataTable
    Public Property RomsArtworks() As RomsDataSet.ArtworksDataTable
        Get
            Return _romsArtworks
        End Get
        Set(ByVal value As RomsDataSet.ArtworksDataTable)
            _romsArtworks = value
        End Set
    End Property

#End Region

#Region "Step 3 : Roms Path selection"

    ''' <summary>
    ''' 3- Roms Path Selection screen
    ''' </summary>
    Private _romsPathSelect As New _3_RomsPathControl

    ''' <summary>
    ''' Selected Roms Path
    ''' </summary>
    Private _romsPath As String
    Public Property RomsPath() As String
        Get
            Return _romsPath
        End Get
        Set(ByVal value As String)
            _romsPath = value
        End Set
    End Property

#End Region

#Region "Step 4 : RomList file new/update choice"

    ''' <summary>
    ''' 4- Choice between generate a new romlist file or update an existing one
    ''' </summary>
    Private _romListChoice As New _4_RomListChoiceControl

    ''' <summary>
    ''' Indicates if the romlist file has to be a new one or if the user wants to update an already existing one
    ''' </summary>
    Private _isRomlistNewfile As Boolean = True
    Public Property IsRomListNewFile() As Boolean
        Get
            Return _isRomlistNewfile
        End Get
        Set(ByVal value As Boolean)
            _isRomlistNewfile = value
        End Set
    End Property

    ''' <summary>
    ''' Romlist file to update
    ''' </summary>
    Private _romlistFilePath As String
    Public Property RomlistFilePath() As String
        Get
            Return _romlistFilePath
        End Get
        Set(ByVal value As String)
            _romlistFilePath = value
        End Set
    End Property

#End Region

#Region "step 5 : Loading data and url from ScreenScraper"

    ''' <summary>
    ''' Roms data retrieve from screenscraper
    ''' </summary>
    Private _romsData As New RomsDataSet.SSRomsDataTable
    Public Property RomsData() As RomsDataSet.SSRomsDataTable
        Get
            Return _romsData
        End Get
        Set(ByVal value As RomsDataSet.SSRomsDataTable)
            _romsData = value
        End Set
    End Property

    ''' <summary>
    ''' Roms in error during loading and downloading
    ''' </summary>
    Private _romsDataErrors As New RomsDataSet.ErrorsSSRomsLoadingDataTable
    Public Property RomsDataErrors() As RomsDataSet.ErrorsSSRomsLoadingDataTable
        Get
            Return _romsDataErrors
        End Get
        Set(ByVal value As RomsDataSet.ErrorsSSRomsLoadingDataTable)
            _romsDataErrors = value
        End Set
    End Property

    ''' <summary>
    ''' Loading process screeen (retrieve data and media's url for games from screenscraper.fr
    ''' </summary>
    Private _loadingProcessScreen As New _5_RomsLoadingProcessControl

#End Region

#Region "step 6 : Build Scrap : Games selection"

    ''' <summary>
    ''' Build Scrap : Games selection
    ''' </summary>
    Private _gamesSelectionProcessScreen As New _6_RomsBuildScrapGamesSelectionControl

#End Region

#Region "step 7 : Build Scrap : Games title selection"

    ''' <summary>
    ''' Build Scrap : Games selection
    ''' </summary>
    Private _gamesTitleScreen As New _7_RomsBuildScrapTitleControl

#End Region

#Region "step 8 : Build Scrap : Games date selection"

    ''' <summary>
    ''' Build Scrap : Games selection
    ''' </summary>
    Private _gamesDateScreen As New _8_RomsBuildScrapDateControl

#End Region

#Region "step 9 : Build Scrap : Games category selection"

    ''' <summary>
    ''' Build Scrap : Games selection
    ''' </summary>
    Private _gamesCategoryScreen As New _9_RomsBuildScrapCategoryControl

#End Region

#Region "step 10 : Associate Artworks to ScrenScraper's media types"

    ''' <summary>
    ''' List of media types defined in screenscraper.fr
    ''' </summary>
    Private _mediaTypes As New RomsDataSet.MediaTypesDataTable
    Public ReadOnly Property MediaTypes() As RomsDataSet.MediaTypesDataTable
        Get
            Return _mediaTypes
        End Get
    End Property

    ''' <summary>
    ''' Build Scrap : Games selection
    ''' </summary>
    Private _artworksMediaTypesScreen As New _10_RomsBuildScrapArtworksControl

#End Region

#Region "step 11 : Build your scrap : Artworks"

    ''' <summary>
    ''' Build Scrap : Games selection
    ''' </summary>
    Private _gamesArtworksScreen As New _11_RomsBuildScrapArtworksControl

#End Region

#Region "step 12 : Download"

    ''' <summary>
    ''' Roms data build for generate romlist file
    ''' </summary>
    Private _romList As New RomsDataSet.RomlistDataTable
    Public Property RomList() As RomsDataSet.RomlistDataTable
        Get
            Return _romList
        End Get
        Set(ByVal value As RomsDataSet.RomlistDataTable)
            _romList = value
        End Set
    End Property

    ''' <summary>
    ''' Download
    ''' </summary>
    Private _downloadScreen As New _12_RomsDownloadControl

#End Region

#Region "step 13 : Results"

    ''' <summary>
    ''' Results
    ''' </summary>
    Private _resultsScreen As New _13_RomsResultsControl

#End Region

    ''' <summary>
    ''' Define the steps for roms scraping completion
    ''' </summary>
    Private Enum Steps
        ''' <summary>
        ''' Home screen
        ''' </summary>
        Home = 0
        ''' <summary>
        ''' Load available systems on screenscraper.fr and define user's selection
        ''' </summary>
        ScreenScraperSystem = 1
        ''' <summary>
        ''' Emulator selection
        ''' </summary>
        Emulator = 2
        ''' <summary>
        ''' Path where roms are stored
        ''' </summary>
        RomsPath = 3
        ''' <summary>
        ''' Allows the user to generate an associated romlist file
        ''' </summary>
        RomListFile = 4
        ''' <summary>
        ''' display loading progress
        ''' </summary>
        LoadingProcess = 5
        ''' <summary>
        ''' allows user to select the games he wants to scrap
        ''' </summary>
        BuildScrapingGamesSelection = 6
        ''' <summary>
        ''' allows user to define what to scrap for games title
        ''' </summary>
        BuildScrapingTitle = 7
        ''' <summary>
        ''' allows user to define what to scrap for games date
        ''' </summary>
        BuildScrapingDate = 8
        ''' <summary>
        ''' allows user to define what to scrap for games category
        ''' </summary>
        BuildScrapingCategory = 9
        ''' <summary>
        ''' allows user to media type to artworks
        ''' </summary>
        AssociateArtworkMediaTypes = 10
        ''' <summary>
        ''' allows user to define what to scrap for games artwork
        ''' </summary>
        BuildScrapingArtwork = 11
        ''' <summary>
        ''' display download progress
        ''' </summary>
        Download = 12
        ''' <summary>
        ''' display results and logs
        ''' </summary>
        Result = 13
    End Enum

    ''' <summary>
    ''' Initialization
    ''' </summary>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Init media types list
        InitMediaTypesList()

        ' Add the Home control to the container
        Me.MainTableLayoutPanel.Controls.Add(Me._homeControl, 0, 2)
        Me._homeControl.Dock = DockStyle.Fill
        Me._homeControl.Margin = New Padding(0)

        ' Actual Step Home
        Me._actualStep = Steps.Home
    End Sub

    ''' <summary>
    ''' Init list of media Types
    ''' </summary>
    Private Sub InitMediaTypesList()
        Me._mediaTypes.Rows.Clear()
        InitMediaTypeRow("Screenshots")
        InitMediaTypeRow("Fanarts")
        InitMediaTypeRow("Video")
        InitMediaTypeRow("Wheels")
        InitMediaTypeRow("Carbon Wheels")
        InitMediaTypeRow("Steel Wheels")
        InitMediaTypeRow("Box Textures (all sides of the jacket)")
        InitMediaTypeRow("Box 2D (Front side of the jacket)")
        InitMediaTypeRow("Box 2D Side")
        InitMediaTypeRow("Box 2D Back")
        InitMediaTypeRow("Box 3D")
        InitMediaTypeRow("Support Texture (Cartridge label)")
        InitMediaTypeRow("Support 2D (Cartridge)")
    End Sub

    ''' <summary>
    ''' Helper : create a media type row
    ''' </summary>
    ''' <param name="name"></param>
    Private Sub InitMediaTypeRow(name As String)
        Dim m As RomsDataSet.MediaTypesRow
        m = Me._mediaTypes.NewRow
        m.Name = name
        Me._mediaTypes.AddMediaTypesRow(m)
    End Sub

    ''' <summary>
    ''' Display or undisplay Previous and Next button based on nthe actual step
    ''' </summary>
    Private Sub DisplayStepsButtons()
        If Me._actualStep = Steps.Home Then
            Me.ButtonPrevious.Visible = False
        ElseIf Me._actualStep > Steps.Home Then
            Me.ButtonPrevious.Visible = True
        End If

        If Me._actualStep = Steps.Result Then
            Me.ButtonNext.Visible = False
        ElseIf Me._actualStep < Steps.Result Then
            Me.ButtonNext.Visible = True
        End If
    End Sub

    ''' <summary>
    ''' Update container content
    ''' </summary>
    Private Sub UpdateContent()
        Select Case Me._actualStep

            Case Steps.Home
                Me.HeaderLabel.Text = "Roms sraping"

                Me.StepsProgressBar.Value = 0

                Me.MainTableLayoutPanel.Controls.Add(Me._homeControl, 0, 2)

            Case Steps.ScreenScraperSystem
                Me.HeaderLabel.Text = "Step 1 : Screen Scraper System Selection"

                Me.StepsProgressBar.Value = 1

                Me.MainTableLayoutPanel.Controls.Add(Me._screenScraperSystemSelect, 0, 2)

                Me._screenScraperSystemSelect.Dock = DockStyle.Fill

            Case Steps.Emulator
                Me.HeaderLabel.Text = "Step 2 : Emulator Selection"

                Me.StepsProgressBar.Value = 2

                Me.MainTableLayoutPanel.Controls.Add(Me._attractModeEmulatorSelect, 0, 2)

                Me._attractModeEmulatorSelect.Dock = DockStyle.Fill

            Case Steps.RomsPath
                Me.HeaderLabel.Text = "Step 3 : Roms Path Selection"

                Me.StepsProgressBar.Value = 3

                Me.MainTableLayoutPanel.Controls.Add(Me._romsPathSelect, 0, 2)

                Me._romsPathSelect.Dock = DockStyle.Fill

            Case Steps.RomListFile
                Me.HeaderLabel.Text = "Step 4 : RomList file Generation"

                Me.StepsProgressBar.Value = 4

                Me._loadingProcessScreen = Nothing
                Me._gamesSelectionProcessScreen.Datagrid.DataSource = Nothing
                Me._gamesTitleScreen.Datagrid.DataSource = Nothing
                Me._gamesDateScreen.Datagrid.DataSource = Nothing
                Me._artworksMediaTypesScreen.Datagrid.DataSource = Nothing
                Me._gamesArtworksScreen.Datagrid.DataSource = Nothing

                Me.MainTableLayoutPanel.Controls.Add(Me._romListChoice, 0, 2)

                Me._romListChoice.Dock = DockStyle.Fill

            Case Steps.LoadingProcess
                Me.HeaderLabel.Text = "Step 5 : Loading Data"

                Me.StepsProgressBar.Value = 5

                Me._loadingProcessScreen = New _5_RomsLoadingProcessControl
                Me.MainTableLayoutPanel.Controls.Add(Me._loadingProcessScreen, 0, 2)

                Me._loadingProcessScreen.Dock = DockStyle.Fill

            Case Steps.BuildScrapingGamesSelection
                Me.HeaderLabel.Text = "Step 6 : Build your scrap : Select the games you want to scrap"

                Me.StepsProgressBar.Value = 6

                Me._gamesSelectionProcessScreen = New _6_RomsBuildScrapGamesSelectionControl
                Me.MainTableLayoutPanel.Controls.Add(Me._gamesSelectionProcessScreen, 0, 2)

                Me._gamesSelectionProcessScreen.Dock = DockStyle.Fill

            Case Steps.BuildScrapingTitle
                Me.HeaderLabel.Text = "Step 7 : Build your scrap : Names"

                Me.StepsProgressBar.Value = 7

                Me._gamesTitleScreen = New _7_RomsBuildScrapTitleControl
                Me.MainTableLayoutPanel.Controls.Add(Me._gamesTitleScreen, 0, 2)

                Me._gamesTitleScreen.Dock = DockStyle.Fill

            Case Steps.BuildScrapingDate
                Me.HeaderLabel.Text = "Step 8 : Build your scrap : Dates"

                Me.StepsProgressBar.Value = 8

                Me._gamesDateScreen = New _8_RomsBuildScrapDateControl
                Me.MainTableLayoutPanel.Controls.Add(Me._gamesDateScreen, 0, 2)

                Me._gamesDateScreen.Dock = DockStyle.Fill

            Case Steps.BuildScrapingCategory
                Me.HeaderLabel.Text = "Step 9 : Build your scrap : Categories"

                Me.StepsProgressBar.Value = 9

                Me._gamesCategoryScreen = New _9_RomsBuildScrapCategoryControl
                Me.MainTableLayoutPanel.Controls.Add(Me._gamesCategoryScreen, 0, 2)

                Me._gamesCategoryScreen.Dock = DockStyle.Fill

            Case Steps.AssociateArtworkMediaTypes
                Me.HeaderLabel.Text = "Step 10 : Associate Artworks to ScrenScraper's media types"

                Me.StepsProgressBar.Value = 10

                Me._artworksMediaTypesScreen = New _10_RomsBuildScrapArtworksControl
                Me._artworksMediaTypesScreen.Datagrid.DataSource = Nothing
                Me.MainTableLayoutPanel.Controls.Add(Me._artworksMediaTypesScreen, 0, 2)

                Me._artworksMediaTypesScreen.Dock = DockStyle.Fill

            Case Steps.BuildScrapingArtwork
                Me.HeaderLabel.Text = "Step 11 : Build your scrap : Artworks"

                Me.StepsProgressBar.Value = 11

                Me._gamesArtworksScreen = New _11_RomsBuildScrapArtworksControl
                Me.MainTableLayoutPanel.Controls.Add(Me._gamesArtworksScreen, 0, 2)

                Me._gamesArtworksScreen.Dock = DockStyle.Fill

            Case Steps.Download
                Me.HeaderLabel.Text = "Step 12 : Download"

                Me.StepsProgressBar.Value = 12

                Me._downloadScreen = New _12_RomsDownloadControl
                Me.MainTableLayoutPanel.Controls.Add(Me._downloadScreen, 0, 2)

                Me._downloadScreen.Dock = DockStyle.Fill

            Case Steps.Result
                Me.HeaderLabel.Text = "Results"

                Me.StepsProgressBar.Value = 13

                Me._resultsScreen = New _13_RomsResultsControl
                Me.MainTableLayoutPanel.Controls.Add(Me._resultsScreen, 0, 2)

                Me._resultsScreen.Dock = DockStyle.Fill

            Case Else
        End Select
    End Sub

    ''' <summary>
    ''' Go to next step
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        ' Remove actual content 
        If Me.MainTableLayoutPanel.Controls.Count > 3 Then
            Me.MainTableLayoutPanel.Controls.RemoveAt(3)
        End If

        ' Upgrade actual step
        Me._actualStep = Me._actualStep + 1

        ' Prev/Next buttons
        Me.DisplayStepsButtons()

        ' Update content
        UpdateContent()
    End Sub

    ''' <summary>
    ''' Go back to previous step
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        ' Remove actual content 
        If Me.MainTableLayoutPanel.Controls.Count > 3 Then
            Me.MainTableLayoutPanel.Controls.RemoveAt(3)
        End If

        ' Upgrade actual step
        Me._actualStep = Me._actualStep - 1

        If Me._actualStep = Steps.LoadingProcess Or Me._actualStep >= Steps.Download Then Me._actualStep = Steps.RomListFile

        ' Prev/Next buttons
        Me.DisplayStepsButtons()

        ' Update content
        UpdateContent()
    End Sub

End Class
