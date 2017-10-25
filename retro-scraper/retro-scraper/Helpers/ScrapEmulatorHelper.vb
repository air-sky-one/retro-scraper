Imports System.IO

Module ScrapEmulatorHelper

    ''' <summary>
    ''' Retrieve the emulators list
    ''' </summary>
    ''' <returns></returns>
    Public Function GetEmulatorsList(ByRef AttractModeEmulatorsList As RomsDataSet.EmulatorsDataTable,
                                     ByRef workerDetailsLastLine As String) As Boolean
        Dim result As Boolean = False
        Dim cpt As Integer = 0

        Try
            For Each path As String In Directory.EnumerateFiles(Application.StartupPath() & "\emulators")
                Dim extension As String = path.Substring(path.LastIndexOf("\") + 1) : extension = extension.Substring(extension.IndexOf(".") + 1, 3)

                cpt = cpt + 1

                If extension = "cfg" Then
                    Dim emul As RomsDataSet.EmulatorsRow = AttractModeEmulatorsList.NewEmulatorsRow
                    Dim name As String

                    name = path.Substring(path.LastIndexOf("\") + 1) : name = name.Substring(0, name.IndexOf("."))

                    emul.Name = name
                    emul.Path = path

                    AttractModeEmulatorsList.AddEmulatorsRow(emul)
                    workerDetailsLastLine = cpt.ToString & " : " & emul.Name & vbCrLf
                Else
                    workerDetailsLastLine = cpt.ToString & " : a file config with a wrong extension was found (" & path.Substring(path.LastIndexOf("\") + 1) & ". Not added to list." & vbCrLf
                End If
            Next

            result = True
        Catch ex As Exception
            Throw ex
        End Try

        Return result
    End Function

    ''' <summary>
    ''' Set accepted rom files extension for the selected emulator
    ''' </summary>
    ''' <returns></returns>
    Public Function SetRomFilesExtensions(ByVal path As String,
                                          ByRef RomsExtensions As String(),
                                          ByRef cpt As Integer) As Boolean
        Dim result As Boolean = False
        Dim sr As StreamReader

        Try
            sr = New StreamReader(path)
            Do While sr.Peek() >= 0
                Dim line As String = sr.ReadLine
                If line.Contains("romext") Then
                    line = line.Substring(6, line.Length - 6)
                    line = line.Trim()

                    Erase RomsExtensions
                    RomsExtensions = line.Split(";")

                    cpt = 1

                    Exit Do
                End If
            Loop
            sr.Close()
        Catch ex As Exception
            Throw ex
        End Try

        Return result
    End Function

    ''' <summary>
    ''' Set type of artworks and their associated folder path
    ''' </summary>
    ''' <returns></returns>
    Public Function SetArtworksTypesAndFolders(ByVal path As String,
                                               ByRef RomsArtworks As RomsDataSet.ArtworksDataTable) As Boolean
        Dim result As Boolean = False
        Dim sr As StreamReader

        Try
            sr = New StreamReader(path)

            RomsArtworks.Clear()

            Do While sr.Peek() >= 0
                Dim line As String = sr.ReadLine
                If line.Contains("artwork") Then
                    Dim artName As String = String.Empty
                    Dim artPath As String = String.Empty

                    Try
                        If line.IndexOf("/") > 0 Then
                            artName = line.Substring(7, line.IndexOf("/") - 7).Trim
                            artPath = line.Substring(line.LastIndexOf("/") + 1)
                        Else
                            artName = line.Substring(7, line.Length - 7).Trim
                            artPath = String.Empty
                        End If

                    Catch ex As Exception
                        Throw New Exception("Oups !, It seems that the emulator file content is incorrect." & vbCrLf & ex.Message, ex)
                    End Try

                    Dim a As RomsDataSet.ArtworksRow = RomsArtworks.NewArtworksRow()
                    a.Name = artName
                    a.Path = artPath

                    If Not a.Path = String.Empty Then
                        RomsArtworks.AddArtworksRow(a)
                    End If
                End If
            Loop
            sr.Close()

            If RomsArtworks.Count = 0 Then
                Throw New Exception("Oups !, It seems that the emulator file content is incorrect." & vbCrLf & "No artwork types and folder defined.")
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return result
    End Function

End Module
