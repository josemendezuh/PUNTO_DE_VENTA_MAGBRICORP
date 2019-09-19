<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cierre_de_turno
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cierre_de_turno))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txthay = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.LBLDeberiaHaber = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblanuncio = New System.Windows.Forms.Label()
        Me.txtfechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.lbldiferencia = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TextBoxDESTINO = New System.Windows.Forms.TextBox()
        Me.TXTENVIOS_A_CORREOS = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.datalistado_correo_base = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.lblEstado_de_envio = New System.Windows.Forms.Label()
        Me.LabelRegistros_de_correo_base = New System.Windows.Forms.Label()
        Me.lblcondicional_de_envio = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.MenuStrip4 = New System.Windows.Forms.MenuStrip()
        Me.btneditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnguardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btncancelar = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblcontraseñabase = New System.Windows.Forms.Label()
        Me.lblestadobase = New System.Windows.Forms.Label()
        Me.lblcorreobase = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel12.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.datalistado_correo_base, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(108, 235)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(199, 20)
        Me.Label6.TabIndex = 193
        Me.Label6.Text = "Efectivo esperado en Caja:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(81, 302)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 20)
        Me.Label1.TabIndex = 193
        Me.Label1.Text = "¿Cuanto de Efectivo hay en Caja?"
        '
        'txthay
        '
        Me.txthay.BackColor = System.Drawing.Color.White
        Me.txthay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txthay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txthay.Location = New System.Drawing.Point(137, 330)
        Me.txthay.Name = "txthay"
        Me.txthay.Size = New System.Drawing.Size(137, 19)
        Me.txthay.TabIndex = 194
        Me.txthay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(24, 466)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(353, 39)
        Me.Label11.TabIndex = 352
        Me.Label11.Text = "Cerrar Turno"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.Controls.Add(Me.Button1)
        Me.Panel12.Controls.Add(Me.Button5)
        Me.Panel12.Controls.Add(Me.Label46)
        Me.Panel12.Location = New System.Drawing.Point(0, 3)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(429, 37)
        Me.Panel12.TabIndex = 599
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(379, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 37)
        Me.Button1.TabIndex = 598
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(966, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(31, 35)
        Me.Button5.TabIndex = 597
        Me.Button5.Text = "X"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(12, 9)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(159, 24)
        Me.Label46.TabIndex = 596
        Me.Label46.Text = "Cierre de Turno"
        '
        'LBLDeberiaHaber
        '
        Me.LBLDeberiaHaber.AutoSize = True
        Me.LBLDeberiaHaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LBLDeberiaHaber.ForeColor = System.Drawing.Color.Black
        Me.LBLDeberiaHaber.Location = New System.Drawing.Point(186, 266)
        Me.LBLDeberiaHaber.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LBLDeberiaHaber.Name = "LBLDeberiaHaber"
        Me.LBLDeberiaHaber.Size = New System.Drawing.Size(39, 20)
        Me.LBLDeberiaHaber.TabIndex = 193
        Me.LBLDeberiaHaber.Text = "345"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(411, 178)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 599
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Location = New System.Drawing.Point(137, 355)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(137, 2)
        Me.Panel1.TabIndex = 600
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(23, 510)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(43, 47)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 602
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'lblanuncio
        '
        Me.lblanuncio.BackColor = System.Drawing.Color.White
        Me.lblanuncio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblanuncio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.lblanuncio.Location = New System.Drawing.Point(76, 510)
        Me.lblanuncio.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblanuncio.Name = "lblanuncio"
        Me.lblanuncio.Size = New System.Drawing.Size(301, 47)
        Me.lblanuncio.TabIndex = 601
        Me.lblanuncio.Text = "Usuario:"
        Me.lblanuncio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblanuncio.Visible = False
        '
        'txtfechaFinal
        '
        Me.txtfechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtfechaFinal.Location = New System.Drawing.Point(16, 177)
        Me.txtfechaFinal.Name = "txtfechaFinal"
        Me.txtfechaFinal.Size = New System.Drawing.Size(74, 20)
        Me.txtfechaFinal.TabIndex = 604
        '
        'lbldiferencia
        '
        Me.lbldiferencia.AutoSize = True
        Me.lbldiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbldiferencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.lbldiferencia.Location = New System.Drawing.Point(186, 374)
        Me.lbldiferencia.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbldiferencia.Name = "lbldiferencia"
        Me.lbldiferencia.Size = New System.Drawing.Size(29, 20)
        Me.lbldiferencia.TabIndex = 193
        Me.lbldiferencia.Text = "45"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.AcceptsTab = True
        Me.RichTextBox1.AutoWordSelection = True
        Me.RichTextBox1.EnableAutoDragDrop = True
        Me.RichTextBox1.Location = New System.Drawing.Point(502, 355)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(274, 109)
        Me.RichTextBox1.TabIndex = 605
        Me.RichTextBox1.Text = ""
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(502, 235)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 609
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TextBoxDESTINO
        '
        Me.TextBoxDESTINO.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBoxDESTINO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDESTINO.Location = New System.Drawing.Point(473, 390)
        Me.TextBoxDESTINO.Name = "TextBoxDESTINO"
        Me.TextBoxDESTINO.Size = New System.Drawing.Size(331, 20)
        Me.TextBoxDESTINO.TabIndex = 608
        Me.TextBoxDESTINO.Text = "cursosmajestuosos@gmail.com"
        Me.TextBoxDESTINO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTENVIOS_A_CORREOS
        '
        Me.TXTENVIOS_A_CORREOS.AutoSize = True
        Me.TXTENVIOS_A_CORREOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TXTENVIOS_A_CORREOS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXTENVIOS_A_CORREOS.Location = New System.Drawing.Point(23, 431)
        Me.TXTENVIOS_A_CORREOS.Name = "TXTENVIOS_A_CORREOS"
        Me.TXTENVIOS_A_CORREOS.Size = New System.Drawing.Size(115, 21)
        Me.TXTENVIOS_A_CORREOS.TabIndex = 610
        Me.TXTENVIOS_A_CORREOS.Text = "Se enviara a: "
        Me.TXTENVIOS_A_CORREOS.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ProgressBar1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(23, 235)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(108, 160)
        Me.Panel2.TabIndex = 611
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(106, 5)
        Me.ProgressBar1.TabIndex = 612
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 158)
        Me.Label3.TabIndex = 600
        Me.Label3.Text = "Enviando Reporte a "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'datalistado_correo_base
        '
        Me.datalistado_correo_base.AllowUserToAddRows = False
        Me.datalistado_correo_base.AllowUserToDeleteRows = False
        Me.datalistado_correo_base.AllowUserToResizeRows = False
        Me.datalistado_correo_base.BackgroundColor = System.Drawing.Color.White
        Me.datalistado_correo_base.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_correo_base.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado_correo_base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado_correo_base.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn8})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado_correo_base.DefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado_correo_base.Location = New System.Drawing.Point(51, 16)
        Me.datalistado_correo_base.Name = "datalistado_correo_base"
        Me.datalistado_correo_base.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_correo_base.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado_correo_base.RowHeadersVisible = False
        Me.datalistado_correo_base.RowHeadersWidth = 5
        Me.datalistado_correo_base.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.ForestGreen
        Me.datalistado_correo_base.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado_correo_base.Size = New System.Drawing.Size(88, 75)
        Me.datalistado_correo_base.TabIndex = 613
        '
        'DataGridViewCheckBoxColumn8
        '
        Me.DataGridViewCheckBoxColumn8.DataPropertyName = "Activo"
        Me.DataGridViewCheckBoxColumn8.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn8.Name = "DataGridViewCheckBoxColumn8"
        Me.DataGridViewCheckBoxColumn8.ReadOnly = True
        '
        'lblEstado_de_envio
        '
        Me.lblEstado_de_envio.AutoSize = True
        Me.lblEstado_de_envio.Location = New System.Drawing.Point(48, 8)
        Me.lblEstado_de_envio.Name = "lblEstado_de_envio"
        Me.lblEstado_de_envio.Size = New System.Drawing.Size(39, 13)
        Me.lblEstado_de_envio.TabIndex = 616
        Me.lblEstado_de_envio.Text = "Label9"
        '
        'LabelRegistros_de_correo_base
        '
        Me.LabelRegistros_de_correo_base.AutoSize = True
        Me.LabelRegistros_de_correo_base.Location = New System.Drawing.Point(57, 47)
        Me.LabelRegistros_de_correo_base.Name = "LabelRegistros_de_correo_base"
        Me.LabelRegistros_de_correo_base.Size = New System.Drawing.Size(39, 13)
        Me.LabelRegistros_de_correo_base.TabIndex = 617
        Me.LabelRegistros_de_correo_base.Text = "Label8"
        '
        'lblcondicional_de_envio
        '
        Me.lblcondicional_de_envio.AutoSize = True
        Me.lblcondicional_de_envio.Location = New System.Drawing.Point(3, 16)
        Me.lblcondicional_de_envio.Name = "lblcondicional_de_envio"
        Me.lblcondicional_de_envio.Size = New System.Drawing.Size(39, 13)
        Me.lblcondicional_de_envio.TabIndex = 616
        Me.lblcondicional_de_envio.Text = "Label9"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblcondicional_de_envio)
        Me.Panel3.Controls.Add(Me.lblEstado_de_envio)
        Me.Panel3.Controls.Add(Me.datalistado_correo_base)
        Me.Panel3.Controls.Add(Me.LabelRegistros_de_correo_base)
        Me.Panel3.Location = New System.Drawing.Point(467, 190)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(274, 132)
        Me.Panel3.TabIndex = 618
        '
        'lblcorreo
        '
        Me.lblcorreo.AutoSize = True
        Me.lblcorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblcorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.lblcorreo.Location = New System.Drawing.Point(136, 430)
        Me.lblcorreo.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(60, 20)
        Me.lblcorreo.TabIndex = 193
        Me.lblcorreo.Text = "correo"
        '
        'MenuStrip4
        '
        Me.MenuStrip4.AutoSize = False
        Me.MenuStrip4.BackColor = System.Drawing.Color.White
        Me.MenuStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btneditar, Me.btnguardar, Me.btncancelar})
        Me.MenuStrip4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip4.Location = New System.Drawing.Point(0, 398)
        Me.MenuStrip4.Name = "MenuStrip4"
        Me.MenuStrip4.ShowItemToolTips = True
        Me.MenuStrip4.Size = New System.Drawing.Size(411, 32)
        Me.MenuStrip4.TabIndex = 621
        Me.MenuStrip4.Text = "MenuStrip4"
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.Transparent
        Me.btneditar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btneditar.ForeColor = System.Drawing.Color.Black
        Me.btneditar.Image = CType(resources.GetObject("btneditar.Image"), System.Drawing.Image)
        Me.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(125, 28)
        Me.btneditar.Text = "Editar correo"
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.Transparent
        Me.btnguardar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnguardar.ForeColor = System.Drawing.Color.Black
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(136, 28)
        Me.btnguardar.Text = "Guardar cambios"
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.Transparent
        Me.btncancelar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btncancelar.ForeColor = System.Drawing.Color.Crimson
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(79, 28)
        Me.btncancelar.Text = "Cancelar"
        '
        'txtcorreo
        '
        Me.txtcorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtcorreo.Location = New System.Drawing.Point(137, 433)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(277, 19)
        Me.txtcorreo.TabIndex = 194
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.LightGray
        Me.Panel8.Location = New System.Drawing.Point(140, 458)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(274, 2)
        Me.Panel8.TabIndex = 600
        '
        'lblcontraseñabase
        '
        Me.lblcontraseñabase.AutoSize = True
        Me.lblcontraseñabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblcontraseñabase.ForeColor = System.Drawing.Color.Black
        Me.lblcontraseñabase.Location = New System.Drawing.Point(6, 73)
        Me.lblcontraseñabase.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblcontraseñabase.Name = "lblcontraseñabase"
        Me.lblcontraseñabase.Size = New System.Drawing.Size(18, 20)
        Me.lblcontraseñabase.TabIndex = 193
        Me.lblcontraseñabase.Text = "1"
        '
        'lblestadobase
        '
        Me.lblestadobase.AutoSize = True
        Me.lblestadobase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblestadobase.ForeColor = System.Drawing.Color.Black
        Me.lblestadobase.Location = New System.Drawing.Point(6, 117)
        Me.lblestadobase.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblestadobase.Name = "lblestadobase"
        Me.lblestadobase.Size = New System.Drawing.Size(18, 20)
        Me.lblestadobase.TabIndex = 193
        Me.lblestadobase.Text = "1"
        '
        'lblcorreobase
        '
        Me.lblcorreobase.AutoSize = True
        Me.lblcorreobase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblcorreobase.ForeColor = System.Drawing.Color.Black
        Me.lblcorreobase.Location = New System.Drawing.Point(6, 24)
        Me.lblcorreobase.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblcorreobase.Name = "lblcorreobase"
        Me.lblcorreobase.Size = New System.Drawing.Size(18, 20)
        Me.lblcorreobase.TabIndex = 193
        Me.lblcorreobase.Text = "1"
        '
        'Timer2
        '
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblcorreobase)
        Me.Panel4.Controls.Add(Me.lblcontraseñabase)
        Me.Panel4.Controls.Add(Me.lblestadobase)
        Me.Panel4.Location = New System.Drawing.Point(379, 281)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 10)
        Me.Panel4.TabIndex = 622
        '
        'Cierre_de_turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(438, 583)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.lblcorreo)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.MenuStrip4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TextBoxDESTINO)
        Me.Controls.Add(Me.TXTENVIOS_A_CORREOS)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.lblanuncio)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txthay)
        Me.Controls.Add(Me.lbldiferencia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBLDeberiaHaber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtfechaFinal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cierre_de_turno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cierre_de_turno"
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.datalistado_correo_base, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MenuStrip4.ResumeLayout(False)
        Me.MenuStrip4.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txthay As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LBLDeberiaHaber As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents lblanuncio As System.Windows.Forms.Label
    Friend WithEvents txtfechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldiferencia As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents TextBoxDESTINO As TextBox
    Friend WithEvents TXTENVIOS_A_CORREOS As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Public WithEvents datalistado_correo_base As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn8 As DataGridViewCheckBoxColumn
    Friend WithEvents lblEstado_de_envio As Label
    Friend WithEvents LabelRegistros_de_correo_base As Label
    Friend WithEvents lblcondicional_de_envio As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblcorreo As Label
    Friend WithEvents MenuStrip4 As MenuStrip
    Friend WithEvents btnguardar As ToolStripMenuItem
    Friend WithEvents btneditar As ToolStripMenuItem
    Friend WithEvents btncancelar As ToolStripMenuItem
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblcontraseñabase As Label
    Friend WithEvents lblestadobase As Label
    Friend WithEvents lblcorreobase As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Panel4 As Panel
End Class
