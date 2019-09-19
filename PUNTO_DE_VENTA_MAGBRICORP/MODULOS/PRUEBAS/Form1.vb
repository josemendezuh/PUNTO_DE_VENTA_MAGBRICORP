Public Class Form1
    Dim a As Double = 0
    Dim b As Double = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        a = a + 1
        If a > 9 Then
            a = 0
            b = b + 1

        End If
        If b > 50 Then
            b = 0
        End If
        If b >= 0 Then
            CircularProgressBar1.ProgressColor = Color.White

        End If
        If b > 15 Then
            CircularProgressBar1.ProgressColor = Color.Orange
        End If

        CircularProgressBar1.SubscriptText = "." & a
        CircularProgressBar1.Value = b
        CircularProgressBar1.Text = CircularProgressBar1.Value

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
End Class