

Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS
    Private m_hOriginalParent As Integer
    Private Const GWL_HWNDPARENT As Integer = -8
    Private Declare Function GetClassLong Lib "user32" Alias "GetClassLongA" (lngHandler As IntPtr, lngIndex As Integer) As Integer
    Private Declare Function GetDesktopWindow Lib "user32" () As Integer
    Private Declare Function SetClassLong Lib "user32" Alias "SetClassLongA" (lngHandler As IntPtr, lngIndex As Integer, lngNewClassLong As Integer) As Integer
    Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (hWnd As IntPtr, nIndex As Integer, dwNewLong As Integer) As Integer
    Public Sub New()

        InitializeComponent()

        Me.SuspendLayout()
        'Me.FormBorderStyle = FormBorderStyle.None
        Const CS_DROPSHADOW As Integer = &H20000

        m_hOriginalParent = SetWindowLong(Me.Handle, GWL_HWNDPARENT, GetDesktopWindow())
        SetClassLong(Me.Handle, -26, GetClassLong(Me.Handle, -26) Or CS_DROPSHADOW)
        Me.ResumeLayout(False)
    End Sub


    Private Sub txtbuscar_Click(sender As Object, e As EventArgs) Handles txtbuscar.Click
        DATALISTADO_PRODUCTOS_OKA.Visible = True
        txtbuscar.Text = ""
        txtbuscar.Focus()
        LISTAR_PRODUCTOS_Abuscador()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged

        lbltipodebusqueda2.Text = "Buscar"
        If txtbuscar.Text = "" Then
            DATALISTADO_PRODUCTOS_OKA.Visible = False
            lbltipodebusqueda2.Visible = True
        End If
        If txtbuscar.Text <> "" Then
            DATALISTADO_PRODUCTOS_OKA.Visible = True
            lbltipodebusqueda2.Visible = False
        End If

        LISTAR_PRODUCTOS_Abuscador()



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
            DATALISTADO_PRODUCTOS_OKA.Columns(17).Width = 420
            DATALISTADO_PRODUCTOS_OKA.Columns(2).Visible = False


        Catch ex As Exception
        End Try
        Cerrar()
        'sumar_total_despachado()
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
    Private Sub AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LISTAR_PRODUCTOS_Abuscador()
        lbltipodebusqueda2.Visible = True
        txtbuscar.Text = ""
        txtcantidad.Text = ""
    End Sub

    Private Sub DATALISTADO_PRODUCTOS_OKA_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_PRODUCTOS_OKA.CellClick
        Try
            txtbuscar.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(2).Value
            txtprecio_unitario.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(9).Value
            txtidproducto.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(1).Value

            DATALISTADO_PRODUCTOS_OKA.Visible = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DATALISTADO_PRODUCTOS_OKA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_PRODUCTOS_OKA.CellContentClick

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If txtcantidad.Text = "" Then txtcantidad.Text = 0
        If txtcantidad.Text > 0 Then
            If txtbuscar.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(2).Value Then
                VENTAS_MENU_PRINCIPAL.TXTSEVENDEPOR.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(11).Value
                VENTAS_MENU_PRINCIPAL.txtidproducto.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(1).Value
                mostrar_stock_de_detalle_de_ventas()
                contar_stock_detalle_ventas()
                If lblcontador_stock_detalle_de_venta.Text = 0 Then
                    VENTAS_MENU_PRINCIPAL.lblStock_de_Productos.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(6).Value
                Else
                    VENTAS_MENU_PRINCIPAL.lblStock_de_Productos.Text = datalistado_stock_detalle_venta.SelectedCells.Item(1).Value
                End If
                VENTAS_MENU_PRINCIPAL.lblUsaInventarios.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(5).Value
                VENTAS_MENU_PRINCIPAL.lbldescripcion.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(17).Value
                VENTAS_MENU_PRINCIPAL.lblcodigo.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(10).Value
                VENTAS_MENU_PRINCIPAL.lblcosto.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(7).Value
                VENTAS_MENU_PRINCIPAL.txtprecio_unitario.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(9).Value
                VENTAS_MENU_PRINCIPAL.txtpantalla.Text = txtcantidad.Text
                VENTAS_MENU_PRINCIPAL.TimerVARIASCANTIDADES.Start()

                Close()
            End If
        Else
            MessageBox.Show("Inserte una cantidad", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

        Close()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click

        Close()
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged

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

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtcantidad.Text = txtcantidad.Text & "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtcantidad.Text = txtcantidad.Text & "1"

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtcantidad.Text = txtcantidad.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtcantidad.Text = txtcantidad.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtcantidad.Text = txtcantidad.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtcantidad.Text = txtcantidad.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtcantidad.Text = txtcantidad.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtcantidad.Text = txtcantidad.Text & "7"


    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtcantidad.Text = txtcantidad.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtcantidad.Text = txtcantidad.Text & "9"
    End Sub

    Dim SECUENCIA As Boolean = True
    Private Sub btnborrarderecha_Click(sender As Object, e As EventArgs) Handles btnborrarderecha.Click

        If SECUENCIA = True Then
            txtcantidad.Text = txtcantidad.Text & "."
            SECUENCIA = False
        Else
            Return

        End If

    End Sub

    Private Sub btnborrartodo_Click(sender As Object, e As EventArgs) Handles btnborrartodo.Click

        txtcantidad.Clear()
        SECUENCIA = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("osk.exe")
    End Sub

    Private Sub AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            If txtcantidad.Text = "" Then txtcantidad.Text = 0
            If txtcantidad.Text > 0 Then
                If txtbuscar.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(2).Value Then
                    VENTAS_MENU_PRINCIPAL.TXTSEVENDEPOR.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(11).Value
                    VENTAS_MENU_PRINCIPAL.txtidproducto.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(1).Value
                    mostrar_stock_de_detalle_de_ventas()
                    contar_stock_detalle_ventas()
                    If lblcontador_stock_detalle_de_venta.Text = 0 Then
                        VENTAS_MENU_PRINCIPAL.lblStock_de_Productos.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(6).Value
                    Else
                        VENTAS_MENU_PRINCIPAL.lblStock_de_Productos.Text = datalistado_stock_detalle_venta.SelectedCells.Item(1).Value
                    End If
                    VENTAS_MENU_PRINCIPAL.lblUsaInventarios.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(5).Value
                    VENTAS_MENU_PRINCIPAL.lbldescripcion.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(17).Value
                    VENTAS_MENU_PRINCIPAL.lblcodigo.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(10).Value
                    VENTAS_MENU_PRINCIPAL.lblcosto.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(7).Value
                    VENTAS_MENU_PRINCIPAL.txtprecio_unitario.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(9).Value
                    VENTAS_MENU_PRINCIPAL.txtpantalla.Text = txtcantidad.Text
                    VENTAS_MENU_PRINCIPAL.TimerVARIASCANTIDADES.Start()

                    Close()
                End If
            Else
                MessageBox.Show("Inserte una cantidad", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End If
    End Sub
End Class