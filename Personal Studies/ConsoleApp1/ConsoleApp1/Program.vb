Imports System

Module Program
    Sub Main(args As String())
        Dim x(5) As Integer

        For i As Integer = 0 To x.Length - 1
            Console.WriteLine("Enter the numbere")
            x(i) = (Int(Console.ReadLine))
        Next
    End Sub
End Module
