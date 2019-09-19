Imports System.Data.SqlClient
Public Class FORM_PRODUCTOS_VENCIDOS
    Private Sub FORM_PRODUCTOS_VENCIDOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar_productos_vencidos()
    End Sub
    Dim rptFREPORT4 As New Report_productos_vencidos()
    Sub buscar_productos_vencidos()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("REPORTE_productos_vencidos", conexion)

            da.Fill(dt)
            Cerrar()
            rptFREPORT4 = New Report_productos_vencidos
            rptFREPORT4.DataSource = dt
            rptFREPORT4.Table2.DataSource = dt

            ReportViewer1.Report = rptFREPORT4
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            '
        End Try
    End Sub
End Class