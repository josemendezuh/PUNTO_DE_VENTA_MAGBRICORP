<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventas_en_espera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas_en_espera))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panelventasespera = New System.Windows.Forms.Panel()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.txtbusca = New System.Windows.Forms.TextBox()
        Me.MenuStrip20 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.datalistado_ventas_en_espera = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.MenuStrip18 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblfechadeventa = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.datalistadodetalledeventasarestaurar = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panelventasespera.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.Panel29.SuspendLayout()
        Me.Panel28.SuspendLayout()
        Me.MenuStrip20.SuspendLayout()
        CType(Me.datalistado_ventas_en_espera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel26.SuspendLayout()
        Me.Panel27.SuspendLayout()
        Me.MenuStrip18.SuspendLayout()
        CType(Me.datalistadodetalledeventasarestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panelventasespera
        '
        Me.Panelventasespera.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panelventasespera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panelventasespera.Controls.Add(Me.Panel25)
        Me.Panelventasespera.Controls.Add(Me.Panel29)
        Me.Panelventasespera.Controls.Add(Me.Panel26)
        Me.Panelventasespera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelventasespera.Location = New System.Drawing.Point(0, 0)
        Me.Panelventasespera.Name = "Panelventasespera"
        Me.Panelventasespera.Size = New System.Drawing.Size(977, 408)
        Me.Panelventasespera.TabIndex = 396
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel25.Controls.Add(Me.Label60)
        Me.Panel25.Location = New System.Drawing.Point(5, 7)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(303, 50)
        Me.Panel25.TabIndex = 403
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.White
        Me.Label60.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label60.ForeColor = System.Drawing.Color.Black
        Me.Label60.Location = New System.Drawing.Point(0, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(303, 50)
        Me.Label60.TabIndex = 4
        Me.Label60.Text = "Ventas en Espera"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel29
        '
        Me.Panel29.BackColor = System.Drawing.Color.White
        Me.Panel29.Controls.Add(Me.Panel28)
        Me.Panel29.Controls.Add(Me.datalistado_ventas_en_espera)
        Me.Panel29.Location = New System.Drawing.Point(5, 54)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(303, 314)
        Me.Panel29.TabIndex = 499
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.White
        Me.Panel28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel28.Controls.Add(Me.txtbusca)
        Me.Panel28.Controls.Add(Me.MenuStrip20)
        Me.Panel28.Location = New System.Drawing.Point(3, 9)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(297, 30)
        Me.Panel28.TabIndex = 498
        '
        'txtbusca
        '
        Me.txtbusca.BackColor = System.Drawing.Color.White
        Me.txtbusca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbusca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbusca.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtbusca.ForeColor = System.Drawing.Color.Black
        Me.txtbusca.Location = New System.Drawing.Point(35, 3)
        Me.txtbusca.Name = "txtbusca"
        Me.txtbusca.Size = New System.Drawing.Size(257, 22)
        Me.txtbusca.TabIndex = 496
        '
        'MenuStrip20
        '
        Me.MenuStrip20.BackColor = System.Drawing.Color.White
        Me.MenuStrip20.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip20.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem14})
        Me.MenuStrip20.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip20.Location = New System.Drawing.Point(1, 3)
        Me.MenuStrip20.Name = "MenuStrip20"
        Me.MenuStrip20.ShowItemToolTips = True
        Me.MenuStrip20.Size = New System.Drawing.Size(36, 24)
        Me.MenuStrip20.TabIndex = 497
        Me.MenuStrip20.Text = "MenuStrip20"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.BackColor = System.Drawing.Color.White
        Me.ToolStripMenuItem14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripMenuItem14.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem14.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem14.Image = CType(resources.GetObject("ToolStripMenuItem14.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(28, 20)
        Me.ToolStripMenuItem14.Text = "+"
        Me.ToolStripMenuItem14.ToolTipText = "Guardar "
        '
        'datalistado_ventas_en_espera
        '
        Me.datalistado_ventas_en_espera.AllowUserToAddRows = False
        Me.datalistado_ventas_en_espera.AllowUserToDeleteRows = False
        Me.datalistado_ventas_en_espera.AllowUserToResizeRows = False
        Me.datalistado_ventas_en_espera.BackgroundColor = System.Drawing.Color.White
        Me.datalistado_ventas_en_espera.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistado_ventas_en_espera.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_ventas_en_espera.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datalistado_ventas_en_espera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado_ventas_en_espera.ColumnHeadersVisible = False
        Me.datalistado_ventas_en_espera.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn6})
        Me.datalistado_ventas_en_espera.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.datalistado_ventas_en_espera.EnableHeadersVisualStyles = False
        Me.datalistado_ventas_en_espera.GridColor = System.Drawing.Color.Gainsboro
        Me.datalistado_ventas_en_espera.Location = New System.Drawing.Point(0, 45)
        Me.datalistado_ventas_en_espera.Name = "datalistado_ventas_en_espera"
        Me.datalistado_ventas_en_espera.ReadOnly = True
        Me.datalistado_ventas_en_espera.RowHeadersVisible = False
        Me.datalistado_ventas_en_espera.RowHeadersWidth = 9
        Me.datalistado_ventas_en_espera.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.datalistado_ventas_en_espera.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.datalistado_ventas_en_espera.RowTemplate.Height = 33
        Me.datalistado_ventas_en_espera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado_ventas_en_espera.Size = New System.Drawing.Size(303, 269)
        Me.datalistado_ventas_en_espera.TabIndex = 393
        '
        'DataGridViewCheckBoxColumn6
        '
        Me.DataGridViewCheckBoxColumn6.DataPropertyName = "Marcar"
        Me.DataGridViewCheckBoxColumn6.HeaderText = "Marcar"
        Me.DataGridViewCheckBoxColumn6.Name = "DataGridViewCheckBoxColumn6"
        Me.DataGridViewCheckBoxColumn6.ReadOnly = True
        Me.DataGridViewCheckBoxColumn6.Visible = False
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.White
        Me.Panel26.Controls.Add(Me.Panel27)
        Me.Panel26.Controls.Add(Me.lblfechadeventa)
        Me.Panel26.Controls.Add(Me.Label39)
        Me.Panel26.Controls.Add(Me.datalistadodetalledeventasarestaurar)
        Me.Panel26.Location = New System.Drawing.Point(311, 7)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(661, 361)
        Me.Panel26.TabIndex = 405
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel27.Controls.Add(Me.MenuStrip18)
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel27.Location = New System.Drawing.Point(0, 0)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(661, 50)
        Me.Panel27.TabIndex = 405
        '
        'MenuStrip18
        '
        Me.MenuStrip18.AutoSize = False
        Me.MenuStrip18.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip18.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip18.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6, Me.ToolStripMenuItem13, Me.ToolStripMenuItem18})
        Me.MenuStrip18.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip18.Location = New System.Drawing.Point(9, 6)
        Me.MenuStrip18.Name = "MenuStrip18"
        Me.MenuStrip18.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip18.ShowItemToolTips = True
        Me.MenuStrip18.Size = New System.Drawing.Size(389, 37)
        Me.MenuStrip18.TabIndex = 401
        Me.MenuStrip18.Text = "MenuStrip7"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripMenuItem6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem6.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem6.Image = CType(resources.GetObject("ToolStripMenuItem6.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(125, 33)
        Me.ToolStripMenuItem6.Text = "Restaurar Venta"
        Me.ToolStripMenuItem6.ToolTipText = "Guardar "
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolStripMenuItem13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem13.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(54, 33)
        Me.ToolStripMenuItem13.Text = "Cerrar"
        Me.ToolStripMenuItem13.ToolTipText = "Cerrar"
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem18.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem18.Image = CType(resources.GetObject("ToolStripMenuItem18.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(114, 33)
        Me.ToolStripMenuItem18.Text = "Eliminar venta"
        Me.ToolStripMenuItem18.ToolTipText = "Eliminar venta"
        '
        'lblfechadeventa
        '
        Me.lblfechadeventa.AutoSize = True
        Me.lblfechadeventa.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblfechadeventa.Location = New System.Drawing.Point(143, 57)
        Me.lblfechadeventa.Name = "lblfechadeventa"
        Me.lblfechadeventa.Size = New System.Drawing.Size(86, 13)
        Me.lblfechadeventa.TabIndex = 404
        Me.lblfechadeventa.Text = "Fecha de Venta:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label39.Location = New System.Drawing.Point(9, 57)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(129, 18)
        Me.Label39.TabIndex = 404
        Me.Label39.Text = "Fecha de Venta:"
        '
        'datalistadodetalledeventasarestaurar
        '
        Me.datalistadodetalledeventasarestaurar.AllowUserToAddRows = False
        Me.datalistadodetalledeventasarestaurar.AllowUserToDeleteRows = False
        Me.datalistadodetalledeventasarestaurar.AllowUserToResizeRows = False
        Me.datalistadodetalledeventasarestaurar.BackgroundColor = System.Drawing.Color.White
        Me.datalistadodetalledeventasarestaurar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistadodetalledeventasarestaurar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datalistadodetalledeventasarestaurar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistadodetalledeventasarestaurar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistadodetalledeventasarestaurar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistadodetalledeventasarestaurar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn8})
        Me.datalistadodetalledeventasarestaurar.EnableHeadersVisualStyles = False
        Me.datalistadodetalledeventasarestaurar.GridColor = System.Drawing.Color.Gainsboro
        Me.datalistadodetalledeventasarestaurar.Location = New System.Drawing.Point(14, 83)
        Me.datalistadodetalledeventasarestaurar.Name = "datalistadodetalledeventasarestaurar"
        Me.datalistadodetalledeventasarestaurar.ReadOnly = True
        Me.datalistadodetalledeventasarestaurar.RowHeadersVisible = False
        Me.datalistadodetalledeventasarestaurar.RowHeadersWidth = 9
        Me.datalistadodetalledeventasarestaurar.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.datalistadodetalledeventasarestaurar.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datalistadodetalledeventasarestaurar.RowTemplate.Height = 35
        Me.datalistadodetalledeventasarestaurar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistadodetalledeventasarestaurar.Size = New System.Drawing.Size(639, 275)
        Me.datalistadodetalledeventasarestaurar.TabIndex = 393
        '
        'DataGridViewCheckBoxColumn8
        '
        Me.DataGridViewCheckBoxColumn8.DataPropertyName = "Marcar"
        Me.DataGridViewCheckBoxColumn8.HeaderText = "Marcar"
        Me.DataGridViewCheckBoxColumn8.Name = "DataGridViewCheckBoxColumn8"
        Me.DataGridViewCheckBoxColumn8.ReadOnly = True
        Me.DataGridViewCheckBoxColumn8.Visible = False
        '
        'Ventas_en_espera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 408)
        Me.Controls.Add(Me.Panelventasespera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ventas_en_espera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panelventasespera.ResumeLayout(False)
        Me.Panel25.ResumeLayout(False)
        Me.Panel29.ResumeLayout(False)
        Me.Panel28.ResumeLayout(False)
        Me.Panel28.PerformLayout()
        Me.MenuStrip20.ResumeLayout(False)
        Me.MenuStrip20.PerformLayout()
        CType(Me.datalistado_ventas_en_espera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel26.ResumeLayout(False)
        Me.Panel26.PerformLayout()
        Me.Panel27.ResumeLayout(False)
        Me.MenuStrip18.ResumeLayout(False)
        Me.MenuStrip18.PerformLayout()
        CType(Me.datalistadodetalledeventasarestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panelventasespera As System.Windows.Forms.Panel
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Panel29 As System.Windows.Forms.Panel
    Friend WithEvents Panel28 As System.Windows.Forms.Panel
    Friend WithEvents txtbusca As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip20 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents datalistado_ventas_en_espera As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Panel26 As System.Windows.Forms.Panel
    Friend WithEvents Panel27 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip18 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblfechadeventa As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents datalistadodetalledeventasarestaurar As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn8 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
