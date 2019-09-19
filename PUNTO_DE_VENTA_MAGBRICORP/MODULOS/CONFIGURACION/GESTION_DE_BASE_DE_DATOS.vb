
Imports System.Data
Imports System.Data.SqlClient

Public Class GESTION_DE_BASE_DE_DATOS
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmd As New SqlCommand

        Try
            If ventas.Checked = True Then lblventas.Text = 1
            If productos.Checked = True Then lblproductos.Text = 1
            If clientes.Checked = True Then lblclientes.Text = 1
            If Gastos.Checked = True Then lblgastos.Text = 1
            If cierresCaja.Checked = True Then lblcierrecaja.Text = 1
            abrir()
            cmd = New SqlCommand("Limpiar_base_De_datos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@ventas", lblventas.Text)
            cmd.Parameters.AddWithValue("@productos", lblproductos.Text)
            cmd.Parameters.AddWithValue("@clientes", lblclientes.Text)
            cmd.Parameters.AddWithValue("@gastos", lblgastos.Text)
            cmd.Parameters.AddWithValue("@movimientos_de_caja", lblcierrecaja.Text)

            cmd.ExecuteNonQuery()

            Cerrar()
            MessageBox.Show("Base de Datos Limpiada", "Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End

        Catch ex As Exception : MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub GESTION_DE_BASE_DE_DATOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ventas.Checked = True Then lblventas.Text = 0
        If productos.Checked = True Then lblproductos.Text = 0
        If clientes.Checked = True Then lblclientes.Text = 0
        If Gastos.Checked = True Then lblgastos.Text = 0
        If cierresCaja.Checked = True Then lblcierrecaja.Text = 0
        ventas.Checked = True
        productos.Checked = True
        clientes.Checked = True
        Gastos.Checked = True
        cierresCaja.Checked = True

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        Close()

    End Sub
End Class