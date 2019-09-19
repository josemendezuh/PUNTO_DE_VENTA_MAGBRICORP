<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_dE_REPORTES_OI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MENU_dE_REPORTES_OI))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tmMOSTRAR = New System.Windows.Forms.Timer(Me.components)
        Me.tmOCULTAR = New System.Windows.Forms.Timer(Me.components)
        Me.Panel72 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ResumenDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.InventarioGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KardexDeInventariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip5 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem22 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelReportVentas = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Telerik.ReportViewer.WinForms.ReportViewer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ChartVENTAS = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PanelREPORTEInventario = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.datalistadoInventariosReport = New System.Windows.Forms.DataGridView()
        Me.Marcar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblcantidaddeProductosEnInventario = New System.Windows.Forms.Label()
        Me.lblcostoInventario = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtbuscar_inventarios = New System.Windows.Forms.TextBox()
        Me.PanelKardex = New System.Windows.Forms.Panel()
        Me.ReportViewer2 = New Telerik.ReportViewer.WinForms.ReportViewer()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.MenuStrip8 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtbuscarKardex_movimientos = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel72.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelReportVentas.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ChartVENTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelREPORTEInventario.SuspendLayout()
        CType(Me.datalistadoInventariosReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelKardex.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.MenuStrip8.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmMOSTRAR
        '
        Me.tmMOSTRAR.Interval = 2
        '
        'tmOCULTAR
        '
        Me.tmOCULTAR.Interval = 2
        '
        'Panel72
        '
        Me.Panel72.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel72.Controls.Add(Me.ToolStrip1)
        Me.Panel72.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel72.Location = New System.Drawing.Point(0, 35)
        Me.Panel72.Name = "Panel72"
        Me.Panel72.Size = New System.Drawing.Size(210, 535)
        Me.Panel72.TabIndex = 402
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton5})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(210, 545)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip7"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResumenDeVentasToolStripMenuItem})
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(208, 25)
        Me.ToolStripButton2.Text = "Reportes de Ventas"
        '
        'ResumenDeVentasToolStripMenuItem
        '
        Me.ResumenDeVentasToolStripMenuItem.Name = "ResumenDeVentasToolStripMenuItem"
        Me.ResumenDeVentasToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.ResumenDeVentasToolStripMenuItem.Text = "Resumen de Ventas"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventarioGeneralToolStripMenuItem, Me.KardexDeInventariosToolStripMenuItem})
        Me.ToolStripButton5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(208, 25)
        Me.ToolStripButton5.Text = "Reportes de Inventarios"
        '
        'InventarioGeneralToolStripMenuItem
        '
        Me.InventarioGeneralToolStripMenuItem.Name = "InventarioGeneralToolStripMenuItem"
        Me.InventarioGeneralToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.InventarioGeneralToolStripMenuItem.Text = "Inventario General"
        '
        'KardexDeInventariosToolStripMenuItem
        '
        Me.KardexDeInventariosToolStripMenuItem.Name = "KardexDeInventariosToolStripMenuItem"
        Me.KardexDeInventariosToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.KardexDeInventariosToolStripMenuItem.Text = "Kardex de Inventarios"
        '
        'MenuStrip5
        '
        Me.MenuStrip5.AutoSize = False
        Me.MenuStrip5.BackColor = System.Drawing.Color.White
        Me.MenuStrip5.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem22})
        Me.MenuStrip5.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip5.Name = "MenuStrip5"
        Me.MenuStrip5.Size = New System.Drawing.Size(35, 35)
        Me.MenuStrip5.TabIndex = 592
        Me.MenuStrip5.Text = "MenuStrip5"
        '
        'ToolStripMenuItem22
        '
        Me.ToolStripMenuItem22.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripMenuItem22.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem22.Image = CType(resources.GetObject("ToolStripMenuItem22.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem22.Name = "ToolStripMenuItem22"
        Me.ToolStripMenuItem22.Size = New System.Drawing.Size(28, 20)
        Me.ToolStripMenuItem22.Text = "ToolStripMenuItem16"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MenuStrip5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1167, 35)
        Me.Panel1.TabIndex = 593
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(35, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1132, 35)
        Me.Label1.TabIndex = 593
        Me.Label1.Text = "Reporte de Ventas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelReportVentas
        '
        Me.PanelReportVentas.Controls.Add(Me.ReportViewer1)
        Me.PanelReportVentas.Controls.Add(Me.Panel2)
        Me.PanelReportVentas.Location = New System.Drawing.Point(625, 108)
        Me.PanelReportVentas.Name = "PanelReportVentas"
        Me.PanelReportVentas.Size = New System.Drawing.Size(188, 280)
        Me.PanelReportVentas.TabIndex = 594
        Me.PanelReportVentas.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 165)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(188, 115)
        Me.ReportViewer1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.ChartVENTAS)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(188, 165)
        Me.Panel2.TabIndex = 0
        '
        'ChartVENTAS
        '
        Me.ChartVENTAS.BackColor = System.Drawing.Color.Transparent
        Me.ChartVENTAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ChartVENTAS.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Right
        Me.ChartVENTAS.BackImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChartVENTAS.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled
        Me.ChartVENTAS.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChartVENTAS.BorderlineColor = System.Drawing.Color.Black
        Me.ChartVENTAS.BorderlineWidth = 6
        Me.ChartVENTAS.BorderSkin.BackColor = System.Drawing.Color.Yellow
        ChartArea1.AxisX.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray
        ChartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot
        ChartArea1.AxisX.MajorGrid.LineWidth = 0
        ChartArea1.AxisX.MajorTickMark.LineWidth = 0
        ChartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis
        ChartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea1.AxisX.MinorGrid.LineWidth = 0
        ChartArea1.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis
        ChartArea1.AxisX2.ScaleBreakStyle.LineColor = System.Drawing.Color.Yellow
        ChartArea1.AxisX2.ScrollBar.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ChartArea1.AxisY.InterlacedColor = System.Drawing.Color.Gray
        ChartArea1.AxisY.LineWidth = 0
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea1.AxisY.MajorTickMark.LineWidth = 0
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Maroon
        ChartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea1.AxisY.MinorGrid.LineWidth = 0
        ChartArea1.AxisY.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea1.AxisY.MinorTickMark.LineWidth = 0
        ChartArea1.AxisY.MinorTickMark.Size = 0!
        ChartArea1.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChartVENTAS.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Far
        Legend1.BackColor = System.Drawing.Color.White
        Legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Legend1.BorderWidth = 2
        Legend1.Name = "Legend1"
        Legend1.Position.Auto = False
        Legend1.Position.Height = 10.66667!
        Legend1.Position.Width = 19.0!
        Legend1.Position.X = 14.0!
        Legend1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Legend1.TextWrapThreshold = 45
        Legend1.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ChartVENTAS.Legends.Add(Legend1)
        Me.ChartVENTAS.Location = New System.Drawing.Point(3, 3)
        Me.ChartVENTAS.Name = "ChartVENTAS"
        Me.ChartVENTAS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft
        Series1.BackImageTransparentColor = System.Drawing.Color.White
        Series1.BackSecondaryColor = System.Drawing.Color.Magenta
        Series1.BorderColor = System.Drawing.Color.Transparent
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(212, Byte), Integer))
        Series1.EmptyPointStyle.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight
        Series1.EmptyPointStyle.LabelAngle = 3
        Series1.LabelAngle = 3
        Series1.LabelForeColor = System.Drawing.Color.Silver
        Series1.LabelToolTip = "h#VALX{D1}"
        Series1.Legend = "Legend1"
        Series1.LegendText = "Monto Total"
        Series1.MarkerBorderColor = System.Drawing.Color.Purple
        Series1.MarkerColor = System.Drawing.Color.White
        Series1.MarkerSize = 6
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series1.Name = "Series1"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series1.ShadowColor = System.Drawing.Color.RoyalBlue
        Series1.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Me.ChartVENTAS.Series.Add(Series1)
        Me.ChartVENTAS.Size = New System.Drawing.Size(390, 156)
        Me.ChartVENTAS.TabIndex = 533
        Me.ChartVENTAS.Text = "Chart1"
        '
        'PanelREPORTEInventario
        '
        Me.PanelREPORTEInventario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelREPORTEInventario.Controls.Add(Me.Panel5)
        Me.PanelREPORTEInventario.Controls.Add(Me.Panel4)
        Me.PanelREPORTEInventario.Controls.Add(Me.datalistadoInventariosReport)
        Me.PanelREPORTEInventario.Controls.Add(Me.Label3)
        Me.PanelREPORTEInventario.Controls.Add(Me.Label2)
        Me.PanelREPORTEInventario.Controls.Add(Me.lblcantidaddeProductosEnInventario)
        Me.PanelREPORTEInventario.Controls.Add(Me.lblcostoInventario)
        Me.PanelREPORTEInventario.Controls.Add(Me.MenuStrip1)
        Me.PanelREPORTEInventario.Controls.Add(Me.txtbuscar_inventarios)
        Me.PanelREPORTEInventario.Location = New System.Drawing.Point(282, 41)
        Me.PanelREPORTEInventario.Name = "PanelREPORTEInventario"
        Me.PanelREPORTEInventario.Size = New System.Drawing.Size(54, 300)
        Me.PanelREPORTEInventario.TabIndex = 597
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel5.Location = New System.Drawing.Point(9, 102)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(388, 2)
        Me.Panel5.TabIndex = 601
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(54, 1)
        Me.Panel4.TabIndex = 600
        '
        'datalistadoInventariosReport
        '
        Me.datalistadoInventariosReport.AllowUserToAddRows = False
        Me.datalistadoInventariosReport.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.datalistadoInventariosReport.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistadoInventariosReport.BackgroundColor = System.Drawing.Color.White
        Me.datalistadoInventariosReport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistadoInventariosReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datalistadoInventariosReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistadoInventariosReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datalistadoInventariosReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistadoInventariosReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Marcar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistadoInventariosReport.DefaultCellStyle = DataGridViewCellStyle3
        Me.datalistadoInventariosReport.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.datalistadoInventariosReport.EnableHeadersVisualStyles = False
        Me.datalistadoInventariosReport.Location = New System.Drawing.Point(0, -135)
        Me.datalistadoInventariosReport.Name = "datalistadoInventariosReport"
        Me.datalistadoInventariosReport.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistadoInventariosReport.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datalistadoInventariosReport.RowHeadersVisible = False
        Me.datalistadoInventariosReport.RowHeadersWidth = 9
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro
        Me.datalistadoInventariosReport.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.datalistadoInventariosReport.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.datalistadoInventariosReport.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.datalistadoInventariosReport.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.datalistadoInventariosReport.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datalistadoInventariosReport.RowTemplate.Height = 32
        Me.datalistadoInventariosReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistadoInventariosReport.Size = New System.Drawing.Size(54, 435)
        Me.datalistadoInventariosReport.TabIndex = 598
        '
        'Marcar
        '
        Me.Marcar.DataPropertyName = "Marcar"
        Me.Marcar.HeaderText = "Marcar"
        Me.Marcar.Name = "Marcar"
        Me.Marcar.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(252, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 17)
        Me.Label3.TabIndex = 596
        Me.Label3.Text = "Cantidad de Productos en Inventario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(13, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 17)
        Me.Label2.TabIndex = 596
        Me.Label2.Text = "Costo del Inventario"
        '
        'lblcantidaddeProductosEnInventario
        '
        Me.lblcantidaddeProductosEnInventario.AutoSize = True
        Me.lblcantidaddeProductosEnInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblcantidaddeProductosEnInventario.ForeColor = System.Drawing.Color.Gray
        Me.lblcantidaddeProductosEnInventario.Location = New System.Drawing.Point(343, 36)
        Me.lblcantidaddeProductosEnInventario.Name = "lblcantidaddeProductosEnInventario"
        Me.lblcantidaddeProductosEnInventario.Size = New System.Drawing.Size(57, 24)
        Me.lblcantidaddeProductosEnInventario.TabIndex = 596
        Me.lblcantidaddeProductosEnInventario.Text = "S/.45"
        '
        'lblcostoInventario
        '
        Me.lblcostoInventario.AutoSize = True
        Me.lblcostoInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblcostoInventario.ForeColor = System.Drawing.Color.Gray
        Me.lblcostoInventario.Location = New System.Drawing.Point(55, 36)
        Me.lblcostoInventario.Name = "lblcostoInventario"
        Me.lblcostoInventario.Size = New System.Drawing.Size(57, 24)
        Me.lblcostoInventario.TabIndex = 596
        Me.lblcostoInventario.Text = "S/.45"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 73)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(38, 31)
        Me.MenuStrip1.TabIndex = 585
        Me.MenuStrip1.Text = "MenuStrip7"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripMenuItem6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem6.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem6.Image = CType(resources.GetObject("ToolStripMenuItem6.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(28, 27)
        Me.ToolStripMenuItem6.ToolTipText = "Quitar logo"
        '
        'txtbuscar_inventarios
        '
        Me.txtbuscar_inventarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtbuscar_inventarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbuscar_inventarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtbuscar_inventarios.Location = New System.Drawing.Point(50, 80)
        Me.txtbuscar_inventarios.Name = "txtbuscar_inventarios"
        Me.txtbuscar_inventarios.Size = New System.Drawing.Size(345, 19)
        Me.txtbuscar_inventarios.TabIndex = 586
        '
        'PanelKardex
        '
        Me.PanelKardex.Controls.Add(Me.ReportViewer2)
        Me.PanelKardex.Controls.Add(Me.Panel7)
        Me.PanelKardex.Location = New System.Drawing.Point(412, 63)
        Me.PanelKardex.Name = "PanelKardex"
        Me.PanelKardex.Size = New System.Drawing.Size(79, 278)
        Me.PanelKardex.TabIndex = 603
        Me.PanelKardex.Visible = False
        '
        'ReportViewer2
        '
        Me.ReportViewer2.AutoScroll = True
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 49)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(79, 229)
        Me.ReportViewer2.TabIndex = 375
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.MenuStrip8)
        Me.Panel7.Controls.Add(Me.txtbuscarKardex_movimientos)
        Me.Panel7.Controls.Add(Me.Label20)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(79, 49)
        Me.Panel7.TabIndex = 374
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel8.Location = New System.Drawing.Point(9, 38)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(388, 2)
        Me.Panel8.TabIndex = 607
        '
        'MenuStrip8
        '
        Me.MenuStrip8.AutoSize = False
        Me.MenuStrip8.BackColor = System.Drawing.Color.White
        Me.MenuStrip8.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip8.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5})
        Me.MenuStrip8.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip8.Location = New System.Drawing.Point(9, 9)
        Me.MenuStrip8.Name = "MenuStrip8"
        Me.MenuStrip8.ShowItemToolTips = True
        Me.MenuStrip8.Size = New System.Drawing.Size(38, 31)
        Me.MenuStrip8.TabIndex = 605
        Me.MenuStrip8.Text = "MenuStrip7"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.BackColor = System.Drawing.Color.White
        Me.ToolStripMenuItem5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem5.Image = CType(resources.GetObject("ToolStripMenuItem5.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(28, 27)
        Me.ToolStripMenuItem5.ToolTipText = "Quitar logo"
        '
        'txtbuscarKardex_movimientos
        '
        Me.txtbuscarKardex_movimientos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtbuscarKardex_movimientos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbuscarKardex_movimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtbuscarKardex_movimientos.Location = New System.Drawing.Point(50, 16)
        Me.txtbuscarKardex_movimientos.Name = "txtbuscarKardex_movimientos"
        Me.txtbuscarKardex_movimientos.Size = New System.Drawing.Size(345, 19)
        Me.txtbuscarKardex_movimientos.TabIndex = 606
        Me.txtbuscarKardex_movimientos.Text = "Buscar producto,cajero"
        '
        'Label20
        '
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label20.Location = New System.Drawing.Point(65, 167)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(165, 20)
        Me.Label20.TabIndex = 216
        Me.Label20.Text = "Buscar seleccione en la lupa>>"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(1129, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(38, 35)
        Me.Button5.TabIndex = 594
        Me.Button5.Text = "X"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'MENU_dE_REPORTES_OI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1167, 570)
        Me.Controls.Add(Me.PanelREPORTEInventario)
        Me.Controls.Add(Me.PanelKardex)
        Me.Controls.Add(Me.PanelReportVentas)
        Me.Controls.Add(Me.Panel72)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MENU_dE_REPORTES_OI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel72.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip5.ResumeLayout(False)
        Me.MenuStrip5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.PanelReportVentas.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.ChartVENTAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelREPORTEInventario.ResumeLayout(False)
        Me.PanelREPORTEInventario.PerformLayout()
        CType(Me.datalistadoInventariosReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelKardex.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.MenuStrip8.ResumeLayout(False)
        Me.MenuStrip8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmMOSTRAR As System.Windows.Forms.Timer
    Friend WithEvents tmOCULTAR As System.Windows.Forms.Timer
    Friend WithEvents Panel72 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip5 As MenuStrip
    Friend WithEvents ToolStripMenuItem22 As ToolStripMenuItem
    Friend WithEvents PanelReportVentas As Panel
    Friend WithEvents ReportViewer1 As Telerik.ReportViewer.WinForms.ReportViewer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ToolStripButton2 As ToolStripDropDownButton
    Friend WithEvents ResumenDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChartVENTAS As DataVisualization.Charting.Chart
    Friend WithEvents PanelREPORTEInventario As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents datalistadoInventariosReport As DataGridView
    Friend WithEvents Marcar As DataGridViewCheckBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblcantidaddeProductosEnInventario As Label
    Friend WithEvents lblcostoInventario As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents txtbuscar_inventarios As TextBox
    Friend WithEvents ToolStripButton5 As ToolStripDropDownButton
    Friend WithEvents InventarioGeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KardexDeInventariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelKardex As Panel
    Friend WithEvents ReportViewer2 As Telerik.ReportViewer.WinForms.ReportViewer
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents MenuStrip8 As MenuStrip
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents txtbuscarKardex_movimientos As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Button5 As Button
End Class
