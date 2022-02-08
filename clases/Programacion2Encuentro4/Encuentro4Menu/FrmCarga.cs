using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encuentro4Menu
{
    public partial class frmCarga : Form
    {

        // Lista declarada. Lista solo de objetos empleadoss, luego
        // se hizo una clase statica y se comento esta linea

        
        //public List<Empleado> oListEmpleado = new List<Empleado>();


        public frmCarga()
        {
            InitializeComponent();
        }

        private void frmCarga_Load(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //instancia de objeto
            Empleado oEmpleado = new Empleado();

            //caracteristicas
            oEmpleado.Legajo = int.Parse(txtLegajo.Text);
            oEmpleado.Apellido = txtApellido.Text;
            oEmpleado.Nombre = txtNombre.Text;
            oEmpleado.FechaNacimiento = DateTime.Parse(dtpFechaNacimiento.Text);
            oEmpleado.Cargo = cboCargo.SelectedItem.ToString();
            oEmpleado.Sueldo = double.Parse(txtSueldo.Text);

            //agregado a la lista
            // se comento luego de agregar la clase data static y public
            //oListEmpleado.Add(oEmpleado);
            // de esta manera se agrga dentro de data
            data.oListEmpleado.Add(oEmpleado);

            Limpiar();


            // Data grid view primero se limpia y luego se carga
            dgv.DataSource = null;
            // se comento luego de agregar la clase data static y public
            //dgv.DataSource = oListEmpleado;
            // de esta manera se instancia la clase
            dgv.DataSource = data.oListEmpleado;
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtLegajo.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            dtpFechaNacimiento.Text = DateTime.Now.ToString();
            cboCargo.SelectedIndex = 0;
            txtSueldo.Clear();

            txtLegajo.Focus();

        }
        
    }
}
