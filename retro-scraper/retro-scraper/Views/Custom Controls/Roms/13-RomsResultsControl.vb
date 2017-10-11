Public Class _13_RomsResultsControl

    ''' <summary>
    ''' Parent con tainer control
    ''' </summary>
    Private _parent As RomsContainerControl

    ''' <summary>
    ''' Component initialization
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _13_RomsResultsControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me._parent = TryCast(Me.Parent.Parent, RomsContainerControl)

            If Me._parent Is Nothing Then Throw New Exception("Unexpected error")

            Me.ScrapedRomsListBox.DataSource = Me._parent.RomsData.Select("isScraped = 'True'")

            Me.ErrorLoadingListBox.DataSource = Me._parent.RomsDataErrors.Select("Type = '" & LogsType.Loading.ToString & "'")
            Me.ErrorLoadingListBox.DisplayMember = "filename"

            Me.ErrorDonwloadListBox.DataSource = Me._parent.RomsDataErrors.Select("Type = '" & LogsType.Download.ToString & "'")
            Me.ErrorDonwloadListBox.DisplayMember = "filename"

        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub
End Class
