
Imports ZXing
Public Class GENERARDOR_DE_CODIGOS_DE_BARRAS
    Private Sub ButtonCREAR_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        e.Graphics.DrawImage(PictureBoxGENERAR.Image, 0, 0) 'CREA UN DOCUMENTO IMPRIMIBLE CON LA IMAGEN SITUADA EN EL ORIGEN (0,0) DEL DOCUMENTO

    End Sub

    Private Sub ButtonIMPRIMIR_Click(sender As System.Object, e As System.EventArgs) Handles ButtonIMPRIMIR.Click

        PrintPreviewDialog1.Document = PrintDocument1 ' ASIGNA EL CONTROL PRINTDOCUMENT AL PRINTPREVIEW
        PrintPreviewDialog1.ShowDialog() 'MUESTRA EL DIALOGO

    End Sub

    Private Sub ButtonGUARDAR_Click(sender As System.Object, e As System.EventArgs) Handles ButtonGUARDAR.Click

        SaveFileDialog1.DefaultExt = ".png" 'PARA NO TENER QUE ESCRIBIR LA EXTENSION
        SaveFileDialog1.FileName = TextBoxGENERAR.Text 'POR SI QUEREMOS USAR EL TEXTO DEL TEXTBOX COMO NOMBRE DE LA IMAGEN

        If SaveFileDialog1.ShowDialog Then
            Try 'GUARDA LA IMAGEN DEL PICTUREBOX EN LA CARPETA DEBUG DEL PROYECTO
                PictureBoxGENERAR.Image.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
                MsgBox("GUARDADO")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub ButtonLEER_Click(sender As System.Object, e As System.EventArgs) Handles ButtonLEER.Click

        If OpenFileDialog1.ShowDialog Then
            Try
                TextBoxLEER.Clear() 'BORRA RESULTADOS ANTERIORES
                PictureBoxLEER.ImageLocation = OpenFileDialog1.FileName 'CARGA LA IMAGEN EN EL PICTUREBOX
                ESPERA(1000) 'PARA DAR TIEMPO AL CARGADO DE LA IMAGEN
                Dim DECODER As BarcodeReader = New BarcodeReader 'DECODIFICA SI PUEDE Y PONE EL RESULTADO EN EL TEXTBOX
                TextBoxLEER.Text = DECODER.Decode(PictureBoxLEER.Image).ToString
            Catch ex As Exception
            End Try
        End If

    End Sub

    'GENERA UN INTERVALO DE ESPERA
    Public Sub ESPERA(ByVal INTERVALO As Integer)

        Dim PARADA As New Stopwatch
        PARADA.Start()
        Do While PARADA.ElapsedMilliseconds < INTERVALO
            Application.DoEvents()
        Loop
        PARADA.Stop()

    End Sub

    Private Sub RadioButtonPDF417_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPDF417.CheckedChanged
        Try
            Dim GENERADOR As BarcodeWriter = New BarcodeWriter 'INICIALIZA EL GENERADOR

            'ELIGE EL CODIGO 
            If RadioButtonPDF417.Checked Then
                GENERADOR.Format = BarcodeFormat.PDF_417
            ElseIf RadioButton128.Checked Then
                GENERADOR.Format = BarcodeFormat.CODE_128
            ElseIf RadioButtonQR.Checked Then
                GENERADOR.Format = BarcodeFormat.QR_CODE

                'ElseIf RadioButton.....Checked Then
                'GENERADOR.Format = BarcodeFormat....
            End If

            Try 'GENERA UN BITMAP Y LO PRESENTA EN EL PICTUREBOX
                Dim IMAGEN As Bitmap = New Bitmap(GENERADOR.Write(TextBoxGENERAR.Text), PictureBoxGENERAR.Width, PictureBoxGENERAR.Height)
                PictureBoxGENERAR.Image = IMAGEN
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GENERARDOR_DE_CODIGOS_DE_BARRAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxGENERAR.Focus()

    End Sub

    Private Sub TextBoxGENERAR_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxGENERAR.KeyDown


    End Sub

    Private Sub TextBoxGENERAR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxGENERAR.KeyPress

    End Sub

    Private Sub TextBoxGENERAR_TextChanged(sender As Object, e As EventArgs) Handles TextBoxGENERAR.TextChanged
        Try
            Dim GENERADOR As BarcodeWriter = New BarcodeWriter 'INICIALIZA EL GENERADOR

            'ELIGE EL CODIGO 
            If RadioButtonPDF417.Checked Then
                GENERADOR.Format = BarcodeFormat.PDF_417
            ElseIf RadioButton128.Checked Then
                GENERADOR.Format = BarcodeFormat.CODE_128
            ElseIf RadioButtonQR.Checked Then
                GENERADOR.Format = BarcodeFormat.QR_CODE

                'ElseIf RadioButton.....Checked Then
                'GENERADOR.Format = BarcodeFormat....
            End If

            Try 'GENERA UN BITMAP Y LO PRESENTA EN EL PICTUREBOX
                Dim IMAGEN As Bitmap = New Bitmap(GENERADOR.Write(TextBoxGENERAR.Text), PictureBoxGENERAR.Width, PictureBoxGENERAR.Height)
                PictureBoxGENERAR.Image = IMAGEN
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton128_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton128.CheckedChanged
        Try
            Dim GENERADOR As BarcodeWriter = New BarcodeWriter 'INICIALIZA EL GENERADOR

            'ELIGE EL CODIGO 
            If RadioButtonPDF417.Checked Then
                GENERADOR.Format = BarcodeFormat.PDF_417
            ElseIf RadioButton128.Checked Then
                GENERADOR.Format = BarcodeFormat.CODE_128
            ElseIf RadioButtonQR.Checked Then
                GENERADOR.Format = BarcodeFormat.QR_CODE

                'ElseIf RadioButton.....Checked Then
                'GENERADOR.Format = BarcodeFormat....
            End If

            Try 'GENERA UN BITMAP Y LO PRESENTA EN EL PICTUREBOX
                Dim IMAGEN As Bitmap = New Bitmap(GENERADOR.Write(TextBoxGENERAR.Text), PictureBoxGENERAR.Width, PictureBoxGENERAR.Height)
                PictureBoxGENERAR.Image = IMAGEN
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButtonQR_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonQR.CheckedChanged
        Try
            Dim GENERADOR As BarcodeWriter = New BarcodeWriter 'INICIALIZA EL GENERADOR

            'ELIGE EL CODIGO 
            If RadioButtonPDF417.Checked Then
                GENERADOR.Format = BarcodeFormat.PDF_417
            ElseIf RadioButton128.Checked Then
                GENERADOR.Format = BarcodeFormat.CODE_128
            ElseIf RadioButtonQR.Checked Then
                GENERADOR.Format = BarcodeFormat.QR_CODE

                'ElseIf RadioButton.....Checked Then
                'GENERADOR.Format = BarcodeFormat....
            End If

            Try 'GENERA UN BITMAP Y LO PRESENTA EN EL PICTUREBOX
                Dim IMAGEN As Bitmap = New Bitmap(GENERADOR.Write(TextBoxGENERAR.Text), PictureBoxGENERAR.Width, PictureBoxGENERAR.Height)
                PictureBoxGENERAR.Image = IMAGEN
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
        Catch ex As Exception

        End Try
    End Sub
End Class