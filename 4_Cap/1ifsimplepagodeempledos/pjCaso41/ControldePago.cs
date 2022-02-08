using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjCaso41
{
    public partial class frmPago : Form
    {
        // Detalle nuevo: ListView y uso de fecha de dia automatico
        // Consutar : DateTime.Today.Date.ToString("d");
        // 

        double sueldo = 0;

        public frmPago()
        {
            InitializeComponent();
        }
        private void frmPago_Load(object sender, EventArgs e)
        {
            // el tipo C indica que lo formatee como fecha anglosajona
            // https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring
            lblFecha.Text = DateTime.Today.Date.ToString("d");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Capturar valores
            string empleado = txtEmpleado.Text;
            string categoria = cboCategoria.Text;

            //Realizar calculos

            double descuento = 0;


            //@mau: ternario me parece
            if (sueldo > 2000) descuento = sueldo * (12.5 / 100);

            double neto = sueldo - descuento;

            //Imprimiendo los resultados en la lista
            //@mau: a lvpagos se le agrega el objeto fila
            // al objeto se le agregaron subitems
            // y fue creado con new ListViewItem

            
            ListViewItem fila = new ListViewItem(empleado);
            fila.SubItems.Add(categoria);
            fila.SubItems.Add(sueldo.ToString("C"));
            fila.SubItems.Add(descuento.ToString("C"));
            fila.SubItems.Add(neto.ToString("C"));
            lvPagos.Items.Add(fila);

            //Limpiando controles
            //@mau: Trigger to cancelar button
            btnCancelar_Click(sender, e);
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Capturando categoria seleccionada
            string categoria = cboCategoria.Text;

            // Asignando sueldo segun categoria
            if (categoria == "Jefe") sueldo = 3500;
            if (categoria == "Administrativo") sueldo = 2500;
            if (categoria == "Tecnico") sueldo = 1700;
            if (categoria == "Operario") sueldo = 1000;

            //Enviando el sueldo obtenido a la impresion
            // el tipo C indica que lo formatee como dinero
            // https://docs.microsoft.com/en-us/dotnet/api/system.int32.tostring
            lblSueldo.Text = sueldo.ToString("C");
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cboCategoria.Text = "(Selecione)";
            txtEmpleado.Clear();
            txtEmpleado.Focus();

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }
    }
}
