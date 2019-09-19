
Imports System.Data.SqlClient

Imports System.Net.Mail
Imports System.Net

Imports System.Xml
Imports System.Text.RegularExpressions

Public Class Cierre_de_turno
    Private aes As New AES()
    Private correos As New MailMessage
    Private envios As New SmtpClient
    Dim diferencia As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MASCARA1.Hide()
        Close()
        VENTAS_MENU_PRINCIPAL.TimerDisposeMascara.Start()

    End Sub
    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

        Timer1.Start()


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
            lblEstado_de_envio.Text = "ENVIADO"
            'MessageBox.Show("Sincronizacion Creada Correctamente", "Sincronizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("No se envio al Correo. Ocurrio un Problema con el correo Sincronizado, vaya a Configuraciones para repararlo", "Envio fallido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    Public Sub ReadfromHtml()
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("Diseño_html.xml")
            Dim root As XmlElement = doc.DocumentElement
            dbcnString = root.Attributes.Item(0).Value
            RichTextBox1.Text = (aes.Decrypt(dbcnString, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException


        End Try
    End Sub
    Dim dbcnString As String
    Private Sub RemplazarTexto(ByVal RichTextBox As Object, Optional ByVal PosIni As Integer = 0)

        Dim Pos As Integer
        Dim TipoBusqueda As Long

        Dim PalabraClave(15) As String
        PalabraClave(0) = "@fecha"
        PalabraClave(1) = "@usuario_nombre"
        PalabraClave(2) = "@ventas_totales"
        PalabraClave(3) = "@esperado"
        PalabraClave(4) = "@Ganancias"
        PalabraClave(5) = "@fondo"
        PalabraClave(6) = "@ventas_efectivo"
        PalabraClave(7) = "@cobros"
        PalabraClave(8) = "@pagos"
        PalabraClave(9) = "@ingresosvarios"
        PalabraClave(10) = "@gastosvarios"
        PalabraClave(11) = "@vefectivo"
        PalabraClave(12) = "@vtarjeta"
        PalabraClave(13) = "@vcredito"
        PalabraClave(14) = "@Tventas"


        Dim Reemplaza(15) As String
        Reemplaza(0) = CIERRE_DE_CAJA.lbldesdehasta.Text.ToString()
        Reemplaza(1) = VENTAS_MENU_PRINCIPAL.lblLogin.Text.ToString
        Reemplaza(2) = CIERRE_DE_CAJA.LBLTOTALVENTAS.Text.ToString
        Reemplaza(3) = CIERRE_DE_CAJA.lblDineroEncajaTurnoTOTAL.Text.ToString()
        Reemplaza(4) = CIERRE_DE_CAJA.lblgananciasVentas.Text.ToString()
        Reemplaza(5) = CIERRE_DE_CAJA.lblfondodeCaja.Text.ToString()
        Reemplaza(6) = CIERRE_DE_CAJA.LBLVENTASenEfectivo.Text.ToString()
        Reemplaza(7) = CIERRE_DE_CAJA.lblabonosEfectivo.Text.ToString()
        Reemplaza(8) = CIERRE_DE_CAJA.lblPAGOSEfectivo.Text.ToString()
        Reemplaza(9) = CIERRE_DE_CAJA.LBLENTRADASVARIAS.Text.ToString()
        Reemplaza(10) = CIERRE_DE_CAJA.lblsalidasvarias.Text.ToString()
        Reemplaza(11) = CIERRE_DE_CAJA.LBLVentasEnEfectivo2.Text.ToString()
        Reemplaza(12) = CIERRE_DE_CAJA.lblventas_Tarjeta.Text.ToString()
        Reemplaza(13) = CIERRE_DE_CAJA.lblVentasAcredito.Text.ToString()
        Reemplaza(14) = CIERRE_DE_CAJA.lblVentas_suma.Text.ToString()
        For i As Integer = 0 To PalabraClave.Count - 1
            If Len(PalabraClave(i)) Then
                'Verificar si Mayusculas y Minusculas esta desactivada
                If CheckBox2.Checked = 0 Then
                    TipoBusqueda = vbTextCompare
                Else
                    TipoBusqueda = vbBinaryCompare
                End If

                Pos = InStr(PosIni + 1, RichTextBox1.Text, PalabraClave(i), TipoBusqueda)

                If Pos > 0 Then

                    With RichTextBox
                        RichTextBox1.SelectionStart = Pos - 3
                        RichTextBox1.SelectionLength = Len(PalabraClave(i))
                        RichTextBox1.Text = RichTextBox1.Text.Replace(PalabraClave(i), Reemplaza(i))
                        RichTextBox1.Focus()


                    End With
                    Me.Text = "Se encontro la palabra."

                Else

                    RichTextBox1.Focus()
                    Me.Text = "No se encontro."
                End If

            End If

        Next
    End Sub

    Sub mostrar_correo_de_empresa()

        Dim importe As String
        Dim com As New SqlCommand("Select Correo_para_envio_de_reportes from EMPRESA", conexion)


        Try
            abrir()
            importe = (com.ExecuteScalar())
            Cerrar()
            lblcorreo.Text = importe

        Catch ex As Exception

            lblcorreo.Text = 0
        End Try



    End Sub
    Sub mostrar_correo_base_correo()

        Dim estado As String
        Dim com As New SqlCommand("SELECT Estado_De_envio FROM Correo_base", conexion)
        Try
            abrir()
            estado = (com.ExecuteScalar())
            Cerrar()
            lblestadobase.Text = Desencriptar(estado)
        Catch ex As Exception
            lblestadobase.Text = 0
        End Try

        Dim correo As String
        Dim com1 As New SqlCommand("SELECT Correo FROM Correo_base", conexion)
        Try
            abrir()
            correo = (com.ExecuteScalar())
            Cerrar()
            lblcorreobase.Text = Desencriptar(correo)
        Catch ex As Exception
            lblcorreobase.Text = 0
        End Try

        Dim contraseña As String
        Dim com2 As New SqlCommand("SELECT Password FROM Correo_base", conexion)
        Try
            abrir()
            contraseña = (com.ExecuteScalar())
            Cerrar()
            lblcontraseñabase.Text = Desencriptar(contraseña)
        Catch ex As Exception
            lblcontraseñabase.Text = 0
        End Try

    End Sub
    Private Sub Cierre_de_turno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_correo_base_correo()

        lblcorreo.Visible = True
        txtcorreo.Visible = False
        btncancelar.Visible = False
        btnguardar.Visible = False
        btneditar.Visible = True
        Panel8.Visible = False
        mostrar_correo_de_empresa()
        LBLDeberiaHaber.Text = CIERRE_DE_CAJA.lblDineroEncajaTurnoTOTAL.Text

        TextBoxDESTINO.Text = lblcorreo.Text
        Panel2.Visible = False
        Panel2.Dock = DockStyle.None
        Label3.Text = "Enviando Reporte a " & TextBoxDESTINO.Text & " ..."
        lbldiferencia.Text = 0

        Try

            Me.lblcondicional_de_envio.Text = datalistado_correo_base.SelectedCells.Item(4).Value
        Catch ex As Exception

        End Try
        If lblcondicional_de_envio.Text <> "ACTIVO" Then
            TXTENVIOS_A_CORREOS.Checked = True
        ElseIf lblcondicional_de_envio.Text = "ACTIVO" Then
            TXTENVIOS_A_CORREOS.Checked = True
        End If


        If lblestadobase.Text <> "SIN CONEXION" Then
            TXTENVIOS_A_CORREOS.Checked = True
        Else
            TXTENVIOS_A_CORREOS.Checked = False
        End If
    End Sub

    Private Sub txthay_TextChanged(sender As Object, e As EventArgs) Handles txthay.TextChanged

        Try


            diferencia = txthay.Text * 1 - LBLDeberiaHaber.Text * 1
            lbldiferencia.Text = diferencia
        Catch ex As Exception

            lbldiferencia.Text = LBLDeberiaHaber.Text
        End Try

        Try
            If diferencia = 0 Then
                PictureBox5.Visible = False
                lblanuncio.Text = "Genial, Todo esta perfecto"
                lblanuncio.ForeColor = Color.FromArgb(0, 166, 63)
                lbldiferencia.ForeColor = Color.FromArgb(0, 166, 63)
                lblanuncio.Visible = True
            ElseIf diferencia < LBLDeberiaHaber.Text * 1 Then
                PictureBox5.Visible = True

                lbldiferencia.ForeColor = Color.FromArgb(231, 63, 67)
                lblanuncio.Visible = True
                lblanuncio.ForeColor = Color.FromArgb(231, 63, 67)
                lblanuncio.Text = "La diferencia sera Registrada en su Turno y se enviara a Gerencia"
            ElseIf diferencia > LBLDeberiaHaber.Text * 1 Then
                PictureBox5.Visible = True
                lbldiferencia.ForeColor = Color.FromArgb(231, 63, 67)
                lblanuncio.Visible = True
                lblanuncio.ForeColor = Color.FromArgb(231, 63, 67)
                lblanuncio.Text = "La diferencia sera Registrada en su Turno y se enviara a Gerencia"
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 20
            Panel2.Visible = True
            Panel2.Dock = DockStyle.Fill
        Else
            Timer1.Stop()
            ProgressBar1.Value = 0

            Try
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("CERRAR_CAJA", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@idcaja", CIERRE_DE_CAJA.datalistado_CIERRE_DE_CAJA_PENDIENTE.SelectedCells.Item(3).Value)
                cmd.Parameters.AddWithValue("@fechafin", txtfechaFinal.Value)
                cmd.Parameters.AddWithValue("@fechacierre", txtfechaFinal.Value)
                cmd.ExecuteNonQuery()

                Cerrar()


            Catch ex As Exception
            End Try

            If TXTENVIOS_A_CORREOS.Checked = True Then
                Try
                    ReadfromHtml()
                    RemplazarTexto(RichTextBox:=RichTextBox1.Rtf, PosIni:=0)
                    enviarCorreo(emisor:=lblcorreobase.Text, password:=lblcontraseñabase.Text, mensaje:=RichTextBox1.Text, asunto:="Cierre de Caja", destinatario:=TextBoxDESTINO.Text, ruta:="")

                    GENERADOR_DE_COPIAS_AUTOMATICO.ShowDialog()
                Catch ex As Exception
                End Try
            End If
            GENERADOR_DE_COPIAS_AUTOMATICO.ShowDialog()
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtde_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GuardarRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TXTENVIOS_A_CORREOS_CheckedChanged(sender As Object, e As EventArgs) Handles TXTENVIOS_A_CORREOS.CheckedChanged
        'If TXTENVIOS_A_CORREOS.Checked = True Then


        'ElseIf TXTENVIOS_A_CORREOS.Checked = False Then

        'End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub lblEstado_de_envio_Click(sender As Object, e As EventArgs) Handles lblEstado_de_envio.Click, lblcondicional_de_envio.Click

    End Sub


    Private Sub LabelRegistros_de_correo_base_Click(sender As Object, e As EventArgs) Handles LabelRegistros_de_correo_base.Click

    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        lblcorreo.Visible = False
        txtcorreo.Visible = True
        txtcorreo.Text = ""
        btneditar.Visible = False
        btnguardar.Visible = True
        btncancelar.Visible = True
        Panel8.Visible = True
        txtcorreo.Focus()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        lblcorreo.Visible = True
        txtcorreo.Visible = False
        Panel8.Visible = False
        btneditar.Visible = True
        btnguardar.Visible = False
        btncancelar.Visible = False
    End Sub
    Sub guardar_cambios_correo()
        Dim cmd As New SqlCommand
        Try

            abrir()
            cmd = New SqlCommand("editar_correo_Empresa", conexion)
            cmd.CommandType = 4

            cmd.Parameters.AddWithValue("@Correo_para_envio_de_reportes", txtcorreo.Text)

            cmd.ExecuteNonQuery()


        Catch ex As Exception : MsgBox(ex.Message)
            End Try






    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If validar_Mail(LCase(txtcorreo.Text)) = False Then
            MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com, " & " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcorreo.Focus()
            txtcorreo.SelectAll()

        Else
            guardar_cambios_correo()
            lblcorreo.Visible = True
            txtcorreo.Visible = False
            Panel8.Visible = False
            btneditar.Visible = True
            btnguardar.Visible = False
            btncancelar.Visible = False
            lblcorreo.Text = txtcorreo.Text

        End If
    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TXTENVIOS_A_CORREOS_Click(sender As Object, e As EventArgs) Handles TXTENVIOS_A_CORREOS.Click
        If lblestadobase.Text = "SIN CONEXION" Then
            Configurar_envio_a_correo.ShowDialog()


        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        mostrar_correo_base_correo()
        If lblestadobase.Text <> "SIN CONEXION" Then
            TXTENVIOS_A_CORREOS.Checked = True
        Else
            TXTENVIOS_A_CORREOS.Checked = False
        End If
        Timer2.Stop()

    End Sub
End Class