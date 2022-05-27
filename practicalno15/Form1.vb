Public Class Form1
    Dim a, r As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getRed()
        area(r)
        display()

    End Sub
    Sub getRed()
        r = Val(TextBox1.Text)
    End Sub

    Sub display()
        MessageBox.Show("area of circle:-" + a.ToString())


    End Sub
    Sub area(ByVal r As Double)
        a = 3.14 * r * r
    End Sub
End Class
