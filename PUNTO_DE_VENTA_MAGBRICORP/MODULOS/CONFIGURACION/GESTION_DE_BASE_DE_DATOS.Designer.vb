<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GESTION_DE_BASE_DE_DATOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GESTION_DE_BASE_DE_DATOS))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ventas = New System.Windows.Forms.CheckBox()
        Me.productos = New System.Windows.Forms.CheckBox()
        Me.clientes = New System.Windows.Forms.CheckBox()
        Me.cierresCaja = New System.Windows.Forms.CheckBox()
        Me.Gastos = New System.Windows.Forms.CheckBox()
        Me.lblventas = New System.Windows.Forms.Label()
        Me.lblproductos = New System.Windows.Forms.Label()
        Me.lblclientes = New System.Windows.Forms.Label()
        Me.lblcierrecaja = New System.Windows.Forms.Label()
        Me.lblgastos = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel12.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(15, 222)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(305, 43)
        Me.Button2.TabIndex = 606
        Me.Button2.Text = "Limpiar Base de Datos"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel12.Controls.Add(Me.Button5)
        Me.Panel12.Controls.Add(Me.Label1)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(332, 45)
        Me.Panel12.TabIndex = 607
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(300, 8)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(29, 28)
        Me.Button5.TabIndex = 528
        Me.Button5.Text = "X"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Base de Datos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 17)
        Me.Label3.TabIndex = 608
        Me.Label3.Text = "Se Eliminaran Estos Registros:"
        '
        'ventas
        '
        Me.ventas.AutoSize = True
        Me.ventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ventas.Location = New System.Drawing.Point(15, 95)
        Me.ventas.Name = "ventas"
        Me.ventas.Size = New System.Drawing.Size(71, 21)
        Me.ventas.TabIndex = 609
        Me.ventas.Text = "Ventas"
        Me.ventas.UseVisualStyleBackColor = True
        '
        'productos
        '
        Me.productos.AutoSize = True
        Me.productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.productos.Location = New System.Drawing.Point(15, 118)
        Me.productos.Name = "productos"
        Me.productos.Size = New System.Drawing.Size(91, 21)
        Me.productos.TabIndex = 609
        Me.productos.Text = "Productos"
        Me.productos.UseVisualStyleBackColor = True
        '
        'clientes
        '
        Me.clientes.AutoSize = True
        Me.clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.clientes.Location = New System.Drawing.Point(15, 141)
        Me.clientes.Name = "clientes"
        Me.clientes.Size = New System.Drawing.Size(173, 21)
        Me.clientes.TabIndex = 609
        Me.clientes.Text = "Clientes y Proveedores"
        Me.clientes.UseVisualStyleBackColor = True
        '
        'cierresCaja
        '
        Me.cierresCaja.AutoSize = True
        Me.cierresCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cierresCaja.Location = New System.Drawing.Point(15, 168)
        Me.cierresCaja.Name = "cierresCaja"
        Me.cierresCaja.Size = New System.Drawing.Size(201, 21)
        Me.cierresCaja.TabIndex = 609
        Me.cierresCaja.Text = "Cierres y Aperturas de Caja"
        Me.cierresCaja.UseVisualStyleBackColor = True
        '
        'Gastos
        '
        Me.Gastos.AutoSize = True
        Me.Gastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Gastos.Location = New System.Drawing.Point(15, 195)
        Me.Gastos.Name = "Gastos"
        Me.Gastos.Size = New System.Drawing.Size(185, 21)
        Me.Gastos.TabIndex = 609
        Me.Gastos.Text = "Gastos y Ingresos Varios"
        Me.Gastos.UseVisualStyleBackColor = True
        '
        'lblventas
        '
        Me.lblventas.AutoSize = True
        Me.lblventas.BackColor = System.Drawing.Color.White
        Me.lblventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblventas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblventas.Location = New System.Drawing.Point(14, 17)
        Me.lblventas.Name = "lblventas"
        Me.lblventas.Size = New System.Drawing.Size(202, 17)
        Me.lblventas.TabIndex = 608
        Me.lblventas.Text = "Se Eliminaran Estos Registros:"
        '
        'lblproductos
        '
        Me.lblproductos.AutoSize = True
        Me.lblproductos.BackColor = System.Drawing.Color.White
        Me.lblproductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblproductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblproductos.Location = New System.Drawing.Point(74, 50)
        Me.lblproductos.Name = "lblproductos"
        Me.lblproductos.Size = New System.Drawing.Size(202, 17)
        Me.lblproductos.TabIndex = 608
        Me.lblproductos.Text = "Se Eliminaran Estos Registros:"
        '
        'lblclientes
        '
        Me.lblclientes.AutoSize = True
        Me.lblclientes.BackColor = System.Drawing.Color.White
        Me.lblclientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblclientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblclientes.Location = New System.Drawing.Point(31, 74)
        Me.lblclientes.Name = "lblclientes"
        Me.lblclientes.Size = New System.Drawing.Size(202, 17)
        Me.lblclientes.TabIndex = 608
        Me.lblclientes.Text = "Se Eliminaran Estos Registros:"
        '
        'lblcierrecaja
        '
        Me.lblcierrecaja.AutoSize = True
        Me.lblcierrecaja.BackColor = System.Drawing.Color.White
        Me.lblcierrecaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblcierrecaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblcierrecaja.Location = New System.Drawing.Point(116, 104)
        Me.lblcierrecaja.Name = "lblcierrecaja"
        Me.lblcierrecaja.Size = New System.Drawing.Size(202, 17)
        Me.lblcierrecaja.TabIndex = 608
        Me.lblcierrecaja.Text = "Se Eliminaran Estos Registros:"
        '
        'lblgastos
        '
        Me.lblgastos.AutoSize = True
        Me.lblgastos.BackColor = System.Drawing.Color.White
        Me.lblgastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblgastos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblgastos.Location = New System.Drawing.Point(104, 136)
        Me.lblgastos.Name = "lblgastos"
        Me.lblgastos.Size = New System.Drawing.Size(202, 17)
        Me.lblgastos.TabIndex = 608
        Me.lblgastos.Text = "Se Eliminaran Estos Registros:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblgastos)
        Me.Panel1.Controls.Add(Me.lblcierrecaja)
        Me.Panel1.Controls.Add(Me.lblclientes)
        Me.Panel1.Controls.Add(Me.lblproductos)
        Me.Panel1.Controls.Add(Me.lblventas)
        Me.Panel1.Location = New System.Drawing.Point(65, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 10)
        Me.Panel1.TabIndex = 610
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 271)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 223)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 611
        Me.PictureBox1.TabStop = False
        '
        'GESTION_DE_BASE_DE_DATOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(332, 521)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Gastos)
        Me.Controls.Add(Me.cierresCaja)
        Me.Controls.Add(Me.clientes)
        Me.Controls.Add(Me.productos)
        Me.Controls.Add(Me.ventas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel12)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GESTION_DE_BASE_DE_DATOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Base de datos"
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ventas As CheckBox
    Friend WithEvents productos As CheckBox
    Friend WithEvents clientes As CheckBox
    Friend WithEvents cierresCaja As CheckBox
    Friend WithEvents Gastos As CheckBox
    Friend WithEvents lblventas As Label
    Friend WithEvents lblproductos As Label
    Friend WithEvents lblclientes As Label
    Friend WithEvents lblcierrecaja As Label
    Friend WithEvents lblgastos As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
