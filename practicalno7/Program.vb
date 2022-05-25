Imports System
'practical no 7: Develop programs to demonstrate use of For, For-each Loops in VB.net.'
Module Program
    Sub Main(args As String())
        'for program

        Console.WriteLine("For Loop... print 1 to 20 step 2")
        Dim i As Double

        For i = 11 To 20 Step 2
            Console.WriteLine(i)
        Next
        Console.ReadLine()

        'for each program'
        Console.WriteLine("For Each Loop...Travers on array")
        Dim arr As Array = {1, 3, 4, 6, 8, 9}
        Dim c As Integer
        For Each c In arr
            Console.WriteLine(c)
        Next
        Console.ReadLine()

        'Armstrong no program - An Armstrong number of is an integer such that the sum of the cubes of its digits is equal to the number itself.'
        Console.WriteLine("While Loop... number is Armstrong or Not ")
        Dim n As Integer, r, temp As Integer, sum As Integer = 0
        Console.Write("Enter the Number= ")
        n = Integer.Parse(Console.ReadLine())
        temp = n

        While n > 0
            r = n Mod 10
            sum = sum + (r * r * r)
            n = n / 10
        End While

        If temp = sum Then
            Console.Write("Armstrong Number.")
        Else
            Console.Write("Not Armstrong Number.")
        End If
        Console.ReadLine()
    End Sub
End Module
