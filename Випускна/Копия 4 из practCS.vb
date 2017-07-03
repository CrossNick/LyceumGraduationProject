Public Class practG
    Dim g As Graphics
    Dim f As Graphics
    Dim k As Integer = 1
    Dim l As Integer
    Dim myBitmap, myBitmap2 As Bitmap
    Dim type, type2, n As Integer
    Dim p(0), p1, p2, pr() As Point
    Dim b As Boolean = False
    Dim b2 As Boolean = False
    Dim prov1 As Boolean = False
    Dim prov2 As Boolean = False
    Dim k1 As Single
    Private Sub practCS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myBitmap = New Bitmap(pct.Width, pct.Height)
        myBitmap2 = New Bitmap(pct.Width, pct.Height)
        type = 0
        type2 = 0
        n = 0
        l = 0
        Label1.Text = "Побудуйте многокутник або довільну фігуру"
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
            prov2 = True
            Label1.Text = "Натисніть кнопку Побудувати або, якщо хочете розпочати спочатку, на кнопку Спочатку"
            g.FillEllipse(Brushes.Red, p1.X - 2, p1.Y - 2, 4, 4)
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
            If n > 2 Then


                g.DrawLines(Pens.Black, p)
            End If
            g.DrawLine(Pens.Black, p1, p2)
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
                Label1.Text = "Побудуйте центр гомотетії та вкажіть коефіцієнт"
                rb3.Enabled = True
                rb3.Checked = True
                rb2.Enabled = False
                rb1.Enabled = False

                g.DrawPolygon(Pens.Black, p)

                pct.Image = myBitmap
                type2 = 1
                type = 2
                prov1 = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        k1 = Val(Trim(TextBox1.Text))
        If k <> 0 And prov1 = True And prov2 = True Then
            Button1.Enabled = False
            Label1.Text = "Натиcніть кнопу Спочатку, щоб розпочати спочатку"
            If k1 < 0 Then
                Dim kk As Integer

                If type2 = 1 Then
                    CheckBox1.Enabled = True
                    g = Graphics.FromImage(myBitmap)
                    Dim pen As New Pen(Brushes.Black)
                    pen.DashStyle = Drawing2D.DashStyle.Dash
                    ReDim pr(n - 1)
                    For i = 0 To n - 1
                        If p(i).X > p1.X And p(i).Y > p1.Y Then
                            pr(i).X = p1.X - (p(i).X - p1.X) * Math.Abs(k1)
                            pr(i).Y = p1.Y - (p(i).Y - p1.Y) * Math.Abs(k1)
                        ElseIf p(i).X > p1.X And p(i).Y < p1.Y Then
                            pr(i).X = p1.X - (p(i).X - p1.X) * Math.Abs(k1)
                            pr(i).Y = (p1.Y - p(i).Y) * Math.Abs(k1) + p1.Y
                        ElseIf p(i).X < p1.X And p(i).Y > p1.Y Then
                            pr(i).X = (p1.X - p(i).X) * Math.Abs(k1) + p1.X
                            pr(i).Y = p1.Y - (p(i).Y - p1.Y) * Math.Abs(k1)
                        ElseIf p(i).X < p1.X And p(i).Y < p1.Y Then
                            pr(i).X = (p1.X - p(i).X) * Math.Abs(k1) + p1.X
                            pr(i).Y = (p1.Y - p(i).Y) * Math.Abs(k1) + p1.Y
                        End If
                        If CheckBox1.Checked = True Then
                            g.DrawLine(pen, p(i).X, p(i).Y, pr(i).X, pr(i).Y)
                        End If

                    Next
                    prov1 = True
                    g.DrawPolygon(Pens.Red, p)
                    g.DrawPolygon(Pens.Blue, pr)
                    pct.Image = myBitmap
                End If
                If type2 = 2 Then
                    g = Graphics.FromImage(myBitmap)
                    ReDim pr(n - 1)
                    For i = 0 To n - 1
                        If p(i).X >= p1.X And p(i).Y >= p1.Y Then
                            pr(i).X = p1.X - (p(i).X - p1.X) * Math.Abs(k1)
                            pr(i).Y = p1.Y - (p(i).Y - p1.Y) * Math.Abs(k1)
                        ElseIf p(i).X >= p1.X And p(i).Y <= p1.Y Then
                            pr(i).X = p1.X - (p(i).X - p1.X) * Math.Abs(k1)
                            pr(i).Y = (p1.Y - p(i).Y) * Math.Abs(k1) + p1.Y
                        ElseIf p(i).X <= p1.X And p(i).Y >= p1.Y Then
                            pr(i).X = (p1.X - p(i).X) * Math.Abs(k1) + p1.X
                            pr(i).Y = p1.Y - (p(i).Y - p1.Y) * Math.Abs(k1)
                        ElseIf p(i).X <= p1.X And p(i).Y <= p1.Y Then
                            pr(i).X = (p1.X - p(i).X) * Math.Abs(k1) + p1.X
                            pr(i).Y = (p1.Y - p(i).Y) * Math.Abs(k1) + p1.Y
                        End If
                    Next
                    g.DrawLines(Pens.Red, p)
                    g.DrawLines(Pens.Blue, pr)
                    pct.Image = myBitmap
                End If
                'ElseIf k < 0 And k > -1 Then

            ElseIf k1 > 0 And k1 < 1 Then
                If type2 = 1 Then
                    CheckBox1.Enabled = True
                    g = Graphics.FromImage(myBitmap)
                    Dim pen As New Pen(Brushes.Black)
                    pen.DashStyle = Drawing2D.DashStyle.Dash
                    ReDim pr(n - 1)
                    For i = 0 To n - 1
                        If p(i).X > p1.X And p(i).Y > p1.Y Then
                            pr(i).X = (p(i).X - p1.X) * Math.Abs(k1) + p1.X
                            pr(i).Y = (p(i).Y - p1.Y) * Math.Abs(k1) + p1.Y
                        ElseIf p(i).X > p1.X And p(i).Y < p1.Y Then
                            pr(i).X = (p(i).X - p1.X) * Math.Abs(k1) + p1.X
                            pr(i).Y = p1.Y - (p1.Y - p(i).Y) * Math.Abs(k1)
                        ElseIf p(i).X < p1.X And p(i).Y > p1.Y Then
                            pr(i).X = p1.X - (p1.X - p(i).X) * Math.Abs(k1)
                            pr(i).Y = (p(i).Y - p1.Y) * Math.Abs(k1 - 1) + p1.Y
                        ElseIf p(i).X < p1.X And p(i).Y < p1.Y Then
                            pr(i).X = p1.X - (p1.X - p(i).X) * Math.Abs(k1)
                            pr(i).Y = p1.Y - (p1.Y - p(i).Y) * Math.Abs(k1)
                        End If
                        If CheckBox1.Checked = True Then
                            g.DrawLine(pen, p1.X, p1.Y, pr(i).X, pr(i).Y)
                        End If

                    Next
                    prov1 = True
                    g.DrawPolygon(Pens.Red, p)
                    g.DrawPolygon(Pens.Blue, pr)
                    pct.Image = myBitmap
                End If
                If type2 = 2 Then
                    g = Graphics.FromImage(myBitmap)
                    ReDim pr(n - 1)
                    For i = 0 To n - 1
                        If p(i).X > p1.X And p(i).Y > p1.Y Then
                            pr(i).X = (p(i).X - p1.X) * Math.Abs(k1) + p1.X
                            pr(i).Y = (p(i).Y - p1.Y) * Math.Abs(k1) + p1.Y
                        ElseIf p(i).X > p1.X And p(i).Y < p1.Y Then
                            pr(i).X = (p(i).X - p1.X) * Math.Abs(k1) + p1.X
                            pr(i).Y = p1.Y - (p1.Y - p(i).Y) * Math.Abs(k1)
                        ElseIf p(i).X < p1.X And p(i).Y > p1.Y Then
                            pr(i).X = p1.X - (p1.X - p(i).X) * Math.Abs(k1)
                            pr(i).Y = (p(i).Y - p1.Y) * Math.Abs(k1) + p1.Y
                        ElseIf p(i).X < p1.X And p(i).Y < p1.Y Then
                            pr(i).X = p1.X - (p1.X - p(i).X) * Math.Abs(k1)
                            pr(i).Y = p1.Y - (p1.Y - p(i).Y) * Math.Abs(k1)
                        End If
                    Next
                    g.DrawPolygon(Pens.Red, p)
                    g.DrawLines(Pens.Blue, pr)
                    pct.Image = myBitmap
                End If
            ElseIf k1 > 0 Then

                If type2 = 1 Then
                    CheckBox1.Enabled = True
                    g = Graphics.FromImage(myBitmap)
                    Dim pen As New Pen(Brushes.Black)
                    pen.DashStyle = Drawing2D.DashStyle.Dash
                    ReDim pr(n - 1)
                    For i = 0 To n - 1
                        If p(i).X > p1.X And p(i).Y > p1.Y Then
                            pr(i).X = (p(i).X - p1.X) * Math.Abs(k1 - 1) + p(i).X
                            pr(i).Y = (p(i).Y - p1.Y) * Math.Abs(k1 - 1) + p(i).Y
                        ElseIf p(i).X > p1.X And p(i).Y < p1.Y Then
                            pr(i).X = (p(i).X - p1.X) * Math.Abs(k1 - 1) + p(i).X
                            pr(i).Y = p(i).Y - (p1.Y - p(i).Y) * Math.Abs(k1 - 1)
                        ElseIf p(i).X < p1.X And p(i).Y > p1.Y Then
                            pr(i).X = p(i).X - (p1.X - p(i).X) * Math.Abs(k1 - 1)
                            pr(i).Y = (p(i).Y - p1.Y) * Math.Abs(k1 - 1) + p(i).Y
                        ElseIf p(i).X < p1.X And p(i).Y < p1.Y Then
                            pr(i).X = p(i).X - (p1.X - p(i).X) * Math.Abs(k1 - 1)
                            pr(i).Y = p(i).Y - (p1.Y - p(i).Y) * Math.Abs(k1 - 1)
                        End If
                        If CheckBox1.Checked = True Then
                            g.DrawLine(pen, p1.X, p1.Y, pr(i).X, pr(i).Y)
                        End If

                    Next
                    prov1 = True
                    g.DrawPolygon(Pens.Red, p)
                    g.DrawPolygon(Pens.Blue, pr)
                    pct.Image = myBitmap
                End If
                If type2 = 2 Then
                    g = Graphics.FromImage(myBitmap)
                    ReDim pr(n - 1)
                    For i = 0 To n - 1
                        If p(i).X > p1.X And p(i).Y > p1.Y Then
                            pr(i).X = (p(i).X - p1.X) * Math.Abs(k1 - 1) + p(i).X
                            pr(i).Y = (p(i).Y - p1.Y) * Math.Abs(k1 - 1) + p(i).Y
                        ElseIf p(i).X > p1.X And p(i).Y < p1.Y Then
                            pr(i).X = (p(i).X - p1.X) * Math.Abs(k1 - 1) + p(i).X
                            pr(i).Y = p(i).Y - (p1.Y - p(i).Y) * Math.Abs(k1 - 1)
                        ElseIf p(i).X < p1.X And p(i).Y > p1.Y Then
                            pr(i).X = p(i).X - (p1.X - p(i).X) * Math.Abs(k1 - 1)
                            pr(i).Y = (p(i).Y - p1.Y) * Math.Abs(k1 - 1) + p(i).Y
                        ElseIf p(i).X < p1.X And p(i).Y < p1.Y Then
                            pr(i).X = p(i).X - (p1.X - p(i).X) * Math.Abs(k1 - 1)
                            pr(i).Y = p(i).Y - (p1.Y - p(i).Y) * Math.Abs(k1 - 1)
                        End If
                    Next
                    g.DrawPolygon(Pens.Red, p)
                    g.DrawLines(Pens.Blue, pr)
                    pct.Image = myBitmap
                End If
            Else
                mes.Show()
                mes.Label1.Text = "k не введено, або k=0"
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        g = Graphics.FromImage(myBitmap)
        Button1.Enabled = True
        g.FillRectangle(Brushes.White, 0, 0, pct.Width, pct.Height)
        Label1.Text = "Побудуйте многокутник або довільну фігуру"
        rb1.Enabled = True
        rb2.Enabled = True
        rb3.Enabled = False
        CheckBox1.Enabled = False
        TextBox1.Text = "Вкажіть коефіцієнт гомотетії k"
        p1.X = 0
        prov1 = False
        p1.Y = 0
        p2.X = 0
        p2.Y = 0
        n = 0
        k = 0
        prov1 = False
        prov2 = False
        l = 0
        k = 1
        type = 1
        type2 = 0
        pct.Image = myBitmap
        rb1.Checked = True
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
            rb3.Enabled = True
            rb3.Checked = True
            rb2.Enabled = False
            rb1.Enabled = False
            type = 2
            prov1 = True
            b = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If prov1 = True Then
            If CheckBox1.Checked = True Then
                g = Graphics.FromImage(myBitmap)
                Dim pen As New Pen(Brushes.Black)
                pen.DashStyle = Drawing2D.DashStyle.Dash
                For i = 0 To n - 1
                    g.DrawLine(pen, p(i).X, p(i).Y, pr(i).X, pr(i).Y)
                    g.DrawLine(pen, p1.X, p1.Y, pr(i).X, pr(i).Y)
                Next
                g.DrawPolygon(Pens.Red, p)
                g.DrawPolygon(Pens.Blue, pr)
                g.FillEllipse(Brushes.Red, p1.X - 2, p1.Y - 2, 4, 4)
                pct.Image = myBitmap
            End If
            If CheckBox1.Checked = False Then
                g = Graphics.FromImage(myBitmap)
                Dim pen As New Pen(Brushes.White)
                pen.DashStyle = Drawing2D.DashStyle.Dash
                For i = 0 To n - 1
                    g.DrawLine(pen, p(i).X, p(i).Y, pr(i).X, pr(i).Y)
                    g.DrawLine(pen, p1.X, p1.Y, pr(i).X, pr(i).Y)
                Next

                g.DrawPolygon(Pens.Red, p)
                g.DrawPolygon(Pens.Blue, pr)
                g.FillEllipse(Brushes.Red, p1.X - 2, p1.Y - 2, 4, 4)
                pct.Image = myBitmap
            End If
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Гомотетия.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_MouseCaptureChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.MouseCaptureChanged

    End Sub

    Private Sub TextBox1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Text = ""
    End Sub

    Private Sub practG_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class