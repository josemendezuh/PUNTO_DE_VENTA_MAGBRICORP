<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTIVAR_LICENCIA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTIVAR_LICENCIA))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtserial = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblserialLicencia = New System.Windows.Forms.Label()
        Me.lblserialPc = New System.Windows.Forms.Label()
        Me.LBLSERIAL_LICENCIA_WEB = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtfechaWEB = New System.Windows.Forms.DateTimePicker()
        Me.lblserialPcWEB = New System.Windows.Forms.Label()
        Me.Timermostrar = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.datalistado_licencias = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.desconectado = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblconectado = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datalistado_licencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.desconectado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(137, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduce tu numero de Compra que te llego al correo, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cuando compraste la Licen" &
    "cia"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtserial
        '
        Me.txtserial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtserial.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtserial.Location = New System.Drawing.Point(336, 157)
        Me.txtserial.Name = "txtserial"
        Me.txtserial.Size = New System.Drawing.Size(532, 31)
        Me.txtserial.TabIndex = 1
        Me.txtserial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(681, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 25)
        Me.Button2.TabIndex = 547
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'lblserialLicencia
        '
        Me.lblserialLicencia.AutoSize = True
        Me.lblserialLicencia.Location = New System.Drawing.Point(9, 14)
        Me.lblserialLicencia.Name = "lblserialLicencia"
        Me.lblserialLicencia.Size = New System.Drawing.Size(39, 13)
        Me.lblserialLicencia.TabIndex = 548
        Me.lblserialLicencia.Text = "Label2"
        '
        'lblserialPc
        '
        Me.lblserialPc.AutoSize = True
        Me.lblserialPc.Location = New System.Drawing.Point(9, 27)
        Me.lblserialPc.Name = "lblserialPc"
        Me.lblserialPc.Size = New System.Drawing.Size(39, 13)
        Me.lblserialPc.TabIndex = 548
        Me.lblserialPc.Text = "Label2"
        '
        'LBLSERIAL_LICENCIA_WEB
        '
        Me.LBLSERIAL_LICENCIA_WEB.AutoSize = True
        Me.LBLSERIAL_LICENCIA_WEB.Location = New System.Drawing.Point(54, 14)
        Me.LBLSERIAL_LICENCIA_WEB.Name = "LBLSERIAL_LICENCIA_WEB"
        Me.LBLSERIAL_LICENCIA_WEB.Size = New System.Drawing.Size(149, 13)
        Me.LBLSERIAL_LICENCIA_WEB.TabIndex = 549
        Me.LBLSERIAL_LICENCIA_WEB.Text = "LBLSERIAL_LICENCIA_WEB"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 19)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(264, 10)
        Me.ProgressBar1.TabIndex = 550
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(74, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(362, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Licencia Activada para PC02"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(13, 194)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 87)
        Me.Panel1.TabIndex = 552
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 551
        Me.PictureBox1.TabStop = False
        '
        'txtfechaWEB
        '
        Me.txtfechaWEB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtfechaWEB.Location = New System.Drawing.Point(-20, 27)
        Me.txtfechaWEB.Name = "txtfechaWEB"
        Me.txtfechaWEB.Size = New System.Drawing.Size(90, 20)
        Me.txtfechaWEB.TabIndex = 555
        '
        'lblserialPcWEB
        '
        Me.lblserialPcWEB.AutoSize = True
        Me.lblserialPcWEB.Location = New System.Drawing.Point(9, 16)
        Me.lblserialPcWEB.Name = "lblserialPcWEB"
        Me.lblserialPcWEB.Size = New System.Drawing.Size(39, 13)
        Me.lblserialPcWEB.TabIndex = 548
        Me.lblserialPcWEB.Text = "Label2"
        '
        'Timermostrar
        '
        Me.Timermostrar.Interval = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(90, 150)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(532, 10)
        Me.Panel2.TabIndex = 553
        '
        'datalistado_licencias
        '
        Me.datalistado_licencias.AllowUserToAddRows = False
        Me.datalistado_licencias.AllowUserToDeleteRows = False
        Me.datalistado_licencias.AllowUserToResizeRows = False
        Me.datalistado_licencias.BackgroundColor = System.Drawing.Color.White
        Me.datalistado_licencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_licencias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado_licencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado_licencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado_licencias.DefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado_licencias.Location = New System.Drawing.Point(490, 123)
        Me.datalistado_licencias.Name = "datalistado_licencias"
        Me.datalistado_licencias.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_licencias.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado_licencias.RowHeadersVisible = False
        Me.datalistado_licencias.RowHeadersWidth = 5
        Me.datalistado_licencias.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.ForestGreen
        Me.datalistado_licencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado_licencias.Size = New System.Drawing.Size(189, 75)
        Me.datalistado_licencias.TabIndex = 554
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "Activo"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        Me.DataGridViewCheckBoxColumn5.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtfechaWEB)
        Me.Panel3.Controls.Add(Me.ProgressBar1)
        Me.Panel3.Controls.Add(Me.lblserialPcWEB)
        Me.Panel3.Controls.Add(Me.lblserialPc)
        Me.Panel3.Controls.Add(Me.lblserialLicencia)
        Me.Panel3.Controls.Add(Me.LBLSERIAL_LICENCIA_WEB)
        Me.Panel3.Location = New System.Drawing.Point(34, 96)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 10)
        Me.Panel3.TabIndex = 555
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.desconectado)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(104, 170)
        Me.Panel4.TabIndex = 556
        Me.Panel4.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(525, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Volver a Intentar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'desconectado
        '
        Me.desconectado.Image = CType(resources.GetObject("desconectado.Image"), System.Drawing.Image)
        Me.desconectado.Location = New System.Drawing.Point(6, 143)
        Me.desconectado.Name = "desconectado"
        Me.desconectado.Size = New System.Drawing.Size(28, 17)
        Me.desconectado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.desconectado.TabIndex = 2
        Me.desconectado.TabStop = False
        Me.desconectado.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(30, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Conectando..."
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(104, 134)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'lblconectado
        '
        Me.lblconectado.AutoSize = True
        Me.lblconectado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblconectado.ForeColor = System.Drawing.Color.Gray
        Me.lblconectado.Location = New System.Drawing.Point(43, 2)
        Me.lblconectado.Name = "lblconectado"
        Me.lblconectado.Size = New System.Drawing.Size(76, 17)
        Me.lblconectado.TabIndex = 1
        Me.lblconectado.Text = "Conectado"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 17)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'ACTIVAR_LICENCIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(711, 293)
        Me.Controls.Add(Me.datalistado_licencias)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblconectado)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtserial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ACTIVAR_LICENCIA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTIVAR_LICENCIA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datalistado_licencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.desconectado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtserial As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblserialLicencia As System.Windows.Forms.Label
    Friend WithEvents lblserialPc As System.Windows.Forms.Label
    Friend WithEvents LBLSERIAL_LICENCIA_WEB As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timermostrar As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents datalistado_licencias As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn5 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents lblserialPcWEB As System.Windows.Forms.Label
    Friend WithEvents txtfechaWEB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents desconectado As System.Windows.Forms.PictureBox
    Friend WithEvents lblconectado As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
