Public Class Form1
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub
    Dim var As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            MessageBox.Show("age is under 15")
        End If

        If CheckBox2.Checked Then
            MessageBox.Show("age is under 25")
        End If
        If CheckBox3.Checked Then
            MessageBox.Show("age is over 25")
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Button1.Enabled = RadioButton1.Checked
        var = 15

    End Sub
End Class
