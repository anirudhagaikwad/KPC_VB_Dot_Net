<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsub = New System.Windows.Forms.Button()
        Me.btnmul = New System.Windows.Forms.Button()
        Me.btndiv = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtfirst = New System.Windows.Forms.TextBox()
        Me.txtsecound = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter 1st no:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter 2nd no:"
        '
        'btnsub
        '
        Me.btnsub.Location = New System.Drawing.Point(231, 275)
        Me.btnsub.Name = "btnsub"
        Me.btnsub.Size = New System.Drawing.Size(94, 29)
        Me.btnsub.TabIndex = 2
        Me.btnsub.Text = "SUB"
        Me.btnsub.UseVisualStyleBackColor = True
        '
        'btnmul
        '
        Me.btnmul.Location = New System.Drawing.Point(377, 275)
        Me.btnmul.Name = "btnmul"
        Me.btnmul.Size = New System.Drawing.Size(94, 29)
        Me.btnmul.TabIndex = 3
        Me.btnmul.Text = "MUL"
        Me.btnmul.UseVisualStyleBackColor = True
        '
        'btndiv
        '
        Me.btndiv.Location = New System.Drawing.Point(544, 275)
        Me.btndiv.Name = "btndiv"
        Me.btndiv.Size = New System.Drawing.Size(94, 29)
        Me.btndiv.TabIndex = 4
        Me.btndiv.Text = "DIV"
        Me.btndiv.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(75, 275)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(94, 29)
        Me.btnadd.TabIndex = 5
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtfirst
        '
        Me.txtfirst.Location = New System.Drawing.Point(200, 51)
        Me.txtfirst.Name = "txtfirst"
        Me.txtfirst.Size = New System.Drawing.Size(125, 27)
        Me.txtfirst.TabIndex = 6
        '
        'txtsecound
        '
        Me.txtsecound.Location = New System.Drawing.Point(200, 132)
        Me.txtsecound.Name = "txtsecound"
        Me.txtsecound.Size = New System.Drawing.Size(125, 27)
        Me.txtsecound.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtsecound)
        Me.Controls.Add(Me.txtfirst)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btndiv)
        Me.Controls.Add(Me.btnmul)
        Me.Controls.Add(Me.btnsub)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsub As Button
    Friend WithEvents btnmul As Button
    Friend WithEvents btndiv As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents txtfirst As TextBox
    Friend WithEvents txtsecound As TextBox
    Friend WithEvents Label3 As Label
End Class
