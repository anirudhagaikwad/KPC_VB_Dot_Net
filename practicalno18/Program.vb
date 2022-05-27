Imports System.Console
Module Program
    Sub Main(args As String())
        Dim con As New Constructor(20)
        WriteLine(con.ShowAge())
        'storing a value in the constructor by passing a value(20) and calling it with the ShowAge method
        Read()
        Dim obj As New Destroy()

    End Sub
End Module
Public Class Constructor
    Public Age As Integer

    Public Sub New(ByVal x As Integer)
        'constructor
        Age = x
        'storing the value of Age in constructor
    End Sub

    Public Function ShowAge() As Integer
        Return Age
        'returning the stored value
    End Function

End Class
Public Class Destroy

    Protected Overrides Sub Finalize()
        'creating a Destrustor
        Write("VB.NET")
        Read()
    End Sub

End Class