Option Strict On
Imports System

Module NumberFrequencyCounter
    '2️⃣ Number Frequency Counter

    'Accept 20 numbers from the user.
    'Count how many times Each number appears.

    'Example output

    '5 appears 3 times
    '7 appears 2 times

    Sub Main(args As String())
        Console.WriteLine("Nxted Number Frequency Counter Program")
        Console.WriteLine()

        'Getting Inputs
        Dim numbers As Double() = Get20Numbers()

        'Displaying Analysis
        Console.WriteLine("----------- ANALYSIS ------------")
        CountFreq(numbers)

    End Sub

    Private Function GetInput() As Double
        Dim validInput As Double

        Do
            Console.Write("Enter a number: ")
            If Double.TryParse(Console.ReadLine(), validInput) Then
                Console.Clear()
                Return validInput
            End If

            Console.WriteLine("Invalid input. Please enter a valid number.")
        Loop
    End Function

    Private Function Get20Numbers() As Double()
        Dim numbers(19) As Double

        For i As Integer = 0 To 19
            Console.Write($"{i + 1}. ")

            numbers(i) = GetInput()
        Next
        Return numbers
    End Function

    Private Sub CountFreq(numbers As Double())
        Dim freq As New Dictionary(Of Double, Integer)()
        For Each number As Double In numbers
            If freq.ContainsKey(number) Then
                freq(number) += 1
            Else
                freq(number) = 1
            End If
        Next

        For Each kvp As KeyValuePair(Of Double, Integer) In freq
            Console.WriteLine($"{kvp.Key} appears {kvp.Value} times")
        Next
    End Sub

End Module
