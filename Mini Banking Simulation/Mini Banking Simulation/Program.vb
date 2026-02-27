Imports System

'Menu System

'1. Deposit
'2. Withdraw
'3. Check Balance
'4. Exit

'Rules
'Cannot withdraw more than balance
'Must handle invalid inputs
'Keep running until Exit
'Store transaction history in a List
'At exit print all transactions

Module Program
    Sub Main(args As String())
        Console.WriteLine("----------- NxTech Mini Banking Simulation ----------")
        Console.WriteLine()

        Dim history = ManageTransactions()

        ' Display History
        Console.WriteLine("----- Transaction History -----")
        Console.WriteLine()

        For i = 0 To history.Count - 1
            If (history(i) > 0) Then
                Dim amount As String = history(i).ToString("F2")
                Console.WriteLine($"{i + 1}. You deposited {amount} cedis into your account.")
            Else
                Dim amount As String = (history(i) * -1).ToString("F2")
                Console.WriteLine($"{i + 1}. You withdrew {amount} cedis from your account.")
            End If
        Next

    End Sub

    Function ManageTransactions() As List(Of Double)
        Dim opt As String
        Dim history As New List(Of Double)

        Console.WriteLine("----- Transactions -----")
        Console.WriteLine()

        Do
            DisplayMenus()

            opt = GetChoice()


            Select Case opt
                Case "1"
                    Deposit(history)
                Case "2"
                    Widraw(history)
                Case "3"
                    CheckBalance(history)
                Case Else
                    Console.WriteLine("GoodBye!")
                    Console.WriteLine()
            End Select

        Loop While opt <> "4"

        Return history
    End Function

    Function Deposit(ByVal history As List(Of Double)) As List(Of Double)

        Console.WriteLine("How much are you depositing right now?")
        Dim amount = GetAmount()
        Console.WriteLine("Processing...")
        history.Add(amount)
        Console.WriteLine($"You've successfully deposited {amount} into your account.")
        Console.WriteLine()

        Return history
    End Function

    Function Widraw(ByVal history As List(Of Double)) As List(Of Double)
        Dim balance As Double = 0

        For Each num In history
            balance += num
        Next

        Console.WriteLine("How much are you withdrawing?")

        Dim amount = GetAmount()

        Console.WriteLine("Processing...")

        If balance <= 0 AndAlso balance < amount Then
            Console.WriteLine($"Balance Insufficient!")
        Else
            history.Add(amount * -1)
            Console.WriteLine($"You've successfully withdrawn {amount} from your account.")
        End If
        Console.WriteLine()

        Return history
    End Function

    Sub CheckBalance(ByVal history As List(Of Double))
        Dim balance As Double = 0
        Console.WriteLine("Processing...")
        For Each num In history
            balance += num
        Next
        Console.WriteLine("Your current balance is: " & balance.ToString("F2") & " cedis")
        Console.WriteLine()

    End Sub

    Sub DisplayMenus()
        Console.WriteLine("Welcome Back! What would you like to do")
        Console.WriteLine("1. Deposit")
        Console.WriteLine("2. Withdraw")
        Console.WriteLine("3. Check Balance")
        Console.WriteLine("4. Exit")
        Console.WriteLine()
    End Sub


    Function GetChoice() As String
        Dim response As String

        Do
            Console.Write("Choice: ")
            response = Console.ReadLine().Trim.ToLower

            Select Case response
                Case "1", "2", "3", "4"
                    Console.WriteLine()
                    Return response
                Case ""
                    Console.WriteLine("No Input! Please choose")
                    Console.WriteLine()
                Case Else
                    Console.WriteLine("Invalid choice! Please choose 1, 2, 3, or 4")
                    Console.WriteLine()
            End Select
        Loop While response <> "1" AndAlso response <> "2" AndAlso response <> "3" AndAlso response <> "4"

        Return response
    End Function



    Function GetAmount() As Double
        Dim response As String
        Dim amount As Double
        Do
            Console.Write("Enter Amount(above 0.00 Eg: 323 or 23.08): ")
            response = Console.ReadLine().Trim.ToLower

            If Double.TryParse(response, amount) Then
                If amount <= 0 Then
                    Console.WriteLine("Invalid amount! Amount must be more than 0.00")
                    Console.WriteLine()
                End If
            ElseIf response.Equals("") Then
                Console.WriteLine("Invalid input! No amount recieve. Please enter amount")
                Console.WriteLine()
            Else
                Console.WriteLine($"Invalid input ({response})! Retry ")
                Console.WriteLine()
            End If

        Loop While amount <= 0

        Return response
    End Function


End Module
