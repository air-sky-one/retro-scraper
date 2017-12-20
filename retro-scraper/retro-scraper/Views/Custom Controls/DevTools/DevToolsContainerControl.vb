Public Class DevToolsContainerControl

    Private Sub MainConfigButton_Click(sender As Object, e As EventArgs) Handles MainConfigButton.Click
        Dim f As New MainConfigForm
        f.ShowDialog()
    End Sub

    Private Sub RescrapRomlistFileButton_Click(sender As Object, e As EventArgs) Handles RescrapRomlistFileButton.Click
        Dim f As New RescrapRomlistFileForm
        f.ShowDialog()
    End Sub
End Class
