Module Module1
    'brooks keller
    '12/7/23
    'binary and decimal converter
    Sub Main()
        Dim input As String
        Dim valid As Integer
        Dim quit As Boolean
        Do
            Console.Write("Press B to convert a DECIMAL to BINARY,      press D to convert a BINARY num to DECIMAL,    and press Q TO QUIT >> ")
            input = Console.ReadLine.ToUpper
            If input = "B" Then
                toBinary()
            ElseIf input = "D" Then

            Else
                Console.WriteLine("quitting program . . .")
                quit = True
            End If
        Loop While quit = False

    End Sub
    Sub toBinary()
        Dim input As String
        Dim valid As Boolean
        Dim int As Integer
        Dim binstring As String = ""
        Console.WriteLine()
        Console.Write("please enter an integer and i will convert it to binary >> ")
        input = Console.ReadLine
        valid = Integer.TryParse(input, int)

        While int > 0
            binstring = (int Mod 2) & binstring
            int = Math.Floor(int / 2)
        End While
        Console.WriteLine($"{input} in binary is {binstring}")
    End Sub
    Function toDecimal()
        Dim input As String

        For i = 0 To input.Length - 1

        Next
    End Function
End Module
