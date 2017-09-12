Imports System.IO
Imports System.Security.Cryptography

Module Md5Helper

#Region "MD5"
    ''' <summary>
    ''' Return the file's Hash
    ''' </summary>
    ''' <param name="hash_type"></param>
    ''' <param name="file_name"></param>
    ''' <returns></returns>
    Private Function hash_generator(ByVal hash_type As String, ByVal file_name As String)

        ' On déclare la variable : hash
        Dim hash
        If hash_type.ToLower = "md5" Then
            ' Initialise un objet de hash : md5
            hash = MD5.Create
        ElseIf hash_type.ToLower = "sha1" Then
            ' Initialise un objet de hash : SHA-1
            hash = SHA1.Create()
        ElseIf hash_type.ToLower = "sha256" Then
            ' Initialise un objet de hash : SHA-256
            hash = SHA256.Create()
        Else
            MsgBox("Type de hash inconnu : " & hash_type, MsgBoxStyle.Critical)
            Return False
        End If

        ' On déclare une variable qui sera un tableau de bytes (octets)
        Dim hashValue() As Byte

        ' On crée un FileStream pour le fichier passé en paramètre
        Dim fileStream As FileStream = File.OpenRead(file_name)
        ' On positionne le curseur au début du stream
        fileStream.Position = 0
        ' On calcule le hash du fichier
        hashValue = hash.ComputeHash(fileStream)
        ' On convertit le tableau d'octets (bytes) en hexadécimal pour qu'on puisse le lire facilement
        Dim hash_hex = PrintByteArray(hashValue)

        ' On ferme le fichier ouvert
        fileStream.Close()

        ' On retourne le hash
        Return hash_hex

    End Function

    ''' <summary>
    ''' On parcoure le tableau de bytes (octets) et on convertit chaque octet (byte) en hexadécimal
    ''' </summary>
    ''' <param name="array"></param>
    ''' <returns></returns>
    Public Function PrintByteArray(ByVal array() As Byte)

        Dim hex_value As String = ""

        ' On parcoure le tableau de bytes (octets)
        Dim i As Integer
        For i = 0 To array.Length - 1

            ' on convertit chaque octet (byte) en hexadécimal
            hex_value += array(i).ToString("X2")

        Next i

        ' On retourne la chaine de caractères en minuscules
        Return hex_value.ToLower

    End Function

    ''' <summary>
    ''' md5 est un nom réservé, nous avons donc nommé la fonction : md5_hash
    ''' </summary>
    ''' <param name="file_name"></param>
    ''' <returns></returns>
    Function md5_hash(ByVal file_name As String)
        Return hash_generator("md5", file_name)
    End Function

    Function sha_1(ByVal file_name As String)
        Return hash_generator("sha1", file_name)
    End Function

    Function sha_256(ByVal file_name As String)
        Return hash_generator("sha256", file_name)
    End Function
#End Region

End Module
