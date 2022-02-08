using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            frmAgregar ofrmAgregar = new frmAgregar();
            ofrmAgregar.Show();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            
            frmListado ofrmListado = new frmListado();
            ofrmListado.Show();
        }
    }
}
