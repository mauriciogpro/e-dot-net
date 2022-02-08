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
        public Form1()
        {
            InitializeComponent();
        }
        // Lo que primero hizo el profe fue usar el menustrip,
        // luego crea los formularios
        // los instancia y los muestra en los menus.
        // Luego usa toolstrip

        // Para convertir la ventana en un contenedor en las propiedades del formulario
        // se seleciona windows state maximixed
        // ahora lo hacemos contenedor... con la opcion ISMDCONTAINER true
        // ahora debo hacer que los objetos se carguen en el contenedor donde estan.

        // crea la clase empleado

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            // @mau para cerrar
            this.Close();
        }

        private void cargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarga ofrmCarga = new frmCarga();
            //@ mau con esta linea se hace hijo del contenedor
            ofrmCarga.MdiParent = this;
            ofrmCarga.Show();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListado ofrmListado = new frmListado();
            ofrmListado.MdiParent = this;
            ofrmListado.Show();
        }

        private void toolStripButtonCarga_Click(object sender, EventArgs e)
        {
            frmCarga ofrmCarga = new frmCarga();
            ofrmCarga.Show();
        }

        private void toolStripButtonListado_Click(object sender, EventArgs e)
        {
            frmListado ofrmListado = new frmListado();
            ofrmListado.Show();
        }
    }
}
