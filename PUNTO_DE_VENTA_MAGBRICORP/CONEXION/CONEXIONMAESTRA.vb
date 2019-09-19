Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Module CONEXIONMAESTRA
    Public conexion As New SqlConnection(checkServer)
    Sub abrir()
        If conexion.State = 0 Then
            conexion.Open()
        End If
    End Sub
    Sub Cerrar()
        If conexion.State = 1 Then
            conexion.Close()
        End If
    End Sub

End Module
