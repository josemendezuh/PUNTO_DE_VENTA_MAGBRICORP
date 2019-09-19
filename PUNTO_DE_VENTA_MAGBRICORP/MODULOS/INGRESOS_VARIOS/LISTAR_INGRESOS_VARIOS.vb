


Imports System.Data
Imports System.Data.SqlClient

Imports System.Globalization
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Data.OleDb

Imports System.IO
Public Class LISTAR_INGRESOS_VARIOS

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub btnagregaryguardar_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtidproyecto_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub btnagregar_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ModificarPrecioToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ToolStripMenuItem21_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ToolStripMenuItem20_Click_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub ToolStripMenuItem10_Click_2(sender As Object, e As EventArgs)

    End Sub
    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtunidad_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub VOLVERToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ToolStripMenuItem11_Click_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub TXTPRECIODEVENTA2_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtcosto_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub btn_insertar_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub No_aplica_fecha_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtcantidad_de_unidad_de_medidaoka_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub ToolStripMenuItem2_Click_2(sender As Object, e As EventArgs)

    End Sub
    Private Sub TXTUNIDAD2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub EliminarPresentaciónAgregadaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ActivarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub InactivarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ToolStripMenuItem19_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtbusca_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub MarcacionManualToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button5_Click_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub ModificarStockToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_ingresos", conexion)
            da.Fill(dt)
            datalistado.DataSource = dt
            'For Each fila As DataGridViewRow In datalistado.Rows
            '    If fila.Cells("Estado").Value = "SIN FORMULACIONES" Then
            '        fila.DefaultCellStyle.BackColor = Color.Pink
            '    Else
            '        fila.DefaultCellStyle.BackColor = Color.White
            '    End If
            'Next


        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()

        datalistado.Columns(2).Visible = False
        datalistado.Columns(1).Width = 140
        datalistado.Columns(3).Width = 110
        datalistado.Columns(4).Width = 140
        datalistado.Columns(5).Width = 90
        datalistado.Columns(6).Width = 200
        datalistado.Columns(0).Width = 50
        datalistado.Columns(9).Width = 185

        datalistado.Columns(8).Visible = False
        datalistado.Columns(7).Visible = False


        sumar()

    End Sub
    Private Sub sumar()
        Try
            Dim totalpagar As Double

            totalpagar = 0
            Dim fila As DataGridViewRow = New DataGridViewRow()
            For Each fila In datalistado.Rows
                totalpagar += (fila.Cells("Importe").Value)
            Next

            TXTTOTALTOTAL.Text = (totalpagar)
            TXTTOTALTOTAL.Text = Format(CType(TXTTOTALTOTAL.Text, Decimal), "##0.00")
        Catch ex As Exception

        End Try



    End Sub
    Private Sub LISTAR_INGRESOS_VARIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()

    End Sub

    Private Sub txtbusca_TextChanged_1(sender As Object, e As EventArgs) Handles txtbusca.TextChanged
        With datalistado
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        End With
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("BUSCAR_INGRESOS", conexion)
        Try
            abrir()
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtbusca.Text)
            da.Fill(dt)
            datalistado.DataSource = dt


        Catch ex As Exception
        End Try
        Try




            datalistado.Columns(2).Visible = False
            datalistado.Columns(1).Width = 140
            datalistado.Columns(3).Width = 110
            datalistado.Columns(4).Width = 140
            datalistado.Columns(5).Width = 90
            datalistado.Columns(6).Width = 200
            datalistado.Columns(0).Width = 50
            datalistado.Columns(9).Width = 185

            datalistado.Columns(8).Visible = False
            datalistado.Columns(7).Visible = False
        Catch ex As Exception

        End Try
        sumar()
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        Try
            If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
                Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
                chkcell.Value = Not chkcell.Value
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        txtmsbox.Text = "Se ha activado la eliminacion de registros"
        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("Idgasto").Value)

                        Try

                            abrir()
                            cmd = New SqlCommand("eliminar_gasto", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@idgasto", onekey)

                            cmd.ExecuteNonQuery()


                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try
                        Cerrar()
                    End If

                Next

                Call Listar()



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
        mascara1.dispose()
    End Sub

    Private Sub ToolStripMenuItem4_Click_1(sender As Object, e As EventArgs)
        GASTOS_VARIOS_FORM.TXTACCION.Text = "INGRESO"
        GASTOS_VARIOS_FORM.datalistadogrupodegastos.Visible = True
        GASTOS_VARIOS_FORM.PANELCOMPROBANTE.Enabled = False
        GASTOS_VARIOS_FORM.PANELPRECIOS.Enabled = False
        GASTOS_VARIOS_FORM.txtmenuinterno.Text = "INTERNO"
        GASTOS_VARIOS_FORM.GuardarCambiosToolStripMenuItem.Visible = False
        GASTOS_VARIOS_FORM.GUARDARNORMAL.Visible = True
        GASTOS_VARIOS_FORM.txtidgasto2.Text = ""
        GASTOS_VARIOS_FORM.TXTIDCONCEPTO.Text = ""


        GASTOS_VARIOS_FORM.txtobservacion.Text = ""
        GASTOS_VARIOS_FORM.txtnrocomprobante.Text = ""
        GASTOS_VARIOS_FORM.txttipocomprobante.Text = ""
        GASTOS_VARIOS_FORM.txtpantalla.Text = 0
        GASTOS_VARIOS_FORM.TXTCONCEPTO.Text = ""


        MASCARA1.Show()
        GASTOS_VARIOS_FORM.ShowDialog()

        GASTOS_VARIOS_FORM.txtmenuinterno.Text = "INTERNO"
        GASTOS_VARIOS_FORM.GuardarCambiosToolStripMenuItem.Visible = False
        GASTOS_VARIOS_FORM.GUARDARNORMAL.Visible = True
        GASTOS_VARIOS_FORM.txtidgasto2.Text = ""
        GASTOS_VARIOS_FORM.TXTIDCONCEPTO.Text = ""


        GASTOS_VARIOS_FORM.txtobservacion.Text = ""
        GASTOS_VARIOS_FORM.txtnrocomprobante.Text = ""
        GASTOS_VARIOS_FORM.txttipocomprobante.Text = ""
        GASTOS_VARIOS_FORM.txtpantalla.Text = 0
        GASTOS_VARIOS_FORM.TXTCONCEPTO.Text = ""
        GASTOS_VARIOS_FORM.PANELCOMPROBANTE.Enabled = False
        GASTOS_VARIOS_FORM.PANELPRECIOS.Enabled = False
        GASTOS_VARIOS_FORM.datalistadogrupodegastos.Visible = True
        GASTOS_VARIOS_FORM.TXTACCION.Text = "INGRESO"
    End Sub
End Class