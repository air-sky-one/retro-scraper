Module DevData

    ''' <summary>
    ''' ScreenScraper DevId
    ''' </summary>
    ''' <returns></returns>
    Public Property DevId() As String
        Get
            Return CType(AppGlobals.licence(0), retro_scraper_libs.Licence.DevRow).DevId
        End Get
        Set(ByVal value As String)
            CType(AppGlobals.licence(0), retro_scraper_libs.Licence.DevRow).DevId = value
        End Set
    End Property

    ''' <summary>
    ''' ScreenScraper DevPassword
    ''' </summary>
    ''' <returns></returns>
    Public Property DevPassword() As String
        Get
            Return CType(AppGlobals.licence(0), retro_scraper_libs.Licence.DevRow).DevPassword
        End Get
        Set(ByVal value As String)
            CType(AppGlobals.licence(0), retro_scraper_libs.Licence.DevRow).DevPassword = value
        End Set
    End Property

    ''' <summary>
    ''' ScreenScraper SoftwareName
    ''' </summary>
    ''' <returns></returns>
    Public Property SoftwareName() As String
        Get
            Return CType(AppGlobals.licence(0), retro_scraper_libs.Licence.DevRow).SoftwareName
        End Get
        Set(ByVal value As String)
            CType(AppGlobals.licence(0), retro_scraper_libs.Licence.DevRow).SoftwareName = value
        End Set
    End Property

    ''' <summary>
    ''' ScreenScraper SoftwareVersion
    ''' </summary>
    ''' <returns></returns>
    Public Property SoftwareVersion() As String
        Get
            Return CType(AppGlobals.licence(0), retro_scraper_libs.Licence.DevRow).SoftwareVersion
        End Get
        Set(ByVal value As String)
            CType(AppGlobals.licence(0), retro_scraper_libs.Licence.DevRow).SoftwareVersion = value
        End Set
    End Property

End Module
