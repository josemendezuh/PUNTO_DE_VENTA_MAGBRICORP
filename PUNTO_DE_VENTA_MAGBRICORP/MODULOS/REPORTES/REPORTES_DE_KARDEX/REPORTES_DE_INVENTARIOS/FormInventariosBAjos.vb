Imports System.Data
Imports System.Data.SqlClient
Public Class FormInventariosBAjos
    Private Sub FormInventariosBAjos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_kardex_movimientos()
    End Sub
    Dim rptFREPORT2 As New ReportInventariosBajos()
    Sub mostrar_kardex_movimientos()

        Dim dtMA As New DataTable
        Dim daMA As SqlDataAdapter
        Try
            abrir()
            daMA = New SqlDataAdapter("MOSTRAR_Inventarios_bajo_minimo", conexion)
            daMA.Fill(dtMA)
            Cerrar()
            rptFREPORT2 = New ReportInventariosBajos
            rptFREPORT2.DataSource = dtMA

            ReportViewer1.Report = rptFREPORT2
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            '
        End Try
    End Sub
End Class