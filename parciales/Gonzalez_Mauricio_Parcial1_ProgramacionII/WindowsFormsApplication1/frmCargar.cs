﻿using System;
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
    public partial class frmCargar : Form
    {
        public frmCargar()
        {
            InitializeComponent();
        }
        private void frmCargar_Load(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Proyecto oProyecto = new Proyecto();

            oProyecto.CodigoConstruccion = int.Parse(txtCodigoConstruccion.Text);
            oProyecto.Nombre = txtNombre.Text;
            oProyecto.CantidadRecursos = int.Parse(txtCantidadRecursos.Text);
            oProyecto.Estado = cboEstado.SelectedItem.ToString();

            Data.oListProyecto.Add(oProyecto);

            Limpiar();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnEstadistica_Click(object sender, EventArgs e)
        {
            verEstadistica();
        }

        private void Limpiar()
        {
            txtCodigoConstruccion.Clear();

            txtCodigoConstruccion.Focus();

        private void verEstadistica()
        {
            Int32 totalcont = 0;
            String maxRecEstado = " ";

            Int32 totalConstruccion = 0;
            Int32 totalAnalisis = 0;
            Int32 totalTerminado = 0;


            foreach (Proyecto item in Data.oListProyecto)
                totalrec = totalrec + item.CantidadRecursos;

                if (item.CantidadRecursos > maxRecCantidad)
                {
                    maxRecCantidad = item.CantidadRecursos;
                    maxRecProy = item.Nombre;
                }
                if (item.Estado == "En Análisis")
                {

                } else if (item.Estado == "En Construcción")
                {
                    totalConstruccion++;
                }
                else if (item.Estado == "Terminado")
                {
                    totalTerminado++;
                }
            }



            MessageBox.Show(" Total Proyectos cargados: " + totalcont + "\n Total Recursos: " + totalrec + "\n Promedio Total de Recursos es: " + totalrec/totalcont + "\n " + maxRecProy.ToUpperInvariant() + " tiene Mayor Cant. de recursos: " + maxRecCantidad + "\n Estado: " + maxRecEstado);
        }

    }
}