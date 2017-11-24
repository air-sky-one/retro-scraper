Public Class MainConfigForm
    Private Sub MainConfigForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ScraperProviderComboBox.DataSource = AppGlobals.MainConfig.Tables("ScraperAPI")
    End Sub
End Class