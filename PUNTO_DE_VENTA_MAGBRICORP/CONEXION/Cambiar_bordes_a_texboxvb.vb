Public Class Cambiar_bordes_a_texboxvb
    Public Class TextBoxEx

        Inherits TextBox

        Protected Overrides Sub OnEnter(e As EventArgs)

            MyBase.OnEnter(e)

            DrawRectangle(Color.Red)

        End Sub

        Protected Overrides Sub OnLeave(e As EventArgs)

            MyBase.OnLeave(e)
            ' Formulario contenedor del control
            Dim frm As Control = Me.Parent

            DrawRectangle(frm.BackColor)

        End Sub

        Private Sub DrawRectangle(clr As Color)

            Dim d As Integer = 2

            Dim pt As New Point(Me.Location.X - d, Me.Location.Y - d)
            Dim sz As New Size(Me.Width + (2 * d), Me.Height + (2 * d))

            ' Formulario contenedor del control
            '
            Dim frm As Control = Me.Parent

            Using g As Graphics = frm.CreateGraphics()
                Dim rect As New Rectangle(pt, sz)
                Dim p As New Pen(clr, 2)
                g.DrawRectangle(p, rect)
                p.Dispose()
            End Using

        End Sub

    End Class
End Class
