Module Module1

    Sub Main()
        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim Resultado As Single

        Console.Write("Ingrese el primer numero:")
        Num1 = Console.ReadLine()
        Console.Write("Ingrese el segundo numero:")
        Num2 = Console.ReadLine()
        Resultado = Num1 + Num2
        Console.Write("La suamtoria de los dos numeros es:")
        Console.Write(Resultado)
        Console.ReadKey()

    End Sub

End Module
