Public Class _9_RomsBuildScrapCategoryControl

    ''' <summary>
    ''' Parent container control
    ''' </summary>
    Private _parent As RomsContainerControl

    ''' <summary>
    ''' Datagrid
    ''' </summary>
    ''' <returns></returns>
    Public Property Datagrid() As DataGridView
        Get
            Return Me.ContentDataGridView
        End Get
        Set(ByVal value As DataGridView)
            Me.ContentDataGridView = value
        End Set
    End Property

    ''' <summary>
    ''' Component initialization
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _9_RomsBuildScrapCategoryControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me._parent = TryCast(Me.Parent.Parent, RomsContainerControl)

            If Me._parent Is Nothing Then Throw New Exception("Unexpected error")

            Me.ContentDataGridView.DataSource = Me._parent.RomsData.Select("IsChecked = 'True'")

        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Select all EN Category
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectAllENCategoryCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SelectAllENCategoryCheckBox.CheckedChanged
        Dim value As Boolean = Me.SelectAllENCategoryCheckBox.Checked

        For Each g As RomsDataSet.SSRomsRow In Me._parent.RomsData.Select("IsChecked = 'True' AND genres_en <> ''")
            g.is_genres_en = value

            If g.is_genres_fr Then g.is_genres_fr = False
            If g.is_genres_de Then g.is_genres_de = False
            If g.is_genres_es Then g.is_genres_es = False
            If g.is_genres_pt Then g.is_genres_pt = False
        Next

        Me.ContentDataGridView.Refresh()
    End Sub

    ''' <summary>
    ''' Select all FR Category
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectAllFRCategoryCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SelectAllFRCategoryCheckBox.CheckedChanged
        Dim value As Boolean = Me.SelectAllFRCategoryCheckBox.Checked

        For Each g As RomsDataSet.SSRomsRow In Me._parent.RomsData.Select("IsChecked = 'True' AND genres_fr <> ''")
            g.is_genres_fr = value

            If g.is_genres_en Then g.is_genres_en = False
            If g.is_genres_de Then g.is_genres_de = False
            If g.is_genres_es Then g.is_genres_es = False
            If g.is_genres_pt Then g.is_genres_pt = False
        Next

        Me.ContentDataGridView.Refresh()
    End Sub

    ''' <summary>
    ''' Select all DE Category
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectAllDECategoryCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SelectAllDECategoryCheckBox.CheckedChanged
        Dim value As Boolean = Me.SelectAllDECategoryCheckBox.Checked

        For Each g As RomsDataSet.SSRomsRow In Me._parent.RomsData.Select("IsChecked = 'True' AND genres_de <> ''")
            g.is_genres_de = value

            If g.is_genres_en Then g.is_genres_en = False
            If g.is_genres_fr Then g.is_genres_fr = False
            If g.is_genres_es Then g.is_genres_es = False
            If g.is_genres_pt Then g.is_genres_pt = False
        Next

        Me.ContentDataGridView.Refresh()
    End Sub

    ''' <summary>
    ''' Select all ES Category
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectAllESCategoryCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SelectAllESCategoryCheckBox.CheckedChanged
        Dim value As Boolean = Me.SelectAllESCategoryCheckBox.Checked

        For Each g As RomsDataSet.SSRomsRow In Me._parent.RomsData.Select("IsChecked = 'True' AND genres_es <> ''")
            g.is_genres_es = value

            If g.is_genres_en Then g.is_genres_en = False
            If g.is_genres_fr Then g.is_genres_fr = False
            If g.is_genres_de Then g.is_genres_de = False
            If g.is_genres_pt Then g.is_genres_pt = False
        Next

        Me.ContentDataGridView.Refresh()
    End Sub

    ''' <summary>
    ''' Select all PT Category
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectAllPTCategoryCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SelectAllPTCategoryCheckBox.CheckedChanged
        Dim value As Boolean = Me.SelectAllPTCategoryCheckBox.Checked

        For Each g As RomsDataSet.SSRomsRow In Me._parent.RomsData.Select("IsChecked = 'True' AND genres_pt <> ''")
            g.is_genres_pt = value

            If g.is_genres_en Then g.is_genres_en = False
            If g.is_genres_fr Then g.is_genres_fr = False
            If g.is_genres_de Then g.is_genres_de = False
            If g.is_genres_es Then g.is_genres_es = False
        Next

        Me.ContentDataGridView.Refresh()
    End Sub

    ''' <summary>
    ''' Set the cell formatting in case data are missing or not
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ContentDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ContentDataGridView.CellFormatting
        Me.ContentDataGridView.SuspendLayout()

        If e.ColumnIndex = 2 Or e.ColumnIndex = 4 Or e.ColumnIndex = 6 Or e.ColumnIndex = 8 Or e.ColumnIndex = 10 Then
            If Me.ContentDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty Then
                Me.ContentDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).ReadOnly = True
                e.CellStyle.ForeColor = Color.IndianRed
                e.CellStyle.BackColor = Color.IndianRed
            Else
                Me.ContentDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).ReadOnly = False
            End If
        End If

        Me.ContentDataGridView.ResumeLayout()
    End Sub

End Class
