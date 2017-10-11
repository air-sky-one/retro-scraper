Public Class _7_RomsBuildScrapTitleControl

    ''' <summary>
    ''' Parent con tainer control
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
    Private Sub _7_RomsBuildScrapTitleControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me._parent = TryCast(Me.Parent.Parent, RomsContainerControl)

            If Me._parent Is Nothing Then Throw New Exception("Unexpected error")

            Me.ContentDataGridView.DataSource = Me._parent.RomsData.Select("IsChecked = 'True'")

        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Select all US Title
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectAllUSTitleCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SelectAllUSTitleCheckBox.CheckedChanged
        Dim value As Boolean = Me.SelectAllUSTitleCheckBox.Checked

        For Each g As RomsDataSet.SSRomsRow In Me._parent.RomsData.Select("IsChecked = 'True' AND nom_us <> ''")
            g.is_nom_us = value

            If g.is_nom_jp Then g.is_nom_jp = False
            If g.is_nom_wor Then g.is_nom_wor = False
            If g.is_nom_eu Then g.is_nom_eu = False
        Next

        Me.ContentDataGridView.Refresh()
    End Sub

    ''' <summary>
    ''' Select all JP Title
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectAllJPTitleCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SelectAllJPTitleCheckBox.CheckedChanged
        Dim value As Boolean = Me.SelectAllJPTitleCheckBox.Checked

        For Each g As RomsDataSet.SSRomsRow In Me._parent.RomsData.Select("IsChecked = 'True' AND nom_jp <> ''")
            g.is_nom_jp = value

            If g.is_nom_us Then g.is_nom_us = False
            If g.is_nom_wor Then g.is_nom_wor = False
            If g.is_nom_eu Then g.is_nom_eu = False
        Next

        Me.ContentDataGridView.Refresh()
    End Sub

    ''' <summary>
    ''' Select all World Title
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectAllWorTitleCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SelectAllWorTitleCheckBox.CheckedChanged
        Dim value As Boolean = Me.SelectAllWorTitleCheckBox.Checked

        For Each g As RomsDataSet.SSRomsRow In Me._parent.RomsData.Select("IsChecked = 'True' AND nom_wor <> ''")
            g.is_nom_wor = value

            If g.is_nom_us Then g.is_nom_us = False
            If g.is_nom_jp Then g.is_nom_jp = False
            If g.is_nom_eu Then g.is_nom_eu = False
        Next

        Me.ContentDataGridView.Refresh()
    End Sub

    ''' <summary>
    ''' Select all Europe Title
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectAllEurTitleCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SelectAllEurTitleCheckBox.CheckedChanged
        Dim value As Boolean = Me.SelectAllEurTitleCheckBox.Checked

        For Each g As RomsDataSet.SSRomsRow In Me._parent.RomsData.Select("IsChecked = 'True' AND nom_eu <> ''")
            g.is_nom_eu = value

            If g.is_nom_us Then g.is_nom_us = False
            If g.is_nom_jp Then g.is_nom_jp = False
            If g.is_nom_wor Then g.is_nom_wor = False
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

        If e.ColumnIndex = 2 Or e.ColumnIndex = 4 Or e.ColumnIndex = 6 Or e.ColumnIndex = 8 Then
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
