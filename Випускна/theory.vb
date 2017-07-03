Public Class theory

    Private Sub TreeView1_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim s As String = Application.StartupPath & "/Text/"
        If TreeView1.SelectedNode.Name = "vid" Then
            Label1.Text = "Загальні відомості"
            RichTextBox1.LoadFile(s & "vid.rtf")
        ElseIf TreeView1.SelectedNode.Name = "ppt" Then
            Label1.Text = "Паралельне перенесення"
            RichTextBox1.LoadFile(s & "ppt.rtf")
        ElseIf TreeView1.SelectedNode.Name = "ppl" Then
            Label1.Text = "Паралельне перенесення"
            RichTextBox1.LoadFile(s & "ppv.rtf")
        ElseIf TreeView1.SelectedNode.Name = "ppz" Then
            Label1.Text = "Паралельне перенесення"
            RichTextBox1.LoadFile(s & "ppz.rtf")
        ElseIf TreeView1.SelectedNode.Name = "cs" Then
            Label1.Text = "Симетрія"
            RichTextBox1.LoadFile(s & "cs.rtf")
        ElseIf TreeView1.SelectedNode.Name = "os" Then
            Label1.Text = "Симетрія"
            RichTextBox1.LoadFile(s & "os.rtf")
        ElseIf TreeView1.SelectedNode.Name = "sl" Then
            Label1.Text = "Симетрія"
            RichTextBox1.LoadFile(s & "sv.rtf")
        ElseIf TreeView1.SelectedNode.Name = "sz" Then
            Label1.Text = "Симетрія"
            RichTextBox1.LoadFile(s & "sz.rtf")
        ElseIf TreeView1.SelectedNode.Name = "pt" Then
            Label1.Text = "Поворот"
            RichTextBox1.LoadFile(s & "pt.rtf")
        ElseIf TreeView1.SelectedNode.Name = "pl" Then
            Label1.Text = "Поворот"
            RichTextBox1.LoadFile(s & "pv.rtf")
        ElseIf TreeView1.SelectedNode.Name = "pz" Then
            Label1.Text = "Поворот"
            RichTextBox1.LoadFile(s & "pz.rtf")
        ElseIf TreeView1.SelectedNode.Name = "gt" Then
            Label1.Text = "Гомотетія"
            RichTextBox1.LoadFile(s & "gt.rtf")
        ElseIf TreeView1.SelectedNode.Name = "gl" Then
            Label1.Text = "Гомотетія"
            RichTextBox1.LoadFile(s & "gv.rtf")
        ElseIf TreeView1.SelectedNode.Name = "gz" Then
            Label1.Text = "Гомотетія"
            RichTextBox1.LoadFile(s & "gz.rtf")
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        If back = 1 Then
            Симетрия.Show()
        ElseIf back = 2 Then
            Гомотетия.Show()
        ElseIf back = 3 Then
            Перенесення.Show()
        ElseIf back = 4 Then
            Поворот.Show()
        End If
    End Sub

    Private Sub theory_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class