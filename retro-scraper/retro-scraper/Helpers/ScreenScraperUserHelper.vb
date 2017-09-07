Imports System.IO
Imports Newtonsoft.Json.Linq
Imports retro_scraper_libs

Public Module ScreenScraperUserHelper

    ''' <summary>
    ''' ScreenScraper user's login
    ''' </summary>
    ''' <returns></returns>
    Public Property Login() As String
        Get
            Return CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).login
        End Get
        Set(ByVal value As String)
            CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).login = value
        End Set
    End Property

    ''' <summary>
    ''' ScreenScraper user's password
    ''' </summary>
    ''' <returns></returns>
    Public Property Password() As String
        Get
            Return CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).password
        End Get
        Set(ByVal value As String)
            CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).password = value
        End Set
    End Property

    ''' <summary>
    ''' ScreenScraper user's niveau
    ''' </summary>
    ''' <returns></returns>
    Public Property Niveau() As Integer
        Get
            Return CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).niveau
        End Get
        Set(ByVal value As Integer)
            CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).niveau = value
        End Set
    End Property

    ''' <summary>
    ''' ScreenScraper user's ApplicationMode
    ''' </summary>
    ''' <returns></returns>
    Public Property ApplicationMode() As String
        Get
            Return CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).ApplicationMode
        End Get
        Set(ByVal value As String)
            CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).ApplicationMode = value
        End Set
    End Property

    ''' <summary>
    ''' ScreenScraper user's contribution
    ''' </summary>
    ''' <returns></returns>
    Public Property Contribution() As Integer
        Get
            Return CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).contribution
        End Get
        Set(ByVal value As Integer)
            CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).contribution = value
        End Set
    End Property

    ''' <summary>
    ''' ScreenScraper user's uploadsysteme
    ''' </summary>
    ''' <returns></returns>
    Public Property Uploadsysteme() As Integer
        Get
            Return CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).uploadsysteme
        End Get
        Set(ByVal value As Integer)
            CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).uploadsysteme = value
        End Set
    End Property

    ''' <summary>
    ''' ScreenScraper user's uploadinfos
    ''' </summary>
    ''' <returns></returns>
    Public Property Uploadinfos() As Integer
        Get
            Return CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).uploadinfos
        End Get
        Set(ByVal value As Integer)
            CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).uploadinfos = value
        End Set
    End Property

    ''' <summary>
    ''' ScreenScraper user's romasso
    ''' </summary>
    ''' <returns></returns>
    Public Property Romasso() As Integer
        Get
            Return CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).romasso
        End Get
        Set(ByVal value As Integer)
            CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).romasso = value
        End Set
    End Property

    ''' <summary>
    ''' ScreenScraper user's uploadmedia
    ''' </summary>
    ''' <returns></returns>
    Public Property Uploadmedia() As Integer
        Get
            Return CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).uploadmedia
        End Get
        Set(ByVal value As Integer)
            CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).uploadmedia = value
        End Set
    End Property

    ''' <summary>
    ''' ScreenScraper user's maxthreads
    ''' </summary>
    ''' <returns></returns>
    Public Property Maxthreads() As Integer
        Get
            Return CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).maxthreads
        End Get
        Set(ByVal value As Integer)
            CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).maxthreads = value
        End Set
    End Property

    ''' <summary>
    ''' ScreenScraper user's maxdownloadspeed
    ''' </summary>
    ''' <returns></returns>
    Public Property Maxdownloadspeed() As Integer
        Get
            Return CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).maxdownloadspeed
        End Get
        Set(ByVal value As Integer)
            CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).maxdownloadspeed = value
        End Set
    End Property

    ''' <summary>
    ''' ScreenScraper user's Visites
    ''' </summary>
    ''' <returns></returns>
    Public Property visites() As Integer
        Get
            Return CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).visites
        End Get
        Set(ByVal value As Integer)
            CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).visites = value
        End Set
    End Property

    ''' <summary>
    ''' ScreenScraper user's datedernierevisite
    ''' </summary>
    ''' <returns></returns>
    Public Property Datedernierevisite() As DateTime
        Get
            Return CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).datedernierevisite
        End Get
        Set(ByVal value As DateTime)
            CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).datedernierevisite = value
        End Set
    End Property

    ''' <summary>
    ''' ScreenScraper user's favregion
    ''' </summary>
    ''' <returns></returns>
    Public Property Favregion() As String
        Get
            Return CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).favregion
        End Get
        Set(ByVal value As String)
            CType(AppGlobals.user(0), retro_scraper_libs.User.SSUSerRow).favregion = value
        End Set
    End Property

    ''' <summary>
    ''' Check and import ScreenScraper Data and credentials
    ''' </summary>
    ''' <returns></returns>
    Public Function isScreenScraperUserFileOK() As Boolean
        Dim result As Boolean = False

        Try
            result = ReadAndLoadEncryptedFile(AppGlobals.userFilePath, AppGlobals.user)
        Catch ex As Exception
            Throw ex
        End Try

        Return result
    End Function

    ''' <summary>
    ''' Test and retrieve ScreenScraper user's data
    ''' </summary>
    ''' <param name="login"></param>
    ''' <param name="password"></param>
    ''' <returns></returns>
    Public Function GetScreenScraperUser(login As String,
                                         password As String,
                                         Optional isRegistered As Boolean = True) As Boolean
        Dim result As Boolean = False
        Dim webClient As New System.Net.WebClient()
        Dim query As String = String.Empty
        Dim json As String = String.Empty
        Dim u As User.SSUSerRow = Nothing

        Try
            If isRegistered Then
                query = BuildGenericURL("ssuserInfos.php")

                u = AppGlobals.user(0)
            Else
                query = "https://www.screenscraper.fr/api/ssuserInfos.php?" &
                "devid=" & DevId & "&" &
                "devpassword=" & DevPassword & "&" &
                "softname=" & SoftwareName & "&" &
                "output=json&" &
                "ssid=" & login & "&" &
                "sspassword=" & password

                AppGlobals.user.Rows.Clear()

                u = AppGlobals.user.NewSSUSerRow
                u.login = login
                u.password = password
                AppGlobals.user.AddSSUSerRow(u)
            End If

            ' getting result
            json = webClient.DownloadString(query)

            If Not String.IsNullOrEmpty(json) Then
                Dim o As JObject = JObject.Parse(json)

                If o.SelectToken("response.ssuser.niveau") IsNot Nothing Then

                    Dim tmp As Integer
                    Integer.TryParse(o.SelectToken("response.ssuser.niveau"), tmp)

                    If tmp > 0 Then
                        Niveau = o.SelectToken("response.ssuser.niveau")
                        Contribution = o.SelectToken("response.ssuser.contribution")
                        Uploadsysteme = o.SelectToken("response.ssuser.uploadsysteme")
                        Uploadinfos = o.SelectToken("response.ssuser.uploadinfos")
                        Romasso = o.SelectToken("response.ssuser.romasso")
                        Uploadmedia = o.SelectToken("response.ssuser.uploadmedia")
                        Maxthreads = o.SelectToken("response.ssuser.maxthreads")
                        Maxdownloadspeed = o.SelectToken("response.ssuser.maxdownloadspeed")
                        visites = o.SelectToken("response.ssuser.visites")
                        Datedernierevisite = o.SelectToken("response.ssuser.datedernierevisite")
                        Favregion = o.SelectToken("response.ssuser.favregion")

                        AppGlobals.user.WriteXml(AppGlobals.userFilePath)

                        Dim encode As String = InternalEncryption.Encode(File.ReadAllText(AppGlobals.userFilePath), LibGlobals.EncryptionPwd)

                        File.Delete(AppGlobals.userFilePath)

                        File.WriteAllText(AppGlobals.userFilePath, encode)

                        result = True
                    End If
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return result
    End Function

End Module
