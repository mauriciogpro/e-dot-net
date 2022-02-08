using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap1App1
{
    class Program
    {
        static void Main(string[] args)
        {// Linea y Espacio en blanco
            Console.WriteLine("**CALCULADORA DE MONTOS **");
            Console.WriteLine(" ");
        // Variables declaradas
            double precio;
            int cantidad;
            // Nuevo mensaje (Write muestra el mensaje y WL muestra el mensaje cambiando la linea
            Console.Write("Ingrese el precio del producto $: ");
            // Captura el precio y se lo asgna a la variable
            precio = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad seleccionada:");
            cantidad = int.Parse(Console.ReadLine());
            double monto = precio*cantidad;
            Console.WriteLine("------------------------------");
            Console.WriteLine("MONTO A CANCELAR $: " +monto.ToString("0.00"));


           // Faltaba el console en la imagen
            Console.ReadKey();

        }
    }
}
