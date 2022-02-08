Module Module1

    Sub Main()

        'Desarrollar un programa que permita El sueldo de los empleado de la Empresa X SA, Para ello de pide 
        'Datos de Entrada
        'Nombre:
        'Cantidad de Hora
        'Cantidad de años de antigüedad
        'Tipo de categoría

        Dim nombre, categoria As String
        Dim cantidad, horas, años, adicional As Integer
        Dim sueldo_n, sueldo_b, antiguedad, descuento As Double

        Console.WriteLine("---------------------------------------------------------")
        Console.WriteLine("Calculadora de sueldo")
        Console.WriteLine("---------------------------------------------------------")
        Console.WriteLine()
        Console.WriteLine("---------------------------------------------------------")
        Console.WriteLine("1. Ingrese su nombre")
        Console.WriteLine("---------------------------------------------------------")
        nombre = Console.ReadLine
        Console.WriteLine("---------------------------------------------------------")
        Console.WriteLine("2. Ingrese la cantidad de horas")
        Console.WriteLine("---------------------------------------------------------")
        cantidad = Console.ReadLine
        Console.WriteLine("---------------------------------------------------------")
        Console.WriteLine("3. Ingrese la cantidad de años trabajado")
        Console.WriteLine("---------------------------------------------------------")
        años = Console.ReadLine
        Console.WriteLine("---------------------------------------------------------")
        Console.WriteLine("4. Ingrese la categoria con la letra correspondiente (J)efe, (A)dministrativo, (T)ecnico, (O)perario")
        Console.WriteLine("---------------------------------------------------------")
        categoria = Console.ReadLine.ToUpper


        Select Case categoria
            Case "J"
                horas = 1000
                categoria = "Jefe"
                If cantidad > 160 Then
                    adicional = 15000
                Else
                    adicional = 0
                End If

            Case "A"
                horas = 750
                categoria = "Administrativo"
                If cantidad > 160 Then
                    adicional = 15000
                Else
                    adicional = 0
                End If

            Case "T"
                horas = 650
                categoria = "Tecnico"
                If cantidad > 160 Then
                    adicional = 15000
                Else
                    adicional = 0
                End If

            Case "O"
                horas = 500
                categoria = "Operario"
                If cantidad > 160 Then
                    adicional = 15000
                Else
                    adicional = 0
                End If

            Case Else
                Console.WriteLine("---------------------------------------------------------")
                Console.WriteLine("Ingresó un valor no valido")
                Console.WriteLine("---------------------------------------------------------")
        End Select

        antiguedad = años * 1500
        sueldo_b = (cantidad * horas) + antiguedad
        descuento = sueldo_b * 0.15
        sueldo_n = sueldo_b - descuento + adicional


        Console.WriteLine("---------------------------------------------------------")
        Console.WriteLine(" Sueldo")
        Console.WriteLine("---------------------------------------------------------")
        Console.WriteLine(" Empleado: " & nombre.ToUpper)
        Console.WriteLine(" Categoria: " & categoria.ToUpper)
        Console.WriteLine("---------------------------------------------------------")
        Console.WriteLine(" Cantidad de Horas Trabajadas: " & cantidad & " horas")
        Console.WriteLine(" Antiguedad: " & años & " años")
        Console.WriteLine(" Adicional por Antiguedad: $" & antiguedad)
        System.Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("---------------------------------------------------------")
        Console.WriteLine(" Sueldo Bruto: $" & sueldo_b)
        Console.WriteLine(" Descuento: $" & descuento & " Adicional: $" & adicional)
        Console.WriteLine("---------------------------------------------------------")
        Console.WriteLine("Sueldo Neto: $" & sueldo_n)
        Console.WriteLine("---------------------------------------------------------")
        System.Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Que tenga un buen dia!")

        Console.Read()


        'Tipo de Categoría
        'Jefe  Valor hora = 1000
        'Administrativo Valor Hora = 750
        'Tecnico Valor Hora = 650
        'Operario Valor Hora = 500

        'Cálculo del Sueldo
        'Sueldo Bruto = (VH * CH) + Antigüedad
        'Antigüedad = Cantidad de años * $1500
        'Descuento = Sueldo Bruto * 15%
        'Adicional = $25000 solo para Jefes que superen las 160 horas trabajadas y de $15000 para las demás categorías
        'Sueldo Neto = Sueldo Bruto - Descuento + Adicional

        'Salida: Mostrar por pantalla el Nombre del Empleado  y su  recibo de sueldo correspondiente.

    End Sub

End Module
