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
Public Class DASHBOARD_PRINCIPAL
    Sub Listar_ventaspor_mes()
        Dim fecha As ArrayList = New ArrayList
        Dim monto As ArrayList = New ArrayList
        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("mostrar_ventas_realizadas", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            dr = cmd.ExecuteReader()
            While (dr.Read())
                fecha.Add(dr.GetString(0))
                monto.Add(dr.GetString(1))
            End While
            ChartVENTAS.Series(0).Points.DataBindXY(fecha, monto)
            dr.Close()
            Cerrar()
            Dim importe As Double
            Dim com As New SqlCommand

            com = New SqlCommand("select CONVERT(NUMERIC(18,1),sum( Monto_total)) FROM dbo.ventas where ACCION= 'VENTA'", conexion)

            Try
                abrir()
                importe = (com.ExecuteScalar())
                Cerrar()

                txtventas.Text = importe
            Catch ex As Exception
                txtventas.Text = 0
            End Try


            Dim importe2 As Double
            Dim com2 As New SqlCommand

            com2 = New SqlCommand("select CONVERT(NUMERIC(18,1),sum( Ganancia )) FROM   dbo.detalle_venta INNER JOIN ventas on VENTAS.idventa=detalle_venta.idventa where ACCION= 'VENTA'", conexion)

            Try
                abrir()
                importe2 = (com2.ExecuteScalar())
                Cerrar()
                lblgananciasok.Text = importe2
            Catch ex As Exception
                lblgananciasok.Text = 0
            End Try


        Catch ex As Exception
            lblgananciasok.Text = 0
        End Try

    End Sub
    Sub Listar_ventas_POR_FECHA()
        Dim fecha As ArrayList = New ArrayList
        Dim monto As ArrayList = New ArrayList
        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("mostrar_ventas_realizadas_POR_FECHAS", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@FI", TXTFI.Value)
            cmd.Parameters.AddWithValue("@FF", TXTFF.Value)
            cmd.CommandType = CommandType.StoredProcedure
            dr = cmd.ExecuteReader()
            While (dr.Read())
                fecha.Add(dr.GetString(0))
                monto.Add(dr.GetString(1))
            End While
            ChartVENTAS.Series(0).Points.DataBindXY(fecha, monto)
            dr.Close()
            Cerrar()



            Dim importe As Double
            Dim com As New SqlCommand
            com = New SqlCommand("mostrar_ventas_realizadas_POR_FECHA", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@FI", TXTFI.Value)
            com.Parameters.AddWithValue("@FF", TXTFF.Value)
            Try
                abrir()
                importe = (com.ExecuteScalar()) 'asignamos el valor del importe
                Cerrar()
                txtventas.Text = importe  ' mostramos el importe
            Catch ex As Exception
                txtventas.Text = 0
            End Try


            Dim importe2 As Double
            Dim com2 As New SqlCommand

            com2 = New SqlCommand("MOSTRAR_Ganancias_por_fecha", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@FI", TXTFI.Value)
            com.Parameters.AddWithValue("@FF", TXTFF.Value)
            Try
                abrir()
                importe2 = (com2.ExecuteScalar()) 'asignamos el valor del importe
                Cerrar()
            Catch ex As Exception
            End Try
            lblgananciasok.Text = importe2  ' mostramos el importe

        Catch ex As Exception
            lblgananciasok.Text = 0
        End Try

    End Sub
    Sub mostrar_5_productos_mas_vendidos()
        Dim CANTIDAD As ArrayList = New ArrayList
        Dim PRODUCTO As ArrayList = New ArrayList
        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("mostrar_5_productos_mas_vendidos", conexion)
            'da.Fill(dt)
            'Chart1.DataSource = dt
            cmd.CommandType = CommandType.StoredProcedure
            dr = cmd.ExecuteReader()
            While (dr.Read())
                CANTIDAD.Add(dr.GetInt32(0))
                PRODUCTO.Add(dr.GetString(1))
            End While
            Chart3.Series(0).Points.DataBindXY(PRODUCTO, CANTIDAD)

            dr.Close()
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub mostrar_5_productos_mas_rentables()
        Dim CANTIDAD As ArrayList = New ArrayList
        Dim PRODUCTO As ArrayList = New ArrayList
        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("mostrar_5_productos_mas_rentables", conexion)
            'da.Fill(dt)
            'Chart1.DataSource = dt
            cmd.CommandType = CommandType.StoredProcedure
            dr = cmd.ExecuteReader()
            While (dr.Read())
                CANTIDAD.Add(dr.GetString(0))
                PRODUCTO.Add(dr.GetString(1))
            End While
            Chart5.Series(0).Points.DataBindXY(PRODUCTO, CANTIDAD)

            dr.Close()
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Private Sub LineShape1_Click(sender As Object, e As EventArgs)

    'End Sub
    'Sub sumar_compras_POR_TURNO()

    '    Dim importe As Double
    '    Dim com As New SqlCommand

    '    com = New SqlCommand("sumar_compras_POR_TURNO", conexion)
    '    com.CommandType = 4
    '    com.Parameters.AddWithValue("@FI", TXTFI.Value)
    '    com.Parameters.AddWithValue("@FF", TXTFF.Value)
    '    Try
    '        abrir()
    '        importe = (com.ExecuteScalar()) 'asignamos el valor del importe
    '        Cerrar()
    '    Catch ex As Exception
    '    End Try
    '    TXTCOMPRAS.Text = importe  ' mostramos el importe

    'End Sub
    Sub sumar_Cuentas_por_pagar()

        Dim importe As Double
        Dim com As New SqlCommand

        com = New SqlCommand("SUMAR_POR_PAGAR_OK", conexion)
     
        Try
            abrir()
            importe = (com.ExecuteScalar()) 'asignamos el valor del importe
            Cerrar()
        Catch ex As Exception
        End Try
        lblPorPagar.Text = importe  ' mostramos el importe
        lblPorPagar.Text = VENTAS_MENU_PRINCIPAL.txtmoneda.Text & " " & Format(CType(lblPorPagar.Text, Decimal), "##0.00")

    End Sub
    Sub MOSTRAR_GANANCIAS()

        Dim importe As Double
        Dim com As New SqlCommand("MOSTRAR_GANANCIAS_DE_VENTAS", conexion)


        Try
            abrir()
            importe = (com.ExecuteScalar())
            Cerrar()
            lblGanancias.Text = importe  ' mostramos el importe
            lblGanancias.Text = VENTAS_MENU_PRINCIPAL.txtmoneda.Text & " " & Format(CType(lblGanancias.Text, Decimal), "##0.00")


        Catch ex As Exception
            lblGanancias.Text = VENTAS_MENU_PRINCIPAL.txtmoneda.Text & 0

        End Try

    End Sub
    Sub MOSTRAR_Inventarios_bajo_minimo_COUNT()

        Dim importe As Double
        Dim com As New SqlCommand("MOSTRAR_Inventarios_bajo_minimo_COUNT", conexion)


        Try
            abrir()
            importe = (com.ExecuteScalar())
            Cerrar()
        Catch ex As Exception
        End Try
        lblStockBajo.Text = importe & " Producto(s)"



    End Sub
    Sub MOSTRAR_Clientes()
        Dim importe As Double
        Dim com As New SqlCommand("select count(idclientev ) from clientes where Cliente='SI'", conexion)
        Try
            abrir()
            importe = (com.ExecuteScalar())
            Cerrar()
        Catch ex As Exception
        End Try
        lblNclientes.Text = importe & " Cliente(s)"
    End Sub
    Sub MOSTRAR_Productos_Count()
        Dim importe As Double
        Dim com As New SqlCommand("select count(Id_Producto1  ) from Producto1  where Usa_inventarios ='SI'", conexion)
        Try
            abrir()
            importe = (com.ExecuteScalar())
            Cerrar()
        Catch ex As Exception
        End Try
        lblProductos.Text = importe & " Productos"
    End Sub
    'Sub sumar_gastos_POR_TURNO()

    '    Dim importe As Double
    '    Dim com As New SqlCommand

    '    com = New SqlCommand("sumar_gastos_POR_TURNO", conexion)
    '    com.CommandType = 4
    '    com.Parameters.AddWithValue("@FI", TXTFI.Value)
    '    com.Parameters.AddWithValue("@FF", TXTFF.Value)
    '    Try
    '        abrir()
    '        importe = (com.ExecuteScalar()) 'asignamos el valor del importe
    '        Cerrar()
    '    Catch ex As Exception
    '    End Try
    '    TXTGASTOSVARIOS.Text = importe  ' mostramos el importe

    'End Sub

    'Sub SUMAR_EGRESOS()
    '    Try
    '        TXTEGRESOSTOTAL.Text = 0
    '        TXTEGRESOSTOTAL.Text = TXTPAGOS.Text * 1 + TXTCOMPRAS.Text * 1 + TXTGASTOSVARIOS.Text * 1
    '    Catch ex As Exception

    '    End Try
    'End Sub
















    'Sub SUMAR_VENTAS()

    '    Dim importe As Double
    '    Dim com As New SqlCommand

    '    com = New SqlCommand("sumar_ventas_POR_TURNO", conexion)
    '    com.CommandType = 4
    '    com.Parameters.AddWithValue("@FI", TXTFI.Value)
    '    com.Parameters.AddWithValue("@FF", TXTFF.Value)
    '    Try
    '        abrir()
    '        importe = (com.ExecuteScalar()) 'asignamos el valor del importe
    '        Cerrar()
    '    Catch ex As Exception
    '    End Try
    '    TXTVENTAS.Text = importe  ' mostramos el importe

    'End Sub
    'Sub sumar_COBROS()
    '    Dim importe As Double
    '    Dim com As New SqlCommand("sumar_COBROS", conexion)
    '    com.CommandType = 4
    '    com.Parameters.AddWithValue("@FI", TXTFI.Value)
    '    com.Parameters.AddWithValue("@FF", TXTFF.Value)
    '    Try
    '        abrir()
    '        importe = (com.ExecuteScalar()) 'asignamos el valor del importe
    '        Cerrar()
    '    Catch ex As Exception
    '    End Try
    '    TXTCOBROS.Text = importe  ' mostramos el importe
    'End Sub
    'Sub sumar_INGRESOS_VARIOS()
    '    Dim importe As Double
    '    Dim com As New SqlCommand("sumar_INGRESOS_VARIOS", conexion)
    '    com.CommandType = 4
    '    com.Parameters.AddWithValue("@FI", TXTFI.Value)
    '    com.Parameters.AddWithValue("@FF", TXTFF.Value)
    '    Try
    '        abrir()
    '        importe = (com.ExecuteScalar()) 'asignamos el valor del importe
    '        Cerrar()
    '    Catch ex As Exception
    '    End Try
    '    TXTINGRESOSVARIOS.Text = importe  ' mostramos el importe
    'End Sub
    'Sub sumar_KARDEX_VENTAS()
    '    Dim importe As Double
    '    Dim com As New SqlCommand("sumar_KARDEX_VENTAS", conexion)
    '    com.CommandType = 4
    '    com.Parameters.AddWithValue("@FI", TXTFI.Value)
    '    com.Parameters.AddWithValue("@FF", TXTFF.Value)
    '    Try
    '        abrir()
    '        importe = (com.ExecuteScalar()) 'asignamos el valor del importe
    '        Cerrar()
    '    Catch ex As Exception
    '    End Try
    '    TXTKARDEXVENTAS.Text = importe  ' mostramos el importe
    'End Sub
    'Sub sumar_KARDEX_RECHASOS()
    '    Dim importe As Double
    '    Dim com As New SqlCommand("sumar_KARDEX_RECHASOS", conexion)
    '    com.CommandType = 4
    '    com.Parameters.AddWithValue("@FI", TXTFI.Value)
    '    com.Parameters.AddWithValue("@FF", TXTFF.Value)
    '    Try
    '        abrir()
    '        importe = (com.ExecuteScalar()) 'asignamos el valor del importe
    '        Cerrar()
    '    Catch ex As Exception
    '    End Try
    '    TXTKARDEXRECHAZO.Text = importe  ' mostramos el importe
    'End Sub
    'Sub SUMAR_INGRESOSOK()
    '    Try
    '        TXTINGRESOS.Text = 0
    '        TXTINGRESOS.Text = TXTINGRESOSVARIOS.Text * 1 + TXTVENTAS.Text * 1 + TXTKARDEXRECHAZO.Text * 1 + TXTKARDEXVENTAS.Text * 1 + TXTINGRESOS.Text * 1 + TXTCOBROS.Text * 1

    '    Catch ex As Exception

    '    End Try
    'End Sub
    'Sub INGRESOS_EGRESOS()
    '    Try
    '        TXTINGRE_EGRESOS.Text = 0
    '        TXTINGRE_EGRESOS.Text = TXTINGRESOS.Text * 1 - TXTEGRESOSTOTAL.Text * 1
    '        TXTINGRE_EGRESOS.Text = "S/. " & Format(CType(TXTINGRE_EGRESOS.Text, Decimal), "##0.00")
    '    Catch ex As Exception

    '    End Try

    'End Sub
    'Sub MOSTRAR_GASTOS_EN_QUE()
    '    Dim dt As New DataTable
    '    Dim da As SqlDataAdapter
    '    Try
    '        abrir()
    '        da = New SqlDataAdapter("mostrar_gastos_POR_FECHAS", conexion)
    '        da.SelectCommand.CommandType = 4
    '        da.SelectCommand.Parameters.AddWithValue("@FI", TXTFI.Value)
    '        da.SelectCommand.Parameters.AddWithValue("@FF", TXTFF.Value)
    '        da.Fill(dt)
    '        datalistadoGASTOS.DataSource = dt
    '        datalistadoGASTOS.Columns.Item(1).Width = 190
    '        datalistadoGASTOS.Columns.Item(2).Width = 80
    '    Catch ex As Exception : MessageBox.Show(ex.Message)
    '    End Try
    '    Cerrar()
    'End Sub
    'Sub SUMAR_KARDEX_SALIDA()
    '    Dim dt As New DataTable
    '    Dim da As SqlDataAdapter
    '    Try
    '        abrir()
    '        da = New SqlDataAdapter("SUMAR_KARDEX_SALIDA", conexion)
    '        da.SelectCommand.CommandType = 4
    '        da.SelectCommand.Parameters.AddWithValue("@FI", TXTFI.Value)
    '        da.SelectCommand.Parameters.AddWithValue("@FF", TXTFF.Value)
    '        da.Fill(dt)
    '        DATALISTADO_PRODUCTOS_MAS_VENDIDOS.DataSource = dt
    '        DATALISTADO_PRODUCTOS_MAS_VENDIDOS.Columns.Item(1).Width = 190
    '        DATALISTADO_PRODUCTOS_MAS_VENDIDOS.Columns.Item(2).Width = 80
    '    Catch ex As Exception : MessageBox.Show(ex.Message)
    '    End Try
    '    Cerrar()
    'End Sub
    'Private Sub DASHBOARD_PRINCIPAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    LBLHOY.BackColor = Color.Gray
    '    LBLTODO.BackColor = Color.Gray


    '    TXTFI.Value = (DateTime.Now.ToShortDateString)
    '    TXTFF.Value = (DateTime.Now.ToShortDateString)
    '    SUMAR_POR_COBRAR_OK()
    '    SUMAR_POR_PAGAR_OK()

    '    SUMAR_VENTAS()
    '    sumar_KARDEX_RECHASOS()
    '    sumar_KARDEX_VENTAS()
    '    sumar_INGRESOS_VARIOS()
    '    sumar_COBROS()
    '    SUMAR_INGRESOSOK()


    '    sumar_pagos_POR_TURNO()
    '    sumar_compras_POR_TURNO()
    '    sumar_gastos_POR_TURNO()
    '    SUMAR_EGRESOS()


    '    INGRESOS_EGRESOS()


    '    MOSTRAR_GASTOS_EN_QUE()
    '    SUMAR_KARDEX_SALIDA()
    'End Sub

    'Private Sub TXTFI_ValueChanged(sender As Object, e As EventArgs) Handles TXTFI.ValueChanged
    '    LBLHOY.BackColor = Color.Gray
    '    LBLTODO.BackColor = Color.Gray


    '    SUMAR_VENTAS()
    '    sumar_KARDEX_RECHASOS()
    '    sumar_KARDEX_VENTAS()
    '    sumar_INGRESOS_VARIOS()
    '    sumar_COBROS()
    '    SUMAR_INGRESOSOK()




    '    sumar_pagos_POR_TURNO()
    '    sumar_compras_POR_TURNO()
    '    sumar_gastos_POR_TURNO()
    '    SUMAR_EGRESOS()



    '    INGRESOS_EGRESOS()

    '    MOSTRAR_GASTOS_EN_QUE()
    '    SUMAR_KARDEX_SALIDA()
    'End Sub

    'Private Sub TXTFF_ValueChanged(sender As Object, e As EventArgs) Handles TXTFF.ValueChanged
    '    LBLHOY.BackColor = Color.Gray
    '    LBLTODO.BackColor = Color.Gray



    '    SUMAR_VENTAS()
    '    sumar_KARDEX_RECHASOS()
    '    sumar_KARDEX_VENTAS()
    '    sumar_INGRESOS_VARIOS()
    '    sumar_COBROS()
    '    SUMAR_INGRESOSOK()



    '    sumar_pagos_POR_TURNO()
    '    sumar_compras_POR_TURNO()
    '    sumar_gastos_POR_TURNO()
    '    SUMAR_EGRESOS()



    '    INGRESOS_EGRESOS()


    '    MOSTRAR_GASTOS_EN_QUE()
    '    SUMAR_KARDEX_SALIDA()
    'End Sub

    'Private Sub Label11_Click(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub Panel19_Paint(sender As Object, e As PaintEventArgs) Handles Panel19.Paint

    'End Sub

    'Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint

    'End Sub

    'Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    'End Sub

    'Private Sub Label4_Click(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub LBLHOY_Click(sender As Object, e As EventArgs) Handles LBLHOY.Click
    '    LBLTODO.BackColor = Color.Gray
    '    LBLHOY.BackColor = Color.MediumSeaGreen



    '    TXTFI.Value = (DateTime.Now.ToShortDateString)
    '    TXTFF.Value = (DateTime.Now.ToShortDateString)
    '    SUMAR_VENTAS()
    '    sumar_KARDEX_RECHASOS()
    '    sumar_KARDEX_VENTAS()
    '    sumar_INGRESOS_VARIOS()
    '    sumar_COBROS()
    '    SUMAR_INGRESOSOK()




    '    sumar_pagos_POR_TURNO()
    '    sumar_compras_POR_TURNO()
    '    sumar_gastos_POR_TURNO()
    '    SUMAR_EGRESOS()



    '    INGRESOS_EGRESOS()


    '    MOSTRAR_GASTOS_EN_QUE()
    '    SUMAR_KARDEX_SALIDA()
    '    LBLTODO.BackColor = Color.Gray
    '    LBLHOY.BackColor = Color.MediumSeaGreen

    'End Sub

    'Private Sub LBLTODO_Click(sender As Object, e As EventArgs) Handles LBLTODO.Click
    '    LBLTODO.BackColor = Color.MediumSeaGreen
    '    LBLHOY.BackColor = Color.Gray



    '    TXTFI.Value = "01/01/1900"
    '    TXTFF.Value = "01/01/2900"
    '    SUMAR_VENTAS()
    '    sumar_KARDEX_RECHASOS()
    '    sumar_KARDEX_VENTAS()
    '    sumar_INGRESOS_VARIOS()
    '    sumar_COBROS()
    '    SUMAR_INGRESOSOK()




    '    sumar_pagos_POR_TURNO()
    '    sumar_compras_POR_TURNO()
    '    sumar_gastos_POR_TURNO()
    '    SUMAR_EGRESOS()



    '    INGRESOS_EGRESOS()


    '    MOSTRAR_GASTOS_EN_QUE()
    '    SUMAR_KARDEX_SALIDA()
    '    LBLTODO.BackColor = Color.MediumSeaGreen
    '    LBLHOY.BackColor = Color.Gray
    'End Sub

    Sub SUMAR_POR_COBRAR_OK()
        Dim importe As Double
        Dim com As New SqlCommand("SUMAR_POR_COBRAR_OK", conexion)
        'com.CommandType = 4
        'com.Parameters.AddWithValue("@FI", TXTFI.Value)
        'com.Parameters.AddWithValue("@FF", TXTFF.Value)
        Try
            abrir()
            importe = (com.ExecuteScalar()) 'asignamos el valor del importe
            Cerrar()
        Catch ex As Exception
        End Try
        TXTPOR_COBRAR.Text = importe  ' mostramos el importe
        TXTPOR_COBRAR.Text = VENTAS_MENU_PRINCIPAL.txtmoneda.Text & " " & Format(CType(TXTPOR_COBRAR.Text, Decimal), "##0.00")

    End Sub
    'Sub SUMAR_POR_PAGAR_OK()
    '    Dim importe As Double
    '    Dim com As New SqlCommand("SUMAR_POR_PAGAR_OK", conexion)
    '    com.CommandType = 4
    '    com.Parameters.AddWithValue("@FI", TXTFI.Value)
    '    com.Parameters.AddWithValue("@FF", TXTFF.Value)
    '    Try
    '        abrir()
    '        importe = (com.ExecuteScalar()) 'asignamos el valor del importe
    '        Cerrar()
    '    Catch ex As Exception
    '    End Try
    '    TXTPOR_PAGAR.Text = importe  ' mostramos el importe
    '    TXTPOR_PAGAR.Text = "S/. " & Format(CType(TXTPOR_PAGAR.Text, Decimal), "##0.00")

    'End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    SUMAR_POR_COBRAR_OK()
    '    SUMAR_POR_PAGAR_OK()

    '    SUMAR_VENTAS()
    '    sumar_KARDEX_RECHASOS()
    '    sumar_KARDEX_VENTAS()
    '    sumar_INGRESOS_VARIOS()
    '    sumar_COBROS()
    '    SUMAR_INGRESOSOK()


    '    sumar_pagos_POR_TURNO()
    '    sumar_compras_POR_TURNO()
    '    sumar_gastos_POR_TURNO()
    '    SUMAR_EGRESOS()


    '    INGRESOS_EGRESOS()


    '    MOSTRAR_GASTOS_EN_QUE()
    '    SUMAR_KARDEX_SALIDA()
    '    Timer1.Stop()

    'End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Sub mostrar_gastos_por_año_en_comboboxAño()
        Dim dtunidad As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("mostrar_gastos_por_anio_en_comboboxAnio", conexion)
            DA.Fill(dtunidad)

            txtaño_gasto.DisplayMember = "anio"

            txtaño_gasto.ValueMember = "anio"

            txtaño_gasto.DataSource = dtunidad
        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try

        Cerrar()

    End Sub
    Sub mostrar_gastos_por_MES_en_comboboxMES()
        Dim dtunidad As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("mostrar_gastos_por_MES_en_comboboxMES", conexion)
            DA.SelectCommand.CommandType = 4
            DA.SelectCommand.Parameters.AddWithValue("@anio", txtaño_gasto.Text)


            DA.Fill(dtunidad)

            txtmes_gasto.DisplayMember = "mes"

            txtmes_gasto.ValueMember = "mes"

            txtmes_gasto.DataSource = dtunidad
        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try

        Cerrar()

    End Sub
    Sub mostrar_mayores_GASTOS_POR_CONCEPTO_por_año()

        Dim fecha As ArrayList = New ArrayList
        Dim descripcion As ArrayList = New ArrayList

        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("mostrar_mayores_GASTOS_POR_CONCEPTO_por_anio", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@anio", txtaño_gasto.Text)

            cmd.CommandType = CommandType.StoredProcedure
            dr = cmd.ExecuteReader()
            While (dr.Read())
                fecha.Add(dr.GetString(0))
                descripcion.Add(dr.GetString(1))
            End While

            ChartGastos_por_año.Series(0).Points.DataBindXY(fecha, descripcion)

            dr.Close()
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub mostrar_mayores_GASTOS_POR_CONCEPTO_por_mes_de_año()

        Dim fecha As ArrayList = New ArrayList
        Dim descripcion As ArrayList = New ArrayList

        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("mostrar_mayores_GASTOS_POR_CONCEPTO_por_mes_de_anio", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@mes", txtmes_gasto.Text)
            cmd.Parameters.AddWithValue("@anio", txtaño_gasto.Text)

            cmd.CommandType = CommandType.StoredProcedure
            dr = cmd.ExecuteReader()
            While (dr.Read())
                fecha.Add(dr.GetString(0))
                descripcion.Add(dr.GetString(1))
            End While
            Chart4.Series(0).Points.DataBindXY(fecha, descripcion)
            dr.Close()
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub DASHBOARD_PRINCIPAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chekFiltros.Checked = False

        mostrar_gastos_por_año_en_comboboxAño()
        mostrar_gastos_por_MES_en_comboboxMES()
        Listar_ventaspor_mes()
        mostrar_mayores_GASTOS_POR_CONCEPTO_por_año()
        mostrar_5_productos_mas_vendidos()

        mostrar_5_productos_mas_rentables()




        SUMAR_POR_COBRAR_OK()
        sumar_Cuentas_por_pagar()
        MOSTRAR_GANANCIAS()
        MOSTRAR_Inventarios_bajo_minimo_COUNT()
        MOSTRAR_Clientes()
        MOSTRAR_Productos_Count()


        Label32.Text = "Total VENTAS " & VENTAS_MENU_PRINCIPAL.txtmoneda.Text
        Label6.Text = "Total GANANCIA " & VENTAS_MENU_PRINCIPAL.txtmoneda.Text


        lblfechaHoy.Text = MonthName(DatePart(DateInterval.Month, Now())) & " " & DatePart(DateInterval.Year, Now())
        Me.lblfechaHoy.Text = UCase(Me.lblfechaHoy.Text)
        Panel4.Location = New Point((Width - Panel4.Width) / 2, (Height - Panel4.Height) / 2)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub txtaño_gasto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtaño_gasto.SelectedIndexChanged
        mostrar_mayores_GASTOS_POR_CONCEPTO_por_año()
        mostrar_gastos_por_MES_en_comboboxMES()
        mostrar_mayores_GASTOS_POR_CONCEPTO_por_mes_de_año()
    End Sub

  
    Private Sub txtmes_gasto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtmes_gasto.SelectedIndexChanged
        mostrar_mayores_GASTOS_POR_CONCEPTO_por_mes_de_año()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

        Close()

    End Sub


    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Listar_ventaspor_mes()
        Panel21.Visible = False

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Listar_ventaspor_mes()
        Panel21.Visible = False
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles TFILTROS.Click
        PanelHoy.Visible = False
        Panel21.Visible = True
        chekFiltros.Checked = True

    End Sub

    Private Sub TXTFI_ValueChanged(sender As Object, e As EventArgs) Handles TXTFI.ValueChanged
        Listar_ventas_POR_FECHA()
    End Sub

    Private Sub TXTFF_ValueChanged(sender As Object, e As EventArgs) Handles TXTFF.ValueChanged
        Listar_ventas_POR_FECHA()
    End Sub

    Private Sub lblfechaHoy_Click(sender As Object, e As EventArgs) Handles lblfechaHoy.Click
        Me.lblfechaHoy.Text = UCase(Me.lblfechaHoy.Text)
        'Me.TextBox1.SelectionStart = Me.TextBox1.TextLength + 1
    End Sub

    Private Sub chekFiltros_CheckedChanged(sender As Object, e As EventArgs) Handles chekFiltros.CheckedChanged
        If chekFiltros.Checked = True Then
            PanelHoy.Visible = False
            Panel21.Visible = True
        ElseIf chekFiltros.Checked = False Then
            PanelHoy.Visible = True
            Listar_ventaspor_mes()
            Panel21.Visible = False
        End If
    End Sub
End Class