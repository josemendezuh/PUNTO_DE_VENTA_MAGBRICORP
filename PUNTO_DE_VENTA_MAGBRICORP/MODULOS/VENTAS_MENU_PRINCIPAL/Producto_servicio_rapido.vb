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
Public Class Producto_servicio_rapido
    Sub insertar_detalle_venta()
        Try


            If txtcosto.Text = "" Then txtcosto.Text = 0

            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_detalle_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", txtidventa.Text)
            cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", 0)
            cmd.Parameters.AddWithValue("@cantidad", txtcantidad.Text)
            cmd.Parameters.AddWithValue("@preciounitario", txtprecio.Text)
            cmd.Parameters.AddWithValue("@moneda", VENTAS_MENU_PRINCIPAL.txtmoneda.Text)


            cmd.Parameters.AddWithValue("@unidades", "Unidad")
            cmd.Parameters.AddWithValue("@Cantidad_mostrada", txtcantidad.Text)
            cmd.Parameters.AddWithValue("@Estado", "EN ESPERA")
            cmd.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text)
            cmd.Parameters.AddWithValue("@Codigo", 0)
            cmd.Parameters.AddWithValue("@Stock", "Ilimitado")
            cmd.Parameters.AddWithValue("@Se_vende_a", "No definido")
            cmd.Parameters.AddWithValue("@Usa_inventarios", "NO")
            cmd.Parameters.AddWithValue("@Costo", txtcosto.Text)


            cmd.ExecuteNonQuery()
            Cerrar()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
    Sub guardar()
        Try
            If txtprecio.Text = "" Then txtprecio.Text = 0
            txtventagenerada.Text = VENTAS_MENU_PRINCIPAL.txtventagenerada.Text

            Try

                If txtventagenerada.Text = "VENTA NUEVA" Then

                    Try
                        Dim cmd As New SqlCommand
                        abrir()
                        cmd = New SqlCommand("insertar_venta", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@idcliente", 0)
                        cmd.Parameters.AddWithValue("@ACCION", "VENTA")
                        cmd.Parameters.AddWithValue("@fecha_venta", Now())
                        cmd.Parameters.AddWithValue("@Fecha_de_pago", Now())
                        cmd.Parameters.AddWithValue("@Comprobante", "Ticket")
                        cmd.Parameters.AddWithValue("@nume_documento", VENTAS_MENU_PRINCIPAL.txtnumerodecomprobante.Text)
                        cmd.Parameters.AddWithValue("@montototal", 0)
                        cmd.Parameters.AddWithValue("@IGV", 0)
                        cmd.Parameters.AddWithValue("@id_usuario", VENTAS_MENU_PRINCIPAL.lblidusuario.Text)
                        cmd.Parameters.AddWithValue("@estado", "EN ESPERA")
                        cmd.Parameters.AddWithValue("@Tipo_de_pago", "-")
                        cmd.Parameters.AddWithValue("@Saldo", 0)
                        cmd.Parameters.AddWithValue("@Pago_con", 0)
                        cmd.Parameters.AddWithValue("@Porcentaje_IGV", 0)
                        cmd.Parameters.AddWithValue("@Id_caja", LOGIN.txtidcaja.Text)
                        cmd.Parameters.AddWithValue("@Referencia_tarjeta", "NULO")

                        cmd.ExecuteNonQuery()
                        Cerrar()
                        Listarventas()
                        txtidventa.Text = datalistadoventas_nuevasok.SelectedCells.Item(1).Value
                        txtventagenerada.Text = "VENTA GENERADA"
                        VENTAS_MENU_PRINCIPAL.txtventagenerada.Text = "VENTA GENERADA"
                        VENTAS_MENU_PRINCIPAL.txtidventa.Text = txtidventa.Text
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                If txtventagenerada.Text = "VENTA GENERADA" Then
                    'actualizar_serie_mas_uno()
                    txtidventa.Text = VENTAS_MENU_PRINCIPAL.txtidventa.Text
                    insertar_detalle_venta()

                    VENTAS_MENU_PRINCIPAL.Timer_MOSTRAR_PRODUCTOS_AGREGADOS.Start()

                    VENTAS_MENU_PRINCIPAL.btn_insertar.Visible = False
                    VENTAS_MENU_PRINCIPAL.BTN_SEGUIR_AGREGANDO.Visible = True

                    VENTAS_MENU_PRINCIPAL.txtbuscar.Text = ""
                    VENTAS_MENU_PRINCIPAL.txtbuscar.Focus()
                    'CONFIRMAR_VENTA()
                    VENTAS_MENU_PRINCIPAL.Panel10.Visible = False
                    VENTAS_MENU_PRINCIPAL.panel_granel.Visible = False

                    Close()

                End If
                'End If
            Catch ex As Exception
            End Try
            Try
                'If DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(6).Value <> txtbuscar.Text Then
                'End If
            Catch ex As Exception
            End Try
            'End If


        Catch ex As Exception

        End Try
    End Sub

    Sub Listarventas()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("select * from ventas order by idventa desc", conexion)
            'da.SelectCommand.CommandType = 4
            'da.SelectCommand.Parameters.AddWithValue("@letra", TextBox2.Text)
            da.Fill(dt)
            datalistadoventas_nuevasok.DataSource = dt
        Catch ex As Exception
            '
        End Try
        Cerrar()
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
            e.KeyChar = _
                Threading.Thread.CurrentThread. _
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtcantidad, e)
    End Sub
    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged
       
    End Sub

    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar = _
                Threading.Thread.CurrentThread. _
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtprecio, e)
    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged

    End Sub

    Private Sub txtcosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcosto.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar = _
                Threading.Thread.CurrentThread. _
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtcosto, e)
    End Sub

    Private Sub txtcosto_TextChanged(sender As Object, e As EventArgs) Handles txtcosto.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

        Close()

    End Sub
    Private tabtip As Process
    Private Sub closetap()
        'If Me.tabtip.HasExited Then
        tabtip.Close()


        'End If
    End Sub
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        'cierrre_proceso("osk.exe")
        Close()


    End Sub

    Private Sub Producto_servicio_rapido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdescripcion.Text = ""
        txtcosto.Text = ""
        txtcantidad.Text = ""
        txtprecio.Text = ""
        'Process.Start("osk.exe")
        'Dim query As IEnumerable(Of Button) = From btn As Button In Me.Controls.OfType(Of Button)() Select btn
        'For Each btn As Button In query.ToList()
        '    AddHandler btn.Click, AddressOf Butto
        'Next
    End Sub

    Private Sub Producto_servicio_rapido_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            guardar()
        End If

    End Sub

    Private Sub txtcantidad_MouseDown(sender As Object, e As MouseEventArgs) Handles txtcantidad.MouseDown

    End Sub

    Private Sub txtcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidad.KeyDown
        If e.KeyCode = Keys.Enter Then

            guardar()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("osk.exe")
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If INDICAR_DE_FOCO = 1 Then
            txtcantidad.Text = txtcantidad.Text & "0"
        ElseIf INDICAR_DE_FOCO = 2 Then
            txtprecio.Text = txtprecio.Text & "0"
        ElseIf INDICAR_DE_FOCO = 3 Then
            txtcosto.Text = txtcosto.Text & "0"
        End If
        Button2.Focus()

    End Sub
    Dim INDICAR_DE_FOCO As Integer

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        If INDICAR_DE_FOCO = 1 Then
            txtcantidad.Text = txtcantidad.Text & "1"
        ElseIf INDICAR_DE_FOCO = 2 Then
            txtprecio.Text = txtprecio.Text & "1"
        ElseIf INDICAR_DE_FOCO = 3 Then
            txtcosto.Text = txtcosto.Text & "1"
        End If

        Button2.Focus()




    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If INDICAR_DE_FOCO = 1 Then
            txtcantidad.Text = txtcantidad.Text & "2"
        ElseIf INDICAR_DE_FOCO = 2 Then
            txtprecio.Text = txtprecio.Text & "2"
        ElseIf INDICAR_DE_FOCO = 3 Then
            txtcosto.Text = txtcosto.Text & "2"
        End If
        Button2.Focus()

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If INDICAR_DE_FOCO = 1 Then
            txtcantidad.Text = txtcantidad.Text & "3"
        ElseIf INDICAR_DE_FOCO = 2 Then
            txtprecio.Text = txtprecio.Text & "3"
        ElseIf INDICAR_DE_FOCO = 3 Then
            txtcosto.Text = txtcosto.Text & "3"
        End If
        Button2.Focus()

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If INDICAR_DE_FOCO = 1 Then
            txtcantidad.Text = txtcantidad.Text & "4"
        ElseIf INDICAR_DE_FOCO = 2 Then
            txtprecio.Text = txtprecio.Text & "4"
        ElseIf INDICAR_DE_FOCO = 3 Then
            txtcosto.Text = txtcosto.Text & "4"
        End If
        Button2.Focus()

    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If INDICAR_DE_FOCO = 1 Then
            txtcantidad.Text = txtcantidad.Text & "5"
        ElseIf INDICAR_DE_FOCO = 2 Then
            txtprecio.Text = txtprecio.Text & "5"
        ElseIf INDICAR_DE_FOCO = 3 Then
            txtcosto.Text = txtcosto.Text & "5"
        End If
        Button2.Focus()

    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If INDICAR_DE_FOCO = 1 Then
            txtcantidad.Text = txtcantidad.Text & "6"
        ElseIf INDICAR_DE_FOCO = 2 Then
            txtprecio.Text = txtprecio.Text & "6"
        ElseIf INDICAR_DE_FOCO = 3 Then
            txtcosto.Text = txtcosto.Text & "6"
        End If
        Button2.Focus()

    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If INDICAR_DE_FOCO = 1 Then
            txtcantidad.Text = txtcantidad.Text & "7"
        ElseIf INDICAR_DE_FOCO = 2 Then
            txtprecio.Text = txtprecio.Text & "7"
        ElseIf INDICAR_DE_FOCO = 3 Then
            txtcosto.Text = txtcosto.Text & "7"
        End If
        Button2.Focus()

    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If INDICAR_DE_FOCO = 1 Then
            txtcantidad.Text = txtcantidad.Text & "8"
        ElseIf INDICAR_DE_FOCO = 2 Then
            txtprecio.Text = txtprecio.Text & "8"
        ElseIf INDICAR_DE_FOCO = 3 Then
            txtcosto.Text = txtcosto.Text & "8"
        End If
        Button2.Focus()

    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If INDICAR_DE_FOCO = 1 Then
            txtcantidad.Text = txtcantidad.Text & "9"
        ElseIf INDICAR_DE_FOCO = 2 Then
            txtprecio.Text = txtprecio.Text & "9"
        ElseIf INDICAR_DE_FOCO = 3 Then
            txtcosto.Text = txtcosto.Text & "9"
        End If
        Button2.Focus()

    End Sub

    Dim SECUENCIA As Boolean = True
    Private Sub btnborrarderecha_Click(sender As Object, e As EventArgs) Handles btnborrarderecha.Click
        If INDICAR_DE_FOCO = 1 Then
            If SECUENCIA = True Then
                txtcantidad.Text = txtcantidad.Text & "."
                SECUENCIA = False
            Else
                Return

            End If
        ElseIf INDICAR_DE_FOCO = 2 Then
            If SECUENCIA = True Then
                txtprecio.Text = txtprecio.Text & "."
                SECUENCIA = False
            Else
                Return

            End If
        ElseIf INDICAR_DE_FOCO = 3 Then
            If SECUENCIA = True Then
                txtcosto.Text = txtcosto.Text & "."
                SECUENCIA = False
            Else
                Return

            End If
        End If


        Button2.Focus()





    End Sub

    Private Sub btnborrartodo_Click(sender As Object, e As EventArgs) Handles btnborrartodo.Click
        If INDICAR_DE_FOCO = 1 Then
            txtcantidad.Clear()
            SECUENCIA = True
        ElseIf INDICAR_DE_FOCO = 2 Then
            txtprecio.Clear()
            SECUENCIA = True
        ElseIf INDICAR_DE_FOCO = 3 Then
            txtcosto.Clear()
            SECUENCIA = True
        End If
        Button2.Focus()

    End Sub

    Private Sub txtcantidad_Click(sender As Object, e As EventArgs) Handles txtcantidad.Click
        INDICAR_DE_FOCO = 1
    End Sub

    Private Sub txtprecio_Click(sender As Object, e As EventArgs) Handles txtprecio.Click
        INDICAR_DE_FOCO = 2
    End Sub

    Private Sub txtcosto_Click(sender As Object, e As EventArgs) Handles txtcosto.Click
        INDICAR_DE_FOCO = 3
    End Sub

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel2.Paint

    End Sub

    Private Sub txtcantidad_TabIndexChanged(sender As Object, e As EventArgs) Handles txtcantidad.TabIndexChanged
        INDICAR_DE_FOCO = 1
    End Sub

    Private Sub txtprecio_TabIndexChanged(sender As Object, e As EventArgs) Handles txtprecio.TabIndexChanged
        INDICAR_DE_FOCO = 2
    End Sub

    Private Sub txtcosto_TabIndexChanged(sender As Object, e As EventArgs) Handles txtcosto.TabIndexChanged
        INDICAR_DE_FOCO = 3
    End Sub

    Private Sub txtcantidad_TabStopChanged(sender As Object, e As EventArgs) Handles txtcantidad.TabStopChanged
        INDICAR_DE_FOCO = 1
    End Sub

    Private Sub btn1_KeyDown(sender As Object, e As KeyEventArgs) Handles btn1.KeyDown
        If e.KeyCode = Keys.Enter Then

            txtcantidad.Focus()




        End If
    End Sub

    Private Sub btn1_KeyUp(sender As Object, e As KeyEventArgs) Handles btn1.KeyUp
        If e.KeyCode = Keys.Enter Then

            e.Handled = True

        End If
    End Sub

    Private Sub btn1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btn1.KeyPress
        If ((e.KeyChar = "Enter")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        guardar()

    End Sub
End Class