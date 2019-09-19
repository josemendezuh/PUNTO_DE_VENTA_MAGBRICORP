

Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Module Class3
    Public conexion0 As New SqlConnection(checkServer)
    Sub abrir0()
        If conexion0.State = 0 Then
            conexion0.Open()
        End If
    End Sub
    Sub Cerrar0()
        If conexion0.State = 1 Then
            conexion0.Close()
        End If
    End Sub

End Module
