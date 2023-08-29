Option Explicit On
Option Strict On

Module SayMyName

    Sub Main()
        Dim name As String
        Console.WriteLine("Hello, What is your name?")
        name = Console.ReadLine()
        Console.WriteLine($"Hello, {name}")
        Console.Read()

    End Sub

End Module
