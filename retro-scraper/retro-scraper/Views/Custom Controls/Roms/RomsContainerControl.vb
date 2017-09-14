﻿Public Class RomsContainerControl

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
    Private _screenScraperSystemSelect As New _1_ScreenScraperSystemSelectControl

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
    ''' Accepted eumator's roms extension
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
    ''' Roms in error during loading
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
    Private _loadingProcessScreen As New _5_RomLoadingProcessControl

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
        ''' allows user to define what to scrap
        ''' </summary>
        PreScraping = 6
        ''' <summary>
        ''' display download progress
        ''' </summary>
        Download = 7
        ''' <summary>
        ''' display results and logs
        ''' </summary>
        Result = 8
    End Enum

    ''' <summary>
    ''' Initialization
    ''' </summary>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add the Home control to the container
        Me.MainTableLayoutPanel.Controls.Add(Me._homeControl, 0, 2)
        Me._homeControl.Dock = DockStyle.Fill
        Me._homeControl.Margin = New Padding(0)

        ' Actual Step Home
        Me._actualStep = Steps.Home
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

                Me.MainTableLayoutPanel.Controls.Add(Me._romListChoice, 0, 2)

                Me._romListChoice.Dock = DockStyle.Fill

            Case Steps.LoadingProcess
                Me.HeaderLabel.Text = "Step 5 : Loading Data"

                Me.StepsProgressBar.Value = 5

                Me.MainTableLayoutPanel.Controls.Add(Me._loadingProcessScreen, 0, 2)

                Me._loadingProcessScreen.Dock = DockStyle.Fill

            Case Steps.PreScraping
                Me.HeaderLabel.Text = "Step 6 : PreScrap"

                Me.StepsProgressBar.Value = 6

            Case Steps.Download
                Me.HeaderLabel.Text = "Step 7 : Download"

                Me.StepsProgressBar.Value = 7

            Case Steps.Result
                Me.HeaderLabel.Text = "Results"

                Me.StepsProgressBar.Value = 8

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

        If Me._actualStep = Steps.LoadingProcess Then Me._actualStep = Steps.RomListFile
        If Me._actualStep = Steps.Download Then Me._actualStep = Steps.PreScraping

        ' Prev/Next buttons
        Me.DisplayStepsButtons()

        ' Update content
        UpdateContent()
    End Sub
End Class
