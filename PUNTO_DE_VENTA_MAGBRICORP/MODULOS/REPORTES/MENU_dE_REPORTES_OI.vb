Imports System.Data
Imports System.Data.SqlClient
Public Class MENU_dE_REPORTES_OI
    Public copiar As Boolean = False
    Public bmp As Bitmap
    Private Sub ToolStripButton31_Click(sender As Object, e As EventArgs)
        MASCARA1.Show()
        F_MOVIMIENTOS_KARDEX.ShowDialog()

    End Sub
    Dim rptFREPORT2 As New ReportKARDEX_Movimientos()
    Sub mostrar_kardex_movimientos()

        Dim dtMA As New DataTable
        Dim daMA As SqlDataAdapter
        Try
            abrir()
            daMA = New SqlDataAdapter("MOSTRAR_MOVIMIENTOS_DE_KARDEX", conexion)
            daMA.SelectCommand.CommandType = 4
            daMA.SelectCommand.Parameters.AddWithValue("@letra", txtbuscarKardex_movimientos.Text)
            daMA.Fill(dtMA)
            Cerrar()
            rptFREPORT2 = New ReportKARDEX_Movimientos
            rptFREPORT2.DataSource = dtMA

            ReportViewer2.Report = rptFREPORT2
            ReportViewer2.RefreshReport()
        Catch ex As Exception
            '
        End Try
    End Sub
    Dim rptFREPORT3 As New ReportRESUMENVentas()
    Sub mostrar_ventas_realizadas()

        Dim dtMA As New DataTable
        Dim daMA As SqlDataAdapter
        Try
            abrir()
            daMA = New SqlDataAdapter("mostrar_ventas_realizadas", conexion)
            'daMA.SelectCommand.CommandType = 4
            'daMA.SelectCommand.Parameters.AddWithValue("@letra", txtbuscarKardex_movimientos.Text)
            daMA.Fill(dtMA)
            Cerrar()
            rptFREPORT3 = New ReportRESUMENVentas
            rptFREPORT3.DataSource = dtMA

            ReportViewer1.Report = rptFREPORT3
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            '
        End Try
    End Sub
    Sub Listar_ventaspor_mes()
        Dim fecha As ArrayList = New ArrayList
        Dim monto As ArrayList = New ArrayList

        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("mostrar_ventas_realizadas", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            dr = cmd.ExecuteReader()
            While (dr.Read())
                fecha.Add(dr.GetString(0))
                monto.Add(dr.GetString(1))
            End While
            ChartVENTAS.Series(0).Points.DataBindXY(fecha, monto)
            dr.Close()
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub MENU_dE_REPORTES_OI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelREPORTEInventario.Visible = False
        PanelReportVentas.Visible = False
        PanelKardex.Visible = False
        Label1.Text = "Elije un Reporte a Visualizar"

    End Sub

    Private Sub tmOCULTAR_Tick(sender As Object, e As EventArgs) Handles tmOCULTAR.Tick
        If Panel72.Width <= 0 Then
            Me.tmOCULTAR.Enabled = False
        Else
            Me.Panel72.Width = Panel72.Width - 70
        End If

    End Sub

    Private Sub tmMOSTRAR_Tick(sender As Object, e As EventArgs) Handles tmMOSTRAR.Tick
        If Panel72.Width >= 210 Then
            Me.tmMOSTRAR.Enabled = False
        Else
            Me.Panel72.Width = Panel72.Width + 70
        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label119_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem22_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem22.Click
        If Panel72.Width = 210 Then
            tmOCULTAR.Enabled = True
        ElseIf Panel72.Width = 0 Then
            tmMOSTRAR.Enabled = True
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ResumenDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumenDeVentasToolStripMenuItem.Click
        Label1.Text = "Reporte de Ventas"
        PanelKardex.Dock = DockStyle.None
        PanelKardex.Visible = False
        PanelREPORTEInventario.Dock = DockStyle.None
        PanelREPORTEInventario.Visible = False
        PanelReportVentas.Dock = DockStyle.Fill
        PanelReportVentas.Visible = True



        Listar_ventaspor_mes()
        mostrar_ventas_realizadas()

        If Panel72.Width = 210 Then
            tmOCULTAR.Enabled = True
        ElseIf Panel72.Width = 0 Then
            tmMOSTRAR.Enabled = True
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Sub mostrar_inventarios_todos()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try

            abrir()
            da = New SqlDataAdapter("mostrar_inventarios_todos", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtbuscar_inventarios.Text)
            da.Fill(dt)
            datalistadoInventariosReport.DataSource = dt
            datalistadoInventariosReport.Columns(0).Visible = False
            datalistadoInventariosReport.Columns(1).Width = 130
            datalistadoInventariosReport.Columns(2).Width = 300
            datalistadoInventariosReport.Columns(3).Visible = 80
            datalistadoInventariosReport.Columns(4).Width = 100
            datalistadoInventariosReport.Columns(5).Width = 80
            datalistadoInventariosReport.Columns(6).Width = 100
            Cerrar()

        Catch ex As Exception
        End Try
        Me.datalistadoInventariosReport.EnableHeadersVisualStyles = False
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.White
        styCabeceras.ForeColor = Color.Black
        styCabeceras.Font = New Font("Segoe UI", 10, FontStyle.Regular Or
        FontStyle.Bold)
        Me.datalistadoInventariosReport.ColumnHeadersDefaultCellStyle = styCabeceras
        sumar()
        contar()
    End Sub
    Private Sub contar()
        Dim x As Integer
        x = datalistadoInventariosReport.Rows.Count
        lblcantidaddeProductosEnInventario.Text = CStr(x)
    End Sub
    Private Sub sumar()
        Try
            Dim totalpagar As Double

            totalpagar = 0
            Dim fila As DataGridViewRow = New DataGridViewRow()
            For Each fila In datalistadoInventariosReport.Rows
                totalpagar += (fila.Cells("Importe").Value)
            Next

            lblcostoInventario.Text = (totalpagar)
            lblcostoInventario.Text = Format(CType(lblcostoInventario.Text, Decimal), "##0.00")
        Catch ex As Exception

        End Try



    End Sub
    Private Sub InventarioGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioGeneralToolStripMenuItem.Click
        mostrar_inventarios_todos()
        PanelKardex.Dock = DockStyle.None
        PanelKardex.Visible = False
        PanelREPORTEInventario.Dock = DockStyle.Fill
        PanelREPORTEInventario.Visible = True
        PanelReportVentas.Dock = DockStyle.None
        PanelReportVentas.Visible = False
        Label1.Text = "Reporte de Inventarios Generales"

        If Panel72.Width = 210 Then
            tmOCULTAR.Enabled = True
        ElseIf Panel72.Width = 0 Then
            tmMOSTRAR.Enabled = True
        End If
    End Sub

    Private Sub txtbuscar_inventarios_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar_inventarios.TextChanged
        mostrar_inventarios_todos()
    End Sub

    Private Sub KardexDeInventariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KardexDeInventariosToolStripMenuItem.Click
        PanelKardex.Dock = DockStyle.Fill
        PanelKardex.Visible = True
        PanelREPORTEInventario.Dock = DockStyle.None
        PanelREPORTEInventario.Visible = False
        PanelReportVentas.Dock = DockStyle.None
        PanelReportVentas.Visible = False
        Label1.Text = "Reporte de Kardex de Inventarios"
        txtbuscarKardex_movimientos.Text = "Buscar producto,cajero"

        If Panel72.Width = 210 Then
            tmOCULTAR.Enabled = True
        ElseIf Panel72.Width = 0 Then
            tmMOSTRAR.Enabled = True
        End If
    End Sub

    Private Sub txtbuscarKardex_movimientos_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarKardex_movimientos.TextChanged

        mostrar_kardex_movimientos()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        mascara1.dispose()
        Close()

    End Sub
End Class