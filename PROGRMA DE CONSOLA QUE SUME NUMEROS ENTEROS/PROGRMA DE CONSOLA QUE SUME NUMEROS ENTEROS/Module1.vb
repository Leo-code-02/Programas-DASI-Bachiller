Module Module1

    Sub Main()
        Console.WriteLine("Escribe tu nombre:")
        Dim nombre As String = Convert.ToString(Console.ReadLine)

        Console.WriteLine("Escribe tu primer numero:")
        Dim num1 As Double = Convert.ToDouble(Console.ReadLine)

        Console.WriteLine("Escribe tu segundo numero:")
        Dim num2 As Double = Convert.ToDouble(Console.ReadLine)

        Dim resultado As Double

        resultado = num1 + num2

        Console.WriteLine(" Tu Resultado " + nombre + " es " + num1 + num2 = resultado)

        Console.ReadLine()

    End Sub

End Module
