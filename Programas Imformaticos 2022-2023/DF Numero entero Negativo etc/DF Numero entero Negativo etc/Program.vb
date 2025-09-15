Imports System

Module Program
    Sub Main()
        Dim Num1 As Double

        Console.WriteLine("Ingrese el Numero:")
        Num1 = Console.ReadLine()

        If Num1 >= 1 Then
            Console.Write("Positivo")
            Console.ReadLine()
            Exit Sub
        End If

        If Num1 < 1 Then
            Console.Write("Negativo")
            Console.ReadLine()
            Exit Sub
        End If

        If Num1 = 0 Then
            Console.Write("Nulo")
            Console.ReadLine()
            Exit Sub
        End If
        Console.ReadKey()


    End Sub
End Module
