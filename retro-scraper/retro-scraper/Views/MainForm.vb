Imports retro_scraper_libs
Imports System.IO
Imports System.Text

Public Class MainForm

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
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class