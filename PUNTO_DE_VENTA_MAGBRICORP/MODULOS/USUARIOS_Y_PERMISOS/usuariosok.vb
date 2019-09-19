
Imports System.Data.SqlClient

Imports System.IO

Imports System.Text.RegularExpressions


Public Class usuariosok

    Inherits Form

    Private dt As New DataTable
    Private dtcaja As New DataTable
    Private dtcargo As New DataTable
    Private aes As New AES()
    Private r As Random


    Private Sub contar()
        Dim x As Integer
        x = datalistado.Rows.Count

    End Sub


    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombre.Text = ""

        txtbuscar.Text = ""


        txtnombre.Text = ""
        txtPassword.Text = ""

    End Sub

    Private Sub mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim procedimiento As String
        procedimiento = "select idUsuario,Nombre_y_Apelllidos as Nombres ,Login as Usuario,Password as Contraseña,Icono ,Nombre_de_icono ,Correo ,rol,Estado from USUARIO2"
        Try
            abrir()
            da = New SqlDataAdapter(procedimiento, conexion)
            da.Fill(dt)
            datalistado.DataSource = dt
            Cerrar()
            contar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Try
            datalistado.Columns(0).Width = 40
            datalistado.Columns(1).Visible = False
            datalistado.Columns(5).Visible = False
            datalistado.Columns(6).Visible = False
            datalistado.Columns(7).Visible = False
            datalistado.Columns(8).Visible = False
            datalistado.Columns(4).Visible = False

            datalistado.Columns(2).Width = 300
            Me.datalistado.EnableHeadersVisualStyles = False
            Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
            styCabeceras.BackColor = Color.White
            styCabeceras.ForeColor = Color.Black
            styCabeceras.Font = New Font("Segoe UI", 10, FontStyle.Regular Or
            FontStyle.Bold)
            Me.datalistado.ColumnHeadersDefaultCellStyle = styCabeceras
            For Each row As DataGridViewRow In datalistado.Rows
                If row.Cells("Estado").Value = "ELIMINADO" Then
                    row.DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Strikeout Or FontStyle.Bold)
                    row.DefaultCellStyle.ForeColor = Color.Red
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub
    Private Sub mostrar_NUEVOS()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("SELECT*FROM USUARIO2 ORDER BY idUsuario desc", conexion)
            da.Fill(dt)
            DATALISTADOUSUARIOSSNUEVOS.DataSource = dt
            contar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()
    End Sub



    Sub buscar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_USUARIO_por_DNI", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letrab", txtbusca.Text)

            da.Fill(dt)
            datalistado.DataSource = dt
            Cerrar()

            Try
                datalistado.Columns(0).Width = 40
                datalistado.Columns(1).Visible = False
                datalistado.Columns(5).Visible = False
                datalistado.Columns(6).Visible = False
                datalistado.Columns(7).Visible = False
                datalistado.Columns(8).Visible = False
                datalistado.Columns(4).Visible = False

                datalistado.Columns(2).Width = 300
                Me.datalistado.EnableHeadersVisualStyles = False
                Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
                styCabeceras.BackColor = Color.White
                styCabeceras.ForeColor = Color.Black
                styCabeceras.Font = New Font("Segoe UI", 10, FontStyle.Regular Or
                FontStyle.Bold)
                Me.datalistado.ColumnHeadersDefaultCellStyle = styCabeceras
                For Each row As DataGridViewRow In datalistado.Rows
                    If row.Cells("Estado").Value = "ELIMINADO" Then
                        row.DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Strikeout Or FontStyle.Bold)
                        row.DefaultCellStyle.ForeColor = Color.Red
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'sumar_total_despachado()
    End Sub





    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
    End Sub

    Private Sub txtidcliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtidcliente.TextChanged

    End Sub





    Private Sub txtnombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'If DirectCast(sender, TextBox).Text.Length > 0 Then
        '    Me.erroricono.SetError(sender, "")
        'Else
        '    Me.erroricono.SetError(sender, "Ingrese el nombre del cliente porfavor, este dato es obligatorio")
        'End If
    End Sub

    Private Sub txtapellidos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtapellidos_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub txtdireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub txtdni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
        mostrar()

    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub datalistado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Try
            'txtPassword.Enabled = False
            txtidusuario.Text = datalistado.SelectedCells.Item(1).Value
            txtnombre.Text = datalistado.SelectedCells.Item(2).Value


            txtrol.Text = datalistado.SelectedCells.Item(6).Value
            txtPassword.Text = datalistado.SelectedCells.Item(7).Value

            'imagen.BackgroundImage = Nothing
            'Dim b() As Byte = datalistado.SelectedCells.Item(9).Value
            'Dim ms As New IO.MemoryStream(b)

            'imagen.Image = Image.FromStream(ms)
            'imagen.SizeMode = PictureBoxSizeMode.StretchImage

            btneditar.Enabled = True
            btnguardar.Enabled = False

            VentasToolStripMenuItem.Visible = False

        Catch ex As Exception

        End Try

    End Sub



    Private Sub btneditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbeliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub







    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged
        buscar()
        Try
            If txtbuscar.Text = "" Or inexistente.Visible = True Then
                txtidcliente.Text = ""
                txtnombre.Text = ""



            Else
                txtidcliente.Text = datalistado.SelectedCells.Item(1).Value
                txtnombre.Text = datalistado.SelectedCells.Item(2).Value

                btnguardar.Visible = False
                btneditar.Visible = True

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txttelefono_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtdni_TextChanged_1(sender As Object, e As EventArgs)

    End Sub



    Private Sub BTNIMPORTAR_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()

    End Sub

    Private Sub cbocampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocampo.SelectedIndexChanged

    End Sub

    Private Sub btnguardar_Click_1(sender As Object, e As EventArgs) Handles btnguardar.Click

    End Sub

    Private Sub btneditar_Click_1(sender As Object, e As EventArgs) Handles btneditar.Click

    End Sub

    Private Sub btnnuevo_Click_1(sender As Object, e As EventArgs) Handles btnnuevo.Click
        btnguardar.Visible = True
        btneditar.Visible = False
    End Sub

    Private Sub MarcarTodosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        mostrar()
        txtbuscar.Visible = False
        For Each fila As DataGridViewRow In datalistado.Rows
            fila.Cells(0).Value = True
        Next

    End Sub

    Private Sub DesmarcarTodosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        mostrar()
        txtbuscar.Visible = False
        For Each fila As DataGridViewRow In datalistado.Rows
            fila.Cells(0).Value = False
        Next

    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        mostrar()

    End Sub

    Private Sub RegistrarNuevoProductoToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub EDITARToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'txtPassword.Enabled = False
        Panel2.Visible = True
        VentasToolStripMenuItem.Visible = False
        GuardarCambiosToolStripMenuItem.Visible = True





    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Panel2.Visible = False



    End Sub

    Private Sub MenuStrip5_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub
    Sub insertar_permisos_CAJERO()
        mostrar_NUEVOS()
        txtidusuariooka.Text = DATALISTADOUSUARIOSSNUEVOS.SelectedCells.Item(1).Value
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_permisos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_Usuario", DATALISTADOUSUARIOSSNUEVOS.SelectedCells.Item(1).Value)
            cmd.Parameters.AddWithValue("@ventas", 1)
            cmd.Parameters.AddWithValue("@aplicar_descuentos", 1)
            cmd.Parameters.AddWithValue("@Devoluciones", 1)

            cmd.Parameters.AddWithValue("@clientes_proveedores", 1)
            cmd.Parameters.AddWithValue("@productos", 0)
            cmd.Parameters.AddWithValue("@invetarios_kardex", 1)
            cmd.Parameters.AddWithValue("@configuraciones", 0)
            cmd.Parameters.AddWithValue("@usuarios", 0)
            cmd.Parameters.AddWithValue("@reportes", 0)
            cmd.Parameters.AddWithValue("@Manejar_caja", 1)
            cmd.Parameters.AddWithValue("@Herramientas", 1)
            cmd.ExecuteNonQuery()

            Cerrar()
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub
    Sub insertar_permisos_Solo_ventas()
        mostrar_NUEVOS()
        txtidusuariooka.Text = DATALISTADOUSUARIOSSNUEVOS.SelectedCells.Item(1).Value

        Try


            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("insertar_permisos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_Usuario", DATALISTADOUSUARIOSSNUEVOS.SelectedCells.Item(1).Value)
            cmd.Parameters.AddWithValue("@ventas", 1)
            cmd.Parameters.AddWithValue("@aplicar_descuentos", 1)
            cmd.Parameters.AddWithValue("@Devoluciones", 0)
            cmd.Parameters.AddWithValue("@Manejar_caja", 0)
            cmd.Parameters.AddWithValue("@Herramientas", 0)
            cmd.Parameters.AddWithValue("@clientes_proveedores", 0)
            cmd.Parameters.AddWithValue("@productos", 0)
            cmd.Parameters.AddWithValue("@invetarios_kardex", 0)
            cmd.Parameters.AddWithValue("@configuraciones", 0)
            cmd.Parameters.AddWithValue("@usuarios", 0)
            cmd.Parameters.AddWithValue("@reportes", 0)

            cmd.ExecuteNonQuery()

            Cerrar()
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub
    Sub insertar_permisos_ADMINISTRADOR()
        mostrar_NUEVOS()
        txtidusuariooka.Text = DATALISTADOUSUARIOSSNUEVOS.SelectedCells.Item(1).Value

        Try


            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("insertar_permisos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_Usuario", DATALISTADOUSUARIOSSNUEVOS.SelectedCells.Item(1).Value)
            cmd.Parameters.AddWithValue("@ventas", 1)
            cmd.Parameters.AddWithValue("@aplicar_descuentos", 1)
            cmd.Parameters.AddWithValue("@Devoluciones", 1)
            cmd.Parameters.AddWithValue("@Manejar_caja", 1)
            cmd.Parameters.AddWithValue("@Herramientas", 1)
            cmd.Parameters.AddWithValue("@clientes_proveedores", 1)
            cmd.Parameters.AddWithValue("@productos", 1)
            cmd.Parameters.AddWithValue("@invetarios_kardex", 1)
            cmd.Parameters.AddWithValue("@configuraciones", 1)
            cmd.Parameters.AddWithValue("@usuarios", 1)
            cmd.Parameters.AddWithValue("@reportes", 1)

            cmd.ExecuteNonQuery()

            Cerrar()
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub
    Public Function validar_Mail(ByVal sMail As String) As Boolean

        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function
    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        If validar_Mail(LCase(txtcorreo.Text)) = False Then
            MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com, " & " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcorreo.Focus()
            txtcorreo.SelectAll()
        Else

            Dim contraseña_encryptada As String
            contraseña_encryptada = Encriptar(Me.txtPassword.Text.Trim)
            Dim cmd As New SqlCommand
            If txtnombre.Text <> "" Or txtPassword.Text <> "" And txtrol.Text <> "" Then
                If LBLcontador_de_contraseña.Text = 6 Then


                    Try
                        If LblAnuncioIcono.Visible = False Then
                            abrir()
                            cmd = New SqlCommand("insertar_usuario", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@nombres", txtnombre.Text)
                            cmd.Parameters.AddWithValue("@Login", txtlogin.Text)
                            cmd.Parameters.AddWithValue("@Password", contraseña_encryptada)

                            Dim ms As New IO.MemoryStream()
                            ICONO.Image.Save(ms, ICONO.Image.RawFormat)
                            cmd.Parameters.AddWithValue("@Icono", ms.GetBuffer)

                            cmd.Parameters.AddWithValue("@Nombre_de_icono", lblnumeroIcono.Text)
                            cmd.Parameters.AddWithValue("@Correo", txtcorreo.Text)
                            cmd.Parameters.AddWithValue("@Rol", txtrol.Text)
                            cmd.Parameters.AddWithValue("@Estado", "ACTIVO")

                            cmd.ExecuteNonQuery()
                            Cerrar()
                            mostrar()

                            Panel2.Visible = False
                        Else
                            MessageBox.Show("Elije un ICONO", "Icono", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message)

                    End Try
                Else
                    MessageBox.Show("La contraseña debe tener 6 digitos", "Cantidad de Digitos de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        End If
    End Sub
    Sub editar_permisosAdministrador()
        Dim cmd As New SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("editar_permisos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_Usuario", datalistado.SelectedCells.Item(1).Value)
            cmd.Parameters.AddWithValue("@ventas", 1)
            cmd.Parameters.AddWithValue("@aplicar_descuentos", 1)
            cmd.Parameters.AddWithValue("@Devoluciones", 1)
            cmd.Parameters.AddWithValue("@Manejar_caja", 1)
            cmd.Parameters.AddWithValue("@Herramientas", 1)
            cmd.Parameters.AddWithValue("@clientes_proveedores", 1)
            cmd.Parameters.AddWithValue("@productos", 1)
            cmd.Parameters.AddWithValue("@invetarios_kardex", 1)
            cmd.Parameters.AddWithValue("@configuraciones", 1)
            cmd.Parameters.AddWithValue("@usuarios", 1)
            cmd.Parameters.AddWithValue("@reportes", 1)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception : MsgBox(ex.Message)
        End Try

    End Sub
    Sub editar_permisosCajero()
        Dim cmd As New SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("editar_permisos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_Usuario", datalistado.SelectedCells.Item(1).Value)
            cmd.Parameters.AddWithValue("@ventas", 1)
            cmd.Parameters.AddWithValue("@aplicar_descuentos", 1)
            cmd.Parameters.AddWithValue("@Devoluciones", 1)
            cmd.Parameters.AddWithValue("@clientes_proveedores", 1)
            cmd.Parameters.AddWithValue("@productos", 0)
            cmd.Parameters.AddWithValue("@invetarios_kardex", 1)
            cmd.Parameters.AddWithValue("@configuraciones", 0)
            cmd.Parameters.AddWithValue("@usuarios", 0)
            cmd.Parameters.AddWithValue("@reportes", 0)
            cmd.Parameters.AddWithValue("@Manejar_caja", 1)
            cmd.Parameters.AddWithValue("@Herramientas", 1)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception : MsgBox(ex.Message)
        End Try

    End Sub
    Sub editar_permisosvendedor()
        Dim cmd As New SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("editar_permisos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_Usuario", datalistado.SelectedCells.Item(1).Value)
            cmd.Parameters.AddWithValue("@ventas", 1)
            cmd.Parameters.AddWithValue("@aplicar_descuentos", 1)
            cmd.Parameters.AddWithValue("@Devoluciones", 0)
            cmd.Parameters.AddWithValue("@Manejar_caja", 0)
            cmd.Parameters.AddWithValue("@Herramientas", 0)
            cmd.Parameters.AddWithValue("@clientes_proveedores", 0)
            cmd.Parameters.AddWithValue("@productos", 0)
            cmd.Parameters.AddWithValue("@invetarios_kardex", 0)
            cmd.Parameters.AddWithValue("@configuraciones", 0)
            cmd.Parameters.AddWithValue("@usuarios", 0)
            cmd.Parameters.AddWithValue("@reportes", 0)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception : MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub GuardarCambiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarCambiosToolStripMenuItem.Click

        Dim contraseña_encryptadaE As String
        contraseña_encryptadaE = Encriptar(Me.txtPassword.Text.Trim)  
        Dim cmd As New SqlCommand
        If txtnombre.Text <> "" And txtrol.Text <> "" Then
            Try

                abrir()
                    cmd = New SqlCommand("editar_usuario", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@idusuario", datalistado.SelectedCells.Item(1).Value)
                    cmd.Parameters.AddWithValue("@nombres", txtnombre.Text)
                    cmd.Parameters.AddWithValue("@paswor", contraseña_encryptadaE)
                Dim ms As New IO.MemoryStream()
                ICONO.Image.Save(ms, ICONO.Image.RawFormat)
                cmd.Parameters.AddWithValue("@Icono", ms.GetBuffer)
                cmd.Parameters.AddWithValue("@Nombre_de_icono", lblnumeroIcono.Text)
                cmd.Parameters.AddWithValue("@Correo", txtcorreo.Text)
                cmd.Parameters.AddWithValue("@rol", txtrol.Text)
                cmd.Parameters.AddWithValue("@Login", txtlogin.Text)
                cmd.ExecuteNonQuery()
                Cerrar()
                Panel2.Visible = False
                    mostrar()
                VENTAS_MENU_PRINCIPAL.TimerMostrarUsuarioLogueado.Start()


            Catch ex As Exception : MsgBox(ex.Message)
            End Try


        Else
            MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        txtPassword.Enabled = True
        limpiar()
        mostrar()
        VentasToolStripMenuItem.Visible = True
        GuardarCambiosToolStripMenuItem.Visible = False
    End Sub

    Private Sub txtbusca_TextChanged(sender As Object, e As EventArgs) Handles txtbusca.TextChanged

        buscar()

    End Sub



    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        txtPassword.Enabled = True

        Panel2.Visible = True


        VentasToolStripMenuItem.Visible = True
        GuardarCambiosToolStripMenuItem.Visible = False
        limpiar()
        mostrar()

    End Sub
    Function ValidatePassword(ByVal pwd As String,
        Optional ByVal minLength As Integer = 8,
        Optional ByVal numUpper As Integer = 2,
        Optional ByVal numLower As Integer = 2,
        Optional ByVal numNumbers As Integer = 2,
        Optional ByVal numSpecial As Integer = 2) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function

    Sub cargarcajas()
        'Dim DA As SqlDataAdapter

        'Try
        '    abrir()
        '    DA = New SqlDataAdapter("MOSTRAR_CAJASOK", conexion)
        '    DA.Fill(dtcaja)
        '    txtcaja.DisplayMember = "Descripcion"
        '    txtcaja.ValueMember = "Descripcion"
        '    txtcaja.DataSource = dtcaja
        'Catch ex As Exception
        'End Try
        'Cerrar()
    End Sub


    Private Sub usuariosok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Visible = False
        PanelIcono.Visible = False

        mostrar()


        btnguardar.Visible = True
        btneditar.Visible = False



    End Sub

    Private Sub btncambiocontraseña_Click(sender As Object, e As EventArgs)
        'cambiodecontraseña.txtLogin.Text = txtLogin.Text
        cambiodecontraseña.lblusuario.Text = txtnombre.Text
        cambiodecontraseña.ShowDialog()
        'cambiodecontraseña.txtLogin.Text = txtLogin.Text
        cambiodecontraseña.lblusuario.Text = txtnombre.Text

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    'Private Sub btnagragarimagen_Click(sender As Object, e As EventArgs)
    '    If dlg.ShowDialog() = DialogResult.OK Then
    '        imagen.BackgroundImage = Nothing
    '        imagen.Image = New Bitmap(dlg.FileName)
    '        imagen.SizeMode = PictureBoxSizeMode.Zoom

    '    End If
    'End Sub

    'Private Sub btnquitarimagen_Click(sender As Object, e As EventArgs)
    '    imagen.Image = Nothing
    '    imagen.BackgroundImage = My.Resources.negro_de_usuario_icono_8390_64
    '    imagen.SizeMode = PictureBoxSizeMode.StretchImage
    'End Sub








    'Private Sub txtcaja_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    With txtidcaja
    '        .DataSource = dtcaja
    '        .DisplayMember = "Id_Caja"
    '        .ValueMember = "Id_Caja"
    '    End With
    'End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs)
        cargarcajas()

    End Sub




    Private Sub ToolStripMenuItem13_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem10_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub datalistado_CellClick1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub datalistado_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub EliminarToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idUsuario").Value)

                        Try

                            abrir()
                            cmd = New SqlCommand("eliminar_usuario", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@idUsuario", onekey)

                            cmd.ExecuteNonQuery()


                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try
                        Cerrar()
                    End If

                Next

                Call mostrar()



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub


    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub txtcargo_SelectedIndexChanged(sender As Object, e As EventArgs)
        With txtidcargo
            .DataSource = dtcargo
            .DisplayMember = "Id_horarios"
            .ValueMember = "Id_horarios"
        End With
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        CONFIGURACION_DE_HORARIOS_PRECIOS.TopMost = True
        CONFIGURACION_DE_HORARIOS_PRECIOS.ShowDialog()
        CONFIGURACION_DE_HORARIOS_PRECIOS.TopMost = True
    End Sub

    Private Sub timerparaactualizarventanueva_Tick(sender As Object, e As EventArgs) Handles timerparaactualizarventanueva.Tick
        timerparaactualizarventanueva.Stop()


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        txtcorreo.Text = ""
        txtlogin.Enabled = True
        txtlogin.Text = ""
        Cargar_estado_de_iconos()
        LblAnuncioIcono.Visible = True

        Label25.Visible = False
        txtrol.Text = "Solo Ventas"
        txtPassword.Enabled = True
        Panel2.Visible = True
        VentasToolStripMenuItem.Visible = True


        GuardarCambiosToolStripMenuItem.Visible = False
        limpiar()
        mostrar()
        'txtLogin.Enabled = True
    End Sub
    Sub GENERAR_CONTRASEÑA_AUTOMATICA()


        Try
            For Each row As DataGridViewRow In datalistado.Rows
                Try
                    r = New Random()
                    txtPassword.Text = r.[Next](0, 9) & r.[Next](0, 9) & r.[Next](0, 9) & r.[Next](0, 9) & r.[Next](0, 9) & r.[Next](0, 9)



                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception

        End Try

    End Sub
    Sub Cargar_estado_de_iconos()
        l1.Visible = False

        l2.Visible = False

        l3.Visible = False

        l4.Visible = False

        l5.Visible = False

        l6.Visible = False

        l7.Visible = False

        l8.Visible = False

        p1.Enabled = True

        p2.Enabled = True

        p3.Enabled = True

        p4.Enabled = True

        p5.Enabled = True

        p6.Enabled = True

        p7.Enabled = True

        p8.Enabled = True

        Try
            For Each row As DataGridViewRow In datalistado.Rows

                Try

                    Dim Icono As String = Convert.ToString(row.Cells("Nombre_de_icono").Value)





                    If Icono = "1" Then
                        l1.Visible = True
                    ElseIf Icono = "2" Then
                        l2.Visible = True
                    ElseIf Icono = "3" Then
                        l3.Visible = True
                    ElseIf Icono = "4" Then
                        l4.Visible = True
                    ElseIf Icono = "5" Then
                        l5.Visible = True
                    ElseIf Icono = "6" Then
                        l6.Visible = True
                    ElseIf Icono = "7" Then
                        l7.Visible = True
                    ElseIf Icono = "8" Then
                        l8.Visible = True
                    End If






                    If Icono = "1" Then
                        p1.Enabled = False
                    ElseIf Icono = "2" Then
                        p2.Enabled = False
                    ElseIf Icono = "3" Then
                        p3.Enabled = False
                    ElseIf Icono = "4" Then
                        p4.Enabled = False
                    ElseIf Icono = "5" Then
                        p5.Enabled = False
                    ElseIf Icono = "6" Then
                        p6.Enabled = False
                    ElseIf Icono = "7" Then
                        p7.Enabled = False
                    ElseIf Icono = "8" Then
                        p8.Enabled = False
                    End If


                Catch ex As Exception


                End Try


            Next
        Catch ex As Exception

        End Try

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        MASCARA1.Hide()
        Close()
        VENTAS_MENU_PRINCIPAL.TimerDisposeMascara.Start()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel2.Visible = False


    End Sub

    Private Sub ventas_CheckedChanged(sender As Object, e As EventArgs) Handles ventas.CheckedChanged

    End Sub
    Sub restaurar_usuarios()
        Dim result As DialogResult

        result = MessageBox.Show("Este Usuario se Elimino. ¿Desea Volver a Habilitarlo?", "Restauracion de registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Dim cmd As SqlCommand
            Try
                For Each row As DataGridViewRow In datalistado.SelectedRows

                    Dim onekey As Integer = Convert.ToInt32(row.Cells("idUsuario").Value)
                    Dim usuario As String = Convert.ToString(row.Cells("Usuario").Value)

                    Try

                        Try

                            abrir()
                            cmd = New SqlCommand("restaurar_usuario", conexion)
                            cmd.CommandType = 4

                            cmd.Parameters.AddWithValue("@idUsuario", onekey)
                            cmd.Parameters.AddWithValue("@login", usuario)
                            cmd.ExecuteNonQuery()
                            Cerrar()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try

                    Catch ex As Exception : MsgBox(ex.Message)

                    End Try

                Next
                Call mostrar()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando restauracion de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub datalistado_CellClick2(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        Try
            txtrol.Text = datalistado.SelectedCells.Item(3).Value

        Catch ex As Exception

        End Try
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eli").Index Then
            Dim result As DialogResult

            result = MessageBox.Show("¿Realmente desea eliminar esta Usuario?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                Dim cmd As SqlCommand
                Try
                    For Each row As DataGridViewRow In datalistado.SelectedRows

                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idUsuario").Value)
                        Dim usuario As String = Convert.ToString(row.Cells("Usuario").Value)

                        Try

                            Try

                                abrir()
                                cmd = New SqlCommand("eliminar_usuario", conexion)
                                cmd.CommandType = 4

                                cmd.Parameters.AddWithValue("@idUsuario", onekey)
                                cmd.Parameters.AddWithValue("@login", usuario)
                                cmd.ExecuteNonQuery()
                                Cerrar()
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try

                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try

                    Next
                    Call mostrar()


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If



        End If
    End Sub

    Private Sub datalistadoMovimientos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub
    Dim estado As String
    Private Sub datalistadoMovimientos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        Try
            txtPassword.Enabled = True
            txtidusuario.Text = datalistado.SelectedCells.Item(1).Value
            txtnombre.Text = datalistado.SelectedCells.Item(2).Value
            txtlogin.Text = datalistado.SelectedCells.Item(3).Value
            txtcorreo.Text = datalistado.SelectedCells.Item(7).Value
            txtrol.Text = datalistado.SelectedCells.Item(8).Value
            estado = datalistado.SelectedCells.Item(9).Value
            If estado = "ELIMINADO" Then
                restaurar_usuarios()

            Else
                If txtlogin.Text = "admin" Then
                    txtlogin.Enabled = False
                    txtrol.Enabled = False
                Else
                    txtlogin.Enabled = True
                    txtrol.Enabled = True
                End If
                Me.txtPassword.Text = Desencriptar(datalistado.SelectedCells.Item(4).Value.Trim)

                ICONO.BackgroundImage = Nothing
                Dim b() As Byte = datalistado.SelectedCells.Item(5).Value
                Dim ms As New IO.MemoryStream(b)
                ICONO.Image = Image.FromStream(ms)
                ICONO.SizeMode = PictureBoxSizeMode.Zoom
                LblAnuncioIcono.Visible = False


                btneditar.Enabled = True
                btnguardar.Enabled = False

                VentasToolStripMenuItem.Visible = False
                Panel2.Visible = True
                VentasToolStripMenuItem.Visible = False

                GuardarCambiosToolStripMenuItem.Visible = True

                Cargar_estado_de_iconos()
            End If



        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtLogin_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

        LBLcontador_de_contraseña.Text = Len(txtPassword.Text)
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtPassword, e)
    End Sub
    Public Sub NumerosyDecimal(ByVal CajaTexto As System.Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If


    End Sub
    Private Sub p1_Click(sender As Object, e As EventArgs) Handles p1.Click


        ICONO.Image = p1.Image
            lblnumeroIcono.Text = 1
            LblAnuncioIcono.Visible = False
            PanelIcono.Visible = False



    End Sub
    Private Sub p2_Click(sender As Object, e As EventArgs) Handles p2.Click

        ICONO.Image = p2.Image
        lblnumeroIcono.Text = 2
        LblAnuncioIcono.Visible = False
        PanelIcono.Visible = False
    End Sub
    Private Sub p3_Click(sender As Object, e As EventArgs) Handles p3.Click

        ICONO.Image = p3.Image
        lblnumeroIcono.Text = 3
        LblAnuncioIcono.Visible = False
        PanelIcono.Visible = False
    End Sub
    Private Sub p4_Click(sender As Object, e As EventArgs) Handles p4.Click



        ICONO.Image = p4.Image
            lblnumeroIcono.Text = 4
            LblAnuncioIcono.Visible = False
            PanelIcono.Visible = False


    End Sub


    Private Sub p5_Click(sender As Object, e As EventArgs) Handles p5.Click



        ICONO.Image = p5.Image
            lblnumeroIcono.Text = 5
            LblAnuncioIcono.Visible = False
            PanelIcono.Visible = False

    End Sub
    Private Sub p6_Click(sender As Object, e As EventArgs) Handles p6.Click




        ICONO.Image = p6.Image
            lblnumeroIcono.Text = 6
            LblAnuncioIcono.Visible = False
            PanelIcono.Visible = False



    End Sub
    Private Sub p7_Click(sender As Object, e As EventArgs) Handles p7.Click




        ICONO.Image = p7.Image
            lblnumeroIcono.Text = 7
            LblAnuncioIcono.Visible = False
            PanelIcono.Visible = False

    End Sub
    Private Sub p8_Click(sender As Object, e As EventArgs) Handles p8.Click



        ICONO.Image = p8.Image
            lblnumeroIcono.Text = 8
            LblAnuncioIcono.Visible = False
            PanelIcono.Visible = False

    End Sub

    Private Sub LblAnuncioIcono_Click(sender As Object, e As EventArgs) Handles LblAnuncioIcono.Click
        Cargar_estado_de_iconos()

        PanelIcono.Visible = True
        LBLENUSO.Visible = False

    End Sub

    Private Sub ICONO_Click(sender As Object, e As EventArgs) Handles ICONO.Click
        Cargar_estado_de_iconos()
        PanelIcono.Visible = True
        LBLENUSO.Visible = False

    End Sub



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles Agregar_Icono.Click
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
            lblnumeroIcono.Text = Path.GetFileName(dlg.FileName)
            LblAnuncioIcono.Visible = False
            PanelIcono.Visible = False


            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Try
                        Dim Icono As String = Convert.ToString(row.Cells("Nombre_de_icono").Value)
                        If Icono = lblnumeroIcono.Text Then
                            MessageBox.Show("Ya existe este Icono Registrado, Elije Otro Icono", "Icono en Uso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LblAnuncioIcono.Visible = True
                        End If

                    Catch ex As Exception

                    End Try
                Next
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub

    Private Sub LBLcontador_de_contraseña_Click(sender As Object, e As EventArgs) Handles LBLcontador_de_contraseña.Click

        GENERAR_CONTRASEÑA_AUTOMATICA()
    End Sub

    Private Sub tver_Click(sender As Object, e As EventArgs) Handles tver.Click
        GENERAR_CONTRASEÑA_AUTOMATICA()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        PanelIcono.Visible = False

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub PanelIcono_Paint(sender As Object, e As PaintEventArgs) Handles PanelIcono.Paint

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub ActivarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivarUsuarioToolStripMenuItem.Click
        Try
            estado = datalistado.SelectedCells.Item(9).Value
            If estado = "ELIMINADO" Then
                restaurar_usuarios()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class