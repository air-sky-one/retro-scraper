﻿''' <summary>
''' Contains globals variables
''' </summary>
Public Class AppGlobals

    ''' <summary>
    ''' Indicates if the licence file is prenset and valid
    ''' </summary>
    Public Shared isLicenceOK As Boolean = False

    ''' <summary>
    ''' Indicates if the user has a valid authentification on https://screenscraper.fr/
    ''' </summary>
    Public Shared isScreenScraperAuthOK As Boolean = False

    ''' <summary>
    ''' Licence File Path
    ''' </summary>
    Public Shared licenceFilePath As String = Application.StartupPath & "\Config\licence.cfg"

End Class
