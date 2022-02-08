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
    public partial class Form1 : Form
    {
        string[] Nombre = new string[5];
        double[] Sueldo = new double[5];
        int cont = 0;
        int cant = 0;
        
        Empleado[] objVector = new Empleado[5];

        List<Empleado> oListEmpleados = new List<Empleado>();

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CargarVector();
            Limpiar();
        }

        private void CargarVector()
        {

            if (cont < Nombre.Length)
            {
                Nombre[cont] = txtNombre.Text;
                Sueldo[cont] = double.Parse(txtSueldo.Text);
                cont++;
            } else
            {
                MessageBox.Show(" Error");
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtSueldo.Clear();

            txtNombre.Focus();

        }

        private void CargarLista()
        {
            //Cargo Objeto
            Empleado obj = new Empleado();
            // sino esta la palabra new no se instancia el obj

            obj.Nombre = txtNombre.Text;
            obj.Sueldo = double.Parse(txtSueldo.Text);

            // Objeto vector
            //if (cant < objVector.Length)
            //{
            //    objVector[cant] = obj;

           //  cant++;
                
            //} else
            //{
            //   MessageBox.Show(" Error");

            // Cargo Lista con el objeto
               oListEmpleados.Add(obj);
            }
        private void btnVerVector_Click(object sender, EventArgs e)
        {
            double acum = 0;
            for (int i = 0; i < Sueldo.Length; i++)
            {
                acum = acum + Sueldo[i];
            }

            MessageBox.Show("Total Sueldos en el vector: " + acum);
        }
        private void btnVerLista_Click(object sender, EventArgs e)
        {
            double acum = 0;

        foreach (Empleado item in oListEmpleados)
        {
                acum = acum + item.Sueldo;
        }
            MessageBox.Show("Total sueldo en la lista es: " + acum);
        }
        
    }
    
}
