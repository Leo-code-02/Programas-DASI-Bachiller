Imports System

Module Program
    Sub Main()
        Dim Num1 As Integer
        Console.WriteLine("Ingrese un numero:")
        Num1 = Console.ReadLine()

        If Num1 < 10 Then
            Console.WriteLine("El numero que ingreso es de un digito:")
            Console.Write(Num1)
            Console.ReadLine()
        End If

        If Num1 >= 10 Then
            Console.WriteLine("El numero que ingreso es de dos digitos:")
            Console.Write(Num1)
            Console.ReadLine()
        End If
        Console.ReadKey()
    End Sub
End Module
