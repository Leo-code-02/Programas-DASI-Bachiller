Imports System

Module Program
    Sub Main()
        Dim Num1 As Integer

        Console.WriteLine("Ingrese un numero de uno, dos, o tres digitos:")
        Num1 = Console.ReadLine()

        If Num1 < 10 Then
            Console.WriteLine("El numero que ingreso tiene un digito:")
            Console.Write(Num1)
            Console.ReadLine()
            Exit Sub
        End If

        If Num1 < 100 Then
            Console.WriteLine("El numero que ingreso tiene dos digitos:")
            Console.Write(Num1)
            Console.ReadLine()
            Exit Sub
        End If

        If Num1 < 1000 Then
            Console.WriteLine("El numero que ingreso tiene tres digitos:")
            Console.Write(Num1)
            Console.ReadLine()
            Exit Sub
        End If

        If Num1 >= 1000 Then
            Console.WriteLine("Nulo")
            Console.ReadLine()
            Exit Sub
        End If
    End Sub
End Module
