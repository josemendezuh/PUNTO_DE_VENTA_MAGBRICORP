Imports System.Data.SqlClient
Public Class REPORTE_FORM_PRUEBA

    Private Sub REPORTE_FORM_PRUEBA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_productos_todos()
    End Sub
    Sub mostrar_productos_todos()
        Dim rptFREPORT2 As New REPORT_PRUEBA()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_todos_los_productos", conexion)
            da.Fill(dt)
            Cerrar()
            rptFREPORT2 = New REPORT_PRUEBA
            rptFREPORT2.DataSource = dt
            ReportViewer1.Report = rptFREPORT2
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            '
        End Try
    End Sub
End Class