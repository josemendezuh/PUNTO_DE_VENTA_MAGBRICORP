




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
Public Class CONCEPTOS_GASTOS_INGRESOS

    Private Sub CONCEPTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

        'MOSTRAR_CONCEPTOS_GASTOS()


        GuardarRegistroToolStripMenuItem.Visible = True
        ModificarToolStripMenuItem.Visible = False

    End Sub


    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
    End Sub
    Sub MOSTRAR_CONCEPTOS_GASTOS()
        'Dim dt As New DataTable
        'Dim da As SqlDataAdapter
        'Try
        '    abrir()
        '    da = New SqlDataAdapter("MOSTRAR_CONCEPTOS_GASTOS", conexion)
        '    da.Fill(dt)
        '    datalistado.DataSource = dt

        '    datalistado.Columns(1).Visible = False
        '    datalistado.Columns(2).Width = 300

        '    datalistado.Columns(0).Width = 60

        '    Cerrar()
        'Catch ex As Exception : MessageBox.Show(ex.Message)
        'End Try
        'Me.datalistado.EnableHeadersVisualStyles = False
        'Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        'styCabeceras.BackColor = Color.White
        'styCabeceras.ForeColor = Color.Black
        'styCabeceras.Font = New Font("Segoe UI", 10, FontStyle.Regular Or
        'FontStyle.Bold)
        'Me.datalistado.ColumnHeadersDefaultCellStyle = styCabeceras
    End Sub
    
    Sub LIMPIAR()
        txtdescripcion.Text = ""



    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("Id_cuenta_bancaria").Value)

                        Try

                            abrir()
                            cmd = New SqlCommand("eliminar_Cuentas_corrientes_bancos_datos_generales", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@Id_cuenta_bancaria", onekey)

                            cmd.ExecuteNonQuery()


                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try
                        Cerrar()
                    End If

                Next
                Call LIMPIAR()
             
                    MOSTRAR_CONCEPTOS_GASTOS()
             



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub NuevoRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoRegistroToolStripMenuItem.Click
        Panel8.Visible = True
        GuardarRegistroToolStripMenuItem.Visible = True
        ModificarToolStripMenuItem.Visible = False
        txtdescripcion.Text = ""

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
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Panel8.Visible = False

    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        Try


            txtdescripcion.Text = datalistado.SelectedCells.Item(2).Value


            Panel8.Visible = True
            GuardarRegistroToolStripMenuItem.Visible = False
            ModificarToolStripMenuItem.Visible = True

        Catch ex As Exception

        End Try
    End Sub

   




    Private Sub datalistadogrupodegastos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Try



        Catch ex As Exception

        End Try
    End Sub

   

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)
     
            MOSTRAR_CONCEPTOS_GASTOS()
         
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
   
        Close()


    End Sub

    Private Sub ELIMINAROKA_Click(sender As Object, e As EventArgs) Handles ELIMINAROKA.Click
        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("Id_concepto").Value)

                        Try

                            abrir()
                            cmd = New SqlCommand("eliminar_concepto", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@idconcepto", onekey)

                            cmd.ExecuteNonQuery()


                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try
                        Cerrar()
                    End If

                Next

               
                    MOSTRAR_CONCEPTOS_GASTOS()
                 
                GASTOS_VARIOS_FORM.Timer1.Start()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Panel8.Visible = False
    End Sub

    Private Sub ModificarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Dim cmd As New SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("editar_CONCEPTO", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text)
            cmd.Parameters.AddWithValue("@Id_concepto", datalistado.SelectedCells.Item(1).Value)
            cmd.ExecuteNonQuery()
           
                MOSTRAR_CONCEPTOS_GASTOS()
               
            Panel8.Visible = False

            GASTOS_VARIOS_FORM.Timer1.Start()
        Catch ex As Exception : MsgBox(ex.Message)
        End Try

        Cerrar()
    End Sub

    Private Sub GuardarRegistroToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles GuardarRegistroToolStripMenuItem.Click
        Dim cmd As New SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("insertar_Conceptos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text)
            cmd.ExecuteNonQuery()
            Cerrar()
            'MOSTRAR_CONCEPTOS_GASTOS()             
            'Panel8.Visible = False
            GASTOS_VARIOS_FORM.Timer1.Start()
            Close()
        Catch ex As Exception : MsgBox(ex.Message)
        End Try

    End Sub
End Class