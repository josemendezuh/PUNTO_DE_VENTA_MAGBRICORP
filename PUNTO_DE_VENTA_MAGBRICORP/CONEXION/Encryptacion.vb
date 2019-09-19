Imports System
Imports System.Security.Cryptography
Imports System.IO

Public Class AES
    Private Function Encrypt(ByVal clearData() As Byte, ByVal Key() As Byte, ByVal IV() As Byte) As Byte()
        Dim ms As New MemoryStream()
        Dim alg As Rijndael = Rijndael.Create()
        alg.Key = Key
        alg.IV = IV
        Dim cs As New CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write)
        cs.Write(clearData, 0, clearData.Length)
        cs.Close()
        Dim encryptedData() As Byte = ms.ToArray()
        Return encryptedData
    End Function

    Public Function Encrypt(ByVal Data As String, ByVal Password As String, ByVal Bits As Integer) As String
        Dim clearBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(Data)
        Dim pdb As New PasswordDeriveBytes(Password, New Byte() {&H0, &H1, &H2, &H1C, &H1D, &H1E, &H3, &H4, &H5, &HF, &H20, &H21, &HAD, &HAF, &HA4})
        If Bits = 128 Then
            Dim encryptedData() As Byte = Encrypt(clearBytes, pdb.GetBytes(16), pdb.GetBytes(16))
            Return Convert.ToBase64String(encryptedData)
        ElseIf Bits = 192 Then
            Dim encryptedData() As Byte = Encrypt(clearBytes, pdb.GetBytes(24), pdb.GetBytes(16))
            Return Convert.ToBase64String(encryptedData)
        ElseIf Bits = 256 Then
            Dim encryptedData() As Byte = Encrypt(clearBytes, pdb.GetBytes(32), pdb.GetBytes(16))
            Return Convert.ToBase64String(encryptedData)
        Else
            Return String.Concat(Bits)
        End If
    End Function

    Private Function Decrypt(ByVal cipherData() As Byte, ByVal Key() As Byte, ByVal IV() As Byte) As Byte()
        On Error Resume Next
        Dim ms As New MemoryStream()
        Dim alg As Rijndael = Rijndael.Create()
        alg.Key = Key
        alg.IV = IV
        Dim cs As New CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write)
        cs.Write(cipherData, 0, cipherData.Length)
        cs.Close()
        Dim decryptedData() As Byte = ms.ToArray()
        Return decryptedData
    End Function
    Public Function Decrypt(ByVal Data As String, ByVal Password As String, ByVal Bits As Integer) As String
        Try
            Dim cipherBytes() As Byte = Convert.FromBase64String(Data)
            Dim pdb As New PasswordDeriveBytes(Password, New Byte() {&H0, &H1, &H2, &H1C, &H1D, &H1E, &H3, &H4, &H5, &HF, &H20, &H21, &HAD, &HAF, &HA4})

            If Bits = 128 Then
                Dim decryptedData() As Byte = Decrypt(cipherBytes, pdb.GetBytes(16), pdb.GetBytes(16))
                Return System.Text.Encoding.Unicode.GetString(decryptedData)
            ElseIf Bits = 192 Then
                Dim decryptedData() As Byte = Decrypt(cipherBytes, pdb.GetBytes(24), pdb.GetBytes(16))
                Return System.Text.Encoding.Unicode.GetString(decryptedData)
            ElseIf Bits = 256 Then
                Dim decryptedData() As Byte = Decrypt(cipherBytes, pdb.GetBytes(32), pdb.GetBytes(16))
                Return System.Text.Encoding.Unicode.GetString(decryptedData)
            Else
                Return String.Concat(Bits)
            End If
        Catch ex As Exception

        End Try

    End Function
End Class