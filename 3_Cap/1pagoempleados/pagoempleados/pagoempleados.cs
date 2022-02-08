using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pagoempleados
{
    public partial class formPagoEmpleado : Form
    {
        public formPagoEmpleado()
        {
            InitializeComponent();
        }

        private void pagoempleados_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bntProcesar_Click(object sender, EventArgs e)
        {
            //Recuperando la informacion registrada
            string empleado = txtEmpleado.Text;
            int horas = int.Parse(txtHoras.Text);
            double costo = double.Parse(txtCosto.Text);

            // Realizando los calculos
            double sueldoBasico = horas * costo;
            double bonificacion = 20.0 / 100 * sueldoBasico;
            double sueldoBruto = sueldoBasico + bonificacion;
            double descuento = sueldoBruto * 12.0 / 100;
            double sueldoNeto = sueldoBruto - descuento;

            //Imprimiendo resultados
            lblMontoBruto.Text = sueldoBruto.ToString("C");
            LlMontoBruto.Text = descuento.ToString("C");
            LMontobruto.Text = sueldoNeto.ToString("C");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEmpleado.Clear();
            txtHoras.Clear();
            txtCosto.Clear();
            lblMontoBruto.Text = "";
            LlMontoBruto.Text = "";
            LMontobruto.Text = "";
            txtEmpleado.Focus();


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de seguro?", "Control de Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
