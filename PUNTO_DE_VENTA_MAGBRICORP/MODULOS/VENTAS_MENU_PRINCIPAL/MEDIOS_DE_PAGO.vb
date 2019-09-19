

Imports System.Data.SqlClient

Imports System.Drawing.Printing

Imports Telerik.Reporting.Processing

Imports System.Management
Public Class MEDIOS_DE_PAGO
    Dim DOCUMENTO As PrintDocument
    Private MisDiscos As New ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard")
    Private DiscInfo As New ManagementObject

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles befectivo.Click
        pefectivo.Visible = True
        ptarjeta.Visible = False
        pcredito.Visible = False
        mpanel.Visible = False
        befectivo.BackColor = Color.PaleGreen
        btarjeta.BackColor = Color.White
        bcredito.BackColor = Color.White
        bmixto.BackColor = Color.White
    End Sub

    Private Sub MEDIOS_DE_PAGO_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            If txtefectivo2.Text = "" Then txtefectivo2.Text = 0
            If txtcredito2.Text = "" Then txtcredito2.Text = 0
            If txttarjeta2.Text = "" Then txttarjeta2.Text = 0
            If TXTVUELTO.Text = "" Then TXTVUELTO.Text = 0

            If txtefectivo2.Text = "" Then txtefectivo2.Text = 0
            If txtcredito2.Text = "" Then txtcredito2.Text = 0
            If txttarjeta2.Text = "" Then txttarjeta2.Text = 0
            If TXTVUELTO.Text = "" Then TXTVUELTO.Text = 0

            actualizar_serie_mas_uno()
            If txttipo.Text = "EFECTIVO" And TXTVUELTO.Text >= 0 Then

                ''CONFIRMAR_VENTA()

                MASCARA1.Dispose()
                VENTAS_MENU_PRINCIPAL.Timer3.Start()

                Close()
            ElseIf txttipo.Text = "EFECTIVO" And TXTVUELTO.Text < 0 Then
                Dim result As DialogResult
                result = MessageBox.Show("El vuelto no puede ser menor a el Total pagado ", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            If txttipo.Text = "CREDITO" And datalistadoclientes.Visible = False Then
                ''CONFIRMAR_VENTA()
                MASCARA1.Dispose()
                VENTAS_MENU_PRINCIPAL.Timer3.Start()

                Close()
            ElseIf txttipo.Text = "CREDITO" And datalistadoclientes.Visible = True Then
                Dim result As DialogResult
                result = MessageBox.Show("Seleccione un Cliente para Activar Pago a Credito", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

            If txtefectivo2.Text = "" Then txtefectivo2.Text = 0
            If txtcredito2.Text = "" Then txtcredito2.Text = 0
            If txttarjeta2.Text = "" Then txttarjeta2.Text = 0

            If txttipo.Text = "MIXTO" And txtrestante.Text = 0 Then

                If txtcredito2.Text * 1 >= 0 And datalistadoclientes2.Visible = True Then

                    'CONFIRMAR_VENTA()
                    MASCARA1.Dispose()
                    VENTAS_MENU_PRINCIPAL.Timer3.Start()

                    Close()
                Else
                    Dim result As DialogResult
                    result = MessageBox.Show("Seleccione un Cliente para Activar Pago a Credito", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If

            ElseIf txttipo.Text = "MIXTO" And txtrestante.Text <> 0 Then
                Dim result As DialogResult
                result = MessageBox.Show("La cantidad Restante tiene que ser 0 ", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

        End If
    End Sub


    Sub MOSTRAR_cajas_por_serial()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("MOSTRAR_cajas_por_serial", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@serial", lblIDSERIAL.Text)

            da.Fill(dt)
            DATALISTADOcajas.DataSource = dt
            Cerrar()

        Catch ex As Exception ': MessageBox.Show(ex.Message)
        End Try


    End Sub
    Sub validar_tipos_de_comprobantes()


        buscar_Tipo_de_documentos_para_insertar_en_ventas()
        Try

            txtserie.Text = dtComprobantes.SelectedCells.Item(3).Value
            txtnumerofin.Text = dtComprobantes.SelectedCells.Item(5).Value + 1
            lblCantidad_de_numeros.Text = dtComprobantes.SelectedCells.Item(4).Value
            lblCorrelativoconCeros.Text = ceros(txtnumerofin.Text, lblCantidad_de_numeros.Text)
        Catch ex As Exception

        End Try
    End Sub
    Sub fechasprueba()
        Dim fecha As String
        Dim fecha1 As String
        Dim dia As String
        Dim count As Integer
        fecha = "01/06/2019"
        fecha1 = "30/06/2019"
        'fecha1 = DateAdd("D", 1, fecha1)
        While Format(fecha, "short date") <> Format(fecha1, "short date")
            dia = Weekday(fecha)
            If dia <> "6" Then
                count = count + 1
            End If
            'fecha = DateAdd("D", 1, fecha)
        End While
        Label1.Text = count
    End Sub
    Dim moneda As String
    Sub mostrar_moneda_de_empresa()


        Dim com As New SqlCommand("Select Moneda From Empresa", conexion)

        Try
            abrir()
            moneda = (com.ExecuteScalar())
            Cerrar()


        Catch ex As Exception
            moneda = ""
        End Try


    End Sub
    Private Sub MEDIOS_DE_PAGO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

        MOSTRAR_comprobante_serializado_POR_DEFECTO()
        mostrar_moneda_de_empresa()
        btnGuardarImprimirdirecto.Text = "Guardar e Imprimir " & lblComprobante.Text & " (Enter)"
        validar_tipos_de_comprobantes()
        txtnumerofin.BackColor = Color.White
        LBLidVenta.Text = VENTAS_MENU_PRINCIPAL.txtidventa.Text
        TXTVUELTO.Text = 0
        txtrestante.Text = 0
        TXTTOTAL.Text = moneda & " " & VENTAS_MENU_PRINCIPAL.txt_total_suma.Text
        txt_total_suma.Text = VENTAS_MENU_PRINCIPAL.txt_total_suma.Text
        txtclientesolicitabnte3.Text = ""
        txtReferencia.Text = ""
        PANEL_CLIENTE_FACTURA.Visible = True
        If txttipo.Text = "EFECTIVO" Then
            TXTPAGOCON.Text = VENTAS_MENU_PRINCIPAL.txt_total_suma.Text
            TXTVUELTO.Text = ""
            pefectivo.Visible = True
            pcredito.Visible = False
            mpanel.Visible = False
            ptarjeta.Visible = False

            TXTPAGOCON.Focus()
        End If
        If txttipo.Text = "TARJETA" Then
            txtmonto_tarjeta.Text = VENTAS_MENU_PRINCIPAL.txt_total_suma.Text

            pefectivo.Visible = False
            pcredito.Visible = False
            mpanel.Visible = False
            ptarjeta.Visible = True

        End If
        If txttipo.Text = "CREDITO" Then
            PANEL_CLIENTE_FACTURA.Visible = False
            txtclientesolicitabnte.Focus()

            pefectivo.Visible = False
            pcredito.Visible = True
            mpanel.Visible = False
            ptarjeta.Visible = False
            buscar_clientes()

        End If
        If txttipo.Text = "MIXTO" Then

            PANEL_CLIENTE_FACTURA.Visible = True
            txtrestante.Text = VENTAS_MENU_PRINCIPAL.txt_total_suma.Text
            pefectivo.Visible = False
            ptarjeta.Visible = False
            pcredito.Visible = False
            mpanel.Visible = True
            txtefectivo2.Text = 0
            txtcredito2.Text = 0
            txttarjeta2.Text = 0


        End If
        TXTVUELTO.Text = 0.0



        Dim MiInfo = From Hd As ManagementObject In MisDiscos.Get Select Hd
        DiscInfo = MiInfo(0)
        lblIDSERIAL.Text = DiscInfo.Properties("SerialNumber").Value
        MOSTRAR_cajas_por_serial()
        Try
            cbxTiket.Text = DATALISTADOcajas.SelectedCells.Item(6).Value
        Catch ex As Exception

        End Try
        cargar_impresoras_del_equipo()
        validar_tipos_de_comprobantes()
    End Sub
    Sub MOSTRAR_comprobante_serializado_POR_DEFECTO()

        Dim importe As String
        Dim com As New SqlCommand("select Id_tipodoc  from Serializacion WHERE Por_defecto='SI'", conexion)
        Try
            abrir()
            importe = (com.ExecuteScalar()) 'asignamos el valor del importe
            Cerrar()
            lblComprobante.Text = importe

        Catch ex As Exception
            lblComprobante.Text = 0
        End Try
        FlowLayoutPanel3.Controls.Clear()
        dibujarCOMPROBANTES()
    End Sub
    Sub dibujarCOMPROBANTES()
        FlowLayoutPanel3.Controls.Clear()
        If txtcredito2.Text = "" Then txtcredito2.Text = 0
        Try
            abrir()
            Dim query As String = "select Id_tipodoc  from Serializacion where destino='VENTAS'"
            Dim cmd As New SqlCommand(query, conexion)
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read()
                Dim b As New Button()
                b.Text = rdr("Id_tipodoc").ToString()
                b.Name = rdr("Id_tipodoc").ToString()
                b.Size = New System.Drawing.Size(191, 60)
                b.BackColor = Color.FromArgb(75, 70, 71)
                b.Font = New System.Drawing.Font(10, 13)
                b.FlatStyle = FlatStyle.Flat
                b.ForeColor = Color.WhiteSmoke
                FlowLayoutPanel3.Controls.Add(b)
                If b.Text = lblComprobante.Text Then
                    b.Visible = False


                End If

                AddHandler b.Click, AddressOf miEvento

            End While
            Cerrar()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub miEvento(ByVal sender As System.Object, ByVal e As EventArgs)
        lblComprobante.Text = DirectCast(sender, Button).Text
        dibujarCOMPROBANTES()
        validar_tipos_de_comprobantes()
        If lblComprobante.Text = "FACTURA" And txttipo.Text = "CREDITO" Then
            lblindicador_de_factura_1.Text = "Cliente: (Obligatorio)"
            lblindicador_de_factura_1.ForeColor = Color.Red

            PANEL_CLIENTE_FACTURA.Visible = False
        End If
        If lblComprobante.Text = "FACTURA" And txttipo.Text = "MIXTO" And txtcredito2.Text = 0 Then
            PANEL_CLIENTE_FACTURA.Visible = True
            lblindicador_de_factura_1.Text = "Cliente: (Obligatorio)"
            lblindicador_de_factura_1.ForeColor = Color.Red
        ElseIf lblComprobante.Text = "FACTURA" And txttipo.Text = "MIXTO" And txtcredito2.Text > 0 Then
            PANEL_CLIENTE_FACTURA.Visible = False
        End If



        If lblComprobante.Text = "FACTURA" And txttipo.Text = "EFECTIVO" Then
            PANEL_CLIENTE_FACTURA.Visible = True
            lblindicador_de_factura_1.Text = "Cliente: (Obligatorio)"
            lblindicador_de_factura_1.ForeColor = Color.Red

        ElseIf lblComprobante.Text <> "FACTURA" And txttipo.Text = "EFECTIVO" Then
            PANEL_CLIENTE_FACTURA.Visible = True
            lblindicador_de_factura_1.Text = "Cliente: (Opcional)"
            lblindicador_de_factura_1.ForeColor = Color.DimGray
        End If



        If lblComprobante.Text = "FACTURA" And txttipo.Text = "TARJETA" Then
            PANEL_CLIENTE_FACTURA.Visible = True
            lblindicador_de_factura_1.Text = "Cliente: (Obligatorio)"
            lblindicador_de_factura_1.ForeColor = Color.Red

        ElseIf lblComprobante.Text <> "FACTURA" And txttipo.Text = "TARJETA" Then
            PANEL_CLIENTE_FACTURA.Visible = True
            lblindicador_de_factura_1.Text = "Cliente: (Opcional)"
            lblindicador_de_factura_1.ForeColor = Color.DimGray
        End If

        If lblComprobante.Text = "FACTURA" And txttipo.Text = "MIXTO" And datalistadoclientes2.Visible = True Then
            PANEL_CLIENTE_FACTURA.Visible = True
            lblindicador_de_factura_1.Text = "Cliente: (Obligatorio)"
            lblindicador_de_factura_1.ForeColor = Color.Red
        ElseIf lblComprobante.Text = "FACTURA" And txttipo.Text = "MIXTO" And datalistadoclientes2.Visible = False Then
            PANEL_CLIENTE_FACTURA.Visible = False
        ElseIf lblComprobante.Text <> "FACTURA" And txttipo.Text = "MIXTO" And datalistadoclientes2.Visible = True Then
            PANEL_CLIENTE_FACTURA.Visible = True
            lblindicador_de_factura_1.Text = "Cliente: (Opcional)"
            lblindicador_de_factura_1.ForeColor = Color.DimGray
        ElseIf lblComprobante.Text <> "FACTURA" And txttipo.Text = "MIXTO" And datalistadoclientes2.Visible = False Then
            PANEL_CLIENTE_FACTURA.Visible = False
        End If

    End Sub
    Sub LIMPIAR()
        txtclientesolicitabnte.Text = ""
        lblidcliente_creditos.Text = ""
        datalistadoclientes.Visible = True

    End Sub
    Sub cargar_impresoras_del_equipo()
        cbxTiket.Items.Clear()
        For I = 0 To PrinterSettings.InstalledPrinters.Count - 1
            cbxTiket.Items.Add(PrinterSettings.InstalledPrinters.Item(I))
        Next
        cbxTiket.Items.Add("Ninguna")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs)


        MASCARA1.Dispose()
        Close()
        VENTAS_MENU_PRINCIPAL.txtbuscar.Focus()



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
    Private Sub TXTPAGOCON_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPAGOCON.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then

            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(TXTPAGOCON, e)
    End Sub

    Private Sub TXTPAGOCON_TextChanged(sender As Object, e As EventArgs) Handles TXTPAGOCON.TextChanged
        Try

            TXTVUELTO.Text = TXTPAGOCON.Text * 1 - VENTAS_MENU_PRINCIPAL.txt_total_suma.Text * 1
            If TXTVUELTO.Text < 0 Then
                PADVER.Visible = True
                TXTADVER.Visible = True

            End If
            If TXTVUELTO.Text >= 0 Then
                PADVER.Visible = False
                TXTADVER.Visible = False

            End If
            If TXTVUELTO.Text = "" Then
                TXTVUELTO.Text = 0.0
            End If
        Catch ex As Exception
            TXTVUELTO.Text = 0.0
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles btarjeta.Click
        txtmonto_tarjeta.Text = VENTAS_MENU_PRINCIPAL.txt_total_suma.Text
        pefectivo.Visible = False
        ptarjeta.Visible = True
        pcredito.Visible = False
        mpanel.Visible = False
        befectivo.BackColor = Color.White
        btarjeta.BackColor = Color.PaleGreen
        bcredito.BackColor = Color.White
        bmixto.BackColor = Color.White

    End Sub
    Sub buscar_clientes3()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_cliente_POR_nombre_PARA_VENTAS_todos", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtclientesolicitabnte3.Text)
            da.Fill(dt)
            datalistadoclientes3.DataSource = dt
            datalistadoclientes3.Columns(2).Visible = False
            datalistadoclientes3.Columns(3).Visible = False
            datalistadoclientes3.Columns(4).Visible = False
            datalistadoclientes3.Columns(5).Visible = False
            datalistadoclientes3.Columns(1).Width = 420
            Cerrar()
        Catch ex As Exception
            '
        End Try


    End Sub
    Sub buscar_clientes()
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
            datalistadoclientes.Columns(5).Visible = False
            datalistadoclientes.Columns(1).Width = 420
            Cerrar()
        Catch ex As Exception
            '
        End Try


    End Sub
    Sub buscarclientes2()
        Dim dt2 As New DataTable
        Dim da2 As SqlDataAdapter
        Try
            abrir()
            da2 = New SqlDataAdapter("buscar_cliente_POR_nombre_PARA_VENTAS_todos", conexion)
            da2.SelectCommand.CommandType = 4
            da2.SelectCommand.Parameters.AddWithValue("@letra", txtclientesolicitabnte2.Text)
            da2.Fill(dt2)
            datalistadoclientes2.DataSource = dt2
            datalistadoclientes2.Columns(2).Visible = False
            datalistadoclientes2.Columns(3).Visible = False
            datalistadoclientes2.Columns(4).Visible = False
            datalistadoclientes2.Columns(5).Visible = False
            datalistadoclientes2.Columns(1).Width = 420
            Cerrar()
        Catch ex As Exception
            '
        End Try


    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles bcredito.Click

        pefectivo.Visible = False
        ptarjeta.Visible = False
        pcredito.Visible = True
        mpanel.Visible = False
        befectivo.BackColor = Color.White
        btarjeta.BackColor = Color.White
        bcredito.BackColor = Color.PaleGreen
        bmixto.BackColor = Color.White

    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        MASCARA1.Show()
        Registro_clientes.ShowDialog()

    End Sub

    Private Sub txtclientesolicitabnte_Click(sender As Object, e As EventArgs) Handles txtclientesolicitabnte.Click
        datalistadoclientes.Visible = True
        txtclientesolicitabnte.Text = ""
    End Sub

    Private Sub txtclientesolicitabnte_TextChanged(sender As Object, e As EventArgs) Handles txtclientesolicitabnte.TextChanged
        buscar_clientes()
        If txtclientesolicitabnte.Text = "" Then
            datalistadoclientes.Visible = True

        End If
    End Sub

    Private Sub datalistadoclientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoclientes.CellClick
        Try



            txtclientesolicitabnte.Text = datalistadoclientes.SelectedCells.Item(1).Value
            datalistadoclientes.Visible = False
            LBL_DIRECCION.Text = datalistadoclientes.SelectedCells.Item(3).Value
            LBL_CELULAR.Text = datalistadoclientes.SelectedCells.Item(4).Value
            txtruc.Text = datalistadoclientes.SelectedCells.Item(5).Value
            lblidcliente_creditos.Text = datalistadoclientes.SelectedCells.Item(2).Value

        Catch ex As Exception

        End Try

    End Sub


    Private Sub txtclientesolicitabnte2_Click(sender As Object, e As EventArgs) Handles txtclientesolicitabnte2.Click
        datalistadoclientes2.Visible = True
        txtclientesolicitabnte2.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtclientesolicitabnte2.TextChanged
        buscarclientes2()
        If txtclientesolicitabnte2.Text = "" Then
            datalistadoclientes2.Visible = True

        End If
    End Sub

    Private Sub datalistadoclientes2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoclientes2.CellClick
        Try



            txtclientesolicitabnte2.Text = datalistadoclientes2.SelectedCells.Item(1).Value
            datalistadoclientes2.Visible = False
            PANEL_CLIENTE_FACTURA.Visible = False


        Catch ex As Exception

        End Try
    End Sub


    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles bmixto.Click
        txtrestante.Text = VENTAS_MENU_PRINCIPAL.txt_total_suma.Text
        pefectivo.Visible = False
        ptarjeta.Visible = False
        pcredito.Visible = False
        mpanel.Visible = True
        txtefectivo2.Text = 0
        txtcredito2.Text = 0
        txttarjeta2.Text = 0
        befectivo.BackColor = Color.White
        btarjeta.BackColor = Color.White
        bcredito.BackColor = Color.White
        bmixto.BackColor = Color.PaleGreen
    End Sub

    Private Sub txtefectivo2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtefectivo2.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then

            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtefectivo2, e)
    End Sub

    Private Sub txtefectivo2_TextChanged(sender As Object, e As EventArgs) Handles txtefectivo2.TextChanged

        Try
            txtrestante.Text = VENTAS_MENU_PRINCIPAL.txt_total_suma.Text * 1 - txtefectivo2.Text * 1 - txtcredito2.Text * 1 - txttarjeta2.Text * 1
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
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
    End Sub

    Private Sub txtcredito2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcredito2.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then

            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtcredito2, e)
    End Sub

    Private Sub txtcredito2_TextChanged(sender As Object, e As EventArgs) Handles txtcredito2.TextChanged

        buscarclientes2()
        pmixtocredito.Visible = True

        Try
            txtrestante.Text = VENTAS_MENU_PRINCIPAL.txt_total_suma.Text * 1 - txtefectivo2.Text * 1 - txtcredito2.Text * 1 - txttarjeta2.Text * 1
            txtrestante.Text = Format(CType(txtrestante.Text, Decimal), "##0.0")
        Catch ex As Exception

        End Try


    End Sub

    Private Sub txttarjeta2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttarjeta2.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then

            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txttarjeta2, e)
    End Sub

    Private Sub txttarjeta2_TextChanged(sender As Object, e As EventArgs) Handles txttarjeta2.TextChanged

        Try
            txtrestante.Text = VENTAS_MENU_PRINCIPAL.txt_total_suma.Text * 1 - txtefectivo2.Text * 1 - txtcredito2.Text * 1 - txttarjeta2.Text * 1
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TXTCOMPROBANTE_SelectedIndexChanged(sender As Object, e As EventArgs)
        buscar_Tipo_de_documentos_para_insertar_en_ventas()

        Try
            txtserie.Text = dtComprobantes.SelectedCells.Item(3).Value
            txtnumerofin.Text = dtComprobantes.SelectedCells.Item(5).Value
            lblCorrelativoconCeros.Text = ceros(txtnumerofin.Text, txtnumerofin.Text)
        Catch ex As Exception

        End Try

    End Sub
    Sub buscar_Tipo_de_documentos_para_insertar_en_ventas()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_Tipo_de_documentos_para_insertar_en_ventas", conexion)
            da.SelectCommand.CommandType = 4


            da.SelectCommand.Parameters.AddWithValue("@letra", lblComprobante.Text)

            da.Fill(dt)
            dtComprobantes.DataSource = dt
            Cerrar()


        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtclientesolicitabnte3_TextChanged(sender As Object, e As EventArgs) Handles txtclientesolicitabnte3.TextChanged
        buscar_clientes3()
        'If txtclientesolicitabnte3.Text = "" Then
        '    datalistadoclientes3.Visible = True

        'End If
    End Sub

    Private Sub datalistadoclientes3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoclientes3.CellClick
        Try



            txtclientesolicitabnte3.Text = datalistadoclientes3.SelectedCells.Item(1).Value
            datalistadoclientes3.Visible = False
            lbldireccion.Text = datalistadoclientes3.SelectedCells.Item(3).Value
            lblcelular.Text = datalistadoclientes3.SelectedCells.Item(4).Value
            lblruc.Text = datalistadoclientes3.SelectedCells.Item(5).Value
            lblidcliente.Text = datalistadoclientes3.SelectedCells.Item(2).Value

        Catch ex As Exception

        End Try
    End Sub
    Sub MOSTRAR_cliente_standar()

        Dim importe As String
        Dim com As New SqlCommand("select*from clientes where Cliente='NEUTRO'", conexion)
        Try
            abrir()
            importe = (com.ExecuteScalar()) 'asignamos el valor del importe
            Cerrar()
            lblidcliente.Text = importe

        Catch ex As Exception
            lblidcliente.Text = 0
        End Try
    End Sub
    Sub CONVERTIR_TOTAL_A_LETRAS()
        Dim numero As Integer
        numero = Int(txt_total_suma.Text)
        TXTTOTAL_STRING.Text = Num2Text(numero)
        Dim a() As String
        a = Split(txt_total_suma.Text, ".")
        txttotaldecimal.Text = a(1) & "0"
        txtnumeroconvertidoenletra.Text = TXTTOTAL_STRING.Text & " CON " & txttotaldecimal.Text & "/100 "

    End Sub
    Sub CONFIRMAR_VENTA_FECTIVO()


        If txtclientesolicitabnte3.Text = "" Then
            MOSTRAR_cliente_standar()
        End If

        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("actualizartotal_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", VENTAS_MENU_PRINCIPAL.txtidventa.Text)
            cmd.Parameters.AddWithValue("@montototal", VENTAS_MENU_PRINCIPAL.txt_total_suma.Text)
            cmd.Parameters.AddWithValue("@IGV", VENTAS_MENU_PRINCIPAL.lbligv.Text)
            cmd.Parameters.AddWithValue("@Saldo", TXTVUELTO.Text)

            cmd.Parameters.AddWithValue("@Tipo_de_pago", txttipo.Text)

            cmd.Parameters.AddWithValue("@Estado", "CONFIRMADO")
            cmd.Parameters.AddWithValue("@idcliente ", lblidcliente.Text)


            cmd.Parameters.AddWithValue("@Id_series", lblComprobante.Text)
            cmd.Parameters.AddWithValue("@Numero_de_doc", (txtserie.Text & "-" & lblCorrelativoconCeros.Text))
            cmd.Parameters.AddWithValue("@fecha_venta", Now())
            cmd.Parameters.AddWithValue("@ACCION", "VENTA")

            cmd.Parameters.AddWithValue("@Fecha_de_pago", "PAGO AL CONTADO")
            cmd.Parameters.AddWithValue("@Pago_con", lblpagocon.Text)
            cmd.Parameters.AddWithValue("@Referencia_tarjeta", "NULO")


            cmd.ExecuteNonQuery()
            Cerrar()
            lblProcede.Text = "PROCEDE"


        Catch ex As Exception : MessageBox.Show(ex.Message)
            lblProcede.Text = "NO PROCEDE"
        End Try



    End Sub
    Sub CONFIRMAR_VENTA_TARJETA()
        If txtclientesolicitabnte3.Text = "" Then
            MOSTRAR_cliente_standar()
        End If

        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("actualizartotal_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", VENTAS_MENU_PRINCIPAL.txtidventa.Text)
            cmd.Parameters.AddWithValue("@montototal", VENTAS_MENU_PRINCIPAL.txt_total_suma.Text)
            cmd.Parameters.AddWithValue("@IGV", VENTAS_MENU_PRINCIPAL.lbligv.Text)
            cmd.Parameters.AddWithValue("@Saldo", 0)

            cmd.Parameters.AddWithValue("@Tipo_de_pago", txttipo.Text)

            cmd.Parameters.AddWithValue("@Estado", "CONFIRMADO")
            cmd.Parameters.AddWithValue("@idcliente ", lblidcliente.Text)


            cmd.Parameters.AddWithValue("@Id_series", lblComprobante.Text)
            cmd.Parameters.AddWithValue("@Numero_de_doc", (txtserie.Text & "-" & lblCorrelativoconCeros.Text))
            cmd.Parameters.AddWithValue("@fecha_venta", Now())
            cmd.Parameters.AddWithValue("@ACCION", "VENTA")

            cmd.Parameters.AddWithValue("@Fecha_de_pago", "PAGO CON TARJETA")
            cmd.Parameters.AddWithValue("@Pago_con", 0)
            cmd.Parameters.AddWithValue("@Referencia_tarjeta", txtReferencia.Text)

            cmd.ExecuteNonQuery()
            Cerrar()
            lblProcede.Text = "PROCEDE"


        Catch ex As Exception : MessageBox.Show(ex.Message)
            lblProcede.Text = "NO PROCEDE"
        End Try



    End Sub
    Sub CONFIRMAR_VENTA_MIXTO()



        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("actualizartotal_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", VENTAS_MENU_PRINCIPAL.txtidventa.Text)
            cmd.Parameters.AddWithValue("@montototal", VENTAS_MENU_PRINCIPAL.txt_total_suma.Text)
            cmd.Parameters.AddWithValue("@IGV", VENTAS_MENU_PRINCIPAL.lbligv.Text)
            cmd.Parameters.AddWithValue("@Saldo", txtcredito2.Text)

            cmd.Parameters.AddWithValue("@Tipo_de_pago", txttipo.Text)

            cmd.Parameters.AddWithValue("@Estado", "CONFIRMADO")

            If txtcredito2.Text > 0 Then
                cmd.Parameters.AddWithValue("@idcliente ", datalistadoclientes2.SelectedCells.Item(2).Value)
            ElseIf txtcredito2.Text = 0 Then
                cmd.Parameters.AddWithValue("@idcliente ", 0)

            End If

            cmd.Parameters.AddWithValue("@Id_series", lblComprobante.Text)
            cmd.Parameters.AddWithValue("@Numero_de_doc", (txtserie.Text & "-" & lblCorrelativoconCeros.Text))
            cmd.Parameters.AddWithValue("@fecha_venta", Now())
            cmd.Parameters.AddWithValue("@ACCION", "VENTA")

            cmd.Parameters.AddWithValue("@Fecha_de_pago", "PAGO MIXTO")
            cmd.Parameters.AddWithValue("@Pago_con", txtefectivo2.Text)
            cmd.Parameters.AddWithValue("@Referencia_tarjeta", "NULO")

            cmd.ExecuteNonQuery()
            Cerrar()
            lblProcede.Text = "PROCEDE"


        Catch ex As Exception : MessageBox.Show(ex.Message)
            lblProcede.Text = "NO PROCEDE"
        End Try



    End Sub
    Sub CONFIRMAR_VENTA_CREDITO()


        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("actualizartotal_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", VENTAS_MENU_PRINCIPAL.txtidventa.Text)
            cmd.Parameters.AddWithValue("@montototal", VENTAS_MENU_PRINCIPAL.txt_total_suma.Text)
            cmd.Parameters.AddWithValue("@IGV", VENTAS_MENU_PRINCIPAL.lbligv.Text)
            cmd.Parameters.AddWithValue("@Saldo", TXTVUELTO.Text)

            cmd.Parameters.AddWithValue("@Tipo_de_pago", txttipo.Text)

            cmd.Parameters.AddWithValue("@Estado", "CONFIRMADO")
            cmd.Parameters.AddWithValue("@idcliente ", lblidcliente_creditos.Text)


            cmd.Parameters.AddWithValue("@Id_series", lblComprobante.Text)
            cmd.Parameters.AddWithValue("@Numero_de_doc", (txtserie.Text & "-" & lblCorrelativoconCeros.Text))
            cmd.Parameters.AddWithValue("@fecha_venta", Now())
            cmd.Parameters.AddWithValue("@ACCION", "VENTA")

            cmd.Parameters.AddWithValue("@Fecha_de_pago", "CREDITO")
            cmd.Parameters.AddWithValue("@Pago_con", 0)
            cmd.Parameters.AddWithValue("@Referencia_tarjeta", "NULO")

            cmd.ExecuteNonQuery()
            Cerrar()
            lblProcede.Text = "PROCEDE"


        Catch ex As Exception : MessageBox.Show(ex.Message)
            lblProcede.Text = "NO PROCEDE"
        End Try



    End Sub
    Sub aumentar_monto_a_cliente()
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("aumentar_saldo_a_cliente", conexion)
            cmd.CommandType = 4

            If txttipo.Text = "CREDITO" Then
                cmd.Parameters.AddWithValue("@Saldo", VENTAS_MENU_PRINCIPAL.txt_total_suma.Text)
                cmd.Parameters.AddWithValue("@idcliente", datalistadoclientes.SelectedCells.Item(2).Value)
            ElseIf txttipo.Text = "MIXTO" Then
                cmd.Parameters.AddWithValue("@Saldo", txtcredito2.Text)
                cmd.Parameters.AddWithValue("@idcliente", datalistadoclientes2.SelectedCells.Item(2).Value)
            End If


            cmd.ExecuteNonQuery()
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)
            '
        End Try
    End Sub
    Sub actualizar_serie_mas_uno()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("actualizar_serializacion_mas_uno", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idserie", dtComprobantes.SelectedCells.Item(6).Value)
            cmd.Parameters.AddWithValue("@numerofin", txtnumerofin.Text)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub disminuir_stock_productos()
        Dim cmdaumentarstock As SqlCommand
        Try
            For Each row As DataGridViewRow In VENTAS_MENU_PRINCIPAL.datalistadomateriales.Rows

                Dim idlote As Integer = Convert.ToInt32(row.Cells("Id_producto").Value)
                Dim cantidad As Decimal = Convert.ToDouble(row.Cells("Cant").Value)
                Try
                    abrir()

                    cmdaumentarstock = New SqlCommand("disminuir_stock", conexion)
                    cmdaumentarstock.CommandType = 4
                    cmdaumentarstock.Parameters.AddWithValue("@Id_presentacionfraccionada", idlote)
                    cmdaumentarstock.Parameters.AddWithValue("@cantidad", cantidad)
                    cmdaumentarstock.ExecuteNonQuery()
                    Cerrar()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Sub mostrar_Ticket_lleno()
        Dim rptFREPORT2 As New Ticket_report()
        Dim dtMA As New DataTable
        Dim daMA As SqlDataAdapter
        If txtclientesolicitabnte3.Text = "" Then txtclientesolicitabnte3.Text = "Generico"
        Try
            abrir()
            daMA = New SqlDataAdapter("mostrar_ticket_impreso", conexion)
            daMA.SelectCommand.CommandType = 4
            daMA.SelectCommand.Parameters.AddWithValue("@idventa", LBLidVenta.Text)
            daMA.SelectCommand.Parameters.AddWithValue("@efectivo", TXTPAGOCON.Text)
            daMA.SelectCommand.Parameters.AddWithValue("@vuelto", TXTVUELTO.Text)
            daMA.Fill(dtMA)
            Cerrar()
            rptFREPORT2 = New Ticket_report
            rptFREPORT2.Table1.DataSource = dtMA
            rptFREPORT2.DataSource = dtMA

            ReportViewer1.Report = rptFREPORT2
            ReportViewer1.Refresh()


        Catch ex As Exception
            '
        End Try
    End Sub
    Private Sub IMPRIMIR(ByVal sender As Object, ByVal ev As PrintPageEventArgs)

    End Sub
    Sub imprimir_directo()
        mostrar_Ticket_lleno()
        Try
            DOCUMENTO = New PrintDocument
            AddHandler DOCUMENTO.PrintPage, AddressOf IMPRIMIR
            DOCUMENTO.PrinterSettings.PrinterName = cbxTiket.Text
            'DOCUMENTO.PrinterSettings.Copies = CInt(TextBoxCOPIAS.Text)
            If DOCUMENTO.PrinterSettings.IsValid Then
                Dim printerSettings As PrinterSettings = New PrinterSettings()
                printerSettings.PrinterName = cbxTiket.Text
                Dim reportProcessor As New ReportProcessor()
                reportProcessor.PrintReport(ReportViewer1.ReportSource, printerSettings)
            Else
                'MsgBox("PARAMETROS NO VALIDOS")
            End If
            MessageBox.Show("VENTA REALIZADA CORRECTAMENTE", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles btnGuardarImprimirdirecto.Click
        indicador = "DIRECTO"
        INGRESAR_LOS_DATOS()

        'If txtefectivo2.Text = "" Then txtefectivo2.Text = 0
        'If txtcredito2.Text = "" Then txtcredito2.Text = 0
        'If txttarjeta2.Text = "" Then txttarjeta2.Text = 0
        'If TXTVUELTO.Text = "" Then TXTVUELTO.Text = 0
        'If txtefectivo2.Text = "" Then txtefectivo2.Text = 0
        'If txtcredito2.Text = "" Then txtcredito2.Text = 0
        'If txttarjeta2.Text = "" Then txttarjeta2.Text = 0
        'If TXTVUELTO.Text = "" Then TXTVUELTO.Text = 0
        'If txttipo.Text = "EFECTIVO" And TXTVUELTO.Text >= 0 Then
        '    lblpagocon.Text = TXTPAGOCON.Text
        '    CONFIRMAR_VENTA_FECTIVO()

        '    If lblProcede.Text = "PROCEDE" Then
        '        actualizar_serie_mas_uno()
        '        disminuir_stock_productos()
        '        INSERTAR_KARDEX_SALIDA()

        '        VENTAS_MENU_PRINCIPAL.Timer3.Start()
        '        imprimir_directo()




        '        Close()
        '    ElseIf lblProcede.Text = "NO PROCEDE" Then
        '        txtnumerofin.Focus()
        '        txtnumerofin.BackColor = Color.NavajoWhite
        '    End If
        'ElseIf txttipo.Text = "EFECTIVO" And TXTVUELTO.Text < 0 Then
        '    Dim result As DialogResult
        '    result = MessageBox.Show("El vuelto no puede ser menor a el Total pagado ", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End If
        'If txttipo.Text = "CREDITO" And datalistadoclientes.Visible = False Then
        '    lblrestante.Text = 0
        '    lblpagocon.Text = 0
        '    CONFIRMAR_VENTA_CREDITO()
        '    If lblProcede.Text = "PROCEDE" Then
        '        actualizar_serie_mas_uno()
        '        disminuir_stock_productos()
        '        INSERTAR_KARDEX_SALIDA()
        '        aumentar_monto_a_cliente()

        '        VENTAS_MENU_PRINCIPAL.Timer3.Start()
        '        imprimir_directo()
        '        Close()
        '    ElseIf lblProcede.Text = "NO PROCEDE" Then
        '        txtnumerofin.Focus()
        '        txtnumerofin.BackColor = Color.NavajoWhite
        '    End If


        'ElseIf txttipo.Text = "CREDITO" And datalistadoclientes.Visible = True Then
        '    Dim result As DialogResult
        '    result = MessageBox.Show("Seleccione un Cliente para Activar Pago a Credito", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End If
        'If txtefectivo2.Text = "" Then txtefectivo2.Text = 0
        'If txtcredito2.Text = "" Then txtcredito2.Text = 0
        'If txttarjeta2.Text = "" Then txttarjeta2.Text = 0
        'If txttipo.Text = "MIXTO" And txtrestante.Text = 0 Then
        '    If txtcredito2.Text * 1 >= 0 And datalistadoclientes2.Visible = False Then
        '        lblrestante.Text = txtefectivo2.Text
        '        lblpagocon.Text = 0
        '        CONFIRMAR_VENTA_MIXTO()

        '        If lblProcede.Text = "PROCEDE" Then
        '            disminuir_stock_productos()
        '            INSERTAR_KARDEX_SALIDA()
        '            If (txtcredito2.Text > 0) Then
        '                aumentar_monto_a_cliente()
        '            End If

        '            VENTAS_MENU_PRINCIPAL.Timer3.Start()
        '            imprimir_directo()
        '            Close()
        '        ElseIf lblProcede.Text = "NO PROCEDE" Then
        '            txtnumerofin.Focus()
        '            txtnumerofin.BackColor = Color.NavajoWhite
        '        End If


        '    Else
        '        Dim result As DialogResult
        '        result = MessageBox.Show("Seleccione un Cliente para Activar Pago a Credito", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        '    End If
        'ElseIf txttipo.Text = "MIXTO" And txtrestante.Text <> 0 Then
        '    Dim result As DialogResult
        '    result = MessageBox.Show("La cantidad Restante tiene que ser 0 ", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End If
        'If txttipo.Text = "TARJETA" Then

        'lblpagocon.Text = txtmonto_tarjeta.Text
        '    CONFIRMAR_VENTA_FECTIVO()

        '    If lblProcede.Text = "PROCEDE" Then
        '        actualizar_serie_mas_uno()
        '        disminuir_stock_productos()
        '        INSERTAR_KARDEX_SALIDA()

        '        VENTAS_MENU_PRINCIPAL.Timer3.Start()
        '        imprimir_directo()

        '        Close()
        '    ElseIf lblProcede.Text = "NO PROCEDE" Then
        '        txtnumerofin.Focus()
        '        txtnumerofin.BackColor = Color.NavajoWhite
        '    End If
        'ElseIf txttipo.Text = "EFECTIVO" And TXTVUELTO.Text < 0 Then
        '    Dim result As DialogResult
        '    result = MessageBox.Show("El vuelto no puede ser menor a el Total pagado ", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End If
        'If txttipo.Text = "CREDITO" And datalistadoclientes.Visible = False Then
        '    lblrestante.Text = 0
        '    lblpagocon.Text = 0
        '    CONFIRMAR_VENTA_CREDITO()
        '    If lblProcede.Text = "PROCEDE" Then
        '        actualizar_serie_mas_uno()
        '        disminuir_stock_productos()
        '        INSERTAR_KARDEX_SALIDA()
        '        aumentar_monto_a_cliente()

        '        VENTAS_MENU_PRINCIPAL.Timer3.Start()
        '        imprimir_directo()
        '        Close()
        '    ElseIf lblProcede.Text = "NO PROCEDE" Then
        '        txtnumerofin.Focus()
        '        txtnumerofin.BackColor = Color.NavajoWhite
        '    End If





        'End If
    End Sub
    Sub INSERTAR_KARDEX_SALIDA()
        Try
            Dim cmd As New SqlCommand
            For Each row As DataGridViewRow In VENTAS_MENU_PRINCIPAL.datalistadomateriales.Rows

                Dim Id_producto As Integer = Convert.ToInt32(row.Cells("Id_producto").Value)
                Dim cantidad As Decimal = Convert.ToDouble(row.Cells("Cant").Value)
                Dim STOCK As Decimal = Convert.ToDouble(row.Cells("Stock").Value)
                abrir()

                cmd = New SqlCommand("insertar_KARDEX_SALIDA", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Fecha", Now())
                cmd.Parameters.AddWithValue("@Motivo", "Venta #" & lblComprobante.Text & " " & lblCorrelativoconCeros.Text)
                cmd.Parameters.AddWithValue("@Cantidad ", cantidad)

                cmd.Parameters.AddWithValue("@Id_producto", Id_producto)
                cmd.Parameters.AddWithValue("@Id_usuario", VENTAS_MENU_PRINCIPAL.lblidusuario.Text)
                cmd.Parameters.AddWithValue("@Tipo", "SALIDA")
                cmd.Parameters.AddWithValue("@Estado", "DESPACHO CONFIRMADO")
                cmd.Parameters.AddWithValue("@Id_caja", VENTAS_MENU_PRINCIPAL.lblidcaja.Text)
                cmd.ExecuteNonQuery()

                Cerrar()
            Next

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub
    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        MASCARA1.Show()
        Registro_clientes.ShowDialog()


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        buscar_clientes3()
        Timer2.Stop()

    End Sub
    Sub completar_con_ceros_los_texbox_de_otros_medios_de_pago()
        If txtefectivo2.Text = "" Then txtefectivo2.Text = 0
        If txtcredito2.Text = "" Then txtcredito2.Text = 0
        If txttarjeta2.Text = "" Then txttarjeta2.Text = 0
        If TXTVUELTO.Text = "" Then TXTVUELTO.Text = 0
        If txtefectivo2.Text = "" Then txtefectivo2.Text = 0
        If txtcredito2.Text = "" Then txtcredito2.Text = 0
        If txttarjeta2.Text = "" Then txttarjeta2.Text = 0
        If TXTVUELTO.Text = "" Then TXTVUELTO.Text = 0

        If txtefectivo2.Text = "" Then txtefectivo2.Text = 0
        If txtcredito2.Text = "" Then txtcredito2.Text = 0
        If txttarjeta2.Text = "" Then txttarjeta2.Text = 0
    End Sub
    Sub vender_en_efectivo()
        lblpagocon.Text = TXTPAGOCON.Text
        CONFIRMAR_VENTA_FECTIVO()

        If lblProcede.Text = "PROCEDE" Then
            actualizar_serie_mas_uno()
            disminuir_stock_productos()
            INSERTAR_KARDEX_SALIDA()

            VENTAS_MENU_PRINCIPAL.Timer3.Start()
            validar_tipo_de_impresion()

            Close()
        ElseIf lblProcede.Text = "NO PROCEDE" Then
            txtnumerofin.Focus()
            txtnumerofin.BackColor = Color.NavajoWhite
        End If
    End Sub
    Sub vender_a_credito()
        lblrestante.Text = 0
        lblpagocon.Text = 0
        CONFIRMAR_VENTA_CREDITO()
        If lblProcede.Text = "PROCEDE" Then
            actualizar_serie_mas_uno()
            disminuir_stock_productos()
            INSERTAR_KARDEX_SALIDA()
            aumentar_monto_a_cliente()

            VENTAS_MENU_PRINCIPAL.Timer3.Start()
            validar_tipo_de_impresion()
            Close()
        ElseIf lblProcede.Text = "NO PROCEDE" Then
            txtnumerofin.Focus()
            txtnumerofin.BackColor = Color.NavajoWhite
        End If

    End Sub
    Sub venta_mixto()
        lblrestante.Text = txtefectivo2.Text
        lblpagocon.Text = 0
        CONFIRMAR_VENTA_MIXTO()

        If lblProcede.Text = "PROCEDE" Then
            actualizar_serie_mas_uno()

            disminuir_stock_productos()
            INSERTAR_KARDEX_SALIDA()
            If (txtcredito2.Text > 0) Then
                aumentar_monto_a_cliente()
            End If

            VENTAS_MENU_PRINCIPAL.Timer3.Start()
            validar_tipo_de_impresion()
            Close()
        ElseIf lblProcede.Text = "NO PROCEDE" Then
            txtnumerofin.Focus()
            txtnumerofin.BackColor = Color.NavajoWhite
        End If
    End Sub
    Sub vender_con_tarjeta()


        lblpagocon.Text = TXTPAGOCON.Text
        CONFIRMAR_VENTA_TARJETA()

        If lblProcede.Text = "PROCEDE" Then
            actualizar_serie_mas_uno()
            disminuir_stock_productos()
            INSERTAR_KARDEX_SALIDA()

            VENTAS_MENU_PRINCIPAL.Timer3.Start()
            validar_tipo_de_impresion()

            Close()
        ElseIf lblProcede.Text = "NO PROCEDE" Then
            txtnumerofin.Focus()
            txtnumerofin.BackColor = Color.NavajoWhite
        End If
    End Sub
    Dim indicador As String
    Sub validar_tipo_de_impresion()
        If indicador = "VISTA PREVIA" Then
            Ticket_Form_Factura_boleta.Timer1.Start()
            Ticket_Form_Factura_boleta.ShowDialog()
        ElseIf indicador = "DIRECTO"
            imprimir_directo()
        End If



    End Sub
    Sub INGRESAR_LOS_DATOS()
        CONVERTIR_TOTAL_A_LETRAS()
        completar_con_ceros_los_texbox_de_otros_medios_de_pago()

        If txttipo.Text = "EFECTIVO" And TXTVUELTO.Text >= 0 Then
            vender_en_efectivo()
        ElseIf txttipo.Text = "EFECTIVO" And TXTVUELTO.Text < 0 Then
            Dim result As DialogResult
            result = MessageBox.Show("El vuelto no puede ser menor a el Total pagado ", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If txttipo.Text = "CREDITO" And datalistadoclientes.Visible = False Then
            vender_a_credito()
        ElseIf txttipo.Text = "CREDITO" And datalistadoclientes.Visible = True Then
            Dim result As DialogResult
            result = MessageBox.Show("Seleccione un Cliente para Activar Pago a Credito", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


        If txttipo.Text = "MIXTO" And txtrestante.Text = 0 Then
            If txtcredito2.Text * 1 >= 0 And datalistadoclientes2.Visible = False Then
                venta_mixto()
            Else
                Dim result As DialogResult
                result = MessageBox.Show("Seleccione un Cliente para Activar Pago a Credito", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        ElseIf txttipo.Text = "MIXTO" And txtrestante.Text <> 0 Then
            Dim result As DialogResult
            result = MessageBox.Show("La cantidad Restante tiene que ser 0 ", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If txttipo.Text = "TARJETA" Then
            If txtReferencia.Text <> "" Then
                vender_con_tarjeta()
            Else
                Dim result As DialogResult
                result = MessageBox.Show("Ingrese los 4 ultimos digitos de la Tarjeta", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtReferencia.Focus()
            End If
        End If
    End Sub
    Private Sub tocultar_Click(sender As Object, e As EventArgs) Handles tocultar.Click
        indicador = "VISTA PREVIA"
        INGRESAR_LOS_DATOS()

    End Sub

    Private Sub datalistadoclientes3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoclientes3.CellContentClick

    End Sub

    Private Sub datalistadoclientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoclientes.CellContentClick

    End Sub

    Private Sub pcredito_Paint(sender As Object, e As PaintEventArgs) Handles pcredito.Paint

    End Sub

    Private Sub FlowLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel4.Paint

    End Sub

    Private Sub btnFactura_Click(sender As Object, e As EventArgs)
        lblComprobante.Text = "FACTURA"
        validar_tipos_de_comprobantes()


    End Sub

    Private Sub BtnBoleta_Click(sender As Object, e As EventArgs)
        lblComprobante.Text = "BOLETA"
        validar_tipos_de_comprobantes()
    End Sub

    Private Sub BtnTicket_Click(sender As Object, e As EventArgs)
        lblComprobante.Text = "TICKET"
        validar_tipos_de_comprobantes()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        MOSTRAR_comprobante_serializado_POR_DEFECTO()
        btnGuardarImprimirdirecto.Text = "Guardar e Imprimir " & lblComprobante.Text & " (Enter)"
        validar_tipos_de_comprobantes()
    End Sub

    Private Sub datalistadoclientes2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoclientes2.CellContentClick

    End Sub
End Class