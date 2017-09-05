Imports retro_scraper_libs
Imports System.IO
Imports System.Text

Public Class MainForm

    ''' <summary>
    ''' Collection of Main Buttons
    ''' </summary>
    Private _mainButtons As New List(Of Button)

    ''' <summary>
    ''' Home Control Back Up
    ''' </summary>
    Private _homeControl As HomeControl

    ''' <summary>
    ''' Main application form loading
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Application title : If the application title is missing, use the application name, without the extension
        Me.Text = GetApplicationName()

        Try
            MainInit()

            'Licence Check
            If Not IsLicenceFileOK() Then Throw New Exception("Licence file is missing or invalid.")

            'ScreenScraper User Check
            If Not isScreenScraperUserFileOK() Then
                Dim authForm As New ScreenScraperLoginForm : authForm.ShowDialog()
                If Not AppGlobals.isScreenScraperAuthOK Then Me.Close()
            End If

        Catch ex As Exception
            ShowErrorMessage(ex)
            Me.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Main initialization
    ''' </summary>
    Private Sub MainInit()
        Try
            'Generate Application encryption/decryption password
            InternalEncryption.GenerateApplicationPassword()

            'Add all MainButtons to the collection + Add them Click Event Handler
            For Each ctrl As Control In MainMenuFlowLayoutPanel.Controls
                If ctrl.Name.Contains("MainButton") Then
                    Dim mainBtn As Button = DirectCast(ctrl, Button)
                    Me._mainButtons.Add(mainBtn)

                    AddHandler mainBtn.Click, AddressOf Me.MainButton_MouseClick
                End If
            Next

            '  Me._homeControl = MainHomeControl

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Main Button click : Change application content
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MainButton_MouseClick(sender As Object, e As MouseEventArgs)
        Dim selectedBtn As Button = sender
        Dim actualContent As UserControl

        Try
            ' Main Menu buttons colors
            For Each mainBtn In Me._mainButtons
                If mainBtn.Name <> selectedBtn.Name Then
                    mainBtn.BackColor = Color.DimGray
                Else
                    mainBtn.BackColor = Color.White
                End If
            Next

            ' Header layout update
            If selectedBtn.Name <> "MainButtonHome" Then
                Me.HeaderPanel.Height = 69
            Else
                ' Me.HeaderPanel.Height = 69
                Me.HeaderPanel.Height = 144
            End If

            ' Remove actual application content
            If Me.MainFormTableLayoutPanel.Controls().Count > 1 Then
                actualContent = Me.MainFormTableLayoutPanel.Controls(1)

                Me.MainFormTableLayoutPanel.Controls().RemoveAt(1)

                ' destruct object if its not the Home Control
                If actualContent.Name <> "MainHomeControl" Then actualContent.Dispose()

            End If

            ' Update application content
            Select Case selectedBtn.Name
                Case "MainButtonHome"
                    Me.MainFormTableLayoutPanel.Controls().Add(Me.MainHomeControl, 1, 0)
                    Me.MainHomeControl.Height = Me.MainHomeControl.Height - 75
                Case "MainButtonRoms"
                    Dim c As New RomsControl

                    Me.MainFormTableLayoutPanel.Controls().Add(c, 1, 0)

                    c.Dock = DockStyle.Fill
                Case "MainButtonSystems"
                Case "MainButtonGameLists"
                Case "MainButtonSettings"
                Case Else
                    ' nothing
            End Select

        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub
End Class