Public Class DevToolsContainerControl
    Private Sub JSonToDataTableButton_Click(sender As Object, e As EventArgs) Handles JSonToDataTableButton.Click
        Dim f As New JSonToDataTableForm
        f.ShowDialog()
    End Sub

    Private Sub VisualControlsTestButton_Click(sender As Object, e As EventArgs) Handles VisualControlsTestButton.Click
        Dim f As New VisualControlsTestsForm
        f.ShowDialog()
    End Sub

    Private Sub CheckAlreadyAvailableMediaButton_Click(sender As Object, e As EventArgs) Handles CheckAlreadyAvailableMediaButton.Click
        Dim f As New CheckAlreadyAvailableMediaForm
        f.ShowDialog()
    End Sub
End Class
