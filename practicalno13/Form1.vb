Imports System.Text.RegularExpressions
Public Class Form1
    'Validating Phone Number Code
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim regex As Regex = New Regex("^[789]\d{9}$")

        Dim isValid As Boolean = regex.IsMatch(TextBox1.Text)

        If isValid Then
            ErrorProvider1.SetError(TextBox1, "Valid")
        Else
            ErrorProvider1.SetError(TextBox1, "InValid")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Validating Email Code
        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim isValid As Boolean = regex.IsMatch(TextBox2.Text.Trim)
        If isValid Then
            MessageBox.Show("valid Email.")
        Else
            MessageBox.Show("Invalid Email.")
        End If
    End Sub
End Class
