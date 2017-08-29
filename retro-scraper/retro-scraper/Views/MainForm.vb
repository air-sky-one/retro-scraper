Public Class MainForm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Application title
        If My.Application.Info.Title <> "" Then
            Me.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            Me.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Dim authForm As New ScreenScraperLoginForm
        authForm.ShowDialog()

    End Sub

End Class