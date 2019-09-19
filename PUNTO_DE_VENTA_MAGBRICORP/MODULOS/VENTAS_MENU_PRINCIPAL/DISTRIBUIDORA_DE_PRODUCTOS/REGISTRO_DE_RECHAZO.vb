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
Public Class REGISTRO_DE_RECHAZO
    Private memoria1 As Double = 0.0
    Private memoria2 As Double = 0.0
    Private signo As String
    Dim DT_USUARIO As New DataTable
    Private txt() As PictureBox
    Private lbl() As Label
    Private lbl2() As Button
    Private b() As Button
    Private a() As Label
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
    Dim dtunidad As New DataTable
    Private Sub REGISTRO_DE_RECHAZO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LISTAR_PRODUCTOS_AGREGADOS()
        LISTAR_PRODUCTOS_AGREGADOS_RECHAZADO()
        

        TXTIDUSUARIO.Text = DISTRIBUCION_DE_PRODUCTOS.TXTIDUSUARIO.Text
        Label44.Visible = True
        DATALISTADO_AGREGANDO.Visible = False
        txtpantalla.Text = ""
        txtbuscar.Text = ""

    End Sub
    Private Sub sumar_total_RECHAZO()
        Dim totalpagar As Double

        totalpagar = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In datalistado_RECHAZO.Rows
            totalpagar += (fila.Cells("Total").Value)
        Next
        lbltotal_RECHAZO.Text = (totalpagar) * (-1)
        lbltotal_RECHAZO.Text = Format(CType(lbltotal_RECHAZO.Text, Decimal), "##0.00")


    End Sub
    'Sub MOSTRAR_USUARIOS()

    '    Dim DA As SqlDataAdapter
    '    Try
    '        abrir()
    '        DA = New SqlDataAdapter("SELECT * FROM USUARIO2", conexion)
    '        DA.Fill(DT_USUARIO)
    '        CBXVENDEDOR.DisplayMember = "Nombre_y_Apelllidos"
    '        CBXVENDEDOR.ValueMember = "idUsuario"
    '        CBXVENDEDOR.DataSource = DT_USUARIO
    '    Catch ex As Exception : MessageBox.Show(ex.Message)
    '    End Try
    '    Cerrar()

    'End Sub
    Sub LISTAR_PRODUCTOS_AGREGADOS()
        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("mostrar_productos_agregados_a_kardex_por_vendedor_id_buscador_para_RECHASO", conexion)
            daListarpresentacionesagregadas.SelectCommand.CommandType = 4

            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@letra", lblidusuario.Text)
            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@fecha", TXTFECHA_DE_KADEX.Value)
            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@letrab", txtbuscar.Text)

            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            DATALISTADO_AGREGANDO.DataSource = dtDATALISTADO_AGREGANDO
            DATALISTADO_AGREGANDO.Columns(0).Visible = False
            DATALISTADO_AGREGANDO.Columns(1).Visible = False
            DATALISTADO_AGREGANDO.Columns(3).Visible = False
            DATALISTADO_AGREGANDO.Columns(2).Width = 380

        Catch ex As Exception
        End Try
        Cerrar()
        'sumar_total_despachado()
    End Sub
    Sub LISTAR_PRODUCTOS_AGREGADOS_RECHAZADO()
        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("mostrar_productos_agregados_a_kardex_por_vendedor_ENTRADAS", conexion)
            daListarpresentacionesagregadas.SelectCommand.CommandType = 4

            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@letra", lblidusuario.Text)
            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@fecha", TXTFECHA_DE_KADEX.Value)


            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            datalistado_RECHAZO.DataSource = dtDATALISTADO_AGREGANDO
            datalistado_RECHAZO.Columns(1).Visible = False
            datalistado_RECHAZO.Columns(2).Visible = False
            datalistado_RECHAZO.Columns(0).Width = 50
            datalistado_RECHAZO.Columns(3).Width = 65
            datalistado_RECHAZO.Columns(4).Width = 290
            datalistado_RECHAZO.Columns(5).Width = 60
            datalistado_RECHAZO.Columns(6).Width = 60
            datalistado_RECHAZO.Columns(7).Visible = False
            datalistado_RECHAZO.Columns(8).Visible = False
        Catch ex As Exception
        End Try
        Cerrar()
        sumar_total_RECHAZO()
    End Sub
    Private Sub CBXVENDEDOR_SelectedIndexChanged(sender As Object, e As EventArgs)
        With TXTIDUSUARIO
            .DataSource = DT_USUARIO
            .DisplayMember = "idUsuario"
            .ValueMember = "idUsuario"

        End With
    End Sub

    Private Sub TXTIDUSUARIO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXTIDUSUARIO.SelectedIndexChanged
        lblidusuario.Text = TXTIDUSUARIO.Text
        LISTAR_PRODUCTOS_AGREGADOS()
        LISTAR_PRODUCTOS_AGREGADOS_RECHAZADO()


    End Sub

    Private Sub txtbuscar_Click(sender As Object, e As EventArgs) Handles txtbuscar.Click
        LISTAR_PRODUCTOS_AGREGADOS()

        DATALISTADO_AGREGANDO.Visible = True
        txtbuscar.Text = ""
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If txtbuscar.Text = "" Then
            Label44.Visible = True
        End If
        If txtbuscar.Text <> "" Then
            Label44.Visible = False
        End If





        LISTAR_PRODUCTOS_AGREGADOS()
        DATALISTADO_AGREGANDO.Visible = True

    End Sub
    Sub aumentar_stockoka()
        Try
            Dim cmd As New SqlCommand

            abrir()






            cmd = New SqlCommand("aumentar_stock", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", DATALISTADO_AGREGANDO.SelectedCells.Item(1).Value)
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
            'PANELCANTIDAD.Visible = False
        Catch ex As Exception

        End Try
    End Sub
    Sub DISMINUIR_STOCK()
        Dim cmdaumentarstock As SqlCommand

        Try
            For Each row As DataGridViewRow In datalistado_RECHAZO.Rows
                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                If marcado Then

                    Dim idlote As Integer = Convert.ToInt32(row.Cells("Id_presentacionfraccionada").Value)
                    Dim cantidad As Decimal = Convert.ToDouble(row.Cells("Cant").Value)

                    Try
                        abrir()
                        cmdaumentarstock = New SqlCommand("disminuir_stock", conexion)
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



    'End Sub
    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click

        Dim cantidad2 As Decimal
        cantidad2 = txtpantalla.Text * txtcantidad_de_unidad_de_medidaoka.Text * 1
        txtcantidad_total.Text = cantidad2

        Try
            Dim cmd As New SqlCommand

            abrir()

            cmd = New SqlCommand("insertar_KARDEX_SALIDA", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Fecha", TXTFECHA_DE_KADEX.Value)
            cmd.Parameters.AddWithValue("@Motivo", "RECHAZO DIARIO")
            cmd.Parameters.AddWithValue("@Cantidad ", txtcantidad_total.Text)

            cmd.Parameters.AddWithValue("@Id_presentacion_fraccionada", DATALISTADO_AGREGANDO.SelectedCells.Item(1).Value)
            cmd.Parameters.AddWithValue("@Id_usuario", TXTIDUSUARIO.Text)
            cmd.Parameters.AddWithValue("@Tipo", "ENTRADA")
            cmd.Parameters.AddWithValue("@Estado", "SIN APROBAR")
            cmd.Parameters.AddWithValue("@Total", txtcantidad_total.Text * 1 * lblpreciount.Text * 1 * (-1))
            cmd.ExecuteNonQuery()
            '       @Fecha datetime,
            '    @Motivo varchar(200),			         

            '        @Cantidad as numeric(18,0)	,
            '@Precio_unitario as numeric(18,18),	
            ' @Id_producto int	,
            '  @Id_usuario as int,	
            '  @Tipo as varchar(50)	


            Cerrar()
            aumentar_stockoka()

            LISTAR_PRODUCTOS_AGREGADOS_RECHAZADO()


        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub TXTFECHA_DE_KADEX_ValueChanged(sender As Object, e As EventArgs) Handles TXTFECHA_DE_KADEX.ValueChanged
        LISTAR_PRODUCTOS_AGREGADOS_RECHAZADO()
        LISTAR_PRODUCTOS_AGREGADOS()

    End Sub

    Private Sub DATALISTADO_AGREGANDO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_AGREGANDO.CellClick
        Try

            txtpantalla.Focus()
            LBLPRODUCTOOKA.Text = DATALISTADO_AGREGANDO.SelectedCells.Item(2).Value
            txtbuscar.Text = DATALISTADO_AGREGANDO.SelectedCells.Item(2).Value
            lblpreciount.Text = DATALISTADO_AGREGANDO.SelectedCells.Item(3).Value
            txtpantalla.Focus()
            DATALISTADO_AGREGANDO.Visible = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DATALISTADO_AGREGANDO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALISTADO_AGREGANDO.CellContentClick

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
    Sub INSERTAR_KARDEX_ELIMINACION()
        Dim cmdKARDEXELIM As SqlCommand
        Try
            For Each row As DataGridViewRow In datalistado_RECHAZO.Rows
                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                If marcado Then
                    Dim idlote As Integer = Convert.ToInt32(row.Cells("Id_presentacionfraccionada").Value)
                    Dim cantidad As Decimal = Convert.ToDouble(row.Cells("Cant").Value)
                    Dim total As Decimal = Convert.ToDouble(row.Cells("Total").Value)
                    Try
                        abrir()
                        cmdKARDEXELIM = New SqlCommand("insertar_KARDEX_SALIDA", conexion)
                        cmdKARDEXELIM.CommandType = 4
                        cmdKARDEXELIM.Parameters.AddWithValue("@Motivo", "ELIMINACION DE RECHAZOS")
                        cmdKARDEXELIM.Parameters.AddWithValue("@Cantidad ", cantidad)
                        cmdKARDEXELIM.Parameters.AddWithValue("@Fecha", TXTFECHA_DE_KADEX.Value)
                        cmdKARDEXELIM.Parameters.AddWithValue("@Id_presentacion_fraccionada", idlote)
                        cmdKARDEXELIM.Parameters.AddWithValue("@Id_usuario", TXTIDUSUARIO.Text)
                        cmdKARDEXELIM.Parameters.AddWithValue("@Tipo", "SALIDA")
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
    Private Sub txtunidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtunidad.SelectedIndexChanged

        Dim dtunidad As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("mostrar_unidades", conexion)
            DA.Fill(dtunidad)
        Catch ex As Exception

        End Try
        Cerrar()

        With txtcantidad_de_unidad_de_medidaoka
            .DataSource = dtunidad
            .DisplayMember = "Cantidad_por_unidad_de_medida"
            .ValueMember = "Cantidad_por_unidad_de_medida"
        End With
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click



        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado_RECHAZO.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        DISMINUIR_STOCK()
                        'INSERTAR_KARDEX_ELIMINACION()
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
                Call LISTAR_PRODUCTOS_AGREGADOS_RECHAZADO()




            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub datalistado_RECHAZO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado_RECHAZO.CellContentClick
        Try
            If e.ColumnIndex = Me.datalistado_RECHAZO.Columns.Item("Eliminar").Index Then
                Dim chkcell2 As DataGridViewCheckBoxCell = Me.datalistado_RECHAZO.Rows(e.RowIndex).Cells("Eliminar")
                chkcell2.Value = Not chkcell2.Value
            End If
        Catch ex As Exception
        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DISTRIBUCION_DE_PRODUCTOS.Timer1.Start()

        Close()
        mascara1.dispose()
    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click
        Label44.Visible = False
        txtbuscar.Text = ""
        txtbuscar.Focus()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
       
        UND.ShowDialog()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        

    End Sub
End Class