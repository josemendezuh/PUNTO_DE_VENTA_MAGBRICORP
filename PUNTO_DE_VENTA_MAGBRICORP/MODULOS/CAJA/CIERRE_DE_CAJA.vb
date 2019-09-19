
Imports System.Data
Imports System.Data.SqlClient

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
Imports System.Net.Mail
Imports System.Net
Imports Microsoft.Reporting.WinForms

Imports System.Configuration
Imports System.Xml
Public Class CIERRE_DE_CAJA


    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        MASCARA1.Show()
        Cierre_de_turno.ShowDialog()

    End Sub
    Sub REPORT_VENTAS_por_TURNOS_en_EFECTIVO()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("REPORT_VENTAS_por_TURNOS_en_EFECTIVO", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            da.SelectCommand.Parameters.AddWithValue("@fi", fechainicial)
            da.SelectCommand.Parameters.AddWithValue("@ff", lblfechaActual.Value)
            da.Fill(dt)
            DATALISTADO_VENTAS_Efectivo.DataSource = dt
            Cerrar()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub REPORT_VENTAS_por_TURNOS_Por_tarjeta()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("REPORT_VENTAS_por_TURNOS_Por_tarjeta", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            da.SelectCommand.Parameters.AddWithValue("@fi", fechainicial)
            da.SelectCommand.Parameters.AddWithValue("@ff", lblfechaActual.Value)
            da.Fill(dt)
            DATALISTADO_VENTAS_Tarjeta.DataSource = dt
            Cerrar()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub REPORT_VENTAS_por_TURNOS_Por_Credito()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("REPORT_VENTAS_por_TURNOS_Por_Credito", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            da.SelectCommand.Parameters.AddWithValue("@fi", fechainicial)
            da.SelectCommand.Parameters.AddWithValue("@ff", lblfechaActual.Value)
            da.Fill(dt)
            DATALISTADO_VENTAS_Credito.DataSource = dt
            Cerrar()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub REPORT_GASTOS_VARIOS_por_turnos()
        Try
            Dim importe As Double
            Dim com As New SqlCommand("REPORT_GASTOS_VARIOS_por_turnos", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            com.Parameters.AddWithValue("@fi", fechainicial)
            com.Parameters.AddWithValue("@ff", lblfechaActual.Value)

            Try
                abrir()
                importe = (com.ExecuteScalar())
                Cerrar()
                lblsalidasvarias.Text = importe

            Catch ex As Exception
                lblsalidasvarias.Text = 0
            End Try
        Catch ex As Exception

        End Try



    End Sub
    Sub REPORT_GANANCIAS_DE_VENTAS_por_TURNOS()
        Try
            Dim importe As Double
            Dim com As New SqlCommand("REPORT_GANANCIAS_DE_VENTAS_por_TURNOS", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            com.Parameters.AddWithValue("@fi", fechainicial)
            com.Parameters.AddWithValue("@ff", lblfechaActual.Value)

            Try
                abrir()
                importe = (com.ExecuteScalar())
                Cerrar()
                lblgananciasVentas.Text = importe

            Catch ex As Exception
                lblgananciasVentas.Text = 0
            End Try
        Catch ex As Exception

        End Try



    End Sub
    Sub REPORT_INGRESOS_VARIOS_por_turnos()
        Try
            Dim importe As Double
            Dim com As New SqlCommand("REPORT_INGRESOS_VARIOS_por_turnos", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            com.Parameters.AddWithValue("@fi", fechainicial)
            com.Parameters.AddWithValue("@ff", lblfechaActual.Value)
            Try
                abrir()
                importe = (com.ExecuteScalar())
                Cerrar()
                LBLENTRADASVARIAS.Text = importe

            Catch ex As Exception
                LBLENTRADASVARIAS.Text = 0
            End Try

        Catch ex As Exception

        End Try


    End Sub
    Sub REPORT_COBROS_EN_EFECTIVO_por_turnos()
        Try
            Dim importe As Double
            Dim com As New SqlCommand("REPORT_COBROS_EN_EFECTIVO_por_turnos", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            com.Parameters.AddWithValue("@fi", fechainicial)
            com.Parameters.AddWithValue("@ff", lblfechaActual.Value)

            Try
                abrir()
                importe = (com.ExecuteScalar())
                Cerrar()
                lblabonosEfectivo.Text = importe

            Catch ex As Exception
                lblabonosEfectivo.Text = 0
            End Try
        Catch ex As Exception

        End Try



    End Sub
    Sub REPORT_PAGOS_EN_EFECTIVO_por_turnos()
        Try
            Dim importe As Double
            Dim com As New SqlCommand("REPORT_PAGOS_EN_EFECTIVO_por_turnos", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            com.Parameters.AddWithValue("@fi", fechainicial)
            com.Parameters.AddWithValue("@ff", lblfechaActual.Value)

            Try
                abrir()
                importe = (com.ExecuteScalar())
                Cerrar()
                lblPAGOSEfectivo.Text = importe
            Catch ex As Exception
                ': MessageBox.Show(ex.Message)
                lblPAGOSEfectivo.Text = 0
            End Try

        Catch ex As Exception

        End Try


    End Sub
    Sub MOSTRAR_FONDO_DE_CAJA()
        Try
            Dim importe As String
            Dim com As New SqlCommand("MOSTRAR_FONDO_DE_CAJA_INICIAL", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            com.Parameters.AddWithValue("@fi", fechainicial)
            com.Parameters.AddWithValue("@ff", lblfechaActual.Value)

            Try
                abrir()
                importe = (com.ExecuteScalar()) 'asignamos el valor del importe
                Cerrar()
                lblfondodeCaja.Text = importe

            Catch ex As Exception
                lblfondodeCaja.Text = 0
            End Try
        Catch ex As Exception

        End Try

    End Sub

    Sub MOSTRAR_CIERRE_DE_CAJA_PENDIENTE()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("MOSTRAR_CIERRE_DE_CAJA_PENDIENTE", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@serial", LOGIN.lblIDSERIAL.Text)

            da.Fill(dt)
            datalistado_CIERRE_DE_CAJA_PENDIENTE.DataSource = dt
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try

    End Sub
    Dim fechainicial As String

    Private Sub CIERRE_DE_CAJA_MAGBRI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-ES")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        'lbldescripciondeCierre.Text = "Corte de " & VENTAS_MENU_PRINCIPAL.lblLogin.Text & " al "
        lblcaja.Text = VENTAS_MENU_PRINCIPAL.lblcaja.Text
        MOSTRAR_CIERRE_DE_CAJA_PENDIENTE()
        Try
            lblidcaja.Text = datalistado_CIERRE_DE_CAJA_PENDIENTE.SelectedCells.Item(3).Value
        Catch ex As Exception

        End Try



        'lbldescripciondeCierre.Text = "Corte de " & VENTAS_MENU_PRINCIPAL.lblLogin.Text & " del "

        lblcaja.Text = VENTAS_MENU_PRINCIPAL.lblcaja.Text

        Try
            fechainicial = datalistado_CIERRE_DE_CAJA_PENDIENTE.SelectedCells.Item(1).Value
            lbldesdehasta.Text = "Corte de " & VENTAS_MENU_PRINCIPAL.lblLogin.Text & " Desde " & fechainicial & " hasta " & lblfechaActual.Value

        Catch ex As Exception

        End Try
        'REPORT_GASTOS_VARIOS_por_turnos()
        'REPORT_INGRESOS_VARIOS_por_turnos()
        'REPORT_COBROS_EN_EFECTIVO_por_turnos()
        'REPORT_PAGOS_EN_EFECTIVO_por_turnos()
        'REPORT_VENTAS_por_TURNOS_en_EFECTIVO()
        'REPORT_VENTAS_por_TURNOS_Por_tarjeta()
        'REPORT_VENTAS_por_TURNOS_Por_Credito()
        'REPORT_GANANCIAS_DE_VENTAS_por_TURNOS()
        ''Try
        'Try
        '    LBLTOTALVENTAS.Text = DATALISTADO_VENTAS_Efectivo.SelectedCells.Item(1).Value

        'Catch ex As Exception
        '    LBLTOTALVENTAS.Text = 0
        'End Try
        'LBLVENTASenEfectivo.Text = LBLTOTALVENTAS.Text
        'LBLVentasEnEfectivo2.Text = LBLVENTASenEfectivo.Text
        'Try
        '    lblventas_Tarjeta.Text = DATALISTADO_VENTAS_Tarjeta.SelectedCells.Item(1).Value

        'Catch ex As Exception
        '    lblventas_Tarjeta.Text = 0
        'End Try
        'Try
        '    lblVentasAcredito.Text = DATALISTADO_VENTAS_Credito.SelectedCells.Item(1).Value

        'Catch ex As Exception
        '    lblVentasAcredito.Text = 0
        'End Try

        ''Catch ex As Exception
        ''    LBLTOTALVENTAS.Text = 0
        ''    LBLVENTASenEfectivo.Text = 0
        ''    LBLVentasEnEfectivo2.Text = 0
        ''    lblventas_Tarjeta.Text = 0
        ''    lblVentasAcredito.Text = 0
        ''End Try

        'MOSTRAR_FONDO_DE_CAJA()
        'Try
        '    lblDineroEncajaTurno.Text = lblfondodeCaja.Text * 1 + LBLVENTASenEfectivo.Text * 1 + lblabonosEfectivo.Text * 1 - lblPAGOSEfectivo.Text * 1 + LBLENTRADASVARIAS.Text * 1 - lblsalidasvarias.Text * 1
        '    lblDineroEncajaTurnoTOTAL.Text = lblDineroEncajaTurno.Text
        '    lblVentas_suma.Text = LBLVentasEnEfectivo2.Text * 1 + lblventas_Tarjeta.Text * 1 + lblVentasAcredito.Text * 1
        'Catch ex As Exception

        'End Try
        btnCortedeTurno.BackColor = Color.FromArgb(255, 204, 1)
        btnresumenDia.BackColor = Color.WhiteSmoke

        'Timer1.Start()
        'Panel2.Visible = False

        'CircularProgressBar1.Value = 0
        'CircularProgressBar1.Text = 0
        'TimerCIERRETURNO.Start()
        calculos_cierre_turno()

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles lblVentasAcredito.Click, lblVentas_suma.Click, lblabonosEfectivo.Click, LBLENTRADASVARIAS.Click, lblsalidasvarias.Click, lblDineroEncajaTurno.Click, lblPAGOSEfectivo.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub
    Sub calculos_cierre_turno()
        'calcular_cierre_de_turno_ok()
        btnCortedeTurno.BackColor = Color.FromArgb(255, 204, 1)
        btnresumenDia.BackColor = Color.WhiteSmoke
        btnresumenDia.ForeColor = Color.Black
        Panel2.Visible = False

        CircularProgressBar1.Value = 0
        CircularProgressBar1.Text = 0
        TimerCIERRETURNO.Start()
        calcular_cierre_de_turno_ok()
    End Sub
    Sub calcular_cierre_de_turno_ok()
        'lbldescripciondeCierre.Text = "Corte de " & VENTAS_MENU_PRINCIPAL.lblLogin.Text & " del "
        MOSTRAR_CIERRE_DE_CAJA_PENDIENTE()
        lblcaja.Text = VENTAS_MENU_PRINCIPAL.lblcaja.Text

        Try
            lbldesdehasta.Text = "Desde " & fechainicial & " hasta " & lblfechaActual.Value

        Catch ex As Exception

        End Try
        REPORT_GASTOS_VARIOS_por_turnos()
        REPORT_INGRESOS_VARIOS_por_turnos()
        REPORT_COBROS_EN_EFECTIVO_por_turnos()
        REPORT_PAGOS_EN_EFECTIVO_por_turnos()
        REPORT_VENTAS_por_TURNOS_en_EFECTIVO()
        REPORT_VENTAS_por_TURNOS_Por_tarjeta()
        REPORT_VENTAS_por_TURNOS_Por_Credito()
        REPORT_GANANCIAS_DE_VENTAS_por_TURNOS()
        'Try
        Try
            LBLTOTALVENTAS.Text = DATALISTADO_VENTAS_Efectivo.SelectedCells.Item(1).Value

        Catch ex As Exception
            LBLTOTALVENTAS.Text = 0
        End Try
        LBLVENTASenEfectivo.Text = LBLTOTALVENTAS.Text
        LBLVentasEnEfectivo2.Text = LBLVENTASenEfectivo.Text
        Try
            lblventas_Tarjeta.Text = DATALISTADO_VENTAS_Tarjeta.SelectedCells.Item(1).Value

        Catch ex As Exception
            lblventas_Tarjeta.Text = 0
        End Try
        Try
            lblVentasAcredito.Text = DATALISTADO_VENTAS_Credito.SelectedCells.Item(1).Value

        Catch ex As Exception
            lblVentasAcredito.Text = 0
        End Try

        'Catch ex As Exception
        '    LBLTOTALVENTAS.Text = 0
        '    LBLVENTASenEfectivo.Text = 0
        '    LBLVentasEnEfectivo2.Text = 0
        '    lblventas_Tarjeta.Text = 0
        '    lblVentasAcredito.Text = 0
        'End Try

        MOSTRAR_FONDO_DE_CAJA()
        Try
            lblDineroEncajaTurno.Text = lblfondodeCaja.Text * 1 + LBLVENTASenEfectivo.Text * 1 + lblabonosEfectivo.Text * 1 - lblPAGOSEfectivo.Text * 1 + LBLENTRADASVARIAS.Text * 1 - lblsalidasvarias.Text * 1
            lblDineroEncajaTurnoTOTAL.Text = lblDineroEncajaTurno.Text
            lblVentas_suma.Text = LBLVentasEnEfectivo2.Text * 1 + lblventas_Tarjeta.Text * 1 + lblVentasAcredito.Text * 1
        Catch ex As Exception

        End Try
        LBLTOTALVENTAS.Text = lblVentas_suma.Text

    End Sub
    Private Sub BTNLECTORA_Click(sender As Object, e As EventArgs) Handles btnCortedeTurno.Click

        calculos_cierre_turno()
    End Sub


    Private Sub MenuStrip9_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip9.ItemClicked

    End Sub



    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub

    Private Sub btnresumenDia_Click(sender As Object, e As EventArgs) Handles btnresumenDia.Click
        btnresumenDia.BackColor = Color.FromArgb(255, 204, 1)
        btnCortedeTurno.BackColor = Color.WhiteSmoke
        btnCortedeTurno.ForeColor = Color.Black
    End Sub

    Private Sub lbldesdehasta_Click(sender As Object, e As EventArgs) Handles lbldesdehasta.Click

    End Sub

    Private Sub TimerCIERRETURNO_Tick(sender As Object, e As EventArgs) Handles TimerCIERRETURNO.Tick
        Panel16.Visible = True
        Panel16.Dock = DockStyle.Fill
        Panel2.Visible = False

        Panel17.Location = New Point((Width - Panel17.Width) / 2, (Height - Panel17.Height) / 2)

        If CircularProgressBar1.Value < 100 Then
            CircularProgressBar1.Value = CircularProgressBar1.Value + 1
            CircularProgressBar1.Text = CircularProgressBar1.Value

        ElseIf CircularProgressBar1.Value = 100 Then
            CircularProgressBar1.Value = 0
            CircularProgressBar1.Text = 0
            Panel16.Visible = False
            Panel2.Visible = True
            PanelTURNO.Visible = True
            PanelTURNO.Dock = DockStyle.Fill
            PanelRESUMENDIARIO.Visible = False

            TimerCIERRETURNO.Stop()
            calcular_cierre_de_turno_ok()
        End If
    End Sub

    Private Sub Label46_Click(sender As Object, e As EventArgs) Handles Label46.Click
        CircularProgressBar1.Value = 0

        TimerCIERRETURNO.Start()

    End Sub

    Private Sub CircularProgressBar1_Click(sender As Object, e As EventArgs) Handles CircularProgressBar1.Click

    End Sub

    Private Sub lblfechaActual_ValueChanged(sender As Object, e As EventArgs) Handles lblfechaActual.ValueChanged

    End Sub
End Class