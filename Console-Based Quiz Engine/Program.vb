Module QuizEngine
    Private questions As List(Of Question)
    Private wrongQuestionIndexes As List(Of Integer)
    Private score As Integer
    Private highestScore As Integer = 0

    Sub Main()
        ' Initialize questions from separate file
        questions = QuestionData.GetQuestions()

        Do
            RunQuiz()
        Loop While AskForRetry()

        Console.WriteLine("Thanks for playing! Press any key to exit.")
        Console.ReadKey()
    End Sub

    ' Run the main quiz
    Private Sub RunQuiz()
        ResetQuiz()
        ' Uncomment next line to shuffle questions
        ' ShuffleQuestions()

        For i As Integer = 0 To questions.Count - 1
            Dim currentQuestion = questions(i)
            Console.Clear()

            ' Display question
            currentQuestion.DisplayQuestion(i + 1)

            ' Get and validate user input
            Dim userAnswer = GetValidAnswer()

            ' Check answer and update score
            If currentQuestion.IsCorrectAnwser(userAnswer) Then
                Console.WriteLine(vbCrLf & "Correct!")
                score += 1
            Else
                Console.WriteLine(vbCrLf & $"Wrong! Correct answer was {currentQuestion.CorrectAnswer}")
                wrongQuestionIndexes.Add(i)
            End If

            Console.WriteLine(vbCrLf & "--------------------------------" & vbCrLf)
            Console.WriteLine("Press any key to continue...")
            Console.ReadKey()
        Next

        ' Show results
        DisplayResults()

        ' Update highest score
        If score > highestScore Then
            highestScore = score
        End If
    End Sub

    ' Reset quiz state
    Private Sub ResetQuiz()
        score = 0
        wrongQuestionIndexes = New List(Of Integer)()
    End Sub

    ' Shuffle questions (optional)
    Private Sub ShuffleQuestions()
        Dim rnd As New Random()
        questions = questions.OrderBy(Function(x) rnd.Next()).ToList()
    End Sub

    ' Get and validate user answer
    Private Function GetValidAnswer() As Char
        Dim input As String
        Dim validAnswers() As Char = {"A"c, "B"c, "C"c, "D"c}

        Do
            Console.Write("Your answer (A-D): ")
            input = Console.ReadLine()?.Trim().ToUpper()

            If String.IsNullOrEmpty(input) OrElse input.Length <> 1 OrElse Not validAnswers.Contains(input(0)) Then
                Console.WriteLine("Invalid input! Please enter A, B, C, or D.")
            Else
                Return input(0)
            End If
        Loop
    End Function

    ' Display final results
    Private Sub DisplayResults()
        Console.Clear()
        Console.WriteLine("Quiz Completed!")
        Console.WriteLine("================")
        Console.WriteLine()

        Dim percentage As Double = (score / questions.Count) * 100
        Dim status As String = If(percentage >= 60, "PASS", "FAIL")

        Console.WriteLine($"Score: {score} / {questions.Count}")
        Console.WriteLine($"Percentage: {percentage:F1}%")
        Console.WriteLine($"Status: {status}")
        Console.WriteLine()

        ' Show wrong questions
        If wrongQuestionIndexes.Count > 0 Then
            Console.WriteLine("Questions you got wrong:")
            For Each index In wrongQuestionIndexes
                Dim q = questions(index)
                Console.WriteLine($"- Question {index + 1}: {q.Text}")
                Console.WriteLine($"  Correct answer was {q.CorrectAnswer}. {q.GetCorrectOptionText()}")
            Next
        Else
            Console.WriteLine("Perfect score! You got all questions right!")
        End If

        ' Show highest score
        Console.WriteLine()
        Console.WriteLine($"Highest score so far: {highestScore} / {questions.Count}")
    End Sub

    ' Ask if user wants to retry
    Private Function AskForRetry() As Boolean
        Console.WriteLine()
        Console.Write("Retry? (Y/N): ")
        Dim response = Console.ReadLine()?.Trim().ToUpper()

        Return response = "Y" OrElse response = "YES"
    End Function
End Module