Public Class IgraPP
    Dim i1, i2, j1, j2 As Integer
    Dim x1, x2, y1, y2 As Single
    Dim dop1, dop2, dop3, dop4, pom, pom1, pom2, pom3, pom4, pom5, pom6, dop5, dop6 As Boolean
    Dim dopp1, dopp2, dopp3, dopp4, dopp, pl1, dopp5, dopp6, pl2 As Point
    Dim g, g2, g3 As Graphics
    Dim p21, p22, p23 As Point
    Dim myBitmap, myBitmap2, myBitmap3 As Bitmap

    Dim mp(2), mp2(2), mp3(2) As Point
    Dim mn, mn2, mn3 As Integer

    Dim type2, k As Integer
    Dim drawFont As New Font("TimesNewRoman", 16)
    Dim drawBrush As New SolidBrush(Color.Black)

    Private Sub IgraPP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        x1 = -10
        y1 = 10
        x2 = 10
        y2 = -10
        Label2.BringToFront()

        mn = 2
        mn2 = 2
        mn3 = 2


        i1 = 0
        j1 = 0
        pom1 = False
        pom2 = False
        pom3 = False
        pom4 = False
        pom5 = False
        pom6 = False
        dop5 = False
        dop6 = False
        dopp6.X = 0
        dopp6.Y = 0
        i2 = pct3.Width
        j2 = pct3.Height
        myBitmap = New Bitmap(pct1.Width, pct1.Height)
        g = Graphics.FromImage(myBitmap)
        myBitmap2 = New Bitmap(pct1.Width, pct1.Height)
        g2 = Graphics.FromImage(myBitmap2)
        myBitmap3 = New Bitmap(pct1.Width, pct1.Height)
        g3 = Graphics.FromImage(myBitmap3)
        pom = False
        OSI()
        g.FillEllipse(Brushes.Red, XtoI(-6) - 3, YtoJ(4) - 3, 6, 6)
        g.DrawString("M", drawFont, drawBrush, XtoI(-6), YtoJ(4) - 20)
        pct1.Image = myBitmap
        type2 = 1
        Label1.BringToFront()

        OSI2()
        g2.DrawLine(Pens.Black, XtoI(3), YtoJ(4), XtoI(5), YtoJ(6))
        g2.DrawLine(Pens.Black, XtoI(5), YtoJ(6), XtoI(8), YtoJ(4))
        g2.DrawLine(Pens.Black, XtoI(8), YtoJ(4), XtoI(3), YtoJ(4))
        g2.FillEllipse(Brushes.Red, XtoI(3) - 3, YtoJ(4) - 3, 6, 6)
        g2.FillEllipse(Brushes.Red, XtoI(5) - 3, YtoJ(6) - 3, 6, 6)
        g2.FillEllipse(Brushes.Red, XtoI(8) - 3, YtoJ(4) - 3, 6, 6)
        g2.DrawString("A", drawFont, drawBrush, XtoI(3) - 20, YtoJ(4))
        g2.DrawString("B", drawFont, drawBrush, XtoI(5) - 10, YtoJ(6) - 25)
        g2.DrawString("C", drawFont, drawBrush, XtoI(8), YtoJ(4))
        dop3 = False
        dop4 = False
        p21.X = 0
        p21.Y = 0
        p22.X = 0
        p22.Y = 0
        p23.X = 0
        p23.Y = 0
        pct2.Image = myBitmap2

        OSI3()
        g3.DrawEllipse(Pens.Black, XtoI(5), YtoJ(8), XtoI(-6), XtoI(-6))
        g3.FillEllipse(Brushes.Red, XtoI(7) - 3, YtoJ(6) - 3, 6, 6)
        g3.DrawString("M", drawFont, drawBrush, XtoI(7), YtoJ(6))
        pct3.Image = myBitmap3

    End Sub
    Function OSI()
        Dim i As Integer
        For i = x1 To x2
            If i <> 0 Then g.DrawString(Str(i), Me.Font, Brushes.Black, XtoI(i) - 8, YtoJ(0) + 10)
            g.DrawLine(Pens.LightGray, XtoI(i), 0, XtoI(i), 500)
            g.DrawLine(Pens.Black, XtoI(i), YtoJ(0.1), XtoI(i), YtoJ(-0.1))

        Next
        For i = y2 To y1
            g.DrawLine(Pens.LightGray, 0, YtoJ(i), 500, YtoJ(i))
            g.DrawLine(Pens.Black, XtoI(-0.1), YtoJ(i), XtoI(0.1), YtoJ(i))
            If i <> 0 Then g.DrawString(Str(i), Me.Font, Brushes.Black, XtoI(0) - 20, YtoJ(i) - 5)

        Next
        g.DrawLine(Pens.Black, XtoI(x2), 250, XtoI(x2) - 20, 240)
        g.DrawLine(Pens.Black, XtoI(x2), 250, XtoI(x2) - 20, 260)
        g.DrawLine(Pens.Black, 250, YtoJ(y1), 240, YtoJ(y1) + 20)
        g.DrawLine(Pens.Black, 250, YtoJ(y1), 260, YtoJ(y1) + 20)
        g.DrawLine(Pens.Black, XtoI(x1), YtoJ(0), XtoI(x2), YtoJ(0))
        g.DrawLine(Pens.Black, XtoI(0), YtoJ(y1), XtoI(0), YtoJ(y2))
        pct1.Image = myBitmap
    End Function
    Function OSI2()
        Dim i As Integer
        For i = x1 To x2
            If i <> 0 Then g2.DrawString(Str(i), Me.Font, Brushes.Black, XtoI(i) - 8, YtoJ(0) + 10)
            g2.DrawLine(Pens.LightGray, XtoI(i), 0, XtoI(i), 500)
            g2.DrawLine(Pens.Black, XtoI(i), YtoJ(0.1), XtoI(i), YtoJ(-0.1))

        Next
        For i = y2 To y1
            g2.DrawLine(Pens.LightGray, 0, YtoJ(i), 500, YtoJ(i))
            g2.DrawLine(Pens.Black, XtoI(-0.1), YtoJ(i), XtoI(0.1), YtoJ(i))
            If i <> 0 Then g2.DrawString(Str(i), Me.Font, Brushes.Black, XtoI(0) - 20, YtoJ(i) - 5)

        Next
        g2.DrawLine(Pens.Black, XtoI(x2), 250, XtoI(x2) - 20, 240)
        g2.DrawLine(Pens.Black, XtoI(x2), 250, XtoI(x2) - 20, 260)
        g2.DrawLine(Pens.Black, 250, YtoJ(y1), 240, YtoJ(y1) + 20)
        g2.DrawLine(Pens.Black, 250, YtoJ(y1), 260, YtoJ(y1) + 20)
        g2.DrawLine(Pens.Black, XtoI(x1), YtoJ(0), XtoI(x2), YtoJ(0))
        g2.DrawLine(Pens.Black, XtoI(0), YtoJ(y1), XtoI(0), YtoJ(y2))
        pct2.Image = myBitmap2
    End Function
    Function OSI3()
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
    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.Hide()
        Перенесення.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Перенесення.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Перенесення.Show()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Me.Hide()
        igraS.Show()
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Me.Hide()
        igraP.Show()
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Me.Hide()
        igraG.Show()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        Me.Hide()
        igraS.Show()
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        Me.Hide()
        igraP.Show()
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        Me.Hide()
        igraG.Show()
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        Me.Hide()
        igraS.Show()
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        Me.Hide()
        igraP.Show()
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        Me.Hide()
        igraG.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
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

    Private Sub pct1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct1.MouseMove
        If dop1 = True And dop2 = True Then
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            Dim pen2 As New Pen(Brushes.White)
            pen2.DashStyle = Drawing2D.DashStyle.Dash
            g.DrawLine(pen2, mp(mn - 2), mp(mn - 1))
            mp(mn - 1).X = e.X
            mp(mn - 1).Y = e.Y
            OSI()
            For i = 2 To mn Step 2
                g.DrawLine(pen, mp(i - 2), mp(i - 1))
            Next
            g.DrawLine(pen, mp(mn - 2), mp(mn - 1))

            g.FillEllipse(Brushes.Red, XtoI(-6) - 3, YtoJ(4) - 3, 6, 6)
            g.DrawString("M", drawFont, drawBrush, XtoI(-6), YtoJ(4) - 20)
            pct1.Image = myBitmap
        Else
            'For i = x1 To x2
            '    For j = y2 To y1
            '        If e.X > XtoI(i) - 3 And e.X < XtoI(i) + 3 And e.Y > YtoJ(j) - 3 And e.Y < YtoJ(j) + 3 Then
            '            dopp.X = XtoI(i)
            '            dopp.Y = YtoJ(j)
            '            g.FillEllipse(Brushes.Blue, XtoI(i) - 3, YtoJ(j) - 3, 6, 6)
            '            pct1.Image = myBitmap
            '            pom = True
            '            Exit For
            '        Else
            '            g.FillEllipse(Brushes.White, dopp.X - 3, dopp.Y - 3, 6, 6)
            '            OSI()
            '            pom = False
            '            g.FillEllipse(Brushes.Red, XtoI(-6) - 3, YtoJ(4) - 3, 6, 6)
            '            g.DrawString("M", drawFont, drawBrush, XtoI(-6), YtoJ(4) - 20)
            '            pct1.Image = myBitmap
            '        End If
            '    Next
            '    If pom = True Then
            '        Exit For
            '    End If
            'Next
        End If
    End Sub

    Private Sub pct1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct1.MouseUp
        If dop1 = True And dop2 = True Then
            dop2 = False
            mn += 2
            ReDim Preserve mp(mn)

        End If
    End Sub

    Private Sub pct1_Click(sender As System.Object, e As System.EventArgs) Handles pct1.Click
       
    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        g.FillRectangle(Brushes.White, 0, 0, 500, 500)
        OSI()
        mn = 2
        ReDim mp(2)

        g.FillEllipse(Brushes.Red, XtoI(-6) - 3, YtoJ(4) - 3, 6, 6)
        g.DrawString("M", drawFont, drawBrush, XtoI(-6), YtoJ(4) - 20)
        pct1.Image = myBitmap
    End Sub

    Private Sub pct1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct1.MouseClick
        If Not dop1 = True Then
            For i = x1 To x2
                For j = y2 To y1
                    If e.X > XtoI(i) - 3 And e.X < XtoI(i) + 3 And e.Y > YtoJ(j) - 3 And e.Y < YtoJ(j) + 3 Then
                        pl1.X = XtoI(i)
                        pl1.Y = YtoJ(j)
                        g.FillEllipse(Brushes.Red, XtoI(i) - 3, YtoJ(j) - 3, 6, 6)
                        pct1.Image = myBitmap
                        pom1 = True
                        Exit For
                    Else
                        g.FillEllipse(Brushes.White, pl1.X - 3, pl1.Y - 3, 6, 6)
                        OSI()
                        pom1 = False
                        g.FillEllipse(Brushes.Red, XtoI(-6) - 3, YtoJ(4) - 3, 6, 6)
                        g.DrawString("M", drawFont, drawBrush, XtoI(-6), YtoJ(4) - 20)
                        pct1.Image = myBitmap
                    End If
                Next
                If pom1 = True Then
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If pl1.X = XtoI(1) And pl1.Y = YtoJ(-2) Then
            mes.Show()
            mes.Label1.Text = "Ви виконали усі завдання на цьому рівні! Другий рівень розблоковано!"

            Panel2.Visible = True
            Label1.Visible = False
        Else
            mes.Show()
            mes.Label1.Text = "Не правильне положення точки"

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            dop3 = True
        ElseIf CheckBox2.Checked = False Then
            dop3 = False
        End If
    End Sub

    Private Sub pct2_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct2.MouseDown
        If dop3 = True Then
            dop4 = True
            mp2(mn2 - 2).X = e.X
            mp2(mn2 - 2).Y = e.Y
        End If

    End Sub

    Private Sub pct2_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct2.MouseClick
        If Not dop3 = True Then
            If type2 = 1 Then
                g2.DrawLine(Pens.White, p21, p22)
                g2.DrawLine(Pens.White, p22, p23)
                g2.DrawLine(Pens.White, p23, p21)
                g2.FillEllipse(Brushes.White, p21.X - 3, p21.Y - 3, 6, 6)
                g2.FillEllipse(Brushes.White, p22.X - 3, p22.Y - 3, 6, 6)
                g2.FillEllipse(Brushes.White, p23.X - 3, p23.Y - 3, 6, 6)
                g2.DrawString("A", drawFont, drawBrush, XtoI(3) - 20, YtoJ(4))
                g2.DrawString("B", drawFont, drawBrush, XtoI(5) - 10, YtoJ(6) - 25)
                g2.DrawString("C", drawFont, drawBrush, XtoI(8), YtoJ(4))
                For i = x1 To x2
                    For j = y2 To y1
                        If e.X > XtoI(i) - 3 And e.X < XtoI(i) + 3 And e.Y > YtoJ(j) - 3 And e.Y < YtoJ(j) + 3 Then
                            p21.X = XtoI(i)
                            p21.Y = YtoJ(j)
                            g2.FillEllipse(Brushes.Red, XtoI(i) - 3, YtoJ(j) - 3, 6, 6)
                            pct2.Image = myBitmap2
                            pom2 = True
                            Exit For
                        Else
                            g2.FillEllipse(Brushes.White, p21.X - 3, p21.Y - 3, 6, 6)
                            OSI2()
                            pom2 = False
                            g2.DrawLine(Pens.Black, XtoI(3), YtoJ(4), XtoI(5), YtoJ(6))
                            g2.DrawLine(Pens.Black, XtoI(5), YtoJ(6), XtoI(8), YtoJ(4))
                            g2.DrawLine(Pens.Black, XtoI(8), YtoJ(4), XtoI(3), YtoJ(4))
                            g2.FillEllipse(Brushes.Red, XtoI(3) - 3, YtoJ(4) - 3, 6, 6)
                            g2.FillEllipse(Brushes.Red, XtoI(5) - 3, YtoJ(6) - 3, 6, 6)
                            g2.FillEllipse(Brushes.Red, XtoI(8) - 3, YtoJ(4) - 3, 6, 6)
                            g2.DrawString("A", drawFont, drawBrush, XtoI(3) - 20, YtoJ(4))
                            g2.DrawString("B", drawFont, drawBrush, XtoI(5) - 10, YtoJ(6) - 25)
                            g2.DrawString("C", drawFont, drawBrush, XtoI(8), YtoJ(4))
                            pct2.Image = myBitmap2
                        End If
                    Next
                    If pom2 = True Then
                        Exit For
                    End If
                Next
                type2 = 2
                pct2.Image = myBitmap2
            ElseIf type2 = 2 Then
                For i = x1 To x2
                    For j = y2 To y1
                        If e.X > XtoI(i) - 3 And e.X < XtoI(i) + 3 And e.Y > YtoJ(j) - 3 And e.Y < YtoJ(j) + 3 Then
                            p22.X = XtoI(i)
                            p22.Y = YtoJ(j)
                            g2.FillEllipse(Brushes.Red, XtoI(i) - 3, YtoJ(j) - 3, 6, 6)
                            pct2.Image = myBitmap2
                            pom2 = True
                            Exit For
                        Else
                            g2.FillEllipse(Brushes.White, p22.X - 3, p22.Y - 3, 6, 6)
                            OSI2()
                            pom2 = False
                            g2.DrawLine(Pens.Black, XtoI(3), YtoJ(4), XtoI(5), YtoJ(6))
                            g2.DrawLine(Pens.Black, XtoI(5), YtoJ(6), XtoI(8), YtoJ(4))
                            g2.DrawLine(Pens.Black, XtoI(8), YtoJ(4), XtoI(3), YtoJ(4))
                            g2.FillEllipse(Brushes.Red, XtoI(3) - 3, YtoJ(4) - 3, 6, 6)
                            g2.FillEllipse(Brushes.Red, XtoI(5) - 3, YtoJ(6) - 3, 6, 6)
                            g2.FillEllipse(Brushes.Red, XtoI(8) - 3, YtoJ(4) - 3, 6, 6)
                            g2.DrawString("A", drawFont, drawBrush, XtoI(3) - 20, YtoJ(4))
                            g2.DrawString("B", drawFont, drawBrush, XtoI(5) - 10, YtoJ(6) - 25)
                            g2.DrawString("C", drawFont, drawBrush, XtoI(8), YtoJ(4))
                            pct2.Image = myBitmap2
                        End If
                    Next
                    If pom2 = True Then
                        Exit For
                    End If
                Next
                type2 = 3
                g2.DrawLine(Pens.Black, p21, p22)
                pct2.Image = myBitmap2
            ElseIf type2 = 3 Then
                For i = x1 To x2
                    For j = y2 To y1
                        If e.X > XtoI(i) - 3 And e.X < XtoI(i) + 3 And e.Y > YtoJ(j) - 3 And e.Y < YtoJ(j) + 3 Then
                            p23.X = XtoI(i)
                            p23.Y = YtoJ(j)
                            g2.FillEllipse(Brushes.Red, XtoI(i) - 3, YtoJ(j) - 3, 6, 6)
                            pct2.Image = myBitmap2
                            pom2 = True
                            Exit For
                        Else
                            g2.FillEllipse(Brushes.White, p23.X - 3, p23.Y - 3, 6, 6)
                            OSI2()
                            pom2 = False
                            g2.DrawLine(Pens.Black, XtoI(3), YtoJ(4), XtoI(5), YtoJ(6))
                            g2.DrawLine(Pens.Black, XtoI(5), YtoJ(6), XtoI(8), YtoJ(4))
                            g2.DrawLine(Pens.Black, XtoI(8), YtoJ(4), XtoI(3), YtoJ(4))
                            g2.FillEllipse(Brushes.Red, XtoI(3) - 3, YtoJ(4) - 3, 6, 6)
                            g2.FillEllipse(Brushes.Red, XtoI(5) - 3, YtoJ(6) - 3, 6, 6)
                            g2.FillEllipse(Brushes.Red, XtoI(8) - 3, YtoJ(4) - 3, 6, 6)
                            g2.DrawString("A", drawFont, drawBrush, XtoI(3) - 20, YtoJ(4))
                            g2.DrawString("B", drawFont, drawBrush, XtoI(5) - 10, YtoJ(6) - 25)
                            g2.DrawString("C", drawFont, drawBrush, XtoI(8), YtoJ(4))
                            pct2.Image = myBitmap2
                        End If
                    Next
                    If pom2 = True Then
                        Exit For
                    End If
                Next
                type2 = 1
                g2.DrawLine(Pens.Black, p21, p23)
                g2.DrawLine(Pens.Black, p22, p23)
                g2.DrawLine(Pens.Black, p21, p22)
                pct2.Image = myBitmap2
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
            OSI2()

            For i = 2 To mn2 Step 2
                g2.DrawLine(pen, mp2(i - 2), mp2(i - 1))
            Next

            g2.DrawLine(pen, mp2(mn2 - 2), mp2(mn2 - 1))
            g2.DrawLine(Pens.Black, XtoI(3), YtoJ(4), XtoI(5), YtoJ(6))
            g2.DrawLine(Pens.Black, XtoI(5), YtoJ(6), XtoI(8), YtoJ(4))
            g2.DrawLine(Pens.Black, XtoI(8), YtoJ(4), XtoI(3), YtoJ(4))
            g2.FillEllipse(Brushes.Red, XtoI(3) - 3, YtoJ(4) - 3, 6, 6)
            g2.FillEllipse(Brushes.Red, XtoI(5) - 3, YtoJ(6) - 3, 6, 6)
            g2.FillEllipse(Brushes.Red, XtoI(8) - 3, YtoJ(4) - 3, 6, 6)
            g2.DrawString("A", drawFont, drawBrush, XtoI(3) - 20, YtoJ(4))
            g2.DrawString("B", drawFont, drawBrush, XtoI(5) - 10, YtoJ(6) - 25)
            g2.DrawString("C", drawFont, drawBrush, XtoI(8), YtoJ(4))
            pct2.Image = myBitmap2
        End If
    End Sub

    Private Sub pct2_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct2.MouseUp
        If dop3 = True And dop4 = True Then
            dop4 = False
            mn2 += 2
            ReDim Preserve mp2(mn2)
        End If
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        g2.FillRectangle(Brushes.White, 0, 0, 500, 500)

        OSI2()
        mn2 = 2
        ReDim mp2(2)
        g2.DrawLine(Pens.Black, XtoI(3), YtoJ(4), XtoI(5), YtoJ(6))
        g2.DrawLine(Pens.Black, XtoI(5), YtoJ(6), XtoI(8), YtoJ(4))
        g2.DrawLine(Pens.Black, XtoI(8), YtoJ(4), XtoI(3), YtoJ(4))
        g2.FillEllipse(Brushes.Red, XtoI(3) - 3, YtoJ(4) - 3, 6, 6)
        g2.FillEllipse(Brushes.Red, XtoI(5) - 3, YtoJ(6) - 3, 6, 6)
        g2.FillEllipse(Brushes.Red, XtoI(8) - 3, YtoJ(4) - 3, 6, 6)
        g2.DrawString("A", drawFont, drawBrush, XtoI(3) - 20, YtoJ(4))
        g2.DrawString("B", drawFont, drawBrush, XtoI(5) - 10, YtoJ(6) - 25)
        g2.DrawString("C", drawFont, drawBrush, XtoI(8), YtoJ(4))
        pct2.Image = myBitmap2
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If (p21.X > XtoI(-3) - 2 And p21.X < XtoI(-3) + 2 And p21.Y > YtoJ(3) - 2 And p21.Y < YtoJ(3) + 2 And p22.X > XtoI(-6) - 2 And p22.X < XtoI(-6) + 2 And p22.Y > YtoJ(1) - 2 And p22.Y < YtoJ(1) + 2 And p23.X > XtoI(-8) - 2 And p23.X < XtoI(-8) + 2 And p23.Y > YtoJ(3) - 2 And p23.Y > YtoJ(3) - 2) _
            Or (p22.X > XtoI(-3) - 2 And p22.X < XtoI(-3) + 2 And p22.Y > YtoJ(3) - 2 And p22.Y < YtoJ(3) + 2 And p23.X > XtoI(-6) - 2 And p23.X < XtoI(-6) + 2 And p23.Y > YtoJ(1) - 2 And p23.Y < YtoJ(1) + 2 And p21.X > XtoI(-8) - 2 And p21.X < XtoI(-8) + 2 And p21.Y > YtoJ(3) - 2 And p21.Y > YtoJ(3) - 2) _
            Or (p23.X > XtoI(-3) - 2 And p23.X < XtoI(-3) + 2 And p23.Y > YtoJ(3) - 2 And p23.Y < YtoJ(3) + 2 And p21.X > XtoI(-6) - 2 And p21.X < XtoI(-6) + 2 And p21.Y > YtoJ(1) - 2 And p21.Y < YtoJ(1) + 2 And p22.X > XtoI(-8) - 2 And p22.X < XtoI(-8) + 2 And p22.Y > YtoJ(3) - 2 And p22.Y > YtoJ(3) - 2) Then
            mes.Show()
            mes.Label1.Text = "Ви успішно виконали усі завдання на другому рівні! Третій рівень розблоковано!"

            Label2.Visible = False
            Panel3.Visible = True
        Else
            mes.Show()
            mes.Label1.Text = "Не правильне положення точок!"

        End If
    End Sub

    Private Sub pct3_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct3.MouseClick
        If Not dop5 = True Then
            For i = x1 To x2
                For j = y2 To y1
                    If e.X > XtoI(i) - 3 And e.X < XtoI(i) + 3 And e.Y > YtoJ(j) - 3 And e.Y < YtoJ(j) + 3 Then
                        pl2.X = XtoI(i)
                        pl2.Y = YtoJ(j)
                        g3.FillEllipse(Brushes.Red, XtoI(i) - 3, YtoJ(j) - 3, 6, 6)
                        g3.DrawEllipse(Pens.Black, pl2.X - XtoI(-8), pl2.Y - XtoI(-8), XtoI(-6), XtoI(-6))
                        pct3.Image = myBitmap3
                        pom5 = True
                        Exit For
                    Else
                        g3.FillEllipse(Brushes.White, pl2.X - 3, pl2.Y - 3, 6, 6)
                        g3.DrawEllipse(Pens.White, pl2.X - XtoI(-8), pl2.Y - XtoI(-8), XtoI(-6), XtoI(-6))
                        OSI3()
                        pom5 = False
                        g3.DrawEllipse(Pens.Black, XtoI(5), YtoJ(8), XtoI(-6), XtoI(-6))
                        g3.FillEllipse(Brushes.Red, XtoI(7) - 3, YtoJ(6) - 3, 6, 6)
                        g3.DrawString("M", drawFont, drawBrush, XtoI(7), YtoJ(6))
                        pct3.Image = myBitmap3
                    End If
                Next
                If pom5 = True Then
                    Exit For
                End If
            Next
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
            Dim pen As New Pen(Brushes.Black)
            pen.DashStyle = Drawing2D.DashStyle.Dash
            Dim pen2 As New Pen(Brushes.White)
            pen2.DashStyle = Drawing2D.DashStyle.Dash
            g3.DrawLine(pen2, mp3(mn3 - 2), mp3(mn3 - 1))
            mp3(mn3 - 1).X = e.X
            mp3(mn3 - 1).Y = e.Y
            g3.DrawLine(pen, mp3(mn3 - 2), mp3(mn3 - 1))
            OSI3()
            For i = 2 To mn3 Step 2
                g3.DrawLine(pen, mp3(i - 2), mp3(i - 1))
            Next
            g3.DrawEllipse(Pens.Black, XtoI(5), YtoJ(8), XtoI(-6), XtoI(-6))
            g3.FillEllipse(Brushes.Red, XtoI(7) - 3, YtoJ(6) - 3, 6, 6)
            g3.DrawString("M", drawFont, drawBrush, XtoI(7), YtoJ(6))
            pct3.Image = myBitmap3

        End If
    End Sub

    Private Sub pct3_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pct3.MouseUp
        If dop5 = True And dop6 = True Then
            dop6 = False
            mn3 += 2
            ReDim Preserve mp3(mn3)

        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If pl2.X = XtoI(-3) And pl2.Y = YtoJ(-7) And Trim(TextBox1.Text) = "-10" And Trim(TextBox2.Text) = "-13" Then
            mes.Show()
            mes.Label1.Text = "Ви виконали усі завдання на цьому рівні, а також пройшли усі рівні гри Паралельне Перенесення!"

        Else
            mes.Show()
            mes.Label1.Text = "Не правильне положення точки або неправильно вказано вектор!"

        End If
    End Sub

    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        g3.FillRectangle(Brushes.White, 0, 0, 500, 500)
        OSI3()
        mn3 = 2
        ReDim mp3(2)
        g3.DrawEllipse(Pens.Black, XtoI(5), YtoJ(8), XtoI(-6), XtoI(-6))
        g3.FillEllipse(Brushes.Red, XtoI(7) - 3, YtoJ(6) - 3, 6, 6)
        g3.DrawString("M", drawFont, drawBrush, XtoI(7), YtoJ(6))
        pct3.Image = myBitmap3
    End Sub

    Private Sub IgraPP_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class