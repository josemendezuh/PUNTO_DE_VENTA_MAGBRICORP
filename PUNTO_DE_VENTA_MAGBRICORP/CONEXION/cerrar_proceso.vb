
Module cerrar_proceso
    Function cierrre_proceso(strnombre As String)
        Dim listarprocesos As Object
        Dim objectowmi As Object
        Dim procesocerrado As Object
        cierrre_proceso = False
        objectowmi = GetObject("winmgmts:")
        If IsDBNull(objectowmi) = False Then

        End If
        'Set objectowmi =getObject("winmgmts:")
        If UCase("osk.exe") = UCase(strnombre) Then
            procesocerrado.Terminate(0)
            cierrre_proceso = True

        End If
    End Function
End Module
