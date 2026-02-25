Option Strict On
Imports System
Module Program
    Sub Main()

        'AddTwoNumbers()


        'Substraction()

        Dim n1, n2 As Double

        n1 = 2.5
        n2 = 40D


        Double.TryParse(Console.ReadLine(), n1)
        Double.TryParse(Console.ReadLine(), n2)

        Console.WriteLine(n2)
        Console.WriteLine(n1)






        'AddT(n1, n2)

    End Sub

    Sub AddTwoNumbers()
        Dim x, y, z As Double

        Console.WriteLine("Enter number: ")

        x = CDbl(Console.ReadLine())
        'Implicit conversion

        y = CDbl(Console.ReadLine())

        z = x + y

        Console.WriteLine(z)
    End Sub

    Sub Substraction()
        Dim x, y, z As Double

        Console.WriteLine("Enter number: ")

        x = CDbl(Console.ReadLine())
        'Implicit conversion

        y = CDbl(Console.ReadLine())


        z = x - y

        Console.WriteLine(z)
    End Sub

    Sub AddT(ByVal n1 As Double, ByVal n2 As Double)
        Console.WriteLine(n1 + n2)
    End Sub
End Module


