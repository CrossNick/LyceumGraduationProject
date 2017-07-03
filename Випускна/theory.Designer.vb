<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class theory
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Загальні відомості")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Теорія")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Паралельне перенесення у житті")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Задачі")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Паралельне перенесення", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Осьова симетрія")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Центральна симетрія")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Симетрія у житті")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Задачі")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Симетрія", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Теорія")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Поворот у житті")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Задачі")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Поворот", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Теорія")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Гомотетія у житті")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Задачі")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Гомотетія", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16, TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Перетворення", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode10, TreeNode14, TreeNode18})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(theory))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(12, 50)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "vid"
        TreeNode1.Text = "Загальні відомості"
        TreeNode2.Name = "ppt"
        TreeNode2.Text = "Теорія"
        TreeNode3.Name = "ppl"
        TreeNode3.Text = "Паралельне перенесення у житті"
        TreeNode4.Name = "ppz"
        TreeNode4.Text = "Задачі"
        TreeNode5.Name = "Узел2"
        TreeNode5.Text = "Паралельне перенесення"
        TreeNode6.Name = "os"
        TreeNode6.Text = "Осьова симетрія"
        TreeNode7.Name = "cs"
        TreeNode7.Text = "Центральна симетрія"
        TreeNode8.Name = "sl"
        TreeNode8.Text = "Симетрія у житті"
        TreeNode9.Name = "sz"
        TreeNode9.Text = "Задачі"
        TreeNode10.Name = "Узел7"
        TreeNode10.Text = "Симетрія"
        TreeNode11.Name = "pt"
        TreeNode11.Text = "Теорія"
        TreeNode12.Name = "pl"
        TreeNode12.Text = "Поворот у житті"
        TreeNode13.Name = "pz"
        TreeNode13.Text = "Задачі"
        TreeNode14.Name = "Узел12"
        TreeNode14.Text = "Поворот"
        TreeNode15.Name = "gt"
        TreeNode15.Text = "Теорія"
        TreeNode16.Name = "gl"
        TreeNode16.Text = "Гомотетія у житті"
        TreeNode17.Name = "gz"
        TreeNode17.Text = "Задачі"
        TreeNode18.Name = "Узел16"
        TreeNode18.Text = "Гомотетія"
        TreeNode19.Name = "Узел1"
        TreeNode19.Text = "Перетворення"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode19})
        Me.TreeView1.Size = New System.Drawing.Size(271, 498)
        Me.TreeView1.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(299, 50)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(880, 595)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(416, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 49)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Теорія"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Monotype Corsiva", 40.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.Location = New System.Drawing.Point(12, 550)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(271, 95)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Меню"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'theory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1196, 657)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "theory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Теорія"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
