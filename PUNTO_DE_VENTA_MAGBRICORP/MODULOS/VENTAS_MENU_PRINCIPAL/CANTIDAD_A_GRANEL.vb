Public Class CANTIDAD_A_GRANEL

    Private Sub CANTIDAD_A_GRANEL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcantidad.Text = 1
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
    Private Sub txtpantalla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
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

    Private Sub txtpantalla_RightToLeftChanged(sender As Object, e As EventArgs) Handles txtcantidad.RightToLeftChanged

    End Sub

    Private Sub txtpantalla_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged
        Try
            txtprecio_actual.Text = txtprecio_unitario.Text * 1 * txtcantidad.Text * 1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtprecio_actual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio_actual.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar = _
                Threading.Thread.CurrentThread. _
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtprecio_actual, e)
    End Sub

    Private Sub txtprecio_actual_TextChanged(sender As Object, e As EventArgs) Handles txtprecio_actual.TextChanged
        Try
            txtcantidad.Text = (txtprecio_actual.Text * 1) / (txtprecio_unitario.Text * 1)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        If lblstock.Text * 1 >= txtcantidad.Text * 1 Then

            VENTAS_MENU_PRINCIPAL.TimerAGRANEL.Start()
            
            Close()
        Else
            MessageBox.Show("Hay " & lblstock.Text & " En STOCK", "Stock Agotado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            VENTAS_MENU_PRINCIPAL.DATALISTADO_PRODUCTOS_OKA.Visible = False
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        VENTAS_MENU_PRINCIPAL.DATALISTADO_PRODUCTOS_OKA.Visible = False


        Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
        Close()

    End Sub
End Class