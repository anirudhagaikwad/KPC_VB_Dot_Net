Public Class Form1
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim a, b, c As Single
        a = txtfirst.Text
        b = txtsecound.Text
        c = a + b
        MsgBox("addition=" & c)

    End Sub

    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        Dim a, b, c As Single
        a = txtfirst.Text
        b = txtsecound.Text
        c = a - b

        MsgBox("Substraction=" & c)
    End Sub

    Private Sub btnmul_Click(sender As Object, e As EventArgs) Handles btnmul.Click
        Dim a, b, c As Single
        a = txtfirst.Text
        b = txtsecound.Text
        c = a * b

        MsgBox("Multiplication=" & c)
    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        Dim a, b, c As Integer

        a = txtfirst.Text
        b = txtsecound.Text
        c = a \ b

        MsgBox("Division=" & c)
    End Sub
End Class
