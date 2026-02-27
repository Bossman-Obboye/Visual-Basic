Imports System
'Number Statistics Engine
'Keep asking the user For numbers until they type "exit".
'At the End display:
'Total numbers entered
'Sum
'Average
'Largest
'Smallest
'How many even numbers
'How many odd numbers
'Handle invalid inputs properly (don't crash).
Module Program
    Sub Main(args As String())

        Console.WriteLine("Number Statistics Engine")
        Console.WriteLine()

        'Keep asking the user For numbers until they type "exit".
        Dim inputs = GetInputs()

        'Display Total numbers entered
        Console.WriteLine($"You've entered {TotalCount(inputs)} numbers")
        Console.WriteLine()

        'Display Sum
        Console.WriteLine("The sum of all the numbers you entered is: " & Sum(inputs).ToString("F2"))
        Console.WriteLine()

        'Display Average
        Console.WriteLine($"The average: " & Average(inputs).ToString("F2"))
        Console.WriteLine()

        'Display Largest
        Console.WriteLine($"The largest: {Largest(inputs)}")
        Console.WriteLine()

        'Display Smallest
        Console.WriteLine($"The smallest: {Smallest(inputs)}")
        Console.WriteLine()

        'Display Analysis
        Analysis(inputs)

        Console.WriteLine("Program Completed")

    End Sub

    Function TotalCount(ByVal numbers As List(Of Double)) As Integer
        Return numbers.Count
    End Function

    Function Sum(ByVal numbers As List(Of Double)) As Double
        Dim sumValue As Double = 0
        For Each num In numbers
            sumValue += num
        Next
        Return sumValue
    End Function

    Function Average(ByVal numbers As List(Of Double)) As Double
        Dim avg As Double
        avg = Sum(numbers) / TotalCount(numbers)
        Return avg
    End Function


    Function Largest(ByVal numbers As List(Of Double)) As Double
        Dim lgNum As Integer = numbers(0)
        For Each num In numbers
            If lgNum < num Then
                lgNum = num
            End If
        Next
        Return lgNum
    End Function

    Function Smallest(ByVal numbers As List(Of Double)) As Double
        Dim lgNum As Integer = numbers(0)
        For Each num In numbers
            If lgNum > num Then
                lgNum = num
            End If
        Next
        Return lgNum
    End Function

    Sub Analysis(ByVal numbers As List(Of Double))
        Dim oddCount, evenCount As Integer

        For Each num In numbers
            If num Mod 2 = 0 Then
                evenCount += 1
            Else
                oddCount += 1
            End If
        Next

        Console.WriteLine("Analysis...")
        Console.WriteLine($"There are {evenCount} even numbers and {oddCount} odd numbers provided.")

    End Sub

    Function GetInputs() As List(Of Double)
        Dim nums As New List(Of Double)

        Console.WriteLine("Program accept only real number. Eg: 3.2, 4, -49.092")
        Console.WriteLine()

        Dim counter = 1
        Dim num As Double = 0
        Dim response As String

        While True
            Console.Write($"{counter}. Input a number or type 'Exit' to stop: ")
            response = Console.ReadLine()
            If response.Trim.ToLower.Equals("exit") Then
                Console.WriteLine("Program Exited!")
                Exit While
            ElseIf response.Trim.Equals("") Then
                Console.WriteLine("Invalid Input! No Input Recieved.")
                Continue While
            ElseIf Double.TryParse(response, num) Then
                nums.Add(num)
                counter += 1
            Else
                Console.WriteLine($"Invalid Input ({response})! Enter a Real Number.")
            End If
        End While

        Console.WriteLine()

        Return nums
    End Function
End Module
