Namespace My.Resources
    Class misrecursos

        'ejecuto los caracteres que deseo extraer para generar el path
        Dim ejecutarrutacompleta = Microsoft.VisualBasic.Right(My.Application.Info.DirectoryPath.Length - 10, My.Application.Info.DirectoryPath.Length)

        'genero solo el path dela aplicacion poniendolo mas corto a modo que que has lo pedio anterior mente
        Dim RutaDeaplicacion As String = Microsoft.VisualBasic.Left(My.Application.Info.DirectoryPath, ejecutarrutacompleta)

        'ejecutamos solo la ruta especificada
        Dim EjecutarArchivo = RutaDeaplicacion & "\Resources\"

        Public ReadOnly Property rutasArbol() As String

            Get

                'retornamos valor 
                Return EjecutarArchivo & "SqlBasemackeys.sql"


            End Get
        End Property

    End Class
End Namespace