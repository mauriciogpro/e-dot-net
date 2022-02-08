using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorNotaAlumno
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            AlumnosDataSetTableAdapters.AlumnosTableAdapter taAlumnos = new AlumnosDataSetTableAdapters.AlumnosTableAdapter();
            AlumnosDataSet.AlumnosDataTable dtAlumnos = new AlumnosDataSet.AlumnosDataTable();

            taAlumnos.Fill(dtAlumnos);

            List<Alumnos> oListAlumnos = new List<Alumnos>();
            oListAlumnos = data.ConvertDataTable<Alumnos>(dtAlumnos);

            int cantAlumnosActual = 0;
            int cantFisicaActual = 0;
            int cantQuimicaActual = 0;
            double prom = 0.0;
            int cantAprobadoF = 0;
            int cantDesaprobadoF = 0;
            int cantAprobadoQ = 0;
            int cantDesaprobadoQ = 0;
            int cantPromocionadosF = 0;
            int cantPromocionadosQ = 0;


            foreach (Alumnos item in oListAlumnos)
            {

                if (item.CicloLectivo == 2021)
                    cantAlumnosActual++;

                if (item.CicloLectivo == 2021 && item.Materia == "Fisica")
                    cantFisicaActual++;

                if (item.CicloLectivo == 2021 && item.Materia == "Quimica")
                    cantQuimicaActual++;

                prom = (item.NotaParcial1 + item.NotaParcial2 + item.NotaTrabajoP) / 3;

                if (item.Materia == "Fisica" && prom <= 3)
                    cantDesaprobadoF++;
                if (item.Materia == "Fisica" && prom > 3 && prom <= 7)
                    cantAprobadoF++;
                if (item.Materia == "Fisica" && prom > 7)
                    cantPromocionadosF++;

                //if (item.Materia == "Quimica" && prom <= 3)
                //    cantDesaprobadoQ++;
                //if (item.Materia == "Quimica" && prom > 3 && prom <= 7)
                //    cantAprobadoQ++;
                //if (item.Materia == "Quimica" && prom > 7)
                //    cantPromocionadosQ++;

                if (item.Materia == "Quimica" && prom <= 3)
                {
                    cantDesaprobadoQ++;
                }
                else if (item.Materia == "Quimica" && prom > 3 && prom <= 7)
                {
                    cantAprobadoQ++;
                }
                else if (item.Materia == "Quimica" && prom > 7)
                {
                    cantPromocionadosQ++;
                }
            }

            lblCantACicloAc.Text = cantAlumnosActual.ToString();
            lblCantAlQuimicaCActual.Text = cantQuimicaActual.ToString();
            lblCantAlFisicaCActual.Text = cantFisicaActual.ToString();

            lblCantAprobadoFisica.Text = cantAprobadoF.ToString();
            lblCantDesapFisica.Text = cantDesaprobadoF.ToString();
            lblCantPromocFisica.Text = cantPromocionadosF.ToString();

            lblCantAprobadoQuimica.Text = cantAprobadoQ.ToString();
            lblCantDesapQuimica.Text = cantDesaprobadoQ.ToString();
            lblCantPromocQuimica.Text = cantPromocionadosQ.ToString();
        }
    }
}
