Imports System

Module Program
    Sub Main()
        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim Num3 As Integer
        Dim Num4 As Integer

        Console.WriteLine("Ingrese el primer numero:")
        Num1 = Console.ReadLine()
        Console.WriteLine("Ingrese el Segundo numero:")
        Num2 = Console.ReadLine()
        Console.WriteLine("Ingrese el Tercer numero:")
        Num3 = Console.ReadLine()
        Console.WriteLine("Ingrese el Cuarto numero:")
        Num4 = Console.ReadLine()

        If Num1 > Num2 And Num1 > Num3 And Num1 > Num4 Then
            Console.Write(Num1)
            Exit Sub
        End If

        If Num2 > Num1 And Num2 > Num3 And Num2 > Num4 Then
            Console.Write(Num2)
            Exit Sub
        End If

        If Num3 > Num1 And Num3 > Num2 And Num3 > Num4 Then
            Console.Write(Num3)
            Exit Sub
        End If

        If Num4 > Num1 And Num4 > Num2 And Num4 > Num3 Then
            Console.Write(Num4)
            Exit Sub
        End If


    End Sub
End Module
