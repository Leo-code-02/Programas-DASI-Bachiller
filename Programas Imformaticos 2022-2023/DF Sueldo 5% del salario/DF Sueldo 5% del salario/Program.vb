Imports System

Module Program
    Sub Main()
        Dim sueldo As Single
        Dim Resultado As Integer
        Console.Write("Ingrese el sueldo del empleado:")
        sueldo = Console.ReadLine()
        If sueldo > 10000 Then
            Resultado = sueldo * 5 / 100
            Console.Write("El impuesto total de " & Resultado & " pesos")
            Console.ReadLine()
        End If

        Console.ReadKey()


    End Sub
End Module
