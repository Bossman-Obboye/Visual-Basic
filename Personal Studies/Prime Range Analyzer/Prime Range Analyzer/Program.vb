Imports System

Module Program
    Sub Main(args As String())
        Greetings()

        Console.WriteLine("Prime Range Analyzer")

        GetRange()

        Dim nums(2) As Integer



    End Sub

    Sub Greetings()
        Console.WriteLine("Welcome to Nxt-Tech Program")
        Console.WriteLine("Loading...")
        Console.WriteLine()
    End Sub

    Function GetRange() As Integer()
        Dim min As Integer = 0
        Dim max As Integer = 1

        While True

            If min >= max Then
                Console.WriteLine($"Invalid Constraints! Minimum value({min}) cannot be greater or equal to maximum value({max}.")
            Else
                Console.Write("Please enter the minimum number of the range: ")
                Dim input1 As String = Console.ReadLine()


                While True
                    If Integer.TryParse(input1, min) Then
                        Console.WriteLine($"Selected range minimum is {min}")
                        Exit While
                    End If

                    Console.WriteLine($"Invalid input! Please enter a number(digits only)")
                End While



                Console.Write("Please enter the maximum number of the range: ")
                Dim input2 As String = Console.ReadLine()


                While True
                    If Integer.TryParse(input2, max) Then
                        Console.WriteLine($"Selected range maximum is {max}")
                        Exit While
                    End If
                    Console.WriteLine($"Invalid input! Please enter a number(digits only)")
                End While

                Exit While
            End If


        End While


        Return


    End Function
End Module
