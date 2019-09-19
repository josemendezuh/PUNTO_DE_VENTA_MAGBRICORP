
Imports System.Data.SqlClient

Imports System.Net.Mail
Imports System.Net

Imports System.Xml
Imports System.Text.RegularExpressions
Imports System.ComponentModel

Public Class Configurar_envio_a_correo
    Private aes As New AES()
    Private correos As New MailMessage
    Private envios As New SmtpClient
    Dim diferencia As Double
    Private Sub Configurar_envio_a_correo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Location = New Point((Width - Panel1.Width) / 2, (Height - Panel1.Height) / 2)
        TXTCORREO.Clear()
        txtpass.Clear()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        enviarCorreo(emisor:=TXTCORREO.Text, password:=txtpass.Text, mensaje:="Sincronizacion con ADA369 creada Correctamente", asunto:="Sincronizacio con ADA369", destinatario:=TXTCORREO.Text, ruta:="")

    End Sub
    Sub enviarCorreo(ByVal emisor As String, ByVal password As String, ByVal mensaje As String, ByVal asunto As String, ByVal destinatario As String, ByVal ruta As String)
        Try
            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.Body = mensaje
            correos.Subject = asunto
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario))
            correos.From = New MailAddress(emisor)
            envios.Credentials = New NetworkCredential(emisor, password)

            'Datos importantes no modificables para tener acceso a las cuentas

            envios.Host = "smtp.gmail.com"
            envios.Port = 587
            envios.EnableSsl = True

            envios.Send(correos)
            'lblEstado_de_envio.Text = "ENVIADO"
            editar_correo_base()
            MessageBox.Show("Sincronizacion Creada Correctamente", "Sincronizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cierre_de_turno.Timer2.Start()
            PANEL_CONFIGURACIONES.Timer1.Start()


            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Sincronizacion Fallida, revisa el Video de Nuevo", "Sincronizacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Cierre_de_turno.Timer2.Start()
        End Try

    End Sub
    Sub editar_correo_base()
        Try
            Dim correo As String
            Dim pass As String
            Dim estado As String
            correo = Encriptar(TXTCORREO.Text)
            pass = Encriptar(txtpass.Text)
            estado = Encriptar("CONECTADO")

            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("editar_correo_base", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Correo", correo)
            cmd.Parameters.AddWithValue("@Password", pass)
            cmd.Parameters.AddWithValue("@Estado_De_envio", estado)
            cmd.ExecuteNonQuery()

            Cerrar()


        Catch ex As Exception
        End Try
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try

            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=HuZCS2OQ84g&t=3s")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tver_Click(sender As Object, e As EventArgs) Handles tver.Click
        txtpass.PasswordChar = ""
    End Sub

    Private Sub tocultar_Click(sender As Object, e As EventArgs) Handles tocultar.Click
        txtpass.PasswordChar = "*"
    End Sub

    Private Sub Configurar_envio_a_correo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Cierre_de_turno.TXTENVIOS_A_CORREOS.Checked = False
    End Sub
End Class