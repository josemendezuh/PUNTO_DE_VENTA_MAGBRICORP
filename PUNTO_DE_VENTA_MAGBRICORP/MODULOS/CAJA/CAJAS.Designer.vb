<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAJAS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAJAS))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarCambiosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.p2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcontador = New System.Windows.Forms.Label()
        Me.MenuStrip4 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTPRESENTACIONRESUMIDA = New System.Windows.Forms.Label()
        Me.txtidaula = New System.Windows.Forms.TextBox()
        Me.txtiddocente = New System.Windows.Forms.TextBox()
        Me.txtidpresentacion = New System.Windows.Forms.Label()
        Me.txtidproceso = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TXTPRESENTACION = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.p2.SuspendLayout()
        Me.MenuStrip4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(927, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 36)
        Me.Button4.TabIndex = 543
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.AutoSize = False
        Me.EliminarToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.EliminarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EliminarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(150, 40)
        Me.EliminarToolStripMenuItem.Text = "&Eliminar Seleccion"
        Me.EliminarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarToolStripMenuItem.Visible = False
        '
        'GuardarRegistroToolStripMenuItem
        '
        Me.GuardarRegistroToolStripMenuItem.AutoSize = False
        Me.GuardarRegistroToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro
        Me.GuardarRegistroToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GuardarRegistroToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GuardarRegistroToolStripMenuItem.Name = "GuardarRegistroToolStripMenuItem"
        Me.GuardarRegistroToolStripMenuItem.Size = New System.Drawing.Size(150, 40)
        Me.GuardarRegistroToolStripMenuItem.Text = "&Guardar registro"
        Me.GuardarRegistroToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GuardarCambiosToolStripMenuItem1
        '
        Me.GuardarCambiosToolStripMenuItem1.AutoSize = False
        Me.GuardarCambiosToolStripMenuItem1.BackColor = System.Drawing.Color.Silver
        Me.GuardarCambiosToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GuardarCambiosToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GuardarCambiosToolStripMenuItem1.Name = "GuardarCambiosToolStripMenuItem1"
        Me.GuardarCambiosToolStripMenuItem1.Size = New System.Drawing.Size(150, 40)
        Me.GuardarCambiosToolStripMenuItem1.Text = "&Guardar Cambios"
        Me.GuardarCambiosToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'p2
        '
        Me.p2.BackColor = System.Drawing.Color.Gray
        Me.p2.Controls.Add(Me.Label1)
        Me.p2.Controls.Add(Me.txtcontador)
        Me.p2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.p2.Location = New System.Drawing.Point(158, 294)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(809, 27)
        Me.p2.TabIndex = 539
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(448, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 24)
        Me.Label1.TabIndex = 194
        Me.Label1.Text = "Cantidad de registros:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcontador
        '
        Me.txtcontador.BackColor = System.Drawing.Color.Transparent
        Me.txtcontador.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontador.ForeColor = System.Drawing.Color.Transparent
        Me.txtcontador.Location = New System.Drawing.Point(603, 0)
        Me.txtcontador.Name = "txtcontador"
        Me.txtcontador.Size = New System.Drawing.Size(61, 24)
        Me.txtcontador.TabIndex = 194
        Me.txtcontador.Text = "contador"
        Me.txtcontador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip4
        '
        Me.MenuStrip4.AutoSize = False
        Me.MenuStrip4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip4.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.GuardarRegistroToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.GuardarCambiosToolStripMenuItem1})
        Me.MenuStrip4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip4.Location = New System.Drawing.Point(0, 4)
        Me.MenuStrip4.Name = "MenuStrip4"
        Me.MenuStrip4.ShowItemToolTips = True
        Me.MenuStrip4.Size = New System.Drawing.Size(158, 317)
        Me.MenuStrip4.TabIndex = 538
        Me.MenuStrip4.Text = "MenuStrip4"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.AutoSize = False
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripMenuItem4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(150, 40)
        Me.ToolStripMenuItem4.Text = "&Nuevo Registro "
        Me.ToolStripMenuItem4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(158, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(809, 36)
        Me.Label3.TabIndex = 532
        Me.Label3.Text = "PRESENTACIONES"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTPRESENTACIONRESUMIDA
        '
        Me.TXTPRESENTACIONRESUMIDA.AutoSize = True
        Me.TXTPRESENTACIONRESUMIDA.ForeColor = System.Drawing.Color.Black
        Me.TXTPRESENTACIONRESUMIDA.Location = New System.Drawing.Point(182, 342)
        Me.TXTPRESENTACIONRESUMIDA.Name = "TXTPRESENTACIONRESUMIDA"
        Me.TXTPRESENTACIONRESUMIDA.Size = New System.Drawing.Size(239, 13)
        Me.TXTPRESENTACIONRESUMIDA.TabIndex = 533
        Me.TXTPRESENTACIONRESUMIDA.Text = "Cantidad por unidad de medida por presentacion:"
        '
        'txtidaula
        '
        Me.txtidaula.BackColor = System.Drawing.Color.White
        Me.txtidaula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtidaula.ForeColor = System.Drawing.Color.Black
        Me.txtidaula.Location = New System.Drawing.Point(251, 224)
        Me.txtidaula.Name = "txtidaula"
        Me.txtidaula.Size = New System.Drawing.Size(121, 20)
        Me.txtidaula.TabIndex = 536
        '
        'txtiddocente
        '
        Me.txtiddocente.BackColor = System.Drawing.Color.White
        Me.txtiddocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtiddocente.ForeColor = System.Drawing.Color.Black
        Me.txtiddocente.Location = New System.Drawing.Point(213, 188)
        Me.txtiddocente.Name = "txtiddocente"
        Me.txtiddocente.Size = New System.Drawing.Size(121, 20)
        Me.txtiddocente.TabIndex = 537
        Me.txtiddocente.Visible = False
        '
        'txtidpresentacion
        '
        Me.txtidpresentacion.AutoSize = True
        Me.txtidpresentacion.ForeColor = System.Drawing.Color.Black
        Me.txtidpresentacion.Location = New System.Drawing.Point(290, 64)
        Me.txtidpresentacion.Name = "txtidpresentacion"
        Me.txtidpresentacion.Size = New System.Drawing.Size(151, 13)
        Me.txtidpresentacion.TabIndex = 535
        Me.txtidpresentacion.Text = "Precio de venta al publico S/.:"
        '
        'txtidproceso
        '
        Me.txtidproceso.BackColor = System.Drawing.Color.White
        Me.txtidproceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtidproceso.ForeColor = System.Drawing.Color.Black
        Me.txtidproceso.Location = New System.Drawing.Point(360, 80)
        Me.txtidproceso.Name = "txtidproceso"
        Me.txtidproceso.Size = New System.Drawing.Size(61, 20)
        Me.txtidproceso.TabIndex = 534
        Me.txtidproceso.Text = "0"
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.DimGray
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(566, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(23, 23)
        Me.Button5.TabIndex = 209
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.TXTPRESENTACION)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Panel2.Location = New System.Drawing.Point(193, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(590, 235)
        Me.Panel2.TabIndex = 359
        Me.Panel2.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(588, 4)
        Me.Panel5.TabIndex = 531
        '
        'TXTPRESENTACION
        '
        Me.TXTPRESENTACION.FormattingEnabled = True
        Me.TXTPRESENTACION.Location = New System.Drawing.Point(6, 79)
        Me.TXTPRESENTACION.Name = "TXTPRESENTACION"
        Me.TXTPRESENTACION.Size = New System.Drawing.Size(319, 28)
        Me.TXTPRESENTACION.TabIndex = 351
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(2, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 342
        Me.Label2.Text = "CAJA"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1112, 34)
        Me.Label7.TabIndex = 210
        Me.Label7.Text = "@Nuevo registro"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.BackgroundColor = System.Drawing.Color.White
        Me.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado.DefaultCellStyle = DataGridViewCellStyle5
        Me.datalistado.EnableHeadersVisualStyles = False
        Me.datalistado.Location = New System.Drawing.Point(158, 40)
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
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(809, 254)
        Me.datalistado.TabIndex = 360
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(580, 212)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 75)
        Me.Panel4.TabIndex = 542
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(967, 4)
        Me.Panel7.TabIndex = 544
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(602, 140)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(213, 48)
        Me.Panel3.TabIndex = 541
        '
        'CAJAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 321)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.datalistado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.MenuStrip4)
        Me.Controls.Add(Me.TXTPRESENTACIONRESUMIDA)
        Me.Controls.Add(Me.txtidaula)
        Me.Controls.Add(Me.txtiddocente)
        Me.Controls.Add(Me.txtidpresentacion)
        Me.Controls.Add(Me.txtidproceso)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CAJAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAJAS"
        Me.p2.ResumeLayout(False)
        Me.MenuStrip4.ResumeLayout(False)
        Me.MenuStrip4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarRegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarCambiosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents p2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcontador As System.Windows.Forms.Label
    Friend WithEvents MenuStrip4 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTPRESENTACIONRESUMIDA As System.Windows.Forms.Label
    Friend WithEvents txtidaula As System.Windows.Forms.TextBox
    Friend WithEvents txtiddocente As System.Windows.Forms.TextBox
    Friend WithEvents txtidpresentacion As System.Windows.Forms.Label
    Friend WithEvents txtidproceso As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents TXTPRESENTACION As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
