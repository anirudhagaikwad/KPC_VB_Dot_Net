Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As New demo
        obj.getdata(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        Label5.Text = "Employee ID:-" & obj.emp_id
        Label6.Text = "Employee Name:-" & obj.emp_name
        Label7.Text = "Employee Salary:-" & obj.salary

    End Sub


End Class
Public Class Employee
    Public emp_name As String
    Public emp_id As Integer
    Public salary As Double
    Overridable Sub getdata(ByVal x As String, ByVal y As String, ByVal z As String)
        emp_name = "arati"
        emp_id = 101
        salary = 10000

    End Sub

End Class
Class demo
    Inherits Employee
    Public Overrides Sub getdata(x As String, y As String, z As String)
        emp_id = Integer.Parse(x)
        emp_name = y
        salary = Double.Parse(z)
    End Sub


End Class
