'Imports System.ComponentModel
Imports System.IO
Imports Newtonsoft.Json

Public Class JSonToDataTableForm

    Private ds As New DataSet

    Private Sub JSonToDataTableForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim webClient As New System.Net.WebClient()
        Dim query As String = String.Empty
        Dim json As String

        query = BuildGenericURL("jeuInfos.php") & "&crc=&md5=c638c1175840c6640d897951daa73637&sha1=&systemid=4&romnom=3 Ninjas Kick Back&romtaille=2097152"
        query = query.Replace("output=json", "output=xml")

        ' getting result
        json = webClient.DownloadString(query)

        ds.ReadXml(New StringReader(json))

        Dim selectTable As New DataTable
        selectTable.Columns.Add(New DataColumn("Index"))
        selectTable.Columns.Add(New DataColumn("Name"))

        Dim cpt As Integer = 1
        For Each t As DataTable In ds.Tables
            Dim r As DataRow
            r = selectTable.NewRow

            r("Name") = t.TableName
            r("Index") = cpt

            selectTable.Rows.Add(r)

            cpt = cpt + 1
        Next

        Me.TablesComboBox.DataSource = selectTable
        Me.TablesComboBox.DisplayMember = selectTable.Columns("Name").ToString
        Me.TablesComboBox.ValueMember = selectTable.Columns("Index").ToString

    End Sub

    Private Sub TablesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TablesComboBox.SelectedIndexChanged
        Me.ResultsDataGridView.DataSource = ds.Tables(Me.TablesComboBox.SelectedIndex)
    End Sub
End Class