Imports System.IO
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class RescrapRomlistFileForm
    Private Sub FolderPathButton_Click(sender As Object, e As EventArgs) Handles FolderPathButton.Click
        Dim path As String = String.Empty
        Dim searchPattern As String = "*.txt"
        Dim isErr As Boolean = False
        Dim cpt As Integer = 0
        Dim romlist As New RomsDataSet.RomlistDataTable
        Dim header As String() = Nothing

        Try
            Me.RomlistOpenFileDialog.Filter = "Text Files (*.txt)|*.txt"
            Me.RomlistOpenFileDialog.ShowDialog()
            path = Me.RomlistOpenFileDialog.FileName

            If Not path = String.Empty Then

                Dim sr As StreamReader = New StreamReader(path)

                Do While sr.Peek() >= 0
                    Dim line As String = sr.ReadLine
                    Dim elements As String() = line.Split(";")

                    If elements.Count <= 1 Then
                        Throw New Exception("The romlist file structure doesn't match th standard file structure")
                    Else
                        If line.First().ToString.Equals("#") And cpt = 0 Then
                            header = elements
                            header(0) = header(0).Substring(1, header(0).Length - 1)
                            For Each c As DataColumn In romlist.Columns
                                Dim isOk As Boolean = False
                                For Each el As String In header
                                    If el = c.ColumnName Then
                                        isOk = True
                                        Exit For
                                    End If
                                Next
                                If Not isOk Then Throw New Exception("The romlist file structure doesn't match th standard file structure")
                            Next
                        ElseIf cpt > 0 Then
                            If Not line.First().ToString.Equals("#") Then
                                Dim row As RomsDataSet.RomlistRow
                                row = romlist.NewRomlistRow

                                For Each c As DataColumn In romlist.Columns
                                    Dim i As Integer = 0
                                    For Each el As String In header
                                        If el = c.ColumnName Then
                                            row(el) = elements(i)
                                        End If
                                        i = i + 1
                                    Next
                                Next
                                romlist.Rows.Add(row)
                            End If
                        Else
                            ' if the first line of the file doesn't start with a '#' character
                            Throw New Exception("The romlist file structure doesn't match th standard file structure")
                        End If
                    End If

                    cpt = cpt + 1
                Loop
                sr.Close()

                For Each r As RomsDataSet.RomlistRow In romlist
                    Dim query As String = String.Empty
                    query = BuildGenericURL("jeuinfos.php")
                    query = query & "&crc="
                    query = query & "&md5="
                    query = query & "&sha1="
                    query = query & "&systemid="
                    query = query & "&romnom=" & r.Name.ToString
                    query = query & "&romtaille="


                    Dim webClient As New System.Net.WebClient()

                    Dim json As String

                    ' getting result
                    webClient.Encoding = Encoding.UTF8

                    Try
                        json = webClient.DownloadString(query)


                        If Not String.IsNullOrEmpty(json) _
                       And Not json.Contains("Erreur : Rom/Iso/Dossier non trouvée !") _
                       And Not json.Contains("Erreur : Jeu non trouvée !") Then

                            ' GetGameData(json, rom)
                            Dim o As JObject = JObject.Parse(json)

                            For Each s As JToken In o.SelectToken("response.jeu")
                                ' GetData(o, rom.genres_en, "response.jeu.genres.genres_en")
                                Dim path2 As String = "response.jeu.genres.genres_en"
                                If o.SelectToken(path, False) IsNot Nothing Then
                                    Dim t As Type = o.SelectToken(path, False).GetType

                                    Select Case t
                                        Case GetType(JValue)
                                            ' value = o.SelectToken(path2, False)
                                            r.Category = o.SelectToken(path2, False)
                                        Case GetType(JArray)
                                            Dim b As New StringBuilder
                                            Dim cpt2 As Integer = 0


                                            For Each result In o.SelectToken(path2, False)
                                                b.Append("/" & e.ToString)

                                                cpt2 = cpt2 + 1
                                            Next
                                            b.Remove(0, 1)
                                            ' value = b.ToString.Trim
                                            r.Category = b.ToString.Trim
                                        Case Else
                                    End Select
                                Else
                                    ' value = String.Empty
                                    r.Category = String.Empty
                                End If
                            Next
                        End If


                    Catch ex As System.Net.WebException
                        Debug.WriteLine("[ERROR] : " & query)
                    End Try

                Next

                cpt = 0
                Dim l As String = "#"
                For Each c As DataColumn In romlist.Columns
                    l = l & c.ColumnName & ";"
                    cpt = cpt + 1
                Next

                Console.WriteLine(l)


                For Each r As RomsDataSet.RomlistRow In romlist
                    l = String.Empty

                    For Each c As DataColumn In romlist.Columns
                        l = r(c).ToString + ";"
                    Next

                    Debug.WriteLine(l)
                Next

                '' https://www.screenscraper.fr/api/jeuInfos.php?devid=xxx&devpassword=yyy&softname=zzz&output=json&ssid=test&sspassword=test&crc=&systemeid=&romtype=rom&romnom=Sonic%20The%20Hedgehog%202%20(World).zip&romtaille=

                'Dim query As String = String.Empty
                'query = BuildGenericURL("jeuInfos.php")
                'query = query & "&crc="
                'query = query & "&md5="
                'query = query & "&sha1="
                'query = query & "&systemid="
                'query = query & "&romnom=" & "Sonic The Hedgehog 2 (World)"
                'query = query & "&romtaille="

                'Stop
            End If
        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub
End Class