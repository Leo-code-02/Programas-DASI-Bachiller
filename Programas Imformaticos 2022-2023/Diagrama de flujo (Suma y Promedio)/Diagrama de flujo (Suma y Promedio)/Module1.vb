Module Module1

    Sub Main()
        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim Num3 As Integer
        Dim Num4 As Integer
        Dim suma As Integer
        Dim promedio As Single
        Console.Write("Ingrese el primer numero:")
        Num1 = Console.ReadLine()
        Console.Write("Ingrese el sengundo numero:")
        Num2 = Console.ReadLine()
        Console.Write("Ingrese el tercer numero:")
        Num3 = Console.ReadLine()
        Console.Write("Ingrese el cuarto numero:")
        Num4 = Console.ReadLine()
        suma = Num1 + Num2 + Num3 + Num4
        promedio = suma / 4
        Console.ReadLine()
        Console.WriteLine("La Sumatoria de todos los numeros es:")
        Console.WriteLine(suma)
        Console.Write("El promedio de todos los Numeros es:")
        Console.WriteLine(promedio)
        Console.ReadLine()
        Console.ReadKey()
    End Sub

End Module
