Public Class zP
    Dim ps, ps1, ps2, pa, pb, pc, pd, pe, pf, pn, pm, px As Point
    Dim pa2, pb2, pc2, pd2, pd12, pe2, pm2, pm12, pp2, pp12 As Point
    Dim type, type2, k2, k As Integer
    Dim g, g2 As Graphics
    Dim myBitmap, myBitmap2 As Bitmap
    Dim drawFont As New Font("TimesNewRoman", 16)
    Dim drawBrush As New SolidBrush(Color.Black)
    Dim bp1, bp2 As Boolean
    Private Sub zP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myBitmap = New Bitmap(pct1.Width, pct1.Height)
        myBitmap2 = New Bitmap(pct2.Width, pct2.Height)
        g = Graphics.FromImage(myBitmap)
        g2 = Graphics.FromImage(myBitmap2)
        bp1 = False
        bp2 = False
        k = 1
        type = 1
        k2 = 1
        type2 = 1
        pa.X = 130
        pa.Y = 80
        pb.X = 280
        pb.Y = 80
        pe.X = 130
        pe.Y = 320
        pd.X = 280
        pd.Y = 320
        pc.X = 360
        pc.Y = 200
        pf.X = 50
        pf.Y = 200
        px.X = 205
        px.Y = 200
        pn.X = 205
        pn.Y = 320
        pm.X = 320
        pm.Y = 260
        'g.DrawLine(Pens.Black, pa, pf)
        'g.DrawLine(Pens.Black, pe, pf)
        'g.DrawLine(Pens.Black, pd, pc)
        'g.DrawLine(Pens.Black, pb, pc)
        'g.DrawLine(Pens.Black, pa, pb)
        'g.DrawLine(Pens.Black, pe, pd)


        pa2.X = 50
        pa2.Y = 280
        pc2.X = 350
        pc2.Y = 280
        pb2.X = 200
        pb2.Y = 20
        pm2.X = 150
        pm2.Y = 106
        pp2.X = 250
        pp2.Y = 106
        pp12.X = 150
        pp12.Y = 280
        pm12.X = 100
        pm12.Y = 366
        pd2.Y = 77
        pd2.X = 200
        pd12.Y = 309
        pd12.X = 100

        pe2.X = 150
        pe2.Y = 193

        'g2.DrawLine(Pens.Black, pe2, pc2)
        'g2.DrawLine(Pens.Black, pd2, pd12)
        'g2.DrawLine(Pens.Black, pa2, pp2)
        'g2.DrawLine(Pens.Black, pd2, pc2)
        'g2.DrawLine(Pens.Black, pd12, pc2)
        'g2.DrawLine(Pens.Black, pm12, pp12)
        'g2.DrawLine(Pens.Black, pm12, pa2)
        'g2.DrawLine(Pens.Black, pm2, pp2)
        'g2.DrawLine(Pens.Black, pa2, pb2)
        'g2.DrawLine(Pens.Black, pb2, pc2)
        'g2.DrawLine(Pens.Black, pc2, pa2)

        pct1.Image = myBitmap
        pct2.Image = myBitmap2
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If type = 1 Then
            ps.X = pa.X + (pb.X - pa.X) * (k / 100)
            ps.Y = pa.Y
            g.DrawLine(Pens.Black, pa, ps)
            ps.X = pb.X + (pc.X - pb.X) * (k / 100)
            ps.Y = pb.Y + (pc.Y - pb.Y) * (k / 100)
            g.DrawLine(Pens.Black, pb, ps)
            ps.X = pc.X - (pc.X - pd.X) * (k / 100)
            ps.Y = pc.Y + (pd.Y - pc.Y) * (k / 100)
            g.DrawLine(Pens.Black, pc, ps)
            ps.X = pd.X - (pd.X - pe.X) * (k / 100)
            ps.Y = pd.Y
            g.DrawLine(Pens.Black, pd, ps)
            ps.X = pe.X - (pe.X - pf.X) * (k / 100)
            ps.Y = pe.Y - (pe.Y - pf.Y) * (k / 100)
            g.DrawLine(Pens.Black, pe, ps)
            ps.X = pf.X + (pa.X - pf.X) * (k / 100)
            ps.Y = pf.Y - (pf.Y - pa.Y) * (k / 100)
            g.DrawLine(Pens.Black, pf, ps)
            k += 1
            pct1.Image = myBitmap
            If k > 100 Then
                Timer1.Interval = 3000
                type = 2
                k = 1
                g.DrawString("A", drawFont, drawBrush, pa.X - 20, pa.Y - 20)
                g.DrawString("B", drawFont, drawBrush, pb.X, pb.Y - 20)
                g.DrawString("C", drawFont, drawBrush, pc.X, pc.Y - 10)
                g.DrawString("D", drawFont, drawBrush, pd.X, pd.Y)
                g.DrawString("E", drawFont, drawBrush, pe.X - 20, pe.Y)
                g.DrawString("F", drawFont, drawBrush, pf.X - 20, pf.Y - 10)
                lst11.Items.Add("1. Будуємо правильний шестикутник ABCDEF")
                pct1.Image = myBitmap

            End If
        ElseIf type = 2 Then
            Timer1.Interval = 10
            ps.X = pa.X + (pm.X - pa.X) * (k / 100)
            ps.Y = pa.Y + (pm.Y - pa.Y) * (k / 100)
            g.DrawLine(Pens.Red, pa, ps)
            ps.X = pb.X - (pb.X - pn.X) * (k / 100)
            ps.Y = pb.Y + (pn.Y - pb.Y) * (k / 100)
            g.DrawLine(Pens.Red, pb, ps)
            k += 1
            pct1.Image = myBitmap
            If k > 100 Then
                Timer1.Interval = 3000
                type = 3
                k = 1
                g.DrawString("M", drawFont, drawBrush, pm.X, pm.Y)
                g.DrawString("N", drawFont, drawBrush, pn.X - 10, pn.Y)
                lst11.Items.Add("2. Будуємо прямі AM i BN, що проведені до середин сторін CD i DE")
                pct1.Image = myBitmap
            End If
        ElseIf type = 3 Then
            lst11.Items.Add("3. Точка Х - центр шестикутника ABCDEF")
            g.FillEllipse(Brushes.Black, px.X - 1, px.Y - 1, 2, 2)
            g.DrawString("X", drawFont, drawBrush, px.X - 20, px.Y - 20)
            type = 4
            pct1.Image = myBitmap
        ElseIf type = 4 Then
            lst1.Items.Add(" При повороті на 60 градусів навколо центру X")
            lst1.Items.Add("правильного шестикутника ABCDEF:")
            type = 5
        ElseIf type = 5 Then
            Dim pen As New Pen(Brushes.Red)
            pen.EndCap = Drawing2D.LineCap.ArrowAnchor
            g.DrawArc(pen, 30, 60, 340, 260, 240, 60)
            lst1.Items.Add(" 1.Вершина А перейде в вершину В.")
            type = 6
            pct1.Image = myBitmap
        ElseIf type = 6 Then
            Dim pen As New Pen(Brushes.Red)
            Dim pen2 As New Pen(Brushes.White)
            pen.EndCap = Drawing2D.LineCap.ArrowAnchor
            pen2.EndCap = Drawing2D.LineCap.ArrowAnchor
            g.DrawArc(pen2, 30, 60, 340, 260, 240, 60)
            g.DrawArc(pen, 30, 60, 340, 280, 360, 60)
            lst1.Items.Add(" 2.Вершина C перейде в вершину D.")
            type = 7
            pct1.Image = myBitmap
        ElseIf type = 7 Then
            Dim pen As New Pen(Brushes.Red)
            Dim pen2 As New Pen(Brushes.White)
            pen.EndCap = Drawing2D.LineCap.ArrowAnchor
            pen2.EndCap = Drawing2D.LineCap.ArrowAnchor
            g.DrawArc(pen2, 30, 60, 340, 280, 360, 60)
            g.DrawArc(pen, 30, 60, 340, 280, 60, 60)
            lst1.Items.Add(" 3.Вершина D перейде в вершину E.")
            type = 8
            pct1.Image = myBitmap
        ElseIf type = 8 Then
            Dim pen As New Pen(Brushes.Red)
            Dim pen2 As New Pen(Brushes.White)
            pen.EndCap = Drawing2D.LineCap.ArrowAnchor
            pen2.EndCap = Drawing2D.LineCap.ArrowAnchor
            g.DrawArc(pen2, 30, 60, 340, 280, 60, 60)
            g.DrawArc(pen, 30, 60, 340, 280, 30, 60)
            lst1.Items.Add(" Тому середина M відрізка CD переходить у")
            lst1.Items.Add("середину N відрізка ED,")
            type = 9
            pct1.Image = myBitmap
        ElseIf type = 9 Then
            lst1.Items.Add("а пряма AM - в пряму BN.")
            type = 10
        ElseIf type = 10 Then
            lst1.Items.Add("Отже, шуканий кут дорівнює 60 градусів.")
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        type = 1
        k = 1
        g.FillRectangle(Brushes.White, 0, 0, 400, 400)
        Timer1.Enabled = False
        lst1.Items.Clear()
        lst11.Items.Clear()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If type2 = 1 Then
            ps.X = pa2.X + (pb2.X - pa2.X) * (k2 / 100)
            ps.Y = pa2.Y - (pa2.Y - pb2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pa2, ps)
            ps.X = pb2.X + (pc2.X - pb2.X) * (k2 / 100)
            ps.Y = pb2.Y + (pc2.Y - pb2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pb2, ps)
            ps.X = pc2.X - (pc2.X - pa2.X) * (k2 / 100)
            ps.Y = pa2.Y
            g2.DrawLine(Pens.Black, pc2, ps)
            k2 += 1
            pct2.Image = myBitmap2
            If k2 > 100 Then
                k2 = 1
                type2 = 2
                Timer2.Interval = 3000
                g2.DrawString("A", drawFont, drawBrush, pa2.X - 20, pa2.Y - 10)
                g2.DrawString("B", drawFont, drawBrush, pb2.X - 10, pb2.Y - 20)
                g2.DrawString("C", drawFont, drawBrush, pc2.X, pc2.Y - 10)
                lst22.Items.Add("1. Будуємо трикутник АВС")
                pct2.Image = myBitmap2
            End If
        ElseIf type2 = 2 Then
            Timer2.Interval = 10
            ps.X = pm2.X + (pp2.X - pm2.X) * (k2 / 100)
            ps.Y = pm2.Y
            g2.DrawLine(Pens.Black, pm2, ps)
            k2 += 1
            pct2.Image = myBitmap2
            If k2 > 100 Then
                k2 = 1
                type2 = 3
                Timer2.Interval = 3000
                g2.DrawString("M", drawFont, drawBrush, pm2.X - 20, pm2.Y - 20)
                g2.DrawString("P", drawFont, drawBrush, pp2.X, pp2.Y - 20)
                g2.DrawString("D", drawFont, drawBrush, pd2.X, pd2.Y - 10)
                g2.FillEllipse(Brushes.Black, pd2.X - 1, pd2.Y - 1, 2, 2)

                lst22.Items.Add("2. Пряма MN перетинає сторони АВ і ВС в точках M i N.")
                lst22.Items.Add("Точка D - центр правильного трикутника PMB.")
                pct2.Image = myBitmap2
            End If
        ElseIf type2 = 3 Then
            Timer2.Interval = 10
            ps.X = pa2.X + (pp2.X - pa2.X) * (k2 / 100)
            ps.Y = pa2.Y - (pa2.Y - pp2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pa2, ps)
            k2 += 1
            pct2.Image = myBitmap2
            If k2 > 100 Then
                k2 = 1
                type2 = 4
                Timer2.Interval = 3000
                g2.DrawString("E", drawFont, drawBrush, pe2.X - 20, pe2.Y - 20)
                lst22.Items.Add("3. Будуємо відрізок АР. Точка Е - середина цього відрізка.")
                pct2.Image = myBitmap2
            End If
        ElseIf type2 = 4 Then
            Timer2.Interval = 10
            ps.X = pe2.X + (pd2.X - pe2.X) * (k2 / 100)
            ps.Y = pe2.Y - (pe2.Y - pd2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pe2, ps)
            ps.X = pc2.X - (pc2.X - pe2.X) * (k2 / 100)
            ps.Y = pc2.Y - (pc2.Y - pe2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pc2, ps)
            ps.X = pd2.X + (pc2.X - pd2.X) * (k2 / 100)
            ps.Y = pd2.Y + (pc2.Y - pd2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pd2, ps)
            k2 += 1
            pct2.Image = myBitmap2
            If k2 > 100 Then
                k2 = 1
                type2 = 5
                Timer2.Interval = 3000
                lst22.Items.Add("4.Будуємо трикутник DEC, кути якого потрібно знайти.")
                pct2.Image = myBitmap2
            End If
        ElseIf type2 = 5 Then
            lst2.Items.Add(" Повернемо трикутник BMP на 60 градусів")
            lst2.Items.Add("відносно точки C так, щоб :")
            type2 = 6
        ElseIf type2 = 6 Then
            Timer2.Interval = 10
            ps.X = pa2.X + (pm12.X - pa2.X) * (k2 / 100)
            ps.Y = pa2.Y + (pm12.Y - pa2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pa2, ps)
            ps.X = pp12.X - (pp12.X - pm12.X) * (k2 / 100)
            ps.Y = pp12.Y + (pm12.Y - pp12.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pp12, ps)
            k2 += 1
            pct2.Image = myBitmap2
            If k2 > 100 Then
                k2 = 1
                type2 = 7
                Timer2.Interval = 3000
                lst2.Items.Add(" трикутник MBP з центром у точці D перейде")
                lst2.Items.Add(" в трикутник M1AP1 з центром у точці D1.")
                g2.FillEllipse(Brushes.Black, pd12.X - 1, pd12.Y - 1, 2, 2)
                g2.DrawString("D1", drawFont, drawBrush, pd12.X, pd12.Y - 20)
                g2.DrawString("M1", drawFont, drawBrush, pm12.X - 10, pm12.Y)
                pct2.Image = myBitmap2
            End If
        ElseIf type2 = 7 Then
            Timer2.Interval = 10
            ps.X = pd2.X + (pp2.X - pd2.X) * (k2 / 100)
            ps.Y = pd2.Y + (pp2.Y - pd2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Red, pd2, ps)
            ps.X = pp2.X - (pp2.X - pd12.X) * (k2 / 100)
            ps.Y = pp2.Y + (pd12.Y - pp2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Red, pp2, ps)
            ps.X = pd12.X - (pd12.X - pa2.X) * (k2 / 100)
            ps.Y = pd12.Y - (pd12.Y - pa2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Red, pd12, ps)
            ps.X = pa2.X + (pd2.X - pa2.X) * (k2 / 100)
            ps.Y = pa2.Y - (pa2.Y - pd2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Red, pa2, ps)
            pct2.Image = myBitmap2
            k2 += 1
            If k2 > 100 Then
                k2 = 1
                type2 = 8
                Timer2.Interval = 3000
                lst2.Items.Add(" Чотирикутник DPD1A - паралелограм.")
                pct2.Image = myBitmap2
            End If
        ElseIf type2 = 8 Then
            Timer2.Interval = 10
            ps.X = pd2.X - (pd2.X - pd12.X) * (k2 / 100)
            ps.Y = pd2.Y + (pd12.Y - pd2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pd2, ps)
            pct2.Image = myBitmap2
            k2 += 1
            If k2 > 100 Then
                k2 = 1
                type2 = 9
                Timer2.Interval = 3000
                lst2.Items.Add(" DD1 - його діагональ. Тому D1D проходить")
                lst2.Items.Add("через точку E і D1E = DE.")
                pct2.Image = myBitmap2
            End If
        ElseIf type2 = 9 Then
            Timer2.Interval = 10
            ps.X = pc2.X - (pc2.X - pd12.X) * (k2 / 100)
            ps.Y = pc2.Y + (pd12.Y - pc2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pc2, ps)
            pct2.Image = myBitmap2
            k2 += 1
            If k2 > 100 Then
                k2 = 1
                type2 = 10
                Timer2.Interval = 3000
                lst22.Items.Add(" 5. Трикутник DCD1 рівнобедрений")
                pct2.Image = myBitmap2
            End If
        ElseIf type2 = 10 Then
            lst2.Items.Add("Оскільки CE - медіана рівнобедреного")
            lst2.Items.Add("трикутника DCD1 (CD = CD1), то ")
            type2 = 11
        ElseIf type2 = 11 Then
            lst2.Items.Add("кут CED = 90, а тому кут DCD1 = 60,")
            lst2.Items.Add("кут DCE = 30.")
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        type2 = 1
        g2.FillRectangle(Brushes.White, 0, 0, 400, 400)
        pct2.Image = myBitmap2
        k2 = 1
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If bp1 = False Then
            Timer1.Enabled = False
            bp1 = True
        ElseIf bp1 = True Then
            Timer1.Enabled = True
            bp1 = False
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If bp2 = False Then
            Timer1.Enabled = False
            bp2 = True
        ElseIf bp2 = True Then
            Timer1.Enabled = True
            bp2 = False
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Поворот.Show()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Поворот.Show()
    End Sub

    Private Sub zP_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class