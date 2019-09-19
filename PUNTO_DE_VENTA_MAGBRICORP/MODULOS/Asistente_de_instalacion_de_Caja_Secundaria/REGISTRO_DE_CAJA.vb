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
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Management

Imports System.AppDomainManagerInitializationOptions
Imports System.MarshalByRefObject
Imports System.Configuration
Imports System.Xml
Public Class REGISTRO_DE_CAJA
    Dim DTc As New DataTable
    Dim DTe As New DataTable
    Dim DTt As New DataTable
    Private MisDiscos As New ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard")
    Private DiscInfo As New ManagementObject
    Private aes As New AES()
    Sub cargarcontratista()
        'Dim DA As SqlDataAdapter
        'Try
        '    cLocal.Open()
        '    DA = New SqlDataAdapter("SELECT * FROM Contratista", cLocal)
        '    DA.Fill(DTc)
        '    txtcontratista.DisplayMember = "Contratista"
        '    txtcontratista.ValueMember = "Id_contratista"
        '    txtcontratista.DataSource = DTc
        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'cLocal.close()
    End Sub

    Sub cargarpresentaciones()
        'Dim DA As SqlDataAdapter
        'Try
        '    cLocal.Open()
        '    Dim PROCECIMIENTO As String
        '    PROCECIMIENTO = "SET NOCOUNT ON SELECT DISTINCT Presentacion FROM Producto1"


        '    DA = New SqlDataAdapter(PROCECIMIENTO, cLocal)
        '    DA.Fill(DTe)
        '    ''txtpresentacion.DisplayMember = "Presentacion"
        '    'txtpresentacion.ValueMember = "Presentacion"
        '    txtpresentacion.DataSource = DTe
        '    '            	
        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'cLocal.close()
    End Sub
    Sub cargartipo()
        'Dim DA As SqlDataAdapter
        'Try
        '    cLocal.Open()
        '    Dim PROCECIMIENTO As String
        '    PROCECIMIENTO = "SET NOCOUNT ON SELECT DISTINCT TIPO_DE_CARTA_FIANZA FROM TABLACARTAFIANZAS"


        '    DA = New SqlDataAdapter(PROCECIMIENTO, cLocal)
        '    DA.Fill(DTt)
        '    TXTTIPOCARTA.DisplayMember = "TIPO_DE_CARTA_FIANZA"
        '    TXTTIPOCARTA.ValueMember = "TIPO_DE_CARTA_FIANZA"
        '    TXTTIPOCARTA.DataSource = DTt
        '    '            	
        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'cLocal.close()
    End Sub
    Sub cargaremitida()
        'Dim DA As SqlDataAdapter
        'Try
        '    cLocal.Open()
        '    Dim PROCECIMIENTO As String
        '    PROCECIMIENTO = "SET NOCOUNT ON SELECT DISTINCT EMITIDA FROM TABLACARTAFIANZAS"


        '    DA = New SqlDataAdapter(PROCECIMIENTO, cLocal)
        '    DA.Fill(DTe)
        '    txtemitida.DisplayMember = "EMITIDA"
        '    'txtemitida.ValueMember = "EMITIDA"
        '    txtemitida.DataSource = DTe
        '    '            	
        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'cLocal.close()
    End Sub
    Private Sub contar()
        Dim x As Integer
        x = datalistado.Rows.Count
        txtcontador.Text = CStr(x)
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
    End Sub

    Sub mostrar_cajas_por_empresa()
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
        '    cLocal.Open()
        '    da = New SqlDataAdapter("MOSTRAR_TABLAGIRO", cLocal)
        '    da.Fill(dt)
        '    datalistadogiros.DataSource = dt
        '    contar()
        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'cLocal.close()
    End Sub
    Sub LIMPIAR()


        txtidpresentacion.Text = ""


    End Sub

    'Private Sub txtEspecialidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEspecialidad.TextChanged
    '    Dim dt As New DataTable
    '    Dim da As New SqlDataAdapter("BuscarEspec", cLocal)
    '    Try
    '        cLocal.Open()
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

        '        cLocal.Open()
        '        cmd = New SqlCommand("insertar_Historial", cLocal)
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
        '    cLocal.close()
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



    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click



        For Each fila As DataGridViewRow In datalistado.Rows
            fila.Cells(0).Value = True
        Next
        txtmsbox.Text = "Se ha activado seleccionar todas las filas"
        datalistado.Columns.Item("Eliminar").Visible = True

    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click


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
        '    cLocal.Open()
        '    DA = New SqlDataAdapter("mostrar_cajas_por_empresa", cLocal)
        '    DA.SelectCommand.CommandType = 4
        '    DA.SelectCommand.Parameters.AddWithValue("@empresa", MENUPRINCIPAL.cbxempresa.Text)
        '    DA.SelectCommand.Parameters.AddWithValue("@ip", CONTROL_TOTAL.TXTIP2.Text)
        '    DA.Fill(dtcaja)
        '    txtcaja.DisplayMember = "Descripcion"
        '    txtcaja.ValueMember = "Id_Caja"
        '    txtcaja.DataSource = dtcaja



        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'cLocal.close()
    End Sub



    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function
    Private Sub EMPRESA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        Panel16.Location = New Point((Width - Panel16.Width) / 2, (Height - Panel16.Height) / 2)

        Dim MiInfo = From Hd As ManagementObject In MisDiscos.Get Select Hd
        DiscInfo = MiInfo(0)
        lblIDSERIAL.Text = DiscInfo.Properties("SerialNumber").Value



    End Sub
    Sub contar_empresas()
        Dim x As Integer
        x = datalistado.Rows.Count
        txtcontador_empresas.Text = CStr(x)

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






    Private Sub VentasToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles GUARDAR.Click

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




    End Sub

    Private Sub ToolStripMenuItem1_Click_2(sender As Object, e As EventArgs)
    End Sub

    Private Sub datalistado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles datalistado.KeyPress

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

                Close()

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

    Private Sub datalistadocajas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadocajas.CellDoubleClick
        Try
            txtcaja.Text = datalistadocajas.SelectedCells.Item(2).Value
            TXTPC2.Text = datalistadocajas.SelectedCells.Item(4).Value
            TXTIP2.Text = datalistadocajas.SelectedCells.Item(4).Value
            GUARDAR.Visible = False
            GUARDARCAMBIOS.Visible = True

        Catch ex As Exception

        End Try
    End Sub







    Private Sub contarcajas()
        Dim x As Integer
        x = datalistadocajas.Rows.Count
        txtcontadorcajas.Text = CStr(x)
    End Sub
    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint

    End Sub

    Private Sub dlg_FileOk(sender As Object, e As CancelEventArgs) Handles dlg.FileOk

    End Sub



    Private Sub ObtenerDatos()
        Dim nombreHost As String = System.Net.Dns.GetHostName
        Dim hostInfo As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(nombreHost)

        TXTIP2.Text = hostInfo.HostName.ToString

    End Sub

    Public Sub SavetoXML_SERIAL_PC(ByVal dbcnString)
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load("Serial_x.xml")
        Dim root As XmlElement = doc.DocumentElement
        root.Attributes.Item(0).Value = dbcnString
        Dim writer As XmlTextWriter = New XmlTextWriter("Serial_x.xml", Nothing)
        writer.Formatting = Formatting.Indented
        doc.Save(writer)
        writer.Close()
    End Sub


    Private Sub TSIGUIENTE__Click(sender As Object, e As EventArgs)
        End

    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs)

    End Sub



    Private Sub ToolStripMenuItem3_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        End

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        End
    End Sub




    Private Sub txtcorreo_Leave(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcorreo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel13_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub TSIGUIENTE_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub TSIGUIENTE_Y_GUARDAR__Click(sender As Object, e As EventArgs) Handles TSIGUIENTE_Y_GUARDAR_.Click
        Dim cmd As New SqlCommand
        If txtcaja.Text <> "" Then
            Try
                abrir()
                cmd = New SqlCommand("Insertar_caja", conexion)
                cmd.CommandType = 4

                cmd.Parameters.AddWithValue("@descripcion", txtcaja.Text)
                cmd.Parameters.AddWithValue("@Tema", "Redentor")
                cmd.Parameters.AddWithValue("@Serial_PC", lblIDSERIAL.Text)
                cmd.Parameters.AddWithValue("@Impresora_Ticket", "Ninguna")
                cmd.Parameters.AddWithValue("@Impresora_A4", "Ninguna")
                cmd.ExecuteNonQuery()
                Cerrar()
                MessageBox.Show("Listo ya Tienes Esta CAJA Habilitada", "Caja Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try



        Else
            MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class