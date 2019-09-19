
Imports System.Data.SqlClient

Public Class HISTORIAL_DE_VENTAS
    Dim DT_USUARIO As New DataTable
    Private Sub BTNLECTORA_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub sumar()
        Dim total As Double

        total = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In datalistado_detalle_de_venta.Rows
            total += (fila.Cells("Importe").Value)
        Next

        lbltotal.Text = total
        lbltotal.Text = Format(CType(lbltotal.Text, Decimal), "##0.00")
          

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs)

        mascara1.dispose()

        Close()


    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
    Sub buscar_ventas_por_numero_de_comprobante()
        Try
            Dim dt As New DataTable
            Dim da As SqlDataAdapter
            Try
                abrir()
                da = New SqlDataAdapter("buscar_ventas_por_numero_de_comprobante", conexion)
                da.SelectCommand.CommandType = 4
                da.SelectCommand.Parameters.AddWithValue("@letra", txtbuscar.Text)
                da.Fill(dt)
                datalistadoventas_historial.DataSource = dt
                datalistadoventas_historial.Columns(1).Visible = False
                datalistadoventas_historial.Columns(2).Width = 140
                datalistadoventas_historial.Columns(3).Width = 140
                datalistadoventas_historial.Columns(4).Visible = False
                datalistadoventas_historial.Columns(5).Visible = False
                datalistadoventas_historial.Columns(6).Visible = False
                datalistadoventas_historial.Columns(7).Width = datalistadoventas_historial.Width - 140
                datalistadoventas_historial.Columns(8).Visible = False
                datalistadoventas_historial.Columns(9).Visible = False
                datalistadoventas_historial.Columns(10).Visible = False
                datalistadoventas_historial.Columns(11).Visible = False



                Cerrar()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        Catch ex As Exception

        End Try

    End Sub

    'Sub buscar_ventas_por_numero_usuario()
    '    Try
    '        Dim dt As New DataTable
    '        Dim da As SqlDataAdapter
    '        Try
    '            abrir()
    '            da = New SqlDataAdapter("buscar_ventas_por_numero_usuario", conexion)
    '            da.SelectCommand.CommandType = 4
    '            da.SelectCommand.Parameters.AddWithValue("@letra", CBXVENDEDOR.Text)
    '            da.Fill(dt)
    '            datalistadoventas_historial.DataSource = dt
    '            Cerrar()

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try


    '    Catch ex As Exception

    '    End Try

    'End Sub
    Sub buscar_ventas_por_fecha()
        Try
            Dim dt As New DataTable
            Dim da As SqlDataAdapter
            Try
                abrir()
                da = New SqlDataAdapter("buscar_ventas_por_fecha", conexion)
                da.SelectCommand.CommandType = 4
                da.SelectCommand.Parameters.AddWithValue("@fi", fi.Text)
                da.SelectCommand.Parameters.AddWithValue("@ff", ff.Text)
                da.Fill(dt)
                datalistadoventas_historial.DataSource = dt
                Cerrar()
                datalistadoventas_historial.Columns(1).Visible = False
                datalistadoventas_historial.Columns(2).Width = 140
                datalistadoventas_historial.Columns(3).Width = 140
                datalistadoventas_historial.Columns(4).Visible = False
                datalistadoventas_historial.Columns(5).Visible = False
                datalistadoventas_historial.Columns(6).Visible = False
                datalistadoventas_historial.Columns(7).Width = datalistadoventas_historial.Width - 140
                datalistadoventas_historial.Columns(8).Visible = False
                datalistadoventas_historial.Columns(9).Visible = False
                datalistadoventas_historial.Columns(10).Visible = False
                datalistadoventas_historial.Columns(11).Visible = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
        End Try
    End Sub
    'Sub MOSTRAR_USUARIOS()

    '    Dim DA As SqlDataAdapter
    '    Try
    '        abrir()
    '        DA = New SqlDataAdapter("mostrar_vendedores", conexion)
    '        DA.Fill(DT_USUARIO)
    '        CBXVENDEDOR.DisplayMember = "Nombre_y_Apelllidos"
    '        CBXVENDEDOR.ValueMember = "idUsuario"
    '        CBXVENDEDOR.DataSource = DT_USUARIO
    '    Catch ex As Exception : MessageBox.Show(ex.Message)
    '    End Try
    '    Cerrar()

    'End Sub
    Sub CONVERTIR_TOTAL_A_LETRAS()

        lbltotal.Text = Format(CType(lbltotal.Text, Decimal), "##0.00")
        Dim numero As Integer
        numero = Int(lbltotal.Text)
        TXTTOTAL_STRING.Text = Num2Text(numero)
        Dim a() As String
        a = Split(lbltotal.Text, ".")
        txttotaldecimal.Text = a(1) & "0"
        txtnumeroconvertidoenletra.Text = TXTTOTAL_STRING.Text & " CON " & txttotaldecimal.Text & "/100 "

    End Sub
    Private Sub HISTORIAL_DE_VENTAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

        'MOSTRAR_USUARIOS()

        Panelcantidad.Visible = False

        PanelINICIAL.Visible = True
        PanelDETALLE.Visible = False
        PanelINICIAL.Dock = DockStyle.Fill
        PanelDETALLE.Dock = DockStyle.None
    End Sub
    Sub mostrar_productos_agregados_a_venta_historial()
        Try
            Dim dt As New DataTable
            Dim da As SqlDataAdapter
            Try
                abrir()
                da = New SqlDataAdapter("mostrar_productos_agregados_a_venta_historial", conexion)
                da.SelectCommand.CommandType = 4
                da.SelectCommand.Parameters.AddWithValue("@idventa", lblidventa.Text)
                da.Fill(dt)
                datalistado_detalle_de_venta.DataSource = dt
                datalistado_detalle_de_venta.Columns(1).Visible = False
                datalistado_detalle_de_venta.Columns(0).Width = 70
                datalistado_detalle_de_venta.Columns(2).Width = 70
                datalistado_detalle_de_venta.Columns(3).Width = 250
                datalistado_detalle_de_venta.Columns(5).Width = 70
                datalistado_detalle_de_venta.Columns(4).Visible = False
                datalistado_detalle_de_venta.Columns(6).Visible = False
                datalistado_detalle_de_venta.Columns(7).Visible = False
                datalistado_detalle_de_venta.Columns(8).Visible = False
                datalistado_detalle_de_venta.Columns(9).Visible = False
                datalistado_detalle_de_venta.Columns(10).Visible = False
                datalistado_detalle_de_venta.Columns(11).Visible = False
                datalistado_detalle_de_venta.Columns(12).Visible = False
                datalistado_detalle_de_venta.Columns(13).Visible = False
                datalistado_detalle_de_venta.Columns(14).Visible = False
                Cerrar()
                sumar()
                Me.datalistado_detalle_de_venta.EnableHeadersVisualStyles = False

                ' estilo para las cabeceras
                Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()




                styCabeceras.BackColor = Color.White
                styCabeceras.ForeColor = Color.Black
                styCabeceras.Font = New Font("Segoe UI", 10, FontStyle.Regular Or
                FontStyle.Bold)

                ' asignar estilo al grid
                Me.datalistado_detalle_de_venta.ColumnHeadersDefaultCellStyle = styCabeceras
            Catch ex As Exception


            End Try


        Catch ex As Exception
            datalistado_detalle_de_venta.DataSource = Nothing
        End Try

    End Sub
    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If txtbuscar.Text = "" Then
            lbltipodebusqueda2.Visible = True
            Pcancelado.Visible = False
        End If
        If txtbuscar.Text <> "" Then
            Pcancelado.Visible = False
            lbltipodebusqueda2.Visible = False
            PanelINICIAL.Visible = True
            PanelDETALLE.Visible = False
            PanelINICIAL.Dock = DockStyle.Fill
            PanelDETALLE.Dock = DockStyle.None
            buscar_ventas_por_numero_de_comprobante()
        End If




    End Sub

    Private Sub datalistadoventas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoventas_historial.CellClick
        Try

            lblcomprobante.Text = datalistadoventas_historial.SelectedCells.Item(3).Value
            lblfecha.Text = datalistadoventas_historial.SelectedCells.Item(2).Value
            lblcajero.Text = datalistadoventas_historial.SelectedCells.Item(5).Value


            lbltotal.Text = datalistadoventas_historial.SelectedCells.Item(4).Value
            lblpagocon.Text = datalistadoventas_historial.SelectedCells.Item(6).Value
            lblidventa.Text = datalistadoventas_historial.SelectedCells.Item(1).Value
            lblcliente.Text = datalistadoventas_historial.SelectedCells.Item(8).Value
            LBLTipodePagoOK.Text = datalistadoventas_historial.SelectedCells.Item(9).Value
            lblvuelto.Text = datalistadoventas_historial.SelectedCells.Item(11).Value
            lblpagocon.Text = datalistadoventas_historial.SelectedCells.Item(10).Value

            PanelTICKET.Visible = True
            Pcancelado.Visible = False
            MenuStrip1.Visible = True
            MenuStrip5.Visible = True
            PanelINICIAL.Visible = False
            PanelDETALLE.Visible = True
            PanelINICIAL.Dock = DockStyle.None
            PanelDETALLE.Dock = DockStyle.Fill
        Catch ex As Exception

        End Try

        mostrar_productos_agregados_a_venta_historial()


    End Sub

    Private Sub datalistadoventas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        buscar_ventas_por_fecha()
        Try
            lblcomprobante.Text = datalistadoventas_historial.SelectedCells.Item(3).Value
            lblfecha.Text = datalistadoventas_historial.SelectedCells.Item(2).Value
            lblcajero.Text = datalistadoventas_historial.SelectedCells.Item(5).Value
        Catch ex As Exception

        End Try

        mostrar_productos_agregados_a_venta_historial()
    End Sub

    Private Sub fi_ValueChanged(sender As Object, e As EventArgs) Handles fi.ValueChanged
        PanelINICIAL.Visible = True
        PanelDETALLE.Visible = False
        PanelINICIAL.Dock = DockStyle.Fill
        PanelDETALLE.Dock = DockStyle.None
        buscar_ventas_por_fecha()
        Pcancelado.Visible = False
        txtbuscar.Text = ""


    End Sub

    Private Sub ff_ValueChanged(sender As Object, e As EventArgs) Handles ff.ValueChanged
        PanelINICIAL.Visible = True
        PanelDETALLE.Visible = False
        PanelINICIAL.Dock = DockStyle.Fill
        PanelDETALLE.Dock = DockStyle.None
        buscar_ventas_por_fecha()
        Pcancelado.Visible = False
        txtbuscar.Text = ""

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        PanelINICIAL.Visible = True
        PanelDETALLE.Visible = False
        PanelINICIAL.Dock = DockStyle.Fill
        PanelDETALLE.Dock = DockStyle.None
        Pcancelado.Visible = False
        fi.Value = Now()
        ff.Value = Now()
        buscar_ventas_por_fecha()
        txtbuscar.Text = ""

    End Sub

    Private Sub CBXVENDEDOR_SelectedIndexChanged(sender As Object, e As EventArgs)
        'With TXTIDUSUARIO
        '    .DataSource = DT_USUARIO
        '    .DisplayMember = "idUsuario"
        '    .ValueMember = "idUsuario"

        'End With
        'buscar_ventas_por_numero_usuario()
        txtbuscar.Text = ""

    End Sub

    Private Sub MenuStrip3_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub
    Sub aumentar_stock()
        Try
            Dim cmd As SqlCommand
            abrir()
            cmd = New SqlCommand("aumentar_stock", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", datalistado_detalle_de_venta.SelectedCells.Item(6).Value)
            cmd.Parameters.AddWithValue("@cantidad", txtcantidad.Text)
            cmd.ExecuteNonQuery()
            Cerrar()

            abrir()
            cmd = New SqlCommand("aumentar_stock_en_detalle_de_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", datalistado_detalle_de_venta.SelectedCells.Item(6).Value)
            cmd.Parameters.AddWithValue("@cantidad", txtcantidad.Text)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs)









    End Sub
    Sub editar_venta()

        Try
            Dim cmd As SqlCommand
            abrir()
            cmd = New SqlCommand("editar_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", lblidventa.Text)
            cmd.Parameters.AddWithValue("@montototal", lbltotal.Text)
            cmd.Parameters.AddWithValue("@IGV", 0)

            cmd.ExecuteNonQuery()
            Cerrar()


            'abrir()
            'cmd = New SqlCommand("eliminar_venta_en_historial", conexion)
            'cmd.CommandType = 4
            'cmd.Parameters.AddWithValue("@Id_venta", datalistadoventas_historial.SelectedCells.Item(1).Value)
            'cmd.ExecuteNonQuery()
            'Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub INSERTAR_KARDEX_ENTRADA()
        Try
            Dim cmd As New SqlCommand

            abrir()

            cmd = New SqlCommand("insertar_KARDEX_ENTRADA", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Fecha", Now())
            cmd.Parameters.AddWithValue("@Motivo", "DEVOLUCION DE PRODUCTO Venta #" & lblcomprobante.Text)
            cmd.Parameters.AddWithValue("@Cantidad ", txtcantidad.Text)

            cmd.Parameters.AddWithValue("@Id_producto", datalistado_detalle_de_venta.SelectedCells.Item(6).Value)
            cmd.Parameters.AddWithValue("@Id_usuario", VENTAS_MENU_PRINCIPAL.lblidusuario.Text)
            cmd.Parameters.AddWithValue("@Tipo", "ENTRADA")
            cmd.Parameters.AddWithValue("@Estado", "DESPACHO CONFIRMADO")


            cmd.Parameters.AddWithValue("@Id_caja", VENTAS_MENU_PRINCIPAL.lblidcaja.Text)
            cmd.ExecuteNonQuery()

            Cerrar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click


        Try
            If txtcantidad.Text = "" Then txtcantidad.Text = 0
            If txtcantidad.Text * 1 > 0 Then

                If txtcantidad.Text * 1 <= lblproducto.Text * 1 Then
                    If datalistado_detalle_de_venta.SelectedCells.Item(9).Value = "Ilimitado" Then
                        Dim cmd As New SqlCommand
                        abrir()
                        cmd = New SqlCommand("editar_detalle_venta_restar", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@iddetalle_venta", datalistado_detalle_de_venta.SelectedCells.Item(7).Value)
                        cmd.Parameters.AddWithValue("@cantidad", txtcantidad.Text)
                        cmd.Parameters.AddWithValue("@Cantidad_mostrada", txtcantidad.Text)
                        cmd.ExecuteNonQuery()
                        Cerrar()

                        'sumar()
                        lbltotal.Text = txttotalnuevo.Text
                        editar_venta()
                        Panelcantidad.Visible = False
                    End If
                    If datalistado_detalle_de_venta.SelectedCells.Item(9).Value <> "Ilimitado" Then


                        Dim cmd As New SqlCommand
                        abrir()
                        cmd = New SqlCommand("editar_detalle_venta_restar_en_Historial", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@Descripcion", datalistado_detalle_de_venta.SelectedCells.Item(3).Value)
                        cmd.Parameters.AddWithValue("@cantidad", txtcantidad.Text)
                        cmd.Parameters.AddWithValue("@Cantidad_mostrada", txtcantidad.Text)
                        cmd.Parameters.AddWithValue("@idventa", lblidventa.Text)
                        cmd.ExecuteNonQuery()
                        Cerrar()
                        aumentar_stock()
                        INSERTAR_KARDEX_ENTRADA()
                        'sumar()
                        lbltotal.Text = txttotalnuevo.Text
                        editar_venta()

                        Panelcantidad.Visible = False

                    End If
                Else
                    MessageBox.Show("Estas Exediendo la cantidad a devolver", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                If lbltotal.Text = 0 Then
                    PanelTICKET.Visible = False
                    Pcancelado.Visible = True
                    Pcancelado.Dock = DockStyle.Fill
                    MenuStrip1.Visible = False
                    MenuStrip5.Visible = False
                End If
                buscar_ventas_por_numero_de_comprobante()
                mostrar_productos_agregados_a_venta_historial()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Panelcantidad.Visible = False
    End Sub

    Private Sub datalistado_detalle_de_venta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

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
    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtcantidad, e)
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged
        Try
            txttotalnuevo.Text = txttotal2.Text * 1 - (txtcantidad.Text * 1 * txtpreciounitario.Text * 1)
            TXTIGV2.Text = (txttotalnuevo.Text * 1 * TXTPORCENTAJEIGV.Text * 1) / 100
        Catch ex As Exception

        End Try
    End Sub

    Private Sub datalistado_detalle_de_venta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado_detalle_de_venta.CellClick
        If e.ColumnIndex = Me.datalistado_detalle_de_venta.Columns.Item("R").Index Then

            Panelcantidad.Visible = True
            txtcantidad.Text = ""
            txtcantidad.Focus()

            Try
                lblproducto.Text = datalistado_detalle_de_venta.SelectedCells.Item(2).Value
                txtpreciounitario.Text = datalistado_detalle_de_venta.SelectedCells.Item(4).Value
                txttotal2.Text = lbltotal.Text
                TXTPORCENTAJEIGV.Text = datalistado_detalle_de_venta.SelectedCells.Item(14).Value
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub PanelTICKET_Paint(sender As Object, e As PaintEventArgs) Handles PanelTICKET.Paint

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Estas seguro de Eliminar esta Venta?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            'Try
            '    Dim cmd As SqlCommand

            '    abrir()
            '    cmd = New SqlCommand("eliminar_venta", conexion)
            '    cmd.CommandType = 4
            '    cmd.Parameters.AddWithValue("@idventa", datalistadoventas_historial.SelectedCells.Item(1).Value)
            '    cmd.ExecuteNonQuery()
            '    Cerrar()

            'Catch ex As Exception

            'End Try

            For Each row As DataGridViewRow In datalistado_detalle_de_venta.Rows
                Dim Id_producto As Integer = Convert.ToInt32(row.Cells("Id_producto").Value)
                Dim iddetalle_venta As Integer = Convert.ToInt32(row.Cells("iddetalle_venta").Value)
                Dim cantidad As Double = Convert.ToDouble(row.Cells("Cant").Value)
                Dim Cantidad_mostrada As Double = Convert.ToDouble(row.Cells("Cant").Value)

                Dim Descripcion As String = Convert.ToString(row.Cells("Descripcion").Value)
                Dim idventa As Integer = Convert.ToInt32(row.Cells("idventa").Value)
                Dim Usa_inventarios As String = Convert.ToString(row.Cells("Usa_inventarios").Value)
                If Usa_inventarios = "Ilimitado" Then
                    Dim cmd As New SqlCommand
                    abrir()
                    cmd = New SqlCommand("editar_detalle_venta_restar", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@iddetalle_venta", iddetalle_venta)
                    cmd.Parameters.AddWithValue("@cantidad", cantidad)
                    cmd.Parameters.AddWithValue("@Cantidad_mostrada", Cantidad_mostrada)
                    cmd.ExecuteNonQuery()
                    Cerrar()
                End If
                If Usa_inventarios <> "Ilimitado" Then


                    Dim cmd As New SqlCommand
                    abrir()
                    cmd = New SqlCommand("editar_detalle_venta_restar_en_Historial", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion)
                    cmd.Parameters.AddWithValue("@cantidad", cantidad)
                    cmd.Parameters.AddWithValue("@Cantidad_mostrada", Cantidad_mostrada)
                    cmd.Parameters.AddWithValue("@idventa", idventa)
                    cmd.ExecuteNonQuery()
                    Cerrar()
                    Try

                        abrir()
                        cmd = New SqlCommand("aumentar_stock", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", Id_producto)
                        cmd.Parameters.AddWithValue("@cantidad", cantidad)
                        cmd.ExecuteNonQuery()
                        Cerrar()
                        abrir()
                        cmd = New SqlCommand("aumentar_stock_en_detalle_de_venta", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", Id_producto)
                        cmd.Parameters.AddWithValue("@cantidad", cantidad)
                        cmd.ExecuteNonQuery()
                        Cerrar()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Next
            eliminar_venta()
            Panelcantidad.Visible = False
        End If
    End Sub
    Sub eliminar_venta()
        Dim cmd As New SqlCommand
        abrir()
        cmd = New SqlCommand("eliminar_venta", conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@idventa", lblidventa.Text)

        cmd.ExecuteNonQuery()
        Cerrar()
        Pcancelado.Visible = True
        Pcancelado.Dock = DockStyle.Fill
        buscar_ventas_por_numero_de_comprobante()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        CONVERTIR_TOTAL_A_LETRAS()
        Ticket_Form_Factura_boleta.Timer2.Start()
        Ticket_Form_Factura_boleta.ShowDialog()
        Ticket_Form_Factura_boleta.Timer2.Start()
    End Sub



    Private Sub CBXVENDEDOR_Click(sender As Object, e As EventArgs)
        PanelINICIAL.Visible = True
        PanelDETALLE.Visible = False
        PanelINICIAL.Dock = DockStyle.Fill
        PanelDETALLE.Dock = DockStyle.None
    End Sub

    Private Sub datalistadoventas_historial_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoventas_historial.CellContentClick

    End Sub

    Private Sub PanelDETALLE_Paint(sender As Object, e As PaintEventArgs) Handles PanelDETALLE.Paint

    End Sub

    Private Sub datalistado_detalle_de_venta_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado_detalle_de_venta.CellContentClick

    End Sub
End Class