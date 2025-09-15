Imports System

Module Program
    Sub Main()
        Dim Nota1 As Single
        Dim Nota2 As Single
        Dim Nota3 As Single
        Dim Suma As Single
        Dim Promedio As Single

        Console.WriteLine("Introduzca la primera nota:")
        Nota1 = Console.ReadLine()
        Console.WriteLine("Introduzca la segunda nota:")
        Nota2 = Console.ReadLine()
        Console.WriteLine("Introduzca la tercera nota:")
        Nota3 = Console.ReadLine()

        Suma = Nota1 + Nota2 + Nota3
        Promedio = Suma / 3

        Console.WriteLine("La suma de todas las notas es:")
        Console.Write(Suma)
        Console.ReadLine()

        Console.WriteLine("El promedio de todas las notas es:")
        Console.Write(Promedio)
        Console.ReadLine()

        If Promedio >= 7 <= 10 Then
            Console.WriteLine("Promovido")
            Console.ReadLine()
            Console.Write(Promedio)
            Console.ReadLine()
            Exit Sub

        End If

        If Promedio >= 4 < 7 Then
            Console.WriteLine("Regular")
            Console.ReadLine()
            Console.Write(Promedio)
            Console.ReadLine()
            Exit Sub

        End If

        If Promedio < 4 Then
            Console.WriteLine("Reprovado")
            Console.ReadLine()
            Console.Write(Promedio)
            Console.ReadLine()
            Exit Sub

        End If
        Console.ReadKey()

    End Sub
End Module
