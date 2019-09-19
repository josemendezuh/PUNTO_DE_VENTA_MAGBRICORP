Imports System.Net
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Net.Mime.MediaTypeNames
Imports System.Globalization
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Data.OleDb

Imports System.IO
Imports System.Management
Imports System.Xml
Imports System.AppDomainManagerInitializationOptions
Imports System.MarshalByRefObject
Imports System.Configuration
Public Class LOGIN_c
    Private aes As New AES()

    Dim MOVIENDO As Boolean = False

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
    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel5.Visible = False
        PictureBox2.Visible = False



        Panel5.Visible = True

        Panel5.Location = New Point((Width - Panel5.Width) / 2, (Height - Panel5.Height) / 2)
        PictureBox2.Location = New Point((Width - PictureBox2.Width) / 2, (Height - PictureBox2.Height) / 2)

        timer1.Start()


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
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtpaswwor_TextChanged(sender As Object, e As EventArgs) Handles txtpaswwor.TextChanged


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
            da.SelectCommand.Parameters.AddWithValue("@login", txtlogin.Text)
            da.SelectCommand.Parameters.AddWithValue("@password", contraseña_encryptada)
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

  
    Private Sub txtlogin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtlogin.SelectedIndexChanged

        txtlogin.Text = ""
        txtlogin.Focus()
        lblusuario.Visible = True
        cargarusuarios()
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 10
            PictureBox2.Visible = True
        Else
            ProgressBar1.Value = 0
            Timer2.Stop()
            If lblApertura_De_caja.Text = "Nuevo*****" Then

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
    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        timer1.Stop()    
        mostrar_usuario()
        mostrar_usuarios_registrados()
        contar_USUARIOS()
        If txtcontador_USUARIOS.Text = 0 Then
            Me.Hide()
            CONEXION_MANUAL.ShowDialog()
            Me.Hide()
        Else
            Dim MiInfo = From Hd As ManagementObject In MisDiscos.Get Select Hd
            DiscInfo = MiInfo(0)
            lblIDSERIAL.Text = DiscInfo.Properties("SerialNumber").Value
            MOSTRAR_CAJA_POR_SERIAL()
            Try
                txtidcaja.Text = datalistado_caja.SelectedCells.Item(1).Value
                lblcaja.Text = datalistado_caja.SelectedCells.Item(2).Value
            Catch ex As Exception
                txtidcaja.Text = 0
            End Try
            If txtidcaja.Text = 0 Then
                REGISTRO_DE_CAJA.ShowDialog()

            End If
        End If
    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub




    Private Sub LOGIN_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Alt + Keys.F4 Then
            End
        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class