Public Class practP
    Dim g As Graphics
    Dim f As Graphics
    Dim k As Integer = 1
    Dim l As Integer
    Dim a, c, len As Single
    Dim myBitmap, myBitmap2 As Bitmap
    Dim type, type2, n As Integer
    Dim p(0), p1, p2, pr() As Point
    Dim b As Boolean = False
    Dim b2 As Boolean = False
    Dim prov1 As Boolean = False
    Dim prov2 As Boolean = False
    Dim al, fi, gam As Single
    Private Sub practP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myBitmap = New Bitmap(pct.Width, pct.Height)
        myBitmap2 = New Bitmap(pct.Width, pct.Height)
        Label1.Text = "Побудуйте многокутник або довільну фігуру"
        type = 0
        type2 = 0
        n = 0
        l = 0
        al = 0
        fi = 0
        a = 0
        len = 0
        c = 0
        gam = 0
        TextBox1.Text = 0
        type = 1
        p1.X = 0
        p1.Y = 0
    End Sub

    Private Sub rb1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked = True Then
            type = 1
        ElseIf rb3.Checked = True Then
            If type = 3 Then
                type2 = 2
            End If
            type = 2
        ElseIf rb2.Checked = True Then
            type = 3
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
            g.FillEllipse(Brushes.White, p1.X - 2, p1.Y - 2, 4, 4)
            p1.X = e.X
            p1.Y = e.Y
            rb3.Enabled = False
            Label1.Text = "Оберіть напрямок повороту та натисніть кнопку Побудувати або, якщо хочете розпочати спочатку, на кнопку Спочатку"
            g.FillEllipse(Brushes.Red, p1.X - 2, p1.Y - 2, 4, 4)
            prov2 = True
            pct.Image = myBitmap
        End If
    End Sub

    Private Sub pct_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct.MouseMove
        g = Graphics.FromImage(myBitmap)
        f = Graphics.FromImage(myBitmap2)
        If type = 1 And p1.X <> 0 And p1.Y <> 0 Then
            g.DrawLine(Pens.White, p1, p2)
            p2.X = e.X
            p2.Y = e.Y
            g.DrawLine(Pens.Black, p1, p2)
            If n > 2 Then


                g.DrawLines(Pens.Black, p)
            End If
            pct.Image = myBitmap
        ElseIf type = 3 And b = True Then
            n += 1
            ReDim Preserve p(n - 1)
            p(n - 1).X = e.X
            p(n - 1).Y = e.Y
            If n >= 2 Then
                g.DrawLines(Pens.Black, p)
            End If
            pct.Image = myBitmap
            type2 = 2
            prov1 = True
        End If
    End Sub

    Private Sub pct_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct.MouseDoubleClick
        If n > 2 Then


            If type = 1 Then
                rb1.Enabled = False
                rb2.Enabled = False
                rb3.Enabled = True
                rb3.Checked = True
                CheckBox1.Enabled = True
                Label1.Text = "Побудуйте центр повороту та вкажіть градус повороту."
                g.DrawPolygon(Pens.Black, p)

                pct.Image = myBitmap
                type2 = 1
                type = 2
                prov1 = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If prov1 = True And prov2 = True Then
            Button1.Enabled = False
            If type2 = 1 Then

                g = Graphics.FromImage(myBitmap)
                ReDim pr(n - 1)
                fi = Math.Abs((Val(Trim(TextBox1.Text)) * (Math.PI / 180)))
                prov1 = True
                gam = fi / 100
                For i = 0 To n - 1
                    pr(i) = p(i)
                Next
                Timer1.Enabled = True
                Label1.Text = "Натиcніть кнопу Спочатку, щоб розпочати спочатку"
            End If
            If type2 = 2 Then
                Label1.Text = "Натиcніть кнопу Спочатку, щоб розпочати спочатку"
                g = Graphics.FromImage(myBitmap)
                ReDim pr(n - 1)
                fi = Math.Abs((Val(TextBox1.Text) * (Math.PI / 180)))
                prov1 = True
                gam = fi / 100
                For i = 0 To n - 1
                    pr(i) = p(i)
                Next
                Timer1.Enabled = True
            End If
        Else
            If prov1 = False Then
                mes.Show()
                mes.Label1.Text = "Побудуйте фігуру"

            ElseIf prov2 = False Then
                mes.Show()
                mes.Label1.Text = "Укажіть центр повороту"

            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        g = Graphics.FromImage(myBitmap)
        g.FillRectangle(Brushes.White, 0, 0, pct.Width, pct.Height)
        Button1.Enabled = True
        p1.X = 0
        prov1 = False
        p1.Y = 0
        p2.X = 0
        p2.Y = 0
        al = 0
        fi = 0
        gam = 0
        TextBox1.Text = "Введіть додатню величину кута "
        prov1 = False
        prov2 = False
        n = 0
        l = 0
        len = 0
        k = 1
        a = 0
        c = 0
        type = 1
        type2 = 0
        pct.Image = myBitmap
        rb1.Checked = True
        rb3.Enabled = False
        rb1.Enabled = True
        rb2.Enabled = True
        CheckBox1.Enabled = False
        Label1.Text = "Побудуйте многокутник або довільну фігуру"
        b = False
        b2 = False
        ReDim p(0)
    End Sub

    Private Sub pct_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct.MouseDown
        If type = 3 Then
            b = True
        End If
    End Sub

    Private Sub pct_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct.MouseUp
        If b = True Then
            rb1.Enabled = False
            rb2.Enabled = False
            rb3.Enabled = True
            rb3.Checked = True
            Label1.Text = "Побудуйте центр повороту та вкажіть градус повороту."
            prov1 = True
            b = False
            type = 2
        End If
    End Sub



    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If type2 = 1 Then
            g = Graphics.FromImage(myBitmap)
            g.DrawPolygon(Pens.White, pr)
            If CheckBox1.Checked = True Then
                For i = 1 To n - 1
                    g.DrawLine(Pens.White, p(i), p1)
                    g.DrawLine(Pens.White, pr(i), p1)
                Next
            End If
            g.DrawPolygon(Pens.Blue, p)

            For i = 0 To n - 1
                If p(i).X >= p1.X And p1.Y >= p(i).Y Then
                    a = p(i).X - p1.X
                    c = p1.Y - p(i).Y
                    al = Math.Atan(a / c)
                    len = Math.Sqrt(a ^ 2 + c ^ 2)
                    If rbtpo.Checked = True Then
                        pr(i).X = p1.X + len * Math.Sin(al + gam)
                        pr(i).Y = p1.Y - len * Math.Cos(al + gam)
                    ElseIf rbtpr.Checked = True Then
                        pr(i).X = p1.X + len * Math.Sin(al - gam)
                        pr(i).Y = p1.Y - len * Math.Cos(al - gam)
                    End If
                ElseIf p1.X > p(i).X And p1.Y > p(i).Y Then
                    a = p1.X - p(i).X
                    c = p1.Y - p(i).Y
                    al = Math.Atan(a / c)
                    len = Math.Sqrt(a ^ 2 + c ^ 2)
                    If rbtpo.Checked = True Then
                        pr(i).X = p1.X + len * Math.Sin(gam - al)
                        pr(i).Y = p1.Y - len * Math.Cos(gam - al)
                    ElseIf rbtpr.Checked = True Then
                        pr(i).X = p1.X + len * Math.Sin(-gam - al)
                        pr(i).Y = p1.Y - len * Math.Cos(-gam - al)
                    End If
                ElseIf p(i).X > p1.X And p(i).Y > p1.Y Then
                    a = p(i).X - p1.X
                    c = p(i).Y - p1.Y
                    al = Math.Atan(a / c)
                    len = Math.Sqrt(a ^ 2 + c ^ 2)
                    If rbtpo.Checked = True Then
                        pr(i).X = p1.X - len * Math.Sin(Math.PI + al - gam)
                        pr(i).Y = p1.Y - len * Math.Cos(Math.PI + al - gam)
                    ElseIf rbtpr.Checked = True Then
                        pr(i).X = p1.X + len * Math.Sin(al + gam)
                        pr(i).Y = p1.Y + len * Math.Cos(al + gam)
                    End If
                ElseIf p(i).Y > p1.Y And p1.X > p(i).X Then
                    a = p1.X - p(i).X
                    c = p(i).Y - p1.Y
                    al = Math.Atan(a / c)
                    len = Math.Sqrt(a ^ 2 + c ^ 2)
                    If rbtpo.Checked = True Then
                        pr(i).X = p1.X + len * Math.Sin(Math.PI + al + gam)
                        pr(i).Y = p1.Y - len * Math.Cos(Math.PI + al + gam)
                    ElseIf rbtpr.Checked = True Then
                        pr(i).X = p1.X + len * Math.Sin(Math.PI + al - gam)
                        pr(i).Y = p1.Y - len * Math.Cos(Math.PI + al - gam)
                    End If
                End If
            Next
            If CheckBox1.Checked = True Then
                For i = 1 To n - 1
                    g.DrawLine(Pens.Black, p(i), p1)
                    g.DrawLine(Pens.Black, pr(i), p1)
                Next
            End If
            g.DrawPolygon(Pens.Red, pr)
            gam += fi / 100
            pct.Image = myBitmap
            If gam >= fi Then
                Timer1.Enabled = False
            End If
        ElseIf type2 = 2 Then
            g = Graphics.FromImage(myBitmap)
            g.DrawLines(Pens.White, pr)
            g.DrawLines(Pens.Blue, p)
            For i = 0 To n - 1
                If p(i).X >= p1.X And p1.Y >= p(i).Y Then
                    a = p(i).X - p1.X
                    c = p1.Y - p(i).Y
                    al = Math.Atan(a / c)
                    len = Math.Sqrt(a ^ 2 + c ^ 2)
                    If rbtpo.Checked = True Then
                        pr(i).X = p1.X + len * Math.Sin(al + gam)
                        pr(i).Y = p1.Y - len * Math.Cos(al + gam)
                    ElseIf rbtpr.Checked = True Then
                        pr(i).X = p1.X + len * Math.Sin(al - gam)
                        pr(i).Y = p1.Y - len * Math.Cos(al - gam)
                    End If
                ElseIf p1.X > p(i).X And p1.Y > p(i).Y Then
                    a = p1.X - p(i).X
                    c = p1.Y - p(i).Y
                    al = Math.Atan(a / c)
                    len = Math.Sqrt(a ^ 2 + c ^ 2)
                    If rbtpo.Checked = True Then
                        pr(i).X = p1.X + len * Math.Sin(gam - al)
                        pr(i).Y = p1.Y - len * Math.Cos(gam - al)
                    ElseIf rbtpr.Checked = True Then
                        pr(i).X = p1.X + len * Math.Sin(-gam - al)
                        pr(i).Y = p1.Y - len * Math.Cos(-gam - al)
                    End If
                ElseIf p(i).X > p1.X And p(i).Y > p1.Y Then
                    a = p(i).X - p1.X
                    c = p(i).Y - p1.Y
                    al = Math.Atan(a / c)
                    len = Math.Sqrt(a ^ 2 + c ^ 2)
                    If rbtpo.Checked = True Then
                        pr(i).X = p1.X - len * Math.Sin(Math.PI + al - gam)
                        pr(i).Y = p1.Y - len * Math.Cos(Math.PI + al - gam)
                    ElseIf rbtpr.Checked = True Then
                        pr(i).X = p1.X + len * Math.Sin(al + gam)
                        pr(i).Y = p1.Y + len * Math.Cos(al + gam)
                    End If
                ElseIf p(i).Y > p1.Y And p1.X > p(i).X Then
                    a = p1.X - p(i).X
                    c = p(i).Y - p1.Y
                    al = Math.Atan(a / c)
                    len = Math.Sqrt(a ^ 2 + c ^ 2)
                    If rbtpo.Checked = True Then
                        pr(i).X = p1.X + len * Math.Sin(Math.PI + al + gam)
                        pr(i).Y = p1.Y - len * Math.Cos(Math.PI + al + gam)
                    ElseIf rbtpr.Checked = True Then
                        pr(i).X = p1.X + len * Math.Sin(Math.PI + al - gam)
                        pr(i).Y = p1.Y - len * Math.Cos(Math.PI + al - gam)
                    End If
                End If
            Next
            g.DrawLines(Pens.Red, pr)
            gam += fi / 100
            pct.Image = myBitmap
            If gam >= fi Then
                Timer1.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Поворот.Show()
    End Sub

    Private Sub TextBox1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Text = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            For i = 0 To n - 1
                Dim pen As New Pen(Brushes.Black)
                pen.DashStyle = Drawing2D.DashStyle.Dash
                g.DrawLine(pen, p(i), p1)
                g.DrawLine(pen, pr(i), p1)
            Next
            g.DrawPolygon(Pens.Red, pr)
            g.DrawPolygon(Pens.Blue, p)
            pct.Image = myBitmap
        ElseIf CheckBox1.Checked = False Then
            For i = 0 To n - 1
                Dim pen As New Pen(Brushes.White)
                pen.DashStyle = Drawing2D.DashStyle.Dash
                g.DrawLine(pen, p(i), p1)
                g.DrawLine(pen, pr(i), p1)
            Next
            g.DrawPolygon(Pens.Red, pr)
            g.DrawPolygon(Pens.Blue, p)
            pct.Image = myBitmap
        End If
    End Sub

    Private Sub practP_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()

    End Sub

   
End Class