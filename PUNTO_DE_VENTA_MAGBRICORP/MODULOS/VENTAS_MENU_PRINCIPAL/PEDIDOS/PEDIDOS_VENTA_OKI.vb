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

Public Class PEDIDOS_VENTA_OKI
    Dim DT_USUARIO As New DataTable
   
    Sub mostrar_productos_agregados_A_PEDIDO_DE_VENTA()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_productos_agregados_A_PEDIDO_DE_VENTA", conexion)

            da.SelectCommand.CommandType = 4
            da.Fill(dt)
            DATALISTADO_PEDIDOS_VENTAS.DataSource = dt
            'DATALISTADO_PEDIDOS_VENTAS.Columns(1).Visible = False
            'datalistado.Columns(9).Visible = False
            'datalistado.Columns(10).Visible = False
            DATALISTADO_PEDIDOS_VENTAS.Columns(2).Width = 120
            DATALISTADO_PEDIDOS_VENTAS.Columns(3).Width = 284


        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()

    End Sub
    Sub buscar_productos_agregados_A_PEDIDO_DE_VENTA()
        'Dim dt As New DataTable
        'Dim da As SqlDataAdapter
        'Try
        '    abrir()
        '    da = New SqlDataAdapter("buscar_productos_agregados_A_PEDIDO_DE_VENTA", conexion)
        '    da.SelectCommand.Parameters.AddWithValue("@letra", txtclientesolicitante.Text)
        '    da.SelectCommand.Parameters.AddWithValue("@idcliente", datalistadoclientes.SelectedCells.Item(2).Value)
        '    da.SelectCommand.CommandType = 4
        '    da.Fill(dt)
        '    DATALISTADO_PEDIDOS_VENTAS.DataSource = dt
        '    'DATALISTADO_PEDIDOS_VENTAS.Columns(1).Visible = False
        '    'datalistado.Columns(9).Visible = False
        '    'datalistado.Columns(10).Visible = False
        '    DATALISTADO_PEDIDOS_VENTAS.Columns(2).Width = 120
        '    DATALISTADO_PEDIDOS_VENTAS.Columns(3).Width = 284


        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'Cerrar()

    End Sub
    Sub buscar_pedido_de_venta()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_pedido_de_venta", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtclientesolicitante.Text)
            da.Fill(dt)
            DATALISTADO_PEDIDOS_VENTAS.DataSource = dt
            DATALISTADO_PEDIDOS_VENTAS.Columns(0).Width = 50
            DATALISTADO_PEDIDOS_VENTAS.Columns(2).Width = 169
            DATALISTADO_PEDIDOS_VENTAS.Columns(5).Width = 180
            DATALISTADO_PEDIDOS_VENTAS.Columns(6).Width = 120
            DATALISTADO_PEDIDOS_VENTAS.Columns(3).Width = 180
            DATALISTADO_PEDIDOS_VENTAS.Columns(8).Visible = False
            DATALISTADO_PEDIDOS_VENTAS.Columns(9).Visible = False
            DATALISTADO_PEDIDOS_VENTAS.Columns(10).Visible = False
            DATALISTADO_PEDIDOS_VENTAS.Columns(11).Visible = False

        Catch ex As Exception
        End Try
        Cerrar()

    End Sub
    Private Sub PEDIDOS_VENTA_COMPRA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar_pedido_de_venta()
        'mostrar_productos_agregados_A_PEDIDO_DE_VENTA()

    End Sub

    Private Sub txtclientesolicitante_Click(sender As Object, e As EventArgs) Handles txtclientesolicitante.Click
        'txtclientesolicitante.Text = ""
        'datalistadoclientes.Visible = True
        'txtclientesolicitante.Focus()

    End Sub

    Private Sub txtclientesolicitante_TextChanged(sender As Object, e As EventArgs) Handles txtclientesolicitante.TextChanged
        buscar_pedido_de_venta()


    End Sub

    Private Sub datalistadoclientes_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        'buscar_productos_agregados_A_PEDIDO_DE_VENTA()

        'txtclientesolicitante.Text = datalistadoclientes.SelectedCells.Item(1).Value

        'datalistadoclientes.Visible = False
    End Sub
    Private Sub ToolStripMenuItem4_Click_1(sender As Object, e As EventArgs)




    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        mascara1.dispose()
        Close()
    End Sub
    Private Sub DATALISTADO_PEDIDOS_VENTAS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_PEDIDOS_VENTAS.CellContentClick
        Try
            If e.ColumnIndex = Me.DATALISTADO_PEDIDOS_VENTAS.Columns.Item("Marcar").Index Then
                Dim chkcell As DataGridViewCheckBoxCell = Me.DATALISTADO_PEDIDOS_VENTAS.Rows(e.RowIndex).Cells("Marcar")
                chkcell.Value = Not chkcell.Value
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub INSERTAR_KARDEX_ELIMINACION()
        'Dim cmdKARDEXELIM As SqlCommand
        'Try
        '    For Each row As DataGridViewRow In datalistado_RECHAZO.Rows
        '        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
        '        If marcado Then
        '            Dim idlote As Integer = Convert.ToInt32(row.Cells("Id_presentacionfraccionada").Value)
        '            Dim cantidad As Decimal = Convert.ToDouble(row.Cells("Cant").Value)
        '            Try
        '                abrir()
        '                cmdKARDEXELIM = New SqlCommand("insertar_KARDEX_SALIDA", conexion)
        '                cmdKARDEXELIM.CommandType = 4
        '                cmdKARDEXELIM.Parameters.AddWithValue("@Motivo", "ELIMINACION DE RECHAZOS")
        '                cmdKARDEXELIM.Parameters.AddWithValue("@Cantidad ", cantidad)
        '                cmdKARDEXELIM.Parameters.AddWithValue("@Fecha", TXTFECHA_DE_KADEX.Value)
        '                cmdKARDEXELIM.Parameters.AddWithValue("@Id_presentacion_fraccionada", idlote)
        '                cmdKARDEXELIM.Parameters.AddWithValue("@Id_usuario", TXTIDUSUARIO.Text)
        '                cmdKARDEXELIM.Parameters.AddWithValue("@Tipo", "SALIDA")
        '                cmdKARDEXELIM.Parameters.AddWithValue("@Estado", "CONFIRMADO")

        '                cmdKARDEXELIM.ExecuteNonQuery()
        '            Catch ex As Exception : MsgBox(ex.Message)

        '            End Try
        '            Cerrar()
        '        End If

        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        ''Dim cmdaumentarstock As SqlCommand

        ''Try
        ''    For Each row As DataGridViewRow In DATALISTADO_AGREGANDO.Rows
        ''        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Marcar").Value)

        ''        If marcado Then

        ''            Dim idlote As Integer = Convert.ToInt32(row.Cells("Id_presentacionfraccionada").Value)
        ''            Dim cantidad As Decimal = Convert.ToDouble(row.Cells("Cant").Value)

        ''            Try
        ''                abrir()
        ''                cmdaumentarstock = New SqlCommand("insertar_KARDEX_SALIDA", conexion)
        ''                cmdaumentarstock.CommandType = 4

        ''                cmdaumentarstock.Parameters.AddWithValue("@Id_presentacionfraccionada", idlote)
        ''                cmdaumentarstock.Parameters.AddWithValue("@cantidad", cantidad)

        ''                cmdaumentarstock.ExecuteNonQuery()
        ''            Catch ex As Exception : MsgBox(ex.Message)

        ''            End Try
        ''            Cerrar()
        '        End If

        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Sub DISMINUIR_STOCK()
        Dim cmdaumentarstock As SqlCommand

        Try
            For Each row As DataGridViewRow In DATALISTADO_PEDIDOS_VENTAS.Rows
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub INSERTAR_KARDEX_SALIDA()
        Dim cmdKARDEXELIM As SqlCommand
        Try
            For Each row As DataGridViewRow In DATALISTADO_PEDIDOS_VENTAS.Rows
                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Marcar").Value)
                If marcado Then
                    Dim idlote As Integer = Convert.ToInt32(row.Cells("Id_presentacionfraccionada").Value)
                    Dim cantidad As Decimal = Convert.ToDouble(row.Cells("cantidad").Value)
                    Dim total As Decimal = Convert.ToDouble(row.Cells("Total_a_pagar").Value)

                    Try
                        abrir()
                        cmdKARDEXELIM = New SqlCommand("insertar_KARDEX_SALIDA", conexion)
                        cmdKARDEXELIM.CommandType = 4
                        cmdKARDEXELIM.Parameters.AddWithValue("@Motivo", "DESPACHO DE PEDIDOS...")
                        cmdKARDEXELIM.Parameters.AddWithValue("@Cantidad ", cantidad)
                        cmdKARDEXELIM.Parameters.AddWithValue("@Fecha", TXTFECHA_DE_KADEX.Value)
                        cmdKARDEXELIM.Parameters.AddWithValue("@Id_presentacion_fraccionada", idlote)
                        cmdKARDEXELIM.Parameters.AddWithValue("@Id_usuario", LOGIN.IDUSUARIO.Text)
                        cmdKARDEXELIM.Parameters.AddWithValue("@Tipo", "SALIDA")
                        cmdKARDEXELIM.Parameters.AddWithValue("@Estado", "CONFIRMADO")
                        cmdKARDEXELIM.Parameters.AddWithValue("@Total", total)

                        cmdKARDEXELIM.ExecuteNonQuery()


                    Catch ex As Exception : MsgBox(ex.Message)

                    End Try
                    Cerrar()
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)



        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("¿Realmente desea DESPACHAR LOS PRODUCTOS SELECCIONADOS?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DATALISTADO_PEDIDOS_VENTAS.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Marcar").Value)

                    If marcado Then


                        Dim onekey As Integer = Convert.ToInt32(row.Cells("iddetalle_venta").Value)
                        Dim Stock As Double = Convert.ToDouble(row.Cells("Stock").Value)
                        Dim cantidad As Double = Convert.ToDouble(row.Cells("cantidad").Value)
                        Dim servicio As String = Convert.ToString(row.Cells("Servicio").Value)
                        If servicio = "NO" Then
                            Try
                                If Stock >= cantidad Then
                                    INSERTAR_KARDEX_SALIDA()
                                    DISMINUIR_STOCK()
                                    abrir()
                                    cmd = New SqlCommand("actualizar_estado_de_DETALLE_despachado", conexion)
                                    cmd.CommandType = 4
                                    cmd.Parameters.AddWithValue("@iddetalleventa", onekey)

                                    cmd.ExecuteNonQuery()
                                    Cerrar()
                                ElseIf Stock < cantidad Then
                                    MsgBox("Hay productos SIN STOCK")
                                End If


                            Catch ex As Exception : MsgBox(ex.Message)

                            End Try
                        End If
                        If servicio = "SI" Then
                            INSERTAR_KARDEX_SALIDA()
                            abrir()
                            cmd = New SqlCommand("actualizar_estado_de_DETALLE_despachado", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@iddetalleventa", onekey)

                            cmd.ExecuteNonQuery()
                            Cerrar()

                        End If


                    End If

                Next
                Call buscar_pedido_de_venta()





            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub

    Private Sub EliminarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DATALISTADO_PEDIDOS_VENTAS.Rows
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
                Call mostrar_productos_agregados_A_PEDIDO_DE_VENTA()





            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        VENTAS_MENU_PRINCIPAL.TXTACCION.Text = "PEDIDO DE VENTA"
        VENTAS_MENU_PRINCIPAL.txtmenuinterno.Text = "INTERNO"
        

        VENTAS_MENU_PRINCIPAL.ShowDialog()
        VENTAS_MENU_PRINCIPAL.txtmenuinterno.Text = "INTERNO"
        VENTAS_MENU_PRINCIPAL.TXTACCION.Text = "PEDIDO DE VENTA"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click


        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("¿Realmente desea DESPACHAR LOS PRODUCTOS SELECCIONADOS?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DATALISTADO_PEDIDOS_VENTAS.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Marcar").Value)

                    If marcado Then


                        Dim onekey As Integer = Convert.ToInt32(row.Cells("iddetalle_venta").Value)
                        Dim Stock As Double = Convert.ToDouble(row.Cells("Stock").Value)
                        Dim cantidad As Double = Convert.ToDouble(row.Cells("cantidad").Value)
                        Dim servicio As String = Convert.ToString(row.Cells("Servicio").Value)
                        If servicio = "NO" Then
                            Try
                                If Stock >= cantidad Then
                                    INSERTAR_KARDEX_SALIDA()
                                    DISMINUIR_STOCK()
                                    abrir()
                                    cmd = New SqlCommand("actualizar_estado_de_DETALLE_despachado", conexion)
                                    cmd.CommandType = 4
                                    cmd.Parameters.AddWithValue("@iddetalleventa", onekey)

                                    cmd.ExecuteNonQuery()
                                    Cerrar()
                                ElseIf Stock < cantidad Then
                                    MsgBox("Hay productos SIN STOCK")
                                End If


                            Catch ex As Exception : MsgBox(ex.Message)

                            End Try
                        End If
                        If servicio = "SI" Then
                            INSERTAR_KARDEX_SALIDA()
                            abrir()
                            cmd = New SqlCommand("actualizar_estado_de_DETALLE_despachado", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@iddetalleventa", onekey)

                            cmd.ExecuteNonQuery()
                            Cerrar()

                        End If


                    End If

                Next
                Call buscar_pedido_de_venta()





            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
End Class