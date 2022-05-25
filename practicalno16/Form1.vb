Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim message As String
        Dim name As String
        name = TextBox1.Text
        message = callme(name)
        MessageBox.Show(message)

    End Sub
    Function callme(name As String) As String
        Dim msg As String = "hello, this is " & name
        Return msg

    End Function


End Class
