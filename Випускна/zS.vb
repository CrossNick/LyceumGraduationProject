Public Class zS
    Dim pa, pb, pc, pd As Point
    Dim ps, pd1, pd2, px1, py1, px, py As Point
    Dim type2, k2 As Integer
    Dim pa2, pb2, pc2, pe2, pn2, pm2, px2, pb12 As Point
    Dim bp1, bp2 As Boolean


    Dim type, k As Integer
    Dim g, g2 As Graphics
    Dim kk, b, k1, b1 As Single
    Dim myBitmap, myBitmap2 As Bitmap
    Dim drawFont As New Font("TimesNewRoman", 16)
    Dim drawBrush As New SolidBrush(Color.Black)

    Private Sub zS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myBitmap = New Bitmap(pct1.Width, pct1.Height)
        g = Graphics.FromImage(myBitmap)
        myBitmap2 = New Bitmap(pct2.Width, pct2.Height)
        g2 = Graphics.FromImage(myBitmap2)
        type = 1
        type2 = 1
        k = 1
        kk = 0
        b = 0
        k1 = 0
        b1 = 0
        k = 1
        pa.X = 30
        pa.Y = 300
        pc.X = 370
        pc.Y = 300
        pb.X = 370
        pb.Y = 40
        bp1 = False
        bp2 = False
        pm2.Y = 250
        pm2.X = 20
        pn2.Y = 250
        pn2.X = 380
        pa2.X = 130
        pa2.Y = 150
        pb2.X = 270
        pb2.Y = 200
        pb12.X = 270
        pb12.Y = 300
        pc2.X = 65
        pc2.Y = 250
        pe2.X = 97
        pe2.Y = 200
        px2.Y = 250
        px2.X = 183

        'g2.DrawLine(Pens.Black, px2, pb2)
        'g2.DrawLine(Pens.Black, pm2, pn2)
        'g2.DrawLine(Pens.Black, pb2, pb12)
        'g2.DrawLine(Pens.Black, pa2, pb12)
        'g2.DrawLine(Pens.Black, pc2, pb12)
        'g2.DrawLine(Pens.Black, pe2, pb12)
        'g2.DrawLine(Pens.Black, pa2, pc2)
        'g2.FillEllipse(Brushes.Black, pa2.X - 1, pa2.Y - 1, 2, 2)
        'g2.FillEllipse(Brushes.Black, pb2.X - 1, pb2.Y - 1, 2, 2)

        pct2.Image = myBitmap2


        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If type = 1 Then
            ps.X = pa.X + (pb.X - pa.X) * (k / 100)
            ps.Y = pa.Y - (pa.Y - pb.Y) * (k / 100)
            g.DrawLine(Pens.Black, pa.X, pa.Y, ps.X, ps.Y)
            g.DrawLine(Pens.Black, pa.X, pa.Y, ps.X, pa.Y)
            k += 1
            pct1.Image = myBitmap
            If k > 100 Then
                type = 2
                k = 1
                Label5.Visible = True
                g.DrawString("A", drawFont, drawBrush, pa.X - 20, pa.Y - 10)
                g.DrawString("B", drawFont, drawBrush, pb.X, pb.Y - 10)
                g.DrawString("C", drawFont, drawBrush, pc.X, pc.Y - 10)
                lst11.Items.Add("1. Будуємо кут АВС.")
                Timer1.Enabled = False
            End If
        ElseIf type = 2 Then
            ps.X = pd.X - (pd.X - pd1.X) * (k / 100)
            ps.Y = pd.Y - (pd.Y - pd1.Y) * (k / 100)
            g.DrawLine(Pens.Black, pd, ps)
            ps.X = pd.X
            ps.Y = pd.Y + (pd2.Y - pd.Y) * (k / 100)
            g.DrawLine(Pens.Black, pd, ps)
            k += 1
            pct1.Image = myBitmap
            If k > 100 Then
                k = 1
                type = 3
                g.DrawString("D1", drawFont, drawBrush, pd1.X, pd1.Y - 10)
                g.DrawString("D2", drawFont, drawBrush, pd2.X, pd2.Y - 10)
                lst11.Items.Add("2. Побудуємо точки D1 і D2, симетричні точці D відносно")
                lst11.Items.Add("прямих АВ і АС – сторін даного трикутника ВАС.")
                lst1.Items.Add("Побудуємо точки D1 і D2, симетричні точці D відносно")
                lst1.Items.Add("прямих АВ і АС – сторін даного трикутника ВАС.")
                Timer1.Enabled = False
            End If
        ElseIf type = 3 Then
            ps.X = pd1.X + (pd2.X - pd1.X) * (k / 100)
            ps.Y = pd1.Y + (pd2.Y - pd1.Y) * (k / 100)
            g.DrawLine(Pens.Black, pd1.X, pd1.Y, ps.X, ps.Y)
            k += 1
            pct1.Image = myBitmap
            If k > 100 Then
                lst1.Items.Add("Пряма D1D2 перетне сторони АВ і АС у точках X і Y.")
                k = 1
                lst11.Items.Add("3. Будуємо пряму D1D2")
                Timer1.Interval = 3000
                type = 4

            End If
        ElseIf type = 4 Then
            Timer1.Interval = 10
            ps.X = pd.X - (pd.X - px.X) * (k / 100)
            ps.Y = pd.Y - (pd.Y - px.Y) * (k / 100)
            g.DrawLine(Pens.Black, pd, ps)
            ps.X = pd.X - (pd.X - py.X) * (k / 100)
            ps.Y = pd.Y + (py.Y - pd.Y) * (k / 100)
            g.DrawLine(Pens.Black, pd, ps)
            k += 1
            pct1.Image = myBitmap
            If k > 100 Then
                lst1.Items.Add("Трикутник DXY – шуканий.")
                lst1.Items.Add("  Доведення:")
                lst11.Items.Add("4. Будуємо трикутник DXY")
                k = 1
                type = 5
                g.DrawString("X", drawFont, drawBrush, px.X - 20, px.Y - 20)
                g.DrawString("Y", drawFont, drawBrush, py.X - 20, py.Y - 20)
                pct1.Image = myBitmap
                Timer1.Interval = 3000
            End If
        ElseIf type = 5 Then
            Timer1.Interval = 10
            If pd.Y >= px1.Y Then
                ps.X = pd.X - (pd.X - px1.X) * (k / 100)
                ps.Y = pd.Y - (pd.Y - px1.Y) * (k / 100)
                g.DrawLine(Pens.Blue, pd, ps)
            ElseIf pd.Y < px1.Y Then
                ps.X = pd.X - (pd.X - px1.X) * (k / 100)
                ps.Y = pd.Y - (pd.Y - px1.Y) * (k / 100)
                g.DrawLine(Pens.Blue, pd, ps)
            End If
            ps.X = px1.X + (py1.X - px1.X) * (k / 100)
            ps.Y = px1.Y + (py1.Y - px1.Y) * (k / 100)
            g.DrawLine(Pens.Blue, px1, ps)
            ps.X = py1.X + (pd.X - py1.X) * (k / 100)
            ps.Y = py1.Y - (py1.Y - pd.Y) * (k / 100)
            g.DrawLine(Pens.Blue, py1, ps)
            k += 1
            pct1.Image = myBitmap
            If k > 100 Then
                Timer1.Interval = 3000
                k = 1
                type = 6
                g.DrawString("X1", drawFont, drawBrush, px1.X - 20, px1.Y - 20)
                g.DrawString("Y1", drawFont, drawBrush, py1.X - 20, py1.Y)
                pct1.Image = myBitmap
                lst1.Items.Add("  Припустимо, що не трикутник DXY має найменший")
                lst1.Items.Add("периметр, а трикутник DX1Y1.")
                lst11.Items.Add("5. Будуємо трикутник DX1Y1.")
            End If
        ElseIf type = 6 Then
            type = 7
            lst1.Items.Add(" За методом спрямлення, спрямимо сторони DX і DY")
            lst1.Items.Add("Периметром трикутника DXY буде довжина")
            lst1.Items.Add("прямої D1D2.")
        ElseIf type = 7 Then
            Timer1.Interval = 10
            ps.X = pd1.X - (pd1.X - px1.X) * (k / 100)
            ps.Y = pd1.Y + (px1.Y - pd1.Y) * (k / 100)
            g.DrawLine(Pens.Blue, pd1, ps)
            ps.X = pd2.X - (pd2.X - py1.X) * (k / 100)
            ps.Y = pd2.Y - (pd2.Y - py1.Y) * (k / 100)
            g.DrawLine(Pens.Blue, pd2, ps)
            pct1.Image = myBitmap
            k += 1
            If k > 100 Then
                Timer1.Interval = 3000
                type = 8
                lst1.Items.Add(" Оскільки DX1 = X1D1, а DY1 =  Y1D2, то периметром")
                lst1.Items.Add("трикутника DX1Y1 буде довжина ламаної D1X1Y1D2, що")
                lst1.Items.Add("буде довша за довжину відрізка D1D2.")
                lst11.Items.Add(" 6. З'єднуємо точки D1 та D2 з точками X1 та Y1 відповідно")

            End If
        ElseIf type = 8 Then
            g.DrawLine(Pens.Red, pd, px)
            g.DrawLine(Pens.Red, px, py)
            g.DrawLine(Pens.Red, py, pd)
            pct1.Image = myBitmap
            lst1.Items.Add(" Отже, P(DXY) < P(DX1Y1).  ")
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub pct1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct1.MouseClick
        If type = 2 Then
            Dim k, bb As Integer
            k = (pa.Y - pb.Y) / (pa.X - pb.X)
            bb = pa.Y - k * pa.X

            If e.X > pa.X And e.X < pb.X And e.Y > k * e.X + bb And e.Y < pa.Y Then
                pd.X = e.X
                pd.Y = e.Y
                kk = (pb.Y - pa.Y) / (pb.X - pa.X)
                b = pb.Y - kk * pb.X
                k1 = (-1) / kk
                b1 = pd.Y - k1 * pd.X
                px.X = (b1 - b) / (kk - k1)
                px.Y = k1 * px.X + b1
                'тут рх вспомогательная точка на перечечении прямой АБ и ДД1
                pd1.X = px.X - (pd.X - px.X)
                pd1.Y = 2 * px.Y - pd.Y
                pd2.Y = (pa.Y - pd.Y) * 2 + pd.Y
                pd2.X = pd.X

                kk = (pb.Y - pa.Y) / (pb.X - pa.X)
                b = pb.Y - kk * pb.X
                k1 = (pd1.Y - pd2.Y) / (pd1.X - pd2.X)
                b1 = pd1.Y - k1 * pd1.X
                px.X = (b1 - b) / (kk - k1)
                px.Y = kk * px.X + b
                px1.X = 80
                px1.Y = px1.X * kk + b

                kk = (pc.Y - pa.Y) / (pc.X - pa.X)
                b = pc.Y - kk * pc.X
                k1 = (pd1.Y - pd2.Y) / (pd1.X - pd2.X)
                b1 = pd1.Y - k1 * pd1.X
                py.X = (b1 - b) / (kk - k1)
                py.Y = kk * py.X + b

                py1.Y = pa.Y
                py1.X = 100

                g.DrawString("D", drawFont, drawBrush, pd.X, pd.Y - 10)
                pct1.Image = myBitmap
                Timer1.Enabled = True

                Label5.Visible = False
                Button1.Enabled = True

            Else
                mes.Show()
                mes.Label1.Text = "Оберіть точку всередені кута"
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        lst1.Items.Clear()
        lst11.Items.Clear()
        g.FillRectangle(Brushes.White, 0, 0, 400, 400)
        type = 1
        kk = 0
        b = 0
        k1 = 0
        b1 = 0
        k = 1
        pa.X = 30
        pa.Y = 300
        pc.X = 370
        pc.Y = 300
        pb.X = 370
        pb.Y = 40
        pct1.Image = myBitmap
        Button1.Enabled = False
        Timer1.Interval = 10
        Timer1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
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


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If type2 = 1 Then
            ps.X = pm2.X + (pn2.X - pm2.X) * (k2 / 100)
            ps.Y = pm2.Y
            g2.DrawLine(Pens.Black, pm2, ps)
            k2 += 1
            pct2.Image = myBitmap2
            If k2 > 100 Then
                type2 = 2
                k2 = 1
                lst22.Items.Add("1. Будуємо пряму MN")
                g2.DrawString("M", drawFont, drawBrush, pm2.X, pm2.Y)
                g2.DrawString("N", drawFont, drawBrush, pn2.X, pn2.Y)
                pct2.Image = myBitmap2
                Timer2.Interval = 3000
            End If
        ElseIf type2 = 2 Then
            g2.DrawString("A", drawFont, drawBrush, pa2.X, pa2.Y - 20)
            g2.DrawString("B", drawFont, drawBrush, pb2.X, pb2.Y - 20)
            g2.FillEllipse(Brushes.Black, pa2.X - 1, pa2.Y - 1, 2, 2)
            g2.FillEllipse(Brushes.Black, pb2.X - 1, pb2.Y - 1, 2, 2)
            pct2.Image = myBitmap2
            type2 = 3
            lst22.Items.Add("2. Будуємо точки А та В по одну сторону від прямої MN")
        ElseIf type2 = 3 Then
            Timer2.Interval = 10
            ps.X = pb2.X
            ps.Y = pb2.Y + (pb12.Y - pb2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pb2, ps)
            pct2.Image = myBitmap2
            k2 += 1
            If k2 > 100 Then
                type2 = 4
                k2 = 1
                g2.DrawString("B1", drawFont, drawBrush, pb12)
                pct2.Image = myBitmap2
                lst22.Items.Add("3. Будуємо точку В1, симетричну точці В")
                lst2.Items.Add(" Побудуємо точку В1, симетричну точці В відносно")
                lst2.Items.Add("прямої MN.")
                Timer2.Interval = 3000
            End If
        ElseIf type2 = 4 Then
            Timer2.Interval = 10
            ps.X = pb12.X - (pb12.X - pa2.X) * (k2 / 100)
            ps.Y = pb12.Y - (pb12.Y - pa2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pb12, ps)
            pct2.Image = myBitmap2
            k2 += 1
            If k2 > 100 Then
                type2 = 5
                k2 = 1
                g2.DrawLine(Pens.Black, pc2.X - 3, pc2.Y - 5, pc2.X + 3, pc2.Y + 5)
                g2.DrawString("C", drawFont, drawBrush, pc2.X - 15, pc2.Y)
                pct2.Image = myBitmap2
                lst22.Items.Add("4. З'еднуемо точки А та В1, та робимо засічку у точці С")
                lst2.Items.Add(" З’єднаємо точки А і В1 і зробимо засічку з центра")
                lst2.Items.Add("В1 радіусом АВ1")
                Timer2.Interval = 3000
            End If
        ElseIf type2 = 5 Then
            Timer2.Interval = 10
            ps.X = pb12.X - (pb12.X - pc2.X) * (k2 / 100)
            ps.Y = pb12.Y - (pb12.Y - pc2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pb12, ps)
            ps.X = pa2.X - (pa2.X - pc2.X) * (k2 / 100)
            ps.Y = pa2.Y + (pc2.Y - pa2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pa2, ps)
            ps.X = pb12.X - (pb12.X - pa2.X) * (k2 / 100)
            ps.Y = pb12.Y - (pb12.Y - pa2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pb12, ps)
            pct2.Image = myBitmap2
            k2 += 1
            If k2 > 100 Then
                type2 = 6
                k2 = 1
                g.DrawLine(Pens.White, pc2.X - 3, pc2.Y - 5, pc2.X + 3, pc2.Y + 5)
                g.DrawLine(Pens.Black, pm2, pn2)
                lst22.Items.Add("5. Будуемо трикутник АСВ1")
                lst2.Items.Add(" Одержимо рівнобедрений трикутник АВ1С. ")
                Timer2.Interval = 3000
                pct2.Image = myBitmap2
            End If
        ElseIf type2 = 6 Then
            Timer2.Interval = 10
            ps.X = pb12.X - (pb12.X - pe2.X) * (k2 / 100)
            ps.Y = pb12.Y - (pb12.Y - pe2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pb12, ps)
            k2 += 1
            pct2.Image = myBitmap2
            If k2 > 100 Then
                g2.FillEllipse(Brushes.Red, px2.X - 3, px2.Y - 3, 6, 6)
                g2.DrawString("E", drawFont, drawBrush, pe2.X - 20, pe2.Y - 20)
                g2.DrawString("X", drawFont, drawBrush, px2.X - 20, px2.Y)
                type2 = 7
                k2 = 1
                lst22.Items.Add("6. Будуємо серединний перпендикуляр В1Е до сторони АС")
                lst2.Items.Add("Проведемо серединний перпендикуляр до відрізка АС,")
                lst2.Items.Add("який пройде через точку В1 і перетне пряму MN у")
                lst2.Items.Add("точці Х. ")
                Timer2.Interval = 3000
                pct2.Image = myBitmap2
            End If
        ElseIf type2 = 7 Then
            Timer2.Interval = 10
            ps.X = pb2.X - (pb2.X - px2.X) * (k2 / 100)
            ps.Y = pb2.Y + (px2.Y - pb2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pb2, ps)
            ps.X = pa2.X + (px2.X - pa2.X) * (k2 / 100)
            ps.Y = pa2.Y + (px2.Y - pa2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pa2, ps)
            k2 += 1
            pct2.Image = myBitmap2
            If k2 > 100 Then
                type2 = 8
                k2 = 1
                lst2.Items.Add(" Дійсно, кут ЕХС = В1ХN = BXN;   AXE = EXC")
                Timer2.Interval = 3000
                pct2.Image = myBitmap2
            End If
        ElseIf type2 = 8 Then
            lst2.Items.Add(" отже, AXM = 2BXN. ")
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Timer2.Enabled = True
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Timer2.Enabled = True
        Timer2.Interval = 10
        lst2.Items.Clear()
        lst22.Items.Clear()

        k2 = 1
        type2 = 1
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

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class