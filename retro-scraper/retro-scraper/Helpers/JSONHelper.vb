Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text

Module JSONHelper

    ''' <summary>
    ''' Const used to build calls to ScreenScraper API
    ''' </summary>
    Private Const SSURL As String = "https://www.screenscraper.fr/api/"

    ''' <summary>
    ''' Build the generic part of the API Call URL
    ''' </summary>
    ''' <param name="methodName"></param>
    ''' <returns></returns>
    Public Function BuildGenericURL(methodName As String) As String
        Dim result As String = String.Empty

        Try
            'devid=xxx&devpassword=yyy&softname=zzz&output=xml&ssid=test&sspassword=test"

            result = SSURL & methodName & "?" &
                "devid=" & DevId & "&" &
                "devpassword=" & DevPassword & "&" &
                "softname=" & SoftwareName & "&" &
                "output=json&" &
                "ssid=" & Login & "&" &
                "sspassword=" & Password

        Catch ex As Exception
            Throw ex
        End Try

        Return result
    End Function

End Module
