
Imports System.Data.SqlClient

Imports System.Data.OleDb

Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class Asistente_de_importacionExcel
    'Inherits PictureBox
    Private Sub Panel3_DragDrop(sender As Object, e As DragEventArgs) Handles PanelCargarrchivo.DragDrop
        'Dim file As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
        'If file IsNot Nothing AndAlso file.Length <> 0 Then
        '    LinkLabel3.Text = file(0)
        'End If

        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path1 In files

            'lblnombre_Del_archivo.Text = path
            lblRuta.Text = path1

            Dim ruta As String = lblRuta.Text
            If (ruta.Contains(".csv")) Then
                lblnombre_Del_archivo.Text = Path.GetFileName(ruta)
            Else
                MessageBox.Show("Archivo Incorrecto", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


            End If

        Next
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles PanelCargarrchivo.Paint

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel4_DragDrop(sender As Object, e As DragEventArgs)
        Dim file As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If file IsNot Nothing AndAlso file.Length <> 0 Then
            LinkLabel3.Text = file(0)
        End If
    End Sub

    Private Sub Panel3_DragEnter(sender As Object, e As DragEventArgs) Handles PanelCargarrchivo.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
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

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim brushImege As System.Drawing.Brush
        Try
            Dim Imagem As New Bitmap(Me.Image)
            'get images of the same size as control
            Imagem = New Bitmap(Imagem, New Size(Me.Width - 1, Me.Height - 1))
            brushImege = New TextureBrush(Imagem)

        Catch
            Dim Imagem As New Bitmap(Me.Width - 1, Me.Height - 1, PixelFormat.Format24bppRgb)
            Using grp As Graphics = Graphics.FromImage(Imagem)
                grp.FillRectangle(Brushes.White, 0, 0, Me.Width - 1, Me.Height - 1)
                Imagem = New Bitmap(Me.Width - 1, Me.Height - 1, grp)

            End Using
            brushImege = New TextureBrush(Imagem)

        End Try
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, Me.Width - 1, Me.Height - 1)
        e.Graphics.FillPath(brushImege, path)
        e.Graphics.DrawPath(Pens.Black, path)

    End Sub

    Private Function Image() As String
        Throw New NotImplementedException()
    End Function

    Private Sub Asistente_de_importacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PictureBox1.Image = Image.FromFile("D:\Temp\MyPic.jpg")
        Dim gp As New GraphicsPath()
        gp.AddEllipse(PictureBox1.DisplayRectangle)
        PictureBox1.Region = New Region(gp)




        B1.Enabled = True
        B2.Enabled = False
        B3.Enabled = False
        Paso1.Visible = True
        Paso2.Visible = False
        Paso3.Visible = False
        MenuStrip1.Visible = False

        PanelDescarga_de_archivo.Visible = True
        PanelDescarga_de_archivo.Dock = DockStyle.Fill
        RBasePrecargada.Checked = True
        Label8.Visible = False
        LinkPRECARGADA.Visible = True
        'PanelBaseDatosDeADA369.Visible = True
        'PanelPlantillaBase.Visible = False



        'PanelGuardarData.Visible = False
        PanelGuardarData.Visible = False
        PanelGuardarData.Dock = DockStyle.None
        PanelCargarrchivo.Visible = False
        PanelCargarrchivo.Dock = DockStyle.None
    End Sub

    Private Sub RBaseADA369_CheckedChanged(sender As Object, e As EventArgs) Handles RBasePrecargada.CheckedChanged
        PanelBaseDatosDeADA369.Visible = True
        PanelPlantillaBase.Visible = False
        LinkPRECARGADA.Visible = True
        Label8.Visible = False


    End Sub

    Private Sub RBasePropia_CheckedChanged(sender As Object, e As EventArgs) Handles RBasePropia.CheckedChanged
        PanelBaseDatosDeADA369.Visible = False
        PanelPlantillaBase.Visible = True
        LinkPRECARGADA.Visible = False
        Label8.Visible = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Try
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1Qib7d5P5TyEOTevSxE8e_OZNzGqWhp_CBvkent6NSr0/edit?usp=sharing")
        Catch ex As Exception

        End Try
    End Sub
    Sub guardar_datos_de_plantilla()
        Dim TextLine As String = ""
        Dim SplitLine() As String
        If System.IO.File.Exists(lblRuta.Text) = True Then

            Dim objReader As New System.IO.StreamReader(lblRuta.Text)

            Do While objReader.Peek() <> -1

                TextLine = objReader.ReadLine()

                SplitLine = Split(TextLine, ",")
                datalistado.ColumnCount = SplitLine.Length - 1
                datalistado.Rows.Add(SplitLine)
            Loop


            datalistado.Columns(1).HeaderText = "Descripcion"
            datalistado.Columns(2).HeaderText = "Codigo"
            datalistado.Columns(3).HeaderText = "Linea"
            datalistado.Columns(4).HeaderText = "Stock"
            datalistado.Columns(5).HeaderText = "Precio_de_compra"
            datalistado.Columns(6).HeaderText = "Precio_de_venta"
            datalistado.Columns(7).HeaderText = "Precio_mayoreo"
            datalistado.Columns(8).HeaderText = "A_partir_de"



            datalistado.Columns(1).Name = "Descripcion"
            datalistado.Columns(2).Name = "Codigo"
            datalistado.Columns(3).Name = "Linea"
            datalistado.Columns(4).Name = "Stock"
            datalistado.Columns(5).Name = "Precio_de_compra"
            datalistado.Columns(6).Name = "Precio_de_venta"
            datalistado.Columns(7).Name = "Precio_mayoreo"
            datalistado.Columns(8).Name = "A_partir_de"

            MsgBox("Importacion Exitosa", MsgBoxStyle.Information, "Importacion de datos")
            productosOK.Timer2.Start()

            Close()
        Else
            MsgBox("Archivo Inexistente", MsgBoxStyle.Information, "CSV Inexistente")
        End If

        Dim CMD As SqlCommand


        Try
            For Each row As DataGridViewRow In datalistado.Rows
                'Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Marcar").Value)
                For Each fila As DataGridViewRow In datalistado.Rows
                    fila.Cells(0).Value = True
                Next
                'If marcado Then
                Try

                    Dim codigointegrno As String = Convert.ToString(row.Cells("Codigo").Value)
                    Dim descripcion As String = Convert.ToString(row.Cells("Descripcion").Value)

                    Dim categoria As String = Convert.ToString(row.Cells("Linea").Value)
                    Dim stock As String = Convert.ToString(row.Cells("Stock").Value)
                    Dim Precio_de_compra As Double = Convert.ToDouble(row.Cells("Precio_de_compra").Value)
                    Dim Precio_de_venta As Double = Convert.ToDouble(row.Cells("Precio_de_venta").Value)
                    Dim Precio_mayoreo As Double = Convert.ToDouble(row.Cells("Precio_mayoreo").Value)
                    Dim A_partir_de As Double = Convert.ToDouble(row.Cells("A_partir_de").Value)






                    abrir()

                    CMD = New SqlCommand("insertar_Producto", conexion)
                    CMD.CommandType = CommandType.StoredProcedure
                    CMD.Parameters.AddWithValue("@Descripcion", descripcion)
                    CMD.Parameters.AddWithValue("@Imagen", ".")
                    CMD.Parameters.AddWithValue("@Linea", categoria)
                    CMD.Parameters.AddWithValue("@Usa_inventarios", "SI")
                    CMD.Parameters.AddWithValue("@Stock", stock)



                    CMD.Parameters.AddWithValue("@Precio_de_compra", Precio_de_compra)
                    CMD.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA")



                    CMD.Parameters.AddWithValue("@Precio_de_venta", Precio_de_venta)
                    CMD.Parameters.AddWithValue("@Codigo", codigointegrno)
                    CMD.Parameters.AddWithValue("@Se_vende_a", "Unidad")
                    CMD.Parameters.AddWithValue("@Impuesto", 0)
                    CMD.Parameters.AddWithValue("@Stock_minimo", 0)
                    CMD.Parameters.AddWithValue("@Precio_mayoreo", Precio_mayoreo)
                    CMD.Parameters.AddWithValue("@A_partir_de", A_partir_de)







                    CMD.ExecuteNonQuery()
                    Cerrar()
                Catch ex As Exception
                    'MsgBox(ex.Message)

                End Try

                'End If

            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub
    Sub guardar_datos_Precargados()
        Dim TextLine As String = ""
        Dim SplitLine() As String
        If System.IO.File.Exists(lblRuta.Text) = True Then

            Dim objReader As New System.IO.StreamReader(lblRuta.Text)

            Do While objReader.Peek() <> -1

                TextLine = objReader.ReadLine()

                SplitLine = Split(TextLine, ",")
                datalistado.ColumnCount = SplitLine.Length - 1
                datalistado.Rows.Add(SplitLine)
            Loop


            datalistado.Columns(1).HeaderText = "Descripcion"
            datalistado.Columns(2).HeaderText = "Codigo"


            datalistado.Columns(1).Name = "Descripcion"
            datalistado.Columns(2).Name = "Codigo"


            MsgBox("Importacion Exitosa", MsgBoxStyle.Information, "Importacion de datos")
            productosOK.Timer2.Start()

            Close()
        Else
            MsgBox("Archivo Inexistente", MsgBoxStyle.Information, "CSV Inexistente")
        End If

        Dim CMD As SqlCommand


        Try
            For Each row As DataGridViewRow In datalistado.Rows
                'Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Marcar").Value)
                For Each fila As DataGridViewRow In datalistado.Rows
                    fila.Cells(0).Value = True
                Next
                'If marcado Then
                Try

                    Dim codigointegrno As String = Convert.ToString(row.Cells("Codigo").Value)
                    Dim descripcion As String = Convert.ToString(row.Cells("Descripcion").Value)






                    abrir()

                    CMD = New SqlCommand("insertar_Producto", conexion)
                    CMD.CommandType = CommandType.StoredProcedure
                    CMD.Parameters.AddWithValue("@Descripcion", descripcion)
                    CMD.Parameters.AddWithValue("@Imagen", ".")
                    CMD.Parameters.AddWithValue("@Linea", "NINGUNA")
                    CMD.Parameters.AddWithValue("@Usa_inventarios", "SI")
                    CMD.Parameters.AddWithValue("@Stock", 0)



                    CMD.Parameters.AddWithValue("@Precio_de_compra", 0)
                    CMD.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA")



                    CMD.Parameters.AddWithValue("@Precio_de_venta", 0)
                    CMD.Parameters.AddWithValue("@Codigo", codigointegrno)
                    CMD.Parameters.AddWithValue("@Se_vende_a", "Unidad")
                    CMD.Parameters.AddWithValue("@Impuesto", 0)
                    CMD.Parameters.AddWithValue("@Stock_minimo", 0)
                    CMD.Parameters.AddWithValue("@Precio_mayoreo", 0)
                    CMD.Parameters.AddWithValue("@A_partir_de", 0)







                    CMD.ExecuteNonQuery()
                    Cerrar()
                Catch ex As Exception
                    'MsgBox(ex.Message)

                End Try

                'End If

            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click


        If RBasePrecargada.Checked = True Then
            guardar_datos_Precargados()
        ElseIf RBasePropia.Checked = True Then
            guardar_datos_de_plantilla()
        End If


        'datalistado.Columns(0).Visible = False

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

        With myFileDialog
            .InitialDirectory = "c:\temp\"
            .Filter = "CSV files (*.csv)|*.CSV"
            .FilterIndex = 2
            .RestoreDirectory = True

            .Title = "Elija el Archivo CSV"
            .ShowDialog()
        End With


        lblnombre_Del_archivo.Text = myFileDialog.SafeFileName.ToString
        lblRuta.Text = myFileDialog.FileName.ToString
        If lblRuta.Text <> "Arrastra aqui el Archivo de CSV" Then
            PanelCargarrchivo.BackColor = Color.White
            lblarchivoCargado.Visible = True
            MenuStrip1.Visible = True
            Label3.Visible = False
        End If

        'importarCSV(OpenFileDialog1, DgvContactos, ",")
    End Sub

    Private Sub LinkPRECARGADA_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkPRECARGADA.LinkClicked
        Try
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/122zznR_inWnPDdB5vqYI939smrz7P8Ce/view?usp=sharing")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TSIGUIENTE_Y_GUARDAR__Click(sender As Object, e As EventArgs) Handles TSIGUIENTE_Y_GUARDAR_.Click
        If RBasePrecargada.Checked = True Then
            Label3.Visible = False

        End If
        If RBasePropia.Checked = True Then

            Label3.Visible = True
        End If

        PanelDescarga_de_archivo.Visible = False
        PanelDescarga_de_archivo.Dock = DockStyle.None

        PanelCargarrchivo.Visible = True
        PanelCargarrchivo.Dock = DockStyle.Fill
        B1.Enabled = False
        B2.Enabled = True
        B3.Enabled = False
        Paso1.Visible = False
        Paso2.Visible = True
        Paso3.Visible = False
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If lblnombre_Del_archivo.Text <> "Arrastra aqui el Archivo de CSV" Then
            PanelCargarrchivo.Visible = False
            PanelCargarrchivo.Dock = DockStyle.None
            PanelGuardarData.Visible = True
            PanelGuardarData.Dock = DockStyle.Fill
            B1.Enabled = False
            B2.Enabled = False
            B3.Enabled = True
            Paso1.Visible = False
            Paso2.Visible = False
            Paso3.Visible = True
        Else
            MsgBox("Carga el Archivo de datos", MsgBoxStyle.Information, "CSV Inexistente")

        End If


    End Sub

    Private Sub lblnombre_Del_archivo_Click(sender As Object, e As EventArgs) Handles lblnombre_Del_archivo.Click

    End Sub



    Private Sub PanelGuardarData_Paint(sender As Object, e As PaintEventArgs) Handles PanelGuardarData.Paint

    End Sub



    Private Sub datalistado_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        Try
            If e.ColumnIndex = Me.datalistado.Columns.Item("Marcar").Index Then
                Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Marcar")
                chkcell.Value = Not chkcell.Value
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles B3.Click

    End Sub

    Private Sub PanelDescarga_de_archivo_Paint(sender As Object, e As PaintEventArgs) Handles PanelDescarga_de_archivo.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mascara1.dispose()
        Close()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

    End Sub
End Class