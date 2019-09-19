Public Class F_MOVIMIENTOS_KARDEX

    Private Sub F_MOVIMIENTOS_KARDEX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: esta línea de código carga datos en la tabla 'BASEMACKEYSDataSet.MOSTRAR_MOVIMIENTOS_DE_KARDEX' Puede moverla o quitarla según sea necesario.
        ''TODO: esta línea de código carga datos en la tabla 'BASEMACKEYSDataSet.mostrar_Empresa' Puede moverla o quitarla según sea necesario.
        'Me.mostrar_EmpresaTableAdapter.Fill(Me.BASEMACKEYSDataSet.mostrar_Empresa)
        ''TODO: esta línea de código carga datos en la tabla 'BASEMACKEYSDataSet.MOSTRAR_MOVIMIENTOS_DE_KARDEX' Puede moverla o quitarla según sea necesario.
        'Me.MOSTRAR_MOVIMIENTOS_DE_KARDEXTableAdapter.Fill(Me.BASEMACKEYSDataSet.MOSTRAR_MOVIMIENTOS_DE_KARDEX, letra:=txtbuscar.Text)

        'Me.ReportViewer1.RefreshReport()
    End Sub

   

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        mascara1.dispose()
        Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Try
            'Me.mostrar_EmpresaTableAdapter.Fill(Me.BASEMACKEYSDataSet.mostrar_Empresa)
            ''TODO: esta línea de código carga datos en la tabla 'BASEMACKEYSDataSet.MOSTRAR_MOVIMIENTOS_DE_KARDEX' Puede moverla o quitarla según sea necesario.
            'Me.MOSTRAR_MOVIMIENTOS_DE_KARDEXTableAdapter.Fill(Me.BASEMACKEYSDataSet.MOSTRAR_MOVIMIENTOS_DE_KARDEX, letra:=txtbuscar.Text)

            'Me.ReportViewer1.RefreshReport()
        Catch ex As Exception

        End Try
    End Sub
End Class