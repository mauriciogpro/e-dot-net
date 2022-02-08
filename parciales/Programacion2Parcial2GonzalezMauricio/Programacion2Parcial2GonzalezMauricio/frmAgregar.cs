using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion2Parcial2GonzalezMauricio
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {

            Limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Mesa oMesa = new Mesa();

            oMesa.numero_Mesa = int.Parse(txtNumero_Mesa.Text);
            oMesa.partido_A = int.Parse(txtPartido_A.Text);
            oMesa.partido_B = int.Parse(txtPartido_B.Text);
            oMesa.provincia = cboProvincia.SelectedItem.ToString();

            
            
            Data.oListMesa.Add(oMesa);

            dgvListado.DataSource = null;
            dgvListado.DataSource = Data.oListMesa;



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(" Esta seguro de salir?", "Gestion de Construcciones", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }
        private void Limpiar() { 
        txtNumero_Mesa.Clear();
            txtPartido_A.Clear();
            txtPartido_B.Clear();
            cboProvincia.SelectedIndex = 0;
            txtNumero_Mesa.Focus();
        }
    }
}
