Public Class InternalEncryption

    ''' <summary>
    ''' Encode a content with a specific password
    ''' </summary>
    ''' <param name="content"></param>
    ''' <param name="password"></param>
    ''' <returns></returns>
    Public Shared Function Encode(content As String, password As String) As String
        Dim encodedContent As String = String.Empty

        Try
            Dim wrapper As New Simple3Des(password)
            encodedContent = wrapper.EncryptData(content)
        Catch ex As Exception
            Throw ex
        End Try

        Return encodedContent
    End Function

    ''' <summary>
    ''' Decode a content with a specific password
    ''' </summary>
    ''' <param name="content"></param>
    ''' <param name="password"></param>
    ''' <returns></returns>
    Public Shared Function Decode(content As String, password As String) As String
        Dim decodedContent As String = String.Empty

        Try
            Dim wrapper As New Simple3Des(password)
            decodedContent = wrapper.DecryptData(content)
        Catch ex As Exception
            Throw ex
        End Try

        Return decodedContent
    End Function

    ''' <summary>
    ''' Generate Application Password
    ''' </summary>
    Public Shared Sub GenerateApplicationPassword()
        ' define password : 
        LibGlobals.EncryptionPwd = Chr(117) &
            Chr(114) &
            Chr(117) &
            Chr(107) &
            Chr(97) &
            Chr(105) &
            Chr(32) &
            Chr(115) &
            Chr(99) &
            Chr(114) &
            Chr(97) &
            Chr(112) &
            Chr(101) &
            Chr(114) &
            Chr(32) &
            Chr(97) &
            Chr(116) &
            Chr(116) &
            Chr(114) &
            Chr(97) &
            Chr(99) &
            Chr(116) &
            Chr(32) &
            Chr(109) &
            Chr(111) &
            Chr(100) &
            Chr(101)
    End Sub

End Class
