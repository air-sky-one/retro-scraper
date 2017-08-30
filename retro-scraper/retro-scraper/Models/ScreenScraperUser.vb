Public Module ScreenScraperUser

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

End Module
