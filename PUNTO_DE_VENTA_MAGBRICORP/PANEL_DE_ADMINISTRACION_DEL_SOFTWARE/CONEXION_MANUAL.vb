Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Xml
Public Class CONEXION_MANUAL
    Private aes As New AES()
    Private Sub ObtenerDatos()
        Dim nombreHost As String = System.Net.Dns.GetHostName
        Dim hostInfo As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(nombreHost)


        For Each ip As System.Net.IPAddress In hostInfo.AddressList
            txtdatasource.Text = ip.ToString

        Next

    End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim cmd As New SqlCommand
    '    abrir()
    '    cmd = New SqlCommand("Insertar_caja", conexion)
    '    cmd.CommandType = 4


    '    cmd.Parameters.AddWithValue("@descripcion", TXTPC2.Text)
    '    cmd.Parameters.AddWithValue("@saldo", 0)
    '    cmd.Parameters.AddWithValue("@Id_empresa", datalistado_empresas_nuevas.SelectedCells.Item(1).Value)
    '    cmd.Parameters.AddWithValue("@PC_Asignada", TXTPC2.Text)
    '    cmd.Parameters.AddWithValue("@IP", TXTIP2.Text)



    '    cmd.ExecuteNonQuery()

    '    Cerrar()
    '    mostrar_empresas_nuevas()
    'End Sub

    'Private Sub CONEXION_MANUAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MiAppConfig As Configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)
        Dim MiSeccion As ConnectionStringsSection = DirectCast(MiAppConfig.GetSection("connectionStrings"), ConnectionStringsSection)
        MiSeccion.ConnectionStrings("PUNTO_DE_VENTA_MAGBRICORP.My.MySettings.BASEMACKEYS").ConnectionString = txtdatasource.Text
        MiAppConfig.Save()
        MessageBox.Show("Conexion generada")
        Application.Restart()

    End Sub
    Public Sub SavetoXML(ByVal dbcnString)
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load("ConnectionString.xml")
        Dim root As XmlElement = doc.DocumentElement
        root.Attributes.Item(0).Value = dbcnString
        Dim writer As XmlTextWriter = New XmlTextWriter("ConnectionString.xml", Nothing)
        writer.Formatting = Formatting.Indented
        doc.Save(writer)
        writer.Close()
    End Sub
    Public Sub SavetoHTML(ByVal dbcnString)
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load("Diseño_html.xml")
        Dim root As XmlElement = doc.DocumentElement
        root.Attributes.Item(0).Value = dbcnString
        Dim writer As XmlTextWriter = New XmlTextWriter("Diseño_html.xml", Nothing)
        writer.Formatting = Formatting.Indented
        doc.Save(writer)
        writer.Close()
    End Sub
    Dim dbcnString As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtCnString.Text = "" Then
            MessageBox.Show("Por favor ingrese la cadena de Conexion..", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            SavetoXML(aes.Encrypt(txtCnString.Text, appPwdUnique, Integer.Parse("256")))
            'MessageBox.Show("Conexion Creada Archivo: ConnectionString.xml", "Encryptacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mostrar_usuario()

        End If

    End Sub
    Public Sub ReadfromXML()

        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("ConnectionString.xml")
            Dim root As XmlElement = doc.DocumentElement
            dbcnString = root.Attributes.Item(0).Value
            txtCnString.Text = (aes.Decrypt(dbcnString, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException


        End Try
    End Sub
    Public Sub ReadfromXMLWEB()
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("Conexion_web.xml")
            Dim root As XmlElement = doc.DocumentElement
            dbcnString = root.Attributes.Item(0).Value
            txtCnStringWEB.Text = (aes.Decrypt(dbcnString, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException

        End Try
    End Sub
    Private Sub CONEXION_MANUAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerDatos()
        ReadfromXML()
        ReadfromXMLWEB()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

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
    Public Sub SavetoWeb(ByVal dbcnString)
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load("Conexion_web.xml")
        Dim root As XmlElement = doc.DocumentElement
        root.Attributes.Item(0).Value = dbcnString
        Dim writer As XmlTextWriter = New XmlTextWriter("Conexion_web.xml", Nothing)
        writer.Formatting = Formatting.Indented
        doc.Save(writer)
        writer.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtCnStringWEB.Text = "" Then
            MessageBox.Show("Por favor ingrese la cadena de Conexion..", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            SavetoWeb(aes.Encrypt(txtCnStringWEB.Text, appPwdUnique, Integer.Parse("256")))
            MessageBox.Show("Conexion Creada Archivo: ConnectionString.xml", "Encryptacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Application.Exit()
        End If
    End Sub
    Sub mostrar_usuario()

        Try
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            da = New SqlDataAdapter("select * from USUARIO2", txtCnString.Text)
            da.Fill(dt)
            datalistado_movimientos_validar.DataSource = dt

            MessageBox.Show("Conexion Creada Correctamente, Abra de nuevo el Aplicativo", "Conexion completada", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End
        Catch ex As Exception
            MessageBox.Show("Conexion Fallida, Revisa de nuevo la Cadena de Conexion o Escribenos para Ayudarte de Inmediato", "Sin Conexion", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try


    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        'ObtenerDatos()
        'ReadfromXML()
        mostrar_usuario()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ObtenerDatos()
        ReadfromXMLWEB()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        mostrar_usuario()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub
End Class