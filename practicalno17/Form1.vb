Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ob As Sample = New Sample()
        ob.display()
        ob.getdata(TextBox1.Text)
        ob.display()
    End Sub
End Class
Public Class Sample
    Dim str As String
    Sub New()
        str = "Default Name:Arati"
    End Sub
    Sub getdata(ByVal st As String)
        str = st
    End Sub
    Function display() As Integer
        MessageBox.Show("Welcome" + str)
        display = 1

    End Function

End Class
