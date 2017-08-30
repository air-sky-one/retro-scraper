Module ApplicationHelper

    ''' <summary>
    ''' Return the application name
    ''' </summary>
    ''' <returns></returns>
    Public Function GetApplicationName() As String
        Dim result As String = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)

        'Application title
        If My.Application.Info.Title <> "" Then result = My.Application.Info.Title

        Return result
    End Function

    ''' <summary>
    ''' Return the application version
    ''' </summary>
    ''' <returns></returns>
    Public Function GetApplicationVersion() As String
        Dim result As String = My.Application.Info.Version.Major & "." &
                               My.Application.Info.Version.Minor & "." &
                               My.Application.Info.Version.Build & "." &
                               My.Application.Info.Version.Revision
        Return result
    End Function

End Module
