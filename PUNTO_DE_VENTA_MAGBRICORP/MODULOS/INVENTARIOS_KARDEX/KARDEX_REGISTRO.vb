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
Public Class KARDEX_REGISTRO
    Private memoria1 As Double = 0.0
    Private memoria2 As Double = 0.0
    Private signo As String
    Dim DT_USUARIO As New DataTable
    Private txt() As PictureBox
    Private lbl() As Label
    Private lbl2() As Button
    Private b() As Button
    Private a() As Label
    Private ESTADO() As Label
    Private ima() As PictureBox
    Dim panel As New PanelExtended
    Dim i As Integer
    Dim j As Integer = 0
    Dim DTturnoinicial As New DataTable
    Dim DTturnofinal As New DataTable


    Dim dtcliente As New DataTable
    Dim dtidventa As New DataTable
    Dim dtserie As New DataTable
    Dim dtunidad As New DataTable
    Private Sub KARDEX_REGISTRO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblidusuario.Text = VENTAS_MENU_PRINCIPAL.lblidusuario.Text
        LISTAR_PRODUCTOS_Abuscador()
        lblcantidadactual.Text = ""
        DATALISTADO_MOTIVOS.Visible = False
    End Sub
   

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
        With txtcantidad_de_unidad_de_medidaoka

            .DataSource = dtunidad
            .DisplayMember = "Cantidad_por_unidad_de_medida"
            .ValueMember = "Cantidad_por_unidad_de_medida"
        End With
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TXTBUSCARProducto.Click
        DATALISTADO_AGREGANDO.Visible = True
        TXTBUSCARProducto.Text = ""

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXTBUSCARProducto.TextChanged
        LISTAR_PRODUCTOS_Abuscador()

    End Sub
    Sub LISTAR_PRODUCTOS_Abuscador()
        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("BUSCAR_PRODUCTOS_KARDEX", conexion)
            daListarpresentacionesagregadas.SelectCommand.CommandType = 4


            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@letrab", TXTBUSCARProducto.Text)

            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            DATALISTADO_AGREGANDO.DataSource = dtDATALISTADO_AGREGANDO
            DATALISTADO_AGREGANDO.Columns(0).Visible = False
            DATALISTADO_AGREGANDO.Columns(1).Visible = False
            DATALISTADO_AGREGANDO.Columns(3).Visible = False

            DATALISTADO_AGREGANDO.Columns(4).Visible = False
            DATALISTADO_AGREGANDO.Columns(5).Visible = False
            DATALISTADO_AGREGANDO.Columns(6).Visible = False
            DATALISTADO_AGREGANDO.Columns(7).Visible = False
            DATALISTADO_AGREGANDO.Columns(8).Visible = False
            DATALISTADO_AGREGANDO.Columns(9).Visible = False
            DATALISTADO_AGREGANDO.Columns(10).Visible = False
            DATALISTADO_AGREGANDO.Columns(11).Visible = False
            DATALISTADO_AGREGANDO.Columns(12).Visible = False
            DATALISTADO_AGREGANDO.Columns(13).Visible = False
            DATALISTADO_AGREGANDO.Columns(14).Visible = False
            DATALISTADO_AGREGANDO.Columns(15).Visible = False
            DATALISTADO_AGREGANDO.Columns(16).Visible = False

            DATALISTADO_AGREGANDO.Columns(2).Width = DATALISTADO_AGREGANDO.Width

        Catch ex As Exception
        End Try
        Cerrar()
        'sumar_total_despachado()
    End Sub
    Dim precio_mayoreo As Double

    Private Sub DATALISTADO_AGREGANDO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_AGREGANDO.CellClick
        Try
            txtagregar.Clear()

            lblcantidadactual.Text = DATALISTADO_AGREGANDO.SelectedCells.Item(6).Value
            txtcosto.Text = DATALISTADO_AGREGANDO.SelectedCells.Item(7).Value
            LBLCOSTO.Text = DATALISTADO_AGREGANDO.SelectedCells.Item(7).Value
            txtprecio_venta.Text = DATALISTADO_AGREGANDO.SelectedCells.Item(9).Value
            txtpreciomayoreo.Text = DATALISTADO_AGREGANDO.SelectedCells.Item(14).Value
            TXTBUSCARProducto.Text = DATALISTADO_AGREGANDO.SelectedCells.Item(2).Value
            txtidproducto.Text = DATALISTADO_AGREGANDO.SelectedCells.Item(1).Value
            precio_mayoreo = DATALISTADO_AGREGANDO.SelectedCells.Item(14).Value
            If precio_mayoreo > 0 Then
                Label43.Visible = True
                txtpreciomayoreo.Visible = True
            Else
                Label43.Visible = False
                txtpreciomayoreo.Visible = False
            End If
            DATALISTADO_AGREGANDO.Visible = False


        Catch ex As Exception
        End Try
    End Sub


    Sub disminuir_stock()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("disminuir_stock_y_editar_precios", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", txtidproducto.Text)
            cmd.Parameters.AddWithValue("@cantidad", txtagregar.Text)
            cmd.Parameters.AddWithValue("@Precio_de_compra", LBLNUEVO_COSTO_PROMEDIADO.Text)
            cmd.Parameters.AddWithValue("@Precio_de_venta", txtprecio_venta.Text)
            cmd.Parameters.AddWithValue("@Precio_mayoreo", txtpreciomayoreo.Text)

            cmd.ExecuteNonQuery()
            Cerrar()
            MessageBox.Show("Registro Guardado Correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub

    Sub aumentar_stock()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("aumentar_stock_y_editar_precios", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", txtidproducto.Text)
            cmd.Parameters.AddWithValue("@cantidad", txtagregar.Text)
            cmd.Parameters.AddWithValue("@Precio_de_compra", LBLNUEVO_COSTO_PROMEDIADO.Text)
            cmd.Parameters.AddWithValue("@Precio_de_venta", txtprecio_venta.Text)
            cmd.Parameters.AddWithValue("@Precio_mayoreo", txtpreciomayoreo.Text)

            cmd.ExecuteNonQuery()
            Cerrar()
            MessageBox.Show("Registro Guardado Correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub agregar_datos()
        If txtcmotivo.Text = "" Then txtcmotivo.Text = "Sin Detallar"
        If txtpreciomayoreo.Text = "" Then txtpreciomayoreo.Text = 0
        If TXTTIPO.Text = "ENTRADA" Then
            aumentar_stock()
            Entrada_kardex()
        End If
        If TXTTIPO.Text = "SALIDA" Then
            disminuir_stock()
            salida_kardex()

        End If
    End Sub
    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Try
            If txtcosto.Text = "" Then txtcosto.Text = 0
            Dim NUEVO_COSTO As Double
            NUEVO_COSTO = ((LBLCOSTO.Text * lblcantidadactual.Text * 1) + (txtcosto.Text * txtagregar.Text * 1)) / (lblcantidadactual.Text * 1 + txtagregar.Text * 1)
            LBLNUEVO_COSTO_PROMEDIADO.Text = NUEVO_COSTO
        Catch ex As Exception
        End Try
        Try
            If txtagregar.Text * 1 > 0 Then
                If txtprecio_venta.Text * 1 > 0 Then
                    If precio_mayoreo > 0 Then
                        If txtpreciomayoreo.Text * 1 > 0 Then
                            agregar_datos()
                        Else
                            MessageBox.Show("Ingrese el Precio de Mayoreo", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtprecio_venta.Focus()
                        End If
                    Else precio_mayoreo = 0
                        agregar_datos()
                    End If
                Else
                    MessageBox.Show("Ingrese el Precio de Venta", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtprecio_venta.Focus()
                    txtprecio_venta.SelectAll()
                End If
            Else
                MessageBox.Show("Ingrese una cantidad", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtagregar.Focus()
                txtagregar.SelectAll()
            End If

        Catch ex As Exception
            MessageBox.Show("Hay campos vacios", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub
    Sub limpiar()
        TXTBUSCARProducto.Text = ""
        txtcmotivo.Text = ""
        txtagregar.Text = ""
        txtidproducto.Text = ""
        txtagregar.Text = ""
        txtcosto.Clear()
        txtprecio_venta.Clear()
        txtpreciomayoreo.Clear()
        txtcmotivo.Clear()
        DATALISTADO_AGREGANDO.Visible = True
        LISTAR_PRODUCTOS_Abuscador()

    End Sub
    Sub salida_kardex()

        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_KARDEX_SALIDA", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Fecha", Now())
            cmd.Parameters.AddWithValue("@Motivo", txtcmotivo.Text)
            cmd.Parameters.AddWithValue("@Cantidad ", txtagregar.Text)
            cmd.Parameters.AddWithValue("@Id_producto", DATALISTADO_AGREGANDO.SelectedCells.Item(1).Value)
            cmd.Parameters.AddWithValue("@Id_usuario", VENTAS_MENU_PRINCIPAL.lblidusuario.Text)
            cmd.Parameters.AddWithValue("@Tipo", TXTTIPO.Text)
            cmd.Parameters.AddWithValue("@Estado", "DESPACHO CONFIRMADO")
            cmd.Parameters.AddWithValue("@Id_caja", VENTAS_MENU_PRINCIPAL.lblidcaja.Text)
            cmd.ExecuteNonQuery()
            Cerrar()


            limpiar()



        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub Entrada_kardex()

        Try
            Dim cmd As New SqlCommand

            abrir()

            cmd = New SqlCommand("insertar_KARDEX_ENTRADA", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Fecha", Now())
            cmd.Parameters.AddWithValue("@Motivo", txtcmotivo.Text)
            cmd.Parameters.AddWithValue("@Cantidad ", txtagregar.Text)
            cmd.Parameters.AddWithValue("@Id_producto", DATALISTADO_AGREGANDO.SelectedCells.Item(1).Value)
            cmd.Parameters.AddWithValue("@Id_usuario", VENTAS_MENU_PRINCIPAL.lblidusuario.Text)
            cmd.Parameters.AddWithValue("@Tipo", TXTTIPO.Text)
            cmd.Parameters.AddWithValue("@Estado", "DESPACHO CONFIRMADO")
            cmd.Parameters.AddWithValue("@Id_caja", VENTAS_MENU_PRINCIPAL.lblidcaja.Text)
            cmd.ExecuteNonQuery()

            Cerrar()
            limpiar()


        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub REGISTRO_GUARDADO()
        Dim toolTip1 As ToolTip = New ToolTip()
        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 1000
        toolTip1.ReshowDelay = 500
        toolTip1.ShowAlways = True
        toolTip1.Show("HOLA", btn_insertar)
        'toolTip1.SetToolTip(Me.Button1, "My button1")
        'toolTip1.SetToolTip(Me.checkBox1, "My checkBox1")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MASCARA1.Hide()
        Close()
        VENTAS_MENU_PRINCIPAL.TimerDisposeMascara.Start()
    End Sub

    Private Sub txtcmotivo_TextChanged(sender As Object, e As EventArgs) Handles txtcmotivo.TextChanged
        mostrar_MOTIVOS_sin_repetir()
        contar()

        If txtcmotivo.Text <> "" And LBLCONTADOR.Text > 0 Then
            DATALISTADO_MOTIVOS.Visible = True

        Else
            DATALISTADO_MOTIVOS.Visible = False
        End If

    End Sub
    Sub mostrar_MOTIVOS_sin_repetir()
        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("mostrar_MOTIVOS_sin_repetir", conexion)
            daListarpresentacionesagregadas.SelectCommand.CommandType = 4
            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@letrab", txtcmotivo.Text)

            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            DATALISTADO_MOTIVOS.DataSource = dtDATALISTADO_AGREGANDO
            Cerrar()


        Catch ex As Exception
        End Try
        DATALISTADO_MOTIVOS.Columns(0).Visible = False
        DATALISTADO_MOTIVOS.Columns(1).Width = DATALISTADO_MOTIVOS.Width

        'sumar_total_despachado()
    End Sub

    Private Sub DATALISTADO_MOTIVOS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_MOTIVOS.CellClick
        Try
            txtcmotivo.Text = DATALISTADO_MOTIVOS.SelectedCells.Item(1).Value
            DATALISTADO_MOTIVOS.Visible = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub contar()
        Dim x As Integer
        x = DATALISTADO_MOTIVOS.Rows.Count
        LBLCONTADOR.Text = CStr(x)
    End Sub
    Private Sub DATALISTADO_MOTIVOS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_MOTIVOS.CellContentClick

    End Sub

    Private Sub DATALISTADO_AGREGANDO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_AGREGANDO.CellContentClick

    End Sub
    Sub calcular_costos()
        Try
            If txtagregar.Text <> "" Then
                If txtagregar.Text * 1 > 0 Then
                    Try
                        Dim NUEVO_COSTO As Double
                        NUEVO_COSTO = ((LBLCOSTO.Text * lblcantidadactual.Text * 1) + (txtcosto.Text * txtagregar.Text * 1)) / (lblcantidadactual.Text * 1 + txtagregar.Text * 1)
                        LBLNUEVO_COSTO_PROMEDIADO.Text = NUEVO_COSTO
                        LBLNUEVO_COSTO_PROMEDIADO.Text = Format(CType(LBLNUEVO_COSTO_PROMEDIADO.Text, Decimal), "##0.00")
                    Catch ex As Exception
                    End Try
                    If precio_mayoreo > 0 Then
                        PanelAnuncioPrecios.Visible = True
                        lblAnunciodeNuevosPrecios.Text = "Se recibiran " & txtagregar.Text & " De Inventario para el Producto, el Nuevo costo sera de " & LBLNUEVO_COSTO_PROMEDIADO.Text _
                    & " El precio de Venta sera de " & txtprecio_venta.Text & " y el Precio de mayoreo de " & txtpreciomayoreo.Text

                    Else

                        PanelAnuncioPrecios.Visible = True
                        lblAnunciodeNuevosPrecios.Text = "Se recibiran " & txtagregar.Text & " De Inventario para el Producto, el Nuevo costo sera de " & LBLNUEVO_COSTO_PROMEDIADO.Text _
                    & " El precio de Venta sera de " & txtprecio_venta.Text

                    End If

                Else
                    PanelAnuncioPrecios.Visible = False
                End If

            End If
        Catch ex As Exception
            PanelAnuncioPrecios.Visible = False
        End Try

    End Sub
    Private Sub txtcosto_TextChanged(sender As Object, e As EventArgs) Handles txtcosto.TextChanged
        calcular_costos()

    End Sub

    Private Sub txtprecio_venta_TextChanged(sender As Object, e As EventArgs) Handles txtprecio_venta.TextChanged
        calcular_costos()
    End Sub

    Private Sub txtagregar_TextChanged(sender As Object, e As EventArgs) Handles txtagregar.TextChanged
        calcular_costos()

    End Sub

    Private Sub txtpreciomayoreo_TextChanged(sender As Object, e As EventArgs) Handles txtpreciomayoreo.TextChanged
        calcular_costos()
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
        ElseIf e.KeyChar = ", " Then
            e.Handled = False

        Else
            e.Handled = True

        End If


    End Sub
    Private Sub txtagregar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtagregar.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtagregar, e)
    End Sub

    Private Sub txtcosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcosto.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtcosto, e)
    End Sub

    Private Sub txtprecio_venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio_venta.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtprecio_venta, e)
    End Sub

    Private Sub txtpreciomayoreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpreciomayoreo.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtpreciomayoreo, e)
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class