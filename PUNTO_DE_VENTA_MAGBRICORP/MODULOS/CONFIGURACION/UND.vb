


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

Public Class UND
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
            da = New SqlDataAdapter("mostrar_unidades", conexion)
            da.Fill(dt)
            datalistado.DataSource = dt
            contar()
            datalistado.Columns(1).Visible = False
            datalistado.Columns(3).Visible = False
            datalistado.Columns(4).Visible = False
            datalistado.Columns(2).Width = 410
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()
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
      
        TXTPRESENTACION.Text = ""
        txtidpresentacion.Text = ""


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

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        txtmsbox.Text = "Se ha activado la eliminacion de registros"
        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("Id_unidad_de_medida").Value)

                        Try

                            abrir()
                            cmd = New SqlCommand("eliminar_unidades", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@id_unidad", onekey)

                            cmd.ExecuteNonQuery()


                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try
                        Cerrar()
                    End If

                Next
                Call LIMPIAR()
                Call Listar()



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Panel2.Visible = False

        MenuStrip2.Visible = True
        datalistado.Enabled = True


        GuardarRegistroToolStripMenuItem.Visible = False
        GuardarCambiosToolStripMenuItem1.Visible = False



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

        EliminarToolStripMenuItem.Visible = True
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Listar()


        For Each fila As DataGridViewRow In datalistado.Rows
            fila.Cells(0).Value = False
        Next
        txtmsbox.Text = "Se ha habilitado la deseleccion de filas"

        EliminarToolStripMenuItem.Visible = False
        datalistado.Columns.Item("Eliminar").Visible = False

    End Sub

    Private Sub EDITARToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Panel2.Visible = True
        GuardarRegistroToolStripMenuItem.Visible = False
        GuardarCambiosToolStripMenuItem1.Visible = True
        datalistado.Enabled = False


        MenuStrip2.Visible = False

        datalistado.Enabled = False
    End Sub
    Private Sub PRESENTACIONESparaventasmenores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

        Panel2.Visible = False
        'Location
        MenuStrip4.Visible = True
        MenuStrip2.Visible = True
        datalistado.Enabled = True
        cargarcontratista()
        cargarpresentaciones()
        cargartipo()
        LIMPIAR()
        Listar()
        Listargiros()
        GuardarRegistroToolStripMenuItem.Visible = False
        GuardarCambiosToolStripMenuItem1.Visible = False


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

        EliminarToolStripMenuItem.Visible = True
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
            conn = New OleDbConnection( _
                              "Provider=Microsoft.ACE.OLEDB.12.0;" & _
                              "data source=" & ExcelFile & "; " & _
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
                Call Listar()

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

    Private Sub NuevoRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoRegistroToolStripMenuItem.Click



        GuardarRegistroToolStripMenuItem.Visible = True
        GuardarCambiosToolStripMenuItem1.Visible = False
        Panel2.Visible = True
        TXTPRESENTACION.Text = ""
        txtcantidadporunidadmedida.Text = ""

    End Sub

    Private Sub GuardarCambiosToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Function LVENDER() As Object
        Throw New NotImplementedException
    End Function
    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        Try
            txtidpresentacion.Text = datalistado.SelectedCells.Item(1).Value
            TXTPRESENTACION.Text = datalistado.SelectedCells.Item(4).Value
            txtcantidadporunidadmedida.Text = datalistado.SelectedCells.Item(3).Value



        Catch ex As Exception
        End Try

        Panel2.Visible = True
        GuardarRegistroToolStripMenuItem.Visible = False
        GuardarCambiosToolStripMenuItem1.Visible = True
        datalistado.Enabled = False


        MenuStrip2.Visible = False

        datalistado.Enabled = False
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()

    End Sub

    Private Sub ToolStripMenuItem5_Click_1(sender As Object, e As EventArgs) Handles GuardarRegistroToolStripMenuItem.Click
        Dim cmd As New SqlCommand
        If TXTPRESENTACION.Text <> "" Then
            Try

                abrir()
                cmd = New SqlCommand("insertar_unidades_de_medida", conexion)
                cmd.CommandType = 4


                cmd.Parameters.AddWithValue("@Unidad_de_medida", TXTPRESENTACION.Text)

                cmd.Parameters.AddWithValue("@Cantidad_por_unidad_de_medida", txtcantidadporunidadmedida.Text)



                cmd.ExecuteNonQuery()





                Panel2.Visible = False

                MenuStrip2.Visible = True
                datalistado.Enabled = True

                GuardarRegistroToolStripMenuItem.Visible = False
                GuardarCambiosToolStripMenuItem1.Visible = False


                Listar()

            Catch ex As Exception : MsgBox(ex.Message)
            End Try
            Listar()
            Cerrar()
            Call cargarpresentaciones()
            Panel2.Visible = False

            productosOK.Timer1.Start()
            REGISTRO_DE_RECHAZO.Timer1.Start()


            DISTRIBUCION_DE_PRODUCTOS.Timer2.Start()
            VENTAS_MENU_PRINCIPAL.Timer2.Start()
        Else
            MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles GuardarCambiosToolStripMenuItem1.Click
        Dim cmd As New SqlCommand
        If TXTPRESENTACION.Text <> "" Then
            Try

                abrir()
                cmd = New SqlCommand("editar_unidades_de_medida", conexion)
                cmd.CommandType = 4


                'TXTPRESENTACIONRESUMIDA.Text = TXTPRESENTACION.Text & " (" & txtcantidadporunidadmedida.Text & ")"
                cmd.Parameters.AddWithValue("@id_Unidad_de_medida", txtidpresentacion.Text)
                cmd.Parameters.AddWithValue("@Unidad_de_medida", TXTPRESENTACION.Text)
                cmd.Parameters.AddWithValue("@Cantidad_por_unidad_de_medida", txtcantidadporunidadmedida.Text)




                cmd.ExecuteNonQuery()






                Panel2.Visible = False

                MenuStrip2.Visible = True
                datalistado.Enabled = True


                GuardarRegistroToolStripMenuItem.Visible = False
                GuardarCambiosToolStripMenuItem1.Visible = False


                Listar()

            Catch ex As Exception : MsgBox(ex.Message)
            End Try
            Listar()
            Cerrar()
            Call cargarpresentaciones()
            Panel2.Visible = False
            productosOK.Timer1.Start()
            REGISTRO_DE_RECHAZO.Timer1.Start()
            DISTRIBUCION_DE_PRODUCTOS.Timer2.Start()
            VENTAS_MENU_PRINCIPAL.Timer2.Start()

        Else
            MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub VOLVERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VOLVERToolStripMenuItem.Click
        Panel2.Visible = False

        MenuStrip2.Visible = True
        datalistado.Enabled = True


        GuardarRegistroToolStripMenuItem.Visible = False
        GuardarCambiosToolStripMenuItem1.Visible = False

    End Sub
End Class