
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
Public Class REGISTRO_DE_CUENTAS_BANCARIAS

    Private Sub GuardarRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarRegistroToolStripMenuItem.Click
        Dim cmd As New SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("insertar_Cuentas_corrientes_bancos_datos_generales", conexion)
            cmd.CommandType = 4
            '         @Titular_de_la_cuenta varchar(50),        
            '         @Id_Banco as INT , 
            '@Numero_Cuenta_corriente varchar(max),        
            '         @Saldo as numeric(18,2) ,
            '@Moneda as varchar(50)
            cmd.Parameters.AddWithValue("@Titular_de_la_cuenta", txttitular.Text)
            cmd.Parameters.AddWithValue("@Id_Banco", datalistadobancos.SelectedCells.Item(1).Value)
            cmd.Parameters.AddWithValue("@Numero_Cuenta_corriente", txtnumerodecuenta.Text)
            cmd.Parameters.AddWithValue("@Saldo", txtsaldo.Text)
            cmd.Parameters.AddWithValue("@Moneda", txtmoneda.Text)
            cmd.ExecuteNonQuery()
            Listar()
            Panel8.Visible = False
            contar()

        Catch ex As Exception : MsgBox(ex.Message)
        End Try

        Cerrar()


    End Sub

    Private Sub REGISTRO_DE_CUENTAS_BANCARIAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        Listar()
        Listarbancos()

        contar()

    End Sub
    Private Sub contar()
        Dim x As Integer
        x = datalistado.Rows.Count
        txtcontador.Text = CStr(x)
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
    End Sub
    Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_Cuentas_corrientes_bancos_datos_generales", conexion)
            da.Fill(dt)
            datalistado.DataSource = dt
            contar()
            datalistado.Columns(1).Visible = False
            datalistado.Columns(2).Width = 100
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()
    End Sub
    Sub Listarbancos()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM BANCOS", conexion)
            da.Fill(dt)
            datalistadobancos.DataSource = dt
            contar()
            datalistadobancos.Columns(1).Visible = False
            datalistadobancos.Columns(2).Width = 260
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()
    End Sub

    Sub LIMPIAR()
        txttitular.Text = ""

        txtnumerodecuenta.Text = ""
        txtsaldo.Text = ""
        txtnombredebanco.Text = ""

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
                Call Listar()



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub NuevoRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoRegistroToolStripMenuItem.Click
        Panel8.Visible = True
        LIMPIAR()

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
    
            txtnombredebanco.Text = datalistado.SelectedCells.Item(2).Value

            txttitular.Text = datalistado.SelectedCells.Item(3).Value
            txtnumerodecuenta.Text = datalistado.SelectedCells.Item(4).Value
            txtsaldo.Text = datalistado.SelectedCells.Item(5).Value
            txtmoneda.Text = datalistado.SelectedCells.Item(6).Value
            Panel8.Visible = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Dim cmd As New SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("editar_Titular_de_la_cuenta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Titular_de_la_cuenta", txttitular.Text)
            cmd.Parameters.AddWithValue("@Id_Banco", datalistadobancos.SelectedCells.Item(1).Value)
            cmd.Parameters.AddWithValue("@Numero_Cuenta_corriente", txtnumerodecuenta.Text)
            cmd.Parameters.AddWithValue("@Saldo", txtsaldo.Text)
            cmd.Parameters.AddWithValue("@Moneda", txtmoneda.Text)
            cmd.Parameters.AddWithValue("@Id_cuenta_bancaria", datalistado.SelectedCells.Item(1).Value)
            cmd.ExecuteNonQuery()
            Listar()
            Panel8.Visible = False
            contar()

        Catch ex As Exception : MsgBox(ex.Message)
        End Try

        Cerrar()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        Listar()

    End Sub

    Private Sub datalistadobancos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadobancos.CellClick
        Try
            txtnombredebanco.Text = datalistadobancos.SelectedCells.Item(2).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub datalistadobancos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadobancos.CellContentClick
       
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        REGISTRO_DE_BANCOS.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        Listarbancos()

    End Sub
End Class