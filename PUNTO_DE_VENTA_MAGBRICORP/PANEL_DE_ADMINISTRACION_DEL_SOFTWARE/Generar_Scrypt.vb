

Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Xml
Public Class Generar_Scrypt
    Private aes As New AES()
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCnString.Text = "" Then
            MessageBox.Show("Por favor ingrese codigo html..", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            SavetoScript_sql(aes.Encrypt(txtCnString.Text, appPwdUnique, Integer.Parse("256")))
            MessageBox.Show("Codigo Guardado", "Encryptacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If
    End Sub

    Public Sub SavetoScript_sql(ByVal dbcnString)
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load("script_sql.xml")
        Dim root As XmlElement = doc.DocumentElement
        root.Attributes.Item(0).Value = dbcnString
        Dim writer As XmlTextWriter = New XmlTextWriter("script_sql.xml", Nothing)
        writer.Formatting = Formatting.Indented
        doc.Save(writer)
        writer.Close()
    End Sub
    Dim dbcnString As String
    Public Sub ReadfromScript_sql()
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("script_sql.xml")
            Dim root As XmlElement = doc.DocumentElement
            dbcnString = root.Attributes.Item(0).Value
            txtCnString.Text = (aes.Decrypt(dbcnString, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException


        End Try
    End Sub
    Private Sub Generar_Scrypt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadfromScript_sql()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class