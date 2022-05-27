Imports System
Class A
    Public Overridable Sub F()
        Console.WriteLine("A.F")
    End Sub
End Class

Class B
    Inherits A

    Public Overrides Sub F()
        Console.WriteLine("B.F")
    End Sub
End Class

Class C
    Inherits B

    Public Overridable Shadows Sub F()
        Console.WriteLine("C.F")
    End Sub
End Class

Class D
    Inherits C

    Public Overrides Sub F()
        Console.WriteLine("D.F")
    End Sub
End Class

Module Program


    Sub Main(args As String())
        Dim d As New D()
        Dim a As A = d
        Dim b As B = d
        Dim c As C = d
        a.F()
        b.F()
        c.F()
        d.F()
    End Sub
End Module
