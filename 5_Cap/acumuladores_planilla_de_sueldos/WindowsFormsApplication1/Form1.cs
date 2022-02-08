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
    public partial class frmPlanilla : Form
    {
        double sueldo;
        int cJefe, cSupervisor, cVendedor, cAdministrador;
        double aJefe, aSupervisor, aVendedor, aAdministrador;


        public frmPlanilla()
        {
            InitializeComponent();
        }

        private void frmPlanilla_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("d");
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //capturar la categoria del empleado
            string categoria = cboCategoria.Text;

            switch (categoria)
            {
                case "Jefe": sueldo = 5000; break;
                case "Supervisor": sueldo = 3500; break;
                case "Vendedor": sueldo = 1500; break;
                case "Administrador": sueldo = 7000; break;
            }
            lblSueldo.Text = sueldo.ToString("C");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //capturando los datos
            string dni = txtDNI.Text;
            string empleado = txtEmpleado.Text;
            string categoria = cboCategoria.Text;

            //Conteos y acumuladociones
            switch (categoria)
            {
                case "Jefe": cJefe++; aJefe += sueldo; break;
                case "Supervisor": cSupervisor++; aSupervisor += sueldo; break;
                case "Vendedor": cVendedor++; aVendedor += sueldo; break;
                case "Administrador": cAdministrador++; aAdministrador += sueldo; break;
            }
            // Impresion de planilla
            ListViewItem fila = new ListViewItem(dni);
            fila.SubItems.Add(empleado);
            fila.SubItems.Add(categoria);
            fila.SubItems.Add(sueldo.ToString("C"));
            lvEmpleados.Items.Add(fila);

            // Imprimiendo las estadisticas
            //@mau: crea el array
            lvEstadisticas.Items.Clear();
            string[] elementosFila = new string[3];
            ListViewItem row;

            //impresion de los datos del Jefe
            //@mau: usa el array y agrega datos. 
            //Luego los agrega al list view
            // quisiera saber por que se crea un nuevo row
           
            elementosFila[0] = "Jefe";
            elementosFila[1] = cJefe.ToString();
            elementosFila[2] = aJefe.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);
            
            //impresion de los datos del Supervisor
            elementosFila[0] = "Supervisor";
            elementosFila[1] = cSupervisor.ToString();
            elementosFila[2] = aSupervisor.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            //impresion de los datos del Vendedor
            elementosFila[0] = "Vendedor";
            elementosFila[1] = cVendedor.ToString();
            elementosFila[2] = aVendedor.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            //impresion de los datos del Administrador
            elementosFila[0] = "Administrador";
            elementosFila[1] = cAdministrador.ToString();
            elementosFila[2] = aAdministrador.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            //Limpiando los controles
            txtDNI.Clear();
            txtEmpleado.Clear();
            cboCategoria.SelectedIndex = -1;
            lblSueldo.Text = (0).ToString("C");
            txtEmpleado.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("Esta seguro que quiere salir", "Planilla", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }
    }
}
