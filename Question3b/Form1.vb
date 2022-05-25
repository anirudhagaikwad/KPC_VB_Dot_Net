Public Class Form1
    Private sum As Single
    'Private substraction As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        Dim num1, num2 As Single
        num1 = txtFirst.Text
        num2 = txtSecond.Text
        sum = num1 + num2
        lbladd.Text = sum
    End Sub

    Private Sub MsgBox(sum As Func(Of Func(Of Char, Decimal), Decimal))
        Throw New NotImplementedException()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1, num2, substraction As Single
        num1 = txtFirst.Text
        num2 = txtSecond.Text
        substraction = num1 - num2

        lblsub.Text = substraction

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1, num2, product As Single
        num1 = txtFirst.Text
        num2 = txtSecond.Text
        product = num1 * num2

        Label3.Text = product

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1, num2, quotient As Single
        num1 = txtFirst.Text
        num2 = txtSecond.Text

        quotient = num1 / num2
        Label3.Text = quotient

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim num1, num2, product As Single

        num1 = txtFirst.Text
        num2 = txtSecond.Text
        product = num1 + num2
        lbladd.Text = product

    End Sub
End Class
