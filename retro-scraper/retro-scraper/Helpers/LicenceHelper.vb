Imports System.IO
Imports System.Text

Module LicenceHelper

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

    ''' <summary>
    ''' Check if the licence file is present and can be imported
    ''' </summary>
    ''' <returns>true : OK / false : KO</returns>
    Public Function IsLicenceFileOK() As Boolean
        Dim result As Boolean = False

        Try
            result = ReadAndLoadEncryptedFile(AppGlobals.licenceFilePath, AppGlobals.licence)

            LicenceHelper.SoftwareName = GetApplicationName()
            LicenceHelper.SoftwareVersion = GetApplicationVersion()
        Catch ex As Exception
            Throw ex
        End Try

        Return result
    End Function

End Module
