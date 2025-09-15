Module Module1

    Sub Main()
        Console.WriteLine("Escribe tu nombre")
        Dim nombre As String = Console.ReadLine

        Console.WriteLine("Escribe tus apellidos")
        Dim apeliidos As String = Console.ReadLine

        Console.WriteLine(" ¡Hola " & nombre " " & apeliidos & "!")
        Console.ReadLine()
    End Sub

End Module
