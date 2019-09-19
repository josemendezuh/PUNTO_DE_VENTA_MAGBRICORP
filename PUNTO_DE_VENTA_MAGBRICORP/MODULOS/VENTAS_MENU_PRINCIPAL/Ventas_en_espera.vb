
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Ventas_en_espera

    Sub mostrar_productos_agregados_a_venta_en_espera()

        Dim dtMA As New DataTable
        Dim daMA As SqlDataAdapter
        Try

            abrir()
            daMA = New SqlDataAdapter("mostrar_productos_agregados_a_venta_en_espera", conexion)
            daMA.SelectCommand.CommandType = 4
            daMA.SelectCommand.Parameters.AddWithValue("@idventa", id_venta)
            daMA.Fill(dtMA)
            datalistadodetalledeventasarestaurar.DataSource = dtMA

            datalistadodetalledeventasarestaurar.Columns(1).Width = 350
            datalistadodetalledeventasarestaurar.Columns(2).Width = 68
            datalistadodetalledeventasarestaurar.Columns(3).Width = 70
            datalistadodetalledeventasarestaurar.Columns(4).Width = 75


            Cerrar()

        Catch ex As Exception
            '
        End Try
    End Sub
    Private Sub Ventas_en_espera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_ventas_en_espera_con_fecha_y_monto()
        contar_ventas_en_espera()
    End Sub
    Sub mostrar_ventas_en_espera_con_fecha_y_monto()
        Try
            Dim dt As New DataTable
            Dim da As SqlDataAdapter
            Try
                abrir()
                da = New SqlDataAdapter("mostrar_ventas_en_espera_con_fecha_y_monto", conexion)
                da.Fill(dt)
                datalistado_ventas_en_espera.DataSource = dt
                datalistado_ventas_en_espera.Columns(1).Visible = False
                datalistado_ventas_en_espera.Columns(3).Width = 80

                datalistado_ventas_en_espera.Columns(2).Width = datalistado_ventas_en_espera.Size.Width - 80
                Cerrar()

            Catch ex As Exception


            End Try


        Catch ex As Exception

        End Try

    End Sub
    Sub contar_ventas_en_espera()
        Dim importe As Double
        Dim com As New SqlCommand("mostrar_ventas_en_espera", conexion)

        Try
            abrir()
            importe = (com.ExecuteScalar()) 'asignamos el valor del importe
            Cerrar()
        Catch ex As Exception
        End Try
        VENTAS_MENU_PRINCIPAL.LBLcontadorESPERA.Text = importe  ' mostramos el importe
        Label60.Text = "Ventas en Espera (" & VENTAS_MENU_PRINCIPAL.LBLcontadorESPERA.Text & ")"

    End Sub
    Dim id_venta As Integer
    Private Sub datalistado_ventas_en_espera_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado_ventas_en_espera.CellClick
        Try
            id_venta = datalistado_ventas_en_espera.SelectedCells.Item(1).Value
        Catch ex As Exception
            id_venta = 0
        End Try
        mostrar_productos_agregados_a_venta_en_espera()
        Try
            lblfechadeventa.Text = datalistado_ventas_en_espera.SelectedCells.Item(3).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub datalistado_ventas_en_espera_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado_ventas_en_espera.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

        Close()

    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem18.Click
        Try
            Dim cmd As SqlCommand

            abrir()
            cmd = New SqlCommand("eliminar_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", datalistado_ventas_en_espera.SelectedCells.Item(1).Value)
            cmd.ExecuteNonQuery()
            Cerrar()

        Catch ex As Exception

        End Try

        id_venta = 0

        mostrar_ventas_en_espera_con_fecha_y_monto()
        mostrar_productos_agregados_a_venta_en_espera()
        contar_ventas_en_espera()



    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        VENTAS_MENU_PRINCIPAL.TimerRESTAURAR_VENTA.Start()

        Close()

    End Sub

    Private Sub Ventas_en_espera_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        VENTAS_MENU_PRINCIPAL.TimerNotificaciones.Start()
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        Close()
    End Sub
End Class