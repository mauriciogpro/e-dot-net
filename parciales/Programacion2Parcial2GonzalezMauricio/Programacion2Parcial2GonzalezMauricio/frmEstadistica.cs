using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion2Parcial2GonzalezMauricio
{
    public partial class frmEstadistica : Form
    {
        public frmEstadistica()
        {
            InitializeComponent();
        }

        private void frmEstadistica_Load(object sender, EventArgs e)
        {

            int Acum = 0;
            int VotospartidoA = 0;
            int VotospartidoB = 0;
            string PartidoMayorNom = "";
            int PartidoMayorNum = 0;

            foreach (Mesa item in Data.oListMesa)
            {
            
                if (item.provincia == "Bs As")
                {
                    Acum = item.partido_A + item.partido_B;
                }
               if (item.provincia == "Córdoba")
                {
                    VotospartidoA = VotospartidoA + item.partido_A;
                    VotospartidoB = VotospartidoB + item.partido_B;
                }

            }
            if (VotospartidoA > VotospartidoB)
            {
                PartidoMayorNom = "Partido A";
                PartidoMayorNum = VotospartidoA;
            } else
            {
                PartidoMayorNom = "Partido B";
                PartidoMayorNum = VotospartidoB;

            }

            lblCantidadTotal.Text = Acum.ToString();
            lbl_MayorVotos.Text = PartidoMayorNom.ToString();


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
