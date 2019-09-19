
Imports System.Data.SqlClient

Imports System.Management
Imports System.Xml
Imports System.Net.Mail
Imports System.Net
Public Class LOGIN
    Private aes As New AES()
    Private correos As New MailMessage
    Private envios As New SmtpClient
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
    Sub mostrar_usuario()
        Dim DA As SqlDataAdapter
        Dim dtu As New DataTable
        Try
            abrir()
            DA = New SqlDataAdapter("SELECT*FROM USUARIO2 ", conexion)
            DA.Fill(dtu)
            txtlogin.DisplayMember = "Login"
            txtlogin.ValueMember = "Login"
            txtlogin.DataSource = dtu
            Cerrar()
        Catch ex As Exception

            'CONEXION_MANUAL.ShowDialog()

        End Try

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
    Private Sub LOGIN_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Sub mostrar_correos()
        Dim DA As SqlDataAdapter
        Dim dtlinea As New DataTable
        Try
            abrir()
            DA = New SqlDataAdapter("select Correo from USUARIO2", conexion)
            DA.Fill(dtlinea)
            txtcorreo.DisplayMember = "Correo"
            txtcorreo.ValueMember = "Correo"
            txtcorreo.DataSource = dtlinea
            Cerrar()


        Catch ex As Exception
        End Try

    End Sub
    Sub dibujarUSUARIOS()
        Try
            abrir()
            Dim query As String = "select * from USUARIO2 WHERE Estado ='ACTIVO'"
            Dim cmd As New SqlCommand(query, conexion)
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            Dim NBotones As Integer = 3
            While rdr.Read()
                'r = New Random()
                Dim b As New Label()
                Dim p1 As New Panel
                'Dim P2 As New Panel
                Dim I1 As New PictureBox
                'Dim P3 As New Panel
                'Dim L As New Label
                b.Text = rdr("Login").ToString()
                b.Name = rdr("idUsuario").ToString()


                b.Size = New System.Drawing.Size(175, 25)
                b.Font = New System.Drawing.Font(16, 19)

                b.FlatStyle = FlatStyle.Flat
                b.BackColor = Color.FromArgb(240, 242, 240)
                b.ForeColor = Color.FromArgb(80, 86, 81)
                b.Dock = DockStyle.Bottom
                b.TextAlign = ContentAlignment.MiddleCenter

                b.Cursor = Cursors.Hand


                p1.Size = New System.Drawing.Size(155, 167)
                p1.BorderStyle = BorderStyle.None
                p1.Dock = DockStyle.Bottom
                p1.BackColor = Color.FromArgb(240, 242, 240)

                'P2.Size = New System.Drawing.Size(246, 22)
                'P2.Dock = DockStyle.Top
                'P2.BackColor = Color.FromArgb(r.[Next](0, 255), r.[Next](0, 255), r.[Next](0, 255))

                I1.Size = New System.Drawing.Size(175, 132)
                I1.Dock = DockStyle.Top
                I1.BackgroundImage = Nothing
                Dim bi() As Byte = rdr("Icono")
                Dim ms As New IO.MemoryStream(bi)
                I1.Image = Image.FromStream(ms)
                I1.SizeMode = PictureBoxSizeMode.Zoom
                I1.Tag = rdr("Login").ToString()
                I1.Cursor = Cursors.Hand

                p1.Controls.Add(b)
                p1.Controls.Add(I1)
                'p1.Controls.Add(P2)
                'p1.Controls.Add(P3)
                'P2.SendToBack()
                b.BringToFront()
                'I1.SendToBack()
                'L.BringToFront()
                'P3.SendToBack()
                Panel_USUARIOS.Controls.Add(p1)
                AddHandler b.Click, AddressOf miEventoLabel

                AddHandler I1.Click, AddressOf miEventoImagen

            End While
            Cerrar()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub miEventoLabel(ByVal sender As System.Object, ByVal e As EventArgs)
        Try
            txtlogin.Text = DirectCast(sender, Label).Text

            Panel16.Visible = False
            Panel5.Visible = True
            MOSTRAR_PERMISOS()
        Catch ex As Exception

        End Try


    End Sub
    Private Sub miEventoImagen(ByVal sender As System.Object, ByVal e As EventArgs)
        Try
            txtlogin.Text = DirectCast(sender, PictureBox).Tag

            Panel16.Visible = False
            Panel5.Visible = True
            MOSTRAR_PERMISOS()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel5.Visible = False
        PictureBox2.Visible = False

        'Panel5.Visible = True

        Panel5.Location = New Point((Width - Panel5.Width) / 2, (Height - Panel5.Height) / 2)
        PictureBox2.Location = New Point((Width - PictureBox2.Width) / 2, (Height - PictureBox2.Height) / 2)
        Panel16.Location = New Point((Width - Panel16.Width) / 2, (Height - Panel16.Height) / 2)
        timer1.Start()
        GENERAR_COPIAS_DE_SEGURIDAD()
        txtpaswwor.Focus()
        dibujarUSUARIOS()

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

    Private Sub txtpaswwor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpaswwor.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then



                Try
                    cargarusuarios()
                    contar()
                    Try
                        txtnombre.Text = datalistadoclientes.SelectedCells.Item(2).Value
                        IDUSUARIO.Text = datalistadoclientes.SelectedCells.Item(1).Value

                    Catch ex As Exception

                    End Try
                    If txtcontador.Text > 0 Then
                        'ListarAPERTURAS_DE_CAJA_padre()
                        'contar_ListarAPERTURAS_DE_CAJA_padre()
                        MOSTRAR_CAJA_POR_SERIAL()
                        Try
                            txtidcaja.Text = datalistado_caja.SelectedCells.Item(1).Value
                            lblcaja.Text = datalistado_caja.SelectedCells.Item(2).Value
                        Catch ex As Exception

                        End Try
                        ListarAPERTURAS_de_detalle_de_cierres_de_caja()
                        contar_APERTURAS_de_detalle_de_cierres_de_caja()
                        If lblcontador_cierres_De_caja_aperturadas.Text = 0 Then

                            'aperturar_caja_padre()
                            'ListarAPERTURAS_DE_CAJA_padre()
                            aperturar_detalle_de_cierre_caja()
                            'ListarAPERTURAS_de_detalle_de_cierres_de_caja()
                            MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario()
                            ListarAPERTURAS_de_detalle_de_cierres_de_caja()
                            Try
                                lblusuario_queinicioCaja.Text = datalistado_detalle_cierre_de_caja.SelectedCells.Item(1).Value
                                lblnombredeCajero.Text = datalistado_detalle_cierre_de_caja.SelectedCells.Item(2).Value
                            Catch ex As Exception

                            End Try
                            lblApertura_De_caja.Text = "Nuevo*****"
                            Timer2.Start()

                        Else

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
                                    MessageBox.Show("Para poder continuar con el turno de *" & lblnombredeCajero.Text & "* ,inicia sesión con el usuario " & lblusuario_queinicioCaja.Text & " -ó-el usuario *
*", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    lblpermisodeCaja.Text = "vacio"
                                ElseIf lblusuario_queinicioCaja.Text = txtlogin.Text Then
                                    lblpermisodeCaja.Text = "correcto"
                                End If

                            Else

                                lblpermisodeCaja.Text = "correcto"
                            End If

                            If lblpermisodeCaja.Text = "correcto" Then
                                lblApertura_De_caja.Text = "Aperturado"
                                Timer2.Start()
                            End If

                        End If







                    Else
                        MessageBox.Show("Usuario o contraseña incorrectos", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    End If



                Catch ex As Exception
                    'MsgBox(ex.Message)

                End Try
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
        Catch ex As Exception ': MessageBox.Show(ex.Message)
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
        inicio_de_sesion_incorrecto()


    End Sub
    Sub inicio_de_sesion_incorrecto()
        Try
            cargarusuarios()
            contar()
            Try
                txtnombre.Text = datalistadoclientes.SelectedCells.Item(2).Value
                IDUSUARIO.Text = datalistadoclientes.SelectedCells.Item(1).Value
                lblLogin.Text = datalistadoclientes.SelectedCells.Item(3).Value
            Catch ex As Exception

            End Try
            If txtcontador.Text > 0 Then
                'ListarAPERTURAS_DE_CAJA_padre()
                'contar_ListarAPERTURAS_DE_CAJA_padre()
                MOSTRAR_CAJA_POR_SERIAL()
                Try
                    txtidcaja.Text = datalistado_caja.SelectedCells.Item(1).Value
                    lblcaja.Text = datalistado_caja.SelectedCells.Item(2).Value
                Catch ex As Exception

                End Try
                ListarAPERTURAS_de_detalle_de_cierres_de_caja()
                contar_APERTURAS_de_detalle_de_cierres_de_caja()
                If lblcontador_cierres_De_caja_aperturadas.Text = 0 Then

                    'aperturar_caja_padre()
                    'ListarAPERTURAS_DE_CAJA_padre()
                    aperturar_detalle_de_cierre_caja()
                    'ListarAPERTURAS_de_detalle_de_cierres_de_caja()
                    MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario()
                    ListarAPERTURAS_de_detalle_de_cierres_de_caja()
                    Try
                        lblusuario_queinicioCaja.Text = datalistado_detalle_cierre_de_caja.SelectedCells.Item(1).Value
                        lblnombredeCajero.Text = datalistado_detalle_cierre_de_caja.SelectedCells.Item(2).Value
                    Catch ex As Exception

                    End Try
                    lblApertura_De_caja.Text = "Nuevo*****"
                    Timer2.Start()

                Else

                    MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario()
                    ListarAPERTURAS_de_detalle_de_cierres_de_caja()
                    Try
                        lblusuario_queinicioCaja.Text = datalistado_detalle_cierre_de_caja.SelectedCells.Item(1).Value
                        lblnombredeCajero.Text = datalistado_detalle_cierre_de_caja.SelectedCells.Item(2).Value
                    Catch ex As Exception

                    End Try

                    If lblcontadorMovimientosValidados.Text = 0 Then

                        If lblusuario_queinicioCaja.Text <> "admin" And txtlogin.Text = "admin" Then
                            MessageBox.Show("Continuaras Turno de *" & lblnombredeCajero.Text & " Todos los Registros seran con ese Usuario", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            lblpermisodeCaja.Text = "correcto"
                        ElseIf lblusuario_queinicioCaja.Text = "admin" And txtlogin.Text = "admin" Then

                            lblpermisodeCaja.Text = "correcto"
                        ElseIf lblusuario_queinicioCaja.Text = "admin" And txtlogin.Text <> "admin" Then
                            MessageBox.Show("Para poder continuar con el Turno de *" & lblnombredeCajero.Text & "* ,Inicia sesion con el Usuario " & lblusuario_queinicioCaja.Text & " -ó-el Usuario *admin*", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            lblpermisodeCaja.Text = "vacio"
                        ElseIf lblusuario_queinicioCaja.Text = txtlogin.Text Then
                            lblpermisodeCaja.Text = "correcto"
                        End If

                    Else

                        lblpermisodeCaja.Text = "correcto"
                    End If

                    If lblpermisodeCaja.Text = "correcto" Then
                        lblApertura_De_caja.Text = "Aperturado"
                        Timer2.Start()
                    End If

                End If

            Else
                MessageBox.Show("Usuario o contraseña Incorrectos", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If



        Catch ex As Exception
            'MsgBox(ex.Message)

        End Try
    End Sub
    Sub Iniciar_sesion_correcto()
        Try
            cargarusuarios()
            contar()
            Try
                txtnombre.Text = datalistadoclientes.SelectedCells.Item(2).Value
                IDUSUARIO.Text = datalistadoclientes.SelectedCells.Item(1).Value
                lblLogin.Text = datalistadoclientes.SelectedCells.Item(3).Value
            Catch ex As Exception

            End Try

            If txtcontador.Text > 0 Then
                'ListarAPERTURAS_DE_CAJA_padre()
                'contar_ListarAPERTURAS_DE_CAJA_padre()
                MOSTRAR_CAJA_POR_SERIAL()
                Try
                    txtidcaja.Text = datalistado_caja.SelectedCells.Item(1).Value
                    lblcaja.Text = datalistado_caja.SelectedCells.Item(2).Value
                Catch ex As Exception

                End Try
                ListarAPERTURAS_de_detalle_de_cierres_de_caja()
                contar_APERTURAS_de_detalle_de_cierres_de_caja()

                If lblcontador_cierres_De_caja_aperturadas.Text = 0 And LBLROL.Text <> "Solo Ventas (no esta autorizado para manejar dinero)" Then

                    'aperturar_caja_padre()
                    'ListarAPERTURAS_DE_CAJA_padre()
                    aperturar_detalle_de_cierre_caja()
                    'ListarAPERTURAS_de_detalle_de_cierres_de_caja()
                    MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario()
                    ListarAPERTURAS_de_detalle_de_cierres_de_caja()
                    Try
                        lblusuario_queinicioCaja.Text = datalistado_detalle_cierre_de_caja.SelectedCells.Item(1).Value
                        lblnombredeCajero.Text = datalistado_detalle_cierre_de_caja.SelectedCells.Item(2).Value
                    Catch ex As Exception

                    End Try
                    lblApertura_De_caja.Text = "Nuevo*****"
                    Timer2.Start()

                Else
                    If LBLROL.Text <> "Solo Ventas (no esta autorizado para manejar dinero)" Then
                        MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario()
                        ListarAPERTURAS_de_detalle_de_cierres_de_caja()
                        Try
                            lblusuario_queinicioCaja.Text = datalistado_detalle_cierre_de_caja.SelectedCells.Item(1).Value
                            lblnombredeCajero.Text = datalistado_detalle_cierre_de_caja.SelectedCells.Item(2).Value
                        Catch ex As Exception

                        End Try

                        If lblcontadorMovimientosValidados.Text = 0 Then

                            If lblusuario_queinicioCaja.Text <> "admin" And txtlogin.Text = "admin" Then
                                MessageBox.Show("Continuaras Turno de *" & lblnombredeCajero.Text & " Todos los Registros seran con ese Usuario", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                            lblApertura_De_caja.Text = "Aperturado"
                            Timer2.Start()
                        End If
                    Else
                        Timer2.Start()
                    End If


                End If

            Else
                'MessageBox.Show("Usuario o contraseña Incorrectos", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If



        Catch ex As Exception
            'MsgBox(ex.Message)

        End Try
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
    Sub MOSTRAR_PERMISOS()


        Dim importe As String
        Dim com As New SqlCommand("mostrar_permisos_por_usuario_ROL_UNICO", conexion)
        com.CommandType = 4
        com.Parameters.AddWithValue("@LOGIN", txtlogin.Text)


        Try
            abrir()
            importe = (com.ExecuteScalar())
            Cerrar()
            LBLROL.Text = importe

        Catch ex As Exception
            LBLROL.Text = 0
        End Try



    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


        If ProgressBar1.Value < 100 Then
            BackColor = Color.FromArgb(26, 26, 26)
            ProgressBar1.Value = ProgressBar1.Value + 10
            PictureBox2.Visible = True

        Else
            ProgressBar1.Value = 0
            Timer2.Stop()
            If lblApertura_De_caja.Text = "Nuevo*****" And LBLROL.Text <> "Solo Ventas (no esta autorizado para manejar dinero)" Then

                Me.Hide()
                APERTURA_DE_CAJA.ShowDialog()
                Me.Hide()

            Else

                Me.Hide()
                VENTAS_MENU_PRINCIPAL.ShowDialog()
                Me.Hide()

            End If

        End If
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
        estado = Encriptar("VENCIDO")
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
    Sub Ingresar_por_licencia_Temporal()
        MOSTRAR_CAJA_POR_SERIAL()
        Try
            txtidcaja.Text = datalistado_caja.SelectedCells.Item(1).Value
            lblcaja.Text = datalistado_caja.SelectedCells.Item(2).Value
        Catch ex As Exception
        End Try
        lblestadoLicencia.Text = "Licencia de Prueba Activada hasta el: " & txtfecha_final_licencia_temporal.Text
    End Sub
    Sub Ingresar_por_licencia_de_paga()
        MOSTRAR_CAJA_POR_SERIAL()
        Try
            txtidcaja.Text = datalistado_caja.SelectedCells.Item(1).Value
            lblcaja.Text = datalistado_caja.SelectedCells.Item(2).Value
        Catch ex As Exception
        End Try
        lblestadoLicencia.Text = "Licencia PROFESIONAL Activada hasta el: " & txtfecha_final_licencia_temporal.Text
    End Sub
    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        timer1.Stop()
        mostrar_usuario()
        mostrar_usuarios_registrados()
        contar_USUARIOS()
        If txtcontador_USUARIOS.Text = 0 Then
            Me.Hide()
            BIENVENIDO.ShowDialog()
            Me.Hide()
        Else
            MOSTRAR_licencia_temporal()
            ReadfromXML_SERIAL_PC()
            Dim MiInfo = From Hd As ManagementObject In MisDiscos.Get Select Hd
            DiscInfo = MiInfo(0)
            lblIDSERIAL.Text = DiscInfo.Properties("SerialNumber").Value
            Try
                txtfecha_final_licencia_temporal.Value = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(3).Value.Trim)
                lblSerialPcLocal.Text = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(2).Value.Trim)
                LBLESTADOLicenciaLocal.Text = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(4).Value.Trim)
                txtfecha_inicio_licencia.Value = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(5).Value.Trim)

            Catch ex As Exception
            End Try
            If txtfecha_final_licencia_temporal.Value >= TXTFECHA_SISTEMA.Value And lblSerialPcLocal.Text = lblIDSERIAL.Text Then
                If txtfecha_inicio_licencia.Value <= TXTFECHA_SISTEMA.Value Then
                    If LBLESTADOLicenciaLocal.Text = "?ACTIVO?" Then
                        Ingresar_por_licencia_Temporal()

                    ElseIf LBLESTADOLicenciaLocal.Text = "?ACTIVADO PRO?" Then
                        Ingresar_por_licencia_de_paga()

                    End If


                Else
                    EDITAR_ESTADO_LICENCIA_LOCAL()

                    Me.Hide()
                    Membresias.ShowDialog()
                End If
            End If


        End If

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

    Private Sub LOGIN_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Alt + Keys.F4 Then
            End
        End If
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



    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        mostrar_correos()
        PanelRestaurarCuenta.Location = New Point((Width - PanelRestaurarCuenta.Width) / 2, (Height - PanelRestaurarCuenta.Height) / 2)

        PanelRestaurarCuenta.Visible = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PanelRestaurarCuenta.Visible = False
        Panel16.Visible = False
        Panel5.Visible = True
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
            MessageBox.Show("Contraseña Enviada, revisa tu correo Electronico", "Restauracion de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PanelRestaurarCuenta.Visible = False
            Panel16.Visible = False
            Panel5.Visible = True
        Catch ex As Exception
            lblEstado_de_envio.Text = "Correo no registrado"
        End Try

    End Sub
    Sub mostrar_usuarios_por_correo()

        Dim importe As String
        Dim com As New SqlCommand("buscar_USUARIO_por_correo", conexion)
        com.CommandType = 4
        com.Parameters.AddWithValue("@correo", txtcorreo.Text)

        Try
            abrir()
            importe = (com.ExecuteScalar())
            Cerrar()
            txtpassenvi.Text = Desencriptar(importe)

        Catch ex As Exception
            ': MessageBox.Show(ex.Message)
            txtpassenvi.Text = "Contraseña no encontrada"
        End Try


    End Sub
    Private Sub RemplazarTexto(ByVal RichTextBox As Object, Optional ByVal PosIni As Integer = 0)

        Dim Pos As Integer
        Dim TipoBusqueda As Long

        Dim PalabraClave(0) As String
        PalabraClave(0) = "@Password"

        Dim Reemplaza(0) As String
        Reemplaza(0) = txtpassenvi.Text.ToString()

        For i As Integer = 0 To PalabraClave.Count - 1
            If Len(PalabraClave(i)) Then
                'Verificar si Mayusculas y Minusculas esta desactivada

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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mostrar_correo_base_correo()
        mostrar_usuarios_por_correo()
        RemplazarTexto(RichTextBox:=RichTextBox1.Rtf, PosIni:=0)
        If lblestadobase.Text <> "SIN CONEXION" Then
            enviarCorreo(emisor:=lblcorreobase.Text, password:=lblcontraseñabase.Text, mensaje:=RichTextBox1.Text, asunto:="Solicitud de Contraseña", destinatario:=txtcorreo.Text, ruta:="")
        Else
            MessageBox.Show("No se ha sincronizado Gmail con: Mi Punto de Venta", "Sin conexion a Gmail", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel16.Visible = True
        Panel5.Visible = False
        txtpaswwor.Text = ""
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        mostrar_correos()
        PanelRestaurarCuenta.Location = New Point((Width - PanelRestaurarCuenta.Width) / 2, (Height - PanelRestaurarCuenta.Height) / 2)
        PanelRestaurarCuenta.Visible = True
        Panel16.Visible = False
        Panel5.Visible = False
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtcorreo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcorreo.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class