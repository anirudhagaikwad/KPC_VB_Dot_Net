Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim height As Integer = 0
        height = Integer.Parse(TextBox3.Text)
        Try
            If (height < 5) Then
                Throw (New HeightIsPositive("Height Shold be >than 5 ft"))
            Else
                Label7.Text = "Height:-" & height
                Label6.Text = "Age:-" & TextBox2.Text
                Label5.Text = "Name:-" & TextBox1.Text

            End If

        Catch ex As Exception
            Label5.Text = ex.Message
            Label6.Text = ""
            Label7.Text = ""

        End Try


    End Sub
End Class
Public Class HeightIsPositive : Inherits ApplicationException
    Public Sub New(ByVal message As String)
        MyBase.New(message)

    End Sub
End Class
