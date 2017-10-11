Imports System.IO
Imports System.Text
Imports retro_scraper_libs

Module FileHelper

    ''' <summary>
    ''' Use to read and load an encrypted XML file (ex: Licence and User) into the associated DataTable
    ''' </summary>
    ''' <param name="path"></param>
    ''' <param name="data"></param>
    ''' <returns></returns>
    Public Function ReadAndLoadEncryptedFile(path As String, data As DataTable) As Boolean
        Dim result As Boolean = False

        Dim tmp As String = String.Empty

        Try

            If File.Exists(path) Then
                tmp = InternalEncryption.Decode(File.ReadAllText(path), LibGlobals.EncryptionPwd)

                ' convert content to stream to be used with datatable
                Dim s As New MemoryStream(Encoding.UTF8.GetBytes(tmp))

                ' load decrypted file content
                data.ReadXml(s)

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

    ''' <summary>
    ''' Get the files on a specific folder with the given extensions only
    ''' </summary>
    ''' <param name="path"></param>
    ''' <param name="extensions"></param>
    ''' <returns></returns>
    Public Function GetFilesAssociatedToExtensions(path As String, extensions As String()) As List(Of String)
        Dim result As New List(Of String)

        For Each file As String In Directory.GetFiles(path)
            Dim concretExt As String
            concretExt = file.Substring(file.Length - 4, 4).ToLower

            For Each ext As String In extensions
                ext = ext.ToLower
                If concretExt = ext Then
                    result.Add(file)
                    Exit For
                End If
            Next
        Next

        Return result
    End Function

End Module
