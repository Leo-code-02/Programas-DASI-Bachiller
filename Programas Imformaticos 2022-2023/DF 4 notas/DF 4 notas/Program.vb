Imports System

Module Program
    Sub Main()
        Dim num1 As Integer
        Dim num2 As Integer
        Dim num3 As Integer
        Dim num4 As Integer
        Dim Suma As Integer
        Dim Promedio As Integer

        Console.WriteLine("Ingrese la primera nota:")
        num1 = Console.ReadLine()
        Console.WriteLine("Ingrese la segunda nota:")
        num2 = Console.ReadLine()
        Console.WriteLine("Ingrese la tercera nota:")
        num3 = Console.ReadLine()
        Console.WriteLine("Ingrese la cuarta nota:")
        num4 = Console.ReadLine()
        Console.WriteLine("La suma de todos los numeros es:")
        Suma = num1 + num2 + num3 + num4
        Promedio = Suma / 4
        Console.Write(Suma)
        Console.ReadLine()
        Console.WriteLine("El promedio es:")
        Console.Write(Promedio)
        Console.ReadLine()

        If Promedio >= 70 Then
            Console.WriteLine("Promovido")
            Console.ReadLine()
        End If

        If Promedio < 70 Then
            Console.WriteLine("Reprovado")
            Console.ReadLine()

        End If
        Console.ReadKey()
    End Sub
End Module
