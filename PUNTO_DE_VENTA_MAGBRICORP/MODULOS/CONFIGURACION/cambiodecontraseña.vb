
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

Public Class cambiodecontraseña

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs)

    End Sub
    Sub limpiar()
        txtActual.Text = ""
        txtLogin.Text = ""
        txtContraseña.Text = ""
        txtConfirmar.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)

    End Sub

    Sub TestValidatePassword()
        'Dim password As String = "Password"
        '' Demonstrate that "Password" is not complex.
        'MsgBox(password & " is complex: " & ValidatePassword(password))

        'password = "Z9f%a>2kQ"
        '' Demonstrate that "Z9f%a>2kQ" is not complex.
        'MsgBox(password & " is complex: " & ValidatePassword(password))
    End Sub
    Private Sub ACEPTAR_Click(sender As Object, e As EventArgs)
        If txtContraseña.Text = txtConfirmar.Text Then


            Dim cmd As New SqlCommand
            Try
               
                abrir()
                cmd = New SqlCommand("Cambiar_Password", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@login", txtLogin.Text)
                cmd.Parameters.AddWithValue("@Password", txtActual.Text)
                cmd.Parameters.AddWithValue("@NuevoPassword", txtConfirmar.Text)
             
                cmd.ExecuteNonQuery()
                MsgBox("CONTRASEÑA MODIFICADA")


            Catch ex As Exception : MsgBox(ex.Message)
            End Try

            Cerrar()
        Else
            MsgBox("Las contraseñas deben coincidir", MsgBoxStyle.OkOnly, "INCORRECTO")
        End If
    End Sub

    Private Sub CANCELAR_Click(sender As Object, e As EventArgs)
        limpiar()
        Me.Close()
    End Sub

    Private Sub cambiodecontraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtLogin.Text = FRMUSUARIOSOK.txtLogin.Text
        'lblusuario.Text = FRMUSUARIOSOK.TxtNombre.Text

    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub

    'Private Sub txtConfirmar_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmar.TextChanged
    '    MsgBox(txtContraseña.Text & " is complex: " & ValidatePassword(txtContraseña.Text))
    'End Sub

    Private Sub btncambiocontraseña_Click(sender As Object, e As EventArgs) Handles btncambiocontraseña.Click
        If txtContraseña.Text = txtConfirmar.Text Then


            Dim cmd As New SqlCommand
            Try

                abrir()
                cmd = New SqlCommand("Cambiar_Contraseña", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@login", txtLogin.Text)
                cmd.Parameters.AddWithValue("@Password", txtActual.Text)
                cmd.Parameters.AddWithValue("@NuevoPassword", txtConfirmar.Text)

                cmd.ExecuteNonQuery()




            Catch ex As Exception : MsgBox(ex.Message)
            End Try

            Cerrar()
        Else
            MsgBox("Las contraseñas deben coincidir", MsgBoxStyle.OkOnly, "INCORRECTO")
        End If
    End Sub
End Class