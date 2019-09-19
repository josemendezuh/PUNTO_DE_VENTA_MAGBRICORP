Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Windows.Forms
Public Class MyTabControl
    Inherits System.Windows.Forms.TabControl

#Region " Constants "
    Dim tabHeight As Integer = 20
#End Region

#Region " Variables "
    Dim rcRedibujado As Rectangle
    Dim limites As Rectangle
    Dim index As Integer
    Dim pont As Point
    Dim x As Integer
    Dim y As Integer
    Dim x_Control As Integer = 0
    Dim resaltadoFicha As Boolean = False

    Dim totalRect As Rectangle
    Dim borderFill As LinearGradientBrush
    Dim bgGradient As LinearGradientBrush
    Dim borderBorder As Pen
    Dim bm As Bitmap
    Dim rectBorderFill As Rectangle
    Dim rectBorderBorder As Rectangle
    Dim rectBorderOuter As Rectangle

    'Color de los marcos
    Dim pensBorderExtCentral As Pen

    Dim bordResalInf As Pen
    Dim bordResalExt As Pen

    Dim bTabGrad As LinearGradientBrush
    Dim bTabGrad2 As LinearGradientBrush


    Dim r As Rectangle

    Dim bm2 As Bitmap
    Dim bm3 As Bitmap
    Dim bm4 As Bitmap


    Dim FondoRectSuperior As Rectangle
    Dim FondoRectInferior As Rectangle
    Dim triangleWidth As Integer

#Region " Colors  "


    'relleno marco superior rectangulo central
    Dim clrInicial As Color = Color.DodgerBlue
    Dim clrFinal As Color = Color.DodgerBlue

    'Relleno Fondo 
    Dim clrBgInicial As Color = Color.DodgerBlue
    Dim clrBgFinal As Color = Color.DodgerBlue


    'Relleno central principal
    Dim clrBgGradientInicial As Color = Color.DodgerBlue
    Dim clrBgGradientFinal As Color = Color.DodgerBlue

    'Borde central exterior
    Dim clrBorderExtCentral As Color = Color.DodgerBlue

    'Rectangulo superior(button-Activado)
    Dim clrBorderFill As Color = Color.DodgerBlue
    Dim clrTabGradientTop As Color = Color.DodgerBlue

    '------------Relleno del Ficha Resaltado--------------
    Dim clrBordeExtResal As Color = Color.DodgerBlue
    Dim clrBordeInfeResal As Color = Color.DodgerBlue
    Dim clrSuperiorResal As Color = Color.DodgerBlue
    Dim clrInferiorResal As Color = Color.DodgerBlue
    Dim clrInferiorInferiorResal As Color = Color.DodgerBlue
    '-----------------------------------------------------


#End Region


#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DrawMode = TabDrawMode.OwnerDrawFixed


        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)


        borderBorder = New Pen(clrBorderExtCentral)

        bm = New Bitmap(1, 1)
        bm2 = New Bitmap(1, 1)
        bm3 = New Bitmap(1, 1)
        bm4 = New Bitmap(1, 1)

        bm2.SetPixel(0, 0, clrBorderExtCentral)
        bm3.SetPixel(0, 0, clrBorderFill)


        bordResalInf = New Pen(clrBordeInfeResal)
        bordResalExt = New Pen(clrBordeExtResal)

        'Color de los marcos
        pensBorderExtCentral = New Pen(clrBorderExtCentral)



    End Sub

    Private Sub PaintTabPagesText(ByRef e As System.Windows.Forms.PaintEventArgs)
        'MsgBox(Me.TabPages.Count)
        'e.Graphics.DrawString(Me.TabPages.Count.ToString, Me.Font, Brushes.DarkSlateBlue, r.X + ItemSize.Height - ItemSize.Height * 0.85, r.Y + ItemSize.Height - ItemSize.Height * 0.5 - 9)
        For i As Integer = Me.TabPages.Count - 1 To 0 Step -1
            r = Me.GetTabRect(i)

            If Me.SelectedIndex <> i Then

                ''Resize rectangle
                '' r = New Rectangle(r.X, r.Y + 4, r.Width + 6, r.Height - 8)
                'r = New Rectangle(r.X, r.Y + 2, r.Width + 6, r.Height - 5)
                'triangleWidth = r.Height
                'bTabGrad = New LinearGradientBrush(New Rectangle(r.X, r.Y, r.Width, r.Height + 1), clrTabButtonInicial, clrTabButtonFinal, LinearGradientMode.Vertical)

                ''relleno completo(rectangulo)
                'e.Graphics.FillRectangle(bTabGrad, r.Left, r.Y + 1, r.Width - triangleWidth + ItemSize.Height - 14, r.Height)

                ''Relleno inferior(linea)
                'e.Graphics.DrawLine(borderBorder, r.Left, r.Top + ItemSize.Height - 5, r.Right - 10, r.Top + ItemSize.Height - 5)


                e.Graphics.DrawString(Me.TabPages(i).Text, Me.Font, Brushes.DodgerBlue, r.X + ItemSize.Height - ItemSize.Height * 0.85, r.Y + ItemSize.Height - ItemSize.Height * 0.5 - 9)

            End If
        Next
    End Sub

    Private Sub PaintTabPageOtros(ByVal triangleWidth As Integer, ByRef e As System.Windows.Forms.PaintEventArgs)



        'Resize rectangle
        r = Me.GetTabRect(Me.SelectedIndex)
        r = New Drawing.Rectangle(r.X, r.Y + 2, r.Width + 6, r.Height - 5)

        'Hide part of main tabcontrol border by overlapping with a rectangle
        'e.Graphics.FillRectangle(borderFill, r.X + 1, r.Y + 15, r.Width - 1, r.Height - 12)

        'Sloping part
        triangleWidth = r.Height
        bTabGrad = New LinearGradientBrush(New Drawing.Rectangle(r.X, r.Y + 1, r.Width, r.Height), clrTabGradientTop, clrBorderFill, LinearGradientMode.Vertical)


        'Relleno central(rectangulo)
        e.Graphics.FillRectangle(bTabGrad, r.Left, r.Y + 1, r.Width - triangleWidth + ItemSize.Height - 14, r.Height)

        'Marco superior

        e.Graphics.DrawLine(borderBorder, r.Left + 1, r.Top, r.Right - 11, r.Top)

        'marco izquierdo 
        e.Graphics.DrawLine(pensBorderExtCentral, r.Left - 1, r.Bottom - 1, r.Left - 1, r.Top + 2)
        'marco derecho
        e.Graphics.DrawLine(pensBorderExtCentral, r.Right - 9, r.Top + 2, r.Right - 9, r.Bottom - 1)

        'Puntos de las esquinas derecha y izquierda del Rectangulo superior
        e.Graphics.DrawImageUnscaled(bm2, r.Left, r.Top + 1)      'superior-left
        e.Graphics.DrawImageUnscaled(bm2, r.Right - 10, r.Top + 1)  '-superior-right

        If (r.Left - 2 > 0) Then
            e.Graphics.DrawImageUnscaled(bm2, r.Left - 2, r.Bottom - 1)      'inferior-left
            'punto q ocultan un punto del relleno
            e.Graphics.DrawImageUnscaled(bm3, r.Left - 1, r.Bottom)      'inferior-left
        Else
            e.Graphics.DrawImageUnscaled(bm2, r.Left - 1, r.Bottom)      'inferior-left

        End If
        e.Graphics.DrawImageUnscaled(bm2, r.Right - 8, r.Bottom - 1)  'inferior-right
        'punto q ocultan un punto del relleno
        e.Graphics.DrawImageUnscaled(bm3, r.Right - 9, r.Bottom)  'inferior-right


        e.Graphics.DrawString(Me.TabPages(Me.SelectedIndex).Text, New Drawing.Font(Me.Font, FontStyle.Bold), Drawing.Brushes.AliceBlue, r.X + ItemSize.Height - ItemSize.Height * 0.85, r.Y + ItemSize.Height - ItemSize.Height * 0.5 - 9)



    End Sub

    Private Sub PaintTabPageResaltado(ByVal triangleWidth As Integer, ByRef e As System.Windows.Forms.PaintEventArgs)

        r = Me.GetTabRect(x)
        r = New Rectangle(r.X, r.Y + 2, r.Width + 6, r.Height - 5)
        'Sloping part
        triangleWidth = r.Height

        FondoRectSuperior = New Rectangle(r.Left, r.Y + 1, r.Width - triangleWidth + ItemSize.Height - 14, r.Height / 2)
        FondoRectInferior = New Rectangle(r.Left, ((r.Y) + r.Height / 2), r.Width - triangleWidth + ItemSize.Height - 14, (r.Height / 2) + 1)

        bTabGrad = New LinearGradientBrush(FondoRectSuperior, clrSuperiorResal, clrInferiorResal, LinearGradientMode.Vertical)
        bTabGrad2 = New LinearGradientBrush(FondoRectInferior, clrInferiorResal, clrInferiorInferiorResal, LinearGradientMode.Vertical)

        ''Relleno central(rectangulo)
        e.Graphics.FillRectangle(bTabGrad2, bTabGrad2.Rectangle)
        e.Graphics.FillRectangle(bTabGrad, bTabGrad.Rectangle)




        'Marco superior
        e.Graphics.DrawLine(bordResalExt, r.Left + 1, r.Top, r.Right - 11, r.Top)
        e.Graphics.DrawLine(bordResalInf, r.Left + 1, r.Top + 1, r.Right - 11, r.Top + 1)


        'marco izquierdo 
        e.Graphics.DrawLine(bordResalExt, r.Left - 1, r.Bottom - 1, r.Left - 1, r.Top + 2)
        e.Graphics.DrawLine(bordResalInf, r.Left, r.Bottom, r.Left, r.Top + 2)

        'marco derecho
        e.Graphics.DrawLine(bordResalExt, r.Right - 9, r.Top + 2, r.Right - 9, r.Bottom)
        e.Graphics.DrawLine(bordResalInf, r.Right - 10, r.Top + 2, r.Right - 10, r.Bottom)


        bm4.SetPixel(0, 0, clrBordeExtResal)

        'Puntos de las esquinas derecha y izquierda del Rectangulo superior
        e.Graphics.DrawImageUnscaled(bm4, r.Left, r.Top + 1)      'superior-left
        e.Graphics.DrawImageUnscaled(bm4, r.Right - 10, r.Top + 1)  '-superior-right
        e.Graphics.DrawImageUnscaled(bm4, r.Left - 1, r.Bottom)      'inferior-left

        'Texto
        e.Graphics.DrawString(Me.TabPages(x).Text, New Font(Me.Font, FontStyle.Regular), Brushes.DodgerBlue, r.X + ItemSize.Height - ItemSize.Height * 0.85, r.Y + ItemSize.Height - ItemSize.Height * 0.5 - 9)

    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
        Try


            If Not (e.ClipRectangle.Height = 0 Or e.ClipRectangle.Width = 0 Or Me.Height < ItemSize.Height + 1) Then

                totalRect = New Rectangle(0, 0, Me.Width, Me.ItemSize.Height)

                'Rectangles
                rectBorderFill = New Rectangle(0, tabHeight + ItemSize.Height - 21, totalRect.Width, Me.Height - ItemSize.Height + 1)
                'Relleno central principal
                borderFill = New LinearGradientBrush(rectBorderFill, clrBgGradientInicial, clrBgGradientFinal, LinearGradientMode.Vertical)

                rectBorderBorder = New Rectangle(3, tabHeight + 4, totalRect.Width - 7, totalRect.Height - tabHeight - 8)

                rectBorderOuter = New Rectangle(0, tabHeight, totalRect.Width - 1, totalRect.Height - tabHeight - 1)

                'Rellenar rectangulo central principal "central"
                e.Graphics.FillRectangle(borderFill, rectBorderFill)

                ''gradient background
                bgGradient = New LinearGradientBrush(totalRect, clrBgInicial, clrBgFinal, LinearGradientMode.Vertical)
                e.Graphics.FillRectangle(bgGradient, totalRect)

                'Border central principal "exterior"
                'e.Graphics.DrawLine(borderBorder, 0, rectBorderOuter.Y + ItemSize.Height - 19, 0, rectBorderOuter.Bottom - 2) 'Left side
                'e.Graphics.DrawLine(borderBorder, rectBorderOuter.Right, rectBorderOuter.Y + ItemSize.Height - 19, rectBorderOuter.Right, rectBorderOuter.Bottom - 2) 'Right side
                e.Graphics.DrawLine(borderBorder, 0, rectBorderOuter.Y + ItemSize.Height - 21, rectBorderOuter.Width - 2, rectBorderOuter.Y + ItemSize.Height - 21) 'Top
                e.Graphics.DrawLine(borderBorder, 2, rectBorderOuter.Bottom, rectBorderOuter.Width, rectBorderOuter.Bottom)    'Bottom

                'Cordenadas de puntos ..Corner points

                e.Graphics.DrawImageUnscaled(bm, 1, rectBorderOuter.Y + ItemSize.Height - 20)      'Top-left
                e.Graphics.DrawImageUnscaled(bm, 1, rectBorderOuter.Bottom - 1) 'Bottom-left
                e.Graphics.DrawImageUnscaled(bm, rectBorderOuter.Right - 1, rectBorderOuter.Y + ItemSize.Height - 20)  'Top-right
                e.Graphics.DrawImageUnscaled(bm, rectBorderOuter.Right - 1, rectBorderOuter.Bottom - 1)  'Bottom-right


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        If Not (e.ClipRectangle.Height = 0 Or e.ClipRectangle.Width = 0) Then

            totalRect = New Rectangle(0, 0, Me.Width, Me.Height)
            rectBorderOuter = New Rectangle(0, tabHeight, totalRect.Width - 1, totalRect.Height - tabHeight - 1)


            '-------------------Diseño de la primera pestaña----------------------------------

            'Color de los marcos
            'Try


            'Titulo de todas las fichas
            PaintTabPagesText(e)

            ''Draw active tab header

            If Me.SelectedIndex <> -1 Then
                PaintTabPageOtros(triangleWidth, e)
            End If

            ''----------------------------------------------Diseño de la ficha Resaltado ---------------------------
            If resaltadoFicha And x <> Me.SelectedIndex Then
                PaintTabPageResaltado(triangleWidth, e)

            End If
            '-----------------------------------------------------------Fin Resaltado-------------------------------------

            'Catch ex As Exception
            '    MsgBox(ex.ToString)
            'End Try

        End If
    End Sub

    Protected Overrides Sub OnSelectedIndexChanged(ByVal e As System.EventArgs)
        Me.Invalidate()
        MyBase.OnSelectedIndexChanged(e)
    End Sub


    Private Sub MyTabControl_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        resaltadoFicha = False
        rcRedibujado = New Rectangle(0, 0, Me.Width, Me.ItemSize.Height)
        Me.Invalidate(rcRedibujado)
    End Sub

    Private Sub MyTabControl_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        rcRedibujado = New Rectangle(0, 0, Me.Width, Me.ItemSize.Height)
        pont = MousePosition
        Dim x As Integer = pont.X - Me.FindForm.Location.X - Me.Location.X - 5
        index = Me.TabPages.Count - 1
        For i As Integer = 0 To index
            limites = Me.GetTabRect(i)
            x_Control = x_Control + limites.Width

            If x < x_Control Then
                resaltadoFicha = True

                Me.x = i
                Me.Invalidate(rcRedibujado)

                Exit For
            End If
        Next
        x_Control = 0


    End Sub



    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        components = New System.ComponentModel.Container()
        Me.SuspendLayout()
        Me.ResumeLayout(False)
    End Sub

End Class
