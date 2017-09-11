Public Class RomsContainerControl

#Region "Main Attributes"

    ''' <summary>
    ''' Actual step of the process
    ''' </summary>
    Private _actualStep As Steps = Steps.Home

    ''' <summary>
    ''' 1- Home screen
    ''' </summary>
    Private _homeControl As New _1_RomsHomeControl

#End Region

#Region "Step 2 : ScreenScraper System Selection Attributes"

    ''' <summary>
    ''' 2- ScreenScraper system Selection screen
    ''' </summary>
    Private _screenScraperSystemSelect As New _2_ScreenScraperSystemSelectControl

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

#End Region

#Region "Step 3 : Attract Mode Emulator Selection Attributes"

    ''' <summary>
    ''' 3- Attract Mode Emulator Selection screen
    ''' </summary>
    Private _attractModeEmulatorSelect As New _3_EmulatorSelectControl

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

#End Region

    ''' <summary>
    ''' Define the steps for roms scraping completion
    ''' </summary>
    Private Enum Steps
        ''' <summary>
        ''' Home screen
        ''' </summary>
        Home = 1
        ''' <summary>
        ''' Load available systems on screenscraper.fr and define user's selection
        ''' </summary>
        ScreenScraperSystem = 2
        ''' <summary>
        ''' Emulator selection
        ''' </summary>
        Emulator = 3
        ''' <summary>
        ''' Path where roms are stored
        ''' </summary>
        RomsPath = 4
        ''' <summary>
        ''' Allows the user to generate an associated romlist file
        ''' </summary>
        RomListFile = 5
        ''' <summary>
        ''' display loading progress
        ''' </summary>
        LoadingProcess = 6
        ''' <summary>
        ''' allows user to define what to scrap
        ''' </summary>
        PreScraping = 7
        ''' <summary>
        ''' display download progress
        ''' </summary>
        Download = 8
        ''' <summary>
        ''' display results and logs
        ''' </summary>
        Result = 9
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

            Case Steps.RomListFile
                Me.HeaderLabel.Text = "Step 4 : RomList file Generation"

                Me.StepsProgressBar.Value = 4

            Case Steps.LoadingProcess
                Me.HeaderLabel.Text = "Step 5 : Loading Data"

                Me.StepsProgressBar.Value = 5

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
