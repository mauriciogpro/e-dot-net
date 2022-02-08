using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro_De_Llamadas
{
    public partial class frmLlamadas : Form
    {
        public frmLlamadas()
        {
            InitializeComponent();
        }

        private void tsRegistrar_Click(object sender, EventArgs e)
        {
            //Capturando datos
            string telefono = txtTelefono.Text;
            int minutos = int.Parse(txtMinutos.Text);

            // Determinando el tipo de llamada
            string tipo = " ";
            if (rbfNacional.Checked == true) tipo = "Fijo Nacional";
            if (rbfInternacional.Checked == true) tipo = "Fijo Internacional";
            if (rbmNacional.Checked == true) tipo = "Movil Nacional";
            if (rbmInternacional.Checked == true) tipo = "Movil Internacional";

            //Validando si no seleeciona un tipo
            if (tipo == " ")
            {
                MessageBox.Show("Debe seleccionar el tipo de llamadas", "Soy un titulo Llamadas");
                    return; // Expulsa del metodo
            }

            // Asignando un tariga segun el tripo de llamada
            double tarifa = 0;
            switch (tipo)
            {
                case "Fijo Nacional": tarifa = 0.25; break;
                case "Fijo Internacional": tarifa = 1.75; break;
                case "Movil Nacional": tarifa = 1.25; break;
                case "Movil Internacional": tarifa = 2.50; break;
            }

            //Realizando los calculo de los importes
            double importe = tarifa * minutos;

            //Determinando descuentos
            double descuento;
            switch (tipo)
            {
                case "Fijo Nacional": descuento = 5.0/100 * importe; break;
                case "Fijo Internacional": descuento = 7.0 / 100 * importe; break;
                case "Movil Nacional": descuento = 9.0 / 100 * importe; break;
                case "Movil Internacional": descuento = 12.0 / 100 * importe; break;
                default: descuento = 0; break;

             
            }
            // Calculando el neto
            double neto = importe - descuento;

            //Realizando impresiones
            ListViewItem fila = new ListViewItem(telefono);
            fila.SubItems.Add(tipo);
            fila.SubItems.Add(minutos.ToString());
            fila.SubItems.Add(importe.ToString("C"));
            fila.SubItems.Add(descuento.ToString("C"));
            fila.SubItems.Add(neto.ToString("C"));
            lvLlamadas.Items.Add(fila);

            //Limpiando controles

        }

        private void tsCancelar_Click(object sender, EventArgs e)
        {
            txtTelefono.Clear();
            txtMinutos.Clear();
            rbfNacional.Checked = true;
            txtTelefono.Focus();
        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Llamadas", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }

        private void txtMinutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) )
            {
                MessageBox.Show("Debe ingresar solo numero", "Llamadas");
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Debe ingresar solo numero", "Llamadas");
                e.Handled = true;
                return;
            }
        }
    }
}
