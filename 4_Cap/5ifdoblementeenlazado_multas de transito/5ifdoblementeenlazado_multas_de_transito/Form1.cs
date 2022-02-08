using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5ifdoblementeenlazado_multas_de_transito
{
    public partial class frmMultas : Form
    {
        //@mau: Instancia para list item (Ver linea 57)

        ListViewItem item;
        public frmMultas()
        {
            InitializeComponent();
        }

        private void frmMultas_Load(object sender, EventArgs e)
        {
            // Fecha actual formato corto
            lblFecha.Text = DateTime.Today.Date.ToShortDateString();
            // Hora actual formato corto
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Capurando datos
            string placa = txtPlaca.Text;
            double velocidad = double.Parse(txtVelocidad.Text);
            DateTime fecha = DateTime.Parse(lblFecha.Text);
            DateTime hora = DateTime.Parse(lblHora.Text);
            //Procesando
            double multa = 0;
            if (velocidad <= 70) multa = 0;
            else if (velocidad > 70 && velocidad <= 90) multa = 120;
            else if (velocidad > 90 && velocidad <= 100) multa = 240;
            else if (velocidad > 100) multa = 350;
            //Imprimiendo los resultados
            //@mau: crea un objeto fila y lo anade a la vista
            ListViewItem fila = new ListViewItem(placa);
            fila.SubItems.Add(lblFecha.Text);
            fila.SubItems.Add(lblHora.Text);
            fila.SubItems.Add(velocidad.ToString("0.00"));
            fila.SubItems.Add(multa.ToString("C"));
            lvMultas.Items.Add(fila);
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //@mau: Ver en la linea 15
            if (item != null)
            {
                lvMultas.Items.Remove(item);
                MessageBox.Show("Multa eliminada correctamente...");
            } else
            {
                MessageBox.Show("Debe selecionar un multa de la lista");
            }
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvMultas_MouseClick(object sender, MouseEventArgs e)
        {
            item = lvMultas.GetItemAt(e.X, e.Y);
        }
    }

}
