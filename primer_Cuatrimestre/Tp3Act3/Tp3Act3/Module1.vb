Module Module1

    Sub Main()
        Dim Name As String
        Dim BirthD As DateTime
        Dim TDays As TimeSpan
        Dim Now As DateTime
        Dim Age As Integer

        Console.WriteLine("Escriba su nombre")

        Name = Console.ReadLine()
        Console.WriteLine("Escriba su fecha de nacimiento en el siguien formato XX/XX/XXXX")

        BirthD = Console.ReadLine()
        Now = DateTime.Now
        TDays = Now - BirthD
        Age = TDays.Days / 365


        Console.WriteLine(Name & " tiene la edad de " & Age & " años")

        Console.ReadLine()




    End Sub

End Module
