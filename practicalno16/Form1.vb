Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim no, fact As Integer
        no = Val(TextBox1.Text)
        fact = Factorial(no)

        MessageBox.Show("Factorial of given no is:" + fact.ToString())



    End Sub
    Function Factorial(ByVal n As Integer) As Integer
        If n <= 1 Then
            Return 1

        End If
        Return Factorial(n - 1) * n


    End Function


End Class
