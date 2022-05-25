'VB.net program to create a user-defined namespace.

Namespace MathNamespace
    Class AritheMatic
        Sub Add(ByVal num1 As Integer, ByVal num2 As Integer)
            Console.WriteLine("Addition is: {0}", num1 + num2)
        End Sub

        Sub Subtract(ByVal num1 As Integer, ByVal num2 As Integer)
            Console.WriteLine("Subtraction is: {0}", num1 - num2)
        End Sub
    End Class

    Class Fact
        Sub CalculateFactorial(ByVal num As Integer)
            Dim fact As Integer = 1

            For i = num To 1 Step -1
                fact = fact * i
            Next
            Console.WriteLine("Factorial is: {0}", fact)
        End Sub
    End Class

End Namespace

Module Module1

    Sub Main()
        Dim airth As New MathNamespace.AritheMatic
        Dim fact As New MathNamespace.Fact

        airth.Add(10, 20)
        airth.Subtract(20, 10)
        fact.CalculateFactorial(5)
    End Sub

End Module

