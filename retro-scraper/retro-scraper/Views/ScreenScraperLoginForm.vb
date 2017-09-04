Public Class ScreenScraperLoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            ' 1- test the authentification on screenscraper.fr
            If Not GetScreenScraperUser(Me.UsernameTextBox.Text, Me.PasswordTextBox.Text, False) Then
                ' 2- if the authentification is not ok then retry
                MessageBox.Show("Invalid ScreenScraper User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                AppGlobals.isScreenScraperAuthOK = True
                Me.Close()
            End If

        Catch ex As Exception
            AddLogs(ex)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        AppGlobals.isScreenScraperAuthOK = False
        Me.Close()
    End Sub

    Private Sub RegistrationLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RegistrationLinkLabel.LinkClicked
        Dim sInfo As ProcessStartInfo = New ProcessStartInfo("https://screenscraper.fr/membreinscription.php")
        Process.Start(sInfo)
    End Sub
End Class
