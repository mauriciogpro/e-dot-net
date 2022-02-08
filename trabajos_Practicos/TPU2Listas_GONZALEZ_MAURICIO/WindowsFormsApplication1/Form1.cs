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
        //Objeto
        Demografia obj = new Demografia();
                
        // Lista
        List<Demografia> oListDemografia = new List<Demografia>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cargarLista();
            limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            verLista();
        }

        //Metodos

        private void limpiar()
        {
            txtHabitantes.Clear();
            txtProvincia.Clear();
            txtProvincia.Focus();

        }

        private void cargarLista()
        {
            //Cargar Objeto
            Demografia obj = new Demografia();

            obj.Provincia = txtProvincia.Text.ToLower();
            obj.Habitantes = Int32.Parse(txtHabitantes.Text);
            //Cargar Lista con el objeto
            oListDemografia.Add(obj);
        }
        private void verLista()
        {
            Int32 acum = 0;
            Int32 cant = 0;
            int MaxHab = 0;
            String MaxProv = " ";
            int CbaHab = 0;

            foreach ( Demografia item in oListDemografia)
            {
                acum = acum + item.Habitantes;
                cant++;
                if (item.Habitantes > MaxHab)
                {
                    MaxHab = item.Habitantes;
                    MaxProv = item.Provincia;
                }
                if (item.Provincia == "cordoba")
                {
                    CbaHab = item.Habitantes;
                }
            }

       MessageBox.Show(" Total Provincias cargadas: " + cant + "\n Total Habitantes en el vector es: " + acum + "\n Promedio Total de Habitantes es: " + acum/cant + "\n "+ MaxProv.ToUpperInvariant() + " tiene Mayor Cant. de Habitantes: " + MaxHab + "\n Habitantes de Cordoba: " + CbaHab);
        }
    }
}
