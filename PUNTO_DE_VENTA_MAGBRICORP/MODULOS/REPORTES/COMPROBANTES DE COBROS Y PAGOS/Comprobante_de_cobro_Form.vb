Imports System.Data.SqlClient
Public Class Comprobante_de_cobro_Form
    Private Sub Comprobante_de_cobro_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_detalle_de_venta_desde_el_medio_De_pago()
    End Sub
    Sub mostrar_detalle_de_venta_desde_el_medio_De_pago()
        Dim rptFREPORT2 As New Comproante_de_cobro()
        Dim dtMA As New DataTable
        Dim daMA As SqlDataAdapter
        Try
            abrir()
            daMA = New SqlDataAdapter("mostrar_detalle_de_cobro_para_Imprimir", conexion)
            daMA.SelectCommand.CommandType = 4
            daMA.SelectCommand.Parameters.AddWithValue("@Id_detalle_de_control_de_cobros", 3)
            daMA.SelectCommand.Parameters.AddWithValue("@pagado_en_letras", "hl")

            daMA.Fill(dtMA)
            Cerrar()
            rptFREPORT2 = New Comproante_de_cobro
            'rptFREPORT2.Table1.DataSource = dtMA
            rptFREPORT2.DataSource = dtMA

            ReportViewer1.Report = rptFREPORT2
            ReportViewer1.RefreshReport()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class