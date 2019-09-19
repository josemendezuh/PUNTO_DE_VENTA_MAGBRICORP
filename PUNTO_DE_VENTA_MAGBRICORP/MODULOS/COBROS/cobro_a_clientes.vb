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
Public Class cobro_a_clientes
    Dim DT_USUARIO As New DataTable
    Sub Listarmostrar_control_de_cobros_a_clientes_por_xmotivos_X_CLIENTE()
        'Dim dt As New DataTable
        'Dim da As SqlDataAdapter
        'Try
        '    abrir()
        '    da = New SqlDataAdapter("mostrar_control_de_cobros_a_clientes_por_xmotivos_X_CLIENTE", conexion)
        '    da.SelectCommand.CommandType = 4
        '    da.SelectCommand.Parameters.AddWithValue("@Id_cliente", datalistadoclientes.SelectedCells.Item(2).Value)
        '    da.Fill(dt)
        '    datalistado_saldos_conceptos_varios.DataSource = dt
        '    datalistado_saldos_conceptos_varios.Columns(1).Visible = False
        '    datalistado_saldos_conceptos_varios.Columns(2).Width = 240
        '    datalistado_saldos_conceptos_varios.Columns(4).Width = 350
        '    'txttotal.Text = "0.00"
        '    'txttotal.Text = datalistado_saldos_conceptos_varios.SelectedCells.Item(3).Value




        'Catch ex As Exception
        'End Try
        'Cerrar()
    End Sub
    Sub Saldo()

        Dim importe As Double
        Dim com As New SqlCommand("mostrar_solo_saldo_cliente_proveedor", conexion)
        com.CommandType = 4
        com.Parameters.AddWithValue("@id", lblidcliente.Text)
        Try
            abrir()
            importe = (com.ExecuteScalar())
            Cerrar()
        Catch ex As Exception
        End Try
        txttotal_saldo.Text = importe
        txttotal_saldo2.Text = importe
    End Sub
    Sub mostrar_moneda_de_empresa()

        Dim moneda As String
        Dim com As New SqlCommand("Select Moneda From Empresa", conexion)

        Try
            abrir()
            moneda = (com.ExecuteScalar())
            Cerrar()
            lblmoneda.Text = moneda

        Catch ex As Exception
            lblmoneda.Text = ""
        End Try


    End Sub
    Private Sub cobro_a_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("fr-FR")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        Panel18.Location = New Point((Width - Panel18.Width) / 2, (Height - Panel18.Height) / 2)
        mostrar_moneda_de_empresa()
        Label12.Visible = False
        datalistadoMovimientos.Visible = False
        datalistadoHistorial.Visible = True
        datalistadoHistorial.Dock = DockStyle.Fill
        With datalistadoHistorial
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        End With
        datalistadoclientes.Visible = False


        TXTIDUSUARIO.Text = VENTAS_MENU_PRINCIPAL.lblidusuario.Text

        txtmonto.Text = "Monto a abonar"
        Panel17.Visible = False
        datalistadoMovimientos.Visible = False
        datalistadoHistorial.Visible = False
        datalistadoclientes.Visible = False
        txttotal_saldo_Editor.Visible = False
        txttotal_saldo.Visible = True
        TEDITAR.Visible = True
        TGUARDAR.Visible = False
        TCANCELAR.Visible = False
    End Sub

    Sub cargarmonto_total_de_cliente()
        'Dim dt As New DataTable
        'Dim da As SqlDataAdapter
        'Try
        '    abrir()
        '    da = New SqlDataAdapter("mostrar_monto_acumulado_de_credito_de_cliente", conexion)
        '    da.SelectCommand.CommandType = 4
        '    da.SelectCommand.Parameters.AddWithValue("@Id_cliente", datalistadoclientes.SelectedCells.Item(2).Value)
        '    da.Fill(dt)
        '    datalistadomontoporcliente.DataSource = dt

        '    'txttotal.Text = "0.00"
        '    'txttotal.Text = datalistadomontoporcliente.SelectedCells.Item(3).Value




        'Catch ex As Exception
        'End Try
        'Cerrar()

    End Sub
    Sub cargarclientes()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_cliente_POR_nombre_PARA_COBROS", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtclientesolicitante.Text)
            da.Fill(dt)
            datalistadoclientes.DataSource = dt
            datalistadoclientes.Columns(2).Visible = False
            datalistadoclientes.Columns(1).Width = datalistadoclientes.Width
            datalistadoclientes.Columns(3).Visible = False
        Catch ex As Exception
        End Try
        Cerrar()

    End Sub
    Sub mostrar_DETALLE_CONTROL_DE_COBROS()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_DETALLE_CONTROL_DE_COBROS", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@id", lblidcliente.Text)
            da.Fill(dt)
            datalistadoMovimientos.DataSource = dt
            datalistadoMovimientos.Columns(0).Width = 20
            datalistadoMovimientos.Columns(1).Visible = False
            datalistadoMovimientos.Columns(2).Width = 90
            datalistadoMovimientos.Columns(3).Width = 80
            datalistadoMovimientos.Columns(4).Width = Panel11.Width - 210
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try

        Me.datalistadoMovimientos.EnableHeadersVisualStyles = False

        ' estilo para las cabeceras
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.White
        styCabeceras.ForeColor = Color.Black
        styCabeceras.Alignment = DataGridViewContentAlignment.MiddleCenter
        styCabeceras.Font = New Font("Segoe UI", 10, FontStyle.Regular Or
        FontStyle.Bold)

        ' asignar estilo al grid
        Me.datalistadoMovimientos.ColumnHeadersDefaultCellStyle = styCabeceras
    End Sub
    Sub cargar_estado_de_cuenta()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_estado_de_cuenta_de_cliente", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Id_cliente", lblidcliente.text)
            da.Fill(dt)
            datalistadoHistorial.DataSource = dt
            datalistadoHistorial.Columns(0).Visible = False


            datalistadoHistorial.Columns(1).Width = 250
            datalistadoHistorial.Columns(2).Width = 90

            datalistadoHistorial.Columns(3).Width = 90
            datalistadoHistorial.Columns(4).Width = 90


            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try

        Me.datalistadoHistorial.EnableHeadersVisualStyles = False

        ' estilo para las cabeceras
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.White
        styCabeceras.ForeColor = Color.Black
        styCabeceras.Font = New Font("Segoe UI", 10, FontStyle.Regular Or
        FontStyle.Bold)

        ' asignar estilo al grid
        Me.datalistadoHistorial.ColumnHeadersDefaultCellStyle = styCabeceras
    End Sub
    Private Sub sumartotal()
        Try
            Dim totalpagar As Double

            totalpagar = 0
            Dim fila As DataGridViewRow = New DataGridViewRow()
            For Each fila In datalistadoHistorial.Rows
                totalpagar += (fila.Cells("Saldo").Value)
            Next
            txttotal1.Text = (totalpagar)
            txttotal1.Text = Format(CType(txttotal1.Text, Decimal), "##0.00")
        Catch ex As Exception

        End Try


    End Sub
    Private Sub sumartotalconceptosvarios()
        'Try
        '    Dim totalpagar2 As Double

        '    totalpagar2 = 0
        '    Dim fila2 As DataGridViewRow = New DataGridViewRow()
        '    For Each fila2 In datalistado_saldos_conceptos_varios.Rows
        '        totalpagar2 += (fila2.Cells("Saldo").Value)
        '    Next
        '    txttotal2.Text = (totalpagar2)
        '    txttotal2.Text = Format(CType(txttotal2.Text, Decimal), "##0.00")
        'Catch ex As Exception

        'End Try


    End Sub
    Private Sub sumarIGV()
        'Dim totalIGV As Double
        'totalIGV = 0
        'Dim fila As DataGridViewRow = New DataGridViewRow()
        'For Each fila In datalistado.Rows
        '    totalIGV += (fila.Cells("IGV").Value)
        'Next
        'txtimpuestos.Text = (totalIGV)
        'txtimpuestos.Text = Format(CType(txtimpuestos.Text, Decimal), "##0.00")

    End Sub
    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub
    Sub cargarclientesxcontacto()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_cliente_POR_nombre_PARA_VENTAS_por_contacto", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtclientesolicitante.Text)
            da.Fill(dt)
            datalistadoclientes.DataSource = dt
            datalistadoclientes.Columns(2).Visible = False
            datalistadoclientes.Columns(1).Width = 260
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()

    End Sub

    Private Sub txtclientesolicitante_Click(sender As Object, e As EventArgs) Handles txtclientesolicitante.Click
        Timerocultar.Start()
        If lblavisoForm.Text = "OCULTO" Then
            TimerostrarForm.Start()
        End If
        lblavisoForm.Text = "MOSTRADO"

        datalistadoclientes.Visible = True

        txtclientesolicitante.Text = ""
        Label12.Visible = False

    End Sub

    Private Sub txtclientesolicitante_KeyDown(sender As Object, e As KeyEventArgs) Handles txtclientesolicitante.KeyDown
        If e.KeyCode = Keys.Down Then

            datalistadoclientes.Focus()

        End If
    End Sub
    Private Sub txtclientesolicitante_TextChanged(sender As Object, e As EventArgs) Handles txtclientesolicitante.TextChanged
        Try
            cargarclientes()


        Catch ex As Exception

        End Try

    End Sub

    Private Sub datalistadoclientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoclientes.CellClick

        Try

            lblidcliente.Text = datalistadoclientes.SelectedCells.Item(2).Value
            datalistadoclientes.Visible = False
            cargar_estado_de_cuenta()
            mostrar_DETALLE_CONTROL_DE_COBROS()
            txtclientesolicitante.Text = datalistadoclientes.SelectedCells.Item(1).Value
            txtcliente.Text = datalistadoclientes.SelectedCells.Item(1).Value

            cargarmonto_total_de_cliente()
            txtmonto.Text = "Monto a abonar"
            sumartotal()
            sumartotalconceptosvarios()
            txttotal.Text = txttotal1.Text * 1 + txttotal2.Text * 1
            txttotal.Text = Format(CType(txttotal.Text, Decimal), "##0.00")

            cargar_estado_de_cuenta()
            datalistadoMovimientos.Visible = False
            datalistadoHistorial.Visible = True
            datalistadoMovimientos.Dock = DockStyle.None
            datalistadoHistorial.Dock = DockStyle.Fill
            PanelH.Visible = True
            PanelM.Visible = False


            Saldo()

            txttotal_saldo_Editor.Visible = False
            txttotal_saldo.Visible = True
            TEDITAR.Visible = True
            TGUARDAR.Visible = False
            TCANCELAR.Visible = False
        Catch ex As Exception

        End Try


    End Sub

    Private Sub datalistadoclientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoclientes.CellContentClick

    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs)
        'Try
        '    If txttotal1.Text <> "0.00" Then
        '        detalle_para_cobro.txtmontorefrencia.Text = datalistado.SelectedCells.Item(8).Value
        '        detalle_para_cobro.txtidcontrol_de_pago.Text = datalistado.SelectedCells.Item(9).Value
        '        detalle_para_cobro.txttipodepago.Text = "COBRO BANCARIO PENDIENTE DE TRANSFERENCIA"
        '        detalle_para_cobro.CONCEPTO.Text = "VENTAS"
        '        detalle_para_cobro.ShowDialog()
        '        detalle_para_cobro.CONCEPTO.Text = "VENTAS"
        '        detalle_para_cobro.txttipodepago.Text = "COBRO BANCARIO PENDIENTE DE TRANSFERENCIA"
        '        detalle_para_cobro.txtidcontrol_de_pago.Text = datalistado.SelectedCells.Item(9).Value
        '        detalle_para_cobro.txtmontorefrencia.Text = datalistado.SelectedCells.Item(8).Value
        '    Else

        '        MessageBox.Show("Esta intentando cobrar una cuenta sin saldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '    End If
        'Catch ex As Exception

        'End Try


    End Sub

    Private Sub timerparaactualizarventanueva_Tick(sender As Object, e As EventArgs) Handles timerparaactualizarventanueva.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 10
            Panel7.Visible = True
        Else
            timerparaactualizarventanueva.Stop()
            ProgressBar1.Value = 0
            cargar_estado_de_cuenta()
            Listarmostrar_control_de_cobros_a_clientes_por_xmotivos_X_CLIENTE()
            ACTUALIZAR_ESTADO_VENTAS()
            Panel7.Visible = False
            sumartotal()
            sumartotalconceptosvarios()
            txttotal.Text = txttotal1.Text * 1 + txttotal2.Text * 1
            txttotal.Text = Format(CType(txttotal.Text, Decimal), "##0.00")
            'txtcliente.Text = "SALDO POR VENTA DE PRODUCTOS" & " (S/." & txttotal1.Text & ")"
            'Labelsaldoconceptosvarios.Text = "SALDO POR CONCEPTOS VARIOS" & " (S/." & txttotal2.Text & ")"
        End If
    End Sub
    Sub ACTUALIZAR_ESTADO_VENTAS()



        Dim cmdaumentarstock As SqlCommand
        For Each fila As DataGridViewRow In datalistadoHistorial.Rows
            fila.Cells(0).Value = True
        Next
        Try
            For Each row As DataGridViewRow In datalistadoHistorial.Rows
                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                If marcado Then

                    Dim idlote As Integer = Convert.ToInt32(row.Cells("idventa").Value)
                    Dim cantidad As Decimal = Convert.ToDouble(row.Cells("Saldo").Value)
                    Try
                        abrir()

                        cmdaumentarstock = New SqlCommand("actualizarestado_venta", conexion)
                        cmdaumentarstock.CommandType = 4
                        cmdaumentarstock.Parameters.AddWithValue("@resto", cantidad)
                        cmdaumentarstock.Parameters.AddWithValue("@idventa", idlote)
                        cmdaumentarstock.ExecuteNonQuery()
                        Cerrar()

                       

                    Catch ex As Exception : MsgBox(ex.Message)

                    End Try

                End If

            Next





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Sub insertar_detalle_cobro_a_cliente()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_DETALLE_CONTROL_DE_COBROS", conexion)
            cmd.CommandType = 4
            '            @Id_control_de_cobros int,
            '@Pago_realizado as numeric(18,2),
            '@Fecha_que_pago as datetime
            cmd.Parameters.AddWithValue("@Id_usuario", TXTIDUSUARIO.Text)
            cmd.Parameters.AddWithValue("@Pago_realizado", txtmonto.Text)
            cmd.Parameters.AddWithValue("@Fecha_que_pago", txtfecha.Value)
            cmd.Parameters.AddWithValue("@Tipo_de_cobro", "EFECTIVO")
            cmd.Parameters.AddWithValue("@idcliente", datalistadoclientes.SelectedCells.Item(2).Value)
            cmd.Parameters.AddWithValue("@Detalle", "COBRO")
            cmd.Parameters.AddWithValue("@Id_caja", VENTAS_MENU_PRINCIPAL.lblidcaja.Text)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)

        'Dim result As DialogResult
        'result = MessageBox.Show("¿Realmente desea liquidar la cuenta seleccionada?", "Liquidación de cuentas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        'If result = DialogResult.OK Then
        '    Try
        '        If txttotal.Text <> "0.00" Then
        '            detalle_liquidacion_de_cobros_a_clientes.txtmontorefrencia.Text = datalistado.SelectedCells.Item(8).Value
        '            detalle_liquidacion_de_cobros_a_clientes.txtidcontrol_de_pago.Text = datalistado.SelectedCells.Item(9).Value
        '            detalle_liquidacion_de_cobros_a_clientes.txttipodepago.Text = "COBRO BANCARIO PENDIENTE DE TRANSFERENCIA"
        '            detalle_liquidacion_de_cobros_a_clientes.ShowDialog()
        '            detalle_liquidacion_de_cobros_a_clientes.txttipodepago.Text = "COBRO BANCARIO PENDIENTE DE TRANSFERENCIA"
        '            detalle_liquidacion_de_cobros_a_clientes.txtidcontrol_de_pago.Text = datalistado.SelectedCells.Item(9).Value
        '            detalle_liquidacion_de_cobros_a_clientes.txtmontorefrencia.Text = datalistado.SelectedCells.Item(8).Value
        '        Else

        '            MessageBox.Show("Esta intentando cobrar una cuenta sin saldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '        End If
        '    Catch ex As Exception

        '    End Try

        'Else
        '    MessageBox.Show("Cancelando eliminación de registros", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'End If
    End Sub

    Private Sub datalistadoclientes_CellContextMenuStripChanged(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoclientes.CellContextMenuStripChanged

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        'Try
        '    If txttotal1.Text <> "0.00" Then
        '        detalle_para_cobro.txtmontorefrencia.Text = datalistado.SelectedCells.Item(7).Value
        '        detalle_para_cobro.txtidcontrol_de_pago.Text = datalistado.SelectedCells.Item(9).Value
        '        detalle_para_cobro.txttipodepago.Text = "EFECTIVO"
        '        detalle_para_cobro.CONCEPTO.Text = "VENTAS"
        '        detalle_para_cobro.ShowDialog()
        '        detalle_para_cobro.CONCEPTO.Text = "VENTAS"
        '        detalle_para_cobro.txttipodepago.Text = "EFECTIVO"
        '        detalle_para_cobro.txtidcontrol_de_pago.Text = datalistado.SelectedCells.Item(9).Value
        '        detalle_para_cobro.txtmontorefrencia.Text = datalistado.SelectedCells.Item(7).Value
        '    Else
        '        MessageBox.Show("Esta intentando cobrar una cuenta sin saldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)

        'Dim result As DialogResult
        'result = MessageBox.Show("¿Realmente desea liquidar la cuenta seleccionada?", "Liquidación de cuentas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        'If result = DialogResult.OK Then
        '    Try
        '        If txttotal.Text <> "0.00" Then
        '            detalle_liquidacion_de_cobros_a_clientes.txtmontorefrencia.Text = datalistado.SelectedCells.Item(8).Value
        '            detalle_liquidacion_de_cobros_a_clientes.txtidcontrol_de_pago.Text = datalistado.SelectedCells.Item(9).Value
        '            detalle_liquidacion_de_cobros_a_clientes.txttipodepago.Text = "EFECTIVO"
        '            detalle_liquidacion_de_cobros_a_clientes.ShowDialog()
        '            detalle_liquidacion_de_cobros_a_clientes.txttipodepago.Text = "EFECTIVO"
        '            detalle_liquidacion_de_cobros_a_clientes.txtidcontrol_de_pago.Text = datalistado.SelectedCells.Item(9).Value
        '            detalle_liquidacion_de_cobros_a_clientes.txtmontorefrencia.Text = datalistado.SelectedCells.Item(8).Value
        '        Else

        '            MessageBox.Show("Esta intentando cobrar una cuenta sin saldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '        End If
        '    Catch ex As Exception

        '    End Try

        'Else
        '    MessageBox.Show("Cancelando eliminación de registros", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'End If
    End Sub



    Private Sub datalistadoMovimientos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoMovimientos.CellClick
        If e.ColumnIndex = Me.datalistadoMovimientos.Columns.Item("Eli").Index Then
            Dim result As DialogResult

            result = MessageBox.Show("¿Realmente desea eliminar esta Abono?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                Dim cmd As SqlCommand
                Try
                    For Each row As DataGridViewRow In datalistadoMovimientos.SelectedRows

                        Dim onekey As Integer = Convert.ToInt32(row.Cells("Id_detalle_de_control_de_cobros").Value)
                        Try

                            Try

                                abrir()
                                cmd = New SqlCommand("aumentar_saldo_a_cliente", conexion)
                                cmd.CommandType = 4

                                cmd.Parameters.AddWithValue("@idcliente", lblidcliente.Text)
                                cmd.Parameters.AddWithValue("@Saldo", datalistadoMovimientos.SelectedCells.Item(2).Value)
                                cmd.ExecuteNonQuery()
                                Cerrar()
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            abrir()
                            cmd = New SqlCommand("eliminar_DETALLE_CONTROL_DE_COBROS", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@id", onekey)
                            cmd.ExecuteNonQuery()
                            Cerrar()
                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try

                    Next
                    Call mostrar_DETALLE_CONTROL_DE_COBROS()
                    Call Saldo()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If



        End If
    End Sub

   

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        'Try
        '    If txttotal1.Text <> "0.00" Then
        '        detalle_para_cobro.txtmontorefrencia2.Text = datalistado_saldos_conceptos_varios.SelectedCells.Item(6).Value
        '        detalle_para_cobro.txtidcontrol_de_pago.Text = datalistado_saldos_conceptos_varios.SelectedCells.Item(1).Value
        '        detalle_para_cobro.txttipodepago.Text = "EFECTIVO"
        '        detalle_para_cobro.CONCEPTO.Text = "VARIOS"


        '        detalle_para_cobro.ShowDialog()


        '        detalle_para_cobro.CONCEPTO.Text = "VARIOS"
        '        detalle_para_cobro.txttipodepago.Text = "EFECTIVO"
        '        detalle_para_cobro.txtidcontrol_de_pago.Text = datalistado_saldos_conceptos_varios.SelectedCells.Item(1).Value
        '        detalle_para_cobro.txtmontorefrencia2.Text = datalistado_saldos_conceptos_varios.SelectedCells.Item(6).Value


        '    Else

        '        MessageBox.Show("Esta intentando cobrar una cuenta sin saldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs)
        'Try
        '    If txttotal2.Text <> "0.00" Then
        '        detalle_para_cobro.txtmontorefrencia2.Text = datalistado_saldos_conceptos_varios.SelectedCells.Item(6).Value
        '        detalle_para_cobro.txtidcontrol_de_pago.Text = datalistado_saldos_conceptos_varios.SelectedCells.Item(1).Value
        '        detalle_para_cobro.txttipodepago.Text = "COBRO BANCARIO PENDIENTE DE TRANSFERENCIA"
        '        detalle_para_cobro.CONCEPTO.Text = "VARIOS"


        '        detalle_para_cobro.ShowDialog()


        '        detalle_para_cobro.CONCEPTO.Text = "VARIOS"
        '        detalle_para_cobro.txttipodepago.Text = "COBRO BANCARIO PENDIENTE DE TRANSFERENCIA"
        '        detalle_para_cobro.txtidcontrol_de_pago.Text = datalistado_saldos_conceptos_varios.SelectedCells.Item(1).Value
        '        detalle_para_cobro.txtmontorefrencia2.Text = datalistado_saldos_conceptos_varios.SelectedCells.Item(6).Value


        '    Else

        '        MessageBox.Show("Esta intentando cobrar una cuenta sin saldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '    End If
        'Catch ex As Exception

        'End Try
    End Sub



    Private Sub datalistado_saldos_conceptos_varios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub ToolStripButton1_Click_2(sender As Object, e As EventArgs)
        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistadoHistorial.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idventa").Value)
                        Dim idcliente As Integer = Convert.ToInt32(row.Cells("idclientev").Value)
                        Dim montopagado As Double = Convert.ToDouble(row.Cells("Saldo").Value)



                        abrir()
                        cmd = New SqlCommand("disminuirSaldocliente", conexion)
                        cmd.CommandType = 4

                        cmd.Parameters.AddWithValue("@Id_cliente", idcliente)
                        cmd.Parameters.AddWithValue("@montopagado", montopagado)

                        cmd.ExecuteNonQuery()
                        Cerrar()



                        Try

                            abrir()
                            cmd = New SqlCommand("eliminar_venta", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@idventa", onekey)

                            cmd.ExecuteNonQuery()


                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try
                        Cerrar()
                    End If

                Next
                cargar_estado_de_cuenta()



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

   
    Sub cobrar_a_cliente()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("disminuirSaldocliente", conexion)
            cmd.CommandType = 4

            cmd.Parameters.AddWithValue("@Id_cliente", datalistadoclientes.SelectedCells.Item(2).Value)
            cmd.Parameters.AddWithValue("@montopagado", txtmonto.Text)
            cmd.ExecuteNonQuery()
            Cerrar()
            CONVERTIR_TOTAL_A_LETRAS()
            Comprobante_de_cobro_Form.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
   
   

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub txtmonto_Click(sender As Object, e As EventArgs) Handles txtmonto.Click, TextBox1.Click
        txtmonto.Text = ""

    End Sub
    Public Sub NumerosyDecimal(ByVal CajaTexto As System.Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        ElseIf e.KeyChar = "," Then
            e.Handled = False

        Else
            e.Handled = True

        End If


    End Sub
    Private Sub txtmonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmonto.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
        
            e.KeyChar = _
                Threading.Thread.CurrentThread. _
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtmonto, e)
    End Sub

   

    Private Sub txtmonto_TextChanged(sender As Object, e As EventArgs) Handles txtmonto.TextChanged

    End Sub

    Private Sub CBXVENDEDOR_SelectedIndexChanged(sender As Object, e As EventArgs)
        With TXTIDUSUARIO
            .DataSource = DT_USUARIO
            .DisplayMember = "idUsuario"
            .ValueMember = "idUsuario"

        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)


        Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Try
            Dim montoreferencia As Double
            Dim monto As Double
            montoreferencia = txttotal_saldo.Text
            monto = txtmonto.Text
            If montoreferencia >= monto Then
                insertar_detalle_cobro_a_cliente()
                cobrar_a_cliente()

                cargar_estado_de_cuenta()



                txttotal_saldo.Text = "-"
                txtmonto.Text = "Monto"
                cargarclientes()
                Label12.Visible = True





            Else
                MsgBox("Esta intentando cobrar mas de lo que debe")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        cargar_estado_de_cuenta()
        datalistadoMovimientos.Visible = False
        datalistadoHistorial.Visible = True
        datalistadoMovimientos.Dock = DockStyle.None
        datalistadoHistorial.Dock = DockStyle.Fill
        PanelH.Visible = True
        PanelM.Visible = False
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles laber.Click
        mostrar_DETALLE_CONTROL_DE_COBROS()
        datalistadoMovimientos.Visible = True
        datalistadoHistorial.Visible = False
        datalistadoHistorial.Dock = DockStyle.None
        datalistadoMovimientos.Dock = DockStyle.Fill
        PanelH.Visible = False
        PanelM.Visible = True
    End Sub

    Private Sub MenuStrip14_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip14.ItemClicked

    End Sub



    Sub CONVERTIR_TOTAL_A_LETRAS()
        Dim numero As Integer
        numero = Int(datalistadoMovimientos.SelectedCells.Item(2).Value)
        TXTTOTAL_STRING.Text = Num2Text(numero)
        Dim a() As String
        a = Split(datalistadoMovimientos.SelectedCells.Item(2).Value, ".")
        txttotaldecimal.Text = a(1) & "0"
        txtnumeroconvertidoenletra.Text = TXTTOTAL_STRING.Text & " CON " & txttotaldecimal.Text & "/100 "

    End Sub
    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        Try


            If txtmonto.Text = "Monto a abonar" Then txtmonto.Text = 0
            If txtmonto.Text = "" Then txtmonto.Text = 0
            If txtmonto.Text > 0 Then
                Try
                    Dim montoreferencia As Double
                    Dim monto As Double
                    montoreferencia = txttotal_saldo.Text
                    monto = txtmonto.Text
                    If montoreferencia >= monto Then
                        insertar_detalle_cobro_a_cliente()
                        cobrar_a_cliente()
                        Saldo()
                        txtmonto.Text = "Monto"
                        Label12.Visible = True
                    Else
                        MessageBox.Show("El saldo debe ser Mayor a 0", "Saldo en 0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                mostrar_DETALLE_CONTROL_DE_COBROS()
                datalistadoMovimientos.Visible = True
                datalistadoHistorial.Visible = False
                datalistadoHistorial.Dock = DockStyle.None
                datalistadoMovimientos.Dock = DockStyle.Fill
                Panel17.Visible = True
                PanelH.Visible = False
                PanelM.Visible = True
                Timerocultar.Start()
            End If
        Catch ex As Exception

        End Try

    End Sub



    Private Sub datalistadoclientes_KeyDown(sender As Object, e As KeyEventArgs) Handles datalistadoclientes.KeyDown
        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True

            SendKeys.Send("{TAB}")
            If Panel10.Height = 40 Then
                Timermostrar.Start()
            End If
            Try
                datalistadoclientes.Visible = False
                cargar_estado_de_cuenta()
                txtclientesolicitante.Text = datalistadoclientes.SelectedCells.Item(1).Value
                txtcliente.Text = datalistadoclientes.SelectedCells.Item(1).Value

                datalistadoclientes.Visible = False
                cargarmonto_total_de_cliente()
                txtmonto.Text = "Monto a abonar"
                sumartotal()
                sumartotalconceptosvarios()
                txttotal.Text = txttotal1.Text * 1 + txttotal2.Text * 1
                txttotal.Text = Format(CType(txttotal.Text, Decimal), "##0.00")
                datalistadoclientes.Visible = False


                Saldo()



            Catch ex As Exception

            End Try


        End If
    End Sub

    Private Sub datalistadoMovimientos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoMovimientos.CellContentClick

    End Sub

    Private Sub TEDITAR_Click(sender As Object, e As EventArgs) Handles TEDITAR.Click
        txttotal_saldo_Editor.Visible = True
        txttotal_saldo.Visible = False
        TEDITAR.Visible = False
        TGUARDAR.Visible = True
        TCANCELAR.Visible = True
        txttotal_saldo_Editor.Text = txttotal_saldo.Text
    End Sub

    Private Sub TGUARDAR_Click(sender As Object, e As EventArgs) Handles TGUARDAR.Click

        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("editar_saldo_total", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idcliente", datalistadoclientes.SelectedCells.Item(2).Value)
            cmd.Parameters.AddWithValue("@saldo", txttotal_saldo_Editor.Text)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
        End Try


        txttotal_saldo_Editor.Visible = False
        txttotal_saldo.Visible = True
        TEDITAR.Visible = True
        TGUARDAR.Visible = False
        TCANCELAR.Visible = False
        txttotal_saldo.Text = txttotal_saldo_Editor.Text
    End Sub

    Private Sub TCANCELAR_Click(sender As Object, e As EventArgs) Handles TCANCELAR.Click
        txttotal_saldo_Editor.Visible = False
        txttotal_saldo.Visible = True
        TEDITAR.Visible = True
        TGUARDAR.Visible = False
        TCANCELAR.Visible = False
    End Sub

    Private Sub txttotal_saldo_Editor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttotal_saldo_Editor.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar = _
                Threading.Thread.CurrentThread. _
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txttotal_saldo_Editor, e)
    End Sub

    Private Sub txttotal_saldo_Editor_TextChanged(sender As Object, e As EventArgs) Handles txttotal_saldo_Editor.TextChanged

    End Sub

    Private Sub ToolStripMenuItem11_DragDrop(sender As Object, e As DragEventArgs) Handles ToolStripMenuItem11.DragDrop

    End Sub

    Private Sub TimerMOSTRAR_DESDE_REFERENCIA_Tick(sender As Object, e As EventArgs) Handles TimerMOSTRAR_DESDE_REFERENCIA.Tick
        TimerMOSTRAR_DESDE_REFERENCIA.Stop()


        lblavisoForm.Text = "MOSTRADO"
        Label12.Visible = False




        cargarclientes()
        datalistadoclientes.Visible = True

        Try

            lblidcliente.Text = datalistadoclientes.SelectedCells.Item(2).Value

            cargar_estado_de_cuenta()
            mostrar_DETALLE_CONTROL_DE_COBROS()
            txtclientesolicitante.Text = datalistadoclientes.SelectedCells.Item(1).Value
            txtcliente.Text = datalistadoclientes.SelectedCells.Item(1).Value

            cargarmonto_total_de_cliente()
            txtmonto.Text = "Monto a abonar"
            sumartotal()
            sumartotalconceptosvarios()
            txttotal.Text = txttotal1.Text * 1 + txttotal2.Text * 1
            txttotal.Text = Format(CType(txttotal.Text, Decimal), "##0.00")

            cargar_estado_de_cuenta()
            datalistadoMovimientos.Visible = False
            datalistadoHistorial.Visible = True
            datalistadoMovimientos.Dock = DockStyle.None
            datalistadoHistorial.Dock = DockStyle.Fill
            PanelH.Visible = True
            PanelM.Visible = False


            Saldo()


        Catch ex As Exception

        End Try
        datalistadoclientes.Visible = False
        txttotal_saldo_Editor.Visible = False
        txttotal_saldo.Visible = True
        TEDITAR.Visible = True
        TGUARDAR.Visible = False
        TCANCELAR.Visible = False
    End Sub

    Private Sub Panel11_Paint(sender As Object, e As PaintEventArgs) Handles Panel11.Paint

    End Sub
End Class