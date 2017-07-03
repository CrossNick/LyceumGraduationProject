Public Class zG
    Dim p1, p2, p3, p4 As Point 'Вершины квадрата
    Dim pk, pl, pp, pn As Point
    Dim sp1x, sp1y, sp2x, sp2y, sp3x, sp3y, sp4x, sp4y As Single
    Dim ps1x, ps1y, ps2x, ps2y, ps3x, ps3y, ps4x, ps4y As Single
    Dim p, ps As Point
    Dim type As Integer 'для таймера
    Dim pa2, pb2, pc2, pm2, pn2, pl2, pk2, pm12, pn12, pl12, pk12 As Point
    Dim type2 As Integer
    Dim k, k2 As Integer 'для таймера
    Dim g, g2 As Graphics
    Dim myBitmap, myBitmap2 As Bitmap
    Dim drawFont As New Font("TimesNewRoman", 16)
    Dim drawBrush As New SolidBrush(Color.Black)
    Dim bp1, bp2 As Boolean


    Private Sub zG_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myBitmap = New Bitmap(pct1.Width, pct1.Height)
        g = Graphics.FromImage(myBitmap)
        myBitmap2 = New Bitmap(pct2.Width, pct2.Height)
        g2 = Graphics.FromImage(myBitmap2)
        bp1 = False
        bp1 = True
        g.DrawString("A", drawFont, drawBrush, 1, 1)
        g.DrawString("B", drawFont, drawBrush, 381, 1)
        g.DrawString("C", drawFont, drawBrush, 379, 379)
        g.DrawString("D", drawFont, drawBrush, 1, 379)
        p1.X = 20
        p1.Y = 20
        p4.X = 20
        p4.Y = 380
        p3.X = 380
        p3.Y = 380
        p2.X = 380
        p2.Y = 20
        pk.X = ((p2.X - p1.X) / 2) + p1.X
        pk.Y = p1.Y
        pn.X = p1.X
        pn.Y = ((p4.Y - p1.Y) / 2) + p1.Y
        pl.X = p2.X
        pl.Y = pn.Y
        pp.X = pk.X
        pp.Y = p3.Y
        type = 1
        k = 1

        pa2.X = 20
        pa2.Y = 300
        pc2.Y = 300
        pc2.X = 380
        pb2.X = 250
        pb2.Y = 120
        pm12.X = 70
        pm12.Y = 260
        pl12.X = 70
        pl12.Y = 300
        pn12.X = 110
        pn12.Y = 260
        pk12.X = 110
        pk12.Y = 300
        pn2.X = 293
        pn2.Y = 180
        pk2.X = 293
        pk2.Y = 300
        pm2.X = 173
        pm2.Y = 180
        pl2.X = 173
        pl2.Y = 300
        type2 = 1
        k2 = 1

        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        g = Graphics.FromImage(myBitmap)
        Dim ps As Point
        If type = 1 Then
            ps.X = p1.X + (p2.X - p1.X) * (k / 100)
            g.DrawLine(Pens.Black, p1.X, p1.Y, ps.X, p2.Y)
            ps.Y = p2.Y + (p3.Y - p2.Y) * (k / 100)
            g.DrawLine(Pens.Black, p2.X, p2.Y, p3.X, ps.Y)
            ps.X = p3.X - (p3.X - p4.X) * (k / 100)
            g.DrawLine(Pens.Black, p3.X, p3.Y, ps.X, p4.Y)
            ps.Y = p4.Y - (p4.Y - p1.Y) * (k / 100)
            g.DrawLine(Pens.Black, p4.X, p4.Y, p1.X, ps.Y)
            k += 1
            pct1.Image = myBitmap
            If k > 100 Then
                k = 1
                type = 2
                lst11.Items.Add("1.Будуємо квадрат ABCD")
                Label5.Visible = True
                Timer1.Enabled = False
            End If
        ElseIf type = 2 Then
            ps.X = p1.X + (p.X - p1.X) * (k / 100)
            ps.Y = p1.Y + (p.Y - p1.Y) * (k / 100)
            g.DrawLine(Pens.Black, p1.X, p1.Y, ps.X, ps.Y)
            ps.X = p2.X - (p2.X - p.X) * (k / 100)
            ps.Y = p2.Y + (p.Y - p2.Y) * (k / 100)
            g.DrawLine(Pens.Black, p2.X, p2.Y, ps.X, ps.Y)
            ps.X = p3.X - (p3.X - p.X) * (k / 100)
            ps.Y = p3.Y - (p3.Y - p.Y) * (k / 100)
            g.DrawLine(Pens.Black, p3.X, p3.Y, ps.X, ps.Y)
            ps.X = p4.X + (p.X - p4.X) * (k / 100)
            ps.Y = p4.Y - (p4.Y - p.Y) * (k / 100)
            g.DrawLine(Pens.Black, p4.X, p4.Y, ps.X, ps.Y)
            k += 1
            pct1.Image = myBitmap
            If k > 100 Then
                k = 1
                type = 3
                Button1.Enabled = True
                g.DrawString("M", drawFont, drawBrush, p.X - 20, p.Y - 20)
                pct1.Image = myBitmap
                lst11.Items.Add("2. Будуємо точку М та з'єднуємо її з вершинами квадрата")
                Timer1.Enabled = False
            End If
        ElseIf type = 3 Then
            Timer1.Interval = 3000
            lst1.Items.Add("1. Нехай K, L, P і N - середини сторін відповідно AB,")
            lst1.Items.Add("BC, CD і AD.")
            g.DrawString("N", drawFont, drawBrush, pn.X - 20, pn.Y - 10)
            g.DrawString("K", drawFont, drawBrush, pk.X - 10, pk.Y - 20)
            g.DrawString("L", drawFont, drawBrush, pl.X, pl.Y - 10)
            g.DrawString("P", drawFont, drawBrush, pp.X - 10, pp.Y)
            pct1.Image = myBitmap
            type = 4
        ElseIf type = 4 Then
            Timer1.Interval = 10
            ps.X = pn.X + (pk.X - pn.X) * (k / 100)
            ps.Y = pn.Y - (pn.Y - pk.Y) * (k / 100)
            g.DrawLine(Pens.Red, pn.X, pn.Y, ps.X, ps.Y)
            ps.X = pk.X + (pl.X - pk.X) * (k / 100)
            ps.Y = pk.Y + (pl.Y - pk.Y) * (k / 100)
            g.DrawLine(Pens.Red, pk.X, pk.Y, ps.X, ps.Y)
            ps.X = pl.X - (pl.X - pp.X) * (k / 100)
            ps.Y = pl.Y + (pp.Y - pl.Y) * (k / 100)
            g.DrawLine(Pens.Red, pl.X, pl.Y, ps.X, ps.Y)
            ps.X = pp.X - (pp.X - pn.X) * (k / 100)
            ps.Y = pp.Y - (pp.Y - pn.Y) * (k / 100)
            g.DrawLine(Pens.Red, pp.X, pp.Y, ps.X, ps.Y)
            k += 1
            pct1.Image = myBitmap
            If k > 100 Then
                k = 1
                type = 5
                lst1.Items.Add("2. Тоді KLPN - квадрат.")
                lst11.Items.Add("3. З'єднуємо точки K, L, P, N отримуючи квадрат KLPN")
                Timer1.Interval = 3000
            End If
        ElseIf type = 5 Then
            Timer1.Interval = 10
            If p.Y >= pn.Y Then
                ps.X = pn.X + (p.X - pn.X) * (k / 100)
                ps.Y = pn.Y + (p.Y - pn.Y) * (k / 100)
                sp1x = (1 / 3) * p.X + (2 / 3) * pn.X
                sp1y = (1 / 3) * p.Y + (2 / 3) * pn.Y
            ElseIf pn.Y > p.Y Then
                ps.X = pn.X + (p.X - pn.X) * (k / 100)
                ps.Y = pn.Y - (pn.Y - p.Y) * (k / 100)
                sp1x = (1 / 3) * p.X + (2 / 3) * pn.X
                sp1y = (1 / 3) * p.Y + (2 / 3) * pn.Y
            End If
            g.DrawLine(Pens.LightGreen, pn.X, pn.Y, ps.X, ps.Y)
            If p.X >= pk.X Then
                ps.X = pk.X + (p.X - pk.X) * (k / 100)
                ps.Y = pk.Y + (p.Y - pk.Y) * (k / 100)
                sp2x = (1 / 3) * p.X + (2 / 3) * pk.X
                sp2y = (1 / 3) * p.Y + (2 / 3) * pk.Y
            ElseIf pk.X > p.X Then
                ps.X = pk.X - (pk.X - p.X) * (k / 100)
                ps.Y = pk.Y + (p.Y - pk.Y) * (k / 100)
                sp2x = (1 / 3) * p.X + (2 / 3) * pk.X
                sp2y = (1 / 3) * p.Y + (2 / 3) * pk.Y
            End If
            g.DrawLine(Pens.LightGreen, pk.X, pk.Y, ps.X, ps.Y)
            If p.Y >= pl.Y Then
                ps.X = pl.X - (pl.X - p.X) * (k / 100)
                ps.Y = pl.Y + (p.Y - pl.Y) * (k / 100)
                sp3x = (1 / 3) * p.X + (2 / 3) * pl.X
                sp3y = (1 / 3) * p.Y + (2 / 3) * pl.Y
            ElseIf pl.Y > p.Y Then
                ps.X = pl.X - (pl.X - p.X) * (k / 100)
                ps.Y = pl.Y - (pl.Y - p.Y) * (k / 100)
                sp3x = (1 / 3) * p.X + (2 / 3) * pl.X
                sp3y = (1 / 3) * p.Y + (2 / 3) * pl.Y
            End If
            g.DrawLine(Pens.LightGreen, pl.X, pl.Y, ps.X, ps.Y)
            If p.X >= pp.X Then
                ps.X = pp.X + (p.X - pp.X) * (k / 100)
                ps.Y = pp.Y - (pp.Y - p.Y) * (k / 100)
                sp4x = (1 / 3) * p.X + (2 / 3) * pp.X
                sp4y = (1 / 3) * p.Y + (2 / 3) * pp.Y
            ElseIf pp.X > p.X Then
                ps.X = pp.X - (pp.X - p.X) * (k / 100)
                ps.Y = pp.Y - (pp.Y - p.Y) * (k / 100)
                sp4x = (1 / 3) * p.X + (2 / 3) * pp.X
                sp4y = (1 / 3) * p.Y + (2 / 3) * pp.Y
            End If
            g.DrawLine(Pens.LightGreen, pp.X, pp.Y, ps.X, ps.Y)
            k += 1
            pct1.Image = myBitmap
            If k > 100 Then
                k = 1
                type = 6
                lst11.Items.Add("4. Будуємо медіани KM, PM, LM, NM трикутників AMB, DMC, BMC, AMD.")
                lst1.Items.Add("3. Оскільки точка перетину медіан ділить кожну ")
                lst1.Items.Add("медіану трикутника щодо 1:2, рахуючи від вершини,")
                lst1.Items.Add("то:")
                Timer1.Interval = 3000
            End If
        ElseIf type = 6 Then
            Timer1.Interval = 10
            g.DrawLine(Pens.White, ps1x, ps1y, ps2x, ps2y)
            g.DrawLine(Pens.White, ps2x, ps2y, ps3x, ps3Y)
            g.DrawLine(Pens.White, ps3x, ps3Y, ps4x, ps4y)
            g.DrawLine(Pens.White, ps4x, ps4y, ps1x, ps1y)
            If sp1y >= pn.Y Then
                ps1x = pn.X + (sp1x - pn.X) * (k / 100)
                ps1y = pn.Y + (sp1y - pn.Y) * (k / 100)
            ElseIf pn.Y > sp1y Then
                ps1x = pn.X + (sp1x - pn.X) * (k / 100)
                ps1y = pn.Y - (pn.Y - sp1y) * (k / 100)
            End If
            If sp2x >= pk.X Then
                ps2x = pk.X + (sp2x - pk.X) * (k / 100)
                ps2y = pk.Y + (sp2y - pk.Y) * (k / 100)
            ElseIf pk.X > sp2x Then
                ps2x = pk.X - (pk.X - sp2x) * (k / 100)
                ps2y = pk.Y + (sp2y - pk.Y) * (k / 100)
            End If
            If sp3y >= pl.Y Then
                ps3x = pl.X - (pl.X - sp3x) * (k / 100)
                ps3y = pl.Y + (sp3y - pl.Y) * (k / 100)
            ElseIf pp.Y > sp3y Then
                ps3x = pl.X - (pl.X - sp3x) * (k / 100)
                ps3y = pl.Y - (pl.Y - sp3y) * (k / 100)
            End If
            If sp4x >= pp.X Then
                ps4x = pp.X + (sp4x - pp.X) * (k / 100)
                ps4y = pp.Y - (pp.Y - sp4y) * (k / 100)
            ElseIf pk.X > sp2x Then
                ps4x = pp.X - (pp.X - sp4x) * (k / 100)
                ps4y = pp.Y - (pp.Y - sp4y) * (k / 100)
            End If
            g.DrawLine(Pens.LightGreen, ps1x, ps1y, ps2x, ps2y)
            g.DrawLine(Pens.LightGreen, ps2x, ps2y, ps3x, ps3y)
            g.DrawLine(Pens.LightGreen, ps3x, ps3y, ps4x, ps4y)
            g.DrawLine(Pens.LightGreen, ps4x, ps4y, ps1x, ps1y)
            k += 1
            g.DrawLine(Pens.Red, pn.X, pn.Y, pk.X, pk.Y)
            g.DrawLine(Pens.Red, pk.X, pk.Y, pl.X, pl.Y)
            g.DrawLine(Pens.Red, pl.X, pl.Y, pp.X, pp.Y)
            g.DrawLine(Pens.Red, pp.X, pp.Y, pn.X, pn.Y)
            g.DrawLine(Pens.Black, p1.X, p1.Y, p.X, p.Y)
            g.DrawLine(Pens.Black, p2.X, p2.Y, p.X, p.Y)
            g.DrawLine(Pens.Black, p3.X, p3.Y, p.X, p.Y)
            g.DrawLine(Pens.Black, p4.X, p4.Y, p.X, p.Y)
            g.DrawLine(Pens.LightGreen, pn.X, pn.Y, p.X, p.Y)
            g.DrawLine(Pens.LightGreen, pk.X, pk.Y, p.X, p.Y)
            g.DrawLine(Pens.LightGreen, pl.X, pl.Y, p.X, p.Y)
            g.DrawLine(Pens.LightGreen, pp.X, pp.Y, p.X, p.Y)
            pct1.Image = myBitmap
            If k > 100 Then
                k = 1
                type = 7
                lst1.Items.Add("при гомотетії з центром M і коефіцієнтом 2/3")
                lst1.Items.Add("чотирикутник KLPN переходить у чотирикутник з ")
                lst1.Items.Add("вершинами в точках перетину медіан трикутників")
                lst1.Items.Add("ABM, BCM, CDM і DAM. ")
                lst11.Items.Add("5.  Будуємо чотирикутник, гомотетичний KLPN відносно точки М з коефіціентом 2/3")
                Timer1.Interval = 3000

            End If
        ElseIf type = 7 Then
            lst1.Items.Add("Отже, останній чотирикутник також є квадратом. ")
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub pct1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct1.MouseClick
        g = Graphics.FromImage(myBitmap)
        If type = 2 Then
            If e.X > p1.X And e.X < p2.X And e.Y > p1.Y And e.Y < p3.Y Then
                p.X = e.X
                p.Y = e.Y
                g.FillEllipse(Brushes.Black, p.X - 1, p.Y - 1, 2, 2)
                Label5.Visible = False
                pct1.Image = myBitmap
                Timer1.Enabled = True
            Else
                mes.Show()
                mes.Label1.Text = "Оберіть точку всередені квадрата"


            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        lst1.Items.Clear()
        lst11.Items.Clear()
        Timer1.Interval = 10
        g.FillRectangle(Brushes.White, 0, 0, 400, 400)
        g.DrawString("A", drawFont, drawBrush, 1, 1)
        g.DrawString("B", drawFont, drawBrush, 381, 1)
        g.DrawString("C", drawFont, drawBrush, 379, 379)
        g.DrawString("D", drawFont, drawBrush, 1, 379)
        p1.X = 20
        p1.Y = 20
        p4.X = 20
        p4.Y = 380
        p3.X = 380
        p3.Y = 380
        p2.X = 380
        p2.Y = 20
        pk.X = ((p2.X - p1.X) / 2) + p1.X
        pk.Y = p1.Y
        pn.X = p1.X
        pn.Y = ((p4.Y - p1.Y) / 2) + p1.Y
        pl.X = p2.X
        pl.Y = pn.Y
        pp.X = pk.X
        pp.Y = p3.Y
        type = 1
        Button1.Enabled = False
        k = 1
        pct1.Image = myBitmap
        Timer1.Enabled = True
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Гомотетия.Show()

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
            ps.Y = pa2.Y
            ps.X = pc2.X - (pc2.X - pa2.X) * (k2 / 100)
            g2.DrawLine(Pens.Black, pc2, ps)
            k2 += 1
            pct2.Image = myBitmap2
            If k2 > 100 Then
                k2 = 1
                type2 = 2
                g2.DrawString("A", drawFont, drawBrush, pa2.X - 20, pa2.Y - 10)
                g2.DrawString("B", drawFont, drawBrush, pb2.X - 10, pb2.Y - 20)
                g2.DrawString("C", drawFont, drawBrush, pc2.X, pc2.Y - 10)
                lst22.Items.Add("1. Будуємо трикутник АВС.")
                pct2.Image = myBitmap2
                Timer2.Interval = 3000
            End If
        ElseIf type2 = 2 Then
            Timer2.Interval = 10
            ps.X = pm12.X + (pn12.X - pm12.X) * (k2 / 100)
            ps.Y = pm12.Y
            g2.DrawLine(Pens.Black, pm12, ps)
            ps.X = pn12.X
            ps.Y = pn12.Y + (pk12.Y - pn12.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pn12, ps)
            ps.X = pk12.X - (pk12.X - pl12.X) * (k2 / 100)
            ps.Y = pk12.Y
            g2.DrawLine(Pens.Black, pk12, ps)
            ps.X = pl12.X
            ps.Y = pl12.Y - (pl12.Y - pm12.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pl12, ps)
            pct2.Image = myBitmap2
            k2 += 1
            If k2 > 100 Then
                Timer2.Interval = 3000
                g2.DrawString("M1", drawFont, drawBrush, pm12.X - 20, pm12.Y - 22)
                g2.DrawString("N1", drawFont, drawBrush, pn12.X, pn12.Y - 20)
                g2.DrawString("K1", drawFont, drawBrush, pk12.X, pk12.Y)
                g2.DrawString("L1", drawFont, drawBrush, pl12.X - 20, pl12.Y)
                lst22.Items.Add("2. Будуємо квадрат M1N1K1L1")
                lst2.Items.Add(" Побудуємо квадрат М1N1К1L1, дві вершини якого")
                lst2.Items.Add("лежать на основі АС, третя — на стороні АВ.")
                type2 = 3
                k2 = 1
                pct2.Image = myBitmap2
            End If
        ElseIf type2 = 3 Then
            Timer2.Interval = 10
            ps.X = pa2.X + (pn2.X - pa2.X) * (k2 / 100)
            ps.Y = pa2.Y - (pa2.Y - pn2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pa2, ps)
            pct2.Image = myBitmap2
            k2 += 1
            If k2 > 100 Then
                Timer2.Interval = 3000
                g2.DrawString("N", drawFont, drawBrush, pn2.X, pn2.Y - 22)
                pct2.Image = myBitmap2
                lst22.Items.Add("3. Будуємо пряму AN, що проходить через вершину N1")
                lst2.Items.Add(" Тепер проведемо пряму AN1 до перетину зі стороною")
                lst2.Items.Add("ВС у точці N. ")
                type2 = 4
                k2 = 1
            End If
        ElseIf type2 = 4 Then
            Timer2.Interval = 10
            g2.DrawLine(Pens.White, ps1x, ps1y, ps2x, ps2y)
            g2.DrawLine(Pens.White, ps2x, ps2y, ps3x, ps3y)
            g2.DrawLine(Pens.White, ps3x, ps3y, ps4x, ps4y)
            g2.DrawLine(Pens.White, ps4x, ps4y, ps1x, ps1y)
            ps1x = pm12.X + (pm2.X - pm12.X) * (k2 / 100)
            ps1y = pm12.Y - (pm12.Y - pm2.Y) * (k2 / 100)
            ps2x = pn12.X + (pn2.X - pn12.X) * (k2 / 100)
            ps2y = pn12.Y - (pn12.Y - pn2.Y) * (k2 / 100)
            ps3x = pk12.X + (pk2.X - pk12.X) * (k2 / 100)
            ps3y = pk12.Y
            ps4y = pk12.Y
            ps4x = pl12.X + (pl2.X - pl12.X) * (k2 / 100)
            g2.DrawLine(Pens.Black, ps1x, ps1y, ps2x, ps2y)
            g2.DrawLine(Pens.Black, ps2x, ps2y, ps3x, ps3y)
            g2.DrawLine(Pens.Black, ps3x, ps3y, ps4x, ps4y)
            g2.DrawLine(Pens.Black, ps4x, ps4y, ps1x, ps1y)
            k2 += 1
            g2.DrawLine(Pens.Black, pa2, pb2)
            g2.DrawLine(Pens.Black, pa2, pc2)
            g2.DrawLine(Pens.Black, pa2, pn2)
            g2.DrawLine(Pens.Black, pm12, pn12)
            g2.DrawLine(Pens.Black, pn12, pk12)
            g2.DrawLine(Pens.Black, pk12, pl12)
            g2.DrawLine(Pens.Black, pl12, pm12)
            g2.DrawString("M1", drawFont, drawBrush, pm12.X - 20, pm12.Y - 22)
            g2.DrawString("N1", drawFont, drawBrush, pn12.X, pn12.Y - 20)
            g2.DrawString("K1", drawFont, drawBrush, pk12.X, pk12.Y)
            g2.DrawString("L1", drawFont, drawBrush, pl12.X - 20, pl12.Y)
            pct2.Image = myBitmap2
            If k2 > 100 Then
                g2.DrawLine(Pens.Red, ps1x, ps1y, ps2x, ps2y)
                g2.DrawLine(Pens.Red, ps2x, ps2y, ps3x, ps3y)
                g2.DrawLine(Pens.Red, ps3x, ps3y, ps4x, ps4y)
                g2.DrawLine(Pens.Red, ps4x, ps4y, ps1x, ps1y)
                pct2.Image = myBitmap2
                lst2.Items.Add(" Квадрат MNKL, гомотетичний квадрату М1N1К1L1")
                lst2.Items.Add("з центром гомотетії А, й буде шуканим.")
                Timer2.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If bp2 = False Then
            Timer2.Enabled = False
            bp2 = True
        ElseIf bp2 = True Then
            Timer2.Enabled = True
            bp2 = False
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Timer2.Enabled = True
        Timer2.Interval = 10
        k2 = 1
        type2 = 1
        lst2.Items.Clear()
        lst22.Items.Clear()

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Гомотетия.Show()
    End Sub

    Private Sub zG_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class