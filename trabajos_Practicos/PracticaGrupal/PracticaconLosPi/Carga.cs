using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaconLosPi
{
    public partial class Carga : Form
    {     
        public Carga()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //instanciamos la clase para crear el objeto
            Empleado oEmpleado = new Empleado();

            //determinamos como son las propiedades.
            oEmpleado.legajo = int.Parse(txtLegajo.Text); //Convert.Toint()
            oEmpleado.nombre = txtNombre.Text;
            oEmpleado.apellido = txtApellido.Text;
            oEmpleado.sueldo = int.Parse(txtSueldo.Text);
            oEmpleado.fechaDeNacimiento = DateTime.Parse(dtpFechaNacimiento.Text);
            oEmpleado.cargo = cboCargo.SelectedItem.ToString();

            Data.oListEmpleado.Add(oEmpleado);

            dgv.DataSource = null;
            dgv.DataSource = Data.oListEmpleado;


            Limpiar();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            int mayEmpleado = 0;
            int cantEmpleados = 0;
            cantEmpleados = Data.oListEmpleado.Count();
            double promedio = 0;
            int acumSueldo = 0;

            foreach(Empleado item in Data.oListEmpleado)
            {
                if(item.sueldo > 1000)
                {
                    mayEmpleado++;                    
                }
            }
            foreach(Empleado item in Data.oListEmpleado)
            {

            }

            







            MessageBox.Show("cantidad de empleados: " + cantEmpleados + "\n cantidad empleados que cobran mas de 1000: " + mayEmpleado);
        }

        private void Limpiar()
        {
            txtLegajo.Clear();
            txtNombre.Clear();
            txtSueldo.Clear();
            txtApellido.Clear();
            cboCargo.SelectedIndex = 0;
            dtpFechaNacimiento.Text = DateTime.Now.ToString();

            txtLegajo.Focus();
        }

        private void Carga_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
