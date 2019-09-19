<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ASISTENCIAS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ASISTENCIAS))
        Me.TXTNOMBRE = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txthoras = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.datalistadohorastotales = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.datalistadoacumuladohorASDIA = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.datalistadohoras = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.datalistadoasistencia = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TXTIDPERSONAL = New System.Windows.Forms.Label()
        Me.txtclientesolicitabnte = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtaviso = New System.Windows.Forms.Label()
        Me.Panelhoras = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txthorasdia = New System.Windows.Forms.Label()
        Me.lblhora2 = New System.Windows.Forms.Label()
        Me.TXTFECHA = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel7 = New System.Windows.Forms.Panel()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.datalistadohorastotales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datalistadoacumuladohorASDIA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datalistadohoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datalistadoasistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelhoras.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.AutoSize = True
        Me.TXTNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOMBRE.ForeColor = System.Drawing.Color.Teal
        Me.TXTNOMBRE.Location = New System.Drawing.Point(142, 332)
        Me.TXTNOMBRE.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(27, 20)
        Me.TXTNOMBRE.TabIndex = 338
        Me.TXTNOMBRE.Text = "***"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 26)
        Me.Label1.TabIndex = 338
        Me.Label1.Text = "Horas acumuladas ultimo ingreso:"
        '
        'txthoras
        '
        Me.txthoras.AutoSize = True
        Me.txthoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txthoras.ForeColor = System.Drawing.Color.White
        Me.txthoras.Location = New System.Drawing.Point(351, 13)
        Me.txthoras.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.txthoras.Name = "txthoras"
        Me.txthoras.Size = New System.Drawing.Size(24, 26)
        Me.txthoras.TabIndex = 338
        Me.txthoras.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(107, 302)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 20)
        Me.Label5.TabIndex = 338
        Me.Label5.Text = "DNI:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(7, 17)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 13)
        Me.Label6.TabIndex = 338
        Me.Label6.Text = "SALIDA NO MARCADA"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.BackgroundColor = System.Drawing.Color.White
        Me.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.datalistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
        Me.datalistado.EnableHeadersVisualStyles = False
        Me.datalistado.Location = New System.Drawing.Point(24, 34)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.RowHeadersVisible = False
        Me.datalistado.RowHeadersWidth = 5
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(436, 89)
        Me.datalistado.TabIndex = 456
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Activo"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtclientesolicitabnte)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtaviso)
        Me.Panel1.Controls.Add(Me.Panelhoras)
        Me.Panel1.Controls.Add(Me.lblhora2)
        Me.Panel1.Controls.Add(Me.TXTFECHA)
        Me.Panel1.Controls.Add(Me.TXTNOMBRE)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(609, 672)
        Me.Panel1.TabIndex = 457
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(0, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(225, 40)
        Me.Button2.TabIndex = 470
        Me.Button2.Text = "PAGOS A PERSONAL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.datalistado)
        Me.Panel2.Controls.Add(Me.datalistadohorastotales)
        Me.Panel2.Controls.Add(Me.datalistadoacumuladohorASDIA)
        Me.Panel2.Controls.Add(Me.datalistadohoras)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.datalistadoasistencia)
        Me.Panel2.Controls.Add(Me.TXTIDPERSONAL)
        Me.Panel2.Location = New System.Drawing.Point(683, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 446)
        Me.Panel2.TabIndex = 462
        '
        'datalistadohorastotales
        '
        Me.datalistadohorastotales.AllowUserToAddRows = False
        Me.datalistadohorastotales.AllowUserToDeleteRows = False
        Me.datalistadohorastotales.BackgroundColor = System.Drawing.Color.White
        Me.datalistadohorastotales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.datalistadohorastotales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datalistadohorastotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistadohorastotales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn5})
        Me.datalistadohorastotales.EnableHeadersVisualStyles = False
        Me.datalistadohorastotales.Location = New System.Drawing.Point(40, 295)
        Me.datalistadohorastotales.Name = "datalistadohorastotales"
        Me.datalistadohorastotales.ReadOnly = True
        Me.datalistadohorastotales.RowHeadersVisible = False
        Me.datalistadohorastotales.RowHeadersWidth = 5
        Me.datalistadohorastotales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistadohorastotales.Size = New System.Drawing.Size(436, 89)
        Me.datalistadohorastotales.TabIndex = 457
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "Activo"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        Me.DataGridViewCheckBoxColumn5.ReadOnly = True
        Me.DataGridViewCheckBoxColumn5.Visible = False
        '
        'datalistadoacumuladohorASDIA
        '
        Me.datalistadoacumuladohorASDIA.AllowUserToAddRows = False
        Me.datalistadoacumuladohorASDIA.AllowUserToDeleteRows = False
        Me.datalistadoacumuladohorASDIA.BackgroundColor = System.Drawing.Color.White
        Me.datalistadoacumuladohorASDIA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.datalistadoacumuladohorASDIA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datalistadoacumuladohorASDIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistadoacumuladohorASDIA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn4})
        Me.datalistadoacumuladohorASDIA.EnableHeadersVisualStyles = False
        Me.datalistadoacumuladohorASDIA.Location = New System.Drawing.Point(40, 260)
        Me.datalistadoacumuladohorASDIA.Name = "datalistadoacumuladohorASDIA"
        Me.datalistadoacumuladohorASDIA.ReadOnly = True
        Me.datalistadoacumuladohorASDIA.RowHeadersVisible = False
        Me.datalistadoacumuladohorASDIA.RowHeadersWidth = 5
        Me.datalistadoacumuladohorASDIA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistadoacumuladohorASDIA.Size = New System.Drawing.Size(436, 29)
        Me.datalistadoacumuladohorASDIA.TabIndex = 456
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "Activo"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.ReadOnly = True
        Me.DataGridViewCheckBoxColumn4.Visible = False
        '
        'datalistadohoras
        '
        Me.datalistadohoras.AllowUserToAddRows = False
        Me.datalistadohoras.AllowUserToDeleteRows = False
        Me.datalistadohoras.BackgroundColor = System.Drawing.Color.White
        Me.datalistadohoras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.datalistadohoras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datalistadohoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistadohoras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn3})
        Me.datalistadohoras.EnableHeadersVisualStyles = False
        Me.datalistadohoras.Location = New System.Drawing.Point(25, 390)
        Me.datalistadohoras.Name = "datalistadohoras"
        Me.datalistadohoras.ReadOnly = True
        Me.datalistadohoras.RowHeadersVisible = False
        Me.datalistadohoras.RowHeadersWidth = 5
        Me.datalistadohoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistadohoras.Size = New System.Drawing.Size(398, 48)
        Me.datalistadohoras.TabIndex = 456
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Activo"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        Me.DataGridViewCheckBoxColumn3.Visible = False
        '
        'datalistadoasistencia
        '
        Me.datalistadoasistencia.AllowUserToAddRows = False
        Me.datalistadoasistencia.AllowUserToDeleteRows = False
        Me.datalistadoasistencia.BackgroundColor = System.Drawing.Color.White
        Me.datalistadoasistencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.datalistadoasistencia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datalistadoasistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistadoasistencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn2})
        Me.datalistadoasistencia.EnableHeadersVisualStyles = False
        Me.datalistadoasistencia.Location = New System.Drawing.Point(24, 129)
        Me.datalistadoasistencia.Name = "datalistadoasistencia"
        Me.datalistadoasistencia.ReadOnly = True
        Me.datalistadoasistencia.RowHeadersVisible = False
        Me.datalistadoasistencia.RowHeadersWidth = 5
        Me.datalistadoasistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistadoasistencia.Size = New System.Drawing.Size(795, 89)
        Me.datalistadoasistencia.TabIndex = 456
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Activo"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Visible = False
        '
        'TXTIDPERSONAL
        '
        Me.TXTIDPERSONAL.AutoSize = True
        Me.TXTIDPERSONAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIDPERSONAL.ForeColor = System.Drawing.Color.Black
        Me.TXTIDPERSONAL.Location = New System.Drawing.Point(21, 12)
        Me.TXTIDPERSONAL.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.TXTIDPERSONAL.Name = "TXTIDPERSONAL"
        Me.TXTIDPERSONAL.Size = New System.Drawing.Size(41, 20)
        Me.TXTIDPERSONAL.TabIndex = 338
        Me.TXTIDPERSONAL.Text = "DNI:"
        '
        'txtclientesolicitabnte
        '
        Me.txtclientesolicitabnte.Location = New System.Drawing.Point(146, 292)
        Me.txtclientesolicitabnte.MaxLength = 8
        Me.txtclientesolicitabnte.Name = "txtclientesolicitabnte"
        Me.txtclientesolicitabnte.Size = New System.Drawing.Size(341, 35)
        Me.txtclientesolicitabnte.TabIndex = 463
        Me.txtclientesolicitabnte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(612, 544)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(85, 72)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 459
        Me.PictureBox4.TabStop = False
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label8.Location = New System.Drawing.Point(-14, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(613, 29)
        Me.Label8.TabIndex = 461
        Me.Label8.Text = "REGISTRO DE ASISTENCIA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtaviso
        '
        Me.txtaviso.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtaviso.ForeColor = System.Drawing.Color.White
        Me.txtaviso.Location = New System.Drawing.Point(1, 449)
        Me.txtaviso.Name = "txtaviso"
        Me.txtaviso.Size = New System.Drawing.Size(613, 29)
        Me.txtaviso.TabIndex = 461
        Me.txtaviso.Text = "********"
        Me.txtaviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panelhoras
        '
        Me.Panelhoras.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panelhoras.Controls.Add(Me.Label4)
        Me.Panelhoras.Controls.Add(Me.Label1)
        Me.Panelhoras.Controls.Add(Me.txthorasdia)
        Me.Panelhoras.Controls.Add(Me.txthoras)
        Me.Panelhoras.Location = New System.Drawing.Point(55, 499)
        Me.Panelhoras.Name = "Panelhoras"
        Me.Panelhoras.Size = New System.Drawing.Size(500, 92)
        Me.Panelhoras.TabIndex = 460
        Me.Panelhoras.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(98, 52)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 26)
        Me.Label4.TabIndex = 338
        Me.Label4.Text = "Horas acumuladas  Hoy:"
        '
        'txthorasdia
        '
        Me.txthorasdia.AutoSize = True
        Me.txthorasdia.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txthorasdia.ForeColor = System.Drawing.Color.White
        Me.txthorasdia.Location = New System.Drawing.Point(351, 52)
        Me.txthorasdia.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.txthorasdia.Name = "txthorasdia"
        Me.txthorasdia.Size = New System.Drawing.Size(24, 26)
        Me.txthorasdia.TabIndex = 338
        Me.txthorasdia.Text = "0"
        '
        'lblhora2
        '
        Me.lblhora2.AutoSize = True
        Me.lblhora2.BackColor = System.Drawing.Color.Transparent
        Me.lblhora2.ForeColor = System.Drawing.Color.DimGray
        Me.lblhora2.Location = New System.Drawing.Point(141, 405)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(221, 29)
        Me.lblhora2.TabIndex = 458
        Me.lblhora2.Text = "ip 12312312312312"
        '
        'TXTFECHA
        '
        Me.TXTFECHA.Enabled = False
        Me.TXTFECHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFECHA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TXTFECHA.Location = New System.Drawing.Point(146, 367)
        Me.TXTFECHA.Name = "TXTFECHA"
        Me.TXTFECHA.Size = New System.Drawing.Size(341, 35)
        Me.TXTFECHA.TabIndex = 457
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(77, 405)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 29)
        Me.Label3.TabIndex = 338
        Me.Label3.Text = "Hora:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(62, 367)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 29)
        Me.Label7.TabIndex = 338
        Me.Label7.Text = "Fecha:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(130, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(357, 248)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 459
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(609, 4)
        Me.Panel7.TabIndex = 532
        '
        'ASISTENCIAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(611, 672)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "ASISTENCIAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.datalistadohorastotales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datalistadoacumuladohorASDIA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datalistadohoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datalistadoasistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelhoras.ResumeLayout(False)
        Me.Panelhoras.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TXTNOMBRE As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txthoras As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TXTFECHA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents datalistadoasistencia As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TXTIDPERSONAL As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Public WithEvents datalistadohoras As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Public WithEvents datalistadoacumuladohorASDIA As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtaviso As System.Windows.Forms.Label
    Friend WithEvents Panelhoras As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents datalistadohorastotales As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn5 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtclientesolicitabnte As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txthorasdia As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
End Class
