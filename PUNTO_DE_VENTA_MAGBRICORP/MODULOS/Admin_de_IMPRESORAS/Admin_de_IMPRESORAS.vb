Imports System.Drawing.Printing
Imports System.Printing
Imports System.Net
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Net.Mime.MediaTypeNames
Imports System.Globalization
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Data.OleDb

Imports System.IO
Imports System.Management
Imports System.Xml
Imports System.AppDomainManagerInitializationOptions
Imports System.MarshalByRefObject
Imports System.Configuration
Public Class Admin_de_IMPRESORAS
    Private MisDiscos As New ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard")
    Private DiscInfo As New ManagementObject
    Private Sub Admin_de_IMPRESORAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxA4.Items.Clear()
        cbxTiket.Items.Clear()
        Panel2.Location = New Point((Width - Panel2.Width) / 2, (Height - Panel2.Height) / 2)
        Dim MiInfo = From Hd As ManagementObject In MisDiscos.Get Select Hd
        DiscInfo = MiInfo(0)
        lblIDSERIAL.Text = DiscInfo.Properties("SerialNumber").Value
        MOSTRAR_cajas_por_serial()
        Try
            cbxA4.Text = DATALISTADOcajas.SelectedCells.Item(5).Value
            cbxTiket.Text = DATALISTADOcajas.SelectedCells.Item(6).Value
        Catch ex As Exception

        End Try
        For I = 0 To PrinterSettings.InstalledPrinters.Count - 1
            cbxTiket.Items.Add(PrinterSettings.InstalledPrinters.Item(I))
            'cbxTiket.Items.Add("Ninguna")
            cbxA4.Items.Add(PrinterSettings.InstalledPrinters.Item(I))

        Next

        cbxA4.Items.Add("Ninguna")
        cbxTiket.Items.Add("Ninguna")

    End Sub




    Sub MOSTRAR_cajas_por_serial()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("MOSTRAR_cajas_por_serial", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@serial", lblIDSERIAL.Text)

            da.Fill(dt)
            DATALISTADOcajas.DataSource = dt
            Cerrar()

        Catch ex As Exception ': MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub guardarBTN_Click(sender As Object, e As EventArgs) Handles guardarBTN.Click
        Dim cmd As New SqlCommand

        Try

            abrir()
            cmd = New SqlCommand("editar_caja_impresoras", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idcaja", DATALISTADOcajas.SelectedCells.Item(3).Value)
            cmd.Parameters.AddWithValue("@Impresora_Ticket", cbxTiket.Text)
            cmd.Parameters.AddWithValue("@Impresora_A4", cbxA4.Text)
            cmd.ExecuteNonQuery()
                Cerrar()
            MessageBox.Show("Datos Guardados Correctamente", "Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

        End Try


    End Sub
End Class