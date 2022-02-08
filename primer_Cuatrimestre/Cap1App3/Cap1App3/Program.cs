using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap1App3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** CONVERSION DE MEDIDAS - EMP. TEXTIL **");
            Console.WriteLine(" ");

            double metros;

            Console.Write("Ingrese cantidad de metros: ");
            metros = double.Parse(Console.ReadLine());

            double centimetros = metros * 100.0;
            double pulgadas = centimetros / 2.54;
            double pies = pulgadas / 12.0;
            double yardas = pies / 3.0;

            Console.WriteLine("----------------------------");
            Console.WriteLine("CENTRIMETROS: "+centimetros.ToString("0.00"));
            Console.WriteLine("PULGADAS: " + pulgadas.ToString("0.00"));
            Console.WriteLine("PIES: " + pies.ToString("0.00"));
            Console.WriteLine("YARDAS: " + yardas.ToString("0.00"));

            Console.ReadKey();
        }
    }
}
