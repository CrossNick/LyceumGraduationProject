Public Class practPP
    Dim g As Graphics
    Dim f As Graphics
    Dim k As Integer = 1
    Dim l As Integer

    Dim myBitmap, myBitmap2 As Bitmap
    Dim type, type2, n As Integer
    Dim p(), pp(), p1, p2 As Point
    Dim b As Boolean = False
    Dim b2 As Boolean = False
    Dim prov1 As Boolean = False
    Dim prov2 As Boolean = False

    Private Sub practPP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myBitmap = New Bitmap(pct.Width, pct.Height)
        myBitmap2 = New Bitmap(pct.Width, pct.Height)
        type = 0
        type2 = 0
        n = 0
        l = 0
      
        Label1.Text = "Побудуйте многокутник або довільну фігуру"
        If rb1.Checked = True Then
            type = 1
        End If
    End Sub

    Private Sub rb1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked = True Then
            type = 1
            p1.X = 0
            p1.Y = 0
        ElseIf rb3.Checked = True Then
            If type = 3 Then
                type2 = 2
            End If
            type = 2
            p1.X = 0
            p1.Y = 0
        ElseIf rb2.Checked = True Then
            type = 3
            p1.X = 0
            p1.Y = 0
        End If
    End Sub

    Private Sub rb2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb2.CheckedChanged
        If rb1.Checked = True Then
            type = 1
            p1.X = 0
            p1.Y = 0
        ElseIf rb3.Checked = True Then
            If type = 3 Then
                type2 = 2
            End If
            type = 2
            p1.X = 0
            p1.Y = 0
        ElseIf rb2.Checked = True Then
            type = 3
            p1.X = 0
            p1.Y = 0
        End If
    End Sub

    Private Sub rb3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb3.CheckedChanged
        If rb1.Checked = True Then
            type = 1
            p1.X = 0
            p1.Y = 0
        ElseIf rb3.Checked = True Then
            If type = 3 Then
                type2 = 2
            End If
            type = 2
            p1.X = 0
            p1.Y = 0
        ElseIf rb2.Checked = True Then
            type = 3
            p1.X = 0
            p1.Y = 0
        End If
    End Sub

    Private Sub pct_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct.MouseClick
        g = Graphics.FromImage(myBitmap)
        If type = 1 Then
            p1.X = e.X
            p1.Y = e.Y
            n += 1
            ReDim Preserve p(n - 1)
            p(n - 1) = p1
            If n > n Then
                g.DrawLines(Pens.Black, p)
            End If
            pct.Image = myBitmap
        ElseIf type = 2 Then
            If p1.X = 0 And p1.Y = 0 Then
                b2 = True

                p1.X = e.X
                p1.Y = e.Y
                g.FillEllipse(Brushes.Blue, p1.X - 3, p1.Y - 3, 6, 6)
                pct.Image = myBitmap
                prov2 = True
            Else
                rb3.Enabled = False
                prov2 = True
                Label1.Text = "Натисніть кнопку Побудувати або, якщо хочете розпочати спочатку, на кнопку Спочатку"
                b2 = False

            End If
        End If
    End Sub

    Private Sub pct_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct.MouseMove
        g = Graphics.FromImage(myBitmap)
        f = Graphics.FromImage(myBitmap2)
        Dim pen As New Pen(Brushes.Red)
        pen.EndCap = Drawing2D.LineCap.ArrowAnchor
        Dim pen2 As New Pen(Brushes.White)

        If type = 1 And p1.X <> 0 And p1.Y <> 0 Then
            g.DrawLine(Pens.White, p1, p2)
            p2.X = e.X
            p2.Y = e.Y
            If n > 2 Then


                g.DrawLines(Pens.Black, p)
            End If
            g.DrawLine(Pens.Black, p1, p2)
            pct.Image = myBitmap
        ElseIf type = 2 Then
            If p1.X <> 0 And p1.Y <> 0 And b2 = True Then

                g.FillEllipse(Brushes.White, p2.X - 3, p2.Y - 3, 6, 6)
                g.DrawLine(pen2, p1, p2)
                p2.X = e.X
                p2.Y = e.Y
                If type2 = 1 Then
                    g.DrawPolygon(Pens.Black, p)
                ElseIf type2 = 2 Then
                    g.DrawLines(Pens.Black, p)
                End If

                g.DrawLine(Pens.Black, p1, p2)
                g.FillEllipse(Brushes.Blue, p1.X - 3, p1.Y - 3, 6, 6)
                g.FillEllipse(Brushes.Red, p2.X - 3, p2.Y - 3, 6, 6)
                pct.Image = myBitmap

            End If
        ElseIf type = 3 And b = True Then

            n += 1

            ReDim Preserve p(n - 1)

            p(n - 1).X = e.X
            p(n - 1).Y = e.Y
           
            If n >= 2 Then
                g.DrawLines(Pens.Black, p)
            End If

            prov1 = True
            pct.Image = myBitmap
            End If
    End Sub

    Private Sub pct_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct.MouseDoubleClick
        If n > 2 Then


            If type = 1 Then

                rb3.Enabled = True
                rb1.Enabled = False
                rb2.Enabled = False
                Label1.Text = "Побудуйте вектор переміщення(клікніть на точці початку вектору та оберіть його напрямок)"
                g.DrawPolygon(Pens.Black, p)
                ReDim Preserve pp(n - 1)
                For i = 0 To n - 1
                    pp(i) = p(i)
                Next
                prov1 = True
                pct.Image = myBitmap
                type2 = 1
                type = 0
                rb3.Checked = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If prov1 = True And prov2 = True Then
            Button1.Enabled = False
            If type2 = 1 Then
                Timer1.Enabled = True
                Label1.Text = "Натиcніть кнопу Спочатку щоб, розпочати спочатку"
                'g = Graphics.FromImage(myBitmap)
                'Dim pr(n - 1) As Point
                'Dim h, w As Integer
                'w = Math.Abs(p2.X - p1.X)
                'h = Math.Abs(p2.Y - p1.Y)
                'For i = 0 To n - 1
                '    If p2.X > p1.X And p2.Y > p1.Y Then
                '        pr(i).X = p(i).X + w
                '        pr(i).Y = p(i).Y + h
                '    ElseIf p2.X > p1.X And p2.Y < p1.Y Then
                '        pr(i).X = p(i).X + w
                '        pr(i).Y = p(i).Y - h
                '    ElseIf p2.X < p1.X And p2.Y > p1.Y Then
                '        pr(i).X = p(i).X - w
                '        pr(i).Y = p(i).Y + h
                '    ElseIf p2.X < p1.X And p2.Y < p1.Y Then
                '        pr(i).X = p(i).X - w
                '        pr(i).Y = p(i).Y - h
                '    End If
                'Next
                'g.DrawPolygon(Pens.Blue, pr)
                'pct.Image = myBitmap
            End If
            If type2 = 2 Then
                Timer1.Enabled = True
                Label1.Text = "Натисніть кнопу Спочатку щоб, розпочати спочатку"
                'Dim h, w As Integer
                'g = Graphics.FromImage(myBitmap)
                'w = Math.Abs(p2.X - p1.X)
                'h = Math.Abs(p2.Y - p1.Y)
                'For i = 0 To n - 1
                '    If p2.X >= p1.X And p2.Y >= p1.Y Then
                '        p(i).X = p(i).X + w
                '        p(i).Y = p(i).Y + h
                '    ElseIf p2.X >= p1.X And p2.Y <= p1.Y Then
                '        p(i).X = p(i).X + w
                '        p(i).Y = p(i).Y - h
                '    ElseIf p2.X <= p1.X And p2.Y >= p1.Y Then
                '        p(i).X = p(i).X - w
                '        p(i).Y = p(i).Y + h
                '    ElseIf p2.X <= p1.X And p2.Y <= p1.Y Then
                '        p(i).X = p(i).X - w
                '        p(i).Y = p(i).Y - h
                '    End If
                '    pct.Image = myBitmap
                'Next
                'g.DrawLines(Pens.Blue, p)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        g = Graphics.FromImage(myBitmap)
        Button1.Enabled = True
        g.FillRectangle(Brushes.White, 0, 0, pct.Width, pct.Height)
        g.FillRectangle(Brushes.White, 0, 0, pct.Width, pct.Height)
        g.FillRectangle(Brushes.White, 0, 0, pct.Width, pct.Height)
        prov1 = False
        prov2 = False
        p1.X = 0
        p1.Y = 0
        p2.X = 0
        p2.Y = 0
        prov1 = False
        CheckBox1.Checked = False
        CheckBox1.Enabled = False
        prov2 = False
        n = 0
        l = 0
        k = 1
        type = 1
        type2 = 0
        pct.Image = myBitmap
        rb1.Checked = True
        rb1.Enabled = True
        rb2.Enabled = True
        Label1.Text = "Побудуйте многокутник або довільну фігуру"
        b = False
        b2 = False
        ReDim p(0)
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        g = Graphics.FromImage(myBitmap)
        Dim pr(n - 1) As Point
        Dim h, w As Single
        w = Math.Abs(p2.X - p1.X)
        h = Math.Abs(p2.Y - p1.Y)
        If type2 = 1 Then

            For i = 0 To n - 1
                g.DrawPolygon(Pens.White, pp)
                If p2.X >= p1.X And p2.Y >= p1.Y Then
                    pp(i).X = pp(i).X + w / 100
                    pp(i).Y = pp(i).Y + h / 100
                ElseIf p2.X >= p1.X And p2.Y <= p1.Y Then
                    pp(i).X = pp(i).X + w / 100
                    pp(i).Y = pp(i).Y - h / 100
                ElseIf p2.X <= p1.X And p2.Y >= p1.Y Then
                    pp(i).X = pp(i).X - w / 100
                    pp(i).Y = pp(i).Y + h / 100
                ElseIf p2.X <= p1.X And p2.Y <= p1.Y Then
                    pp(i).X = pp(i).X - w / 100
                    pp(i).Y = pp(i).Y - h / 100
                End If
                g.DrawPolygon(Pens.Blue, p)
                g.DrawPolygon(Pens.Red, pp)
                pct.Image = myBitmap
            Next
            k += 1
            CheckBox1.Enabled = True
            g.DrawLine(Pens.Black, p1, p2)
            g.FillEllipse(Brushes.Blue, p1.X - 3, p1.Y - 3, 6, 6)
            g.FillEllipse(Brushes.Red, p2.X - 3, p2.Y - 3, 6, 6)
            If k = 100 Then
                Timer1.Enabled = False
            End If
        ElseIf type2 = 2 Then
            For i = 0 To n - 1
                g.DrawLines(Pens.White, pp)
                If p2.X >= p1.X And p2.Y >= p1.Y Then
                    pp(i).X = pp(i).X + w
                    pp(i).Y = pp(i).Y + h
                ElseIf p2.X >= p1.X And p2.Y <= p1.Y Then
                    pp(i).X = pp(i).X + w
                    pp(i).Y = pp(i).Y - h
                ElseIf p2.X <= p1.X And p2.Y >= p1.Y Then
                    pp(i).X = pp(i).X - w
                    pp(i).Y = pp(i).Y + h
                ElseIf p2.X <= p1.X And p2.Y <= p1.Y Then
                    pp(i).X = pp(i).X - w
                    pp(i).Y = pp(i).Y - h
                End If
                g.DrawLines(Pens.Blue, p)
                g.DrawLines(Pens.Red, pp)
                pct.Image = myBitmap
            Next
            g.DrawLine(Pens.Black, p1, p2)
            g.FillEllipse(Brushes.Blue, p1.X - 3, p1.Y - 3, 6, 6)
            g.FillEllipse(Brushes.Red, p2.X - 3, p2.Y - 3, 6, 6)
            k += 1
            If k = 100 Then
                Timer1.Enabled = False
            End If
        End If
    End Sub

    Private Sub pct_Click(sender As System.Object, e As System.EventArgs) Handles pct.Click

    End Sub

    Private Sub pct_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct.MouseDown
        If type = 3 Then
            b = True
        End If
    End Sub

    Private Sub pct_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct.MouseUp
        If b = True Then
            b = False
            Label1.Text = "Побудуйте вектор переміщення(клікніть на точці початку вектору та оберіть його напрямок)"
            prov1 = True
            ReDim Preserve pp(n - 1)
            For i = 0 To n - 1
                pp(i) = p(i)
            Next
            rb3.Enabled = True
            rb1.Enabled = False
            rb2.Enabled = False
            type2 = 2
            rb3.Checked = True
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Перенесення.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            For i = 0 To n - 1
                Dim pen As New Pen(Brushes.Black)
                pen.DashStyle = Drawing2D.DashStyle.Dash
                g.DrawLine(pen, p(i), pp(i))

            Next
            g.DrawPolygon(Pens.Blue, p)
            g.DrawPolygon(Pens.Red, pp)
            pct.Image = myBitmap
        ElseIf CheckBox1.Checked = False Then
            For i = 0 To n - 1
                Dim pen As New Pen(Brushes.White)
                pen.DashStyle = Drawing2D.DashStyle.Dash
                g.DrawLine(pen, p(i), pp(i))
            Next
            g.DrawPolygon(Pens.Blue, p)
            g.DrawPolygon(Pens.Red, pp)
            pct.Image = myBitmap
        End If
    End Sub

    Private Sub practPP_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class