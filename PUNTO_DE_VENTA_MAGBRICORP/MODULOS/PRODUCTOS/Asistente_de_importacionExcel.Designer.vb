<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Asistente_de_importacionExcel
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Asistente_de_importacionExcel))
        Me.B1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Paso3 = New System.Windows.Forms.Panel()
        Me.Paso1 = New System.Windows.Forms.Panel()
        Me.Paso2 = New System.Windows.Forms.Panel()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.PanelDescarga_de_archivo = New System.Windows.Forms.Panel()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Marcar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PanelBaseDatosDeADA369 = New System.Windows.Forms.Panel()
        Me.txtTipodeEmpresa = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LinkPRECARGADA = New System.Windows.Forms.LinkLabel()
        Me.TSIGUIENTE_Y_GUARDAR = New System.Windows.Forms.MenuStrip()
        Me.TSIGUIENTE_Y_GUARDAR_ = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RBasePropia = New System.Windows.Forms.RadioButton()
        Me.RBasePrecargada = New System.Windows.Forms.RadioButton()
        Me.PanelPlantillaBase = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelCargarrchivo = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblnombre_Del_archivo = New System.Windows.Forms.Label()
        Me.lblarchivoCargado = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelGuardarData = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.PanelDescarga_de_archivo.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBaseDatosDeADA369.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TSIGUIENTE_Y_GUARDAR.SuspendLayout()
        Me.PanelPlantillaBase.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCargarrchivo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelGuardarData.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'B1
        '
        Me.B1.BackColor = System.Drawing.Color.White
        Me.B1.FlatAppearance.BorderSize = 0
        Me.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B1.Location = New System.Drawing.Point(0, 0)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(235, 56)
        Me.B1.TabIndex = 0
        Me.B1.Text = "PASO 1  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Elegir Archivo"
        Me.B1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Paso3)
        Me.Panel1.Controls.Add(Me.Paso1)
        Me.Panel1.Controls.Add(Me.Paso2)
        Me.Panel1.Controls.Add(Me.B3)
        Me.Panel1.Controls.Add(Me.B2)
        Me.Panel1.Controls.Add(Me.B1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1198, 56)
        Me.Panel1.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(1149, 11)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(37, 35)
        Me.Button4.TabIndex = 557
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Paso3
        '
        Me.Paso3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Paso3.Location = New System.Drawing.Point(470, 52)
        Me.Paso3.Name = "Paso3"
        Me.Paso3.Size = New System.Drawing.Size(233, 4)
        Me.Paso3.TabIndex = 556
        Me.Paso3.Visible = False
        '
        'Paso1
        '
        Me.Paso1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Paso1.Location = New System.Drawing.Point(0, 52)
        Me.Paso1.Name = "Paso1"
        Me.Paso1.Size = New System.Drawing.Size(233, 4)
        Me.Paso1.TabIndex = 556
        Me.Paso1.Visible = False
        '
        'Paso2
        '
        Me.Paso2.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Paso2.Location = New System.Drawing.Point(235, 52)
        Me.Paso2.Name = "Paso2"
        Me.Paso2.Size = New System.Drawing.Size(233, 4)
        Me.Paso2.TabIndex = 556
        Me.Paso2.Visible = False
        '
        'B3
        '
        Me.B3.BackColor = System.Drawing.Color.White
        Me.B3.Enabled = False
        Me.B3.FlatAppearance.BorderSize = 0
        Me.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B3.ForeColor = System.Drawing.Color.Black
        Me.B3.Location = New System.Drawing.Point(470, 0)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(235, 56)
        Me.B3.TabIndex = 2
        Me.B3.Text = "PASO 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Guardar Datos"
        Me.B3.UseVisualStyleBackColor = False
        '
        'B2
        '
        Me.B2.BackColor = System.Drawing.Color.White
        Me.B2.Enabled = False
        Me.B2.FlatAppearance.BorderSize = 0
        Me.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B2.ForeColor = System.Drawing.Color.Black
        Me.B2.Location = New System.Drawing.Point(235, 0)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(235, 56)
        Me.B2.TabIndex = 1
        Me.B2.Text = "PASO 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cargar Archivo .CSV"
        Me.B2.UseVisualStyleBackColor = False
        '
        'PanelDescarga_de_archivo
        '
        Me.PanelDescarga_de_archivo.Controls.Add(Me.PanelBaseDatosDeADA369)
        Me.PanelDescarga_de_archivo.Controls.Add(Me.TSIGUIENTE_Y_GUARDAR)
        Me.PanelDescarga_de_archivo.Controls.Add(Me.Label1)
        Me.PanelDescarga_de_archivo.Controls.Add(Me.RBasePropia)
        Me.PanelDescarga_de_archivo.Controls.Add(Me.RBasePrecargada)
        Me.PanelDescarga_de_archivo.Controls.Add(Me.PanelPlantillaBase)
        Me.PanelDescarga_de_archivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelDescarga_de_archivo.Location = New System.Drawing.Point(116, 68)
        Me.PanelDescarga_de_archivo.Name = "PanelDescarga_de_archivo"
        Me.PanelDescarga_de_archivo.Size = New System.Drawing.Size(677, 314)
        Me.PanelDescarga_de_archivo.TabIndex = 2
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.AllowUserToResizeRows = False
        Me.datalistado.BackgroundColor = System.Drawing.Color.White
        Me.datalistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Marcar})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado.DefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado.Location = New System.Drawing.Point(22, 28)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.RowHeadersVisible = False
        Me.datalistado.RowHeadersWidth = 5
        Me.datalistado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.ForestGreen
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(14, 20)
        Me.datalistado.TabIndex = 611
        '
        'Marcar
        '
        Me.Marcar.DataPropertyName = "Marcar"
        Me.Marcar.HeaderText = "Marcar"
        Me.Marcar.Name = "Marcar"
        Me.Marcar.ReadOnly = True
        Me.Marcar.Visible = False
        '
        'PanelBaseDatosDeADA369
        '
        Me.PanelBaseDatosDeADA369.Controls.Add(Me.txtTipodeEmpresa)
        Me.PanelBaseDatosDeADA369.Controls.Add(Me.PictureBox1)
        Me.PanelBaseDatosDeADA369.Controls.Add(Me.Label8)
        Me.PanelBaseDatosDeADA369.Controls.Add(Me.LinkPRECARGADA)
        Me.PanelBaseDatosDeADA369.Location = New System.Drawing.Point(26, 215)
        Me.PanelBaseDatosDeADA369.Name = "PanelBaseDatosDeADA369"
        Me.PanelBaseDatosDeADA369.Size = New System.Drawing.Size(613, 76)
        Me.PanelBaseDatosDeADA369.TabIndex = 585
        '
        'txtTipodeEmpresa
        '
        Me.txtTipodeEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipodeEmpresa.DropDownWidth = 230
        Me.txtTipodeEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtTipodeEmpresa.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTipodeEmpresa.FormattingEnabled = True
        Me.txtTipodeEmpresa.IntegralHeight = False
        Me.txtTipodeEmpresa.Items.AddRange(New Object() {"Ferreteria"})
        Me.txtTipodeEmpresa.Location = New System.Drawing.Point(74, 5)
        Me.txtTipodeEmpresa.Name = "txtTipodeEmpresa"
        Me.txtTipodeEmpresa.Size = New System.Drawing.Size(223, 28)
        Me.txtTipodeEmpresa.TabIndex = 603
        Me.txtTipodeEmpresa.Text = "Ferreteria"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(72, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(481, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Una vez Descargado Llena el Archivo Excel y Guardalo como Archivo .CSV"
        '
        'LinkPRECARGADA
        '
        Me.LinkPRECARGADA.AutoSize = True
        Me.LinkPRECARGADA.LinkColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.LinkPRECARGADA.Location = New System.Drawing.Point(303, 8)
        Me.LinkPRECARGADA.Name = "LinkPRECARGADA"
        Me.LinkPRECARGADA.Size = New System.Drawing.Size(83, 20)
        Me.LinkPRECARGADA.TabIndex = 2
        Me.LinkPRECARGADA.TabStop = True
        Me.LinkPRECARGADA.Text = "Descargar"
        '
        'TSIGUIENTE_Y_GUARDAR
        '
        Me.TSIGUIENTE_Y_GUARDAR.AutoSize = False
        Me.TSIGUIENTE_Y_GUARDAR.BackColor = System.Drawing.Color.Transparent
        Me.TSIGUIENTE_Y_GUARDAR.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TSIGUIENTE_Y_GUARDAR.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSIGUIENTE_Y_GUARDAR_})
        Me.TSIGUIENTE_Y_GUARDAR.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.TSIGUIENTE_Y_GUARDAR.Location = New System.Drawing.Point(0, 282)
        Me.TSIGUIENTE_Y_GUARDAR.Name = "TSIGUIENTE_Y_GUARDAR"
        Me.TSIGUIENTE_Y_GUARDAR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TSIGUIENTE_Y_GUARDAR.ShowItemToolTips = True
        Me.TSIGUIENTE_Y_GUARDAR.Size = New System.Drawing.Size(677, 32)
        Me.TSIGUIENTE_Y_GUARDAR.TabIndex = 584
        Me.TSIGUIENTE_Y_GUARDAR.Text = "MenuStrip4"
        '
        'TSIGUIENTE_Y_GUARDAR_
        '
        Me.TSIGUIENTE_Y_GUARDAR_.BackColor = System.Drawing.Color.Gainsboro
        Me.TSIGUIENTE_Y_GUARDAR_.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TSIGUIENTE_Y_GUARDAR_.ForeColor = System.Drawing.Color.Black
        Me.TSIGUIENTE_Y_GUARDAR_.Image = CType(resources.GetObject("TSIGUIENTE_Y_GUARDAR_.Image"), System.Drawing.Image)
        Me.TSIGUIENTE_Y_GUARDAR_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TSIGUIENTE_Y_GUARDAR_.Name = "TSIGUIENTE_Y_GUARDAR_"
        Me.TSIGUIENTE_Y_GUARDAR_.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TSIGUIENTE_Y_GUARDAR_.Size = New System.Drawing.Size(99, 28)
        Me.TSIGUIENTE_Y_GUARDAR_.Text = "Siguiente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tienes 2 Opciones"
        '
        'RBasePropia
        '
        Me.RBasePropia.AutoSize = True
        Me.RBasePropia.Location = New System.Drawing.Point(3, 73)
        Me.RBasePropia.Name = "RBasePropia"
        Me.RBasePropia.Size = New System.Drawing.Size(286, 24)
        Me.RBasePropia.TabIndex = 0
        Me.RBasePropia.TabStop = True
        Me.RBasePropia.Text = "Carga tu Propia Base de datos Excel"
        Me.RBasePropia.UseVisualStyleBackColor = True
        '
        'RBasePrecargada
        '
        Me.RBasePrecargada.AutoSize = True
        Me.RBasePrecargada.Location = New System.Drawing.Point(3, 43)
        Me.RBasePrecargada.Name = "RBasePrecargada"
        Me.RBasePrecargada.Size = New System.Drawing.Size(383, 24)
        Me.RBasePrecargada.TabIndex = 0
        Me.RBasePrecargada.TabStop = True
        Me.RBasePrecargada.Text = "Usa nuestra Base de datos  Precargadas en Excel"
        Me.RBasePrecargada.UseVisualStyleBackColor = True
        '
        'PanelPlantillaBase
        '
        Me.PanelPlantillaBase.Controls.Add(Me.PictureBox2)
        Me.PanelPlantillaBase.Controls.Add(Me.datalistado)
        Me.PanelPlantillaBase.Controls.Add(Me.LinkLabel2)
        Me.PanelPlantillaBase.Controls.Add(Me.Label2)
        Me.PanelPlantillaBase.Location = New System.Drawing.Point(7, 118)
        Me.PanelPlantillaBase.Name = "PanelPlantillaBase"
        Me.PanelPlantillaBase.Size = New System.Drawing.Size(632, 91)
        Me.PanelPlantillaBase.TabIndex = 585
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(72, 15)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(183, 20)
        Me.LinkLabel2.TabIndex = 2
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Descargar Plantilla Excel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(72, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(474, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Una vez Descargado Llena el Archivo Excel .Guardalo como Archivo .CSV"
        '
        'PanelCargarrchivo
        '
        Me.PanelCargarrchivo.AllowDrop = True
        Me.PanelCargarrchivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PanelCargarrchivo.BackgroundImage = CType(resources.GetObject("PanelCargarrchivo.BackgroundImage"), System.Drawing.Image)
        Me.PanelCargarrchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PanelCargarrchivo.Controls.Add(Me.Panel2)
        Me.PanelCargarrchivo.Controls.Add(Me.Label3)
        Me.PanelCargarrchivo.Controls.Add(Me.lblnombre_Del_archivo)
        Me.PanelCargarrchivo.Controls.Add(Me.lblarchivoCargado)
        Me.PanelCargarrchivo.Controls.Add(Me.LinkLabel3)
        Me.PanelCargarrchivo.Controls.Add(Me.MenuStrip1)
        Me.PanelCargarrchivo.Location = New System.Drawing.Point(583, 141)
        Me.PanelCargarrchivo.Name = "PanelCargarrchivo"
        Me.PanelCargarrchivo.Size = New System.Drawing.Size(326, 241)
        Me.PanelCargarrchivo.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblRuta)
        Me.Panel2.Location = New System.Drawing.Point(15, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 11)
        Me.Panel2.TabIndex = 602
        '
        'lblRuta
        '
        Me.lblRuta.AutoSize = True
        Me.lblRuta.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.lblRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblRuta.ForeColor = System.Drawing.Color.White
        Me.lblRuta.Location = New System.Drawing.Point(-32, 21)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(262, 20)
        Me.lblRuta.TabIndex = 601
        Me.lblRuta.Text = "Arrastra aqui el Archivo de CSV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(179, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(550, 20)
        Me.Label3.TabIndex = 601
        Me.Label3.Text = "Recuerda que el Archivo Excel debes Guardarlo como Archivo .CSV"
        '
        'lblnombre_Del_archivo
        '
        Me.lblnombre_Del_archivo.AutoSize = True
        Me.lblnombre_Del_archivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.lblnombre_Del_archivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblnombre_Del_archivo.ForeColor = System.Drawing.Color.White
        Me.lblnombre_Del_archivo.Location = New System.Drawing.Point(478, 218)
        Me.lblnombre_Del_archivo.Name = "lblnombre_Del_archivo"
        Me.lblnombre_Del_archivo.Size = New System.Drawing.Size(242, 20)
        Me.lblnombre_Del_archivo.TabIndex = 601
        Me.lblnombre_Del_archivo.Text = "Arrastra aqui el Archivo .CSV"
        '
        'lblarchivoCargado
        '
        Me.lblarchivoCargado.AutoSize = True
        Me.lblarchivoCargado.BackColor = System.Drawing.Color.Transparent
        Me.lblarchivoCargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblarchivoCargado.ForeColor = System.Drawing.Color.DimGray
        Me.lblarchivoCargado.Location = New System.Drawing.Point(379, 17)
        Me.lblarchivoCargado.Name = "lblarchivoCargado"
        Me.lblarchivoCargado.Size = New System.Drawing.Size(141, 20)
        Me.lblarchivoCargado.TabIndex = 601
        Me.lblarchivoCargado.Text = "Archivo Cargado"
        Me.lblarchivoCargado.Visible = False
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel3.LinkColor = System.Drawing.Color.White
        Me.LinkLabel3.Location = New System.Drawing.Point(517, 258)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(165, 20)
        Me.LinkLabel3.TabIndex = 600
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Seleccionar archivo"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 209)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(326, 32)
        Me.MenuStrip1.TabIndex = 599
        Me.MenuStrip1.Text = "MenuStrip4"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(99, 28)
        Me.ToolStripMenuItem1.Text = "Siguiente"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(72, 28)
        Me.ToolStripMenuItem2.Text = "Atras"
        Me.ToolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolStripMenuItem2.Visible = False
        '
        'PanelGuardarData
        '
        Me.PanelGuardarData.Controls.Add(Me.Panel6)
        Me.PanelGuardarData.Controls.Add(Me.Label11)
        Me.PanelGuardarData.Controls.Add(Me.PictureBox5)
        Me.PanelGuardarData.Controls.Add(Me.Label7)
        Me.PanelGuardarData.Controls.Add(Me.Label6)
        Me.PanelGuardarData.Location = New System.Drawing.Point(29, 65)
        Me.PanelGuardarData.Name = "PanelGuardarData"
        Me.PanelGuardarData.Size = New System.Drawing.Size(880, 317)
        Me.PanelGuardarData.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(445, 66)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(12, 10)
        Me.Panel6.TabIndex = 613
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(11, 92)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(356, 39)
        Me.Label11.TabIndex = 602
        Me.Label11.Text = "Iniciar"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(13, 20)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(41, 26)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 558
        Me.PictureBox5.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(355, 17)
        Me.Label7.TabIndex = 601
        Me.Label7.Text = "Todo listo para realizar la Importacion de Datos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(60, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 17)
        Me.Label6.TabIndex = 601
        Me.Label6.Text = "ferreteria.csv"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Asistente_de_importacion
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1198, 474)
        Me.Controls.Add(Me.PanelCargarrchivo)
        Me.Controls.Add(Me.PanelDescarga_de_archivo)
        Me.Controls.Add(Me.PanelGuardarData)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Asistente_de_importacion"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistente de Importacion"
        Me.Panel1.ResumeLayout(False)
        Me.PanelDescarga_de_archivo.ResumeLayout(False)
        Me.PanelDescarga_de_archivo.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBaseDatosDeADA369.ResumeLayout(False)
        Me.PanelBaseDatosDeADA369.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TSIGUIENTE_Y_GUARDAR.ResumeLayout(False)
        Me.TSIGUIENTE_Y_GUARDAR.PerformLayout()
        Me.PanelPlantillaBase.ResumeLayout(False)
        Me.PanelPlantillaBase.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCargarrchivo.ResumeLayout(False)
        Me.PanelCargarrchivo.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelGuardarData.ResumeLayout(False)
        Me.PanelGuardarData.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents B1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents B3 As Button
    Friend WithEvents B2 As Button
    Friend WithEvents PanelDescarga_de_archivo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents RBasePropia As RadioButton
    Friend WithEvents RBasePrecargada As RadioButton
    Friend WithEvents PanelBaseDatosDeADA369 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TSIGUIENTE_Y_GUARDAR As MenuStrip
    Friend WithEvents TSIGUIENTE_Y_GUARDAR_ As ToolStripMenuItem
    Friend WithEvents PanelPlantillaBase As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelCargarrchivo As Panel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Paso2 As Panel
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents lblRuta As Label
    Friend WithEvents PanelGuardarData As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Paso3 As Panel
    Friend WithEvents Paso1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents lblnombre_Del_archivo As Label
    Friend WithEvents lblarchivoCargado As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkPRECARGADA As LinkLabel
    Public WithEvents datalistado As DataGridView
    Friend WithEvents Marcar As DataGridViewCheckBoxColumn
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents txtTipodeEmpresa As ComboBox
End Class
