Public Class Form1

    Private Sub pctS_MouseEnter(sender As System.Object, e As System.EventArgs) Handles pctS.MouseEnter
        pctS.Image = Image.FromFile(Application.StartupPath & "\карта\Симетрия.png")
    End Sub


    Private Sub pctS_MouseLeave(sender As System.Object, e As System.EventArgs) Handles pctS.MouseLeave
        pctS.Image = Image.FromFile(Application.StartupPath & "\карта\0.png")
    End Sub

    Private Sub pctG_MouseEnter(sender As System.Object, e As System.EventArgs) Handles pctG.MouseEnter
        pctG.Image = Image.FromFile(Application.StartupPath & "\карта\Гомотетія.png")
    End Sub

    Private Sub pctG_MouseLeave(sender As System.Object, e As System.EventArgs) Handles pctG.MouseLeave
        pctG.Image = Image.FromFile(Application.StartupPath & "\карта\0.png")
    End Sub

    Private Sub pctPP_MouseEnter(sender As System.Object, e As System.EventArgs) Handles pctPP.MouseEnter
        pctPP.Image = Image.FromFile(Application.StartupPath & "\карта\Паралельне перенесення.png")
    End Sub

    Private Sub pctPP_MouseLeave(sender As System.Object, e As System.EventArgs) Handles pctPP.MouseLeave
        pctPP.Image = Image.FromFile(Application.StartupPath & "\карта\0.png")
    End Sub

    Private Sub pctP_MouseEnter(sender As System.Object, e As System.EventArgs) Handles pctP.MouseEnter
        pctP.Image = Image.FromFile(Application.StartupPath & "\карта\Поворот.png")
    End Sub

    Private Sub pctP_MouseLeave(sender As System.Object, e As System.EventArgs) Handles pctP.MouseLeave
        pctP.Image = Image.FromFile(Application.StartupPath & "\карта\0.png")
    End Sub

    Private Sub pctP_Click(sender As System.Object, e As System.EventArgs) Handles pctP.Click
        back = 4
        Me.Hide()
        Поворот.Show()

    End Sub

    Private Sub pctG_Click(sender As System.Object, e As System.EventArgs) Handles pctG.Click
        back = 2
        Me.Hide()
        Гомотетия.Show()
    End Sub

    Private Sub pctPP_Click(sender As System.Object, e As System.EventArgs) Handles pctPP.Click
        back = 3
        Me.Hide()
        Перенесення.Show()
    End Sub

    Private Sub pctS_Click(sender As System.Object, e As System.EventArgs) Handles pctS.Click
        back = 1
        Me.Hide()
        Симетрия.Show()
    End Sub

  

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class
