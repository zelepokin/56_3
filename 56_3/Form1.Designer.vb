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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.B1 = New System.Windows.Forms.Button()
        Me.TS = New System.Windows.Forms.TextBox()
        Me.Tk = New System.Windows.Forms.TextBox()
        Me.TSa = New System.Windows.Forms.TextBox()
        Me.Posl = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(446, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "S"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(446, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "k"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(446, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sa"
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(391, 297)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(181, 95)
        Me.B1.TabIndex = 1
        Me.B1.Text = "Обчислити"
        Me.B1.UseVisualStyleBackColor = True
        '
        'TS
        '
        Me.TS.Location = New System.Drawing.Point(645, 60)
        Me.TS.Name = "TS"
        Me.TS.Size = New System.Drawing.Size(100, 20)
        Me.TS.TabIndex = 2
        '
        'Tk
        '
        Me.Tk.Location = New System.Drawing.Point(645, 140)
        Me.Tk.Name = "Tk"
        Me.Tk.Size = New System.Drawing.Size(100, 20)
        Me.Tk.TabIndex = 2
        '
        'TSa
        '
        Me.TSa.Location = New System.Drawing.Point(645, 209)
        Me.TSa.Name = "TSa"
        Me.TSa.Size = New System.Drawing.Size(100, 20)
        Me.TSa.TabIndex = 2
        '
        'Posl
        '
        Me.Posl.Location = New System.Drawing.Point(27, 61)
        Me.Posl.Multiline = True
        Me.Posl.Name = "Posl"
        Me.Posl.Size = New System.Drawing.Size(218, 272)
        Me.Posl.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Posl)
        Me.Controls.Add(Me.TSa)
        Me.Controls.Add(Me.Tk)
        Me.Controls.Add(Me.TS)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents B1 As Button
    Friend WithEvents TS As TextBox
    Friend WithEvents Tk As TextBox
    Friend WithEvents TSa As TextBox
    Friend WithEvents Posl As TextBox
End Class
