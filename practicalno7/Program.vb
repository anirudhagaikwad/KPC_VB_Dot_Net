Imports System
'practical no 7: Develop programs to demonstrate use of For, For-each Loops in VB.net.'
Module Program
    Sub Main(args As String())
        'for program
        Dim i As Double

        For i = 11 To 20 Step 2
            Console.WriteLine(i)
        Next
        Console.ReadLine()

        'for each program'

        Dim arr As Array = {1, 3, 4, 6, 8, 9}
        Dim c As Integer
        For Each c In arr
            Console.WriteLine(c)
        Next
        Console.ReadLine()

        'Armstrong no program'

        Dim num, temp, remd, sum, a As Integer
        For num = 1 To 500
            temp = num
            sum = 0
            For a = 1 To num
                remd = temp Mod 10
                If num < 10 Then
                    sum = remd + sum
                ElseIf num < 100 Then
                    sum = (remd * remd) + sum
                Else
                    sum = (remd * remd * remd) + sum
                End If
                temp = temp \ 10

            Next
            If num = sum Then
                Console.WriteLine(num)


            End If
        Next

        Console.ReadLine()


    End Sub
End Module
