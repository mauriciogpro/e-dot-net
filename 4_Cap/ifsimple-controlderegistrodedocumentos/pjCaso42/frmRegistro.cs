using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjCaso42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, System.EventArgs e)
        {
            //Capturar valores
            int numero = int.Parse(txtNumero.Text);
            DateTime fecha = dtFecha.Value;
            string empresa = txtEmpresa.Text;

            // Calculando los anios de emision
            int años = DateTime.Today.Date.Year - fecha.Year;

            //Determinando la condicion
            string condicion = " ";
            if (años <= 5) condicion = "HABILITADO";
            if (años > 5) condicion = "INHABILITADO";

            //Imprimir resutados
            ListViewItem fila = new ListViewItem(numero.ToString());
            fila.SubItems.Add(fecha.ToString("d"));
            fila.SubItems.Add(empresa);
            fila.SubItems.Add(años.ToString("d"));
            fila.SubItems.Add(condicion);
            lvRegistro.Items.Add(fila);

            //Limpiando controles
            btnCancelar_Click(sender, e);





        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {


            txtNumero.Clear();
            dtFecha.Value = DateTime.Today.Date;
            txtEmpresa.Clear();
            txtNumero.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro de salir?", "Documentos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }
    }
}
