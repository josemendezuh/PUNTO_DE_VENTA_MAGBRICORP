Imports System.Data.SqlClient
Public Class CAMBIAR_PRECIOS_MANUALMENTE
    Private Sub CAMBIAR_PRECIOS_MANUALMENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtprecio.Text = ""


        lblproducto.Text = VENTAS_MENU_PRINCIPAL.lblcantidad.Text
        'lbldescripcion.Text = VENTAS_MENU_PRINCIPAL
    End Sub

    Private Sub MenuStrip3_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip3.ItemClicked

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
    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtprecio, e)
    End Sub
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtprecio.Text = txtprecio.Text & "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtprecio.Text = txtprecio.Text & "1"

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtprecio.Text = txtprecio.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtprecio.Text = txtprecio.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtprecio.Text = txtprecio.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtprecio.Text = txtprecio.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtprecio.Text = txtprecio.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtprecio.Text = txtprecio.Text & "7"


    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtprecio.Text = txtprecio.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtprecio.Text = txtprecio.Text & "9"
    End Sub

    Private Sub btnborrarderecha_Click(sender As Object, e As EventArgs) Handles btnborrarderecha.Click
        Try
            Dim largo As Integer
            If txtprecio.Text <> "" Then
                largo = txtprecio.Text.Length
                txtprecio.Text = Mid(txtprecio.Text, 1, largo - 1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnborrartodo_Click(sender As Object, e As EventArgs) Handles btnborrartodo.Click
        txtprecio.Clear()
    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("editar_precio_unitario_en_detalle_De_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@iddetalle_venta", VENTAS_MENU_PRINCIPAL.datalistadomateriales.SelectedCells.Item(9).Value)
            cmd.Parameters.AddWithValue("@precio", txtprecio.Text)
            cmd.ExecuteNonQuery()
            Cerrar()
            VENTAS_MENU_PRINCIPAL.Timer_MOSTRAR_PRODUCTOS_AGREGADOS.Start()
            Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged

    End Sub

    Private Sub txtprecio_Click(sender As Object, e As EventArgs) Handles txtprecio.Click
        txtprecio.SelectAll()
    End Sub

    Private Sub MenuStrip4_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip4.ItemClicked

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Close()

    End Sub
End Class