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
        //Cantidad
        Int32 cont = 0;
        // Vector
        Demografia[] objVector = new Demografia[5];


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
            cargarVectorObj();
            limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            verVectorObjeto();
        }

        //Metodos

        private void limpiar()
        {
            txtHabitantes.Clear();
            txtProvincia.Clear();
            txtProvincia.Focus();

        }

        private void cargarVectorObj()
        {
            //Cargar Objeto
            Demografia obj = new Demografia();

            obj.Provincia = txtProvincia.Text.ToLower();
            obj.Habitantes = Int32.Parse(txtHabitantes.Text);

            //Guardar en vector objeto
            if (cont < objVector.Length)
            {
                objVector[cont] = obj;
                cont++;
            } else
            {
                MessageBox.Show(" Error. Limite de Vector de Objeto alcanzado");
            }
        }

        
        private void verVectorObjeto()
        {
            Int32 acum = 0;
            Int32 cant = 0;
            Int32 MaxHab = 0;
            String MaxProv = " ";
            Int32 CbaHab = 0;

            foreach (Demografia elements in objVector)
            {
                if (elements != null)
                {
                    acum = acum + elements.Habitantes;
                    cant++;

                    if (elements.Habitantes > MaxHab)
                    {
                        MaxHab = elements.Habitantes;
                        MaxProv = elements.Provincia;
                    }
                    if (elements.Provincia == "cordoba")
                    {
                        CbaHab = elements.Habitantes;
                    }
                }
            }
                MessageBox.Show(" Total Provincias cargadas: " + cant + "\n Total Habitantes en el vector es: " + acum + "\n Promedio Total de Habitantes es: " + acum / cant + "\n " + MaxProv.ToUpperInvariant() + " tiene Mayor Cant. de Habitantes: " + MaxHab + "\n Habitantes de Cordoba: " + CbaHab);
            
        }
    }
}
