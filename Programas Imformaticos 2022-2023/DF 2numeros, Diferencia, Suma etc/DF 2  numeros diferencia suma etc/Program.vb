Imports System

Module Program
    Sub Main()

        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim Suma As Integer
        Dim Diferencia As Integer
        Dim Multiplicacion As Integer
        Dim Division As Integer

        Console.Write("Introduzca el primer numero:")
        Num1 = Console.ReadLine()
        Console.Write("Introduzca el Segundo numero:")
        Num2 = Console.ReadLine()

        Suma = Num1 + Num2
        Diferencia = Num1 - Num2

        Console.WriteLine("La suma de los numeros es:")
        Console.Write(Suma)
        Console.ReadLine()
        Console.WriteLine("La diferencia de los numeros es:")
        Console.Write(Diferencia)
        Console.ReadLine()

        If Num1 > Num2 Then
            Exit Sub
        End If

        Multiplicacion = Num1 * Num2
        Division = Num1 / Num2

        Console.WriteLine("La multiplicacion de los numeros es:")
        Console.Write(Multiplicacion)
        Console.ReadLine()
        Console.WriteLine("La division de los numeros es:")
        Console.Write(Division)
        Console.ReadLine()

        If Num2 > Num1 Then
            Exit Sub
        End If

        Console.ReadKey()

    End Sub
End Module
