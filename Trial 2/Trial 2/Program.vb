Imports System
Imports System.Diagnostics.Metrics
Imports System.Runtime.ConstrainedExecution

Module Program

    'Prime Range Analyzer
    'Ask the user For:
    'Start number
    'End number
    'Print:
    'All prime numbers In that range
    'Total number Of primes found
    'The largest prime In the range
    'No built-In prime helpers. Write your own logic.
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim range As Integer() = GetRange()

        Dim primes = GetPrimeFromRange(range)

        PrintTenNumsPerRow(primes)


    End Sub

    Function IsPrime(ByVal num As Integer) As Boolean
        Dim flag As Boolean = True

        Dim divider = 2
        While True
            If num Mod divider = 0 Then
                flag = False
                Exit While

            ElseIf divider > num / 2 Then
                Exit While
            Else
                divider += 1
            End If


        End While

        Return flag

    End Function

    Function GetRange() As Integer()
        Dim range(1) As Integer
        Dim input1, input2 As String

        Dim startNum, endNum As Integer

        Console.WriteLine("Enter Range")
        Console.WriteLine("NB: Inputs must be integers")
        Console.WriteLine("NB: Start Number must be less than End Number")

        Console.WriteLine()


        While True
            Console.Write($"Start Number: ")
            input1 = Console.ReadLine()

            Console.Write($"End Number: ")
            input2 = Console.ReadLine()

            If Integer.TryParse(input1, startNum) AndAlso Integer.TryParse(input2, endNum) Then
                If startNum > endNum Then
                    Console.WriteLine("End number must be greater than the start number")
                    Console.WriteLine("Please check and retry")
                    Console.WriteLine()
                Else

                    Console.WriteLine("Inputs are Valid!")
                    Exit While

                End If


            Else
                Console.WriteLine("Invalid Inputs!")
                Console.WriteLine("Please check and retry")
                Console.WriteLine()
            End If
        End While

        Console.WriteLine()

        range(0) = startNum
        range(1) = endNum

        Return range
    End Function

    Function GetPrimeFromRange(ByVal range As Integer()) As List(Of Integer)
        Dim primeNumbers As New List(Of Integer)
        For i = range.First To range.Last
            If IsPrime(i) Then
                primeNumbers.Add(i)
            End If
        Next

        Return primeNumbers
    End Function

    Sub PrintTenNumsPerRow(ByVal numbers As List(Of Integer))
        Dim counter As Integer = 0

        For Each num In numbers
            Console.Write(num & " ")
            counter += 1

            If counter = 10 Then
                Console.WriteLine()
                counter = 0
            End If
        Next
    End Sub
End Module
