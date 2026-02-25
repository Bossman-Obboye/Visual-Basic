Option Strict On
Imports System

'Create a program  To receive 10 Integer inputs
'a.display the inputs in ascending order 
'b.display in descending order
'c.largest
'd.min
'e.find average
'f.determine even And odd
'g.sum up all the odd numbers And 
'h Sum up all the even numbers
'i.Display the array position of  the odd numbers
'j.If you use ai you  loss you marks.

Module Program

    Sub Main(args As String)

        Dim numbers(9) As Integer
        Dim i As Integer

        'Receive 10 integers
        For i = 0 To 9
            Console.Write($"Enter number {i + 1}. ")
            numbers(i) = Convert.ToInt32(Console.ReadLine())
        Next

        'a. Ascending order (Bubble Sort)
        Dim asc(9) As Integer
        Array.Copy(numbers, asc, 10)

        For i = 0 To 8
            For j As Integer = 0 To 8 - i
                If asc(j) > asc(j + 1) Then
                    Dim temp = asc(j)
                    asc(j) = asc(j + 1)
                    asc(j + 1) = temp
                End If
            Next
        Next

        Console.WriteLine(vbCrLf & "Ascending Order: ")
        For i = 0 To 9
            Console.Write(asc(i) & " ")
        Next


        'Console.WriteLine(vbCrLf & vbCrLf & "Descending Order: ")

    End Sub
End Module