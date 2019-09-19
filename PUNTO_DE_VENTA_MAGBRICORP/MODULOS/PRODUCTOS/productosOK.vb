Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Globalization

Public Class productosOK
    Dim DTc As New DataTable
    Dim DTe As New DataTable
    Dim DTt As New DataTable
    Dim dtlinea As New DataTable
    Dim dttipo As New DataTable
    Dim panel As New PanelExtended




    Sub LISTARPRODUCTOSNUEVOS()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("MOSTRAR_PRODUCTOS_NUEVOS", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@DESCRIPCION", txtdescripcion.Text)
            da.Fill(dt)
            datalistadoProductosNuevos.DataSource = dt
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try

    End Sub



    Sub Listar()
        'Dim dt As New DataTable
        'Dim da As SqlDataAdapter
        'Try
        '    abrir()
        '    da = New SqlDataAdapter("mostrar_Producto1", conexion)
        '    da.Fill(dt)
        '    datalistado.DataSource = dt
        '    Cerrar()
        '    datalistado.Columns(2).Visible = False
        '    datalistado.Columns(7).Visible = False
        '    datalistado.Columns(10).Visible = False
        '    datalistado.Columns(15).Visible = False
        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try

        'Multilinea(datalistado)
        'Contar_productos()
        'sumar_costo_de_inventario()
    End Sub
    Sub mostrar_descripcion_produco_sin_repetir()
        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("mostrar_descripcion_produco_sin_repetir", conexion)
            daListarpresentacionesagregadas.SelectCommand.CommandType = 4


            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@buscar", txtdescripcion.Text)

            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            DATALISTADO_PRODUCTOS_OKA.DataSource = dtDATALISTADO_AGREGANDO
            DATALISTADO_PRODUCTOS_OKA.Columns(1).Width = 500

            Cerrar()
        Catch ex As Exception
        End Try




    End Sub
    Sub mostrar_Empresa_igv()
        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("mostrar_Empresa_igv", conexion)
            daListarpresentacionesagregadas.SelectCommand.CommandType = 4


            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@empresa", VENTAS_MENU_PRINCIPAL.LBLempresa.Text)

            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            datalistado_empresa.DataSource = dtDATALISTADO_AGREGANDO


            Cerrar()
        Catch ex As Exception
        End Try




    End Sub


    Sub LIMPIAR()
        txtidproducto.Text = ""
        txtdescripcion.Text = ""
        txtcosto.Text = 0
        TXTPRECIODEVENTA2.Text = 0
        txtpreciomayoreo.Text = 0
        txtgrupo.Text = ""

        agranel.Checked = False
        txtstockminimo.Text = 0
        txtstock2.Text = 0
        lblEstadoCodigo.Text = "NUEVO"
    End Sub

    Sub buscar()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("buscar_producto_por_descripcion", conexion)
        Try
            abrir()
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtbusca.Text)
            da.Fill(dt)
            datalistado.DataSource = dt
            Cerrar()
            datalistado.Columns(2).Visible = False
            datalistado.Columns(7).Visible = False
            datalistado.Columns(10).Visible = False
            datalistado.Columns(15).Visible = False
            datalistado.Columns(16).Visible = False
        Catch ex As Exception
        End Try

        Multilinea(datalistado)

        sumar_costo_de_inventario_CONTAR_PRODUCTOS()
    End Sub

    Private Sub txtbusca_TextChanged(sender As Object, e As EventArgs) Handles txtbusca.TextChanged
        If txtbusca.Text <> "" Then
            buscar()
        ElseIf txtbusca.Text = "" Then

        End If



    End Sub


    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim result As DialogResult

            result = MessageBox.Show("¿Realmente desea eliminar este Producto?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                Dim cmd As SqlCommand
                Try
                    For Each row As DataGridViewRow In datalistado.SelectedRows

                        Dim onekey As Integer = Convert.ToInt32(row.Cells("Id_Producto1").Value)
                        Try

                            Try

                                abrir()
                                cmd = New SqlCommand("eliminar_Producto1", conexion)
                                cmd.CommandType = 4

                                cmd.Parameters.AddWithValue("@id", onekey)

                                cmd.ExecuteNonQuery()
                                Cerrar()
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try

                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try

                    Next
                    Call buscar()


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If



        End If
        If e.ColumnIndex = Me.datalistado.Columns.Item("Editar").Index Then
            proceso_para_obtener_datos_de_productos()

        End If
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

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        txtmsbox.Text = "Se ha activado la eliminacion de registros"
        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("Id_Producto1").Value)

                        Try

                            abrir()
                            cmd = New SqlCommand("eliminar_Producto1", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@id", onekey)

                            cmd.ExecuteNonQuery()

                            Cerrar()

                            '

                        Catch ex As Exception 'MsgBox(ex.Message)

                        End Try

                    End If

                Next

                Call sumar_costo_de_inventario_CONTAR_PRODUCTOS()



            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub




    Private Sub Apagadado_Click(sender As Object, e As EventArgs) Handles Apagado.Click
        If TXTIDPRODUCTOOk.Text <> 0 Then
            Dim CMD As SqlCommand
            Try
                abrir()
                CMD = New SqlCommand("editar_Producto1_SIN_CONTROL_DE_INVENTARIO", conexion)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@Id_Producto1", TXTIDPRODUCTOOk.Text)
                CMD.Parameters.AddWithValue("@Stock", txtstock2.Text)
                CMD.Parameters.AddWithValue("@Stock_minimo", txtstockminimo.Text)
                CMD.Parameters.AddWithValue("@Usa_inventarios", "SI")
                If No_aplica_fecha.Checked = True Then
                    CMD.Parameters.AddWithValue("@Fecha_de_vencimiento", txtfechaoka.Text)
                ElseIf No_aplica_fecha.Checked = False Then
                    CMD.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA")
                End If

                CMD.ExecuteNonQuery()
                Cerrar()

            Catch ex As Exception

            End Try
        End If

        TimerEncendido.Start()
    End Sub
    Private Sub TimerEncendido_Tick(sender As Object, e As EventArgs) Handles TimerEncendido.Tick

        If ProgressEncendido.Value < 100 Then
            ProgressEncendido.Value = ProgressEncendido.Value + 11
            Encendido.Visible = False
            Apagado.Visible = False
            Encendido2.Visible = False
            Apagado2.Visible = False
            gif_apagado.Visible = False
            gif_encendido.Visible = True
        Else
            ProgressEncendido.Value = 0
            TimerEncendido.Stop()
            Encendido.Visible = True
            gif_encendido.Visible = False
            PANELINVENTARIO.Visible = True




        End If
    End Sub


    Private Sub Encendido_Click(sender As Object, e As EventArgs) Handles Encendido.Click


        Try
            If TXTIDPRODUCTOOk.Text = 0 Then
                TimerApagado.Start()
            End If
        Catch ex As Exception

        End Try

        Try
            If TXTIDPRODUCTOOk.Text * 1 <> 0 And txtstock2.Text * 1 > 0 Then
                Dim result2 As DialogResult
                result2 = MessageBox.Show("Hay Aun En Stock, Dirijete al Modulo Inventarios para Ajustar el Inventario a cero", "Stock Existente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            End If
        Catch ex As Exception

        End Try

        Try
            If TXTIDPRODUCTOOk.Text * 1 <> 0 And txtstock2.Text * 1 = 0 Then
                Dim CMD As SqlCommand
                Try
                    abrir()
                    CMD = New SqlCommand("editar_Producto1_SIN_CONTROL_DE_INVENTARIO", conexion)
                    CMD.CommandType = CommandType.StoredProcedure
                    CMD.Parameters.AddWithValue("@Id_Producto1", TXTIDPRODUCTOOk.Text)
                    CMD.Parameters.AddWithValue("@Stock", "Ilimitado")
                    CMD.Parameters.AddWithValue("@Stock_minimo", 0)
                    CMD.Parameters.AddWithValue("@Usa_inventarios", "NO")
                    CMD.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA")
                    CMD.ExecuteNonQuery()
                    Cerrar()
                    TimerApagado.Start()
                    txtstock2.Text = 0
                    txtstockminimo.Text = 0
                    No_aplica_fecha.Checked = False
                    Panel25.Enabled = False
                Catch ex As Exception

                End Try
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub TimerApagado_Tick(sender As Object, e As EventArgs) Handles TimerApagado.Tick




        If ProgressApagado.Value < 100 Then
            ProgressApagado.Value = ProgressApagado.Value + 20
            Encendido.Visible = False
            Apagado.Visible = False
            Encendido2.Visible = False
            Apagado2.Visible = False
            gif_apagado.Visible = True
            gif_encendido.Visible = False
        Else
            gif_apagado.Visible = False
            Apagado2.Visible = True
            ProgressApagado.Value = 0
            TimerApagado.Stop()
            PANELINVENTARIO.Visible = False

        End If
    End Sub



    Private Sub Apagado2_Click(sender As Object, e As EventArgs) Handles Apagado2.Click

        TimerEncendido.Start()

    End Sub
    Sub REGISTRO_CORRECTO(ByVal fin As Integer)

        Dim NBotones As Integer = 3

        Dim b As New Label()
        Dim P2 As New Panel
        'Dim I1 As New PictureBox


        b.Text = "REGISTRO GUARDADO CORRECTAMENTE"
        b.Size = New System.Drawing.Size(430, 35)

        b.BackColor = BackColor
        b.FlatStyle = FlatStyle.Flat
        b.BackColor = Color.Transparent
        b.ForeColor = Color.Black
        b.Dock = DockStyle.Fill
        b.Font = New Font("Segoe UI", 12, FontStyle.Regular Or
        FontStyle.Bold)
        b.TextAlign = ContentAlignment.MiddleCenter
        'I1.BackgroundImage = My.Resources.correcto_simbolo
        'I1.BackgroundImageLayout = ImageLayout.Zoom
        'I1.Size = New System.Drawing.Size(90, 69)
        'I1.Dock = DockStyle.Left
        'I1.BackColor = Color.Transparent
        panel.Size = New System.Drawing.Size(430, 67)
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.Dock = DockStyle.Top
        panel.BackColor = Color.FromArgb(8, 198, 91)


        panel.Controls.Add(b)
        'panel.Controls.Add(I1)
        panel.Dock = DockStyle.Top
        panel.SendToBack()



    End Sub

    Sub sumar_costo_de_inventario_CONTAR_PRODUCTOS()
        Dim resultado As String
        Dim queryMoneda As String
        queryMoneda = "SELECT Moneda  FROM EMPRESA"
        Dim comMoneda As New SqlCommand(queryMoneda, conexion)
        Try
            abrir()
            resultado = (comMoneda.ExecuteScalar()) 'asignamos el valor del importe
            Cerrar()
        Catch ex As Exception
            resultado = ""
        End Try

        Dim importe As String
        Dim query As String
        query = "SELECT      CONVERT(NUMERIC(18,2),sum(Producto1.Precio_de_compra * Stock )) as suma FROM  Producto1 where  Usa_inventarios ='SI'"
        Dim com As New SqlCommand(query, conexion)
        Try
            abrir()
            importe = (com.ExecuteScalar()) 'asignamos el valor del importe
            Cerrar()
            lblcosto_inventario.Text = resultado & " " & importe
        Catch ex As Exception
            lblcosto_inventario.Text = resultado & " " & 0
        End Try

        Dim conteoresultado As String
        Dim querycontar As String
        querycontar = "select count(Id_Producto1 ) from Producto1 "
        Dim comcontar As New SqlCommand(querycontar, conexion)
        Try
            abrir()
            conteoresultado = (comcontar.ExecuteScalar()) 'asignamos el valor del importe
            Cerrar()
            lblcantidad_productos.Text = conteoresultado
        Catch ex As Exception
            conteoresultado = ""
            lblcantidad_productos.Text = 0
        End Try

    End Sub
    Sub mostra_moneda_de_empresa()

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

    Private Sub productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        PANELDEPARTAMENTO.Visible = False
        mostrar_Empresa_igv()


        Try

            txtnumeroigv.Text = datalistado_empresa.SelectedCells.Item(1).Value
            txtigv.Text = datalistado_empresa.SelectedCells.Item(2).Value
            txtigv2.Text = txtnumeroigv.Text
            lbligvcalculo.Text = "+ " & txtigv.Text
        Catch ex As Exception

        End Try

        Try
            If txtnumeroigv.Text = 0 Then
                txtigv.Visible = False

            End If
            If txtnumeroigv.Text <> 0 Then
                txtigv.Visible = True

            End If
        Catch ex As Exception

        End Try

        txtdescripcion.AutoCompleteCustomSource = DataHelper.LoadAutoComplete
        txtdescripcion.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtdescripcion.AutoCompleteSource = AutoCompleteSource.CustomSource
        Panel2.Visible = False
        txtbusca.Visible = True
        MenuStrip2.Visible = True
        datalistado.Enabled = True

        LIMPIAR()
        'Listar()
        NuevoRegistroToolStripMenuItem.Visible = False
        txtbusca.Text = "Buscar..."
        sumar_costo_de_inventario_CONTAR_PRODUCTOS()
        buscar()
    End Sub

    Private Sub NuevoRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs)
        LIMPIAR()
        sumar_costo_de_inventario_CONTAR_PRODUCTOS()


    End Sub
    Sub agregar_formato_de_moneda()
        Try

            mostra_moneda_de_empresa()
            TXTPRECIODEVENTA2.Text = lblmoneda.Text & " " & Format(Convert.ToDouble(TXTPRECIODEVENTA2.Text), "#,###,###,#0.00")


        Catch ex As Exception

        End Try

    End Sub
    Sub proceso_para_obtener_datos_de_productos()
        Try

            Panel25.Enabled = True
            DATALISTADO_PRODUCTOS_OKA.Visible = False

            Panel6.Visible = False
            TGUARDAR.Visible = False
            TGUARDARCAMBIOS.Visible = True
            PANELDEPARTAMENTO.Visible = True
            MenuStrip2.Visible = False


            NuevoRegistroToolStripMenuItem.Visible = True
            txtmsbox.Text = "Se ha activado la modificacion de registros   "
            TXTIDPRODUCTOOk.Text = datalistado.SelectedCells.Item(2).Value
            lblEstadoCodigo.Text = "EDITAR"
            datalistadoGrupos.Visible = False
            BtnGuardarCambios.Visible = False
            btnGuardar_grupo.Visible = False
            BtnCancelar.Visible = False
            btnNuevoGrupo.Visible = True

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try

            txtidproducto.Text = datalistado.SelectedCells.Item(2).Value
            txtcodigodebarras.Text = datalistado.SelectedCells.Item(3).Value
            txtgrupo.Text = datalistado.SelectedCells.Item(4).Value

            txtdescripcion.Text = datalistado.SelectedCells.Item(5).Value
            txtnumeroigv.Text = datalistado.SelectedCells.Item(6).Value
            lblIdGrupo.Text = datalistado.SelectedCells.Item(15).Value
            Try
                If txtnumeroigv.Text = 0 Then
                    txtigv.Checked = False
                End If
                If txtnumeroigv.Text <> 0 Then
                    txtigv.Checked = True

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            LBL_ESSERVICIO.Text = datalistado.SelectedCells.Item(7).Value



            txtcosto.Text = datalistado.SelectedCells.Item(8).Value
            txtpreciomayoreo.Text = datalistado.SelectedCells.Item(9).Value
            LBLSEVENDEPOR.Text = datalistado.SelectedCells.Item(10).Value
            If LBLSEVENDEPOR.Text = "Unidad" Then
                porunidad.Checked = True

            End If
            If LBLSEVENDEPOR.Text = "Granel" Then
                agranel.Checked = True
            End If
            txtstockminimo.Text = datalistado.SelectedCells.Item(11).Value
            lblfechasvenci.Text = datalistado.SelectedCells.Item(12).Value
            If lblfechasvenci.Text = "NO APLICA" Then
                No_aplica_fecha.Checked = True
            End If
            If lblfechasvenci.Text <> "NO APLICA" Then
                No_aplica_fecha.Checked = False
            End If
            txtstock2.Text = datalistado.SelectedCells.Item(13).Value
            TXTPRECIODEVENTA2.Text = datalistado.SelectedCells.Item(14).Value
            Try

                Dim TotalVentaVariabledouble As Double
                TotalVentaVariabledouble = ((TXTPRECIODEVENTA2.Text * 1 - txtcosto.Text * 1) / (txtcosto.Text * 1)) * 100

                If TotalVentaVariabledouble > 0 Then
                    Me.txtPorcentajeGanancia.Text = TotalVentaVariabledouble
                Else
                    'Me.txtPorcentajeGanancia.Text = 0
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            If LBL_ESSERVICIO.Text = "SI" Then
                Encendido.Visible = True
                Apagado.Visible = False
                Encendido2.Visible = False
                Apagado2.Visible = False
                gif_apagado.Visible = False
                gif_encendido.Visible = False
                PANELINVENTARIO.Visible = True
                PANELINVENTARIO.Visible = True
                txtstock2.ReadOnly = True

            End If
            If LBL_ESSERVICIO.Text = "NO" Then
                Apagado2.Visible = True
                Encendido.Visible = False
                Apagado.Visible = False
                Encendido2.Visible = False
                gif_apagado.Visible = False
                gif_encendido.Visible = False
                PANELINVENTARIO.Visible = False
                PANELINVENTARIO.Visible = False
                txtstock2.ReadOnly = True
                txtstock2.Text = 0
                txtstockminimo.Text = 0
                No_aplica_fecha.Checked = True
                txtstock2.ReadOnly = False
            End If
            txtapartirde.Text = datalistado.SelectedCells.Item(16).Value
            agregar_formato_de_moneda()


            datalistadoGrupos.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        proceso_para_obtener_datos_de_productos()

    End Sub





    Private Sub txtgrupo_SelectedIndexChanged(sender As Object, e As EventArgs)
        With txtidlinea
            .DataSource = dtlinea
            .DisplayMember = "Idline"
            .ValueMember = "Idline"
        End With
    End Sub

    Private Sub datalistado_KeyDown(sender As Object, e As KeyEventArgs) Handles datalistado.KeyDown
        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True

            SendKeys.Send("{TAB}")
            Try
                DATALISTADO_PRODUCTOS_OKA.Visible = False

                Panel6.Visible = False
                TGUARDAR.Visible = False
                TGUARDARCAMBIOS.Visible = True
                PANELDEPARTAMENTO.Visible = True
                MenuStrip2.Visible = False


                NuevoRegistroToolStripMenuItem.Visible = True
                txtmsbox.Text = "Se ha activado la modificacion de registros   "
                TXTIDPRODUCTOOk.Text = datalistado.SelectedCells.Item(1).Value




            Catch ex As Exception

            End Try

            Try

                txtidproducto.Text = datalistado.SelectedCells.Item(1).Value

                txtcodigodebarras.Text = datalistado.SelectedCells.Item(2).Value
                txtgrupo.Text = datalistado.SelectedCells.Item(3).Value
                txtdescripcion.Text = datalistado.SelectedCells.Item(4).Value
                txtnumeroigv.Text = datalistado.SelectedCells.Item(5).Value
                Try
                    If txtnumeroigv.Text = 0 Then
                        txtigv.Checked = False
                    End If
                    If txtnumeroigv.Text <> 0 Then
                        txtigv.Checked = True

                    End If
                Catch ex As Exception

                End Try

                LBL_ESSERVICIO.Text = datalistado.SelectedCells.Item(6).Value

                If LBL_ESSERVICIO.Text = "SI" Then
                    Encendido.Visible = True
                    Apagado.Visible = False
                    Encendido2.Visible = False
                    Apagado2.Visible = False
                    gif_apagado.Visible = False
                    gif_encendido.Visible = False
                    PANELINVENTARIO.Visible = True
                    PANELINVENTARIO.Visible = True
                    txtstock2.ReadOnly = True

                End If
                If LBL_ESSERVICIO.Text = "NO" Then
                    Apagado2.Visible = True
                    Encendido.Visible = False
                    Apagado.Visible = False
                    Encendido2.Visible = False
                    gif_apagado.Visible = False
                    gif_encendido.Visible = False
                    PANELINVENTARIO.Visible = False
                    PANELINVENTARIO.Visible = False
                    txtstock2.ReadOnly = False
                End If


                txtcosto.Text = datalistado.SelectedCells.Item(7).Value
                txtpreciomayoreo.Text = datalistado.SelectedCells.Item(8).Value
                LBLSEVENDEPOR.Text = datalistado.SelectedCells.Item(9).Value
                If LBLSEVENDEPOR.Text = "Unidad" Then
                    porunidad.Checked = True

                End If
                If LBLSEVENDEPOR.Text = "Granel" Then
                    agranel.Checked = True
                End If
                txtstockminimo.Text = datalistado.SelectedCells.Item(10).Value
                lblfechasvenci.Text = datalistado.SelectedCells.Item(11).Value
                If lblfechasvenci.Text = "NO APLICA" Then
                    No_aplica_fecha.Checked = True
                End If
                If lblfechasvenci.Text <> "NO APLICA" Then
                    No_aplica_fecha.Checked = False
                End If
                txtstock2.Text = datalistado.SelectedCells.Item(12).Value
                TXTPRECIODEVENTA2.Text = datalistado.SelectedCells.Item(13).Value



                'imagenrs.BackgroundImage = Nothing
                'Dim brs() As Byte = datalistado.SelectedCells.Item(9).Value
                'Dim msrs As New IO.MemoryStream(brs)
                'imagenrs.Image = Image.FromStream(msrs)
                'imagenrs.SizeMode = PictureBoxSizeMode.StretchImage



                'imagenft.BackgroundImage = Nothing
                'Dim bft() As Byte = datalistado.SelectedCells.Item(4).Value
                'Dim msft As New IO.MemoryStream(bft)
                'imagenft.Image = Image.FromStream(msft)
                'imagenft.SizeMode = PictureBoxSizeMode.StretchImage






            Catch ex As Exception
            End Try
        End If
        If (e.KeyCode = Keys.Delete) Then


            Dim result As DialogResult
            Dim cmd As SqlCommand
            result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                Try
                    For Each row As DataGridViewRow In datalistado.SelectedRows
                        'Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                        'datalistado.Rows.Remove(datalistado.CurrentRow)


                        'If datalistado.SelectedCells.Item(6).Value Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("Id_Producto1").Value)

                        Try

                            abrir()
                            cmd = New SqlCommand("eliminar_Producto1", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@id", onekey)

                            cmd.ExecuteNonQuery()

                            Cerrar()
                        Catch ex As Exception 'MsgBox(ex.Message)

                        End Try

                        'End If

                    Next

                    Call sumar_costo_de_inventario_CONTAR_PRODUCTOS()

                    Timer2.Start()


                Catch ex As Exception
                    'MsgBox(ex.Message)

                End Try
            Else
                MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If


        End If


    End Sub



    Private Sub txttipodeproducto_SelectedIndexChanged(sender As Object, e As EventArgs)
        With txtidtipodeproducto
            .DataSource = dttipo
            .DisplayMember = "Id_tipo_de_producto"
            .ValueMember = "Id_tipo_de_producto"
        End With
    End Sub
    Private Sub ToolStripMenuItem19_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem19.Click
        Panel8.Visible = False

    End Sub


    Private Sub VOLVERToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Panel6.Visible = False

    End Sub


    Private Sub TXTPRECIODEVENTA2_Click(sender As Object, e As EventArgs) Handles TXTPRECIODEVENTA2.Click
        'Panel21.Visible = True
        'Panel18.Visible = True

        'Panel22.Visible = False

        'Try
        '    If txtigv.Checked = True Then
        '        txtigv2.Visible = True
        '        lbligvcalculo.Visible = True
        '        txtprecio_sin_impuestos.Text = TXTPRECIODEVENTA2.Text
        '        txtigv2.Text = 0
        '        txtigv2.Text = (txtnumeroigv.Text * 1 * TXTPRECIODEVENTA2.Text * 1) / 100
        '        txtprecio_sin_impuestos.Text = TXTPRECIODEVENTA2.Text * 1 - txtigv2.Text * 1
        '        txtpreciofinal.Text = txtigv2.Text * 1 + txtprecio_sin_impuestos.Text * 1

        '        txtigv2.Text = Format(CType(txtigv2.Text, Decimal), "##0.00")
        '        txtpreciofinal.Text = Format(CType(txtpreciofinal.Text, Decimal), "##0.00")
        '    End If
        '    If txtigv.Checked = False Then
        '        txtprecio_sin_impuestos.Text = TXTPRECIODEVENTA2.Text
        '        txtigv2.Text = 0
        '        txtigv2.Visible = False
        '        lbligvcalculo.Visible = False
        '        txtpreciofinal.Text = txtprecio_sin_impuestos.Text * 1
        '        txtpreciofinal.Text = Format(CType(txtpreciofinal.Text, Decimal), "##0.00")
        '    End If

        'Catch ex As Exception

        'End Try

        Try

            Dim TotalVentaVariabledouble As Double
            TotalVentaVariabledouble = ((TXTPRECIODEVENTA2.Text * 1 - txtcosto.Text * 1) / (txtcosto.Text * 1)) * 100
            Me.txtPorcentajeGanancia.Text = TotalVentaVariabledouble
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TXTPRECIODEVENTA2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPRECIODEVENTA2.KeyPress

        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(TXTPRECIODEVENTA2, e)
    End Sub


    Private Sub TXTPRECIODEVENTA2_TextChanged(sender As Object, e As EventArgs) Handles TXTPRECIODEVENTA2.TextChanged
        TimerCalcular_precio_venta.Stop()


        TimerCalucular_porcentaje_ganancia.Start()
        TimerCalcular_precio_venta.Stop()



        'Try
        '    txtPorcentajeGanancia.Value = (TXTPRECIODEVENTA2.Text * 1 - txtcosto.Text * 1) / (txtcosto.Text * 1)

        'Catch ex As Exception
        '    'txtPorcentajeGanancia.Value = 0
        'End Try
        'Try
        '    If txtigv.Checked = True Then
        '        txtigv2.Visible = True
        '        lbligvcalculo.Visible = True

        '        txtigv2.Text = 0
        '        txtigv2.Text = (txtnumeroigv.Text * 1 * TXTPRECIODEVENTA2.Text * 1) / 100
        '        txtprecio_sin_impuestos.Text = TXTPRECIODEVENTA2.Text * 1 - txtigv2.Text * 1
        '        txtpreciofinal.Text = txtigv2.Text * 1 + txtprecio_sin_impuestos.Text * 1

        '        txtigv2.Text = Format(CType(txtigv2.Text, Decimal), "##0.00")
        '        txtpreciofinal.Text = Format(CType(txtpreciofinal.Text, Decimal), "##0.00")
        '    End If
        '    If txtigv.Checked = False Then
        '        txtprecio_sin_impuestos.Text = TXTPRECIODEVENTA2.Text
        '        txtigv2.Text = 0
        '        txtigv2.Visible = False
        '        lbligvcalculo.Visible = False
        '        txtpreciofinal.Text = txtprecio_sin_impuestos.Text * 1
        '        txtpreciofinal.Text = Format(CType(txtpreciofinal.Text, Decimal), "##0.00")
        '    End If

        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub txtcosto_Click(sender As Object, e As EventArgs) Handles txtcosto.Click
        Panel22.Visible = False
        Panel21.Visible = False
        Panel18.Visible = False
    End Sub

    Private Sub txtcosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcosto.KeyPress

        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then

            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtcosto, e)
    End Sub

    Private Sub txtcosto_TextChanged(sender As Object, e As EventArgs) Handles txtcosto.TextChanged
        Panel22.Visible = False
        Panel21.Visible = False
        Panel18.Visible = False

    End Sub



    Private Sub txtdescripcion_Click(sender As Object, e As EventArgs) Handles txtdescripcion.Click
        DATALISTADO_PRODUCTOS_OKA.Visible = True
        Panel22.Visible = False
        Panel21.Visible = False
        Panel18.Visible = False
    End Sub
    Private Sub contar()
        Dim x As Integer
        x = DATALISTADO_PRODUCTOS_OKA.Rows.Count
        txtcontador.Text = CStr(x)
    End Sub
    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged
        Panel22.Visible = False
        Panel21.Visible = False
        Panel18.Visible = False
        mostrar_descripcion_produco_sin_repetir()
        contar()


        If txtcontador.Text = 0 Then
            DATALISTADO_PRODUCTOS_OKA.Visible = False
        End If
        If txtcontador.Text > 0 Then
            DATALISTADO_PRODUCTOS_OKA.Visible = True
        End If
        If TGUARDAR.Visible = False Then
            DATALISTADO_PRODUCTOS_OKA.Visible = False
        End If

    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        datalistadoGrupos.Visible = True
        btnGuardar_grupo.Visible = False
        BtnGuardarCambios.Visible = False
        BtnCancelar.Visible = False
        btnNuevoGrupo.Visible = True
        mostrar_grupos()

        txtapartirde.Text = 0
        txtstock2.ReadOnly = False
        Panel25.Enabled = True
        Panel21.Visible = False
        Panel22.Visible = False
        Panel18.Visible = False
        TXTIDPRODUCTOOk.Text = 0
        Encendido.Visible = True
        Apagado.Visible = False
        Encendido2.Visible = False
        Apagado2.Visible = False
        gif_apagado.Visible = False
        gif_encendido.Visible = False
        PANELINVENTARIO.Visible = True
        txtdescripcion.AutoCompleteCustomSource = DataHelper.LoadAutoComplete
        txtdescripcion.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtdescripcion.AutoCompleteSource = AutoCompleteSource.CustomSource
        PANELDEPARTAMENTO.Visible = True
        porunidad.Checked = True
        noconsiderarinventario.Checked = True
        No_aplica_fecha.Checked = False
        Panel6.Visible = False

        NuevoRegistroToolStripMenuItem.Visible = True
        LIMPIAR()
        txtmsbox.Text = "Se ha activado  registro  nuevo "
        btnagregaryguardar.Visible = True
        btnagregar.Visible = False


        txtdescripcion.Text = ""
        PANELINVENTARIO.Visible = True

        Encendido.Visible = True
        Apagado.Visible = False
        Encendido2.Visible = False
        Apagado2.Visible = False
        gif_apagado.Visible = False
        gif_encendido.Visible = False


        TGUARDAR.Visible = True
        TGUARDARCAMBIOS.Visible = False

    End Sub

    Private Sub lblcostoUnt_TextChanged(sender As Object, e As EventArgs) Handles lblcostoUnt.TextChanged
        Try
            txtcosto.Text = lblcostoUnt.Text * 1 * txtcantidad_de_unidad_de_medidaoka.Text * 1

        Catch ex As Exception
            lblcostoUnt.Text = 0
        End Try
    End Sub

    Private Sub PANELDEPARTAMENTO_MouseMove(sender As Object, e As MouseEventArgs) Handles PANELDEPARTAMENTO.MouseMove
        DATALISTADO_PRODUCTOS_OKA.Visible = False


    End Sub


    Private Sub DATALISTADO_PRODUCTOS_OKA_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_PRODUCTOS_OKA.CellClick, datalistado_empresa.CellClick
        Try
            txtdescripcion.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells.Item(1).Value
            DATALISTADO_PRODUCTOS_OKA.Visible = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DATALISTADO_PRODUCTOS_OKA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_PRODUCTOS_OKA.CellContentClick, datalistado_empresa.CellContentClick

    End Sub

    Private Sub txtpreciomayoreo_Click(sender As Object, e As EventArgs) Handles txtpreciomayoreo.Click, txtapartirde.Click
        Panel21.Visible = False
        Panel22.Visible = True
        Panel18.Visible = True

        Try
            If txtigv.Checked = True Then
                txtigv2.Visible = True
                lbligvcalculo.Visible = True

                txtigv2.Text = 0
                txtigv2.Text = (txtnumeroigv.Text * 1 * txtpreciomayoreo.Text * 1) / 100
                txtprecio_sin_impuestos.Text = txtpreciomayoreo.Text * 1 - txtigv2.Text * 1
                txtpreciofinal.Text = txtigv2.Text * 1 + txtprecio_sin_impuestos.Text * 1

                txtigv2.Text = Format(CType(txtigv2.Text, Decimal), "##0.00")
                txtpreciofinal.Text = Format(CType(txtpreciofinal.Text, Decimal), "##0.00")
            End If
            If txtigv.Checked = False Then
                txtprecio_sin_impuestos.Text = txtpreciomayoreo.Text
                txtigv2.Text = 0
                txtigv2.Visible = False
                lbligvcalculo.Visible = False
                txtpreciofinal.Text = txtprecio_sin_impuestos.Text * 1
                txtpreciofinal.Text = Format(CType(txtpreciofinal.Text, Decimal), "##0.00")
            End If

        Catch ex As Exception

        End Try
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
    Private Sub txtpreciomayoreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpreciomayoreo.KeyPress

        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtpreciomayoreo, e)
    End Sub

    Private Sub txtpreciomayoreo_MouseMove(sender As Object, e As MouseEventArgs) Handles txtpreciomayoreo.MouseMove

    End Sub

    Private Sub txtpreciomayoreo_TextChanged(sender As Object, e As EventArgs) Handles txtpreciomayoreo.TextChanged

        'Try
        '    If txtigv.Checked = True Then
        '        txtigv2.Visible = True
        '        lbligvcalculo.Visible = True

        '        txtigv2.Text = 0
        '        txtigv2.Text = (txtnumeroigv.Text * 1 * txtpreciomayoreo.Text * 1) / 100
        '        txtprecio_sin_impuestos.Text = txtpreciomayoreo.Text * 1 - txtigv2.Text * 1
        '        txtpreciofinal.Text = txtigv2.Text * 1 + txtprecio_sin_impuestos.Text * 1

        '        txtigv2.Text = Format(CType(txtigv2.Text, Decimal), "##0.00")
        '        txtpreciofinal.Text = Format(CType(txtpreciofinal.Text, Decimal), "##0.00")
        '    End If
        '    If txtigv.Checked = False Then
        '        txtprecio_sin_impuestos.Text = txtpreciomayoreo.Text
        '        txtigv2.Text = 0
        '        txtigv2.Visible = False
        '        lbligvcalculo.Visible = False
        '        txtpreciofinal.Text = txtprecio_sin_impuestos.Text * 1
        '        txtpreciofinal.Text = Format(CType(txtpreciofinal.Text, Decimal), "##0.00")
        '    End If

        'Catch ex As Exception

        'End Try
        Try

        Catch ex As Exception
            txtapartirde.Text = 0
        End Try
    End Sub

    Private Sub txtcodigodebarras_Click(sender As Object, e As EventArgs) Handles txtcodigodebarras.Click
        Panel22.Visible = False
        Panel21.Visible = False
        Panel18.Visible = False
    End Sub

    Private Sub txtcodigodebarras_TextChanged(sender As Object, e As EventArgs) Handles txtcodigodebarras.TextChanged
        Panel22.Visible = False
        Panel21.Visible = False
        Panel18.Visible = False
    End Sub

    Private Sub txtstock2_Click(sender As Object, e As EventArgs) Handles txtstock2.Click
        Panel22.Visible = False
        Panel21.Visible = False
        Panel18.Visible = False

    End Sub

    Private Sub txtstock2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstock2.KeyPress

        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then

            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)
        End If
        NumerosyDecimal(txtstock2, e)
    End Sub

    Private Sub txtstock2_MouseClick(sender As Object, e As MouseEventArgs) Handles txtstock2.MouseClick
        Try
            If TXTIDPRODUCTOOk.Text <> 0 Then
                Tmensajes.SetToolTip(txtstock2, "Para modificar el Stock Hazlo desde el Modulo de Inventarios")
                Tmensajes.ToolTipTitle = "Accion denegada"
                Tmensajes.ToolTipIcon = ToolTipIcon.Info

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtstock2_MouseHover(sender As Object, e As EventArgs) Handles txtstock2.MouseHover
        Try
            If TXTIDPRODUCTOOk.Text <> 0 Then
                Tmensajes.SetToolTip(txtstock2, "Para modificar el Stock Hazlo desde el Modulo de Inventarios")
                Tmensajes.ToolTipTitle = "Accion denegada"
                Tmensajes.ToolTipIcon = ToolTipIcon.Info

            End If
        Catch ex As Exception

        End Try


    End Sub



    Private Sub txtstock2_TextChanged(sender As Object, e As EventArgs) Handles txtstock2.TextChanged
        Panel22.Visible = False
        Panel21.Visible = False
        Panel18.Visible = False

    End Sub

    Private Sub txtstockminimo_Click(sender As Object, e As EventArgs) Handles txtstockminimo.Click
        Panel22.Visible = False
        Panel21.Visible = False
        Panel18.Visible = False
    End Sub

    Private Sub txtstockminimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstockminimo.KeyPress

        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtstockminimo, e)
    End Sub

    Private Sub txtstockminimo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtstockminimo.KeyUp

    End Sub

    Private Sub txtstockminimo_TextChanged(sender As Object, e As EventArgs) Handles txtstockminimo.TextChanged
        Panel22.Visible = False
        Panel21.Visible = False
        Panel18.Visible = False
    End Sub

    Private Sub txtfechaoka_ValueChanged(sender As Object, e As EventArgs) Handles txtfechaoka.ValueChanged
        Panel22.Visible = False
        Panel21.Visible = False
        Panel18.Visible = False
    End Sub

    Private Sub porunidad_CheckedChanged(sender As Object, e As EventArgs) Handles porunidad.CheckedChanged
        Panel22.Visible = False
        Panel21.Visible = False
        Panel18.Visible = False
    End Sub

    Private Sub agranel_CheckedChanged(sender As Object, e As EventArgs) Handles agranel.CheckedChanged
        Panel22.Visible = False
        Panel21.Visible = False
        Panel18.Visible = False
    End Sub

    Private Sub ToolStripMenuItem11_Click_2(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        DATALISTADO_PRODUCTOS_OKA.Visible = False

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        sumar_costo_de_inventario_CONTAR_PRODUCTOS()
        Timer2.Stop()


    End Sub

    Private Sub ToolStripMenuItem15_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        MASCARA1.Show()
        Asistente_de_importacionExcel.ShowDialog()
    End Sub

    Private Sub txtigv_CheckedChanged(sender As Object, e As EventArgs) Handles txtigv.CheckedChanged
        If Panel21.Visible = True Then
            Try
                If txtigv.Checked = True Then
                    txtigv2.Visible = True
                    lbligvcalculo.Visible = True
                    txtigv2.Text = 0
                    txtigv2.Text = (txtnumeroigv.Text * 1 * TXTPRECIODEVENTA2.Text * 1) / 100
                    txtprecio_sin_impuestos.Text = TXTPRECIODEVENTA2.Text * 1 - txtigv2.Text * 1
                    txtpreciofinal.Text = txtigv2.Text * 1 + txtprecio_sin_impuestos.Text * 1

                    txtigv2.Text = Format(CType(txtigv2.Text, Decimal), "##0.00")
                    txtpreciofinal.Text = Format(CType(txtpreciofinal.Text, Decimal), "##0.00")
                End If
                If txtigv.Checked = False Then
                    txtprecio_sin_impuestos.Text = TXTPRECIODEVENTA2.Text
                    txtigv2.Text = 0
                    txtigv2.Visible = False
                    lbligvcalculo.Visible = False
                    txtpreciofinal.Text = txtprecio_sin_impuestos.Text * 1
                    txtpreciofinal.Text = Format(CType(txtpreciofinal.Text, Decimal), "##0.00")
                End If

            Catch ex As Exception

            End Try

        ElseIf Panel22.Visible = True Then
            Try
                If txtigv.Checked = True Then
                    txtigv2.Visible = True
                    lbligvcalculo.Visible = True

                    txtigv2.Text = 0
                    txtigv2.Text = (txtnumeroigv.Text * 1 * txtpreciomayoreo.Text * 1) / 100
                    txtprecio_sin_impuestos.Text = txtpreciomayoreo.Text * 1 - txtigv2.Text * 1
                    txtpreciofinal.Text = txtigv2.Text * 1 + txtprecio_sin_impuestos.Text * 1

                    txtigv2.Text = Format(CType(txtigv2.Text, Decimal), "##0.00")
                    txtpreciofinal.Text = Format(CType(txtpreciofinal.Text, Decimal), "##0.00")
                End If
                If txtigv.Checked = False Then
                    txtprecio_sin_impuestos.Text = txtpreciomayoreo.Text
                    txtigv2.Text = 0
                    txtigv2.Visible = False
                    lbligvcalculo.Visible = False
                    txtpreciofinal.Text = txtprecio_sin_impuestos.Text * 1
                    txtpreciofinal.Text = Format(CType(txtpreciofinal.Text, Decimal), "##0.00")
                End If

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub Panel22_Paint(sender As Object, e As PaintEventArgs) Handles Panel22.Paint

    End Sub
    Sub INSERTAR_KARDEX_ENTRADA()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_KARDEX_ENTRADA", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Fecha", Now())
            cmd.Parameters.AddWithValue("@Motivo", "Registro inicial de Producto")
            cmd.Parameters.AddWithValue("@Cantidad ", txtstock2.Text)
            cmd.Parameters.AddWithValue("@Id_producto", lblIdProducto.Text)
            cmd.Parameters.AddWithValue("@Id_usuario", VENTAS_MENU_PRINCIPAL.lblidusuario.Text)
            cmd.Parameters.AddWithValue("@Tipo", "ENTRADA")
            cmd.Parameters.AddWithValue("@Estado", "CONFIRMADO")
            cmd.Parameters.AddWithValue("@Id_caja", VENTAS_MENU_PRINCIPAL.lblidcaja.Text)
            cmd.ExecuteNonQuery()

            Cerrar()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub insertar_productos()
        If txtpreciomayoreo.Text = 0 Or txtpreciomayoreo.Text = "" Then txtapartirde.Text = 0
        Dim CMD As SqlCommand
        Try
            abrir()

            CMD = New SqlCommand("insertar_Producto", conexion)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text)
            CMD.Parameters.AddWithValue("@Imagen", ".")
            CMD.Parameters.AddWithValue("@Precio_de_compra", txtcosto.Text)
            CMD.Parameters.AddWithValue("@Precio_de_venta", TXTPRECIODEVENTA2.Text)
            CMD.Parameters.AddWithValue("@Codigo", txtcodigodebarras.Text)
            CMD.Parameters.AddWithValue("@A_partir_de", txtapartirde.Text)

            If txtigv.Checked = True Then
                CMD.Parameters.AddWithValue("@Impuesto", txtnumeroigv.Text)
            End If
            If txtigv.Checked = False Then
                CMD.Parameters.AddWithValue("@Impuesto", 0)
            End If

            CMD.Parameters.AddWithValue("@Precio_mayoreo", txtpreciomayoreo.Text)



            If porunidad.Checked = True Then txtse_vende_a.Text = "Unidad"
            If agranel.Checked = True Then txtse_vende_a.Text = "Granel"

            CMD.Parameters.AddWithValue("@Se_vende_a", txtse_vende_a.Text)
            CMD.Parameters.AddWithValue("@Id_grupo", lblIdGrupo.Text)
            If PANELINVENTARIO.Visible = True Then
                CMD.Parameters.AddWithValue("@Usa_inventarios", "SI")
                CMD.Parameters.AddWithValue("@Stock_minimo", txtstockminimo.Text)
                CMD.Parameters.AddWithValue("@Stock", txtstock2.Text)

                If No_aplica_fecha.Checked = True Then
                    CMD.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA")
                End If

                If No_aplica_fecha.Checked = False Then
                    CMD.Parameters.AddWithValue("@Fecha_de_vencimiento", txtfechaoka.Text)
                End If


            End If
            If PANELINVENTARIO.Visible = False Then
                CMD.Parameters.AddWithValue("@Usa_inventarios", "NO")
                CMD.Parameters.AddWithValue("@Stock_minimo", 0)
                CMD.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA")
                CMD.Parameters.AddWithValue("@Stock", "Ilimitado")

            End If
            CMD.ExecuteNonQuery()
            If PANELINVENTARIO.Visible = True Then
                LISTARPRODUCTOSNUEVOS()
                Try
                    lblIdProducto.Text = datalistadoProductosNuevos.SelectedCells.Item(1).Value
                Catch ex As Exception
                End Try
                INSERTAR_KARDEX_ENTRADA()
            End If


            PANELDEPARTAMENTO.Visible = False
            CORRECTO()
            Timer3.Start()
            VENTAS_MENU_PRINCIPAL.TimerDIBUJARCATEGORIAS.Start()
            txtbusca.Text = txtdescripcion.Text
            buscar()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TGUARDAR_Click(sender As Object, e As EventArgs) Handles TGUARDAR.Click
        If txtpreciomayoreo.Text = "" Then txtpreciomayoreo.Text = 0
        If txtapartirde.Text = "" Then txtapartirde.Text = 0
        TXTPRECIODEVENTA2.Text = TXTPRECIODEVENTA2.Text.Replace(lblmoneda.Text & " ", "")
        TXTPRECIODEVENTA2.Text = Format(CType(TXTPRECIODEVENTA2.Text, Decimal), "##0.00")
        If (txtpreciomayoreo.Text * 1 > 0 And txtapartirde.Text * 1 > 0) Or (txtpreciomayoreo.Text * 1 = 0 And txtapartirde.Text * 1 = 0) Then
            If txtcosto.Text * 1 >= TXTPRECIODEVENTA2.Text * 1 Then

                Dim result As DialogResult
                result = MessageBox.Show("El precio de Venta es menor que el COSTO, Esto Te puede Generar Perdidas", "Producto con Perdidas", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

                If result = DialogResult.OK Then
                    insertar_productos()
                Else
                    TXTPRECIODEVENTA2.Focus()
                End If


            ElseIf txtcosto.Text * 1 < TXTPRECIODEVENTA2.Text * 1 Then
                insertar_productos()
            End If
        ElseIf txtpreciomayoreo.Text * 1 <> 0 Or txtapartirde.Text * 1 <> 0 Then
            MessageBox.Show("Estas configurando Precio mayoreo, debes completar los campos de Precio mayoreo y A partir de, si no deseas configurarlo dejalos en blanco", "Datos incompletos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        End If



    End Sub

    Private Sub TGUARDARCAMBIOS_Click(sender As Object, e As EventArgs) Handles TGUARDARCAMBIOS.Click
        If txtpreciomayoreo.Text = "" Then txtpreciomayoreo.Text = 0
        If txtapartirde.Text = "" Then txtapartirde.Text = 0
        TXTPRECIODEVENTA2.Text = TXTPRECIODEVENTA2.Text.Replace(lblmoneda.Text & " ", "")
        TXTPRECIODEVENTA2.Text = Format(CType(TXTPRECIODEVENTA2.Text, Decimal), "##0.00")
        If (txtpreciomayoreo.Text * 1 > 0 And txtapartirde.Text * 1 > 0) Or (txtpreciomayoreo.Text * 1 = 0 And txtapartirde.Text * 1 = 0) Then


            If txtcosto.Text * 1 > TXTPRECIODEVENTA2.Text * 1 Then
                Dim result As DialogResult
                result = MessageBox.Show("El precio de Venta es menor que el COSTO, Esto Te puede Generar Perdidas", "Producto con Perdidas", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    editar_productos()
                Else
                    TXTPRECIODEVENTA2.Focus()
                End If



            ElseIf txtcosto.Text * 1 < TXTPRECIODEVENTA2.Text * 1 Then
                editar_productos()
            End If
        ElseIf txtpreciomayoreo.Text * 1 <> 0 Or txtapartirde.Text * 1 <> 0 Then
            MessageBox.Show("Estas configurando Precio mayoreo, debes completar los campos de Precio mayoreo y A partir de, si no deseas configurarlo dejalos en blanco", "Datos incompletos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        End If





    End Sub
    Sub editar_productos()
        If txtpreciomayoreo.Text = 0 Then txtapartirde.Text = 0
        If txtpreciomayoreo.Text = "" Then txtapartirde.Text = 0
        Dim CMD As SqlCommand
        Try
            abrir()

            CMD = New SqlCommand("editar_Producto1", conexion)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@Id_Producto1", TXTIDPRODUCTOOk.Text)
            CMD.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text)
            CMD.Parameters.AddWithValue("@Imagen", ".")
            CMD.Parameters.AddWithValue("@A_partir_de", txtapartirde.Text)

            If PANELINVENTARIO.Visible = True Then
                CMD.Parameters.AddWithValue("@Stock", txtstock2.Text)
                If No_aplica_fecha.Checked = True Then
                    CMD.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA")
                End If

                If No_aplica_fecha.Checked = False Then
                    CMD.Parameters.AddWithValue("@Fecha_de_vencimiento", txtfechaoka.Text)
                End If
            End If
            If PANELINVENTARIO.Visible = False Then
                CMD.Parameters.AddWithValue("@Stock", "Ilimitado")
                CMD.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA")

            End If

            CMD.Parameters.AddWithValue("@Precio_de_compra", txtcosto.Text)
            CMD.Parameters.AddWithValue("@Precio_de_venta", TXTPRECIODEVENTA2.Text)
            CMD.Parameters.AddWithValue("@Codigo", txtcodigodebarras.Text)
            If txtigv.Checked = True Then
                CMD.Parameters.AddWithValue("@Impuesto", txtnumeroigv.Text)
            End If
            If txtigv.Checked = False Then
                CMD.Parameters.AddWithValue("@Impuesto", 0)
            End If

            CMD.Parameters.AddWithValue("@Stock_minimo", txtstockminimo.Text)
            CMD.Parameters.AddWithValue("@Precio_mayoreo", txtpreciomayoreo.Text)



            If porunidad.Checked = True Then txtse_vende_a.Text = "Unidad"
            If agranel.Checked = True Then txtse_vende_a.Text = "Granel"

            CMD.Parameters.AddWithValue("@Se_vende_a", txtse_vende_a.Text)
            CMD.Parameters.AddWithValue("@Id_grupo", lblIdGrupo.Text)
            If PANELINVENTARIO.Visible = True Then
                CMD.Parameters.AddWithValue("@Usa_inventarios", "SI")
            End If
            If PANELINVENTARIO.Visible = False Then
                CMD.Parameters.AddWithValue("@Usa_inventarios", "NO")
            End If

            CMD.ExecuteNonQuery()

            PANELDEPARTAMENTO.Visible = False
            txtbusca.Text = txtdescripcion.Text
            buscar()
            Try
                CORRECTO()
                Timer3.Start()
                VENTAS_MENU_PRINCIPAL.TimerDIBUJARCATEGORIAS.Start()

            Catch ex As Exception

            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try







    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        PANELDEPARTAMENTO.Visible = False

    End Sub
    Sub CORRECTO()
        Me.panel.Visible = True
        panel.AutoScroll = True
        panel.Location = New System.Drawing.Point(193, 38)
        panel.Name = "Panel1"
        panel.Size = New System.Drawing.Size(455, 640)
        Me.panel.Controls.Clear()
        Me.Controls.Add(panel)
        REGISTRO_CORRECTO(fin:=1)
    End Sub
    Private Sub ToolStripMenuItem5_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click


    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 10

        Else
            ProgressBar1.Value = 0

            Me.panel.Controls.Clear()
            Me.panel.Visible = False
            Timer3.Stop()

            ProgressBar1.Value = 0

        End If
    End Sub

    Private Sub txtapartirde_TextChanged(sender As Object, e As EventArgs) Handles txtapartirde.TextChanged

    End Sub

    Private Sub txtapartirde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapartirde.KeyPress

        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then

            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtapartirde, e)
    End Sub
    Private Sub txtcodigodebarras_Enter(sender As Object, e As EventArgs) Handles txtcodigodebarras.Enter

        ' Referenciamos el control TextBox que ha desencadenado el evento
        Dim tb As TextBox = DirectCast(sender, TextBox)

        DrawRectangle(tb, Color.Red)

    End Sub

    Private Sub txtcodigodebarras_Leave(sender As Object, e As EventArgs) Handles txtcodigodebarras.Leave

        ' Referenciamos el control TextBox que ha desencadenado el evento
        Dim tb As TextBox = DirectCast(sender, TextBox)

        DrawRectangle(tb, Me.BackColor)

    End Sub

    Private Sub DrawRectangle(tb As TextBox, clr As Color)

        If (tb Is Nothing) Then Return

        Dim d As Integer = 2

        Dim pt As New Point(tb.Location.X - d, tb.Location.Y - d)
        Dim sz As New Size(tb.Width + (2 * d), tb.Height + (2 * d))

        Using g As Graphics = Me.CreateGraphics()
            Dim rect As New Rectangle(pt, sz)
            Dim p As New Pen(clr, 2)
            g.DrawRectangle(p, rect)
            p.Dispose()
        End Using

    End Sub





    Private Sub TimerCalcular_precio_venta_Tick(sender As Object, e As EventArgs) Handles TimerCalcular_precio_venta.Tick
        TimerCalcular_precio_venta.Stop()

        Try
            Dim TotalVentaVariabledouble As Double
            TotalVentaVariabledouble = (txtcosto.Text * 1) + (txtcosto.Text * 1) * ((txtPorcentajeGanancia.Text * 1) / 100)

            If TotalVentaVariabledouble > 0 And txtPorcentajeGanancia.Focused = True Then
                TXTPRECIODEVENTA2.Text = TotalVentaVariabledouble
            Else
                'txtPorcentajeGanancia.Value = 0
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub TimerCalucular_porcentaje_ganancia_Tick(sender As Object, e As EventArgs) Handles TimerCalucular_porcentaje_ganancia.Tick
        TimerCalucular_porcentaje_ganancia.Stop()

        Try

            Dim TotalVentaVariabledouble As Double
            TotalVentaVariabledouble = ((TXTPRECIODEVENTA2.Text * 1 - txtcosto.Text * 1) / (txtcosto.Text * 1)) * 100

            If TotalVentaVariabledouble > 0 And TXTPRECIODEVENTA2.Focused = True Then
                Me.txtPorcentajeGanancia.Text = TotalVentaVariabledouble
            Else
                'Me.txtPorcentajeGanancia.Text = 0
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtMiTexto_LostFocus()

    End Sub



    Private Sub Panel13_Paint(sender As Object, e As PaintEventArgs) Handles Panel13.Paint

    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label38.Click, lblIdGrupo.Click

    End Sub

    Private Sub TXTPRECIODEVENTA2_LostFocus(sender As Object, e As EventArgs) Handles TXTPRECIODEVENTA2.LostFocus
        agregar_formato_de_moneda()
    End Sub
    Sub insertar_grupo()

        Dim CMD As SqlCommand
        Try
            abrir()

            CMD = New SqlCommand("insertar_Grupo", conexion)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@Grupo", txtgrupo.Text)
            CMD.Parameters.AddWithValue("@Por_defecto", "NO")
            CMD.ExecuteNonQuery()

            Cerrar()

            mostrar_grupos()
            datalistadoGrupos.Visible = True
            lblIdGrupo.Text = datalistadoGrupos.SelectedCells.Item(2).Value
            txtgrupo.Text = datalistadoGrupos.SelectedCells.Item(3).Value


            datalistadoGrupos.Visible = False
            btnGuardar_grupo.Visible = False
            BtnGuardarCambios.Visible = False
            BtnCancelar.Visible = False
            btnNuevoGrupo.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnGuardar_Categoria_Click(sender As Object, e As EventArgs) Handles BtnGuardar_Categoria.Click
        insertar_grupo()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        PanelGrupo.Visible = False

    End Sub

    Private Sub ToolStripMenuItem21_Click(sender As Object, e As EventArgs) Handles btnNuevoGrupo.Click
        txtgrupo.Text = "Escribe el Nuevo GRUPO"
        txtgrupo.SelectAll()
        txtgrupo.Focus()

        datalistadoGrupos.Visible = False
        btnGuardar_grupo.Visible = True
        BtnGuardarCambios.Visible = False
        BtnCancelar.Visible = True
        btnNuevoGrupo.Visible = False

    End Sub

    Private Sub btnGuardar_grupo_Click(sender As Object, e As EventArgs) Handles btnGuardar_grupo.Click
        insertar_grupo()

    End Sub

    Private Sub txtgrupo_TextChanged_1(sender As Object, e As EventArgs) Handles txtgrupo.TextChanged

        mostrar_grupos()

    End Sub
    Sub mostrar_grupos()
        datalistadoGrupos.Visible = True

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_grupos", conexion)
            da.SelectCommand.CommandType = 4


            da.SelectCommand.Parameters.AddWithValue("@buscar", txtgrupo.Text)

            da.Fill(dt)
            datalistadoGrupos.DataSource = dt
            datalistadoGrupos.Columns(2).Visible = False
            datalistadoGrupos.Columns(3).Width = 500

            Cerrar()
        Catch ex As Exception
        End Try
        Multilinea(datalistadoGrupos)



    End Sub

    Private Sub BtnGuardarCambios_Click(sender As Object, e As EventArgs) Handles BtnGuardarCambios.Click
        editar_grupo()


    End Sub

    Sub editar_grupo()

        Dim CMD As SqlCommand
        Try
            abrir()

            CMD = New SqlCommand("editar_grupo", conexion)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@id", lblIdGrupo.Text)
            CMD.Parameters.AddWithValue("@Grupo", txtgrupo.Text)
            CMD.ExecuteNonQuery()
            Cerrar()
            txtgrupo.Text = ""
            mostrar_grupos()
            datalistadoGrupos.Visible = True
            btnGuardar_grupo.Visible = False
            BtnGuardarCambios.Visible = False
            BtnCancelar.Visible = False
            btnNuevoGrupo.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub datalistadoGrupos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoGrupos.CellContentClick

    End Sub

    Private Sub datalistadoGrupos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoGrupos.CellClick
        If e.ColumnIndex = Me.datalistadoGrupos.Columns.Item("EliminarG").Index Then
            Dim result As DialogResult

            result = MessageBox.Show("¿Realmente desea eliminar este Grupo?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                Dim cmd As SqlCommand
                Try
                    For Each row As DataGridViewRow In datalistadoGrupos.SelectedRows

                        Dim onekey As Integer = Convert.ToInt32(row.Cells("Idline").Value)
                        Try

                            Try

                                abrir()
                                cmd = New SqlCommand("eliminar_grupos", conexion)
                                cmd.CommandType = 4

                                cmd.Parameters.AddWithValue("@id", onekey)

                                cmd.ExecuteNonQuery()
                                Cerrar()
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try

                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try

                    Next
                    Call mostrar_grupos()



                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If



        End If
        If e.ColumnIndex = Me.datalistadoGrupos.Columns.Item("EditarG").Index Then


            Try
                lblIdGrupo.Text = datalistadoGrupos.SelectedCells.Item(2).Value
                txtgrupo.Text = datalistadoGrupos.SelectedCells.Item(3).Value
                txtgrupo.SelectAll()
                txtgrupo.Focus()

                datalistadoGrupos.Visible = False
                btnGuardar_grupo.Visible = False
                BtnGuardarCambios.Visible = True
                BtnCancelar.Visible = True
                btnNuevoGrupo.Visible = False
            Catch ex As Exception
            End Try

        End If
        If e.ColumnIndex = Me.datalistadoGrupos.Columns.Item("Grupo").Index Then
            lblIdGrupo.Text = datalistadoGrupos.SelectedCells.Item(2).Value
            txtgrupo.Text = datalistadoGrupos.SelectedCells.Item(3).Value
            datalistadoGrupos.Visible = False
            btnGuardar_grupo.Visible = False
            BtnGuardarCambios.Visible = False
            BtnCancelar.Visible = False
            btnNuevoGrupo.Visible = True
            If lblEstadoCodigo.Text = "NUEVO" Then
                GENERAR_CODIGO_DE_BARRAS_AUTOMATICO()
            End If
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        datalistadoGrupos.Visible = False
        btnGuardar_grupo.Visible = False
        BtnGuardarCambios.Visible = False
        BtnCancelar.Visible = False
        btnNuevoGrupo.Visible = True
        mostrar_grupos  
    End Sub

    Private Sub txtgrupo_Click(sender As Object, e As EventArgs) Handles txtgrupo.Click



    End Sub

    Private Sub txtPorcentajeGanancia_TextChanged(sender As Object, e As EventArgs) Handles txtPorcentajeGanancia.TextChanged
        TimerCalucular_porcentaje_ganancia.Stop()

        TimerCalcular_precio_venta.Start()
        TimerCalucular_porcentaje_ganancia.Stop()
    End Sub

    Private Sub txtPorcentajeGanancia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorcentajeGanancia.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtPorcentajeGanancia, e)
    End Sub

    Private Sub lblmoneda_Click(sender As Object, e As EventArgs) Handles lblmoneda.Click

    End Sub

    Private Sub MenuStrip15_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip15.ItemClicked

    End Sub

    Private Sub btnGenerarCodigo_Click(sender As Object, e As EventArgs) Handles btnGenerarCodigo.Click
        GENERAR_CODIGO_DE_BARRAS_AUTOMATICO()
    End Sub
    Sub GENERAR_CODIGO_DE_BARRAS_AUTOMATICO()
        txtcodigodebarras.Text = ""
        Try
            Dim importe As Double
            Dim com As New SqlCommand("SELECT max(Id_Producto1)  FROM Producto1", conexion)
            Try
                abrir()
                importe = (com.ExecuteScalar()) 'asignamos el valor del importe
                Cerrar()
            Catch ex As Exception
            End Try
            txtcodigodebarras.Text = importe + 1

        Catch ex As Exception
            txtcodigodebarras.Text = 1
        End Try

        Dim Cadena As String = txtgrupo.Text
        Dim Palabra() As String
        Palabra = Cadena.Split(" ")
        Try
            txtcodigodebarras.Text = txtcodigodebarras.Text & Palabra(0).Substring(0, 2) & 369
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub txtbusca_Click(sender As Object, e As EventArgs) Handles txtbusca.Click
        txtbusca.SelectAll()

    End Sub
End Class