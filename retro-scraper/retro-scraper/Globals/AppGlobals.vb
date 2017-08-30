Imports retro_scraper_libs

''' <summary>
''' Contains globals variables
''' </summary>
Public Class AppGlobals

#Region "Licence"

    ''' <summary>
    ''' Indicates if the licence file is prenset and valid
    ''' </summary>
    Public Shared isLicenceOK As Boolean = False

    ''' <summary>
    ''' Licence File Path
    ''' </summary>
    Public Shared licenceFilePath As String = Application.StartupPath & "\Config\licence.cfg"

    ''' <summary>
    ''' Licence File Content
    ''' </summary>
    Public Shared licence As New Licence.DevDataTable

#End Region

#Region "ScreenScraper Authentification - User"

    ''' <summary>
    ''' Indicates if the user has a valid authentification on https://screenscraper.fr/
    ''' </summary>
    Public Shared isScreenScraperAuthOK As Boolean = False

    ''' <summary>
    ''' ScreenScraper User file Path
    ''' </summary>
    Public Shared userFilePath As String = Application.StartupPath & "\Config\user.cfg"

    ''' <summary>
    ''' ScreenScraper User
    ''' </summary>
    Public Shared user As New User.SSUSerDataTable

#End Region

#Region "Logs"

    ''' <summary>
    ''' Logs file path
    ''' </summary>
    Public Shared logsFilePath As String = Application.StartupPath & "\logs.xml"

    ''' <summary>
    ''' Log content
    ''' </summary>
    Public Shared logs As New Logs.ErrorsDataTable

#End Region

End Class
