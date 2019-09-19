
Imports System.Data.SqlClient

Public Class FormReporteMovimientosFILTROS
    Private Sub FormReporteMovimientosFILTROS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar_MOVIMIENTOS_DE_KARDEX_FILTROS_TABLA_DETALLADA()
    End Sub
    Dim rptFREPORT3 As New Reporte_Movimientos_con_filtros()

    Sub buscar_MOVIMIENTOS_DE_KARDEX_FILTROS_TABLA_DETALLADA()

        Dim dtMA As New DataTable
        Dim daMA As SqlDataAdapter
        Try
            abrir()
            daMA = New SqlDataAdapter("buscar_MOVIMIENTOS_DE_KARDEX_filtros", conexion)
            daMA.SelectCommand.CommandType = 4
            daMA.SelectCommand.Parameters.AddWithValue("@fecha", INVENTARIO.txtfechaM.Value)
            daMA.SelectCommand.Parameters.AddWithValue("@tipo", INVENTARIO.txtTipoMovi.Text)
            daMA.SelectCommand.Parameters.AddWithValue("@Id_usuario", INVENTARIO.txtIdcaja.Text)
            daMA.Fill(dtMA)
            Cerrar()

            rptFREPORT3 = New Reporte_Movimientos_con_filtros
            rptFREPORT3.DataSource = dtMA
            rptFREPORT3.Table1.DataSource = dtMA

            ReportViewer1.Report = rptFREPORT3
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            '
        End Try
    End Sub

End Class