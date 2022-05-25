Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str, strrev As String
        str = TextBox1.Text
        strrev = StrReverse(str)
        TextBox2.Text = strrev

    End Sub


End Class
