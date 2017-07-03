<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pctS = New System.Windows.Forms.PictureBox()
        Me.pctPP = New System.Windows.Forms.PictureBox()
        Me.pctG = New System.Windows.Forms.PictureBox()
        Me.pctP = New System.Windows.Forms.PictureBox()
        CType(Me.pctS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctS
        '
        Me.pctS.BackColor = System.Drawing.Color.Transparent
        Me.pctS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctS.Location = New System.Drawing.Point(16, 125)
        Me.pctS.Name = "pctS"
        Me.pctS.Size = New System.Drawing.Size(323, 421)
        Me.pctS.TabIndex = 0
        Me.pctS.TabStop = False
        '
        'pctPP
        '
        Me.pctPP.BackColor = System.Drawing.Color.Transparent
        Me.pctPP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctPP.Location = New System.Drawing.Point(623, 81)
        Me.pctPP.Name = "pctPP"
        Me.pctPP.Size = New System.Drawing.Size(348, 465)
        Me.pctPP.TabIndex = 1
        Me.pctPP.TabStop = False
        '
        'pctG
        '
        Me.pctG.BackColor = System.Drawing.Color.Transparent
        Me.pctG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctG.Location = New System.Drawing.Point(347, 12)
        Me.pctG.Name = "pctG"
        Me.pctG.Size = New System.Drawing.Size(301, 209)
        Me.pctG.TabIndex = 2
        Me.pctG.TabStop = False
        '
        'pctP
        '
        Me.pctP.BackColor = System.Drawing.Color.Transparent
        Me.pctP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctP.Location = New System.Drawing.Point(361, 435)
        Me.pctP.Name = "pctP"
        Me.pctP.Size = New System.Drawing.Size(301, 225)
        Me.pctP.TabIndex = 3
        Me.pctP.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(983, 672)
        Me.Controls.Add(Me.pctP)
        Me.Controls.Add(Me.pctG)
        Me.Controls.Add(Me.pctPP)
        Me.Controls.Add(Me.pctS)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Геометричні перетворення"
        CType(Me.pctS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pctS As System.Windows.Forms.PictureBox
    Friend WithEvents pctPP As System.Windows.Forms.PictureBox
    Friend WithEvents pctG As System.Windows.Forms.PictureBox
    Friend WithEvents pctP As System.Windows.Forms.PictureBox

End Class
