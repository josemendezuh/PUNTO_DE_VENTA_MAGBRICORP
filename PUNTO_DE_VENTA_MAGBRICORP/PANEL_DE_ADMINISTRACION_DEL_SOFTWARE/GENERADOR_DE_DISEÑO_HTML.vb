Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Xml
Public Class GENERADOR_DE_DISEÑO_HTML
    Private aes As New AES()
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCnString.Text = "" Then
            MessageBox.Show("Por favor ingrese codigo html..", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            SavetoHTML(AES.Encrypt(txtCnString.Text, appPwdUnique, Integer.Parse("256")))
            MessageBox.Show("Codigo Guardado", "Encryptacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If
    End Sub

    Public Sub SavetoHTML(ByVal dbcnString)
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load("Diseño_html.xml")
        Dim root As XmlElement = doc.DocumentElement
        root.Attributes.Item(0).Value = dbcnString
        Dim writer As XmlTextWriter = New XmlTextWriter("Diseño_html.xml", Nothing)
        writer.Formatting = Formatting.Indented
        doc.Save(writer)
        writer.Close()
    End Sub
    Dim dbcnString As String
    Public Sub ReadfromHtml()
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("Diseño_html.xml")
            Dim root As XmlElement = doc.DocumentElement
            dbcnString = root.Attributes.Item(0).Value
            txtCnString.Text = (aes.Decrypt(dbcnString, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException


        End Try
    End Sub
    Private Sub GENERADOR_DE_DISEÑO_HTML_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadfromHtml()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class