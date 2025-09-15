Imports System

Module Program
    Sub Main()
        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim Num3 As Integer

        Console.WriteLine("Ingrese el primer valor:")
        Num1 = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo valor:")
        Num2 = Console.ReadLine()
        Console.WriteLine("Ingrese el tercer valor:")
        Num3 = Console.ReadLine()

        If Num1 > Num2 And Num1 > Num3 Then
            Console.Write(Num1)
        Else
            If Num2 > Num1 And Num2 > Num3 Then
                Console.Write(Num2)
            Else
                If Num3 > Num1 And Num3 > Num2 Then
                    Console.Write(Num3)
                    Exit Sub
                End If
            End If
        End If

        Console.ReadKey()


    End Sub
End Module
