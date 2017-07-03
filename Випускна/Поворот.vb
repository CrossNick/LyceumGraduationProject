Public Class Поворот

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Label1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label1.MouseEnter
        g.Visible = True
        Label1.Visible = False
    End Sub

    Private Sub Label2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label2.MouseEnter
        t.Visible = True
        Label2.Visible = False
    End Sub

    Private Sub Label3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label3.MouseEnter
        z.Visible = True
        Label3.Visible = False
    End Sub

    Private Sub Label4_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label4.MouseEnter
        p.Visible = True
        Label4.Visible = False
    End Sub

    Private Sub g_MouseLeave(sender As System.Object, e As System.EventArgs) Handles g.MouseLeave
        g.Visible = False
        Label1.Visible = True
    End Sub

    Private Sub t_MouseLeave(sender As System.Object, e As System.EventArgs) Handles t.MouseLeave
        t.Visible = False
        Label2.Visible = True
    End Sub

  

    Private Sub p_MouseLeave(sender As System.Object, e As System.EventArgs) Handles p.MouseLeave
        p.Visible = False
        Label4.Visible = True
    End Sub

    Private Sub Поворот_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.BringToFront()
    End Sub

    Private Sub z_Click(sender As System.Object, e As System.EventArgs) Handles z.Click
        Me.Hide()
        zP.Show()
    End Sub

    Private Sub p_Click(sender As System.Object, e As System.EventArgs) Handles p.Click
        Me.Hide()
        practP.Show()
    End Sub

    Private Sub g_Click(sender As System.Object, e As System.EventArgs) Handles g.Click
        igraP.Show()
        Me.Hide()
    End Sub


    Private Sub z_MouseLeave(sender As System.Object, e As System.EventArgs) Handles z.MouseLeave
        z.Visible = False
        Label3.Visible = True
    End Sub

    Private Sub t_Click(sender As System.Object, e As System.EventArgs) Handles t.Click
        Me.Hide()
        theory.Show()
    End Sub

    Private Sub Поворот_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class