Imports System.IO
Imports System.Text

Public Class RomlistsContainerControl

#Region "Main Attributes"

    ''' <summary>
    ''' Actual step of the process
    ''' </summary>
    Private _actualStep As Steps = Steps.Home

    ''' <summary>
    ''' 1- Home screen
    ''' </summary>
    Private _homeControl As New _0_RomlistsHomeControl

#End Region

    ''' <summary>
    ''' Define the steps for Romlists (re)work
    ''' </summary>
    Private Enum Steps
        ''' <summary>
        ''' Home screen
        ''' </summary>
        Home = 0
        ''' <summary>
        ''' Choice selection
        ''' </summary>
        Choice = 1
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

End Class
