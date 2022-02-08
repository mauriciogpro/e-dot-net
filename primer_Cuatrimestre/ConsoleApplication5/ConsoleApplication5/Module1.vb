Module Module1

    Sub Main()
        Dim Name As String
        Dim BirthD As Date
        Dim Today As Date = Today
        Dim Age As Integer

        Console.Write("Nombre de la Persona")
        Name = Console.ReadLine()
        Console.Write("Fecha de Nacimiento")
        BirthD = Console.ReadLine()

        Age = Today.Year - BirthD.Year
        Console.Write(Name & " tiene la edad de" & Age & "años")
        Console.Read()

    End Sub

End Module
