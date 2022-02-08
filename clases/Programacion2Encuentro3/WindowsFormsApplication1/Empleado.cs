using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    // se le agrega publica
    public class Empleado
    {
        //  Pueden tener prop, metodos, eventos, atrib, campos
       public string Nombre { get; set; }
       public double Sueldo { get; set; }
        // No hace falta aca por que no hace nada pero lo puso el profe
    public Empleado()
        { } // requiere estos parentesis sino da error.
    }

}
