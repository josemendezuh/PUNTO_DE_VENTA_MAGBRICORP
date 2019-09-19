
Imports System.Text.RegularExpressions

Imports System.Net
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
Imports System.Management

Imports System.AppDomainManagerInitializationOptions
Imports System.MarshalByRefObject
Imports System.Configuration

Public Class EMPRESA_CONFIG
    Dim DTc As New DataTable
    Dim DTe As New DataTable
    Dim DTt As New DataTable
    Private MisDiscos As New ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard")
    Private DiscInfo As New ManagementObject

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
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
    End Sub

    Sub mostrar_cajas_por_empresa()

    End Sub
    Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_Empresa", conexion)
            da.Fill(dt)
            datalistado.DataSource = dt
            contar()
            'datalistado.Columns(1).Visible = False
            'datalistado.Columns(2).Width = 170
            'datalistado.Columns(5).Width = 75
            'datalistado.Columns(3).Width = 75
            'datalistado.Columns(4).Width = 70
            'datalistado.Columns(9).Visible = False
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try

        'CType(datalistado.Columns("Logo"), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom

        'Me.datalistado.EnableHeadersVisualStyles = False

        '' estilo para las cabeceras
        'Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        'styCabeceras.BackColor = Color.White
        'styCabeceras.ForeColor = Color.Black
        'styCabeceras.Font = New Font("Segoe UI", 10, FontStyle.Regular Or
        'FontStyle.Bold)

        '' asignar estilo al grid
        'Me.datalistado.ColumnHeadersDefaultCellStyle = styCabeceras


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
    Sub LIMPIAR()

        txtempresa.Text = ""


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







    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs)

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

        datalistado.Enabled = True


        GUARDARCAMBIOS.Visible = False



    End Sub






    Private Sub EDITARToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Panel2.Visible = True
        GUARDARCAMBIOS.Visible = True
        datalistado.Enabled = False



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
    Sub mostrar_cajas_por_SERIAL()
        Dim MiInfo = From Hd As ManagementObject In MisDiscos.Get Select Hd
        DiscInfo = MiInfo(0)
        lblIDSERIAL.Text = DiscInfo.Properties("SerialNumber").Value
        Try
            Dim dt As New DataTable
            Dim da As SqlDataAdapter
            Try
                abrir()
                da = New SqlDataAdapter("mostrar_cajas_por_empresa_por_serial", conexion)
                da.SelectCommand.CommandType = 4
                da.SelectCommand.Parameters.AddWithValue("@serial", lblIDSERIAL.Text)
                da.Fill(dt)
                datalistadocajas.DataSource = dt

                Cerrar()

            Catch ex As Exception
                '
            End Try


        Catch ex As Exception

        End Try
    End Sub
    Private Sub EMPRESA_CONFIG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

        Listar()
        mostrar_cajas_por_SERIAL()

        Try
            txtcaja.Text = datalistadocajas.SelectedCells.Item(2).Value

        Catch ex As Exception

        End Try
        Try
            txtidempresa.Text = datalistado.SelectedCells.Item(5).Value
            If datalistado.SelectedCells.Item(8).Value = "LECTORA" Then
                TXTCON_LECTORA.Checked = True
            End If
            If datalistado.SelectedCells.Item(8).Value = "TECLADO" Then
                txtteclado.Checked = True
            End If
            Imagenproducto.BackgroundImage = Nothing
            Dim b() As Byte = datalistado.SelectedCells.Item(1).Value
            Dim ms As New IO.MemoryStream(b)
            Imagenproducto.Image = Image.FromStream(ms)
            Imagenproducto.SizeMode = PictureBoxSizeMode.StretchImage
            txtempresa.Text = datalistado.SelectedCells.Item(2).Value
            txtcorreo.Text = datalistado.SelectedCells.Item(11).Value
            TXTTRABAJASCONIMPUESTOS.Text = datalistado.SelectedCells.Item(9).Value
            If TXTTRABAJASCONIMPUESTOS.Text = "SI" Then
                si.Checked = True

            End If
            If TXTTRABAJASCONIMPUESTOS.Text = "NO" Then
                no.Checked = True

            End If
            txtporcentaje.Text = datalistado.SelectedCells.Item(6).Value
            txtimpuesto.Text = datalistado.SelectedCells.Item(7).Value
            TXTMONEDA.Text = datalistado.SelectedCells.Item(4).Value
            txtruta.Text = datalistado.SelectedCells.Item(12).Value


            LBLEstadoRedondeo.Text = datalistado.SelectedCells.Item(13).Value


            If LBLEstadoRedondeo.Text = "SI" Then
                PREDONDEAROK.BackColor = Color.FromArgb(255, 204, 0)
                PNOREDONDEAROK.BackColor = Color.White
            ElseIf LBLEstadoRedondeo.Text = "NO" Then
                PNOREDONDEAROK.BackColor = Color.FromArgb(255, 204, 0)
                PREDONDEAROK.BackColor = Color.White
            End If

        Catch ex As Exception
        End Try
        Panel2.Visible = True


    End Sub
    Sub contar_empresas()
        Dim x As Integer
        x = datalistado_empresas_nuevas.Rows.Count
        txtcontador_empresas.Text = CStr(x)

    End Sub
    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub txtEspecialidad_SelectedIndexChanged(sender As Object, e As EventArgs)







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

    Private Sub NuevoRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub GuardarCambiosToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Function LVENDER() As Object
        Throw New NotImplementedException
    End Function

    Private Sub datalistado_CellContextMenuStripNeeded(sender As Object, e As DataGridViewCellContextMenuStripNeededEventArgs)

    End Sub
    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        'If CONTROL_TOTAL.txtadmin.Text = "SI" Then

        txtidempresa.Text = datalistado.SelectedCells.Item(6).Value
        If datalistado.SelectedCells.Item(9).Value = "LECTORA" Then
            TXTCON_LECTORA.Checked = True
        End If
        If datalistado.SelectedCells.Item(9).Value = "TECLADO" Then
            txtteclado.Checked = True
        End If
        mostrar_cajas_por_empresa()

        GUARDAR.Visible = False


        Try
            Imagenproducto.BackgroundImage = Nothing
            Dim b() As Byte = datalistado.SelectedCells.Item(1).Value
            Dim ms As New IO.MemoryStream(b)
            Imagenproducto.Image = Image.FromStream(ms)
            Imagenproducto.SizeMode = PictureBoxSizeMode.StretchImage
            txtempresa.Text = datalistado.SelectedCells.Item(2).Value

            TXTTRABAJASCONIMPUESTOS.Text = datalistado.SelectedCells.Item(9).Value
            If TXTTRABAJASCONIMPUESTOS.Text = "SI" Then
                si.Checked = True

            End If
            If TXTTRABAJASCONIMPUESTOS.Text = "NO" Then
                no.Checked = True

            End If
            txtporcentaje.Text = datalistado.SelectedCells.Item(7).Value
            txtimpuesto.Text = datalistado.SelectedCells.Item(8).Value
            TXTMONEDA.Text = datalistado.SelectedCells.Item(4).Value


        Catch ex As Exception
        End Try
        Panel2.Visible = True
        'ElseIf CONTROL_TOTAL.txtadmin.Text = "NO" Then
        'MsgBox("NO TIENES PERMISOS de Admin,Contacta al Administrador")

        'End If
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ToolStripMenuItem5_Click_1(sender As Object, e As EventArgs)
        Dim cmd As New SqlCommand
        If txtempresa.Text <> "" Then
            Try

                abrir()
                cmd = New SqlCommand("insertar_Empresa", conexion)
                cmd.CommandType = 4


                cmd.Parameters.AddWithValue("@Nombre_Empresa", txtempresa.Text)

                Dim ms As New IO.MemoryStream()
                If Not Imagenproducto.Image Is Nothing Then
                    Imagenproducto.Image.Save(ms, Imagenproducto.Image.RawFormat)
                Else
                    Imagenproducto.Image = My.Resources.candado
                    Imagenproducto.Image.Save(ms, Imagenproducto.Image.RawFormat)
                End If
                cmd.Parameters.AddWithValue("@logo", ms.GetBuffer)


                cmd.ExecuteNonQuery()





                Panel2.Visible = False

                datalistado.Enabled = True

                GUARDARCAMBIOS.Visible = False


                Listar()

            Catch ex As Exception : MsgBox(ex.Message)
            End Try

            Cerrar()

            Panel2.Visible = False

        Else
            MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VOLVERToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Panel2.Visible = False

        datalistado.Enabled = True


        GUARDARCAMBIOS.Visible = False

    End Sub

    Private Sub ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs)
        If dlg.ShowDialog() = DialogResult.OK Then
            Imagenproducto.BackgroundImage = Nothing
            Imagenproducto.Image = New Bitmap(dlg.FileName)
            Imagenproducto.SizeMode = PictureBoxSizeMode.Zoom

        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click_1(sender As Object, e As EventArgs)
        Imagenproducto.Image = Nothing
        Imagenproducto.BackgroundImage = My.Resources.candado
        Imagenproducto.SizeMode = PictureBoxSizeMode.Zoom
    End Sub




    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Imagenproducto_MouseMove(sender As Object, e As MouseEventArgs) Handles Imagenproducto.MouseMove
        lbleditarLogo.Visible = True

    End Sub
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        lbleditarLogo.Visible = False
    End Sub
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub si_CheckedChanged(sender As Object, e As EventArgs) Handles si.CheckedChanged
        Panel11.Visible = True

    End Sub

    Private Sub no_CheckedChanged(sender As Object, e As EventArgs) Handles no.CheckedChanged
        Panel11.Visible = False
    End Sub
    Sub ingresar_empresa()
        Dim cmd As New SqlCommand
        If txtempresa.Text <> "" Then
            Try
                If no.Checked = True Then
                    TXTTRABAJASCONIMPUESTOS.Text = "NO"

                End If
                If si.Checked = True Then
                    TXTTRABAJASCONIMPUESTOS.Text = "SI"

                End If
                abrir()
                cmd = New SqlCommand("insertar_Empresa", conexion)
                cmd.CommandType = 4


                cmd.Parameters.AddWithValue("@Nombre_Empresa", txtempresa.Text)
                cmd.Parameters.AddWithValue("@Impuesto", txtimpuesto.Text)
                cmd.Parameters.AddWithValue("@Porcentaje_impuesto", txtporcentaje.Text)
                cmd.Parameters.AddWithValue("@Moneda", TXTMONEDA.Text)

                cmd.Parameters.AddWithValue("@Trabajas_con_impuestos", TXTTRABAJASCONIMPUESTOS.Text)
                '                @logo as image,
                '@Impuesto varchar(50),
                '@Porcentaje_impuesto numeric(18,2),
                '@Moneda varchar(50),
                '@Saldo numeric(18,2)
                Dim ms As New IO.MemoryStream()
                If Not Imagenproducto.Image Is Nothing Then
                    Imagenproducto.Image.Save(ms, Imagenproducto.Image.RawFormat)
                Else
                    Imagenproducto.Image = My.Resources.candado
                    Imagenproducto.Image.Save(ms, Imagenproducto.Image.RawFormat)
                End If
                cmd.Parameters.AddWithValue("@logo", ms.GetBuffer)
                If TXTCON_LECTORA.Checked = True Then
                    cmd.Parameters.AddWithValue("@Modo_de_busqueda", "LECTORA")
                End If
                If txtteclado.Checked = True Then
                    cmd.Parameters.AddWithValue("@Modo_de_busqueda", "TECLADO")
                End If


                cmd.ExecuteNonQuery()

                Cerrar()





            Catch ex As Exception : MsgBox(ex.Message)
            End Try





        Else
            MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Sub mostrar_empresas_nuevas()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("select * from Empresa", conexion)
            da.Fill(dt)
            datalistado_EMPRESASNUEVAS.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try




    End Sub
    Private Sub VentasToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles GUARDAR.Click

    End Sub

    Private Sub ToolStripMenuItem4_Click_1(sender As Object, e As EventArgs)
        If dlg.ShowDialog() = DialogResult.OK Then
            Imagenproducto.BackgroundImage = Nothing
            Imagenproducto.Image = New Bitmap(dlg.FileName)
            Imagenproducto.SizeMode = PictureBoxSizeMode.Zoom

        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click_2(sender As Object, e As EventArgs)
        Imagenproducto.Image = Nothing
        Imagenproducto.BackgroundImage = My.Resources.candado
        Imagenproducto.SizeMode = PictureBoxSizeMode.Zoom
    End Sub



    Private Sub MenuStrip9_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ToolStripMenuItem20_Click(sender As Object, e As EventArgs)
        Panel3.Visible = True

        GUARDARCAMBIOS.Visible = False

    End Sub

    Private Sub ToolStripMenuItem2_Click_2(sender As Object, e As EventArgs) Handles VOLVEROK.Click
        Panel3.Visible = False

    End Sub

    Private Sub txtporcentaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtporcentaje.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtporcentaje_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtporcentaje.SelectedIndexChanged

    End Sub

    Private Sub txtempresa_Click(sender As Object, e As EventArgs) Handles txtempresa.Click

        lblempresa.Visible = True

    End Sub

    Private Sub txtempresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtempresa.KeyPress

    End Sub

    Private Sub txtempresa_TextChanged(sender As Object, e As EventArgs) Handles txtempresa.TextChanged




    End Sub

    Private Sub ToolStripMenuItem1_Click_2(sender As Object, e As EventArgs)


    End Sub

    Private Sub datalistado_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub GuardarCambiosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles GUARDARCAMBIOS.Click
        Dim cmd As New SqlCommand
        If txtcaja.Text <> "" Then
            Try


                abrir()
                cmd = New SqlCommand("editar_caja", conexion)
                cmd.CommandType = 4


                cmd.Parameters.AddWithValue("@descripcion", txtcaja.Text)
                cmd.Parameters.AddWithValue("@idcaja", datalistadocajas.SelectedCells.Item(1).Value)



                cmd.ExecuteNonQuery()

                Cerrar()

                Panel3.Visible = False
                mostrar_cajas_por_empresa()

            Catch ex As Exception
                ': MsgBox(ex.Message)
            End Try



        Else
            MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Seguir_agregando_cajas_Click(sender As Object, e As EventArgs)
        Dim cmd As New SqlCommand
        If txtcaja.Text <> "" Then
            Try
                If no.Checked = True Then
                    txtimpuesto.Text = "NINGUNO"
                    txtporcentaje.Text = 0
                End If


                abrir()
                cmd = New SqlCommand("Insertar_caja", conexion)
                cmd.CommandType = 4


                cmd.Parameters.AddWithValue("@descripcion", txtcaja.Text)
                cmd.Parameters.AddWithValue("@saldo", 0)
                cmd.Parameters.AddWithValue("@Id_empresa", txtidempresa.Text)
                cmd.Parameters.AddWithValue("@PC_Asignada", "NINGUNA")
                cmd.Parameters.AddWithValue("@IP", "NINGUNA")


                cmd.ExecuteNonQuery()

                Cerrar()

                mostrar_cajas_por_empresa()


                Panel3.Visible = False

            Catch ex As Exception
                ': MsgBox(ex.Message)
            End Try



        Else
            MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub datalistadocajas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadocajas.CellContentClick

    End Sub



    Private Sub btn_insertar_Click(sender As Object, e As EventArgs)
        Dim cmd As New SqlCommand
        If txtempresa.Text <> "" Then
            Try
                If no.Checked = True Then
                    TXTTRABAJASCONIMPUESTOS.Text = "NO"

                End If
                If si.Checked = True Then
                    TXTTRABAJASCONIMPUESTOS.Text = "SI"

                End If
                abrir()
                cmd = New SqlCommand("editar_Empresa", conexion)
                cmd.CommandType = 4

                cmd.Parameters.AddWithValue("@Id_empresa", datalistado.SelectedCells.Item(6).Value)
                cmd.Parameters.AddWithValue("@Nombre_Empresa", txtempresa.Text)
                cmd.Parameters.AddWithValue("@Impuesto", txtimpuesto.Text)
                cmd.Parameters.AddWithValue("@Porcentaje_impuesto", txtporcentaje.Text)
                cmd.Parameters.AddWithValue("@Moneda", TXTMONEDA.Text)
                cmd.Parameters.AddWithValue("@Trabajas_con_impuestos", TXTTRABAJASCONIMPUESTOS.Text)
                '                @logo as image,
                '@Impuesto varchar(50),
                '@Porcentaje_impuesto numeric(18,2),
                '@Moneda varchar(50),
                '@Saldo numeric(18,2)
                Dim ms As New IO.MemoryStream()
                If Not Imagenproducto.Image Is Nothing Then
                    Imagenproducto.Image.Save(ms, Imagenproducto.Image.RawFormat)
                Else
                    Imagenproducto.Image = My.Resources.candado
                    Imagenproducto.Image.Save(ms, Imagenproducto.Image.RawFormat)
                End If
                cmd.Parameters.AddWithValue("@logo", ms.GetBuffer)
                If TXTCON_LECTORA.Checked = True Then
                    cmd.Parameters.AddWithValue("@Modo_de_busqueda", "LECTORA")
                End If
                If txtteclado.Checked = True Then
                    cmd.Parameters.AddWithValue("@Modo_de_busqueda", "TECLADO")
                End If

                cmd.ExecuteNonQuery()

                Cerrar()
                Listar()
                Panel2.Visible = False

            Catch ex As Exception : MsgBox(ex.Message)
            End Try





        Else
            MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs)
        Panel2.Visible = False
        Listar()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistadocajas.SelectedRows
                    'Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    'datalistado.Rows.Remove(datalistado.CurrentRow)


                    'If datalistado.SelectedCells.Item(6).Value Then
                    Dim onekey As Integer = Convert.ToInt32(row.Cells("Id_Caja").Value)

                    Try

                        abrir()
                        cmd = New SqlCommand("eliminar_caja", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@id", onekey)

                        cmd.ExecuteNonQuery()


                    Catch ex As Exception : MsgBox(ex.Message)

                    End Try
                    Cerrar()
                    'End If

                Next

                Call mostrar_cajas_por_empresa()




            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub


    Private Sub contarcajas()
        Dim x As Integer
        x = datalistadocajas.Rows.Count
        txtcontadorcajas.Text = CStr(x)
    End Sub

    Private Sub TXTCON_LECTORA_CheckedChanged(sender As Object, e As EventArgs) Handles TXTCON_LECTORA.CheckedChanged
        If TXTCON_LECTORA.Checked = True Then
            txtteclado.Checked = False
        ElseIf TXTCON_LECTORA.Checked = False Then
            txtteclado.Checked = True
        End If
    End Sub

    Private Sub txtteclado_CheckedChanged(sender As Object, e As EventArgs) Handles txtteclado.CheckedChanged
        If txtteclado.Checked = True Then
            TXTCON_LECTORA.Checked = False
        ElseIf txtteclado.Checked = False Then
            TXTCON_LECTORA.Checked = True
        End If
    End Sub


    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function
    Sub editar_caja()
        Dim cmd As New SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("editar_caja", conexion)
            cmd.CommandType = 4

            cmd.Parameters.AddWithValue("@idcaja", datalistadocajas.SelectedCells.Item(1).Value)
            cmd.Parameters.AddWithValue("@descripcion", txtcaja.Text)

            cmd.ExecuteNonQuery()

            Cerrar()
        Catch ex As Exception

        End Try


    End Sub
    Private Sub TSIGUIENTE__Click(sender As Object, e As EventArgs) Handles TSIGUIENTE_.Click
        If validar_Mail(LCase(txtcorreo.Text)) = False Then
            MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com, " & " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcorreo.Focus()
            txtcorreo.SelectAll()
        Else

            Dim cmd As New SqlCommand
            If txtempresa.Text <> "" Then
                Try
                    If no.Checked = True Then
                        TXTTRABAJASCONIMPUESTOS.Text = "NO"

                    End If
                    If si.Checked = True Then
                        TXTTRABAJASCONIMPUESTOS.Text = "SI"

                    End If
                    abrir()
                    cmd = New SqlCommand("editar_Empresa", conexion)
                    cmd.CommandType = 4

                    cmd.Parameters.AddWithValue("@Id_empresa", txtidempresa.Text)
                    cmd.Parameters.AddWithValue("@Nombre_Empresa", txtempresa.Text)
                    cmd.Parameters.AddWithValue("@Impuesto", txtimpuesto.Text)
                    cmd.Parameters.AddWithValue("@Porcentaje_impuesto", txtporcentaje.Text)
                    cmd.Parameters.AddWithValue("@Moneda", TXTMONEDA.Text)
                    cmd.Parameters.AddWithValue("@Trabajas_con_impuestos", TXTTRABAJASCONIMPUESTOS.Text)

                    Dim ms As New IO.MemoryStream()
                    If Not Imagenproducto.Image Is Nothing Then
                        Imagenproducto.Image.Save(ms, Imagenproducto.Image.RawFormat)
                    Else
                        Imagenproducto.Image = My.Resources.candado
                        Imagenproducto.Image.Save(ms, Imagenproducto.Image.RawFormat)
                    End If
                    cmd.Parameters.AddWithValue("@logo", ms.GetBuffer)
                    If TXTCON_LECTORA.Checked = True Then
                        cmd.Parameters.AddWithValue("@Modo_de_busqueda", "LECTORA")
                    End If
                    If txtteclado.Checked = True Then
                        cmd.Parameters.AddWithValue("@Modo_de_busqueda", "TECLADO")
                    End If
                    cmd.Parameters.AddWithValue("@Carpeta_para_copias_de_seguridad", txtruta.Text)
                    cmd.Parameters.AddWithValue("@Correo_para_envio_de_reportes", txtcorreo.Text)
                    cmd.Parameters.AddWithValue("@Redondeo", LBLEstadoRedondeo.Text)

                    cmd.ExecuteNonQuery()

                    Cerrar()
                    editar_caja()
                    MessageBox.Show("Cambios guardados", "Guardando Cambios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    VENTAS_MENU_PRINCIPAL.TimerEmpresa.Start()

                    MASCARA1.Hide()
                    Close()
                    VENTAS_MENU_PRINCIPAL.TimerDisposeMascara.Start()

                Catch ex As Exception : MsgBox(ex.Message)
                End Try





            Else
                MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbleditarLogo_Click(sender As Object, e As EventArgs) Handles lbleditarLogo.Click
        With dlg
            .InitialDirectory = ""
            .Filter = "Imagenes|*.jpg;*.png"
            .FilterIndex = 2
            .Title = "Cargador de Imagenes ADA 369"

        End With
        If dlg.ShowDialog() = DialogResult.OK Then
            Imagenproducto.BackgroundImage = Nothing
            Imagenproducto.Image = New Bitmap(dlg.FileName)
            Imagenproducto.SizeMode = PictureBoxSizeMode.Zoom

        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        MASCARA1.Dispose()
        Close()


    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click, Button1.Click
        MASCARA1.Hide()
        Close()
        VENTAS_MENU_PRINCIPAL.TimerDisposeMascara.Start()

    End Sub

    Private Sub txtpais_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TXTPAIS_SelectedIndexChanged_1(sender As Object, e As EventArgs)
        'TXTMONEDA.SelectedIndex = TXTPAIS.SelectedIndex
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txtruta.Text = FolderBrowserDialog1.SelectedPath
            Dim ruta As String = txtruta.Text
            If (ruta.Contains("C:\")) Then
                MessageBox.Show("Selecciona un Disco Diferente al Disco C:", "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtruta.Text = ""
            Else
                txtruta.Text = FolderBrowserDialog1.SelectedPath

            End If


        End If
    End Sub

    Private Sub ToolStripButton22_Click(sender As Object, e As EventArgs) Handles ToolStripButton22.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then

            txtruta.Text = FolderBrowserDialog1.SelectedPath
            Dim ruta As String = txtruta.Text
            If (ruta.Contains("C:\")) Then
                MessageBox.Show("Selecciona un Disco Diferente al Disco C:", "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtruta.Text = ""
            Else
                txtruta.Text = FolderBrowserDialog1.SelectedPath

            End If


        End If
    End Sub



    Private Sub txtRuta_Click(sender As Object, e As EventArgs) Handles txtruta.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txtruta.Text = FolderBrowserDialog1.SelectedPath
            Dim ruta As String = txtruta.Text
            If (ruta.Contains("C:\")) Then
                MessageBox.Show("Selecciona un Disco Diferente al Disco C:", "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtruta.Text = ""
            Else
                txtruta.Text = FolderBrowserDialog1.SelectedPath

            End If


        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PRedondear_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PNOREDONDEAROK_Click(sender As Object, e As EventArgs) Handles PNOREDONDEAROK.Click
        LBLEstadoRedondeo.Text = "NO"
        PNOREDONDEAROK.BackColor = Color.FromArgb(255, 204, 0)
        PREDONDEAROK.BackColor = Color.White
    End Sub

    Private Sub PREDONDEAROK_Click(sender As Object, e As EventArgs) Handles PREDONDEAROK.Click
        LBLEstadoRedondeo.Text = "SI"
        PREDONDEAROK.BackColor = Color.FromArgb(255, 204, 0)
        PNOREDONDEAROK.BackColor = Color.White
    End Sub

    Private Sub txtruta_TextChanged(sender As Object, e As EventArgs) Handles txtruta.TextChanged

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txtruta.Text = FolderBrowserDialog1.SelectedPath
            Dim ruta As String = txtruta.Text
            If (ruta.Contains("C:\")) Then
                MessageBox.Show("Selecciona un Disco Diferente al Disco C:", "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtruta.Text = ""
            Else
                txtruta.Text = FolderBrowserDialog1.SelectedPath

            End If


        End If
    End Sub
End Class