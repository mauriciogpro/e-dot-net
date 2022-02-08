Module Module1

    Sub Main()
        Dim Nota1 As Integer
        Dim Nota2 As Integer
        Dim Tp As Integer
        Dim Resultado As Integer

        Console.WriteLine("Introduzca la nota 1")
        Nota1 = Console.ReadLine()
        Console.WriteLine("Introduzca la nota 2")
        Nota2 = Console.ReadLine()
        Console.WriteLine("Introduzca la nota del Trabajo practico")
        Tp = Console.ReadLine()
        Resultado = (Nota1 + Nota2 + Tp)/3
        Console.WriteLine("El promedio es: " & Resultado)

        Console.ReadLine()
    End Sub

End Module
