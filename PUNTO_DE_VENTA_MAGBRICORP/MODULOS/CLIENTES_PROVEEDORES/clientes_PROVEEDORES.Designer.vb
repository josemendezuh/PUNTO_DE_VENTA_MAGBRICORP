<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clientes_PROVEEDORES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clientes_PROVEEDORES))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.txtidcentrodeproduccion = New System.Windows.Forms.Label()
        Me.txtidcliente = New System.Windows.Forms.Label()
        Me.txtidpersonalencargado = New System.Windows.Forms.Label()
        Me.txtiddestinoi = New System.Windows.Forms.Label()
        Me.txtidusuarioqueemite = New System.Windows.Forms.Label()
        Me.txtidproducto = New System.Windows.Forms.Label()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.txtiddocente = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtrucdefactura = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lestado = New System.Windows.Forms.Label()
        Me.LPROVEEDOR = New System.Windows.Forms.Label()
        Me.LCLIENTE = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtdirecciondefactura = New System.Windows.Forms.TextBox()
        Me.txtnombrecliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panelregistro = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.grupo_facturacion = New System.Windows.Forms.GroupBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip9 = New System.Windows.Forms.MenuStrip()
        Me.GuardarRegistro = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarCambios = New System.Windows.Forms.ToolStripMenuItem()
        Me.VOLVERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtcelular = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblprioridad = New System.Windows.Forms.Label()
        Me.txtclientes = New System.Windows.Forms.RadioButton()
        Me.txtproveedor = New System.Windows.Forms.RadioButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.txtbusca = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblcp = New System.Windows.Forms.Label()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.txtestado = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelregistro.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.grupo_facturacion.SuspendLayout()
        Me.MenuStrip9.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"Nombres_y_Apellidos", "dni", "telefono"})
        Me.cbocampo.Location = New System.Drawing.Point(967, 116)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(152, 21)
        Me.cbocampo.TabIndex = 452
        Me.cbocampo.Text = "Nombres_y_Apellidos"
        '
        'txtidcentrodeproduccion
        '
        Me.txtidcentrodeproduccion.AutoSize = True
        Me.txtidcentrodeproduccion.ForeColor = System.Drawing.Color.Black
        Me.txtidcentrodeproduccion.Location = New System.Drawing.Point(1004, 304)
        Me.txtidcentrodeproduccion.Name = "txtidcentrodeproduccion"
        Me.txtidcentrodeproduccion.Size = New System.Drawing.Size(151, 13)
        Me.txtidcentrodeproduccion.TabIndex = 444
        Me.txtidcentrodeproduccion.Text = "Precio de venta al publico S/.:"
        '
        'txtidcliente
        '
        Me.txtidcliente.AutoSize = True
        Me.txtidcliente.ForeColor = System.Drawing.Color.Black
        Me.txtidcliente.Location = New System.Drawing.Point(1018, 187)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(151, 13)
        Me.txtidcliente.TabIndex = 445
        Me.txtidcliente.Text = "Precio de venta al publico S/.:"
        '
        'txtidpersonalencargado
        '
        Me.txtidpersonalencargado.AutoSize = True
        Me.txtidpersonalencargado.ForeColor = System.Drawing.Color.Black
        Me.txtidpersonalencargado.Location = New System.Drawing.Point(1028, 228)
        Me.txtidpersonalencargado.Name = "txtidpersonalencargado"
        Me.txtidpersonalencargado.Size = New System.Drawing.Size(151, 13)
        Me.txtidpersonalencargado.TabIndex = 446
        Me.txtidpersonalencargado.Text = "Precio de venta al publico S/.:"
        '
        'txtiddestinoi
        '
        Me.txtiddestinoi.AutoSize = True
        Me.txtiddestinoi.ForeColor = System.Drawing.Color.Black
        Me.txtiddestinoi.Location = New System.Drawing.Point(1046, 273)
        Me.txtiddestinoi.Name = "txtiddestinoi"
        Me.txtiddestinoi.Size = New System.Drawing.Size(151, 13)
        Me.txtiddestinoi.TabIndex = 447
        Me.txtiddestinoi.Text = "Precio de venta al publico S/.:"
        '
        'txtidusuarioqueemite
        '
        Me.txtidusuarioqueemite.AutoSize = True
        Me.txtidusuarioqueemite.ForeColor = System.Drawing.Color.Black
        Me.txtidusuarioqueemite.Location = New System.Drawing.Point(988, 206)
        Me.txtidusuarioqueemite.Name = "txtidusuarioqueemite"
        Me.txtidusuarioqueemite.Size = New System.Drawing.Size(151, 13)
        Me.txtidusuarioqueemite.TabIndex = 448
        Me.txtidusuarioqueemite.Text = "Precio de venta al publico S/.:"
        '
        'txtidproducto
        '
        Me.txtidproducto.AutoSize = True
        Me.txtidproducto.ForeColor = System.Drawing.Color.Black
        Me.txtidproducto.Location = New System.Drawing.Point(985, 168)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(151, 13)
        Me.txtidproducto.TabIndex = 449
        Me.txtidproducto.Text = "Precio de venta al publico S/.:"
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(1031, 244)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(62, 17)
        Me.cbeliminar.TabIndex = 453
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'txtiddocente
        '
        Me.txtiddocente.BackColor = System.Drawing.Color.White
        Me.txtiddocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtiddocente.ForeColor = System.Drawing.Color.Black
        Me.txtiddocente.Location = New System.Drawing.Point(972, 320)
        Me.txtiddocente.Name = "txtiddocente"
        Me.txtiddocente.Size = New System.Drawing.Size(121, 20)
        Me.txtiddocente.TabIndex = 450
        Me.txtiddocente.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(1069, 345)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(15, 13)
        Me.Label22.TabIndex = 451
        Me.Label22.Text = "id"
        Me.Label22.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 20)
        Me.Label4.TabIndex = 341
        Me.Label4.Text = "Registro sanitario de Ingreso:"
        '
        'txtrucdefactura
        '
        Me.txtrucdefactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtrucdefactura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtrucdefactura.Location = New System.Drawing.Point(12, 81)
        Me.txtrucdefactura.Mask = "   0      0      0      0      0      0      0      0      0      0      0"
        Me.txtrucdefactura.Name = "txtrucdefactura"
        Me.txtrucdefactura.Size = New System.Drawing.Size(452, 19)
        Me.txtrucdefactura.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lestado)
        Me.Panel1.Controls.Add(Me.LPROVEEDOR)
        Me.Panel1.Controls.Add(Me.LCLIENTE)
        Me.Panel1.Location = New System.Drawing.Point(805, 145)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 11)
        Me.Panel1.TabIndex = 440
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(31, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 336
        Me.Label6.Text = "Nombre/:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lestado
        '
        Me.lestado.AutoSize = True
        Me.lestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lestado.ForeColor = System.Drawing.Color.Black
        Me.lestado.Location = New System.Drawing.Point(31, 18)
        Me.lestado.Name = "lestado"
        Me.lestado.Size = New System.Drawing.Size(52, 13)
        Me.lestado.TabIndex = 336
        Me.lestado.Text = "Nombre/:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lestado.Visible = False
        '
        'LPROVEEDOR
        '
        Me.LPROVEEDOR.AutoSize = True
        Me.LPROVEEDOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPROVEEDOR.ForeColor = System.Drawing.Color.Black
        Me.LPROVEEDOR.Location = New System.Drawing.Point(31, 45)
        Me.LPROVEEDOR.Name = "LPROVEEDOR"
        Me.LPROVEEDOR.Size = New System.Drawing.Size(52, 13)
        Me.LPROVEEDOR.TabIndex = 336
        Me.LPROVEEDOR.Text = "Nombre/:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LPROVEEDOR.Visible = False
        '
        'LCLIENTE
        '
        Me.LCLIENTE.AutoSize = True
        Me.LCLIENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCLIENTE.ForeColor = System.Drawing.Color.Black
        Me.LCLIENTE.Location = New System.Drawing.Point(33, 68)
        Me.LCLIENTE.Name = "LCLIENTE"
        Me.LCLIENTE.Size = New System.Drawing.Size(52, 13)
        Me.LCLIENTE.TabIndex = 336
        Me.LCLIENTE.Text = "Nombre/:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LCLIENTE.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(13, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(146, 20)
        Me.Label14.TabIndex = 336
        Me.Label14.Text = "RUC/ RFC/ NIT/ CI:"
        '
        'txtdirecciondefactura
        '
        Me.txtdirecciondefactura.BackColor = System.Drawing.Color.White
        Me.txtdirecciondefactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdirecciondefactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdirecciondefactura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtdirecciondefactura.Location = New System.Drawing.Point(233, 102)
        Me.txtdirecciondefactura.Name = "txtdirecciondefactura"
        Me.txtdirecciondefactura.Size = New System.Drawing.Size(451, 19)
        Me.txtdirecciondefactura.TabIndex = 3
        Me.txtdirecciondefactura.Text = "0"
        '
        'txtnombrecliente
        '
        Me.txtnombrecliente.BackColor = System.Drawing.Color.White
        Me.txtnombrecliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnombrecliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombrecliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtnombrecliente.Location = New System.Drawing.Point(232, 34)
        Me.txtnombrecliente.Name = "txtnombrecliente"
        Me.txtnombrecliente.Size = New System.Drawing.Size(452, 19)
        Me.txtnombrecliente.TabIndex = 1
        Me.txtnombrecliente.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(132, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 20)
        Me.Label11.TabIndex = 336
        Me.Label11.Text = "Nombre/:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(388, 62)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Registro sanitario de Ingreso"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.PictureBox4)
        Me.TabPage6.Controls.Add(Me.Label17)
        Me.TabPage6.Location = New System.Drawing.Point(4, 29)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(388, 62)
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
        Me.Label17.Size = New System.Drawing.Size(107, 20)
        Me.Label17.TabIndex = 340
        Me.Label17.Text = "Ficha tecnica:"
        '
        'Panelregistro
        '
        Me.Panelregistro.BackColor = System.Drawing.Color.White
        Me.Panelregistro.Controls.Add(Me.Panel6)
        Me.Panelregistro.Controls.Add(Me.Panel1)
        Me.Panelregistro.Controls.Add(Me.lblprioridad)
        Me.Panelregistro.Controls.Add(Me.TabControl3)
        Me.Panelregistro.Controls.Add(Me.txtclientes)
        Me.Panelregistro.Controls.Add(Me.txtproveedor)
        Me.Panelregistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelregistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panelregistro.Location = New System.Drawing.Point(0, 106)
        Me.Panelregistro.Name = "Panelregistro"
        Me.Panelregistro.Size = New System.Drawing.Size(1301, 406)
        Me.Panelregistro.TabIndex = 442
        Me.Panelregistro.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Controls.Add(Me.Panel11)
        Me.Panel6.Controls.Add(Me.grupo_facturacion)
        Me.Panel6.Controls.Add(Me.Panel3)
        Me.Panel6.Controls.Add(Me.Panel2)
        Me.Panel6.Controls.Add(Me.txtdirecciondefactura)
        Me.Panel6.Controls.Add(Me.MenuStrip9)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.txtcelular)
        Me.Panel6.Controls.Add(Me.txtnombrecliente)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1301, 406)
        Me.Panel6.TabIndex = 442
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(234, 124)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(450, 1)
        Me.Panel4.TabIndex = 533
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.LightGray
        Me.Panel11.Location = New System.Drawing.Point(119, 140)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(600, 1)
        Me.Panel11.TabIndex = 538
        '
        'grupo_facturacion
        '
        Me.grupo_facturacion.Controls.Add(Me.Label14)
        Me.grupo_facturacion.Controls.Add(Me.txtrucdefactura)
        Me.grupo_facturacion.Controls.Add(Me.Panel9)
        Me.grupo_facturacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo_facturacion.Location = New System.Drawing.Point(131, 156)
        Me.grupo_facturacion.Name = "grupo_facturacion"
        Me.grupo_facturacion.Size = New System.Drawing.Size(600, 131)
        Me.grupo_facturacion.TabIndex = 537
        Me.grupo_facturacion.TabStop = False
        Me.grupo_facturacion.Text = "Datos de FACTURACION (Opcional)"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.LightGray
        Me.Panel9.Location = New System.Drawing.Point(15, 106)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(450, 2)
        Me.Panel9.TabIndex = 533
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(233, 94)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(450, 1)
        Me.Panel3.TabIndex = 533
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(233, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(450, 1)
        Me.Panel2.TabIndex = 533
        '
        'MenuStrip9
        '
        Me.MenuStrip9.AutoSize = False
        Me.MenuStrip9.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip9.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip9.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarRegistro, Me.GuardarCambios, Me.VOLVERToolStripMenuItem})
        Me.MenuStrip9.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip9.Location = New System.Drawing.Point(131, 306)
        Me.MenuStrip9.Name = "MenuStrip9"
        Me.MenuStrip9.Size = New System.Drawing.Size(340, 35)
        Me.MenuStrip9.TabIndex = 5
        Me.MenuStrip9.Text = "MenuStrip7"
        '
        'GuardarRegistro
        '
        Me.GuardarRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.GuardarRegistro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GuardarRegistro.ForeColor = System.Drawing.Color.Black
        Me.GuardarRegistro.Name = "GuardarRegistro"
        Me.GuardarRegistro.Size = New System.Drawing.Size(83, 31)
        Me.GuardarRegistro.Text = "&Guargar"
        Me.GuardarRegistro.ToolTipText = "Nuevo registro de lineas"
        '
        'GuardarCambios
        '
        Me.GuardarCambios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.GuardarCambios.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GuardarCambios.ForeColor = System.Drawing.Color.Black
        Me.GuardarCambios.Name = "GuardarCambios"
        Me.GuardarCambios.Size = New System.Drawing.Size(151, 31)
        Me.GuardarCambios.Text = "&Guardar cambios"
        Me.GuardarCambios.ToolTipText = "Actualizar datos"
        '
        'VOLVERToolStripMenuItem
        '
        Me.VOLVERToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.VOLVERToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.VOLVERToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.VOLVERToolStripMenuItem.Name = "VOLVERToolStripMenuItem"
        Me.VOLVERToolStripMenuItem.Size = New System.Drawing.Size(72, 31)
        Me.VOLVERToolStripMenuItem.Text = "Volver"
        '
        'txtcelular
        '
        Me.txtcelular.BackColor = System.Drawing.Color.White
        Me.txtcelular.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcelular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcelular.Location = New System.Drawing.Point(233, 69)
        Me.txtcelular.Name = "txtcelular"
        Me.txtcelular.Size = New System.Drawing.Size(404, 19)
        Me.txtcelular.TabIndex = 2
        Me.txtcelular.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(127, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 336
        Me.Label2.Text = "Direccion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(115, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 336
        Me.Label1.Text = "Celular/ Tel."
        '
        'lblprioridad
        '
        Me.lblprioridad.AutoSize = True
        Me.lblprioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblprioridad.ForeColor = System.Drawing.Color.Black
        Me.lblprioridad.Location = New System.Drawing.Point(386, 380)
        Me.lblprioridad.Name = "lblprioridad"
        Me.lblprioridad.Size = New System.Drawing.Size(91, 20)
        Me.lblprioridad.TabIndex = 336
        Me.lblprioridad.Text = "SALDO: S/."
        '
        'txtclientes
        '
        Me.txtclientes.AutoSize = True
        Me.txtclientes.Location = New System.Drawing.Point(274, 376)
        Me.txtclientes.Name = "txtclientes"
        Me.txtclientes.Size = New System.Drawing.Size(81, 24)
        Me.txtclientes.TabIndex = 443
        Me.txtclientes.TabStop = True
        Me.txtclientes.Text = "clientes"
        Me.txtclientes.UseVisualStyleBackColor = True
        '
        'txtproveedor
        '
        Me.txtproveedor.AutoSize = True
        Me.txtproveedor.Location = New System.Drawing.Point(342, 326)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(115, 24)
        Me.txtproveedor.TabIndex = 444
        Me.txtproveedor.TabStop = True
        Me.txtproveedor.Text = "proveedores"
        Me.txtproveedor.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panelregistro)
        Me.Panel5.Controls.Add(Me.datalistado)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1301, 512)
        Me.Panel5.TabIndex = 457
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.datalistado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado.BackgroundColor = System.Drawing.Color.White
        Me.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datalistado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.Editar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado.DefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datalistado.EnableHeadersVisualStyles = False
        Me.datalistado.Location = New System.Drawing.Point(0, 106)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datalistado.RowHeadersVisible = False
        Me.datalistado.RowHeadersWidth = 9
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro
        Me.datalistado.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.datalistado.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.datalistado.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.datalistado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.datalistado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datalistado.RowTemplate.Height = 40
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(1301, 406)
        Me.datalistado.TabIndex = 443
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = ""
        Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
        Me.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Editar
        '
        Me.Editar.HeaderText = ""
        Me.Editar.Image = CType(resources.GetObject("Editar.Image"), System.Drawing.Image)
        Me.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Editar.Name = "Editar"
        Me.Editar.ReadOnly = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.Panel29)
        Me.Panel7.Controls.Add(Me.txtbusca)
        Me.Panel7.Controls.Add(Me.MenuStrip1)
        Me.Panel7.Controls.Add(Me.PictureBox2)
        Me.Panel7.Controls.Add(Me.Label16)
        Me.Panel7.Controls.Add(Me.lblcp)
        Me.Panel7.Controls.Add(Me.lbltipo)
        Me.Panel7.Controls.Add(Me.txtestado)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1301, 106)
        Me.Panel7.TabIndex = 434
        '
        'Panel29
        '
        Me.Panel29.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel29.Location = New System.Drawing.Point(12, 96)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(273, 2)
        Me.Panel29.TabIndex = 534
        '
        'txtbusca
        '
        Me.txtbusca.BackColor = System.Drawing.Color.White
        Me.txtbusca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbusca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbusca.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtbusca.ForeColor = System.Drawing.Color.Black
        Me.txtbusca.Location = New System.Drawing.Point(12, 68)
        Me.txtbusca.Name = "txtbusca"
        Me.txtbusca.Size = New System.Drawing.Size(272, 22)
        Me.txtbusca.TabIndex = 529
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem4})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(286, 59)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(67, 45)
        Me.MenuStrip1.TabIndex = 530
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.AutoSize = False
        Me.ToolStripMenuItem5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripMenuItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripMenuItem5.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem5.Image = CType(resources.GetObject("ToolStripMenuItem5.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(50, 30)
        Me.ToolStripMenuItem5.Text = "+"
        Me.ToolStripMenuItem5.ToolTipText = "Guardar "
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(128, 41)
        Me.ToolStripMenuItem4.Text = "ToolStripMenuItem3"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(366, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(111, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 528
        Me.PictureBox2.TabStop = False
        '
        'Label16
        '
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label16.Location = New System.Drawing.Point(65, 167)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(165, 20)
        Me.Label16.TabIndex = 216
        Me.Label16.Text = "Buscar seleccione en la lupa>>"
        '
        'lblcp
        '
        Me.lblcp.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblcp.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblcp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblcp.ForeColor = System.Drawing.Color.White
        Me.lblcp.Location = New System.Drawing.Point(0, 0)
        Me.lblcp.Name = "lblcp"
        Me.lblcp.Size = New System.Drawing.Size(1301, 44)
        Me.lblcp.TabIndex = 336
        Me.lblcp.Text = "NUEVO REGISTRO"
        Me.lblcp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!)
        Me.lbltipo.ForeColor = System.Drawing.Color.Black
        Me.lbltipo.Location = New System.Drawing.Point(405, 79)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(39, 7)
        Me.lbltipo.TabIndex = 336
        Me.lbltipo.Text = "CLIENTES"
        '
        'txtestado
        '
        Me.txtestado.AutoSize = True
        Me.txtestado.Checked = True
        Me.txtestado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.txtestado.Enabled = False
        Me.txtestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.txtestado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtestado.Location = New System.Drawing.Point(32, 12)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(45, 14)
        Me.txtestado.TabIndex = 359
        Me.txtestado.Text = "Activo"
        Me.txtestado.UseVisualStyleBackColor = True
        '
        'clientes_PROVEEDORES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1301, 512)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.cbocampo)
        Me.Controls.Add(Me.txtidcentrodeproduccion)
        Me.Controls.Add(Me.txtidcliente)
        Me.Controls.Add(Me.txtidpersonalencargado)
        Me.Controls.Add(Me.txtiddestinoi)
        Me.Controls.Add(Me.txtidusuarioqueemite)
        Me.Controls.Add(Me.txtidproducto)
        Me.Controls.Add(Me.cbeliminar)
        Me.Controls.Add(Me.txtiddocente)
        Me.Controls.Add(Me.Label22)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "clientes_PROVEEDORES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelregistro.ResumeLayout(False)
        Me.Panelregistro.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.grupo_facturacion.ResumeLayout(False)
        Me.grupo_facturacion.PerformLayout()
        Me.MenuStrip9.ResumeLayout(False)
        Me.MenuStrip9.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbocampo As System.Windows.Forms.ComboBox
    Friend WithEvents txtidcentrodeproduccion As System.Windows.Forms.Label
    Friend WithEvents txtidcliente As System.Windows.Forms.Label
    Friend WithEvents txtidpersonalencargado As System.Windows.Forms.Label
    Friend WithEvents txtiddestinoi As System.Windows.Forms.Label
    Friend WithEvents txtidusuarioqueemite As System.Windows.Forms.Label
    Friend WithEvents txtidproducto As System.Windows.Forms.Label
    Friend WithEvents cbeliminar As System.Windows.Forms.CheckBox
    Friend WithEvents txtiddocente As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtrucdefactura As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lestado As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LCLIENTE As System.Windows.Forms.Label
    Friend WithEvents LPROVEEDOR As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtdirecciondefactura As System.Windows.Forms.TextBox
    Friend WithEvents txtnombrecliente As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panelregistro As System.Windows.Forms.Panel
    Friend WithEvents txtcelular As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtproveedor As System.Windows.Forms.RadioButton
    Friend WithEvents txtclientes As System.Windows.Forms.RadioButton
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents lblcp As System.Windows.Forms.Label
    Friend WithEvents MenuStrip9 As System.Windows.Forms.MenuStrip
    Friend WithEvents GuardarRegistro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarCambios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VOLVERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblprioridad As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel11 As Panel
    Friend WithEvents grupo_facturacion As GroupBox
    Friend WithEvents txtestado As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewImageColumn
    Friend WithEvents Editar As DataGridViewImageColumn
    Friend WithEvents txtbusca As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents Panel29 As Panel
End Class
