
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Xml
Imports System.IO

Public Class BIENVENIDO
    Private aes As New AES()
    Dim a As Double = 0
    Dim b As Double = 0

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        If cbruta.Text = "" Then
            MessageBox.Show("Seleccione un Disco", "Seleccione", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cbruta.Text <> "" Then

            PanelConfiguracion.Dock = DockStyle.Fill
            PanelConfiguracion.Visible = True

            CircularProgressBar1.Value = 0
            Timer3.Start()

        End If


    End Sub


    Sub ejecutar_para_Instancias_con_otros_nombres()
        Try
            Dim instanceName As String = ".\SQLEXPRESS"
            Dim folder As String = GetMasterFolderPath_EXPRESS(instanceName)
            lblRutaInstancia.Text = folder
        Catch ex As Exception
            ejecutar_para_Instancias_con_otros_nombres_NORMAL()
        End Try
    End Sub
    Sub ejecutar_para_Instancias_con_otros_nombres_NORMAL()
        Try
            Dim instanceName As String = ".\"
            Dim folder As String = GetMasterFolderPath_NORMAL(instanceName)
            lblRutaInstancia.Text = folder
        Catch ex As Exception
            Dim hola As String
            hola = (ex.Message)
            lblRutaInstancia.Text = hola
        End Try
    End Sub

    Sub crear_base_normal()
        Dim cnn As New SqlConnection(
                       "Server=" & ".\" & "; " &
                       "database=master; integrated security=yes")

        Dim s As String = "CREATE DATABASE " & "BASEADA"
        Dim cmd As New SqlCommand(s, cnn)

        Try

            cnn.Open()
            cmd.ExecuteNonQuery()
            textBoxNombreServidor.Text = ".\"
            SavetoXML(aes.Encrypt("Data Source=.\;Initial Catalog=BASEADA;Integrated Security=True", appPwdUnique, Integer.Parse("256")))
            ejecutar_scryt_crearProcedimientos_almacenados_y_tablas()

        Catch ex As Exception
            MessageBox.Show(ex.Message,
                            "Error al crear la base",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try

    End Sub
    Sub ejecutar_scryt_crearBase()

        Dim cnn As New SqlConnection(
                       "Server=" & ".\SQLEXPRESS" & "; " &
                       "database=master; integrated security=yes")

        Dim s As String = "CREATE DATABASE " & "BASEADA"
        Dim cmd As New SqlCommand(s, cnn)

        Try

            cnn.Open()
            cmd.ExecuteNonQuery()
            textBoxNombreServidor.Text = ".\SQLEXPRESS"
            SavetoXML(aes.Encrypt("Data Source=.\SQLEXPRESS;Initial Catalog=BASEADA;Integrated Security=True", appPwdUnique, Integer.Parse("256")))
            ejecutar_scryt_crearProcedimientos_almacenados_y_tablas()

        Catch ex As Exception
            crear_base_normal()
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try

    End Sub

    Sub ejecutar_scryt_ELIMINARBaseEXPRESS()
        Dim str As String
        Dim myConn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
        str = txtEliminarBase.Text
        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try
    End Sub
    Sub ejecutar_scryt_ELIMINARBaseNORMAL()
        Dim str As String
        Dim myConn As SqlConnection = New SqlConnection("Data Source=.\;Initial Catalog=master;Integrated Security=True")
        str = txtEliminarBase.Text
        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try
    End Sub
    Private Shared Function GetMasterFolderPath_EXPRESS(instanceName As String) As String


        Dim cadenaConexion As String = "Initial Catalog=master;Integrated Security=True;Data Source=" & ".\SQLEXPRESS"
        Dim folderPath As String = String.Empty

        Using cnn As New SqlConnection(cadenaConexion)
            Dim cmd As SqlCommand = cnn.CreateCommand()
            cmd.CommandText =
                "SELECT SUBSTRING(physical_name, 1, CHARINDEX(N'master.mdf', physical_name) - 1) AS FolderPath " &
                "FROM master.sys.master_files " &
                "WHERE name = N'master'"
            cnn.Open()
            folderPath = cmd.ExecuteScalar().ToString()
        End Using

        Return folderPath

    End Function
    Private Shared Function GetMasterFolderPath_NORMAL(instanceName As String) As String


        Dim cadenaConexion As String = "Initial Catalog=master;Integrated Security=True;Data Source=" & ".\"
        Dim folderPath As String = String.Empty

        Using cnn As New SqlConnection(cadenaConexion)
            Dim cmd As SqlCommand = cnn.CreateCommand()
            cmd.CommandText =
                "SELECT SUBSTRING(physical_name, 1, CHARINDEX(N'master.mdf', physical_name) - 1) AS FolderPath " &
                "FROM master.sys.master_files " &
                "WHERE name = N'master'"
            cnn.Open()
            folderPath = cmd.ExecuteScalar().ToString()
        End Using

        Return folderPath

    End Function
    Sub autorizar_usuarios()
        'Dim str As String

        'Dim myConn As SqlConnection = New SqlConnection("Data Source=" & textBoxNombreServidor.Text & ";Initial Catalog=master;Integrated Security=True")
        'str = "Alter authorization on database::BASEADA to peruinka"
        'Dim myCommand As SqlCommand = New SqlCommand(str, myConn)

        'Try
        '    myConn.Open()
        '    myCommand.ExecuteNonQuery()

        'Catch ex As Exception

        'Finally
        '    If (myConn.State = ConnectionState.Open) Then
        '        myConn.Close()
        '    End If
        'End Try

    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        End

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        End

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        CONEXION_MANUAL.ShowDialog()
    End Sub
    Sub COMPROBAR_CONEXION()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_Empresa", conexion)
            da.Fill(dt)
            datalistado.DataSource = dt

            Cerrar()
        Catch ex As Exception
            'CONEXION_MANUAL.ShowDialog()

        End Try



    End Sub
    Sub ejecutar_scryt_ELIMINARBaseEXPRESS2014()
        Dim str As String
        Dim myConn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
        str = txtEliminarBase.Text
        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try
    End Sub
    Sub ejecutar_scryt_ELIMINARBase2014NORMAL()
        Dim str As String
        Dim myConn As SqlConnection = New SqlConnection("Data Source=.\;Initial Catalog=master;Integrated Security=True")
        str = txtEliminarBase.Text
        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try
    End Sub
    Sub ejecutar_scryt_ELIMINARBaseEXPRESS2017()
        Dim str As String
        Dim myConn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
        str = txtEliminarBase.Text
        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try
    End Sub
    Sub ejecutar_scryt_ELIMINARBaseEXPRESS2017NUEVO_14()
        Dim str As String
        Dim myConn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
        str = txtEliminarBase.Text
        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try
    End Sub
    Sub CREATE_GASTOS_POR_CONCEPTO_por_año()
        Dim str As String
        Dim myConn As SqlConnection = New SqlConnection("Data Source=" & textBoxNombreServidor.Text & ";Initial Catalog=BASEADA;Integrated Security=True")
        str = GASTOS_POR_CONCEPTO_por_año.Text
        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try
    End Sub
    Sub CREATE_MOSTRAR_GASTOS_POR_MES()
        Dim str As String
        Dim myConn As SqlConnection = New SqlConnection("Data Source=" & textBoxNombreServidor.Text & ";Initial Catalog=BASEADA;Integrated Security=True")
        str = TXTGASTOSPORMES.Text
        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try
    End Sub
    Sub CREATE_MOSTRAR_usuarios()
        Dim str As String
        Dim myConn As SqlConnection = New SqlConnection("Data Source=" & textBoxNombreServidor.Text & ";Initial Catalog=BASEADA;Integrated Security=True")
        str = txtCrearMostrar_usuarios.Text
        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try
    End Sub
    Sub create_procedure_mostrar_permisos_por_usuario()
        Dim str As String
        Dim myConn As SqlConnection = New SqlConnection("Data Source=" & textBoxNombreServidor.Text & ";Initial Catalog=BASEADA;Integrated Security=True")
        str = txtmostrar_permisos_por_usuario.Text
        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try
    End Sub
    Sub CREATE_MAYORES_GASTOS_POR_CONCEPTO()
        Dim str As String
        Dim myConn As SqlConnection = New SqlConnection("Data Source=" & textBoxNombreServidor.Text & ";Initial Catalog=BASEADA;Integrated Security=True")
        str = TXTMAYORESGASTOS.Text
        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try
    End Sub
    Sub ejecutar_scryt_crearProcedimientos_almacenados_y_tablas()
        Dim ruta As String = cbruta.Text + "\ScriptADA.txt"
        Dim fi As FileInfo = New FileInfo(ruta)
        Dim sw As StreamWriter

        Try
            If File.Exists(ruta) = False Then

                sw = File.CreateText(ruta)
                sw.WriteLine(txtCrear_procedimientos.Text)
                sw.Flush()
                sw.Close()
            ElseIf File.Exists(ruta) = True Then
                File.Delete(ruta)
                sw = File.CreateText(ruta)
                sw.WriteLine(txtCrear_procedimientos.Text)
                sw.Flush()
                sw.Close()
            End If
        Catch ex As Exception

        End Try

        Try
            Label3.Text = cbruta.Text + "\ScriptADA.txt"
            Dim cmd As ProcessStartInfo
            cmd = New ProcessStartInfo("sqlcmd", " -S " & textBoxNombreServidor.Text & " -i " & Label3.Text)
            cmd.UseShellExecute = False
            cmd.CreateNoWindow = True
            cmd.RedirectStandardOutput = True
            Dim proc As New Process()
            proc.StartInfo = cmd
            proc.Start()
            PanelProcedimientos.Visible = True
            PanelTablas.Visible = True
        Catch ex As Exception
            PanelProcedimientos.Visible = False
            PanelTablas.Visible = False
        End Try

    End Sub


    Sub ejecutar_scryt_crearBaseSQL2014Express()
        Dim str As String
        Dim myConn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
        str = txtCrear_base_de_datosEXPRESS2014.Text
        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
            PanelBase.Visible = True
            textBoxNombreServidor.Text = ".\SQLEXPRESS"
            ejecutar_scryt_crearProcedimientos_almacenados_y_tablas()
            SavetoXML(aes.Encrypt("Data Source=.\SQLEXPRESS ;Initial Catalog=BASEADA;Integrated Security=True", appPwdUnique, Integer.Parse("256")))
        Catch ex As Exception
            PanelSERVIDOR.Visible = True
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try
    End Sub
    Sub ejecutar_scryt_crearBaseSQL2014normal()
        Dim str As String
        Dim myConn As SqlConnection = New SqlConnection("Data Source=.\;Initial Catalog=master;Integrated Security=True")
        str = txtCrear_base_de_datos2014NORMAL.Text
        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
            PanelBase.Visible = True
            textBoxNombreServidor.Text = ".\"
            ejecutar_scryt_crearProcedimientos_almacenados_y_tablas()
            SavetoXML(aes.Encrypt("Data Source=.\;Initial Catalog=BASEADA;Integrated Security=True", appPwdUnique, Integer.Parse("256")))
        Catch ex As Exception
            PanelSERVIDOR.Visible = True
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try
    End Sub
    Sub ejecutar_scryt_crearBaseSQL2017normal()
        Dim str As String
        Dim myConn As SqlConnection = New SqlConnection("Data Source=.\;Initial Catalog=master;Integrated Security=True")
        str = txtCrear_base_de_datos2017NORMAL.Text
        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
            PanelBase.Visible = True
            textBoxNombreServidor.Text = ".\"
            ejecutar_scryt_crearProcedimientos_almacenados_y_tablas()
            SavetoXML(aes.Encrypt("Data Source=.\;Initial Catalog=BASEADA;Integrated Security=True", appPwdUnique, Integer.Parse("256")))
        Catch ex As Exception
            PanelSERVIDOR.Visible = True
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try
    End Sub
    Sub ejecutar_scryt_crearBaseSQLExpress2017()
        Dim str As String
        Dim myConn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
        str = txtCrear_base_de_datosEXPRESS2017.Text
        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
            PanelBase.Visible = True
            textBoxNombreServidor.Text = ".\SQLEXPRESS"
            ejecutar_scryt_crearProcedimientos_almacenados_y_tablas()
            SavetoXML(aes.Encrypt("Data Source=.\SQLEXPRESS;Initial Catalog=BASEADA;Integrated Security=True", appPwdUnique, Integer.Parse("256")))
        Catch ex As Exception
            PanelSERVIDOR.Visible = True
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try
    End Sub
    Sub ejecutar_scryt_crearBaseSQLExpress2017Nuevo_14()
        Dim str As String
        Dim myConn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
        str = txtCrear_base_de_datosEXPRESS2017NUEVO.Text
        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
            PanelBase.Visible = True
            textBoxNombreServidor.Text = ".\SQLEXPRESS"
            ejecutar_scryt_crearProcedimientos_almacenados_y_tablas()
            SavetoXML(aes.Encrypt("Data Source=.\SQLEXPRESS;Initial Catalog=BASEADA;Integrated Security=True", appPwdUnique, Integer.Parse("256")))
        Catch ex As Exception
            PanelSERVIDOR.Visible = True
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try
    End Sub
    Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("select * from empresa", conexion)
            da.Fill(dt)
            datalistado.DataSource = dt
            Close()
            lblEstado_de_conexion.Text = "CONECTADO"
        Catch ex As Exception
            lblEstado_de_conexion.Text = "NO CONECTADO"
        End Try


    End Sub
    Public Shared Function Instancias() As DataTable
        Dim enume As DataTable = SqlDataSourceEnumerator.Instance.GetDataSources()
        Return enume
    End Function
    Private Shared Sub Main(args As String())

        If args(0) Is Nothing Then
            Console.WriteLine("No file passed to the program.")
            Return
        End If

        If Not File.Exists(args(0).ToString()) Then
            Console.WriteLine("File does not exist.")
            Return
        End If

        Try
            Dim file As New FileStream(args(0).ToString(), FileMode.Open, FileAccess.ReadWrite)
            Dim sr As New StreamReader(file)
            Dim Commands As String = sr.ReadToEnd()
            sr.Close()
            file.Close()

            Dim cmd As New SqlCommand(Commands)
            cmd.Connection.ConnectionString = "Data Source=.;Integrated Authentication=true"
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Console.WriteLine(String.Format("Exeception occured: {0}", ex.Message))
        End Try

    End Sub
    Private Sub BIENVENIDO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each vUnidad As String In Directory.GetLogicalDrives()
            cbruta.Items.Add(vUnidad)
        Next vUnidad

        Timer1.Start()



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles PanelSERVIDOR.Paint

    End Sub

    Private Sub textBoxNombreServidor_TextChanged(sender As Object, e As EventArgs) Handles textBoxNombreServidor.TextChanged

    End Sub


    Public Sub SavetoXML(ByVal dbcnString)
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("ConnectionString.xml")
            Dim root As XmlElement = doc.DocumentElement
            root.Attributes.Item(0).Value = dbcnString
            Dim writer As XmlTextWriter = New XmlTextWriter("ConnectionString.xml", Nothing)
            writer.Formatting = Formatting.Indented
            doc.Save(writer)
            writer.Close()
        Catch ex As Exception
            PanelSERVIDOR.Visible = True
            MessageBox.Show("Es la Primera vez que estas abriendo ADA 369 Debes Ejecutar el Aplicativo como Administrador, da anticlik izquierdo y Elije *Ejecutar como Administrador*", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        End Try

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtEliminarBase_TextChanged(sender As Object, e As EventArgs) Handles txtEliminarBase.TextChanged

    End Sub



    Private Sub txtCrear_procedimientos_TextChanged(sender As Object, e As EventArgs) Handles txtCrear_procedimientos.TextChanged

    End Sub

    Private Sub TXTMAYORESGASTOS_TextChanged(sender As Object, e As EventArgs) Handles TXTMAYORESGASTOS.TextChanged, txtCrearMostrar_usuarios.TextChanged

    End Sub

    Private Sub MenuStrip4_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip4.ItemClicked

    End Sub

    Private Sub buttonEjecutarScript_Click(sender As Object, e As EventArgs) Handles buttonEjecutarScript.Click

    End Sub

    Private Sub cbruta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbruta.SelectedIndexChanged
        Dim ruta As String = cbruta.Text
        If (ruta.Contains("C:\")) Then
            MessageBox.Show("Selecciona un Disco Diferente al Disco C:", "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbruta.Text = ""


        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click






    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
        REGISTRO_DE_EMPRESA.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Listar()
        If lblEstado_de_conexion.Text = "CONECTADO" Then
            Timer1.Stop()
            Hide()
            REGISTRO_DE_EMPRESA.ShowDialog()
        Else
            Timer1.Stop()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PanelConfiguracion.Visible = True
        PanelConfiguracion.Dock = DockStyle.Fill

        Timer2.Stop()

        MessageBox.Show("Configuracion Generada Correctamente, Vuelve a Iniciar el Programa", "Configuracion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        lblconfiguracion.Text = "Base de datos Creada"

        Application.Restart()
    End Sub

    Private Sub PADVER_Click(sender As Object, e As EventArgs) Handles PADVER.Click
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        a = a + 1
        If a > 9 Then
            a = 0
            b = b + 1

        End If

        If b = 100 Then
            b = 0
            Timer3.Stop()
            ejecutar_scryt_crearBase()
            'CREAR_PROCEDIMIENTOS_QUE_NO_LOS_CREA_EL_SCRYPT()
            Timer2.Start()
        End If
        If b >= 0 Then
            CircularProgressBar1.ProgressColor = Color.White

        End If
        If b > 15 Then

            CircularProgressBar1.ProgressColor = Color.FromArgb(0, 166, 63)
            lblconfiguracion.Text = "Buscando Instancias Instaladas..."

        End If
        If b > 30 Then
            lblconfiguracion.Text = "Eliminando base de datos Existente..."
            CircularProgressBar1.ProgressColor = Color.Crimson
            'CircularProgressBar1.SubscriptColor = Color.Crimson
            ejecutar_scryt_ELIMINARBaseEXPRESS()
            ejecutar_scryt_ELIMINARBaseNORMAL()
        End If
        If b > 50 Then
            lblconfiguracion.Text = "Creando la Base de DATOS..."
            CircularProgressBar1.ProgressColor = Color.Violet
            'CircularProgressBar1.SubscriptColor = Color.Violet
        End If
        If b > 98 Then

            CircularProgressBar1.ProgressColor = Color.FromArgb(249, 215, 11)
            'CircularProgressBar1.SubscriptColor = Color.FromArgb(249, 215, 11)

            lblconfiguracion.Text = "Creando Tablas y precedimientos almacenados..."


        End If

        'CircularProgressBar1.SubscriptText = "." & a
        CircularProgressBar1.Value = b
        CircularProgressBar1.Text = CircularProgressBar1.Value

    End Sub

    Sub CREAR_PROCEDIMIENTOS_QUE_NO_LOS_CREA_EL_SCRYPT()
        CREATE_GASTOS_POR_CONCEPTO_por_año()
        CREATE_MOSTRAR_usuarios()

        CREATE_MAYORES_GASTOS_POR_CONCEPTO()
        CREATE_MOSTRAR_GASTOS_POR_MES()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        ejecutar_scryt_crearProcedimientos_almacenados_y_tablas()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click, PictureBox1.Click



    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub PanelConfiguracion_Paint(sender As Object, e As PaintEventArgs) Handles PanelConfiguracion.Paint

    End Sub
End Class