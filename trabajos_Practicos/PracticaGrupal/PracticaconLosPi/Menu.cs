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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Carga oCarga = new Carga();

            oCarga.Show();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            Listado oListado = new Listado();
            oListado.Show();

           
        }
    }
}
