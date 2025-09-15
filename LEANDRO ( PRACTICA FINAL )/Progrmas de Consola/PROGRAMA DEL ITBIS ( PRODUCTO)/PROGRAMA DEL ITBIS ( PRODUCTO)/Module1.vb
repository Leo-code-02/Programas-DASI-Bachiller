Module Module1

    Sub Main()
        Const ITBIS As Double = 0.18
        Console.WriteLine(" Escribe el  valor del producto ")
        Dim producto As Double = Console.ReadLine
        Console.WriteLine(" El ITBIS de producto es: " & producto * ITBIS & "Pesos dominicanos. El valor final es " & producto + (producto * ITBIS) & "PESOS")
        Console.WriteLine("¿Que producto es?")
        Dim Nombre As String = Console.ReadLine
        Console.WriteLine("Este es el calculo del producto")
        Dim animo As String = Console.ReadLine
        Console.WriteLine("OK, solo era para cofirmamr")
        Dim opinion As String = Console.ReadLine
        Console.WriteLine("Bueno gracias, mucho gusto bye :) ")
        Dim BYE As String = Console.ReadLine
        Console.ReadLine()

    End Sub

End Module
