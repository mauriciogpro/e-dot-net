using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6ifdoblementeenlazado_registro_de_postulantes
{
    public partial class frmPostulantes : Form
    {
        public frmPostulantes()
        {
            InitializeComponent();
            //Para que el reloj se muestr dijitalizado
            tHora.Enabled = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Capturar datos del formulario
            string postulante = txtPostulante.Text;
            string carrera = cboCarrera.Text;
            double puntaje = Double.Parse(txtPuntaje.Text);

            //Determinar
            // @mau genial... ingresa si o si... pero si el puntaje es menor se le cambia a no ingresa. Sublime
            string condicion = "Ingresa";
            double puntos = 0;
            if (carrera == "Ing sistemas")
            {
                if (puntaje < 100)
                {

                    condicion = "No Ingresa";
                    puntos = 100 - puntaje;

                }
            }

            else if (carrera == "Ing Software")
            {
                if (puntaje < 120)
                {

                    condicion = "No Ingresa";
                    puntos = 120 - puntaje;

                }
            }

            else if (carrera == "Ing Mecanica")
            {
                if (puntaje < 140)
                {

                    condicion = "No Ingresa";
                    puntos = 140 - puntaje;

                }
            }
            else if (carrera == "Ing Indrustrial")
            {
                if (puntaje < 160)
                {

                    condicion = "No Ingresa";
                    puntos = 160 - puntaje;

                }
            }
            //Mostrando Resultados
            ListViewItem fila = new ListViewItem(postulante);
            fila.SubItems.Add(carrera);
            //@mau: to string 0.00 hace que salga con ese formato 1.00, 2.00
            fila.SubItems.Add(puntaje.ToString("0.00"));
            fila.SubItems.Add(condicion);
            fila.SubItems.Add("Faltan " + puntos.ToString("0.00"));
            lvPostulantes.Items.Add(fila);

            //Limpiando los controles
            tsCancelar_Click(sender, e);
                        
        }
      
        private void tsCancelar_Click(object sender, EventArgs e)
        {
            txtPostulante.Clear();
            //@mau: El cbo queda en blanco
            cboCarrera.SelectedIndex = -1;
            txtPuntaje.Clear();
            txtPostulante.Focus();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir", "Postulantes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }

        private void tHora_Tick(object sender, EventArgs e)
        {
            this.Text = "Control de registro de postulantes -";
            this.Text += DateTime.Now.ToString("hh:mm:ss");
        }
    }

    }

