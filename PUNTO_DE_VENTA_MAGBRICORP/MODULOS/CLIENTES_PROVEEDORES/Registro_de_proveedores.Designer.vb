<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rregistro_de_proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rregistro_de_proveedores))
        Me.txtestado = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblcp = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.VOLVERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarRegistro = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtdirecciondefactura = New System.Windows.Forms.TextBox()
        Me.MenuStrip9 = New System.Windows.Forms.MenuStrip()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcelular = New System.Windows.Forms.TextBox()
        Me.txtnombrecliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7.SuspendLayout()
        Me.MenuStrip9.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(165, 119)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(450, 1)
        Me.Panel4.TabIndex = 533
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.LightGray
        Me.Panel11.Location = New System.Drawing.Point(26, 143)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(600, 1)
        Me.Panel11.TabIndex = 538
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(621, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 47)
        Me.Button1.TabIndex = 527
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.lblcp.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblcp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblcp.ForeColor = System.Drawing.Color.Black
        Me.lblcp.Location = New System.Drawing.Point(0, 0)
        Me.lblcp.Name = "lblcp"
        Me.lblcp.Size = New System.Drawing.Size(279, 47)
        Me.lblcp.TabIndex = 336
        Me.lblcp.Text = "NUEVO REGISTRO"
        Me.lblcp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.Button1)
        Me.Panel7.Controls.Add(Me.Label16)
        Me.Panel7.Controls.Add(Me.lblcp)
        Me.Panel7.Controls.Add(Me.lbltipo)
        Me.Panel7.Controls.Add(Me.txtestado)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(661, 47)
        Me.Panel7.TabIndex = 445
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!)
        Me.lbltipo.ForeColor = System.Drawing.Color.Black
        Me.lbltipo.Location = New System.Drawing.Point(984, 24)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(39, 7)
        Me.lbltipo.TabIndex = 336
        Me.lbltipo.Text = "CLIENTES"
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(164, 89)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(450, 1)
        Me.Panel3.TabIndex = 533
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(164, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(450, 1)
        Me.Panel2.TabIndex = 533
        '
        'txtdirecciondefactura
        '
        Me.txtdirecciondefactura.BackColor = System.Drawing.Color.White
        Me.txtdirecciondefactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdirecciondefactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdirecciondefactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtdirecciondefactura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtdirecciondefactura.Location = New System.Drawing.Point(164, 97)
        Me.txtdirecciondefactura.Name = "txtdirecciondefactura"
        Me.txtdirecciondefactura.Size = New System.Drawing.Size(451, 19)
        Me.txtdirecciondefactura.TabIndex = 328
        Me.txtdirecciondefactura.Text = "0"
        '
        'MenuStrip9
        '
        Me.MenuStrip9.AutoSize = False
        Me.MenuStrip9.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip9.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip9.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarRegistro, Me.VOLVERToolStripMenuItem})
        Me.MenuStrip9.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip9.Location = New System.Drawing.Point(32, 161)
        Me.MenuStrip9.Name = "MenuStrip9"
        Me.MenuStrip9.Size = New System.Drawing.Size(340, 35)
        Me.MenuStrip9.TabIndex = 442
        Me.MenuStrip9.Text = "MenuStrip7"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(63, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 20)
        Me.Label11.TabIndex = 336
        Me.Label11.Text = "Nombre/:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtcelular
        '
        Me.txtcelular.BackColor = System.Drawing.Color.White
        Me.txtcelular.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtcelular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcelular.Location = New System.Drawing.Point(164, 64)
        Me.txtcelular.Name = "txtcelular"
        Me.txtcelular.Size = New System.Drawing.Size(404, 19)
        Me.txtcelular.TabIndex = 328
        Me.txtcelular.Text = "0"
        '
        'txtnombrecliente
        '
        Me.txtnombrecliente.BackColor = System.Drawing.Color.White
        Me.txtnombrecliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnombrecliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombrecliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtnombrecliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtnombrecliente.Location = New System.Drawing.Point(163, 29)
        Me.txtnombrecliente.Name = "txtnombrecliente"
        Me.txtnombrecliente.Size = New System.Drawing.Size(452, 19)
        Me.txtnombrecliente.TabIndex = 328
        Me.txtnombrecliente.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(58, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 336
        Me.Label2.Text = "Direccion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(46, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 336
        Me.Label1.Text = "Celular/ Tel."
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Controls.Add(Me.Panel11)
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
        Me.Panel6.Location = New System.Drawing.Point(0, 47)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(661, 215)
        Me.Panel6.TabIndex = 446
        '
        'Rregistro_de_proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 262)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Rregistro_de_proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rregistro_de_proveedores"
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.MenuStrip9.ResumeLayout(False)
        Me.MenuStrip9.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtestado As CheckBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents lblcp As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lbltipo As Label
    Friend WithEvents VOLVERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarRegistro As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtdirecciondefactura As TextBox
    Friend WithEvents MenuStrip9 As MenuStrip
    Friend WithEvents Label11 As Label
    Friend WithEvents txtcelular As TextBox
    Friend WithEvents txtnombrecliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
End Class
