Imports System.IO
Imports System.Text

Module LogsHelper

    Public Enum LogsType
        Loading = 1
        Download = 2
    End Enum

    Public Enum LogsLevel
        _Info_ = 1
        _Warning_ = 2
        _Alert_ = 3
        _Error_ = 4
    End Enum

    ''' <summary>
    ''' Add and write logs to file
    ''' </summary>
    Public Sub AddLogs(level As LogsLevel, message As String, stackTrace As String)
        Dim l As New StringBuilder

        'if there is already a log file
        If File.Exists(AppGlobals.logsFilePath) Then

            'if the log file is older than 7 days, it will be deleted else, errors are append to the existing file
            If File.GetLastWriteTime(AppGlobals.logsFilePath) < New Date(Now.Ticks).AddDays(-7) Then
                File.Delete(AppGlobals.logsFilePath)
            Else
                l.Append(File.ReadAllText(AppGlobals.logsFilePath))
            End If

            AppGlobals.logs.AddErrorsRow(level, message, stackTrace)

        End If

        For Each r As Logs.ErrorsRow In AppGlobals.logs.Rows
            Dim mess As String = String.Empty
            Dim stack As String = String.Empty

            If r IsNot Nothing Then
                If Not r.IsMessageNull Then mess = r.Message
                If Not r.IsStackTraceNull Then stack = r.StackTrace
            End If

            l.AppendLine(mess & ";" & Stack)
        Next

        File.WriteAllText(AppGlobals.logsFilePath, l.ToString)
    End Sub

    ''' <summary>
    ''' Add and write logs to file
    ''' </summary>
    Public Sub AddLogs(e As Exception)
        AddLogs(LogsLevel._Error_, e.Message, e.StackTrace)
    End Sub

    ''' <summary>
    ''' Display a message containing the error
    ''' </summary>
    ''' <param name="e"></param>
    Public Sub ShowErrorMessage(e As Exception)
        AddLogs(e)

        MessageBox.Show(e.Message, "Error !!!",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error)
    End Sub

End Module
