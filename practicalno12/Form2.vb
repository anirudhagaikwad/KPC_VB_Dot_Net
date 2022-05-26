Public Class Form2


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As String
        a = TextBox1.Text
        b = TextBox2.Text
        MsgBox("You are Enter..." & a + " And " & b)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b, c, d As String
        a = TextBox3.Text
        b = TextBox4.Text
        c = TextBox5.Text
        d = TextBox6.Text
        MsgBox("You are Enter..." & d + " And " & a + " And " & b + " And " & c)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim timerForm As New Form1
        timerForm.Show()
    End Sub
End Class