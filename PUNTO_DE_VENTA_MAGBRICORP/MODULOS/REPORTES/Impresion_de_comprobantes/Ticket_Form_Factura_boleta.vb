Imports System.Data.SqlClient



Public Class Ticket_Form_Factura_boleta



    Private Sub Ticket_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Sub mostrar_detalle_de_venta_desde_el_medio_De_pago()
        Dim rptFREPORT2 As New Ticket_report()
        Dim dtMA As New DataTable
        Dim daMA As SqlDataAdapter
        Try
            abrir()
            daMA = New SqlDataAdapter("mostrar_ticket_impreso", conexion)
            daMA.SelectCommand.CommandType = 4
            daMA.SelectCommand.Parameters.AddWithValue("@idventa", MEDIOS_DE_PAGO.LBLidVenta.Text)
            daMA.SelectCommand.Parameters.AddWithValue("@total_en_letras", MEDIOS_DE_PAGO.txtnumeroconvertidoenletra.Text)

            daMA.Fill(dtMA)
            Cerrar()
            rptFREPORT2 = New Ticket_report
            rptFREPORT2.Table1.DataSource = dtMA
            rptFREPORT2.DataSource = dtMA

            ReportViewer1.Report = rptFREPORT2
            ReportViewer1.RefreshReport()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub reemprimir_comprobante()
        Dim rptFREPORT2 As New Ticket_report()
        Dim dtMA As New DataTable
        Dim daMA As SqlDataAdapter
        Try
            abrir()
            daMA = New SqlDataAdapter("mostrar_ticket_impreso", conexion)
            daMA.SelectCommand.CommandType = 4
            daMA.SelectCommand.Parameters.AddWithValue("@idventa", HISTORIAL_DE_VENTAS.lblidventa.Text)
            daMA.SelectCommand.Parameters.AddWithValue("@total_en_letras", HISTORIAL_DE_VENTAS.txtnumeroconvertidoenletra.Text)

            daMA.Fill(dtMA)
            Cerrar()
            rptFREPORT2 = New Ticket_report
            rptFREPORT2.Table1.DataSource = dtMA
            rptFREPORT2.DataSource = dtMA

            ReportViewer1.Report = rptFREPORT2
            ReportViewer1.RefreshReport()



        Catch ex As Exception
            '
        End Try
    End Sub





    Private Sub Ticket_form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        ReportViewer1.Refresh()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mostrar_detalle_de_venta_desde_el_medio_De_pago()
        Timer1.Stop()
        MessageBox.Show("VENTA REALIZADA CORRECTAMENTE", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        reemprimir_comprobante()
        Timer2.Stop()

    End Sub
End Class