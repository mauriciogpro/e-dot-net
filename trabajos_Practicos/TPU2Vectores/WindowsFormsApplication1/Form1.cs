using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //Declaracion
        string[] Provincia = new string[5];
        Int32[] Habitantes = new Int32[5];

        //Contador
        int cont = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            limpiarVector();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cargarVector();
            limpiarVector();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarVector();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            VerVector();
        }

        // Metodos
        // Cargar
        private void cargarVector()
        {
            if (Provincia.Length > cont)
            {
                Provincia[cont] = (txtProvincia.Text).ToLower();
                Habitantes[cont] = Int32.Parse(txtHabitantes.Text);

                cont++;
            } else
            {
                MessageBox.Show(" Error. Cantidad Maxima Alcanzada");
            }
        }
        // Limpiar
        private void limpiarVector()
        {
            txtProvincia.Clear();
            txtHabitantes.Clear();
            txtProvincia.Focus();
        }
        // Ver
        private void VerVector()
        {
            int acum = 0;
            int cant = 0;
            int MaxHab = 0;
            String MaxProv = " ";
            int CbaHab = 0;

            for (int i=0; i < Provincia.Length; i++)
            {
                acum = acum + Habitantes[i];
                cant++;

                if (Habitantes[i] > MaxHab)
                {
                    MaxHab = Habitantes[i];
                    MaxProv = Provincia[i];
                }
                if (Provincia[i] == "cordoba")
                {
                    CbaHab = Habitantes[i];
                }
            }

            MessageBox.Show(" Total Provincias cargadas: " + cant + "\n Total Habitantes en el vector es: " + acum + "\n Promedio Total de Habitantes es: " + acum/cant + "\n "+ MaxProv.ToUpperInvariant() + " tiene Mayor Cant. de Habitantes: " + MaxHab + "\n Habitantes de Cordoba " + CbaHab);


        }
    }
}
