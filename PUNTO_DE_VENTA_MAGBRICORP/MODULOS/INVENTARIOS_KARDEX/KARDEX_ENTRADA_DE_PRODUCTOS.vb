Imports System.Data
Imports System.Data.SqlClient


Public Class KARDEX_ENTRADA_DE_PRODUCTOS

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        KARDEX_REGISTRO.TXTTIPO.Text = "ENTRADA"
        MASCARA1.Show()

        KARDEX_REGISTRO.ShowDialog()
        KARDEX_REGISTRO.TXTTIPO.Text = "ENTRADA"
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        

        ELECCION_DE_SALIDA_DE_KARDEX.ShowDialog()

    End Sub
    Sub MOSTRAR_KARDEX_ENTRADA()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("MOSTRAR_KARDEX_ENTRADA", conexion)
            da.Fill(dt)
            DATALISTADO_ENTRADAS.DataSource = dt
            DATALISTADO_ENTRADAS.Columns(0).Width = 50
            DATALISTADO_ENTRADAS.Columns(1).Visible = False
            DATALISTADO_ENTRADAS.Columns(2).Visible = False
            DATALISTADO_ENTRADAS.Columns(6).Visible = False
            DATALISTADO_ENTRADAS.Columns(3).Width = 80
            DATALISTADO_ENTRADAS.Columns(4).Width = 190
            DATALISTADO_ENTRADAS.Columns(5).Width = 105
            DATALISTADO_ENTRADAS.Columns(7).Width = 210
            DATALISTADO_ENTRADAS.Columns(8).Width = 286
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()
    End Sub
    Sub MOSTRAR_KARDEX_SALIDA()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("MOSTRAR_KARDEX_SALIDA", conexion)
            da.Fill(dt)
            DATALISTADO_SALIDAS.DataSource = dt
            DATALISTADO_SALIDAS.Columns(0).Width = 50
            DATALISTADO_SALIDAS.Columns(1).Visible = False
            DATALISTADO_SALIDAS.Columns(2).Visible = False
            DATALISTADO_SALIDAS.Columns(6).Visible = False
            DATALISTADO_SALIDAS.Columns(3).Width = 80
            DATALISTADO_SALIDAS.Columns(4).Width = 190
            DATALISTADO_SALIDAS.Columns(5).Width = 105
            DATALISTADO_SALIDAS.Columns(7).Width = 210
            DATALISTADO_SALIDAS.Columns(8).Width = 286

        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()
    End Sub
    Private Sub KARDEX_ENTRADA_DE_PRODUCTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MOSTRAR_KARDEX_ENTRADA()
        MOSTRAR_KARDEX_SALIDA()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        MOSTRAR_KARDEX_ENTRADA()
        MOSTRAR_KARDEX_SALIDA()

    End Sub
End Class