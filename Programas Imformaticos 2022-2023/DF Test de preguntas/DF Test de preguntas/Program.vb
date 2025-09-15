Imports System

Module Program
    Sub Main()

        Dim PR As Single
        Dim PRC As Single
        Dim Porcentaje As Single


        Console.WriteLine("Escriba el numero de preguntas realizadas:")
        PR = Console.ReadLine()
        Console.WriteLine("Escriba el numero de preguntas respondidas correctamente:")
        PRC = Console.ReadLine()

        Porcentaje = PRC * PR / 100

        If Porcentaje >= 90% Then
            Console.Write("Nivel Maximo:")
            Console.Write(Porcentaje)
            Console.ReadLine()
            Exit Sub
        End If

        If Porcentaje >= 75% < 90% Then
            Console.Write("Nivel Medio:")
            Console.Write(Porcentaje)
            Console.ReadLine()
            Exit Sub
        End If

        If Porcentaje >= 50% < 75% Then
            Console.Write("Nivel Regular:")
            Console.Write(Porcentaje)
            Console.ReadLine()
            Exit Sub
        End If

        If Porcentaje < 50% Then
            Console.Write("Fuera de Nivel:")
            Console.Write(Porcentaje)
            Console.ReadLine()
            Exit Sub
        End If

        Console.ReadKey()



    End Sub
End Module
