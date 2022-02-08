Module Module1

    Sub Main()
        '“El náufrago satisfecho” ofrece hamburguesas sencillas (S), dobles (D) y triples (T),
        'las cuales tienen un costo de $20, $25 y $28 respectivamente. La empresa acepta
        'tarjetas de crédito con un cargo de 5 % sobre la compra. Suponiendo que los
        'clientes adquieren N hamburguesas, las cuales pueden ser de diferente tipo, realice
        'un algoritmo para determinar cuánto deben pagar. Represéntelo en diagrama de
        'flujo, pseudocódigo y diagrama N/S. 

        Dim precio As Double
        Dim cantidad As Integer
        Dim hamburguesa, tarjeta, eleccion As String

        Console.WriteLine("--------------------------------------------------------------")
        Console.WriteLine(" BIENVENIDO A EL NAUFRAGIO INSASTISFECHO"
        Console.WriteLine("--------------------------------------------------------------")



        Console.WriteLine("--------------------------------------------------------------")
        Console.WriteLine("| Que desea ordernar? Sencillas (S), dobles (D) y triples (T)|")
        Console.WriteLine("--------------------------------------------------------------")
        Console.WriteLine("1. - S sencilla $ 20")
        Console.WriteLine("1. - D doble $ 25")
        Console.WriteLine("1. - T triple $28")
        Console.WriteLine("--------------------------------------------------------------")
        hamburguesa = Console.ReadLine()
        Select Case hamburguesa
            Case "S"
                precio = 20
                eleccion = "Simple"
            Case "D"
                precio = 25
                eleccion = "Doble"
            Case "T"
                precio = 28
                eleccion = "Triple"
            Case Else
                Console.WriteLine("Orden incorrecta")
        End Select

        Console.WriteLine("--------------------------------------------------------------")
        Console.WriteLine("| Cuantas va a querer?                                       |")
        Console.WriteLine("--------------------------------------------------------------")
        cantidad = Console.ReadLine()
        precio = cantidad * precio

        Console.WriteLine("--------------------------------------------------------------")
        Console.WriteLine("| Abona con tarjeta de Credito? S/N                          |")
        Console.WriteLine("--------------------------------------------------------------")
        tarjeta = Console.ReadLine()
        If tarjeta = "S" Then
            precio = precio * 1.21
            Console.WriteLine("Su orden es de Hamburguesas: " & eleccion & " Cant: " & cantidad & " Precio Total: " & precio)
            Console.WriteLine("Disfrute su orden")
        ElseIf tarjeta IsNot "S" Then
            Console.WriteLine("Su orden es de Hamburguesas: " & eleccion & " Cant: " & cantidad & " Precio Total: " & precio)
            Console.WriteLine("Disfrute su orden")
        Else Console.WriteLine(" Error tarjeta")
        End If


        Console.Read()

        '2. Una empresa desea determinar el monto de un cheque que debe proporcionar a uno
        'de sus empleados que tendrá que ir por equis número de días a la ciudad de
        'Monterrey; los gastos que cubre la empresa son: hotel, comida y 100.00 pesos
        'diarios para otros gastos. El monto debe estar desglosado para cada concepto.
        'Realice un diagrama de flujo y pseudocódigo que representen el algoritmo que
        'determine el monto del cheque.

        'Dim hotel, comida, otros, cheque As Double
        'Dim cantidad As Integer
        'Console.WriteLine("ingrese costo de hotel")
        'Console.WriteLine("-----------------------------------")
        'hotel = Console.ReadLine()
        'Console.WriteLine("ingrese costo de comida")
        'Console.WriteLine("-----------------------------------")
        'comida = Console.ReadLine()
        'Console.WriteLine("ingrese cantidad de dias")
        'Console.WriteLine("-----------------------------------")
        'cantidad = Console.ReadLine()
        'otros = cantidad * 100
        'cheque = cantidad * (hotel + comida + otros)
        'Console.WriteLine()
        'Console.WriteLine("------Emision de Cheque------------")
        'Console.WriteLine(" Gasto en hotel: " & hotel * cantidad)
        'Console.WriteLine("-----------------------------------")
        'Console.WriteLine(" Gasto en comida: " & comida * cantidad)
        'Console.WriteLine("-----------------------------------")
        'Console.WriteLine(" Gasto en otros: " & otros)
        'Console.WriteLine("-----------------------------------")
        'Console.WriteLine(" Cheque por un total de : $" & cheque)
        'Console.WriteLine("-----------------------------------")
        'Console.Read()

        '3. Se les dará un bono por antigüedad a los empleados de una tienda. Si tienen un
        'año, se les dará $100; si tienen 2 años, $200, y así sucesivamente hasta los 5 años.
        'Para los que tengan más de 5, el bono será de $1000. Realice un algoritmo y
        'represéntelo mediante el diagrama de flujo, el pseudocódigo y diagrama N/S que
        'permita determinar el bono que recibirá un trabajador.

        'Dim año, bono As Integer

        'año = Console.ReadLine()


        'Select Case año
        '    Case = 1
        '        bono = 100
        '    Case = 2
        '        bono = 200
        '    Case = 3
        '        bono = 300
        '    Case = 4
        '        bono = 400
        '    Case = 5
        '        bono = 500
        '    Case > 5
        '        bono = 1000
        '    Case Else
        '        Console.WriteLine(" Felicitacione su bono es de " & bono & "por tener" & año & "años trabajados")
        'End Select

        'Console.Read()


        '4. Un profesor tiene un salario inicial de $1500, y recibe un incremento de 10 % anual
        'durante 6 años. ¿Cuál es su salario al cabo de 6 años? ¿Qué salario ha recibido en
        'cada uno de los 6 años? Realice el algoritmo y represente la solución mediante el
        'diagrama de flujo, el pseudocódigo y el diagrama N/S, utilizando el ciclo apropiado.

        'Dim salario As Integer
        'Console.WriteLine("------Ingrese salario------------")
        'Console.WriteLine("---------------------------------")
        'salario = Console.ReadLine()
        'Console.WriteLine()
        'Console.WriteLine("---------------------------------")
        'Console.WriteLine("Salario al cabo de un año: $" & salario * 1.1)
        'Console.WriteLine("Salario al cabo de dos años: $" & salario * 1.2)
        'Console.WriteLine("Salario al cabo de tres años: $" & salario * 1.3)
        'Console.WriteLine("Salario al cabo de 4 años: $" & salario * 1.4)
        'Console.WriteLine("Salario al cabo de 5 años: $" & salario * 1.5)
        'Console.WriteLine("Salario al cabo de 6 años: $" & salario * 1.6)
        'Console.WriteLine("---------------------------------")
        'Console.ReadLine()


    End Sub

End Module
