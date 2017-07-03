Public Class zPP
    Dim ps, ps4, ps3, p1, p2, ps1, ps2, pn, pd, pm, pb, pa, po1, po2 As Point
    Dim pa2, pb2, pn2, pm2, pa21, pn21, pm21 As Point
    Dim type, k, type2, k2 As Integer
    Dim g, g2 As Graphics
    Dim myBitmap, myBitmap2 As Bitmap
    Dim drawFont As New Font("TimesNewRoman", 16)
    Dim drawBrush As New SolidBrush(Color.Black)
    Dim bp1, bp2 As Boolean
   
    Private Sub zPP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myBitmap = New Bitmap(pct1.Width, pct1.Height)
        g = Graphics.FromImage(myBitmap)
        myBitmap2 = New Bitmap(pct2.Width, pct2.Height)
        g2 = Graphics.FromImage(myBitmap2)
        type = 1
        k = 1
        type2 = 1
        bp1 = False
        bp2 = False
        k2 = 1
        p1.X = 20
        p1.Y = 100
        p2.X = 180
        p2.Y = 100
        ps1.X = 20
        ps1.Y = 300
        ps2.X = 380
        ps2.Y = 300
        pm.X = 200
        pm.Y = 140
        pn.X = 200
        pn.Y = 260
        po1.X = 120
        po1.Y = 200
        po2.X = 280
        po2.Y = 200
        pb.X = 220
        pb.Y = 200
        pa.X = 380
        pa.Y = 200
        pd.X = 360
        pd.Y = 140
        pct1.Image = myBitmap

        'g2.DrawLine(Pens.Black, 0, 170, 400, 170)
        'g2.DrawLine(Pens.Black, 0, 230, 400, 230)
        pb2.X = 370
        pb2.Y = 350
        pa2.X = 30
        pa2.Y = 50
        pa21.X = 30
        pa21.Y = 110
        pn2.X = 200
        pn2.Y = 230
        pm2.X = 200
        pm2.Y = 170
        pn21.X = 270
        pn21.Y = 230
        pm21.X = 270
        pm21.Y = 170
        g2.FillRectangle(Brushes.LightGreen, 0, 0, 400, 170)
        g2.FillRectangle(Brushes.LightGreen, 0, 230, 400, 200)
        g2.FillRectangle(Brushes.LightBlue, 0, 170, 400, 60)
        'g2.DrawLine(Pens.Black, pm21, pn21)
        'g2.DrawLine(Pens.Black, pm21, pa2)
        'g2.DrawLine(Pens.Black, pn21, pb2)
        'g2.DrawLine(Pens.Black, pm2, pn2)
        'g2.DrawLine(Pens.Black, pa21, pa2)
        'g2.DrawLine(Pens.Black, pb2, pa21)
        pct2.Image = myBitmap2
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        g.DrawEllipse(Pens.Black, 20, 100, 200, 200)
        g.DrawEllipse(Pens.Black, 180, 100, 200, 200)
        g.DrawString("S1", drawFont, drawBrush, ps1)
        g.DrawString("S2", drawFont, drawBrush, ps2.X - 20, ps2.Y)
        pct1.Image = myBitmap
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If type = 1 Then
            lst11.Items.Add("1.Будуємо кола S1 та S2.")
            type = 2
        ElseIf type = 2 Then
            lst11.Items.Add("2. M i N - точки перетину кіл S1 та S2")
            g.DrawString("M", drawFont, drawBrush, pm.X - 10, pm.Y - 30)
            g.DrawString("N", drawFont, drawBrush, pn.X - 10, pn.Y + 20)
            pct1.Image = myBitmap
            type = 3
        ElseIf type = 3 Then
            Timer1.Interval = 10
            ps.X = pn.X
            ps.Y = pm.Y + (pn.Y - pm.Y) * (k / 100)
            g.DrawLine(Pens.Black, pm, ps)
            k += 1
            pct1.Image = myBitmap
            If k > 100 Then
                lst11.Items.Add("3. З'єднуємо точки M i N, отримуючи пряму MN.")
                type = 4
                k = 1
                Timer1.Interval = 3000
            End If
        ElseIf type = 4 Then
            Timer1.Interval = 10
            ps.X = 10 + (390 - 10) * (k / 100)
            ps.Y = p1.Y + 100
            g.DrawLine(Pens.Red, 10, p1.Y + 100, ps.X, ps.Y)
            k += 1
            pct1.Image = myBitmap
            If k > 100 Then
                lst11.Items.Add("4. Будуємо серединний перпендикуляр до прямої MN який")
                lst11.Items.Add("перетинає кола S1 i S2 у точках А і В.")
                g.DrawString("A", drawFont, drawBrush, pa.X, pa.Y - 20)
                g.DrawString("B", drawFont, drawBrush, pb.X, pb.Y - 20)
                pct1.Image = myBitmap
                type = 5
                k = 1
                Timer1.Interval = 3000
            End If
        ElseIf type = 5 Then
            g.DrawString("O1", drawFont, drawBrush, po1)
            g.DrawString("O2", drawFont, drawBrush, po2)
            lst1.Items.Add("Нехай O1 і O2 - центри даних кіл S1 і S2,")
            lst1.Items.Add("точка A лежить на колі S1, B - на колі S2.")
            lst11.Items.Add("5. Будуємо цнтри кіл S1 i S2 - O1 i O2 відповідно")
            pct1.Image = myBitmap
            type = 6
        ElseIf type = 6 Then
            Timer1.Interval = 10
            ps.Y = pm.Y
            ps.X = 10 + (390 - 10) * (k / 100)
            g.DrawLine(Pens.Red, 10, pm.Y, ps.X, ps.Y)
            pct1.Image = myBitmap
            k += 1
            If k > 100 Then
                lst1.Items.Add("Через точку M проведемо пряму, паралельну O1O2.")
                lst11.Items.Add("6. Через точку M проведемо пряму, паралельну O1O2.")
                type = 7
                k = 1
                Timer1.Interval = 3000
            End If
        ElseIf type = 7 Then
            lst1.Items.Add("Нехай D - її точка перетину з колом S1. ")
            g.DrawString("D", drawFont, drawBrush, pd.X, pd.Y - 25)
            pct1.Image = myBitmap
            type = 8
        ElseIf type = 8 Then
            Timer1.Interval = 10
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash

            g.DrawEllipse(Pens.White, p2.X, p2.Y, 200, 200)
            g.DrawEllipse(Pens.White, ps.X, ps.Y, 200, 200)
            ps.X = p2.X - (p2.X - p1.X) * (k / 100)
            ps.Y = p2.Y
            g.DrawEllipse(Pens.Black, ps.X, ps.Y, 200, 200)
            ps4.X = pa.X - (pa.X - pb.X) * (k / 100)
            ps4.Y = pa.Y
            g.DrawEllipse(pen, p2.X, p2.Y, 200, 200)
            ps3.X = pd.X - (pd.X - pm.X) * (k / 100)
            ps3.Y = pd.Y
            g.DrawString("B", drawFont, drawBrush, pb.X, pb.Y - 20)
            g.DrawString("O1", drawFont, drawBrush, po1)
            g.DrawString("O2", drawFont, drawBrush, po2)
            g.DrawLine(Pens.Black, pn, pd)
            g.DrawEllipse(Pens.Black, p1.X, p1.Y, 200, 200)
            g.DrawLine(Pens.Black, pm, pn)
            g.DrawLine(Pens.Red, 10, p1.Y + 100, 390, p1.Y + 100)
            g.DrawLine(Pens.Red, 10, pm.Y, 390, pm.Y)
            g.DrawString("M", drawFont, drawBrush, pm.X - 10, pm.Y - 30)
            g.DrawString("N", drawFont, drawBrush, pn.X - 10, pn.Y + 20)
            k += 1
            pct1.Image = myBitmap
            If k > 100 Then
                Timer1.Interval = 3000
                g.DrawEllipse(Pens.White, ps.X, ps.Y, 200, 200)
                g.DrawString("A", drawFont, Brushes.White, ps4)
                g.DrawString("D", drawFont, Brushes.White, ps3)
                g.DrawString("A", drawFont, drawBrush, pa.X, pa.Y - 20)
                g.DrawString("D", drawFont, drawBrush, pd.X, pd.Y - 25)
                g.DrawLine(Pens.Black, pn, pd)
                g.DrawEllipse(Pens.Black, p1.X, p1.Y, 200, 200)
                g.DrawLine(Pens.Black, pm, pn)
                g.DrawLine(Pens.Red, 10, p1.Y + 100, 390, p1.Y + 100)
                g.DrawLine(Pens.Red, 10, pm.Y, 390, pm.Y)
                g.DrawString("M", drawFont, drawBrush, pm.X - 10, pm.Y - 30)
                g.DrawString("N", drawFont, drawBrush, pn.X - 10, pn.Y + 20)
                g.DrawString("M", drawFont, Brushes.White, pm.X, pm.Y)
                g.DrawString("N", drawFont, Brushes.White, pn.X, pn.Y)
                g.DrawString("B", drawFont, Brushes.White, pb)
                g.DrawString("B", drawFont, drawBrush, pb.X, pb.Y - 20)
                g.DrawString("O1", drawFont, drawBrush, po1)
                g.DrawString("O2", drawFont, drawBrush, po2)
                g.DrawEllipse(pen, p2.X, p2.Y, 200, 200)
                lst1.Items.Add("При паралельному перенесенні на вектор О1О2")
                lst1.Items.Add("коло S1 перейде в коло S2, точка D - в точку M,")
                lst1.Items.Add("точка A - в точку B.")
                type = 9
            End If
        ElseIf type = 9 Then
            lst1.Items.Add("Тому відрізок DM дорівнює і паралельний відрізку AB")
            lst1.Items.Add(" а кут DMN = 90. Тоді, DN - діаметр кола.")
            type = 10
        ElseIf type = 10 Then
            lst1.Items.Add("Отже, 4R^2 = DN^2 = DM^2 + MN^2 = AB^2 + MN^2.")
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        type = 1
        k = 1
        g.FillRectangle(Brushes.White, 0, 0, 400, 400)
        pct1.Image = myBitmap
        Timer1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Перенесення.Show()
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

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Timer2.Enabled = True
        g2.FillRectangle(Brushes.White, 0, 0, 400, 400)
        k2 = 1
        type2 = 1
        lst2.Items.Clear()
        lst22.Items.Clear()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Timer2.Enabled = True
        Timer2.Interval = 10

    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If type2 = 1 Then
            ps.X = 0 + 400 * (k2 / 100)
            ps.Y = 170
            g2.DrawLine(Pens.Black, 0, 170, ps.X, ps.Y)
            ps.X = 0 + 400 * (k2 / 100)
            ps.Y = 230
            g2.DrawLine(Pens.Black, 0, 230, ps.X, ps.Y)
            pct2.Image = myBitmap2
            k2 += 1
            If k2 > 100 Then
                k2 = 1
                lst22.Items.Add("1. Будуємо прямі, якими позначаємо береги річки.")
                Timer2.Interval = 3000
                type2 = 2

            End If
        ElseIf type2 = 2 Then
            g2.FillEllipse(Brushes.Black, pa2.X - 3, pa2.Y - 3, 6, 6)
            g2.FillEllipse(Brushes.Black, pb2.X - 3, pb2.Y - 3, 6, 6)
            g2.DrawString("A", drawFont, drawBrush, pa2.X, pa2.Y - 20)
            g2.DrawString("B", drawFont, drawBrush, pb2.X, pb2.Y)
            pct2.Image = myBitmap2
            lst22.Items.Add("2. А і В - дані населені пункти.")
            type2 = 3
        ElseIf type2 = 3 Then
            Timer2.Interval = 10
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            ps.X = pm21.X
            ps.Y = pm21.Y + (pn21.Y - pm21.Y) * (k2 / 100)
            g2.DrawLine(pen, pm21, ps)
            k2 += 1
            pct2.Image = myBitmap2
            If k2 > 100 Then
                k2 = 1
                type2 = 4
                Timer2.Interval = 3000
                g2.DrawImage(Image.FromFile("мост2.png"), pm21.X - 19, pm21.Y)
                g2.DrawString("M1", drawFont, drawBrush, pm21.X, pm21.Y - 22)
                g2.DrawString("N1", drawFont, drawBrush, pn21.X, pn21.Y)

                pct2.Image = myBitmap2
                lst2.Items.Add(" Припустимо, що деяке положення мосту M1N1 знайдено. ")

            End If
        ElseIf type2 = 4 Then
            Timer2.Interval = 10
            Dim pen As New Pen(Brushes.Black)
            pen.EndCap = Drawing2D.LineCap.ArrowAnchor
            ps.X = pa2.X
            ps.Y = pa2.Y + (pa21.Y - pa2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Black, pa2, ps)
            k2 += 1
            pct2.Image = myBitmap2
            If k2 > 100 Then
                k2 = 1
                type2 = 5
                Timer2.Interval = 3000
                g2.DrawString("A1", drawFont, drawBrush, pa21.X, pa21.Y)
                pct2.Image = myBitmap2
                lst2.Items.Add(" При паралельному перенесенні на вектор M1N1 точка A")
                lst2.Items.Add("перейде в деяку точку A1, а точка M1 - в точку N1.")
            End If
        ElseIf type2 = 5 Then
            Timer2.Interval = 10
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            ps.X = pa2.X + (pm21.X - pa2.X) * (k2 / 100)
            ps.Y = pa2.Y + (pm21.Y - pa2.Y) * (k2 / 100)
            g2.DrawLine(pen, pa2, ps)
            ps.X = pn21.X + (pb2.X - pn21.X) * (k2 / 100)
            ps.Y = pn21.Y + (pb2.Y - pn21.Y) * (k2 / 100)
            g2.DrawLine(pen, pn21, ps)
            ps.X = pa21.X + (pn21.X - pa21.X) * (k2 / 100)
            ps.Y = pa21.Y + (pn21.Y - pa21.Y) * (k2 / 100)
            g2.DrawLine(pen, pa21, ps)
            ps.X = pa21.X + (pb2.X - pa21.X) * (k2 / 100)
            ps.Y = pa21.Y + (pb2.Y - pa21.Y) * (k2 / 100)
            g2.DrawLine(Pens.Red, pa21, ps)
            pct2.Image = myBitmap2
            k2 += 1
            If k2 > 100 Then
                k2 = 1
                type2 = 6
                Timer2.Interval = 3000
                lst22.Items.Add("3. Будуємо необхідні для розв'язку відрізки АМ, NB, A1N, A1B.")
                lst2.Items.Add(" Тоді:")
                lst2.Items.Add("AM + MN + NB = AA1 + A1N + NB  ≥ AA1 + A1B")
                lst2.Items.Add("(нерівність трикутника)")
            End If
        ElseIf type2 = 6 Then
            lst2.Items.Add("причому рівність досягається, якщо точки A1,")
            lst2.Items.Add("N і B лежать на одній прямій, тобто BN | | AM.")
            lst2.Items.Add(" Звідси випливає наступний спосіб побудови:")
            type2 = 7
        ElseIf type2 = 7 Then
            lst2.Items.Add("Відкладемо від точки A відрізок AA1,")
            lst2.Items.Add("за величиною рівний ширині річки і перпендикулярний")
            lst2.Items.Add("до її напрямку. ")
            type2 = 8
        ElseIf type2 = 8 Then
            Timer2.Interval = 10
            ps.X = pa21.X + (pb2.X - pa21.X) * (k2 / 100)
            ps.Y = pa21.Y + (pb2.Y - pa21.Y) * (k2 / 100)
            g2.DrawLine(Pens.Red, pa21, ps)
            pct2.Image = myBitmap2
            k2 += 1
            If k2 > 100 Then
                k2 = 1
                type2 = 9
                Timer2.Interval = 3000
                lst2.Items.Add("З'єднаємо точку A1 з точкою B.")
            End If
        ElseIf type2 = 9 Then
            g2.DrawString("N", drawFont, drawBrush, pn2.X, pn2.Y)
            type2 = 10
            Timer2.Interval = 3000
            lst2.Items.Add("Точка N, отримана при перетині A1B з більш близьким")
            lst2.Items.Add("до B берегом річки, визначить положення мосту.")
        ElseIf type2 = 10 Then
            Timer2.Interval = 10
            ps.X = pn2.X
            ps.Y = pn2.Y - (pn2.Y - pm2.Y) * (k2 / 100)
            g2.DrawLine(Pens.Red, pn2, ps)
            pct2.Image = myBitmap2
            k2 += 1
            If k2 > 100 Then
                k2 = 1
                g2.DrawString("M", drawFont, drawBrush, pm2.X, pm2.Y - 22)
                g2.DrawImage(Image.FromFile("мост.png"), pm2.X - 19, pm2.Y)
                g2.DrawLine(Pens.Red, pa21, pb2)
                g2.DrawLine(Pens.Black, pa21, pn21)
                lst2.Items.Add("MN - шуканий мост.")
                pct2.Image = myBitmap2
                Timer2.Enabled = False
            End If
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

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Перенесення.Show()
    End Sub

    Private Sub zPP_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class