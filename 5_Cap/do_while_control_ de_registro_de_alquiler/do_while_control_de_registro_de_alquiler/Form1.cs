using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_while_control_de_registro_de_alquiler
{
    public partial class frmAlquiler : Form
    {
        public frmAlquiler()
        {
            InitializeComponent();
            tHora.Enabled = true;
        }

        private void frmAlquiler_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        private void tHora_Tick_1(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Capturar datos
            string habitacion = cboTipo.Text;
            int dias = int.Parse(txtDias.Text);
            //Asignacion de costo por habitacion
            double costo = 0;
            switch (habitacion)
            {
                case "Simple": costo = 30; break;
                case "Doble": costo = 50; break;
                case "Matrimonial": costo = 120; break;
                case "Presidencial": costo = 300; break;
            }

            //Realizando los aclulos
            double subtotal = costo * dias;

            double descuento = 0;
            if (dias <= 5)
                descuento = 0;
            else if (dias > 5 && dias <=10)
                descuento = 0.05 * subtotal;
            else if (dias > 10 && dias <= 30)
                descuento = 0.01 * subtotal;
            else if (dias > 30)
                descuento = 0.02 * subtotal;

            double neto = subtotal - descuento;
        }
    }
}
