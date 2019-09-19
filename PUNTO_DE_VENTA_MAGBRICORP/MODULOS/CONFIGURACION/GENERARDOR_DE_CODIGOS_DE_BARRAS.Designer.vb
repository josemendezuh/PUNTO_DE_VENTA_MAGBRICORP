<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GENERARDOR_DE_CODIGOS_DE_BARRAS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GENERARDOR_DE_CODIGOS_DE_BARRAS))
        Me.RadioButton128 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonQR = New System.Windows.Forms.RadioButton()
        Me.ButtonGUARDAR = New System.Windows.Forms.Button()
        Me.RadioButtonPDF417 = New System.Windows.Forms.RadioButton()
        Me.TextBoxGENERAR = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TextBoxLEER = New System.Windows.Forms.TextBox()
        Me.ButtonLEER = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonIMPRIMIR = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxGENERAR = New System.Windows.Forms.PictureBox()
        Me.PictureBoxLEER = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxGENERAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLEER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadioButton128
        '
        Me.RadioButton128.AutoSize = True
        Me.RadioButton128.Location = New System.Drawing.Point(177, 97)
        Me.RadioButton128.Name = "RadioButton128"
        Me.RadioButton128.Size = New System.Drawing.Size(43, 17)
        Me.RadioButton128.TabIndex = 117
        Me.RadioButton128.Text = "128"
        Me.RadioButton128.UseVisualStyleBackColor = True
        '
        'RadioButtonQR
        '
        Me.RadioButtonQR.AutoSize = True
        Me.RadioButtonQR.Checked = True
        Me.RadioButtonQR.Location = New System.Drawing.Point(278, 97)
        Me.RadioButtonQR.Name = "RadioButtonQR"
        Me.RadioButtonQR.Size = New System.Drawing.Size(41, 17)
        Me.RadioButtonQR.TabIndex = 116
        Me.RadioButtonQR.TabStop = True
        Me.RadioButtonQR.Text = "QR"
        Me.RadioButtonQR.UseVisualStyleBackColor = True
        '
        'ButtonGUARDAR
        '
        Me.ButtonGUARDAR.BackColor = System.Drawing.Color.Teal
        Me.ButtonGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonGUARDAR.ForeColor = System.Drawing.Color.White
        Me.ButtonGUARDAR.Location = New System.Drawing.Point(218, 313)
        Me.ButtonGUARDAR.Name = "ButtonGUARDAR"
        Me.ButtonGUARDAR.Size = New System.Drawing.Size(128, 27)
        Me.ButtonGUARDAR.TabIndex = 119
        Me.ButtonGUARDAR.Text = "GUARDAR"
        Me.ButtonGUARDAR.UseVisualStyleBackColor = False
        '
        'RadioButtonPDF417
        '
        Me.RadioButtonPDF417.AutoSize = True
        Me.RadioButtonPDF417.Location = New System.Drawing.Point(76, 98)
        Me.RadioButtonPDF417.Name = "RadioButtonPDF417"
        Me.RadioButtonPDF417.Size = New System.Drawing.Size(64, 17)
        Me.RadioButtonPDF417.TabIndex = 115
        Me.RadioButtonPDF417.Text = "PDF417"
        Me.RadioButtonPDF417.UseVisualStyleBackColor = True
        '
        'TextBoxGENERAR
        '
        Me.TextBoxGENERAR.BackColor = System.Drawing.Color.White
        Me.TextBoxGENERAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxGENERAR.ForeColor = System.Drawing.Color.Black
        Me.TextBoxGENERAR.Location = New System.Drawing.Point(12, 40)
        Me.TextBoxGENERAR.Name = "TextBoxGENERAR"
        Me.TextBoxGENERAR.Size = New System.Drawing.Size(401, 20)
        Me.TextBoxGENERAR.TabIndex = 120
        Me.TextBoxGENERAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxLEER
        '
        Me.TextBoxLEER.BackColor = System.Drawing.Color.Black
        Me.TextBoxLEER.ForeColor = System.Drawing.Color.Yellow
        Me.TextBoxLEER.Location = New System.Drawing.Point(154, 210)
        Me.TextBoxLEER.Multiline = True
        Me.TextBoxLEER.Name = "TextBoxLEER"
        Me.TextBoxLEER.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxLEER.Size = New System.Drawing.Size(18, 14)
        Me.TextBoxLEER.TabIndex = 123
        '
        'ButtonLEER
        '
        Me.ButtonLEER.BackColor = System.Drawing.Color.Black
        Me.ButtonLEER.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonLEER.Location = New System.Drawing.Point(241, 244)
        Me.ButtonLEER.Name = "ButtonLEER"
        Me.ButtonLEER.Size = New System.Drawing.Size(10, 10)
        Me.ButtonLEER.TabIndex = 122
        Me.ButtonLEER.Text = "LEER"
        Me.ButtonLEER.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ButtonIMPRIMIR
        '
        Me.ButtonIMPRIMIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonIMPRIMIR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonIMPRIMIR.ForeColor = System.Drawing.Color.Black
        Me.ButtonIMPRIMIR.Location = New System.Drawing.Point(76, 313)
        Me.ButtonIMPRIMIR.Name = "ButtonIMPRIMIR"
        Me.ButtonIMPRIMIR.Size = New System.Drawing.Size(126, 27)
        Me.ButtonIMPRIMIR.TabIndex = 124
        Me.ButtonIMPRIMIR.Text = "IMPRIMIR"
        Me.ButtonIMPRIMIR.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Que tipo de Codigo Desea Generar"
        '
        'PictureBoxGENERAR
        '
        Me.PictureBoxGENERAR.BackColor = System.Drawing.Color.White
        Me.PictureBoxGENERAR.Location = New System.Drawing.Point(65, 133)
        Me.PictureBoxGENERAR.Name = "PictureBoxGENERAR"
        Me.PictureBoxGENERAR.Size = New System.Drawing.Size(291, 157)
        Me.PictureBoxGENERAR.TabIndex = 118
        Me.PictureBoxGENERAR.TabStop = False
        '
        'PictureBoxLEER
        '
        Me.PictureBoxLEER.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBoxLEER.Location = New System.Drawing.Point(266, 226)
        Me.PictureBoxLEER.Name = "PictureBoxLEER"
        Me.PictureBoxLEER.Size = New System.Drawing.Size(12, 11)
        Me.PictureBoxLEER.TabIndex = 121
        Me.PictureBoxLEER.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 13)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Digite lo que desea codificar:"
        '
        'GENERARDOR_DE_CODIGOS_DE_BARRAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(428, 357)
        Me.Controls.Add(Me.PictureBoxGENERAR)
        Me.Controls.Add(Me.RadioButton128)
        Me.Controls.Add(Me.RadioButtonQR)
        Me.Controls.Add(Me.ButtonGUARDAR)
        Me.Controls.Add(Me.RadioButtonPDF417)
        Me.Controls.Add(Me.TextBoxGENERAR)
        Me.Controls.Add(Me.TextBoxLEER)
        Me.Controls.Add(Me.ButtonLEER)
        Me.Controls.Add(Me.ButtonIMPRIMIR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBoxLEER)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "GENERARDOR_DE_CODIGOS_DE_BARRAS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GENERARDOR DE CODIGOS DE BARRAS"
        CType(Me.PictureBoxGENERAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLEER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioButton128 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonQR As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonGUARDAR As System.Windows.Forms.Button
    Friend WithEvents RadioButtonPDF417 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxGENERAR As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TextBoxLEER As System.Windows.Forms.TextBox
    Friend WithEvents ButtonLEER As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ButtonIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxGENERAR As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxLEER As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
