
Imports System.Data.SqlClient
Imports System.Linq

Public Class DASBOARD_DEMO
    Sub Listar_ventas_realizadas()
        Dim fecha As ArrayList = New ArrayList
        Dim monto As ArrayList = New ArrayList
        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("mostrar_ventas_realizadas", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            dr = cmd.ExecuteReader()
            While (dr.Read())
                fecha.Add(dr.GetString(0))
                monto.Add(dr.GetString(1))

            End While
            Chart1.Series(0).Points.DataBindXY(fecha, monto)
            dr.Close()
            Cerrar()

            Dim importe As Double
            Dim com As New SqlCommand
            com = New SqlCommand("select convert(numeric(18,1),sum(Monto_total)) From Ventas")
            Try
                abrir()
                importe = (com.ExecuteScalar())
                Cerrar()
            Catch ex As Exception
            End Try
            txtventas.Text = importe



            Dim importe2 As Double
            Dim com2 As New SqlCommand
            com2 = New SqlCommand("select convert(numeric(18,1),sum(Ganancia)) From detalle_venta")
            Try
                abrir()
                importe2 = (com2.ExecuteScalar())
                Cerrar()
            Catch ex As Exception
            End Try
            lblgananciasok.Text = importe2


        Catch ex As Exception

        End Try

    End Sub
    Private Sub DASBOARD_DEMO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_ventas_realizadas()

    End Sub
    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
    Private Sub lblgananciasok_Click(sender As Object, e As EventArgs) Handles lblgananciasok.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Listar_ventas_realizadas()
    End Sub
End Class