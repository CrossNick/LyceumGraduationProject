Public Class igraP
    Dim g, g2, g3 As Graphics
    Dim ps, pal1, pbl1, pcl1, pdl1, pel1, pfl1, pol1 As Point
    Dim pal2, pbl2, pcl2, phl2, pml2, pol2, pll2 As Point
    Dim pl3a, pl3b, pl3c, pl3d, pl3k, pl3m, pl3n, pl3l, pl3p, pl3h, pl3e, pl3f As Point

    Dim type, k As Integer
    Dim myBitmap, myBitmap2, myBitmap3 As Bitmap
    Dim drawFont As New Font("TimesNewRoman", 16)
    Dim drawBrush As New SolidBrush(Color.Black)
    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.Hide()
        Поворот.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Поворот.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Поворот.Show()
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
        igraG.Show()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Me.Hide()
        igraS.Show()
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Me.Hide()
        IgraPP.Show()
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
        IgraPP.Show()
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        Me.Hide()
        igraG.Show()
    End Sub

    Private Sub igraP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.BringToFront()
        k = 1
        type = 1
        myBitmap = New Bitmap(pct1.Width, pct1.Height)
        g = Graphics.FromImage(myBitmap)
        myBitmap2 = New Bitmap(pct2.Width, pct2.Height)
        g2 = Graphics.FromImage(myBitmap2)
        myBitmap3 = New Bitmap(pct1.Width, pct1.Height)
        g3 = Graphics.FromImage(myBitmap3)
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
        g.DrawLine(Pens.Black, pal1, pbl1)
        g.DrawLine(Pens.Black, pbl1, pcl1)
        g.DrawLine(Pens.Black, pcl1, pdl1)
        g.DrawLine(Pens.Black, pdl1, pel1)
        g.DrawLine(Pens.Black, pel1, pfl1)
        g.DrawLine(Pens.Black, pfl1, pal1)
        g.DrawLine(Pens.Black, pal1, pdl1)
        g.DrawLine(Pens.Black, pbl1, pel1)
        g.DrawLine(Pens.Black, pcl1, pfl1)
        g.DrawString("A", drawFont, drawBrush, pal1.X - 10, pal1.Y - 22)
        g.DrawString("B", drawFont, drawBrush, pbl1.X, pbl1.Y - 22)
        g.DrawString("C", drawFont, drawBrush, pcl1.X, pcl1.Y - 10)
        g.DrawString("D", drawFont, drawBrush, pdl1.X, pdl1.Y)
        g.DrawString("E", drawFont, drawBrush, pel1.X - 10, pel1.Y)
        g.DrawString("F", drawFont, drawBrush, pfl1.X - 20, pfl1.Y - 10)
        g.DrawString("O", drawFont, drawBrush, pfl1.X + (pcl1.X - pfl1.X) / 2 - 10, pfl1.Y - 20)

        pal2.X = 90
        pal2.Y = 380
        pcl2.X = 390
        pcl2.Y = 380
        pbl2.X = 240
        pbl2.Y = 120
        phl2.X = 240
        phl2.Y = 380
        pml2.Y = 250
        pml2.X = 165
        pll2.X = 315
        pll2.Y = 250
        pol2.X = 240
        pol2.Y = 294
        g2.DrawLine(Pens.Black, pal2, pbl2)
        g2.DrawLine(Pens.Black, pbl2, pcl2)
        g2.DrawLine(Pens.Black, pal2, pcl2)
        g2.DrawLine(Pens.Black, pml2, pcl2)
        g2.DrawLine(Pens.Black, pbl2, phl2)
        g2.DrawLine(Pens.Black, pal2, pll2)

        g2.DrawString("A", drawFont, drawBrush, pal2.X - 20, pal2.Y)
        g2.DrawString("B", drawFont, drawBrush, pbl2.X - 10, pbl2.Y - 20)
        g2.DrawString("C", drawFont, drawBrush, pcl2.X, pcl2.Y)
        g2.DrawString("H", drawFont, drawBrush, phl2.X - 10, phl2.Y)
        g2.DrawString("M", drawFont, drawBrush, pml2.X - 20, pml2.Y - 20)
        g2.DrawString("L", drawFont, drawBrush, pll2.X, pll2.Y - 20)
        g2.DrawString("O", drawFont, drawBrush, pol2.X, pol2.Y - 20)
        pct2.Image = myBitmap2
        pct1.Image = myBitmap

        pl3a.X = 70
        pl3a.Y = 70
        pl3b.X = 430
        pl3b.Y = 70
        pl3c.X = 430
        pl3c.Y = 430
        pl3d.X = 70
        pl3d.Y = 430
        pl3k.X = 70
        pl3k.Y = 250
        pl3l.X = 250
        pl3l.Y = 70
        pl3m.X = 430
        pl3m.Y = 250
        pl3n.X = 250
        pl3n.Y = 430


        g3.DrawLine(Pens.Black, pl3a, pl3b)
        g3.DrawLine(Pens.Black, pl3c, pl3b)
        g3.DrawLine(Pens.Black, pl3c, pl3d)
        g3.DrawLine(Pens.Black, pl3a, pl3d)

        g3.DrawLine(Pens.Green, pl3k, pl3l)
        g3.DrawLine(Pens.Green, pl3l, pl3m)
        g3.DrawLine(Pens.Green, pl3m, pl3n)
        g3.DrawLine(Pens.Green, pl3n, pl3k)

        pl3h.X = (pl3l.X - pl3k.X) / 2 + pl3k.X
        pl3h.Y = (pl3k.Y - pl3l.Y) / 2 + pl3l.Y
        pl3p.X = (pl3l.X - pl3m.X) / 2 + pl3m.X
        pl3p.Y = (pl3l.Y - pl3m.Y) / 2 + pl3m.Y
        pl3e.X = (pl3m.X - pl3n.X) / 2 + pl3n.X
        pl3e.Y = (pl3m.Y - pl3n.Y) / 2 + pl3n.Y
        pl3f.X = (pl3n.X - pl3k.X) / 2 + pl3k.X
        pl3f.Y = (pl3n.Y - pl3k.Y) / 2 + pl3k.Y

        g3.DrawLine(Pens.Blue, pl3h, pl3p)
        g3.DrawLine(Pens.Blue, pl3e, pl3p)
        g3.DrawLine(Pens.Blue, pl3e, pl3f)
        g3.DrawLine(Pens.Blue, pl3f, pl3h)
        g3.DrawLine(Pens.Blue, pl3k, pl3m)
        g3.DrawLine(Pens.Blue, pl3l, pl3n)

        g3.DrawLine(Pens.Black, pl3c, pl3a)
        g3.DrawLine(Pens.Black, pl3b, pl3d)
        g3.DrawString("A", drawFont, drawBrush, pl3a.X - 22, pl3a.Y - 22)
        g3.DrawString("B", drawFont, drawBrush, pl3b.X, pl3b.Y - 22)
        g3.DrawString("C", drawFont, drawBrush, pl3c.X, pl3c.Y)
        g3.DrawString("D", drawFont, drawBrush, pl3d.X - 22, pl3d.Y)
        g3.DrawString("O", drawFont, drawBrush, 250, 250 - 11)
        g3.DrawString("K", drawFont, drawBrush, pl3k.X - 22, pl3k.Y - 11)
        g3.DrawString("L", drawFont, drawBrush, pl3l.X - 10, pl3l.Y - 22)
        g3.DrawString("M", drawFont, drawBrush, pl3m.X, pl3m.Y - 11)
        g3.DrawString("N", drawFont, drawBrush, pl3n.X - 10, pl3n.Y)
        g3.DrawString("H", drawFont, drawBrush, pl3h.X - 22, pl3h.Y - 22)
        g3.DrawString("P", drawFont, drawBrush, pl3p.X, pl3p.Y - 22)
        g3.DrawString("E", drawFont, drawBrush, pl3e.X, pl3e.Y)
        g3.DrawString("F", drawFont, drawBrush, pl3f.X - 22, pl3f.Y)

        pct3.Image = myBitmap3
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If (Trim(TextBox1.Text) = "DE" Or Trim(TextBox1.Text) = "de" Or Trim(TextBox1.Text) = "ed" Or Trim(TextBox1.Text) = "ED") And (Trim(TextBox2.Text) = "CF" Or Trim(TextBox2.Text) = "FC" Or Trim(TextBox2.Text) = "cf" Or Trim(TextBox2.Text) = "fc") Then
            mes.Show()
            mes.Label1.Text = "Ви виконали усі завдання на першому рівні! Другий рівень розблоковано!"
            Label1.Visible = False
            Panel2.Visible = True
        Else
            mes.Show()
            mes.Label1.Text = "Неправильні відповіді на питання"
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        mes.Show()
        mes.Label1.Text = "Центральний кут шестикутника дорівнює 60 градусів"
    End Sub

    Private Sub Label12_Click(sender As System.Object, e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If (Trim(TextBox3.Text) = "AB" Or Trim(TextBox3.Text) = "BA" Or Trim(TextBox3.Text) = "ab" Or Trim(TextBox3.Text) = "ba") And (Trim(TextBox4.Text) = "MOB" Or Trim(TextBox4.Text) = "mob") Then

            mes.Show()
            mes.Label1.Text = "Ви виконалі усі завдання на другому рівні! Третій рівень розблоковано!"
            Label2.Visible = False
            Panel3.Visible = True
        Else
            mes.Show()
            mes.Label1.Text = "Не привильна відповідь на одне з запитань"

        End If
    End Sub

    Private Sub igraP_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If (Trim(TextBox5.Text) = "NOE" Or Trim(TextBox5.Text) = "noe") And (Trim(TextBox6.Text) = "Ні" Or Trim(TextBox6.Text) = "ні") Then
            mes.Label1.Text = "Ви виконали усі завдання на цьюму рівні і пройшли гру з повороту!"
            mes.Show()
        Else
            mes.Label1.Text = "Не правильно виконане одне чи декілька завдань!"
            mes.Show()
        End If
    End Sub
End Class