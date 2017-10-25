Imports Newtonsoft.Json.Linq

Module ScrapSystemsHelper

    ''' <summary>
    ''' Retrieve Screen Scraper systems list
    ''' </summary>
    Public Function GetScreenScraperSystems(ByRef ScreenScraperSystemsList As RomsDataSet.ScreenScraperSystemsDataTable,
                                           ByRef workerDetailsLastLine As String) As Boolean
        Dim result = False
        Dim webClient As New System.Net.WebClient()
        Dim query As String = String.Empty
        Dim json As String = String.Empty

        Try
            ScreenScraperSystemsList.Clear()

            query = BuildGenericURL("systemesListe.php")
            workerDetailsLastLine = "fecthing screeenscraper.fr" & vbCrLf
            json = webClient.DownloadString(query)

            If Not String.IsNullOrEmpty(json) Then
                Dim o As JObject = JObject.Parse(json)
                Dim cpt As Integer = 0

                For Each s As JToken In o.SelectToken("response.systemes")
                    Dim r As RomsDataSet.ScreenScraperSystemsRow

                    cpt = cpt + 1

                    r = ScreenScraperSystemsList.NewRow

                    If s.SelectToken("id", False) IsNot Nothing Then r.Id = s.SelectToken("id", False) Else r.Id = String.Empty

                    If Not String.IsNullOrEmpty(r.Id) Then
                        If s.SelectToken("noms.nom_eu", False) IsNot Nothing Then r.Name_EU = s.SelectToken("noms.nom_eu", False) Else r.Name_EU = String.Empty
                        If s.SelectToken("noms.nom_us", False) IsNot Nothing Then r.Name_US = s.SelectToken("noms.nom_us", False) Else r.Name_US = String.Empty
                        If s.SelectToken("noms.nom_jp", False) IsNot Nothing Then r.Name_JP = s.SelectToken("noms.nom_jp", False) Else r.Name_JP = String.Empty

                        ' TODO : preferred language
                        Select Case AppGlobals.user(0).favregion
                            Case Else
                                r.Name = r.Name_EU
                        End Select

                        ScreenScraperSystemsList.AddScreenScraperSystemsRow(r)
                        workerDetailsLastLine = cpt.ToString & " : " & r.Name & vbCrLf
                    Else
                        workerDetailsLastLine = cpt.ToString & " : screenscraper.fr returned a system with no identifier. Not added to list." & vbCrLf
                    End If
                Next

                result = True
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return result
    End Function

End Module
