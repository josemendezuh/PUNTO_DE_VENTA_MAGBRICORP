
Imports System.Management
Imports System.Data.SqlClient

Public Class PANEL_CONFIGURACIONES

    Private MisDiscos As New ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard")
    Private DiscInfo As New ManagementObject

    Sub mostrar_empresas()



        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("mostrar_Empresa", conexion)


            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            'dtempresaok.DataSource = dtDATALISTADO_AGREGANDO
            Cerrar()

        Catch ex As Exception
        End Try




        Try

        Catch ex As Exception
        End Try
    End Sub
    Sub mostrar_correo_base()

        Dim importe As String
        Dim com As New SqlCommand("SELECT Estado_De_envio FROM Correo_base", conexion)

        Try
            abrir()
            importe = (com.ExecuteScalar())
            Cerrar()
            LBLEstado_correo.Text = Desencriptar(importe)
        Catch ex As Exception
            LBLEstado_correo.Text = 0
        End Try

    End Sub
    Private Sub Apagado2_Click(sender As Object, e As EventArgs) Handles Apagado2.Click
        tema = "Elegante Black"



        TimerEncendido.Start()
        editar_tema()
    End Sub
    Private Sub Apagadado_Click(sender As Object, e As EventArgs) Handles Apagado.Click


        TimerEncendido.Start()
    End Sub
    Private Sub Encendido_Click(sender As Object, e As EventArgs) Handles Encendido.Click


        Try
            tema = "Redentor"
            TimerApagado.Start()
            editar_tema()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub PANEL_CONFIGURACIONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Location = New Point((Width - Panel1.Width) / 2, (Height - Panel1.Height) / 2)
        mostrar_correo_base()
        Dim numero_correos As Integer
        If LBLEstado_correo.Text <> "SIN CONEXION" Then
            btnEnvios_a_correo.Text = "Activado"
            btnEnvios_a_correo.BackColor = Color.FromArgb(8, 198, 91)
        Else
            btnEnvios_a_correo.Text = "Activar"
            btnEnvios_a_correo.BackColor = Color.Orange
        End If

        mostrar_tema_por_caja()
        Try

            If tema = "Elegante Black" Then
                Encendido.Visible = True
                Apagado.Visible = False
                Encendido2.Visible = False
                Apagado2.Visible = False
                gif_apagado.Visible = False
                gif_encendido.Visible = False

            ElseIf tema = "Redentor" Then
                Apagado2.Visible = True
                Encendido.Visible = False
                Apagado.Visible = False
                Encendido2.Visible = False
                gif_apagado.Visible = False
                gif_encendido.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Dim tema As String

    Sub mostrar_tema_por_caja()
        Dim MiInfo = From Hd As ManagementObject In MisDiscos.Get Select Hd
        DiscInfo = MiInfo(0)
        lblIDSERIAL.Text = DiscInfo.Properties("SerialNumber").Value
        Dim importe As String
        Dim com As New SqlCommand("mostrar_tema_por_caja", conexion)
        com.CommandType = 4
        com.Parameters.AddWithValue("@Serial", lblIDSERIAL.Text)


        Try
            abrir()
            importe = (com.ExecuteScalar())
            Cerrar()
            tema = importe

        Catch ex As Exception
            tema = 0

        End Try


    End Sub

    Private Sub Panel16_Click(sender As Object, e As EventArgs) Handles Panel16.Click
        MASCARA1.Show()
        EMPRESA_CONFIG.ShowDialog()
    End Sub

    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs) Handles Panel16.Paint


    End Sub

    Private Sub LBLempresa_Click(sender As Object, e As EventArgs)
        MASCARA1.Show()
        EMPRESA_CONFIG.ShowDialog()
    End Sub



    Private Sub Logo_institucion_Click(sender As Object, e As EventArgs) Handles Logo_empresa.Click
        MASCARA1.Show()
        MASCARA1.FormBorderStyle = FormBorderStyle.None
        EMPRESA_CONFIG.ShowDialog()
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub




    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

        CONEXION_MANUAL.ShowDialog()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        MASCARA1.Show()
        usuariosok.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        MASCARA1.Show()
        usuariosok.ShowDialog()
    End Sub

    Private Sub Panel27_Click(sender As Object, e As EventArgs)

        Ticket.ShowDialog()

    End Sub

    Private Sub Panel27_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel31_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub txttema_SelectedIndexChanged(sender As Object, e As EventArgs)
        'Try
        '    Dim cmd As New SqlCommand

        '    abrir()
        '    cmd = New SqlCommand("Tema", conexion)
        '    cmd.CommandType = 4
        '    cmd.Parameters.AddWithValue("@Tema", txttema.Text)
        '    cmd.Parameters.AddWithValue("@Id_caja", VENTAS_MENU_PRINCIPAL.lblidcaja.Text)
        '    cmd.ExecuteNonQuery()
        '    Cerrar()
        '    VENTAS_MENU_PRINCIPAL.TimerEmpresa.Start()
        'Catch ex As Exception

        'End Try
        'If txttema.Text = "Elegante Black" Then
        '    Tema_EleganteBlack.Visible = True
        '    TemaRedentor.Visible = False
        'ElseIf txttema.Text = "Redentor" Then
        '    Tema_EleganteBlack.Visible = False
        '    TemaRedentor.Visible = True
        'End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

        GESTION_DE_BASE_DE_DATOS.ShowDialog()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)
        Membresias.ShowDialog()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs)

        Ticket.ShowDialog()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)
        GENERADOR_DE_DISEÑO_HTML.ShowDialog()
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs)

        GESTION_DE_BASE_DE_DATOS.ShowDialog()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

        GESTION_DE_BASE_DE_DATOS.ShowDialog()
    End Sub





    Private Sub Label24_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MASCARA1.Show()
        MASCARA1.FormBorderStyle = FormBorderStyle.None

        usuariosok.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        SERIALIZACION.ShowDialog()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click

        Admin_de_IMPRESORAS.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MASCARA1.Show()
        MASCARA1.FormBorderStyle = FormBorderStyle.None

        GENERAR_COPIAS_DE_SEGURIDAD.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ticket.ShowDialog()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mostrar_correo_base()

        If LBLEstado_correo.Text <> "SIN CONEXION" Then
            btnEnvios_a_correo.Text = "Activado"
            btnEnvios_a_correo.BackColor = Color.FromArgb(8, 198, 91)
        Else
            btnEnvios_a_correo.Text = "Activar"
            btnEnvios_a_correo.BackColor = Color.Orange
        End If
        Timer1.Stop()

    End Sub

    Private Sub btnEnvios_a_correo_Click(sender As Object, e As EventArgs) Handles btnEnvios_a_correo.Click
        Configurar_envio_a_correo.ShowDialog()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Configurar_envio_a_correo.ShowDialog()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Configurar_envio_a_correo.ShowDialog()
    End Sub

    Private Sub txttema_CheckedChanged(sender As Object, e As EventArgs)

        editar_tema()

    End Sub
    Sub editar_tema()
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("Tema", conexion)
            cmd.CommandType = 4

            cmd.Parameters.AddWithValue("@Tema", tema)


            cmd.Parameters.AddWithValue("@Id_caja", VENTAS_MENU_PRINCIPAL.lblidcaja.Text)
            cmd.ExecuteNonQuery()
            Cerrar()
            VENTAS_MENU_PRINCIPAL.TimerEmpresa.Start()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TimerEncendido_Tick(sender As Object, e As EventArgs) Handles TimerEncendido.Tick
        If ProgressEncendido.Value < 100 Then
            ProgressEncendido.Value = ProgressEncendido.Value + 11
            Encendido.Visible = False
            Apagado.Visible = False
            Encendido2.Visible = False
            Apagado2.Visible = False
            gif_apagado.Visible = False
            gif_encendido.Visible = True
        Else
            ProgressEncendido.Value = 0
            TimerEncendido.Stop()
            Encendido.Visible = True
            gif_encendido.Visible = False





        End If
    End Sub

    Private Sub TimerApagado_Tick(sender As Object, e As EventArgs) Handles TimerApagado.Tick

        If ProgressApagado.Value < 100 Then
            ProgressApagado.Value = ProgressApagado.Value + 20
            Encendido.Visible = False
            Apagado.Visible = False
            Encendido2.Visible = False
            Apagado2.Visible = False
            gif_apagado.Visible = True
            gif_encendido.Visible = False
        Else
            gif_apagado.Visible = False
            Apagado2.Visible = True
            ProgressApagado.Value = 0
            TimerApagado.Stop()


        End If
    End Sub

    Private Sub Label42_Click(sender As Object, e As EventArgs) Handles Label42.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class