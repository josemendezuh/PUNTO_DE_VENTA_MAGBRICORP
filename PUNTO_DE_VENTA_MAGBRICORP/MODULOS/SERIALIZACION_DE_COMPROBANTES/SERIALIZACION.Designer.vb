<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SERIALIZACION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SERIALIZACION))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcacionManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXTPRESENTACIONRESUMIDA = New System.Windows.Forms.Label()
        Me.txtcantidadporunidadmedida = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcontador = New System.Windows.Forms.Label()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.txtidpresentacion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TXTCOMPRO = New System.Windows.Forms.TextBox()
        Me.txtnumerofin = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.TXTCANTIDADDECEROS = New System.Windows.Forms.TextBox()
        Me.MenuStrip5 = New System.Windows.Forms.MenuStrip()
        Me.GUARDAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.GUARDARCAMBIOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.VOLVEROK = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtmsbox = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.checkDefecto = New System.Windows.Forms.CheckBox()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip5.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(958, 39)
        Me.Label3.TabIndex = 544
        Me.Label3.Text = "SERIALIZACION DE COMPROBANTES"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.ToolStripMenuItem6, Me.MarcacionManualToolStripMenuItem})
        Me.ToolStripMenuItem8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(117, 32)
        Me.ToolStripMenuItem8.Text = "Marcar-Desmarcar"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(173, 22)
        Me.ToolStripMenuItem7.Text = "Marcar Todos"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(173, 22)
        Me.ToolStripMenuItem6.Text = "Desmarcar Todos"
        '
        'MarcacionManualToolStripMenuItem
        '
        Me.MarcacionManualToolStripMenuItem.Name = "MarcacionManualToolStripMenuItem"
        Me.MarcacionManualToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.MarcacionManualToolStripMenuItem.Text = "&Marcacion manual"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.RightToLeftAutoMirrorImage = True
        Me.ActualizarToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ActualizarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(86, 32)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar (F5)"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem8, Me.ActualizarToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(27, 9)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1134, 36)
        Me.MenuStrip2.TabIndex = 367
        Me.MenuStrip2.Text = "MenuStrip5"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(-18, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(246, 20)
        Me.Label10.TabIndex = 336
        Me.Label10.Text = "Describa la unidad de medida"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(11, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(178, 13)
        Me.Label13.TabIndex = 531
        Me.Label13.Text = "Unidad de medida por presentacion:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(-18, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(246, 20)
        Me.Label15.TabIndex = 336
        Me.Label15.Text = "Describa la unidad de medida"
        '
        'TXTPRESENTACIONRESUMIDA
        '
        Me.TXTPRESENTACIONRESUMIDA.AutoSize = True
        Me.TXTPRESENTACIONRESUMIDA.ForeColor = System.Drawing.Color.Black
        Me.TXTPRESENTACIONRESUMIDA.Location = New System.Drawing.Point(11, 63)
        Me.TXTPRESENTACIONRESUMIDA.Name = "TXTPRESENTACIONRESUMIDA"
        Me.TXTPRESENTACIONRESUMIDA.Size = New System.Drawing.Size(178, 13)
        Me.TXTPRESENTACIONRESUMIDA.TabIndex = 531
        Me.TXTPRESENTACIONRESUMIDA.Text = "Unidad de medida por presentacion:"
        '
        'txtcantidadporunidadmedida
        '
        Me.txtcantidadporunidadmedida.BackColor = System.Drawing.Color.White
        Me.txtcantidadporunidadmedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidadporunidadmedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtcantidadporunidadmedida.ForeColor = System.Drawing.Color.Black
        Me.txtcantidadporunidadmedida.Location = New System.Drawing.Point(101, 99)
        Me.txtcantidadporunidadmedida.Name = "txtcantidadporunidadmedida"
        Me.txtcantidadporunidadmedida.Size = New System.Drawing.Size(88, 26)
        Me.txtcantidadporunidadmedida.TabIndex = 328
        Me.txtcantidadporunidadmedida.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(-4, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 342
        Me.Label5.Text = "UND"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(-91, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(238, 20)
        Me.Label6.TabIndex = 342
        Me.Label6.Text = "Cantidad por unidad de medida: "
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(101, 99)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 26)
        Me.TextBox1.TabIndex = 328
        Me.TextBox1.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(69, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(178, 13)
        Me.Label12.TabIndex = 530
        Me.Label12.Text = "Unidad de medida por presentacion:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(69, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 13)
        Me.Label11.TabIndex = 529
        Me.Label11.Text = "Describa la presentaciòn"
        Me.Label11.Visible = False
        '
        'txtcontador
        '
        Me.txtcontador.AutoSize = True
        Me.txtcontador.ForeColor = System.Drawing.Color.Black
        Me.txtcontador.Location = New System.Drawing.Point(69, 106)
        Me.txtcontador.Name = "txtcontador"
        Me.txtcontador.Size = New System.Drawing.Size(178, 13)
        Me.txtcontador.TabIndex = 530
        Me.txtcontador.Text = "Unidad de medida por presentacion:"
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'txtidpresentacion
        '
        Me.txtidpresentacion.AutoSize = True
        Me.txtidpresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidpresentacion.ForeColor = System.Drawing.Color.Black
        Me.txtidpresentacion.Location = New System.Drawing.Point(69, 93)
        Me.txtidpresentacion.Name = "txtidpresentacion"
        Me.txtidpresentacion.Size = New System.Drawing.Size(148, 13)
        Me.txtidpresentacion.TabIndex = 529
        Me.txtidpresentacion.Text = "Describa la presentaciòn"
        Me.txtidpresentacion.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 175)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 359
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.checkDefecto)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.txtnumerofin)
        Me.Panel2.Controls.Add(Me.txtSerie)
        Me.Panel2.Controls.Add(Me.TXTCANTIDADDECEROS)
        Me.Panel2.Controls.Add(Me.MenuStrip5)
        Me.Panel2.Controls.Add(Me.btnvolver)
        Me.Panel2.Controls.Add(Me.TabControl3)
        Me.Panel2.Controls.Add(Me.txtmsbox)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(958, 548)
        Me.Panel2.TabIndex = 360
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel3.Controls.Add(Me.TXTCOMPRO)
        Me.Panel3.Location = New System.Drawing.Point(259, 112)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(209, 36)
        Me.Panel3.TabIndex = 620
        '
        'TXTCOMPRO
        '
        Me.TXTCOMPRO.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TXTCOMPRO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTCOMPRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TXTCOMPRO.ForeColor = System.Drawing.Color.White
        Me.TXTCOMPRO.Location = New System.Drawing.Point(-1, 10)
        Me.TXTCOMPRO.Name = "TXTCOMPRO"
        Me.TXTCOMPRO.Size = New System.Drawing.Size(210, 16)
        Me.TXTCOMPRO.TabIndex = 615
        Me.TXTCOMPRO.Text = "FACTURA"
        Me.TXTCOMPRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnumerofin
        '
        Me.txtnumerofin.BackColor = System.Drawing.Color.White
        Me.txtnumerofin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumerofin.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.txtnumerofin.ForeColor = System.Drawing.Color.Black
        Me.txtnumerofin.Location = New System.Drawing.Point(537, 149)
        Me.txtnumerofin.Name = "txtnumerofin"
        Me.txtnumerofin.Size = New System.Drawing.Size(182, 35)
        Me.txtnumerofin.TabIndex = 616
        Me.txtnumerofin.Text = "0"
        Me.txtnumerofin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSerie
        '
        Me.txtSerie.BackColor = System.Drawing.Color.White
        Me.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.txtSerie.ForeColor = System.Drawing.Color.Black
        Me.txtSerie.Location = New System.Drawing.Point(537, 220)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(182, 35)
        Me.txtSerie.TabIndex = 618
        Me.txtSerie.Text = "0"
        Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTCANTIDADDECEROS
        '
        Me.TXTCANTIDADDECEROS.BackColor = System.Drawing.Color.White
        Me.TXTCANTIDADDECEROS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTCANTIDADDECEROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.TXTCANTIDADDECEROS.ForeColor = System.Drawing.Color.Black
        Me.TXTCANTIDADDECEROS.Location = New System.Drawing.Point(549, 83)
        Me.TXTCANTIDADDECEROS.Name = "TXTCANTIDADDECEROS"
        Me.TXTCANTIDADDECEROS.Size = New System.Drawing.Size(170, 35)
        Me.TXTCANTIDADDECEROS.TabIndex = 618
        Me.TXTCANTIDADDECEROS.Text = "0"
        Me.TXTCANTIDADDECEROS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuStrip5
        '
        Me.MenuStrip5.AutoSize = False
        Me.MenuStrip5.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip5.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GUARDAR, Me.GUARDARCAMBIOS, Me.VOLVEROK})
        Me.MenuStrip5.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip5.Location = New System.Drawing.Point(537, 275)
        Me.MenuStrip5.Name = "MenuStrip5"
        Me.MenuStrip5.ShowItemToolTips = True
        Me.MenuStrip5.Size = New System.Drawing.Size(411, 51)
        Me.MenuStrip5.TabIndex = 532
        Me.MenuStrip5.Text = "MenuStrip5"
        '
        'GUARDAR
        '
        Me.GUARDAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GUARDAR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GUARDAR.ForeColor = System.Drawing.Color.Black
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(83, 47)
        Me.GUARDAR.Text = "&Guardar"
        Me.GUARDAR.ToolTipText = "Guardar "
        '
        'GUARDARCAMBIOS
        '
        Me.GUARDARCAMBIOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GUARDARCAMBIOS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GUARDARCAMBIOS.ForeColor = System.Drawing.Color.Black
        Me.GUARDARCAMBIOS.Name = "GUARDARCAMBIOS"
        Me.GUARDARCAMBIOS.Size = New System.Drawing.Size(153, 47)
        Me.GUARDARCAMBIOS.Text = "&Guardar Cambios"
        '
        'VOLVEROK
        '
        Me.VOLVEROK.BackColor = System.Drawing.Color.Gray
        Me.VOLVEROK.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.VOLVEROK.ForeColor = System.Drawing.Color.White
        Me.VOLVEROK.Name = "VOLVEROK"
        Me.VOLVEROK.Size = New System.Drawing.Size(82, 47)
        Me.VOLVEROK.Text = "VOLVER"
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnvolver.ForeColor = System.Drawing.Color.White
        Me.btnvolver.Location = New System.Drawing.Point(52, 602)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(309, 39)
        Me.btnvolver.TabIndex = 562
        Me.btnvolver.Text = "Volver {}"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage5)
        Me.TabControl3.Controls.Add(Me.TabPage6)
        Me.TabControl3.Location = New System.Drawing.Point(132, 773)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(396, 95)
        Me.TabControl3.TabIndex = 350
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(388, 69)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Registro sanitario de Ingreso"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 13)
        Me.Label4.TabIndex = 341
        Me.Label4.Text = "Registro sanitario de Ingreso:"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.PictureBox4)
        Me.TabPage6.Controls.Add(Me.Label17)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(388, 69)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Ficha tecnica"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(92, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(79, 57)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 346
        Me.PictureBox4.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(7, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 13)
        Me.Label17.TabIndex = 340
        Me.Label17.Text = "Ficha tecnica:"
        '
        'txtmsbox
        '
        Me.txtmsbox.BackColor = System.Drawing.Color.Transparent
        Me.txtmsbox.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmsbox.ForeColor = System.Drawing.Color.White
        Me.txtmsbox.Location = New System.Drawing.Point(51, 522)
        Me.txtmsbox.Name = "txtmsbox"
        Me.txtmsbox.Size = New System.Drawing.Size(332, 24)
        Me.txtmsbox.TabIndex = 381
        Me.txtmsbox.Text = "Listo"
        Me.txtmsbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-228, -44)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1361, 752)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 619
        Me.PictureBox3.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel14)
        Me.Panel1.Controls.Add(Me.datalistado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(958, 529)
        Me.Panel1.TabIndex = 545
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.White
        Me.Panel14.Controls.Add(Me.PictureBox1)
        Me.Panel14.Controls.Add(Me.PictureBox2)
        Me.Panel14.Controls.Add(Me.Panel4)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel14.Location = New System.Drawing.Point(844, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(114, 529)
        Me.Panel14.TabIndex = 535
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 268)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(114, 90)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 359
        Me.PictureBox2.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.MenuStrip2)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.TXTPRESENTACIONRESUMIDA)
        Me.Panel4.Controls.Add(Me.txtcantidadporunidadmedida)
        Me.Panel4.Controls.Add(Me.txtidpresentacion)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.txtcontador)
        Me.Panel4.Location = New System.Drawing.Point(101, 153)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 10)
        Me.Panel4.TabIndex = 535
        Me.Panel4.Visible = False
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.AllowUserToOrderColumns = True
        Me.datalistado.BackgroundColor = System.Drawing.Color.White
        Me.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datalistado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado.DefaultCellStyle = DataGridViewCellStyle5
        Me.datalistado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datalistado.EnableHeadersVisualStyles = False
        Me.datalistado.GridColor = System.Drawing.Color.LightGray
        Me.datalistado.Location = New System.Drawing.Point(0, 0)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.datalistado.RowHeadersVisible = False
        Me.datalistado.RowHeadersWidth = 5
        Me.datalistado.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datalistado.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.datalistado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray
        Me.datalistado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datalistado.RowTemplate.Height = 60
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(958, 529)
        Me.datalistado.TabIndex = 366
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Visible = False
        '
        'checkDefecto
        '
        Me.checkDefecto.AutoSize = True
        Me.checkDefecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkDefecto.Location = New System.Drawing.Point(549, 341)
        Me.checkDefecto.Name = "checkDefecto"
        Me.checkDefecto.Size = New System.Drawing.Size(219, 28)
        Me.checkDefecto.TabIndex = 621
        Me.checkDefecto.Text = "Elejir Por DEFECTO"
        Me.checkDefecto.UseVisualStyleBackColor = True
        '
        'SERIALIZACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 568)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SERIALIZACION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MenuStrip5.ResumeLayout(False)
        Me.MenuStrip5.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents MarcacionManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TXTPRESENTACIONRESUMIDA As Label
    Friend WithEvents txtcantidadporunidadmedida As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtcontador As Label
    Friend WithEvents dlg As OpenFileDialog
    Friend WithEvents txtidpresentacion As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TXTCOMPRO As TextBox
    Friend WithEvents txtnumerofin As TextBox
    Friend WithEvents TXTCANTIDADDECEROS As TextBox
    Friend WithEvents MenuStrip5 As MenuStrip
    Friend WithEvents GUARDAR As ToolStripMenuItem
    Friend WithEvents GUARDARCAMBIOS As ToolStripMenuItem
    Friend WithEvents VOLVEROK As ToolStripMenuItem
    Friend WithEvents btnvolver As Button
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtmsbox As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Panel14 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents checkDefecto As CheckBox
End Class
