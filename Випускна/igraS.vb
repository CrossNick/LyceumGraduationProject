Public Class igraS
    Dim g, g2, g3 As Graphics
    Dim ps, pl1z1, pal1, pbl1, pcl1, pdl1, pel1, pfl1, pp1l1, pp2l1 As Point
    Dim type, k As Integer
    Dim myBitmap, myBitmap2, myBitmap3 As Bitmap
    Dim bool1 As Boolean
    Dim dop1, dop2, dop3, dop4, dop5, dop6 As Boolean
    Dim dopp1, dopp2, dopp3, dopp4, dopp6, dopp5 As Point
    Dim pl21, pl22, pl23, pl24, pl25, pl26, pl27, pl28, pl29, pl211, pl222, pl233, pl244, pl255, pl266, pl277, pl288, pl299 As Point
    Dim bool2 As Boolean
    Dim type2 As Integer

    Dim mp(2), mp2(2), mp3(2), mp4(2), mp5(2) As Point
    Dim mn, mn2 As Integer

    Dim i1, i2, j1, j2 As Integer
    Dim x1, x2, y1, y2 As Single

    Dim drawFont As New Font("TimesNewRoman", 16)
    Dim drawBrush As New SolidBrush(Color.Black)

    Private Sub igraS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myBitmap = New Bitmap(pct1.Width, pct1.Height)
        g = Graphics.FromImage(myBitmap)
        myBitmap2 = New Bitmap(pct1.Width, pct1.Height)
        g2 = Graphics.FromImage(myBitmap2)
        myBitmap3 = New Bitmap(pct1.Width, pct1.Height)
        g3 = Graphics.FromImage(myBitmap3)

        mn = 2
        mn2 = 2

        type2 = 1
        pp1l1.X = 0
        pp1l1.Y = 0
        pp2l1.X = 0
        pp2l1.Y = 0
        type = 0
        k = 1
        dop1 = False
        dop2 = False
        dop3 = False
        dop4 = False
        dop5 = False
        dop6 = False
        Label2.BringToFront()
        bool1 = False
        pl1z1.X = 0
        pl1z1.Y = 0
        pal1.X = 180
        pal1.Y = 130
        pbl1.X = 330
        pbl1.Y = 130
        pel1.X = 180
        pel1.Y = 370
        pdl1.X = 330
        pdl1.Y = 370
        pcl1.X = 410
        pcl1.Y = 250
        pfl1.X = 100
        pfl1.Y = 250
        'g.DrawLine(Pens.Black, pal1, pbl1)
        'g.DrawLine(Pens.Black, pbl1, pcl1)
        'g.DrawLine(Pens.Black, pcl1, pdl1)
        'g.DrawLine(Pens.Black, pdl1, pel1)
        'g.DrawLine(Pens.Black, pel1, pfl1)
        'g.DrawLine(Pens.Black, pfl1, pal1)
        pct1.Image = myBitmap
        Timer1.Interval = 10
        Timer1.Enabled = True
        Label1.SendToBack()
        Label2.SendToBack()
        TabControl1.SendToBack()
        dopp4.X = 0
        dopp4.Y = 0
        dopp2.X = 0
        dopp2.Y = 0
        dopp6.X = 0
        dopp6.Y = 0
        pl21.X = 250
        pl21.Y = 90
        pl22.X = 200
        pl22.Y = 150
        pl23.X = 230
        pl23.Y = 150
        pl24.X = 170
        pl24.Y = 250
        pl25.X = 200
        pl25.Y = 250
        pl26.X = 120
        pl26.Y = 320
        pl27.X = 210
        pl27.Y = 320
        pl28.X = 210
        pl28.Y = 350
        pl29.X = 250
        pl29.Y = 350

        Dim p(6) As Point
        p(0) = pl21
        p(1) = pl22
        p(2) = pl23
        p(3) = pl24
        p(4) = pl25
        p(5) = pl26
        p(6).X = 250
        p(6).Y = 320
        g2.FillPolygon(Brushes.Green, p)
        Dim p1(3) As Point
        p1(0) = pl27
        p1(1) = pl28
        p1(2) = pl29
        p1(3).X = 250
        p1(3).Y = 320
        g2.FillPolygon(Brushes.Brown, p1)
        Dim pen As New Pen(Brushes.Black)
        pen.DashStyle = Drawing2D.DashStyle.Dash
        g2.DrawLine(pen, 250, 0, 250, 500)
        g2.DrawLine(Pens.Black, pl21, pl22)
        g2.DrawLine(Pens.Black, pl22, pl23)
        g2.DrawLine(Pens.Black, pl23, pl24)
        g2.DrawLine(Pens.Black, pl24, pl25)
        g2.DrawLine(Pens.Black, pl25, pl26)
        g2.DrawLine(Pens.Black, pl26, pl27)
        g2.DrawLine(Pens.Black, pl27, pl28)
        g2.DrawLine(Pens.Black, pl28, pl29)
        g2.DrawLine(Pens.Black, pl29, pl21)
        pct2.Image = myBitmap2

        x1 = -10
        y1 = 10
        x2 = 10
        y2 = -10
        i1 = 0
        j1 = 0
        i2 = pct3.Width
        j2 = pct3.Height
        OSI()
        g3.DrawEllipse(Pens.Black, XtoI(-7), YtoJ(-5), XtoI(-6), XtoI(-6))
        g3.FillEllipse(Brushes.Red, XtoI(-1) - 3, YtoJ(2) - 3, 6, 6)
        g3.DrawString("M", drawFont, drawBrush, XtoI(-1) - 22, YtoJ(2) - 22)
        pct3.Image = myBitmap3
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
        If type = 0 Then
            ps.X = pal1.X + (pbl1.X - pal1.X) * (k / 100)
            ps.Y = pal1.Y
            g.DrawLine(Pens.Black, ps, pal1)
            ps.X = pbl1.X + (pcl1.X - pbl1.X) * (k / 100)
            ps.Y = pbl1.Y + (pcl1.Y - pbl1.Y) * (k / 100)
            g.DrawLine(Pens.Black, ps, pbl1)
            ps.X = pcl1.X - (pcl1.X - pdl1.X) * (k / 100)
            ps.Y = pcl1.Y + (pdl1.Y - pcl1.Y) * (k / 100)
            g.DrawLine(Pens.Black, ps, pcl1)
            ps.X = pdl1.X - (pdl1.X - pel1.X) * (k / 100)
            ps.Y = pdl1.Y
            g.DrawLine(Pens.Black, ps, pdl1)
            ps.X = pel1.X - (pel1.X - pfl1.X) * (k / 100)
            ps.Y = pel1.Y - (pel1.Y - pfl1.Y) * (k / 100)
            g.DrawLine(Pens.Black, ps, pel1)
            ps.X = pfl1.X + (pal1.X - pfl1.X) * (k / 100)
            ps.Y = pfl1.Y - (pfl1.Y - pal1.Y) * (k / 100)
            g.DrawLine(Pens.Black, ps, pfl1)
            k += 1
            pct1.Image = myBitmap
            If k > 100 Then
                type = 1
                k = 1
                g.DrawString("A", drawFont, drawBrush, pal1.X - 10, pal1.Y - 22)
                g.DrawString("B", drawFont, drawBrush, pbl1.X, pbl1.Y - 22)
                g.DrawString("C", drawFont, drawBrush, pcl1.X, pcl1.Y - 10)
                g.DrawString("D", drawFont, drawBrush, pdl1.X, pdl1.Y)
                g.DrawString("E", drawFont, drawBrush, pel1.X - 10, pel1.Y)
                g.DrawString("F", drawFont, drawBrush, pfl1.X - 20, pfl1.Y - 10)
                l1z1.Visible = True
                lbl1.Text = "Оберіть точку всередені шестикутника, яка на вашу думку є центром симетрії"
                Timer1.Enabled = False

            End If
        End If
    End Sub

    Private Sub pct1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct1.MouseClick
        If Not dop1 = True Then


            If type = 1 Then
                g.FillEllipse(Brushes.White, pl1z1.X - 3, pl1z1.Y - 3, 6, 6)
                pl1z1.X = e.X
                pl1z1.Y = e.Y
                g.FillEllipse(Brushes.Red, pl1z1.X - 3, pl1z1.Y - 3, 6, 6)
                pct1.Image = myBitmap
            ElseIf type = 2 Then
                g.DrawLine(Pens.White, pp1l1, pp2l1)
                g.DrawLine(Pens.Black, pal1, pbl1)
                g.DrawLine(Pens.Black, pbl1, pcl1)
                g.DrawLine(Pens.Black, pcl1, pdl1)
                g.DrawLine(Pens.Black, pdl1, pel1)
                g.DrawLine(Pens.Black, pel1, pfl1)
                g.DrawLine(Pens.Black, pfl1, pal1)
                g.DrawString("A", drawFont, drawBrush, pal1.X - 10, pal1.Y - 22)
                g.DrawString("B", drawFont, drawBrush, pbl1.X, pbl1.Y - 22)
                g.DrawString("C", drawFont, drawBrush, pcl1.X, pcl1.Y - 10)
                g.DrawString("D", drawFont, drawBrush, pdl1.X, pdl1.Y)
                g.DrawString("E", drawFont, drawBrush, pel1.X - 10, pel1.Y)
                g.DrawString("F", drawFont, drawBrush, pfl1.X - 20, pfl1.Y - 10)
                pct1.Image = myBitmap
                bool1 = True
                pp1l1.X = e.X
                pp1l1.Y = e.Y
                type = 3
            ElseIf type = 3 Then
                g.DrawLine(Pens.Black, pal1, pbl1)
                g.DrawLine(Pens.Black, pbl1, pcl1)
                g.DrawLine(Pens.Black, pcl1, pdl1)
                g.DrawLine(Pens.Black, pdl1, pel1)
                g.DrawLine(Pens.Black, pel1, pfl1)
                g.DrawLine(Pens.Black, pfl1, pal1)
                g.DrawString("A", drawFont, drawBrush, pal1.X - 10, pal1.Y - 22)
                g.DrawString("B", drawFont, drawBrush, pbl1.X, pbl1.Y - 22)
                g.DrawString("C", drawFont, drawBrush, pcl1.X, pcl1.Y - 10)
                g.DrawString("D", drawFont, drawBrush, pdl1.X, pdl1.Y)
                g.DrawString("E", drawFont, drawBrush, pel1.X - 10, pel1.Y)
                g.DrawString("F", drawFont, drawBrush, pfl1.X - 20, pfl1.Y - 10)
                pct1.Image = myBitmap
                pp2l1.X = e.X
                pp2l1.Y = e.Y
                type = 2
                bool1 = False
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If type = 1 Then

            If pl1z1.X > (pcl1.X - (pcl1.X - pfl1.X) / 2 - 15) And pl1z1.X < (pcl1.X - (pcl1.X - pfl1.X) / 2 + 15) And pl1z1.Y > (pel1.Y - (pel1.Y - pal1.Y) / 2 - 15) And pl1z1.Y < (pel1.Y - (pel1.Y - pal1.Y) / 2 + 15) Then
                Dim pom1, pom2 As Integer
                Dim pen As New Pen(Brushes.White)
                pen.DashStyle = Drawing2D.DashStyle.Dash
                g.DrawLine(pen, pal1, pdl1)
                g.DrawLine(pen, pbl1, pel1)
                g.DrawLine(pen, pfl1, pcl1)
                pom1 = pel1.Y - (pel1.Y - pal1.Y) / 2 - 3
                pom2 = pcl1.X - (pcl1.X - pfl1.X) / 2 - 3
                g.FillEllipse(Brushes.White, pl1z1.X - 3, pl1z1.Y - 3, 6, 6)
                pct1.Image = myBitmap
                mes.Show()
                mes.Label1.Text = "Ви успішно виконали перше завдання!"

                type = 2
                l1z2.Visible = True
                lbl1.Text = "Проведіть пряму через сторони АВ i DE, яка на вашу думку є віссю симетрії"
            Else
                mes.Show()
                mes.Label1.Text = "Не првильне положення, спробуйте ще раз!"

            End If
        ElseIf type = 2 Then
            If pp1l1.X > (pal1.X + (pbl1.X - pal1.X) / 2 - 15) And pp1l1.X < (pal1.X + (pbl1.X - pal1.X) / 2 + 15) And pp2l1.X > (pal1.X + (pbl1.X - pal1.X) / 2 - 15) And pp2l1.X < (pal1.X + (pbl1.X - pal1.X) / 2 + 15) Then

                mes.Show()
                mes.Label1.Text = "Ви успішно виконали Друге завдання! Другий рівень розблоковано!"
                type = 4
                Panel2.Visible = True
                Label1.Visible = False
                lbl1.Text = "Ви виконали вся завдання на цьому рівні! Спробуйти пройти другий!"
            Else

                mes.Show()
                mes.Label1.Text = "Не првильне положення, спробуйте ще раз!"
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If type = 1 Then
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            g.DrawLine(pen, pal1, pdl1)
            g.DrawLine(pen, pbl1, pel1)
            g.DrawLine(pen, pfl1, pcl1)
            pct1.Image = myBitmap
        ElseIf type = 2 Then
            Dim pen As New Pen(Brushes.Black)
            Dim pom As Integer
            pom = (pal1.X + (pbl1.X - pal1.X) / 2)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            g.DrawLine(pen, pom, pal1.Y, pom, pel1.Y)

            pct1.Image = myBitmap
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()

        Симетрия.Show()
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
            g.DrawLine(Pens.Black, pal1, pbl1)
            g.DrawLine(Pens.Black, pbl1, pcl1)
            g.DrawLine(Pens.Black, pcl1, pdl1)
            g.DrawLine(Pens.Black, pdl1, pel1)
            g.DrawLine(Pens.Black, pel1, pfl1)
            g.DrawLine(Pens.Black, pfl1, pal1)
            g.DrawString("A", drawFont, drawBrush, pal1.X - 10, pal1.Y - 22)
            g.DrawString("B", drawFont, drawBrush, pbl1.X, pbl1.Y - 22)
            g.DrawString("C", drawFont, drawBrush, pcl1.X, pcl1.Y - 10)
            g.DrawString("D", drawFont, drawBrush, pdl1.X, pdl1.Y)
            g.DrawString("E", drawFont, drawBrush, pel1.X - 10, pel1.Y)
            g.DrawString("F", drawFont, drawBrush, pfl1.X - 20, pfl1.Y - 10)
            pct1.Image = myBitmap
        Else
            If bool1 = True Then
                g.DrawLine(Pens.White, pp1l1, pp2l1)
                g.DrawLine(Pens.Black, pal1, pbl1)
                g.DrawLine(Pens.Black, pbl1, pcl1)
                g.DrawLine(Pens.Black, pcl1, pdl1)
                g.DrawLine(Pens.Black, pdl1, pel1)
                g.DrawLine(Pens.Black, pel1, pfl1)
                g.DrawLine(Pens.Black, pfl1, pal1)
                g.DrawString("A", drawFont, drawBrush, pal1.X - 10, pal1.Y - 22)
                g.DrawString("B", drawFont, drawBrush, pbl1.X, pbl1.Y - 22)
                g.DrawString("C", drawFont, drawBrush, pcl1.X, pcl1.Y - 10)
                g.DrawString("D", drawFont, drawBrush, pdl1.X, pdl1.Y)
                g.DrawString("E", drawFont, drawBrush, pel1.X - 10, pel1.Y)
                g.DrawString("F", drawFont, drawBrush, pfl1.X - 20, pfl1.Y - 10)

                g.DrawLine(Pens.White, pp1l1, pp2l1)
                pp2l1.X = e.X
                pp2l1.Y = e.Y

                g.DrawLine(Pens.Black, pp1l1, pp2l1)
                pct1.Image = myBitmap
            End If
        End If
    End Sub

    Private Sub pct2_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct2.MouseClick
        If type2 = 1 Then
            g2.DrawLine(Pens.White, pl211, pl222)
            g2.DrawLine(Pens.White, pl222, pl233)
            g2.DrawLine(Pens.White, pl233, pl244)
            g2.DrawLine(Pens.White, pl244, pl255)
            g2.DrawLine(Pens.White, pl255, pl266)
            g2.DrawLine(Pens.White, pl266, pl277)
            g2.DrawLine(Pens.White, pl277, pl288)
            g2.DrawLine(Pens.White, pl288, pl299)
            g2.DrawLine(Pens.White, pl299, pl211)

            Dim p(6) As Point
            p(0) = pl21
            p(1) = pl22
            p(2) = pl23
            p(3) = pl24
            p(4) = pl25
            p(5) = pl26
            p(6).X = 250
            p(6).Y = 320
            g2.FillPolygon(Brushes.Green, p)
            Dim p1(3) As Point
            p1(0) = pl27
            p1(1) = pl28
            p1(2) = pl29
            p1(3).X = 250
            p1(3).Y = 320
            g2.FillPolygon(Brushes.Brown, p1)
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            g2.DrawLine(pen, 250, 0, 250, 500)
            g2.DrawLine(Pens.Black, pl21, pl22)
            g2.DrawLine(Pens.Black, pl22, pl23)
            g2.DrawLine(Pens.Black, pl23, pl24)
            g2.DrawLine(Pens.Black, pl24, pl25)
            g2.DrawLine(Pens.Black, pl25, pl26)
            g2.DrawLine(Pens.Black, pl26, pl27)
            g2.DrawLine(Pens.Black, pl27, pl28)
            g2.DrawLine(Pens.Black, pl28, pl29)
            g2.DrawLine(Pens.Black, pl29, pl21)

            pct2.Image = myBitmap2
            pl211.X = e.X
            pl211.Y = e.Y
            type2 = 2
        ElseIf type2 = 2 Then
            pl222.X = e.X
            pl222.Y = e.Y
            type2 = 3
        ElseIf type2 = 3 Then
            pl233.X = e.X
            pl233.Y = e.Y
            type2 = 4
        ElseIf type2 = 4 Then
            pl244.X = e.X
            pl244.Y = e.Y
            type2 = 5
        ElseIf type2 = 5 Then
            pl255.X = e.X
            pl255.Y = e.Y
            type2 = 6
        ElseIf type2 = 6 Then
            pl266.X = e.X
            pl266.Y = e.Y
            type2 = 7
        ElseIf type2 = 7 Then
            pl277.X = e.X
            pl277.Y = e.Y
            type2 = 8
        ElseIf type2 = 8 Then
            pl288.X = e.X
            pl288.Y = e.Y
            type2 = 9
        ElseIf type2 = 9 Then
            pl299.X = e.X
            pl299.Y = e.Y
            type2 = 1
        End If
    End Sub

    Private Sub pct2_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct2.MouseMove
        If type2 = 2 Then

            Dim p(6) As Point
            p(0) = pl21
            p(1) = pl22
            p(2) = pl23
            p(3) = pl24
            p(4) = pl25
            p(5) = pl26
            p(6).X = 250
            p(6).Y = 320
            g2.FillPolygon(Brushes.Green, p)
            Dim p1(3) As Point
            p1(0) = pl27
            p1(1) = pl28
            p1(2) = pl29
            p1(3).X = 250
            p1(3).Y = 320
            g2.FillPolygon(Brushes.Brown, p1)
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            g2.DrawLine(pen, 250, 0, 250, 500)
            g2.DrawLine(Pens.Black, pl21, pl22)
            g2.DrawLine(Pens.Black, pl22, pl23)
            g2.DrawLine(Pens.Black, pl23, pl24)
            g2.DrawLine(Pens.Black, pl24, pl25)
            g2.DrawLine(Pens.Black, pl25, pl26)
            g2.DrawLine(Pens.Black, pl26, pl27)
            g2.DrawLine(Pens.Black, pl27, pl28)
            g2.DrawLine(Pens.Black, pl28, pl29)
            g2.DrawLine(Pens.Black, pl29, pl21)
            If bool2 = True Then
                g2.DrawLine(pen, pl21.X, pl21.Y, 300, 150)
                g2.DrawLine(pen, 300, 150, 270, 150)
                g2.DrawLine(pen, 270, 150, 330, 250)
                g2.DrawLine(pen, 330, 250, 300, 250)
                g2.DrawLine(pen, 300, 250, 380, 320)
                g2.DrawLine(pen, 380, 320, 290, 320)
                g2.DrawLine(pen, 290, 320, 290, 350)
                g2.DrawLine(pen, 290, 350, 250, 350)
            End If


            g2.DrawLine(Pens.White, pl211, pl222)
            pl222.X = e.X
            pl222.Y = e.Y
            g2.DrawLine(Pens.Black, pl211, pl222)

            pct2.Image = myBitmap2
        ElseIf type2 = 3 Then
            g2.DrawLine(Pens.Black, pl211, pl222)


            Dim p(6) As Point
            p(0) = pl21
            p(1) = pl22
            p(2) = pl23
            p(3) = pl24
            p(4) = pl25
            p(5) = pl26
            p(6).X = 250
            p(6).Y = 320
            g2.FillPolygon(Brushes.Green, p)
            Dim p1(3) As Point
            p1(0) = pl27
            p1(1) = pl28
            p1(2) = pl29
            p1(3).X = 250
            p1(3).Y = 320
            g2.FillPolygon(Brushes.Brown, p1)
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            g2.DrawLine(pen, 250, 0, 250, 500)
            g2.DrawLine(Pens.Black, pl21, pl22)
            g2.DrawLine(Pens.Black, pl22, pl23)
            g2.DrawLine(Pens.Black, pl23, pl24)
            g2.DrawLine(Pens.Black, pl24, pl25)
            g2.DrawLine(Pens.Black, pl25, pl26)
            g2.DrawLine(Pens.Black, pl26, pl27)
            g2.DrawLine(Pens.Black, pl27, pl28)
            g2.DrawLine(Pens.Black, pl28, pl29)
            g2.DrawLine(Pens.Black, pl29, pl21)

            If bool2 = True Then
                g2.DrawLine(pen, pl21.X, pl21.Y, 300, 150)
                g2.DrawLine(pen, 300, 150, 270, 150)
                g2.DrawLine(pen, 270, 150, 330, 250)
                g2.DrawLine(pen, 330, 250, 300, 250)
                g2.DrawLine(pen, 300, 250, 380, 320)
                g2.DrawLine(pen, 380, 320, 290, 320)
                g2.DrawLine(pen, 290, 320, 290, 350)
                g2.DrawLine(pen, 290, 350, 250, 350)
            End If


            g2.DrawLine(Pens.White, pl222, pl233)
            pl233.X = e.X
            pl233.Y = e.Y
            g2.DrawLine(Pens.Black, pl222, pl233)

            pct2.Image = myBitmap2
      
        ElseIf type2 = 4 Then
            g2.DrawLine(Pens.Black, pl211, pl222)
            g2.DrawLine(Pens.Black, pl222, pl233)
            Dim p(6) As Point
            p(0) = pl21
            p(1) = pl22
            p(2) = pl23
            p(3) = pl24
            p(4) = pl25
            p(5) = pl26
            p(6).X = 250
            p(6).Y = 320
            g2.FillPolygon(Brushes.Green, p)
            Dim p1(3) As Point
            p1(0) = pl27
            p1(1) = pl28
            p1(2) = pl29
            p1(3).X = 250
            p1(3).Y = 320
            g2.FillPolygon(Brushes.Brown, p1)
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            g2.DrawLine(pen, 250, 0, 250, 500)
            g2.DrawLine(Pens.Black, pl21, pl22)
            g2.DrawLine(Pens.Black, pl22, pl23)
            g2.DrawLine(Pens.Black, pl23, pl24)
            g2.DrawLine(Pens.Black, pl24, pl25)
            g2.DrawLine(Pens.Black, pl25, pl26)
            g2.DrawLine(Pens.Black, pl26, pl27)
            g2.DrawLine(Pens.Black, pl27, pl28)
            g2.DrawLine(Pens.Black, pl28, pl29)
            g2.DrawLine(Pens.Black, pl29, pl21)

            If bool2 = True Then
                g2.DrawLine(pen, pl21.X, pl21.Y, 300, 150)
                g2.DrawLine(pen, 300, 150, 270, 150)
                g2.DrawLine(pen, 270, 150, 330, 250)
                g2.DrawLine(pen, 330, 250, 300, 250)
                g2.DrawLine(pen, 300, 250, 380, 320)
                g2.DrawLine(pen, 380, 320, 290, 320)
                g2.DrawLine(pen, 290, 320, 290, 350)
                g2.DrawLine(pen, 290, 350, 250, 350)
            End If


            g2.DrawLine(Pens.White, pl233, pl244)
            pl244.X = e.X
            pl244.Y = e.Y
            g2.DrawLine(Pens.Black, pl233, pl244)

            pct2.Image = myBitmap2
        ElseIf type2 = 5 Then
            g2.DrawLine(Pens.Black, pl211, pl222)
            g2.DrawLine(Pens.Black, pl222, pl233)
            g2.DrawLine(Pens.Black, pl233, pl244)
            Dim p(6) As Point
            p(0) = pl21
            p(1) = pl22
            p(2) = pl23
            p(3) = pl24
            p(4) = pl25
            p(5) = pl26
            p(6).X = 250
            p(6).Y = 320
            g2.FillPolygon(Brushes.Green, p)
            Dim p1(3) As Point
            p1(0) = pl27
            p1(1) = pl28
            p1(2) = pl29
            p1(3).X = 250
            p1(3).Y = 320
            g2.FillPolygon(Brushes.Brown, p1)
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            g2.DrawLine(pen, 250, 0, 250, 500)
            g2.DrawLine(Pens.Black, pl21, pl22)
            g2.DrawLine(Pens.Black, pl22, pl23)
            g2.DrawLine(Pens.Black, pl23, pl24)
            g2.DrawLine(Pens.Black, pl24, pl25)
            g2.DrawLine(Pens.Black, pl25, pl26)
            g2.DrawLine(Pens.Black, pl26, pl27)
            g2.DrawLine(Pens.Black, pl27, pl28)
            g2.DrawLine(Pens.Black, pl28, pl29)
            g2.DrawLine(Pens.Black, pl29, pl21)

            If bool2 = True Then
                g2.DrawLine(pen, pl21.X, pl21.Y, 300, 150)
                g2.DrawLine(pen, 300, 150, 270, 150)
                g2.DrawLine(pen, 270, 150, 330, 250)
                g2.DrawLine(pen, 330, 250, 300, 250)
                g2.DrawLine(pen, 300, 250, 380, 320)
                g2.DrawLine(pen, 380, 320, 290, 320)
                g2.DrawLine(pen, 290, 320, 290, 350)
                g2.DrawLine(pen, 290, 350, 250, 350)
            End If


            g2.DrawLine(Pens.White, pl244, pl255)
            pl255.X = e.X
            pl255.Y = e.Y
            g2.DrawLine(Pens.Black, pl244, pl255)

            pct2.Image = myBitmap2
        ElseIf type2 = 6 Then
            g2.DrawLine(Pens.Black, pl211, pl222)
            g2.DrawLine(Pens.Black, pl222, pl233)
            g2.DrawLine(Pens.Black, pl233, pl244)
            g2.DrawLine(Pens.Black, pl244, pl255)
            Dim p(6) As Point
            p(0) = pl21
            p(1) = pl22
            p(2) = pl23
            p(3) = pl24
            p(4) = pl25
            p(5) = pl26
            p(6).X = 250
            p(6).Y = 320
            g2.FillPolygon(Brushes.Green, p)
            Dim p1(3) As Point
            p1(0) = pl27
            p1(1) = pl28
            p1(2) = pl29
            p1(3).X = 250
            p1(3).Y = 320
            g2.FillPolygon(Brushes.Brown, p1)
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            g2.DrawLine(pen, 250, 0, 250, 500)
            g2.DrawLine(Pens.Black, pl21, pl22)
            g2.DrawLine(Pens.Black, pl22, pl23)
            g2.DrawLine(Pens.Black, pl23, pl24)
            g2.DrawLine(Pens.Black, pl24, pl25)
            g2.DrawLine(Pens.Black, pl25, pl26)
            g2.DrawLine(Pens.Black, pl26, pl27)
            g2.DrawLine(Pens.Black, pl27, pl28)
            g2.DrawLine(Pens.Black, pl28, pl29)
            g2.DrawLine(Pens.Black, pl29, pl21)

            If bool2 = True Then
                g2.DrawLine(pen, pl21.X, pl21.Y, 300, 150)
                g2.DrawLine(pen, 300, 150, 270, 150)
                g2.DrawLine(pen, 270, 150, 330, 250)
                g2.DrawLine(pen, 330, 250, 300, 250)
                g2.DrawLine(pen, 300, 250, 380, 320)
                g2.DrawLine(pen, 380, 320, 290, 320)
                g2.DrawLine(pen, 290, 320, 290, 350)
                g2.DrawLine(pen, 290, 350, 250, 350)
            End If


            g2.DrawLine(Pens.White, pl255, pl266)
            pl266.X = e.X
            pl266.Y = e.Y
            g2.DrawLine(Pens.Black, pl255, pl266)

            pct2.Image = myBitmap2
        ElseIf type2 = 7 Then
            g2.DrawLine(Pens.Black, pl211, pl222)
            g2.DrawLine(Pens.Black, pl222, pl233)
            g2.DrawLine(Pens.Black, pl233, pl244)
            g2.DrawLine(Pens.Black, pl244, pl255)
            g2.DrawLine(Pens.Black, pl255, pl266)
            Dim p(6) As Point
            p(0) = pl21
            p(1) = pl22
            p(2) = pl23
            p(3) = pl24
            p(4) = pl25
            p(5) = pl26
            p(6).X = 250
            p(6).Y = 320
            g2.FillPolygon(Brushes.Green, p)
            Dim p1(3) As Point
            p1(0) = pl27
            p1(1) = pl28
            p1(2) = pl29
            p1(3).X = 250
            p1(3).Y = 320
            g2.FillPolygon(Brushes.Brown, p1)
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            g2.DrawLine(pen, 250, 0, 250, 500)
            g2.DrawLine(Pens.Black, pl21, pl22)
            g2.DrawLine(Pens.Black, pl22, pl23)
            g2.DrawLine(Pens.Black, pl23, pl24)
            g2.DrawLine(Pens.Black, pl24, pl25)
            g2.DrawLine(Pens.Black, pl25, pl26)
            g2.DrawLine(Pens.Black, pl26, pl27)
            g2.DrawLine(Pens.Black, pl27, pl28)
            g2.DrawLine(Pens.Black, pl28, pl29)
            g2.DrawLine(Pens.Black, pl29, pl21)

            If bool2 = True Then
                g2.DrawLine(pen, pl21.X, pl21.Y, 300, 150)
                g2.DrawLine(pen, 300, 150, 270, 150)
                g2.DrawLine(pen, 270, 150, 330, 250)
                g2.DrawLine(pen, 330, 250, 300, 250)
                g2.DrawLine(pen, 300, 250, 380, 320)
                g2.DrawLine(pen, 380, 320, 290, 320)
                g2.DrawLine(pen, 290, 320, 290, 350)
                g2.DrawLine(pen, 290, 350, 250, 350)
            End If


            g2.DrawLine(Pens.White, pl266, pl277)
            pl277.X = e.X
            pl277.Y = e.Y
            g2.DrawLine(Pens.Black, pl266, pl277)

            pct2.Image = myBitmap2
        ElseIf type2 = 8 Then
            g2.DrawLine(Pens.Black, pl211, pl222)
            g2.DrawLine(Pens.Black, pl222, pl233)
            g2.DrawLine(Pens.Black, pl233, pl244)
            g2.DrawLine(Pens.Black, pl244, pl255)
            g2.DrawLine(Pens.Black, pl255, pl266)
            g2.DrawLine(Pens.Black, pl266, pl277)
            Dim p(6) As Point
            p(0) = pl21
            p(1) = pl22
            p(2) = pl23
            p(3) = pl24
            p(4) = pl25
            p(5) = pl26
            p(6).X = 250
            p(6).Y = 320
            g2.FillPolygon(Brushes.Green, p)
            Dim p1(3) As Point
            p1(0) = pl27
            p1(1) = pl28
            p1(2) = pl29
            p1(3).X = 250
            p1(3).Y = 320
            g2.FillPolygon(Brushes.Brown, p1)
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            g2.DrawLine(pen, 250, 0, 250, 500)
            g2.DrawLine(Pens.Black, pl21, pl22)
            g2.DrawLine(Pens.Black, pl22, pl23)
            g2.DrawLine(Pens.Black, pl23, pl24)
            g2.DrawLine(Pens.Black, pl24, pl25)
            g2.DrawLine(Pens.Black, pl25, pl26)
            g2.DrawLine(Pens.Black, pl26, pl27)
            g2.DrawLine(Pens.Black, pl27, pl28)
            g2.DrawLine(Pens.Black, pl28, pl29)
            g2.DrawLine(Pens.Black, pl29, pl21)

            If bool2 = True Then
                g2.DrawLine(pen, pl21.X, pl21.Y, 300, 150)
                g2.DrawLine(pen, 300, 150, 270, 150)
                g2.DrawLine(pen, 270, 150, 330, 250)
                g2.DrawLine(pen, 330, 250, 300, 250)
                g2.DrawLine(pen, 300, 250, 380, 320)
                g2.DrawLine(pen, 380, 320, 290, 320)
                g2.DrawLine(pen, 290, 320, 290, 350)
                g2.DrawLine(pen, 290, 350, 250, 350)
            End If


            g2.DrawLine(Pens.White, pl277, pl288)
            pl288.X = e.X
            pl288.Y = e.Y
            g2.DrawLine(Pens.Black, pl277, pl288)

            pct2.Image = myBitmap2
        ElseIf type2 = 9 Then
            g2.DrawLine(Pens.Black, pl211, pl222)
            g2.DrawLine(Pens.Black, pl222, pl233)
            g2.DrawLine(Pens.Black, pl233, pl244)
            g2.DrawLine(Pens.Black, pl244, pl255)
            g2.DrawLine(Pens.Black, pl255, pl266)
            g2.DrawLine(Pens.Black, pl266, pl277)
            g2.DrawLine(Pens.Black, pl277, pl288)
            Dim p(6) As Point
            p(0) = pl21
            p(1) = pl22
            p(2) = pl23
            p(3) = pl24
            p(4) = pl25
            p(5) = pl26
            p(6).X = 250
            p(6).Y = 320
            g2.FillPolygon(Brushes.Green, p)
            Dim p1(3) As Point
            p1(0) = pl27
            p1(1) = pl28
            p1(2) = pl29
            p1(3).X = 250
            p1(3).Y = 320
            g2.FillPolygon(Brushes.Brown, p1)
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            g2.DrawLine(pen, 250, 0, 250, 500)
            g2.DrawLine(Pens.Black, pl21, pl22)
            g2.DrawLine(Pens.Black, pl22, pl23)
            g2.DrawLine(Pens.Black, pl23, pl24)
            g2.DrawLine(Pens.Black, pl24, pl25)
            g2.DrawLine(Pens.Black, pl25, pl26)
            g2.DrawLine(Pens.Black, pl26, pl27)
            g2.DrawLine(Pens.Black, pl27, pl28)
            g2.DrawLine(Pens.Black, pl28, pl29)
            g2.DrawLine(Pens.Black, pl29, pl21)

            If bool2 = True Then
                g2.DrawLine(pen, pl21.X, pl21.Y, 300, 150)
                g2.DrawLine(pen, 300, 150, 270, 150)
                g2.DrawLine(pen, 270, 150, 330, 250)
                g2.DrawLine(pen, 330, 250, 300, 250)
                g2.DrawLine(pen, 300, 250, 380, 320)
                g2.DrawLine(pen, 380, 320, 290, 320)
                g2.DrawLine(pen, 290, 320, 290, 350)
                g2.DrawLine(pen, 290, 350, 250, 350)
            End If


            g2.DrawLine(Pens.White, pl288, pl299)
            pl299.X = e.X
            pl299.Y = e.Y
            g2.DrawLine(Pens.Black, pl288, pl299)

            pct2.Image = myBitmap2
        End If

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If type2 = 1 Then
            If ((pl211.X > pl21.X - 20) And (pl211.X < pl21.X + 20) And (pl211.Y > pl21.Y - 20) And (pl211.Y < pl21.Y + 20)) And ((pl222.X > pl22.X + (250 - pl22.X) * 2 - 20) And (pl222.X < pl22.X + (250 - pl22.X) * 2 + 20) And (pl222.Y > pl22.Y - 20) And (pl222.Y < pl22.Y + 20)) And ((pl233.X > pl23.X + (250 - pl23.X) * 2 - 20) And (pl233.X < pl23.X + (250 - pl23.X) * 2 + 20) And (pl233.Y > pl23.Y - 20) And (pl233.Y < pl23.Y + 20)) And ((pl244.X > pl24.X + (250 - pl24.X) * 2 - 20) And (pl244.X < pl24.X + (250 - pl24.X) * 2 + 20) And (pl244.Y > pl24.Y - 20) And (pl244.Y < pl24.Y + 20)) And ((pl255.X > pl25.X + (250 - pl25.X) * 2 - 20) And (pl255.X < pl25.X + (250 - pl25.X) * 2 + 20) And (pl255.Y > pl25.Y - 20) And (pl255.Y < pl25.Y + 20)) And ((pl266.X > pl26.X + (250 - pl26.X) * 2 - 20) And (pl266.X < pl26.X + (250 - pl26.X) * 2 + 20) And (pl266.Y > pl26.Y - 20) And (pl266.Y < pl26.Y + 20)) And ((pl277.X > pl27.X + (250 - pl27.X) * 2 - 20) And (pl277.X < pl27.X + (250 - pl27.X) * 2 + 20) And (pl277.Y > pl27.Y - 20) And (pl277.Y < pl27.Y + 20)) And ((pl288.X > pl28.X + (250 - pl28.X) * 2 - 20) And (pl288.X < pl28.X + (250 - pl28.X) * 2 + 20) And (pl288.Y > pl28.Y - 20) And (pl288.Y < pl28.Y + 20)) And ((pl299.X > pl29.X + (250 - pl29.X) * 2 - 20) And (pl299.X < pl29.X + (250 - pl29.X) * 2 + 20) And (pl299.Y > pl29.Y - 20) And (pl299.Y < pl29.Y + 20)) Then
                Panel3.Visible = True
                Label2.Visible = False
                mes.Show()
                mes.Label1.Text = "Ви виконали усі завдання на другому рівні! Третій рівень розблоковано!"


                type2 = 0
            Else
                mes.Show()
                mes.Label1.Text = "Ви не правильно розмістили одну, або декілько точок. Спробуйте ще раз!"

            End If

        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim pen As New Pen(Brushes.Black)
        pen.DashStyle = Drawing2D.DashStyle.Dash
        'pl21.X = 250
        'pl21.Y = 90
        'pl22.X = 200
        'pl22.Y = 150
        'pl23.X = 230
        'pl23.Y = 150
        'pl24.X = 170
        'pl24.Y = 250
        'pl25.X = 200
        'pl25.Y = 250
        'pl26.X = 120
        'pl26.Y = 320
        'pl27.X = 210
        'pl27.Y = 320
        'pl28.X = 210
        'pl28.Y = 350
        'pl29.X = 250
        'pl29.Y = 350
        g2.DrawLine(pen, pl21.X, pl21.Y, 300, 150)
        g2.DrawLine(pen, 300, 150, 270, 150)
        g2.DrawLine(pen, 270, 150, 330, 250)
        g2.DrawLine(pen, 330, 250, 300, 250)
        g2.DrawLine(pen, 300, 250, 380, 320)
        g2.DrawLine(pen, 380, 320, 290, 320)
        g2.DrawLine(pen, 290, 320, 290, 350)
        g2.DrawLine(pen, 290, 350, 250, 350)
        bool2 = True
        pct2.Image = myBitmap2
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Симетрия.Show()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Me.Hide()
        IgraPP.Show()
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Me.Hide()
        igraP.Show()
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Me.Hide()
        igraG.Show()
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        Me.Hide()
        IgraPP.Show()
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        Me.Hide()
        igraP.Show()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        Me.Hide()
        igraG.Show()
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        Me.Hide()
        IgraPP.Show()
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        Me.Hide()
        igraP.Show()
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        Me.Hide()
        igraG.Show()
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
            dop2 = True
            mp(mn - 2).X = e.X
            mp(mn - 2).Y = e.Y
        End If
    End Sub

    Private Sub pct1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct1.MouseUp
        If dop1 = True And dop2 = True Then
            dop2 = False
            mn += 2
            ReDim Preserve mp(mn)

        End If
    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        g.FillRectangle(Brushes.White, 0, 0, 500, 500)
        g.DrawLine(Pens.Black, pal1, pbl1)
        g.DrawLine(Pens.Black, pbl1, pcl1)
        g.DrawLine(Pens.Black, pcl1, pdl1)
        g.DrawLine(Pens.Black, pdl1, pel1)
        g.DrawLine(Pens.Black, pel1, pfl1)
        g.DrawLine(Pens.Black, pfl1, pal1)
        g.DrawString("A", drawFont, drawBrush, pal1.X - 10, pal1.Y - 22)
        g.DrawString("B", drawFont, drawBrush, pbl1.X, pbl1.Y - 22)
        g.DrawString("C", drawFont, drawBrush, pcl1.X, pcl1.Y - 10)
        g.DrawString("D", drawFont, drawBrush, pdl1.X, pdl1.Y)
        g.DrawString("E", drawFont, drawBrush, pel1.X - 10, pel1.Y)
        g.DrawString("F", drawFont, drawBrush, pfl1.X - 20, pfl1.Y - 10)
        ReDim mp(2)
        mn = 2
        pct1.Image = myBitmap
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            dop5 = False
        ElseIf CheckBox2.Checked = True Then
            dop5 = True
        End If
    End Sub

    Private Sub pct3_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct3.MouseDown
        If dop5 = True Then
            dop6 = True
            mp2(mn2 - 2).X = e.X
            mp2(mn2 - 2).Y = e.Y
        End If
    End Sub

    Private Sub pct3_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct3.MouseMove
        If dop5 = True And dop6 = True Then
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            Dim pen2 As New Pen(Brushes.White)
            pen2.DashStyle = Drawing2D.DashStyle.Dash
            g3.DrawLine(pen2, mp2(mn2 - 2), mp2(mn2 - 1))
            mp2(mn2 - 1).X = e.X
            mp2(mn2 - 1).Y = e.Y
            g3.DrawLine(pen, mp2(mn2 - 2), mp2(mn2 - 1))
            OSI()
            For i = 2 To mn2 Step 2
                g3.DrawLine(pen, mp2(i - 2), mp2(i - 1))
            Next
            g3.DrawEllipse(Pens.Black, XtoI(-7), YtoJ(-5), XtoI(-6), XtoI(-6))
            g3.FillEllipse(Brushes.Red, XtoI(-1) - 3, YtoJ(2) - 3, 6, 6)
            g3.DrawString("M", drawFont, drawBrush, XtoI(-1) - 22, YtoJ(2) - 22)
            pct3.Image = myBitmap3
        End If
    End Sub

    Private Sub pct3_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct3.MouseUp
        If dop5 = True And dop6 = True Then
            dop6 = False
            mn2 += 2
            ReDim Preserve mp2(mn2)

        End If
    End Sub

    Private Sub pct3_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct3.MouseClick
        If Not dop5 = True Then

        End If
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        g3.FillRectangle(Brushes.White, 0, 0, 500, 500)
        OSI()
        g3.DrawEllipse(Pens.Black, XtoI(-7), YtoJ(-5), XtoI(-6), XtoI(-6))
        g3.FillEllipse(Brushes.Red, XtoI(-1) - 3, YtoJ(2) - 3, 6, 6)
        g3.DrawString("M", drawFont, drawBrush, XtoI(-1) - 22, YtoJ(2) - 22)
        mn2 = 2
        ReDim mp2(2)

        pct3.Image = myBitmap3
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If Trim(TextBox1.Text) = "3" And Trim(TextBox2.Text) = "-3" Then

            mes.Show()
            mes.Label1.Text = "Ви виконали усі завдання на цьому рівні, а тако ж усі рівні у грі Симетрія!"
        Else

            mes.Show()
            mes.Label1.Text = "Неправильне рівняння кола!"
        End If
    End Sub

    Private Sub igraS_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class