Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Module Conexion_web
    Public conexionWEB As New SqlConnection(checkServerWEB)
    Sub abrirWEB()
        If conexionWEB.State = 0 Then
            conexionWEB.Open()
        End If
    End Sub
    Sub CerrarWEB()
        If conexionWEB.State = 1 Then
            conexionWEB.Close()
        End If
    End Sub
End Module
