Imports System.Text.RegularExpressions
'Q13)Write a program to perform validation using regular expression and error provider.'
'Q14)Write a program to perform validation using regular expression And error rovider.'
'  #Match the beginning of the string
'[789] #Match a 7, 8 Or 9
'\d    #Match a digit (0-9 And anything else that Is a "digit" in the regex engine)
'{9}   #Repeat the previous "\d" 9 times (9 digits)
'$     #Match the end of the string
Module Program
    Sub Main(args As String())
        Dim regex As Regex = New Regex("\d+")
        Dim match As Match = regex.Match("this 10 th lecture")
        If match.Success Then
            Console.WriteLine(match.Value)
        Else
            Console.WriteLine("digit not found")

        End If
        Console.ReadKey()






    End Sub




End Module
