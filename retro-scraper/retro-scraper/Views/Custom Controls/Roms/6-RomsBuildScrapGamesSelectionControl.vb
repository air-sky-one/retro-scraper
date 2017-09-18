Public Class _6_RomsBuildScrapGamesSelectionControl

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
    Private Sub _6_RomsBuildScrapGamesSelectionControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me._parent = TryCast(Me.Parent.Parent, RomsContainerControl)

            If Me._parent Is Nothing Then Throw New Exception("Unexpected error")

            Me.ContentDataGridView.DataSource = Me._parent.RomsData

        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Select all files
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectAllCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SelectAllCheckBox.CheckedChanged
        Dim value As Boolean = Me.SelectAllCheckBox.Checked

        For Each g As RomsDataSet.SSRomsRow In Me._parent.RomsData
            g.IsChecked = value
        Next
    End Sub
End Class
