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
Public Class CANTIDAD_DE_PRODUCTOS_VARIOS
    Private txt() As PictureBox
    Private lbl() As Label
    Private lbl2() As Button
    Private b() As Button
    Private a() As Label
    Dim panel As New PanelExtended
    Dim i As Integer
    Dim j As Integer = 0
    Dim DTturnoinicial As New DataTable
    Dim DTturnofinal As New DataTable


    Dim dtcliente As New DataTable
    Dim dtidventa As New DataTable
    Dim dtserie As New DataTable
    'Dim dtunidad As New DataTable
    Dim DT_USUARIO As New DataTable
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        
        Close()

    End Sub
    Sub buscar_und()
        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("buscar_und", conexion)
            daListarpresentacionesagregadas.SelectCommand.CommandType = 4


            daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@letra", txtunidad.Text)

            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            dtund.DataSource = dtDATALISTADO_AGREGANDO


        Catch ex As Exception
        End Try
        Cerrar()
        'sumar_total_despachado()
    End Sub
    Private Sub BTN_SEGUIR_AGREGANDO_Click(sender As Object, e As EventArgs) Handles BTN_SEGUIR_AGREGANDO.Click

    End Sub

    Private Sub txtunidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtunidad.SelectedIndexChanged
        buscar_und()


        'lbl_unidadoka.Text = txtunidad.Text
        'With txtcantidad_de_unidad_de_medidaoka
        '    .DataSource = dtunidad
        '    .DisplayMember = "Cantidad_por_unidad_de_medida"
        '    .ValueMember = "Cantidad_por_unidad_de_medida"
        'End With
        Try
            LBL_CANTIDAD_UNIDAD_MEDIDA.Text = dtund.SelectedCells.Item(3).Value
        Catch ex As Exception

        End Try

        Try
            txtprecio_por_unidad_De_medida.Text = txtprecio.Text * 1 * LBL_CANTIDAD_UNIDAD_MEDIDA.Text * 1

        Catch ex As Exception
            txtprecio_por_unidad_De_medida.Text = ""
        End Try
    End Sub

    Private Sub txtpantalla_Click(sender As Object, e As EventArgs) Handles txtpantalla.Click
        Label27.Visible = False
        If txtpantalla.Text = "" Then
            Label27.Visible = True

        End If
    End Sub

    Private Sub txtpantalla_TextChanged(sender As Object, e As EventArgs) Handles txtpantalla.TextChanged
        Label27.Visible = False

        If txtpantalla.Text = "" Or txtpantalla.Text = 0 Then
            Label27.Visible = True
            btn_insertar.Enabled = False
        End If
        If txtpantalla.Text <> "" Or txtpantalla.Text <> 0 Then
            Label27.Visible = False
            btn_insertar.Enabled = True
        End If
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        txtpantalla.Text = ""
        txtpantalla.Focus()
        'Label27.Visible = Fals
    End Sub

    Private Sub CANTIDAD_DE_PRODUCTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class