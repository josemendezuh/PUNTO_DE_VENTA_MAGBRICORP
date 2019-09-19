
Imports System.Data.SqlClient
Public Class FormInventariosTodos
    Private Sub FormInventariosTodos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_inventarios_todos()
    End Sub
    Dim rptFREPORT2 As New ReportInventarios_Todos()
    Sub mostrar_inventarios_todos()

        Dim dtMA As New DataTable
        Dim daMA As SqlDataAdapter
        Try
            abrir()
            daMA = New SqlDataAdapter("imprimir_inventarios_todos", conexion)

            daMA.Fill(dtMA)
            Cerrar()
            rptFREPORT2 = New ReportInventarios_Todos
            rptFREPORT2.DataSource = dtMA

            ReportViewer1.Report = rptFREPORT2
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            '
        End Try
    End Sub
End Class