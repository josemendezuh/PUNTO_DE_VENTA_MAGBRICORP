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
Public Class CONFIGURACION_DE_HORARIOS_PRECIOS
    Dim dtlinea As New DataTable
    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
    

        Try
            If lunes.Checked = True Then lbllunes.Text = 1
            If martes.Checked = True Then lblmartes.Text = 1
            If miercole.Checked = True Then lblmiercoles.Text = 1
            If jueves.Checked = True Then lbljueves.Text = 1
            If viernes.Checked = True Then lblvierns.Text = 1
            If sabado.Checked = True Then lblsabado.Text = 1
            If domingo.Checked = True Then lbldomingo.Text = 1

            If lunes.Checked = False Then lbllunes.Text = 0
            If martes.Checked = False Then lblmartes.Text = 0
            If miercole.Checked = False Then lblmiercoles.Text = 0
            If jueves.Checked = False Then lbljueves.Text = 0
            If viernes.Checked = False Then lblvierns.Text = 0
            If sabado.Checked = False Then lblsabado.Text = 0
            If domingo.Checked = False Then lbldomingo.Text = 0
            Dim cmd As New SqlCommand

            abrir()

            cmd = New SqlCommand("insertar_HORARIOS", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Cargo", txtcargo.Text)
            cmd.Parameters.AddWithValue("@Horas_laborales_diarias", txthorasdiarias.Text)
            cmd.Parameters.AddWithValue("@Costo_hora_normal ", txtcostohorasnormales.Text)
            cmd.Parameters.AddWithValue("@Costo_hora_extra", txtcostohorasextra.Text)
            cmd.Parameters.AddWithValue("@Horas_libres_diarias", txthoraslibres.Text)


            cmd.Parameters.AddWithValue("@lunes", lbllunes.Text)
            cmd.Parameters.AddWithValue("@martes", lblmartes.Text)
            cmd.Parameters.AddWithValue("@miercoles", lblmiercoles.Text)
            cmd.Parameters.AddWithValue("@jueves", lbljueves.Text)
            cmd.Parameters.AddWithValue("@viernes", lblvierns.Text)
            cmd.Parameters.AddWithValue("@sabado", lblsabado.Text)
            cmd.Parameters.AddWithValue("@domingo", lbldomingo.Text)




            cmd.ExecuteNonQuery()
            '       @Fecha datetime,
            '    @Motivo varchar(200),			         

            '        @Cantidad as numeric(18,0)	,
            '@Precio_unitario as numeric(18,18),	
            ' @Id_producto int	,
            '  @Id_usuario as int,	
            '  @Tipo as varchar(50)	


            Cerrar()

           
            Listar()
            Panel5.Visible = False

           
            usuariosok.timerparaactualizarventanueva.Start()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub mostrar_cargos_sin_repetir()
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("mostrar_cargos_sin_repetir", conexion)
            DA.Fill(dtlinea)
            txtcargo.DisplayMember = "Cargo"
            txtcargo.ValueMember = "Cargo"
            txtcargo.DataSource = dtlinea
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()
    End Sub
    Private Sub CONFIGURACION_DE_HORARIOS_PRECIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_cargos_sin_repetir()
        Listar()

    End Sub
    Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_HORARIOS", conexion)
            da.Fill(dt)
            datalistado.DataSource = dt
            'For Each fila As DataGridViewRow In datalistado.Rows
            '    If fila.Cells("Estado").Value = "SIN FORMULACIONES" Then
            '        fila.DefaultCellStyle.BackColor = Color.Pink
            '    Else
            '        fila.DefaultCellStyle.BackColor = Color.White
            '    End If
            'Next


        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()

        'datalistado.Columns(2).Visible = False
        'datalistado.Columns(1).Width = 140
        ''datalistado.Columns(3).Width = 110
        'datalistado.Columns(4).Width = 140
        'datalistado.Columns(5).Width = 90
        'datalistado.Columns(6).Width = 200
        'datalistado.Columns(0).Width = 50
        'datalistado.Columns(9).Width = 185

        'datalistado.Columns(8).Visible = False
        'datalistado.Columns(7).Visible = False


        'sumar()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Panel5.Visible = False

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub domingo_CheckedChanged(sender As Object, e As EventArgs) Handles domingo.CheckedChanged

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel5.Visible = True

        txthorasdiarias.Text = ""
        txtcostohorasnormales.Text = ""
        txtcostohorasextra.Text = ""
        txthoraslibres.Text = ""
    End Sub
End Class