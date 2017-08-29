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
        If My.Application.Info.Title <> "" Then Me.Text = My.Application.Info.Title Else Me.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)

        ''
        Dim l As New Licence.DevDataTable
        Dim tmp As String = String.Empty
        InternalEncryption.GenerateApplicationPassword()

        tmp = File.ReadAllText(AppGlobals.licenceFilePath)
        tmp = InternalEncryption.Decode(tmp, LibGlobals.EncryptionPwd)

        ' convert content to stream to be used with datatable
        Dim s As New MemoryStream(Encoding.UTF8.GetBytes(tmp))

        ' load decrypted file content
        l.ReadXml(s)

        ''
        Dim authForm As New ScreenScraperLoginForm : authForm.ShowDialog()
        If Not AppGlobals.isScreenScraperAuthOK Then Me.Close()
    End Sub

End Class