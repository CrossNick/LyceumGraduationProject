Public Class practOS
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

    Private Sub practCS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myBitmap = New Bitmap(pct.Width, pct.Height)
        myBitmap2 = New Bitmap(pct.Width, pct.Height)
        Label1.Text = "Побудуйте многокутник або довільну фігуру"
        type = 0
        type2 = 0
        n = 0
        l = 0
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
            If p1.X = 0 And p1.Y = 0 Then
                b2 = True
                p1.X = e.X
                p1.Y = e.Y
                prov2 = True
            Else
                Label1.Text = "Натисніть кнопку Побудувати або, якщо хочете розпочати спочатку, на кнопку Спочатку"
                prov2 = True
                b2 = False
            End If
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
        ElseIf type = 2 Then
            If p1.X <> 0 And p1.Y <> 0 And b2 = True Then


                g.DrawLine(Pens.White, p1, p2)
                p2.X = e.X
                p2.Y = e.Y
                g.DrawLine(Pens.Red, p1, p2)
                If type2 = 1 Then
                    g.DrawPolygon(Pens.Black, p)
                ElseIf type2 = 2 Then
                    g.DrawLines(Pens.Black, p)
                End If
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
                Label1.Text = "Побудуйте вісь симетрії"
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
                Dim pen As New Pen(Brushes.Black)
                Dim k, k1, b, b1 As Single
                Dim pp As Point
                pen.DashStyle = Drawing2D.DashStyle.Dash
                CheckBox1.Enabled = True
                ReDim pr(n - 1)
                Label1.Text = "Натиcнiть кнопу Спочатку, щоб розпочати спочатку"
                For i = 0 To n - 1
                    k = (p2.Y - p1.Y) / (p2.X - p1.X)
                    b = p2.Y - k * p2.X
                    k1 = (-1) / k
                    b1 = p(i).Y - k1 * p(i).X
                    pp.X = (b1 - b) / (k - k1)
                    pp.Y = k * pp.X + b
                    pr(i).X = 2 * pp.X - p(i).X
                    pr(i).Y = 2 * pp.Y - p(i).Y
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
                Label1.Text = "Натиcнiть кнопу Спочатку, щоб розпочати спочатку"
                g = Graphics.FromImage(myBitmap)
                ReDim pr(n - 1)
                Dim k, k1, b, b1 As Single
                Dim pp As Point
                For i = 0 To n - 1
                    k = Math.Abs((p2.Y - p1.Y) / (p2.X - p1.X))
                    b = p2.Y - k * p2.X
                    k1 = (-1) / k
                    b1 = p(i).Y - k1 * p(i).X
                    pp.X = (b1 - b) / (k - k1)
                    pp.Y = k * pp.X + b
                    pr(i).X = 2 * pp.X - p(i).X
                    pr(i).Y = 2 * pp.Y - p(i).Y
                Next
                prov1 = True
                g.DrawLines(Pens.Red, p)
                g.DrawLines(Pens.Blue, pr)
                pct.Image = myBitmap
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        g = Graphics.FromImage(myBitmap)
        g.FillRectangle(Brushes.White, 0, 0, pct.Width, pct.Height)
        Label1.Text = "Побудуйте многокутник або довільну фігуру"
        rb1.Enabled = True
        rb2.Enabled = True
        rb3.Enabled = False
        CheckBox1.Enabled = False
        Button1.Enabled = True
        p1.X = 0
        prov1 = False
        p1.Y = 0
        p2.X = 0
        p2.Y = 0
        n = 0
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
            b = False
            rb1.Enabled = False
            rb2.Enabled = False
            rb3.Enabled = True
            rb3.Checked = True
            prov1 = True
            type = 2
            Label1.Text = "Побудуйте вісь симетрії"
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
        Симетрия.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        practCS.Show()
    End Sub

    Private Sub practOS_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub practOS_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Label1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDoubleClick

    End Sub
End Class