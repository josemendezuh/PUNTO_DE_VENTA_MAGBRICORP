Imports System.Configuration
Imports System.Data.SqlClient

Public Module DataHelper


    Public Function LoadDataTable() As DataTable
          Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter

        abrir()
        daListarpresentacionesagregadas = New SqlDataAdapter("SELECT*FROM Producto1", conexion)
        'daListarpresentacionesagregadas.SelectCommand.CommandType = 4


        'daListarpresentacionesagregadas.SelectCommand.Parameters.AddWithValue("@buscar", txtdescripcion.Text)

        daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
        Return dtDATALISTADO_AGREGANDO


    End Function

    Public Function LoadAutoComplete() As AutoCompleteStringCollection
        Dim dt As DataTable = LoadDataTable()

        Dim stringCol As New AutoCompleteStringCollection()

        For Each row As DataRow In dt.Rows
            stringCol.Add(Convert.ToString(row("Descripcion")))
        Next

        Return stringCol
    End Function

End Module
