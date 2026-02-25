Module Program
    Sub Main()

        Greet()

        PrintArithmeticMenu()


        'While True
        '    Console.Write("Enter first number (or type 'off' to quit): ")
        '    Dim input1 As String = Console.ReadLine()

        '    If input1.ToLower().Trim() = "off" Then
        '        Exit While
        '    End If

        '    Console.Write("Enter second number (or type 'off' to quit): ")
        '    Dim input2 As String = Console.ReadLine()

        '    If input2.ToLower().Trim() = "off" Then
        '        Exit While
        '    End If

        '    Dim num1, num2 As Integer

        '    If Integer.TryParse(input1, num1) AndAlso Integer.TryParse(input2, num2) Then
        '        Console.WriteLine("Sum = " & (num1 + num2))
        '    Else
        '        Console.WriteLine("Invalid input. Enter numbers only")
        '    End If

        '    Console.WriteLine()

        'End While

        'Console.WriteLine("Program ended")

        'Console.ReadKey()



    End Sub

    Sub Greet()
        Console.WriteLine("Hello folks, let do some arithmetics!")
        Console.WriteLine()
    End Sub

    Sub PrintArithmeticMenu()
        Console.WriteLine("Choose you preferred Operation:")
        Console.WriteLine("1. Addition")
        Console.WriteLine("2. Substraction")
        Console.WriteLine("3. Division")
        Console.WriteLine("4. Multiplication")
        Console.WriteLine("5. Modulus")
        Console.WriteLine()


    End Sub

End Module