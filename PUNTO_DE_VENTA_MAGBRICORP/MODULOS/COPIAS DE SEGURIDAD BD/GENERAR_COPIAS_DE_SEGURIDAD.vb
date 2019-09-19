Imports System.IO
Imports System.Data.SqlClient
Imports System.Threading
Public Class GENERAR_COPIAS_DE_SEGURIDAD
    Private Hilo As Thread
    Dim acaba As Boolean = False


    Public Shared Sub Main()
        Dim path As String = "C:\CI"
        Dim di As DirectoryInfo = Directory.CreateDirectory(path)
        Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path))
        di.Delete()
        Console.WriteLine("The directory was deleted successfully.")
        Try

            If Directory.Exists(path) Then
                Console.WriteLine("That path exists already.")
                Return
            End If


        Catch e As Exception
            MsgBox("HOLA")
            Console.WriteLine("The process failed: {0}", e.ToString())

        Finally
        End Try
    End Sub
    Sub mostrar_empresas_nuevas()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("select * from Empresa", conexion)
            da.Fill(dt)
            datalistado_empresas_nuevas.DataSource = dt
            'lblfrecuencia.DisplayMember = "Frecuencia_de_copias"
            'lblfrecuencia.ValueMember = "Frecuencia_de_copias"
            'lblfrecuencia.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try




    End Sub
    Private Sub GENERAR_COPIAS_DE_SEGURIDAD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mostrar_empresas_nuevas()
        Try
            txtRuta.Text = datalistado_empresas_nuevas.SelectedCells.Item(9).Value
            lblfecha.Text = datalistado_empresas_nuevas.SelectedCells.Item(11).Value
            lbldirectorio.Text = "Copia Guardada en: " & txtRuta.Text & "\" & "BASEMAGBRI.bak"
            lbldirectorio.Visible = False
            'lblfrecuencia.Items.Add(datalistado_empresas_nuevas.SelectedCells.Item(14).Value)
            lblfrecuencia.Text = datalistado_empresas_nuevas.SelectedCells.Item(13).Value
        Catch ex As Exception

        End Try
        txtRuta.BackColor = Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim ruta1 As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim ruta2 As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Dim miCarpeta As String = "C:\Respaldos_ADA369"
        Try
            If Directory.Exists(miCarpeta) Then

            Else

                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(ruta1, miCarpeta))

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtRuta.Text <> "" Then
            Hilo = New Thread(New ThreadStart(AddressOf executa))
            txtRuta.BackColor = Color.White
            'Iniciar el proceso
            PictureBox1.Visible = True
            Panel1.Enabled = False
            lbldirectorio.Visible = False
            Panel2.Visible = False
            'Try
            Hilo.Start()
            acaba = False
            Timer1.Enabled = True
            ''Catch ex As Exception
            ''    Dim result As DialogResult
            ''    result = MessageBox.Show("Selecciona una Ruta Diferente al Disco C", "Seleccione Ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ''    If result = DialogResult.OK Then
            ''        PictureBox1.Visible = False
            ''        Panel1.Enabled = True
            ''        Timer1.Enabled = False
            ''        lbldirectorio.Visible = False
            ''        Panel2.Visible = True
            ''        txtRuta.BackColor = Color.White
            ''    End If
            ''End Try

        Else
            MessageBox.Show("Selecciona una Ruta donde Guardar las Copias de Seguridad", "Seleccione Ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRuta.Focus()
            txtRuta.BackColor = Color.FromArgb(255, 255, 192)
        End If

    End Sub
    Sub executa()
        Dim ruta2 As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Dim miCarpeta As String = txtRuta.Text & "\Respaldo_ADA369_al_" & Now.Day & "_" & Now.Month & "_" & Now.Year & "_" & Hour(TimeOfDay) & "_" & Minute(TimeOfDay)
        Try 
            System.IO.Directory.CreateDirectory(System.IO.Path.Combine(ruta2, miCarpeta))
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Try
            Dim v_nombre_respaldo As String
            v_nombre_respaldo = "BASEADA" & ".bak"
            abrir()
            Dim cmd As New SqlCommand("BACKUP DATABASE BASEADA TO DISK = '" & miCarpeta & "\" & v_nombre_respaldo & "'", conexion)
            cmd.ExecuteNonQuery()
            Cerrar()
            acaba = True
        Catch ex As Exception
            acaba = False

        End Try

    End Sub

    Private Sub ToolStripButton22_Click(sender As Object, e As EventArgs) Handles ToolStripButton22.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txtRuta.Text = FolderBrowserDialog1.SelectedPath
            Dim ruta As String = txtRuta.Text
            If (ruta.Contains("C:\")) Then
                MessageBox.Show("Selecciona un Disco Diferente al Disco C:", "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtRuta.Text = ""
            Else
                txtRuta.Text = FolderBrowserDialog1.SelectedPath
                editar_frecuencia_y_ruta()
            End If


        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (acaba = True) Then


            Me.Button2.Enabled = True

            Me.Button2.Refresh()

            'PicBox.Visible = False
            PictureBox1.Visible = False
            Panel1.Enabled = True
            Timer1.Enabled = False
            lbldirectorio.Visible = True
            lbldirectorio.Text = "Copia Guardada en: " & txtRuta.Text & "\" & "BASEADA.bak"

            Panel2.Visible = True
            txtRuta.BackColor = Color.White
            editar_Empresa_copia_de_seguridad()
            mostrar_empresas_nuevas()
            Try
                lblfecha.Text = datalistado_empresas_nuevas.SelectedCells.Item(11).Value
            Catch ex As Exception

            End Try
        End If
    End Sub
    Sub editar_Empresa_copia_de_seguridad()

        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("editar_Empresa_copia_de_seguridad", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Ultima_fecha_de_copia_de_seguridad", txtfechaSistema.Value)
            cmd.Parameters.AddWithValue("@Carpeta_para_copias_de_seguridad", txtRuta.Text)
            cmd.Parameters.AddWithValue("@Ultima_fecha_de_copia_date", txtfechaSistema.Value)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label4.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txtRuta.Text = FolderBrowserDialog1.SelectedPath
            Dim ruta As String = txtRuta.Text
            If (ruta.Contains("C:\")) Then
                MessageBox.Show("Selecciona un Disco Diferente al Disco C:", "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtRuta.Text = ""
            Else
                txtRuta.Text = FolderBrowserDialog1.SelectedPath
                editar_frecuencia_y_ruta()
            End If


        End If
    End Sub

    Private Sub txtRuta_Click(sender As Object, e As EventArgs) Handles txtRuta.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txtRuta.Text = FolderBrowserDialog1.SelectedPath
            Dim ruta As String = txtRuta.Text
            If (ruta.Contains("C:\")) Then
                MessageBox.Show("Selecciona un Disco Diferente al Disco C:", "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtRuta.Text = ""
            Else
                txtRuta.Text = FolderBrowserDialog1.SelectedPath
                editar_frecuencia_y_ruta()
            End If


        End If
    End Sub

    Private Sub txtRuta_TextChanged(sender As Object, e As EventArgs) Handles txtRuta.TextChanged
       
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MASCARA1.Hide()
        Close()
        VENTAS_MENU_PRINCIPAL.TimerDisposeMascara.Start()

    End Sub

    Private Sub lblfrecuencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lblfrecuencia.SelectedIndexChanged
        editar_frecuencia_y_ruta()
    End Sub
    Sub editar_frecuencia_y_ruta()
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("editar_frecuencia_y_carpeta_Empresa", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Carpeta_para_copias_de_seguridad", txtRuta.Text)
            cmd.Parameters.AddWithValue("@Frecuencia_de_copias", lblfrecuencia.Text)

            cmd.ExecuteNonQuery()
            Cerrar()
            VENTAS_MENU_PRINCIPAL.TimerEmpresa.Start()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblfrecuencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lblfrecuencia.KeyPress
        e.KeyChar = ""
    End Sub
End Class