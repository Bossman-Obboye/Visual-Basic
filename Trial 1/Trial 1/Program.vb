Option Strict On
Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.Text

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

    Sub Main(args As String())


        Dim numbers(4) As Integer



        'If letter = input Then
        '    Console.WriteLine("Error")
        'End If

        While True
            Console.WriteLine("Enter 5 Numbers: ")
            Dim input As String = Console.ReadLine()

            Dim num As Integer
            If Integer.TryParse(input, num) Then
                numbers(4) = num
                Exit While
            Else
                Console.WriteLine("Input Error! Enter an Ingeter Only")

            End If
        End While

        For i = 0 To 4


            ''Console.Write($"{i + 1}. ")
            numbers(i) = Convert.ToInt32(Console.ReadLine())

        Next


        Dim asc(4) As Integer
        Dim dsc(4) As Integer
        Array.Copy(numbers, asc, 5)

        For i = 0 To 4
            For a = 0 To 4 - 1
                If asc(a) > asc(a + 1) Then
                    Dim temp = asc(a + 1)
                    asc(a + 1) = asc(a)
                    asc(a) = temp
                End If
            Next

        Next

        Console.WriteLine("In Ascending Order: ")
        For i = 0 To 4
            Console.Write($"{asc(i)} ")
        Next

        Console.WriteLine("In Descending Order: ")
        For j = 4 To 0 Step -1
            Console.Write($"{asc(j)} ")
        Next

        ''Diaplaying the largest Number
        Console.WriteLine($"largest Number: {(asc.Last)}")

        ''Display smallest
        Console.WriteLine($"Smallest Number: {asc.First}")

        '' Displaying mean


        Dim mean As Double
        Dim sum As Double = 0
        Dim n As Double = 5
        For i = 0 To 4
            sum += numbers(i)
        Next

        mean = sum / n
        '   mean = sum

        Console.WriteLine("Mean is " & mean)


        'Displaying Median
        Console.WriteLine("Median is " & asc(2))


        'Displaying Even Numbers
        Console.Write("Even numbers: ")
        For i = 0 To 4
            If asc(i) Mod 2 = 0 Then
                Console.Write(asc(i) & " ")
            End If
        Next

        'Displaying Odd Numbers
        Console.Write("Odd numbers: ")
        For i = 0 To 4
            If asc(i) Mod 2 = 1 Then
                Console.Write(asc(i) & " ")
            End If
        Next

        'Displaying Odd Numbers
        Console.Write("Odd numbers: ")
        For i = 0 To 4
            If numbers(i) Mod 2 = 1 Then
                Console.WriteLine(numbers(i) & " At position " & i)
            End If
        Next


        'Dim dsc(4) As Integer



        'Console.WriteLine("In descending Order: ")
        'For i = 4 To 4 - 1
        '    Console.Write($"{asc(i)} ")
        'Next
        'For i = 4 To 4 - 1
        '    Console.Write($"{asc(i)} ")
        'Next
        'Dim numbers(4) As Integer

        'Console.WriteLine("Enter five numbers: ")
        'For i = 0 To 4
        '    Console.Write($"{i + 1}. ")
        '    numbers(i) = CInt(Console.ReadLine())
        'Next


        ''Sort Numbers in ascending order
        'Dim asc(4) As Integer
        'Array.Copy(numbers, asc, 5)

        'For b = 1 To asc.Length - 1
        '    Dim key As Integer = asc(b)
        '    Dim a As Integer = b - 1

        '    While a >= 0 AndAlso asc(a) > key
        '        asc(a + 1) = asc(a)
        '        a -= 1
        '    End While

        '    asc(a + 1) = key

        'Next

        'Console.WriteLine()

        'Console.WriteLine("Numbers In Ascending Order:")
        'For i = 0 To asc.Length - 1
        '    Console.Write($"{asc(i)} ")
        'Next


        '''''''Dim numbers(9) As Integer
        '''''''Dim i As Integer

        ''''''''Receive 10 integers
        '''''''For i = 0 To 9
        '''''''    Console.Write($"Enter number {i + 1}. ")
        '''''''    numbers(i) = Convert.ToInt32(Console.ReadLine())
        '''''''Next



        ''''''''a. Ascending order (Bubble Sort)
        '''''''Dim asc(9) As Integer
        '''''''Array.Copy(numbers, asc, 10)

        '''''''For i = 0 To 8
        '''''''    For j As Integer = 0 To 8 - i
        '''''''        If asc(j) > asc(j + 1) Then
        '''''''            Dim temp = asc(j)
        '''''''            asc(j) = asc(j + 1)
        '''''''            asc(j + 1) = temp
        '''''''        End If
        '''''''    Next
        '''''''Next

        '''''''Console.WriteLine("Ascending Order: ")
        '''''''For i = 0 To 9
        '''''''    Console.Write(asc(i) & " ")
        '''''''Next
        ''''


        'Dim num(4) As Integer
        'Dim odd As Integer
        'Dim even As Integer




        ''' To allow a user to input 10 integer digits

        'Console.WriteLine("Input 5 digits: ")

        'For i = 0 To 4
        '    ''Console.Write({i + 1})
        '    num(i) = Convert.ToInt32(Console.ReadLine())

        'Next

        '''' for dis playing the entered Numbers
        ''Console.WriteLine("You Entered: ")
        ''For i = 0 To 4
        ''    Console.Write(num(i))
        ''Next

        ''' Displaying Entered Numbers in Ascending order

        'Dim ascend(4) As Integer
        'Array.Copy(num, ascend, 5)
        'For i = 0 To 3
        '    For a As Integer = 0 To 3 - 1
        '        If ascend(a) > ascend(a + 1) Then
        '            Dim ascend_numbers = ascend(a)
        '            ascend(a) = ascend(a + 1)
        '            ascend(a + 1) = ascend_numbers
        '        End If
        '    Next
        'Next

        'Console.WriteLine(" In Ascending order: ")
        'For i = 0 To 4
        '    Console.WriteLine(ascend(i))
        'Next

        '''a. Ascending order (Bubble Sort)
        ''Dim asc(4) As Integer
        ''Array.Copy(num, asc, 5)

        ''For i = 0 To 3
        ''    For j As Integer = 0 To 3 - i
        ''        If asc(j) > asc(j + 1) Then
        ''            Dim temp = asc(j)
        ''            asc(j) = asc(j + 1)
        ''            asc(j + 1) = temp
        ''        End If
        ''    Next
        ''Next

        ''Console.WriteLine(" In Ascending order: ")
        ''For i = 0 To 4
        ''    Console.WriteLine(asc(i))
        ''Next

        ''' Diaplaying the Input in Descending other

        ''Dim descend(4) As Integer
        ''For i = 0 To 4
        ''    For d = 0 To 4
        ''        If descend(d) < descend(d + 1) Then
        ''            Dim descend_number = descend(d)
        ''            descend(d) = descend(d + 1)
        ''            descend(1 + d) = descend_number
        ''        End If
        ''    Next
        ''Next

        ''''Displaying the Entered Input as decending numbers
        ''Console.WriteLine("In Descending: ")
        ''For i = 0 To 4
        ''    Console.WriteLine(descend(i))
        ''Next




    End Sub
End Module


