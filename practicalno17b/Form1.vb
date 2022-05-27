Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim no1, no2, no3 As Double
        no1 = Val(ComboBox1.SelectedItem.ToString)
        no2 = Val(ComboBox2.SelectedItem.ToString)
        no3 = Val(ComboBox3.SelectedItem.ToString)
        Dim ob As average = New average()
        Label5.Text = ob.cal_average(no1, no2, no3).ToString()

    End Sub
    Class average
        Function cal_average(ByVal no1 As Integer, ByVal no2 As Integer, ByVal no3 As Integer)
            cal_average = (no1 + no2 + no3) / 3

        End Function

    End Class
End Class
