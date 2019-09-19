<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip4 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbltipodebusqueda2 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.DATALISTADO_PRODUCTOS_OKA = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MenuStrip9 = New System.Windows.Forms.MenuStrip()
        Me.BTNLECTORA = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbltipodebusqueda = New System.Windows.Forms.Label()
        Me.txtprecio_unitario = New System.Windows.Forms.Label()
        Me.txtidproducto = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblcontador_stock_detalle_de_venta = New System.Windows.Forms.Label()
        Me.datalistado_stock_detalle_venta = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnborrarderecha = New System.Windows.Forms.Button()
        Me.btnborrartodo = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.MenuStrip4.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        CType(Me.DATALISTADO_PRODUCTOS_OKA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip9.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.datalistado_stock_detalle_venta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip4
        '
        Me.MenuStrip4.AutoSize = False
        Me.MenuStrip4.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5})
        Me.MenuStrip4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip4.Location = New System.Drawing.Point(415, 126)
        Me.MenuStrip4.Name = "MenuStrip4"
        Me.MenuStrip4.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip4.ShowItemToolTips = True
        Me.MenuStrip4.Size = New System.Drawing.Size(131, 37)
        Me.MenuStrip4.TabIndex = 552
        Me.MenuStrip4.Text = "MenuStrip7"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripMenuItem5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(72, 33)
        Me.ToolStripMenuItem5.Text = "<<Volver"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.AutoSize = False
        Me.MenuStrip3.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem6})
        Me.MenuStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip3.Location = New System.Drawing.Point(328, 126)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip3.ShowItemToolTips = True
        Me.MenuStrip3.Size = New System.Drawing.Size(267, 37)
        Me.MenuStrip3.TabIndex = 551
        Me.MenuStrip3.Text = "MenuStrip7"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(79, 33)
        Me.ToolStripMenuItem3.Text = "Aceptar"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(12, 33)
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtcantidad.Location = New System.Drawing.Point(156, 82)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(159, 38)
        Me.txtcantidad.TabIndex = 550
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Miriam Fixed", 20.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(7, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 27)
        Me.Label9.TabIndex = 549
        Me.Label9.Text = "Cantidad:"
        '
        'lbltipodebusqueda2
        '
        Me.lbltipodebusqueda2.AutoSize = True
        Me.lbltipodebusqueda2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lbltipodebusqueda2.ForeColor = System.Drawing.Color.DimGray
        Me.lbltipodebusqueda2.Location = New System.Drawing.Point(26, 37)
        Me.lbltipodebusqueda2.Name = "lbltipodebusqueda2"
        Me.lbltipodebusqueda2.Size = New System.Drawing.Size(201, 18)
        Me.lbltipodebusqueda2.TabIndex = 553
        Me.lbltipodebusqueda2.Text = "Buscar por Codigo de Barras"
        Me.lbltipodebusqueda2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbuscar
        '
        Me.txtbuscar.BackColor = System.Drawing.Color.White
        Me.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtbuscar.Location = New System.Drawing.Point(12, 34)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(400, 26)
        Me.txtbuscar.TabIndex = 554
        '
        'DATALISTADO_PRODUCTOS_OKA
        '
        Me.DATALISTADO_PRODUCTOS_OKA.AllowUserToAddRows = False
        Me.DATALISTADO_PRODUCTOS_OKA.AllowUserToDeleteRows = False
        Me.DATALISTADO_PRODUCTOS_OKA.AllowUserToResizeRows = False
        Me.DATALISTADO_PRODUCTOS_OKA.BackgroundColor = System.Drawing.Color.White
        Me.DATALISTADO_PRODUCTOS_OKA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DATALISTADO_PRODUCTOS_OKA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DATALISTADO_PRODUCTOS_OKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATALISTADO_PRODUCTOS_OKA.ColumnHeadersVisible = False
        Me.DATALISTADO_PRODUCTOS_OKA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn4})
        Me.DATALISTADO_PRODUCTOS_OKA.EnableHeadersVisualStyles = False
        Me.DATALISTADO_PRODUCTOS_OKA.Location = New System.Drawing.Point(12, 66)
        Me.DATALISTADO_PRODUCTOS_OKA.Name = "DATALISTADO_PRODUCTOS_OKA"
        Me.DATALISTADO_PRODUCTOS_OKA.ReadOnly = True
        Me.DATALISTADO_PRODUCTOS_OKA.RowHeadersVisible = False
        Me.DATALISTADO_PRODUCTOS_OKA.RowHeadersWidth = 9
        Me.DATALISTADO_PRODUCTOS_OKA.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DATALISTADO_PRODUCTOS_OKA.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DATALISTADO_PRODUCTOS_OKA.RowTemplate.Height = 40
        Me.DATALISTADO_PRODUCTOS_OKA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATALISTADO_PRODUCTOS_OKA.Size = New System.Drawing.Size(608, 346)
        Me.DATALISTADO_PRODUCTOS_OKA.TabIndex = 556
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "Marcar"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "Marcar"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.ReadOnly = True
        '
        'MenuStrip9
        '
        Me.MenuStrip9.AutoSize = False
        Me.MenuStrip9.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip9.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip9.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BTNLECTORA})
        Me.MenuStrip9.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip9.Location = New System.Drawing.Point(402, 23)
        Me.MenuStrip9.Name = "MenuStrip9"
        Me.MenuStrip9.ShowItemToolTips = True
        Me.MenuStrip9.Size = New System.Drawing.Size(51, 50)
        Me.MenuStrip9.TabIndex = 557
        Me.MenuStrip9.Text = "MenuStrip9"
        '
        'BTNLECTORA
        '
        Me.BTNLECTORA.AutoSize = False
        Me.BTNLECTORA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTNLECTORA.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BTNLECTORA.ForeColor = System.Drawing.Color.Black
        Me.BTNLECTORA.Image = CType(resources.GetObject("BTNLECTORA.Image"), System.Drawing.Image)
        Me.BTNLECTORA.Name = "BTNLECTORA"
        Me.BTNLECTORA.Size = New System.Drawing.Size(34, 30)
        Me.BTNLECTORA.ToolTipText = "Buscar"
        '
        'lbltipodebusqueda
        '
        Me.lbltipodebusqueda.AutoSize = True
        Me.lbltipodebusqueda.Font = New System.Drawing.Font("Miriam Fixed", 20.0!)
        Me.lbltipodebusqueda.ForeColor = System.Drawing.Color.Black
        Me.lbltipodebusqueda.Location = New System.Drawing.Point(46, 41)
        Me.lbltipodebusqueda.Name = "lbltipodebusqueda"
        Me.lbltipodebusqueda.Size = New System.Drawing.Size(156, 27)
        Me.lbltipodebusqueda.TabIndex = 549
        Me.lbltipodebusqueda.Text = "Cantidad:"
        '
        'txtprecio_unitario
        '
        Me.txtprecio_unitario.AutoSize = True
        Me.txtprecio_unitario.Font = New System.Drawing.Font("Miriam Fixed", 20.0!)
        Me.txtprecio_unitario.ForeColor = System.Drawing.Color.Black
        Me.txtprecio_unitario.Location = New System.Drawing.Point(15, 41)
        Me.txtprecio_unitario.Name = "txtprecio_unitario"
        Me.txtprecio_unitario.Size = New System.Drawing.Size(156, 27)
        Me.txtprecio_unitario.TabIndex = 549
        Me.txtprecio_unitario.Text = "Cantidad:"
        '
        'txtidproducto
        '
        Me.txtidproducto.AutoSize = True
        Me.txtidproducto.Font = New System.Drawing.Font("Miriam Fixed", 20.0!)
        Me.txtidproducto.ForeColor = System.Drawing.Color.Black
        Me.txtidproducto.Location = New System.Drawing.Point(31, 64)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(156, 27)
        Me.txtidproducto.TabIndex = 549
        Me.txtidproducto.Text = "Cantidad:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblcontador_stock_detalle_de_venta)
        Me.Panel1.Controls.Add(Me.datalistado_stock_detalle_venta)
        Me.Panel1.Controls.Add(Me.lbltipodebusqueda)
        Me.Panel1.Controls.Add(Me.txtidproducto)
        Me.Panel1.Controls.Add(Me.txtprecio_unitario)
        Me.Panel1.Location = New System.Drawing.Point(371, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 10)
        Me.Panel1.TabIndex = 559
        '
        'lblcontador_stock_detalle_de_venta
        '
        Me.lblcontador_stock_detalle_de_venta.AutoSize = True
        Me.lblcontador_stock_detalle_de_venta.Location = New System.Drawing.Point(48, 18)
        Me.lblcontador_stock_detalle_de_venta.Name = "lblcontador_stock_detalle_de_venta"
        Me.lblcontador_stock_detalle_de_venta.Size = New System.Drawing.Size(45, 13)
        Me.lblcontador_stock_detalle_de_venta.TabIndex = 612
        Me.lblcontador_stock_detalle_de_venta.Text = "Label60"
        '
        'datalistado_stock_detalle_venta
        '
        Me.datalistado_stock_detalle_venta.AllowUserToAddRows = False
        Me.datalistado_stock_detalle_venta.AllowUserToDeleteRows = False
        Me.datalistado_stock_detalle_venta.AllowUserToResizeRows = False
        Me.datalistado_stock_detalle_venta.BackgroundColor = System.Drawing.Color.White
        Me.datalistado_stock_detalle_venta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_stock_detalle_venta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado_stock_detalle_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado_stock_detalle_venta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn8})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado_stock_detalle_venta.DefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado_stock_detalle_venta.Location = New System.Drawing.Point(3, 45)
        Me.datalistado_stock_detalle_venta.Name = "datalistado_stock_detalle_venta"
        Me.datalistado_stock_detalle_venta.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_stock_detalle_venta.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado_stock_detalle_venta.RowHeadersVisible = False
        Me.datalistado_stock_detalle_venta.RowHeadersWidth = 5
        Me.datalistado_stock_detalle_venta.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.ForestGreen
        Me.datalistado_stock_detalle_venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado_stock_detalle_venta.Size = New System.Drawing.Size(64, 68)
        Me.datalistado_stock_detalle_venta.TabIndex = 613
        '
        'DataGridViewCheckBoxColumn8
        '
        Me.DataGridViewCheckBoxColumn8.DataPropertyName = "Activo"
        Me.DataGridViewCheckBoxColumn8.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn8.Name = "DataGridViewCheckBoxColumn8"
        Me.DataGridViewCheckBoxColumn8.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(470, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 30)
        Me.Button1.TabIndex = 611
        Me.Button1.Text = "Teclado virtual"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn0.FlatAppearance.BorderSize = 0
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0.Font = New System.Drawing.Font("Calibri", 35.0!, System.Drawing.FontStyle.Bold)
        Me.btn0.ForeColor = System.Drawing.Color.White
        Me.btn0.Location = New System.Drawing.Point(101, 341)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(65, 66)
        Me.btn0.TabIndex = 615
        Me.btn0.Text = "0"
        Me.btn0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btnborrarderecha
        '
        Me.btnborrarderecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnborrarderecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnborrarderecha.FlatAppearance.BorderSize = 0
        Me.btnborrarderecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnborrarderecha.Font = New System.Drawing.Font("Calibri", 21.0!, System.Drawing.FontStyle.Bold)
        Me.btnborrarderecha.ForeColor = System.Drawing.Color.White
        Me.btnborrarderecha.Location = New System.Drawing.Point(172, 341)
        Me.btnborrarderecha.Name = "btnborrarderecha"
        Me.btnborrarderecha.Size = New System.Drawing.Size(65, 66)
        Me.btnborrarderecha.TabIndex = 614
        Me.btnborrarderecha.Text = ","
        Me.btnborrarderecha.UseVisualStyleBackColor = False
        '
        'btnborrartodo
        '
        Me.btnborrartodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnborrartodo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnborrartodo.FlatAppearance.BorderSize = 0
        Me.btnborrartodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnborrartodo.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnborrartodo.ForeColor = System.Drawing.Color.White
        Me.btnborrartodo.Location = New System.Drawing.Point(243, 341)
        Me.btnborrartodo.Name = "btnborrartodo"
        Me.btnborrartodo.Size = New System.Drawing.Size(65, 66)
        Me.btnborrartodo.TabIndex = 613
        Me.btnborrartodo.Text = "Borrar"
        Me.btnborrartodo.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btn1)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn2)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn3)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn4)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn5)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn6)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn7)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn8)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn9)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(98, 126)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(217, 214)
        Me.FlowLayoutPanel2.TabIndex = 612
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn1.FlatAppearance.BorderSize = 0
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("Calibri", 35.0!, System.Drawing.FontStyle.Bold)
        Me.btn1.ForeColor = System.Drawing.Color.White
        Me.btn1.Location = New System.Drawing.Point(3, 3)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(65, 65)
        Me.btn1.TabIndex = 40
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn2.FlatAppearance.BorderSize = 0
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("Calibri", 35.0!, System.Drawing.FontStyle.Bold)
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.Location = New System.Drawing.Point(74, 3)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(65, 65)
        Me.btn2.TabIndex = 41
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn3.FlatAppearance.BorderSize = 0
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Font = New System.Drawing.Font("Calibri", 35.0!, System.Drawing.FontStyle.Bold)
        Me.btn3.ForeColor = System.Drawing.Color.White
        Me.btn3.Location = New System.Drawing.Point(145, 3)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(65, 65)
        Me.btn3.TabIndex = 42
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn4.FlatAppearance.BorderSize = 0
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.Font = New System.Drawing.Font("Calibri", 35.0!, System.Drawing.FontStyle.Bold)
        Me.btn4.ForeColor = System.Drawing.Color.White
        Me.btn4.Location = New System.Drawing.Point(3, 74)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(65, 65)
        Me.btn4.TabIndex = 35
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn5.FlatAppearance.BorderSize = 0
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5.Font = New System.Drawing.Font("Calibri", 35.0!, System.Drawing.FontStyle.Bold)
        Me.btn5.ForeColor = System.Drawing.Color.White
        Me.btn5.Location = New System.Drawing.Point(74, 74)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(65, 65)
        Me.btn5.TabIndex = 36
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn6.FlatAppearance.BorderSize = 0
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn6.Font = New System.Drawing.Font("Calibri", 35.0!, System.Drawing.FontStyle.Bold)
        Me.btn6.ForeColor = System.Drawing.Color.White
        Me.btn6.Location = New System.Drawing.Point(145, 74)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(65, 65)
        Me.btn6.TabIndex = 37
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn7.FlatAppearance.BorderSize = 0
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn7.Font = New System.Drawing.Font("Calibri", 35.0!, System.Drawing.FontStyle.Bold)
        Me.btn7.ForeColor = System.Drawing.Color.White
        Me.btn7.Location = New System.Drawing.Point(3, 145)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(65, 65)
        Me.btn7.TabIndex = 30
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn8.FlatAppearance.BorderSize = 0
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn8.Font = New System.Drawing.Font("Calibri", 35.0!, System.Drawing.FontStyle.Bold)
        Me.btn8.ForeColor = System.Drawing.Color.White
        Me.btn8.Location = New System.Drawing.Point(74, 145)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(65, 65)
        Me.btn8.TabIndex = 31
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn9.FlatAppearance.BorderSize = 0
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn9.Font = New System.Drawing.Font("Calibri", 35.0!, System.Drawing.FontStyle.Bold)
        Me.btn9.ForeColor = System.Drawing.Color.White
        Me.btn9.Location = New System.Drawing.Point(145, 145)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(65, 65)
        Me.btn9.TabIndex = 32
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 478)
        Me.Controls.Add(Me.DATALISTADO_PRODUCTOS_OKA)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnborrarderecha)
        Me.Controls.Add(Me.btnborrartodo)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbltipodebusqueda2)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.MenuStrip4)
        Me.Controls.Add(Me.MenuStrip3)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.MenuStrip9)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AGREGAR_VARIAS_CANTIDADES_DE_PRODUCTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar varias cantidades de Producto"
        Me.MenuStrip4.ResumeLayout(False)
        Me.MenuStrip4.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        CType(Me.DATALISTADO_PRODUCTOS_OKA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip9.ResumeLayout(False)
        Me.MenuStrip9.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.datalistado_stock_detalle_venta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip4 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip3 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbltipodebusqueda2 As System.Windows.Forms.Label
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents DATALISTADO_PRODUCTOS_OKA As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MenuStrip9 As System.Windows.Forms.MenuStrip
    Friend WithEvents BTNLECTORA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbltipodebusqueda As System.Windows.Forms.Label
    Friend WithEvents txtprecio_unitario As System.Windows.Forms.Label
    Friend WithEvents txtidproducto As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents datalistado_stock_detalle_venta As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn8 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents lblcontador_stock_detalle_de_venta As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnborrarderecha As Button
    Friend WithEvents btnborrartodo As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
End Class
