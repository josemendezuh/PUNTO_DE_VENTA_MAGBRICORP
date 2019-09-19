
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

Public Class clientes_PROVEEDORES
    Dim DTc As New DataTable
    Dim DTe As New DataTable
    Dim DTt As New DataTable

    Sub cargarcontratista()
        'Dim DA As SqlDataAdapter
        'Try
        '    abrir()
        '    DA = New SqlDataAdapter("SELECT * FROM Contratista", conexion)
        '    DA.Fill(DTc)
        '    txtcontratista.DisplayMember = "Contratista"
        '    txtcontratista.ValueMember = "Id_contratista"
        '    txtcontratista.DataSource = DTc
        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'Cerrar()
    End Sub

    Sub cargarpresentaciones()
        'Dim DA As SqlDataAdapter
        'Try
        '    abrir()
        '    Dim PROCECIMIENTO As String
        '    PROCECIMIENTO = "SET NOCOUNT ON SELECT DISTINCT Presentacion FROM Producto1"


        '    DA = New SqlDataAdapter(PROCECIMIENTO, conexion)
        '    DA.Fill(DTe)
        '    ''txtpresentacion.DisplayMember = "Presentacion"
        '    'txtpresentacion.ValueMember = "Presentacion"
        '    txtpresentacion.DataSource = DTe
        '    '            	
        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'Cerrar()
    End Sub
    Sub cargartipo()
        'Dim DA As SqlDataAdapter
        'Try
        '    abrir()
        '    Dim PROCECIMIENTO As String
        '    PROCECIMIENTO = "SET NOCOUNT ON SELECT DISTINCT TIPO_DE_CARTA_FIANZA FROM TABLACARTAFIANZAS"


        '    DA = New SqlDataAdapter(PROCECIMIENTO, conexion)
        '    DA.Fill(DTt)
        '    TXTTIPOCARTA.DisplayMember = "TIPO_DE_CARTA_FIANZA"
        '    TXTTIPOCARTA.ValueMember = "TIPO_DE_CARTA_FIANZA"
        '    TXTTIPOCARTA.DataSource = DTt
        '    '            	
        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'Cerrar()
    End Sub
    Sub cargaremitida()
        'Dim DA As SqlDataAdapter
        'Try
        '    abrir()
        '    Dim PROCECIMIENTO As String
        '    PROCECIMIENTO = "SET NOCOUNT ON SELECT DISTINCT EMITIDA FROM TABLACARTAFIANZAS"


        '    DA = New SqlDataAdapter(PROCECIMIENTO, conexion)
        '    DA.Fill(DTe)
        '    txtemitida.DisplayMember = "EMITIDA"
        '    'txtemitida.ValueMember = "EMITIDA"
        '    txtemitida.DataSource = DTe
        '    '            	
        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'Cerrar()
    End Sub
    Private Sub contar()
        'Dim x As Integer
        'x = datalistado.Rows.Count
        'txtcontador.Text = CStr(x)
    End Sub
    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
        datalistado.Columns(11).Visible = False
        datalistado.Columns(12).Visible = False

    End Sub



    Sub buscar_cliente_Form()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_cliente_Form", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtbusca.Text)
            da.Fill(dt)
            datalistado.DataSource = dt

            datalistado.Columns(2).Visible = False

            'datalistado.Columns(0).Width = 80
            'datalistado.Columns(1).Visible = False
            datalistado.Columns(3).Width = 400
            datalistado.Columns(4).Width = 250
            'datalistado.Columns(5).Width = 130
            'datalistado.Columns(6).Visible = False

            'datalistado.Columns(7).Visible = False
            'datalistado.Columns(8).Visible = False
            'datalistado.Columns(9).Visible = False

            contar()
        Catch ex As Exception
        End Try
        Cerrar()
        Me.datalistado.EnableHeadersVisualStyles = False

        ' estilo para las cabeceras
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.White
        styCabeceras.ForeColor = Color.Black

        styCabeceras.Font = New Font("Segoe UI", 10, FontStyle.Regular Or
        FontStyle.Bold)

        ' asignar estilo al grid
        Me.datalistado.ColumnHeadersDefaultCellStyle = styCabeceras


        For Each row As DataGridViewRow In datalistado.Rows
            If row.Cells("Estado").Value = "ELIMINADO" Then
                row.DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Strikeout Or FontStyle.Bold)
                row.DefaultCellStyle.ForeColor = Color.Red
            End If
        Next

    End Sub
    Sub buscar_proveedor_Form()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_proveedor_Form", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtbusca.Text)
            da.Fill(dt)
            datalistado.DataSource = dt
            datalistado.Columns(2).Visible = False
            datalistado.Columns(3).Width = 400
            datalistado.Columns(4).Width = 250
            datalistado.Columns(5).Visible = False

            Cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.datalistado.EnableHeadersVisualStyles = False

        ' estilo para las cabeceras
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.White
        styCabeceras.ForeColor = Color.Black
        styCabeceras.Font = New Font("Segoe UI", 10, FontStyle.Regular Or
        FontStyle.Bold)

        ' asignar estilo al grid
        Me.datalistado.ColumnHeadersDefaultCellStyle = styCabeceras
        For Each row As DataGridViewRow In datalistado.Rows
            If row.Cells("Estado").Value = "ELIMINADO" Then
                row.DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Strikeout Or FontStyle.Bold)
                row.DefaultCellStyle.ForeColor = Color.Red
            End If
        Next
    End Sub
    Sub Listargiros()
        'Dim dt As New DataTable
        'Dim da As SqlDataAdapter
        'Try
        '    abrir()
        '    da = New SqlDataAdapter("MOSTRAR_TABLAGIRO", conexion)
        '    da.Fill(dt)
        '    datalistadogiros.DataSource = dt
        '    contar()
        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'Cerrar()
    End Sub
    Sub LIMPIAR()


        txtidcliente.Text = ""
        txtnombrecliente.Text = ""
        txtdirecciondefactura.Text = ""
        txtrucdefactura.Text = ""
        GuardarCambios.Visible = False
        GuardarRegistro.Visible = True
        txtcelular.Text = ""
        If lbltipo.Text = "C" Then
            grupo_facturacion.Visible = True
        End If
        If lbltipo.Text = "P" Then
            grupo_facturacion.Visible = False
        End If

    End Sub

    'Private Sub txtEspecialidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEspecialidad.TextChanged
    '    Dim dt As New DataTable
    '    Dim da As New SqlDataAdapter("BuscarEspec", conexion)
    '    Try
    '        abrir()
    '        da.SelectCommand.CommandType = 4
    '        da.SelectCommand.Parameters.AddWithValue("@letra", txtEspecialidad.Text)
    '        da.Fill(dt)
    '        datalistado.DataSource = dt

    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Sub REGISTRAR_HISTORIAL()
        'Dim cmd As New SqlCommand
        'If txtcontador.Text <> "" Then
        '    Try

        '        abrir()
        '        cmd = New SqlCommand("insertar_Historial", conexion)
        '        cmd.CommandType = 4
        '        '               
        '        cmd.Parameters.AddWithValue("@idcontratista", txtidcontratista.Text)
        '        cmd.Parameters.AddWithValue("@idcarta", datalistado.SelectedCells.Item(1).Value)
        '        cmd.Parameters.AddWithValue("@estado", "INICIAL")
        '        cmd.Parameters.AddWithValue("@situacion ", txtsituacion.Text)
        '        cmd.Parameters.AddWithValue("@observaciones", txtobservaciones.Text)
        '        cmd.Parameters.AddWithValue("@fechaobservacion", txtfechadeobservacion.Text)
        '        cmd.Parameters.AddWithValue("@Nro_de_Renovacion", "NINGUNO")

        '        cmd.Parameters.Add("@MENSAJE", SqlDbType.VarChar, 100).Direction = 2
        '        cmd.ExecuteNonQuery()
        '        Dim MENSAJE As String = cmd.Parameters("@MENSAJE").Value.ToString
        '        MessageBox.Show(MENSAJE, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)



        '        Listar()

        '        LIMPIAR()
        '    Catch ex As Exception : MsgBox(ex.Message)
        '    End Try
        '    Cerrar()
        'Else
        '    MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar/ El aula ya fue designada un docente", "Colegio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtbusca_TextChanged(sender As Object, e As EventArgs)




    End Sub

    Private Sub BuscarPorDNIToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub datalistado_AlternatingRowsDefaultCellStyleChanged(sender As Object, e As EventArgs)
        With datalistado

            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        End With
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
                Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
                chkcell.Value = Not chkcell.Value
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idclientev").Value)

                        Try

                            abrir()
                            cmd = New SqlCommand("eliminar_cliente", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@idcliente", onekey)

                            cmd.ExecuteNonQuery()


                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try
                        Cerrar()
                    End If

                Next
                txtbusca.Text = ""
                If lbltipo.Text = "C" Then
                    buscar_cliente_Form()
                End If
                If lbltipo.Text = "P" Then
                    buscar_proveedor_Form()
                End If
                VENTAS_MENU_PRINCIPAL.TimERSTOCK.Start()
                APERTURA_DE_CREDITOS.Timer1.Start()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)



    End Sub



    Private Sub destinos_de_produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        txtbusca.Text = "Buscar..."
        txtbusca.Focus()

        If lbltipo.Text = "C" Then
            buscar_cliente_Form()
        End If
        If lbltipo.Text = "P" Then
            buscar_proveedor_Form()
        End If



    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BuscarPorNombresYApellidosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cbocampo.Text = "Codigo_interno"

    End Sub

    Private Sub txtEspecialidad_SelectedIndexChanged(sender As Object, e As EventArgs)







    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    'Private Sub txtdocente_SelectedIndexChanged(sender As Object, e As EventArgs)


    '    With txtiddocentesss
    '        .DataSource = DTd
    '        .DisplayMember = "Id_docente"
    '        .ValueMember = "Id_docente"

    '    End With

    'End Sub









    Private Sub GuardarCambiosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcontratista_SelectedIndexChanged(sender As Object, e As EventArgs)
        'With txtidcontratista
        '    .DataSource = DTc
        '    .DisplayMember = "Id_contratista"
        '    .ValueMember = "Id_contratista"

        'End With
    End Sub



    Private Sub btnactualizar_Click(sender As Object, e As EventArgs)
        cargarcontratista()

    End Sub

    Private Sub MarcacionManualToolStripMenuItem_Click(sender As Object, e As EventArgs)
        datalistado.Columns.Item("Eliminar").Visible = True


    End Sub





    Sub importarExcel(ByVal tabla As DataGridView)
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

        With myFileDialog
            .Filter = "Excel Files |*.xlsx"
            .Title = "Open File"
            .ShowDialog()
        End With
        If myFileDialog.FileName.ToString <> "" Then
            Dim ExcelFile As String = myFileDialog.FileName.ToString

            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim conn As OleDbConnection

            xSheet = InputBox("Digite el nombre de la Hoja que desea importar", "Complete")
            conn = New OleDbConnection(
                              "Provider=Microsoft.ACE.OLEDB.12.0;" &
                              "data source=" & ExcelFile & "; " &
                             "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

            Try
                da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)

                conn.Open()
                da.Fill(ds, "MyData")
                dt = ds.Tables("MyData")
                tabla.DataSource = ds
                tabla.DataMember = "MyData"
            Catch ex As Exception
                MsgBox("Inserte un nombre valido de la Hoja que desea importar", MsgBoxStyle.Information, "Informacion")
            Finally
                conn.Close()
            End Try
        End If
        MsgBox("Se ha cargado la importacion correctamente", MsgBoxStyle.Information, "Importado con exito")
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs)
        Dim result2 As DialogResult
        Dim CMD As SqlCommand
        result2 = MessageBox.Show("IMPORTAR UNA NUEVA LISTA DESDE EXCEL?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result2 = DialogResult.OK Then
            importarExcel(datalistado)
            Try
                For Each row As DataGridViewRow In datalistado.Rows


                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    For Each fila As DataGridViewRow In datalistado.Rows
                        fila.Cells(0).Value = True
                    Next
                    If marcado Then
                        Try

                            Dim FECHA As String = Convert.ToDateTime(row.Cells("FECHA").Value)
                            Dim RENDIDO As String = Convert.ToString(row.Cells("RENDIDO").Value)
                            Dim MONTO As String = Convert.ToString(row.Cells("MONTO_PENDIENTE").Value)

                            Dim IDGIRO As String = Convert.ToInt32(row.Cells("Id_Giro").Value)
                            Dim DEVOLUCION As String = Convert.ToString(row.Cells("DEVOLUCION").Value)



                            abrir()

                            CMD = New SqlCommand("INSERTAR_INSERTAR_TABLARENDICION_ANTICIPOS", conexion)
                            CMD.CommandType = CommandType.StoredProcedure
                            CMD.Parameters.AddWithValue("@FECHA", FECHA)
                            CMD.Parameters.AddWithValue("@RENDIDO", RENDIDO)
                            CMD.Parameters.AddWithValue("@MONTO_PENDIENTE", MONTO)
                            CMD.Parameters.AddWithValue("@Id_Giro", IDGIRO)
                            CMD.Parameters.AddWithValue("@DEVOLUCION", DEVOLUCION)



                            CMD.ExecuteNonQuery()
                            '              
                            'Dim MENSAJE As String = CMD.Parameters("@MENSAJE").Value.ToString
                            'MessageBox.Show(MENSAJE, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                        Catch ex As Exception
                            MsgBox(ex.Message)
                            Cerrar()
                        End Try

                    End If

                Next

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Call LIMPIAR()
        Else
            MsgBox("IMPORTANCION CANCELADA POR EL USUARIO")
        End If
    End Sub
    Private Sub GuardarRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs)






    End Sub
    Sub insertar_control_de_cobro()
        Dim cmd As New SqlCommand
        abrir()
        cmd = New SqlCommand("insertar_control_de_cobrosx", conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@idcliente", datalistado.SelectedCells.Item(1).Value)
        cmd.Parameters.AddWithValue("@monto", "0.00")
        cmd.Parameters.AddWithValue("@Concepto", "POR VENTA")
        cmd.ExecuteNonQuery()
        Cerrar()
    End Sub
    Sub insertar_control_de_pago_a_proveedores()
        Dim cmd As New SqlCommand
        abrir()
        cmd = New SqlCommand("insertar_control_de_pagos_a_proveedoresx", conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@idproveedor", datalistado.SelectedCells.Item(1).Value)
        cmd.Parameters.AddWithValue("@Concepto", "POR COMPRAS")
        cmd.Parameters.AddWithValue("@monto", "0.00")
        cmd.ExecuteNonQuery()
        Cerrar()
    End Sub

    Private Sub txtrucdefactura_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtrucdefactura_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtclientes_CheckedChanged(sender As Object, e As EventArgs)
        'txtdirecciondefactura.Visible = True
        'txtdirecciondeenvio.Visible = True
        'txtrucdefactura.Visible = True
        'Label14.Visible = True
        'Label3.Visible = True
        'Label2.Visible = True
    End Sub

    Private Sub txtproveedor_CheckedChanged(sender As Object, e As EventArgs)
        'txtdirecciondefactura.Visible = False
        'txtdirecciondeenvio.Visible = False
        'txtrucdefactura.Visible = False
        'Label14.Visible = False
        'Label3.Visible = False
        'Label2.Visible = False
    End Sub

    Private Sub datalistado_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True

            SendKeys.Send("{TAB}")
            Try
                txtidcliente.Text = datalistado.SelectedCells.Item(1).Value
                txtnombrecliente.Text = datalistado.SelectedCells.Item(2).Value
                txtdirecciondefactura.Text = datalistado.SelectedCells.Item(3).Value
                txtrucdefactura.Text = datalistado.SelectedCells.Item(4).Value

                txtcelular.Text = datalistado.SelectedCells.Item(9).Value


                LCLIENTE.Text = datalistado.SelectedCells.Item(11).Value
                LPROVEEDOR.Text = datalistado.SelectedCells.Item(12).Value

            Catch ex As Exception
            End Try


            Panelregistro.Visible = True
            GuardarRegistro.Visible = False
            GuardarCambios.Enabled = True






        End If
        If e.KeyCode = 46 Then
            e.SuppressKeyPress = True

            Dim result As DialogResult
            Dim cmd As SqlCommand
            result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                Try
                    For Each row As DataGridViewRow In datalistado.Rows
                        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                        If marcado Then
                            Dim onekey As Integer = Convert.ToInt32(row.Cells("idclientev").Value)

                            Try

                                abrir()
                                cmd = New SqlCommand("eliminar_cliente", conexion)
                                cmd.CommandType = 4
                                cmd.Parameters.AddWithValue("@idcliente", onekey)

                                cmd.ExecuteNonQuery()


                            Catch ex As Exception : MsgBox(ex.Message)

                            End Try
                            Cerrar()
                        End If

                    Next
                    Call LIMPIAR()



                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If



        End If
    End Sub

    Private Sub datalistado_KeyPress(sender As Object, e As KeyPressEventArgs)
        'If Asc(e.KeyChar) = 13 Then
        '    'If e.KeyCode = Keys.Enter Then

        '    '    e.SuppressKeyPress = True

        '    '    SendKeys.Send("{TAB}")

        '    'End If
        'End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()


    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

        Panelregistro.Visible = True






        GuardarRegistro.Visible = True
        GuardarCambios.Visible = False


        LIMPIAR()
        'mostrar()

    End Sub

    Private Sub ToolStripMenuItem5_Click_1(sender As Object, e As EventArgs) Handles GuardarRegistro.Click
        Try



            Dim cmd As New SqlCommand
            If txtnombrecliente.Text <> "" Then
                If txtdirecciondefactura.Text = "" Then txtdirecciondefactura.Text = "-"
                If txtrucdefactura.Text = "" Then txtdirecciondefactura.Text = "0"
                If txtcelular.Text = "" Then txtdirecciondefactura.Text = "0"

                abrir()
                cmd = New SqlCommand("insertar_cliente", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Nombre", txtnombrecliente.Text)
                cmd.Parameters.AddWithValue("@Direccion_para_factura", txtdirecciondefactura.Text)
                cmd.Parameters.AddWithValue("@Ruc ", txtrucdefactura.Text)
                cmd.Parameters.AddWithValue("@movil", txtcelular.Text)
                If lbltipo.Text = "C" Then
                    cmd.Parameters.AddWithValue("@Cliente ", "SI")
                    cmd.Parameters.AddWithValue("@Proveedor", "NO")
                End If
                If lbltipo.Text = "P" Then
                    cmd.Parameters.AddWithValue("@Cliente ", "NO")
                    cmd.Parameters.AddWithValue("@Proveedor", "SI")
                End If
                cmd.Parameters.AddWithValue("@Estado", "ACTIVO")
                cmd.Parameters.AddWithValue("@Saldo", 0)
                cmd.ExecuteNonQuery()
                Cerrar()
                txtbusca.Text = txtnombrecliente.Text
                If lbltipo.Text = "C" Then
                    buscar_cliente_Form()
                End If
                If lbltipo.Text = "P" Then
                    buscar_proveedor_Form()
                End If
                Panelregistro.Visible = False


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles GuardarCambios.Click
        Try
            Dim cmd As New SqlCommand
            If txtnombrecliente.Text <> "" Then

                If txtdirecciondefactura.Text = "" Then txtdirecciondefactura.Text = "-"
                If txtrucdefactura.Text = "" Then txtdirecciondefactura.Text = "0"
                If txtcelular.Text = "" Then txtdirecciondefactura.Text = "0"
                abrir()
                cmd = New SqlCommand("editar_cliente", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@idcliente", txtidcliente.Text)
                cmd.Parameters.AddWithValue("@Nombre", txtnombrecliente.Text)
                cmd.Parameters.AddWithValue("@Direccion_para_factura", txtdirecciondefactura.Text)
                cmd.Parameters.AddWithValue("@Ruc ", txtrucdefactura.Text)
                cmd.Parameters.AddWithValue("@movil", txtcelular.Text)
                cmd.ExecuteNonQuery()
                LIMPIAR()
                Panelregistro.Visible = False


                Cerrar()
                txtbusca.Text = txtnombrecliente.Text
                If lbltipo.Text = "C" Then
                    buscar_cliente_Form()
                End If
                If lbltipo.Text = "P" Then
                    buscar_proveedor_Form()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub VOLVERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VOLVERToolStripMenuItem.Click
        Panelregistro.Visible = False

    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panelregistro_Paint(sender As Object, e As PaintEventArgs) Handles Panelregistro.Paint

    End Sub

    Private Sub datalistado_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblcp_Click(sender As Object, e As EventArgs) Handles lblcp.Click


    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panelregistro.Visible = True
        GuardarRegistro.Visible = True
        GuardarCambios.Visible = False
        LIMPIAR()
        txtbusca.Clear()
        txtnombrecliente.Focus()

    End Sub

    Private Sub txtbusca_TextChanged_1(sender As Object, e As EventArgs) Handles txtbusca.TextChanged
        If lbltipo.Text = "C" Then
            buscar_cliente_Form()
        End If
        If lbltipo.Text = "P" Then
            buscar_proveedor_Form()
        End If
    End Sub

    Private Sub datalistado_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub
    Sub obtener_datos()
        Try
            txtidcliente.Text = datalistado.SelectedCells.Item(2).Value
            txtnombrecliente.Text = datalistado.SelectedCells.Item(3).Value
            txtcelular.Text = datalistado.SelectedCells.Item(4).Value
            txtrucdefactura.Text = datalistado.SelectedCells.Item(5).Value

            txtdirecciondefactura.Text = datalistado.SelectedCells.Item(6).Value
            txtestado.Text = datalistado.SelectedCells.Item(7).Value

            If lbltipo.Text = "C" Then

                grupo_facturacion.Visible = True
            End If
            If lbltipo.Text = "P" Then

                grupo_facturacion.Visible = False
            End If

            GuardarRegistro.Visible = False
            GuardarCambios.Visible = True

            If txtestado.Text = "ELIMINADO" Then
                RESTAURAR_DATOS_ELIMINADOS()
            Else
                Panelregistro.Visible = True
            End If


        Catch ex As Exception
        End Try

    End Sub
    Sub RESTAURAR_DATOS_ELIMINADOS()
        Dim result As DialogResult
        result = MessageBox.Show("Este Cliente se Elimino. ¿Desea Volver a Habilitarlo?", "Restaurando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Dim cmd As SqlCommand
            Try
                For Each row As DataGridViewRow In datalistado.SelectedRows
                    Dim onekey As Integer = Convert.ToInt32(row.Cells("idclientev").Value)
                    Try
                        Try
                            abrir()
                            cmd = New SqlCommand("restaurar_cliente", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@idcliente", onekey)
                            cmd.ExecuteNonQuery()
                            Cerrar()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Catch ex As Exception : MsgBox(ex.Message)
                    End Try
                Next
                If lbltipo.Text = "C" Then
                    buscar_cliente_Form()
                End If
                If lbltipo.Text = "P" Then
                    buscar_proveedor_Form()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else


        End If
    End Sub
    Sub ELIMINAR_CLIENTES_PROVEEDORES()
        Dim result As DialogResult
        result = MessageBox.Show("¿Realmente desea eliminar este Producto?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Dim cmd As SqlCommand
            Try
                For Each row As DataGridViewRow In datalistado.SelectedRows
                    Dim onekey As Integer = Convert.ToInt32(row.Cells("idclientev").Value)
                    Try
                        Try
                            abrir()
                            cmd = New SqlCommand("eliminar_cliente", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@idcliente", onekey)
                            cmd.ExecuteNonQuery()
                            Cerrar()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Catch ex As Exception : MsgBox(ex.Message)
                    End Try
                Next
                If lbltipo.Text = "C" Then
                    buscar_cliente_Form()
                End If
                If lbltipo.Text = "P" Then
                    buscar_proveedor_Form()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
        End If
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            ELIMINAR_CLIENTES_PROVEEDORES()
            If lbltipo.Text = "C" Then
                buscar_cliente_Form()
            End If
            If lbltipo.Text = "P" Then
                buscar_proveedor_Form()
            End If
        End If



        If e.ColumnIndex = Me.datalistado.Columns.Item("Editar").Index Then
            obtener_datos()
        End If
    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        obtener_datos()
    End Sub

    Private Sub txtbusca_Click(sender As Object, e As EventArgs) Handles txtbusca.Click
        txtbusca.SelectAll()

    End Sub
End Class