Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Management


Imports System.Xml

Imports System.Text.RegularExpressions

Public Class VENTAS_MENU_PRINCIPAL
    Private txt() As PictureBox
    Private lbl() As Label
    Private lbl2() As Button
    Private b() As Button
    Private a() As Label
    Dim panel As New PanelExtended
    Dim i As Integer
    Dim j As Integer = 0
    Dim DTturnoinicial As New DataTable
    Dim DTturnofinal As New DataTable

    Dim dtcliente As New DataTable
    Dim dtidventa As New DataTable
    Dim dtserie As New DataTable

    Dim DT_USUARIO As New DataTable
    Dim columna As Integer
    Private MisDiscos As New ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard")
    Private DiscInfo As New ManagementObject
    Private ra As Random


    Private Sub VENTAS_MENU_PRINCIPAL_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If DATALISTADO_PRODUCTOS_OKA.Visible = False Then



            If e.KeyCode = Keys.Down Then
                columna = datalistadomateriales.CurrentRow.Index
                lblcolumna.Text = columna
            End If
            If e.KeyCode = Keys.Up Then

                columna = datalistadomateriales.CurrentRow.Index
                lblcolumna.Text = columna
            End If
        End If
    End Sub


    Private Sub miEventoCOBROS(ByVal sender As System.Object, ByVal e As EventArgs)

        Try

            cobro_a_clientes.txtclientesolicitante.Text = DirectCast(sender, Label).Name
            cobro_a_clientes.TimerMOSTRAR_DESDE_REFERENCIA.Start()

            cobro_a_clientes.ShowDialog()
            cobro_a_clientes.txtclientesolicitante.Text = DirectCast(sender, Label).Name
            ocultar_objetos_emergentes()
            cobro_a_clientes.TimerMOSTRAR_DESDE_REFERENCIA.Start()

        Catch ex As Exception

        End Try

    End Sub
    Private Sub miEventoVENTASESPERA(ByVal sender As System.Object, ByVal e As EventArgs)
        Try
            Ventas_en_espera.txtbusca.Text = DirectCast(sender, Label).Name
            ocultar_objetos_emergentes()
            Ventas_en_espera.ShowDialog()
            Ventas_en_espera.txtbusca.Text = DirectCast(sender, Label).Name

        Catch ex As Exception

        End Try

    End Sub
    Private Sub miEventoPAGOS(ByVal sender As System.Object, ByVal e As EventArgs)
        Try

            PAGOS_PROVEEDOSOKA.txtclientesolicitante.Text = DirectCast(sender, Label).Name
            PAGOS_PROVEEDOSOKA.TimerMOSTRAR_DESDE_REFERENCIA.Start()
            ocultar_objetos_emergentes()

            PAGOS_PROVEEDOSOKA.ShowDialog()
            PAGOS_PROVEEDOSOKA.txtclientesolicitante.Text = DirectCast(sender, Label).Name
            PAGOS_PROVEEDOSOKA.TimerMOSTRAR_DESDE_REFERENCIA.Start()

        Catch ex As Exception

        End Try

    End Sub
    Private Sub miEventoProductos_Vencidos(ByVal sender As System.Object, ByVal e As EventArgs)
        Try

            INVENTARIO.TimerVencimientos.Start()
            ocultar_objetos_emergentes()
            INVENTARIO.txtBuscarVencimientos.Text = DirectCast(sender, Label).Name

            INVENTARIO.ShowDialog()
            INVENTARIO.TimerVencimientos.Start()
            INVENTARIO.txtBuscarVencimientos.Text = DirectCast(sender, Label).Name

        Catch ex As Exception

        End Try

    End Sub
    Sub Listarproductosagregados()
        Dim dtMA As New DataTable
        Dim daMA As SqlDataAdapter
        Try
            abrir()
            daMA = New SqlDataAdapter("mostrar_productos_agregados_a_venta", conexion)
            daMA.SelectCommand.CommandType = 4
            daMA.SelectCommand.Parameters.AddWithValue("@idventa", txtidventa.Text)
            daMA.Fill(dtMA)
            datalistadomateriales.DataSource = dtMA
            datalistadomateriales.Columns(0).Width = 50
            datalistadomateriales.Columns(1).Width = 50
            datalistadomateriales.Columns(2).Width = 50

            datalistadomateriales.Columns(3).Visible = False
            datalistadomateriales.Columns(4).Width = 250
            datalistadomateriales.Columns(5).Width = 100
            datalistadomateriales.Columns(6).Width = 100
            datalistadomateriales.Columns(7).Width = 100
            datalistadomateriales.Columns(8).Visible = False
            datalistadomateriales.Columns(9).Visible = False
            datalistadomateriales.Columns(10).Visible = False
            datalistadomateriales.Columns(11).Width = datalistadomateriales.Width - 908
            datalistadomateriales.Columns(12).Visible = False
            datalistadomateriales.Columns(13).Visible = False
            datalistadomateriales.Columns(14).Visible = False
            datalistadomateriales.Columns(15).Visible = False
            datalistadomateriales.Columns(16).Visible = False
            datalistadomateriales.Columns(17).Visible = False
            datalistadomateriales.Columns(18).Visible = False
            datalistadomateriales.Columns(19).Visible = False
            Cerrar()
            txtbuscar.Text = ""
            'txtbuscar.Focus()
            DATALISTADO_PRODUCTOS_OKA.Visible = False
        Catch ex As Exception
            '
        End Try

        sumar()

        Me.datalistadomateriales.EnableHeadersVisualStyles = False
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        If lbltema.Text = "Elegante Black" Then
            styCabeceras.BackColor = Color.Black
            styCabeceras.ForeColor = Color.White
        ElseIf lbltema.Text = "Redentor" Then
            styCabeceras.BackColor = Color.White
            styCabeceras.ForeColor = Color.Black
        End If


        styCabeceras.Font = New Font("Segoe UI", 9, FontStyle.Regular Or
        FontStyle.Bold)
        Me.datalistadomateriales.ColumnHeadersDefaultCellStyle = styCabeceras
        'Me.datalistadomateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'Try
        '    '    Me.datalistadomateriales.CurrentCell = Me.datalistadomateriales(2, columna)
        '    'Catch ex As Exception
        '    'End Try
        '    Multilinea(datalistadomateriales)


    End Sub
    Sub dibujar()

        abrir()

        Dim query As String = "buscar_producto_por_descripcion_para_ventas"

        Dim cmd As New SqlCommand(query, conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@letra", txtbuscar.Text)
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        Dim NBotones As Integer = txtcontador.Text
        While rdr.Read()
            For I As Integer = 1 To NBotones
                Dim b As New Button()
                b.Text = rdr("Descripcion").ToString() & rdr("Presentacion").ToString()
                b.Size = New System.Drawing.Size(218, 60)
                'Panel4.Controls.Add(b)
            Next
        End While
        Cerrar()
    End Sub

    Sub cargarseries_VENTAS()
        Try
            Dim dt As New DataTable
            Dim da As SqlDataAdapter
            Try
                abrir()
                da = New SqlDataAdapter("mostrar_Tipo_de_documentos_para_insertar_en_ventas", conexion)
                'da.SelectCommand.CommandType = 4
                'da.SelectCommand.Parameters.AddWithValue("@letra", TextBox2.Text)
                da.Fill(dt)
                datalistadocomprobante.DataSource = dt
                datalistadocomprobante.Columns(2).Visible = False
                datalistadocomprobante.Columns(3).Visible = False
                datalistadocomprobante.Columns(4).Visible = False
                datalistadocomprobante.Columns(5).Visible = False
                datalistadocomprobante.Columns(6).Visible = False
                datalistadocomprobante.Columns(7).Visible = False
                datalistadocomprobante.Columns(8).Visible = False
                datalistadocomprobante.Columns(9).Visible = False


                datalistadocomprobante.Columns(1).Width = 260
            Catch ex As Exception
                '
            End Try
            Cerrar()

        Catch ex As Exception

        End Try

    End Sub


    Private Sub REGISTRO_DE_CREDITOS_CON_PRODUCTOS_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown


        If (e.KeyCode = Keys.Escape) Then
            txtbuscar.Text = ""
            txtbuscar.Focus()
            DATALISTADO_PRODUCTOS_OKA.Visible = False

            lbltipodebusqueda.Text = dtempresaok.SelectedCells.Item(8).Value
            If lbltipodebusqueda.Text = "LECTORA" Then
                lbltipodebusqueda2.Text = "Precione ESC para iniciar una busqueda"
                BTNLECTORA.BackColor = Color.FromArgb(0, 197, 21)
                BTNTECLADO.BackColor = Color.DarkGray

            ElseIf lbltipodebusqueda.Text = "TECLADO" Then
                lbltipodebusqueda2.Text = "Buscar con teclado"
                BTNLECTORA.BackColor = Color.DarkGray
                BTNTECLADO.BackColor = Color.FromArgb(0, 197, 21)
            End If

        End If
        If (e.KeyCode = Keys.Space) Then



            If txt_total_suma.Text <> 0 And lblROL.Text <> "Solo Ventas (no esta autorizado para manejar dinero)" Then
                MEDIOS_DE_PAGO.befectivo.Visible = True
                MEDIOS_DE_PAGO.btarjeta.Visible = False
                MEDIOS_DE_PAGO.bcredito.Visible = False
                MEDIOS_DE_PAGO.bmixto.Visible = False
                MEDIOS_DE_PAGO.txttipo.Text = "EFECTIVO"
                MEDIOS_DE_PAGO.ShowDialog()
                MEDIOS_DE_PAGO.txttipo.Text = "EFECTIVO"
                MEDIOS_DE_PAGO.befectivo.Visible = True
                MEDIOS_DE_PAGO.btarjeta.Visible = False
                MEDIOS_DE_PAGO.bcredito.Visible = False
                MEDIOS_DE_PAGO.bmixto.Visible = False
            End If
        End If
        If e.KeyData = Keys.Alt + Keys.F4 Then

        End If
    End Sub

    Sub contar_ventas_en_espera()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("mostrar_ventas_en_espera", conexion)
        Try
            abrir()

            da.Fill(dt)
            datalistadoVentasEnEspera.DataSource = dt
            Cerrar()

        Catch ex As Exception
        End Try
        contar_ventasEspera()
    End Sub
    Private Sub contar_ventasEspera()
        Dim x As Integer
        x = datalistadoVentasEnEspera.Rows.Count
        LBLcontadorESPERA.Text = CStr(x)
    End Sub
    Sub contar_ventas_en_espera_solo_para_vendedores()
        Dim importe As Double
        Dim com As New SqlCommand("mostrar_ventas_en_espera_solo_para_vendedores", conexion)
        com.CommandType = 4
        com.Parameters.AddWithValue("@Id_caja", lblidcaja.Text)

        Try
            abrir()
            importe = (com.ExecuteScalar()) 'asignamos el valor del importe
            Cerrar()
            LBLcontadorESPERA.Text = importe
        Catch ex As Exception
            LBLcontadorESPERA.Text = 0
        End Try
        ' mostramos el importe

    End Sub
    Sub contar_Notificador_cobros()
        Dim importe As Double
        Dim com As New SqlCommand("CONTARNOTIFICADOR_COBROS", conexion)

        Try
            abrir()
            importe = (com.ExecuteScalar()) 'asignamos el valor del importe
            Cerrar()
            lblContarNOTIFICADOR_COBROS.Text = importe
        Catch ex As Exception
            lblContarNOTIFICADOR_COBROS.Text = 0
        End Try
        ' mostramos el importe

    End Sub
    Sub contar_Notificador_productos_vencidos()
        Dim importe As Double
        Dim com As New SqlCommand("contar_productos_vencidos", conexion)

        Try
            abrir()
            importe = (com.ExecuteScalar()) 'asignamos el valor del importe
            Cerrar()
            lblContarNOTIFICADOR_PRODUCTO_VENCIDOS.Text = importe
        Catch ex As Exception
            lblContarNOTIFICADOR_PRODUCTO_VENCIDOS.Text = 0
        End Try
        ' mostramos el importe

    End Sub
    Sub contar_NOTIFICADOR_PAGOS()
        Dim importe As Double
        Dim com As New SqlCommand("CONTARNOTIFICADOR_PAGOS", conexion)

        Try
            abrir()
            importe = (com.ExecuteScalar()) 'asignamos el valor del importe
            Cerrar()
            lblContarNOTIFICADOR_Pagos.Text = importe
        Catch ex As Exception
            lblContarNOTIFICADOR_Pagos.Text = 0
        End Try
        ' mostramos el importe

    End Sub
    Sub mostrar_empresas()



        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("mostrar_Empresa", conexion)


            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            dtempresaok.DataSource = dtDATALISTADO_AGREGANDO
            Cerrar()

        Catch ex As Exception
        End Try




        Try

            txtmoneda.Text = dtempresaok.SelectedCells.Item(4).Value
            LBLempresa.Text = dtempresaok.SelectedCells.Item(2).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Apagadado_Click(sender As Object, e As EventArgs) Handles Apagado.Click

        TimerEncendido.Start()

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


            Try
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("editar_IGV_Empresa", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Impuesto", txtimpuesto.Text)
                cmd.Parameters.AddWithValue("@Porcentaje_impuesto", txtporcentaje.Text)
                cmd.Parameters.AddWithValue("@Trabajas_con_impuestos", "SI")
                cmd.ExecuteNonQuery()
                Cerrar()
            Catch ex As Exception

            End Try
            LBLtrabajasConimpuestos.Text = "SI"
            mostrar_empresas()
            Try
                txtporcentaje.Text = dtempresaok.SelectedCells.Item(6).Value
            Catch ex As Exception
            End Try
            MenuEDITORdeIgv.Visible = True
            If txtporcentaje.Text = 0 Then
                TEDITARigv.Visible = False
                TconfirmaredicionIgv.Visible = True
                TcancelarEdiciondeIgv.Visible = True
            Else
                TEDITARigv.Visible = True
                TconfirmaredicionIgv.Visible = False
                TcancelarEdiciondeIgv.Visible = False
            End If
            txtimpuesto.Visible = True
            txtporcentaje.Visible = True


        End If
    End Sub

    Private Sub gif_apagado_Click(sender As Object, e As EventArgs) Handles gif_apagado.Click

    End Sub

    Private Sub Encendido_Click(sender As Object, e As EventArgs) Handles Encendido.Click

        TimerApagado.Start()

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
            MenuEDITORdeIgv.Visible = False
            txtimpuesto.Visible = False
            txtporcentaje.Visible = False
            Try
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("editar_IGV_Empresa", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Impuesto", txtimpuesto.Text)
                cmd.Parameters.AddWithValue("@Porcentaje_impuesto", txtporcentaje.Text)
                cmd.Parameters.AddWithValue("@Trabajas_con_impuestos", "NO")
                cmd.ExecuteNonQuery()
                Cerrar()
            Catch ex As Exception

            End Try
            LBLtrabajasConimpuestos.Text = "NO"

        End If
    End Sub

    Private Sub Encendido2_Click(sender As Object, e As EventArgs) Handles Encendido2.Click

        TimerApagado.Start()

    End Sub

    Private Sub Apagado2_Click(sender As Object, e As EventArgs) Handles Apagado2.Click

        TimerEncendido.Start()

    End Sub

    Private Sub VENTAS_MENU_PRINCIPAL_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dlgRes As DialogResult
        dlgRes = MessageBox.Show("¿Realmente desea Cerrar el Sistema?", "Cerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'If sender.Equals(guardar) Then
        '    Me.Dispose()
        'Else
        If dlgRes = DialogResult.Yes Then
            ''Dim valor As Boolean
            ''valor = btnGuardar()

            ''If valor = True Then
            'End
            ''End If

            ''If valor = False Then
            ''    e.Cancel = True
            ''End If
            If LBLcontadorESPERA.Text > 0 Then
                MASCARA1.Show()
                Anuncio_tienes_ventas_en_espera.ShowDialog()
            End If
            MASCARA1.Show()
            GENERADOR_DE_COPIAS_AUTOMATICO.ShowDialog()
            End
        End If

        If dlgRes = DialogResult.No Then
            e.Cancel = True
        End If

        'End If
        'Dim result As DialogResult
        ''CIERRE_DE_CAJA.ShowDialog()
        'result = MessageBox.Show("¿Realmente desea Cerrar el Sistema?", "Cerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'If result = DialogResult.OK Then

        '    End
        'Else

        'End If

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
    Sub validar_licencia_pro()
        MOSTRAR_licencia_temporal()


        Try

            LBLESTADOLicenciaLocal.Text = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(4).Value.Trim)
            txtfecha_final_licencia_temporal.Text = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(3).Value.Trim)

        Catch ex As Exception
        End Try

        If LBLESTADOLicenciaLocal.Text = "?ACTIVADO PRO?" Then
            PanelLicencia.Visible = True
            lblActivando_licencia.Text = "Licencia PROFESIONAL Activada hasta " & txtfecha_final_licencia_temporal.Text
            Button20.Visible = False

        End If



    End Sub
    Private Sub VENTAS_MENU_PRINCIPAL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

        validar_licencia_pro()




        Dim MiInfo = From Hd As ManagementObject In MisDiscos.Get Select Hd
        DiscInfo = MiInfo(0)
        lblIDSERIAL.Text = DiscInfo.Properties("SerialNumber").Value

        TXTACCION.Text = "VENTA"
        txtmenuinterno.Text = "MENU"
        'txtbuscar.Focus()
        mostrar_empresas()
        mostrar_Cajas()
        lblcaja.Text = LOGIN.lblcaja.Text
        lblidcaja.Text = LOGIN.txtidcaja.Text
        lblnombreUsuario.Text = LOGIN.lblnombredeCajero.Text
        lblLogin.Text = LOGIN.lblusuario_queinicioCaja.Text
        Try
            lbltipodebusqueda.Text = dtempresaok.SelectedCells.Item(8).Value
            txtimpuesto.Text = dtempresaok.SelectedCells.Item(7).Value
            txtporcentaje.Text = dtempresaok.SelectedCells.Item(6).Value
            LBLtrabajasConimpuestos.Text = dtempresaok.SelectedCells.Item(9).Value
            lbltema.Text = datalistadoCajas.SelectedCells.Item(2).Value
            lblcorreo.Text = dtempresaok.SelectedCells.Item(11).Value
            lblRedondeo.Text = dtempresaok.SelectedCells.Item(13).Value
        Catch ex As Exception

        End Try
        If lbltema.Text = "Redentor" Then
            tema_Redentor()
        ElseIf lbltema.Text = "Elegante Black" Then
            tema_Elegante_Black()

        End If
        Try
            If LBLtrabajasConimpuestos.Text = "NO" Then
                Apagado.Visible = True
                Apagado.BringToFront()
                txtimpuesto.Visible = False
                txtporcentaje.Visible = False
                MenuEDITORdeIgv.Visible = False

            Else
                Encendido.Visible = True
                Encendido.BringToFront()
                txtimpuesto.Visible = True
                txtporcentaje.Visible = True
                MenuEDITORdeIgv.Visible = True
                TEDITARigv.Visible = True
                TconfirmaredicionIgv.Visible = False
                TcancelarEdiciondeIgv.Visible = False


            End If
        Catch ex As Exception

        End Try
        If lbltipodebusqueda.Text = "LECTORA" Then
            lbltipodebusqueda2.Text = "Precione ESC para iniciar una busqueda"
            BTNLECTORA.BackColor = Color.FromArgb(0, 197, 21)
            BTNTECLADO.BackColor = Color.DarkGray

        ElseIf lbltipodebusqueda.Text = "TECLADO" Then
            lbltipodebusqueda2.Text = "Buscar con teclado"
            BTNLECTORA.BackColor = Color.DarkGray
            BTNTECLADO.BackColor = Color.FromArgb(0, 197, 21)

        End If
        Try
            If LBLtrabajasConimpuestos.Text = "SI" Then
                labeligv.Text = txtimpuesto.Text & "(" & txtporcentaje.Text & "%)"
                lbligvnumero.Text = txtporcentaje.Text
            End If
        Catch ex As Exception
        End Try
        lblsubtotal.Text = 0
        lbligv.Text = 0
        lbldescuento.Text = 0
        lbl_Login.Text = LOGIN.lblLogin.Text

        rcontado.Checked = True
        rcontado.BackColor = Color.SeaGreen
        rcredito.BackColor = Color.Silver
        Panel10.Visible = False
        Panel10.Dock = DockStyle.None
        'txtbuscar.Focus()

        limpiar()
        txtventagenerada.Text = "VENTA NUEVA"

        paneldegenerarventa.Enabled = True


        'txtbuscar.Focus()

        PANELCLIENTE.Enabled = False
        PANELCOMPROBANTE.Enabled = True
        panel_fechasoka.Enabled = False
        PANELPRODUCTOS.Enabled = True
        PanelTIPODEPAGO.Enabled = True

        txtidventa.Text = ""

        Listarventas()
        Listarproductosagregados()
        btn_insertar.Visible = True

        BTN_SEGUIR_AGREGANDO.Visible = False

        lblidusuario.Text = LOGIN.IDUSUARIO.Text


        Label27.Visible = True
        'txtbuscar.Focus()
        mostrar_permisos()
        SUMAR_NOTIFICACIONES()
        mostrar_usuario_logueado()
        If LBLcontadorESPERA.Text > 0 Then
            MASCARA1.Show()
            Anuncio_tienes_ventas_en_espera.ShowDialog()
        End If

    End Sub

    Sub SUMAR_NOTIFICACIONES()

        If lblROL.Text = "Solo Ventas (no esta autorizado para manejar dinero)" Then
            contar_ventas_en_espera_solo_para_vendedores()
        ElseIf lblROL.Text = "Cajero (Si esta autorizado para manejar dinero)" Then
            contar_ventas_en_espera()
        ElseIf lblROL.Text = "Administrador (Control total)" Then
            contar_ventas_en_espera()
        End If


        contar_Notificador_cobros()
        contar_NOTIFICADOR_PAGOS()
        contar_Notificador_productos_vencidos()
        mostrar_correo_base()
        Dim numero_correos As Integer
        If LBLEstado_correo.Text = "SIN CONEXION" Then

            numero_correos = 1
        Else
            numero_correos = 0

        End If
        Try

            LBLTotaldeNotificaciones.Text = numero_correos + LBLcontadorESPERA.Text * 1 + lblContarNOTIFICADOR_COBROS.Text * 1 + lblContarNOTIFICADOR_Pagos.Text * 1 + lblContarNOTIFICADOR_PRODUCTO_VENCIDOS.Text * 1
            If LBLTotaldeNotificaciones.Text = 0 Then
                LBLnotificaciones.Visible = False
            Else
                LBLnotificaciones.Visible = True
                LBLnotificaciones.Text = LBLTotaldeNotificaciones.Text
            End If
        Catch ex As Exception

        End Try
        mostrar_correo_base()

    End Sub
    Sub mostrar_Cajas()
        Try
            Dim dt As New DataTable
            Dim da As SqlDataAdapter
            Try
                abrir()
                da = New SqlDataAdapter("MOSTRAR_cajas_por_serial", conexion)
                da.SelectCommand.CommandType = 4
                da.SelectCommand.Parameters.AddWithValue("@serial", lblIDSERIAL.Text)
                da.Fill(dt)
                datalistadoCajas.DataSource = dt

            Catch ex As Exception
                '
            End Try
            Cerrar()

        Catch ex As Exception

        End Try

    End Sub
    Sub mostrar_usuario_logueado()
        Try
            Dim dt As New DataTable
            Dim da As SqlDataAdapter
            Try
                abrir()
                da = New SqlDataAdapter("mostrar_usuario_POR_login", conexion)
                da.SelectCommand.CommandType = 4
                da.SelectCommand.Parameters.AddWithValue("@login", lbl_Login.Text)
                da.Fill(dt)
                datalistado_usuario_logueado.DataSource = dt
                Cerrar()
            Catch ex As Exception
                '
            End Try


        Catch ex As Exception

        End Try
        Try
            ImagenEmpresaTRUE.BackgroundImage = Nothing
            Dim b() As Byte = datalistado_usuario_logueado.SelectedCells.Item(1).Value
            Dim ms As New IO.MemoryStream(b)
            ImagenEmpresaTRUE.Image = Image.FromStream(ms)
            ImagenEmpresaTRUE.SizeMode = PictureBoxSizeMode.StretchImage


        Catch ex As Exception
        End Try
    End Sub
    Sub mostrar_permisos()
        ''Dim dt As New DataTable
        ''Dim da As SqlDataAdapter
        ''Try
        ''    abrir()
        ''    da = New SqlDataAdapter("mostrar_permisos_por_usuario", conexion)
        ''    da.SelectCommand.CommandType = 4
        ''    da.SelectCommand.Parameters.AddWithValue("@LOGIN", lbl_Login.Text)
        ''    da.Fill(dt)
        ''    datalistado_permisos.DataSource = dt
        ''    Cerrar()

        'Catch ex As Exception
        'End Try
        Dim importe As String
        Dim com As New SqlCommand("mostrar_permisos_por_usuario", conexion)
        com.CommandType = 4
        com.Parameters.AddWithValue("@LOGIN", lbl_Login.Text)
        Try
            abrir()
            importe = (com.ExecuteScalar()) 'asignamos el valor del importe
            Cerrar()
            lblROL.Text = importe
        Catch ex As Exception
        End Try
        ' mostramos el importe

        Try

            If lblROL.Text = "Solo Ventas (no esta autorizado para manejar dinero)" Then
                PanelGALERIA_DE_PAGOS.Enabled = False

                txtbuscar.Enabled = True
                MenuStrip5.Visible = False
                MenuStrip6.Visible = False
                ToolStrip1.Visible = False
                PictureBox18.Visible = False
                LBLnotificaciones.Visible = False
                BTNVENTASENESPERA.Visible = False
                LBLcontadorESPERA.Visible = False
                btnIngresosCaja.Visible = False
                btnGastos.Visible = False

                BtnCerrar_turno.Visible = False
                PanelGALERIA_DE_PAGOS.Visible = False
                btnVerventas.Visible = False

            ElseIf lblROL.Text = "Cajero (Si esta autorizado para manejar dinero)" Then
                PanelGALERIA_DE_PAGOS.Enabled = True
                PanelGALERIA_DE_PAGOS.Visible = True

                txtbuscar.Enabled = True
                MenuStrip5.Visible = True
                MenuStrip6.Visible = False
                ToolStrip1.Visible = False
                PictureBox18.Visible = True
                LBLnotificaciones.Visible = True
                BTNVENTASENESPERA.Visible = True
                LBLcontadorESPERA.Visible = True
                btnIngresosCaja.Visible = True
                btnGastos.Visible = True
                PanelDISEÑADOR.Visible = False
                PanelDASHBOARD.Visible = False
                PanelUSUARIOS.Visible = False
                BtnCerrar_turno.Visible = True
                btnVerventas.Visible = True

            ElseIf lblROL.Text = "Administrador (Control total)" Then
                PanelGALERIA_DE_PAGOS.Visible = True
                PanelGALERIA_DE_PAGOS.Enabled = True
                txtbuscar.Enabled = True
                MenuStrip5.Visible = True
                MenuStrip6.Visible = True
                ToolStrip1.Visible = True
                PictureBox18.Visible = True
                LBLnotificaciones.Visible = True
                BTNVENTASENESPERA.Visible = True
                LBLcontadorESPERA.Visible = True
                btnIngresosCaja.Visible = True
                btnGastos.Visible = True
                PanelDISEÑADOR.Visible = True
                PanelDASHBOARD.Visible = True
                PanelUSUARIOS.Visible = True
                BtnCerrar_turno.Visible = True
                btnVerventas.Visible = True

            End If
        Catch ex As Exception

        End Try

        '    If datalistado_permisos.SelectedCells.Item(7).Value = 1 Then
        '        txtbuscar.Enabled = True
        '    Else
        '        txtbuscar.Enabled = False
        '    End If

        '    If datalistado_permisos.SelectedCells.Item(8).Value = 1 Then
        '        MenuStrip16.Enabled = True
        '    Else
        '        MenuStrip16.Enabled = False
        '    End If

        '    If datalistado_permisos.SelectedCells.Item(9).Value = 1 Then
        '        Tdevoluciones.Enabled = True
        '    Else
        '        Tdevoluciones.Enabled = False
        '    End If

        '    If datalistado_permisos.SelectedCells.Item(10).Value = 1 Then
        '        PanelCOBROS.Visible = True
        '    Else
        '        PanelCOBROS.Visible = False
        '    End If

        '    If datalistado_permisos.SelectedCells.Item(11).Value = 1 Then
        '        PanelPAGOS.Visible = True
        '    Else
        '        PanelPAGOS.Visible = False
        '    End If

        '    If datalistado_permisos.SelectedCells.Item(12).Value = 1 Then
        '        PanelCLIENTES.Visible = True
        '    Else
        '        PanelCLIENTES.Visible = False
        '    End If

        '    If datalistado_permisos.SelectedCells.Item(13).Value = 1 Then
        '        ToolStrip1.Visible = True
        '    Else
        '        ToolStrip1.Visible = False
        '    End If
        '    If datalistado_permisos.SelectedCells.Item(14).Value = 1 Then
        '        PanelINVENTARIO.Visible = True
        '    Else
        '        PanelINVENTARIO.Visible = False
        '    End If
        '    If datalistado_permisos.SelectedCells.Item(15).Value = 1 Then
        '        MenuStrip6.Visible = True
        '    Else
        '        MenuStrip6.Visible = False
        '    End If
        '    If datalistado_permisos.SelectedCells.Item(16).Value = 1 Then
        '        PanelUSUARIOS.Visible = True
        '    Else
        '        PanelUSUARIOS.Visible = False
        '    End If
        '    If datalistado_permisos.SelectedCells.Item(17).Value = 1 Then
        '        PanelREPORTES.Visible = True
        '    Else
        '        PanelREPORTES.Visible = False
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Sub cargarPROVEEDORES()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_cliente_POR_nombre_PARA_COMPRAS_buscador", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtclientesolicitabnte.Text)
            da.Fill(dt)
            datalistadoclientes.DataSource = dt
            datalistadoclientes.Columns(2).Visible = False
            datalistadoclientes.Columns(3).Visible = False
            datalistadoclientes.Columns(4).Visible = False
            datalistadoclientes.Columns(1).Width = 300
            Cerrar()
        Catch ex As Exception
            '
        End Try


    End Sub

    Sub cargarseries()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_Tipo_de_documentos_para_insertar_en_ventas", conexion)
            'da.SelectCommand.CommandType = 4
            'da.SelectCommand.Parameters.AddWithValue("@letra", TextBox2.Text)
            da.Fill(dt)
            datalistadocomprobante.DataSource = dt
            datalistadocomprobante.Columns(2).Visible = False
            datalistadocomprobante.Columns(3).Visible = False
            datalistadocomprobante.Columns(4).Visible = False
            datalistadocomprobante.Columns(5).Visible = False
            datalistadocomprobante.Columns(6).Visible = False
            datalistadocomprobante.Columns(7).Visible = False
            datalistadocomprobante.Columns(8).Visible = False
            datalistadocomprobante.Columns(9).Visible = False


            datalistadocomprobante.Columns(1).Width = 260
        Catch ex As Exception
            '
        End Try
        Cerrar()

    End Sub

    Sub cargarclientes()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_cliente_POR_nombre_PARA_VENTAS_todos", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtclientesolicitabnte.Text)
            da.Fill(dt)
            datalistadoclientes.DataSource = dt
            datalistadoclientes.Columns(2).Visible = False
            datalistadoclientes.Columns(3).Visible = False
            datalistadoclientes.Columns(4).Visible = False
            datalistadoclientes.Columns(1).Width = 300
            Cerrar()
        Catch ex As Exception
            '
        End Try


    End Sub


    Sub Listarproductos()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_producto_por_descripcion_para_ventas", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtbuscar.Text)
            da.Fill(dt)
            datalistado.DataSource = dt
            ocultar_datalistado_de_busqueda_de_productos()
            datalistado.Columns(7).Visible = False
        Catch ex As Exception
            '
        End Try
        Cerrar()
    End Sub
    Sub ocultar_datalistado_de_busqueda_de_productos()
        datalistado.Columns(2).Width = 260
        datalistado.Columns(3).Width = 160
        datalistado.Columns(4).Width = 68
        datalistado.Columns(6).Width = 130
        datalistado.Columns(1).Visible = False
        datalistado.Columns(5).Visible = False

    End Sub
    Private Sub contar_tablas_ventas()
        Dim x As Integer
        x = datalistadomateriales.Rows.Count
        lblcontadortablaventas.Text = CStr(x)
    End Sub
    Private Sub contar()
        Dim x As Integer
        x = datalistado.Rows.Count
        txtcontador.Text = CStr(x)
    End Sub
    Sub Listarventas()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("select * from ventas  where ventas.Estado='EN ESPERA' order by idventa desc", conexion)
            'da.SelectCommand.CommandType = 4
            'da.SelectCommand.Parameters.AddWithValue("@letra", TextBox2.Text)
            da.Fill(dt)
            datalistadoventas_nuevasok.DataSource = dt
        Catch ex As Exception
            '
        End Try
        Cerrar()
    End Sub


    Private Sub All_filter_click(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub


    Private Sub lbl2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim obj As New Negocio_Producto
        'Dim listaProductos As New List(Of Entidad_productos_ok)
        'Detalle_Producto.Show() 'Abrimos el formulario detalle producto '

    End Sub



    Private Function convertirfecha_ansi(ByVal picker As DateTimePicker) As String
        Dim cadena As String = ""
        cadena = CStr(picker.Value.Year)
        If (picker.Value.Month) < 10 Then
            cadena = cadena + "0" + CStr(picker.Value.Month)
        Else
            cadena = cadena + CStr(picker.Value.Month)
        End If

        If picker.Value.Day < 10 Then
            cadena = cadena + "0" + CStr(picker.Value.Day)
        Else
            cadena = cadena + CStr(picker.Value.Day)
        End If
        Return cadena
    End Function

    Private Sub txtbuscar_Click(sender As Object, e As EventArgs) Handles txtbuscar.Click
        DATALISTADO_PRODUCTOS_OKA.Visible = True
        txtbuscar.Text = ""
        'txtbuscar.Focus()
        LISTAR_PRODUCTOS_Abuscador()
        ocultar_objetos_emergentes()

    End Sub

    Private Sub txtbuscar_HandleDestroyed(sender As Object, e As EventArgs) Handles txtbuscar.HandleDestroyed

    End Sub

    Private Sub txtbuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbuscar.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            DATALISTADO_PRODUCTOS_OKA.Focus()

        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            DATALISTADO_PRODUCTOS_OKA.Focus()

        End If

        If e.KeyCode = Keys.Right Then
            Try
                DATALISTADO_PRODUCTOS_OKA.Focus()
                txtbuscar.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(2).Value

                DATALISTADO_PRODUCTOS_OKA.Visible = False

            Catch ex As Exception

            End Try

        End If
    End Sub

    Sub LISTAR_PRODUCTOS_Abuscador()
        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("BUSCAR_PRODUCTOS_oka", conexion)
            daListarpresentacionesagregadas.SelectCommand.CommandType = 4


            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@letrab", txtbuscar.Text)

            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            DATALISTADO_PRODUCTOS_OKA.DataSource = dtDATALISTADO_AGREGANDO
            DATALISTADO_PRODUCTOS_OKA.Columns(0).Width = 60
            DATALISTADO_PRODUCTOS_OKA.Columns(1).Visible = False
            DATALISTADO_PRODUCTOS_OKA.Columns(3).Visible = False
            DATALISTADO_PRODUCTOS_OKA.Columns(4).Visible = False
            DATALISTADO_PRODUCTOS_OKA.Columns(5).Visible = False
            DATALISTADO_PRODUCTOS_OKA.Columns(6).Visible = False
            DATALISTADO_PRODUCTOS_OKA.Columns(7).Visible = False
            DATALISTADO_PRODUCTOS_OKA.Columns(8).Visible = False
            DATALISTADO_PRODUCTOS_OKA.Columns(9).Visible = False
            DATALISTADO_PRODUCTOS_OKA.Columns(10).Visible = False
            DATALISTADO_PRODUCTOS_OKA.Columns(11).Visible = False
            DATALISTADO_PRODUCTOS_OKA.Columns(12).Visible = False
            DATALISTADO_PRODUCTOS_OKA.Columns(13).Visible = False
            DATALISTADO_PRODUCTOS_OKA.Columns(14).Visible = False
            DATALISTADO_PRODUCTOS_OKA.Columns(15).Visible = False
            DATALISTADO_PRODUCTOS_OKA.Columns(16).Visible = False
            DATALISTADO_PRODUCTOS_OKA.Columns(17).Visible = False
            DATALISTADO_PRODUCTOS_OKA.Columns(2).Width = 620


        Catch ex As Exception
        End Try
        Cerrar()
        'sumar_total_despachado()
    End Sub
    Sub eliminar_venta_al_agregar_productos()
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("eliminar_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)

            cmd.ExecuteNonQuery()
            Cerrar()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtbuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscar.KeyUp
        If e.KeyCode = Keys.Down Then
            DATALISTADO_PRODUCTOS_OKA.RowsDefaultCellStyle.SelectionBackColor = Color.WhiteSmoke
            DATALISTADO_PRODUCTOS_OKA.Focus()
        End If
        If e.KeyCode = Keys.Up Then
            DATALISTADO_PRODUCTOS_OKA.RowsDefaultCellStyle.SelectionBackColor = Color.WhiteSmoke
            DATALISTADO_PRODUCTOS_OKA.Focus()
        End If
    End Sub
    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        contar_tablas_ventas()
        If lblcontadortablaventas.Text = 0 And txtventagenerada.Text = "VENTA GENERADA" Then
            Listarventas()
            Try
                txtidventa.Text = datalistadoventas_nuevasok.SelectedCells.Item(1).Value
            Catch ex As Exception
            End Try
            eliminar_venta_al_agregar_productos()
            txtventagenerada.Text = "VENTA NUEVA"
        End If
        If lbltipodebusqueda.Text = "LECTORA" Then
            lbltipodebusqueda2.Text = "Buscar con lector de código de barras"
            TimerBUSCADORcodigodebarras.Start()

            lbltipodebusqueda2.Visible = False

        ElseIf lbltipodebusqueda.Text = "TECLADO" Then
            lbltipodebusqueda2.Text = "Buscar con teclado"
            If txtbuscar.Text = "" Then
                DATALISTADO_PRODUCTOS_OKA.Visible = False
                lbltipodebusqueda2.Visible = True
            End If
            If txtbuscar.Text <> "" Then
                DATALISTADO_PRODUCTOS_OKA.Visible = True
                lbltipodebusqueda2.Visible = False
            End If

            LISTAR_PRODUCTOS_Abuscador()


        End If



    End Sub


    Private Sub Buscarporgirado_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As EventArgs) Handles Panel3.Paint

    End Sub

    Private Sub txtclientesolicitante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtidventa.SelectedIndexChanged
        With txtidclientequesolicitacargado
            .DataSource = dtcliente
            .DisplayMember = "idclientev"
            .ValueMember = "idclientev"
        End With
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click


    End Sub
    Sub disminuir_stock_productos()
        Dim cmdaumentarstock As SqlCommand
        Try
            For Each row As DataGridViewRow In datalistadomateriales.Rows

                Dim idlote As Integer = Convert.ToInt32(row.Cells("Id_producto").Value)
                Dim cantidad As Decimal = Convert.ToDouble(row.Cells("Cant").Value)
                Try
                    abrir()

                    cmdaumentarstock = New SqlCommand("disminuir_stock", conexion)
                    cmdaumentarstock.CommandType = 4
                    cmdaumentarstock.Parameters.AddWithValue("@Id_presentacionfraccionada", idlote)
                    cmdaumentarstock.Parameters.AddWithValue("@cantidad", cantidad)
                    cmdaumentarstock.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Cerrar()

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub txtbuscador_para_detalle_de_producto_TextChanged(sender As Object, e As EventArgs) Handles txtbuscador_para_detalle_de_producto.TextChanged
        'If cbocampo.Text = "Descripcion" Then
        '    Dim dt As New DataTable
        '    Dim da As New SqlDataAdapter("BUSCAR_producto_por_descripcion", conexion)
        '    Try
        '        abrir()
        '        da.SelectCommand.CommandType = 4
        '        da.SelectCommand.Parameters.AddWithValue("@letra", txtbuscador_para_detalle_de_producto.Text)



        '        da.Fill(dt)
        '        datalistado.DataSource = dt
        '        'contar()

        '    Catch ex As Exception

        '    End Try
        'If cbocampo.Text = "Codigo_interno" Then
        '    Dim dt As New DataTable
        '    Dim da As New SqlDataAdapter("BUSCAR_producto_por_codigo_interno", conexion)
        '    Try
        '        abrir()
        '        da.SelectCommand.CommandType = 4
        '        da.SelectCommand.Parameters.AddWithValue("@letra", txtbuscador_para_detalle_de_producto.Text)



        '        da.Fill(dt)
        '        datalistado.DataSource = dt
        '        'contar()

        '    Catch ex As Exception

        '    End Try
        'End If

        'ElseIf cbocampo.Text = "Codigo_de_barras" Then
        'Dim dt As New DataTable
        'Dim da As New SqlDataAdapter("BUSCAR_producto_por_Codigo_de_barras", conexion)
        'Try
        '    abrir()
        '    da.SelectCommand.CommandType = 4
        '    da.SelectCommand.Parameters.AddWithValue("@letra", txtbuscador_para_detalle_de_producto.Text)



        '    da.Fill(dt)
        '    datalistado.DataSource = dt


        'Catch ex As Exception

        'End Try
        'End If


    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        'PictureBox2.BackgroundImage = Nothing
        'Dim b() As Byte = datalistado.SelectedCells.Item(7).Value
        'Dim ms As New IO.MemoryStream(b)
        'PictureBox2.Image = Image.FromStream(ms)
        'PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    'Private Sub radiomayorista_CheckedChanged(sender As Object, e As EventArgs) Handles radiomayorista.CheckedChanged
    '    txtprecioreferencia.Text = datalistado.SelectedCells.Item(10).Value
    'End Sub

    'Private Sub radiominorista_CheckedChanged(sender As Object, e As EventArgs) Handles radiominorista.CheckedChanged
    '    txtprecioreferencia.Text = datalistado.SelectedCells.Item(9).Value
    'End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        detalle_producto.Visible = True
        txtnombreproducto.Text = datalistado.SelectedCells.Item(2).Value
        txtidproducto.Text = datalistado.SelectedCells.Item(1).Value
        TXTIDPRODUCTO_PARAFRACCIONAR.Text = datalistado.SelectedCells.Item(1).Value

        txtpresentacionok.Text = datalistado.SelectedCells.Item(3).Value
        txtprecioreal.Text = 0
        txtcantidad.Text = 0
        Listarpresentaciones_con_precios_agregados()
        txtstockok.Text = datalistado.SelectedCells.Item(4).Value

    End Sub
    Sub Listarpresentaciones_con_precios_agregados()
        Dim dtListarpresentacionesagregadas As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("mostrar_presentaciones_de_fraccionamiento_con_precios_por_presentacion_en_especifico", conexion)
            daListarpresentacionesagregadas.SelectCommand.CommandType = 4
            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@Id_presentacionfraccionada", datalistado.SelectedCells.Item(5).Value)
            daListarpresentacionesagregadas.Fill(dtListarpresentacionesagregadas)
            DATALISTADOPRESENTACIONES_AGREGADAS.DataSource = dtListarpresentacionesagregadas
            DATALISTADOPRESENTACIONES_AGREGADAS.Columns(4).Visible = False
            DATALISTADOPRESENTACIONES_AGREGADAS.Columns(1).Width = 260
            DATALISTADOPRESENTACIONES_AGREGADAS.Columns(2).Width = 140
            DATALISTADOPRESENTACIONES_AGREGADAS.Columns(3).Width = 100
        Catch ex As Exception
        End Try
        Cerrar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Sub actualizar_serie_mas_uno()
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("actualizar_serializacion_mas_uno", conexion)
            cmd.CommandType = 4

            cmd.Parameters.AddWithValue("@idserie", txtnumerofin.Text)
            cmd.ExecuteNonQuery()


            Cerrar()



        Catch ex As Exception

        End Try

    End Sub

    Sub insertar_guias_de_remision()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_guias_de_remision", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_venta", txtidventa.Text)



            cmd.Parameters.AddWithValue("@Estado", "GUIA DE REMISION PENDIENTE")


            cmd.ExecuteNonQuery()
            Cerrar()


        Catch ex As Exception

        End Try
    End Sub



    Private Sub sumar()


        Try
            Dim totalpagar As Double
            totalpagar = 0

            Dim fila As DataGridViewRow = New DataGridViewRow()
            For Each fila In datalistadomateriales.Rows
                totalpagar += (fila.Cells("Importe").Value)
            Next
            If totalpagar = 0 Then
                lbldescuento.Text = 0
            End If
            Try
                If LBLtrabajasConimpuestos.Text = "SI" Then
                    lbligv.Text = (txtporcentaje.Text * 1 * (totalpagar) / 100)
                    lbligv.Text = Format(CType(lbligv.Text, Decimal), "##0.0")
                    lblsubtotal.Text = (totalpagar) - lbligv.Text * 1 + lbldescuento.Text * 1
                    lblsubtotal.Text = Format(CType(lblsubtotal.Text, Decimal), "##0.00")
                End If
            Catch ex As Exception
            End Try
            Try
                If LBLtrabajasConimpuestos.Text = "NO" Then
                    lblsubtotal.Text = (totalpagar) + lbldescuento.Text * 1
                    lblsubtotal.Text = Format(CType(lblsubtotal.Text, Decimal), "##0.00")
                    lbligv.Text = 0
                End If
                If lblRedondeo.Text = "SI" Then
                    txt_total_suma.Text = lblsubtotal.Text * 1 + lbligv.Text * 1 - lbldescuento.Text * 1
                    txt_total_suma.Text = Format(CType(txt_total_suma.Text, Decimal), "##0.0")
                    TXTSALDO.Text = txt_total_suma.Text
                Else

                    txt_total_suma.Text = lblsubtotal.Text * 1 + lbligv.Text * 1 - lbldescuento.Text * 1
                    txt_total_suma.Text = Format(CType(txt_total_suma.Text, Decimal), "##0.00")
                    TXTSALDO.Text = txt_total_suma.Text
                End If
                If txt_total_suma.Text * 1 > 0 Then
                    PanelOperaciones.Visible = True
                Else
                    PanelOperaciones.Visible = False

                End If

            Catch ex As Exception

            End Try



        Catch ex As Exception

        End Try
    End Sub





    Private Sub checkigv_CheckedChanged(sender As Object, e As EventArgs) Handles checkigv.CheckedChanged
        Try
            If checkigv.Checked = True Then
                txtigv.Text = txttotalparcial.Text * (0.18)
                txttotal.Text = txttotalparcial.Text - txtigv.Text
                txttotal.Text = Format(CType(txttotal.Text, Decimal), "##0.0")

            Else
                txttotal.Text = txttotalparcial.Text
                txttotal.Text = Format(CType(txttotal.Text, Decimal), "##0.0")
                txtigv.Text = "0.00"

            End If
        Catch ex As Exception

        End Try



    End Sub

    Sub aumentar_monto_a_cliente()
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("aumentar_saldo_a_cliente", conexion)
            cmd.CommandType = 4

            cmd.Parameters.AddWithValue("@idcliente", datalistadoclientes.SelectedCells.Item(2).Value)
            cmd.Parameters.AddWithValue("@Saldo", txttotal_oka.Text)

            cmd.ExecuteNonQuery()
            Cerrar()

        Catch ex As Exception

        End Try
    End Sub
    Sub CONFIRMAR_VENTA()

        Dim numero As Double
        numero = txttotalentero.Text
        txt_total_suma.Text = Num2Text(numero)
        Dim a() As String
        a = Split(txttotal.Text, ".")
        txttotaldecimal.Text = a(1) & "0"
        txtnumeroconvertidoenletra.Text = txt_total_suma.Text & " CON " & txttotaldecimal.Text & "/100"
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("actualizartotal_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)
            cmd.Parameters.AddWithValue("@montototal", txt_total_suma.Text)
            cmd.Parameters.AddWithValue("@IGV", 0)
            cmd.Parameters.AddWithValue("@Saldo", TXTSALDO.Text)

            cmd.ExecuteNonQuery()
            'MsgBox("VENTA GUARDADA CORRECTAMENTE")
            Cerrar()


            If TXTACCION.Text = "COMPRA" Then
                aumentar_stock()
                aumentar_monto_a_cliente_PARA_COMISIONES()
            End If






        Catch ex As Exception

        End Try




    End Sub
    Sub limpiar()
        txtidventa.Text = ""
        txtidclientequesolicitacargado.Text = ""

        txtcliente.Text = ""
        txtidclientequesolicitacargado.Text = ""
        txtnumerodecomprobante.Text = ""
        txttotal.Text = "0.00"
        txtigv.Text = "0.00"
        txttotalparcial.Text = "0.00"

        radiocontado.Checked = False
        radiocredito.Checked = True
        radiomayorista.Checked = False
        radiominorista.Checked = False
        txtprecioreferencia.Text = ""
        txtanuncio.Text = "Inicie venta seleccionando cliente y comprobante     >>>>>>>>>>>>>>>>>>>>>>>"
        paneldegenerarventa.Enabled = True

        txtclientesolicitabnte.Text = ""
        'txtbuscar.Text = ""
        'txtbuscar.Enabled = False
        txtnumerodecomprobante.Text = ""
        cargarclientes()
        cargarseries()
        noafectarstock.Checked = True

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        detalle_producto.Visible = False
    End Sub




    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub datalistadomateriales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadomateriales.CellClick
        Try
            txtpantalla.Text = 1
            columna = datalistadomateriales.CurrentRow.Index
            lblcolumna.Text = columna
        Catch ex As Exception

        End Try



        ocultar_objetos_emergentes()
        Try
            txtidproducto.Text = datalistadomateriales.SelectedCells.Item(8).Value
        Catch ex As Exception

        End Try
        If e.ColumnIndex = Me.datalistadomateriales.Columns.Item("S").Index Then

            lblidproducto.Text = datalistadomateriales.SelectedCells.Item(8).Value
            If datalistadomateriales.SelectedCells.Item(17).Value = "Unidad" Or datalistadomateriales.SelectedCells.Item(17).Value = "No definido" Then

                editar_detalle_venta_sumar()
            ElseIf datalistadomateriales.SelectedCells.Item(17).Value = "Granel" Then
                CANTIDAD_A_GRANEL.txtprecio_unitario.Text = datalistadomateriales.SelectedCells.Item(6).Value
                Id_presentacion.Text = datalistadomateriales.SelectedCells.Item(8).Value
                CANTIDAD_A_GRANEL.txtProducto.Text = datalistadomateriales.SelectedCells.Item(4).Value
                CANTIDAD_A_GRANEL.lblstock.Text = datalistadomateriales.SelectedCells.Item(11).Value
                lblAgranellAumentar.Text = "AUMENTAR AGRANEL"
                CANTIDAD_A_GRANEL.txtcantidad.Text = 1
                CANTIDAD_A_GRANEL.LblcantidadAumentar.Visible = True

                CANTIDAD_A_GRANEL.ShowDialog()

            End If


        End If
        If e.ColumnIndex = Me.datalistadomateriales.Columns.Item("R").Index Then
            editar_detalle_venta_restar()
            contar_tablas_ventas()
            If lblcontadortablaventas.Text = 0 And txtventagenerada.Text = "VENTA GENERADA" Then
                Listarventas()
                Try
                    txtidventa.Text = datalistadoventas_nuevasok.SelectedCells.Item(1).Value
                Catch ex As Exception
                End Try
                eliminar_venta_al_agregar_productos()
                txtventagenerada.Text = "VENTA NUEVA"
            End If
        End If

        If e.ColumnIndex = Me.datalistadomateriales.Columns.Item("EL").Index Then

            Dim cmd As SqlCommand

            Try
                For Each row As DataGridViewRow In datalistadomateriales.SelectedRows

                    Dim onekey As Integer = Convert.ToInt32(row.Cells("iddetalle_venta").Value)
                    Dim Id_producto As Integer = Convert.ToInt32(row.Cells("Id_producto").Value)
                    Dim cantidad As Double = Convert.ToDouble(row.Cells("cantidad").Value)


                    Try


                        abrir()
                        cmd = New SqlCommand("eliminar_detalle_venta", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@iddetalleventa", onekey)
                        cmd.ExecuteNonQuery()
                        Cerrar()

                    Catch ex As Exception : MsgBox(ex.Message)

                    End Try


                Next
                Call Listarproductosagregados()
                If txt_total_suma.Text = 0 Then
                    abrir()
                    cmd = New SqlCommand("eliminar_venta", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)
                    cmd.ExecuteNonQuery()
                    Cerrar()

                End If

                contar_ventas_en_espera()




            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub






    Private Sub datalistadoclientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoclientes.CellClick
        Try

            txtcliente.Text = datalistadoclientes.SelectedCells.Item(1).Value

            txtclientesolicitabnte.Text = datalistadoclientes.SelectedCells.Item(1).Value
            datalistadoclientes.Visible = False
            LBL_DIRECCION.Text = datalistadoclientes.SelectedCells.Item(3).Value
            LBL_CELULAR.Text = datalistadoclientes.SelectedCells.Item(4).Value

            panel_fechasoka.Enabled = True
            PANELPRODUCTOS.Enabled = True
        Catch ex As Exception

        End Try


    End Sub

    Sub editar_serializacion()
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("editar_serializacion", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@serie", txtserie.Text)
            cmd.Parameters.AddWithValue("@numeroinicio", txtnumeroinicio.Text)
            cmd.Parameters.AddWithValue("@numerofin", txtnumerofin.Text)
            cmd.Parameters.AddWithValue("@idserie", datalistadocomprobante.SelectedCells.Item(6).Value)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub datalistadocomprobante_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadocomprobante.CellClick
        txttipodecomprobante.Text = datalistadocomprobante.SelectedCells.Item(1).Value
        'txtnumerodecomprobante.Text = datalistadocomprobante.SelectedCells.Item(7).Value

        txtserie.Text = datalistadocomprobante.SelectedCells.Item(3).Value
        txtnumeroinicio.Text = datalistadocomprobante.SelectedCells.Item(4).Value
        txtnumerofin.Text = datalistadocomprobante.SelectedCells.Item(5).Value
        PANELCLIENTE.Enabled = True

    End Sub

    Private Sub datalistadocomprobante_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadocomprobante.CellContentClick

    End Sub

    Private Sub txtclientesolicitabnte_Click(sender As Object, e As EventArgs) Handles txtclientesolicitabnte.Click
        datalistadoclientes.Visible = True
        txtclientesolicitabnte.Text = ""

    End Sub

    Private Sub txtclientesolicitabnte_TextChanged(sender As Object, e As EventArgs) Handles txtclientesolicitabnte.TextChanged

        If TXTACCION.Text = "PEDIDO DE VENTA" Then
            cargarclientes()

        End If
        If TXTACCION.Text = "VENTA" Then
            cargarclientes()

        End If
        If TXTACCION.Text = "COMPRA" Then

            cargarPROVEEDORES()
        End If



    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click


        If TXTACCION.Text = "VENTA" Then
            clientes_PROVEEDORES.Panelregistro.Visible = True
            clientes_PROVEEDORES.GuardarCambios.Visible = True
            clientes_PROVEEDORES.GuardarRegistro.Visible = True
            clientes_PROVEEDORES.txtclientes.Checked = True

            clientes_PROVEEDORES.lbltipo.Text = "C"

            clientes_PROVEEDORES.ShowDialog()
            clientes_PROVEEDORES.txtclientes.Checked = True
            clientes_PROVEEDORES.lbltipo.Text = "C"
            clientes_PROVEEDORES.Panelregistro.Visible = True
            clientes_PROVEEDORES.GuardarCambios.Visible = True
            clientes_PROVEEDORES.GuardarRegistro.Visible = True
        End If
        If TXTACCION.Text = "COMPRA" Then
            clientes_PROVEEDORES.GuardarCambios.Visible = True
            clientes_PROVEEDORES.GuardarRegistro.Visible = True
            clientes_PROVEEDORES.Panelregistro.Visible = True
            clientes_PROVEEDORES.txtproveedor.Checked = True
            clientes_PROVEEDORES.lbltipo.Text = "P"


            clientes_PROVEEDORES.ShowDialog()
            clientes_PROVEEDORES.txtproveedor.Checked = True
            clientes_PROVEEDORES.lbltipo.Text = "P"
            clientes_PROVEEDORES.Panelregistro.Visible = True
            clientes_PROVEEDORES.GuardarCambios.Visible = True
            clientes_PROVEEDORES.GuardarRegistro.Visible = True
        End If
        If TXTACCION.Text = "PEDIDO DE VENTA" Then
            clientes_PROVEEDORES.GuardarCambios.Visible = True
            clientes_PROVEEDORES.GuardarRegistro.Visible = True
            clientes_PROVEEDORES.Panelregistro.Visible = True
            clientes_PROVEEDORES.txtclientes.Checked = True
            clientes_PROVEEDORES.lbltipo.Text = "C"


            clientes_PROVEEDORES.ShowDialog()
            clientes_PROVEEDORES.txtclientes.Checked = True
            clientes_PROVEEDORES.lbltipo.Text = "C"
            clientes_PROVEEDORES.Panelregistro.Visible = True
            clientes_PROVEEDORES.GuardarCambios.Visible = True
            clientes_PROVEEDORES.GuardarRegistro.Visible = True
        End If








    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)
        cargarseries()

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Sub eliminar_venta()
        Dim result As DialogResult

        result = MessageBox.Show("¿Realmente desea eliminar esta Venta?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then


            Try
                Dim cmd As New SqlCommand

                abrir()
                cmd = New SqlCommand("eliminar_venta", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)

                cmd.ExecuteNonQuery()
                Cerrar()
                limpiar()

            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub




    Private Sub txtfecha_de_pago_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        productosOK.ShowDialog()


    End Sub


    Private Sub ActualizarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem1.Click
        Listarpresentaciones_con_precios_agregados()

    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs)


        productosOK.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs)

    End Sub
    Sub SUMAR_VENTAS()

        Dim importe As Double
        Dim com As New SqlCommand("contar_detalles_de_venta_en_espera", conexion)
        com.CommandType = 4
        com.Parameters.AddWithValue("@id_producto", lblidproducto.Text)
        Try
            abrir()
            importe = (com.ExecuteScalar()) 'asignamos el valor del importe
            Cerrar()
            lblcontador_detalle_de_venta.Text = importe
        Catch ex As Exception
            lblcontador_detalle_de_venta.Text = 0
        End Try
        ' mostramos el importe
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
    Sub insertar_detalle_venta()

        Try
            If lblUsaInventarios.Text = "SI" Then
                If lblStock_de_Productos.Text * 1 >= txtpantalla.Text * 1 Then
                    SUMAR_VENTAS()
                    Dim cmd As New SqlCommand
                    abrir()
                    cmd = New SqlCommand("insertar_detalle_venta", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)
                    cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", txtidproducto.Text)
                    cmd.Parameters.AddWithValue("@cantidad", txtpantalla.Text)
                    cmd.Parameters.AddWithValue("@preciounitario", txtprecio_unitario.Text)
                    cmd.Parameters.AddWithValue("@moneda", txtmoneda.Text)



                    cmd.Parameters.AddWithValue("@unidades", "Unidad")
                    cmd.Parameters.AddWithValue("@Cantidad_mostrada", txtpantalla.Text)
                    cmd.Parameters.AddWithValue("@Estado", "EN ESPERA")
                    cmd.Parameters.AddWithValue("@Descripcion", lbldescripcion.Text)
                    cmd.Parameters.AddWithValue("@Codigo", lblcodigo.Text)
                    If lblStock_de_Productos.Text = 0 Then
                        cmd.Parameters.AddWithValue("@Stock", lblStock_de_Productos.Text)
                    ElseIf lblStock_de_Productos.Text > 0 Then
                        cmd.Parameters.AddWithValue("@Stock", lblStock_de_Productos.Text)
                    End If

                    cmd.Parameters.AddWithValue("@Se_vende_a", TXTSEVENDEPOR.Text)
                    cmd.Parameters.AddWithValue("@Usa_inventarios", lblUsaInventarios.Text)
                    cmd.Parameters.AddWithValue("@Costo", lblcosto.Text)

                    cmd.ExecuteNonQuery()
                    Cerrar()

                    disminuir_stock()

                Else
                    TimerLABEL_STOCK.Start()
                End If



            ElseIf lblUsaInventarios.Text = "NO" Then

                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("insertar_detalle_venta", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)

                cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", txtidproducto.Text)
                cmd.Parameters.AddWithValue("@cantidad", txtpantalla.Text)
                cmd.Parameters.AddWithValue("@preciounitario", txtprecio_unitario.Text)
                cmd.Parameters.AddWithValue("@moneda", txtmoneda.Text)


                cmd.Parameters.AddWithValue("@unidades", "Unidad")
                cmd.Parameters.AddWithValue("@Cantidad_mostrada", txtpantalla.Text)
                cmd.Parameters.AddWithValue("@Estado", "EN ESPERA")
                cmd.Parameters.AddWithValue("@Descripcion", lbldescripcion.Text)
                cmd.Parameters.AddWithValue("@Codigo", lblcodigo.Text)
                cmd.Parameters.AddWithValue("@Stock", lblStock_de_Productos.Text)
                cmd.Parameters.AddWithValue("@Se_vende_a", TXTSEVENDEPOR.Text)
                cmd.Parameters.AddWithValue("@Usa_inventarios", lblUsaInventarios.Text)
                cmd.Parameters.AddWithValue("@Costo", lblcosto.Text)

                cmd.ExecuteNonQuery()
                Cerrar()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        contar_ventas_en_espera()

    End Sub
    Sub insertar_detalle_venta_a_granel()

        Try




            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_detalle_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)
            cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", Id_presentacion.Text)
            cmd.Parameters.AddWithValue("@cantidad", 1)
            cmd.Parameters.AddWithValue("@preciounitario", txtprecio_unitario.Text)
            cmd.Parameters.AddWithValue("@moneda", txtmoneda.Text)



            cmd.Parameters.AddWithValue("@unidades", "Unidad")
            cmd.Parameters.AddWithValue("@Cantidad_mostrada", txtpantalla.Text)
            cmd.Parameters.AddWithValue("@Estado", "EN ESPERA")
            cmd.Parameters.AddWithValue("@Costo", DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(7).Value)

            cmd.ExecuteNonQuery()
            Cerrar()
            detalle_producto.Visible = False
            Listarproductosagregados()
            sumar()
            txtcantidad.Text = 0
            txtprecioreal.Text = 0
            aumentar_monto_a_cliente()
            Panel10.Visible = False
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try



    End Sub
    Sub editar_detalle_venta_sumar()


        Try
            If datalistadomateriales.SelectedCells.Item(16).Value = "NO" Then
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("editar_detalle_venta_sumar", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Id_producto", lblidproducto.Text)
                cmd.Parameters.AddWithValue("@cantidad", 1)
                cmd.Parameters.AddWithValue("@Cantidad_mostrada", 1)
                cmd.Parameters.AddWithValue("@Id_venta", txtidventa.Text)

                cmd.ExecuteNonQuery()
                Cerrar()

            End If
            If datalistadomateriales.SelectedCells.Item(16).Value = "SI" Then
                If datalistadomateriales.SelectedCells.Item(11).Value > 0 Then
                    Dim cmd As New SqlCommand
                    abrir()
                    cmd = New SqlCommand("editar_detalle_venta_sumar", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@Id_producto", lblidproducto.Text)
                    cmd.Parameters.AddWithValue("@cantidad", 1)
                    cmd.Parameters.AddWithValue("@Cantidad_mostrada", 1)
                    cmd.Parameters.AddWithValue("@Id_venta", txtidventa.Text)

                    cmd.ExecuteNonQuery()
                    Cerrar()
                    txtidproducto.Text = datalistadomateriales.SelectedCells.Item(8).Value
                    disminuir_stock()
                Else
                    TimerLABEL_STOCK.Start()

                End If


            End If
            Listarproductosagregados()
            sumar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Sub editar_detalle_venta_restar()



        If datalistadomateriales.SelectedCells.Item(16).Value = "NO" Then
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("editar_detalle_venta_restar", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@iddetalle_venta", datalistadomateriales.SelectedCells.Item(9).Value)
            cmd.Parameters.AddWithValue("@cantidad", 1)
            cmd.Parameters.AddWithValue("@Cantidad_mostrada", 1)
            cmd.Parameters.AddWithValue("@Id_producto", lblidproducto.Text)
            cmd.Parameters.AddWithValue("@Id_venta", txtidventa.Text)
            cmd.ExecuteNonQuery()
            Cerrar()
        End If

        Try


            If datalistadomateriales.SelectedCells.Item(16).Value = "SI" Then

                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("editar_detalle_venta_restar", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@iddetalle_venta", datalistadomateriales.SelectedCells.Item(9).Value)
                cmd.Parameters.AddWithValue("@cantidad", 1)
                cmd.Parameters.AddWithValue("@Cantidad_mostrada", 1)
                cmd.Parameters.AddWithValue("@Id_producto", txtidproducto.Text)
                cmd.Parameters.AddWithValue("@Id_venta", datalistadomateriales.SelectedCells.Item(18).Value)
                cmd.ExecuteNonQuery()
                Cerrar()
                txtidproducto.Text = datalistadomateriales.SelectedCells.Item(8).Value
                aumentar_stock()

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Listarproductosagregados()
        sumar()


    End Sub
    Sub editar_detalle_venta_restar_BOTON_CANTIDAD()

        Try

            If datalistadomateriales.SelectedCells.Item(16).Value = "NO" Then
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("editar_detalle_venta_restar", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@iddetalle_venta", datalistadomateriales.SelectedCells.Item(9).Value)
                cmd.Parameters.AddWithValue("@cantidad", CANTIDAD_A_EDITAR)
                cmd.Parameters.AddWithValue("@Cantidad_mostrada", CANTIDAD_A_EDITAR)
                cmd.Parameters.AddWithValue("@Id_producto", lblidproducto.Text)
                cmd.Parameters.AddWithValue("@Id_venta", datalistadomateriales.SelectedCells.Item(18).Value)

                cmd.ExecuteNonQuery()
                Cerrar()

            End If
            If datalistadomateriales.SelectedCells.Item(16).Value = "SI" Then

                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("editar_detalle_venta_restar", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@iddetalle_venta", datalistadomateriales.SelectedCells.Item(9).Value)
                cmd.Parameters.AddWithValue("@cantidad", CANTIDAD_A_EDITAR)
                cmd.Parameters.AddWithValue("@Cantidad_mostrada", CANTIDAD_A_EDITAR)
                cmd.Parameters.AddWithValue("@Id_producto", datalistadomateriales.SelectedCells.Item(8).Value)
                cmd.Parameters.AddWithValue("@Id_venta", datalistadomateriales.SelectedCells.Item(18).Value)

                cmd.ExecuteNonQuery()
                Cerrar()
                txtidproducto.Text = datalistadomateriales.SelectedCells.Item(8).Value
                aumentar_stock_BOTON_CANTIDAD()

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Listarproductosagregados()
        sumar()


    End Sub
    Private Sub txtcantidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcantidad.SelectedIndexChanged

    End Sub


    Sub disminuir_stock()
        Try
            Dim cmd As New SqlCommand

            Try
                abrir()
                cmd = New SqlCommand("disminuir_stock_en_detalle_de_venta", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", txtidproducto.Text)
                If TXTSEVENDEPOR.Text <> "Granel" Then
                    cmd.Parameters.AddWithValue("@cantidad", txtpantalla.Text)
                ElseIf TXTSEVENDEPOR.Text = "Granel" Then
                    cmd.Parameters.AddWithValue("@cantidad", CANTIDAD_A_GRANEL.txtcantidad.Text)
                End If


            Catch ex As Exception

            End Try




            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            TimerLABEL_STOCK.Start()
        End Try

    End Sub
    Sub disminuir_stock_varias_cantidades()
        Try
            Dim cmd As New SqlCommand

            Try
                abrir()
                cmd = New SqlCommand("disminuir_stock_en_detalle_de_venta", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", txtidproducto.Text)

                cmd.Parameters.AddWithValue("@cantidad", AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS.txtcantidad.Text)



            Catch ex As Exception

            End Try




            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            TimerLABEL_STOCK.Start()
        End Try

    End Sub
    Sub aumentar_stock()
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("aumentar_stock_en_detalle_de_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", datalistadomateriales.SelectedCells.Item(8).Value)
            cmd.Parameters.AddWithValue("@cantidad", 1)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub aumentar_stock_BOTON_CANTIDAD()
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("aumentar_stock_en_detalle_de_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", datalistadomateriales.SelectedCells.Item(8).Value)
            cmd.Parameters.AddWithValue("@cantidad", CANTIDAD_A_EDITAR)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click

        'editar_serializacion()
        If txtventagenerada.Text = "VENTA NUEVA" Then
            txtnumerodecomprobante.Text = txtserie.Text & "-" & txtnumeroinicio.Text & txtnumerofin.Text
            If rcontado.Checked = True Then txttipo.Text = "CONTADO"
            If rcredito.Checked = True Then txttipo.Text = "CREDITO"
            If rcontado.Checked = True Then txtestado.Text = "PAGADO"
            If rcredito.Checked = True Then txtestado.Text = "DEUDA"
            Try
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("insertar_venta", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@idcliente", 0)
                cmd.Parameters.AddWithValue("@ACCION", TXTACCION.Text)
                cmd.Parameters.AddWithValue("@fecha_venta", Now())
                cmd.Parameters.AddWithValue("@Fecha_de_pago", txtfecha_de_pago.Value)
                cmd.Parameters.AddWithValue("@Comprobante", "Ticket")
                cmd.Parameters.AddWithValue("@nume_documento", txtnumerodecomprobante.Text)
                cmd.Parameters.AddWithValue("@montototal", 0)
                cmd.Parameters.AddWithValue("@IGV", 0)
                cmd.Parameters.AddWithValue("@id_usuario", lblidusuario.Text)
                cmd.Parameters.AddWithValue("@estado", "EN ESPERA")
                cmd.Parameters.AddWithValue("@Tipo_de_pago", "-")
                cmd.Parameters.AddWithValue("@Saldo", 0)
                cmd.Parameters.AddWithValue("@Pago_con", 0)
                cmd.Parameters.AddWithValue("@Porcentaje_IGV", lbligvnumero.Text)
                cmd.Parameters.AddWithValue("@Id_caja", LOGIN.txtidcaja.Text)
                cmd.Parameters.AddWithValue("@Referencia_tarjeta", "NULO")
                cmd.ExecuteNonQuery()
                txtanuncio.ForeColor = Color.RoyalBlue
                Cerrar()
                Listarventas()
                txtidventa.Text = datalistadoventas_nuevasok.SelectedCells.Item(1).Value
                txtventagenerada.Text = "VENTA GENERADA"
            Catch ex As Exception
                LBL_CANTIDAD_UNIDAD_MEDIDA.Text = MsgBox(ex.Message)
            End Try
        End If

        If txtventagenerada.Text = "VENTA GENERADA" Then
            'actualizar_serie_mas_uno()
            insertar_detalle_venta_a_granel()
            Listarproductosagregados()
            btn_insertar.Visible = False
            BTN_SEGUIR_AGREGANDO.Visible = True
            DATALISTADO_PRODUCTOS_OKA.Visible = True
            txtbuscar.Text = ""
            'txtbuscar.Focus()
            'CONFIRMAR_VENTA()
            Panel10.Visible = False
            panel_granel.Visible = False
        End If

        '*
        '    *
        '    *



    End Sub
    Sub aumentar_monto_a_cliente_PARA_COMISIONES()
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("aumentar_saldo_a_cliente", conexion)
            cmd.CommandType = 4

            cmd.Parameters.AddWithValue("@idcliente", datalistadoclientes.SelectedCells.Item(2).Value)
            cmd.Parameters.AddWithValue("@Saldo", TXTSALDO.Text)

            cmd.ExecuteNonQuery()
            Cerrar()

        Catch ex As Exception
            '
        End Try
    End Sub


    Private Sub CBXVENDEDOR_SelectedIndexChanged(sender As Object, e As EventArgs)
        With TXTIDUSUARIO
            .DataSource = DT_USUARIO
            .DisplayMember = "idUsuario"
            .ValueMember = "idUsuario"

        End With
    End Sub
    Private Sub DATALISTADO_PRODUCTOS_OKA_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_PRODUCTOS_OKA.CellClick

        Try

            txtbuscar.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(2).Value
            lblidproducto.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(1).Value
            Timerbuscar_descripcioncodigo.Start()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub DATALISTADO_PRODUCTOS_OKA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_PRODUCTOS_OKA.CellContentClick

    End Sub
    Public Sub NumerosyDecimal(ByVal CajaTexto As System.Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        ElseIf e.KeyChar = "," Then
            e.Handled = False

        Else
            e.Handled = True

        End If


    End Sub


    Private Sub txtpantalla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpantalla.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            '
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtpantalla, e)
    End Sub


    Private Sub txtpantalla_TextChanged(sender As Object, e As EventArgs) Handles txtpantalla.TextChanged
        Try
            txtprecio_actual.Text = txtprecio_unitario.Text * 1 * txtpantalla.Text * 1
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged

    End Sub

    Private Sub BTN_SEGUIR_AGREGANDO_Click(sender As Object, e As EventArgs) Handles BTN_SEGUIR_AGREGANDO.Click
        editar_serializacion()


        txtnumerodecomprobante.Text = txtserie.Text & "-" & txtnumeroinicio.Text & txtnumerofin.Text
        'Try
        '    Dim cmd As New SqlCommand

        '    abrir()
        '    cmd = New SqlCommand("insertar_venta", conexion)
        '    cmd.CommandType = 4
        '    cmd.Parameters.AddWithValue("@idcliente", datalistadoclientes.SelectedCells.Item(2).Value)
        '    cmd.Parameters.AddWithValue("@fecha_venta", txtfechadeventa.Value)
        '    cmd.Parameters.AddWithValue("@Fecha_de_pago", txtfecha_de_pago.Value)
        '    cmd.Parameters.AddWithValue("@Id_series", datalistadocomprobante.SelectedCells.Item(6).Value)
        '    cmd.Parameters.AddWithValue("@nume_documento", txtnumerodecomprobante.Text)
        '    cmd.Parameters.AddWithValue("@montototal", "0.0")
        '    cmd.Parameters.AddWithValue("@Guia_de_remision", "0.0")
        '    cmd.Parameters.AddWithValue("@IGV", "0.0")
        '    cmd.Parameters.AddWithValue("@id_usuario", lblidusuario.Text)
        '    cmd.Parameters.AddWithValue("@estado", "DEUDA")
        '    cmd.Parameters.AddWithValue("@Tipo_de_pago", "CREDITO")



        '    cmd.ExecuteNonQuery()
        '    txtanuncio.Text = "<<<<< VENTA GENERADA CORRECTAMENTE: PROSIGA AGREGANDO PRODUCTOS A LA VENTA"

        '    txtanuncio.ForeColor = Color.RoyalBlue

        '    Cerrar()

        '    Listarventas()
        '    txtidventa.Text = datalistadoventas.SelectedCells.Item(1).Value

        '    paneldegenerarventa.Enabled = False
        '    paneldeguardarventa.Enabled = True



        'Catch ex As Exception
        '
        'End Try
        actualizar_serie_mas_uno()



        'Dim DA As SqlDataAdapter
        'Try
        '    abrir()
        '    DA = New SqlDataAdapter("mostrar_Tipo_de_documentos_para_insertar_en_ventas", conexion)
        '    DA.Fill(dtserie)


        'Catch ex As Exception
        'End Try
        'Cerrar()


        'txtbuscar.Enabled = True
        'txtbuscar.Text = ""

        'actualizar_estado_de_inmobiliario()
        insertar_detalle_venta()
        Listarproductosagregados()

        'btn_insertar.Visible = False
        'BTN_SEGUIR_AGREGANDO.Visible = True

        CONFIRMAR_VENTA()
        Panel10.Dock = DockStyle.None
    End Sub


    Private Sub txtprecio_actual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio_actual.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then

            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtpantalla, e)
    End Sub

    Private Sub txtprecio_por_unidad_De_medida_TextChanged(sender As Object, e As EventArgs) Handles txtprecio_actual.TextChanged
        Try
            txtpantalla.Text = (txtprecio_actual.Text * 1) / (txtprecio_unitario.Text * 1)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        Dim progFiles As String = "C:\Program Files\Common Files\Microsoft Shared\ink"
        Dim keyboardPath As String = Path.Combine(progFiles, "TabTip.exe")
        Process.Start(keyboardPath)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub txt_total_suma_Click(sender As Object, e As EventArgs) Handles TXTTOTALACTUAL.Click, txt_total_suma.Click
        ocultar_objetos_emergentes()
    End Sub

    Private Sub TXTMANDO_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TimERSTOCK_Tick(sender As Object, e As EventArgs) Handles TimERSTOCK.Tick

        disminuir_stock_productos()
        TimERSTOCK.Stop()

    End Sub

    Private Sub rcontado_CheckedChanged(sender As Object, e As EventArgs) Handles rcontado.CheckedChanged
        Label21.Visible = False
        txtfecha_de_pago.Visible = False
        rcontado.BackColor = Color.SeaGreen
        rcredito.BackColor = Color.Silver
    End Sub

    Private Sub rcredito_CheckedChanged(sender As Object, e As EventArgs) Handles rcredito.CheckedChanged
        Label21.Visible = True
        txtfecha_de_pago.Visible = True
        rcontado.BackColor = Color.Silver
        rcredito.BackColor = Color.OrangeRed
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs)

        'Label27.Visible = False

    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()


    End Sub



    Private Sub PANELPRODUCTOS_Paint(sender As Object, e As EventArgs) Handles PANELPRODUCTOS.Paint

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles Button1.Click

        panel_granel.Visible = False
    End Sub

    Private Sub MenuStrip3_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip3.ItemClicked

    End Sub

    Private Sub LBL_DIRECCION_Click(sender As Object, e As EventArgs) Handles LBL_DIRECCION.Click

    End Sub

    Private Sub Panel11_Paint(sender As Object, e As EventArgs) Handles panel_granel.Paint

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)

    End Sub




    Private Sub datalistadomateriales_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles datalistadomateriales.CellFormatting
        'If e.ColumnIndex = 4 Then
        '    e.CellStyle.BackColor = Color.LightGreen
        'End If
    End Sub

    Private Sub datalistadomateriales_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datalistadomateriales.CellMouseMove

    End Sub


    Private Sub datalistadomateriales_KeyDown(sender As Object, e As KeyEventArgs) Handles datalistadomateriales.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{TAB}")
        End If

        If (e.KeyCode = Keys.Delete) Then

            Dim result As DialogResult
            Dim cmd As SqlCommand
            result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                Try
                    For Each row As DataGridViewRow In datalistadomateriales.SelectedRows
                        'Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                        'datalistado.Rows.Remove(datalistado.CurrentRow)


                        'If datalistado.SelectedCells.Item(6).Value Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("iddetalle_venta").Value)
                        Dim Id_producto As Integer = Convert.ToInt32(row.Cells("Id_producto").Value)
                        Dim cantidad As Double = Convert.ToDouble(row.Cells("cantidad").Value)


                        Try

                            Try

                                abrir()
                                cmd = New SqlCommand("aumentar_stock", conexion)
                                cmd.CommandType = 4
                                cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", Id_producto)
                                cmd.Parameters.AddWithValue("@cantidad", cantidad)
                                cmd.ExecuteNonQuery()
                                Cerrar()
                            Catch ex As Exception

                            End Try

                            abrir()
                            cmd = New SqlCommand("eliminar_detalle_venta", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@iddetalleventa", onekey)
                            cmd.ExecuteNonQuery()
                            Cerrar()

                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try

                        'End If

                    Next
                    Call Listarproductosagregados()





                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If


        End If


    End Sub

    Private Sub datalistadomateriales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles datalistadomateriales.KeyPress

        txtpantalla.Text = 1
        If e.KeyChar = "+"c Then

            'R.SuppressKeyPress = True

            'SendKeys.Send("{TAB}")
            'ocultar_objetos_emergentes()
            Try
                txtidproducto.Text = datalistadomateriales.SelectedCells.Item(8).Value
            Catch ex As Exception

            End Try
            lblidproducto.Text = datalistadomateriales.SelectedCells.Item(8).Value
            If datalistadomateriales.SelectedCells.Item(17).Value = "Unidad" Then

                editar_detalle_venta_sumar()
            ElseIf datalistadomateriales.SelectedCells.Item(17).Value = "Granel" Then
                CANTIDAD_A_GRANEL.txtprecio_unitario.Text = datalistadomateriales.SelectedCells.Item(6).Value
                Id_presentacion.Text = datalistadomateriales.SelectedCells.Item(8).Value
                CANTIDAD_A_GRANEL.txtProducto.Text = datalistadomateriales.SelectedCells.Item(4).Value
                CANTIDAD_A_GRANEL.lblstock.Text = datalistadomateriales.SelectedCells.Item(11).Value
                lblAgranellAumentar.Text = "AUMENTAR AGRANEL"
                CANTIDAD_A_GRANEL.txtcantidad.Text = 1
                CANTIDAD_A_GRANEL.LblcantidadAumentar.Visible = True

                CANTIDAD_A_GRANEL.ShowDialog()

            End If





        End If
        If e.KeyChar = "-"c Then
            editar_detalle_venta_restar()
            contar_tablas_ventas()
            If lblcontadortablaventas.Text = 0 And txtventagenerada.Text = "VENTA GENERADA" Then
                Listarventas()
                Try
                    txtidventa.Text = datalistadoventas_nuevasok.SelectedCells.Item(1).Value
                Catch ex As Exception
                End Try
                eliminar_venta_al_agregar_productos()
                txtventagenerada.Text = "VENTA NUEVA"
            End If
        End If
    End Sub

    Private Sub DATALISTADO_PRODUCTOS_OKA_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DATALISTADO_PRODUCTOS_OKA.CellFormatting
        Dim dgv As DataGridView = CType(sender, DataGridView)

        If dgv.Columns(e.ColumnIndex).Name = "Usa_inventarios" Then
            Select Case e.Value.ToString
                Case "SI"
                    dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
                Case "NO"
                    dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Blue
            End Select
        End If
        Select Case DATALISTADO_PRODUCTOS_OKA.Columns(e.ColumnIndex).Index
            Case 3
                Dim row As DataGridViewRow = DATALISTADO_PRODUCTOS_OKA.Rows(e.RowIndex)
                Dim cell As DataGridViewCell = DATALISTADO_PRODUCTOS_OKA.Rows(e.RowIndex).Cells(2)
                Select Case System.Convert.ToString(e.Value)
                    Case "SI"
                        row.DefaultCellStyle.BackColor = Color.Honeydew
                    Case Else
                        row.DefaultCellStyle.BackColor = Color.LightPink
                        cell.Style.BackColor = Color.LightCoral
                End Select
        End Select
    End Sub



    Private Sub DATALISTADO_PRODUCTOS_OKA_CellMouseEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DATALISTADO_PRODUCTOS_OKA.CellMouseEnter
        If e.RowIndex >= 0 Then
            Me.DATALISTADO_PRODUCTOS_OKA.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.WhiteSmoke
        End If

    End Sub

    Private Sub DATALISTADO_PRODUCTOS_OKA_CellMouseLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DATALISTADO_PRODUCTOS_OKA.CellMouseLeave
        If e.RowIndex >= 0 Then
            Me.DATALISTADO_PRODUCTOS_OKA.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End If
    End Sub



    Private Sub DATALISTADO_PRODUCTOS_OKA_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles DATALISTADO_PRODUCTOS_OKA.DefaultValuesNeeded

    End Sub



    Private Sub DATALISTADO_PRODUCTOS_OKA_KeyDown(sender As Object, e As KeyEventArgs) Handles DATALISTADO_PRODUCTOS_OKA.KeyDown
        If e.KeyCode = Keys.Enter Then

            Try

                txtbuscar.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(2).Value
                lblidproducto.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(1).Value
                Timerbuscar_descripcioncodigo.Start()

            Catch ex As Exception

            End Try

        End If
    End Sub








    Private Sub datalistadomateriales_KeyUp(sender As Object, e As KeyEventArgs) Handles datalistadomateriales.KeyUp

        If e.KeyCode = Keys.Down Then
            columna = datalistadomateriales.CurrentRow.Index
            lblcolumna.Text = columna
        End If
        If e.KeyCode = Keys.Up Then

            columna = datalistadomateriales.CurrentRow.Index
            lblcolumna.Text = columna
        End If

    End Sub




    Private Sub ToolStripMenuItem4_Click_1(sender As Object, e As EventArgs)
        editar_detalle_venta_sumar()

    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs)
        editar_detalle_venta_restar()

    End Sub



    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        txtidventa.Text = ""
        txtventagenerada.Text = "VENTA NUEVA"
        Listarproductosagregados()
        sumar()

        Timer3.Stop()

    End Sub

    Private Sub ToolStripMenuItem20_Click(sender As Object, e As EventArgs) Handles BTNTECLADO.Click
        lbltipodebusqueda.Text = "TECLADO"
        lbltipodebusqueda2.Text = "Buscar con teclado"
        BTNLECTORA.BackColor = Color.DarkGray
        BTNTECLADO.BackColor = Color.FromArgb(0, 197, 21)
        txtbuscar.Text = ""
        ocultar_objetos_emergentes()

    End Sub

    Private Sub befectivo_Click(sender As Object, e As EventArgs) Handles befectivo.Click

        ocultar_objetos_emergentes()
        If txt_total_suma.Text <> 0 Then
            MEDIOS_DE_PAGO.befectivo.Visible = True
            MEDIOS_DE_PAGO.btarjeta.Visible = False
            MEDIOS_DE_PAGO.bcredito.Visible = False
            MEDIOS_DE_PAGO.bmixto.Visible = False
            MEDIOS_DE_PAGO.txttipo.Text = "EFECTIVO"
            MEDIOS_DE_PAGO.Timer1.Start()

            'MASCARA1.Show()
            MEDIOS_DE_PAGO.ShowDialog()
            'MEDIOS_DE_PAGO.Timer1.Start()
            MEDIOS_DE_PAGO.txttipo.Text = "EFECTIVO"
            MEDIOS_DE_PAGO.befectivo.Visible = True
            MEDIOS_DE_PAGO.btarjeta.Visible = False
            MEDIOS_DE_PAGO.bcredito.Visible = False
            MEDIOS_DE_PAGO.bmixto.Visible = False
        End If

    End Sub

    Private Sub bcredito_Click(sender As Object, e As EventArgs) Handles bcredito.Click

        'ocultar_objetos_emergentes()
        If txt_total_suma.Text <> 0 Then
            MEDIOS_DE_PAGO.befectivo.Visible = False
            MEDIOS_DE_PAGO.btarjeta.Visible = False
            MEDIOS_DE_PAGO.bcredito.Visible = True
            MEDIOS_DE_PAGO.bmixto.Visible = False
            MEDIOS_DE_PAGO.PANEL_CLIENTE_FACTURA.Visible = False
            MEDIOS_DE_PAGO.txttipo.Text = "CREDITO"
            MEDIOS_DE_PAGO.Timer1.Start()
            'MASCARA1.Show()
            MEDIOS_DE_PAGO.ShowDialog()

            MEDIOS_DE_PAGO.txttipo.Text = "CREDITO"
            MEDIOS_DE_PAGO.PANEL_CLIENTE_FACTURA.Visible = False
            MEDIOS_DE_PAGO.befectivo.Visible = False
            MEDIOS_DE_PAGO.btarjeta.Visible = False
            MEDIOS_DE_PAGO.bcredito.Visible = True
            MEDIOS_DE_PAGO.bmixto.Visible = False
        End If

    End Sub

    Private Sub txtbuscar2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btarjeta_Click(sender As Object, e As EventArgs) Handles btarjeta.Click

        'ocultar_objetos_emergentes()
        If txt_total_suma.Text <> 0 Then

            MEDIOS_DE_PAGO.befectivo.Visible = False
            MEDIOS_DE_PAGO.btarjeta.Visible = True
            MEDIOS_DE_PAGO.bcredito.Visible = False
            MEDIOS_DE_PAGO.bmixto.Visible = False
            MEDIOS_DE_PAGO.txttipo.Text = "TARJETA"
            MEDIOS_DE_PAGO.Timer1.Start()
            MEDIOS_DE_PAGO.ShowDialog()

            MEDIOS_DE_PAGO.txttipo.Text = "TARJETA"
            MEDIOS_DE_PAGO.befectivo.Visible = False
            MEDIOS_DE_PAGO.btarjeta.Visible = True
            MEDIOS_DE_PAGO.bcredito.Visible = False
            MEDIOS_DE_PAGO.bmixto.Visible = False
        End If

    End Sub

    Private Sub bmixto_Click(sender As Object, e As EventArgs) Handles bmixto.Click

        'ocultar_objetos_emergentes()
        If txt_total_suma.Text <> 0 Then


            MEDIOS_DE_PAGO.befectivo.Visible = False
            MEDIOS_DE_PAGO.btarjeta.Visible = False
            MEDIOS_DE_PAGO.bcredito.Visible = False
            MEDIOS_DE_PAGO.bmixto.Visible = True
            MEDIOS_DE_PAGO.txttipo.Text = "MIXTO"
            MEDIOS_DE_PAGO.Timer1.Start()
            MEDIOS_DE_PAGO.ShowDialog()

            MEDIOS_DE_PAGO.txttipo.Text = "MIXTO"
            MEDIOS_DE_PAGO.befectivo.Visible = False
            MEDIOS_DE_PAGO.btarjeta.Visible = False
            MEDIOS_DE_PAGO.bcredito.Visible = False
            MEDIOS_DE_PAGO.bmixto.Visible = True
        End If

    End Sub



    Private Sub ToolStripMenuItem12_Click_1(sender As Object, e As EventArgs)
        Try
            Paneldesc.Visible = False
            lbldescuento.Text = 0.0

            sumar()

        Catch ex As Exception

        End Try
    End Sub

    'Private Sub ToolStripMenuItem10_Click_2(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
    '    If TXTNUEVOTOTAL.Text = "" Then TXTNUEVOTOTAL.Text = 0
    '    If TXTNUEVOTOTAL.Text * 1 < txt_total_suma.Text * 1 And TXTNUEVOTOTAL.Text > 0 Then
    '        lbldescuento.Text = txt_total_suma.Text * 1 - TXTNUEVOTOTAL.Text * 1
    '        lblporcentaje.Text = (TXTTOTALACTUAL.Text * 1 - TXTNUEVOTOTAL.Text * 1) / TXTTOTALACTUAL.Text * 1
    '        aplicar_descuento_a_cada_producto_en_detalle_venta()
    '        sumar()

    '        Paneldesc.Visible = False
    '    ElseIf TXTNUEVOTOTAL.Text * 1 >= txt_total_suma.Text * 1 Then
    '        MsgBox("El descuento Tiene que ser menor al TOTAL actual y mayor que 0")
    '    End If


    'End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click
        Paneldesc.Visible = False

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs)
        ocultar_objetos_emergentes()

        GASTOS_VARIOS_FORM.lbltipo.Text = "GASTOS VARIOS (-)"
        GASTOS_VARIOS_FORM.TXTACCION.Text = "SALIDA"
        GASTOS_VARIOS_FORM.PANELCOMPROBANTE.Enabled = False
        GASTOS_VARIOS_FORM.PANELPRECIOS.Enabled = False
        GASTOS_VARIOS_FORM.GuardarCambiosToolStripMenuItem.Visible = False
        GASTOS_VARIOS_FORM.txtmenuinterno.Text = "INTERNO"
        GASTOS_VARIOS_FORM.Id_usuario.Text = lblidusuario.Text
        GASTOS_VARIOS_FORM.ShowDialog()
        GASTOS_VARIOS_FORM.Id_usuario.Text = lblidusuario.Text
        GASTOS_VARIOS_FORM.txtmenuinterno.Text = "INTERNO"
        GASTOS_VARIOS_FORM.GuardarCambiosToolStripMenuItem.Visible = False
        GASTOS_VARIOS_FORM.PANELCOMPROBANTE.Enabled = False
        GASTOS_VARIOS_FORM.PANELPRECIOS.Enabled = False
        GASTOS_VARIOS_FORM.TXTACCION.Text = "SALIDA"
        GASTOS_VARIOS_FORM.lbltipo.Text = "GASTOS VARIOS (-)"
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)
        ocultar_objetos_emergentes()
        MASCARA1.Show()
        GASTOS_VARIOS_FORM.lbltipo.Text = "INGRESOS VARIOS (+)"
        GASTOS_VARIOS_FORM.TXTACCION.Text = "INGRESO"
        GASTOS_VARIOS_FORM.PANELCOMPROBANTE.Enabled = False
        GASTOS_VARIOS_FORM.PANELPRECIOS.Enabled = False

        GASTOS_VARIOS_FORM.GuardarCambiosToolStripMenuItem.Visible = False
        GASTOS_VARIOS_FORM.GUARDARNORMAL.Visible = True
        GASTOS_VARIOS_FORM.txtidgasto2.Text = ""
        GASTOS_VARIOS_FORM.TXTIDCONCEPTO.Text = ""


        GASTOS_VARIOS_FORM.txtobservacion.Text = ""
        GASTOS_VARIOS_FORM.txtnrocomprobante.Text = ""
        GASTOS_VARIOS_FORM.txttipocomprobante.Text = ""
        GASTOS_VARIOS_FORM.txtpantalla.Text = ""
        GASTOS_VARIOS_FORM.TXTCONCEPTO.Text = ""



        GASTOS_VARIOS_FORM.ShowDialog()


        GASTOS_VARIOS_FORM.GuardarCambiosToolStripMenuItem.Visible = False
        GASTOS_VARIOS_FORM.GUARDARNORMAL.Visible = True
        GASTOS_VARIOS_FORM.txtidgasto2.Text = ""
        GASTOS_VARIOS_FORM.TXTIDCONCEPTO.Text = ""


        GASTOS_VARIOS_FORM.txtobservacion.Text = ""
        GASTOS_VARIOS_FORM.txtnrocomprobante.Text = ""
        GASTOS_VARIOS_FORM.txttipocomprobante.Text = ""
        GASTOS_VARIOS_FORM.txtpantalla.Text = ""
        GASTOS_VARIOS_FORM.TXTCONCEPTO.Text = ""
        GASTOS_VARIOS_FORM.PANELCOMPROBANTE.Enabled = False
        GASTOS_VARIOS_FORM.PANELPRECIOS.Enabled = False

        GASTOS_VARIOS_FORM.TXTACCION.Text = "INGRESO"
        GASTOS_VARIOS_FORM.lbltipo.Text = "INGRESOS VARIOS (+)"
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs)
        'ocultar_objetos_emergentes()
        'If txt_total_suma.Text <> 0 Then


        '    Try
        '        Paneldesc.Visible = True
        '        TXTTOTALACTUAL.Text = txt_total_suma.Text
        '        txtmonto.Text = txt_total_suma.Text


        '    Catch ex As Exception

        '    End Try
        'End If
    End Sub

    Private Sub ToolStripMenuItem2_Click_1(sender As Object, e As EventArgs)
        ocultar_objetos_emergentes()
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs)
        ocultar_objetos_emergentes()
        Try
            Paneldesc.Visible = False
            lbldescuento.Text = 0.0

            sumar()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub TimerBUSCADORcodigodebarras_Tick(sender As Object, e As EventArgs) Handles TimerBUSCADORcodigodebarras.Tick


        TimerBUSCADORcodigodebarras.Stop()
        Try


            If txtbuscar.Text = "" Then
                DATALISTADO_PRODUCTOS_OKA.Visible = False
                lbltipodebusqueda2.Visible = True
            End If
            If txtbuscar.Text <> "" Then
                DATALISTADO_PRODUCTOS_OKA.Visible = True
                lbltipodebusqueda2.Visible = False
            End If
            LISTAR_PRODUCTOS_Abuscador()
            TXTSEVENDEPOR.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(11).Value
            txtidproducto.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(1).Value
            mostrar_stock_de_detalle_de_ventas()
            contar_stock_detalle_ventas()
            If lblcontador_stock_detalle_de_venta.Text = 0 Then
                lblStock_de_Productos.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(6).Value
            Else
                lblStock_de_Productos.Text = datalistado_stock_detalle_venta.SelectedCells.Item(1).Value
            End If
            lblUsaInventarios.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(5).Value
            lbldescripcion.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(17).Value
            lblcodigo.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(10).Value
            lblcosto.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(7).Value

            Try
                TXTSEVENDEPOR.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(11).Value
                If TXTSEVENDEPOR.Text = "Granel" Then
                    CANTIDAD_A_GRANEL.txtprecio_unitario.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(9).Value
                    Id_presentacion.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(1).Value
                    CANTIDAD_A_GRANEL.txtProducto.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(17).Value
                    Try
                        CANTIDAD_A_GRANEL.lblstock.Text = datalistadomateriales.SelectedCells.Item(11).Value

                    Catch ex As Exception
                        CANTIDAD_A_GRANEL.lblstock.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(6).Value

                    End Try
                    CANTIDAD_A_GRANEL.LblcantidadAumentar.Visible = False

                    CANTIDAD_A_GRANEL.ShowDialog()
                ElseIf TXTSEVENDEPOR.Text = "Unidad" Then
                    txtpantalla.Text = 1
                    txtprecio_unitario.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(9).Value
                    Try
                        If txtbuscar.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(10).Value Then
                            DATALISTADO_PRODUCTOS_OKA.Visible = True
                            If txtventagenerada.Text = "VENTA NUEVA" Then
                                txtnumerodecomprobante.Text = txtserie.Text & "-" & txtnumeroinicio.Text & txtnumerofin.Text
                                If rcontado.Checked = True Then txttipo.Text = "CONTADO"
                                If rcredito.Checked = True Then txttipo.Text = "CREDITO"
                                If rcontado.Checked = True Then txtestado.Text = "PAGADO"
                                If rcredito.Checked = True Then txtestado.Text = "DEUDA"
                                Try
                                    Dim cmd As New SqlCommand
                                    abrir()
                                    cmd = New SqlCommand("insertar_venta", conexion)
                                    cmd.CommandType = 4
                                    cmd.Parameters.AddWithValue("@idcliente", 0)
                                    cmd.Parameters.AddWithValue("@ACCION", TXTACCION.Text)
                                    cmd.Parameters.AddWithValue("@fecha_venta", Now())
                                    cmd.Parameters.AddWithValue("@Fecha_de_pago", txtfecha_de_pago.Value)
                                    cmd.Parameters.AddWithValue("@Comprobante", "Ticket " & txtidventa.Text)
                                    cmd.Parameters.AddWithValue("@Porcentaje_IGV", txtporcentaje.Text)
                                    cmd.Parameters.AddWithValue("@nume_documento", txtnumerodecomprobante.Text)
                                    cmd.Parameters.AddWithValue("@montototal", 0)
                                    cmd.Parameters.AddWithValue("@IGV", 0)
                                    cmd.Parameters.AddWithValue("@id_usuario", lblidusuario.Text)
                                    cmd.Parameters.AddWithValue("@estado", "EN ESPERA")
                                    cmd.Parameters.AddWithValue("@Tipo_de_pago", "-")
                                    cmd.Parameters.AddWithValue("@Saldo", 0)
                                    cmd.Parameters.AddWithValue("@Pago_con", 0)
                                    cmd.Parameters.AddWithValue("@Id_caja", LOGIN.txtidcaja.Text)
                                    cmd.Parameters.AddWithValue("@Referencia_tarjeta", "NULO")

                                    cmd.ExecuteNonQuery()
                                    txtanuncio.ForeColor = Color.RoyalBlue
                                    Cerrar()
                                    Listarventas()
                                    txtidventa.Text = datalistadoventas_nuevasok.SelectedCells.Item(1).Value
                                    txtventagenerada.Text = "VENTA GENERADA"
                                Catch ex As Exception
                                    MsgBox(ex.Message)
                                End Try
                            End If
                            If txtventagenerada.Text = "VENTA GENERADA" Then

                                insertar_detalle_venta()
                                Listarproductosagregados()
                                btn_insertar.Visible = False
                                BTN_SEGUIR_AGREGANDO.Visible = True
                                DATALISTADO_PRODUCTOS_OKA.Visible = False
                                txtbuscar.Text = ""
                                'txtbuscar.Focus()

                                Panel10.Visible = False
                                panel_granel.Visible = False
                            End If
                        End If
                    Catch ex As Exception
                    End Try
                End If
            Catch ex As Exception
            End Try
        Catch ex As Exception

        End Try
    End Sub
    Sub mostrar_stock_de_detalle_de_ventas()


        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_stock_de_detalle_de_ventas", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Id_producto", txtidproducto.Text)

            da.Fill(dt)
            datalistado_stock_detalle_venta.DataSource = dt
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try



    End Sub
    Private Sub contar_stock_detalle_ventas()
        Dim x As Integer
        x = datalistado_stock_detalle_venta.Rows.Count
        lblcontador_stock_detalle_de_venta.Text = CStr(x)
    End Sub
    Private Sub Timerbuscar_descripcioncodigo_Tick(sender As Object, e As EventArgs) Handles Timerbuscar_descripcioncodigo.Tick
        Timerbuscar_descripcioncodigo.Stop()
        Try
            TXTSEVENDEPOR.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(11).Value
            txtidproducto.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(1).Value
            mostrar_stock_de_detalle_de_ventas()
            contar_stock_detalle_ventas()
            If lblcontador_stock_detalle_de_venta.Text = 0 Then
                lblStock_de_Productos.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(6).Value
            Else
                lblStock_de_Productos.Text = datalistado_stock_detalle_venta.SelectedCells.Item(1).Value
            End If
            lblUsaInventarios.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(5).Value
            lbldescripcion.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(17).Value
            lblcodigo.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(10).Value
            lblcosto.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(7).Value
            If TXTSEVENDEPOR.Text = "Granel" Then
                vender_a_granel()
            ElseIf TXTSEVENDEPOR.Text = "Unidad" Then
                vender_por_unidad()
            End If


        Catch ex As Exception

        End Try

    End Sub
    Sub vender_a_granel()

        CANTIDAD_A_GRANEL.txtprecio_unitario.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(9).Value
        Id_presentacion.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(1).Value
        CANTIDAD_A_GRANEL.txtProducto.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(17).Value
        Try
            CANTIDAD_A_GRANEL.lblstock.Text = datalistadomateriales.SelectedCells.Item(11).Value
        Catch ex As Exception
            CANTIDAD_A_GRANEL.lblstock.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(6).Value
        End Try
        CANTIDAD_A_GRANEL.txtcantidad.Text = 1
        CANTIDAD_A_GRANEL.LblcantidadAumentar.Visible = False
        CANTIDAD_A_GRANEL.ShowDialog()
    End Sub
    Sub vender_por_unidad()
        txtpantalla.Text = 1
        txtprecio_unitario.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(9).Value
        Try
            If txtbuscar.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(2).Value Then
                DATALISTADO_PRODUCTOS_OKA.Visible = True

                If txtventagenerada.Text = "VENTA NUEVA" Then
                    txtnumerodecomprobante.Text = txtserie.Text & "-" & txtnumeroinicio.Text & txtnumerofin.Text
                    If rcontado.Checked = True Then txttipo.Text = "CONTADO"
                    If rcredito.Checked = True Then txttipo.Text = "CREDITO"
                    If rcontado.Checked = True Then txtestado.Text = "PAGADO"
                    If rcredito.Checked = True Then txtestado.Text = "DEUDA"
                    Try
                        Dim cmd As New SqlCommand
                        abrir()
                        cmd = New SqlCommand("insertar_venta", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@idcliente", 0)
                        cmd.Parameters.AddWithValue("@ACCION", TXTACCION.Text)
                        cmd.Parameters.AddWithValue("@fecha_venta", Now())
                        cmd.Parameters.AddWithValue("@Fecha_de_pago", txtfecha_de_pago.Value)
                        cmd.Parameters.AddWithValue("@Comprobante", "Ticket " & txtidventa.Text)
                        cmd.Parameters.AddWithValue("@Porcentaje_IGV", txtporcentaje.Text)
                        cmd.Parameters.AddWithValue("@nume_documento", txtnumerodecomprobante.Text)
                        cmd.Parameters.AddWithValue("@montototal", 0)
                        cmd.Parameters.AddWithValue("@IGV", 0)
                        cmd.Parameters.AddWithValue("@id_usuario", lblidusuario.Text)
                        cmd.Parameters.AddWithValue("@estado", "EN ESPERA")
                        cmd.Parameters.AddWithValue("@Tipo_de_pago", "-")
                        cmd.Parameters.AddWithValue("@Saldo", 0)
                        cmd.Parameters.AddWithValue("@Pago_con", 0)
                        cmd.Parameters.AddWithValue("@Id_caja", LOGIN.txtidcaja.Text)
                        cmd.Parameters.AddWithValue("@Referencia_tarjeta", "NULO")

                        cmd.ExecuteNonQuery()
                        txtanuncio.ForeColor = Color.RoyalBlue
                        Cerrar()
                        Listarventas()
                        txtidventa.Text = datalistadoventas_nuevasok.SelectedCells.Item(1).Value
                        txtventagenerada.Text = "VENTA GENERADA"
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                If txtventagenerada.Text = "VENTA GENERADA" Then

                    insertar_detalle_venta()
                    Listarproductosagregados()
                    btn_insertar.Visible = False
                    BTN_SEGUIR_AGREGANDO.Visible = True

                    txtbuscar.Text = ""
                    txtbuscar.Focus()

                    Panel10.Visible = False
                    panel_granel.Visible = False
                End If
            End If
        Catch ex As Exception
        End Try

    End Sub
    Private Sub BTNLECTORA_Click(sender As Object, e As EventArgs) Handles BTNLECTORA.Click
        lbltipodebusqueda.Text = "LECTORA"
        lbltipodebusqueda2.Text = "Buscar con lector de código de barras"
        BTNLECTORA.BackColor = Color.FromArgb(0, 197, 21)
        BTNTECLADO.BackColor = Color.DarkGray
        txtbuscar.Text = ""
        ocultar_objetos_emergentes()
    End Sub
    Private Sub TimerAGRANEL_Tick(sender As Object, e As EventArgs) Handles TimerAGRANEL.Tick
        TimerAGRANEL.Stop()
        Try
            txtpantalla.Text = CANTIDAD_A_GRANEL.txtcantidad.Text
            txtprecio_unitario.Text = CANTIDAD_A_GRANEL.txtprecio_actual.Text
            Try

                DATALISTADO_PRODUCTOS_OKA.Visible = True

                If txtventagenerada.Text = "VENTA NUEVA" Then
                    txtnumerodecomprobante.Text = txtserie.Text & "-" & txtnumeroinicio.Text & txtnumerofin.Text
                    If rcontado.Checked = True Then txttipo.Text = "CONTADO"
                    If rcredito.Checked = True Then txttipo.Text = "CREDITO"
                    If rcontado.Checked = True Then txtestado.Text = "PAGADO"
                    If rcredito.Checked = True Then txtestado.Text = "DEUDA"
                    Try
                        Dim cmd As New SqlCommand
                        abrir()
                        cmd = New SqlCommand("insertar_venta", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@idcliente", 0)
                        cmd.Parameters.AddWithValue("@ACCION", TXTACCION.Text)
                        cmd.Parameters.AddWithValue("@fecha_venta", Now())
                        cmd.Parameters.AddWithValue("@Fecha_de_pago", txtfecha_de_pago.Value)
                        cmd.Parameters.AddWithValue("@Comprobante", "Ticket " & txtidventa.Text)
                        cmd.Parameters.AddWithValue("@nume_documento", txtnumerodecomprobante.Text)
                        cmd.Parameters.AddWithValue("@montototal", 0)
                        cmd.Parameters.AddWithValue("@IGV", 0)
                        cmd.Parameters.AddWithValue("@id_usuario", lblidusuario.Text)
                        cmd.Parameters.AddWithValue("@estado", "EN ESPERA")
                        cmd.Parameters.AddWithValue("@Tipo_de_pago", "-")
                        cmd.Parameters.AddWithValue("@Saldo", 0)
                        cmd.Parameters.AddWithValue("@Pago_con", 0)
                        cmd.Parameters.AddWithValue("@Porcentaje_IGV", 0)
                        cmd.Parameters.AddWithValue("@Id_caja", LOGIN.txtidcaja.Text)
                        cmd.Parameters.AddWithValue("@Referencia_tarjeta", "NULO")

                        cmd.ExecuteNonQuery()
                        txtanuncio.ForeColor = Color.RoyalBlue
                        Cerrar()
                        Listarventas()
                        txtidventa.Text = datalistadoventas_nuevasok.SelectedCells.Item(1).Value
                        txtventagenerada.Text = "VENTA GENERADA"
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                If txtventagenerada.Text = "VENTA GENERADA" Then

                    insertar_detalle_venta()






                    Listarproductosagregados()
                    btn_insertar.Visible = False
                    BTN_SEGUIR_AGREGANDO.Visible = True

                    txtbuscar.Text = ""
                    'txtbuscar.Focus()

                    Panel10.Visible = False
                    panel_granel.Visible = False
                    lblAgranellAumentar.Text = "UNIDAD"
                End If

            Catch ex As Exception
            End Try
            Try

            Catch ex As Exception
            End Try

            '*
            '    *
            '    *



        Catch ex As Exception

        End Try
        DATALISTADO_PRODUCTOS_OKA.Visible = False
    End Sub

    Private Sub ToolStripMenuItem7_Click_1(sender As Object, e As EventArgs)



    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Timer_MOSTRAR_PRODUCTOS_AGREGADOS_Tick(sender As Object, e As EventArgs) Handles Timer_MOSTRAR_PRODUCTOS_AGREGADOS.Tick

        Listarproductosagregados()
        Timer_MOSTRAR_PRODUCTOS_AGREGADOS.Stop()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BTNVENTASENESPERA_Click(sender As Object, e As EventArgs)



    End Sub
    Sub RENOVAR_VENTA()
        contar_tablas_ventas()
        If lblcontadortablaventas.Text = 0 And txtventagenerada.Text = "VENTA GENERADA" Then
            Listarventas()
            Try
                txtidventa.Text = datalistadoventas_nuevasok.SelectedCells.Item(1).Value
            Catch ex As Exception
            End Try
            eliminar_venta_al_agregar_productos()
            txtventagenerada.Text = "VENTA NUEVA"
        End If
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)

        RENOVAR_VENTA()

        ocultar_objetos_emergentes()


        AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS.ShowDialog()

    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click
        ocultar_objetos_emergentes()
    End Sub

    Private Sub TimerVARIASCANTIDADES_Tick(sender As Object, e As EventArgs) Handles TimerVARIASCANTIDADES.Tick
        'TimerVARIASCANTIDADES.Stop()
        'Try
        '    txtprecio_unitario.Text = AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS.DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(9).Value

        '    DATALISTADO_PRODUCTOS_OKA.Visible = True
        '    txtpantalla.Text = AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS.txtcantidad.Text
        '    txtprecio_unitario.Text = AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS.lblprecioUnitario.Text

        '    'txtprecio_unitario.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(9).Value


        '    txtbuscar.Text = AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS.txtbuscar.Text
        '    Try
        '        If txtbuscar.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(2).Value Then
        '            If txtventagenerada.Text = "VENTA NUEVA" Then
        '                txtnumerodecomprobante.Text = txtserie.Text & "-" & txtnumeroinicio.Text & txtnumerofin.Text
        '                If rcontado.Checked = True Then txttipo.Text = "CONTADO"
        '                If rcredito.Checked = True Then txttipo.Text = "CREDITO"
        '                If rcontado.Checked = True Then txtestado.Text = "PAGADO"
        '                If rcredito.Checked = True Then txtestado.Text = "DEUDA"
        '                Try
        '                    Dim cmd As New SqlCommand
        '                    abrir()
        '                    cmd = New SqlCommand("insertar_venta", conexion)
        '                    cmd.CommandType = 4
        '                    cmd.Parameters.AddWithValue("@idcliente", 0)
        '                    cmd.Parameters.AddWithValue("@ACCION", TXTACCION.Text)
        '                    cmd.Parameters.AddWithValue("@fecha_venta", txtfechadeventa.Value)
        '                    cmd.Parameters.AddWithValue("@Fecha_de_pago", txtfecha_de_pago.Value)
        '                    cmd.Parameters.AddWithValue("@Comprobante", "Ticket " & txtidventa.Text)
        '                    cmd.Parameters.AddWithValue("@Porcentaje_IGV", txtporcentaje.Text)
        '                    cmd.Parameters.AddWithValue("@nume_documento", txtnumerodecomprobante.Text)
        '                    cmd.Parameters.AddWithValue("@montototal", 0)
        '                    cmd.Parameters.AddWithValue("@IGV", 0)
        '                    cmd.Parameters.AddWithValue("@id_usuario", lblidusuario.Text)
        '                    cmd.Parameters.AddWithValue("@estado", "EN ESPERA")
        '                    cmd.Parameters.AddWithValue("@Tipo_de_pago", "-")
        '                    cmd.Parameters.AddWithValue("@Saldo", 0)
        '                    cmd.Parameters.AddWithValue("@Pago_con", 0)
        '                    cmd.Parameters.AddWithValue("@Id_caja", LOGIN.txtidcaja.Text)
        '                    cmd.ExecuteNonQuery()
        '                    txtanuncio.ForeColor = Color.RoyalBlue
        '                    Cerrar()
        '                    Listarventas()
        '                    txtidventa.Text = datalistadoventas_nuevasok.SelectedCells.Item(1).Value
        '                    txtventagenerada.Text = "VENTA GENERADA"
        '                Catch ex As Exception
        '                    MsgBox(ex.Message)

        '                End Try
        '            End If
        '            If txtventagenerada.Text = "VENTA GENERADA" Then

        '                insertar_detalle_venta()
        '                Listarproductosagregados()
        '                btn_insertar.Visible = False
        '                BTN_SEGUIR_AGREGANDO.Visible = True

        '                txtbuscar.Text = ""
        '                'txtbuscar.Focus()

        '                Panel10.Visible = False
        '                panel_granel.Visible = False
        '            End If
        '        End If
        '    Catch ex As Exception
        '    End Try
        '    Try
        '        If DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(6).Value <> txtbuscar.Text Then
        '        End If
        '    Catch ex As Exception
        '    End Try


        'Catch ex As Exception

        'End Try
        TimerVARIASCANTIDADES.Stop()

        Try


            'TXTSEVENDEPOR.Text = AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS.DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(11).Value
            'txtidproducto.Text = AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS.DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(1).Value
            'lblStock_de_Productos.Text = AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS.DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(6).Value
            'lblUsaInventarios.Text = AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS.DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(5).Value
            'lbldescripcion.Text = AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS.DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(17).Value
            'lblcodigo.Text = AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS.DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(10).Value
            'lblcosto.Text = AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS.DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(7).Value
            'txtpantalla.Text = 1
            'txtprecio_unitario.Text = AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS.txtprecio_unitario.Text
            Try
                DATALISTADO_PRODUCTOS_OKA.Visible = False
                If txtventagenerada.Text = "VENTA NUEVA" Then
                    txtnumerodecomprobante.Text = txtserie.Text & "-" & txtnumeroinicio.Text & txtnumerofin.Text
                    If rcontado.Checked = True Then txttipo.Text = "CONTADO"
                    If rcredito.Checked = True Then txttipo.Text = "CREDITO"
                    If rcontado.Checked = True Then txtestado.Text = "PAGADO"
                    If rcredito.Checked = True Then txtestado.Text = "DEUDA"
                    Try
                        Dim cmd As New SqlCommand
                        abrir()
                        cmd = New SqlCommand("insertar_venta", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@idcliente", 0)
                        cmd.Parameters.AddWithValue("@ACCION", TXTACCION.Text)
                        cmd.Parameters.AddWithValue("@fecha_venta", Now())
                        cmd.Parameters.AddWithValue("@Fecha_de_pago", txtfecha_de_pago.Value)
                        cmd.Parameters.AddWithValue("@Comprobante", "Ticket " & txtidventa.Text)
                        cmd.Parameters.AddWithValue("@Porcentaje_IGV", txtporcentaje.Text)
                        cmd.Parameters.AddWithValue("@nume_documento", txtnumerodecomprobante.Text)
                        cmd.Parameters.AddWithValue("@montototal", 0)
                        cmd.Parameters.AddWithValue("@IGV", 0)
                        cmd.Parameters.AddWithValue("@id_usuario", lblidusuario.Text)
                        cmd.Parameters.AddWithValue("@estado", "EN ESPERA")
                        cmd.Parameters.AddWithValue("@Tipo_de_pago", "-")
                        cmd.Parameters.AddWithValue("@Saldo", 0)
                        cmd.Parameters.AddWithValue("@Pago_con", 0)
                        cmd.Parameters.AddWithValue("@Id_caja", LOGIN.txtidcaja.Text)
                        cmd.Parameters.AddWithValue("@Referencia_tarjeta", "NULO")

                        cmd.ExecuteNonQuery()
                        txtanuncio.ForeColor = Color.RoyalBlue
                        Cerrar()
                        Listarventas()
                        txtidventa.Text = datalistadoventas_nuevasok.SelectedCells.Item(1).Value
                        txtventagenerada.Text = "VENTA GENERADA"
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                If txtventagenerada.Text = "VENTA GENERADA" Then

                    insertar_detalle_venta()
                    Listarproductosagregados()
                    btn_insertar.Visible = False
                    BTN_SEGUIR_AGREGANDO.Visible = True

                    txtbuscar.Text = ""
                    'txtbuscar.Focus()

                    Panel10.Visible = False
                    panel_granel.Visible = False
                End If

            Catch ex As Exception
            End Try

        Catch ex As Exception

        End Try
    End Sub
    Private Sub datalistadomateriales_CellMouseEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadomateriales.CellMouseEnter
        'If e.RowIndex >= 0 Then
        '    Me.datalistadomateriales.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.WhiteSmoke
        'End If

    End Sub

    Private Sub datalistadomateriales_CellMouseLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadomateriales.CellMouseLeave
        'If e.RowIndex >= 0 Then
        '    Me.datalistadomateriales.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        'End If
    End Sub



    Private Sub logo_institucionfalse_Click(sender As Object, e As EventArgs)
        ImagenEmpresaTRUE.Visible = True
        Panelcuenta.Visible = False
        PanelHERRAMIENTAS.Visible = False
        PanelCONTENEDOR_CUENTA_HERRAMIENTAS.Visible = False
    End Sub

    Private Sub logo_instituciontrue_Click(sender As Object, e As EventArgs) Handles ImagenEmpresaTRUE.Click
        Panel_Cambio_de_usuario.Controls.Clear()
        lbleditarLogo.Visible = False



        TXTeditarEMPRESA.Visible = False
        txtusuarioEdit.Visible = False
        txtcajaEdit.Visible = False
        TXTMONEDAEdit.Visible = False

        Logo_institucion.Image = ImagenEmpresaTRUE.Image
        Panelcuenta.Visible = True
        Panelcuenta.Dock = DockStyle.Top
        PanelHERRAMIENTAS.Visible = False
        TGUARDAR.Visible = False
        TEDITAR.Visible = True
        TCANCELAR.Visible = False
        PanelCONTENEDOR_CUENTA_HERRAMIENTAS.BringToFront()
        PanelCONTENEDOR_CUENTA_HERRAMIENTAS.Visible = True
        PanelNOTIFICACIONES.Visible = False

        'mostrar_empresas()

        'Try
        '    txtimpuesto.Text = dtempresaok.SelectedCells.Item(7).Value
        '    txtporcentaje.Text = dtempresaok.SelectedCells.Item(6).Value
        '    LBLtrabajasConimpuestos.Text = dtempresaok.SelectedCells.Item(9).Value
        'Catch ex As Exception

        'End Try
        'Try
        '    If LBLtrabajasConimpuestos.Text = "NO" Then
        '        Apagado.Visible = True
        '        Apagado.BringToFront()
        '        txtimpuesto.Visible = False
        '        txtporcentaje.Visible = False
        '        MenuEDITORdeIgv.Visible = False

        '    Else
        '        Encendido.Visible = True
        '        Encendido.BringToFront()
        '        txtimpuesto.Visible = True
        '        txtporcentaje.Visible = True
        '        MenuEDITORdeIgv.Visible = True
        '        TEDITARigv.Visible = True
        '        TconfirmaredicionIgv.Visible = False
        '        TcancelarEdiciondeIgv.Visible = False
        '        txtporcentaje.Enabled = False
        '        txtimpuesto.Enabled = False

        '    End If
        'Catch ex As Exception

        'End Try
        dibujarUSUARIOS()
        'MASCARA1.Show()
        'Cambio_de_usuario.ShowDialog()


    End Sub

    Private Sub ToolStripButton22_Click(sender As Object, e As EventArgs)


        'MASCARA3.Show()


    End Sub


    Private Sub TimerLABEL_STOCK_Tick(sender As Object, e As EventArgs) Handles TimerLABEL_STOCK.Tick

        If ProgressBarETIQUETA_STOCK.Value < 100 Then

            ProgressBarETIQUETA_STOCK.Value = ProgressBarETIQUETA_STOCK.Value + 10
            LABEL_STOCK.Visible = True
            LABEL_STOCK.Dock = DockStyle.Fill
        Else
            LABEL_STOCK.Visible = False
            LABEL_STOCK.Dock = DockStyle.None
            ProgressBarETIQUETA_STOCK.Value = 0

            TimerLABEL_STOCK.Stop()

        End If


    End Sub

    Private Sub TEDITAR_Click(sender As Object, e As EventArgs) Handles TEDITAR.Click
        TGUARDAR.Visible = True
        TEDITAR.Visible = False
        TXTeditarEMPRESA.Visible = True
        txtcajaEdit.Visible = True
        txtusuarioEdit.Visible = True
        TXTMONEDAEdit.Visible = True


        TCANCELAR.Visible = True
        TXTeditarEMPRESA.Text = LBLempresa.Text
        TXTMONEDAEdit.Text = txtmoneda.Text
        txtusuarioEdit.Text = lblnombreUsuario.Text
        txtcajaEdit.Text = lblcaja.Text
    End Sub

    Private Sub TGUARDAR_Click(sender As Object, e As EventArgs) Handles TGUARDAR.Click
        If TXTeditarEMPRESA.Text <> "" Then
            Try
                Dim cmd As New SqlCommand

                abrir()
                cmd = New SqlCommand("editar_nombre_de_EMPRESA", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@nombre", TXTeditarEMPRESA.Text)
                cmd.Parameters.AddWithValue("@moneda", TXTMONEDAEdit.Text)
                cmd.ExecuteNonQuery()
                Cerrar()

                abrir()
                cmd = New SqlCommand("editar_caja", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@idcaja", lblidcaja.Text)
                cmd.Parameters.AddWithValue("@descripcion", txtcajaEdit.Text)
                cmd.ExecuteNonQuery()
                Cerrar()

                abrir()
                cmd = New SqlCommand("editar_usuario_solo_nombre", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@idusuario", lblidusuario.Text)
                cmd.Parameters.AddWithValue("@nombres", txtusuarioEdit.Text)
                cmd.ExecuteNonQuery()
                Cerrar()

            Catch ex As Exception

            End Try

            TXTeditarEMPRESA.Visible = False
            txtcajaEdit.Visible = False
            txtusuarioEdit.Visible = False
            TXTMONEDAEdit.Visible = False


            LBLempresa.Text = TXTeditarEMPRESA.Text

            LBLempresa.Text = TXTeditarEMPRESA.Text
            txtmoneda.Text = TXTMONEDAEdit.Text
            lblnombreUsuario.Text = txtusuarioEdit.Text
            lblcaja.Text = txtcajaEdit.Text

            TEDITAR.Visible = True
            TGUARDAR.Visible = False
            TCANCELAR.Visible = False
        End If
    End Sub

    Private Sub TCANCELAR_Click(sender As Object, e As EventArgs) Handles TCANCELAR.Click
        TXTeditarEMPRESA.Visible = False
        txtcajaEdit.Visible = False
        txtusuarioEdit.Visible = False
        TXTMONEDAEdit.Visible = False
        TEDITAR.Visible = True
        TCANCELAR.Visible = False
        TGUARDAR.Visible = False
    End Sub

    Private Sub lbleditarLogo_Click(sender As Object, e As EventArgs) Handles lbleditarLogo.Click
        If dlg.ShowDialog() = DialogResult.OK Then
            Logo_institucion.BackgroundImage = Nothing
            Logo_institucion.Image = New Bitmap(dlg.FileName)
            Logo_institucion.SizeMode = PictureBoxSizeMode.Zoom
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("editar_logo_de_EMPRESA", conexion)
            cmd.CommandType = 4


            Dim ms As New IO.MemoryStream()
            If Not Logo_institucion.Image Is Nothing Then
                Logo_institucion.Image.Save(ms, Logo_institucion.Image.RawFormat)
            Else

            End If
            cmd.Parameters.AddWithValue("@logo", ms.GetBuffer)

            cmd.ExecuteNonQuery()

            Cerrar()
            Try
                mostrar_empresas()



            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Logo_institucion_MouseMove(sender As Object, e As MouseEventArgs) Handles Logo_institucion.MouseMove
        lbleditarLogo.Visible = True

    End Sub
    Private Sub Panelcuenta_MouseMove(sender As Object, e As MouseEventArgs) Handles Panelcuenta.MouseMove
        lbleditarLogo.Visible = False
    End Sub



    Private Sub ToolStripMenuItem22_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem22.Click
        PanelCONTENEDOR_CUENTA_HERRAMIENTAS.Visible = True
        'PanelCONTENEDOR_CUENTA_HERRAMIENTAS.BringToFront()
        Panelcuenta.Visible = False
        PanelHERRAMIENTAS.Visible = True
        PanelHERRAMIENTAS.Dock = DockStyle.Top
        PanelNOTIFICACIONES.Visible = False

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        cobro_a_clientes.txtclientesolicitante.Text = "Buscar beneficiario"
        ocultar_objetos_emergentes()
        cobro_a_clientes.ShowDialog()

    End Sub
    Sub escribir_nombre_a_venta_en_espera()
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("Poner_nombre_a_venta_en_espera", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@id_venta", txtidventa.Text)
            If txtnombre.Text = "" Then
                cmd.Parameters.AddWithValue("@nombre", "Ticket " & txtidventa.Text)
            ElseIf txtnombre.Text <> "" Then
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)

            End If

            cmd.ExecuteNonQuery()

            Cerrar()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        ocultar_objetos_emergentes()

        escribir_nombre_a_venta_en_espera()
        contar_ventas_en_espera()
        Timer3.Start()
        PanelVENTAENESPERANOMBRE.Visible = False
        PanelVENTAENESPERANOMBRE.Dock = DockStyle.None
    End Sub


    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        ocultar_objetos_emergentes()
        txtnombre.Text = "Ticket " & txtidventa.Text

        escribir_nombre_a_venta_en_espera()
        Timer3.Start()
        contar_ventas_en_espera()
        PanelVENTAENESPERANOMBRE.Visible = False
        PanelVENTAENESPERANOMBRE.Dock = DockStyle.None
    End Sub

    Private Sub ToolStripMenuItem9_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        ocultar_objetos_emergentes()

        PanelVENTAENESPERANOMBRE.Visible = False
        PanelVENTAENESPERANOMBRE.Dock = DockStyle.None
    End Sub

    Private Sub BTNELIMINARVENTA_Click(sender As Object, e As EventArgs)

    End Sub
    Sub dibujarUSUARIOS()
        Try

            Cerrar()
            abrir()
            Dim query As String = "select * from USUARIO2 WHERE Estado ='ACTIVO'"
            Dim cmd As New SqlCommand(query, conexion)
            Dim rdr As SqlDataReader = cmd.ExecuteReader()

            While rdr.Read()
                ra = New Random()
                Dim b As New Label()
                Dim p1 As New Panel
                Dim P2 As New Panel
                Dim I1 As New PictureBox
                Dim P3 As New Panel
                Dim L As New Label
                b.Text = rdr("Login").ToString()
                b.Name = rdr("Login").ToString()
                b.Tag = rdr("Login").ToString()

                b.Size = New System.Drawing.Size(375, 35)
                b.Font = New System.Drawing.Font(10, 10)
                b.BackColor = BackColor
                b.FlatStyle = FlatStyle.Flat
                b.BackColor = Color.White
                b.ForeColor = Color.Black
                b.Dock = DockStyle.Top
                b.TextAlign = ContentAlignment.MiddleLeft
                b.Cursor = Cursors.Hand

                L.Text = "(" & rdr("Nombre_y_Apelllidos").ToString()
                L.Name = rdr("Login").ToString()
                L.Tag = rdr("Login").ToString()
                L.Size = New System.Drawing.Size(375, 18)
                L.Font = New System.Drawing.Font(10, 10)
                L.BackColor = BackColor
                L.FlatStyle = FlatStyle.Flat
                L.BackColor = Color.White
                L.ForeColor = Color.Gray
                L.Dock = DockStyle.Fill
                L.TextAlign = ContentAlignment.MiddleLeft
                L.Cursor = Cursors.Hand

                p1.Size = New System.Drawing.Size(375, 67)
                p1.BorderStyle = BorderStyle.None
                p1.Dock = DockStyle.Top
                p1.BackColor = Color.White
                P2.Size = New System.Drawing.Size(287, 22)
                P2.Dock = DockStyle.Top
                P2.BackColor = Color.White

                P3.Size = New System.Drawing.Size(243, 2)
                P3.Dock = DockStyle.Bottom
                P3.BackColor = Color.WhiteSmoke

                I1.Size = New System.Drawing.Size(90, 69)
                I1.Dock = DockStyle.Left
                I1.BackgroundImage = Nothing
                Dim bi() As Byte = rdr("Icono")
                Dim ms As New IO.MemoryStream(bi)
                I1.Image = Image.FromStream(ms)
                I1.SizeMode = PictureBoxSizeMode.Zoom
                I1.Tag = rdr("Login").ToString()
                I1.Cursor = Cursors.Hand

                p1.Controls.Add(b)
                p1.Controls.Add(I1)
                p1.Controls.Add(P2)
                p1.Controls.Add(P3)
                P2.Controls.Add(L)
                P2.BringToFront()
                b.SendToBack()
                I1.SendToBack()
                L.BringToFront()
                P3.SendToBack()
                Panel_Cambio_de_usuario.Controls.Add(p1)
                AddHandler b.Click, AddressOf miEventocambioUsuarioB
                AddHandler L.Click, AddressOf miEventocambioUsuarioL
                AddHandler I1.Click, AddressOf miEventocambioUsuarioImagen
            End While
            Cerrar()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub miEventocambioUsuarioL(ByVal sender As System.Object, ByVal e As EventArgs)

        Try
            lbllogin_cambio_de_usuario.Text = DirectCast(sender, Label).Name
            ocultar_objetos_emergentes()
            'lblidusuario.Text = DirectCast(sender, Label).Name
            MASCARA1.Show()
            MASCARA1.FormBorderStyle = FormBorderStyle.None
            Cambio_de_usuario.ShowDialog()
            ocultar_objetos_emergentes()

        Catch ex As Exception

        End Try

    End Sub
    Private Sub miEventocambioUsuarioB(ByVal sender As System.Object, ByVal e As EventArgs)

        Try
            lbllogin_cambio_de_usuario.Text = DirectCast(sender, Label).Name
            ocultar_objetos_emergentes()
            'lblidusuario.Text = DirectCast(sender, Label).Name
            MASCARA1.Show()
            MASCARA1.FormBorderStyle = FormBorderStyle.None

            Cambio_de_usuario.ShowDialog()


        Catch ex As Exception

        End Try

    End Sub
    Private Sub miEventocambioUsuarioImagen(ByVal sender As System.Object, ByVal e As EventArgs)

        Try
            lbllogin_cambio_de_usuario.Text = DirectCast(sender, PictureBox).Tag
            ocultar_objetos_emergentes()
            'lblidusuario.Text = DirectCast(sender, Label).Name
            MASCARA1.Show()
            MASCARA1.FormBorderStyle = FormBorderStyle.None

            Cambio_de_usuario.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub
    Sub dibujarVENTAS_EN_ESPERA()
        Cerrar()
        abrir()
        Dim query As String = "contar_ventas_en_espera"
        Dim cmd As New SqlCommand(query, conexion)
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        Dim NBotones As Integer = 3
        While rdr.Read()
            Dim b As New Label()
            Dim p1 As New Panel
            Dim P2 As New Panel
            Dim I1 As New PictureBox
            Dim I2 As New PictureBox
            Dim L As New Label
            For I As Integer = 0 To NBotones
                b.Text = "Gestiona la Venta en ESPERA (" & rdr("Comprobante").ToString() & ")"
                b.Name = rdr("Comprobante").ToString()
                b.Size = New System.Drawing.Size(430, 35)
                b.Font = New System.Drawing.Font(10, 10)
                b.BackColor = BackColor
                b.FlatStyle = FlatStyle.Flat
                b.BackColor = Color.White
                b.ForeColor = Color.Black
                b.Dock = DockStyle.Top
                b.TextAlign = ContentAlignment.MiddleLeft
                L.Text = "(" & rdr("id_producto").ToString() & ") Productos agregados el " & rdr("fecha_venta").ToString()
                L.Name = rdr("Comprobante").ToString()
                L.Size = New System.Drawing.Size(430, 18)
                L.Font = New System.Drawing.Font(10, 10)
                L.BackColor = BackColor
                L.FlatStyle = FlatStyle.Flat
                L.BackColor = Color.White
                L.ForeColor = Color.Gray
                L.Dock = DockStyle.Fill
                L.TextAlign = ContentAlignment.MiddleLeft
                I2.BackgroundImage = My.Resources.carrito_de_tienda_online
                I2.BackgroundImageLayout = ImageLayout.Zoom
                I2.Size = New System.Drawing.Size(18, 18)
                I2.Dock = DockStyle.Left

                p1.Size = New System.Drawing.Size(430, 67)
                p1.BorderStyle = BorderStyle.FixedSingle
                p1.Dock = DockStyle.Top
                p1.BackColor = Color.White

                P2.Size = New System.Drawing.Size(287, 22)
                P2.Dock = DockStyle.Top
                P2.BackColor = Color.White


                I1.BackgroundImage = My.Resources.etiqueta
                I1.BackgroundImageLayout = ImageLayout.Zoom
                I1.Size = New System.Drawing.Size(90, 69)
                I1.Dock = DockStyle.Left
                I1.BackColor = Color.White
            Next
            p1.Controls.Add(b)
            p1.Controls.Add(I1)
            p1.Controls.Add(P2)
            P2.Controls.Add(I2)
            P2.Controls.Add(L)
            P2.BringToFront()
            b.SendToBack()
            I1.SendToBack()
            L.BringToFront()
            PanelCONTENEDORDENOTIFICACIONES.Controls.Add(p1)
            AddHandler b.Click, AddressOf miEventoVENTASESPERA
            AddHandler L.Click, AddressOf miEventoVENTASESPERA
            AddHandler I1.Click, AddressOf miEventoVENTASESPERA
            AddHandler I2.Click, AddressOf miEventoVENTASESPERA
        End While
        Cerrar()
    End Sub
    Sub dibujarCorreoBase_sin_conexion()



        Dim b As New Label()
        Dim p1 As New Panel
        Dim P2 As New Panel
        Dim I1 As New PictureBox
        Dim I2 As New PictureBox
        Dim L As New Label

        b.Text = "Sincroniza tu correo para recibir Reportes en tu Bandeja de Correo"

        b.Size = New System.Drawing.Size(430, 35)
        b.Font = New System.Drawing.Font(10, 10)
        b.BackColor = BackColor
        b.FlatStyle = FlatStyle.Flat
        b.BackColor = Color.White
        b.ForeColor = Color.Black
        b.Dock = DockStyle.Top
        b.TextAlign = ContentAlignment.MiddleLeft

        L.Size = New System.Drawing.Size(430, 18)
        L.Text = "Recibiras reportes a tu Correo Electronico"

        L.Font = New System.Drawing.Font(10, 10)
        L.BackColor = BackColor
        L.FlatStyle = FlatStyle.Flat
        L.BackColor = Color.White
        L.ForeColor = Color.Gray
        L.Dock = DockStyle.Fill
        L.TextAlign = ContentAlignment.MiddleLeft
        I2.BackgroundImage = My.Resources.nube_secundaria
        I2.BackgroundImageLayout = ImageLayout.Zoom
        I2.Size = New System.Drawing.Size(18, 18)
        I2.Dock = DockStyle.Left

        p1.Size = New System.Drawing.Size(430, 67)
        p1.BorderStyle = BorderStyle.FixedSingle
        p1.Dock = DockStyle.Top
        p1.BackColor = Color.White

        P2.Size = New System.Drawing.Size(287, 22)
        P2.Dock = DockStyle.Top
        P2.BackColor = Color.White


        I1.BackgroundImage = My.Resources.nube_sincroizacio
        I1.BackgroundImageLayout = ImageLayout.Zoom
        I1.Size = New System.Drawing.Size(90, 69)
        I1.Dock = DockStyle.Left
        I1.BackColor = Color.White

        p1.Controls.Add(b)
        p1.Controls.Add(I1)
        p1.Controls.Add(P2)
        P2.Controls.Add(I2)
        P2.Controls.Add(L)
        P2.BringToFront()
        b.SendToBack()
        I1.SendToBack()
        L.BringToFront()
        PanelCONTENEDORDENOTIFICACIONES.Controls.Add(p1)
        AddHandler b.Click, AddressOf miEventoCorreoLabel
        AddHandler L.Click, AddressOf miEventoCorreoLabel
        AddHandler I1.Click, AddressOf miEventoCorreoLabel
        AddHandler I2.Click, AddressOf miEventoCorreoLabel

    End Sub
    Private Sub miEventoCorreoLabel(ByVal sender As System.Object, ByVal e As EventArgs)
        Try
            Configurar_envio_a_correo.ShowDialog()

        Catch ex As Exception
        End Try
    End Sub
    Sub dibujarVENTAS_EN_ESPERA_solo_para_vendedores()
        Cerrar()
        abrir()
        Dim query As String = "mostrar_ventas_en_espera_solo_para_vendedores"

        Dim cmd As New SqlCommand(query, conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@Id_caja", lblidcaja.Text)
        Dim rdr As SqlDataReader = cmd.ExecuteReader()

        While rdr.Read()
            Dim b As New Label()
            Dim p1 As New Panel
            Dim P2 As New Panel
            Dim I1 As New PictureBox
            Dim I2 As New PictureBox
            Dim L As New Label

            b.Text = "Gestiona la Venta en ESPERA (" & rdr("Comprobante").ToString() & ")"
            b.Name = rdr("Comprobante").ToString()
            b.Size = New System.Drawing.Size(430, 35)
            b.Font = New System.Drawing.Font(10, 10)
            b.BackColor = BackColor
            b.FlatStyle = FlatStyle.Flat
            b.BackColor = Color.White
            b.ForeColor = Color.Black
            b.Dock = DockStyle.Top
            b.TextAlign = ContentAlignment.MiddleLeft
            L.Text = "(" & rdr("id_producto").ToString() & ") Productos agregados el " & rdr("fecha_venta").ToString()
            L.Name = rdr("Comprobante").ToString()
            L.Size = New System.Drawing.Size(430, 18)
            L.Font = New System.Drawing.Font(10, 10)
            L.BackColor = BackColor
            L.FlatStyle = FlatStyle.Flat
            L.BackColor = Color.White
            L.ForeColor = Color.Gray
            L.Dock = DockStyle.Fill
            L.TextAlign = ContentAlignment.MiddleLeft
            I2.BackgroundImage = My.Resources.carrito_de_tienda_online
            I2.BackgroundImageLayout = ImageLayout.Zoom
            I2.Size = New System.Drawing.Size(18, 18)
            I2.Dock = DockStyle.Left

            p1.Size = New System.Drawing.Size(430, 67)
            p1.BorderStyle = BorderStyle.FixedSingle
            p1.Dock = DockStyle.Top
            p1.BackColor = Color.White

            P2.Size = New System.Drawing.Size(287, 22)
            P2.Dock = DockStyle.Top
            P2.BackColor = Color.White


            I1.BackgroundImage = My.Resources.etiqueta
            I1.BackgroundImageLayout = ImageLayout.Zoom
            I1.Size = New System.Drawing.Size(90, 69)
            I1.Dock = DockStyle.Left
            I1.BackColor = Color.White
            p1.Controls.Add(b)
            p1.Controls.Add(I1)
            p1.Controls.Add(P2)
            P2.Controls.Add(I2)
            P2.Controls.Add(L)
            P2.BringToFront()
            b.SendToBack()
            I1.SendToBack()
            L.BringToFront()
            PanelCONTENEDORDENOTIFICACIONES.Controls.Add(p1)
            AddHandler b.Click, AddressOf miEventoVENTASESPERA
            AddHandler L.Click, AddressOf miEventoVENTASESPERA
            AddHandler I1.Click, AddressOf miEventoVENTASESPERA
            AddHandler I2.Click, AddressOf miEventoVENTASESPERA
        End While
        Cerrar()
    End Sub
    Sub dibujarCOBROS()
        abrir()
        Dim query As String = "NOTIFICADOR_COBROS"
        Dim cmd As New SqlCommand(query, conexion)
        Dim rdr As SqlDataReader = cmd.ExecuteReader()

        While rdr.Read()
            Dim b As New Label()
            Dim p1 As New Panel
            Dim P2 As New Panel
            Dim I1 As New PictureBox
            Dim I2 As New PictureBox
            Dim L As New Label

            b.Text = rdr("Nombre").ToString() & " Te debe " & "(" & rdr("Saldo").ToString() & ")"
            b.Name = rdr("Nombre").ToString()
            b.Size = New System.Drawing.Size(430, 35)
            b.Font = New System.Drawing.Font(10, 10)
            b.BackColor = BackColor
            b.FlatStyle = FlatStyle.Flat
            b.BackColor = Color.White
            b.ForeColor = Color.Black
            b.Dock = DockStyle.Top
            b.TextAlign = ContentAlignment.MiddleLeft
            b.Cursor = Cursors.Hand
            L.Text = "(" & rdr("Saldo").ToString() & ") Saldo por Cobrar"
            L.Name = rdr("Nombre").ToString()
            L.Size = New System.Drawing.Size(430, 18)
            L.Font = New System.Drawing.Font(10, 10)
            L.BackColor = BackColor
            L.FlatStyle = FlatStyle.Flat
            L.BackColor = Color.White
            L.ForeColor = Color.Gray
            L.Dock = DockStyle.Fill
            L.TextAlign = ContentAlignment.MiddleLeft
            L.Cursor = Cursors.Hand
            I2.BackgroundImage = My.Resources.monedas
            I2.BackgroundImageLayout = ImageLayout.Zoom
            I2.Size = New System.Drawing.Size(18, 18)
            I2.Dock = DockStyle.Left
            p1.Size = New System.Drawing.Size(430, 67)
            p1.BorderStyle = BorderStyle.FixedSingle
            p1.Dock = DockStyle.Top
            p1.BackColor = Color.White
            P2.Size = New System.Drawing.Size(287, 22)
            P2.Dock = DockStyle.Top
            P2.BackColor = Color.White
            I1.BackgroundImage = My.Resources.COBROSSSS
            I1.BackgroundImageLayout = ImageLayout.Zoom
            I1.Size = New System.Drawing.Size(90, 69)
            I1.Dock = DockStyle.Left
            I1.BackColor = Color.White

            p1.Controls.Add(b)
            p1.Controls.Add(I1)
            p1.Controls.Add(P2)
            P2.Controls.Add(I2)
            P2.Controls.Add(L)
            P2.BringToFront()
            b.SendToBack()
            I1.SendToBack()
            L.BringToFront()
            PanelCONTENEDORDENOTIFICACIONES.Controls.Add(p1)
            AddHandler b.Click, AddressOf miEventoCOBROS
            AddHandler L.Click, AddressOf miEventoCOBROS
            AddHandler I1.Click, AddressOf miEventoCOBROS
            AddHandler I2.Click, AddressOf miEventoCOBROS
        End While
        Cerrar()
    End Sub
    Sub dibujarPOR_PAGAR()
        Try
            abrir()
            Dim query As String = "NOTIFICADOR_PAGOS"
            Dim cmd As New SqlCommand(query, conexion)
            Dim rdr As SqlDataReader = cmd.ExecuteReader()



            Dim NBotones As Integer = 3
            While rdr.Read()
                Dim b As New Label()
                Dim p1 As New Panel
                Dim P2 As New Panel
                Dim I1 As New PictureBox
                Dim I2 As New PictureBox
                Dim L As New Label


                For I As Integer = 0 To NBotones

                    b.Text = "Recuerda Pagar a " & rdr("Nombre").ToString() & " los " & rdr("Saldo").ToString() & " que le Debes"
                    b.Name = rdr("Nombre").ToString()
                    b.Size = New System.Drawing.Size(430, 35)
                    b.Font = New System.Drawing.Font(10, 10)
                    b.BackColor = BackColor
                    b.FlatStyle = FlatStyle.Flat
                    b.BackColor = Color.White
                    b.ForeColor = Color.Black
                    b.Dock = DockStyle.Top
                    b.TextAlign = ContentAlignment.MiddleLeft


                    L.Text = "(" & rdr("Saldo").ToString() & ") Saldo por Pagar"
                    L.Name = rdr("Nombre").ToString()
                    L.Size = New System.Drawing.Size(430, 18)
                    L.Font = New System.Drawing.Font(10, 10)
                    L.BackColor = BackColor
                    L.FlatStyle = FlatStyle.Flat
                    L.BackColor = Color.White
                    L.ForeColor = Color.Gray
                    L.Dock = DockStyle.Fill
                    L.TextAlign = ContentAlignment.MiddleLeft



                    I2.BackgroundImage = My.Resources.advertencia
                    I2.BackgroundImageLayout = ImageLayout.Zoom
                    I2.Size = New System.Drawing.Size(18, 18)
                    I2.Dock = DockStyle.Left

                    p1.Size = New System.Drawing.Size(430, 67)
                    p1.BorderStyle = BorderStyle.FixedSingle
                    p1.Dock = DockStyle.Top
                    p1.BackColor = Color.White

                    P2.Size = New System.Drawing.Size(287, 22)
                    P2.Dock = DockStyle.Top
                    P2.BackColor = Color.White


                    I1.Image = My.Resources.megafono
                    I1.SizeMode = ImageLayout.Zoom
                    I1.Size = New System.Drawing.Size(90, 69)
                    I1.Dock = DockStyle.Left
                    I1.BackColor = Color.White



                Next
                p1.Controls.Add(b)
                p1.Controls.Add(I1)
                p1.Controls.Add(P2)
                P2.Controls.Add(I2)
                P2.Controls.Add(L)

                P2.BringToFront()
                b.SendToBack()
                I1.SendToBack()
                L.BringToFront()


                PanelCONTENEDORDENOTIFICACIONES.Controls.Add(p1)
                AddHandler b.Click, AddressOf miEventoPAGOS
                AddHandler L.Click, AddressOf miEventoPAGOS
                AddHandler I1.Click, AddressOf miEventoPAGOS
                AddHandler I2.Click, AddressOf miEventoPAGOS
            End While

            Cerrar()
        Catch ex As Exception

        End Try

    End Sub
    Sub dibujarPRODUCTOS_vencidos()
        Try
            abrir()
            Dim query As String = "contar_productos_vencidos"
            Dim cmd As New SqlCommand(query, conexion)
            Dim rdr As SqlDataReader = cmd.ExecuteReader()

            While rdr.Read()
                Dim b As New Label()
                Dim p1 As New Panel
                Dim P2 As New Panel
                Dim I1 As New PictureBox
                Dim I2 As New PictureBox
                Dim L As New Label




                b.Text = "Tienes Productos Vencidos"
                b.Name = rdr("id").ToString()
                b.Size = New System.Drawing.Size(430, 35)
                b.Font = New System.Drawing.Font(10, 10)
                b.BackColor = BackColor
                b.FlatStyle = FlatStyle.Flat
                b.BackColor = Color.White
                b.ForeColor = Color.Black
                b.Dock = DockStyle.Top
                b.TextAlign = ContentAlignment.MiddleLeft


                L.Text = "(" & rdr("id").ToString() & ") Producto(s) Vencido(s)"
                L.Name = rdr("id").ToString()
                L.Size = New System.Drawing.Size(430, 18)
                L.Font = New System.Drawing.Font(10, 10)
                L.BackColor = BackColor
                L.FlatStyle = FlatStyle.Flat
                L.BackColor = Color.White
                L.ForeColor = Color.Gray
                L.Dock = DockStyle.Fill
                L.TextAlign = ContentAlignment.MiddleLeft



                I2.BackgroundImage = My.Resources.advertencia
                I2.BackgroundImageLayout = ImageLayout.Zoom
                I2.Size = New System.Drawing.Size(18, 18)
                I2.Dock = DockStyle.Left

                p1.Size = New System.Drawing.Size(430, 67)
                p1.BorderStyle = BorderStyle.FixedSingle
                p1.Dock = DockStyle.Top
                p1.BackColor = Color.White

                P2.Size = New System.Drawing.Size(287, 22)
                P2.Dock = DockStyle.Top
                P2.BackColor = Color.White


                I1.Image = My.Resources.calendario
                I1.SizeMode = ImageLayout.Zoom
                I1.Size = New System.Drawing.Size(90, 69)
                I1.Dock = DockStyle.Left
                I1.BackColor = Color.White




                p1.Controls.Add(b)
                p1.Controls.Add(I1)
                p1.Controls.Add(P2)
                P2.Controls.Add(I2)
                P2.Controls.Add(L)

                P2.BringToFront()
                b.SendToBack()
                I1.SendToBack()
                L.BringToFront()


                PanelCONTENEDORDENOTIFICACIONES.Controls.Add(p1)
                AddHandler b.Click, AddressOf miEventoProductos_Vencidos
                AddHandler L.Click, AddressOf miEventoProductos_Vencidos
                AddHandler I1.Click, AddressOf miEventoProductos_Vencidos
                AddHandler I2.Click, AddressOf miEventoProductos_Vencidos
            End While

            Cerrar()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click



        PanelHERRAMIENTAS.Visible = False
        Panelcuenta.Visible = False

        PanelCONTENEDORDENOTIFICACIONES.Controls.Clear()
        PanelCONTENEDOR_CUENTA_HERRAMIENTAS.Visible = True
        PanelNOTIFICACIONES.Visible = True
        PanelNOTIFICACIONES.Dock = DockStyle.Top

        If lblROL.Text = "Solo Ventas (no esta autorizado para manejar dinero)" Then
            dibujarVENTAS_EN_ESPERA_solo_para_vendedores()
        ElseIf lblROL.Text = "Cajero (Si esta autorizado para manejar dinero)" Then
            dibujarVENTAS_EN_ESPERA()
        ElseIf lblROL.Text = "Administrador (Control total)" Then
            dibujarVENTAS_EN_ESPERA()
        End If




        dibujarCOBROS()
        dibujarPOR_PAGAR()
        dibujarPRODUCTOS_vencidos()
        If LBLEstado_correo.Text = "SIN CONEXION" Then
            dibujarCorreoBase_sin_conexion()
        End If
    End Sub



    Private Sub PanelCONTENEDOR_CUENTA_HERRAMIENTAS_Paint(sender As Object, e As EventArgs) Handles PanelCONTENEDOR_CUENTA_HERRAMIENTAS.Paint

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ocultar_objetos_emergentes()

        INVENTARIO.ShowDialog()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ocultar_objetos_emergentes()
        CIERRE_DE_CAJA.ShowDialog()

    End Sub
    Sub ocultar_objetos_emergentes()
        PanelCONTENEDOR_CUENTA_HERRAMIENTAS.Visible = False
        DATALISTADO_PRODUCTOS_OKA.Visible = False


    End Sub


    Private Sub Panel17_click(sender As Object, e As EventArgs) Handles Panel17.Click
        ocultar_objetos_emergentes()

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs)
        ocultar_objetos_emergentes()
        aplicar_precio_mayoreo()
    End Sub
    Sub aplicar_precio_mayoreo()

        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("aplicar_precio_mayoreo", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_producto", lblidproducto.Text)
            cmd.Parameters.AddWithValue("@Id_venta", txtidventa.Text)
            cmd.ExecuteNonQuery()
            Cerrar()
            Listarproductosagregados()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Panel12_click(sender As Object, e As EventArgs) Handles Panel12.Click
        ocultar_objetos_emergentes()
    End Sub

    Private Sub Panel15_click(sender As Object, e As EventArgs) Handles Panel15.Click
        ocultar_objetos_emergentes()
    End Sub

    Private Sub Panel9_click(sender As Object, e As EventArgs) Handles PanelGALERIA_DE_PAGOS.Click
        ocultar_objetos_emergentes()
    End Sub

    Private Sub ToolStripMenuItem23_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem23.Click
        ocultar_objetos_emergentes()

        PANEL_CONFIGURACIONES.ShowDialog()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clientes_PROVEEDORES.lbltipo.Text = "C"
        clientes_PROVEEDORES.lblcp.Text = "Clientes"
        ocultar_objetos_emergentes()
        clientes_PROVEEDORES.ShowDialog()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        clientes_PROVEEDORES.lbltipo.Text = "P"
        clientes_PROVEEDORES.lblcp.Text = "Proveedores"
        ocultar_objetos_emergentes()
        clientes_PROVEEDORES.ShowDialog()
    End Sub
    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click

        APERTURA_DE_CREDITOS.lblTipo.Text = "POR PAGAR"
        ocultar_objetos_emergentes()
        APERTURA_DE_CREDITOS.ShowDialog()
        APERTURA_DE_CREDITOS.lblTipo.Text = "POR PAGAR"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        APERTURA_DE_CREDITOS.lblTipo.Text = "POR COBRAR"
        ocultar_objetos_emergentes()
        APERTURA_DE_CREDITOS.ShowDialog()
        APERTURA_DE_CREDITOS.lblTipo.Text = "POR COBRAR"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        ocultar_objetos_emergentes()
        MASCARA1.Show()
        MASCARA1.FormBorderStyle = FormBorderStyle.None
        usuariosok.ShowDialog()

    End Sub



    Private Sub TconfirmaredicionIgv_Click(sender As Object, e As EventArgs) Handles TconfirmaredicionIgv.Click
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("editar_IGV_Empresa", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Impuesto", txtimpuesto.Text)
            cmd.Parameters.AddWithValue("@Porcentaje_impuesto", txtporcentaje.Text)
            cmd.Parameters.AddWithValue("@Trabajas_con_impuestos", "SI")

            cmd.ExecuteNonQuery()
            Cerrar()

        Catch ex As Exception

        End Try
        mostrar_empresas()
        MenuEDITORdeIgv.Visible = False
        txtimpuesto.Visible = True
        txtporcentaje.Visible = True
        txtimpuesto.Enabled = False
        txtporcentaje.Enabled = False
    End Sub

    Private Sub TEDITARigv_Click(sender As Object, e As EventArgs) Handles TEDITARigv.Click
        txtimpuesto.Enabled = True
        txtporcentaje.Enabled = True
        TEDITARigv.Visible = False
        TconfirmaredicionIgv.Visible = True
        TcancelarEdiciondeIgv.Visible = True

    End Sub

    Private Sub MenuEDITORdeIgv_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuEDITORdeIgv.ItemClicked

    End Sub

    Private Sub TcancelarEdiciondeIgv_Click(sender As Object, e As EventArgs) Handles TcancelarEdiciondeIgv.Click
        txtporcentaje.Enabled = False
        txtimpuesto.Enabled = False
        TEDITARigv.Visible = True
        TcancelarEdiciondeIgv.Visible = False
        TconfirmaredicionIgv.Visible = False

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ocultar_objetos_emergentes()
        PAGOS_PROVEEDOSOKA.ShowDialog()
    End Sub

    Private Sub MenuStrip13_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip13.ItemClicked

    End Sub

    Private Sub datalistadomateriales_CellErrorTextNeeded(sender As Object, e As DataGridViewCellErrorTextNeededEventArgs) Handles datalistadomateriales.CellErrorTextNeeded

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ocultar_objetos_emergentes()
        Ticket.ShowDialog()
    End Sub



    Private Sub TXTNUEVOTOTAL_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)
        DISTRIBUCION_DE_PRODUCTOS.ShowDialog()

    End Sub

    Private Sub lblcontadortablaventas_Click(sender As Object, e As EventArgs) Handles lblcontadortablaventas.Click

    End Sub


    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub TimerRESTAURAR_VENTA_Tick(sender As Object, e As EventArgs) Handles TimerRESTAURAR_VENTA.Tick
        TimerRESTAURAR_VENTA.Stop()
        Try
            txtidventa.Text = Ventas_en_espera.datalistado_ventas_en_espera.SelectedCells.Item(1).Value

        Catch ex As Exception

        End Try

        Listarproductosagregados()

    End Sub
    Sub tema_Elegante_Black()
        Panel21.BackColor = Color.Black
        btnINSVarios.BackColor = Color.Transparent
        btnINSVarios.ForeColor = Color.White
        btnMayoreo.BackColor = Color.Transparent
        btnMayoreo.ForeColor = Color.White
        btnProductoRapido.BackColor = Color.Transparent
        btnProductoRapido.ForeColor = Color.White
        btnIngresosCaja.BackColor = Color.Transparent
        btnIngresosCaja.ForeColor = Color.White
        btnGastos.BackColor = Color.Transparent
        btnGastos.ForeColor = Color.White
        MenuStrip21.RenderMode = ToolStripRenderMode.Professional
        btnTecladoVirtual.BackColor = Color.Transparent
        btnTecladoVirtual.ForeColor = Color.White
        Label35.BackColor = Color.Black
        PictureBox6.BackColor = Color.Black
        Label30.BackColor = Color.Black
        Label30.ForeColor = Color.Gainsboro
        Panel13.BackColor = Color.FromArgb(18, 18, 18)
        btnCajasConectadas.ForeColor = Color.White
        btnVerventas.ForeColor = Color.White
        btnEspera.ForeColor = Color.White
        btnRestaurarventasespera.ForeColor = Color.White
        BtnEliminarVentaOK.ForeColor = Color.White
        btnEspera.BackColor = Color.Transparent
        btnRestaurarventasespera.BackColor = Color.Transparent
        BtnEliminarVentaOK.BackColor = Color.Transparent


        Panel17.BackColor = Color.FromArgb(35, 35, 35)
        Label66.ForeColor = Color.White
        datalistadomateriales.BackgroundColor = Color.Black
        txtbuscar.BackColor = Color.Black
        txtbuscar.ForeColor = Color.White
        'lbltipodebusqueda2.ForeColor = Color.White

        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.Black
        styCabeceras.ForeColor = Color.White
        Me.datalistadomateriales.ColumnHeadersDefaultCellStyle = styCabeceras
        Me.datalistadomateriales.RowTemplate.DefaultCellStyle.BackColor = Color.Black
        Me.datalistadomateriales.RowTemplate.DefaultCellStyle.ForeColor = Color.White
        Me.datalistadomateriales.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Gainsboro
        Me.datalistadomateriales.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 35, 35)

        lbltipodebusqueda2.BackColor = Color.Black
        ToolStripButton22.ForeColor = Color.White
        'MenuStrip2.BackColor = Color.FromArgb(35, 35, 35)
        'MenuStrip2.RenderMode = ToolStripRenderMode.Professional
        Panel12.BackColor = Color.FromArgb(35, 35, 35)
        Label36.ForeColor = Color.White
        labeligv.ForeColor = Color.White
        Label11.ForeColor = Color.White
        lblsubtotal.ForeColor = Color.White
        lbligv.ForeColor = Color.White
        lbldescuento.ForeColor = Color.White
        'Panel21.BackColor = Color.FromArgb(35, 35, 35)
        Panel5.BackColor = Color.DimGray

        ToolStripMenuItem23.Image = My.Resources.icon_BLACK
        ToolStripMenuItem22.Image = My.Resources.menu_BLACK
        PictureBox18.Image = My.Resources.notificacion_BLACK2

        'ToolStripButton2.ForeColor = Color.White
        ''ToolStripButton6.ForeColor = Color.White
        'TIngresosVarios.ForeColor = Color.White
        'TGastosvarios.ForeColor = Color.White
        'TProductoRapido.ForeColor = Color.White

        'ToolStripButton2.BackColor = Color.Transparent
        ''ToolStripButton6.BackColor = Color.Transparent
        'TIngresosVarios.BackColor = Color.Transparent
        'TGastosvarios.BackColor = Color.Transparent
        'TProductoRapido.BackColor = Color.Transparent

        Panel15.BackColor = Color.FromArgb(64, 64, 64)
        PanelGALERIA_DE_PAGOS.BackColor = Color.FromArgb(35, 35, 35)

        befectivo.BackColor = Color.FromArgb(64, 64, 64)
        btarjeta.BackColor = Color.FromArgb(64, 64, 64)
        bcredito.BackColor = Color.FromArgb(64, 64, 64)
        bmixto.BackColor = Color.FromArgb(64, 64, 64)

        bcredito.ForeColor = Color.White
        bmixto.ForeColor = Color.White
        Listarproductosagregados()
    End Sub
    Sub tema_Redentor()
        Panel21.BackColor = Color.White
        btnINSVarios.BackColor = Color.WhiteSmoke
        btnINSVarios.ForeColor = Color.Black
        btnMayoreo.BackColor = Color.WhiteSmoke
        btnMayoreo.ForeColor = Color.Black
        btnProductoRapido.BackColor = Color.WhiteSmoke
        btnProductoRapido.ForeColor = Color.Black
        btnIngresosCaja.BackColor = Color.WhiteSmoke
        btnIngresosCaja.ForeColor = Color.Black
        btnGastos.BackColor = Color.WhiteSmoke
        btnGastos.ForeColor = Color.Black
        MenuStrip21.RenderMode = ToolStripRenderMode.Professional
        btnTecladoVirtual.BackColor = Color.WhiteSmoke
        btnTecladoVirtual.ForeColor = Color.Black
        Label35.BackColor = Color.White
        PictureBox6.BackColor = Color.White
        Label30.BackColor = Color.White
        Label30.ForeColor = Color.DimGray
        Panel13.BackColor = Color.Gainsboro
        btnCajasConectadas.ForeColor = Color.Black
        btnVerventas.ForeColor = Color.Black
        btnEspera.ForeColor = Color.Black
        btnRestaurarventasespera.ForeColor = Color.Black
        BtnEliminarVentaOK.ForeColor = Color.Black
        btnEspera.BackColor = Color.WhiteSmoke
        btnRestaurarventasespera.BackColor = Color.Transparent
        BtnEliminarVentaOK.BackColor = Color.FromArgb(255, 192, 192)




        'TimerCambio_de_tema.Stop()
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.White
        styCabeceras.ForeColor = Color.Black
        Me.datalistadomateriales.ColumnHeadersDefaultCellStyle = styCabeceras

        Panel17.BackColor = Color.White
        Label66.ForeColor = Color.Black
        datalistadomateriales.BackgroundColor = Color.White
        txtbuscar.BackColor = Color.White
        txtbuscar.ForeColor = Color.Black
        'lbltipodebusqueda2.ForeColor = Color.White


        Me.datalistadomateriales.RowTemplate.DefaultCellStyle.BackColor = Color.White
        Me.datalistadomateriales.RowTemplate.DefaultCellStyle.ForeColor = Color.Black
        Me.datalistadomateriales.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black
        Me.datalistadomateriales.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke

        lbltipodebusqueda2.BackColor = Color.White
        ToolStripButton22.ForeColor = Color.Black

        'MenuStrip2.BackColor = Color.White
        'MenuStrip2.RenderMode = ToolStripRenderMode.System

        Panel12.BackColor = Color.WhiteSmoke

        Label36.ForeColor = Color.DimGray
        labeligv.ForeColor = Color.DimGray
        Label11.ForeColor = Color.DimGray
        lblsubtotal.ForeColor = Color.DimGray
        lbligv.ForeColor = Color.DimGray
        lbldescuento.ForeColor = Color.DimGray
        'Panel21.BackColor = Color.White
        Panel5.BackColor = Color.Gainsboro


        ToolStripMenuItem23.Image = My.Resources.config_redentor
        ToolStripMenuItem22.Image = My.Resources.Menu_redentor
        PictureBox18.Image = My.Resources.notificacion_redentor

        'ToolStripButton2.ForeColor = Color.Black
        'ToolStripButton6.ForeColor = Color.Black
        'TIngresosVarios.ForeColor = Color.Black
        'TGastosvarios.ForeColor = Color.Black
        'TProductoRapido.ForeColor = Color.Black

        'ToolStripButton2.BackColor = Color.WhiteSmoke
        'ToolStripButton6.BackColor = Color.WhiteSmoke
        'TIngresosVarios.BackColor = Color.WhiteSmoke
        'TGastosvarios.BackColor = Color.WhiteSmoke
        'TProductoRapido.BackColor = Color.WhiteSmoke

        Panel15.BackColor = Color.FromArgb(231, 63, 67)

        PanelGALERIA_DE_PAGOS.BackColor = Color.FromArgb(242, 243, 245)

        befectivo.BackColor = Color.FromArgb(0, 166, 63)
        btarjeta.BackColor = Color.FromArgb(64, 64, 64)
        bcredito.BackColor = Color.FromArgb(255, 192, 192)
        bmixto.BackColor = Color.Indigo

        bcredito.ForeColor = Color.Black
        Listarproductosagregados()

    End Sub

    Private Sub TimerCambio_de_tema_Tick(sender As Object, e As EventArgs) Handles TimerCambio_de_tema.Tick

        'lblhora.Text = DateTime.Now.ToString("hh")

        'If lblhora.Text >= 18 Then


        'End If
        'If lblhora.Text < 7 Then

        'End If
        'If lblhora.Text >= 7 And lblhora.Text < 18 Then
        '    tema_oscuro()
        'End If
    End Sub


    Private Sub TimerEmpresa_Tick(sender As Object, e As EventArgs) Handles TimerEmpresa.Tick
        TimerEmpresa.Stop()

        mostrar_empresas()
        mostrar_Cajas()
        Try
            lbltipodebusqueda.Text = dtempresaok.SelectedCells.Item(8).Value
            txtimpuesto.Text = dtempresaok.SelectedCells.Item(7).Value
            txtporcentaje.Text = dtempresaok.SelectedCells.Item(6).Value
            LBLtrabajasConimpuestos.Text = dtempresaok.SelectedCells.Item(9).Value
            lbltema.Text = datalistadoCajas.SelectedCells.Item(2).Value
            lblcorreo.Text = dtempresaok.SelectedCells.Item(11).Value
            lblRedondeo.Text = dtempresaok.SelectedCells.Item(13).Value
        Catch ex As Exception

        End Try
        If lbltema.Text = "Redentor" Then
            tema_Redentor()
        ElseIf lbltema.Text = "Elegante Black" Then
            tema_Elegante_Black()

        End If
        Try
            If LBLtrabajasConimpuestos.Text = "NO" Then
                Apagado.Visible = True
                Apagado.BringToFront()
                txtimpuesto.Visible = False
                txtporcentaje.Visible = False
                MenuEDITORdeIgv.Visible = False

            Else
                Encendido.Visible = True
                Encendido.BringToFront()
                txtimpuesto.Visible = True
                txtporcentaje.Visible = True
                MenuEDITORdeIgv.Visible = True
                TEDITARigv.Visible = True
                TconfirmaredicionIgv.Visible = False
                TcancelarEdiciondeIgv.Visible = False


            End If
        Catch ex As Exception

        End Try
        If lbltipodebusqueda.Text = "LECTORA" Then
            lbltipodebusqueda2.Text = "Buscar con lector de código de barras"
            BTNLECTORA.BackColor = Color.FromArgb(0, 197, 21)
            BTNTECLADO.BackColor = Color.DarkGray

        ElseIf lbltipodebusqueda.Text = "TECLADO" Then
            lbltipodebusqueda2.Text = "Buscar con teclado"
            BTNLECTORA.BackColor = Color.DarkGray
            BTNTECLADO.BackColor = Color.FromArgb(0, 197, 21)
        End If
        Try
            If LBLtrabajasConimpuestos.Text = "SI" Then
                labeligv.Text = txtimpuesto.Text & "(" & txtporcentaje.Text & "%)"
                lbligvnumero.Text = txtporcentaje.Text
            End If
        Catch ex As Exception
        End Try
        sumar()

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        ocultar_objetos_emergentes()
        DASHBOARD_PRINCIPAL.ShowDialog()

    End Sub

    Private Sub TXTCON_LECTORA_CheckedChanged(sender As Object, e As EventArgs) Handles TXTCON_LECTORA.CheckedChanged
        If TXTCON_LECTORA.Checked = True Then

            txtteclado.Checked = False
            Try
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("editar_Modo_de_busqueda", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Modo_de_busqueda", "LECTORA")
                cmd.ExecuteNonQuery()
                Cerrar()
            Catch ex As Exception

            End Try
        ElseIf TXTCON_LECTORA.Checked = False Then

            txtteclado.Checked = True
            Try
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("editar_Modo_de_busqueda", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Modo_de_busqueda", "TECLADO")
                cmd.ExecuteNonQuery()
                Cerrar()
            Catch ex As Exception

            End Try
        End If



        mostrar_empresas()
        Try
            lbltipodebusqueda.Text = dtempresaok.SelectedCells.Item(8).Value
        Catch ex As Exception
        End Try

        If lbltipodebusqueda.Text = "LECTORA" Then
            lbltipodebusqueda2.Text = "Buscar con lector de código de barras"
            BTNLECTORA.BackColor = Color.FromArgb(0, 197, 21)
            BTNTECLADO.BackColor = Color.DarkGray
        ElseIf lbltipodebusqueda.Text = "TECLADO" Then
            lbltipodebusqueda2.Text = "Buscar con teclado"
            BTNLECTORA.BackColor = Color.DarkGray
            BTNTECLADO.BackColor = Color.FromArgb(0, 197, 21)
        End If
    End Sub

    Private Sub txtteclado_CheckedChanged(sender As Object, e As EventArgs) Handles txtteclado.CheckedChanged
        If txtteclado.Checked = True Then
            TXTCON_LECTORA.Checked = False
            Try
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("editar_Modo_de_busqueda", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Modo_de_busqueda", "TECLADO")
                cmd.ExecuteNonQuery()
                Cerrar()
            Catch ex As Exception

            End Try
        ElseIf txtteclado.Checked = False Then
            TXTCON_LECTORA.Checked = True
            Try
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("editar_Modo_de_busqueda", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Modo_de_busqueda", "LECTORA")
                cmd.ExecuteNonQuery()
                Cerrar()
            Catch ex As Exception

            End Try
        End If
        mostrar_empresas()
        Try
            lbltipodebusqueda.Text = dtempresaok.SelectedCells.Item(8).Value
        Catch ex As Exception
        End Try

        If lbltipodebusqueda.Text = "LECTORA" Then
            lbltipodebusqueda2.Text = "Buscar con lector de código de barras"
            BTNLECTORA.BackColor = Color.FromArgb(0, 197, 21)
            BTNTECLADO.BackColor = Color.DarkGray
        ElseIf lbltipodebusqueda.Text = "TECLADO" Then
            lbltipodebusqueda2.Text = "Buscar con teclado"
            BTNLECTORA.BackColor = Color.DarkGray
            BTNTECLADO.BackColor = Color.FromArgb(0, 197, 21)
        End If
    End Sub

    Private Sub lbltipodebusqueda2_Click(sender As Object, e As EventArgs) Handles lbltipodebusqueda2.Click

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        MASCARA1.Show()
        ocultar_objetos_emergentes()
        MENU_dE_REPORTES_OI.ShowDialog()
    End Sub

    Private Sub Button18_Click_1(sender As Object, e As EventArgs) Handles Button18.Click
        ocultar_objetos_emergentes()
        MASCARA1.Show()
        MASCARA1.FormBorderStyle = FormBorderStyle.None
        GENERAR_COPIAS_DE_SEGURIDAD.ShowDialog()
    End Sub

    Private Sub PanelCONTENEDORDENOTIFICACIONES_Paint(sender As Object, e As PaintEventArgs) Handles PanelCONTENEDORDENOTIFICACIONES.Paint

    End Sub

    Private Sub TimerNotificaciones_Tick(sender As Object, e As EventArgs) Handles TimerNotificaciones.Tick
        SUMAR_NOTIFICACIONES()
        TimerNotificaciones.Stop()

    End Sub
    Sub ACTIVAR_MODO_PEDIDO()
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.FromArgb(0, 102, 204)
        styCabeceras.ForeColor = Color.White
        Me.datalistadomateriales.ColumnHeadersDefaultCellStyle = styCabeceras
        PanelGALERIA_DE_PAGOS.BackColor = Color.White




        Me.datalistadomateriales.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(0, 102, 204)
        Me.datalistadomateriales.RowTemplate.DefaultCellStyle.ForeColor = Color.White
        Me.datalistadomateriales.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White
        Me.datalistadomateriales.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 100, 200)
        Me.datalistadomateriales.BackgroundColor = Color.FromArgb(0, 102, 204)

    End Sub


    Private Sub MenuStrip14_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub TimerCambio_de_usuario_Tick(sender As Object, e As EventArgs) Handles TimerCambio_de_usuario.Tick
        mostrar_usuario_logueado()
        mostrar_permisos()
        TimerCambio_de_usuario.Stop()

    End Sub
    Sub restaurar_base_para_versiones_no_express()
        Dim cnn As New SqlConnection("Server=.\;database=master; integrated security=yes")
        cnn.Open()
        Dim DropRes As String = "EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'BASEADA' USE [master] ALTER DATABASE [BASEADA] SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE [BASEADA] RESTORE DATABASE BASEADA FROM DISK = N'" & lblruta.Text & "' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10"

        Try

            Dim BorraRestaura As New SqlCommand(DropRes, cnn)
            BorraRestaura.ExecuteNonQuery()

            MessageBox.Show("La base de datos " & Microsoft.VisualBasic.Left(lblruta.Text, lblruta.TextLength - 4) & " ha sido restaurada satisfactoriamente! Vuelve a Iniciar El Aplicativo", "Restauración de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al restaurar la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try
    End Sub
    Private Sub Button17_Click_1(sender As Object, e As EventArgs) Handles Button17.Click
        With dlg
            .InitialDirectory = ""
            .Filter = "Backup ADA369|*.bak"
            .FilterIndex = 2
            .Title = "Cargador de Backup ADA 369"

        End With
        If dlg.ShowDialog() = DialogResult.OK Then
            Try
                lblruta.Text = Path.GetFullPath(dlg.FileName)

            Catch ex As Exception

            End Try
        End If

        If MessageBox.Show("Usted está a punto de restaurar la base de datos," & vbCrLf &
"asegurese de que el archivo .bak sea reciente, de" & vbCrLf &
"lo contrario podría perder información y no podrá" & vbCrLf &
"recuperarla, ¿desea continuar?", "Restauración de base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim cnn As New SqlConnection("Server=.\SQLEXPRESS;database=master; integrated security=yes")
            cnn.Open()
            Dim DropRes As String = "EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'BASEADA' USE [master] ALTER DATABASE [BASEADA] SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE [BASEADA] RESTORE DATABASE BASEADA FROM DISK = N'" & lblruta.Text & "' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10"

            Try

                Dim BorraRestaura As New SqlCommand(DropRes, cnn)
                BorraRestaura.ExecuteNonQuery()

                MessageBox.Show("La base de datos " & Microsoft.VisualBasic.Left(lblruta.Text, lblruta.TextLength - 4) & " ha sido restaurada satisfactoriamente! Vuelve a Iniciar El Aplicativo", "Restauración de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End
            Catch ex As Exception
                restaurar_base_para_versiones_no_express()
            Finally
                If cnn.State = ConnectionState.Open Then
                    cnn.Close()
                End If
            End Try
        Else ' No restaura
            Exit Sub
        End If
    End Sub

    Private Sub datalistadomateriales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadomateriales.CellContentClick

    End Sub

    Private Sub datalistado_usuario_logueado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado_usuario_logueado.CellContentClick

    End Sub

    Private Sub ToolStripButton3_Click_1(sender As Object, e As EventArgs)
        MASCARA1.Show()
        Membresias.ShowDialog()

    End Sub

    Private Sub MenuStrip9_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip9.ItemClicked

    End Sub

    Private Sub datalistadomateriales_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadomateriales.CellDoubleClick

        If e.ColumnIndex <> Me.datalistadomateriales.Columns.Item("S").Index Then
            If e.ColumnIndex <> Me.datalistadomateriales.Columns.Item("R").Index Then

                Try
                    lbliddetalleventa.Text = datalistadomateriales.SelectedCells.Item(9).Value
                    lblcantidad.Text = datalistadomateriales.SelectedCells.Item(12).Value

                    CAMBIAR_PRECIOS_MANUALMENTE.lblproducto.Text = lblcantidad.Text
                    CAMBIAR_PRECIOS_MANUALMENTE.lbliddetalleventa.Text = lbliddetalleventa.Text

                    CAMBIAR_PRECIOS_MANUALMENTE.ShowDialog()
                    CAMBIAR_PRECIOS_MANUALMENTE.lbliddetalleventa.Text = lbliddetalleventa.Text
                    CAMBIAR_PRECIOS_MANUALMENTE.lblproducto.Text = lblcantidad.Text
                Catch ex As Exception

                End Try

            End If


        End If



    End Sub

    Private Sub Panel17_Paint(sender As Object, e As PaintEventArgs) Handles Panel17.Paint

    End Sub

    Private Sub PanelHERRAMIENTAS_Paint(sender As Object, e As PaintEventArgs) Handles PanelHERRAMIENTAS.Paint

    End Sub

    Private Sub Panel34_Paint(sender As Object, e As PaintEventArgs) Handles Panel34.Paint

    End Sub

    Private Sub LBLcontadorESPERA_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PanelProductoCategoria_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs)

    End Sub





    Private Sub BTNPONERENESPERA_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        ocultar_objetos_emergentes()

        HISTORIAL_DE_VENTAS.ShowDialog()
    End Sub



    Private Sub mostrar_Orden_de_ProduccionBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles mostrar_Orden_de_ProduccionBindingSource.CurrentChanged

    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint

    End Sub

    Private Sub ToolStripMenuItem2_Click_2(sender As Object, e As EventArgs) Handles ToolStripButton22.Click
        productosOK.ShowDialog()
        ocultar_objetos_emergentes()
    End Sub



    Private Sub BtnCerrar_turno_Click(sender As Object, e As EventArgs) Handles BtnCerrar_turno.Click
        CIERRE_DE_CAJA.ShowDialog()
        ocultar_objetos_emergentes()
    End Sub

    Private Sub PanelProductoCategoria_MouseMove(sender As Object, e As MouseEventArgs)
        ocultar_objetos_emergentes()
    End Sub

    Private Sub PanelElejirCategoria_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PanelElejirCategoria_MouseMove(sender As Object, e As MouseEventArgs)
        ocultar_objetos_emergentes()
    End Sub

    Private Sub btnINSVarios_Click(sender As Object, e As EventArgs) Handles btnINSVarios.Click
        RENOVAR_VENTA()

        ocultar_objetos_emergentes()


        AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS.ShowDialog()
    End Sub

    Private Sub btnMayoreo_Click(sender As Object, e As EventArgs) Handles btnMayoreo.Click
        ocultar_objetos_emergentes()
        If txtidventa.Text <> "" Then
            aplicar_precio_mayoreo()
        End If

    End Sub

    Private Sub btnIngresosCaja_Click(sender As Object, e As EventArgs) Handles btnIngresosCaja.Click
        ocultar_objetos_emergentes()

        MASCARA1.Show()
        MASCARA1.FormBorderStyle = FormBorderStyle.None
        GASTOS_VARIOS_FORM.lbltipo.Text = "INGRESOS VARIOS (+)"
        GASTOS_VARIOS_FORM.TXTACCION.Text = "INGRESO"
        GASTOS_VARIOS_FORM.PANELCOMPROBANTE.Enabled = False
        GASTOS_VARIOS_FORM.PANELPRECIOS.Enabled = False

        GASTOS_VARIOS_FORM.GuardarCambiosToolStripMenuItem.Visible = False
        GASTOS_VARIOS_FORM.GUARDARNORMAL.Visible = True
        GASTOS_VARIOS_FORM.txtidgasto2.Text = ""
        GASTOS_VARIOS_FORM.TXTIDCONCEPTO.Text = ""


        GASTOS_VARIOS_FORM.txtobservacion.Text = ""
        GASTOS_VARIOS_FORM.txtnrocomprobante.Text = ""
        GASTOS_VARIOS_FORM.txttipocomprobante.Text = ""
        GASTOS_VARIOS_FORM.txtpantalla.Text = ""
        GASTOS_VARIOS_FORM.TXTCONCEPTO.Text = ""



        GASTOS_VARIOS_FORM.ShowDialog()


        GASTOS_VARIOS_FORM.GuardarCambiosToolStripMenuItem.Visible = False
        GASTOS_VARIOS_FORM.GUARDARNORMAL.Visible = True
        GASTOS_VARIOS_FORM.txtidgasto2.Text = ""
        GASTOS_VARIOS_FORM.TXTIDCONCEPTO.Text = ""


        GASTOS_VARIOS_FORM.txtobservacion.Text = ""
        GASTOS_VARIOS_FORM.txtnrocomprobante.Text = ""
        GASTOS_VARIOS_FORM.txttipocomprobante.Text = ""
        GASTOS_VARIOS_FORM.txtpantalla.Text = ""
        GASTOS_VARIOS_FORM.TXTCONCEPTO.Text = ""
        GASTOS_VARIOS_FORM.PANELCOMPROBANTE.Enabled = False
        GASTOS_VARIOS_FORM.PANELPRECIOS.Enabled = False

        GASTOS_VARIOS_FORM.TXTACCION.Text = "INGRESO"
        GASTOS_VARIOS_FORM.lbltipo.Text = "INGRESOS VARIOS (+)"
    End Sub

    Private Sub btnGastos_Click(sender As Object, e As EventArgs) Handles btnGastos.Click

        ocultar_objetos_emergentes()
        MASCARA1.Show()
        MASCARA1.FormBorderStyle = FormBorderStyle.None
        GASTOS_VARIOS_FORM.lbltipo.Text = "GASTOS VARIOS (-)"
        GASTOS_VARIOS_FORM.TXTACCION.Text = "SALIDA"
        GASTOS_VARIOS_FORM.PANELCOMPROBANTE.Enabled = False
        GASTOS_VARIOS_FORM.PANELPRECIOS.Enabled = False
        GASTOS_VARIOS_FORM.GuardarCambiosToolStripMenuItem.Visible = False
        GASTOS_VARIOS_FORM.txtmenuinterno.Text = "INTERNO"
        GASTOS_VARIOS_FORM.Id_usuario.Text = lblidusuario.Text
        GASTOS_VARIOS_FORM.ShowDialog()
        GASTOS_VARIOS_FORM.Id_usuario.Text = lblidusuario.Text
        GASTOS_VARIOS_FORM.txtmenuinterno.Text = "INTERNO"
        GASTOS_VARIOS_FORM.GuardarCambiosToolStripMenuItem.Visible = False
        GASTOS_VARIOS_FORM.PANELCOMPROBANTE.Enabled = False
        GASTOS_VARIOS_FORM.PANELPRECIOS.Enabled = False
        GASTOS_VARIOS_FORM.TXTACCION.Text = "SALIDA"
        GASTOS_VARIOS_FORM.lbltipo.Text = "GASTOS VARIOS (-)"
    End Sub

    Private Sub btnProductoRapido_Click(sender As Object, e As EventArgs) Handles btnProductoRapido.Click
        RENOVAR_VENTA()
        ocultar_objetos_emergentes()
        Producto_servicio_rapido.ShowDialog()

    End Sub

    Private Sub BtnEliminarVentaOK_Click(sender As Object, e As EventArgs) Handles BtnEliminarVentaOK.Click
        If txtidventa.Text <> "" Then
            eliminar_venta()
            Listarproductosagregados()
        End If
        ocultar_objetos_emergentes()
        contar_ventas_en_espera()
    End Sub

    Private Sub btnEspera_Click(sender As Object, e As EventArgs) Handles btnEspera.Click
        If txtidventa.Text <> "" Then
            PanelVENTAENESPERANOMBRE.Visible = True
            PanelVENTAENESPERANOMBRE.Dock = DockStyle.Fill
            txtnombre.Text = ""
            txtnombre.Focus()
            Process.Start("osk.exe")

        End If
        ocultar_objetos_emergentes()
    End Sub

    Private Sub btnRestaurarventasespera_MouseMove(sender As Object, e As MouseEventArgs) Handles btnRestaurarventasespera.MouseMove
        If lbltema.Text = "Elegante Black" Then
            btnRestaurarventasespera.ForeColor = Color.Black
        End If

    End Sub
    Private Sub btnRestaurarventasespera_MouseLeave(sender As Object, e As EventArgs) Handles btnRestaurarventasespera.MouseLeave
        If lbltema.Text = "Elegante Black" Then
            btnRestaurarventasespera.ForeColor = Color.White

        End If
    End Sub
    Private Sub btnRestaurarventasespera_Click(sender As Object, e As EventArgs) Handles btnRestaurarventasespera.Click
        ocultar_objetos_emergentes()


        Ventas_en_espera.ShowDialog()
    End Sub


    Private Sub VENTAS_MENU_PRINCIPAL_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing

    End Sub

    Private Sub VENTAS_MENU_PRINCIPAL_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs)
        lblporcentaje.Text = (TXTTOTALACTUAL.Text * 1 - txtmonto.Text * 1) / TXTTOTALACTUAL.Text * 1
        aplicar_descuento_a_cada_producto_en_detalle_venta()

    End Sub

    Sub aplicar_descuento_a_cada_producto_en_detalle_venta()
        For Each row As DataGridViewRow In datalistadomateriales.Rows
            'Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
            'datalistado.Rows.Remove(datalistado.CurrentRow)


            'If datalistado.SelectedCells.Item(6).Value Then
            Dim onekey As Integer = Convert.ToInt32(row.Cells("iddetalle_venta").Value)



            Try

                Try
                    Dim cmd As New SqlCommand
                    abrir()
                    cmd = New SqlCommand("editar_detalle_descuento_por_producto", conexion)
                    cmd.CommandType = 4

                    cmd.Parameters.AddWithValue("@porcentaje", lblporcentaje.Text)
                    cmd.Parameters.AddWithValue("@Id_detalleventa", onekey)

                    cmd.ExecuteNonQuery()

                Catch ex As Exception

                End Try

            Catch ex As Exception : MsgBox(ex.Message)

            End Try
            Cerrar()
            'End If

        Next
        Call Listarproductosagregados()
        sumar()
    End Sub

    Private Sub MenuStrip17_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub TimerMostrarUsuarioLogueado_Tick(sender As Object, e As EventArgs) Handles TimerMostrarUsuarioLogueado.Tick
        mostrar_usuario_logueado()
        TimerMostrarUsuarioLogueado.Stop()

    End Sub


    Private Sub Button20_Click_1(sender As Object, e As EventArgs) Handles Button20.Click
        Membresias.ShowDialog()

    End Sub



    Private Sub btnVerventas_Click(sender As Object, e As EventArgs) Handles btnVerventas.Click
        ocultar_objetos_emergentes()

        HISTORIAL_DE_VENTAS.ShowDialog()
    End Sub

    Private Sub Panel13_Paint(sender As Object, e As PaintEventArgs) Handles Panel13.Paint

    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtmonto.Text = txtmonto.Text & "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtmonto.Text = txtmonto.Text & "1"

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtmonto.Text = txtmonto.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtmonto.Text = txtmonto.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtmonto.Text = txtmonto.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtmonto.Text = txtmonto.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtmonto.Text = txtmonto.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtmonto.Text = txtmonto.Text & "7"


    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtmonto.Text = txtmonto.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtmonto.Text = txtmonto.Text & "9"
    End Sub

    Dim SECUENCIA As Boolean = True
    Private Sub btnborrarderecha_Click(sender As Object, e As EventArgs) Handles btnborrarderecha.Click

        If SECUENCIA = True Then
            txtmonto.Text = txtmonto.Text & "."
            SECUENCIA = False
        Else
            Return

        End If
        'Try
        'txtmonto.Text = txtmonto.Text & "."
        'txtmonto_KeyPress(Me, New KeyPressEventArgs(CType((Keys.Enter), CharacterRange)))

        'txtmonto_KeyPress(sender, Nothing)



        '    'Dim caracter As String
        '    'caracter = "."
        '    'Dim contador As Integer
        '    'contador = 0
        '    'Dim arraycadena As String
        '    'arraycadena = txtmonto.Text.ToCharArray()
        '    'For i = 0 To arraycadena.Length - 1
        '    '    caracter = arraycadena(i)
        '    '    For j = 0 To arraycadena.Length - 1
        '    '        If arraycadena(j) = caracter Then
        '    '            contador = contador + 1
        '    '        End If
        '    '    Next

        '    'Next
        '    'If contador > 1 Then
        '    'End If
        '    Separador_de_Numeros(txtmonto, e)



        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub btnborrartodo_Click(sender As Object, e As EventArgs) Handles btnborrartodo.Click

        txtmonto.Clear()
        SECUENCIA = True
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Try


            If txtmonto.Text * 1 > 0 Then
                Try
                    Dim cmd As New SqlCommand
                    abrir()
                    cmd = New SqlCommand("editar_precio_unitario_en_detalle_De_venta", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@iddetalle_venta", datalistadomateriales.SelectedCells.Item(9).Value)
                    cmd.Parameters.AddWithValue("@precio", txtmonto.Text)
                    cmd.ExecuteNonQuery()
                    Cerrar()
                    Timer_MOSTRAR_PRODUCTOS_AGREGADOS.Start()
                    txtmonto.Clear()


                Catch ex As Exception

                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtmonto_TextChanged(sender As Object, e As EventArgs) Handles txtmonto.TextChanged

    End Sub

    Private Sub txtmonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmonto.KeyPress

        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then

            e.KeyChar =
                    Threading.Thread.CurrentThread.
                    CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If


        Separador_de_Numeros(txtmonto, e)
    End Sub
    Sub editar_detalle_venta_sumar_EN_BOTON_CANTIDAD()


        Try
            If datalistadomateriales.SelectedCells.Item(16).Value = "NO" Then
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("editar_detalle_venta_sumar", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Id_producto", lblidproducto.Text)
                cmd.Parameters.AddWithValue("@cantidad", CANTIDAD_A_EDITAR)
                cmd.Parameters.AddWithValue("@Cantidad_mostrada", CANTIDAD_A_EDITAR)
                cmd.Parameters.AddWithValue("@Id_venta", txtidventa.Text)

                cmd.ExecuteNonQuery()
                Cerrar()

            End If
            If datalistadomateriales.SelectedCells.Item(16).Value = "SI" Then
                If datalistadomateriales.SelectedCells.Item(11).Value > 0 Then
                    Dim cmd As New SqlCommand
                    abrir()
                    cmd = New SqlCommand("editar_detalle_venta_sumar", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@Id_producto", lblidproducto.Text)
                    cmd.Parameters.AddWithValue("@cantidad", CANTIDAD_A_EDITAR)
                    cmd.Parameters.AddWithValue("@Cantidad_mostrada", CANTIDAD_A_EDITAR)
                    cmd.Parameters.AddWithValue("@Id_venta", txtidventa.Text)

                    cmd.ExecuteNonQuery()
                    Cerrar()
                    txtidproducto.Text = datalistadomateriales.SelectedCells.Item(8).Value
                    disminuir_stock_EN_BOTON_CANTIDAD()
                Else
                    TimerLABEL_STOCK.Start()

                End If


            End If
            Listarproductosagregados()
            sumar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
    Sub disminuir_stock_EN_BOTON_CANTIDAD()
        Try
            Dim cmd As New SqlCommand

            Try
                abrir()
                cmd = New SqlCommand("disminuir_stock_en_detalle_de_venta", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", txtidproducto.Text)
                If TXTSEVENDEPOR.Text <> "Granel" Then
                    cmd.Parameters.AddWithValue("@cantidad", CANTIDAD_A_EDITAR)
                ElseIf TXTSEVENDEPOR.Text = "Granel" Then
                    cmd.Parameters.AddWithValue("@cantidad", CANTIDAD_A_EDITAR)
                End If


            Catch ex As Exception

            End Try




            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            TimerLABEL_STOCK.Start()
        End Try

    End Sub
    Dim INDICADOR As String
    Dim CANTIDAD_A_EDITAR As New Double
    Sub AUMENTAR_BOTON_CANTIDAD()

        lblidproducto.Text = datalistadomateriales.SelectedCells.Item(8).Value
        If datalistadomateriales.SelectedCells.Item(17).Value = "Unidad" Or datalistadomateriales.SelectedCells.Item(17).Value = "No definido" Then

            editar_detalle_venta_sumar_EN_BOTON_CANTIDAD()
            'ElseIf datalistadomateriales.SelectedCells.Item(17).Value = "Granel" Then
            '    CANTIDAD_A_GRANEL.txtprecio_unitario.Text = datalistadomateriales.SelectedCells.Item(6).Value
            '    Id_presentacion.Text = datalistadomateriales.SelectedCells.Item(8).Value
            '    CANTIDAD_A_GRANEL.txtProducto.Text = datalistadomateriales.SelectedCells.Item(4).Value
            '    CANTIDAD_A_GRANEL.lblstock.Text = datalistadomateriales.SelectedCells.Item(11).Value
            '    lblAgranellAumentar.Text = "AUMENTAR AGRANEL"
            '    CANTIDAD_A_GRANEL.txtcantidad.Text = 1
            '    CANTIDAD_A_GRANEL.LblcantidadAumentar.Visible = True

            '    CANTIDAD_A_GRANEL.ShowDialog()

        End If
    End Sub
    Sub DISMINUIR_BOTON_CANTIDAD()
        editar_detalle_venta_restar_BOTON_CANTIDAD()
        contar_tablas_ventas()
        If lblcontadortablaventas.Text = 0 And txtventagenerada.Text = "VENTA GENERADA" Then
            Listarventas()
            Try
                txtidventa.Text = datalistadoventas_nuevasok.SelectedCells.Item(1).Value
            Catch ex As Exception
            End Try
            eliminar_venta_al_agregar_productos()
            txtventagenerada.Text = "VENTA NUEVA"
        End If
    End Sub
    Sub Activar_boton_cantidad()
        Try
            Dim cant As Double
            Dim stock As Double
            Dim condicional As Double
            Dim indicador As String

            If datalistadomateriales.SelectedCells.Item(11).Value <> "Ilimitado" Then
                cant = datalistadomateriales.SelectedCells.Item(5).Value
                stock = datalistadomateriales.SelectedCells.Item(11).Value
                condicional = cant + stock
                If condicional >= txtmonto.Text * 1 Then
                    indicador = "PROCEDE"
                Else
                    indicador = "NO PRECEDE"
                End If
            Else
                indicador = "NO PRECEDE"
            End If




            If indicador = "PROCEDE" Or (datalistadomateriales.SelectedCells.Item(11).Value = "Ilimitado") Then
                If txtmonto.Text * 1 > 0 Then
                    CANTIDAD_A_EDITAR = 0
                    Try
                        Dim CANTIDAD As Double
                        CANTIDAD = 0
                        CANTIDAD = datalistadomateriales.SelectedCells.Item(5).Value
                        If txtmonto.Text * 1 > CANTIDAD Then
                            indicador = "SUMA"
                            CANTIDAD_A_EDITAR = txtmonto.Text * 1 - CANTIDAD
                            AUMENTAR_BOTON_CANTIDAD()
                        ElseIf txtmonto.Text * 1 < CANTIDAD
                            indicador = "RESTA"
                            CANTIDAD_A_EDITAR = CANTIDAD - txtmonto.Text * 1
                            DISMINUIR_BOTON_CANTIDAD()
                        End If
                        txtmonto.Clear()

                    Catch ex As Exception

                    End Try
                End If
            Else
                TimerLABEL_STOCK.Start()
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub Button21_Click_1(sender As Object, e As EventArgs) Handles Button21.Click

        If datalistadomateriales.SelectedCells.Item(17).Value = "Unidad" Then
            Dim ruta As String = txtmonto.Text
            If (ruta.Contains(".")) Then
                MessageBox.Show("Este Producto no acepta decimales ya que esta Configurado para ser vendido por UNIDAD", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Activar_boton_cantidad()

            End If

        ElseIf datalistadomateriales.SelectedCells.Item(17).Value = "Granel" Then

            Activar_boton_cantidad()
        End If



    End Sub

    Private Sub txtmonto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmonto.KeyDown
        If e.KeyValue = Keys.Separator Then
            FuncKeysModule(e.KeyValue)
            e.Handled = True
        End If
    End Sub
    Public Sub FuncKeysModule(ByVal value As Keys)
        'Check what function key is in a pressed state, and then perform the corresponding action.
        Select Case value
            Case Keys.Separator
                MessageBox.Show("Separator pressed")
        End Select
    End Sub

    Private Sub btnborrarderecha_KeyDown(sender As Object, e As KeyEventArgs) Handles btnborrarderecha.KeyDown
        If e.KeyValue = Keys.Separator Then
            FuncKeysModule(e.KeyValue)
            e.Handled = True
        End If
    End Sub

    Private Sub btnborrarderecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnborrarderecha.KeyPress

        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)
        End If
        Separador_de_Numeros(txtmonto, e)

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If txtmonto.Text <> "" Then


            TXTTOTALACTUAL.Text = txt_total_suma.Text
            If txtmonto.Text = "" Then txtmonto.Text = 0
            If txtmonto.Text * 1 < txt_total_suma.Text * 1 And txtmonto.Text > 0 Then
                lbldescuento.Text = txt_total_suma.Text * 1 - txtmonto.Text * 1
                lblporcentaje.Text = (TXTTOTALACTUAL.Text * 1 - txtmonto.Text * 1) / TXTTOTALACTUAL.Text * 1
                aplicar_descuento_a_cada_producto_en_detalle_venta()
                sumar()

                txtmonto.Clear()


            ElseIf txtmonto.Text * 1 >= txt_total_suma.Text * 1 Then
                MsgBox("El descuento Tiene que ser menor al TOTAL actual y mayor que 0")
            End If
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnTecladoVirtual_Click(sender As Object, e As EventArgs) Handles btnTecladoVirtual.Click
        Process.Start("osk.exe")
    End Sub

    Private Sub TimerDisposeMascara_Tick(sender As Object, e As EventArgs) Handles TimerDisposeMascara.Tick
        TimerDisposeMascara.Stop()

        MASCARA1.Dispose()
    End Sub

    Private Sub befectivo_MouseMove(sender As Object, e As MouseEventArgs) Handles befectivo.MouseMove

        befectivo.ForeColor = Color.Black
    End Sub
    Private Sub befectivo_MouseLeave(sender As Object, e As EventArgs) Handles befectivo.MouseLeave

        befectivo.ForeColor = Color.White
    End Sub
    Private Sub bmixto_MouseMove(sender As Object, e As MouseEventArgs) Handles bmixto.MouseMove

        bmixto.ForeColor = Color.Black
    End Sub
    Private Sub bmixto_MouseLeave(sender As Object, e As EventArgs) Handles bmixto.MouseLeave

        bmixto.ForeColor = Color.White
    End Sub
    Private Sub bcredito_MouseMove(sender As Object, e As MouseEventArgs) Handles bcredito.MouseMove
        If lbltema.Text = "Elegante Black" Then
            bcredito.ForeColor = Color.Black

        End If
    End Sub
    Private Sub bcredito_MouseLeave(sender As Object, e As EventArgs) Handles bcredito.MouseLeave
        If lbltema.Text = "Elegante Black" Then
            bcredito.ForeColor = Color.White

        End If
    End Sub

    Private Sub btarjeta_MouseMove(sender As Object, e As MouseEventArgs) Handles btarjeta.MouseMove

        btarjeta.ForeColor = Color.Black

    End Sub
    Private Sub btarjeta_MouseLeave(sender As Object, e As EventArgs) Handles btarjeta.MouseLeave

        btarjeta.ForeColor = Color.White
    End Sub

    Private Sub txtbuscar_Resize(sender As Object, e As EventArgs) Handles txtbuscar.Resize

    End Sub
End Class

