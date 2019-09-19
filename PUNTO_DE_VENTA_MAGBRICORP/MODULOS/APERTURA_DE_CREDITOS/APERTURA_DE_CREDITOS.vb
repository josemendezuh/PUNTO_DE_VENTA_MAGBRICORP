




Imports System.Data
Imports System.Data.SqlClient

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

Public Class APERTURA_DE_CREDITOS
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
    Dim dtunidad As New DataTable
    Dim DT_USUARIO As New DataTable
    Sub dibujarPLANIFICACIONES(ByVal fin As Integer)

        abrir()
        ReDim b(fin)
        ReDim a(fin)
        Dim query As String = "mostrar_inmuebles_para_ventas"

        Dim cmd As New SqlCommand(query, conexion)
        'cmd.CommandType = 4
        'cmd.Parameters.AddWithValue("@ff", txtff.Text)
        'cmd.Parameters.AddWithValue("@fi", txtfi.Text)
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        Dim NBotones As Integer = 6

        Dim j As Integer = 0
        Dim contador As Integer = 0

        Dim constante As Integer = 120 'variable que determina el espaciado entre los picturebox'
        Dim constantex As Integer = 260

        While rdr.Read()

            For T = 1 To fin
                b(T) = New Button 'instanciamos los picturebox'
                a(T) = New Label 'iniciamos el label'



                Me.b(T).Text = rdr("Codigo").ToString()

                Me.b(T).Name = rdr("Id_inmueble").ToString()
                '& rdr("Marca").ToString()
                Me.b(T).Size = New System.Drawing.Size(248, 80)
                Me.b(T).BackColor = Color.ForestGreen
                Me.b(T).ForeColor = Color.White
                Me.b(T).FlatStyle = FlatStyle.Flat
                Me.b(T).Font = New System.Drawing.Font(12, 20)

                Me.a(T).BackColor = Color.ForestGreen
                Me.a(T).ForeColor = Color.White
                Me.a(T).Text = rdr("Proyecto").ToString()
                Me.a(T).Name = rdr("Id_inmueble").ToString()
                Me.a(T).Size = New System.Drawing.Size(248, 30)
                Me.a(T).FlatStyle = FlatStyle.Flat
                Me.a(T).TextAlign = ContentAlignment.MiddleCenter

                contador = contador + 1
                If contador <= 4 Then
                    b(T).Location = New System.Drawing.Point((contador * constantex) - constantex, j * constante) 'para la ubicacion'
                    'a(T).Location = New System.Drawing.Point((contador * constantex2) - constantex2, j * constante2) 'para la ubicacion'

                Else
                    j = j + 1
                    b(T).Location = New System.Drawing.Point(0, j * constante)
                    'a(T).Location = New System.Drawing.Point((contador * constantex2) - constantex2, j * constante2) 'para la ubicacion'

                    contador = 1
                End If
                a(T).Location = New System.Drawing.Point(b(T).Location.X, b(T).Location.Y + 79)
                panel.Controls.Add(b(T))
                panel.Controls.Add(a(T))
                'FlowLayoutPanel2.Controls.Add(A)
                AddHandler b(T).Click, AddressOf miEvento2
                AddHandler b(T).MouseMove, AddressOf miEvento3
            Next



        End While
        Cerrar()






    End Sub
    Private Sub miEvento3(ByVal sender As System.Object, ByVal e As EventArgs)

    End Sub
    Private Sub miEvento2(ByVal sender As System.Object, ByVal e As EventArgs)
        Try
            'TXTIDREPORGRAMACION.Text = DirectCast(sender, Button).Name
            'ListarDETALLES_DE_VENTAS_PROGRAMAdas_PARA_REPROGRAMAR()
            'paneldeprogramacion.Visible = True
            Try
                'txthorainicio1.Text = DATALISTADORESULTADOS.SelectedCells.Item(5).Value
                'txthorafin1.Text = DATALISTADORESULTADOS.SelectedCells.Item(4).Value
                'TXTACTIVIDAD.Text = DATALISTADORESULTADOS.SelectedCells.Item(1).Value
                'txtcantidad.Text = DATALISTADORESULTADOS.SelectedCells.Item(7).Value
                'TXTFECHAINICIO.Text = DATALISTADORESULTADOS.SelectedCells.Item(2).Value
                'TXTFECHAFIN.Text = DATALISTADORESULTADOS.SelectedCells.Item(3).Value
            Catch ex As Exception

            End Try

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
            datalistadomateriales.Columns(1).Width = 260
            datalistadomateriales.Columns(2).Width = 85
            datalistadomateriales.Columns(3).Width = 65
            datalistadomateriales.Columns(4).Width = 65
            datalistadomateriales.Columns(5).Visible = False
            datalistadomateriales.Columns(6).Visible = False
            datalistadomateriales.Columns(7).Visible = False
            datalistadomateriales.Columns(8).Visible = False
            datalistadomateriales.Columns(9).Visible = False


        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()
        sumar()

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
    'Sub 
    '    Dim DA As SqlDataAdapter
    '    Try
    '        abrir()
    '        DA = New SqlDataAdapter("SELECT * FROM Unidad_de_medida", conexion)
    '        DA.Fill(dtunidad)
    '        txtunidad.DisplayMember = "Unidad_de_medida"
    '        txtunidad.ValueMember = "Id_unidad_de_medida"
    '        txtunidad.DataSource = dtunidad
    '        Cerrar()
    '    Catch ex As Exception : MessageBox.Show(ex.Message)
    '    End Try

    '    lbl_unidadoka.Text = txtunidad.Text
    'End Sub

    Private Sub POR_PAGAR_SIMPLE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

        panel.AutoScroll = True
        panel.Location = New System.Drawing.Point(16, 53)
        panel.Name = "Panel1"
        panel.Size = New System.Drawing.Size(1100, 500)
        Me.Controls.Add(panel)
        limpiar()
        If lblTipo.Text = "POR PAGAR" Then
            cargarPROVEEDORES()
            Label12.Text = "Buscar Proveedor"
            PANELEtiquetas.Visible = True
        End If
        If lblTipo.Text = "POR COBRAR" Then
            Label12.Text = "Buscar Cliente"
            buscar_cliente_POR_nombre_PARA_VENTAS_todos()
            PANELEtiquetas.Visible = False
        End If


        paneldegenerarventa.Enabled = True
        paneldeguardarventa.Enabled = False
        txtsaldo.Clear()
        txtconcepto.Clear()
        txtetiqueta.Clear()

        datalistadoclientes.Visible = True
        idconcepto = 0
    End Sub


    Sub cargarPROVEEDORES()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_PROVEEDOR_POR_nombre_PARA_VENTAS_todos", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtclientesolicitabnte.Text)
            da.Fill(dt)
            datalistadoclientes.DataSource = dt
            datalistadoclientes.Columns(2).Visible = False
            datalistadoclientes.Columns(3).Visible = False
            datalistadoclientes.Columns(1).Width = 240
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try


    End Sub
    Sub buscar_cliente_POR_nombre_PARA_VENTAS_todos()
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

            datalistadoclientes.Columns(1).Width = 240
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
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
        Catch ex As Exception : MessageBox.Show(ex.Message)
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
    Private Sub contar()
        Dim x As Integer
        x = datalistado.Rows.Count
        txtcontador.Text = CStr(x)
    End Sub
    Sub ListarPOR_PAGAR()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            If lblTipo.Text = "POR PAGAR" Then
                da = New SqlDataAdapter("select * from ventas  where ventas.Accion='POR PAGAR OTROS' order by idventa desc", conexion)

            End If
            If lblTipo.Text = "POR COBRAR" Then
                da = New SqlDataAdapter("select * from ventas  where ventas.Accion='POR COBRAR OTROS' order by idventa desc", conexion)

            End If
            'da.SelectCommand.CommandType = 4
            'da.SelectCommand.Parameters.AddWithValue("@letra", TextBox2.Text)
            da.Fill(dt)
            datalistadoventas.DataSource = dt
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

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True


            Listarproductos()
            contar()
            detalle_producto.Visible = False

            dibujar()
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
            DATALISTADO_PRODUCTOS_OKA.Columns(0).Visible = False
            DATALISTADO_PRODUCTOS_OKA.Columns(1).Visible = False
            DATALISTADO_PRODUCTOS_OKA.Columns(3).Visible = False

            DATALISTADO_PRODUCTOS_OKA.Columns(2).Width = 320

        Catch ex As Exception
        End Try
        Cerrar()
        'sumar_total_despachado()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        DATALISTADO_PRODUCTOS_OKA.Visible = True

        'Listarproductos()
        'contar()
        'detalle_producto.Visible = False

        'dibujar()

        LISTAR_PRODUCTOS_Abuscador()



    End Sub


    Private Sub Buscarporgirado_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

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
    Sub actualizar_estado_de_ventas_a_programado()
        Dim cmdaumentarstock As SqlCommand
        For Each fila As DataGridViewRow In datalistadomateriales.Rows
            fila.Cells(0).Value = True
        Next
        Try
            For Each row As DataGridViewRow In datalistadomateriales.Rows
                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Marcar").Value)

                If marcado Then

                    Dim idlote As Integer = Convert.ToInt32(row.Cells("Id_presentacionfraccionada").Value)
                    Dim cantidad As Decimal = Convert.ToDouble(row.Cells("cantidad").Value)
                    Try
                        abrir()

                        cmdaumentarstock = New SqlCommand("disminuir_stock", conexion)
                        cmdaumentarstock.CommandType = 4
                        cmdaumentarstock.Parameters.AddWithValue("@Id_presentacionfraccionada", idlote)
                        cmdaumentarstock.Parameters.AddWithValue("@cantidad", cantidad)
                        cmdaumentarstock.ExecuteNonQuery()



                    Catch ex As Exception : MsgBox(ex.Message)

                    End Try
                    Cerrar()
                End If

            Next

            Call Listarproductosagregados()
            Call Listarproductos()





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Sub DISMINUIR_STOCK()
        Dim cmdaumentarstock As SqlCommand
        For Each fila As DataGridViewRow In datalistadomateriales.Rows
            fila.Cells(0).Value = True
        Next
        Try
            For Each row As DataGridViewRow In datalistadomateriales.Rows
                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Marcar").Value)

                If marcado Then

                    Dim idlote As Integer = Convert.ToInt32(row.Cells("Id_presentacionfraccionada").Value)
                    Dim cantidad As Decimal = Convert.ToDouble(row.Cells("cantidad").Value)
                    Try
                        abrir()

                        cmdaumentarstock = New SqlCommand("disminuir_stock", conexion)
                        cmdaumentarstock.CommandType = 4
                        cmdaumentarstock.Parameters.AddWithValue("@Id_presentacionfraccionada", idlote)
                        cmdaumentarstock.Parameters.AddWithValue("@cantidad", cantidad)
                        cmdaumentarstock.ExecuteNonQuery()



                    Catch ex As Exception : MsgBox(ex.Message)

                    End Try
                    Cerrar()
                End If

            Next

            Call Listarproductosagregados()
            Call Listarproductos()





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
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncobrobancario.Click
        Dim numero As Double
        numero = txttotalentero.Text
        txttotaltexto.Text = Num2Text(numero)
        Dim a() As String
        a = Split(txttotal.Text, ".")
        txttotaldecimal.Text = a(1) & "0"
        txtnumeroconvertidoenletra.Text = txttotaltexto.Text & " CON " & txttotaldecimal.Text & "/100"
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("actualizartotal_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)
            cmd.Parameters.AddWithValue("@montototal", txttotal.Text)
            cmd.Parameters.AddWithValue("@IGV", txtigv.Text)
            cmd.Parameters.AddWithValue("@Tipo_de_pago", "BANCARIO PENDIENTE DE TRANSFERENCIA")
            cmd.ExecuteNonQuery()


            MsgBox("VENTA GUARDADA CORRECTAMENTE")
            Cerrar()


            aumentar_monto_a_cliente_PARA_COMISIONES()



            limpiar()
            Listarproductosagregados()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    'Sub eliminar_ventas_en_cero()
    '    Try
    '        Dim cmd As New SqlCommand

    '        abrir()
    '        cmd = New SqlCommand("eliminar_venta__en_cero", conexion)
    '        cmd.CommandType = 4


    '        cmd.ExecuteNonQuery()
    '        Cerrar()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
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
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txttotalparcialporproductovendido.TextChanged
        'Try
        '    Dim cantidad, stock As Double
        '    cantidad = txtcantidad.Text * txtcantidad_de_unidad_de_medida.Text
        '    stock = txtstockok.Text
        '    If stock > cantidad Then
        '        If txtcantidad.Text <> "0" Then
        '            If txtstockok.Text <> "0" Then
        '                sub_TOTAL()
        '            Else
        '                txtcantidad.Text = "0.0"
        '            End If
        '        Else
        '            'MsgBox("INGRESE UN VALOR")
        '        End If
        '    Else
        '        MsgBox("LA CANTIDAD QUE INTENTA VENDER SUPERA EL STOCK EXISTENTE")
        '    End If


        'Catch ex As Exception

        'End Try
        'txtprecioreal.Text = ""

    End Sub
    Public Sub sub_TOTAL()
        'Try
        '    Dim cantidad As Decimal
        '    Dim preciouni As Decimal
        '    Dim total As Decimal
        '    cantidad = txtcantidad.Text * txtcantidad_de_unidad_de_medida.Text * 1
        '    preciouni = txtprecio.Text
        '    total = txtcantidad.Text * preciouni
        '    txttotalparcialporproductovendido.Text = total
        'Catch ex As Exception

        'End Try


    End Sub
    Private Sub sumar()
        Dim totalpagar As Double

        totalpagar = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In datalistadomateriales.Rows
            totalpagar += (fila.Cells("Total_a_pagar").Value)
        Next
        txt_total_suma.Text = (totalpagar)
        txt_total_suma.Text = Format(CType(txt_total_suma.Text, Decimal), "##0.00")
        'txttotal.Text = (totalpagar)
        'txttotal.Text = Format(CType(txttotal.Text, Decimal), "##0.0")
        'txttotalentero.Text = Int(txttotal.Text)

        'Listarproductosagregados()

    End Sub

    Private Sub txtprecioreal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprecioreal.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                Try
                    Dim stock As Decimal
                    Dim cantidad As Decimal
                    stock = txtstockok.Text
                    cantidad = txtcantidad.Text * txtcantidad_de_unidad_de_medida.Text * 1
                    If noafectarstock.Checked = True Then
                        sub_TOTAL()
                        Dim cmd As New SqlCommand
                        abrir()
                        cmd = New SqlCommand("insertar_detalle_venta", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)
                        cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", datalistado.SelectedCells.Item(5).Value)
                        cmd.Parameters.AddWithValue("@cantidad", cantidad)
                        cmd.Parameters.AddWithValue("@preciounitario", txtprecioreal.Text)
                        cmd.Parameters.AddWithValue("@moneda", "S/.")
                        cmd.Parameters.AddWithValue("@totalapagar", txttotalparcialporproductovendido.Text)
                        cmd.Parameters.AddWithValue("@unidades", txtunidad.Text)
                        cmd.Parameters.AddWithValue("@Cantidad_mostrada", txtcantidad.Text)
                        cmd.Parameters.AddWithValue("@Estado", "DESPACHO PENDIENTE")
                        cmd.ExecuteNonQuery()
                        Cerrar()
                        detalle_producto.Visible = False
                        Listarproductosagregados()
                        sumar()
                        txtcantidad.Text = 0
                        txtprecioreal.Text = 0
                    ElseIf noafectarstock.Checked = False Then
                        If stock >= cantidad Then
                            sub_TOTAL()
                            Dim cmd As New SqlCommand
                            abrir()
                            cmd = New SqlCommand("insertar_detalle_venta", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)
                            cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", datalistado.SelectedCells.Item(5).Value)
                            cmd.Parameters.AddWithValue("@cantidad", cantidad)
                            cmd.Parameters.AddWithValue("@preciounitario", txtprecioreal.Text)
                            cmd.Parameters.AddWithValue("@moneda", "S/.")
                            cmd.Parameters.AddWithValue("@totalapagar", txttotalparcialporproductovendido.Text)
                            cmd.Parameters.AddWithValue("@unidades", txtunidad.Text)
                            cmd.Parameters.AddWithValue("@Cantidad_mostrada", txtcantidad.Text)
                            cmd.Parameters.AddWithValue("@Estado", "DESPACHO PENDIENTE")
                            cmd.ExecuteNonQuery()
                            Cerrar()
                            detalle_producto.Visible = False
                            Listarproductosagregados()
                            sumar()
                            txtcantidad.Text = 0
                            txtprecioreal.Text = 0
                            'txtbuscar.Text = ""
                        Else
                            MsgBox("LA CANTIDAD QUE INTENTA VENDER SUPERA EL STOCK EXISTENTE")
                        End If
                    End If
                Catch ex As Exception : MessageBox.Show(ex.Message)
                End Try



            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtprecioreal_TextChanged(sender As Object, e As EventArgs) Handles txtprecioreal.TextChanged
        Try
            'Dim cantidad, stock As Double
            'cantidad = txtcantidad.Text
            'stock = txtstock.Text
            'If txtcantidad.Text <> "0" Then
            '    If txtstock.Text <> "0" Then
            'sub_TOTAL()
            '    Else
            '        txtcantidad.Text = "0.0"
            '    End If
            'Else
            '    MsgBox("INGRESE UN VALOR")
            'End If


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
    Sub aumentar_monto_a_cliente_PARA_COMISIONES()
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("insertar_control_de_cobros", conexion)
            cmd.CommandType = 4

            cmd.Parameters.AddWithValue("@Id_venta", txtidventa.Text)
            cmd.Parameters.AddWithValue("@Monto", txtsaldo.Text)
            cmd.Parameters.AddWithValue("@Concepto", txtconcepto.Text)
            cmd.ExecuteNonQuery()
            Cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub aumentar_monto_a_cliente()
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("insertar_control_de_cobros", conexion)
            cmd.CommandType = 4

            cmd.Parameters.AddWithValue("@Id_venta", txtidventa.Text)
            cmd.Parameters.AddWithValue("@Monto", txttotal.Text)
            cmd.Parameters.AddWithValue("@Concepto", "POR VENTAS")
            cmd.ExecuteNonQuery()
            Cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CONFIRMAR_VENTA()

        Dim numero As Double
        numero = txttotalentero.Text
        txttotaltexto.Text = Num2Text(numero)
        Dim a() As String
        a = Split(txttotal.Text, ".")
        txttotaldecimal.Text = a(1) & "0"
        txtnumeroconvertidoenletra.Text = txttotaltexto.Text & " CON " & txttotaldecimal.Text & "/100"
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("actualizartotal_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)
            cmd.Parameters.AddWithValue("@montototal", txttotal.Text)
            cmd.Parameters.AddWithValue("@IGV", txtigv.Text)


            cmd.ExecuteNonQuery()
            MsgBox("VENTA GUARDADA CORRECTAMENTE")
            Cerrar()






        Catch ex As Exception
            MessageBox.Show(ex.Message)
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
        paneldeguardarventa.Enabled = False
        txtclientesolicitabnte.Text = ""
        'txtbuscar.Text = ""
        'txtbuscar.Enabled = False
        txtnumerodecomprobante.Text = ""


        noafectarstock.Checked = True

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        detalle_producto.Visible = False
    End Sub


    Public Function Num2Text(ByVal value As Double) As String
        Select Case value
            Case 0 : Num2Text = "CERO"
            Case 1 : Num2Text = "UN"
            Case 2 : Num2Text = "DOS"
            Case 3 : Num2Text = "TRES"
            Case 4 : Num2Text = "CUATRO"
            Case 5 : Num2Text = "CINCO"
            Case 6 : Num2Text = "SEIS"
            Case 7 : Num2Text = "SIETE"
            Case 8 : Num2Text = "OCHO"
            Case 9 : Num2Text = "NUEVE"
            Case 10 : Num2Text = "DIEZ"
            Case 11 : Num2Text = "ONCE"
            Case 12 : Num2Text = "DOCE"
            Case 13 : Num2Text = "TRECE"
            Case 14 : Num2Text = "CATORCE"
            Case 15 : Num2Text = "QUINCE"
            Case Is < 20 : Num2Text = "DIECI" & Num2Text(value - 10)
            Case 20 : Num2Text = "VEINTE"
            Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
            Case 30 : Num2Text = "TREINTA"
            Case 40 : Num2Text = "CUARENTA"
            Case 50 : Num2Text = "CINCUENTA"
            Case 60 : Num2Text = "SESENTA"
            Case 70 : Num2Text = "SETENTA"
            Case 80 : Num2Text = "OCHENTA"
            Case 90 : Num2Text = "NOVENTA"
            Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
            Case 100 : Num2Text = "CIEN"
            Case Is < 200 : Num2Text = "CIENTO " & Num2Text(value - 100)
            Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
            Case 500 : Num2Text = "QUINIENTOS"
            Case 700 : Num2Text = "SETECIENTOS"
            Case 900 : Num2Text = "NOVECIENTOS"
            Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
            Case 1000 : Num2Text = "MIL"
            Case Is < 2000 : Num2Text = "MIL " & Num2Text(value Mod 1000)
            Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
            Case 1000000 : Num2Text = "UN MILLON"
            Case Is < 2000000 : Num2Text = "UN MILLON " & Num2Text(value Mod 1000000)
            Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " MILLONES "
                If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000) * 1000000)
            Case 1000000000000.0# : Num2Text = "UN BILLON"
            Case Is < 2000000000000.0# : Num2Text = "UN BILLON " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            Case Else : Num2Text = Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
        End Select
    End Function

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Dim result As DialogResult
        Dim cmd As SqlCommand

        result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistadomateriales.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Marcar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("iddetalle_venta").Value)

                        Try
                            abrir()


                            cmd = New SqlCommand("eliminar_detalle_venta", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@iddetalleventa", onekey)
                            cmd.ExecuteNonQuery()


                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try
                        Cerrar()
                    End If

                Next

                Call Listarproductosagregados()
                Call Listarproductos()





            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub datalistadomateriales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadomateriales.CellContentClick
        Try
            If e.ColumnIndex = Me.datalistadomateriales.Columns.Item("Marcar").Index Then
                Dim chkcell As DataGridViewCheckBoxCell = Me.datalistadomateriales.Rows(e.RowIndex).Cells("Marcar")
                chkcell.Value = Not chkcell.Value
            End If
        Catch ex As Exception
        End Try
    End Sub












    Private Sub DATALISTADOPRESENTACIONES_AGREGADAS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADOPRESENTACIONES_AGREGADAS.CellClick
        Try
            txtprecioreal.Text = DATALISTADOPRESENTACIONES_AGREGADAS.SelectedCells.Item(3).Value
            txtunidad.Text = DATALISTADOPRESENTACIONES_AGREGADAS.SelectedCells.Item(2).Value
            txtcantidad_de_unidad_de_medida.Text = DATALISTADOPRESENTACIONES_AGREGADAS.SelectedCells.Item(4).Value
        Catch ex As Exception
            MsgBox("NO HAY PRECIOS AGREGADOS, VAYA A NUEVO PARA AGREGAR PRECIOS A LOS PRODUCTOS")
        End Try
    End Sub

    Private Sub DATALISTADOPRESENTACIONES_AGREGADAS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADOPRESENTACIONES_AGREGADAS.CellContentClick

    End Sub

    Private Sub DATALISTADOPRESENTACIONES_AGREGADAS_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADOPRESENTACIONES_AGREGADAS.CellDoubleClick



    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub txtunidad_SelectedIndexChanged(sender As Object, e As EventArgs)
        'With txtcantidad_de_unidad_de_medida
        '    .DataSource = dtunidad
        '    .DisplayMember = "Cantidad_por_unidad_de_medida"
        '    .ValueMember = "Cantidad_por_unidad_de_medida"
        'End With
        'With txtcantidad
        '    .DataSource = dtunidad
        '    .DisplayMember = "Precio"
        '    .ValueMember = "Precio"
        'End With
    End Sub

    Private Sub buscar_por_descripcion_CheckedChanged(sender As Object, e As EventArgs) Handles buscar_por_descripcion.CheckedChanged
        txtbuscar.Focus()

        txtbuscar.Focus()
    End Sub


    Private Sub datalistadoclientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoclientes.CellClick
        Try
            txtcliente.Text = datalistadoclientes.SelectedCells.Item(1).Value
            txtclientesolicitabnte.Text = datalistadoclientes.SelectedCells.Item(1).Value
            datalistadoclientes.Visible = False
            panel_fechasoka.Enabled = True
            PANELPRODUCTOS.Enabled = True
            If e.ColumnIndex = Me.datalistadoclientes.Columns.Item("Editar").Index Then

            End If
        Catch ex As Exception

        End Try


    End Sub


    Private Sub datalistadoclientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoclientes.CellContentClick

    End Sub



    Private Sub datalistadocomprobante_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub txtclientesolicitabnte_Click(sender As Object, e As EventArgs) Handles txtclientesolicitabnte.Click
        datalistadoclientes.Visible = True
        Label12.Visible = True
        txtclientesolicitabnte.Text = ""

    End Sub

    Private Sub txtclientesolicitabnte_KeyDown(sender As Object, e As KeyEventArgs) Handles txtclientesolicitabnte.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            datalistadoclientes.Focus()

        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            datalistadoclientes.Focus()

        End If
    End Sub

    Private Sub txtclientesolicitabnte_TextChanged(sender As Object, e As EventArgs) Handles txtclientesolicitabnte.TextChanged
        If lblTipo.Text = "POR PAGAR" Then
            cargarPROVEEDORES()
        End If
        If lblTipo.Text = "POR COBRAR" Then
            buscar_cliente_POR_nombre_PARA_VENTAS_todos()
        End If
        If txtclientesolicitabnte.Text = "" Then
            Label12.Visible = True
        ElseIf txtclientesolicitabnte.Text <> "" Then
            Label12.Visible = False
        End If
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        If lblTipo.Text = "POR PAGAR" Then

            MASCARA1.Show()
            MASCARA1.FormBorderStyle = FormBorderStyle.None
            Rregistro_de_proveedores.ShowDialog()

        End If
        If lblTipo.Text = "POR COBRAR" Then
            MASCARA1.Show()
            MASCARA1.FormBorderStyle = FormBorderStyle.None

            Registro_clientes.ShowDialog()


        End If




    End Sub


    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub radiocredito_CheckedChanged(sender As Object, e As EventArgs) Handles radiocredito.CheckedChanged
        txtfecha_de_pago.Visible = True
        Label21.Visible = True
    End Sub

    Private Sub radiocontado_CheckedChanged(sender As Object, e As EventArgs) Handles radiocontado.CheckedChanged
        txtfecha_de_pago.Visible = False
        Label21.Visible = False
    End Sub

    Private Sub txtfecha_de_pago_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        productosOK.ShowDialog()


    End Sub

    Private Sub btnsologuardarcreditos_Click(sender As Object, e As EventArgs) Handles btnsologuardarcreditos.Click
        Dim numero As Double
        numero = txttotalentero.Text
        txttotaltexto.Text = Num2Text(numero)
        Dim a() As String
        a = Split(txttotal.Text, ".")
        txttotaldecimal.Text = a(1) & "0"
        txtnumeroconvertidoenletra.Text = txttotaltexto.Text & " CON " & txttotaldecimal.Text & "/100"
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("actualizartotal_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)
            cmd.Parameters.AddWithValue("@montototal", txttotal.Text)
            cmd.Parameters.AddWithValue("@IGV", txtigv.Text)
            cmd.Parameters.AddWithValue("@Tipo_de_pago", "CREDITO")
            cmd.ExecuteNonQuery()



            If radiocredito.Checked = True Then
                aumentar_monto_a_cliente()

            End If
            MsgBox("VENTA GUARDADA CORRECTAMENTE")
            Cerrar()


            limpiar()
            Listarproductosagregados()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ActualizarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem1.Click
        Listarpresentaciones_con_precios_agregados()

    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        productosOK.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidad.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                Try
                    Dim stock As Decimal
                    Dim cantidad As Decimal
                    stock = txtstockok.Text
                    cantidad = txtcantidad.Text * txtcantidad_de_unidad_de_medida.Text * 1
                    If noafectarstock.Checked = True Then
                        sub_TOTAL()
                        Dim cmd As New SqlCommand
                        abrir()
                        cmd = New SqlCommand("insertar_detalle_venta", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)
                        cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", datalistado.SelectedCells.Item(5).Value)
                        cmd.Parameters.AddWithValue("@cantidad", cantidad)
                        cmd.Parameters.AddWithValue("@preciounitario", txtprecioreal.Text)
                        cmd.Parameters.AddWithValue("@moneda", "S/.")
                        cmd.Parameters.AddWithValue("@totalapagar", txttotalparcialporproductovendido.Text)
                        cmd.Parameters.AddWithValue("@unidades", txtunidad.Text)
                        cmd.Parameters.AddWithValue("@Cantidad_mostrada", txtcantidad.Text)
                        cmd.Parameters.AddWithValue("@Estado", "DESPACHO PENDIENTE")
                        If txtstockok.Text >= txtcantidad.Text Then
                            cmd.Parameters.AddWithValue("@Requerir_Produccion", "NO")
                        ElseIf txtstockok.Text < txtcantidad.Text Then
                            MessageBox.Show("¿NO SE CUENTA CON STOCK,DESEA REQUERIR A PRODUCCION?", "REQUERIR A PRODUCCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            If DialogResult.OK Then
                                cmd.Parameters.AddWithValue("@Requerir_Produccion", "SI")
                            ElseIf DialogResult.No Then
                                cmd.Parameters.AddWithValue("@Requerir_Produccion", "NO")
                            End If
                        End If

                    End If


                Catch ex As Exception : MessageBox.Show(ex.Message)
                End Try



            End If

        Catch ex As Exception

        End Try
    End Sub
    Sub insertar_detalle_venta()
        Try

            Dim stock As Decimal
            Dim cantidad As Decimal
            stock = txtstockok.Text
            cantidad = txtpantalla.Text * txtcantidad_de_unidad_de_medidaoka.Text * 1

            'sub_TOTAL()


            Dim cantidad2 As Decimal
            Dim preciouni As Decimal
            Dim total As Decimal
            cantidad2 = txtpantalla.Text * txtcantidad_de_unidad_de_medidaoka.Text * 1
            preciouni = txtprecio.Text
            total = cantidad2 * preciouni * 1
            txttotal_oka.Text = total
            txtcantidad_total.Text = cantidad2


            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_detalle_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)
            cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", Id_presentacion.Text)
            cmd.Parameters.AddWithValue("@cantidad", txtcantidad_total.Text)
            cmd.Parameters.AddWithValue("@preciounitario", txtprecio.Text)
            cmd.Parameters.AddWithValue("@moneda", "S/.")
            cmd.Parameters.AddWithValue("@totalapagar", txttotal_oka.Text)
            cmd.Parameters.AddWithValue("@unidades", txtunidad.Text)
            cmd.Parameters.AddWithValue("@Cantidad_mostrada", txtpantalla.Text)
            cmd.Parameters.AddWithValue("@Estado", "DESPACHO PENDIENTE")
            cmd.ExecuteNonQuery()
            Cerrar()
            detalle_producto.Visible = False
            Listarproductosagregados()
            sumar()
            txtcantidad.Text = 0
            txtprecioreal.Text = 0
            'txtbuscar.Text = ""

        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try



    End Sub
    Private Sub txtcantidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcantidad.SelectedIndexChanged

    End Sub

    Private Sub txtunidad_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles txtunidad.SelectedIndexChanged
        With txtcantidad_de_unidad_de_medidaoka
            .DataSource = dtunidad
            .DisplayMember = "Cantidad_por_unidad_de_medida"
            .ValueMember = "Cantidad_por_unidad_de_medida"
        End With

    End Sub

    Private Sub ToolStripMenuItem10_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        UND.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click


    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles PANELCLIENTE.Paint

    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub paneldegenerarventa_Paint(sender As Object, e As PaintEventArgs) Handles paneldegenerarventa.Paint

    End Sub

    Sub agregar_datos()
        Dim cmd As New SqlCommand
        abrir()
        cmd = New SqlCommand("insertar_venta", conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@idcliente", datalistadoclientes.SelectedCells.Item(2).Value)

        If lblTipo.Text = "POR PAGAR" Then
            cmd.Parameters.AddWithValue("@ACCION", "POR PAGAR OTROS")
        End If
        If lblTipo.Text = "POR COBRAR" Then
            cmd.Parameters.AddWithValue("@ACCION", "POR COBRAR OTROS")
        End If
        cmd.Parameters.AddWithValue("@fecha_venta", txtfechadeventa.Value)
        cmd.Parameters.AddWithValue("@Fecha_de_pago", txtfecha_de_pago.Value)
        cmd.Parameters.AddWithValue("@Comprobante", "Ticket " & txtidventa.Text)
        cmd.Parameters.AddWithValue("@nume_documento", txtnumerodecomprobante.Text)
        cmd.Parameters.AddWithValue("@montototal", txtsaldo.Text)
        cmd.Parameters.AddWithValue("@IGV", 0)
        cmd.Parameters.AddWithValue("@id_usuario", VENTAS_MENU_PRINCIPAL.lblidusuario.Text)
        cmd.Parameters.AddWithValue("@estado", "OTRAS CUENTAS")
        cmd.Parameters.AddWithValue("@Tipo_de_pago", "CREDITO")
        cmd.Parameters.AddWithValue("@Saldo", 0)
        cmd.Parameters.AddWithValue("@Pago_con", 0)
        cmd.Parameters.AddWithValue("@Porcentaje_IGV", 0)
        cmd.Parameters.AddWithValue("@Id_caja", LOGIN.txtidcaja.Text)
        cmd.Parameters.AddWithValue("@Referencia_tarjeta", "NULO")

        cmd.ExecuteNonQuery()
        Cerrar()
        ListarPOR_PAGAR()
        txtidventa.Text = datalistadoventas.SelectedCells.Item(1).Value
        insertar_POR_PAGAR()
        aumentar_monto_a_PROVEEDOR()
        MessageBox.Show("Registro Guardado Correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        VENTAS_MENU_PRINCIPAL.TimerNotificaciones.Start()

        Close()
    End Sub
    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Try
            If txtclientesolicitabnte.Text <> "" Then
                If txtconcepto.Text <> "" Then
                    If txtsaldo.Text <> "" Then
                        If txtsaldo.Text > 0 Then
                            If lblTipo.Text = "POR PAGAR" Then
                                Try
                                    If idconcepto = datalistadogrupodegastos.SelectedCells.Item(1).Value And txtetiqueta.Text = datalistadogrupodegastos.SelectedCells.Item(2).Value Then
                                        agregar_datos()
                                    Else
                                        MessageBox.Show("Ingrese una Etiqueta", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                        txtetiqueta.Focus()
                                    End If
                                Catch ex As Exception
                                    MessageBox.Show("Ingrese una Etiqueta", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    txtetiqueta.Focus()
                                End Try
                            ElseIf lblTipo.Text = "POR COBRAR"
                                agregar_datos()
                            End If
                        Else
                                MessageBox.Show("Ingrese el Saldo", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtsaldo.Focus()
                        End If
                    Else
                            MessageBox.Show("Ingrese el Saldo", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtsaldo.Focus()
                    End If
                Else
                        MessageBox.Show("Ingrese el detalle por favor", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtconcepto.Focus()
                End If
            Else
                MessageBox.Show("Seleccione un Registro", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtclientesolicitabnte.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub aumentar_monto_a_PROVEEDOR()
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("aumentar_saldo_a_cliente", conexion)
            cmd.CommandType = 4

            cmd.Parameters.AddWithValue("@idcliente", datalistadoclientes.SelectedCells.Item(2).Value)
            cmd.Parameters.AddWithValue("@Saldo", txtsaldo.Text)

            cmd.ExecuteNonQuery()
            Cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub insertar_POR_PAGAR()

        Try

            Dim cmd As New SqlCommand
            abrir()

            cmd = New SqlCommand("insertar_detalle_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)
            cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", idconcepto)
            cmd.Parameters.AddWithValue("@cantidad", 1)
            cmd.Parameters.AddWithValue("@preciounitario", txtsaldo.Text)
            cmd.Parameters.AddWithValue("@moneda", VENTAS_MENU_PRINCIPAL.txtmoneda.Text)


            cmd.Parameters.AddWithValue("@unidades", "Unidad")
            cmd.Parameters.AddWithValue("@Cantidad_mostrada", 1)
            cmd.Parameters.AddWithValue("@Estado", "-")
            cmd.Parameters.AddWithValue("@Descripcion", txtconcepto.Text)
            cmd.Parameters.AddWithValue("@Codigo", 0)
            cmd.Parameters.AddWithValue("@Costo", 0)
            cmd.Parameters.AddWithValue("@Stock", 0)

            cmd.Parameters.AddWithValue("@Se_vende_a", 0)
            cmd.Parameters.AddWithValue("@Usa_inventarios", 0)


            cmd.ExecuteNonQuery()
            Cerrar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
    Sub MOSTRAR_USUARIOS()

        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("SELECT * FROM USUARIO2", conexion)
            DA.Fill(DT_USUARIO)
            CBXVENDEDOR.DisplayMember = "Nombre_y_Apelllidos"
            CBXVENDEDOR.ValueMember = "idUsuario"
            CBXVENDEDOR.DataSource = DT_USUARIO
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub CBXVENDEDOR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBXVENDEDOR.SelectedIndexChanged
        With TXTIDUSUARIO
            .DataSource = DT_USUARIO
            .DisplayMember = "idUsuario"
            .ValueMember = "idUsuario"

        End With
    End Sub

    Private Sub DATALISTADO_PRODUCTOS_OKA_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_PRODUCTOS_OKA.CellClick
        Try


            txtprecio.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(3).Value

            Id_presentacion.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(1).Value

            txtbuscar.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(2).Value
            Try
                txtprecio_por_unidad_De_medida.Text = txtprecio.Text * txtcantidad_de_unidad_de_medidaoka.Text * 1

            Catch ex As Exception

            End Try

            DATALISTADO_PRODUCTOS_OKA.Visible = False
        Catch ex As Exception

        End Try


    End Sub

    Private Sub DATALISTADO_PRODUCTOS_OKA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_PRODUCTOS_OKA.CellContentClick

    End Sub

    Private Sub TXTIDUSUARIO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXTIDUSUARIO.SelectedIndexChanged
        lblidusuario.Text = TXTIDUSUARIO.Text
    End Sub

    Private Sub txtpantalla_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpantalla.KeyDown
        'Try
        '    If e.KeyCode = Keys.Enter Then
        '        e.SuppressKeyPress = True
        '        Try
        '            Dim stock As Decimal
        '            Dim cantidad As Decimal
        '            stock = txtstockok.Text
        '            cantidad = txtcantidad.Text * txtcantidad_de_unidad_de_medida.Text * 1

        '                    sub_TOTAL()
        '                    Dim cmd As New SqlCommand
        '                    abrir()
        '                    cmd = New SqlCommand("insertar_detalle_venta", conexion)
        '                    cmd.CommandType = 4
        '                    cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)
        '                    cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", datalistado.SelectedCells.Item(5).Value)
        '                    cmd.Parameters.AddWithValue("@cantidad", cantidad)
        '            cmd.Parameters.AddWithValue("@preciounitario", txtprecio.Text)
        '                    cmd.Parameters.AddWithValue("@moneda", "S/.")
        '                    cmd.Parameters.AddWithValue("@totalapagar", txttotalparcialporproductovendido.Text)
        '                    cmd.Parameters.AddWithValue("@unidades", txtunidad.Text)
        '                    cmd.Parameters.AddWithValue("@Cantidad_mostrada", txtcantidad.Text)
        '                    cmd.Parameters.AddWithValue("@Estado", "DESPACHO PENDIENTE")
        '                    cmd.ExecuteNonQuery()
        '                    Cerrar()
        '                    detalle_producto.Visible = False
        '                    Listarproductosagregados()
        '                    sumar()
        '                    txtcantidad.Text = 0
        '                    txtprecioreal.Text = 0
        '                    'txtbuscar.Text = ""

        '        Catch ex As Exception : MessageBox.Show(ex.Message)
        '        End Try



        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub txtpantalla_TextChanged(sender As Object, e As EventArgs) Handles txtpantalla.TextChanged

    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged

    End Sub

    Private Sub txtcantidad_de_unidad_de_medidaoka_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcantidad_de_unidad_de_medidaoka.SelectedIndexChanged
        lbl_unidadoka.Text = txtunidad.Text
        Try
            txtprecio_por_unidad_De_medida.Text = txtprecio.Text * txtcantidad_de_unidad_de_medidaoka.Text * 1

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtprecio_por_unidad_De_medida_TextChanged(sender As Object, e As EventArgs) Handles txtprecio_por_unidad_De_medida.TextChanged
        Try

            txtprecio.Text = txtprecio_por_unidad_De_medida.Text / txtcantidad_de_unidad_de_medidaoka.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        aumentar_monto_a_cliente_PARA_COMISIONES()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim progFiles As String = "C:\Program Files\Common Files\Microsoft Shared\ink"
        Dim keyboardPath As String = Path.Combine(progFiles, "TabTip.exe")
        Process.Start(keyboardPath)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Close()



    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs) Handles Label41.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click, Label24.Click

    End Sub

    Private Sub txtconcepto_TextChanged(sender As Object, e As EventArgs) Handles txtconcepto.TextChanged

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

    Private Sub txtsaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsaldo.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then

            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtsaldo, e)
    End Sub


    Private Sub txtsaldo_TextChanged(sender As Object, e As EventArgs) Handles txtsaldo.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If lblTipo.Text = "POR PAGAR" Then
            cargarPROVEEDORES()
        End If
        If lblTipo.Text = "POR COBRAR" Then
            buscar_cliente_POR_nombre_PARA_VENTAS_todos()
        End If
    End Sub

    Private Sub datalistadoclientes_KeyDown(sender As Object, e As KeyEventArgs) Handles datalistadoclientes.KeyDown
        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True

            SendKeys.Send("{TAB}")
            Try
                txtcliente.Text = datalistadoclientes.SelectedCells.Item(1).Value

                txtclientesolicitabnte.Text = datalistadoclientes.SelectedCells.Item(1).Value


                datalistadoclientes.Visible = False
                panel_fechasoka.Enabled = True
                PANELPRODUCTOS.Enabled = True
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Label12.Visible = True
        txtclientesolicitabnte.Text = ""

    End Sub
    Dim idconcepto As Integer
    Private Sub datalistadogrupodegastos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadogrupodegastos.CellClick
        Try

            idconcepto = datalistadogrupodegastos.SelectedCells.Item(1).Value
            txtetiqueta.Text = datalistadogrupodegastos.SelectedCells.Item(2).Value
            datalistadogrupodegastos.Visible = False

            If e.ColumnIndex = Me.datalistadogrupodegastos.Columns.Item("Editar").Index Then
                GuardarRegistroToolStripMenuItem.Visible = False
                ModificarToolStripMenuItem.Visible = True
                txtdescripcion.Text = datalistadogrupodegastos.SelectedCells.Item(2).Value
                Panel9.Visible = True
                txtbuscar.Text = ""
            End If
        Catch ex As Exception

        End Try


    End Sub
    Private Sub datalistadogrupodegastos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadogrupodegastos.CellContentClick

    End Sub

    Private Sub GuardarRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarRegistroToolStripMenuItem.Click
        Dim cmd As New SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("insertar_Conceptos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text)
            cmd.ExecuteNonQuery()
            Cerrar()
            'MOSTRAR_CONCEPTOS_GASTOS()             
            Panel9.Visible = False
            Timer2.Start()

        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub
    Sub MOSTRAR_CONCEPTOS_EN_GASTOS_VARIOS()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("MOSTRAR_CONCEPTOS_EN_GASTOS_VARIOS", conexion)
            da.Fill(dt)
            datalistadogrupodegastos.DataSource = dt
            datalistadogrupodegastos.Columns(1).Visible = False
            datalistadogrupodegastos.Columns(2).Width = 500
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()

        If lblTipo.Text = "POR PAGAR" Then
                MOSTRAR_CONCEPTOS_EN_GASTOS_VARIOS()
            End If
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Dim cmd As New SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("editar_CONCEPTO", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text)
            cmd.Parameters.AddWithValue("@Id_concepto", idconcepto)
            cmd.ExecuteNonQuery()
            Cerrar()

            Panel9.Visible = False
            txtbuscar.Text = ""
            Timer2.Start()
        Catch ex As Exception : MsgBox(ex.Message)
        End Try

    End Sub
    Sub BUSCAR_CONCEPTOS_EN_GASTOS_VARIOS()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("BUSCAR_CONCEPTOS_EN_GASTOS_VARIOS", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtetiqueta.Text)
            da.Fill(dt)
            datalistadogrupodegastos.DataSource = dt

            datalistadogrupodegastos.Columns(1).Visible = False

            datalistadogrupodegastos.Columns(2).Width = 230

            Cerrar()
        Catch ex As Exception
        End Try


    End Sub
    Private Sub txtetiqueta_TextChanged(sender As Object, e As EventArgs) Handles txtetiqueta.TextChanged
        BUSCAR_CONCEPTOS_EN_GASTOS_VARIOS()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        txtetiqueta.Text = ""
        idconcepto = 0
        txtdescripcion.Focus()
        Panel9.Visible = True
        GuardarRegistroToolStripMenuItem.Visible = True
        ModificarToolStripMenuItem.Visible = False

    End Sub

    Private Sub txtetiqueta_MouseEnter(sender As Object, e As EventArgs) Handles txtetiqueta.MouseEnter

    End Sub

    Private Sub txtetiqueta_Click(sender As Object, e As EventArgs) Handles txtetiqueta.Click
        datalistadogrupodegastos.Visible = True

        txtetiqueta.Text = ""
        BUSCAR_CONCEPTOS_EN_GASTOS_VARIOS()
    End Sub
End Class
