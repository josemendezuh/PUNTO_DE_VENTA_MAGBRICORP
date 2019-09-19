
Imports System.Data.SqlClient
Imports System.Xml
Imports System.Management
Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.IO

Public Class Membresias
    Private MisDiscos As New ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard")
    Private DiscInfo As New ManagementObject
    Private aes As New AES()
    Sub mostrar_nombre_de_admin()

        Dim importe As Double
        Dim com As New SqlCommand("Select Nombre_y_Apelllidos from USUARIO2 where Login='admin'", conexion)

        Try
            abrir()
            importe = (com.ExecuteScalar())
            Cerrar()
            lblnombreAdmin.Text = importe

        Catch ex As Exception

        End Try


    End Sub
    Sub mostrar_empresa()

        Dim importe As Double
        Dim com As New SqlCommand("Select Nombre_Empresa from EMPRESA", conexion)

        Try
            abrir()
            importe = (com.ExecuteScalar())
            Cerrar()
            lblEmpresa.Text = importe

        Catch ex As Exception

        End Try


    End Sub
    Sub mostrar_correo_de_empresa()

        Dim importe As String
        Dim com As New SqlCommand("Select Correo_para_envio_de_reportes from EMPRESA", conexion)

        Try
            abrir()
            importe = (com.ExecuteScalar())
            Cerrar()
            txtcorreo.Text = importe

        Catch ex As Exception

        End Try


    End Sub
    Sub crear_licencia()


        Dim CMD As SqlCommand
        Try
            abrirWEB()
            CMD = New SqlCommand("Insertar_lic", conexionWEB)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@Serial_pc", txtSerial.Text)
            CMD.Parameters.AddWithValue("@Serial_Licencia", "Ninguna")
            CMD.Parameters.AddWithValue("@Fecha_de_finalizacion", Now())
            CMD.Parameters.AddWithValue("@Estado", "PENDIENTE")
            CMD.Parameters.AddWithValue("@Nombre_admin", lblnombreAdmin.Text)
            CMD.Parameters.AddWithValue("@Empresa", lblEmpresa.Text)
            CMD.Parameters.AddWithValue("@Correo", txtcorreo.Text)
            CMD.Parameters.AddWithValue("@Periodo", "1 mes (es)")
            CMD.Parameters.AddWithValue("@Software", "Ada_369")
            CMD.Parameters.AddWithValue("@Fecha_de_solicitud", Now())
            CMD.Parameters.AddWithValue("@Fecha_de_activacion", Now())
            CMD.ExecuteNonQuery()
            CerrarWEB()
        Catch ex As Exception
            MsgBox(ex.Message)
            PanelConexion.Visible = True
            Label7.Text = "Sin conexion a Internet "
            desconectado.Visible = True
        End Try
    End Sub
    Public Sub ReadfromXML_SERIAL_PC()
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load(lblruta.Text)
            Dim root As XmlElement = doc.DocumentElement
            dbcnString = root.Attributes.Item(0).Value
            lblarchivo1.Text = (aes.Decrypt(dbcnString, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException


        End Try
    End Sub
    Dim dbcnString As String
    Sub MOSTRAR_licencia_temporal()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("SELECT*FROM Marcan", conexion)

            da.Fill(dt)
            datalistado_licencia_temporal.DataSource = dt
            Cerrar()


        Catch ex As Exception ': MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With dlg
            .InitialDirectory = ""
            .Filter = "Licencia ADA369|*.xml"
            .FilterIndex = 2
            .Title = "Cargador de Licencia ADA 369"

        End With
        If dlg.ShowDialog() = DialogResult.OK Then
            Try
                lblruta.Text = Path.GetFullPath(dlg.FileName)
                ReadfromXML_SERIAL_PC()
                Dim cadena As String = lblarchivo1.Text

                Dim separadas As String()

                separadas = cadena.Split("|")
                lblSerial.Text = separadas(1)
                lblFecha.Text = separadas(2)
                lblEstado.Text = separadas(3)
                lblSoftware.Text = separadas(4)
                Dim MiInfo = From Hd As ManagementObject In MisDiscos.Get Select Hd
                DiscInfo = MiInfo(0)
                lblIDSERIAL.Text = DiscInfo.Properties("SerialNumber").Value

            Catch ex As Exception

            End Try

            If lblSoftware.Text = "Ada_369" And lblEstado.Text = "PENDIENTE" Then

                ACTIVACION_DE_LICENCIA_manual()
                MOSTRAR_licencia_temporal()


                Try
                    txtfecha_final_licencia_temporal.Value = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(3).Value.Trim)
                    lblSerialPcLocal.Text = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(2).Value.Trim)
                    LBLESTADOLicenciaLocal.Text = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(4).Value.Trim)
                    txtfecha_inicio_licencia.Value = Desencriptar(datalistado_licencia_temporal.SelectedCells.Item(5).Value.Trim)

                Catch ex As Exception
                End Try
                If txtfecha_final_licencia_temporal.Value >= TXTFECHA_SISTEMA.Value And lblSerialPcLocal.Text = lblIDSERIAL.Text Then
                    If txtfecha_inicio_licencia.Value <= TXTFECHA_SISTEMA.Value Then

                        If LBLESTADOLicenciaLocal.Text = "?ACTIVADO PRO?" Then
                            PanelActivando_licencia.Visible = True
                            PanelActivando_licencia.Dock = DockStyle.Fill
                            PictureBox1.Visible = False
                            lblActivando_licencia.Text = "Licencia Activada hasta " & lblFecha.Text


                        End If


                    Else

                    End If
                End If



            Else
                MessageBox.Show("Archivo de licencia rechazado por Datos Incorrectos", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If

        'cargarLicencia_solicitada()
        'Try
        '    Label6.Text = datalistadoLicencias.SelectedCells.Item(1).Value
        '    lblActivando_licencia.Text = "Ya solicitaste tu Licencia vuelve a abrir el Aplicativo mas tarde"
        'Catch ex As Exception
        '    crear_licencia()
        '    lblActivando_licencia.Text = "Aun no Realizas la Compra de tu Licencia, se te direccionara a nuestra pagina Web: magbri.co"
        '    System.Diagnostics.Process.Start("https://magbri.co/product/sistema-de-ventas-magbriventa/")
        'End Try


        ''ACTIVAR_LICENCIA.ShowDialog()

    End Sub
    Sub cargarLicencia_solicitada()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_estado_de_licencia", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Serial", txtSerial.Text)

            da.Fill(dt)
            datalistadoLicencias.DataSource = dt
            Cerrar()
        Catch ex As Exception ': MessageBox.Show(ex.Message)

        End Try


    End Sub
    Sub BUSCAR_L()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrirWEB()
            da = New SqlDataAdapter("BUSCAR_L", conexionWEB)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Serial_pc", txtSerial.Text)
            da.Fill(dt)

            datalistado_licencias.DataSource = dt
            CerrarWEB()
        Catch ex As Exception

        End Try


    End Sub
    Sub ACTIVACION_DE_LICENCIA_manual()
        Dim SERIALpC As String
        SERIALpC = Encriptar(Me.lblIDSERIAL.Text.Trim)

        Dim FECHA_FINAL As String
        FECHA_FINAL = Encriptar(Me.lblFecha.Text.Trim)
        Dim estado As String
        estado = Encriptar("?ACTIVADO PRO?")
        Dim fecha_activacion
        fecha_activacion = Encriptar(Me.TXTFECHA_SISTEMA.Text.Trim)
        Dim CMD As SqlCommand
        Try
            abrir()
            CMD = New SqlCommand("EDITAR_marcan_a", conexion)
            CMD.CommandType = CommandType.StoredProcedure

            CMD.Parameters.AddWithValue("@e", estado)
            CMD.Parameters.AddWithValue("@fa", fecha_activacion)
            CMD.Parameters.AddWithValue("@f", FECHA_FINAL)
            CMD.Parameters.AddWithValue("@s", SERIALpC)

            CMD.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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
    Sub Activar_licencia()
        Dim CMD As SqlCommand
        Try
            abrirWEB()
            CMD = New SqlCommand("Activar_l", conexionWEB)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@id", datalistado_licencias.SelectedCells.Item(1).Value)
            CMD.Parameters.AddWithValue("@Fecha_de_activacion", Now())
            CMD.ExecuteNonQuery()
            CerrarWEB()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Membresias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MiInfo = From Hd As ManagementObject In MisDiscos.Get Select Hd
        DiscInfo = MiInfo(0)
        txtSerial.Text = DiscInfo.Properties("SerialNumber").Value
        mostrar_correo_de_empresa()
        mostrar_nombre_de_admin()
        mostrar_empresa()

        'ACTIVACION_AUTOMATICA_DE_LICENCIA()


    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        crear_licencia()

        Try

            System.Diagnostics.Process.Start("https://magbri.co/product/sistema-de-ventas-magbriventa/")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Membresias_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReadfromXML_SERIAL_PC()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub
End Class