using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap1App5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ** CONTROL DE VENTA DE PRODUCTOS **");
            Console.WriteLine(" ");

            double precio;
            int cantidad;

            Console.Write("Ingrese el precio del producto: $");
            precio = double.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad comprada: ");
            cantidad = int.Parse(Console.ReadLine());
            //soy un comentario
            double importe = cantidad * precio;
            double descuento = 11 / 100.0 * importe;
            double total = importe - descuento;
            //soy un comentario multi
            //    linea
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Importe Total: $"+ importe.ToString("0.00"));
            Console.WriteLine("Descuento : $"+ descuento.ToString("0.00"));
            Console.WriteLine("Total a Pagar: $" + total.ToString("0.00"));

            Console.ReadKey();

        }
    }
}
