Imports System.Data.SqlClient
Public Class Ticket

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Close()

    End Sub

    Private Sub PanelTICKET_Paint(sender As Object, e As PaintEventArgs) Handles PanelTICKET.Paint

    End Sub

    Private Sub Ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_formato_ticket()
        Mostrar_serializacion_ticket()
        Try
            txttipo.Text = datalistado_tickets.SelectedCells.Item(13).Value

        Catch ex As Exception

        End Try
        If txttipo.Text = "Ticket No Fiscal" Then
            btnTicket.BackColor = Color.FromArgb(255, 204, 1)
            btnFacturaBoleta.BackColor = Color.WhiteSmoke
            txtAutorizacion_fiscal.Visible = False

        Else
            btnFacturaBoleta.BackColor = Color.FromArgb(255, 204, 1)
            btnTicket.BackColor = Color.WhiteSmoke
            txtAutorizacion_fiscal.Visible = True

        End If
        Try
            ICONO.BackgroundImage = Nothing
            Dim b() As Byte = datalistado_tickets.SelectedCells.Item(1).Value
            Dim ms As New IO.MemoryStream(b)
            ICONO.Image = Image.FromStream(ms)
            ICONO.SizeMode = PictureBoxSizeMode.Zoom
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            txtempresaTICKET.Text = datalistado_tickets.SelectedCells.Item(2).Value
            txtEmpresa_RUC.Text = datalistado_tickets.SelectedCells.Item(5).Value
            txtDireccion.Text = datalistado_tickets.SelectedCells.Item(6).Value
            txtProvincia_departamento.Text = datalistado_tickets.SelectedCells.Item(7).Value
            txtMoneda_String.Text = datalistado_tickets.SelectedCells.Item(8).Value

            txtAgradecimiento.Text = datalistado_tickets.SelectedCells.Item(9).Value
            txtpagina_o_facebook.Text = datalistado_tickets.SelectedCells.Item(10).Value
            TXTANUNCIO.Text = datalistado_tickets.SelectedCells.Item(11).Value
            txtAutorizacion_fiscal.Text = datalistado_tickets.SelectedCells.Item(12).Value

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        'Dim gr As Graphics = Me.CreateGraphics
        '' Tamaño de lo que queremos copiar
        '' En este caso el tamaño de la ventana principal
        'Dim fSize As Size = Screen.PrimaryScreen.Bounds.Size
        '' Creamos el bitmap con el área que vamos a capturar
        'Dim bm As New Bitmap(fSize.Width, fSize.Height, gr)
        '' Un objeto Graphics a partir del bitmap
        'Dim gr2 As Graphics = Graphics.FromImage(bm)
        '' Copiar todo el área de la pantalla
        'gr2.CopyFromScreen(0, 0, 0, 0, fSize)

        '' Asignamos la imagen al PictureBox
        'Me.picCaptura.Image = bm
    End Sub

    Sub editar_diseño_ticket()

    End Sub
    Sub Mostrar_formato_ticket()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("Mostrar_formato_ticket", conexion)
            'da.SelectCommand.CommandType = 4
            'da.SelectCommand.Parameters.AddWithValue("@login", txtlogin.Text)
            'da.SelectCommand.Parameters.AddWithValue("@password", contraseña_encryptada)
            da.Fill(dt)
            datalistado_tickets.DataSource = dt
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try


    End Sub
    Sub Mostrar_serializacion_ticket()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("select * from Serializacion Where Serializacion.Id_tipodoc  ='TICKET'", conexion)
            'da.SelectCommand.CommandType = 4
            'da.SelectCommand.Parameters.AddWithValue("@login", txtlogin.Text)
            'da.SelectCommand.Parameters.AddWithValue("@password", contraseña_encryptada)
            da.Fill(dt)
            DATALISTADO_SERIALIZACION.DataSource = dt
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub EDITAR_EMPRESA()
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("editar_nombre_de_EMPRESA_con_imagen", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@nombre", txtempresaTICKET.Text)

            Dim ms As New IO.MemoryStream()
            If Not ICONO.Image Is Nothing Then
                ICONO.Image.Save(ms, ICONO.Image.RawFormat)
            Else

            End If
            cmd.Parameters.AddWithValue("@Imagen", ms.GetBuffer)

            cmd.ExecuteNonQuery()
            Cerrar()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub TSIGUIENTE__Click_1(sender As Object, e As EventArgs)
        If txtempresaTICKET.Text <> "" Then
            Try
                Dim cmd As New SqlCommand


                abrir()
                cmd = New SqlCommand("editar_FORMATO_TICKET", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Empresa_Ruc", txtEmpresa_RUC.Text)
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                cmd.Parameters.AddWithValue("@Provincia", txtProvincia_departamento.Text)
                cmd.Parameters.AddWithValue("@Moneda_string", txtMoneda_String.Text)
                cmd.Parameters.AddWithValue("@Agradecimiento", txtAgradecimiento.Text)
                cmd.Parameters.AddWithValue("@pagina_Web_Facebook", txtpagina_o_facebook.Text)
                cmd.Parameters.AddWithValue("@Extra", TXTANUNCIO.Text)
                cmd.ExecuteNonQuery()
                Cerrar()

                EDITAR_EMPRESA()
                MessageBox.Show("Datos Guardados Correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("No se guardaron los Datos", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End Try
        Else
            MessageBox.Show("Ingresa un Nombre de Empresa", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'SaveFileDialog1.DefaultExt = ".png" 'PARA NO TENER QUE ESCRIBIR LA EXTENSION
        'SaveFileDialog1.FileName = txtempresaTICKET.Text  'POR SI QUEREMOS USAR EL TEXTO DEL TEXTBOX COMO NOMBRE DE LA IMAGEN

        'If SaveFileDialog1.ShowDialog Then
        '    Try 'GUARDA LA IMAGEN DEL PICTUREBOX EN LA CARPETA DEBUG DEL PROYECTO
        '        picCaptura.Image.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
        '        MsgBox("GUARDADO")
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        With dlg
            .InitialDirectory = ""
            .Filter = "Imagenes|*.jpg;*.png"
            .FilterIndex = 2
            .Title = "Cargador de Imagenes ADA 369"

        End With
        If dlg.ShowDialog() = DialogResult.OK Then
            ICONO.BackgroundImage = Nothing
            ICONO.Image = New Bitmap(dlg.FileName)
            ICONO.SizeMode = PictureBoxSizeMode.Zoom

        End If


    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txttipo.Text = "Ticket No Fiscal" Then
            editar_ticket_no_fiscal()
            'Application.Restart()
            'Application.ExitThread()


        Else
            editar_factura_boleta()

        End If
    End Sub
    Sub editar_ticket_no_fiscal()
        Try


            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("editar_FORMATO_TICKET", conexion)
            cmd.CommandType = 4


            cmd.Parameters.AddWithValue("@Identificador_fiscal", txtEmpresa_RUC.Text)
            cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
            cmd.Parameters.AddWithValue("@Provincia_Departamento_Pais", txtProvincia_departamento.Text)
            cmd.Parameters.AddWithValue("@Nombre_de_Moneda", txtMoneda_String.Text)
            cmd.Parameters.AddWithValue("@Agradecimiento", txtAgradecimiento.Text)
            cmd.Parameters.AddWithValue("@pagina_Web_Facebook", txtpagina_o_facebook.Text)
            cmd.Parameters.AddWithValue("@Anuncio", TXTANUNCIO.Text)
            cmd.Parameters.AddWithValue("@Datos_fiscales_de_autorizacion", "-")

            cmd.Parameters.AddWithValue("@Por_defecto", txttipo.Text)
            cmd.Parameters.AddWithValue("@Nombre_Empresa", txtempresaTICKET.Text)
            Dim ms As New IO.MemoryStream()

            ICONO.Image.Save(ms, ICONO.Image.RawFormat)

            cmd.Parameters.AddWithValue("@Logo", ms.GetBuffer)
            cmd.ExecuteNonQuery()
            Cerrar()
            MessageBox.Show("Cambios Guardados correctamente", "Guardando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()


        Catch ex As Exception

        End Try
    End Sub
    Sub editar_factura_boleta()
        Try
            If txtAutorizacion_fiscal.Text <> "" Then
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("editar_FORMATO_TICKET", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Identificador_fiscal", txtEmpresa_RUC.Text)
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                cmd.Parameters.AddWithValue("@Provincia_Departamento_Pais", txtProvincia_departamento.Text)
                cmd.Parameters.AddWithValue("@Nombre_de_Moneda", txtMoneda_String.Text)
                cmd.Parameters.AddWithValue("@Agradecimiento", txtAgradecimiento.Text)
                cmd.Parameters.AddWithValue("@pagina_Web_Facebook", txtpagina_o_facebook.Text)
                cmd.Parameters.AddWithValue("@Anuncio", TXTANUNCIO.Text)
                cmd.Parameters.AddWithValue("@Datos_fiscales_de_autorizacion", txtAutorizacion_fiscal.Text)
                cmd.Parameters.AddWithValue("@Por_defecto", txttipo.Text)
                cmd.Parameters.AddWithValue("@Nombre_Empresa", txtempresaTICKET.Text)
                Dim ms As New IO.MemoryStream()
                ICONO.Image.Save(ms, ICONO.Image.RawFormat)
                cmd.Parameters.AddWithValue("@Logo", ms.GetBuffer)
                cmd.ExecuteNonQuery()
                Cerrar()
                MessageBox.Show("Cambios Guardados correctamente", "Guardando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Else
                MessageBox.Show("Ingrese la Autorizacion de emision de Comprobantes Electronicos al Final", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnTicket_Click(sender As Object, e As EventArgs) Handles btnTicket.Click
        txttipo.Text = "Ticket No Fiscal"
        btnTicket.BackColor = Color.FromArgb(255, 204, 1)
        btnFacturaBoleta.BackColor = Color.WhiteSmoke
        txtAutorizacion_fiscal.Visible = False

    End Sub

    Private Sub btnFacturaBoleta_Click(sender As Object, e As EventArgs) Handles btnFacturaBoleta.Click
        txttipo.Text = "Factura-Boleta"
        btnFacturaBoleta.BackColor = Color.FromArgb(255, 204, 1)
        btnTicket.BackColor = Color.WhiteSmoke
        txtAutorizacion_fiscal.Visible = True

    End Sub
End Class