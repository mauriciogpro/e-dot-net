using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorNotaAlumno
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ingresoDeDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCarga oIngresoDatos = new frmCarga();
            oIngresoDatos.MdiParent = this;
            oIngresoDatos.Show();
        }

        private void listadoDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado oListadoDatos = new Listado();
            oListadoDatos.MdiParent = this;
            oListadoDatos.Show();
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadisticas oEstadistica = new Estadisticas();
            oEstadistica.MdiParent = this;
            oEstadistica.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
