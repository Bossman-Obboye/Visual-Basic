Option Strict On
Imports System


'Array Processing
'Write a program To
'Accept 10 integers into an array
'Display:
'The largest number
'The smallest number
'The average
'The total Of even numbers

Module ArrayProcessing
    Sub Main()

        Dim numbers As Integer() = GetSortedNumbersInAscOrder()
        Console.WriteLine("---------- ANALYSIS --------")
        Console.WriteLine("========================================")
        Console.WriteLine("The largest number among the provided numbers is : " & GetLargest(numbers))
        Console.WriteLine()
        Console.WriteLine("The smallest number in the provided list of numbers is : " & GetSmallest(numbers))
        Console.WriteLine()
        Console.WriteLine("The average of the provided list of numbers is : " & GetAverage(numbers))
        Console.WriteLine()
        Console.WriteLine("The total sum of even numbers is : " & GetEvenTotal(numbers))
        Console.WriteLine("========================================")
        Console.WriteLine("Press Any Key to exit")
        Console.ReadKey()
        Console.WriteLine("GoodBye!")

    End Sub

    Private Function GetValidInput() As Integer
        Dim validResponse As Integer

        Do
            Console.Write("Enter a number: ")

            If Integer.TryParse(Console.ReadLine(), validResponse) Then
                Console.Clear()
                Return validResponse
            End If

            Console.WriteLine("Invalid input! Enter an integer (+/- whole numbers only)")
        Loop
    End Function

    Private Function GetNumbers() As Integer()
        Dim numbers(9) As Integer

        For i = 0 To 9
            Console.Write($"{i + 1}. ")
            numbers(i) = GetValidInput()
        Next

        Return numbers
    End Function

    Private Function GetSortedNumbersInAscOrder() As Integer()

        Dim numbers As Integer() = GetNumbers()

        'Apply Bubble Sorting Method
        For i = 0 To 9
            For j = 0 To 8
                If numbers(j) > numbers(j + 1) Then
                    Dim temp = numbers(j + 1)
                    numbers(j + 1) = numbers(j)
                    numbers(j) = temp
                End If
            Next
        Next

        Return numbers
    End Function

    Private Function GetSmallest(ByVal numbers As Integer()) As Integer
        Return numbers.First
    End Function

    Private Function GetLargest(ByVal numbers As Integer()) As Integer
        Return numbers.Last
    End Function

    Private Function GetAverage(ByVal numbers As Integer()) As Double
        Dim sum As Integer

        For i = 0 To numbers.Length - 1
            sum += numbers(i)
        Next

        Return sum / numbers.Length - 1
    End Function

    Private Function GetEvenTotal(ByVal numbers As Integer()) As Integer
        Dim sum As Integer

        For i = 0 To numbers.Length - 1
            If numbers(i) Mod 2 = 0 Then
                sum += numbers(i)
            End If
        Next

        Return sum
    End Function
End Module
