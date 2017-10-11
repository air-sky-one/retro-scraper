Public Class _8_RomsBuildScrapDateControl

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
    Private Sub _8_RomsBuildScrapDateControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me._parent = TryCast(Me.Parent.Parent, RomsContainerControl)

            If Me._parent Is Nothing Then Throw New Exception("Unexpected error")

            Me.ContentDataGridView.DataSource = Me._parent.RomsData.Select("IsChecked = 'True'")

        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Select all US Date
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectAllUSDateCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SelectAllUSDateCheckBox.CheckedChanged
        Dim value As Boolean = Me.SelectAllUSDateCheckBox.Checked

        For Each g As RomsDataSet.SSRomsRow In Me._parent.RomsData.Select("IsChecked = 'True' AND date_us <> ''")
            g.is_date_us = value

            If g.is_date_jp Then g.is_date_jp = False
            If g.is_date_wor Then g.is_date_wor = False
            If g.is_date_eu Then g.is_date_eu = False
        Next

        Me.ContentDataGridView.Refresh()
    End Sub

    ''' <summary>
    ''' Select all JP Date
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectAllJPDateCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SelectAllJPDateCheckBox.CheckedChanged
        Dim value As Boolean = Me.SelectAllJPDateCheckBox.Checked

        For Each g As RomsDataSet.SSRomsRow In Me._parent.RomsData.Select("IsChecked = 'True' AND date_jp <> ''")
            g.is_date_jp = value

            If g.is_date_us Then g.is_date_us = False
            If g.is_date_wor Then g.is_date_wor = False
            If g.is_date_eu Then g.is_date_eu = False
        Next

        Me.ContentDataGridView.Refresh()
    End Sub

    ''' <summary>
    ''' Select all World Date
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectAllWorDateCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SelectAllWorDateCheckBox.CheckedChanged
        Dim value As Boolean = Me.SelectAllWorDateCheckBox.Checked

        For Each g As RomsDataSet.SSRomsRow In Me._parent.RomsData.Select("IsChecked = 'True' AND date_wor <> ''")
            g.is_date_wor = value

            If g.is_date_us Then g.is_date_us = False
            If g.is_date_jp Then g.is_date_jp = False
            If g.is_date_eu Then g.is_date_eu = False
        Next

        Me.ContentDataGridView.Refresh()
    End Sub

    ''' <summary>
    ''' Select all Europe Date
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectAllEurDateCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SelectAllEurDateCheckBox.CheckedChanged
        Dim value As Boolean = Me.SelectAllEurDateCheckBox.Checked

        For Each g As RomsDataSet.SSRomsRow In Me._parent.RomsData.Select("IsChecked = 'True' AND date_eu <> ''")
            g.is_date_eu = value

            If g.is_date_us Then g.is_date_us = False
            If g.is_date_jp Then g.is_date_jp = False
            If g.is_date_wor Then g.is_date_wor = False
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
