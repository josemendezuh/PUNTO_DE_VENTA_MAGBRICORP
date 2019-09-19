Module Personalizar_tabControl
    Private Sub RepaintControls(sender As Object, e As DrawItemEventArgs)
        Try
            Dim _Fnt As Font
            Dim _BackBrush As Brush
            Dim _ForeBrush As Brush
            Dim _Rec As Rectangle = e.Bounds
            If e.Index = SelectedIndex Then
                ' Remove the comment below if you want the font style
                ' of selected tab page as normal.
                ' _Fnt = new Font(e.Font, e.Font.Style And  ~FontStyle.Bold);
                ' Remove the comment below if you want the font style of
                ' selected tab page as bold.
                _Fnt = New Font(e.Font, e.Font.Style)
                _BackBrush = New SolidBrush(Me.SelectedTab.BackColor)
                _ForeBrush = New SolidBrush(Me.SelectedTab.ForeColor)
                _Rec = New Rectangle(_Rec.X + (Me.Padding.X / 2), _Rec.Y + Me.Padding.Y, _Rec.Width - Me.Padding.X, _Rec.Height - (Me.Padding.Y * 2))

            Else
                ' Remove the comment below if you want the font style
                ' of inactive tab page as normal.
                _Fnt = New Font(e.Font, e.Font.Style And  ~FontStyle.Bold)
                ' Remove the comment below if you want the font style
                ' of inactive tab page as bold.
                '_Fnt = new Font(e.Font, e.Font.Style);
                If Me._InactiveColorOn = True Then
                    _BackBrush = New SolidBrush(Me.InactiveBGColor)
                    _ForeBrush = New SolidBrush(Me.InactiveFGColor)

                Else
                    ReDim _BackBrush(0 To e.Index - 1)
                    ReDim _ForeBrush(0 To e.Index - 1)

                End If
                _Rec = New Rectangle(_Rec.X + (Me.Padding.X / 2), _Rec.Y + Me.Padding.Y, _Rec.Width - Me.Padding.X, _Rec.Height - Me.Padding.Y)

            End If

            _TabName = Me.TabPages(e.Index).Text
            Dim _SF As New StringFormat()
            _SF.Alignment = StringAlignment.Center
            e.Graphics.FillRectangle(_BackBrush, _Rec)
            e.Graphics.DrawString(_TabName, _Fnt, _ForeBrush, _Rec, _SF)
            _SF.Dispose()
            _BackBrush.Dispose()
            _ForeBrush.Dispose()
            _Fnt.Dispose()

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

    End Sub


End Module
