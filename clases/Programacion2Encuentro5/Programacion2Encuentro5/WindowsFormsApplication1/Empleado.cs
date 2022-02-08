using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion2Encuentro5
{
    
    public class Empleado
    {
    

        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Cargo { get; set; }
        public double Sueldo { get; set; }

    
        // siempre se crea el constructor basico (no por que punto net lo necesite sino por que es
        // una buena practica
        public Empleado()
        { }
        // Para que se crea? Para configurar algo o tomar valores iniciales
        // ej
        public Empleado(int pLegajo)
        {
            Legajo = pLegajo;
        }

        public Empleado(int pLegajo, double pSueldo)
        {
            Legajo = pLegajo;
            Sueldo = pSueldo;
        }
    }
}
