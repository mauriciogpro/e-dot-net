using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuentro4Menu
{   
    //Se cambia a public
    public class Empleado
    {
        //Se agrega a public
        
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Cargo { get; set; }
        public double Sueldo { get; set; }

        // Constructor por defecto
        //tiene que ser llamado igual que la clase
          

        public Empleado()
        { }
    }
}
