using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8switch_control_de_registro_de_estacionamiento
{
    public partial class frmEstacionamiento : Form
    {
        string dia;
        public frmEstacionamiento()
        {
            InitializeComponent();
        }

        private void frmEstacionamiento_Load(object sender, EventArgs e)
        {
            //Mostrando la fecha actual
            lblFecha.Text = DateTime.Now.ToShortDateString();

            //
            DateTime fecha = DateTime.Parse(lblFecha.Text);

            //@mau dddd signigica full name day, 
            //ddd abrebiated, dd 01-31, dd 1-31 lo mismo con horas, 
            //messes, años, utc, fracciones de seguros
            
            dia = fecha.ToString("dddd");

            double costo = 0;
            switch (dia)
            {
                case "Sunday": costo = 2; break;
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday": costo = 4; break;
                case "Friday":
                case "Saturday": costo = 7; break;
            }

            lblCosto.Text = costo.ToString("0.00");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Captudano los datos del formulario
            string placa = txtPlaca.Text;
            double costo = double.Parse(lblCosto.Text);
            DateTime fecha = DateTime.Parse(txtHoraInicio.Text);
            DateTime horaInicio = DateTime.Parse(txtHoraInicio.Text);
            DateTime horaFin = DateTime.Parse(txtHoraFin.Text);

            //Calcular la hora
            TimeSpan hora = horaFin - horaInicio;
            //Calcular importe
            //@mau total hours es el numero del total de horas en esta instancia 
            //(hay de segundo, mili, dias, minutos)
            double importe = costo * (hora.TotalHours);

            //@me parece que siempre le pone como valor la primera columna
            // c es currency
            // d es decimal
            // t es time
            ListViewItem fila = new ListViewItem(placa);
            fila.SubItems.Add(fecha.ToString("d"));
            fila.SubItems.Add(horaInicio.ToString("t"));
            fila.SubItems.Add(horaFin.ToString("t"));
            fila.SubItems.Add(hora.TotalHours.ToString());
            fila.SubItems.Add(costo.ToString("C"));
            fila.SubItems.Add(importe.ToString("C"));
            lvRegistro.Items.Add(fila);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPlaca.Clear();
            txtHoraInicio.Clear();
            txtHoraFin.Clear();
            txtPlaca.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro que quiere salir", "Estacionamiento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }
    }
}
