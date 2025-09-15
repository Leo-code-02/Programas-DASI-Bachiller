Module Module1

    Sub Main()
        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim Num3 As Integer
        Dim Num4 As Integer
        Dim suma As Integer
        Dim producto As Integer
        Console.Write("Indrese el Primer valor:")
        Num1 = Console.ReadLine()
        Console.Write("Ingrese el segundo Valor:")
        Num2 = Console.ReadLine()
        suma = Num1 + Num2
        Console.Write("Ingrese el tercer valor:")
        Num3 = Console.ReadLine()
        Console.Write("ingrese el cuarto valor:")
        Num4 = Console.ReadLine()
        producto = Num3 * Num4
        Console.Write("La suma de los dos primeros es:")
        Console.WriteLine(suma)
        Console.Write("El Producto del tercer y el cuarto es:")
        Console.WriteLine(producto)
        Console.ReadKey()
    End Sub

End Module
