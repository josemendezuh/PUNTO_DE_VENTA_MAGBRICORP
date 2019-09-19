Module MENSAJES_EMERGENTE
    Sub TOOL(ByVal lblmensaje As String, ByVal buton As Object)
        Dim toolTipoka As ToolTip = New ToolTip()
        toolTipoka.AutoPopDelay = 1000
        toolTipoka.InitialDelay = 500
        toolTipoka.ReshowDelay = 500

        toolTipoka.Show(lblmensaje, buton)
        toolTipoka.BackColor = Color.Black
        toolTipoka.ForeColor = Color.White
        'toolTip1.SetToolTip(Me.Button1, "My button1")
        'toolTip1.SetToolTip(Me.checkBox1, "My checkBox1")
    End Sub
    Sub labelRegistrado()
        Dim labelRegistrado As New Label
        'labelRegistrado.Text = "okioki"


    End Sub
    Sub timerOki(ByVal labell As Label)
        Dim timer As New Timer

        Dim labelRegistrado As New Label

        timer.Interval = 1000
        timer.Start()
        'If contador = 5 Then
        labelRegistrado.Text = "okioki"
        labelRegistrado.BringToFront()
        labelRegistrado.Show()

        'Else
        'contador += 1
        'End If

    End Sub
End Module
