Imports System.Data
Imports System.Data.SqlClient
Public Class INVENTARIO

    Private Sub MenuStrip3_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip3.ItemClicked

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
            datalistadoInventariosReport.Columns(9).Visible = False
            datalistadoInventariosReport.Columns(10).Visible = False
            Cerrar()

        Catch ex As Exception
        End Try
        Multilinea(datalistadoInventariosReport)
        sumar()
        contar()
    End Sub


    Sub MOSTRAR_MOVIMIENTOS_DE_KARDEX()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("MOSTRAR_MOVIMIENTOS_DE_KARDEX", conexion)
            da.Fill(dt)
            DatalistadoMovimientos.DataSource = dt
            DatalistadoMovimientos.Columns(0).Visible = False
            DatalistadoMovimientos.Columns(12).Visible = False
            DatalistadoMovimientos.Columns(13).Visible = False
            DatalistadoMovimientos.Columns(14).Visible = False
            DatalistadoMovimientos.Columns(15).Visible = False

            Cerrar()

        Catch ex As Exception
        End Try
        Multilinea(DatalistadoMovimientos)
    End Sub
    Sub MOSTRAR_Inventarios_bajo_minimo()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("MOSTRAR_Inventarios_bajo_minimo", conexion)
            da.Fill(dt)
            datalistadoInventarioBAJO.DataSource = dt
            datalistadoInventarioBAJO.Columns(0).Visible = False
            datalistadoInventarioBAJO.Columns(4).Visible = False
            datalistadoInventarioBAJO.Columns(7).Visible = False
            datalistadoInventarioBAJO.Columns(8).Visible = False
            datalistadoInventarioBAJO.Columns(9).Visible = False
            Cerrar()

        Catch ex As Exception
        End Try
        Multilinea(datalistadoInventarioBAJO)
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
    Sub CAMBIO_DE_COLOR_MDI()
        Dim ctl As Control
        Dim ctlMDI As MdiClient


        For Each ctl In Me.Controls

            Try

                ctlMDI = CType(ctl, MdiClient)
                ctlMDI.BackColor = Me.BackColor


            Catch exc As InvalidCastException


            End Try

        Next


    End Sub

    Private Sub INVENTARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        PanelMOVIMIENTOS.Dock = DockStyle.None
        PanelREPORTEInventario.Dock = DockStyle.None
        PaneliNVENTARIObajo.Dock = DockStyle.None
        PanelMOVIMIENTOS.Visible = False
        PanelREPORTEInventario.Visible = False
        PaneliNVENTARIObajo.Visible = False
        PanelKardex.Visible = True
        PanelKardex.Dock = DockStyle.Fill
        Panelv.Visible = False
        PanelVencimientos.Visible = False
        PanelVencimientos.Dock = DockStyle.None

        PanelK.Visible = True
        PanelI.Visible = False
        PanelM.Visible = False
        PanelR.Visible = False
        Panelv.Visible = False
        txtbuscarKardex_movimientos.Text = "Buscar producto"
        'CAMBIO_DE_COLOR_MDI()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        KARDEX_REGISTRO.TXTTIPO.Text = "ENTRADA"

        MASCARA1.Show()
        KARDEX_REGISTRO.ShowDialog()
        KARDEX_REGISTRO.TXTTIPO.Text = "ENTRADA"
    End Sub
    Sub mostrar_cajas()
        Dim dtunidad As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("select*from USUARIO2", conexion)
            DA.Fill(dtunidad)

            txtUSUARIOS.DisplayMember = "Nombre_y_Apelllidos"

            txtUSUARIOS.ValueMember = "idUsuario"

            txtUSUARIOS.DataSource = dtunidad
            Cerrar()
            txtIdcaja.Text = txtUSUARIOS.ValueMember
        Catch ex As Exception

        End Try



    End Sub

    Private Sub TMOVIMIENTOS_Click(sender As Object, e As EventArgs) Handles TMOVIMIENTOS.Click
        Panel17.Visible = False
        PanelR.Visible = False
        PanelK.Visible = False
        PanelI.Visible = False
        PanelM.Visible = True
        Panelv.Visible = False
        PanelMOVIMIENTOS.Visible = True
        PanelREPORTEInventario.Visible = False

        PanelMOVIMIENTOS.Dock = DockStyle.Fill
        PanelREPORTEInventario.Dock = DockStyle.None
        PaneliNVENTARIObajo.Dock = DockStyle.None
        PaneliNVENTARIObajo.Visible = False
        PanelKardex.Visible = False
        PanelKardex.Dock = DockStyle.None
        PanelVencimientos.Visible = False
        PanelVencimientos.Dock = DockStyle.None
        Panelv.Visible = False
        MOSTRAR_MOVIMIENTOS_DE_KARDEX()
        mostrar_cajas()
        buscar_id_caja()
        txtbuscarMovimiento.Text = "Buscar producto"
    End Sub

    Private Sub TOTROSPAGOS_Click(sender As Object, e As EventArgs) Handles TOTROSPAGOS.Click

        PanelR.Visible = True
        PanelK.Visible = False
        PanelI.Visible = False
        PanelM.Visible = False
        Panelv.Visible = False
        PanelMOVIMIENTOS.Visible = False
        PanelREPORTEInventario.Visible = True
        PaneliNVENTARIObajo.Visible = False
        PanelMOVIMIENTOS.Dock = DockStyle.None
        PanelREPORTEInventario.Dock = DockStyle.Fill
        PaneliNVENTARIObajo.Dock = DockStyle.None
        PanelKardex.Visible = False
        PanelKardex.Dock = DockStyle.None
        PanelVencimientos.Visible = False
        PanelVencimientos.Dock = DockStyle.None
        Panelv.Visible = False
        mostrar_inventarios_todos()

    End Sub
    Sub buscar_MOVIMIENTOS_DE_KARDEX()
        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("buscar_MOVIMIENTOS_DE_KARDEX", conexion)
            daListarpresentacionesagregadas.SelectCommand.CommandType = 4
            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@idProducto", DATALISTADO_PRODUCTOS_Movimientos.SelectedCells.Item(1).Value)
            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            DatalistadoMovimientos.DataSource = dtDATALISTADO_AGREGANDO
            Cerrar()

            DatalistadoMovimientos.Columns(0).Visible = False
            DatalistadoMovimientos.Columns(10).Visible = False
            DatalistadoMovimientos.Columns(11).Visible = False

        Catch ex As Exception
        End Try
        Multilinea(DatalistadoMovimientos)

    End Sub
    Private Sub txtbuscarMovimiento_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarMovimiento.TextChanged
        '        If GroupBox1.Visible = True Then
        '            buscar_MOVIMIENTOS_FILTROS()
        '        Else
        'If txtbuscarMovimiento.Text <> "Buscar producto" Then
        '                buscar_MOVIMIENTOS_DE_KARDEX()
        '            End If

        '        End If
        If txtbuscarMovimiento.Text = "Buscar producto" Or txtbuscarMovimiento.Text = "" Then
            DATALISTADO_PRODUCTOS_Movimientos.Visible = False
        Else
            DATALISTADO_PRODUCTOS_Movimientos.Visible = True
            buscar_productos_movimientos()

        End If

    End Sub
    Sub buscar_productos_movimientos()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try

            abrir()
            da = New SqlDataAdapter("BUSCAR_PRODUCTOS_KARDEX", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letrab", txtbuscarMovimiento.Text)
            da.Fill(dt)
            DATALISTADO_PRODUCTOS_Movimientos.DataSource = dt
            DATALISTADO_PRODUCTOS_Movimientos.Columns(1).Visible = False
            DATALISTADO_PRODUCTOS_Movimientos.Columns(3).Visible = False
            DATALISTADO_PRODUCTOS_Movimientos.Columns(4).Visible = False
            DATALISTADO_PRODUCTOS_Movimientos.Columns(5).Visible = False
            DATALISTADO_PRODUCTOS_Movimientos.Columns(6).Visible = False
            DATALISTADO_PRODUCTOS_Movimientos.Columns(7).Visible = False
            DATALISTADO_PRODUCTOS_Movimientos.Columns(8).Visible = False
            DATALISTADO_PRODUCTOS_Movimientos.Columns(9).Visible = False
            DATALISTADO_PRODUCTOS_Movimientos.Columns(10).Visible = False
            DATALISTADO_PRODUCTOS_Movimientos.Columns(11).Visible = False
            DATALISTADO_PRODUCTOS_Movimientos.Columns(12).Visible = False
            DATALISTADO_PRODUCTOS_Movimientos.Columns(13).Visible = False
            DATALISTADO_PRODUCTOS_Movimientos.Columns(14).Visible = False
            DATALISTADO_PRODUCTOS_Movimientos.Columns(15).Visible = False
            DATALISTADO_PRODUCTOS_Movimientos.Columns(16).Visible = False
            Cerrar()

            'Multilinea(DATALISTADO_PRODUCTOS_Movimientos)
            DATALISTADO_PRODUCTOS_Movimientos.Columns(2).Width = DATALISTADO_PRODUCTOS_Movimientos.Width
        Catch ex As Exception
            'MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub TKardex_Click(sender As Object, e As EventArgs) Handles TKardex.Click
        PanelR.Visible = False
        PanelK.Visible = True
        PanelI.Visible = False
        PanelM.Visible = False
        Panelv.Visible = False

        PanelMOVIMIENTOS.Dock = DockStyle.None
        PanelREPORTEInventario.Dock = DockStyle.None
        PaneliNVENTARIObajo.Dock = DockStyle.None
        PanelMOVIMIENTOS.Visible = False
        PanelREPORTEInventario.Visible = False
        PaneliNVENTARIObajo.Visible = False
        PanelKardex.Visible = True
        PanelKardex.Dock = DockStyle.Fill
        PanelVencimientos.Visible = False
        PanelVencimientos.Dock = DockStyle.None
        Panelv.Visible = False
        txtbuscarKardex_movimientos.Text = "Buscar producto"



    End Sub

    Private Sub TNOTAS_Click(sender As Object, e As EventArgs) Handles TNOTAS.Click

        PanelMOVIMIENTOS.Dock = DockStyle.None
        PanelREPORTEInventario.Dock = DockStyle.None

        PanelMOVIMIENTOS.Visible = False
        PanelREPORTEInventario.Visible = False
        PaneliNVENTARIObajo.Visible = True
        PaneliNVENTARIObajo.Dock = DockStyle.Fill
        PanelKardex.Visible = False
        PanelKardex.Dock = DockStyle.None
        PanelK.Visible = False
        PanelI.Visible = True
        PanelM.Visible = False
        PanelR.Visible = False
        Panelv.Visible = False
        PanelVencimientos.Visible = False
        PanelVencimientos.Dock = DockStyle.None
        Panelv.Visible = False
        MOSTRAR_Inventarios_bajo_minimo()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        KARDEX_REGISTRO.TXTTIPO.Text = "ENTRADA"

        MASCARA1.Show()
        KARDEX_REGISTRO.ShowDialog()
        KARDEX_REGISTRO.TXTTIPO.Text = "ENTRADA"
    End Sub
    Sub buscar_MOVIMIENTOS_FILTROS()
        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("buscar_MOVIMIENTOS_DE_KARDEX_filtros", conexion)
            daListarpresentacionesagregadas.SelectCommand.CommandType = 4
            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@fecha", txtfechaM.Value)
            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@tipo", txtTipoMovi.Text)
            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@Id_usuario", txtIdcaja.Text)

            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            DatalistadoMovimientos.DataSource = dtDATALISTADO_AGREGANDO
            Cerrar()


            DatalistadoMovimientos.Columns(0).Visible = False
            DatalistadoMovimientos.Columns(10).Visible = False
            DatalistadoMovimientos.Columns(11).Visible = False

            DatalistadoMovimientos.Columns(9).Visible = False
            DatalistadoMovimientos.Columns(13).Visible = False
            DatalistadoMovimientos.Columns(14).Visible = False
            DatalistadoMovimientos.Columns(12).Visible = False
            'DatalistadoMovimientos.Columns(16).Visible = False
        Catch ex As Exception
        End Try
        Multilinea(DatalistadoMovimientos)

    End Sub
    Sub buscar_MOVIMIENTOS_FILTROS_ACUMULADO()
        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("buscar_MOVIMIENTOS_DE_KARDEX_filtros_acumulado", conexion)
            daListarpresentacionesagregadas.SelectCommand.CommandType = 4
            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@fecha", txtfechaM.Value)
            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@tipo", txtTipoMovi.Text)
            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@Id_usuario", txtIdcaja.Text)

            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            DatalistadoMovimientosACUMULADO_PRODUCTO.DataSource = dtDATALISTADO_AGREGANDO
            Cerrar()
            Try
                DatalistadoMovimientosACUMULADO_PRODUCTO.Columns(4).Visible = False
                DatalistadoMovimientosACUMULADO_PRODUCTO.Columns(5).Visible = False
                DatalistadoMovimientosACUMULADO_PRODUCTO.Columns(6).Visible = False

            Catch ex As Exception

            End Try


        Catch ex As Exception
        End Try
        Multilinea(DatalistadoMovimientosACUMULADO_PRODUCTO)

    End Sub
    Sub buscar_id_caja()
        Dim importe As Double
        Dim com As New SqlCommand("Buscar_id_USUARIOS", conexion)
        com.CommandType = 4
        com.Parameters.AddWithValue("@Nombre_y_Apelllidos", txtUSUARIOS.Text)
        Try
            abrir()
            importe = (com.ExecuteScalar()) 'asignamos el valor del importe
            Cerrar()
        Catch ex As Exception
        End Try
        txtIdcaja.Text = importe  ' mostramos el importe
    End Sub
    Private Sub txtCaja_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtUSUARIOS.SelectedIndexChanged
        If GroupBox1.Visible = True Then

            buscar_id_caja()
            buscar_MOVIMIENTOS_FILTROS()
            buscar_MOVIMIENTOS_FILTROS_ACUMULADO()
        End If


    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        GroupBox1.Visible = True
        DATALISTADO_PRODUCTOS_Movimientos.Visible = False
        txtTipoMovi.Text = "-Todos-"
        buscar_MOVIMIENTOS_FILTROS()
        buscar_MOVIMIENTOS_FILTROS_ACUMULADO()
        Panel17.Visible = True
    End Sub



    Private Sub tver_Click(sender As Object, e As EventArgs) Handles tver.Click
        Panel17.Visible = False
        GroupBox1.Visible = False
        buscar_MOVIMIENTOS_DE_KARDEX()
        txtTipoMovi.Text = "-Todos-"
        txtbuscarMovimiento.Text = "Buscar producto"
    End Sub

    Private Sub txtTipoMovi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtTipoMovi.SelectedIndexChanged
        If GroupBox1.Visible = True Then

            buscar_MOVIMIENTOS_FILTROS()
        buscar_MOVIMIENTOS_FILTROS_ACUMULADO()

        End If
    End Sub

    Private Sub txtfechaM_ValueChanged(sender As Object, e As EventArgs) Handles txtfechaM.ValueChanged
        If GroupBox1.Visible = True Then


            buscar_MOVIMIENTOS_FILTROS()
            buscar_MOVIMIENTOS_FILTROS_ACUMULADO()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

        Close()

    End Sub





    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar_inventarios.TextChanged
        If txtbuscar_inventarios.Text <> "Buscar..." Then
            mostrar_inventarios_todos()
        End If

    End Sub



    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        KARDEX_REGISTRO.TXTTIPO.Text = "ENTRADA"

        MASCARA1.Show()
        KARDEX_REGISTRO.ShowDialog()
        KARDEX_REGISTRO.TXTTIPO.Text = "ENTRADA"
    End Sub
    Dim rptFREPORT2 As New ReportKARDEX_Movimientos()
    Sub mostrar_kardex_movimientos()

        Dim dtMA As New DataTable
        Dim daMA As SqlDataAdapter
        Try
            abrir()
            daMA = New SqlDataAdapter("MOSTRAR_MOVIMIENTOS_DE_KARDEX", conexion)
            daMA.SelectCommand.CommandType = 4
            daMA.SelectCommand.Parameters.AddWithValue("@idProducto", DATALISTADO_PRODUCTOS_Kardex.SelectedCells.Item(1).Value)
            daMA.Fill(dtMA)
            Cerrar()
            rptFREPORT2 = New ReportKARDEX_Movimientos
            rptFREPORT2.DataSource = dtMA
            rptFREPORT2.Table3.DataSource = dtMA
            ReportViewer1.Report = rptFREPORT2
            ReportViewer1.RefreshReport()
        Catch ex As Exception      '
        End Try
    End Sub
    Private Sub txtbuscarKardex_movimientos_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarKardex_movimientos.TextChanged
        If txtbuscarKardex_movimientos.Text = "Buscar producto" Or txtbuscarKardex_movimientos.Text = "" Then
            DATALISTADO_PRODUCTOS_Kardex.Visible = False
        Else
            buscar_productos_kardex()
        End If


    End Sub
    'daMA = New SqlDataAdapter("MOSTRAR_MOVIMIENTOS_DE_KARDEX", conexion)
    '       daMA.SelectCommand.CommandType = 4
    '       daMA.SelectCommand.Parameters.AddWithValue("@letra", txtbuscarKardex_movimientos.Text)
    '       daMA.Fill(dtMA)
    Sub buscar_productos_kardex()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try

            abrir()
            da = New SqlDataAdapter("BUSCAR_PRODUCTOS_KARDEX", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letrab", txtbuscarKardex_movimientos.Text)
            da.Fill(dt)
            DATALISTADO_PRODUCTOS_Kardex.DataSource = dt
            DATALISTADO_PRODUCTOS_Kardex.Columns(1).Visible = False
            DATALISTADO_PRODUCTOS_Kardex.Columns(3).Visible = False
            DATALISTADO_PRODUCTOS_Kardex.Columns(4).Visible = False
            DATALISTADO_PRODUCTOS_Kardex.Columns(5).Visible = False
            DATALISTADO_PRODUCTOS_Kardex.Columns(6).Visible = False
            DATALISTADO_PRODUCTOS_Kardex.Columns(7).Visible = False
            DATALISTADO_PRODUCTOS_Kardex.Columns(8).Visible = False
            DATALISTADO_PRODUCTOS_Kardex.Columns(9).Visible = False
            DATALISTADO_PRODUCTOS_Kardex.Columns(10).Visible = False
            DATALISTADO_PRODUCTOS_Kardex.Columns(11).Visible = False
            DATALISTADO_PRODUCTOS_Kardex.Columns(12).Visible = False
            DATALISTADO_PRODUCTOS_Kardex.Columns(13).Visible = False
            DATALISTADO_PRODUCTOS_Kardex.Columns(14).Visible = False
            DATALISTADO_PRODUCTOS_Kardex.Columns(15).Visible = False
            DATALISTADO_PRODUCTOS_Kardex.Columns(16).Visible = False
            Cerrar()
            DATALISTADO_PRODUCTOS_Kardex.Visible = True
            'Multilinea(DATALISTADO_PRODUCTOS_Kardex)
            DATALISTADO_PRODUCTOS_Kardex.Columns(2).Width = DATALISTADO_PRODUCTOS_Kardex.Width
        Catch ex As Exception
            'MsgBox(ex.Message)
            DATALISTADO_PRODUCTOS_Kardex.Visible = False
        End Try


    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        FormInventariosBAjos.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        FormInventariosTodos.ShowDialog()
    End Sub

    Private Sub PanelREPORTEInventario_Paint(sender As Object, e As PaintEventArgs) Handles PanelREPORTEInventario.Paint

    End Sub
    Private Sub contar_registros_Movimientos()
        Dim x As Integer
        x = DatalistadoMovimientos.Rows.Count
        lblcontarMovimientos.Text = CStr(x)
    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        contar_registros_Movimientos()

        If txtbuscarMovimiento.Text = "Buscar producto" Or txtbuscarMovimiento.Text = "" Or lblcontarMovimientos.Text = 0 Then
            MessageBox.Show("Busque un Producto Primero", "Sin datos que mostrar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            FormMovimientosBuscar.ShowDialog()

        End If


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        KARDEX_REGISTRO.TXTTIPO.Text = "SALIDA"

        MASCARA1.Show()
        KARDEX_REGISTRO.ShowDialog()
        KARDEX_REGISTRO.TXTTIPO.Text = "SALIDA"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        KARDEX_REGISTRO.TXTTIPO.Text = "SALIDA"

        MASCARA1.Show()
        KARDEX_REGISTRO.ShowDialog()
        KARDEX_REGISTRO.TXTTIPO.Text = "SALIDA"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        KARDEX_REGISTRO.TXTTIPO.Text = "SALIDA"

        MASCARA1.Show()
        KARDEX_REGISTRO.ShowDialog()
        KARDEX_REGISTRO.TXTTIPO.Text = "SALIDA"
    End Sub
    Sub mostrar_productos_vencidos()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_productos_vencidos", conexion)
            da.Fill(dt)
            datalistadoVencimientos.DataSource = dt
            Cerrar()
        Catch ex As Exception
        End Try
    End Sub
    Sub mostrar_productos_vencidos_en_menos_de_30_dias()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_productos_vencidos_en_menos_de_30_dias", conexion)
            da.Fill(dt)
            datalistadoVencimientos.DataSource = dt
            Cerrar()
        Catch ex As Exception
        End Try
    End Sub
    Sub buscar_productos_vencidos()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_productos_vencidos", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtBuscarVencimientos.Text)
            da.Fill(dt)
            datalistadoVencimientos.DataSource = dt
            Cerrar()
            Try
                datalistadoVencimientos.Columns(0).Visible = False
                datalistadoVencimientos.Columns(1).Visible = False
                datalistadoVencimientos.Columns(6).Visible = False
                datalistadoVencimientos.Columns(7).Visible = False
            Catch ex As Exception

            End Try
            Multilinea(datalistadoVencimientos)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtBuscarVencimientos_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarVencimientos.TextChanged
        If txtBuscarVencimientos.Text <> "Buscar producto/Codigo" Then
            buscar_productos_vencidos()
            CheckPorVenceren30Dias.Checked = False
            CheckProductosVencidos.Checked = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerVencimientos.Tick
        CheckProductosVencidos.Checked = False
        CheckPorVenceren30Dias.Checked = False
        PanelR.Visible = False
        PanelK.Visible = False
        PanelI.Visible = False
        PanelM.Visible = False

        PanelMOVIMIENTOS.Visible = False
        PanelREPORTEInventario.Visible = False
        PaneliNVENTARIObajo.Visible = False
        PanelMOVIMIENTOS.Dock = DockStyle.None
        PanelREPORTEInventario.Dock = DockStyle.Fill
        PaneliNVENTARIObajo.Dock = DockStyle.None
        PanelKardex.Visible = False
        PanelKardex.Dock = DockStyle.None
        PanelVencimientos.Visible = True
        PanelVencimientos.Dock = DockStyle.Fill
        Panelv.Visible = True

        TimerVencimientos.Stop()

    End Sub



    Private Sub TVencimientos_Click(sender As Object, e As EventArgs) Handles TVencimientos.Click

        PanelR.Visible = False
        PanelK.Visible = False
        PanelI.Visible = False
        PanelM.Visible = False
        Panelv.Visible = True
        PanelMOVIMIENTOS.Visible = False
        PanelREPORTEInventario.Visible = False
        PaneliNVENTARIObajo.Visible = False
        PanelMOVIMIENTOS.Dock = DockStyle.None
        PanelREPORTEInventario.Dock = DockStyle.Fill
        PaneliNVENTARIObajo.Dock = DockStyle.None
        PanelKardex.Visible = False
        PanelKardex.Dock = DockStyle.None
        PanelVencimientos.Visible = True
        PanelVencimientos.Dock = DockStyle.Fill
        Panelv.Visible = True
        txtBuscarVencimientos.Text = "Buscar producto/Codigo"
    End Sub



    Private Sub CheckProductosVencidos_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckProductosVencidos.CheckedChanged
        mostrar_productos_vencidos()
        txtBuscarVencimientos.Text = "Buscar producto/Codigo"
    End Sub

    Private Sub CheckPorVenceren30Dias_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckPorVenceren30Dias.CheckedChanged
        mostrar_productos_vencidos_en_menos_de_30_dias()
        txtBuscarVencimientos.Text = "Buscar producto/Codigo"
    End Sub

    Private Sub PanelVencimientos_Paint(sender As Object, e As PaintEventArgs) Handles PanelVencimientos.Paint

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click

    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click, ToolStripMenuItem10.Click
        txtbuscar_inventarios.Text = ""
        mostrar_inventarios_todos()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        'If GroupBox1.Visible = True Then
        '    buscar_MOVIMIENTOS_FILTROS()
        'Else
        '    If txtbuscarMovimiento.Text <> "Buscar producto,cajero" Then
        '        buscar_MOVIMIENTOS_DE_KARDEX()
        '    End If

        'End If

    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click

    End Sub

    Private Sub Panel13_Paint(sender As Object, e As PaintEventArgs) Handles Panel13.Paint

    End Sub

    Private Sub DATALISTADO_PRODUCTOS_Kardex_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_PRODUCTOS_Kardex.CellContentClick

    End Sub

    Private Sub DATALISTADO_PRODUCTOS_Kardex_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_PRODUCTOS_Kardex.CellClick

        txtbuscarKardex_movimientos.Text = DATALISTADO_PRODUCTOS_Kardex.SelectedCells.Item(2).Value
        DATALISTADO_PRODUCTOS_Kardex.Visible = False
        mostrar_kardex_movimientos()
    End Sub

    Private Sub txtbuscarKardex_movimientos_Click(sender As Object, e As EventArgs) Handles txtbuscarKardex_movimientos.Click
        txtbuscarKardex_movimientos.SelectAll()
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub DATALISTADO_PRODUCTOS_Movimientos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_PRODUCTOS_Movimientos.CellContentClick

    End Sub

    Private Sub DATALISTADO_PRODUCTOS_Movimientos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_PRODUCTOS_Movimientos.CellClick
        txtbuscarMovimiento.Text = DATALISTADO_PRODUCTOS_Movimientos.SelectedCells.Item(2).Value
        DATALISTADO_PRODUCTOS_Movimientos.Visible = False
        buscar_MOVIMIENTOS_DE_KARDEX()
    End Sub

    Private Sub txtbuscarMovimiento_Click(sender As Object, e As EventArgs) Handles txtbuscarMovimiento.Click
        txtbuscarMovimiento.SelectAll()
        Panel17.Visible = False

    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        FormReporteMovimientosFILTROS.ShowDialog()


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        FORM_MOVIMIENTOS_FILTROS_ACUMULADOS.ShowDialog()
    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtBuscarVencimientos_Click(sender As Object, e As EventArgs) Handles txtBuscarVencimientos.Click
        txtBuscarVencimientos.SelectAll()

    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        FORM_PRODUCTOS_VENCIDOS.ShowDialog()

    End Sub

    Private Sub txtbuscar_inventarios_Click(sender As Object, e As EventArgs) Handles txtbuscar_inventarios.Click
        txtbuscarKardex_movimientos.SelectAll()

    End Sub
End Class