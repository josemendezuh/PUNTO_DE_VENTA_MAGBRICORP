


Imports System.Data.SqlClient
Imports System.Data
Imports System
Imports System.ComponentModel

Public Class SERIALIZACION
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
        Dim x As Integer
        x = datalistado.Rows.Count
        txtcontador.Text = CStr(x)
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
    End Sub


    Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_Tipo_de_documentos_para_insertar_estos_mismos", conexion)
            da.Fill(dt)
            datalistado.DataSource = dt
            contar()
            'datalistado.Columns(1).Visible = False
            'datalistado.Columns(6).Visible = False
            'datalistado.Columns(7).Visible = False
            'datalistado.Columns(2).Width = 270
            'datalistado.Columns(3).Width = 75
            datalistado.Columns(1).Visible = False
            datalistado.Columns(2).Visible = False
            datalistado.Columns(3).Visible = False

            datalistado.Columns(4).Visible = False
            datalistado.Columns(5).Width = 220
            datalistado.Columns(6).Width = 520
            'datalistado.Columns(9).Visible = False
        Catch ex As Exception : MessageBox.Show(ex.Message)
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


    End Sub
    'Private Sub ZoomToImage(ByVal sender As Object ByVal e As EventArgs) Handles Button4.Click


    '    For Each column As DataGridViewImageColumn _
    '        In datalistado.Columns
    '        column.ImageLayout = DataGridViewImageCellLayout.Zoom
    '        column.Description = "Zoomed image layout"
    '    Next
    'End Sub
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







    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick

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



    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Panel2.Visible = False

        MenuStrip2.Visible = True
        datalistado.Enabled = True


        GUARDARCAMBIOS.Visible = False



    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        Listar()

    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click

        Listar()


        For Each fila As DataGridViewRow In datalistado.Rows
            fila.Cells(0).Value = True
        Next
        txtmsbox.Text = "Se ha activado seleccionar todas las filas"
        datalistado.Columns.Item("Eliminar").Visible = True

    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Listar()


        For Each fila As DataGridViewRow In datalistado.Rows
            fila.Cells(0).Value = False
        Next
        txtmsbox.Text = "Se ha habilitado la deseleccion de filas"

        datalistado.Columns.Item("Eliminar").Visible = False

    End Sub

    Private Sub EDITARToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Panel2.Visible = True
        GUARDARCAMBIOS.Visible = True
        datalistado.Enabled = False


        MenuStrip2.Visible = False

        datalistado.Enabled = False
    End Sub
    Sub cargar_cajas_assignadas_a_pc()
        'Dim DA As SqlDataAdapter
        'Dim dtcaja As New DataTable
        'Try
        '    abrir()
        '    DA = New SqlDataAdapter("mostrar_cajas_por_empresa", conexion)
        '    DA.SelectCommand.CommandType = 4
        '    DA.SelectCommand.Parameters.AddWithValue("@empresa", MENUPRINCIPAL.cbxempresa.Text)
        '    DA.SelectCommand.Parameters.AddWithValue("@ip", CONTROL_TOTAL.TXTIP2.Text)
        '    DA.Fill(dtcaja)
        '    txtcaja.DisplayMember = "Descripcion"
        '    txtcaja.ValueMember = "Id_Caja"
        '    txtcaja.DataSource = dtcaja



        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'Cerrar()
    End Sub
    Private Sub EMPRESA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

        Panel2.Visible = False

        MenuStrip2.Visible = True
        datalistado.Enabled = True




        Listar()
        Listargiros()
        GUARDARCAMBIOS.Visible = False



    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub txtEspecialidad_SelectedIndexChanged(sender As Object, e As EventArgs)







    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

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

    Private Sub MarcacionManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcacionManualToolStripMenuItem.Click
        datalistado.Columns.Item("Eliminar").Visible = True

    End Sub









    Private Sub GuardarRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NuevoRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub GuardarCambiosToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Function LVENDER() As Object
        Throw New NotImplementedException
    End Function

    Private Sub datalistado_CellContextMenuStripNeeded(sender As Object, e As DataGridViewCellContextMenuStripNeededEventArgs) Handles datalistado.CellContextMenuStripNeeded

    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs)


    End Sub



    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VOLVERToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Panel2.Visible = False

        MenuStrip2.Visible = True
        datalistado.Enabled = True


        GUARDARCAMBIOS.Visible = False

    End Sub



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub



    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub si_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub no_CheckedChanged(sender As Object, e As EventArgs)

    End Sub


































    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


        'If CONTROL_TOTAL.txtadmin.Text = "SI" Then


        txtmsbox.Text = "Se ha activado la eliminacion de registros"
        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.SelectedRows
                    'Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    'datalistado.Rows.Remove(datalistado.CurrentRow)


                    'If datalistado.SelectedCells.Item(6).Value Then
                    Dim onekey As Integer = Convert.ToInt32(row.Cells("Id_serializacion").Value)

                    Try

                        abrir()
                        cmd = New SqlCommand("eliminar_Serializacion", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@id", onekey)

                        cmd.ExecuteNonQuery()


                    Catch ex As Exception : MsgBox(ex.Message)

                    End Try
                    Cerrar()
                    'End If

                Next
                Call Listar()




            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else

        End If
        'ElseIf CONTROL_TOTAL.txtadmin.Text = "NO" Then
        'MsgBox("NO TIENES PERMISOS de Admin,Contacta al Administrador")

        'End If
    End Sub

    Private Sub MenuStrip9_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub


    Private Sub txtporcentaje_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtporcentaje_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub txtempresa_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub txtempresa_TextChanged(sender As Object, e As EventArgs)
        'If txtempresa.Text = "" Then
        '    txtempresa.Text = "NOMBRE DE TU EMPRESA"
        'End If




    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        Panel2.Visible = True
        Try
            TXTCOMPRO.Text = datalistado.SelectedCells.Item(6).Value

            TXTCANTIDADDECEROS.Text = datalistado.SelectedCells.Item(2).Value
            txtnumerofin.Text = datalistado.SelectedCells.Item(3).Value
            txtSerie.Text = datalistado.SelectedCells.Item(1).Value
            GUARDAR.Visible = False
            GUARDARCAMBIOS.Visible = True
            If datalistado.SelectedCells.Item(7).Value = "SI" Then
                checkDefecto.Visible = False
                checkDefecto.Checked = True
            Else
                checkDefecto.Visible = True
                checkDefecto.Checked = False


            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub datalistado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles datalistado.KeyPress

    End Sub



    Private Sub datalistadocajas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub




    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Panel2.Visible = False
        Listar()

    End Sub





    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint

    End Sub




    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        ELEJIR_POR_DEFECTO()

        Try



            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_Serializacion", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Serie", txtSerie.Text)
            cmd.Parameters.AddWithValue("@numeroinicio", TXTCANTIDADDECEROS.Text)
            cmd.Parameters.AddWithValue("@numerofin", txtnumerofin.Text)
            cmd.Parameters.AddWithValue("@Destino", "VENTAS")
            cmd.Parameters.AddWithValue("@Id_tipodoc", TXTCOMPRO.Text)
            cmd.Parameters.AddWithValue("@Por_defecto", "-")
            cmd.ExecuteNonQuery()
            Cerrar()
            Listar()
            Panel2.Visible = False



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel2.Visible = True
        GUARDAR.Visible = True
        GUARDARCAMBIOS.Visible = False
    End Sub

    Private Sub VOLVEROK_Click(sender As Object, e As EventArgs) Handles VOLVEROK.Click
        Panel2.Visible = False
        ELEJIR_POR_DEFECTO()
    End Sub

    Private Sub GUARDARCAMBIOS_Click(sender As Object, e As EventArgs) Handles GUARDARCAMBIOS.Click
        ELEJIR_POR_DEFECTO()

        Try


            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("editar_serializacion", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Serie", txtSerie.Text)
            cmd.Parameters.AddWithValue("@Cantidad_de_numeros", TXTCANTIDADDECEROS.Text)
            cmd.Parameters.AddWithValue("@numerofin", txtnumerofin.Text)
            cmd.Parameters.AddWithValue("@Tipo", TXTCOMPRO.Text)
            cmd.Parameters.AddWithValue("@Id_serie", datalistado.SelectedCells.Item(4).Value)
            cmd.ExecuteNonQuery()
            Cerrar()
            Listar()
            Panel2.Visible = False


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtnumeroinicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCANTIDADDECEROS.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(TXTCANTIDADDECEROS, e)
    End Sub






    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs)

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


    Private Sub txtprecio_descuento_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub txtnumeroinicio_TextChanged(sender As Object, e As EventArgs) Handles TXTCANTIDADDECEROS.TextChanged

    End Sub

    Private Sub txtnumerofin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumerofin.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtnumerofin, e)
    End Sub

    Private Sub txtnumerofin_TextChanged(sender As Object, e As EventArgs) Handles txtnumerofin.TextChanged

    End Sub

    Private Sub txtserie_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Sub ELEJIR_POR_DEFECTO()
        If checkDefecto.Checked = True Then
            Try
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("editar_serializacion_POR_DEFECTO", conexion)
                cmd.CommandType = 4

                cmd.Parameters.AddWithValue("@Id_serie", datalistado.SelectedCells.Item(4).Value)
                cmd.ExecuteNonQuery()
                Cerrar()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub checkDefecto_CheckedChanged(sender As Object, e As EventArgs) Handles checkDefecto.CheckedChanged




    End Sub

    Private Sub SERIALIZACION_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ELEJIR_POR_DEFECTO()
    End Sub
End Class