Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim ob As New Student("Arati", 90, "VB.Net")
        ob.ShowName()
        ob.ShowMarks()
    End Sub
End Class
Public Class Faculty
    Dim sub_name As String
    Dim Emp_Id As Integer
    Public Sub New(ByVal x As String)
        sub_name = x
    End Sub
    Public Function ShowName() As String
        Return sub_name
    End Function

End Class
Public Class Student
    Inherits Faculty
    Dim name As String
    Dim marks As Integer
    Public Sub New(ByVal na As String, ByVal x As Integer, ByVal sub_ne As String)
        MyBase.New(sub_ne)
        name = na
        marks = x

    End Sub
    Public Function ShowMarks() As Integer
        MessageBox.Show("student Name:--" & name & vbCrLf & "Subject Name:--" & ShowName().ToString & vbCrLf & "Marks:--" & marks)
        Return 0

    End Function

End Class
