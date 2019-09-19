<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CANTIDAD_A_GRANEL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CANTIDAD_A_GRANEL))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.BTN_SEGUIR_AGREGANDO = New System.Windows.Forms.Button()
        Me.txtprecio_actual = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtprecio_unitario = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblstock = New System.Windows.Forms.Label()
        Me.LblcantidadAumentar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(452, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 39)
        Me.Button1.TabIndex = 544
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold)
        Me.txtcantidad.Location = New System.Drawing.Point(37, 110)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(163, 45)
        Me.txtcantidad.TabIndex = 543
        '
        'btn_insertar
        '
        Me.btn_insertar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btn_insertar.FlatAppearance.BorderSize = 0
        Me.btn_insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_insertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_insertar.ForeColor = System.Drawing.Color.Black
        Me.btn_insertar.Location = New System.Drawing.Point(452, 69)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(157, 39)
        Me.btn_insertar.TabIndex = 540
        Me.btn_insertar.Text = "+ AGREGAR"
        Me.btn_insertar.UseVisualStyleBackColor = False
        '
        'BTN_SEGUIR_AGREGANDO
        '
        Me.BTN_SEGUIR_AGREGANDO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.BTN_SEGUIR_AGREGANDO.FlatAppearance.BorderSize = 0
        Me.BTN_SEGUIR_AGREGANDO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SEGUIR_AGREGANDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_SEGUIR_AGREGANDO.ForeColor = System.Drawing.Color.Black
        Me.BTN_SEGUIR_AGREGANDO.Location = New System.Drawing.Point(452, 69)
        Me.BTN_SEGUIR_AGREGANDO.Name = "BTN_SEGUIR_AGREGANDO"
        Me.BTN_SEGUIR_AGREGANDO.Size = New System.Drawing.Size(157, 39)
        Me.BTN_SEGUIR_AGREGANDO.TabIndex = 541
        Me.BTN_SEGUIR_AGREGANDO.Text = "+ AGREGAR"
        Me.BTN_SEGUIR_AGREGANDO.UseVisualStyleBackColor = False
        '
        'txtprecio_actual
        '
        Me.txtprecio_actual.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold)
        Me.txtprecio_actual.Location = New System.Drawing.Point(235, 110)
        Me.txtprecio_actual.Name = "txtprecio_actual"
        Me.txtprecio_actual.Size = New System.Drawing.Size(205, 45)
        Me.txtprecio_actual.TabIndex = 542
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label27.ForeColor = System.Drawing.Color.Gray
        Me.Label27.Location = New System.Drawing.Point(274, 83)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(137, 25)
        Me.Label27.TabIndex = 535
        Me.Label27.Text = "Importe Actual"
        '
        'txtProducto
        '
        Me.txtProducto.AutoSize = True
        Me.txtProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold)
        Me.txtProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.txtProducto.Location = New System.Drawing.Point(1, 1)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(172, 39)
        Me.txtProducto.TabIndex = 536
        Me.txtProducto.Text = "Cantidad:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(59, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 25)
        Me.Label14.TabIndex = 537
        Me.Label14.Text = "Cantidad:"
        '
        'txtprecio_unitario
        '
        Me.txtprecio_unitario.AutoSize = True
        Me.txtprecio_unitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtprecio_unitario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.txtprecio_unitario.Location = New System.Drawing.Point(241, 169)
        Me.txtprecio_unitario.Name = "txtprecio_unitario"
        Me.txtprecio_unitario.Size = New System.Drawing.Size(30, 31)
        Me.txtprecio_unitario.TabIndex = 538
        Me.txtprecio_unitario.Text = "0"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Label38.Location = New System.Drawing.Point(12, 169)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(235, 31)
        Me.Label38.TabIndex = 539
        Me.Label38.Text = "Precio unitario = "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(479, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 537
        Me.Label1.Text = "Stock:"
        '
        'lblstock
        '
        Me.lblstock.AutoSize = True
        Me.lblstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblstock.ForeColor = System.Drawing.Color.DarkGray
        Me.lblstock.Location = New System.Drawing.Point(547, 169)
        Me.lblstock.Name = "lblstock"
        Me.lblstock.Size = New System.Drawing.Size(62, 25)
        Me.lblstock.TabIndex = 537
        Me.lblstock.Text = "Stock"
        '
        'LblcantidadAumentar
        '
        Me.LblcantidadAumentar.AutoSize = True
        Me.LblcantidadAumentar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LblcantidadAumentar.ForeColor = System.Drawing.Color.Gray
        Me.LblcantidadAumentar.Location = New System.Drawing.Point(3, 40)
        Me.LblcantidadAumentar.Name = "LblcantidadAumentar"
        Me.LblcantidadAumentar.Size = New System.Drawing.Size(197, 25)
        Me.LblcantidadAumentar.TabIndex = 535
        Me.LblcantidadAumentar.Text = "Cantidad a Aumentar"
        Me.LblcantidadAumentar.Visible = False
        '
        'CANTIDAD_A_GRANEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(628, 218)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.btn_insertar)
        Me.Controls.Add(Me.BTN_SEGUIR_AGREGANDO)
        Me.Controls.Add(Me.txtprecio_actual)
        Me.Controls.Add(Me.LblcantidadAumentar)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.lblstock)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtprecio_unitario)
        Me.Controls.Add(Me.Label38)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "CANTIDAD_A_GRANEL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents btn_insertar As System.Windows.Forms.Button
    Friend WithEvents BTN_SEGUIR_AGREGANDO As System.Windows.Forms.Button
    Friend WithEvents txtprecio_actual As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtProducto As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtprecio_unitario As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblstock As System.Windows.Forms.Label
    Friend WithEvents LblcantidadAumentar As System.Windows.Forms.Label
End Class
