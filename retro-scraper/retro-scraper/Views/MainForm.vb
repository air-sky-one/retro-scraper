Public Class MainForm

    ''' <summary>
    ''' Main application form loading
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Application title : If the application title is missing, use the application name, without the extension
        If My.Application.Info.Title <> "" Then Me.Text = My.Application.Info.Title Else Me.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)

        ''
        Dim authForm As New ScreenScraperLoginForm : authForm.ShowDialog()
        If Not AppGlobals.isScreenScraperAuthOK Then Me.Close()
    End Sub

End Class