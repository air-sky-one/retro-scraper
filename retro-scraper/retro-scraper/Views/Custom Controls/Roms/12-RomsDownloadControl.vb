Imports System.ComponentModel
Imports System.IO
Imports System.Text

Public Class _12_RomsDownloadControl

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
    Private _workerDetailsText As String = String.Empty

    ''' <summary>
    ''' Indicates if the background worker's job is done
    ''' </summary>
    Private _isJobDone As Boolean = False

    Private _mainCpt As Integer = 0
    Private _detailCpt As Integer = 0

    ''' <summary>
    ''' Component initialization
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _12_RomsDownloadControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me._parent = TryCast(Me.Parent.Parent, RomsContainerControl)

            If Me._parent Is Nothing Then Throw New Exception("Unexpected error")

            If Me._parent.RomsData.Select("IsChecked = 'True'").Count > 0 Then
                Me.ActionPanel.Visible = False
                Me.ActionWaitingControl.HeaderLabel.Text = ""
                Me.ActionWaitingControl.DetailsTextBox.Visible = False
                Me.ActionWaitingControl.MainWaitingProgressBar.Maximum = Me._parent.RomsData.Select("IsChecked = 'True'").Count
                Me.ActionWaitingControl.MainWaitingProgressBar.Style = ProgressBarStyle.Continuous
                Me.ActionWaitingControl.DetailsProgressBar.Maximum = Me._parent.RomsArtworks.Select("AssociatedMediaType <> ''").Count
                Me.ActionWaitingControl.DetailsProgressBar.Style = ProgressBarStyle.Continuous

                Me._parent.ButtonNext.Enabled = False
                Me._parent.ButtonPrevious.Visible = False

                ' start asynchrone screenscraper system list loading
                LoadBackgroundWorker.RunWorkerAsync()
            Else
                Me.ActionWaitingControl.Visible = False
                Me.DescriptionLabel.Text = "Please select at least one game :)"
                Me._parent.ButtonNext.Visible = False
            End If

        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Helper for downloading media
    ''' </summary>
    ''' <param name="game">game datarow</param>
    ''' <param name="art">artwork datarow</param>
    ''' <param name="mediaExtension">media extension file (ex: png, mp4)</param>
    ''' <param name="associatedColumns">list of associated columns names</param>
    Private Sub DownloadMedia(game As RomsDataSet.SSRomsRow,
                              art As RomsDataSet.ArtworksRow,
                              mediaExtension As String,
                              associatedColumns As List(Of String))

        Dim mediaPath As String = Me._parent.RomsPath & "\" & art.Path & "\" & game.filename & "." & mediaExtension
        Dim go As Boolean = True

        Try
            If File.Exists(mediaPath) Then
                If art.ForceDownload Then
                    File.Delete(mediaPath)
                Else
                    go = False
                End If
            End If

            If go Then
                For Each col As String In associatedColumns
                    If File.Exists(mediaPath) Then File.Delete(mediaPath)
                    If CBool(game("is_media_" & col)) Then My.Computer.Network.DownloadFile(game("media_" & col), mediaPath)
                Next
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Download
    ''' </summary>
    ''' <param name="worker"></param>
    ''' <param name="e"></param>
    ''' <returns></returns>
    Private Function Download(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Boolean
        Dim result As Boolean = False
        Dim cpt As Integer = 0

        Try
            ' folder init
            For Each art As RomsDataSet.ArtworksRow In Me._parent.RomsArtworks.Select("AssociatedMediaType <> ''")
                If Not Directory.Exists(Me._parent.RomsPath & "\" & art.Path) Then
                    Directory.CreateDirectory(Me._parent.RomsPath & "\" & art.Path)
                End If
            Next

            For Each game As RomsDataSet.SSRomsRow In Me._parent.RomsData.Select("IsChecked = 'True'")

                Me._mainProgressText = game.filename
                Me._mainCpt = Me._mainCpt + 1
                Me._detailCpt = 0

                worker.ReportProgress(cpt)

                For Each art As RomsDataSet.ArtworksRow In Me._parent.RomsArtworks.Select("AssociatedMediaType <> ''")
                    Try
                        Dim mediaPath As String = String.Empty

                        Select Case art.AssociatedMediaType
                            Case "Screenshots"
                                Me._workerDetailsText = "Screenshots"
                                Me._detailCpt = Me._detailCpt + 1
                                worker.ReportProgress(cpt)
                                DownloadMedia(game,
                                              art,
                                              "png",
                                              New List(Of String)(New String() {"screenshot",
                                                                                "screenshottitle"}))

                            Case "Fanarts"
                                Me._workerDetailsText = "Fanarts"
                                Me._detailCpt = Me._detailCpt + 1
                                worker.ReportProgress(cpt)
                                DownloadMedia(game,
                                              art,
                                              "png",
                                              New List(Of String)(New String() {"fanart"}))


                            Case "Video"
                                Me._workerDetailsText = "Video"
                                Me._detailCpt = Me._detailCpt + 1
                                worker.ReportProgress(cpt)
                                DownloadMedia(game,
                                              art,
                                              "mp4",
                                              New List(Of String)(New String() {"video"}))

                            Case "Wheels"
                                Me._workerDetailsText = "Wheels"
                                Me._detailCpt = Me._detailCpt + 1
                                worker.ReportProgress(cpt)
                                DownloadMedia(game,
                                              art,
                                              "png",
                                              New List(Of String)(New String() {"wheel_jp",
                                                                                "wheel_us",
                                                                                "wheel_wor"}))

                            Case "Carbon Wheels"
                                Me._workerDetailsText = "Carbon Wheels"
                                Me._detailCpt = Me._detailCpt + 1
                                worker.ReportProgress(cpt)
                                DownloadMedia(game,
                                              art,
                                              "png",
                                              New List(Of String)(New String() {"wheelcarbon_jp",
                                                                                "wheelcarbon_us",
                                                                                "wheelcarbon_wor"}))

                            Case "Steel Wheels"
                                Me._workerDetailsText = "Steel Wheels"
                                Me._detailCpt = Me._detailCpt + 1
                                worker.ReportProgress(cpt)
                                DownloadMedia(game,
                                              art,
                                              "png",
                                              New List(Of String)(New String() {"wheelsteel_jp",
                                                                                "wheelsteel_us",
                                                                                "wheelsteel_wor"}))

                            Case "Box Textures (all sides of the jacket)"
                                Me._workerDetailsText = "Box Textures"
                                Me._detailCpt = Me._detailCpt + 1
                                worker.ReportProgress(cpt)
                                DownloadMedia(game,
                                              art,
                                              "png",
                                              New List(Of String)(New String() {"boxtexture_jp",
                                                                                "boxtexture_us",
                                                                                "boxtexture_eu"}))

                            Case "Box 2D (Front side of the jacket)"
                                Me._workerDetailsText = "Box 2D"
                                Me._detailCpt = Me._detailCpt + 1
                                worker.ReportProgress(cpt)
                                DownloadMedia(game,
                                              art,
                                              "png",
                                              New List(Of String)(New String() {"box2d_jp",
                                                                                "box2d_us",
                                                                                "box2d_eu"}))

                            Case "Box 2D Side"
                                Me._workerDetailsText = "Box 2D Side"
                                Me._detailCpt = Me._detailCpt + 1
                                worker.ReportProgress(cpt)
                                DownloadMedia(game,
                                              art,
                                              "png",
                                              New List(Of String)(New String() {"box2d_side_jp",
                                                                                "box2d_side_us",
                                                                                "box2d_side_eu"}))

                            Case "Box 2D Back"
                                Me._workerDetailsText = "Box 2D Back"
                                Me._detailCpt = Me._detailCpt + 1
                                worker.ReportProgress(cpt)
                                DownloadMedia(game,
                                              art,
                                              "png",
                                              New List(Of String)(New String() {"box2d_back_jp",
                                                                                "box2d_back_us",
                                                                                "box2d_back_eu"}))

                            Case "Box 3D"
                                Me._workerDetailsText = "Box 3D"
                                Me._detailCpt = Me._detailCpt + 1
                                worker.ReportProgress(cpt)
                                DownloadMedia(game,
                                             art,
                                             "png",
                                             New List(Of String)(New String() {"box3d_jp",
                                                                               "box3d_us",
                                                                               "box3d_eu"}))

                            Case "Support Texture (Cartridge label)"
                                Me._workerDetailsText = "Support Texturek"
                                Me._detailCpt = Me._detailCpt + 1
                                worker.ReportProgress(cpt)
                                DownloadMedia(game,
                                             art,
                                             "png",
                                             New List(Of String)(New String() {"supporttexture_jp",
                                                                               "supporttexture_us",
                                                                               "supporttexture_eu"}))


                            Case "Support 2D (Cartridge)"
                                Me._workerDetailsText = "Support 2D"
                                Me._detailCpt = Me._detailCpt + 1
                                worker.ReportProgress(cpt)
                                DownloadMedia(game,
                                             art,
                                             "png",
                                             New List(Of String)(New String() {"support2d_jp",
                                                                               "support2d_us",
                                                                               "support2d_eu"}))

                            Case Else
                        End Select
                    Catch ex As Exception
                        Dim err As RomsDataSet.ErrorsSSRomsLoadingRow
                        err = Me._parent.RomsDataErrors.NewErrorsSSRomsLoadingRow()
                        err.type = LogsType.Download.ToString
                        err.filename = game.filename
                        err.details = art.Name & " - Exception - " & ex.Message
                        Me._parent.RomsDataErrors.AddErrorsSSRomsLoadingRow(err)

                        AddLogs(New Exception("Error downloading data from screenscraper.fr for : " & game.filename & " with return : " & art.Name & " - Exception - " & ex.Message))
                    End Try

                    game.isScraped = True

                Next

                Dim r As RomsDataSet.RomlistRow
                r = Me._parent.RomList.NewRomlistRow

                r.Name = game.filename

                If game.is_nom_jp Then r.Title = game.nom_jp
                If game.is_nom_us Then r.Title = game.nom_us
                If game.is_nom_wor Then r.Title = game.nom_wor
                If game.is_nom_eu Then r.Title = game.nom_eu

                r.Emulator = Me._parent.AttractModeSelectedSystem

                r.CloneOf = String.Empty

                If game.is_date_jp Then r.Year = game.date_jp
                If game.is_date_us Then r.Year = game.date_us
                If game.is_date_wor Then r.Year = game.date_wor
                If game.is_date_eu Then r.Year = game.date_eu

                r.Manufacturer = game.editeur

                If game.is_genres_pt Then r.Category = game.genres_pt
                If game.is_genres_es Then r.Category = game.genres_es
                If game.is_genres_de Then r.Category = game.genres_de
                If game.is_genres_fr Then r.Category = game.genres_fr
                If game.is_genres_en Then r.Category = game.genres_en

                r.Players = game.joueurs

                r.Rotation = game.rotation

                r.Control = game.controles

                r.Status = String.Empty
                r.DisplayCount = 0
                r.DisplayType = 0
                r.AltRomname = String.Empty
                r.AltTitle = String.Empty
                r.Extra = String.Empty
                r.Buttons = String.Empty


                Me._parent.RomList.AddRomlistRow(r)


                'media_screenshot
                'media_screenshottitle
                'media_fanart
                'media_video
                'media_wheel_us
                'media_wheel_jp
                'media_wheel_wor
                'media_wheelcarbon_us
                'media_wheelcarbon_jp
                'media_wheelcarbon_wor
                'media_wheelsteel_us
                'media_wheelsteel_jp
                'media_wheelsteel_wor
                'media_boxtexture_us
                'media_boxtexture_jp
                'media_boxtexture_eu
                'media_box2d_us
                'media_box2d_jp
                'media_box2d_eu
                'media_box2d_side_us
                'media_box2d_side_jp
                'media_box2d_side_eu
                'media_box2d_back_us
                'media_box2d_back_jp
                'media_box2d_back_eu
                'media_box3d_us
                'media_box3d_jp
                'media_box3d_eu
                'media_supporttexture_us
                'media_supporttexture_jp
                'media_supporttexture_eu
                'media_support2d_us
                'media_support2d_jp
                'media_support2d_eu
            Next

            Dim romlistFileContent As New StringBuilder

            'header
            If Me._parent.IsRomListNewFile Then
                For Each c As DataColumn In Me._parent.RomList.Columns
                    romlistFileContent.Append(c.ColumnName & ";")
                Next
                romlistFileContent.AppendLine()
            End If

            'content
            For Each c As RomsDataSet.RomlistRow In Me._parent.RomList
                romlistFileContent.AppendLine(c.Name.ToString & ";")
                romlistFileContent.AppendLine(c.Title.ToString & ";")
                romlistFileContent.AppendLine(c.Emulator.ToString & ";")
                romlistFileContent.AppendLine(c.CloneOf.ToString & ";")
                romlistFileContent.AppendLine(c.Year.ToString & ";")
                romlistFileContent.AppendLine(c.Manufacturer.ToString & ";")
                romlistFileContent.AppendLine(c.Category.ToString & ";")
                romlistFileContent.AppendLine(c.Players.ToString & ";")
                romlistFileContent.AppendLine(c.Rotation.ToString & ";")
                romlistFileContent.AppendLine(c.Control.ToString & ";")
                romlistFileContent.AppendLine(c.Status.ToString & ";")
                romlistFileContent.AppendLine(c.DisplayCount.ToString & ";")
                romlistFileContent.AppendLine(c.DisplayType.ToString & ";")
                romlistFileContent.AppendLine(c.AltRomname.ToString & ";")
                romlistFileContent.AppendLine(c.AltTitle.ToString & ";")
                romlistFileContent.AppendLine(c.Extra.ToString & ";")
                romlistFileContent.AppendLine(c.Buttons.ToString & ";")
                romlistFileContent.AppendLine()
            Next

            If Me._parent.IsRomListNewFile Then
                If File.Exists(Me._parent.RomsPath & "\romlist.txt") Then File.Delete(Me._parent.RomsPath & "\romlist.txt")
                File.WriteAllText(Me._parent.RomsPath & "\romlist.txt", romlistFileContent.ToString)
            Else
                File.AppendAllText(Me._parent.RomsPath & "\romlist.txt", romlistFileContent.ToString)
            End If



            'filename
            'extension
            'size
            'nom_us
            'nom_jp
            'nom_wor
            'nom_eu
            'cloneof
            'date_us
            'date_jp
            'date_wor
            'date_eu
            'editeur
            'genres_en
            'genres_fr
            'genres_de
            'genres_es
            'genres_pt
            'genres_pt
            'joueurs
            'rotation
            'controles
            'media_screenshot
            'media_screenshottitle
            'media_fanart
            'media_video
            'media_wheel_us
            'media_wheel_jp
            'media_wheel_wor
            'media_wheelcarbon_us
            'media_wheelcarbon_jp
            'media_wheelcarbon_wor
            'media_wheelsteel_us
            'media_wheelsteel_jp
            'media_wheelsteel_wor
            'media_boxtexture_us
            'media_boxtexture_jp
            'media_boxtexture_eu
            'media_box2d_us
            'media_box2d_jp
            'media_box2d_eu
            'media_box2d_side_us
            'media_box2d_side_jp
            'media_box2d_side_eu
            'media_box2d_back_us
            'media_box2d_back_jp
            'media_box2d_back_eu
            'media_box3d_us
            'media_box3d_jp
            'media_box3d_eu
            'media_supporttexture_us
            'media_supporttexture_jp
            'media_supporttexture_eu
            'media_support2d_us
            'media_support2d_jp
            'media_support2d_eu
            'local_romsize
            'local_romcrc
            'local_rommd5

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
    Private Sub LoadBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoadBackgroundWorker.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        e.Result = Download(worker, e)
    End Sub

    ''' <summary>
    ''' Update waiting progress update
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LoadBackgroundWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles LoadBackgroundWorker.ProgressChanged
        With Me.ActionWaitingControl
            .HeaderLabel.Text = "Download for " & Me._mainProgressText

            .MainProgressLabel.Text = Me._workerDetailsText
            .MainWaitingProgressBar.Value = Me._mainCpt

            .DetailsProgressBar.Value = Me._detailCpt

            '.DetailsTextBox.Text = Me._workerDetailsText
        End With
    End Sub

    ''' <summary>
    ''' Is triggered when Screen Scraper Games data loading is finished
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LoadBackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles LoadBackgroundWorker.RunWorkerCompleted
        If (e.Error Is Nothing) Or Not e.Cancelled Then
            Me.ActionWaitingControl.DetailsProgressBar.Visible = False
            Me.ActionWaitingControl.MainProgressLabel.Visible = False
            Me.ActionWaitingControl.HeaderLabel.Text = "Finished !"

            Me._parent.ButtonNext.Enabled = True
        End If
    End Sub
End Class
