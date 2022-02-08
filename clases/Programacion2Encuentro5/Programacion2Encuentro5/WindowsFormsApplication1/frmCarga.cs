using Programacion2Encuentro5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmCarga : Form
    {
        public frmCarga()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //instancia de objeto
            Empleado oEmpleado = new Empleado();

            // 

            //caracteristicas
            oEmpleado.Legajo = int.Parse(txtLegajo.Text);
            oEmpleado.Apellido = txtApellido.Text;
            oEmpleado.Nombre = txtNombre.Text;
            oEmpleado.FechaNacimiento = DateTime.Parse(dtpFechaNacimiento.Text);
            oEmpleado.Cargo = cboCargo.SelectedItem.ToString();
            oEmpleado.Sueldo = double.Parse(txtSueldo.Text);

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
