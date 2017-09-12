Imports System.ComponentModel
Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class _5_RomLoadingProcessControl

    ''' <summary>
    ''' Parent con tainer control
    ''' </summary>
    Private _parent As RomsContainerControl

    ''' <summary>
    ''' Main progress Text to display
    ''' </summary>
    Private _mainProgressText As String

    ''' <summary>
    ''' Last line of waiting details to display
    ''' </summary>
    Private _workerDetailsLastLine As String = String.Empty

    ''' <summary>
    ''' Indicates if the background worker's job is done
    ''' </summary>
    Private _isJobDone As Boolean = False

    ''' <summary>
    ''' Component initialization
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _5_RomLoadingProcessControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me._parent = TryCast(Me.Parent.Parent, RomsContainerControl)

            If Me._parent Is Nothing Then Throw New Exception("Unexpected error")

            Me.ActionPanel.Visible = False

            Dim collection = From fi In New DirectoryInfo(Me._parent.RomsPath).GetFiles()
                             Where Me._parent.RomsExtensions.Contains(fi.Extension.ToUpper())

            If collection.Count > 0 Then
                With Me.ActionWaitingControl
                    .Visible = True
                    .HeaderLabel.Text = "Please wait while data and media's URL are retrieved from screenscraper.fr"
                    .DetailsTextBox.Visible = True
                    .DetailsProgressBar.Visible = True
                    .MainProgressLabel.Visible = True

                    .MainWaitingProgressBar.Style = ProgressBarStyle.Continuous
                    .MainWaitingProgressBar.Maximum = collection.Count
                End With

                Me._parent.ButtonNext.Enabled = False
                Me._parent.ButtonPrevious.Enabled = False

                ' start asynchrone screenscraper system list loading
                LoadBackgroundWorker.RunWorkerAsync()
            Else
                Throw New Exception("Oups ! It seems that your roms have disapeared from the selected folder.")
            End If

        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Retrieve the games data
    ''' </summary>
    ''' <param name="worker"></param>
    ''' <param name="e"></param>
    ''' <returns></returns>
    Private Function GetGamesData(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Boolean
        Dim result As Boolean = False
        Dim cpt As Integer = 0

        Dim webClient As New System.Net.WebClient()
        Dim query As String = String.Empty
        Dim json As String

        Try
            Dim collection = From fi In New DirectoryInfo(Me._parent.RomsPath).GetFiles()
                             Where Me._parent.RomsExtensions.Contains(fi.Extension.ToUpper())

            If collection.Count > 0 Then

                Me._parent.RomsData.Clear()

                For Each file As FileInfo In collection
                    Dim rom As RomsDataSet.RomRow = Me._parent.RomsData.NewRomRow
                    Dim fileName As String = file.Name

                    rom.extension = fileName.Substring(fileName.LastIndexOf("."))
                    rom.filename = fileName.Substring(0, fileName.Length - rom.extension.Length)

                    Me._mainProgressText = rom.filename

                    rom.size = New FileInfo(file.FullName).Length
                    rom.local_rommd5 = md5_hash(file.FullName)

                    ' interrogation
                    query = BuildGenericURL("jeuInfos.php")
                    query = query & "&crc="
                    query = query & "&md5=" & rom.local_rommd5
                    query = query & "&sha1="
                    query = query & "&systemid=" & Me._parent.ScreenScraperSelectedSystem
                    query = query & "&romnom=" & rom.filename
                    query = query & "&romtaille=" & rom.size

                    ' getting result
                    json = webClient.DownloadString(query)

                    If Not String.IsNullOrEmpty(json) _
                        And Not json.Contains("Erreur : Rom/Iso/Dossier non trouvÃ©e !") _
                        And Not json.Contains("Erreur : Jeu non trouvÃ©e !") Then

                        Try
                            Dim o As JObject = JObject.Parse(json)

                            For Each s As JToken In o.SelectToken("response.jeu")
                                If o.SelectToken("response.jeu.nom", False) IsNot Nothing Then rom.name = o.SelectToken("response.jeu.nom", False) Else rom.name = String.Empty
                                If o.SelectToken("response.jeu.noms.nom_us", False) IsNot Nothing Then rom.name_us = o.SelectToken("response.jeu.noms.nom_us", False) Else rom.name_us = String.Empty
                                If o.SelectToken("response.jeu.noms.nom_jp", False) IsNot Nothing Then rom.name_jp = o.SelectToken("response.jeu.noms.nom_jp", False) Else rom.name_jp = String.Empty
                                If o.SelectToken("response.jeu.noms.nom_eu", False) IsNot Nothing Then rom.name_eu = o.SelectToken("response.jeu.noms.nom_eu", False) Else rom.name_eu = String.Empty
                                If o.SelectToken("response.jeu.noms.nom_sp", False) IsNot Nothing Then rom.name_sp = o.SelectToken("response.jeu.noms.nom_sp", False) Else rom.name_sp = String.Empty
                                If o.SelectToken("response.jeu.noms.nom_de", False) IsNot Nothing Then rom.name_de = o.SelectToken("response.jeu.noms.nom_de", False) Else rom.name_de = String.Empty
                                If o.SelectToken("response.jeu.noms.nom_ss", False) IsNot Nothing Then rom.name_ss = o.SelectToken("response.jeu.noms.nom_ss", False) Else rom.name_ss = String.Empty

                                If o.SelectToken("response.jeu.joueurs", False) IsNot Nothing Then rom.players = o.SelectToken("response.jeu.joueurs", False) Else rom.players = String.Empty
                                If o.SelectToken("response.jeu.note", False) IsNot Nothing Then rom.score = o.SelectToken("response.jeu.note", False) Else rom.score = String.Empty

                                If o.SelectToken("response.jeu.synopsis.synopsis_en", False) IsNot Nothing Then rom.synopsis_en = o.SelectToken("response.jeu.synopsis.synopsis_en", False) Else rom.synopsis_en = String.Empty
                                If o.SelectToken("response.jeu.synopsis.synopsis_fr", False) IsNot Nothing Then rom.synopsis_fr = o.SelectToken("response.jeu.synopsis.synopsis_fr", False) Else rom.synopsis_fr = String.Empty
                                If o.SelectToken("response.jeu.synopsis.synopsis_de", False) IsNot Nothing Then rom.synopsis_de = o.SelectToken("response.jeu.synopsis.synopsis_de", False) Else rom.synopsis_de = String.Empty
                                If o.SelectToken("response.jeu.synopsis.synopsis_es", False) IsNot Nothing Then rom.synopsis_es = o.SelectToken("response.jeu.synopsis.synopsis_es", False) Else rom.synopsis_es = String.Empty

                                If o.SelectToken("response.jeu.dates.date_us", False) IsNot Nothing Then rom.date_us = o.SelectToken("response.jeu.dates.date_us", False) Else rom.date_us = String.Empty
                                If o.SelectToken("response.jeu.dates.date_fr", False) IsNot Nothing Then rom.date_fr = o.SelectToken("response.jeu.dates.date_fr", False) Else rom.date_fr = String.Empty
                                If o.SelectToken("response.jeu.dates.date_wor", False) IsNot Nothing Then rom.date_wor = o.SelectToken("response.jeu.dates.date_wor", False) Else rom.date_wor = String.Empty

                                If o.SelectToken("response.jeu.genres.genres_en", False) IsNot Nothing Then rom.genre_en = o.SelectToken("response.jeu.genres.genres_en", False)(0) Else rom.genre_en = String.Empty
                                If o.SelectToken("response.jeu.genres.genres_fr", False) IsNot Nothing Then rom.genre_fr = o.SelectToken("response.jeu.genres.genres_fr", False)(0) Else rom.genre_fr = String.Empty
                                If o.SelectToken("response.jeu.genres.genres_de", False) IsNot Nothing Then rom.genre_de = o.SelectToken("response.jeu.genres.genres_de", False)(0) Else rom.genre_de = String.Empty
                                If o.SelectToken("response.jeu.genres.genres_es", False) IsNot Nothing Then rom.genre_es = o.SelectToken("response.jeu.genres.genres_es", False)(0) Else rom.genre_es = String.Empty

                                If o.SelectToken("response.jeu.medias.media_screenshot", False) IsNot Nothing Then rom.media_screenshot = o.SelectToken("response.jeu.medias.media_screenshot", False) Else rom.media_screenshot = String.Empty
                                If o.SelectToken("response.jeu.medias.media_fanart", False) IsNot Nothing Then rom.media_fanart = o.SelectToken("response.jeu.medias.media_fanart", False) Else rom.media_fanart = String.Empty
                                If o.SelectToken("response.jeu.medias.media_video", False) IsNot Nothing Then rom.media_video = o.SelectToken("response.jeu.medias.media_video", False) Else rom.media_video = String.Empty

                                If o.SelectToken("response.jeu.medias.media_wheels.media_wheel_us", False) IsNot Nothing Then rom.media_wheel_us = o.SelectToken("response.jeu.medias.media_wheels.media_wheel_us", False) Else rom.media_wheel_us = String.Empty
                                If o.SelectToken("response.jeu.medias.media_wheels.media_wheel_eu", False) IsNot Nothing Then rom.media_wheel_eu = o.SelectToken("response.jeu.medias.media_wheels.media_wheel_eu", False) Else rom.media_wheel_eu = String.Empty
                                If o.SelectToken("response.jeu.medias.media_wheels.media_wheel_jp", False) IsNot Nothing Then rom.media_wheel_eu = o.SelectToken("response.jeu.medias.media_wheels.media_wheel_jp", False) Else rom.media_wheel_jp = String.Empty

                                If o.SelectToken("response.jeu.medias.media_wheelscarbon.media_wheelcarbon_us", False) IsNot Nothing Then rom.media_wheelcarbon_us = o.SelectToken("response.jeu.medias.media_wheelscarbon.media_wheelcarbon_us", False) Else rom.media_wheelcarbon_us = String.Empty
                                If o.SelectToken("response.jeu.medias.media_wheelscarbon.media_wheelcarbon_eu", False) IsNot Nothing Then rom.media_wheelcarbon_eu = o.SelectToken("response.jeu.medias.media_wheelscarbon.media_wheelcarbon_eu", False) Else rom.media_wheelcarbon_eu = String.Empty
                                If o.SelectToken("response.jeu.medias.media_wheelscarbon.media_wheelcarbon_jp", False) IsNot Nothing Then rom.media_wheelcarbon_jp = o.SelectToken("response.jeu.medias.media_wheelscarbon.media_wheelcarbon_jp", False) Else rom.media_wheelcarbon_jp = String.Empty

                                If o.SelectToken("response.jeu.medias.media_wheelssteel.media_wheelsteel_us", False) IsNot Nothing Then rom.media_wheelsteel_us = o.SelectToken("response.jeu.medias.media_wheelssteel.media_wheelsteel_us", False) Else rom.media_wheelsteel_us = String.Empty
                                If o.SelectToken("response.jeu.medias.media_wheelssteel.media_wheelsteel_eu", False) IsNot Nothing Then rom.media_wheelsteel_eu = o.SelectToken("response.jeu.medias.media_wheelssteel.media_wheelsteel_eu", False) Else rom.media_wheelsteel_eu = String.Empty
                                If o.SelectToken("response.jeu.medias.media_wheelssteel.media_wheelsteel_jp", False) IsNot Nothing Then rom.media_wheelsteel_jp = o.SelectToken("response.jeu.medias.media_wheelssteel.media_wheelsteel_jp", False) Else rom.media_wheelsteel_jp = String.Empty

                                If o.SelectToken("response.jeu.medias.media_boxs.media_boxstexture.media_boxtexture_us", False) IsNot Nothing Then rom.media_boxtexture_us = o.SelectToken("response.jeu.medias.media_boxs.media_boxstexture.media_boxtexture_us", False) Else rom.media_boxtexture_us = String.Empty
                                If o.SelectToken("response.jeu.medias.media_boxs.media_boxstexture.media_boxtexture_jp", False) IsNot Nothing Then rom.media_boxtexture_jp = o.SelectToken("response.jeu.medias.media_boxs.media_boxstexture.media_boxtexture_jp", False) Else rom.media_boxtexture_jp = String.Empty
                                If o.SelectToken("response.jeu.medias.media_boxs.media_boxstexture.media_boxtexture_eu", False) IsNot Nothing Then rom.media_boxtexture_eu = o.SelectToken("response.jeu.medias.media_boxs.media_boxstexture.media_boxtexture_eu", False) Else rom.media_boxtexture_eu = String.Empty

                                If o.SelectToken("response.jeu.medias.media_boxs.media_boxs2d.media_box2d_us", False) IsNot Nothing Then rom.media_box2d_us = o.SelectToken("response.jeu.medias.media_boxs.media_boxs2d.media_box2d_us", False) Else rom.media_box2d_us = String.Empty
                                If o.SelectToken("response.jeu.medias.media_boxs.media_boxs2d.media_box2d_eu", False) IsNot Nothing Then rom.media_box2d_eu = o.SelectToken("response.jeu.medias.media_boxs.media_boxs2d.media_box2d_eu", False) Else rom.media_box2d_eu = String.Empty
                                If o.SelectToken("response.jeu.medias.media_boxs.media_boxs2d.media_box2d_jp", False) IsNot Nothing Then rom.media_box2d_jp = o.SelectToken("response.jeu.medias.media_boxs.media_boxs2d.media_box2d_jp", False) Else rom.media_box2d_jp = String.Empty

                                If o.SelectToken("response.jeu.medias.media_boxs.media_boxs2d-side.media_box2d-side_us", False) IsNot Nothing Then rom.media_box2d_side_us = o.SelectToken("response.jeu.medias.media_boxs.media_boxs2d-side.media_box2d-side_us", False) Else rom.media_box2d_side_us = String.Empty
                                If o.SelectToken("response.jeu.medias.media_boxs.media_boxs2d-side.media_box2d-side_jp", False) IsNot Nothing Then rom.media_box2d_side_jp = o.SelectToken("response.jeu.medias.media_boxs.media_boxs2d-side.media_box2d-side_jp", False) Else rom.media_box2d_side_jp = String.Empty
                                If o.SelectToken("response.jeu.medias.media_boxs.media_boxs2d-side.media_box2d-side_eu", False) IsNot Nothing Then rom.media_box2d_side_eu = o.SelectToken("response.jeu.medias.media_boxs.media_boxs2d-side.media_box2d-side_eu", False) Else rom.media_box2d_side_eu = String.Empty

                                If o.SelectToken("response.jeu.medias.media_boxs.media_boxs2d-back.media_box2d-back_us", False) IsNot Nothing Then rom.media_box2d_side_us = o.SelectToken("response.jeu.medias.media_boxs.media_boxs2d-back.media_box2d-back_us", False) Else rom.media_box2d_side_us = String.Empty
                                If o.SelectToken("response.jeu.medias.media_boxs.media_boxs2d-back.media_box2d-back_jp", False) IsNot Nothing Then rom.media_box2d_side_jp = o.SelectToken("response.jeu.medias.media_boxs.media_boxs2d-back.media_box2d-back_jp", False) Else rom.media_box2d_side_jp = String.Empty
                                If o.SelectToken("response.jeu.medias.media_boxs.media_boxs2d-back.media_box2d-back_eu", False) IsNot Nothing Then rom.media_box2d_side_eu = o.SelectToken("response.jeu.medias.media_boxs.media_boxs2d-back.media_box2d-back_eu", False) Else rom.media_box2d_side_eu = String.Empty

                                If o.SelectToken("response.jeu.medias.media_boxs.media_boxs3d.media_box3d_us", False) IsNot Nothing Then rom.media_box3d_us = o.SelectToken("response.jeu.medias.media_boxs.media_boxs3d.media_box3d_us", False) Else rom.media_box3d_us = String.Empty
                                If o.SelectToken("response.jeu.medias.media_boxs.media_boxs3d.media_box3d_jp", False) IsNot Nothing Then rom.media_box3d_jp = o.SelectToken("response.jeu.medias.media_boxs.media_boxs3d.media_box3d_jp", False) Else rom.media_box3d_jp = String.Empty
                                If o.SelectToken("response.jeu.medias.media_boxs.media_boxs3d.media_box3d_eu", False) IsNot Nothing Then rom.media_box3d_eu = o.SelectToken("response.jeu.medias.media_boxs.media_boxs3d.media_box3d_eu", False) Else rom.media_box3d_eu = String.Empty

                                If o.SelectToken("response.jeu.medias.media_supports.media_supportstexture.media_supporttexture_us", False) IsNot Nothing Then rom.media_supporttexture_us = o.SelectToken("response.jeu.medias.media_supports.media_supportstexture.media_supporttexture_us", False) Else rom.media_box3d_us = String.Empty
                                If o.SelectToken("response.jeu.medias.media_supports.media_supportstexture.media_supporttexture_jp", False) IsNot Nothing Then rom.media_supporttexture_jp = o.SelectToken("response.jeu.medias.media_supports.media_supportstexture.media_supporttexture_jp", False) Else rom.media_box3d_jp = String.Empty
                                If o.SelectToken("response.jeu.medias.media_supports.media_supportstexture.media_supporttexture_eu", False) IsNot Nothing Then rom.media_supporttexture_eu = o.SelectToken("response.jeu.medias.media_supports.media_supportstexture.media_supporttexture_eu", False) Else rom.media_box3d_eu = String.Empty

                                If o.SelectToken("response.jeu.medias.media_supports.media_supports2d.media_support2d_us", False) IsNot Nothing Then rom.media_supporttexture_us = o.SelectToken("response.jeu.medias.media_supports.media_supports2d.media_support2d_us", False) Else rom.media_box3d_us = String.Empty
                                If o.SelectToken("response.jeu.medias.media_supports.media_supports2d.media_support2d_jp", False) IsNot Nothing Then rom.media_supporttexture_jp = o.SelectToken("response.jeu.medias.media_supports.media_supports2d.media_support2d_jp", False) Else rom.media_box3d_jp = String.Empty
                                If o.SelectToken("response.jeu.medias.media_supports.media_supports2d.media_support2d_eu", False) IsNot Nothing Then rom.media_supporttexture_eu = o.SelectToken("response.jeu.medias.media_supports.media_supports2d.media_support2d_eu", False) Else rom.media_box3d_eu = String.Empty

                                If o.SelectToken("response.jeu.medias.media_manuels.media_manuel_us", False) IsNot Nothing Then rom.media_manuel_us = o.SelectToken("response.jeu.medias.media_manuels.media_manuel_us", False) Else rom.media_box3d_us = String.Empty
                                If o.SelectToken("response.jeu.medias.media_manuels.media_manuel_jp", False) IsNot Nothing Then rom.media_manuel_jp = o.SelectToken("response.jeu.medias.media_manuels.media_manuel_jp", False) Else rom.media_box3d_jp = String.Empty
                                If o.SelectToken("response.jeu.medias.media_manuels.media_manuel_eu", False) IsNot Nothing Then rom.media_manuel_eu = o.SelectToken("response.jeu.medias.media_manuels.media_manuel_eu", False) Else rom.media_box3d_eu = String.Empty

                            Next
                        Catch ex As Exception
                            ' TODO : Error
                        End Try

                        Me._workerDetailsLastLine = "Building index for " & rom.filename & " Ok" & vbCrLf

                        Me._parent.RomsData.AddRomRow(rom)

                    Else
                        Me._workerDetailsLastLine = "<<< - !!! ERROR !!! " & rom.filename & " not found on screenscraper.fr !!! - >>>" & vbCrLf

                        AddLogs(New Exception("Error retrieving data from screenscraper.fr for : " & rom.filename & " with return : " & json))
                    End If



                    cpt = cpt + 1
                    worker.ReportProgress(cpt)

                Next

                result = True
            Else
                Throw New Exception("Oups ! It seems that your roms have disapeared from the selected folder.")
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return result
    End Function

    ''' <summary>
    ''' Defines the asynchronous Job for loading Screen Scraper data
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LoadBackgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles LoadBackgroundWorker.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        e.Result = GetGamesData(worker, e)
    End Sub

    ''' <summary>
    ''' Update waiting progress update
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LoadBackgroundWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles LoadBackgroundWorker.ProgressChanged
        With Me.ActionWaitingControl
            .MainProgressLabel.Text = Me._mainProgressText
            .MainWaitingProgressBar.Value = e.ProgressPercentage

            .DetailsTextBox.AppendText(Me._workerDetailsLastLine)
        End With
    End Sub

    ''' <summary>
    ''' Is triggered when Screen Scraper Games data loading is finished
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LoadBackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles LoadBackgroundWorker.RunWorkerCompleted
        If (e.Error Is Nothing) Or Not e.Cancelled Then
            Me.ActionWaitingControl.DetailsTextBox.Enabled = True
        End If
    End Sub
End Class
