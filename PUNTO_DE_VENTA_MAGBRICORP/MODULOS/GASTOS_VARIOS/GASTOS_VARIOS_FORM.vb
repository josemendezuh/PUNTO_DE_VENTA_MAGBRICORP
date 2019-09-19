

Imports System.Data.SqlClient
Imports System.IO


Public Class GASTOS_VARIOS_FORM
    Private memoria1 As Double = 0.0
    Private memoria2 As Double = 0.0
    Private signo As String
    Private dt As New DataTable
    Private Sub contar()
        Dim x As Integer
        x = datalistado.Rows.Count
        txtcontador.Text = CStr(x)
    End Sub
    Private Sub frmgastosvarios_Load(sender As Object, e As EventArgs)
        'Panel2.Visible = False
        'Me.Location = New Point(0, 135)
        'Listar()

    End Sub
    Public Sub limpiar()

        txtidgasto.Text = ""
        txtfecha.Text = ""


        txtpantalla.Text = ""
        txtobservacion.Text = ""
        datalistadogrupodegastos.Visible = False
        TXTCONCEPTO.Text = ""
        txttipocomprobante.Text = "SIN COMPROBANTE"
        txtnrocomprobante.Text = "------"
        cheknoconsiderarguiaderemision.Checked = True
        PANELCOMPROBANTE.Visible = False
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
    End Sub
    Private Sub txtidcliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtidcliente.TextChanged

    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
        Listar()


    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub datalistado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellClick
        Try
            txtidgasto.Text = datalistado.SelectedCells.Item(1).Value
            txtfecha.Text = datalistado.SelectedCells.Item(2).Value

            txtnrocomprobante.Text = datalistado.SelectedCells.Item(3).Value
            txttipocomprobante.Text = datalistado.SelectedCells.Item(4).Value

            txtpantalla.Text = datalistado.SelectedCells.Item(5).Value
            txtobservacion.Text = datalistado.SelectedCells.Item(6).Value

            txtestadook.Text = datalistado.SelectedCells.Item(7).Value
            TXTIDCONCEPTO.Text = datalistado.SelectedCells.Item(8).Value
            If txtestadook.Text = "PAGADO" Then
                CONTADO.Checked = True


            End If
            EDITARToolStripMenuItem.Visible = True
            GUARDARNORMAL.Visible = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub datalistado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
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





    Private Sub datalistado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick



    End Sub



    Private Sub txttelefono_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtdni_TextChanged_1(sender As Object, e As EventArgs)

    End Sub



    Private Sub BTNIMPORTAR_Click(sender As Object, e As EventArgs)

    End Sub





    Private Sub MarcarTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcarTodosToolStripMenuItem.Click
        Listar()

        'txtbuscar.Visible = False
        For Each fila As DataGridViewRow In datalistado.Rows
            fila.Cells(0).Value = True
        Next
        txtmsbox.Text = "Se ha activado seleccionar todas las filas"
    End Sub

    Private Sub DesmarcarTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesmarcarTodosToolStripMenuItem.Click
        Listar()

        'txtbuscar.Visible = False
        For Each fila As DataGridViewRow In datalistado.Rows
            fila.Cells(0).Value = True
        Next
        txtmsbox.Text = "Se ha activado seleccionar todas las filas"
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        Listar()


    End Sub



    Private Sub EDITARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITARToolStripMenuItem.Click
        Panel2.Visible = True
        GUARDARNORMAL.Visible = False
        GuardarCambiosToolStripMenuItem.Visible = True
        datalistado.Enabled = False

        MenuStrip4.Visible = False
        MenuStrip5.Visible = False

        datalistado.Enabled = False

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
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("Idgasto").Value)

                        Try

                            abrir()
                            cmd = New SqlCommand("eliminar_ingreso", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@idgasto", onekey)

                            cmd.ExecuteNonQuery()


                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try
                        Cerrar()
                    End If

                Next
                Call limpiar()
                Call Listar()
                Call sumar()



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

   
    Private Sub MenuStrip5_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip5.ItemClicked

    End Sub
    Sub INSERTAR_GASTOS_CON_COMPROBANTE()
        Dim cmd As New SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("insertar_gasto", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@fecha", txtfecha.Value)
            cmd.Parameters.AddWithValue("@Id_concepto", datalistadogrupodegastos.SelectedCells.Item(1).Value)
            cmd.Parameters.AddWithValue("@observacion", txtobservacion.Text)
            cmd.Parameters.AddWithValue("@Nro_Comprobante", txtnrocomprobante.Text)
            cmd.Parameters.AddWithValue("@Tipo_de_Comprobante", txttipocomprobante.Text)
            cmd.Parameters.AddWithValue("@importe", txtpantalla.Text)
            txtestadook.Text = "PAGADO"
            cmd.Parameters.AddWithValue("@estado", txtestadook.Text)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception : MsgBox(ex.Message)
        End Try

    End Sub
    Sub INSERTAR_GASTOS_SIN_COMPROBANTE()

        If TXTACCION.Text = "SALIDA" Then
            If TXTCONCEPTO.Text <> "" Then
                INGRESAR_GASTO_ENTRADA()
            ElseIf TXTCONCEPTO.Text = "" Then
                MessageBox.Show("Seleccione un Concepto", "Concepto", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If


        Else TXTACCION.Text = "INGRESO"
            INGRESAR_GASTO_ENTRADA()
        End If


    End Sub
    Sub INGRESAR_GASTO_ENTRADA()
        Dim cmd As New SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("insertar_gasto_sin_comprobante", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@fecha", txtfecha.Value)
            If TXTACCION.Text = "SALIDA" Then
                cmd.Parameters.AddWithValue("@TIPO", "SALIDA")

                cmd.Parameters.AddWithValue("@Id_concepto", datalistadogrupodegastos.SelectedCells.Item(1).Value)
            End If
            If TXTACCION.Text = "INGRESO" Then
                cmd.Parameters.AddWithValue("@TIPO", "INGRESO")

                cmd.Parameters.AddWithValue("@Id_concepto", 0)
            End If
            cmd.Parameters.AddWithValue("@Descripcion", txtobservacion.Text)
            cmd.Parameters.AddWithValue("@Nro_Comprobante", txtnrocomprobante.Text)
            cmd.Parameters.AddWithValue("@Tipo_de_Comprobante", txttipocomprobante.Text)
            cmd.Parameters.AddWithValue("@importe", txtpantalla.Text)
            cmd.Parameters.AddWithValue("@Id_usuario", Id_usuario.Text)


            cmd.Parameters.AddWithValue("@Id_caja", LOGIN.txtidcaja.Text)

            cmd.ExecuteNonQuery()
            Cerrar()
            MessageBox.Show("Registro Guardado Correctamente", "Registro Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MASCARA1.Hide()
            Close()
            VENTAS_MENU_PRINCIPAL.TimerDisposeMascara.Start()

        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GUARDARNORMAL_Click(sender As Object, e As EventArgs) Handles GUARDARNORMAL.Click


        If cheknoconsiderarguiaderemision.Checked = True Then
            txttipocomprobante.Text = "SIN COMPROBANTE"
            txtnrocomprobante.Text = "------"
        End If
        If txtpantalla.Text <> "" Then
            INSERTAR_GASTOS_SIN_COMPROBANTE()
        Else
            MessageBox.Show("Ingrese el Monto", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpantalla.Focus()

        End If


    End Sub

    Private Sub GuardarCambiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarCambiosToolStripMenuItem.Click
        Dim cmd As New SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("editar_gasto", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@fecha", txtfecha.Value)
            If TXTACCION.Text = "SALIDA" Then
                cmd.Parameters.AddWithValue("@Id_concepto", TXTIDCONCEPTO.Text)
            End If
            If TXTACCION.Text = "INGRESO" Then
                cmd.Parameters.AddWithValue("@Id_concepto", 0)
            End If
            cmd.Parameters.AddWithValue("@observacion", txtobservacion.Text)
            cmd.Parameters.AddWithValue("@Nro_Comprobante", txtnrocomprobante.Text)
            cmd.Parameters.AddWithValue("@Tipo_de_Comprobante", txttipocomprobante.Text)
            cmd.Parameters.AddWithValue("@importe", txtpantalla.Text)
            cmd.Parameters.AddWithValue("@idgasto", txtidgasto2.Text)
            cmd.ExecuteNonQuery()
            Cerrar()

            LISTADO_GASTOS_VARIOS.Timer1.Start()
            DISTRIBUCION_DE_PRODUCTOS.Timer1.Start()

            MessageBox.Show("Todos los Cambios fueron Guardados", "Registro Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mascara1.dispose()
            Close()
        Catch ex As Exception : MsgBox(ex.Message)
        End Try



    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        'datalistado.Enabled = False
        'Panel2.Visible = True
        'MenuStrip4.Visible = False
        'MenuStrip5.Visible = False
        'GUARDARNORMAL.Visible = True
        'GuardarCambiosToolStripMenuItem.Visible = False
        'limpiar()
        'Listar()
        'txtmsbox.Text = "Se ha activado el registro de un nuevo Gasto"
    End Sub

    Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_gastos", conexion)
            da.Fill(dt)
            datalistado.DataSource = dt
            contar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()
    End Sub
    Sub MOSTRAR_CONCEPTOS_EN_GASTOS_VARIOS()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("MOSTRAR_CONCEPTOS_EN_GASTOS_VARIOS", conexion)
            da.Fill(dt)
            datalistadogrupodegastos.DataSource = dt
            datalistadogrupodegastos.Columns(1).Visible = False
            datalistadogrupodegastos.Columns(2).Width = 500
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtpantalla.Text = txtpantalla.Text & "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtpantalla.Text = txtpantalla.Text & "1"

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

    Private Sub gastosvarios_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        'Panel2.Visible = False
        'Listar()
        Panel2.Visible = True
        cheknoconsiderarguiaderemision.Checked = True
        PANELCOMPROBANTE.Visible = False
        txttipocomprobante.Text = "SIN COMPROBANTE"
        txtnrocomprobante.Text = "------"


        'limpiar()

        'PANELCOMPROBANTE.Enabled = False
        'PANELPRECIOS.Enabled = False

        If TXTACCION.Text = "SALIDA" Then
            MOSTRAR_CONCEPTOS_EN_GASTOS_VARIOS()
            PANELCONCEPTO.Visible = True
            datalistadogrupodegastos.Visible = True
            PANELPRECIOS.Enabled = False
            PANELCOMPROBANTE.Enabled = False
            Label15.Visible = True
        End If
        If TXTACCION.Text = "INGRESO" Then

            PANELCONCEPTO.Visible = False
            datalistadogrupodegastos.Visible = False
            PANELPRECIOS.Enabled = True
            PANELCOMPROBANTE.Enabled = True
            Label15.Visible = False
        End If

        Id_usuario.Text = LOGIN.IDUSUARIO.Text
        txtusuario_frontal.Text = LOGIN.txtnombre.Text

        TXTCONCEPTO.Text = ""
        Label5.Visible = True
    End Sub

    Private Sub txtbusca_ValueChanged(sender As Object, e As EventArgs)
        buscar()

    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = String.Format(cbocampo.Text & " LIKE '%{0}%'", "#" & txtbuscar.Text & "#")
            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv
                contar()
                For Each fila As DataGridViewRow In datalistado.Rows
                    If fila.Cells("Estado").Value = "DEUDA" Then
                        fila.DefaultCellStyle.BackColor = Color.Coral
                        'fila.Cells("Stock").Style.BackColor = Color.Yellow

                    Else
                        'fila.Cells("Stock").Style.BackColor = Color.Red
                        fila.DefaultCellStyle.BackColor = Color.White

                    End If

                Next
                datalistado.Columns(2).Width = 345
                datalistado.Columns(6).Width = 140
                datalistado.Columns(7).Width = 140
            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing
                contar()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Private Function listar() As DataTable
    '    Try
    '        Dim fechas1 As New DateTime
    '        fechas1 = fecha1.Value.Date
    '        Dim fechas2 As New DateTime
    '        fechas2 = fecha2.Value.Date

    '        Using cnn As New SqlConnection("data source=localhost ;Initial Catalog=BASE_COSMOS;Integrated Security=True")
    '            Dim sqlbuscar As String
    '            sqlbuscar = "select * from GASTOSVARIOS WHERE Fecha_del_Gasto>=@fecha1 and Fecha_del_Gasto <= @fecha2 "
    '            Dim cmd As New SqlCommand(sqlbuscar, cnn)
    '            cmd.Parameters.AddWithValue("@fecha1", fecha1)
    '            cmd.Parameters.AddWithValue("@fecha2", fecha2)

    '            Dim da As New SqlDataAdapter(cmd)
    '            da.Fill(dt)
    '            Return dt


    '        End Using

    '    Catch ex As Exception




    '        'Throw

    '    End Try
    'End Function




    Private Sub txtbusca_TextChanged(sender As Object, e As EventArgs)


    End Sub
    Private Sub sumar()
        Try
            Dim totalpagar As Double

            totalpagar = 0
            Dim fila As DataGridViewRow = New DataGridViewRow()
            For Each fila In datalistado.Rows
                totalpagar += (fila.Cells("Total_a_pagar").Value)
            Next

            txttotal.Text = (totalpagar)
            txttotal.Text = Format(CType(txttotal.Text, Decimal), "##0.00")
        Catch ex As Exception

        End Try



    End Sub


    Private Sub cheknoconsiderarguiaderemision_CheckedChanged(sender As Object, e As EventArgs) Handles cheknoconsiderarguiaderemision.CheckedChanged
        If cheknoconsiderarguiaderemision.Checked = True Then
            PANELCOMPROBANTE.Visible = False
        Else
            PANELCOMPROBANTE.Visible = True
        End If
    End Sub

    Private Sub CONTADO_CheckedChanged(sender As Object, e As EventArgs) Handles CONTADO.CheckedChanged


    End Sub

    Private Sub datalistadogrupodegastos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadogrupodegastos.CellClick
        Try

            TXTIDCONCEPTO.Text = datalistadogrupodegastos.SelectedCells.Item(1).Value
            TXTCONCEPTO.Text = datalistadogrupodegastos.SelectedCells.Item(2).Value
            datalistadogrupodegastos.Visible = False
            PANELCOMPROBANTE.Enabled = True
            PANELPRECIOS.Enabled = True
            Label5.Visible = False
            If e.ColumnIndex = Me.datalistadogrupodegastos.Columns.Item("Editar").Index Then
                GuardarRegistroToolStripMenuItem.Visible = False
                ModificarToolStripMenuItem.Visible = True
                txtdescripcion.Text = datalistadogrupodegastos.SelectedCells.Item(2).Value
                Panel9.Visible = True
                txtbuscar.Text = ""
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub datalistadogrupodegastos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadogrupodegastos.CellContentClick

    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs)
        CONCEPTOS_GASTOS_INGRESOS.ShowDialog()

    End Sub

    Private Sub ActualizarToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        If TXTACCION.Text = "SALIDA" Then
            MOSTRAR_CONCEPTOS_EN_GASTOS_VARIOS()
        End If


    End Sub

    Private Sub TXTCONCEPTO_Click(sender As Object, e As EventArgs) Handles TXTCONCEPTO.Click
        datalistadogrupodegastos.Visible = True
        TXTCONCEPTO.Text = ""
        Label5.Visible = False
    End Sub
    Sub BUSCAR_CONCEPTOS_EN_GASTOS_VARIOS()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("BUSCAR_CONCEPTOS_EN_GASTOS_VARIOS", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", TXTCONCEPTO.Text)
            da.Fill(dt)
            datalistadogrupodegastos.DataSource = dt

            datalistadogrupodegastos.Columns(1).Visible = False

            datalistadogrupodegastos.Columns(2).Width = 500

            Cerrar()
        Catch ex As Exception
        End Try


    End Sub

    Private Sub TXTCONCEPTO_TextChanged(sender As Object, e As EventArgs) Handles TXTCONCEPTO.TextChanged

        BUSCAR_CONCEPTOS_EN_GASTOS_VARIOS()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click


    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs)
        Dim progFiles As String = "C:\Program Files\Common Files\Microsoft Shared\ink"
        Dim keyboardPath As String = Path.Combine(progFiles, "TabTip.exe")
        Process.Start(keyboardPath)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        MASCARA1.Hide()
        Close()
        VENTAS_MENU_PRINCIPAL.TimerDisposeMascara.Start()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        txtbuscar.Text = ""
        txtdescripcion.Text = ""
        txtdescripcion.Focus()
        Panel9.Visible = True
        GuardarRegistroToolStripMenuItem.Visible = True
        ModificarToolStripMenuItem.Visible = False




    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        If TXTACCION.Text = "SALIDA" Then
            MOSTRAR_CONCEPTOS_EN_GASTOS_VARIOS()
        End If
      
    End Sub

    Private Sub datalistadogrupodegastos_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datalistadogrupodegastos.CellMouseDown

    End Sub

    Private Sub datalistadogrupodegastos_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadogrupodegastos.CellMouseLeave


    End Sub

    Private Sub datalistadogrupodegastos_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datalistadogrupodegastos.CellMouseMove

    End Sub

    Private Sub datalistadogrupodegastos_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datalistadogrupodegastos.CellMouseUp

    End Sub

    Private Sub PANELPRECIOS_MouseMove(sender As Object, e As MouseEventArgs) Handles PANELPRECIOS.MouseMove
        datalistadogrupodegastos.Visible = False

    End Sub

    Private Sub PANELPRECIOS_Paint(sender As Object, e As PaintEventArgs) Handles PANELPRECIOS.Paint

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        If TXTACCION.Text = "SALIDA" Then
            MOSTRAR_CONCEPTOS_EN_GASTOS_VARIOS()
        End If
        
    End Sub

    Private Sub txtusuario_frontal_Click(sender As Object, e As EventArgs) Handles txtusuario_frontal.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub GuardarRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarRegistroToolStripMenuItem.Click
        Dim cmd As New SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("insertar_Conceptos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text)
            cmd.ExecuteNonQuery()
            Cerrar()
            TXTCONCEPTO.Text = txtdescripcion.Text
            BUSCAR_CONCEPTOS_EN_GASTOS_VARIOS()
            Panel9.Visible = False
            Timer1.Start()

        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Dim cmd As New SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("editar_CONCEPTO", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text)
            cmd.Parameters.AddWithValue("@Id_concepto", TXTIDCONCEPTO.Text)
            cmd.ExecuteNonQuery()
            Cerrar()

            Panel9.Visible = False
            txtbuscar.Text = ""
            Timer1.Start()
            TXTCONCEPTO.Text = txtdescripcion.Text
            BUSCAR_CONCEPTOS_EN_GASTOS_VARIOS()
        Catch ex As Exception : MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Panel9.Visible = False
    End Sub



    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub txtpantalla_TextChanged(sender As Object, e As EventArgs) Handles txtpantalla.TextChanged

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
    Private Sub txtpantalla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpantalla.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then

            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtpantalla, e)
    End Sub
End Class




