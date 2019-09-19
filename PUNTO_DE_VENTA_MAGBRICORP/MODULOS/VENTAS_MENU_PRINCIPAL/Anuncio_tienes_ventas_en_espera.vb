Imports System.Data.SqlClient
Public Class Anuncio_tienes_ventas_en_espera
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblanuncio.Click, Label2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MASCARA1.Close()
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cmd As SqlCommand

            abrir()
            cmd = New SqlCommand("eliminar_venta_en_espera_todas", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_caja", VENTAS_MENU_PRINCIPAL.lblidcaja.Text)
            cmd.ExecuteNonQuery()
            Cerrar()

        Catch ex As Exception

        End Try
        VENTAS_MENU_PRINCIPAL.TimerNotificaciones.Start()
        MASCARA1.Dispose()
        Close()

    End Sub

    Private Sub Anuncio_tienes_ventas_en_espera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblanuncio.Text = "Tienes (" & VENTAS_MENU_PRINCIPAL.LBLcontadorESPERA.Text & ") Ventas en Espera"
    End Sub
End Class