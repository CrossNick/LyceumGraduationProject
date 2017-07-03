Public Class igraG
    Dim g, g2, g3 As Graphics
    Dim mybitmap1, mybitmap2, mybitmap3 As Bitmap
    Dim ps, pl1a, pl1b, pl1c, pl1m, pl1c1, pl1a1, pl1b1, pl1m1 As Point

    Dim dop1, dop2, dop3, dop4, dop5, dop6 As Boolean
    Dim dopp1, dopp2, dopp3, dopp4, dopp5, dopp6 As Point

    Dim pl2a, pl2b, pl2c, pl2d, pl2o, pl2a1, pl2b1, pl2c1, pl2d1, pl2a2, pl2b2, pl2c2, pl2d2 As Point

    Dim k, kk As Integer
    Dim drawFont As New Font("TimesNewRoman", 16)
    Dim drawBrush As New SolidBrush(Color.Black)
    Dim type, type2, type22 As Integer

    Dim mp(2), mp2(2), mp3(2) As Point
    Dim mn, mn2, mn3 As Integer

    Dim pom, pom2 As Boolean
    Dim pl3a, pl3b, pl3c, pl3m, pl3a1, pl3b1, pl3c1 As Point

    Dim i1, i2, j1, j2, type4 As Integer
    Dim x1, x2, y1, y2 As Single

  
    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
        Гомотетия.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Гомотетия.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Гомотетия.Show()
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        Me.Hide()
        igraS.Show()
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        Me.Hide()
        IgraPP.Show()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        Me.Hide()
        igraP.Show()
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Me.Hide()
        igraS.Show()
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Me.Hide()
        IgraPP.Show()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Me.Hide()
        igraP.Show()
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        Me.Hide()
        igraS.Show()
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        Me.Hide()
        IgraPP.Show()
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        Me.Hide()
        igraP.Show()
    End Sub

    Private Sub igraG_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.BringToFront()
        mybitmap1 = New Bitmap(pct1.Width, pct1.Height)
        g = Graphics.FromImage(mybitmap1)
        mybitmap2 = New Bitmap(pct1.Width, pct1.Height)
        g2 = Graphics.FromImage(mybitmap2)
        mybitmap3 = New Bitmap(pct1.Width, pct1.Height)
        g3 = Graphics.FromImage(mybitmap3)
        Timer1.Enabled = True
        pl1a.X = 30

        mn = 2
        mn2 = 2
        mn3 = 2

        pl1a.Y = 450
        dop1 = False
        dop2 = False
        dop3 = False
        dop4 = False
        dop5 = False
        dop6 = False
        pom = False
        pom2 = False
        dopp4.X = 0
        type4 = 1
        Label3.BringToFront()
        dopp4.Y = 0
        dopp6.X = 0
        dopp6.Y = 0
        dopp2.X = 0
        dopp2.Y = 0
        pl1b.X = 70
        pl1b.Y = 380
        pl1c.X = 150
        pl1c.Y = 450
        pl1m.X = 170
        pl1m.Y = 330
        pl1a1.X = pl1a.X + (pl1m.X - pl1a.X) * 3
        pl1a1.Y = pl1a.Y - (pl1a.Y - pl1m.Y) * 3
        kk = 1
        pl1b1.X = pl1b.X + (pl1m.X - pl1b.X) * 3
        pl1b1.Y = pl1b.Y - (pl1b.Y - pl1m.Y) * 3
        type = 1
        type2 = 1
        type22 = 1
        pl1c1.X = pl1c.X + (pl1m.X - pl1c.X) * 3
        pl1c1.Y = pl1c.Y - (pl1c.Y - pl1m.Y) * 3
        pl1m1.X = 0
        pl1m1.Y = 0
        'g.DrawLine(Pens.Black, pl1a1, pl1b1)
        'g.DrawLine(Pens.Black, pl1b1, pl1c1)
        'g.DrawLine(Pens.Black, pl1c1, pl1a1)

        'g.DrawLine(Pens.Black, pl1a, pl1b)
        'g.DrawLine(Pens.Black, pl1b, pl1c)
        'g.DrawLine(Pens.Black, pl1c, pl1a)
        pct1.Image = mybitmap1

        pl2a.X = 130
        pl2a.Y = 320
        pl2b.X = 230
        pl2b.Y = 170
        pl2c.X = 380
        pl2c.Y = 150
        pl2d.X = 280
        pl2d.Y = 290
        pl2o.X = 255
        pl2o.Y = 235
        pl2a1.X = 0
        pl2a1.Y = 0
        pl2b1.X = 0
        pl2b1.Y = 0
        pl2c1.X = 0
        pl2c1.Y = 0
        pl2d1.X = 0
        pl2d1.Y = 0
        pl2a2.X = 0
        pl2a2.Y = 0
        pl2b2.X = 0
        pl2b2.Y = 0
        pl2c2.X = 0
        pl2c2.Y = 0
        pl2d2.X = 0
        pl2d2.Y = 0
        g2.DrawLine(Pens.Black, pl2a, pl2b)
        g2.DrawLine(Pens.Black, pl2b, pl2c)
        g2.DrawLine(Pens.Black, pl2c, pl2d)
        g2.DrawLine(Pens.Black, pl2d, pl2a)
        g2.DrawLine(Pens.Black, pl2c, pl2a)
        g2.DrawLine(Pens.Black, pl2d, pl2b)
        g2.DrawLine(Pens.Black, pl2c, pl2o)
        g2.DrawString("A", drawFont, drawBrush, pl2a.X - 20, pl2a.Y)
        g2.DrawString("B", drawFont, drawBrush, pl2b.X - 20, pl2b.Y - 20)
        g2.DrawString("C", drawFont, drawBrush, pl2c.X, pl2c.Y - 20)
        g2.DrawString("D", drawFont, drawBrush, pl2d.X, pl2d.Y)
        g2.DrawString("O", drawFont, drawBrush, pl2o.X + 5, pl2o.Y - 10)
        pct2.Image = mybitmap2

        x1 = -10
        y1 = 10
        x2 = 10
        y2 = -10
        i1 = 0
        j1 = 0
        i2 = pct3.Width
        j2 = pct3.Height
        OSI()
        pl3a.X = XtoI(5)
        pl3a.Y = YtoJ(6)
        pl3c.X = XtoI(7)
        pl3c.Y = YtoJ(6)
        pl3b.X = XtoI(6)
        pl3b.Y = YtoJ(7)
        pl3m.X = XtoI(4)
        pl3m.Y = YtoJ(4)
        g3.DrawLine(Pens.Black, pl3a, pl3b)
        g3.DrawLine(Pens.Black, pl3b, pl3c)
        g3.DrawLine(Pens.Black, pl3a, pl3c)
        g3.DrawString("A", drawFont, drawBrush, pl3a.X - 22, pl3a.Y)
        g3.DrawString("B", drawFont, drawBrush, pl3b.X - 10, pl3b.Y - 22)
        g3.DrawString("C", drawFont, drawBrush, pl3c.X, pl3c.Y)
        g3.FillEllipse(Brushes.Red, pl3m.X - 3, pl3m.Y - 3, 6, 6)
        g3.DrawString("M", drawFont, drawBrush, pl3m.X, pl3m.Y)
        pct3.Image = mybitmap3

    End Sub
    Function OSI()
        Dim i As Integer
        For i = x1 To x2
            If i <> 0 Then g3.DrawString(Str(i), Me.Font, Brushes.Black, XtoI(i) - 8, YtoJ(0) + 10)
            g3.DrawLine(Pens.LightGray, XtoI(i), 0, XtoI(i), 500)
            g3.DrawLine(Pens.Black, XtoI(i), YtoJ(0.1), XtoI(i), YtoJ(-0.1))

        Next
        For i = y2 To y1
            g3.DrawLine(Pens.LightGray, 0, YtoJ(i), 500, YtoJ(i))
            g3.DrawLine(Pens.Black, XtoI(-0.1), YtoJ(i), XtoI(0.1), YtoJ(i))
            If i <> 0 Then g3.DrawString(Str(i), Me.Font, Brushes.Black, XtoI(0) - 20, YtoJ(i) - 5)

        Next
        g3.DrawLine(Pens.Black, XtoI(x2), 250, XtoI(x2) - 20, 240)
        g3.DrawLine(Pens.Black, XtoI(x2), 250, XtoI(x2) - 20, 260)
        g3.DrawLine(Pens.Black, 250, YtoJ(y1), 240, YtoJ(y1) + 20)
        g3.DrawLine(Pens.Black, 250, YtoJ(y1), 260, YtoJ(y1) + 20)
        g3.DrawLine(Pens.Black, XtoI(x1), YtoJ(0), XtoI(x2), YtoJ(0))
        g3.DrawLine(Pens.Black, XtoI(0), YtoJ(y1), XtoI(0), YtoJ(y2))
        pct3.Image = myBitmap3
    End Function

    Function XtoI(ByVal x As Single) As Integer
        XtoI = i1 + Int((x - x1) * (i2 - i1) / (x2 - x1))
    End Function
    Function YtoJ(ByVal y As Single) As Integer
        YtoJ = j1 + Int((y - y1) * (j2 - j1) / (y2 - y1))
    End Function
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ps.X = pl1a.X + (pl1b.X - pl1a.X) * (k / 100)
        ps.Y = pl1a.Y - (pl1a.Y - pl1b.Y) * (k / 100)
        g.DrawLine(Pens.Black, pl1a, ps)
        ps.X = pl1b.X + (pl1c.X - pl1b.X) * (k / 100)
        ps.Y = pl1b.Y + (pl1c.Y - pl1b.Y) * (k / 100)
        g.DrawLine(Pens.Black, pl1b, ps)
        ps.X = pl1c.X - (pl1c.X - pl1a.X) * (k / 100)
        ps.Y = pl1c.Y
        g.DrawLine(Pens.Black, pl1c, ps)
        ps.X = pl1a1.X + (pl1b1.X - pl1a1.X) * (k / 100)
        ps.Y = pl1a1.Y - (pl1a1.Y - pl1b1.Y) * (k / 100)
        g.DrawLine(Pens.Black, pl1a1, ps)
        ps.X = pl1b1.X + (pl1c1.X - pl1b1.X) * (k / 100)
        ps.Y = pl1b1.Y + (pl1c1.Y - pl1b1.Y) * (k / 100)
        g.DrawLine(Pens.Black, pl1b1, ps)
        ps.X = pl1c1.X - (pl1c1.X - pl1a1.X) * (k / 100)
        ps.Y = pl1c1.Y
        g.DrawLine(Pens.Black, pl1c1, ps)
        k += 1
        pct1.Image = mybitmap1
        If k > 100 Then
            k = 1
            g.DrawString("A", drawFont, drawBrush, pl1a.X - 20, pl1a.Y)
            g.DrawString("B", drawFont, drawBrush, pl1b.X - 10, pl1b.Y - 20)
            g.DrawString("C", drawFont, drawBrush, pl1c.X, pl1c.Y)
            g.DrawString("A1", drawFont, drawBrush, pl1a1.X, pl1a1.Y)
            g.DrawString("B1", drawFont, drawBrush, pl1b1.X - 10, pl1b1.Y)
            g.DrawString("C1", drawFont, drawBrush, pl1c1.X - 20, pl1c1.Y)
            pct1.Image = mybitmap1
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub pct1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct1.MouseClick
        If dop1 = True Then

        ElseIf dop1 = False Then
            If type = 1 Then
                g.FillEllipse(Brushes.White, pl1m1.X - 3, pl1m1.Y - 3, 6, 6)
                g.DrawString("A", drawFont, drawBrush, pl1a.X - 20, pl1a.Y)
                g.DrawString("B", drawFont, drawBrush, pl1b.X - 10, pl1b.Y - 20)
                g.DrawString("C", drawFont, drawBrush, pl1c.X, pl1c.Y)
                g.DrawString("A1", drawFont, drawBrush, pl1a1.X, pl1a1.Y)
                g.DrawString("B1", drawFont, drawBrush, pl1b1.X - 10, pl1b1.Y)
                g.DrawString("C1", drawFont, drawBrush, pl1c1.X - 20, pl1c1.Y)
                g.DrawLine(Pens.Black, pl1a1, pl1b1)
                g.DrawLine(Pens.Black, pl1b1, pl1c1)
                g.DrawLine(Pens.Black, pl1c1, pl1a1)
                g.DrawLine(Pens.Black, pl1a, pl1b)
                g.DrawLine(Pens.Black, pl1b, pl1c)
                g.DrawLine(Pens.Black, pl1c, pl1a)
                pl1m1.X = e.X
                pl1m1.Y = e.Y
                g.FillEllipse(Brushes.Red, pl1m1.X - 3, pl1m1.Y - 3, 6, 6)
                pct1.Image = mybitmap1
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        kk = Val(Trim(TextBox1.Text))
        If pl1m1.X > (pl1m.X - 15) And pl1m1.X < (pl1m.X + 15) And pl1m1.Y > (pl1m.Y - 15) And pl1m1.Y < (pl1m.Y + 15) And kk = -2 Then
            mes.Show()
            mes.Label1.Text = "Ви успішно виконали усі завдання на першому рівні! Другий рівень розблоковано!"

            Label1.Visible = False
            Panel2.Visible = True
        Else
            mes.Show()
            mes.Label1.Text = "Не правильне положення точка М, або коефіцієнт гомотетії k."

        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim pen As New Pen(Brushes.Black)
        pen.DashStyle = Drawing2D.DashStyle.Dash
        g.DrawLine(pen, pl1a, pl1a1)
        g.DrawLine(pen, pl1b, pl1b1)
        g.DrawLine(pen, pl1c, pl1c1)
        pct1.Image = mybitmap1
    End Sub

    Private Sub pct2_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct2.MouseClick
        If Not dop3 = True Then
            If type2 = 1 Then
                If type22 = 1 Then
                    g2.DrawLine(Pens.White, pl2a1, pl2b1)
                    g2.DrawLine(Pens.White, pl2b1, pl2c1)
                    g2.DrawLine(Pens.White, pl2c1, pl2d1)
                    g2.DrawLine(Pens.White, pl2d1, pl2a1)
                    g2.DrawLine(Pens.Black, pl2a, pl2b)
                    g2.DrawLine(Pens.Black, pl2b, pl2c)
                    g2.DrawLine(Pens.Black, pl2c, pl2d)
                    g2.DrawLine(Pens.Black, pl2d, pl2a)
                    g2.DrawLine(Pens.Black, pl2c, pl2a)
                    g2.DrawLine(Pens.Black, pl2d, pl2b)
                    g2.DrawLine(Pens.Black, pl2c, pl2o)
                    g2.DrawString("A", drawFont, drawBrush, pl2a.X - 20, pl2a.Y)
                    g2.DrawString("B", drawFont, drawBrush, pl2b.X - 20, pl2b.Y - 20)
                    g2.DrawString("C", drawFont, drawBrush, pl2c.X, pl2c.Y - 20)
                    g2.DrawString("D", drawFont, drawBrush, pl2d.X, pl2d.Y)
                    g2.DrawString("O", drawFont, drawBrush, pl2o.X + 5, pl2o.Y - 10)
                    pl2a1.X = e.X
                    pl2a1.Y = e.Y
                    pct2.Image = mybitmap2
                    type22 = 2


                ElseIf type22 = 2 Then

                    pl2b1.X = e.X
                    pl2b1.Y = e.Y
                    type22 = 3

                ElseIf type22 = 3 Then

                    pl2c1.X = e.X
                    pl2c1.Y = e.Y
                    type22 = 4

                ElseIf type22 = 4 Then

                    pl2d1.X = e.X
                    pl2d1.Y = e.Y
                    g2.DrawLine(Pens.Black, pl2d1, pl2a1)
                    pct2.Image = mybitmap2
                    type22 = 1
                End If
            ElseIf type2 = 2 Then
                If type22 = 1 Then
                    g2.DrawLine(Pens.White, pl2a2, pl2b2)
                    g2.DrawLine(Pens.White, pl2b2, pl2c2)
                    g2.DrawLine(Pens.White, pl2c2, pl2d2)
                    g2.DrawLine(Pens.White, pl2d2, pl2a2)

                    g2.DrawLine(Pens.Black, pl2a, pl2b)
                    g2.DrawLine(Pens.Black, pl2b, pl2c)
                    g2.DrawLine(Pens.Black, pl2c, pl2d)
                    g2.DrawLine(Pens.Black, pl2d, pl2a)
                    g2.DrawLine(Pens.Black, pl2c, pl2a)
                    g2.DrawLine(Pens.Black, pl2d, pl2b)
                    g2.DrawLine(Pens.Black, pl2c, pl2o)
                    g2.DrawString("A", drawFont, drawBrush, pl2a.X - 20, pl2a.Y)
                    g2.DrawString("B", drawFont, drawBrush, pl2b.X - 20, pl2b.Y - 20)
                    g2.DrawString("C", drawFont, drawBrush, pl2c.X, pl2c.Y - 20)
                    g2.DrawString("D", drawFont, drawBrush, pl2d.X, pl2d.Y)
                    g2.DrawString("O", drawFont, drawBrush, pl2o.X + 5, pl2o.Y - 10)
                    pl2a2.X = e.X
                    pl2a2.Y = e.Y
                    pct2.Image = mybitmap2
                    type22 = 2


                ElseIf type22 = 2 Then

                    pl2b2.X = e.X
                    pl2b2.Y = e.Y
                    type22 = 3

                ElseIf type22 = 3 Then

                    pl2c2.X = e.X
                    pl2c2.Y = e.Y
                    type22 = 4

                ElseIf type22 = 4 Then

                    pl2d2.X = e.X
                    pl2d2.Y = e.Y
                    g2.DrawLine(Pens.Black, pl2d2, pl2a2)
                    pct2.Image = mybitmap2
                    type22 = 1
                End If
            End If
        End If
    End Sub

    Private Sub pct2_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct2.MouseMove
        If dop3 = True And dop4 = True Then
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            Dim pen2 As New Pen(Brushes.White)
            pen2.DashStyle = Drawing2D.DashStyle.Dash
            g2.DrawLine(pen2, mp2(mn2 - 2), mp2(mn2 - 1))
            mp2(mn2 - 1).X = e.X
            mp2(mn2 - 1).Y = e.Y
            g2.DrawLine(pen, mp2(mn2 - 2), mp2(mn2 - 1))
            For i = 2 To mn2 Step 2
                g2.DrawLine(pen, mp2(i - 2), mp2(i - 1))
            Next
            g2.DrawLine(Pens.Black, pl2a, pl2b)
            g2.DrawLine(Pens.Black, pl2b, pl2c)
            g2.DrawLine(Pens.Black, pl2c, pl2d)
            g2.DrawLine(Pens.Black, pl2d, pl2a)
            g2.DrawLine(Pens.Black, pl2c, pl2a)
            g2.DrawLine(Pens.Black, pl2d, pl2b)
            g2.DrawLine(Pens.Black, pl2c, pl2o)
            g2.DrawString("A", drawFont, drawBrush, pl2a.X - 20, pl2a.Y)
            g2.DrawString("B", drawFont, drawBrush, pl2b.X - 20, pl2b.Y - 20)
            g2.DrawString("C", drawFont, drawBrush, pl2c.X, pl2c.Y - 20)
            g2.DrawString("D", drawFont, drawBrush, pl2d.X, pl2d.Y)
            g2.DrawString("O", drawFont, drawBrush, pl2o.X + 5, pl2o.Y - 10)
            pct2.Image = mybitmap2
        Else
            If type2 = 1 Then
                If type22 = 2 Then
                    g2.DrawLine(Pens.White, pl2a1, pl2b1)

                    g2.DrawLine(Pens.White, pl2a1, pl2b1)
                    g2.DrawLine(Pens.White, pl2b1, pl2c1)
                    g2.DrawLine(Pens.White, pl2c1, pl2d1)
                    g2.DrawLine(Pens.White, pl2d1, pl2a1)
                    g2.DrawLine(Pens.Black, pl2a, pl2b)
                    g2.DrawLine(Pens.Black, pl2b, pl2c)
                    g2.DrawLine(Pens.Black, pl2c, pl2d)
                    g2.DrawLine(Pens.Black, pl2d, pl2a)
                    g2.DrawLine(Pens.Black, pl2c, pl2a)
                    g2.DrawLine(Pens.Black, pl2d, pl2b)
                    g2.DrawLine(Pens.Black, pl2c, pl2o)
                    g2.DrawString("A", drawFont, drawBrush, pl2a.X - 20, pl2a.Y)
                    g2.DrawString("B", drawFont, drawBrush, pl2b.X - 20, pl2b.Y - 20)
                    g2.DrawString("C", drawFont, drawBrush, pl2c.X, pl2c.Y - 20)
                    g2.DrawString("D", drawFont, drawBrush, pl2d.X, pl2d.Y)
                    g2.DrawString("O", drawFont, drawBrush, pl2o.X + 5, pl2o.Y - 10)
                    pl2b1.X = e.X
                    pl2b1.Y = e.Y
                    g2.DrawLine(Pens.Black, pl2a1, pl2b1)
                    pct2.Image = mybitmap2
                ElseIf type22 = 3 Then
                    g2.DrawLine(Pens.White, pl2b1, pl2c1)


                    g2.DrawLine(Pens.Black, pl2a1, pl2b1)
                    g2.DrawLine(Pens.Black, pl2a, pl2b)
                    g2.DrawLine(Pens.Black, pl2b, pl2c)
                    g2.DrawLine(Pens.Black, pl2c, pl2d)
                    g2.DrawLine(Pens.Black, pl2d, pl2a)
                    g2.DrawLine(Pens.Black, pl2c, pl2a)
                    g2.DrawLine(Pens.Black, pl2d, pl2b)
                    g2.DrawLine(Pens.Black, pl2c, pl2o)
                    g2.DrawString("A", drawFont, drawBrush, pl2a.X - 20, pl2a.Y)
                    g2.DrawString("B", drawFont, drawBrush, pl2b.X - 20, pl2b.Y - 20)
                    g2.DrawString("C", drawFont, drawBrush, pl2c.X, pl2c.Y - 20)
                    g2.DrawString("D", drawFont, drawBrush, pl2d.X, pl2d.Y)
                    g2.DrawString("O", drawFont, drawBrush, pl2o.X + 5, pl2o.Y - 10)
                    pl2c1.X = e.X
                    pl2c1.Y = e.Y
                    g2.DrawLine(Pens.Black, pl2b1, pl2c1)
                    pct2.Image = mybitmap2
                ElseIf type22 = 4 Then
                    g2.DrawLine(Pens.White, pl2c1, pl2d1)
                    g2.DrawLine(Pens.Black, pl2b1, pl2c1)
                    g2.DrawLine(Pens.Black, pl2a1, pl2b1)
                    g2.DrawLine(Pens.Black, pl2a, pl2b)
                    g2.DrawLine(Pens.Black, pl2b, pl2c)
                    g2.DrawLine(Pens.Black, pl2c, pl2d)
                    g2.DrawLine(Pens.Black, pl2d, pl2a)
                    g2.DrawLine(Pens.Black, pl2c, pl2a)
                    g2.DrawLine(Pens.Black, pl2d, pl2b)
                    g2.DrawLine(Pens.Black, pl2c, pl2o)
                    g2.DrawString("A", drawFont, drawBrush, pl2a.X - 20, pl2a.Y)
                    g2.DrawString("B", drawFont, drawBrush, pl2b.X - 20, pl2b.Y - 20)
                    g2.DrawString("C", drawFont, drawBrush, pl2c.X, pl2c.Y - 20)
                    g2.DrawString("D", drawFont, drawBrush, pl2d.X, pl2d.Y)
                    g2.DrawString("O", drawFont, drawBrush, pl2o.X + 5, pl2o.Y - 10)
                    pl2d1.X = e.X
                    pl2d1.Y = e.Y
                    g2.DrawLine(Pens.Black, pl2c1, pl2d1)

                    pct2.Image = mybitmap2
                End If
            ElseIf type2 = 2 Then
                If type22 = 2 Then
                    g2.DrawLine(Pens.White, pl2a2, pl2b2)

                    g2.DrawLine(Pens.White, pl2a2, pl2b2)
                    g2.DrawLine(Pens.White, pl2b2, pl2c2)
                    g2.DrawLine(Pens.White, pl2c2, pl2d2)
                    g2.DrawLine(Pens.White, pl2d2, pl2a2)
                    g2.DrawLine(Pens.Black, pl2a1, pl2b1)
                    g2.DrawLine(Pens.Black, pl2b1, pl2c1)
                    g2.DrawLine(Pens.Black, pl2c1, pl2d1)
                    g2.DrawLine(Pens.Black, pl2d1, pl2a1)
                    g2.DrawLine(Pens.Black, pl2a, pl2b)
                    g2.DrawLine(Pens.Black, pl2b, pl2c)
                    g2.DrawLine(Pens.Black, pl2c, pl2d)
                    g2.DrawLine(Pens.Black, pl2d, pl2a)
                    g2.DrawLine(Pens.Black, pl2c, pl2a)
                    g2.DrawLine(Pens.Black, pl2d, pl2b)
                    g2.DrawLine(Pens.Black, pl2c, pl2o)
                    g2.DrawString("A", drawFont, drawBrush, pl2a.X - 20, pl2a.Y)
                    g2.DrawString("B", drawFont, drawBrush, pl2b.X - 20, pl2b.Y - 20)
                    g2.DrawString("C", drawFont, drawBrush, pl2c.X, pl2c.Y - 20)
                    g2.DrawString("D", drawFont, drawBrush, pl2d.X, pl2d.Y)
                    g2.DrawString("O", drawFont, drawBrush, pl2o.X + 5, pl2o.Y - 10)
                    pl2b2.X = e.X
                    pl2b2.Y = e.Y
                    g2.DrawLine(Pens.Black, pl2a2, pl2b2)
                    pct2.Image = mybitmap2
                ElseIf type22 = 3 Then
                    g2.DrawLine(Pens.White, pl2b2, pl2c2)


                    g2.DrawLine(Pens.Black, pl2a2, pl2b2)
                    g2.DrawLine(Pens.Black, pl2a1, pl2b1)
                    g2.DrawLine(Pens.Black, pl2b1, pl2c1)
                    g2.DrawLine(Pens.Black, pl2c1, pl2d1)
                    g2.DrawLine(Pens.Black, pl2d1, pl2a1)
                    g2.DrawLine(Pens.Black, pl2a, pl2b)
                    g2.DrawLine(Pens.Black, pl2b, pl2c)
                    g2.DrawLine(Pens.Black, pl2c, pl2d)
                    g2.DrawLine(Pens.Black, pl2d, pl2a)
                    g2.DrawLine(Pens.Black, pl2c, pl2a)
                    g2.DrawLine(Pens.Black, pl2d, pl2b)
                    g2.DrawLine(Pens.Black, pl2c, pl2o)
                    g2.DrawString("A", drawFont, drawBrush, pl2a.X - 20, pl2a.Y)
                    g2.DrawString("B", drawFont, drawBrush, pl2b.X - 20, pl2b.Y - 20)
                    g2.DrawString("C", drawFont, drawBrush, pl2c.X, pl2c.Y - 20)
                    g2.DrawString("D", drawFont, drawBrush, pl2d.X, pl2d.Y)
                    g2.DrawString("O", drawFont, drawBrush, pl2o.X + 5, pl2o.Y - 10)
                    pl2c2.X = e.X
                    pl2c2.Y = e.Y
                    g2.DrawLine(Pens.Black, pl2b2, pl2c2)
                    pct2.Image = mybitmap2
                ElseIf type22 = 4 Then
                    g2.DrawLine(Pens.White, pl2c2, pl2d2)
                    g2.DrawLine(Pens.Black, pl2b2, pl2c2)
                    g2.DrawLine(Pens.Black, pl2a2, pl2b2)
                    g2.DrawLine(Pens.Black, pl2a1, pl2b1)
                    g2.DrawLine(Pens.Black, pl2b1, pl2c1)
                    g2.DrawLine(Pens.Black, pl2c1, pl2d1)
                    g2.DrawLine(Pens.Black, pl2d1, pl2a1)
                    g2.DrawLine(Pens.Black, pl2a, pl2b)
                    g2.DrawLine(Pens.Black, pl2b, pl2c)
                    g2.DrawLine(Pens.Black, pl2c, pl2d)
                    g2.DrawLine(Pens.Black, pl2d, pl2a)
                    g2.DrawLine(Pens.Black, pl2c, pl2a)
                    g2.DrawLine(Pens.Black, pl2d, pl2b)
                    g2.DrawLine(Pens.Black, pl2c, pl2o)
                    g2.DrawString("A", drawFont, drawBrush, pl2a.X - 20, pl2a.Y)
                    g2.DrawString("B", drawFont, drawBrush, pl2b.X - 20, pl2b.Y - 20)
                    g2.DrawString("C", drawFont, drawBrush, pl2c.X, pl2c.Y - 20)
                    g2.DrawString("D", drawFont, drawBrush, pl2d.X, pl2d.Y)
                    g2.DrawString("O", drawFont, drawBrush, pl2o.X + 5, pl2o.Y - 10)
                    pl2d2.X = e.X
                    pl2d2.Y = e.Y
                    g2.DrawLine(Pens.Black, pl2c2, pl2d2)

                    pct2.Image = mybitmap2
                End If
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click

        Dim pen As New Pen(Brushes.Black)
        pen.DashStyle = Drawing2D.DashStyle.Dash
        Dim po As Point
        po.X = pl2a.X - (pl2o.X - pl2a.X) * (0.5)
        po.Y = pl2a.Y + (pl2a.Y - pl2o.Y) * (0.5)
        g2.DrawLine(pen, pl2o, po)
        po.X = pl2b.X - (pl2o.X - pl2b.X) * (0.5)
        po.Y = pl2b.Y - (pl2o.Y - pl2b.Y) * (0.5)
        g2.DrawLine(pen, pl2o, po)
        po.X = pl2c.X + (pl2c.X - pl2o.X) * (0.5)
        po.Y = pl2c.Y - (pl2o.Y - pl2c.Y) * (0.5)
        g2.DrawLine(pen, pl2o, po)
        po.X = pl2d.X + (pl2d.X - pl2o.X) * (0.5)
        po.Y = pl2d.Y + (pl2d.Y - pl2o.Y) * (0.5)
        g2.DrawLine(pen, pl2o, po)

        pct2.Image = mybitmap2

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If type2 = 1 And ((pl2a1.X > (pl2a.X - (pl2o.X - pl2a.X) * (0.5) - 15) And pl2a1.X < (pl2a.X - (pl2o.X - pl2a.X) * (0.5) + 15) And pl2a1.Y > pl2a.Y + (pl2a.Y - pl2o.Y) * (0.5) - 15 And pl2a1.Y < pl2a.Y + (pl2a.Y - pl2o.Y) * (0.5) + 15 _
            And pl2b1.X > (pl2b.X - (pl2o.X - pl2b.X) * (0.5) - 15) And pl2b1.X < (pl2b.X - (pl2o.X - pl2b.X) * (0.5) + 15) And pl2b1.Y > (pl2b.Y - (pl2o.Y - pl2b.Y) * (0.5) - 15) And pl2b1.Y < (pl2b.Y - (pl2o.Y - pl2b.Y) * (0.5) + 15) _
            And pl2c1.X > (pl2c.X + (pl2c.X - pl2o.X) * (0.5) - 15) And pl2c1.X < (pl2c.X + (pl2c.X - pl2o.X) * (0.5) + 15) And pl2c1.Y > (pl2c.Y - (pl2o.Y - pl2c.Y) * (0.5) - 15) And pl2c1.Y < (pl2c.Y - (pl2o.Y - pl2c.Y) * (0.5) + 15) _
            And pl2d1.X > (pl2d.X + (pl2d.X - pl2o.X) * (0.5) - 15) And pl2d1.X < (pl2d.X + (pl2d.X - pl2o.X) * (0.5) + 15) And pl2d1.Y > (pl2d.Y + (pl2d.Y - pl2o.Y) * (0.5) - 15) And pl2d1.Y < (pl2d.Y + (pl2d.Y - pl2o.Y) * (0.5) + 15)) _
        Or (pl2b1.X > (pl2a.X - (pl2o.X - pl2a.X) * (0.5) - 15) And pl2b1.X < (pl2a.X - (pl2o.X - pl2a.X) * (0.5) + 15) And pl2b1.Y > pl2a.Y + (pl2a.Y - pl2o.Y) * (0.5) - 15 And pl2b1.Y < pl2a.Y + (pl2a.Y - pl2o.Y) * (0.5) + 15 _
            And pl2c1.X > (pl2b.X - (pl2o.X - pl2b.X) * (0.5) - 15) And pl2c1.X < (pl2b.X - (pl2o.X - pl2b.X) * (0.5) + 15) And pl2c1.Y > (pl2b.Y - (pl2o.Y - pl2b.Y) * (0.5) - 15) And pl2c1.Y < (pl2b.Y - (pl2o.Y - pl2b.Y) * (0.5) + 15) _
            And pl2d1.X > (pl2c.X + (pl2c.X - pl2o.X) * (0.5) - 15) And pl2d1.X < (pl2c.X + (pl2c.X - pl2o.X) * (0.5) + 15) And pl2d1.Y > (pl2c.Y - (pl2o.Y - pl2c.Y) * (0.5) - 15) And pl2d1.Y < (pl2c.Y - (pl2o.Y - pl2c.Y) * (0.5) + 15) _
            And pl2a1.X > (pl2d.X + (pl2d.X - pl2o.X) * (0.5) - 15) And pl2a1.X < (pl2d.X + (pl2d.X - pl2o.X) * (0.5) + 15) And pl2a1.Y > (pl2d.Y + (pl2d.Y - pl2o.Y) * (0.5) - 15) And pl2a1.Y < (pl2d.Y + (pl2d.Y - pl2o.Y) * (0.5) + 15)) _
          Or (pl2c1.X > (pl2a.X - (pl2o.X - pl2a.X) * (0.5) - 15) And pl2c1.X < (pl2a.X - (pl2o.X - pl2a.X) * (0.5) + 15) And pl2c1.Y > pl2a.Y + (pl2a.Y - pl2o.Y) * (0.5) - 15 And pl2c1.Y < pl2a.Y + (pl2a.Y - pl2o.Y) * (0.5) + 15 _
            And pl2d1.X > (pl2b.X - (pl2o.X - pl2b.X) * (0.5) - 15) And pl2d1.X < (pl2b.X - (pl2o.X - pl2b.X) * (0.5) + 15) And pl2d1.Y > (pl2b.Y - (pl2o.Y - pl2b.Y) * (0.5) - 15) And pl2d1.Y < (pl2b.Y - (pl2o.Y - pl2b.Y) * (0.5) + 15) _
            And pl2a1.X > (pl2c.X + (pl2c.X - pl2o.X) * (0.5) - 15) And pl2a1.X < (pl2c.X + (pl2c.X - pl2o.X) * (0.5) + 15) And pl2a1.Y > (pl2c.Y - (pl2o.Y - pl2c.Y) * (0.5) - 15) And pl2a1.Y < (pl2c.Y - (pl2o.Y - pl2c.Y) * (0.5) + 15) _
            And pl2b1.X > (pl2d.X + (pl2d.X - pl2o.X) * (0.5) - 15) And pl2b1.X < (pl2d.X + (pl2d.X - pl2o.X) * (0.5) + 15) And pl2b1.Y > (pl2d.Y + (pl2d.Y - pl2o.Y) * (0.5) - 15) And pl2b1.Y < (pl2d.Y + (pl2d.Y - pl2o.Y) * (0.5) + 15)) _
          Or (pl2d1.X > (pl2a.X - (pl2o.X - pl2a.X) * (0.5) - 15) And pl2d1.X < (pl2a.X - (pl2o.X - pl2a.X) * (0.5) + 15) And pl2d1.Y > pl2a.Y + (pl2a.Y - pl2o.Y) * (0.5) - 15 And pl2d1.Y < pl2a.Y + (pl2a.Y - pl2o.Y) * (0.5) + 15 _
            And pl2a1.X > (pl2b.X - (pl2o.X - pl2b.X) * (0.5) - 15) And pl2a1.X < (pl2b.X - (pl2o.X - pl2b.X) * (0.5) + 15) And pl2a1.Y > (pl2b.Y - (pl2o.Y - pl2b.Y) * (0.5) - 15) And pl2a1.Y < (pl2b.Y - (pl2o.Y - pl2b.Y) * (0.5) + 15) _
            And pl2b1.X > (pl2c.X + (pl2c.X - pl2o.X) * (0.5) - 15) And pl2b1.X < (pl2c.X + (pl2c.X - pl2o.X) * (0.5) + 15) And pl2b1.Y > (pl2c.Y - (pl2o.Y - pl2c.Y) * (0.5) - 15) And pl2b1.Y < (pl2c.Y - (pl2o.Y - pl2c.Y) * (0.5) + 15) _
            And pl2c1.X > (pl2d.X + (pl2d.X - pl2o.X) * (0.5) - 15) And pl2c1.X < (pl2d.X + (pl2d.X - pl2o.X) * (0.5) + 15) And pl2c1.Y > (pl2d.Y + (pl2d.Y - pl2o.Y) * (0.5) - 15) And pl2c1.Y < (pl2d.Y + (pl2d.Y - pl2o.Y) * (0.5) + 15))) Then
            type2 = 2
            Label10.Visible = True
            mes.Show()
            mes.Label1.Text = "Ви виконали перше завдання!"

        ElseIf type2 = 2 And ((pl2a2.X > (pl2a.X + (pl2o.X - pl2a.X) * (0.5) - 15) And pl2a2.X < (pl2a.X + (pl2o.X - pl2a.X) * (0.5) + 15) And pl2a2.Y > pl2a.Y - (pl2a.Y - pl2o.Y) * (0.5) - 15 And pl2a2.Y < pl2a.Y - (pl2a.Y - pl2o.Y) * (0.5) + 15 _
            And pl2b2.X > (pl2b.X + (pl2o.X - pl2b.X) * (0.5) - 15) And pl2b2.X < (pl2b.X + (pl2o.X - pl2b.X) * (0.5) + 15) And pl2b2.Y > (pl2b.Y + (pl2o.Y - pl2b.Y) * (0.5) - 15) And pl2b2.Y < (pl2b.Y + (pl2o.Y - pl2b.Y) * (0.5) + 15) _
            And pl2c2.X > (pl2c.X - (pl2c.X - pl2o.X) * (0.5) - 15) And pl2c2.X < (pl2c.X - (pl2c.X - pl2o.X) * (0.5) + 15) And pl2c2.Y > (pl2c.Y + (pl2o.Y - pl2c.Y) * (0.5) - 15) And pl2c2.Y < (pl2c.Y + (pl2o.Y - pl2c.Y) * (0.5) + 15) _
            And pl2d2.X > (pl2d.X - (pl2d.X - pl2o.X) * (0.5) - 15) And pl2d2.X < (pl2d.X - (pl2d.X - pl2o.X) * (0.5) + 15) And pl2d2.Y > (pl2d.Y - (pl2d.Y - pl2o.Y) * (0.5) - 15) And pl2d2.Y < (pl2d.Y - (pl2d.Y - pl2o.Y) * (0.5) + 15)) _
             Or (pl2b2.X > (pl2a.X + (pl2o.X - pl2a.X) * (0.5) - 15) And pl2b2.X < (pl2a.X + (pl2o.X - pl2a.X) * (0.5) + 15) And pl2b2.Y > pl2a.Y - (pl2a.Y - pl2o.Y) * (0.5) - 15 And pl2b2.Y < pl2a.Y - (pl2a.Y - pl2o.Y) * (0.5) + 15 _
                 And pl2c2.X > (pl2b.X + (pl2o.X - pl2b.X) * (0.5) - 15) And pl2c2.X < (pl2b.X + (pl2o.X - pl2b.X) * (0.5) + 15) And pl2c2.Y > (pl2b.Y + (pl2o.Y - pl2b.Y) * (0.5) - 15) And pl2c2.Y < (pl2b.Y + (pl2o.Y - pl2b.Y) * (0.5) + 15) _
                 And pl2d2.X > (pl2c.X - (pl2c.X - pl2o.X) * (0.5) - 15) And pl2d2.X < (pl2c.X - (pl2c.X - pl2o.X) * (0.5) + 15) And pl2d2.Y > (pl2c.Y + (pl2o.Y - pl2c.Y) * (0.5) - 15) And pl2d2.Y < (pl2c.Y + (pl2o.Y - pl2c.Y) * (0.5) + 15) _
                 And pl2a2.X > (pl2d.X - (pl2d.X - pl2o.X) * (0.5) - 15) And pl2a2.X < (pl2d.X - (pl2d.X - pl2o.X) * (0.5) + 15) And pl2a2.Y > (pl2d.Y - (pl2d.Y - pl2o.Y) * (0.5) - 15) And pl2a2.Y < (pl2d.Y - (pl2d.Y - pl2o.Y) * (0.5) + 15)) _
               Or (pl2c2.X > (pl2a.X + (pl2o.X - pl2a.X) * (0.5) - 15) And pl2c2.X < (pl2a.X + (pl2o.X - pl2a.X) * (0.5) + 15) And pl2c2.Y > pl2a.Y - (pl2a.Y - pl2o.Y) * (0.5) - 15 And pl2c2.Y < pl2a.Y - (pl2a.Y - pl2o.Y) * (0.5) + 15 _
                 And pl2d2.X > (pl2b.X + (pl2o.X - pl2b.X) * (0.5) - 15) And pl2d2.X < (pl2b.X + (pl2o.X - pl2b.X) * (0.5) + 15) And pl2d2.Y > (pl2b.Y + (pl2o.Y - pl2b.Y) * (0.5) - 15) And pl2d2.Y < (pl2b.Y + (pl2o.Y - pl2b.Y) * (0.5) + 15) _
                 And pl2a2.X > (pl2c.X - (pl2c.X - pl2o.X) * (0.5) - 15) And pl2a2.X < (pl2c.X - (pl2c.X - pl2o.X) * (0.5) + 15) And pl2a2.Y > (pl2c.Y + (pl2o.Y - pl2c.Y) * (0.5) - 15) And pl2a2.Y < (pl2c.Y + (pl2o.Y - pl2c.Y) * (0.5) + 15) _
                 And pl2b2.X > (pl2d.X - (pl2d.X - pl2o.X) * (0.5) - 15) And pl2b2.X < (pl2d.X - (pl2d.X - pl2o.X) * (0.5) + 15) And pl2b2.Y > (pl2d.Y - (pl2d.Y - pl2o.Y) * (0.5) - 15) And pl2b2.Y < (pl2d.Y - (pl2d.Y - pl2o.Y) * (0.5) + 15)) _
               Or (pl2d2.X > (pl2a.X + (pl2o.X - pl2a.X) * (0.5) - 15) And pl2d2.X < (pl2a.X + (pl2o.X - pl2a.X) * (0.5) + 15) And pl2d2.Y > pl2a.Y - (pl2a.Y - pl2o.Y) * (0.5) - 15 And pl2d2.Y < pl2a.Y - (pl2a.Y - pl2o.Y) * (0.5) + 15 _
                 And pl2a2.X > (pl2b.X + (pl2o.X - pl2b.X) * (0.5) - 15) And pl2a2.X < (pl2b.X + (pl2o.X - pl2b.X) * (0.5) + 15) And pl2a2.Y > (pl2b.Y + (pl2o.Y - pl2b.Y) * (0.5) - 15) And pl2a2.Y < (pl2b.Y + (pl2o.Y - pl2b.Y) * (0.5) + 15) _
                 And pl2b2.X > (pl2c.X - (pl2c.X - pl2o.X) * (0.5) - 15) And pl2b2.X < (pl2c.X - (pl2c.X - pl2o.X) * (0.5) + 15) And pl2b2.Y > (pl2c.Y + (pl2o.Y - pl2c.Y) * (0.5) - 15) And pl2b2.Y < (pl2c.Y + (pl2o.Y - pl2c.Y) * (0.5) + 15) _
                 And pl2c2.X > (pl2d.X - (pl2d.X - pl2o.X) * (0.5) - 15) And pl2c2.X < (pl2d.X - (pl2d.X - pl2o.X) * (0.5) + 15) And pl2c2.Y > (pl2d.Y - (pl2d.Y - pl2o.Y) * (0.5) - 15) And pl2c2.Y < (pl2d.Y - (pl2d.Y - pl2o.Y) * (0.5) + 15))) Then
            type2 = 3
            Label2.Visible = False
            Panel3.Visible = True
            mes.Show()
            mes.Label1.Text = "Ви виконали усі завдання на другом рівні! Третій рівень розблоковано!"

        Else
            mes.Show()
            mes.Label1.Text = "Не правильне положення точок."

        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            dop1 = True
        ElseIf CheckBox1.Checked = False Then
            dop1 = False
        End If
    End Sub

    Private Sub pct1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct1.MouseDown


        If dop1 = True Then
            mp(mn - 2).X = e.X
            mp(mn - 2).Y = e.Y
            dop2 = True
        End If
    End Sub

    Private Sub pct1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct1.MouseMove
        If dop1 = True And dop2 = True Then
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            Dim pen2 As New Pen(Brushes.White)
            pen2.DashStyle = Drawing2D.DashStyle.Dash
            g.DrawLine(pen2, mp(mn - 2), mp(mn - 1))
            mp(mn - 1).X = e.X
            mp(mn - 1).Y = e.Y
            g.DrawLine(pen, mp(mn - 2), mp(mn - 1))
            For i = 2 To mn Step 2
                g.DrawLine(pen, mp(i - 2), mp(i - 1))

            Next

            g.DrawString("A", drawFont, drawBrush, pl1a.X - 20, pl1a.Y)
            g.DrawString("B", drawFont, drawBrush, pl1b.X - 10, pl1b.Y - 20)
            g.DrawString("C", drawFont, drawBrush, pl1c.X, pl1c.Y)
            g.DrawString("A1", drawFont, drawBrush, pl1a1.X, pl1a1.Y)
            g.DrawString("B1", drawFont, drawBrush, pl1b1.X - 10, pl1b1.Y)
            g.DrawString("C1", drawFont, drawBrush, pl1c1.X - 20, pl1c1.Y)
            g.DrawLine(Pens.Black, pl1a1, pl1b1)
            g.DrawLine(Pens.Black, pl1b1, pl1c1)
            g.DrawLine(Pens.Black, pl1c1, pl1a1)

            g.DrawLine(Pens.Black, pl1a, pl1b)
            g.DrawLine(Pens.Black, pl1b, pl1c)
            g.DrawLine(Pens.Black, pl1c, pl1a)
            pct1.Image = mybitmap1

        End If
    End Sub

    Private Sub pct1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct1.MouseUp
        If dop1 = True And dop2 = True Then
            dop2 = False
            mn += 2
            ReDim Preserve mp(mn)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            dop3 = True
        ElseIf CheckBox2.Checked = False Then
            dop3 = False
        End If
    End Sub

    Private Sub pct2_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct2.MouseUp
        If dop3 = True And dop4 = True Then
            dop4 = False
            mn2 += 2
            ReDim Preserve mp2(mn2)
        End If
    End Sub

    Private Sub pct2_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct2.MouseDown
        If dop3 = True Then
            dop4 = True
            mp2(mn2 - 2).X = e.X
            mp2(mn2 - 2).Y = e.Y
        End If
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        g.FillRectangle(Brushes.White, 0, 0, 500, 500)
        g.DrawString("A", drawFont, drawBrush, pl1a.X - 20, pl1a.Y)
        g.DrawString("B", drawFont, drawBrush, pl1b.X - 10, pl1b.Y - 20)
        g.DrawString("C", drawFont, drawBrush, pl1c.X, pl1c.Y)
        g.DrawString("A1", drawFont, drawBrush, pl1a1.X, pl1a1.Y)
        g.DrawString("B1", drawFont, drawBrush, pl1b1.X - 10, pl1b1.Y)
        g.DrawString("C1", drawFont, drawBrush, pl1c1.X - 20, pl1c1.Y)
        g.DrawLine(Pens.Black, pl1a1, pl1b1)
        g.DrawLine(Pens.Black, pl1b1, pl1c1)
        g.DrawLine(Pens.Black, pl1c1, pl1a1)
        mn = 2
        ReDim mp(2)
        g.DrawLine(Pens.Black, pl1a, pl1b)
        g.DrawLine(Pens.Black, pl1b, pl1c)
        g.DrawLine(Pens.Black, pl1c, pl1a)
        pct1.Image = mybitmap1

    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        g2.FillRectangle(Brushes.White, 0, 0, 500, 500)
        g2.DrawLine(Pens.Black, pl2a, pl2b)
        g2.DrawLine(Pens.Black, pl2b, pl2c)
        g2.DrawLine(Pens.Black, pl2c, pl2d)
        g2.DrawLine(Pens.Black, pl2d, pl2a)
        g2.DrawLine(Pens.Black, pl2c, pl2a)
        g2.DrawLine(Pens.Black, pl2d, pl2b)
        g2.DrawLine(Pens.Black, pl2c, pl2o)
        mn2 = 2
        ReDim mp2(2)
        g2.DrawString("A", drawFont, drawBrush, pl2a.X - 20, pl2a.Y)
        g2.DrawString("B", drawFont, drawBrush, pl2b.X - 20, pl2b.Y - 20)
        g2.DrawString("C", drawFont, drawBrush, pl2c.X, pl2c.Y - 20)
        g2.DrawString("D", drawFont, drawBrush, pl2d.X, pl2d.Y)
        g2.DrawString("O", drawFont, drawBrush, pl2o.X + 5, pl2o.Y - 10)
        pct2.Image = mybitmap2
    End Sub

    Private Sub pct3_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct3.MouseClick
        If Not dop5 = True Then
            If type4 = 1 Then
                g3.DrawLine(Pens.White, pl3a1, pl3c1)
                g3.DrawLine(Pens.White, pl3b1, pl3a1)
                g3.DrawLine(Pens.White, pl3b1, pl3c1)
                g3.FillEllipse(Brushes.White, pl3b1.X - 3, pl3b1.Y - 3, 6, 6)
                g3.FillEllipse(Brushes.White, pl3a1.X - 3, pl3a1.Y - 3, 6, 6)
                g3.FillEllipse(Brushes.White, pl3c1.X - 3, pl3c1.Y - 3, 6, 6)
                g3.DrawString("A", drawFont, drawBrush, pl3a.X - 22, pl3a.Y)
                g3.DrawString("B", drawFont, drawBrush, pl3b.X - 10, pl3b.Y - 22)
                g3.DrawString("C", drawFont, drawBrush, pl3c.X, pl3c.Y)
                For i = x1 To x2
                    For j = y2 To y1
                        If e.X > XtoI(i) - 3 And e.X < XtoI(i) + 3 And e.Y > YtoJ(j) - 3 And e.Y < YtoJ(j) + 3 Then
                            pl3a1.X = XtoI(i)
                            pl3a1.Y = YtoJ(j)
                            g3.FillEllipse(Brushes.Red, XtoI(i) - 3, YtoJ(j) - 3, 6, 6)
                            pct3.Image = mybitmap3
                            pom2 = True
                            Exit For
                        Else
                            g3.FillEllipse(Brushes.White, pl3a1.X - 3, pl3a1.Y - 3, 6, 6)
                            OSI()
                            pom2 = False
                            g3.DrawLine(Pens.Black, pl3a, pl3b)
                            g3.DrawLine(Pens.Black, pl3b, pl3c)
                            g3.DrawLine(Pens.Black, pl3a, pl3c)
                            g3.DrawString("A", drawFont, drawBrush, pl3a.X - 22, pl3a.Y)
                            g3.DrawString("B", drawFont, drawBrush, pl3b.X - 10, pl3b.Y - 22)
                            g3.DrawString("C", drawFont, drawBrush, pl3c.X, pl3c.Y)
                            g3.FillEllipse(Brushes.Red, pl3m.X - 3, pl3m.Y - 3, 6, 6)
                            g3.DrawString("M", drawFont, drawBrush, pl3m.X, pl3m.Y)
                            pct3.Image = mybitmap3
                        End If
                    Next
                    If pom2 = True Then
                        Exit For
                    End If
                Next
                type4 = 2
                pct3.Image = mybitmap3
            ElseIf type4 = 2 Then
                For i = x1 To x2
                    For j = y2 To y1
                        If e.X > XtoI(i) - 3 And e.X < XtoI(i) + 3 And e.Y > YtoJ(j) - 3 And e.Y < YtoJ(j) + 3 Then
                            pl3b1.X = XtoI(i)
                            pl3b1.Y = YtoJ(j)
                            g3.FillEllipse(Brushes.Red, XtoI(i) - 3, YtoJ(j) - 3, 6, 6)
                            pct3.Image = mybitmap3
                            pom2 = True
                            Exit For
                        Else
                            g3.FillEllipse(Brushes.White, pl3b1.X - 3, pl3b1.Y - 3, 6, 6)
                            OSI()
                            pom2 = False
                            g3.DrawLine(Pens.Black, pl3a, pl3b)
                            g3.DrawLine(Pens.Black, pl3b, pl3c)
                            g3.DrawLine(Pens.Black, pl3a, pl3c)
                            g3.DrawString("A", drawFont, drawBrush, pl3a.X - 22, pl3a.Y)
                            g3.DrawString("B", drawFont, drawBrush, pl3b.X - 10, pl3b.Y - 22)
                            g3.DrawString("C", drawFont, drawBrush, pl3c.X, pl3c.Y)
                            g3.FillEllipse(Brushes.Red, pl3m.X - 3, pl3m.Y - 3, 6, 6)
                            g3.DrawString("M", drawFont, drawBrush, pl3m.X, pl3m.Y)
                            pct3.Image = mybitmap3
                        End If
                    Next
                    If pom2 = True Then
                        Exit For
                    End If
                Next
                type4 = 3
                g3.DrawLine(Pens.Black, pl3a1, pl3b1)
                pct3.Image = mybitmap3
            ElseIf type4 = 3 Then
                For i = x1 To x2
                    For j = y2 To y1
                        If e.X > XtoI(i) - 3 And e.X < XtoI(i) + 3 And e.Y > YtoJ(j) - 3 And e.Y < YtoJ(j) + 3 Then
                            pl3c1.X = XtoI(i)
                            pl3c1.Y = YtoJ(j)
                            g3.FillEllipse(Brushes.Red, XtoI(i) - 3, YtoJ(j) - 3, 6, 6)
                            pct3.Image = mybitmap3
                            pom2 = True
                            Exit For
                        Else
                            g3.FillEllipse(Brushes.White, pl3c1.X - 3, pl3c1.Y - 3, 6, 6)
                            OSI()
                            pom2 = False
                            g3.DrawLine(Pens.Black, pl3a, pl3b)
                            g3.DrawLine(Pens.Black, pl3b, pl3c)
                            g3.DrawLine(Pens.Black, pl3a, pl3c)
                            g3.DrawString("A", drawFont, drawBrush, pl3a.X - 22, pl3a.Y)
                            g3.DrawString("B", drawFont, drawBrush, pl3b.X - 10, pl3b.Y - 22)
                            g3.DrawString("C", drawFont, drawBrush, pl3c.X, pl3c.Y)
                            g3.FillEllipse(Brushes.Red, pl3m.X - 3, pl3m.Y - 3, 6, 6)
                            g3.DrawString("M", drawFont, drawBrush, pl3m.X, pl3m.Y)
                            pct3.Image = mybitmap3
                        End If
                    Next
                    If pom2 = True Then
                        Exit For
                    End If
                Next
                type4 = 1
                g3.DrawLine(Pens.Black, pl3a1, pl3c1)
                g3.DrawLine(Pens.Black, pl3c1, pl3b1)
                g3.DrawLine(Pens.Black, pl3a1, pl3b1)
                pct3.Image = mybitmap3
            End If
        End If
    End Sub

    Private Sub Button9_Click_1(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If ((pl3a1.X = XtoI(1) And pl3a1.Y = YtoJ(-2)) And (pl3b1.X = XtoI(-2) And pl3b1.Y = YtoJ(-5)) And (pl3c1.X = XtoI(-5) And pl3c1.Y = YtoJ(-2))) Or ((pl3b1.X = XtoI(1) And pl3b1.Y = YtoJ(-2)) And (pl3c1.X = XtoI(-2) And pl3c1.Y = YtoJ(-5)) And (pl3a1.X = XtoI(-5) And pl3a1.Y = YtoJ(-2))) Or ((pl3c1.X = XtoI(1) And pl3c1.Y = YtoJ(-2)) And (pl3a1.X = XtoI(-2) And pl3a1.Y = YtoJ(-5)) And (pl3b1.X = XtoI(-5) And pl3b1.Y = YtoJ(-2))) Then
            mes.Show()
            mes.Label1.Text = "Ви виконали усі завдання на цьюму рівні і пройшли гру з гомотетії!"

        Else
            mes.Show()
            mes.Label1.Text = "Неправильне положення точок, або неправильно вказана площа!"

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            dop5 = True
        ElseIf CheckBox3.Checked = False Then
            dop5 = False
        End If
    End Sub

    Private Sub pct3_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct3.MouseDown
        If dop5 = True Then
            dop6 = True
            mp3(mn3 - 2).X = e.X
            mp3(mn3 - 2).Y = e.Y
        End If
    End Sub

    Private Sub pct3_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct3.MouseMove
        If dop5 = True And dop6 = True Then
            OSI()
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            Dim pen2 As New Pen(Brushes.White)
            pen2.DashStyle = Drawing2D.DashStyle.Dash
            g3.DrawLine(pen2, mp3(mn3 - 2), mp3(mn3 - 1))
            g3.DrawLine(Pens.Black, pl3a, pl3b)
            g3.DrawLine(Pens.Black, pl3b, pl3c)
            g3.DrawLine(Pens.Black, pl3a, pl3c)
            g3.DrawString("A", drawFont, drawBrush, pl3a.X - 22, pl3a.Y)
            g3.DrawString("B", drawFont, drawBrush, pl3b.X - 10, pl3b.Y - 22)
            g3.DrawString("C", drawFont, drawBrush, pl3c.X, pl3c.Y)
            g3.FillEllipse(Brushes.Red, pl3m.X - 3, pl3m.Y - 3, 6, 6)
            g3.DrawString("M", drawFont, drawBrush, pl3m.X, pl3m.Y)
            pct3.Image = mybitmap3
            mp3(mn3 - 1).X = e.X
            mp3(mn3 - 1).Y = e.Y
            g3.DrawLine(pen, mp3(mn3 - 2), mp3(mn3 - 1))
            For i = 2 To mn3 Step 2
                g3.DrawLine(pen, mp3(i - 2), mp3(i - 1))
            Next

            pct3.Image = mybitmap3
        End If
    End Sub

    Private Sub pct3_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct3.MouseUp
        If dop5 = True And dop6 = True Then
            dop6 = False
            mn3 += 2
            ReDim Preserve mp3(mn3)
        End If
    End Sub

    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        g3.FillRectangle(Brushes.White, 0, 0, 500, 500)
        OSI()
        mn3 = 2
        ReDim mp3(2)
        g3.DrawLine(Pens.Black, pl3a, pl3b)
        g3.DrawLine(Pens.Black, pl3b, pl3c)
        g3.DrawLine(Pens.Black, pl3a, pl3c)
        g3.DrawString("A", drawFont, drawBrush, pl3a.X - 22, pl3a.Y)
        g3.DrawString("B", drawFont, drawBrush, pl3b.X - 10, pl3b.Y - 22)
        g3.DrawString("C", drawFont, drawBrush, pl3c.X, pl3c.Y)
        g3.FillEllipse(Brushes.Red, pl3m.X - 3, pl3m.Y - 3, 6, 6)
        g3.DrawString("M", drawFont, drawBrush, pl3m.X, pl3m.Y)
        pct3.Image = mybitmap3
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub igraG_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button7_Click_1(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.Hide()
        Гомотетия.Show()
    End Sub
End Class