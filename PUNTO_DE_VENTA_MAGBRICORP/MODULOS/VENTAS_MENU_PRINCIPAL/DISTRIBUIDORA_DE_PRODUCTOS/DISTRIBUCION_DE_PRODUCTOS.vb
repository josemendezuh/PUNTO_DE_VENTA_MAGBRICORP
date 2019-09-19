
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
Public Class DISTRIBUCION_DE_PRODUCTOS
    Private memoria1 As Double = 0.0
    Private memoria2 As Double = 0.0
    Private signo As String
    Dim DT_USUARIO As New DataTable
    Private txt() As PictureBox
    Private lbl() As Label
    Private lbl2() As Button
    Private b() As Button
    Private a() As Button
    Private ESTADO() As Label
    Private ima() As PictureBox
    Dim panel As New PanelExtended
    Dim i As Integer
    Dim j As Integer = 0
    Dim DTturnoinicial As New DataTable
    Dim DTturnofinal As New DataTable


    Dim dtcliente As New DataTable
    Dim dtidventa As New DataTable
    Dim dtserie As New DataTable
    Public dtunidad As New DataTable


    Sub dibujarproductos()
        Dim NBotones As Integer = 4
        Dim ima As New PictureBox()
        For I As Integer = 0 To NBotones
            ima.BackgroundImage = Nothing
            Dim b() As Byte = datalistadoinmueble.SelectedCells.Item(10).Value
            Dim ms As New IO.MemoryStream(b)
            ima.Image = Image.FromStream(ms)
            ima.Size = New System.Drawing.Size(300, 200)
            ima.SizeMode = PictureBoxSizeMode.Zoom

        Next
        FlowLayoutPanel1.Controls.Add(ima)
    End Sub

    Sub dibujarPLANIFICACIONES(ByVal fin As Integer)

        abrir()
        ReDim b(fin)
        ReDim a(fin)
        ReDim ESTADO(fin)
        Dim query As String = "mostrar_productos_para_ventas"

        Dim cmd As New SqlCommand(query, conexion)
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        Dim NBotones As Integer = 2
        Dim j As Integer = 0
        Dim contador As Integer = 0
        Dim constante As Integer = 88 'variable que determina el espaciado entre los picturebox'
        Dim constantex As Integer = 210
        While rdr.Read()
            For T = 1 To fin
                b(T) = New Button 'instanciamos los picturebox'
                a(T) = New Button 'iniciamos el label'
                ESTADO(T) = New Label
                Me.ESTADO(T).Text = rdr("Descripcion").ToString()
                Me.ESTADO(T).Name = rdr("Id_presentacionfraccionada").ToString()
                Me.ESTADO(T).Size = New System.Drawing.Size(250, 80)
                Me.ESTADO(T).BackColor = Color.Black
                Me.ESTADO(T).ForeColor = Color.White
                Me.ESTADO(T).FlatStyle = FlatStyle.Flat
                Me.ESTADO(T).Font = New System.Drawing.Font(12, 13)
                Me.ESTADO(T).TextAlign = ContentAlignment.BottomCenter

                Me.b(T).Text = rdr("Descripcion").ToString()
                'Me.b(T).Text = rdr("Descripcion").ToString() & "/Proyecto: " & rdr("Proyecto").ToString()
                Me.b(T).Name = rdr("Id_presentacionfraccionada").ToString()
                Me.b(T).Tag = rdr("Id_Producto1").ToString()
                Me.b(T).Size = New System.Drawing.Size(200, 80)
                'Me.b(T).BackColor = Color.FromArgb(59, 90, 154)
                Me.b(T).BackColor = Color.White
                Me.b(T).ForeColor = Color.Black
                Me.b(T).FlatStyle = FlatStyle.Flat
                Me.b(T).Font = New System.Drawing.Font(12, 13)
                Me.b(T).Cursor = Cursors.Hand
                Me.a(T).BackColor = Color.White
                Me.a(T).ForeColor = Color.Teal
                Me.a(T).Text = rdr("Descripcion").ToString() & " " & rdr("Descripcion").ToString() & " " & rdr("Descripcion").ToString()
                Me.a(T).Name = rdr("Id_Producto1").ToString()
                Me.a(T).Size = New System.Drawing.Size(300, 30)
                Me.a(T).FlatStyle = FlatStyle.Flat
                Me.a(T).TextAlign = ContentAlignment.MiddleCenter
                Me.a(T).Font = New System.Drawing.Font(12, 10)
                TXTESTADOOK.Text = Me.ESTADO(T).Text
                BTNVENDER.Enabled = True




                contador = contador + 1
                If contador <= 2 Then
                    b(T).Location = New System.Drawing.Point((contador * constantex) - constantex, j * constante) 'para la ubicacion'
                    'a(T).Location = New System.Drawing.Point((contador * constantex2) - constantex2, j * constante2) 'para la ubicacion'

                Else
                    j = j + 1
                    b(T).Location = New System.Drawing.Point(0, j * constante)
                    a(T).Location = New System.Drawing.Point((contador * constantex) - constantex, j * constantex) 'para la ubicacion'

                    contador = 1
                End If
                a(T).Location = New System.Drawing.Point(b(T).Location.X, b(T).Location.Y + 79)
                ESTADO(T).Location = New System.Drawing.Point(b(T).Location.X, b(T).Location.Y + 79)


                panel.Controls.Add(b(T))
                'panel.Controls.Add(a(T))


                AddHandler b(T).Click, AddressOf miEvento2
                AddHandler a(T).Click, AddressOf miEvento3

            Next



        End While
        Cerrar()






    End Sub
    Sub dibujarinmueblesporlinea(ByVal fin As Integer)
        abrir()
        ReDim b(fin)
        ReDim a(fin)
        ReDim ESTADO(fin)
        Dim query As String = "mostrar_productos_para_ventas_por_linea"
        Dim cmd As New SqlCommand(query, conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@idlinea", lblid_linea.Text)

        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        Dim NBotones As Integer = 2
        Dim j As Integer = 0
        Dim contador As Integer = 0
        Dim constante As Integer = 88 'variable que determina el espaciado entre los picturebox'
        Dim constantex As Integer = 210
        While rdr.Read()
            For T = 1 To fin
                b(T) = New Button 'instanciamos los picturebox'
                a(T) = New Button 'iniciamos el label'
                ESTADO(T) = New Label
                Me.ESTADO(T).Text = rdr("Descripcion").ToString()
                Me.ESTADO(T).Name = rdr("Id_presentacionfraccionada").ToString()
                Me.ESTADO(T).Size = New System.Drawing.Size(300, 80)
                Me.ESTADO(T).BackColor = Color.Black
                Me.ESTADO(T).ForeColor = Color.White
                Me.ESTADO(T).FlatStyle = FlatStyle.Flat
                Me.ESTADO(T).Font = New System.Drawing.Font(12, 13)
                Me.ESTADO(T).TextAlign = ContentAlignment.BottomCenter

                Me.b(T).Text = rdr("Descripcion").ToString()
                'Me.b(T).Text = rdr("Descripcion").ToString() & "/Proyecto: " & rdr("Proyecto").ToString()
                Me.b(T).Name = rdr("Id_presentacionfraccionada").ToString()
                Me.b(T).Tag = rdr("Id_Producto1").ToString()
                Me.b(T).Size = New System.Drawing.Size(200, 80)
                Me.b(T).BackColor = Color.White
                Me.b(T).ForeColor = Color.Black
                Me.b(T).FlatStyle = FlatStyle.Flat
                Me.b(T).Font = New System.Drawing.Font(12, 13)
                Me.b(T).Cursor = Cursors.Hand
                Me.a(T).BackColor = Color.White
                Me.a(T).ForeColor = Color.Teal
                Me.a(T).Text = rdr("Descripcion").ToString() & " " & rdr("Descripcion").ToString() & " " & rdr("Descripcion").ToString()
                Me.a(T).Name = rdr("Id_presentacionfraccionada").ToString()
                Me.a(T).Size = New System.Drawing.Size(300, 30)
                Me.a(T).FlatStyle = FlatStyle.Flat
                Me.a(T).TextAlign = ContentAlignment.MiddleCenter
                Me.a(T).Font = New System.Drawing.Font(12, 10)
                TXTESTADOOK.Text = Me.ESTADO(T).Text
                BTNVENDER.Enabled = True




                contador = contador + 1
                If contador <= 2 Then
                    b(T).Location = New System.Drawing.Point((contador * constantex) - constantex, j * constante) 'para la ubicacion'
                    a(T).Location = New System.Drawing.Point((contador * constantex) - constantex, j * constantex) 'para la ubicacion'

                Else
                    j = j + 1
                    b(T).Location = New System.Drawing.Point(0, j * constante)
                    'a(T).Location = New System.Drawing.Point((contador * constantex2) - constantex2, j * constante2) 'para la ubicacion'

                    contador = 1
                End If
                a(T).Location = New System.Drawing.Point(b(T).Location.X, b(T).Location.Y + 79)
                ESTADO(T).Location = New System.Drawing.Point(b(T).Location.X, b(T).Location.Y + 79)


                panel.Controls.Add(b(T))
                'panel.Controls.Add(a(T))


                AddHandler b(T).Click, AddressOf miEvento2
                AddHandler a(T).Click, AddressOf miEvento3

            Next



        End While
        Cerrar()






        ' abrir()
        ' ReDim b(fin)
        ' ReDim a(fin)
        ' ReDim ESTADO(fin)
        ' Dim query As String = "mostrar_productos_para_ventas_por_linea"

        ' Dim cmd As New SqlCommand(query, conexion)
        ' cmd.CommandType = 4
        ' cmd.Parameters.AddWithValue("@idlinea", lblid_linea.Text)
        ' Dim rdr As SqlDataReader = cmd.ExecuteReader()
        ' Dim NBotones As Integer = 6
        ' Dim j As Integer = 0
        ' Dim contador As Integer = 0
        ' Dim constante As Integer = 120 'variable que determina el espaciado entre los picturebox'
        ' Dim constantex As Integer = 320
        'While rdr.Read()
        '     For T = 1 To fin
        '         b(T) = New Button 'instanciamos los picturebox'
        '         a(T) = New Label 'iniciamos el label'
        '         ESTADO(T) = New Label
        '         Me.ESTADO(T).Text = rdr("Descripcion").ToString()
        '         Me.ESTADO(T).Name = rdr("Id_Producto1").ToString()
        '         Me.ESTADO(T).Size = New System.Drawing.Size(300, 80)
        '         Me.ESTADO(T).BackColor = Color.Black
        '         Me.ESTADO(T).ForeColor = Color.White
        '         Me.ESTADO(T).FlatStyle = FlatStyle.Flat
        '         Me.ESTADO(T).Font = New System.Drawing.Font(12, 13)
        '         Me.ESTADO(T).TextAlign = ContentAlignment.BottomCenter

        '         Me.b(T).Text = rdr("Descripcion").ToString()
        '         'Me.b(T).Text = rdr("Descripcion").ToString() & "/Proyecto: " & rdr("Proyecto").ToString()
        '         Me.b(T).Name = rdr("Id_Producto1").ToString()
        '         Me.b(T).Size = New System.Drawing.Size(300, 80)
        '         Me.b(T).BackColor = Color.FromArgb(95, 193, 93)
        '         Me.b(T).ForeColor = Color.White
        '         Me.b(T).FlatStyle = FlatStyle.Flat
        '         Me.b(T).Font = New System.Drawing.Font(12, 13)
        '         Me.b(T).Cursor = Cursors.Hand
        '         Me.a(T).BackColor = Color.White
        '         Me.a(T).ForeColor = Color.Teal
        '         Me.a(T).Text = rdr("Descripcion").ToString() & " " & rdr("Descripcion").ToString() & " " & rdr("Descripcion").ToString()
        '         Me.a(T).Name = rdr("Id_Producto1").ToString()
        '         Me.a(T).Size = New System.Drawing.Size(300, 30)
        '         Me.a(T).FlatStyle = FlatStyle.Flat
        '         Me.a(T).TextAlign = ContentAlignment.MiddleCenter
        '         Me.a(T).Font = New System.Drawing.Font(12, 10)
        '         TXTESTADOOK.Text = Me.ESTADO(T).Text
        '         BTNVENDER.Enabled = True




        '         contador = contador + 1
        '         If contador <= 4 Then
        '             b(T).Location = New System.Drawing.Point((contador * constantex) - constantex, j * constante) 'para la ubicacion'
        '             'a(T).Location = New System.Drawing.Point((contador * constantex2) - constantex2, j * constante2) 'para la ubicacion'

        '         Else
        '             j = j + 1
        '             b(T).Location = New System.Drawing.Point(0, j * constante)
        '             'a(T).Location = New System.Drawing.Point((contador * constantex2) - constantex2, j * constante2) 'para la ubicacion'

        '             contador = 1
        '         End If
        '         a(T).Location = New System.Drawing.Point(b(T).Location.X, b(T).Location.Y + 79)
        '         ESTADO(T).Location = New System.Drawing.Point(b(T).Location.X, b(T).Location.Y + 79)


        '         panel.Controls.Add(b(T))
        '         panel.Controls.Add(a(T))


        '         AddHandler b(T).Click, AddressOf miEvento2
        '         AddHandler b(T).MouseMove, AddressOf miEvento3

        '     Next



        ' End While
        ' Cerrar()




    End Sub



    Sub dibujarinmueblesBUSCADOR(ByVal fin As Integer)
        abrir()
        ReDim b(fin)
        ReDim a(fin)
        ReDim ESTADO(fin)
        Dim query As String = "buscar_producto_por_descripcion_DIBUJADO"
        Dim cmd As New SqlCommand(query, conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@letra", txtbuscar.Text)

        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        Dim NBotones As Integer = 2
        Dim j As Integer = 0
        Dim contador As Integer = 0
        Dim constante As Integer = 88 'variable que determina el espaciado entre los picturebox'
        Dim constantex As Integer = 210
        While rdr.Read()
            For T = 1 To fin
                b(T) = New Button 'instanciamos los picturebox'
                a(T) = New Button 'iniciamos el label'
                ESTADO(T) = New Label
                Me.ESTADO(T).Text = rdr("Descripcion").ToString()
                Me.ESTADO(T).Name = rdr("Id_presentacionfraccionada").ToString()
                Me.ESTADO(T).Size = New System.Drawing.Size(300, 80)
                Me.ESTADO(T).BackColor = Color.Black
                Me.ESTADO(T).ForeColor = Color.White
                Me.ESTADO(T).FlatStyle = FlatStyle.Flat
                Me.ESTADO(T).Font = New System.Drawing.Font(12, 13)
                Me.ESTADO(T).TextAlign = ContentAlignment.BottomCenter

                Me.b(T).Text = rdr("Descripcion").ToString()
                'Me.b(T).Text = rdr("Descripcion").ToString() & "/Proyecto: " & rdr("Proyecto").ToString()
                Me.b(T).Name = rdr("Id_presentacionfraccionada").ToString()
                Me.b(T).Tag = rdr("Id_Producto1").ToString()
                Me.b(T).Size = New System.Drawing.Size(200, 80)
                Me.b(T).BackColor = Color.White
                Me.b(T).ForeColor = Color.Black
                Me.b(T).FlatStyle = FlatStyle.Flat
                Me.b(T).Font = New System.Drawing.Font(12, 13)
                Me.b(T).Cursor = Cursors.Hand
                Me.a(T).BackColor = Color.White
                Me.a(T).ForeColor = Color.Teal
                Me.a(T).Text = rdr("Descripcion").ToString() & " " & rdr("Descripcion").ToString() & " " & rdr("Descripcion").ToString()
                Me.a(T).Name = rdr("Id_presentacionfraccionada").ToString()
                Me.a(T).Size = New System.Drawing.Size(300, 30)
                Me.a(T).FlatStyle = FlatStyle.Flat
                Me.a(T).TextAlign = ContentAlignment.MiddleCenter
                Me.a(T).Font = New System.Drawing.Font(12, 10)
                TXTESTADOOK.Text = Me.ESTADO(T).Text
                BTNVENDER.Enabled = True




                contador = contador + 1
                If contador <= 2 Then
                    b(T).Location = New System.Drawing.Point((contador * constantex) - constantex, j * constante) 'para la ubicacion'
                    a(T).Location = New System.Drawing.Point((contador * constantex) - constantex, j * constantex) 'para la ubicacion'

                Else
                    j = j + 1
                    b(T).Location = New System.Drawing.Point(0, j * constante)
                    'a(T).Location = New System.Drawing.Point((contador * constantex2) - constantex2, j * constante2) 'para la ubicacion'

                    contador = 1
                End If
                a(T).Location = New System.Drawing.Point(b(T).Location.X, b(T).Location.Y + 79)
                ESTADO(T).Location = New System.Drawing.Point(b(T).Location.X, b(T).Location.Y + 79)


                panel.Controls.Add(b(T))
                'panel.Controls.Add(a(T))


                AddHandler b(T).Click, AddressOf miEvento2
                AddHandler a(T).Click, AddressOf miEvento3

            Next



        End While
        Cerrar()






        ' abrir()
        ' ReDim b(fin)
        ' ReDim a(fin)
        ' ReDim ESTADO(fin)
        ' Dim query As String = "mostrar_productos_para_ventas_por_linea"

        ' Dim cmd As New SqlCommand(query, conexion)
        ' cmd.CommandType = 4
        ' cmd.Parameters.AddWithValue("@idlinea", lblid_linea.Text)
        ' Dim rdr As SqlDataReader = cmd.ExecuteReader()
        ' Dim NBotones As Integer = 6
        ' Dim j As Integer = 0
        ' Dim contador As Integer = 0
        ' Dim constante As Integer = 120 'variable que determina el espaciado entre los picturebox'
        ' Dim constantex As Integer = 320
        'While rdr.Read()
        '     For T = 1 To fin
        '         b(T) = New Button 'instanciamos los picturebox'
        '         a(T) = New Label 'iniciamos el label'
        '         ESTADO(T) = New Label
        '         Me.ESTADO(T).Text = rdr("Descripcion").ToString()
        '         Me.ESTADO(T).Name = rdr("Id_Producto1").ToString()
        '         Me.ESTADO(T).Size = New System.Drawing.Size(300, 80)
        '         Me.ESTADO(T).BackColor = Color.Black
        '         Me.ESTADO(T).ForeColor = Color.White
        '         Me.ESTADO(T).FlatStyle = FlatStyle.Flat
        '         Me.ESTADO(T).Font = New System.Drawing.Font(12, 13)
        '         Me.ESTADO(T).TextAlign = ContentAlignment.BottomCenter

        '         Me.b(T).Text = rdr("Descripcion").ToString()
        '         'Me.b(T).Text = rdr("Descripcion").ToString() & "/Proyecto: " & rdr("Proyecto").ToString()
        '         Me.b(T).Name = rdr("Id_Producto1").ToString()
        '         Me.b(T).Size = New System.Drawing.Size(300, 80)
        '         Me.b(T).BackColor = Color.FromArgb(95, 193, 93)
        '         Me.b(T).ForeColor = Color.White
        '         Me.b(T).FlatStyle = FlatStyle.Flat
        '         Me.b(T).Font = New System.Drawing.Font(12, 13)
        '         Me.b(T).Cursor = Cursors.Hand
        '         Me.a(T).BackColor = Color.White
        '         Me.a(T).ForeColor = Color.Teal
        '         Me.a(T).Text = rdr("Descripcion").ToString() & " " & rdr("Descripcion").ToString() & " " & rdr("Descripcion").ToString()
        '         Me.a(T).Name = rdr("Id_Producto1").ToString()
        '         Me.a(T).Size = New System.Drawing.Size(300, 30)
        '         Me.a(T).FlatStyle = FlatStyle.Flat
        '         Me.a(T).TextAlign = ContentAlignment.MiddleCenter
        '         Me.a(T).Font = New System.Drawing.Font(12, 10)
        '         TXTESTADOOK.Text = Me.ESTADO(T).Text
        '         BTNVENDER.Enabled = True




        '         contador = contador + 1
        '         If contador <= 4 Then
        '             b(T).Location = New System.Drawing.Point((contador * constantex) - constantex, j * constante) 'para la ubicacion'
        '             'a(T).Location = New System.Drawing.Point((contador * constantex2) - constantex2, j * constante2) 'para la ubicacion'

        '         Else
        '             j = j + 1
        '             b(T).Location = New System.Drawing.Point(0, j * constante)
        '             'a(T).Location = New System.Drawing.Point((contador * constantex2) - constantex2, j * constante2) 'para la ubicacion'

        '             contador = 1
        '         End If
        '         a(T).Location = New System.Drawing.Point(b(T).Location.X, b(T).Location.Y + 79)
        '         ESTADO(T).Location = New System.Drawing.Point(b(T).Location.X, b(T).Location.Y + 79)


        '         panel.Controls.Add(b(T))
        '         panel.Controls.Add(a(T))


        '         AddHandler b(T).Click, AddressOf miEvento2
        '         AddHandler b(T).MouseMove, AddressOf miEvento3

        '     Next



        ' End While
        ' Cerrar()




    End Sub

    Private Sub miEvento3(ByVal sender As System.Object, ByVal e As EventArgs)
        txtidproductooka.Text = DirectCast(sender, Button).Name

        cargar_productos_para_kardex()
        Try
            lblpreciount.Text = datalistadoinmueble.SelectedCells.Item(3).Value
            LBLPRODUCTOOKA.Text = datalistadoinmueble.SelectedCells.Item(2).Value
            txtstock.Text = datalistadoinmueble.SelectedCells.Item(4).Value
            TXTSERVICIO.Text = datalistadoinmueble.SelectedCells.Item(5).Value


        Catch ex As Exception
            lblpreciount.Text = datalistadoinmueble.SelectedCells.Item(3).Value
            LBLPRODUCTOOKA.Text = datalistadoinmueble.SelectedCells.Item(2).Value
            txtstock.Text = datalistadoinmueble.SelectedCells.Item(4).Value
            TXTSERVICIO.Text = datalistadoinmueble.SelectedCells.Item(5).Value

        End Try
    End Sub

    Private Sub miEvento2(ByVal sender As System.Object, ByVal e As EventArgs)

        Try
            txtpantalla.Focus()

            txtid_producto.Text = DirectCast(sender, Button).Name

            FlowLayoutPanel1.Controls.Clear()
            'Listarpresentacionesagregadas()
            PANELCANTIDAD.Visible = True
            LISTAR_PRODUCTOS_AGREGADOS()
            Panel7.Visible = True
            txtpantalla.Text = ""
            txtidproductooka.Text = DirectCast(sender, Button).Tag
            cargar_productos_para_kardex()
            Try
                LBLPRODUCTOOKA.Text = datalistadoinmueble.SelectedCells.Item(2).Value
                txtstock.Text = datalistadoinmueble.SelectedCells.Item(4).Value
                lblpreciount.Text = datalistadoinmueble.SelectedCells.Item(3).Value
                TXTSERVICIO.Text = datalistadoinmueble.SelectedCells.Item(5).Value
            Catch ex As Exception
                LBLPRODUCTOOKA.Text = datalistadoinmueble.SelectedCells.Item(2).Value
                txtstock.Text = datalistadoinmueble.SelectedCells.Item(4).Value
                lblpreciount.Text = datalistadoinmueble.SelectedCells.Item(3).Value
                TXTSERVICIO.Text = datalistadoinmueble.SelectedCells.Item(5).Value
            End Try
            Imagenproducto.BackgroundImage = Nothing
            Dim b() As Byte = datalistadoinmueble.SelectedCells.Item(3).Value
            Dim ms As New IO.MemoryStream(b)
            Imagenproducto.Image = Image.FromStream(ms)
            Imagenproducto.SizeMode = PictureBoxSizeMode.StretchImage
            'txtcodigo.Text = datalistadoinmueble.SelectedCells.Item(2).Value
            'txttipo.Text = datalistadoinmueble.SelectedCells.Item(7).Value
            'descripcion.Text = datalistadoinmueble.SelectedCells.Item(8).Value
            'localizacion.Text = datalistadoinmueble.SelectedCells.Item(9).Value
            'txtclientesolicitante.Text = datalistadoinmueble.SelectedCells.Item(4).Value

            'txtprecio.Text = datalistadoinmueble.SelectedCells.Item(6).Value & " " & datalistadoinmueble.SelectedCells.Item(5).Value
            'TXTESTADO.Text = datalistadoinmueble.SelectedCells.Item(11).Value
            'If TXTESTADO.Text = "LIBRE" Then
            '    BTNVENDER.Enabled = True
            'ElseIf TXTESTADO.Text = "VENDIDO" Then
            '    BTNVENDER.Enabled = False
            'End If
            'dibujarproductos()

            txtpantalla.Focus()



        Catch ex As Exception

        End Try






    End Sub
    Sub cargar_productos_para_kardex()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_produtos_para_kardex_por_id", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtidproductooka.Text)
            da.Fill(dt)
            datalistadoinmueble.DataSource = dt

        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()

    End Sub
    Sub Listarpresentacionesagregadas()
        Dim dtListarpresentacionesagregadas As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("mostrar_CARACTERISTICAS_AGREGADAS_POR_INMUEBLE", conexion)
            daListarpresentacionesagregadas.SelectCommand.CommandType = 4
            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@idproducto", TXTIDREPORGRAMACION.Text)
            daListarpresentacionesagregadas.Fill(dtListarpresentacionesagregadas)
            datalistadocaracteristicas.DataSource = dtListarpresentacionesagregadas
            datalistadocaracteristicas.Columns(1).Visible = False
            datalistadocaracteristicas.Columns(3).Visible = False
            datalistadocaracteristicas.Columns(2).Width = 436
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()
    End Sub
    Sub dibujarTIPO()

        abrir()

        Dim query As String = "mostrar_lineas_sin_repetir"

        Dim cmd As New SqlCommand(query, conexion)

        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        Dim NBotones As Integer = 3
        While rdr.Read()
            Dim b As New Button()
            For I As Integer = 0 To NBotones

                b.Text = rdr("Linea").ToString()
                b.Name = rdr("Linea").ToString()
                b.Size = New System.Drawing.Size(170, 80)
                b.BackColor = Color.FromArgb(75, 70, 71)
                b.FlatStyle = FlatStyle.Flat
                b.ForeColor = Color.WhiteSmoke

            Next

            AddHandler b.Click, AddressOf miEvento



        End While

        Cerrar()
    End Sub


    Private Sub miEvento(ByVal sender As System.Object, ByVal e As EventArgs)
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        panel.AutoScroll = True
        panel.Location = New System.Drawing.Point(193, 38)
        panel.Name = "Panel1"
        panel.Size = New System.Drawing.Size(455, 640)
        Me.panel.Controls.Clear()
        Me.Controls.Add(panel)
        lblid_linea.Text = DirectCast(sender, Button).Name
        dibujarinmueblesporlinea(fin:=1)

    End Sub
    Sub MOSTRAR_USUARIOS()

        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("mostrar_vendedores", conexion)
            DA.Fill(DT_USUARIO)
            CBXVENDEDOR.DisplayMember = "Nombre_y_Apelllidos"
            CBXVENDEDOR.ValueMember = "idUsuario"
            CBXVENDEDOR.DataSource = DT_USUARIO
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()

    End Sub
    Private Sub sumar_total_despachado()

        Dim totalpagar As Double

        totalpagar = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In DATALISTADO_AGREGANDO.Rows
            totalpagar += (fila.Cells("Total").Value)
        Next
        TXTtotaldespachado.Text = (totalpagar)
        TXTtotaldespachado.Text = Format(CType(TXTtotaldespachado.Text, Decimal), "##0.00")


    End Sub
    Private Sub sumar_gastos()
        Dim totalpagar As Double

        totalpagar = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In datalistado_GASTOS.Rows
            totalpagar += (fila.Cells("Importe").Value)
        Next
        TXTTOTALgastos.Text = (totalpagar)
        TXTTOTALgastos.Text = Format(CType(TXTTOTALgastos.Text, Decimal), "##0.00")


    End Sub
    'Sub 
    '    Dim dtunidad As New DataTable
    '    Dim DA As SqlDataAdapter
    '    Try
    '        abrir()
    '        DA = New SqlDataAdapter("mostrar_unidades", conexion)
    '        DA.Fill(dtunidad)

    '        txtunidad.DisplayMember = "Unidad_de_medida"

    '        txtunidad.ValueMember = "Id_unidad_de_medida"

    '        txtunidad.DataSource = dtunidad
    '    Catch ex As Exception : MessageBox.Show(ex.Message)

    '    End Try

    '    Cerrar()

    '    lbl_unidadoka.Text = txtunidad.Text
    'End Sub
    Sub cargarunidades_EXP()

        Dim DA As SqlDataAdapter

        Try

            abrir()
            DA = New SqlDataAdapter("mostrar_unidades", conexion)

            DA.Fill(dtunidad)

            txtunidad.DisplayMember = "Unidad_de_medida"

            txtunidad.ValueMember = "Id_unidad_de_medida"
            'txtunidad.Refresh()
            'txtunidad.DataSource = New DataSet
            'txtunidad.Refresh()



            txtunidad.DataSource = dtunidad
        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try

        Cerrar()

        lbl_unidadoka.Text = txtunidad.Text
    End Sub
    Private Sub VISOR_PARA_VENTAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        panel.AutoScroll = True
        panel.Location = New System.Drawing.Point(193, 38)
        panel.Name = "Panel1"
        panel.Size = New System.Drawing.Size(455, 640)
        Me.panel.Controls.Clear()
        Me.Controls.Add(panel)
        dibujarPLANIFICACIONES(fin:=1)
        Timer1.Start()
        dibujarTIPO()
        LISTAR_PRODUCTOS_AGREGADOS()
        LISTAR_gastos_por_usuario()


        MOSTRAR_USUARIOS()
        PANELCANTIDAD.Visible = False
        
        txtbuscar.Text = ""
        Label17.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel7.Visible = False

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles BTNVENDER.Click
        VENTAS_MENU_PRINCIPAL.ShowDialog()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Stop()
        LISTAR_PRODUCTOS_AGREGADOS()
        LISTAR_gastos_por_usuario()
        buscar_creditos_x_vendedor_y_fecha()
        buscar_cobros_x_vendedor_y_fecha()
        buscar_rechazo_x_vendedor_y_fecha()
        Try
            txtTOTALrechazo.Text = datalistadorechazo.SelectedCells.Item(1).Value
            txtTOTALrechazo.Text = Format(CType(txtTOTALrechazo.Text, Decimal), "##0.00")
        Catch ex As Exception
            txtTOTALrechazo.Text = 0
        End Try
        Try
            txttotalcobros.Text = datalistadocobros.SelectedCells.Item(1).Value
        Catch ex As Exception
            txttotalcobros.Text = 0
        End Try


        Try
            txtTOTALcreditos.Text = datalistadocreditos_con_productos.SelectedCells.Item(1).Value
        Catch ex As Exception
            txtTOTALcreditos.Text = 0
        End Try
        TXTOTAL_TOTAL.Text = txttotalcobros.Text * 1 - txtTOTALcreditos.Text * 1 + TXTtotaldespachado.Text * 1 - TXTTOTALgastos.Text * 1 - txtTOTALrechazo.Text * 1
        TXTOTAL_TOTAL.Text = Format(CType(TXTOTAL_TOTAL.Text, Decimal), "##0.00")
        'Try
        '    lblgastos.Text = datalistadocreditos_con_producto.SelectedCells.Item(1).Value
        'Catch ex As Exception
        '    lblgastos.Text = 0
        'End Try


        'If ProgressBar1.Value < 100 Then
        '    ProgressBar1.Value = ProgressBar1.Value + 10
        'Else

        '    System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        '    System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        '    System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        '    System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        '    System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","


        '    panel.AutoScroll = True
        '    panel.Location = New System.Drawing.Point(193, 38)

        '    panel.Name = "Panel1"
        '    panel.Size = New System.Drawing.Size(565, 640)
        '    Me.panel.Controls.Clear()
        '    Me.Controls.Add(panel)


        '    dibujarPLANIFICACIONES(fin:=1)
        '    Timer1.Stop()
        '    ProgressBar1.Value = 0

        'End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Timer1.Start()

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub



    Private Sub ToolStripMenuItem2_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        productosOK.ShowDialog()

    End Sub

    Private Sub CBXVENDEDOR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBXVENDEDOR.SelectedIndexChanged
        With TXTIDUSUARIO
            .DataSource = DT_USUARIO
            .DisplayMember = "idUsuario"
            .ValueMember = "idUsuario"

        End With
        Timer1.Start()


    End Sub
    Sub LISTAR_PRODUCTOS_AGREGADOS()
        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("mostrar_productos_agregados_a_kardex_por_vendedor_id", conexion)
            daListarpresentacionesagregadas.SelectCommand.CommandType = 4

            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@letra", lblidusuario.Text)
            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@fecha", TXTFECHA_DE_KADEX.Value)

            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            DATALISTADO_AGREGANDO.DataSource = dtDATALISTADO_AGREGANDO
            DATALISTADO_AGREGANDO.Columns(1).Visible = False
            DATALISTADO_AGREGANDO.Columns(2).Visible = False
            DATALISTADO_AGREGANDO.Columns(0).Width = 45
            DATALISTADO_AGREGANDO.Columns(3).Width = 65
            DATALISTADO_AGREGANDO.Columns(4).Width = 280
            DATALISTADO_AGREGANDO.Columns(5).Width = 60
            DATALISTADO_AGREGANDO.Columns(6).Width = 60
            DATALISTADO_AGREGANDO.Columns(7).Visible = False
            DATALISTADO_AGREGANDO.Columns(8).Visible = False
        Catch ex As Exception
        End Try
        Cerrar()
        sumar_total_despachado()
    End Sub
    Sub LISTAR_gastos_por_usuario()
        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("mostrar_gastos_por_usuario", conexion)
            daListarpresentacionesagregadas.SelectCommand.CommandType = 4

            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@idusuario", lblidusuario.Text)
            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@fecha", TXTFECHA_DE_KADEX.Value)


            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            datalistado_GASTOS.DataSource = dtDATALISTADO_AGREGANDO

        Catch ex As Exception
        End Try
        Cerrar()
        sumar_gastos()

    End Sub
    Sub buscar_creditos_x_vendedor_y_fecha()
        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("buscar_creditos_x_vendedor_y_fecha", conexion)
            daListarpresentacionesagregadas.SelectCommand.CommandType = 4

            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@idvendedor", lblidusuario.Text)
            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@fecha", TXTFECHA_DE_KADEX.Value)


            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            datalistadocreditos_con_productos.DataSource = dtDATALISTADO_AGREGANDO

        Catch ex As Exception
        End Try
        Cerrar()


    End Sub
    Sub buscar_rechazo_x_vendedor_y_fecha()
        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("buscar_rechazo_x_vendedor_y_fecha", conexion)
            daListarpresentacionesagregadas.SelectCommand.CommandType = 4

            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@idvendedor", lblidusuario.Text)
            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@fecha", TXTFECHA_DE_KADEX.Value)


            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            datalistadorechazo.DataSource = dtDATALISTADO_AGREGANDO

        Catch ex As Exception
        End Try
        Cerrar()


    End Sub

    Sub buscar_cobros_x_vendedor_y_fecha()
        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("buscar_cobros_x_vendedor_y_fecha", conexion)
            daListarpresentacionesagregadas.SelectCommand.CommandType = 4

            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@idvendedor", lblidusuario.Text)
            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@fecha", TXTFECHA_DE_KADEX.Value)


            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            datalistadocobros.DataSource = dtDATALISTADO_AGREGANDO

        Catch ex As Exception
        End Try
        Cerrar()


    End Sub
    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Dim cantidad2 As Decimal
        cantidad2 = txtpantalla.Text * txtcantidad_de_unidad_de_medidaoka.Text * 1
        txtcantidad_total.Text = cantidad2
        TXTTTT.Text = cantidad2
        If TXTSERVICIO.Text = "NO" Then



            If txtstock.Text * 1 >= txtcantidad_total.Text * 1 Then
                Try
                    Dim cmd As New SqlCommand
                    abrir()
                    cmd = New SqlCommand("insertar_KARDEX_SALIDA", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@Fecha", TXTFECHA_DE_KADEX.Value)
                    cmd.Parameters.AddWithValue("@Motivo", "DESPACHO DIARIO DE VENDEDORES...")
                    cmd.Parameters.AddWithValue("@Cantidad ", txtcantidad_total.Text)

                    cmd.Parameters.AddWithValue("@Id_presentacion_fraccionada", txtid_producto.Text)
                    cmd.Parameters.AddWithValue("@Id_usuario", TXTIDUSUARIO.Text)
                    cmd.Parameters.AddWithValue("@Tipo", "SALIDA")
                    cmd.Parameters.AddWithValue("@Estado", "DESPACHADO")
                    cmd.Parameters.AddWithValue("@Total", (lblpreciount.Text * 1 * txtcantidad_total.Text * 1))
                    cmd.ExecuteNonQuery()
                    '       @Fecha datetime,
                    '    @Motivo varchar(200),			         

                    '        @Cantidad as numeric(18,0)	,
                    '@Precio_unitario as numeric(18,18),	
                    ' @Id_producto int	,
                    '  @Id_usuario as int,	
                    '  @Tipo as varchar(50)	


                    Cerrar()
                    DISMINUIR_STOCK()

                    LISTAR_PRODUCTOS_AGREGADOS()
                    PANELCANTIDAD.Visible = False
                Catch ex As Exception

                End Try
            Else
                MsgBox("No hay Suficiente Stock - Solicite que Registren Entrada de Producto")
            End If
        ElseIf TXTSERVICIO.Text = "SI" Then
            Try
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("insertar_KARDEX_SALIDA", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Fecha", TXTFECHA_DE_KADEX.Value)
                cmd.Parameters.AddWithValue("@Motivo", "DESPACHO DIARIO DE VENDEDORES...")
                cmd.Parameters.AddWithValue("@Cantidad ", txtcantidad_total.Text)

                cmd.Parameters.AddWithValue("@Id_presentacion_fraccionada", txtid_producto.Text)
                cmd.Parameters.AddWithValue("@Id_usuario", TXTIDUSUARIO.Text)
                cmd.Parameters.AddWithValue("@Tipo", "SALIDA")
                cmd.Parameters.AddWithValue("@Estado", "DESPACHADO")
                cmd.Parameters.AddWithValue("@Total", (lblpreciount.Text * 1 * txtcantidad_total.Text * 1))
                cmd.ExecuteNonQuery()
                '       @Fecha datetime,
                '    @Motivo varchar(200),			         

                '        @Cantidad as numeric(18,0)	,
                '@Precio_unitario as numeric(18,18),	
                ' @Id_producto int	,
                '  @Id_usuario as int,	
                '  @Tipo as varchar(50)	


                Cerrar()


                LISTAR_PRODUCTOS_AGREGADOS()
                PANELCANTIDAD.Visible = False
            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub CBXVENDEDOR_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBXVENDEDOR.SelectedValueChanged

    End Sub

    Private Sub TXTIDUSUARIO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXTIDUSUARIO.SelectedIndexChanged
        lblidusuario.Text = TXTIDUSUARIO.Text
        LISTAR_PRODUCTOS_AGREGADOS()
        LISTAR_gastos_por_usuario()

    End Sub

    Private Sub TXTFECHA_DE_KADEX_ValueChanged(sender As Object, e As EventArgs) Handles TXTFECHA_DE_KADEX.ValueChanged


        Timer1.Start()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        PANELCANTIDAD.Visible = False

    End Sub


    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtpantalla.Text = txtpantalla.Text & "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtpantalla.Text = txtpantalla.Text & "1"
        txtpantalla.Focus()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtpantalla.Text = txtpantalla.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtpantalla.Text = txtpantalla.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtpantalla.Text = txtpantalla.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtpantalla.Text = txtpantalla.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtpantalla.Text = txtpantalla.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtpantalla.Text = txtpantalla.Text & "7"
        txtpantalla.Focus()

    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtpantalla.Text = txtpantalla.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtpantalla.Text = txtpantalla.Text & "9"
    End Sub

    Private Sub btnmas_Click(sender As Object, e As EventArgs) Handles btnmas.Click
        Try
            If txtpantalla.Text <> "" Then
                memoria1 = Val(txtpantalla.Text)
                signo = "+"
                txtpantalla.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnmenos_Click(sender As Object, e As EventArgs) Handles btnmenos.Click
        Try
            If txtpantalla.Text <> "" Then
                memoria1 = Val(txtpantalla.Text)
                signo = "-"
                txtpantalla.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnmultipllicacion_Click(sender As Object, e As EventArgs) Handles btnmultipllicacion.Click
        Try
            If txtpantalla.Text <> "" Then
                memoria1 = Val(txtpantalla.Text)
                signo = "*"
                txtpantalla.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndivision_Click(sender As Object, e As EventArgs) Handles btndivision.Click
        Try
            If txtpantalla.Text <> "" Then
                memoria1 = Val(txtpantalla.Text)
                signo = "/"
                txtpantalla.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub




    Private Sub btnborrartodo_Click(sender As Object, e As EventArgs) Handles btnborrartodo.Click
        txtpantalla.Clear()
        memoria1 = 0.0
        memoria2 = 0.0
        signo = String.Empty
    End Sub

    Private Sub btnborrarderecha_Click(sender As Object, e As EventArgs) Handles btnborrarderecha.Click
        Try
            Dim largo As Integer
            If txtpantalla.Text <> "" Then
                largo = txtpantalla.Text.Length
                txtpantalla.Text = Mid(txtpantalla.Text, 1, largo - 1)
            End If
        Catch ex As Exception

        End Try
    End Sub




    Private Sub btnpunto_Click(sender As Object, e As EventArgs) Handles btnpunto.Click
        If txtpantalla.Text = "" Then
            txtpantalla.Text = "0."
        ElseIf existepunto(txtpantalla.Text) = False Then
            txtpantalla.Text = txtpantalla.Text & "."
        End If
    End Sub


    Private Function existepunto(ByVal cadena As String) As Boolean
        Dim largo As Integer
        Dim respuesta As Boolean = False

        largo = cadena.Length

        For i As Integer = 1 To largo Step 1
            If Mid(cadena, i, 1) = "." Then
                respuesta = True
            End If
        Next
        Return respuesta

    End Function

    Private Sub btnigual_Click(sender As Object, e As EventArgs) Handles btnigual.Click
        Try
            If txtpantalla.Text <> "" And memoria1 <> 0.0 Then
                memoria2 = txtpantalla.Text
                calculadora()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub calculadora()
        Select Case signo
            Case "+"
                txtpantalla.Text = memoria1 + memoria2
            Case "-"
                txtpantalla.Text = memoria1 - memoria2
            Case "*"
                txtpantalla.Text = memoria1 * memoria2
            Case "/"
                txtpantalla.Text = memoria1 / memoria2
            Case "raiz"
                txtpantalla.Text = memoria1 ^ (1 / memoria2) 'alt 94
            Case "exponente"
                txtpantalla.Text = memoria1 ^ memoria2
            Case "%"
                txtpantalla.Text = memoria1 * memoria2 / 100
            Case Else
                MsgBox("Error")

        End Select
    End Sub

    Private Sub txtpantalla_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpantalla.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Try
                    If txtpantalla.Text <> "" And memoria1 <> 0.0 Then
                        memoria2 = txtpantalla.Text
                        calculadora()
                    End If
                Catch ex As Exception

                End Try
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub txtpantalla_TextChanged(sender As Object, e As EventArgs) Handles txtpantalla.TextChanged

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MASCARA1.Show()
        GASTOS_VARIOS_FORM.lbltipo.Text = "GASTOS VARIOS (-)"
        GASTOS_VARIOS_FORM.TXTACCION.Text = "SALIDA"
        GASTOS_VARIOS_FORM.PANELCOMPROBANTE.Enabled = False
        GASTOS_VARIOS_FORM.PANELPRECIOS.Enabled = False
        GASTOS_VARIOS_FORM.GuardarCambiosToolStripMenuItem.Visible = False
        GASTOS_VARIOS_FORM.txtmenuinterno.Text = "INTERNO"
        GASTOS_VARIOS_FORM.Id_usuario.Text = lblidusuario.Text
        GASTOS_VARIOS_FORM.ShowDialog()
        GASTOS_VARIOS_FORM.Id_usuario.Text = lblidusuario.Text
        GASTOS_VARIOS_FORM.txtmenuinterno.Text = "INTERNO"
        GASTOS_VARIOS_FORM.GuardarCambiosToolStripMenuItem.Visible = False
        GASTOS_VARIOS_FORM.PANELCOMPROBANTE.Enabled = False
        GASTOS_VARIOS_FORM.PANELPRECIOS.Enabled = False
        GASTOS_VARIOS_FORM.TXTACCION.Text = "SALIDA"
        GASTOS_VARIOS_FORM.lbltipo.Text = "GASTOS VARIOS (-)"
    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MASCARA1.Show()

        REGISTRO_DE_RECHAZO.lblidusuario.Text = TXTIDUSUARIO.Text
        REGISTRO_DE_RECHAZO.ShowDialog()
        REGISTRO_DE_RECHAZO.lblidusuario.Text = TXTIDUSUARIO.Text
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MASCARA1.Show()

        cobro_a_clientes.txtmenuinterno.Text = "INTERNO"
        cobro_a_clientes.ShowDialog()
        cobro_a_clientes.txtmenuinterno.Text = "INTERNO"
    End Sub



    Private Sub txtunidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtunidad.SelectedIndexChanged


        Dim importe As Double
        Dim com As New SqlCommand("buscar_und", conexion)
        com.CommandType = 4
        com.Parameters.AddWithValue("@letra", txtunidad.Text)
        Try
            abrir()
            importe = (com.ExecuteScalar()) 'asignamos el valor del importe
            Cerrar()
        Catch ex As Exception
        End Try
        txtcantidad_de_unidad_de_medidaoka.Text = importe  ' mostramos el importe



    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        Dim cantidad2 As Decimal

        cantidad2 = txtpantalla.Text * txtcantidad_de_unidad_de_medidaoka.Text * 1


        txtcantidad_total.Text = cantidad2
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
    Sub DISMINUIR_STOCK()
        'Dim cmdaumentarstock As SqlCommand
        'For Each fila As DataGridViewRow In DATALISTADO_AGREGANDO.Rows
        '    fila.Cells(0).Value = True
        'Next
        'Try
        '    For Each row As DataGridViewRow In DATALISTADO_AGREGANDO.Rows
        '        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Marcar").Value)

        '        If marcado Then

        '            Dim idlote As Integer = Convert.ToInt32(row.Cells("Id_presentacionfraccionada").Value)
        '            Dim cantidad As Decimal = Convert.ToDouble(row.Cells("Cantidad").Value)
        '            Dim estado As String = Convert.ToString(row.Cells("Estado").Value)
        '            Try
        '                abrir()
        '                cmdaumentarstock = New SqlCommand("disminuir_stock", conexion)
        '                cmdaumentarstock.CommandType = 4
        '                cmdaumentarstock.Parameters.AddWithValue("@Id_presentacionfraccionada", idlote)
        '                cmdaumentarstock.Parameters.AddWithValue("@cantidad", cantidad)
        '                cmdaumentarstock.Parameters.AddWithValue("@Estado", estado)
        '                cmdaumentarstock.ExecuteNonQuery()
        '            Catch ex As Exception : MsgBox(ex.Message)

        '            End Try
        '            Cerrar()
        '        End If

        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Try
            Dim cmd As New SqlCommand

            abrir()






            cmd = New SqlCommand("disminuir_stock", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", txtid_producto.Text)
            cmd.Parameters.AddWithValue("@cantidad", txtcantidad_total.Text)



            cmd.ExecuteNonQuery()
            '       @Fecha datetime,
            '    @Motivo varchar(200),			         

            '        @Cantidad as numeric(18,0)	,
            '@Precio_unitario as numeric(18,18),	
            ' @Id_producto int	,
            '  @Id_usuario as int,	
            '  @Tipo as varchar(50)	


            Cerrar()
            LISTAR_PRODUCTOS_AGREGADOS()
            PANELCANTIDAD.Visible = False
        Catch ex As Exception

        End Try

    End Sub
    Sub AUMENTAR_STOCK()
        Dim cmdaumentarstock As SqlCommand

        Try
            For Each row As DataGridViewRow In DATALISTADO_AGREGANDO.Rows
                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Marcar").Value)

                If marcado Then

                    Dim idlote As Integer = Convert.ToInt32(row.Cells("Id_presentacionfraccionada").Value)
                    Dim cantidad As Decimal = Convert.ToDouble(row.Cells("Cant").Value)

                    Try
                        abrir()
                        cmdaumentarstock = New SqlCommand("aumentar_stock", conexion)
                        cmdaumentarstock.CommandType = 4
                        cmdaumentarstock.Parameters.AddWithValue("@Id_presentacionfraccionada", idlote)
                        cmdaumentarstock.Parameters.AddWithValue("@cantidad", cantidad)

                        cmdaumentarstock.ExecuteNonQuery()
                    Catch ex As Exception : MsgBox(ex.Message)

                    End Try
                    Cerrar()
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub INSERTAR_KARDEX_ELIMINACION()
        Dim cmdKARDEXELIM As SqlCommand
        Try
            For Each row As DataGridViewRow In DATALISTADO_AGREGANDO.Rows
                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Marcar").Value)
                If marcado Then
                    Dim idlote As Integer = Convert.ToInt32(row.Cells("Id_presentacionfraccionada").Value)
                    Dim cantidad As Decimal = Convert.ToDouble(row.Cells("Cant").Value)
                    Dim total As Decimal = Convert.ToDouble(row.Cells("Total").Value)
                    Try
                        abrir()
                        cmdKARDEXELIM = New SqlCommand("insertar_KARDEX_SALIDA", conexion)
                        cmdKARDEXELIM.CommandType = 4
                        cmdKARDEXELIM.Parameters.AddWithValue("@Motivo", "ELIMINACION DE DESPACHO DE VENDEDORES")
                        cmdKARDEXELIM.Parameters.AddWithValue("@Cantidad ", cantidad)
                        cmdKARDEXELIM.Parameters.AddWithValue("@Fecha", TXTFECHA_DE_KADEX.Value)
                        cmdKARDEXELIM.Parameters.AddWithValue("@Id_presentacion_fraccionada", idlote)
                        cmdKARDEXELIM.Parameters.AddWithValue("@Id_usuario", TXTIDUSUARIO.Text)
                        cmdKARDEXELIM.Parameters.AddWithValue("@Tipo", "ENTRADA")
                        cmdKARDEXELIM.Parameters.AddWithValue("@Estado", "CONFIRMADO")
                        cmdKARDEXELIM.Parameters.AddWithValue("@Total", total)
                        cmdKARDEXELIM.ExecuteNonQuery()
                    Catch ex As Exception : MsgBox(ex.Message)

                    End Try
                    Cerrar()
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Dim cmdaumentarstock As SqlCommand

        'Try
        '    For Each row As DataGridViewRow In DATALISTADO_AGREGANDO.Rows
        '        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Marcar").Value)

        '        If marcado Then

        '            Dim idlote As Integer = Convert.ToInt32(row.Cells("Id_presentacionfraccionada").Value)
        '            Dim cantidad As Decimal = Convert.ToDouble(row.Cells("Cant").Value)

        '            Try
        '                abrir()
        '                cmdaumentarstock = New SqlCommand("insertar_KARDEX_SALIDA", conexion)
        '                cmdaumentarstock.CommandType = 4

        '                cmdaumentarstock.Parameters.AddWithValue("@Id_presentacionfraccionada", idlote)
        '                cmdaumentarstock.Parameters.AddWithValue("@cantidad", cantidad)

        '                cmdaumentarstock.ExecuteNonQuery()
        '            Catch ex As Exception : MsgBox(ex.Message)

        '            End Try
        '            Cerrar()
        '        End If

        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs)

        panel_de_despacho.Enabled = False
        panel_de_cuadre.Enabled = True

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        'INSERTAR_KARDEX_ELIMINACION()
        AUMENTAR_STOCK()


        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DATALISTADO_AGREGANDO.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Marcar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("Id_kardex").Value)

                        Try

                            abrir()
                            cmd = New SqlCommand("eliminar_PRODUCTO_DE_KARDEX", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@id", onekey)

                            cmd.ExecuteNonQuery()


                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try
                        Cerrar()
                    End If

                Next
                Call LISTAR_PRODUCTOS_AGREGADOS()




            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub DATALISTADO_AGREGANDO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_AGREGANDO.CellContentClick
        Try
            If e.ColumnIndex = Me.DATALISTADO_AGREGANDO.Columns.Item("Marcar").Index Then
                Dim chkcell2 As DataGridViewCheckBoxCell = Me.DATALISTADO_AGREGANDO.Rows(e.RowIndex).Cells("Marcar")
                chkcell2.Value = Not chkcell2.Value
            End If
        Catch ex As Exception
        End Try
    End Sub





    Private Sub PANELCANTIDAD_MouseLeave(sender As Object, e As EventArgs) Handles PANELCANTIDAD.MouseLeave
        'PANELCANTIDAD.Visible = False

    End Sub

    Private Sub PANELCANTIDAD_Paint(sender As Object, e As PaintEventArgs) Handles PANELCANTIDAD.Paint

    End Sub

    Private Sub Button16_Click_2(sender As Object, e As EventArgs) Handles Button16.Click
        MASCARA1.Show()
        PEDIDOS_VENTA_OKI.txtclientesolicitante.Text = CBXVENDEDOR.Text
        PEDIDOS_VENTA_OKI.ShowDialog()
        PEDIDOS_VENTA_OKI.txtclientesolicitante.Text = CBXVENDEDOR.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GASTOS_VARIOS_FORM.txtmenuinterno.Text = "INTERNO"
        MASCARA1.Show()

        LISTADO_GASTOS_VARIOS.ShowDialog()
        GASTOS_VARIOS_FORM.txtmenuinterno.Text = "INTERNO"
    End Sub



    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
       
        Close()
    End Sub

    Private Sub txtstock_Click(sender As Object, e As EventArgs) Handles txtstock.Click, lblpreciount.Click, Label14.Click, TXTSERVICIO.Click

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
       

        UND.ShowDialog()


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        



    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        Label17.Visible = False
        panel.AutoScroll = True
        panel.Location = New System.Drawing.Point(193, 38)
        panel.Name = "Panel1"
        panel.Size = New System.Drawing.Size(455, 640)
        Me.panel.Controls.Clear()
        Me.Controls.Add(panel)

        dibujarinmueblesBUSCADOR(fin:=1)

    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
       

        productosOK.ShowDialog()

    End Sub
End Class