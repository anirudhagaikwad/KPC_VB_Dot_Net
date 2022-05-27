Imports System

Module Program
    Public Class Calculate

        Public Sub AddNumbers(ByVal a As Integer, ByVal b As Integer)

            Console.WriteLine("a + b = {0}", a + b)

        End Sub

        Public Sub AddNumbers(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer)

            Console.WriteLine("a + b + c = {0}", a + b + c)

        End Sub

    End Class

    Sub Main(ByVal args As String())

        Dim c As Calculate = New Calculate()

        c.AddNumbers(1, 2)

        c.AddNumbers(1, 2, 3)

        Console.WriteLine("Press Enter Key to Exit..")

        Console.ReadLine()

    End Sub
End Module
