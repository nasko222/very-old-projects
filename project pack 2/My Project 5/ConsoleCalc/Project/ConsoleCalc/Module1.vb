Module Module1
    Sub Main()
        Console.Title = "ConsoleCalc"
        Dim a As String
        Dim b As String
        Dim op As String
        Dim result As Double
B1:
        Console.WriteLine("First number")
        a = Console.ReadLine
        If Not IsNumeric(a) Then
            Console.WriteLine("Error!")
            GoTo B1
        End If
B2:
        Console.WriteLine("Operation? 1=Addition 2=Subtraction 3=Multiplication 4=Division")
        op = Console.ReadLine
        If IsNumeric(op) Then
            If op = 1 Or op = 2 Or op = 3 Or op = 4 Then
            Else
                Console.WriteLine("Error!")
                GoTo B2
            End If
        Else
            Console.WriteLine("Error!")
            GoTo B2
        End If
B3:
        Console.WriteLine("Second number")
        b = Console.ReadLine
        If Not IsNumeric(b) Then
            Console.WriteLine("Error!")
            GoTo B3
        End If
        If op = 1 Then
            result = a + b
        End If
        If op = 2 Then
            result = a - b
        End If
        If op = 3 Then
            result = a * b
        End If
        If op = 4 Then
            result = a / b
        End If
        Console.WriteLine(result)
        Console.WriteLine("Press any key to continue...")
        Console.ReadKey(ConsoleKey.Enter)
        GoTo B1
    End Sub
End Module
