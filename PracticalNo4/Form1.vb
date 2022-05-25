Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) > Val(TextBox2.Text) And Val(TextBox1.Text) > Val(TextBox3.Text) Then
            MsgBox("First Number is Greater....")
        ElseIf Val(TextBox1.Text) < Val(TextBox2.Text) And Val(TextBox2.Text) > Val(TextBox3.Text) Then
            MsgBox("Second Number is Greater....")
        Else
            MsgBox("Third Number Is Greater....")




        End If









    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
