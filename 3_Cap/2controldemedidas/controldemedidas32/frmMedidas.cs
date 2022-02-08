using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controldemedidas32
{
    public partial class frmMedidas : Form
    {
        public frmMedidas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Capturar el valor en metros
            double metros = double.Parse(txtMetros.Text);

            //Realizando conversiones
            double centrimetros = metros * 100;
            double pulgadas = centrimetros / 2.54;
            double pies = pulgadas / 12;
            double yardas = pies / 3;

            //Mostrando los resultados de la conversion
            lstR.Items.Add("**RESUMEN DE CONVERSIONES**");
            lstR.Items.Add("MEDIDAS EN METROS: " + metros.ToString("0.00"));
            lstR.Items.Add("--------------------------------------------");
            lstR.Items.Add("MEDIDAS EN CENTIMETROS: " + centrimetros.ToString("0.00"));
            lstR.Items.Add("MEDIDAS EN PULGADAS: " + pulgadas.ToString("0.00"));
            lstR.Items.Add("MEDIDAS EN PIES: " + pies.ToString("0.00"));
            lstR.Items.Add("MEDIDAS EN YARDAS:" + yardas.ToString("0.00"));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMetros.Clear();
            lstR.Items.Clear();
            txtMetros.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Medidas", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes) this.Close();
        }
    }
}
