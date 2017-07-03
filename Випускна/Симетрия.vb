Public Class Симетрия

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Симетрия_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    

    Private Sub t_MouseEnter(sender As System.Object, e As System.EventArgs) Handles t.MouseEnter

    End Sub

    Private Sub z_MouseEnter(sender As System.Object, e As System.EventArgs) Handles z.MouseEnter

    End Sub

    Private Sub p_MouseEnter(sender As System.Object, e As System.EventArgs) Handles p.MouseEnter

    End Sub

    Private Sub i_MouseLeave(sender As System.Object, e As System.EventArgs) Handles i.MouseLeave
        i.Visible = False
        Label1.Visible = True
    End Sub

    Private Sub t_MouseLeave(sender As System.Object, e As System.EventArgs) Handles t.MouseLeave
        t.Visible = False
        Label2.Visible = True
    End Sub

    Private Sub z_MouseLeave(sender As System.Object, e As System.EventArgs) Handles z.MouseLeave
        z.Visible = False
        Label3.Visible = True
    End Sub

   
    Private Sub p_MouseLeave(sender As System.Object, e As System.EventArgs) Handles p.MouseLeave
        p.Visible = False
        Label4.Visible = True
    End Sub

    Private Sub i1_MouseEnter(sender As System.Object, e As System.EventArgs)

       
    End Sub

    Private Sub Label1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label1.MouseEnter
        i.Visible = True
        Label1.Visible = False
    End Sub

    Private Sub Label2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label2.MouseEnter
        Label2.Visible = False
        t.Visible = True
    End Sub

    Private Sub Label3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label3.MouseEnter
        Label3.Visible = False
        z.Visible = True

    End Sub

    Private Sub Label4_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label4.MouseEnter
        Label4.Visible = False
        p.Visible = True

    End Sub


    Private Sub i_Click(sender As System.Object, e As System.EventArgs) Handles i.Click
        Me.Hide()
        igraS.Show()
    End Sub

    Private Sub z_Click(sender As System.Object, e As System.EventArgs) Handles z.Click
        Me.Hide()
        zS.Show()
    End Sub

    Private Sub p_Click(sender As System.Object, e As System.EventArgs) Handles p.Click
        Me.Hide()
        practCS.Show()

    End Sub

    Private Sub t_Click(sender As System.Object, e As System.EventArgs) Handles t.Click
        Me.Hide()
        theory.Show()
    End Sub

    Private Sub Симетрия_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class