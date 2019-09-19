
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

Imports System.Drawing.Drawing2D
Public Class ASISTENCIAS
    Sub cargarclientes()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_USUARIO_por_DNI", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtclientesolicitabnte.Text)
            da.Fill(dt)
            datalistado.DataSource = dt           
        Catch ex As Exception
        End Try
        Cerrar()
    End Sub
    Sub cargarasistencias()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_ASISTENCIAS_por_id", conexion)
            da.SelectCommand.CommandType = 4

            da.SelectCommand.Parameters.AddWithValue("@letra", TXTIDPERSONAL.Text)
            da.Fill(dt)
            datalistadoasistencia.DataSource = dt

        Catch ex As Exception
        End Try
        Cerrar()

    End Sub


    Sub cargarasistencias_horas()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_ASISTENCIAS_por_id_para_horas", conexion)
            da.SelectCommand.CommandType = 4

            da.SelectCommand.Parameters.AddWithValue("@letra", datalistado.SelectedCells.Item(1).Value)
            da.Fill(dt)
            datalistadohoras.DataSource = dt

        Catch ex As Exception
        End Try
        Cerrar()

    End Sub
    Sub INSERTAR_CONTROLASISTENCIA()
        Dim cmd As New SqlCommand
        Try
            '          @Id_personal ,
            '@Fecha_entrada ,
            '@Fecha_salida ,
            '@Estado
            abrir()
            cmd = New SqlCommand("Insertar_CONTROL_ASISTENCIA", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_personal", datalistadohoras.SelectedCells.Item(1).Value)
            cmd.Parameters.AddWithValue("@Horas_acumuladas", datalistadohoras.SelectedCells.Item(7).Value)
            cmd.Parameters.AddWithValue("@Concepto", "ASISTENCIA DIARIA")
            cmd.ExecuteNonQuery()
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
        Cerrar()
    End Sub
    Sub INSERTAR_ASISTENCIA()
        Dim cmd As New SqlCommand
        Try
            '          @Id_personal ,
            '@Fecha_entrada ,
            '@Fecha_salida ,
            '@Estado
            abrir()
            cmd = New SqlCommand("Insertar_ASISTENCIAS", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_personal", datalistado.SelectedCells.Item(1).Value)
            cmd.Parameters.AddWithValue("@Fecha_entrada", TXTFECHA.Text & " " & lblhora2.Text)
            cmd.Parameters.AddWithValue("@Fecha_salida", TXTFECHA.Text & " " & lblhora2.Text)
            cmd.Parameters.AddWithValue("@Estado", "ENTRADA")
            DateDiff(DateInterval.Hour, TXTFECHA.Value, TXTFECHA.Value)
            cmd.Parameters.AddWithValue("@Horas", DateDiff(DateInterval.Hour, TXTFECHA.Value, TXTFECHA.Value))
            cmd.ExecuteNonQuery()

         

        Catch ex As Exception : MsgBox(ex.Message)
        End Try

        Cerrar()



    End Sub
    Sub EDITAR_ASISTENCIA()
        Dim cmd As New SqlCommand
        Try
            '          @Id_personal ,
            '@Fecha_entrada ,
            '@Fecha_salida ,
            '@Estado
            abrir()
            cmd = New SqlCommand("editar_ASISTENCIAS", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_personal", datalistado.SelectedCells.Item(1).Value)

            cmd.Parameters.AddWithValue("@Fecha_salida", TXTFECHA.Text & " " & lblhora2.Text)
            cmd.Parameters.AddWithValue("@Horas", DateDiff(DateInterval.Hour, datalistadoasistencia.SelectedCells.Item(3).Value, TXTFECHA.Value))

            cmd.ExecuteNonQuery()



        Catch ex As Exception : MsgBox(ex.Message)
        End Try

        Cerrar()



    End Sub
    Private Sub txtclientesolicitabnte_TextChanged(sender As Object, e As EventArgs)
       



    End Sub
    Sub cargar_horasdiarias()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_horas_dia", conexion)
            da.SelectCommand.CommandType = 4

            da.SelectCommand.Parameters.AddWithValue("@idpersonal", TXTIDPERSONAL.Text)
            da.SelectCommand.Parameters.AddWithValue("@fecha_sistema", TXTFECHA.Text)
            da.Fill(dt)
            datalistadoacumuladohorASDIA.DataSource = dt
            Cerrar()
        Catch ex As Exception
        End Try
    End Sub
    Sub cargar_horastotales()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_horas_totales", conexion)
            da.SelectCommand.CommandType = 4

            da.SelectCommand.Parameters.AddWithValue("@idpersonal", TXTIDPERSONAL.Text)

            da.Fill(dt)
            datalistadohorastotales.DataSource = dt
            Cerrar()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ASISTENCIAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("fr-FR")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        txtclientesolicitabnte.Focus()

        cargarclientes()


    End Sub

    Private Sub TXTFECHA_ValueChanged(sender As Object, e As EventArgs) Handles TXTFECHA.ValueChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click, TXTIDPERSONAL.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblhora2.Text = TimeOfDay
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label4.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click, Label3.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Panelhoras_Paint(sender As Object, e As PaintEventArgs) Handles Panelhoras.Paint

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles TXTNOMBRE.Click

    End Sub

    Private Sub lblhora2_Click(sender As Object, e As EventArgs) Handles lblhora2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtaviso_Click(sender As Object, e As EventArgs) Handles txtaviso.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub txtclientesolicitabnte_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)


    End Sub

    Private Sub txtclientesolicitabnte_TabIndexChanged(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub txtclientesolicitabnte_TextChanged_1(sender As Object, e As EventArgs) Handles txtclientesolicitabnte.TextChanged
        Try

            cargarclientes()


            If txtclientesolicitabnte.Text = datalistado.SelectedCells.Item(3).Value Then
                TXTNOMBRE.Text = datalistado.SelectedCells.Item(2).Value
                TXTIDPERSONAL.Text = datalistado.SelectedCells.Item(1).Value
                cargarasistencias()

                Try

                    If datalistadoasistencia.RowCount = 0 Then
                        INSERTAR_ASISTENCIA()
                        txtaviso.Text = "ENTRADA REGISTRADA"
                        Panelhoras.Visible = False
                        txtclientesolicitabnte.Text = ""


                    ElseIf datalistadoasistencia.RowCount > 0 Then
                        EDITAR_ASISTENCIA()
                        cargarasistencias_horas()
                        txthoras.Text = datalistadohoras.SelectedCells.Item(6).Value & " Horas "
                        'INSERTAR_CONTROLASISTENCIA()
                        cargar_horasdiarias()
                        'cargar_horastotales()


                        'txthorasacumuladas.Text = datalistadohorastotales.SelectedCells.Item(1).Value
                        txthorasdia.Text = datalistadoacumuladohorASDIA.SelectedCells.Item(1).Value

                        'Dim minuto As Double = ((txthorasacumuladas.Text * 1))
                        'Dim hora As Integer = Int((txthorasacumuladas.Text * 1))
                        'Dim horaminuto As Double = Int((minuto - hora) * 60)
                        'txthorasacumuladas.Text = hora & " Horas y " & horaminuto & " minutos"


                        'Dim minuto2 As Double = ((txthorasdia.Text * 1))
                        'Dim hora2 As Integer = Int((txthorasdia.Text * 1))
                        'Dim horaminuto2 As Double = Int((minuto2 - hora2) * 60)

                        'txthorasdia.Text = hora2 & " Horas y " & horaminuto2 & " minutos"



                        txtaviso.Text = "SALIDA REGISTRADA"
                        Panelhoras.Visible = True
                        txtclientesolicitabnte.Text = ""
                    End If
                Catch ex As Exception

                End Try

            End If
            cargarasistencias()

            txthoras.Text = datalistadoasistencia.SelectedCells.Item(5).Value & " Horas " & datalistadoasistencia.SelectedCells.Item(6).Value & " Minutos"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MASCARA1.Show()



    End Sub

    Private Sub PictureBox2_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox2.Paint
        'creamos un objeto de la clase GraphicsPath
        Dim figura As GraphicsPath = New GraphicsPath
        'manipulando las variables que se corresponden con los puntos x e y, el ancho y el alto de la figura, podemos variar su aspecto
        Dim x, y, ancho, alto As Integer
        'anchura y altura de la figura (círculo en este caso)
        ancho = 260
        alto = 260
        'posiciones x e y de la figura (centrada en el control PictureBox)
        x = (PictureBox2.Width - ancho) / 2
        y = (PictureBox2.Height - alto) / 2
        'usamos el método AddEllipse para conseguir la figura de un círculo,
        'que aplicaremos sobre el control PictureBox.
        figura.AddEllipse(New Rectangle(x, y, ancho, alto))
        'en el control PictureBox creamos una región que se corresponde
        'con la figura del objeto GraphicsPath
        PictureBox2.Region = New Region(figura)
    End Sub

    

End Class