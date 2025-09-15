Module Module1

    Sub Main()
        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim suma As Integer
        Dim producto As Integer

        Console.Write("Indrese el Primer valor:")
        Num1 = Console.ReadLine()
        Console.Write("Ingrese el segundo Valor:")
        Num2 = Console.ReadLine()
        suma = Num1 + Num2
        producto = Num1 * Num2
        Console.Write("La suma de los valores es:")
        Console.WriteLine(suma)
        Console.Write("El Producto de los valores es:")
        Console.WriteLine(producto)
        Console.ReadKey()

    End Sub

End Module
