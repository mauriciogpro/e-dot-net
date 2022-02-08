Module Module1

    Sub Main()
        Dim Rta_Correcta As Single
        Dim Rta_Incorrecta As Single
        Dim Rta_Blanco As Single
        Dim Pje_Total As Single

        Console.WriteLine("Introduzca las cantidad de Rtas del Postulante:")
        Console.Write("Cantidad de Respuestas Correctas:")
        Rta_Correcta = Console.ReadLine()
        Console.Write("Cantidad de Respuestas Incorrectas:")
        Rta_Incorrecta = Console.ReadLine()
        Console.Write("Cantidad de Respuestas en blanco:")
        Rta_Blanco = Console.ReadLine()
        Pje_Total = (Rta_Correcta * 4) + (Rta_Incorrecta * (-1))
        Console.WriteLine("***********************************")
        Console.WriteLine("Puntaje total:" & Pje_Total)
        Console.ReadLine()



    End Sub

End Module
