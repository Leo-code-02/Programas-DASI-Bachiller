Module Module1

    Sub Main()
        Const ITBIS As Double = 0.18
        Console.WriteLine(" Escribe el valor del producto ")
        Dim producto As Double = Console.ReadLine
        Console.WriteLine(" El ITBIS de producto es: " & producto * ITBIS & "Pesos dominicanos. El valor final es " & producto + (producto * ITBIS) & "PESOS")
        Console.ReadLine()


    End Sub

End Module
