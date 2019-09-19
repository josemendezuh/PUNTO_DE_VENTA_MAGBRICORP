
Imports System.Data.SqlClient

Imports System.Management

Imports System.Xml
Public Class ACTIVAR_LICENCIA
    Private MisDiscos As New ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard")
    Private DiscInfo As New ManagementObject
    Private aes As New AES()
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        
        Me.Close()

    End Sub

    Private Sub ACTIVAR_LICENCIA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MiInfo = From Hd As ManagementObject In MisDiscos.Get Select Hd
        DiscInfo = MiInfo(0)
        lblserialPc.Text = DiscInfo.Properties("SerialNumber").Value
        BUSCAR_L()

    End Sub
    Public Sub SavetoXML_SERIAL_LICENCIA(ByVal dbcnString)
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load("Serial_l.xml")
        Dim root As XmlElement = doc.DocumentElement
        root.Attributes.Item(0).Value = dbcnString
        Dim writer As XmlTextWriter = New XmlTextWriter("Serial_l.xml", Nothing)
        writer.Formatting = Formatting.Indented
        doc.Save(writer)
        writer.Close()
    End Sub
    Public Sub SavetoXML_SERIAL_PC(ByVal dbcnString)
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load("Serial_x.xml")
        Dim root As XmlElement = doc.DocumentElement
        root.Attributes.Item(0).Value = dbcnString
        Dim writer As XmlTextWriter = New XmlTextWriter("Serial_x.xml", Nothing)
        writer.Formatting = Formatting.Indented
        doc.Save(writer)
        writer.Close()
    End Sub
    Public Sub SavetoXML_fecha_expiracion(ByVal dbcnString)
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load("Serial_ff.xml")
        Dim root As XmlElement = doc.DocumentElement
        root.Attributes.Item(0).Value = dbcnString
        Dim writer As XmlTextWriter = New XmlTextWriter("Serial_ff.xml", Nothing)
        writer.Formatting = Formatting.Indented
        doc.Save(writer)
        writer.Close()
    End Sub
    Sub BUSCAR_L()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrirWEB()
            da = New SqlDataAdapter("BUSCAR_L", conexionWEB)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Serial_pc", lblserialPc.Text)
            da.SelectCommand.Parameters.AddWithValue("@Serial_Licencia", txtserial.Text)
            da.Fill(dt)

            datalistado_licencias.DataSource = dt
            CerrarWEB()
        Catch ex As Exception
            Panel4.Visible = True
            Label3.Text = "Sin conexion a Internet "
            desconectado.Visible = True
        End Try


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'BUSCAR_L()
        'Try
        '    LBLSERIAL_LICENCIA_WEB.Text = datalistado_licencias.SelectedCells.Item(3).Value
        'Catch ex As Exception
        'End Try

        'If LBLSERIAL_LICENCIA_WEB.Text = txtserial.Text and lblserialPc.Text = Then
        '    SavetoXML_fecha_expiracion(aes.Encrypt(lblfechaexpircion.Text, appPwdUnique, Integer.Parse("256")))
        '    SavetoXML_SERIAL_PC(aes.Encrypt(lblserialPc.Text, appPwdUnique, Integer.Parse("256")))
        '    SavetoXML_SERIAL_LICENCIA(aes.Encrypt(lblserialLicencia.Text, appPwdUnique, Integer.Parse("256")))
        '    Timermostrar.Start()
        'End If

    End Sub

    Private Sub Timermostrar_Tick(sender As Object, e As EventArgs) Handles Timermostrar.Tick
        Me.Height = Me.Height + 10
        If Me.Height = 300 Then Timermostrar.Stop()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Timermostrar.Start()

    End Sub
    Sub Activar_licencia()
        Dim CMD As SqlCommand
        Try
            abrirWEB()
            CMD = New SqlCommand("Activar_l", conexionWEB)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@Licencia", LBLSERIAL_LICENCIA_WEB.Text)
        
            CMD.ExecuteNonQuery()
            CerrarWEB()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub eliminar_l()
        Dim CMD As SqlCommand
        Try
            abrirWEB()
            CMD = New SqlCommand("eliminar_l", conexionWEB)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@Licencia", LBLSERIAL_LICENCIA_WEB.Text)

            CMD.ExecuteNonQuery()
            CerrarWEB()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtserial_TextChanged(sender As Object, e As EventArgs) Handles txtserial.TextChanged
        BUSCAR_L()
        Try
            LBLSERIAL_LICENCIA_WEB.Text = datalistado_licencias.SelectedCells.Item(3).Value
            lblserialPcWEB.Text = datalistado_licencias.SelectedCells.Item(2).Value
            txtfechaWEB.Text = datalistado_licencias.SelectedCells.Item(4).Value
        Catch ex As Exception
        End Try

        If LBLSERIAL_LICENCIA_WEB.Text = txtserial.Text And lblserialPcWEB.Text = lblserialPc.Text Then
            Activar_licencia()
            SavetoXML_fecha_expiracion(aes.Encrypt(txtfechaWEB.Text, appPwdUnique, Integer.Parse("256")))
            SavetoXML_SERIAL_PC(aes.Encrypt(lblserialPcWEB.Text, appPwdUnique, Integer.Parse("256")))
            SavetoXML_SERIAL_LICENCIA(aes.Encrypt(LBLSERIAL_LICENCIA_WEB.Text, appPwdUnique, Integer.Parse("256")))
            eliminar_l()
            Timermostrar.Start()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Panel4.Visible = False
        desconectado.Visible = False
     
    End Sub
End Class