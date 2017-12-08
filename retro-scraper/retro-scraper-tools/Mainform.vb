Imports System.IO
Imports retro_scraper_libs

Public Class MainForm

    ''' <summary>
    ''' Generate Licence File
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LicenceGenerateButton_Click(sender As Object, e As EventArgs) Handles LicenceGenerateButton.Click
        Dim login As String
        Dim password As String
        Dim licenceXML As New Licence.DevDataTable
        Dim tmpLicenceFilePath As String = String.Empty
        Dim licence As String = String.Empty


#If DEBUG Then
        login = "urukai"
        password = "7M7Cof1CU6nk"
#Else
        login = Me.LicenceUsernameTextBox.Text
        password = Me.LicencePasswordTextBox.Text
#End If

        'create the row in the licence datatable schema containing the licence credentials for screenscraper.fr
        licenceXML.AddDevRow(login,
                             password,
                             My.Application.Info.AssemblyName,
                             My.Application.Info.Version.ToString)

        ' define the export folder file path for the generated licence file
        tmpLicenceFilePath = Application.StartupPath() & "\licence.cfg"

        'delete potential existing files
        File.Delete(tmpLicenceFilePath)

        'write en tmp file without encryption
        licenceXML.WriteXml(tmpLicenceFilePath)

        'generate the encryption password
        InternalEncryption.GenerateApplicationPassword()

        'read the tmp file without encryption and then encrypt it
        licence = InternalEncryption.Encode(File.ReadAllText(tmpLicenceFilePath), LibGlobals.EncryptionPwd)

        'delete the not encrypted licence file
        File.Delete(tmpLicenceFilePath)

        'write the encrypted version of the licence file
        File.WriteAllText(tmpLicenceFilePath, licence)

        MessageBox.Show("Licence File generated with success here : " & vbCrLf & tmpLicenceFilePath, "Licence", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

End Class
