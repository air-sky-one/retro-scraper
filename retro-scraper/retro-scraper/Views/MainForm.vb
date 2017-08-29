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

        '' ----------------
        '' TODO : VISUEL
        'Application title : If the application title is missing, use the application name, without the extension
        If My.Application.Info.Title <> "" Then Me.Text = My.Application.Info.Title Else Me.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        '' ----------------


        Try
            If Not IsLicenceFileOK() Then Throw New Exception("Licence file is missing or invalid")


            ''
            Dim authForm As New ScreenScraperLoginForm : authForm.ShowDialog()
            If Not AppGlobals.isScreenScraperAuthOK Then Me.Close()
        Catch ex As Exception
            LogsHelper.ShowErrorMessage(ex)
            Me.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Check if the licence file is present and can be imported
    ''' </summary>
    ''' <returns>true : OK / false : KO</returns>
    Private Function IsLicenceFileOK() As Boolean
        Dim result As Boolean = False

        Dim l As New Licence.DevDataTable
        Dim tmp As String = String.Empty

        Try
            InternalEncryption.GenerateApplicationPassword()

            If File.Exists(AppGlobals.licenceFilePath) Then
                tmp = InternalEncryption.Decode(File.ReadAllText(AppGlobals.licenceFilePath), LibGlobals.EncryptionPwd)

                ' convert content to stream to be used with datatable
                Dim s As New MemoryStream(Encoding.UTF8.GetBytes(tmp))

                ' load decrypted file content
                l.ReadXml(s)

                result = True
            Else
                'the licence file doesn't exist
                result = False
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return result
    End Function

End Class