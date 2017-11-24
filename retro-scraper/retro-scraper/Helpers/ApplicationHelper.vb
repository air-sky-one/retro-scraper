Imports System.IO

Module ApplicationHelper

    ''' <summary>
    ''' Return the application name
    ''' </summary>
    ''' <returns></returns>
    Public Function GetApplicationName() As String
        Dim result As String = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)

        'Application title
        If My.Application.Info.Title <> "" Then result = My.Application.Info.Title

        Return result
    End Function

    ''' <summary>
    ''' Return the application version
    ''' </summary>
    ''' <returns></returns>
    Public Function GetApplicationVersion() As String
        Dim result As String = My.Application.Info.Version.Major & "." &
                               My.Application.Info.Version.Minor & "." &
                               My.Application.Info.Version.Build & "." &
                               My.Application.Info.Version.Revision
        Return result
    End Function

    ''' <summary>
    ''' Load existing application config file or initiate it for first launch
    ''' </summary>
    ''' <returns></returns>
    Public Function LoadApplicationConfig() As Boolean
        Dim result As Boolean = False

        Try
            If Not File.Exists(AppGlobals.mainConfigFile) Then

                AppGlobals.MainConfig.Relations.Clear()
                AppGlobals.MainConfig.Tables.Clear()

                ' *********
                ' Main application config

                Dim mainConfigDT As New Configs.MainConfigDataTable

#Region "Main application config"


                Dim mainConfigRow As Configs.MainConfigRow
                mainConfigRow = mainConfigDT.NewMainConfigRow
                mainConfigRow.Scraper = "screenscraper.fr v1"
                mainConfigDT.AddMainConfigRow(mainConfigRow)
#End Region

                AppGlobals.MainConfig.Tables.Add(mainConfigDT)

                ' *********
                ' scrapers list
                Dim scraperAPIDT As New Configs.ScraperAPIDataTable

#Region "screenscraper v1"
                ' screenscraper v1
                Dim ssAPIv1 As Configs.ScraperAPIRow
                ssAPIv1 = scraperAPIDT.NewRow
                ssAPIv1.ScraperName = "screenscraper.fr v1"
                ssAPIv1.Url = "https://www.screenscraper.fr/api/"
                scraperAPIDT.Rows.Add(ssAPIv1)
#End Region

#Region "screenscraper v2"
                ' screenscraper v2
                Dim ssAPIv2 As Configs.ScraperAPIRow
                ssAPIv2 = scraperAPIDT.NewRow
                ssAPIv2.ScraperName = "screenscraper.fr v2"
                ssAPIv2.Url = "https://www.screenscraper.fr/api2/"
                scraperAPIDT.Rows.Add(ssAPIv2)
#End Region

                AppGlobals.MainConfig.Tables.Add(scraperAPIDT)

                ' *********
                ' scrapers methods list
                Dim APImethodsDT As New Configs.APIMethodsDataTable

#Region "screenscraper v1 - SystemesListe"
                Dim ssV1SystemesListeMethod As Configs.APIMethodsRow
                ssV1SystemesListeMethod = APImethodsDT.NewAPIMethodsRow
                ssV1SystemesListeMethod.ScraperName = "screenscraper.fr v1"
                ssV1SystemesListeMethod.Method = "SystemesListe"
                APImethodsDT.Rows.Add(ssV1SystemesListeMethod)
#End Region

#Region "screenscraper v1 - JeuInfos"
                Dim ssV1JeuInfosMethod As Configs.APIMethodsRow
                ssV1JeuInfosMethod = APImethodsDT.NewAPIMethodsRow
                ssV1JeuInfosMethod.ScraperName = "screenscraper.fr v1"
                ssV1JeuInfosMethod.Method = "JeuInfos"
                APImethodsDT.Rows.Add(ssV1JeuInfosMethod)
#End Region

#Region "screenscraper v2 - SystemesListe"
                Dim ssV2SystemesListeMethod As Configs.APIMethodsRow
                ssV2SystemesListeMethod = APImethodsDT.NewAPIMethodsRow
                ssV2SystemesListeMethod.ScraperName = "screenscraper.fr v2"
                ssV2SystemesListeMethod.Method = "SystemesListe"
                APImethodsDT.Rows.Add(ssV2SystemesListeMethod)
#End Region

#Region "screenscraper v2 - JeuInfos"
                Dim ssV2JeuInfosMethod As Configs.APIMethodsRow
                ssV2JeuInfosMethod = APImethodsDT.NewAPIMethodsRow
                ssV2JeuInfosMethod.ScraperName = "screenscraper.fr v2"
                ssV2JeuInfosMethod.Method = "JeuInfos"
                APImethodsDT.Rows.Add(ssV2JeuInfosMethod)
#End Region

                AppGlobals.MainConfig.Tables.Add(APImethodsDT)

                ' *********
                ' scrapers methods params list
                Dim methodsParamsDT As New Configs.MethodParamsDataTable

#Region "screenscraper v1 - JeuInfos"
#Region "screenscraper v1 - JeuInfos / crc"
                Dim ssV1crc As Configs.MethodParamsRow
                ssV1crc = methodsParamsDT.NewMethodParamsRow
                ssV1crc.ScraperName = "screenscraper.fr v1"
                ssV1crc.Method = "JeuInfos"
                ssV1crc.Param = "crc"
                ssV1crc.ParamOrder = 0
                methodsParamsDT.Rows.Add(ssV1crc)
#End Region

#Region "screenscraper v1 - JeuInfos / md5"
                Dim ssV1md5 As Configs.MethodParamsRow
                ssV1md5 = methodsParamsDT.NewMethodParamsRow
                ssV1md5.ScraperName = "screenscraper.fr v1"
                ssV1md5.Method = "JeuInfos"
                ssV1md5.Param = "md5"
                ssV1md5.ParamOrder = 1
                methodsParamsDT.Rows.Add(ssV1md5)
#End Region

#Region "screenscraper v1 - JeuInfos / sha1"
                Dim ssV1sha1 As Configs.MethodParamsRow
                ssV1sha1 = methodsParamsDT.NewMethodParamsRow
                ssV1sha1.ScraperName = "screenscraper.fr v1"
                ssV1sha1.Method = "JeuInfos"
                ssV1sha1.Param = "sha1"
                ssV1sha1.ParamOrder = 2
                methodsParamsDT.Rows.Add(ssV1sha1)
#End Region

#Region "screenscraper v1 - JeuInfos / systemeid"
                Dim ssV1systemeid As Configs.MethodParamsRow
                ssV1systemeid = methodsParamsDT.NewMethodParamsRow
                ssV1systemeid.ScraperName = "screenscraper.fr v1"
                ssV1systemeid.Method = "JeuInfos"
                ssV1systemeid.Param = "systemeid"
                ssV1systemeid.ParamOrder = 3
                methodsParamsDT.Rows.Add(ssV1systemeid)
#End Region

#Region "screenscraper v1 - JeuInfos / romtype"
                Dim ssV1romtype As Configs.MethodParamsRow
                ssV1romtype = methodsParamsDT.NewMethodParamsRow
                ssV1romtype.ScraperName = "screenscraper.fr v1"
                ssV1romtype.Method = "JeuInfos"
                ssV1romtype.Param = "romtype"
                ssV1romtype.ParamOrder = 4
                methodsParamsDT.Rows.Add(ssV1romtype)
#End Region

#Region "screenscraper v1 - JeuInfos / romnom"
                Dim ssV1romnom As Configs.MethodParamsRow
                ssV1romnom = methodsParamsDT.NewMethodParamsRow
                ssV1romnom.ScraperName = "screenscraper.fr v1"
                ssV1romnom.Method = "JeuInfos"
                ssV1romnom.Param = "romnom"
                ssV1romnom.ParamOrder = 5
                methodsParamsDT.Rows.Add(ssV1romnom)
#End Region

#Region "screenscraper v1 - JeuInfos / gameid"
                Dim ssV1gameid As Configs.MethodParamsRow
                ssV1gameid = methodsParamsDT.NewMethodParamsRow
                ssV1gameid.ScraperName = "screenscraper.fr v1"
                ssV1gameid.Method = "JeuInfos"
                ssV1gameid.Param = "gameid"
                ssV1gameid.ParamOrder = 6
                methodsParamsDT.Rows.Add(ssV1gameid)
#End Region
#End Region

#Region "screenscraper v2 - JeuInfos"
#Region "screenscraper v2 - JeuInfos / crc"
                Dim ssV2crc As Configs.MethodParamsRow
                ssV2crc = methodsParamsDT.NewMethodParamsRow
                ssV2crc.ScraperName = "screenscraper.fr v2"
                ssV2crc.Method = "JeuInfos"
                ssV2crc.Param = "crc"
                ssV2crc.ParamOrder = 0
                methodsParamsDT.Rows.Add(ssV2crc)
#End Region

#Region "screenscraper v2 - JeuInfos / md5"
                Dim ssV2md5 As Configs.MethodParamsRow
                ssV2md5 = methodsParamsDT.NewMethodParamsRow
                ssV2md5.ScraperName = "screenscraper.fr v2"
                ssV2md5.Method = "JeuInfos"
                ssV2md5.Param = "md5"
                ssV2md5.ParamOrder = 1
                methodsParamsDT.Rows.Add(ssV2md5)
#End Region

#Region "screenscraper v2 - JeuInfos / sha1"
                Dim ssV2sha1 As Configs.MethodParamsRow
                ssV2sha1 = methodsParamsDT.NewMethodParamsRow
                ssV2sha1.ScraperName = "screenscraper.fr v2"
                ssV2sha1.Method = "JeuInfos"
                ssV2sha1.Param = "sha1"
                ssV2sha1.ParamOrder = 2
                methodsParamsDT.Rows.Add(ssV2sha1)
#End Region

#Region "screenscraper v2 - JeuInfos / systemeid"
                Dim ssV2systemeid As Configs.MethodParamsRow
                ssV2systemeid = methodsParamsDT.NewMethodParamsRow
                ssV2systemeid.ScraperName = "screenscraper.fr v2"
                ssV2systemeid.Method = "JeuInfos"
                ssV2systemeid.Param = "systemeid"
                ssV2systemeid.ParamOrder = 3
                methodsParamsDT.Rows.Add(ssV2systemeid)
#End Region

#Region "screenscraper v2 - JeuInfos / romtype"
                Dim ssV2romtype As Configs.MethodParamsRow
                ssV2romtype = methodsParamsDT.NewMethodParamsRow
                ssV2romtype.ScraperName = "screenscraper.fr v2"
                ssV2romtype.Method = "JeuInfos"
                ssV2romtype.Param = "romtype"
                ssV2romtype.ParamOrder = 4
                methodsParamsDT.Rows.Add(ssV2romtype)
#End Region

#Region "screenscraper v2 - JeuInfos / romnom"
                Dim ssV2romnom As Configs.MethodParamsRow
                ssV2romnom = methodsParamsDT.NewMethodParamsRow
                ssV2romnom.ScraperName = "screenscraper.fr v2"
                ssV2romnom.Method = "JeuInfos"
                ssV2romnom.Param = "romnom"
                ssV2romnom.ParamOrder = 5
                methodsParamsDT.Rows.Add(ssV2romnom)
#End Region

#Region "screenscraper v2 - JeuInfos / gameid"
                Dim ssV2gameid As Configs.MethodParamsRow
                ssV2gameid = methodsParamsDT.NewMethodParamsRow
                ssV2gameid.ScraperName = "screenscraper.fr v2"
                ssV2gameid.Method = "JeuInfos"
                ssV2gameid.Param = "gameid"
                ssV2gameid.ParamOrder = 6
                methodsParamsDT.Rows.Add(ssV2gameid)
#End Region
#End Region

                AppGlobals.MainConfig.Tables.Add(methodsParamsDT)

                AppGlobals.MainConfig.WriteXml(AppGlobals.mainConfigFile)
            Else
                AppGlobals.MainConfig.ReadXml(AppGlobals.mainConfigFile)
            End If

            result = True

        Catch ex As Exception
            Throw ex
        End Try

        Return result
    End Function

End Module
