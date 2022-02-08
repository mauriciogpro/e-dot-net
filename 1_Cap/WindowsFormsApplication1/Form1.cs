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
        Int32[] sueldos = new Int32[3];
        int cont = 0;
        int acum = 0;
        public Form1()
        {
            InitializeComponent();
            // MessageBox.Show("Hola Mundo");
            // Este es el metodo constructor y es lo primero que se ejecuta antes que el load.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Metodo relacionado con el evento. 
            //MessageBox.Show("Bienvenido");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cont < sueldos.Length)
            {
                sueldos[cont] = Int32.Parse(TextBox1.Text);
                cont++;
            }
            else
            {
                MessageBox.Show("cont");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sueldos.Length; i++)
            {
                acum = acum + sueldos[i];
            }
            MessageBox.Show("Sueldo Acumulado:" + acum);
        }
    }
}

