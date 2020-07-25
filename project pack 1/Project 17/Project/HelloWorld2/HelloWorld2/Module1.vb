Module Module1
    Sub Main()
        Console.Title = "Hello World"
        Console.WriteLine("Hello")
        Console.ReadLine()
        Console.WriteLine("Enter Your Name")
back1:
        Dim a As String
        a = Nothing
        a = Console.ReadLine
        If a = Nothing Then
            Console.WriteLine("Please enter your name")
            GoTo back1
        Else
            Console.WriteLine("Hello " + a)
        End If
        Console.WriteLine("How old are you?")
back2:
        Dim b As String
        b = Nothing
        b = Console.ReadLine
        If b = Nothing Then
            Console.WriteLine("Please enter your age")
            GoTo back2
        ElseIf IsNumeric(b) Then
            Console.WriteLine("Ok " + a + ". You are " + b + " years old")
        ElseIf Not IsNumeric(b) Then
            Console.WriteLine("Only numbers Please")
            GoTo back2
        End If
        Console.WriteLine("How are you today?")
        Console.ReadLine()
        MsgBox("Here's your information", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Hello World")
        MsgBox("Your name is " + a, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Hello World")
        MsgBox("You are " + b + " years old", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Hello World")
        MsgBox("Hello World 2.0 in Console by nasko222", MsgBoxStyle.Exclamation, "6estica")
        Call Advanced()
    End Sub

    Sub Advanced()
        Console.WriteLine("Hello World, Advanced Settings Loading")
1:
        Dim a As Double
        a = Nothing
        a = Rnd()
        a = a * 10000
        Console.WriteLine(Int(a))
        GoTo 1
    End Sub
End Module