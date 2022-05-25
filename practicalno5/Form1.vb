Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim percentage As Integer
        percentage = Val(TextBox1.Text)
        Select Case percentage
            Case Is >= 75
                MsgBox("Hello You Got Distinction....")
            Case Is >= 65
                MsgBox("Hello You Got First Class....")
            Case Is >= 50
                MsgBox("Hello You Got Second class....")
            Case Is >= 35
                MsgBox("Hello You Got Pass....")



            Case Else
                MsgBox("Hello You are Fail....")



        End Select


    End Sub
End Class
