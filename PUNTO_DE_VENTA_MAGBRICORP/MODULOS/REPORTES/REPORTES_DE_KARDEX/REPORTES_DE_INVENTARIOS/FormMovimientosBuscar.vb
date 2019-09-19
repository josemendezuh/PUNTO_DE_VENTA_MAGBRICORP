
Imports System.Data
Imports System.Data.SqlClient
Public Class FormMovimientosBuscar
    Private Sub FormMovimientosBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar_MOVIMIENTOS_DE_KARDEX()
    End Sub
    Dim rptFREPORT2 As New ReportMovimientosBuscar()
    Sub buscar_MOVIMIENTOS_DE_KARDEX()

        Dim dtMA As New DataTable
        Dim daMA As SqlDataAdapter
        Try
            abrir()
            daMA = New SqlDataAdapter("buscar_MOVIMIENTOS_DE_KARDEX", conexion)
            daMA.SelectCommand.CommandType = 4
            daMA.SelectCommand.Parameters.AddWithValue("@idProducto", INVENTARIO.DATALISTADO_PRODUCTOS_Movimientos.SelectedCells.Item(1).Value)
            daMA.Fill(dtMA)
            Cerrar()
            rptFREPORT2 = New ReportMovimientosBuscar
            rptFREPORT2.DataSource = dtMA



            ReportViewer1.Report = rptFREPORT2
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            '
        End Try
    End Sub
End Class


