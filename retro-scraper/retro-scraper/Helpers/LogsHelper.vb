Imports System.IO
Imports System.Text

Module LogsHelper

    ''' <summary>
    ''' Add and write logs to file
    ''' </summary>
    Public Sub AddLogs(Optional e As Exception = Nothing)
        Dim l As New StringBuilder

        'if there is already a log file
        If File.Exists(AppGlobals.logsFilePath) Then

            'if the log file is older than 7 days, it will be deleted else, errors are append to the existing file
            If File.GetLastWriteTime(AppGlobals.logsFilePath) < New Date(Now.Ticks).AddDays(-7) Then
                File.Delete(AppGlobals.logsFilePath)
            Else
                l.Append(File.ReadAllText(AppGlobals.logsFilePath))
            End If

            If e IsNot Nothing Then AppGlobals.logs.AddErrorsRow(e.Message, e.StackTrace)

        End If

        For Each r As Logs.ErrorsRow In AppGlobals.logs.Rows
            l.AppendLine(r.Message & ";" & r.StackTrace)
        Next

        File.WriteAllText(AppGlobals.logsFilePath, l.ToString)
    End Sub

    ''' <summary>
    ''' Display a message containing the error
    ''' </summary>
    ''' <param name="e"></param>
    Public Sub ShowErrorMessage(e As Exception)
        MessageBox.Show(e.Message, "Error !!!",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error)
    End Sub

End Module
