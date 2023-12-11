Imports System.Threading

Module Module1
    'brooks keller
    '12/7/23
    'binary and decimal converter
    Sub Main()
        Dim input As String
        Dim quit As Boolean
        Do
            Console.Write("Press B to convert a DECIMAL to BINARY,      Press D to convert a BINARY num to DECIMAL,
Press O to convert to OCTAL,           and press Q TO QUIT >> ")
            input = Console.ReadLine.ToUpper
            If input = "B" Then
                toBinary()
            ElseIf input = "D" Then
                toDecimal()
            ElseIf input = "O" Then
                toOctal()
            ElseIf input = "Q" Then
                Console.WriteLine("Quitting program . . .")
                Thread.Sleep(500)
                quit = True
            Else
                Console.WriteLine("Invalid Input.")
                Console.WriteLine("Press any key to continue. . .")
                Console.Clear()
            End If
        Loop While quit = False

    End Sub
    Sub toBinary()
        Dim input As String
        Dim valid As Boolean
        Dim int As Integer
        Dim binstring As String = ""
        Console.WriteLine()
        Console.Write("Please enter an integer and I will convert it to binary >> ")
        input = Console.ReadLine
        valid = Integer.TryParse(input, int)

        While int > 0
            binstring = (int Mod 2) & binstring
            int = Math.Floor(int / 2)
        End While
        Console.WriteLine($"{input} in binary is {binstring}")
        Console.WriteLine("Press any key to continue...")
        Console.ReadKey()
        Console.WriteLine()
        Console.Clear()
    End Sub
    Sub toDecimal()
        Dim input As String
        Dim num As Integer
        Dim totalnum As String

        Console.WriteLine()
        Console.Write($"Please enter some binary and i will attempt to make it an integer >> ")
        input = Console.ReadLine
        For i As Integer = 0 To input.Length - 1
            If input(i) = "1" Then
                num = 1 * 2 ^ (input.Length - 1 - i)
                totalnum += num
            ElseIf input(i) = "0" Then
                num = 0
                totalnum += num
            Else
                Console.WriteLine("Your binary was formatted wrong. Please try again.")
                totalnum = "invalid"
            End If

        Next
        Console.WriteLine($"{input} to a decimal is {totalnum}")
        Console.WriteLine("Press any key to continue...")
        Console.ReadKey()
        Console.WriteLine()
        Console.Clear()
    End Sub
    Sub toOctal()
        Dim input As String
        Dim valid As Boolean
        Dim int As Integer
        Dim octalstring As String = ""
        Console.WriteLine()
        Console.Write("Please enter an integer and i will convert it to octal >> ")
        input = Console.ReadLine
        valid = Integer.TryParse(input, int)

        While int > 0
            octalstring = (int Mod 8) & octalstring
            int = Math.Floor(int / 8)
        End While
        Console.WriteLine($"{input} in binary is {octalstring}")
        Console.WriteLine("Press any key to continue...")
        Console.ReadKey()
        Console.WriteLine()
        Console.Clear()
    End Sub
End Module
