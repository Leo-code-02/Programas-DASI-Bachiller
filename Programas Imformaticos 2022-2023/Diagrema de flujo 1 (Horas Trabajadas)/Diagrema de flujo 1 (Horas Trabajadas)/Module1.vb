Module Module1

    Sub Main()
        Dim HorasTrabajadas As Integer
        Dim CostoHora As Single
        Dim Sueldo As Single

        Console.Write("Ingrese Horas trabajadas por el operario:")
        HorasTrabajadas = Console.ReadLine()
        Console.Write("Ingrese pago por hora:")
        CostoHora = Console.ReadLine()
        Sueldo = HorasTrabajadas * CostoHora
        Console.Write("El Sueldo totel del operario es:")
        Console.Write(Sueldo)
        Console.ReadKey()
    End Sub

End Module
