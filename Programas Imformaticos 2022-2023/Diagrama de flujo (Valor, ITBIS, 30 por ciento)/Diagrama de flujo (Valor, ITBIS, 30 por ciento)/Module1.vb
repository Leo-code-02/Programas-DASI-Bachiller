Imports System.ComponentModel.Design

Module Module1

    Sub Main()
        Dim Precio As Integer
        Dim Cantidad As Integer
        Dim Valor As Integer
        Dim ITBIS As Integer
        Dim Abono As Integer
        Dim Articulo As String

        Console.Write("Ingrese el Articulo que va a comprar:")
        Articulo = Console.ReadLine()
        Console.Write("Ingrese el Precio del articulo:")
        Precio = Console.ReadLine()
        Console.Write("Ingrese la cantidad de articulos a comprar:")
        Cantidad = Console.ReadLine()
        Valor = Precio * Cantidad
        ITBIS = Valor * 0.18
        Abono = Valor * 30 / 100
        Console.Write("El precio del " & Articulo & " es:")
        Console.WriteLine(Valor)
        Console.Write("El ITBIS del Articulo es:")
        Console.WriteLine(ITBIS)
        Console.Write("El 30% que debe abonar es:")
        Console.WriteLine(Abono)
        Console.WriteLine("Si va a pagar a credito entonces, el precio es:")
        If Valor = Abono Then
            Console.WriteLine(Abono)
        End If
        Console.ReadKey()
    End Sub
End Module
