Option Strict On

Public Class Question

    Public Property Text As String
    Public Property Options As Dictionary(Of Char, String)
    Public Property CorrectAnswer As Char

    'Constructor with required parameters
    Public Sub New(questionText As String, options As Dictionary(Of Char, String), correctAnswer As Char)
        Me.Text = questionText
        Me.Options = options
        Me.CorrectAnswer = Char.ToUpper(correctAnswer)
    End Sub

    'Display the question with options
    Public Sub DisplayQuestion(questionNumber As Integer)
        Console.WriteLine($"Question {questionNumber}:")
        Console.WriteLine(Text)
        Console.WriteLine()

        For Each opt In Options
            Console.WriteLine($"{opt.Key}. {opt.Value}")
        Next
        Console.WriteLine()
    End Sub

    Public Function IsCorrectAnwser(answer As Char) As Boolean
        Return Char.ToUpper(answer) = CorrectAnswer
    End Function

    Public Function GetCorrectOptionText() As String
        Return Options(CorrectAnswer)
    End Function
End Class