Public Module QuestionData
    Public Function GetQuestions() As List(Of Question)
        Return New List(Of Question) From {
            New Question(
                "What does OOP stand for?",
                New Dictionary(Of Char, String) From {
                    {"A"c, "Object Oriented Programming"},
                    {"B"c, "Operational Output Process"},
                    {"C"c, "Object Optimized Protocol"},
                    {"D"c, "Ordered Object Procedure"}
                },
                "A"c
            ),
            New Question(
                "Which keyword defines a class?",
                New Dictionary(Of Char, String) From {
                    {"A"c, "Structure"},
                    {"B"c, "Class"},
                    {"C"c, "Module"},
                    {"D"c, "Object"}
                },
                "B"c
            ),
            New Question(
                "Which loop always runs at least once?",
                New Dictionary(Of Char, String) From {
                    {"A"c, "For"},
                    {"B"c, "While"},
                    {"C"c, "Do While"},
                    {"D"c, "Do Loop Until"}
                },
                "D"c
            ),
            New Question(
                "Which data type stores decimal numbers?",
                New Dictionary(Of Char, String) From {
                    {"A"c, "Integer"},
                    {"B"c, "Boolean"},
                    {"C"c, "Double"},
                    {"D"c, "Char"}
                },
                "C"c
            ),
            New Question(
                "Dividing by zero causes:",
                New Dictionary(Of Char, String) From {
                    {"A"c, "Compile error"},
                    {"B"c, "Runtime exception"},
                    {"C"c, "Returns 0"},
                    {"D"c, "Warning only"}
                },
                "B"c
            ),
            New Question(
                "Which keyword exits a loop immediately?",
                New Dictionary(Of Char, String) From {
                    {"A"c, "Stop"},
                    {"B"c, "Exit"},
                    {"C"c, "Break"},
                    {"D"c, "Continue"}
                },
                "B"c
            ),
            New Question(
                "What is the default value of Boolean?",
                New Dictionary(Of Char, String) From {
                    {"A"c, "True"},
                    {"B"c, "False"},
                    {"C"c, "Nothing"},
                    {"D"c, "0"}
                },
                "B"c
            ),
            New Question(
                "Which symbol concatenates strings?",
                New Dictionary(Of Char, String) From {
                    {"A"c, "+"},
                    {"B"c, "&"},
                    {"C"c, "*"},
                    {"D"c, "&&"}
                },
                "B"c
            ),
            New Question(
                "Which access modifier makes members visible only inside the class?",
                New Dictionary(Of Char, String) From {
                    {"A"c, "Public"},
                    {"B"c, "Protected"},
                    {"C"c, "Friend"},
                    {"D"c, "Private"}
                },
                "D"c
            ),
            New Question(
                "What does Dim mean?",
                New Dictionary(Of Char, String) From {
                    {"A"c, "Define Memory"},
                    {"B"c, "Declare Variable"},
                    {"C"c, "Delete Instance Memory"},
                    {"D"c, "Dynamic Instance Mode"}
                },
                "B"c
            ),
            New Question(
                "Which keyword handles exceptions?",
                New Dictionary(Of Char, String) From {
                    {"A"c, "Catch"},
                    {"B"c, "Handle"},
                    {"C"c, "Try"},
                    {"D"c, "Throw"}
                },
                "C"c
            ),
            New Question(
                "Which statement is used for multiple condition checks?",
                New Dictionary(Of Char, String) From {
                    {"A"c, "If"},
                    {"B"c, "Select Case"},
                    {"C"c, "Switch"},
                    {"D"c, "Loop"}
                },
                "B"c
            ),
            New Question(
                "Arrays in VB.NET are:",
                New Dictionary(Of Char, String) From {
                    {"A"c, "Dynamic only"},
                    {"B"c, "Fixed size by default"},
                    {"C"c, "Unlimited"},
                    {"D"c, "Text only"}
                },
                "B"c
            ),
            New Question(
                "Which keyword prevents inheritance?",
                New Dictionary(Of Char, String) From {
                    {"A"c, "NotInheritable"},
                    {"B"c, "Sealed"},
                    {"C"c, "Static"},
                    {"D"c, "Locked"}
                },
                "A"c
            ),
            New Question(
                "What does ByRef do?",
                New Dictionary(Of Char, String) From {
                    {"A"c, "Passes copy"},
                    {"B"c, "Passes reference"},
                    {"C"c, "Blocks variable"},
                    {"D"c, "Converts type"}
                },
                "B"c
            ),
            New Question(
                "Which collection allows dynamic sizing?",
                New Dictionary(Of Char, String) From {
                    {"A"c, "Array"},
                    {"B"c, "List(Of T)"},
                    {"C"c, "Structure"},
                    {"D"c, "Enum"}
                },
                "B"c
            ),
            New Question(
                "Which operator checks equality?",
                New Dictionary(Of Char, String) From {
                    {"A"c, "=="},
                    {"B"c, "="},
                    {"C"c, "==="},
                    {"D"c, "<>"}
                },
                "B"c
            ),
            New Question(
                "What is Nothing?",
                New Dictionary(Of Char, String) From {
                    {"A"c, "Zero"},
                    {"B"c, "Empty string"},
                    {"C"c, "Null reference"},
                    {"D"c, "False"}
                },
                "C"c
            ),
            New Question(
                "Which keyword creates an object instance?",
                New Dictionary(Of Char, String) From {
                    {"A"c, "Create"},
                    {"B"c, "Build"},
                    {"C"c, "New"},
                    {"D"c, "Init"}
                },
                "C"c
            ),
            New Question(
                "Which statement skips to next loop iteration?",
                New Dictionary(Of Char, String) From {
                    {"A"c, "Exit"},
                    {"B"c, "Continue"},
                    {"C"c, "Skip"},
                    {"D"c, "Pass"}
                },
                "B"c
            )
        }
    End Function
End Module