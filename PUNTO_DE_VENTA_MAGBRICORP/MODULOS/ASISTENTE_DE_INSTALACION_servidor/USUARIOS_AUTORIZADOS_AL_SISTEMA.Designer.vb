<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USUARIOS_AUTORIZADOS_AL_SISTEMA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(USUARIOS_AUTORIZADOS_AL_SISTEMA))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.TXTUSUARIO = New System.Windows.Forms.TextBox()
        Me.TXTCONTRASEÑA = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip4 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.datalistado_empresas_nuevas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtconfirmarcontraseña = New System.Windows.Forms.TextBox()
        Me.DATALISTADOUSUARIOSSNUEVOS = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtfechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.txtfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblIDSERIAL = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBLcontador_de_contraseña2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBLcontador_de_contraseña = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.MenuStrip4.SuspendLayout()
        CType(Me.datalistado_empresas_nuevas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATALISTADOUSUARIOSSNUEVOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "¿Que cajero Principal usara el Programa?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(14, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre del Cajero(a):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(121, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(91, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Contraseña:"
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtnombre.Location = New System.Drawing.Point(203, 53)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(231, 23)
        Me.txtnombre.TabIndex = 3
        '
        'TXTUSUARIO
        '
        Me.TXTUSUARIO.Enabled = False
        Me.TXTUSUARIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TXTUSUARIO.Location = New System.Drawing.Point(203, 85)
        Me.TXTUSUARIO.Name = "TXTUSUARIO"
        Me.TXTUSUARIO.Size = New System.Drawing.Size(206, 23)
        Me.TXTUSUARIO.TabIndex = 3
        Me.TXTUSUARIO.Text = "admin"
        '
        'TXTCONTRASEÑA
        '
        Me.TXTCONTRASEÑA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TXTCONTRASEÑA.Location = New System.Drawing.Point(203, 114)
        Me.TXTCONTRASEÑA.MaxLength = 6
        Me.TXTCONTRASEÑA.Name = "TXTCONTRASEÑA"
        Me.TXTCONTRASEÑA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTCONTRASEÑA.Size = New System.Drawing.Size(160, 23)
        Me.TXTCONTRASEÑA.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label6.Location = New System.Drawing.Point(42, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(631, 29)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "El Administrador siempre tendra Acceso a todas las Funciones del Programa"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStrip4
        '
        Me.MenuStrip4.AutoSize = False
        Me.MenuStrip4.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip4.Location = New System.Drawing.Point(542, 400)
        Me.MenuStrip4.Name = "MenuStrip4"
        Me.MenuStrip4.ShowItemToolTips = True
        Me.MenuStrip4.Size = New System.Drawing.Size(114, 32)
        Me.MenuStrip4.TabIndex = 587
        Me.MenuStrip4.Text = "MenuStrip4"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(99, 28)
        Me.ToolStripMenuItem1.Text = "Siguiente"
        '
        'datalistado_empresas_nuevas
        '
        Me.datalistado_empresas_nuevas.AllowUserToAddRows = False
        Me.datalistado_empresas_nuevas.AllowUserToDeleteRows = False
        Me.datalistado_empresas_nuevas.BackgroundColor = System.Drawing.Color.White
        Me.datalistado_empresas_nuevas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistado_empresas_nuevas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_empresas_nuevas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado_empresas_nuevas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado_empresas_nuevas.ColumnHeadersVisible = False
        Me.datalistado_empresas_nuevas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado_empresas_nuevas.DefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado_empresas_nuevas.EnableHeadersVisualStyles = False
        Me.datalistado_empresas_nuevas.Location = New System.Drawing.Point(297, 230)
        Me.datalistado_empresas_nuevas.Name = "datalistado_empresas_nuevas"
        Me.datalistado_empresas_nuevas.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_empresas_nuevas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado_empresas_nuevas.RowHeadersWidth = 5
        Me.datalistado_empresas_nuevas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.datalistado_empresas_nuevas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datalistado_empresas_nuevas.RowTemplate.Height = 40
        Me.datalistado_empresas_nuevas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado_empresas_nuevas.Size = New System.Drawing.Size(109, 79)
        Me.datalistado_empresas_nuevas.TabIndex = 594
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Eliminar"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(11, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Confirmar contraseña:"
        '
        'txtconfirmarcontraseña
        '
        Me.txtconfirmarcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtconfirmarcontraseña.Location = New System.Drawing.Point(203, 143)
        Me.txtconfirmarcontraseña.MaxLength = 6
        Me.txtconfirmarcontraseña.Name = "txtconfirmarcontraseña"
        Me.txtconfirmarcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirmarcontraseña.Size = New System.Drawing.Size(160, 23)
        Me.txtconfirmarcontraseña.TabIndex = 3
        '
        'DATALISTADOUSUARIOSSNUEVOS
        '
        Me.DATALISTADOUSUARIOSSNUEVOS.AllowUserToAddRows = False
        Me.DATALISTADOUSUARIOSSNUEVOS.AllowUserToDeleteRows = False
        Me.DATALISTADOUSUARIOSSNUEVOS.AllowUserToResizeRows = False
        Me.DATALISTADOUSUARIOSSNUEVOS.BackgroundColor = System.Drawing.Color.White
        Me.DATALISTADOUSUARIOSSNUEVOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DATALISTADOUSUARIOSSNUEVOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DATALISTADOUSUARIOSSNUEVOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATALISTADOUSUARIOSSNUEVOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn3})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DATALISTADOUSUARIOSSNUEVOS.DefaultCellStyle = DataGridViewCellStyle5
        Me.DATALISTADOUSUARIOSSNUEVOS.Location = New System.Drawing.Point(275, 267)
        Me.DATALISTADOUSUARIOSSNUEVOS.Name = "DATALISTADOUSUARIOSSNUEVOS"
        Me.DATALISTADOUSUARIOSSNUEVOS.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DATALISTADOUSUARIOSSNUEVOS.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DATALISTADOUSUARIOSSNUEVOS.RowHeadersVisible = False
        Me.DATALISTADOUSUARIOSSNUEVOS.RowHeadersWidth = 5
        Me.DATALISTADOUSUARIOSSNUEVOS.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.ForestGreen
        Me.DATALISTADOUSUARIOSSNUEVOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATALISTADOUSUARIOSSNUEVOS.Size = New System.Drawing.Size(88, 75)
        Me.DATALISTADOUSUARIOSSNUEVOS.TabIndex = 595
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Activo"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        '
        'txtfechaFinal
        '
        Me.txtfechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtfechaFinal.Location = New System.Drawing.Point(40, 38)
        Me.txtfechaFinal.Name = "txtfechaFinal"
        Me.txtfechaFinal.Size = New System.Drawing.Size(192, 20)
        Me.txtfechaFinal.TabIndex = 596
        '
        'txtfechaInicio
        '
        Me.txtfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtfechaInicio.Location = New System.Drawing.Point(0, 60)
        Me.txtfechaInicio.Name = "txtfechaInicio"
        Me.txtfechaInicio.Size = New System.Drawing.Size(192, 20)
        Me.txtfechaInicio.TabIndex = 596
        '
        'lblIDSERIAL
        '
        Me.lblIDSERIAL.AutoSize = True
        Me.lblIDSERIAL.BackColor = System.Drawing.Color.White
        Me.lblIDSERIAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblIDSERIAL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblIDSERIAL.Location = New System.Drawing.Point(26, 15)
        Me.lblIDSERIAL.Name = "lblIDSERIAL"
        Me.lblIDSERIAL.Size = New System.Drawing.Size(84, 20)
        Me.lblIDSERIAL.TabIndex = 2
        Me.lblIDSERIAL.Text = "lblidserial"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtfechaInicio)
        Me.Panel1.Controls.Add(Me.txtfechaFinal)
        Me.Panel1.Controls.Add(Me.lblIDSERIAL)
        Me.Panel1.Location = New System.Drawing.Point(37, 378)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 10)
        Me.Panel1.TabIndex = 597
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.LBLcontador_de_contraseña2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.LBLcontador_de_contraseña)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.MenuStrip4)
        Me.Panel2.Controls.Add(Me.txtconfirmarcontraseña)
        Me.Panel2.Controls.Add(Me.TXTCONTRASEÑA)
        Me.Panel2.Controls.Add(Me.TXTUSUARIO)
        Me.Panel2.Controls.Add(Me.txtnombre)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.datalistado_empresas_nuevas)
        Me.Panel2.Controls.Add(Me.DATALISTADOUSUARIOSSNUEVOS)
        Me.Panel2.Location = New System.Drawing.Point(184, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(666, 449)
        Me.Panel2.TabIndex = 598
        '
        'LBLcontador_de_contraseña2
        '
        Me.LBLcontador_de_contraseña2.AutoSize = True
        Me.LBLcontador_de_contraseña2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLcontador_de_contraseña2.ForeColor = System.Drawing.Color.DimGray
        Me.LBLcontador_de_contraseña2.Location = New System.Drawing.Point(370, 150)
        Me.LBLcontador_de_contraseña2.Name = "LBLcontador_de_contraseña2"
        Me.LBLcontador_de_contraseña2.Size = New System.Drawing.Size(13, 13)
        Me.LBLcontador_de_contraseña2.TabIndex = 596
        Me.LBLcontador_de_contraseña2.Text = "6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(389, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 13)
        Me.Label7.TabIndex = 596
        Me.Label7.Text = "Ingresa hasta 6 numeros"
        '
        'LBLcontador_de_contraseña
        '
        Me.LBLcontador_de_contraseña.AutoSize = True
        Me.LBLcontador_de_contraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLcontador_de_contraseña.ForeColor = System.Drawing.Color.DimGray
        Me.LBLcontador_de_contraseña.Location = New System.Drawing.Point(370, 121)
        Me.LBLcontador_de_contraseña.Name = "LBLcontador_de_contraseña"
        Me.LBLcontador_de_contraseña.Size = New System.Drawing.Size(13, 13)
        Me.LBLcontador_de_contraseña.TabIndex = 596
        Me.LBLcontador_de_contraseña.Text = "6"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(165, 214)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(340, 194)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 589
        Me.PictureBox2.TabStop = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(902, 233)
        Me.Panel12.TabIndex = 605
        '
        'USUARIOS_AUTORIZADOS_AL_SISTEMA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(902, 733)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "USUARIOS_AUTORIZADOS_AL_SISTEMA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Usuario Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip4.ResumeLayout(False)
        Me.MenuStrip4.PerformLayout()
        CType(Me.datalistado_empresas_nuevas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATALISTADOUSUARIOSSNUEVOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents TXTUSUARIO As System.Windows.Forms.TextBox
    Friend WithEvents TXTCONTRASEÑA As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip4 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents datalistado_empresas_nuevas As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtconfirmarcontraseña As System.Windows.Forms.TextBox
    Public WithEvents DATALISTADOUSUARIOSSNUEVOS As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtfechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblIDSERIAL As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LBLcontador_de_contraseña2 As Label
    Friend WithEvents LBLcontador_de_contraseña As Label
    Friend WithEvents Label7 As Label
End Class
