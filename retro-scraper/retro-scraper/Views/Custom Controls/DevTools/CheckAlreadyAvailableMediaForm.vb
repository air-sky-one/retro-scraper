Imports System.IO
Imports System.Text

Public Class CheckAlreadyAvailableMediaForm

    ''' <summary>
    ''' Attract Mode Emulators List
    ''' </summary>
    Private _attractModeEmulatorsList As New RomsDataSet.EmulatorsDataTable
    Public Property AttractModeEmulatorsList() As RomsDataSet.EmulatorsDataTable
        Get
            Return _attractModeEmulatorsList
        End Get
        Set(ByVal value As RomsDataSet.EmulatorsDataTable)
            _attractModeEmulatorsList = value
        End Set
    End Property

    ''' <summary>
    ''' Accepted emulator's roms extension
    ''' </summary>
    Private _romsExtensions As String()
    Public Property RomsExtensions() As String()
        Get
            Return _romsExtensions
        End Get
        Set(ByVal value As String())
            _romsExtensions = value
        End Set
    End Property

    ''' <summary>
    ''' Roms artworks (name and path)
    ''' </summary>
    Private _romsArtworks As New RomsDataSet.ArtworksDataTable
    Public Property RomsArtworks() As RomsDataSet.ArtworksDataTable
        Get
            Return _romsArtworks
        End Get
        Set(ByVal value As RomsDataSet.ArtworksDataTable)
            _romsArtworks = value
        End Set
    End Property

    ''' <summary>
    ''' Selected Roms Path
    ''' </summary>
    Private _romsPath As String
    Public Property RomsPath() As String
        Get
            Return _romsPath
        End Get
        Set(ByVal value As String)
            _romsPath = value
        End Set
    End Property

    Private roms As New DataTable

    Private Sub CheckAlreadyAvailableMediaForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each path As String In Directory.EnumerateFiles(Application.StartupPath() & "\emulators")
            Dim extension As String = path.Substring(path.LastIndexOf("\") + 1) : extension = extension.Substring(extension.IndexOf(".") + 1, 3)

            If extension = "cfg" Then
                Dim emul As RomsDataSet.EmulatorsRow = Me.AttractModeEmulatorsList.NewEmulatorsRow
                Dim name As String

                name = path.Substring(path.LastIndexOf("\") + 1) : name = name.Substring(0, name.IndexOf("."))

                emul.Name = name
                emul.Path = path

                Me.AttractModeEmulatorsList.AddEmulatorsRow(emul)
            End If
        Next

        Me.EmulatorsListComboBox.DataSource = Me.AttractModeEmulatorsList.Select("", "Name ASC")
        Me.EmulatorsListComboBox.DisplayMember = Me.AttractModeEmulatorsList.Columns("Name").ToString
        Me.EmulatorsListComboBox.ValueMember = Me.AttractModeEmulatorsList.Columns("path").ToString
    End Sub

    Private Sub EmulatorsListComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EmulatorsListComboBox.SelectedIndexChanged
        Dim path As String = String.Empty
        Dim sr As StreamReader
        Dim content As String = String.Empty
        Dim cpt As Integer = 0
        Dim isErr As Boolean = False

        Try
            path = Me.EmulatorsListComboBox.SelectedValue.ToString


            Try
                ' **********************************
                ' Get accepted roms files extension
                sr = New StreamReader(path)
                Do While sr.Peek() >= 0
                    Dim line As String = sr.ReadLine
                    If line.Contains("romext") Then
                        line = line.Substring(6, line.Length - 6)
                        line = line.Trim()

                        Erase Me.RomsExtensions
                        Me.RomsExtensions = line.Split(";")

                        cpt = 1

                        Exit Do
                    End If
                Loop
                sr.Close()
                ' **********************************

                ' ******************************************************
                ' Get type of artworks and their associated folder path
                sr = New StreamReader(path)

                Me.RomsArtworks.Clear()

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

                        Dim a As RomsDataSet.ArtworksRow = Me.RomsArtworks.NewArtworksRow()
                        a.Name = artName
                        a.Path = artPath

                        If Not a.Path = String.Empty Then
                            Me.RomsArtworks.AddArtworksRow(a)
                        End If
                    End If
                Loop
                sr.Close()

                If Me.RomsArtworks.Count = 0 Then
                    Throw New Exception("Oups !, It seems that the emulator file content is incorrect." & vbCrLf & "No artwork types and folder defined.")
                End If
                ' ******************************************************

                If cpt = 0 Then
                    Dim err As New Exception("The selected emulator file doesn't contain roms extensions definition. Please choose a valid emulator config file.")

                    isErr = True
                    ShowErrorMessage(err)

                End If

                If Me.roms.Columns.Count = 0 Then
                    Me.roms.Columns.Add("Filename")

                    For Each art As RomsDataSet.ArtworksRow In Me.RomsArtworks
                        Dim c As New DataColumn With {.ColumnName = art.Name,
                                                      .DataType = True.GetType}
                        Me.roms.Columns.Add(c)
                    Next
                End If
            Catch ex As Exception

            End Try
        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    Private Sub RomsFolderButton_Click(sender As Object, e As EventArgs) Handles RomsFolderButton.Click
        Dim path As String = String.Empty
        Dim searchPattern As New StringBuilder
        Dim isErr As Boolean = False
        Dim cpt As Integer = 0

        Try
            Me.RomsFolderFolderBrowserDialog.ShowDialog()
            path = Me.RomsFolderFolderBrowserDialog.SelectedPath

            If Not path = String.Empty Then
                For Each ext As String In Me.RomsExtensions
                    searchPattern.Append("*" & ext & ",")
                Next

                Dim collection = From fi In New DirectoryInfo(path).GetFiles()
                                 Where Me.RomsExtensions.Contains(fi.Extension.ToUpper())

                If collection.Count > 0 Then
                    Me.RomsFolderTextBox.Text = path
                    Me.RomsPath = path
                End If
            End If
        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
        Dim collection = From fi In New DirectoryInfo(Me.RomsPath).GetFiles()
                         Where Me.RomsExtensions.Contains(fi.Extension.ToUpper())

        If collection.Count > 0 Then
            For Each file As FileInfo In collection
                Dim r As DataRow = Me.roms.NewRow
                r("Filename") = file.Name.Substring(0, file.Name.Length - 4)

                For Each art As RomsDataSet.ArtworksRow In Me.RomsArtworks
                    Dim isFind As Boolean = False
                    For Each f As FileInfo In New DirectoryInfo(Me.RomsPath & "\" & art.Name).GetFiles()
                        If f.Name.Contains(r("Filename")) Then
                            isFind = True
                            Exit For
                        End If
                    Next
                    r(art.Name) = isFind
                Next
                Me.roms.Rows.Add(r)
            Next

            Me.DataGridView1.DataSource = Me.roms

        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.ColumnIndex > 0 Then
            If Me.DataGridView1.Columns(e.ColumnIndex).Visible Then
                If Not (Me.roms(e.RowIndex)(e.ColumnIndex)) Then
                    Me.DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = True
                    e.CellStyle.ForeColor = Color.IndianRed
                    e.CellStyle.BackColor = Color.IndianRed
                End If
            End If
        End If
    End Sub
End Class