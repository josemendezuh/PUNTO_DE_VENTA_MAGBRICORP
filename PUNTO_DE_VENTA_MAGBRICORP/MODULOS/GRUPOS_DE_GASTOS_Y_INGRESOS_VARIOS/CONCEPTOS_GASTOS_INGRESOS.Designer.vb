<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONCEPTOS_GASTOS_INGRESOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CONCEPTOS_GASTOS_INGRESOS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtbancoseleccionado = New System.Windows.Forms.Label()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Finalizar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.NuevoRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINAROKA = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.Button()
        Me.GuardarRegistroToolStripMenuItem = New System.Windows.Forms.Button()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtindicador = New System.Windows.Forms.Label()
        Me.txtidconcepto = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.TXTACCION = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip5 = New System.Windows.Forms.MenuStrip()
        Me.BToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Buscarporgirado = New System.Windows.Forms.ToolStripMenuItem()
        Me.Buscarportipo = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPorCodigoDeBarrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Finalizar.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.MenuStrip5.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripMenuItem1.Text = "&Canjear"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BackColor = System.Drawing.Color.White
        Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtdescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtdescripcion.ForeColor = System.Drawing.Color.Black
        Me.txtdescripcion.Location = New System.Drawing.Point(39, 89)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(376, 19)
        Me.txtdescripcion.TabIndex = 2
        '
        'txtbancoseleccionado
        '
        Me.txtbancoseleccionado.AutoSize = True
        Me.txtbancoseleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtbancoseleccionado.ForeColor = System.Drawing.Color.Black
        Me.txtbancoseleccionado.Location = New System.Drawing.Point(35, 66)
        Me.txtbancoseleccionado.Name = "txtbancoseleccionado"
        Me.txtbancoseleccionado.Size = New System.Drawing.Size(82, 20)
        Me.txtbancoseleccionado.TabIndex = 342
        Me.txtbancoseleccionado.Text = "Concepto:"
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
        Me.TabPage5.Controls.Add(Me.Label3)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(388, 66)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Registro sanitario de Ingreso"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 17)
        Me.Label3.TabIndex = 341
        Me.Label3.Text = "Registro sanitario de Ingreso:"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.PictureBox4)
        Me.TabPage6.Controls.Add(Me.Label5)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(388, 66)
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 17)
        Me.Label5.TabIndex = 340
        Me.Label5.Text = "Ficha tecnica:"
        '
        'Finalizar
        '
        Me.Finalizar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.Finalizar.Name = "Finalizar"
        Me.Finalizar.Size = New System.Drawing.Size(115, 26)
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(54, 405)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(332, 24)
        Me.Label6.TabIndex = 381
        Me.Label6.Text = "Listo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Location = New System.Drawing.Point(484, 33)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(121, 21)
        Me.cbocampo.TabIndex = 410
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoRegistroToolStripMenuItem, Me.ELIMINAROKA})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(903, 36)
        Me.MenuStrip2.TabIndex = 416
        Me.MenuStrip2.Text = "MenuStrip5"
        '
        'NuevoRegistroToolStripMenuItem
        '
        Me.NuevoRegistroToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.NuevoRegistroToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NuevoRegistroToolStripMenuItem.Name = "NuevoRegistroToolStripMenuItem"
        Me.NuevoRegistroToolStripMenuItem.Size = New System.Drawing.Size(153, 32)
        Me.NuevoRegistroToolStripMenuItem.Text = "Nuevo Concepto"
        '
        'ELIMINAROKA
        '
        Me.ELIMINAROKA.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ELIMINAROKA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ELIMINAROKA.ForeColor = System.Drawing.Color.White
        Me.ELIMINAROKA.Name = "ELIMINAROKA"
        Me.ELIMINAROKA.Size = New System.Drawing.Size(77, 32)
        Me.ELIMINAROKA.Text = "Eliminar"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 398)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(903, 36)
        Me.Panel3.TabIndex = 461
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.MenuStrip2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(903, 36)
        Me.Panel6.TabIndex = 218
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(11, 225)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 17)
        Me.Label10.TabIndex = 342
        Me.Label10.Visible = False
        '
        'txtidventa
        '
        Me.txtidventa.Location = New System.Drawing.Point(486, 74)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(155, 20)
        Me.txtidventa.TabIndex = 411
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(903, 493)
        Me.Panel4.TabIndex = 463
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.cbocampo)
        Me.Panel1.Controls.Add(Me.txtidventa)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(903, 493)
        Me.Panel1.TabIndex = 446
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.datalistado)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(903, 434)
        Me.Panel2.TabIndex = 412
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.Panel7)
        Me.Panel8.Controls.Add(Me.TabControl3)
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(936, 434)
        Me.Panel8.TabIndex = 410
        '
        'Panel7
        '
        Me.Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), System.Drawing.Image)
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Controls.Add(Me.ModificarToolStripMenuItem)
        Me.Panel7.Controls.Add(Me.GuardarRegistroToolStripMenuItem)
        Me.Panel7.Controls.Add(Me.txtdescripcion)
        Me.Panel7.Controls.Add(Me.txtbancoseleccionado)
        Me.Panel7.Location = New System.Drawing.Point(187, 8)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(466, 372)
        Me.Panel7.TabIndex = 461
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.LightGray
        Me.Panel10.Location = New System.Drawing.Point(40, 109)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(376, 2)
        Me.Panel10.TabIndex = 534
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.ModificarToolStripMenuItem.FlatAppearance.BorderSize = 0
        Me.ModificarToolStripMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModificarToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificarToolStripMenuItem.Location = New System.Drawing.Point(234, 162)
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(181, 33)
        Me.ModificarToolStripMenuItem.TabIndex = 461
        Me.ModificarToolStripMenuItem.Text = "Guardar Cambios"
        Me.ModificarToolStripMenuItem.UseVisualStyleBackColor = False
        '
        'GuardarRegistroToolStripMenuItem
        '
        Me.GuardarRegistroToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.GuardarRegistroToolStripMenuItem.FlatAppearance.BorderSize = 0
        Me.GuardarRegistroToolStripMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GuardarRegistroToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardarRegistroToolStripMenuItem.Location = New System.Drawing.Point(37, 162)
        Me.GuardarRegistroToolStripMenuItem.Name = "GuardarRegistroToolStripMenuItem"
        Me.GuardarRegistroToolStripMenuItem.Size = New System.Drawing.Size(181, 33)
        Me.GuardarRegistroToolStripMenuItem.TabIndex = 461
        Me.GuardarRegistroToolStripMenuItem.Text = "Guardar"
        Me.GuardarRegistroToolStripMenuItem.UseVisualStyleBackColor = False
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.BackgroundColor = System.Drawing.Color.White
        Me.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado.DefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datalistado.EnableHeadersVisualStyles = False
        Me.datalistado.Location = New System.Drawing.Point(0, 0)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado.RowHeadersVisible = False
        Me.datalistado.RowHeadersWidth = 9
        Me.datalistado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.datalistado.RowTemplate.Height = 40
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(903, 398)
        Me.datalistado.TabIndex = 409
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Controls.Add(Me.Button4)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.MenuStrip5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(903, 59)
        Me.Panel5.TabIndex = 217
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.txtindicador)
        Me.Panel9.Controls.Add(Me.txtidconcepto)
        Me.Panel9.Controls.Add(Me.btncerrar)
        Me.Panel9.Controls.Add(Me.TXTACCION)
        Me.Panel9.Location = New System.Drawing.Point(58, 16)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(10, 10)
        Me.Panel9.TabIndex = 462
        '
        'txtindicador
        '
        Me.txtindicador.AutoSize = True
        Me.txtindicador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtindicador.ForeColor = System.Drawing.Color.Red
        Me.txtindicador.Location = New System.Drawing.Point(20, 48)
        Me.txtindicador.Name = "txtindicador"
        Me.txtindicador.Size = New System.Drawing.Size(63, 17)
        Me.txtindicador.TabIndex = 457
        Me.txtindicador.Text = "Moneda:"
        '
        'txtidconcepto
        '
        Me.txtidconcepto.AutoSize = True
        Me.txtidconcepto.Enabled = False
        Me.txtidconcepto.ForeColor = System.Drawing.Color.Black
        Me.txtidconcepto.Location = New System.Drawing.Point(20, 48)
        Me.txtidconcepto.Name = "txtidconcepto"
        Me.txtidconcepto.Size = New System.Drawing.Size(66, 13)
        Me.txtidconcepto.TabIndex = 342
        Me.txtidconcepto.Text = "Descripción:"
        Me.txtidconcepto.Visible = False
        '
        'btncerrar
        '
        Me.btncerrar.BackColor = System.Drawing.Color.White
        Me.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!)
        Me.btncerrar.Location = New System.Drawing.Point(21, 51)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(223, 51)
        Me.btncerrar.TabIndex = 389
        Me.btncerrar.Text = "VOLVER"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'TXTACCION
        '
        Me.TXTACCION.AutoSize = True
        Me.TXTACCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TXTACCION.ForeColor = System.Drawing.Color.Black
        Me.TXTACCION.Location = New System.Drawing.Point(3, 25)
        Me.TXTACCION.Name = "TXTACCION"
        Me.TXTACCION.Size = New System.Drawing.Size(108, 20)
        Me.TXTACCION.TabIndex = 342
        Me.TXTACCION.Text = "TXTACCION"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(850, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 41)
        Me.Button4.TabIndex = 527
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(903, 59)
        Me.Label4.TabIndex = 217
        Me.Label4.Text = "CONCEPTOS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip5
        '
        Me.MenuStrip5.AutoSize = False
        Me.MenuStrip5.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip5.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BToolStripMenuItem})
        Me.MenuStrip5.Location = New System.Drawing.Point(210, 2)
        Me.MenuStrip5.Name = "MenuStrip5"
        Me.MenuStrip5.Size = New System.Drawing.Size(40, 24)
        Me.MenuStrip5.TabIndex = 214
        Me.MenuStrip5.Text = "MenuStrip3"
        '
        'BToolStripMenuItem
        '
        Me.BToolStripMenuItem.AutoSize = False
        Me.BToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Buscarporgirado, Me.Buscarportipo, Me.BuscarPorCodigoDeBarrasToolStripMenuItem})
        Me.BToolStripMenuItem.Name = "BToolStripMenuItem"
        Me.BToolStripMenuItem.Size = New System.Drawing.Size(28, 20)
        Me.BToolStripMenuItem.Text = "B"
        '
        'Buscarporgirado
        '
        Me.Buscarporgirado.Name = "Buscarporgirado"
        Me.Buscarporgirado.Size = New System.Drawing.Size(223, 22)
        Me.Buscarporgirado.Text = "&Buscar por descripción"
        '
        'Buscarportipo
        '
        Me.Buscarportipo.Name = "Buscarportipo"
        Me.Buscarportipo.Size = New System.Drawing.Size(223, 22)
        Me.Buscarportipo.Text = "&Buscar por Código interno"
        '
        'BuscarPorCodigoDeBarrasToolStripMenuItem
        '
        Me.BuscarPorCodigoDeBarrasToolStripMenuItem.Name = "BuscarPorCodigoDeBarrasToolStripMenuItem"
        Me.BuscarPorCodigoDeBarrasToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.BuscarPorCodigoDeBarrasToolStripMenuItem.Text = "&Buscar por Código de barras"
        '
        'CONCEPTOS_GASTOS_INGRESOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 493)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CONCEPTOS_GASTOS_INGRESOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONCEPTOS"
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Finalizar.ResumeLayout(False)
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.MenuStrip5.ResumeLayout(False)
        Me.MenuStrip5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NuevoRegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtbancoseleccionado As System.Windows.Forms.Label
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Finalizar As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbocampo As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ELIMINAROKA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtidventa As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtidconcepto As System.Windows.Forms.Label
    Friend WithEvents txtindicador As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip5 As System.Windows.Forms.MenuStrip
    Friend WithEvents BToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Buscarporgirado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Buscarportipo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarPorCodigoDeBarrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents GuardarRegistroToolStripMenuItem As System.Windows.Forms.Button
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents TXTACCION As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
End Class
