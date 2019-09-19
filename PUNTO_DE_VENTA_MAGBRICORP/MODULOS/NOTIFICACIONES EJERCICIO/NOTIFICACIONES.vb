Imports System.Data.SqlClient
Public Class NOTIFICACIONES
    Private Sub NOTIFICACIONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dibujarCOBROS()

    End Sub
    Sub dibujarCOBROS()
        abrir()
        Dim query As String = "NOTIFICADOR_COBROS"
        Dim cmd As New SqlCommand(query, conexion)
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        While rdr.Read
            Dim b As New Label()
            Dim p1 As New Panel
            Dim P2 As New Panel
            Dim I1 As New PictureBox
            Dim I2 As New PictureBox
            Dim L As New Label

            b.Text = rdr("Nombre").ToString() & " Te debe " & "(" & rdr("Saldo").ToString() & ")"
            b.Size = New System.Drawing.Size(430, 35)
            b.Font = New System.Drawing.Font(10, 10)
            b.BackColor = Color.White
            b.ForeColor = Color.Black
            b.Dock = DockStyle.Top
            b.TextAlign = ContentAlignment.MiddleLeft
            b.Cursor = Cursors.Hand

            L.Text = "(" & rdr("Saldo").ToString() & ") Saldo por Cobrar"
            L.Name = rdr("Nombre").ToString()
            L.Size = New System.Drawing.Size(430, 18)
            L.Font = New System.Drawing.Font(10, 10)
            L.BackColor = BackColor
            L.FlatStyle = FlatStyle.Flat
            L.BackColor = Color.White
            L.ForeColor = Color.Gray
            L.Dock = DockStyle.Fill
            L.TextAlign = ContentAlignment.MiddleLeft
            L.Cursor = Cursors.Hand

            I2.BackgroundImage = My.Resources.monedas
            I2.BackgroundImageLayout = ImageLayout.Zoom
            I2.Size = New System.Drawing.Size(18, 18)
            I2.Dock = DockStyle.Left

            p1.Size = New System.Drawing.Size(430, 67)
            p1.BorderStyle = BorderStyle.FixedSingle
            p1.Dock = DockStyle.Top
            p1.BackColor = Color.White

            P2.Size = New System.Drawing.Size(287, 22)
            P2.Dock = DockStyle.Top
            P2.BackColor = Color.White

            I1.BackgroundImage = My.Resources.COBROSSSS
            I1.BackgroundImageLayout = ImageLayout.Zoom
            I1.Size = New System.Drawing.Size(90, 69)
            I1.Dock = DockStyle.Left
            I1.BackColor = Color.White

            p1.Controls.Add(b)
            p1.Controls.Add(I1)
            p1.Controls.Add(P2)
            P2.Controls.Add(I2)
            P2.Controls.Add(L)

            P2.BringToFront()
            b.SendToBack()
            I1.SendToBack()
            L.BringToFront()

            FlowLayoutPanel1.Controls.Add(p1)


        End While

        Cerrar()

    End Sub
End Class