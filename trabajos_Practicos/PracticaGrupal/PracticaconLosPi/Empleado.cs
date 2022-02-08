using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaconLosPi
{
    public class Empleado
    {

        public int legajo { get; set; }
        public string nombre { get; set; }
        public string apellido{ get; set; }
        public DateTime fechaDeNacimiento { get; set; }
        public string cargo { get; set; }
        public double sueldo { get; set; }

        public Empleado() {}

        public Empleado(DateTime pFechaNacimiento)
        {
            fechaDeNacimiento = pFechaNacimiento;
        }
    }
}
