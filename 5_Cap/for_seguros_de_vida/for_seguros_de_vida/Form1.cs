using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_seguros_de_vida
{
    public partial class frmProformas : Form
    {
        public frmProformas()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string razon = txtRazon.Text;
            string tipo = cboTipo.Text;
            int cantidad = int.Parse(txtCantidad.Text);

            //calculando el pago mensual por tipo de seguro
            double pagoMensual = 0;
            switch (tipo)
            {
                case "Inversion Clasica":
                    if (cantidad <= 10) pagoMensual = 50 * cantidad;
                    else pagoMensual = (50 * cantidad) + (10 * (cantidad - 10));
                    break;

                case "Inversion Platino":
                    if (cantidad <= 8) pagoMensual = 80 * cantidad;
                    else pagoMensual = (80 * cantidad) + (8 * (cantidad - 8));
                    break;

                case "Inversion Oro":
                    if (cantidad <= 5) pagoMensual = 150 * cantidad;
                    else pagoMensual = (150 * cantidad) + (15 * (cantidad - 5));
                    break;
            }
            // Imrpimiendo el detalle de la proforma
            ListViewItem fila = new ListViewItem(tipo);
            fila.SubItems.Add(cantidad.ToString());
            fila.SubItems.Add(pagoMensual.ToString("0.00"));
            lvProforma.Items.Add(fila);
        }

        private void tsGeneral_Click(object sender, EventArgs e)
        {
            //Determinar el total de personas aseguradas
            int totalAsegurados = 0;
            for (int i = 0; i < lvProforma.Items.Count; i++)
            {
                if (lvProforma.Items[i].SubItems[0].Text != "") totalAsegurados += int.Parse(lvProforma.Items[i].SubItems[1].Text);
            }
            //Determinar el monto total acumulado a cancelar
            double total = 0;
            for (int i = 0; i < lvProforma.Items.Count; i++)
            {
                if (lvProforma.Items[i].SubItems[0].Text != "") total += double.Parse(lvProforma.Items[i].SubItems[2].Text);
            }

            // Impresion de las estadisticas
            lvEstadisticas.Items.Clear();
            string[] elementosFila = new string[2];
            ListViewItem row;

            elementosFila[0] = "Total de personas aseguradas";
            elementosFila[1] = totalAsegurados.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto total a canceclar";
            elementosFila[1] = total.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);
        }

        private void tsAnular_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de anular la proforma?", "Seguros", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes)
            {
                txtRazon.Clear();
                cboTipo.Text = "(Seleccione tipo)";
                txtCantidad.Clear();
                txtRazon.Focus();
                lvProforma.Items.Clear();
                lvEstadisticas.Items.Clear();
            }
        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir", "Seguros", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }
    }
}
