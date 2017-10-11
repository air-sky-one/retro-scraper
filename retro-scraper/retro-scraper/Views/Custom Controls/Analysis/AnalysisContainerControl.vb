Imports System.IO
Imports System.Text

Public Class AnalysisContainerControl

#Region "Main Attributes"

    ''' <summary>
    ''' Actual step of the process
    ''' </summary>
    Private _actualStep As Steps = Steps.Home

    ''' <summary>
    ''' 1- Home screen
    ''' </summary>
    Private _homeControl As New _0_AnalysisHomeControl

#End Region

#Region "Step 1 : Attract Mode Emulator Selection Attributes"

    ''' <summary>
    ''' 1- Attract Mode Emulator Selection screen
    ''' </summary>
    Private _attractModeEmulatorSelect As New _1_AnalysisEmulatorSelectControl

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

#Region "Step 2 : Roms Path selection"

    ''' <summary>
    ''' 3- Roms Path Selection screen
    ''' </summary>
    Private _romsPathSelect As New _2_AnalysisPathControl

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

#Region "step 3 : Analyse local media"

    ''' <summary>
    ''' Roms data retrieve from screenscraper
    ''' </summary>
    Private _romsData As New DataTable
    Public Property RomsData() As DataTable
        Get
            Return _romsData
        End Get
        Set(ByVal value As DataTable)
            _romsData = value
        End Set
    End Property

    ''' <summary>
    ''' Loading process screeen
    ''' </summary>
    Private _loadingProcessScreen As New _3_AnalysisLoadingProcessControl

#End Region

#Region "step 4 : Results and Export"

    ''' <summary>
    ''' Results and Export screeen
    ''' </summary>
    Private _resultScreen As New _4_AnalysisResultControl

#End Region

    ''' <summary>
    ''' Define the steps for local analysis completion
    ''' </summary>
    Private Enum Steps
        ''' <summary>
        ''' Home screen
        ''' </summary>
        Home = 0
        ''' <summary>
        ''' Emulator selection
        ''' </summary>
        Emulator = 1
        ''' <summary>
        ''' Path where roms are stored
        ''' </summary>
        RomsPath = 2
        ''' <summary>
        ''' display analysis progress
        ''' </summary>
        Analysis = 3
        ''' <summary>
        ''' display results and logs
        ''' </summary>
        Result = 4
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
                Me.HeaderLabel.Text = "Local Analysis"

                Me.StepsProgressBar.Value = 0

                Me.MainTableLayoutPanel.Controls.Add(Me._homeControl, 0, 2)

            Case Steps.Emulator
                Me.HeaderLabel.Text = "Step 1 : Emulator Selection"

                Me.StepsProgressBar.Value = 1

                Me.MainTableLayoutPanel.Controls.Add(Me._attractModeEmulatorSelect, 0, 2)

                Me._attractModeEmulatorSelect.Dock = DockStyle.Fill

            Case Steps.RomsPath
                Me.HeaderLabel.Text = "Step 2 : Roms Path Selection"

                Me.StepsProgressBar.Value = 2

                Me.MainTableLayoutPanel.Controls.Add(Me._romsPathSelect, 0, 2)

                Me._romsPathSelect.Dock = DockStyle.Fill

            Case Steps.Analysis
                Me.HeaderLabel.Text = "Step 3 : Loading Data"

                Me.StepsProgressBar.Value = 3

                Me._loadingProcessScreen = New _3_AnalysisLoadingProcessControl
                Me.MainTableLayoutPanel.Controls.Add(Me._loadingProcessScreen, 0, 2)

                Me._loadingProcessScreen.Dock = DockStyle.Fill

            Case Steps.Result
                Me.HeaderLabel.Text = "Step 4 : Results and Export"

                Me.StepsProgressBar.Value = 4

                Me._resultScreen = New _4_AnalysisResultControl
                Me.MainTableLayoutPanel.Controls.Add(Me._resultScreen, 0, 2)

                Me._resultScreen.Dock = DockStyle.Fill

                Me.ButtonNext.Visible = False
                Me.ButtonPrevious.Visible = False
                Me.ButtonExport.Visible = True
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

    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        ' Remove actual content 
        If Me.MainTableLayoutPanel.Controls.Count > 3 Then
            Me.MainTableLayoutPanel.Controls.RemoveAt(3)
        End If

        ' Upgrade actual step
        Me._actualStep = Me._actualStep - 1

        If Me._actualStep = Steps.Analysis Then Me._actualStep = Steps.RomsPath

        ' Prev/Next buttons
        Me.DisplayStepsButtons()

        ' Update content
        UpdateContent()
    End Sub

    ''' <summary>
    ''' Export results
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonExport_Click(sender As Object, e As EventArgs) Handles ButtonExport.Click
        Dim s As New StringBuilder

        Me.ExportSaveFileDialog.FileName = Me.AttractModeSelectedSystem & "_" &
                                            Date.Now.Year.ToString & "-" &
                                            Date.Now.Month.ToString & "-" &
                                            Date.Now.Hour.ToString & "-" &
                                            Date.Now.Minute.ToString & "-" &
                                            Date.Now.Day.ToString &
                                            "_Export.csv"

        If Me.ExportSaveFileDialog.ShowDialog Then
            For Each c As DataColumn In Me.RomsData.Columns
                s.Append(c.ColumnName & ";")
            Next

            s.AppendLine()

            For Each r As DataRow In Me.RomsData.Rows
                For Each c As DataColumn In Me.RomsData.Columns
                    s.Append(r(c).ToString() & ";")
                Next
                s.AppendLine()
            Next

            File.WriteAllText(Me.ExportSaveFileDialog.FileName, s.ToString)
        End If
    End Sub
End Class
