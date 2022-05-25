Imports System

Module Program
    Sub Main()
        'Q6)Develop programs to demonstrate use of While, Do while Loops in VB.net.'
        ' Do While example'
        Dim a As Integer
        a = 0
        Do
            a += 1
            Console.WriteLine(a)
        Loop While a < 5

        Console.ReadLine()
        'program to create any tables'
        Dim n1, n2 As Integer
        Console.WriteLine("Enter any number:")
        n1 = 0
        n2 = Console.ReadLine()
        Console.WriteLine("Table of" & n2 & ":")
        While (n1 < 10)
            n1 += 1
            Console.WriteLine(n2 & "*" & n1 & "=" & n2 * n1)

        End While
        Console.ReadLine()



    End Sub
End Module
