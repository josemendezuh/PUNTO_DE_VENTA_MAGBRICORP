
Imports System.Data.SqlClient
Imports System.Net.Mail

Imports System.Management
Imports System.Xml

Public Class Cambio_de_usuario
    Private aes As New AES()

    Dim MOVIENDO As Boolean = False
    Private r As Random
    Dim MIX As Integer
    Dim MIY As Integer
    Private dt As New DataTable
    Private MisDiscos As New ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard")
    Private DiscInfo As New ManagementObject

    Sub mostrar_usuarios_registrados()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("select * from USUARIO2", conexion)
            da.Fill(dt)
            datalistado_USUARIOS_REGISTRADOS.DataSource = dt
            Cerrar()

        Catch ex As Exception
        End Try

    End Sub
    Sub contar_USUARIOS()
        Dim x As Integer
        x = datalistado_USUARIOS_REGISTRADOS.Rows.Count
        txtcontador_USUARIOS.Text = CStr(x)
    End Sub

    Dim dbcnString As String
    Public Sub ReadfromXML_SERIAL_PC()
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("Serial_x.xml")
            Dim root As XmlElement = doc.DocumentElement
            dbcnString = root.Attributes.Item(0).Value
            lblSerialPc_WEB.Text = (aes.Decrypt(dbcnString, appPwdUnique, Integer.Parse("256")))


        Catch ex As System.Security.Cryptography.CryptographicException
            lblSerialPc_WEB.Text = "NULO"
        End Try
    End Sub
    Public Sub ReadfromXML_FECHA()
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("Serial_ff.xml")
            Dim root As XmlElement = doc.DocumentElement
            dbcnString = root.Attributes.Item(0).Value
            lblfecha_expiracionWEB.Text = (aes.Decrypt(dbcnString, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException
            lblfecha_expiracionWEB.Text = "NULO"
        End Try
    End Sub

    Sub dibujarUSUARIOS()
        Try
            r = New Random()
            abrir()
            Dim query As String = "select * from USUARIO2"
            Dim cmd As New SqlCommand(query, conexion)
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            Dim NBotones As Integer = 3
            While rdr.Read()
                'Dim b As New Button()
                Dim p1 As New Panel
                Dim P2 As New Panel

                Dim L As New Label
                Dim ICONO As New PictureBox
                For I As Integer = 0 To NBotones
                    'b.Text = rdr("Login").ToString()
                    'b.Name = rdr("Login").ToString()
                    'b.Size = New System.Drawing.Size(230, 35)
                    'b.Font = New Font("Segoe UI", 18, FontStyle.Regular Or FontStyle.Bold)

                    'b.BackColor = BackColor
                    'b.FlatStyle = FlatStyle.Flat
                    'b.FlatAppearance.BorderSize = 0
                    'b.BackColor = Color.White
                    'b.ForeColor = Color.Black
                    'b.Dock = DockStyle.Fill
                    'b.TextAlign = ContentAlignment.MiddleCenter
                    'b.Cursor = Cursors.Hand
                    L.Text = rdr("Login").ToString()
                    L.Name = rdr("Login").ToString()
                    L.Size = New System.Drawing.Size(230, 40)
                    L.Font = New Font("Segoe UI", 18, FontStyle.Regular Or FontStyle.Bold)
                    L.BackColor = BackColor
                    L.FlatStyle = FlatStyle.Flat
                    L.BackColor = Color.Transparent
                    L.ForeColor = Color.White
                    L.Dock = DockStyle.Bottom
                    L.TextAlign = ContentAlignment.MiddleCenter
                    L.Cursor = Cursors.Hand

                    p1.Size = New System.Drawing.Size(186, 155)
                    p1.BorderStyle = BorderStyle.None
                    p1.Dock = DockStyle.Top
                    p1.BackColor = Color.Transparent
                    P2.Size = New System.Drawing.Size(243, 6)
                    P2.Dock = DockStyle.Bottom
                    P2.BackColor = Color.FromArgb(r.[Next](0, 255), r.[Next](0, 255), r.[Next](0, 255))

                    ICONO.Name = rdr("Icono").ToString()
                    If ICONO.Name = 1 Then
                        ICONO.Image = My.Resources.monster
                    ElseIf ICONO.Name = 2 Then
                        ICONO.Image = My.Resources.pacman
                    ElseIf ICONO.Name = 3 Then
                        ICONO.Image = My.Resources.homero
                    ElseIf ICONO.Name = 4 Then
                        ICONO.Image = My.Resources.cerveza
                    ElseIf ICONO.Name = 5 Then
                        ICONO.Image = My.Resources.naruto
                    ElseIf ICONO.Name = 6 Then
                        ICONO.Image = My.Resources.gokuqueda
                    ElseIf ICONO.Name = 7 Then
                        ICONO.Image = My.Resources.Candy_Candy_candy_candy_9421203_572_508
                    ElseIf ICONO.Name = 8 Then
                        ICONO.Image = My.Resources.sakura

                    End If
                    ICONO.SizeMode = PictureBoxSizeMode.Zoom
                    'ICONO.Size = New System.Drawing.Size(186, 35)
                    ICONO.Dock = DockStyle.Fill
                    ICONO.Tag = rdr("Login").ToString()
                Next
                p1.Controls.Add(ICONO)
                p1.Controls.Add(L)
                p1.Controls.Add(P2)

                'P2.Controls.Add(L)

                L.SendToBack()

                'L.BringToFront()
                P2.SendToBack()

                AddHandler L.Click, AddressOf miEventoLOGIN
                AddHandler ICONO.Click, AddressOf miEventopicturebox
            End While
            Cerrar()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub miEventoLOGIN(ByVal sender As System.Object, ByVal e As EventArgs)
        Try
            txtpaswwor.Text = ""
            txtlogin.Text = DirectCast(sender, Label).Name
        Catch ex As Exception

        End Try

    End Sub
    Private Sub miEventopicturebox(ByVal sender As System.Object, ByVal e As EventArgs)
        Try
            txtpaswwor.Text = ""
            txtlogin.Text = DirectCast(sender, PictureBox).Tag
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Cambio_de_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel5.Visible = False
        txtpaswwor.Text = ""
        txtpaswwor.Focus()

        Panel5.Visible = True



        txtpaswwor.Focus()
        txtlogin.Text = VENTAS_MENU_PRINCIPAL.lbllogin_cambio_de_usuario.Text
        MOSTRAR_PERMISOS()
    End Sub
    Sub MOSTRAR_PERMISOS()


        Dim importe As String
        Dim com As New SqlCommand("mostrar_permisos_por_usuario_ROL_UNICO", conexion)
        com.CommandType = 4
        com.Parameters.AddWithValue("@LOGIN", txtlogin.Text)


        Try
            abrir()
            importe = (com.ExecuteScalar())
            Cerrar()
            lblRol_referencia.Text = importe

        Catch ex As Exception
            lblRol_referencia.Text = 0
        End Try



    End Sub
    Sub GENERAR_COPIAS_DE_SEGURIDAD()
        mostrar_empresas_nuevas()

        Try
            lblfrecuencia.Text = datalistado_empresas_nuevas.SelectedCells.Item(14).Value
            TXTFECHA_DE_ULTIMA_COPIA.Value = datalistado_empresas_nuevas.SelectedCells.Item(13).Value
        Catch ex As Exception

        End Try

        LBL_RESULTADOS_DE_INTERVALOS_FECHAS_DE_COPIAS.Text = DateDiff(DateInterval.Day, TXTFECHA_DE_ULTIMA_COPIA.Value, TXTFECHA_SISTEMA.Value)
        If LBL_RESULTADOS_DE_INTERVALOS_FECHAS_DE_COPIAS.Text >= lblfrecuencia.Text Then
            MASCARA1.Show()
            GENERADOR_DE_COPIAS_AUTOMATICO.ShowDialog()
        End If
    End Sub
    Sub mostrar_empresas_nuevas()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("select * from Empresa", conexion)
            da.Fill(dt)
            datalistado_empresas_nuevas.DataSource = dt
            Cerrar()

        Catch ex As Exception ': MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Sub CONTROL_TOTAL_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If MOVIENDO = True Then
            Me.Location = New Point(MousePosition.X - MIX, MousePosition.Y - MIY) 'MUEVE EL FORM SEGUN EL CAMBIO DE POSICION DE LA ETIQUETA
        End If
    End Sub

    Private Sub CONTROL_TOTAL_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp

        MOVIENDO = False 'FINALIZA EL MOVIMIENTO
    End Sub




    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)
        If MOVIENDO = True Then
            Me.Location = New Point(MousePosition.X - MIX, MousePosition.Y - MIY) 'MUEVE EL FORM SEGUN EL CAMBIO DE POSICION DE LA ETIQUETA
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs)
        MOVIENDO = False 'FINALIZA EL MOVIMIENTO
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub





    Private Sub txtpaswwor_Click(sender As Object, e As EventArgs) Handles txtpaswwor.Click
        txtpaswwor.Text = ""
        txtpaswwor.Focus()

    End Sub


    Sub Iniciar_sesion_correcto()
        Dim MiInfo = From Hd As ManagementObject In MisDiscos.Get Select Hd
        DiscInfo = MiInfo(0)
        lblIDSERIAL.Text = DiscInfo.Properties("SerialNumber").Value
        Try
            cargarusuarios()
            contar()
            Try
                txtnombre.Text = datalistadoclientes.SelectedCells.Item(2).Value
                IDUSUARIO.Text = datalistadoclientes.SelectedCells.Item(1).Value
                txtlogin.Text = datalistadoclientes.SelectedCells.Item(3).Value

            Catch ex As Exception

            End Try



            If txtcontador.Text > 0 Then

                MOSTRAR_CAJA_POR_SERIAL()
                Try
                    txtidcaja.Text = datalistado_caja.SelectedCells.Item(1).Value
                    lblcaja.Text = datalistado_caja.SelectedCells.Item(2).Value
                Catch ex As Exception

                End Try
                ListarAPERTURAS_de_detalle_de_cierres_de_caja()
                contar_APERTURAS_de_detalle_de_cierres_de_caja()

                If lblcontador_cierres_De_caja_aperturadas.Text = 0 And lblRol_referencia.Text <> "Solo Ventas (no esta autorizado para manejar dinero)" Then
                    MessageBox.Show("No haz Aperturado Caja, Ingresa al sistema de Nuevo", "Caja sin Aperturar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End
                ElseIf lblcontador_cierres_De_caja_aperturadas.Text > 0 And lblRol_referencia.Text <> "Solo Ventas (no esta autorizado para manejar dinero)" Then

                    MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario()
                    ListarAPERTURAS_de_detalle_de_cierres_de_caja()
                    Try
                        lblusuario_queinicioCaja.Text = datalistado_detalle_cierre_de_caja.SelectedCells.Item(1).Value
                        lblnombredeCajero.Text = datalistado_detalle_cierre_de_caja.SelectedCells.Item(2).Value
                    Catch ex As Exception

                    End Try

                    If lblcontadorMovimientosValidados.Text = 0 Then

                        If lblusuario_queinicioCaja.Text <> "admin" And txtlogin.Text = "admin" Then
                            'MessageBox.Show("Continuaras Turno de *" & lblnombredeCajero.Text & " Todos los Registros seran con ese Usuario", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            lblpermisodeCaja.Text = "correcto"
                        ElseIf lblusuario_queinicioCaja.Text = "admin" And txtlogin.Text = "admin" Then

                            lblpermisodeCaja.Text = "correcto"
                        ElseIf lblusuario_queinicioCaja.Text = "admin" And txtlogin.Text <> "admin" Then
                            MessageBox.Show("Para poder continuar con el Turno de *" & lblnombredeCajero.Text & "* ,Inicia sesion con el Usuario " & lblusuario_queinicioCaja.Text & " -ó-el Usuario *admin*", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            lblpermisodeCaja.Text = "vacio"
                        ElseIf lblusuario_queinicioCaja.Text <> "admin" And txtlogin.Text <> "admin" Then
                            MessageBox.Show("Para poder continuar con el Turno de *" & lblnombredeCajero.Text & "* ,Inicia sesion con el Usuario " & lblusuario_queinicioCaja.Text & " -ó-el Usuario *admin*", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            lblpermisodeCaja.Text = "vacio"

                        ElseIf lblusuario_queinicioCaja.Text = txtlogin.Text Then
                            lblpermisodeCaja.Text = "correcto"
                        End If

                    Else

                        lblpermisodeCaja.Text = "correcto"
                    End If

                    If lblpermisodeCaja.Text = "correcto" Then
                        VENTAS_MENU_PRINCIPAL.lblidusuario.Text = IDUSUARIO.Text
                        VENTAS_MENU_PRINCIPAL.lbl_Login.Text = txtlogin.Text
                        VENTAS_MENU_PRINCIPAL.TimerCambio_de_usuario.Start()
                        MASCARA1.Hide()
                        Close()
                        VENTAS_MENU_PRINCIPAL.TimerDisposeMascara.Start()
                        VENTAS_MENU_PRINCIPAL.lbl_Login.Text = txtlogin.Text
                    End If
                ElseIf lblRol_referencia.Text = "Solo Ventas (no esta autorizado para manejar dinero)" Then
                    VENTAS_MENU_PRINCIPAL.lblidusuario.Text = IDUSUARIO.Text
                    VENTAS_MENU_PRINCIPAL.lbl_Login.Text = txtlogin.Text
                    VENTAS_MENU_PRINCIPAL.TimerCambio_de_usuario.Start()
                    MASCARA1.Hide()
                    Close()
                    VENTAS_MENU_PRINCIPAL.TimerDisposeMascara.Start()
                    VENTAS_MENU_PRINCIPAL.lbl_Login.Text = txtlogin.Text
                End If




            End If

        Catch ex As Exception


        End Try
    End Sub
    Sub Iniciar_sesion_incorrecto()
        Try
            cargarusuarios()
            contar()
            Try
                txtnombre.Text = datalistadoclientes.SelectedCells.Item(2).Value
                IDUSUARIO.Text = datalistadoclientes.SelectedCells.Item(1).Value

            Catch ex As Exception

            End Try
            If txtcontador.Text > 0 Then
                VENTAS_MENU_PRINCIPAL.lblidusuario.Text = IDUSUARIO.Text
                VENTAS_MENU_PRINCIPAL.lblIcono.Text = lblnumeroIcono.Text
                VENTAS_MENU_PRINCIPAL.TimerCambio_de_usuario.Start()
                mascara1.dispose()
                Close()


            Else
                MessageBox.Show("Usuario o contraseña Incorrectos", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If



        Catch ex As Exception


        End Try
    End Sub
    Private Sub txtpaswwor_TextChanged(sender As Object, e As EventArgs) Handles txtpaswwor.TextChanged

        Iniciar_sesion_correcto()

    End Sub

    'Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
    '    'lblHora.Text = DateTime.Now.ToString("hh:mm:ss")
    '    lblFecha.Text = DateTime.Now.ToLongDateString()
    'End Sub

    Sub cargarusuarios()
        Dim contraseña_encryptada As String
        contraseña_encryptada = Encriptar(Me.txtpaswwor.Text.Trim)
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("validar_usuario", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@password", contraseña_encryptada)
            da.SelectCommand.Parameters.AddWithValue("@login", txtlogin.Text)

            da.Fill(dt)
            datalistadoclientes.DataSource = dt
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub contar()
        Dim x As Integer
        x = datalistadoclientes.Rows.Count
        txtcontador.Text = CStr(x)
    End Sub
    Sub aperturar_caja_padre()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("APERTURA_DE_CAJA_PADRE", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_caja", txtidcaja.Text)
            cmd.Parameters.AddWithValue("@Fecha_de_cierre", lblfechaoka.Value)
            cmd.Parameters.AddWithValue("@Estado", "CAJA APERTURADA")
            cmd.Parameters.AddWithValue("@id_usuario", IDUSUARIO.Text)
            cmd.Parameters.AddWithValue("@fechainicio", lblfechaoka.Value)
            cmd.Parameters.AddWithValue("@ingresos", "0.00")
            cmd.Parameters.AddWithValue("@egresos", "0.00")
            cmd.Parameters.AddWithValue("@saldo", "0.00")

            cmd.Parameters.AddWithValue("@totalcaluclado", "0.00")
            cmd.Parameters.AddWithValue("@totalreal", "0.00")


            cmd.Parameters.AddWithValue("@diferencia", "0.00")
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception

        End Try

    End Sub

    Sub MOSTRAR_CAJA_POR_SERIAL()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_cajas_por_Serial_de_DiscoDuro", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Serial", lblIDSERIAL.Text)

            da.Fill(dt)
            datalistado_caja.DataSource = dt
            Cerrar()

        Catch ex As Exception ': MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub contar_ListarAPERTURAS_DE_CAJA_padre()
        Dim x As Integer
        x = datalistadoAPERTURAS_DE_CAJA_PADRE.Rows.Count
        lblcontador_cierres_De_caja_aperturadas.Text = CStr(x)
    End Sub

    Sub ListarAPERTURAS_DE_CAJA_padre()
        MOSTRAR_CAJA_POR_SERIAL()
        Try
            txtidcaja.Text = datalistado_caja.SelectedCells.Item(1).Value
            lblcaja.Text = datalistado_caja.SelectedCells.Item(2).Value
        Catch ex As Exception

        End Try
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_APERTURAS_DE_CAJA_PADRE", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Id_usuario", IDUSUARIO.Text)
            da.SelectCommand.Parameters.AddWithValue("@Id_CAJA", txtidcaja.Text)
            da.Fill(dt)
            datalistadoAPERTURAS_DE_CAJA_PADRE.DataSource = dt
            Cerrar()

        Catch ex As Exception

        End Try
        Try
            lblidCierredecajaPadre.Text = datalistadoAPERTURAS_DE_CAJA_PADRE.SelectedCells.Item(1).Value
        Catch ex As Exception

        End Try
    End Sub
    Sub MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@serial", lblIDSERIAL.Text)
            da.SelectCommand.Parameters.AddWithValue("@idusuario", IDUSUARIO.Text)
            da.Fill(dt)
            datalistado_movimientos_validar.DataSource = dt
            Cerrar()
            Dim x As Integer
            x = datalistado_movimientos_validar.Rows.Count
            lblcontadorMovimientosValidados.Text = CStr(x)

        Catch ex As Exception ': MessageBox.Show(ex.Message)
        End Try


    End Sub
    Sub MOSTRAR_licencia_temporal()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("SELECT*FROM Marcan", conexion)

            da.Fill(dt)
            datalistado_licencia_temporal.DataSource = dt
            Cerrar()


        Catch ex As Exception ': MessageBox.Show(ex.Message)
        End Try


    End Sub
    Sub contar_APERTURAS_de_detalle_de_cierres_de_caja()
        Dim x As Integer
        x = datalistado_detalle_cierre_de_caja.Rows.Count
        lblcontador_cierres_De_caja_aperturadas.Text = CStr(x)
    End Sub
    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Iniciar_sesion_incorrecto()


    End Sub
    Sub ListarAPERTURAS_de_detalle_de_cierres_de_caja()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@serial", lblIDSERIAL.Text)

            da.Fill(dt)
            datalistado_detalle_cierre_de_caja.DataSource = dt
            Cerrar()

        Catch ex As Exception

        End Try

    End Sub
    Sub aperturar_detalle_de_cierre_caja()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_DETALLE_cierre_de_caja", conexion)
            cmd.CommandType = 4

            cmd.Parameters.AddWithValue("@fechaini", lblfechaoka.Value)
            cmd.Parameters.AddWithValue("@fechafin", lblfechaoka.Value)
            cmd.Parameters.AddWithValue("@fechacierre", lblfechaoka.Value)
            cmd.Parameters.AddWithValue("@ingresos", "0.00")
            cmd.Parameters.AddWithValue("@egresos", "0.00")
            cmd.Parameters.AddWithValue("@saldo", "0.00")
            cmd.Parameters.AddWithValue("@idusuario", IDUSUARIO.Text)
            cmd.Parameters.AddWithValue("@totalcaluclado", "0.00")
            cmd.Parameters.AddWithValue("@totalreal", "0.00")

            cmd.Parameters.AddWithValue("@estado", "CAJA APERTURADA")
            cmd.Parameters.AddWithValue("@diferencia", "0.00")
            cmd.Parameters.AddWithValue("@idcierrepadre", txtidcaja.Text)
            cmd.ExecuteNonQuery()
            lblpermisodeCaja.Text = "correcto"
            Cerrar()


        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cargarusuarios()
        'txtnombre.Text = datalistadoclientes.SelectedCells.Item(3).Value
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Dim lbldynamic As New Label
        lbldynamic.Text = "Texto Dinamiasdasdasdasdasdco"

        Me.Controls.Add(lbldynamic)


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

        usuariosok.TopMost = True
        usuariosok.ShowDialog()
        usuariosok.TopMost = True
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        Try
            System.Diagnostics.Process.Start("https://www.facebook.com/codigo369magbri/")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Try
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC7UirgYx9bGAnK2rYWW7Wsw")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Try
            System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=51983116935&text=SOLICITO+Restaurar+mi+Contraseña+del+Sistema+ADA369")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub DomainUpDown1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try

            'obtener la descripcion de la propiedad

            lblIDSERIAL.Text = DiscInfo.Properties("SerialNumber").Value

        Catch ex As Exception

            'en caso de error…

            lblIDSERIAL.Text = "¿?"

        End Try
    End Sub

    Private Sub tver_Click(sender As Object, e As EventArgs) Handles tver.Click
        txtpaswwor.PasswordChar = ""
        tocultar.Visible = True
        tver.Visible = False
    End Sub

    Private Sub tocultar_Click(sender As Object, e As EventArgs) Handles tocultar.Click
        txtpaswwor.PasswordChar = "*"
        tocultar.Visible = False
        tver.Visible = True
    End Sub


    Private Sub txtlogin_SelectedIndexChanged(sender As Object, e As EventArgs)

        txtlogin.Text = ""
        txtlogin.Focus()

        cargarusuarios()
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub



    Private Sub Timer3_Tick(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Try
            System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=51983116935&text=SOLICITO+Restaurar+mi+Contraseña+del+Sistema+ADA369")
        Catch ex As Exception

        End Try
    End Sub
    Sub EDITAR_ESTADO_LICENCIA_LOCAL()
        Dim estado As String
        estado = Encriptar("ÑAGOTADOÑ")
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("EDITAR_marcan", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@e", estado)

            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub cmdSendMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim htmlBody As String = "<html><body><h1>Picture</h1><br>" +
        "<img src=""cid:Pic1""></body></html>"

        Dim avHtml As AlternateView = AlternateView.CreateAlternateViewFromString _
        (htmlBody, Nothing, System.Net.Mime.MediaTypeNames.Text.Html)

        Dim pic1 As LinkedResource = New LinkedResource("E:\Resources\adjuntar.png", System.Net.Mime.MediaTypeNames.Image.Jpeg)
        pic1.ContentId = "Pic1"
        avHtml.LinkedResources.Add(pic1)

        Dim textBody As String = "You must use an e-mail client that supports HTML messages"
        Dim avText As AlternateView = AlternateView.CreateAlternateViewFromString _
        (textBody, Nothing, System.Net.Mime.MediaTypeNames.Text.Plain)

        Dim m As MailMessage = New MailMessage
        m.AlternateViews.Add(avHtml)
        m.AlternateViews.Add(avText)

        m.From = New MailAddress("cursosmajestuosos@gmail.com")
        m.To.Add("cursosmajestuosos@gmail.com")
        m.Subject = "prueba email con imagen"
        Dim client As SmtpClient = New SmtpClient("smtp.gmail.com")
        client.Credentials = New Net.NetworkCredential("colegio.de.ingenieros.peru.pe@gmail.com", "MAGbri2018")
        client.Host = "smtp.gmail.com"
        client.Port = 587
        client.EnableSsl = True
        client.Send(m)

        'probamos el envio 
        MsgBox("enviado")

        'Revisa tu coreo y veras la imagen......... 

    End Sub



    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtpaswwor.Text = txtpaswwor.Text & "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtpaswwor.Text = txtpaswwor.Text & "1"

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtpaswwor.Text = txtpaswwor.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtpaswwor.Text = txtpaswwor.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtpaswwor.Text = txtpaswwor.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtpaswwor.Text = txtpaswwor.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtpaswwor.Text = txtpaswwor.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtpaswwor.Text = txtpaswwor.Text & "7"


    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtpaswwor.Text = txtpaswwor.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtpaswwor.Text = txtpaswwor.Text & "9"
    End Sub

    Private Sub btnborrarderecha_Click(sender As Object, e As EventArgs) Handles btnborrarderecha.Click
        Try
            Dim largo As Integer
            If txtpaswwor.Text <> "" Then
                largo = txtpaswwor.Text.Length
                txtpaswwor.Text = Mid(txtpaswwor.Text, 1, largo - 1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnborrartodo_Click(sender As Object, e As EventArgs) Handles btnborrartodo.Click
        txtpaswwor.Clear()
    End Sub

    Private Sub lblusuario_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        MASCARA1.Hide()
        Close()
        VENTAS_MENU_PRINCIPAL.TimerDisposeMascara.Start()

    End Sub

    Private Sub Panel12_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub
End Class