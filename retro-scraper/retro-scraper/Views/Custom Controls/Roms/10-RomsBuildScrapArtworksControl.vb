Public Class _10_RomsBuildScrapArtworksControl

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
    Private Sub _10_RomsBuildScrapArtworksControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me._parent = TryCast(Me.Parent.Parent, RomsContainerControl)

            If Me._parent Is Nothing Then Throw New Exception("Unexpected error")

            Me.ContentDataGridView.DataSource = Me._parent.RomsArtworks
            Me.AssociatedMediaTypeDataGridViewComboBoxColumn.DataSource = Me._parent.MediaTypes

            Me.ContentDataGridView.AutoSize = True

        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Reset settings for artwork association with media types
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        ResetAssociations()
    End Sub

    ''' <summary>
    ''' Reset settings for artwork association with media types
    ''' </summary>
    Private Sub ResetAssociations()
        For Each r As RomsDataSet.ArtworksRow In Me._parent.RomsArtworks
            r.AssociatedMediaType = String.Empty
        Next
    End Sub
End Class
