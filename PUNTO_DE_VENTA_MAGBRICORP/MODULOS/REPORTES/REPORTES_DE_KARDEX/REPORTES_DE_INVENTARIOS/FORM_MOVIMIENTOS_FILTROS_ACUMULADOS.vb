Imports System.Data.SqlClient

Public Class FORM_MOVIMIENTOS_FILTROS_ACUMULADOS
    Private Sub FORM_MOVIMIENTOS_FILTROS_ACUMULADOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar_MOVIMIENTOS_DE_KARDEX_FILTROS_TABLA_ACUMULADA()
    End Sub
    Dim rptFREPORT4 As New Report_movimientos_filtros_acumulados()

    Sub buscar_MOVIMIENTOS_DE_KARDEX_FILTROS_TABLA_ACUMULADA()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_MOVIMIENTOS_DE_KARDEX_filtros_acumulado", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@fecha", INVENTARIO.txtfechaM.Value)
            da.SelectCommand.Parameters.AddWithValue("@tipo", INVENTARIO.txtTipoMovi.Text)
            da.SelectCommand.Parameters.AddWithValue("@Id_usuario", INVENTARIO.txtIdcaja.Text)

            da.Fill(dt)
            Cerrar()
            rptFREPORT4 = New Report_movimientos_filtros_acumulados
            rptFREPORT4.DataSource = dt
            rptFREPORT4.Table2.DataSource = dt

            ReportViewer1.Report = rptFREPORT4
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            '
        End Try
    End Sub
End Class