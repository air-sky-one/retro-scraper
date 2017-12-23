Imports System.IO
Imports System.Text

Module RomlistHelper

    ''' <summary>
    ''' Return the romlist file into a Datatable object
    ''' </summary>
    ''' <param name="path">path of the romlist file</param>
    ''' <returns></returns>
    Public Function ImportRomlistFile(path As String) As RomsDataSet.RomlistDataTable
        Dim romlist As New RomsDataSet.RomlistDataTable
        Dim fileName As String = String.Empty
        Dim cpt As Integer = 0
        Dim sr As StreamReader
        Dim header As String() = Nothing

        Try
            If File.Exists(path) Then
                fileName = path.Substring(path.LastIndexOf("\") + 1)
                fileName = fileName.Substring(0, fileName.Length - 4)
                romlist.TableName = fileName

                sr = New StreamReader(path)

                ' Read the file, line by line
                Do While sr.Peek() >= 0
                    Dim line As String = sr.ReadLine
                    Dim elements As String() = line.Split(";")

                    If elements.Count <= 1 Then
                        ' Throw New Exception("The romlist file structure doesn't match th standard file structure : " & path)
                        Exit Do
                    Else
                        ' First line
                        If line.First().ToString.Equals("#") And cpt = 0 Then
                            header = elements
                            ' delete the '#' character
                            header(0) = header(0).Substring(1, header(0).Length - 1)

                            ' test if all the needed columns are present in the file
                            For Each column As DataColumn In romlist.Columns
                                Dim isOk As Boolean = False
                                For Each el As String In header
                                    If el = column.ColumnName Then
                                        isOk = True
                                        Exit For
                                    End If
                                Next
                                If Not isOk Then Exit Do : Throw New Exception("The romlist file structure doesn't match th standard file structure")
                            Next
                        ElseIf cpt > 0 Then
                            ' all lines after the header line

                            Dim row As RomsDataSet.RomlistRow
                            row = romlist.NewRomlistRow

                            For Each column As DataColumn In romlist.Columns
                                Dim i As Integer = 0
                                For Each columnName As String In header
                                    If columnName = column.ColumnName Then
                                        row(columnName) = elements(i)
                                    End If
                                    i = i + 1
                                Next
                            Next
                            romlist.Rows.Add(row)
                        Else
                            ' [ERROR] if the first line of the file doesn't start with a '#' character
                            ' Throw New Exception("The romlist file structure doesn't match th standard file structure")
                            Exit Do
                        End If
                    End If
                    cpt = cpt + 1
                Loop

                sr.Close()
            Else
                ' [ERROR] 
                ' Throw New Exception("The file : " & path & " doesnt exist")
            End If
        Catch ex As Exception
            Throw ex
        End Try

        If romlist.Count = 0 Then romlist = Nothing

        Return romlist
    End Function

    ''' <summary>
    ''' Merge all the files given into one DataTable
    ''' </summary>
    ''' <param name="romlistFiles">list of the romlist files path to merge</param>
    ''' <returns></returns>
    Public Function MergeRomlistFiles(romlistFiles As List(Of String),
                                      Optional addRomlistName As Boolean = True) As RomsDataSet.RomlistDataTable

        Dim result As New RomsDataSet.RomlistDataTable
        Dim fileName As String = String.Empty
        Dim romlistDataTables As New List(Of RomsDataSet.RomlistDataTable)

        Try
            ' for each file in the list of paths
            For Each romlistFile In romlistFiles
                Dim romlist As New RomsDataSet.RomlistDataTable

                ' Set the name with the actual romlist file
                fileName = romlistFile.Substring(romlistFile.LastIndexOf("\") + 1)
                fileName = fileName.Substring(0, fileName.Length - 4)
                romlist.TableName = fileName
                ' get the romlist file into a DataTable
                romlist = ImportRomlistFile(romlistFile)

                If romlist IsNot Nothing Then
                    romlistDataTables.Add(romlist)

                    '    If addRomlistName Then
                    '        ' create a line of comment in the result to indicate the romlist file
                    '        Dim headerRow As RomsDataSet.RomlistRow = result.NewRomlistRow()

                    '        For Each column As DataColumn In romlist.Columns
                    '            If column.ColumnName = "Name" Then
                    '                headerRow.Name = "#" & romlist.TableName
                    '            Else
                    '                headerRow(column.ColumnName) = String.Empty
                    '            End If
                    '        Next

                    '        result.Rows.Add(headerRow)
                    '    End If

                    '    ' add all lines of the imported romlist file into the merged result one
                    '    For Each line As RomsDataSet.RomlistRow In romlist
                    '        result.Rows.Add(line)
                    '    Next
                End If
            Next

            result = MergeRomlists(romlistDataTables, addRomlistName)
        Catch ex As Exception
            Throw ex
        End Try

        Return result
    End Function

    ''' <summary>
    ''' Merge all the romlist DataTables given into one DataTable
    ''' </summary>
    ''' <param name="romlist">list of the romlist DataTables path to merge</param>
    ''' <returns></returns>
    Public Function MergeRomlists(romlist As List(Of RomsDataSet.RomlistDataTable),
                                      Optional addRomlistName As Boolean = True) As RomsDataSet.RomlistDataTable

        Dim result As New RomsDataSet.RomlistDataTable
        Try
            For Each romlistDataTable In romlist

                If addRomlistName Then
                    ' create a line of comment in the result to indicate the romlist file
                    Dim headerRow As RomsDataSet.RomlistRow = result.NewRomlistRow()

                    For Each column As DataColumn In romlistDataTable.Columns
                        If column.ColumnName = "Name" Then
                            headerRow.Name = "#" & romlistDataTable.TableName
                        Else
                            headerRow(column.ColumnName) = String.Empty
                        End If
                    Next

                    result.Rows.Add(headerRow)
                End If

                For Each line As RomsDataSet.RomlistRow In romlistDataTable.Select("", "Title ASC")
                    ' add all lines of the imported romlist file into the merged result one
                    Dim newRow As RomsDataSet.RomlistRow
                    newRow = result.NewRomlistRow
                    For Each column As DataColumn In result.Columns
                        newRow(column.ColumnName) = line(column.ColumnName)
                    Next

                    result.Rows.Add(newRow)
                Next
            Next
        Catch ex As Exception
            Throw ex
        End Try

        Return result
    End Function

    ''' <summary>
    ''' Export a DataTable into a Romlist file format content
    ''' </summary>
    ''' <param name="romlist"></param>
    ''' <returns></returns>
    Public Function ExportRomlistDataTableToString(romlist As RomsDataSet.RomlistDataTable,
                                                   Optional isNewFile As Boolean = True) As String

        Dim result As String = String.Empty
        Dim build As New StringBuilder

        Try
            If isNewFile Then
                ' Build the columns list line in comment
                build.Append("#")
                For Each column As DataColumn In romlist.Columns
                    build.Append(column.ColumnName)
                    build.Append(";")
                Next
                build.AppendLine()
            End If

            ' insert all the rows
            For Each line As RomsDataSet.RomlistRow In romlist.Select("", "Title ASC")
                For Each column In romlist.Columns
                    build.Append(line(column))
                    build.Append(";")
                Next
                build.AppendLine()
            Next
        Catch ex As Exception
            Throw ex
        End Try

        result = build.ToString

        Return result
    End Function

    ''' <summary>
    ''' Remove duplicated entries in a romlist file
    ''' </summary>
    ''' <param name="romlistFilePath"></param>
    ''' <returns></returns>
    Public Function RemoveDuplicates(romlistFilePath As String) As RomsDataSet.RomlistDataTable
        Try
            Return RemoveDuplicates(ImportRomlistFile(romlistFilePath))
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Remove duplicated entries in a Romlist DataTable
    ''' </summary>
    ''' <param name="romlist"></param>
    ''' <returns></returns>
    Public Function RemoveDuplicates(romlist As RomsDataSet.RomlistDataTable) As RomsDataSet.RomlistDataTable
        Dim result As New RomsDataSet.RomlistDataTable
        Dim rowsToRemove As New List(Of RomsDataSet.RomlistRow)
        Dim distinctRows As DataTable = romlist.DefaultView.ToTable(True, {"Name", "Emulator"})

        Try
            For Each line As DataRow In distinctRows.Select
                'Dim romName As String = line("Name")
                'Dim romEmulator As String = line("Emulator")

                Dim isAlreadyFlagged As Boolean = False
                For Each rowToRemove As RomsDataSet.RomlistRow In rowsToRemove
                    If line.Equals(rowToRemove) Then
                        isAlreadyFlagged = True
                        Exit For
                    End If
                Next

                If Not isAlreadyFlagged Then
                    Dim duplicatedRows As RomsDataSet.RomlistRow()
                    'duplicatedRows = romlist.Select("Name = '" & line.Name.Replace("'", "''") & "' AND Category = '" & line.Category.Replace("'", "''") & "'")
                    duplicatedRows = romlist.Select("Name = '" & line("Name").Replace("'", "''") & "' AND Emulator = '" & line("Emulator").Replace("'", "''") & "'")

                    If duplicatedRows.Count > 1 Then
                        Dim scores As New List(Of Integer)

                        For Each duplicate As RomsDataSet.RomlistRow In duplicatedRows
                            Dim score As Integer = 0
                            For Each column As DataColumn In romlist.Columns
                                If Not String.IsNullOrEmpty(duplicate(column).ToString) Then score = score + 1
                            Next
                            scores.Add(score)
                        Next

                        Dim max As Integer = scores.Max
                        Dim iMax As Integer = Array.IndexOf(scores.ToArray, max)
                        Dim i As Integer = 0

                        For Each duplicate As RomsDataSet.RomlistRow In duplicatedRows
                            If i <> iMax Then
                                rowsToRemove.Add(duplicate)
                            End If

                            i = i + 1
                        Next
                    End If
                End If
            Next

            For Each rowToRemove As RomsDataSet.RomlistRow In rowsToRemove
                romlist.RemoveRomlistRow(rowToRemove)
            Next

            result = romlist
        Catch ex As Exception
            Throw ex
        End Try

        Return result
    End Function

End Module
