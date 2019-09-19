<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CANTIDAD_DE_PRODUCTOS_VARIOS
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.BTN_SEGUIR_AGREGANDO = New System.Windows.Forms.Button()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.txtunidad = New System.Windows.Forms.ComboBox()
        Me.txtpantalla = New System.Windows.Forms.TextBox()
        Me.MenuStrip7 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_unidadoka = New System.Windows.Forms.Label()
        Me.dtund = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtprecio_por_unidad_De_medida = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.LBL_CANTIDAD_UNIDAD_MEDIDA = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel10.SuspendLayout()
        Me.MenuStrip7.SuspendLayout()
        CType(Me.dtund, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.Controls.Add(Me.Button4)
        Me.Panel10.Controls.Add(Me.Label27)
        Me.Panel10.Controls.Add(Me.BTN_SEGUIR_AGREGANDO)
        Me.Panel10.Controls.Add(Me.btn_insertar)
        Me.Panel10.Controls.Add(Me.txtunidad)
        Me.Panel10.Controls.Add(Me.txtpantalla)
        Me.Panel10.Controls.Add(Me.MenuStrip7)
        Me.Panel10.Controls.Add(Me.lbl_unidadoka)
        Me.Panel10.Controls.Add(Me.dtund)
        Me.Panel10.Controls.Add(Me.txtprecio_por_unidad_De_medida)
        Me.Panel10.Controls.Add(Me.txtprecio)
        Me.Panel10.Controls.Add(Me.Label37)
        Me.Panel10.Controls.Add(Me.LBL_CANTIDAD_UNIDAD_MEDIDA)
        Me.Panel10.Controls.Add(Me.Label38)
        Me.Panel10.Controls.Add(Me.Label39)
        Me.Panel10.Controls.Add(Me.Label14)
        Me.Panel10.Location = New System.Drawing.Point(3, -3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(668, 160)
        Me.Panel10.TabIndex = 536
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(633, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 41)
        Me.Button4.TabIndex = 534
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.White
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label27.ForeColor = System.Drawing.Color.Gray
        Me.Label27.Location = New System.Drawing.Point(19, 10)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(73, 20)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Cantidad"
        '
        'BTN_SEGUIR_AGREGANDO
        '
        Me.BTN_SEGUIR_AGREGANDO.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BTN_SEGUIR_AGREGANDO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SEGUIR_AGREGANDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BTN_SEGUIR_AGREGANDO.ForeColor = System.Drawing.Color.White
        Me.BTN_SEGUIR_AGREGANDO.Location = New System.Drawing.Point(148, 116)
        Me.BTN_SEGUIR_AGREGANDO.Name = "BTN_SEGUIR_AGREGANDO"
        Me.BTN_SEGUIR_AGREGANDO.Size = New System.Drawing.Size(159, 39)
        Me.BTN_SEGUIR_AGREGANDO.TabIndex = 2
        Me.BTN_SEGUIR_AGREGANDO.Text = "+ AGREGAR"
        Me.BTN_SEGUIR_AGREGANDO.UseVisualStyleBackColor = False
        '
        'btn_insertar
        '
        Me.btn_insertar.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btn_insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_insertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_insertar.ForeColor = System.Drawing.Color.White
        Me.btn_insertar.Location = New System.Drawing.Point(148, 116)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(159, 39)
        Me.btn_insertar.TabIndex = 2
        Me.btn_insertar.Text = "+ AGREGAR"
        Me.btn_insertar.UseVisualStyleBackColor = False
        '
        'txtunidad
        '
        Me.txtunidad.BackColor = System.Drawing.Color.White
        Me.txtunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtunidad.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtunidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtunidad.FormattingEnabled = True
        Me.txtunidad.Location = New System.Drawing.Point(116, 7)
        Me.txtunidad.Name = "txtunidad"
        Me.txtunidad.Size = New System.Drawing.Size(176, 28)
        Me.txtunidad.TabIndex = 467
        '
        'txtpantalla
        '
        Me.txtpantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtpantalla.Location = New System.Drawing.Point(9, 7)
        Me.txtpantalla.Name = "txtpantalla"
        Me.txtpantalla.Size = New System.Drawing.Size(101, 29)
        Me.txtpantalla.TabIndex = 533
        '
        'MenuStrip7
        '
        Me.MenuStrip7.AutoSize = False
        Me.MenuStrip7.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip7.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip7.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem10})
        Me.MenuStrip7.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip7.Location = New System.Drawing.Point(295, 2)
        Me.MenuStrip7.Name = "MenuStrip7"
        Me.MenuStrip7.ShowItemToolTips = True
        Me.MenuStrip7.Size = New System.Drawing.Size(71, 43)
        Me.MenuStrip7.TabIndex = 400
        Me.MenuStrip7.Text = "MenuStrip7"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.AutoSize = False
        Me.ToolStripMenuItem10.BackColor = System.Drawing.Color.SeaGreen
        Me.ToolStripMenuItem10.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.ToolStripMenuItem10.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(30, 30)
        Me.ToolStripMenuItem10.Text = "+"
        Me.ToolStripMenuItem10.ToolTipText = "Guardar "
        '
        'lbl_unidadoka
        '
        Me.lbl_unidadoka.AutoSize = True
        Me.lbl_unidadoka.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_unidadoka.ForeColor = System.Drawing.Color.Gray
        Me.lbl_unidadoka.Location = New System.Drawing.Point(318, 45)
        Me.lbl_unidadoka.Name = "lbl_unidadoka"
        Me.lbl_unidadoka.Size = New System.Drawing.Size(141, 25)
        Me.lbl_unidadoka.TabIndex = 0
        Me.lbl_unidadoka.Text = " X Precio: S/."
        '
        'dtund
        '
        Me.dtund.AllowUserToAddRows = False
        Me.dtund.AllowUserToDeleteRows = False
        Me.dtund.AllowUserToResizeRows = False
        Me.dtund.BackgroundColor = System.Drawing.Color.White
        Me.dtund.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtund.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtund.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtund.ColumnHeadersVisible = False
        Me.dtund.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn5})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtund.DefaultCellStyle = DataGridViewCellStyle5
        Me.dtund.EnableHeadersVisualStyles = False
        Me.dtund.Location = New System.Drawing.Point(125, 16)
        Me.dtund.Name = "dtund"
        Me.dtund.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtund.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dtund.RowHeadersVisible = False
        Me.dtund.RowHeadersWidth = 5
        Me.dtund.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.ForestGreen
        Me.dtund.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtund.Size = New System.Drawing.Size(25, 10)
        Me.dtund.TabIndex = 532
        Me.dtund.Visible = False
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "Activo"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        Me.DataGridViewCheckBoxColumn5.ReadOnly = True
        Me.DataGridViewCheckBoxColumn5.Visible = False
        '
        'txtprecio_por_unidad_De_medida
        '
        Me.txtprecio_por_unidad_De_medida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtprecio_por_unidad_De_medida.Location = New System.Drawing.Point(148, 43)
        Me.txtprecio_por_unidad_De_medida.Name = "txtprecio_por_unidad_De_medida"
        Me.txtprecio_por_unidad_De_medida.Size = New System.Drawing.Size(138, 26)
        Me.txtprecio_por_unidad_De_medida.TabIndex = 494
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtprecio.Location = New System.Drawing.Point(148, 75)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(138, 26)
        Me.txtprecio.TabIndex = 494
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label37.ForeColor = System.Drawing.Color.DimGray
        Me.Label37.Location = New System.Drawing.Point(4, 76)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(138, 25)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "Precio Unt: S/."
        '
        'LBL_CANTIDAD_UNIDAD_MEDIDA
        '
        Me.LBL_CANTIDAD_UNIDAD_MEDIDA.AutoSize = True
        Me.LBL_CANTIDAD_UNIDAD_MEDIDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LBL_CANTIDAD_UNIDAD_MEDIDA.ForeColor = System.Drawing.Color.Black
        Me.LBL_CANTIDAD_UNIDAD_MEDIDA.Location = New System.Drawing.Point(519, 100)
        Me.LBL_CANTIDAD_UNIDAD_MEDIDA.Name = "LBL_CANTIDAD_UNIDAD_MEDIDA"
        Me.LBL_CANTIDAD_UNIDAD_MEDIDA.Size = New System.Drawing.Size(103, 25)
        Me.LBL_CANTIDAD_UNIDAD_MEDIDA.TabIndex = 0
        Me.LBL_CANTIDAD_UNIDAD_MEDIDA.Text = "Precio: S/."
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(46, 44)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(103, 25)
        Me.Label38.TabIndex = 0
        Me.Label38.Text = "Precio: S/."
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label39.ForeColor = System.Drawing.Color.Red
        Me.Label39.Location = New System.Drawing.Point(286, 45)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(39, 25)
        Me.Label39.TabIndex = 0
        Me.Label39.Text = " X "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(182, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 20)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Comprobante:"
        '
        'CANTIDAD_DE_PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(698, 160)
        Me.Controls.Add(Me.Panel10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CANTIDAD_DE_PRODUCTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CANTIDAD_DE_PRODUCTOS"
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.MenuStrip7.ResumeLayout(False)
        Me.MenuStrip7.PerformLayout()
        CType(Me.dtund, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents BTN_SEGUIR_AGREGANDO As System.Windows.Forms.Button
    Friend WithEvents btn_insertar As System.Windows.Forms.Button
    Friend WithEvents txtunidad As System.Windows.Forms.ComboBox
    Friend WithEvents txtpantalla As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip7 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_unidadoka As System.Windows.Forms.Label
    Public WithEvents dtund As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn5 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtprecio_por_unidad_De_medida As System.Windows.Forms.TextBox
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents LBL_CANTIDAD_UNIDAD_MEDIDA As System.Windows.Forms.Label
End Class
