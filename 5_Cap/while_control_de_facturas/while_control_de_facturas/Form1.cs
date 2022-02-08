﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_control_de_facturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int i;

            // Capturando los datos
            int numFact = int.Parse(txtNumFact.Text);
            string licencia = cboTipo.Text;
            int unidades = int.Parse(txtUnidades.Text);

            //Determinar el precio de las licencias
            double precio = 0;
            switch (licencia)
            {
                case "Cobre": precio = 700; break;
                case "Bronce": precio = 900; break;
                case "Silver": precio = 1400; break;
                case "Gold": precio = 2500; break;
            }

            //Calculando el subtotal
            double subtotal = unidades * precio;

            //Enviando la informacion a la lista de registros
            ListViewItem fila = new ListViewItem(numFact.ToString());
            fila.SubItems.Add(licencia);
            fila.SubItems.Add(unidades.ToString());
            fila.SubItems.Add(subtotal.ToString("0.00"));
            lvRegistro.Items.Add(fila);

            //Calculando el monto total acumulado
            double mAcumulado = 0;
            i = 0;
            while(i < lvRegistro.Items.Count)
            {
                mAcumulado += double.Parse(lvRegistro.Items[i].SubItems[3].Text);
                i++;
            }
            lblMonto.Text = mAcumulado.ToString("C");

            //Calculando las estadisticas
            int cCobre = 0, cBronce = 0, cSilver = 0, cGold = 0;
            double tCobre = 0, tBronce = 0, tSilver = 0, tGold = 0;

            i = 0;
            while(i < lvRegistro.Items.Count)
            {
                if (lvRegistro.Items[i].SubItems[1].Text == "Cobre")
                {
                    cCobre += int.Parse(lvRegistro.Items[i].SubItems[2].Text);
                    tCobre += double.Parse(lvRegistro.Items[i].SubItems[3].Text);
                } else if (lvRegistro.Items[i].SubItems[1].Text == "Bronce")
                {
                        cBronce += int.Parse(lvRegistro.Items[i].SubItems[2].Text);
                        tBronce += double.Parse(lvRegistro.Items[i].SubItems[3].Text);

                }
                else if (lvRegistro.Items[i].SubItems[1].Text == "Silver")
                {
                    cSilver += int.Parse(lvRegistro.Items[i].SubItems[2].Text);
                    tSilver += double.Parse(lvRegistro.Items[i].SubItems[3].Text);

                }
                else if (lvRegistro.Items[i].SubItems[1].Text == "Gold")
                {
                    cGold += int.Parse(lvRegistro.Items[i].SubItems[2].Text);
                    tGold += double.Parse(lvRegistro.Items[i].SubItems[3].Text);

                }
                i++;

            }

            //Impremiedo las estadisticas
            lvEstadisticas.Items.Clear();
            string[] elementosFila = new string[3];
            ListViewItem row;

            elementosFila[0] = "Total Cobre";
            elementosFila[1] = "cCobre.ToString()";
            elementosFila[2] = "tCobre.ToString()";
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);
            elementosFila[0] = "Total Bronce";
            elementosFila[1] = "cBronce.ToString()";
            elementosFila[2] = "tBronce.ToString()";
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);
            elementosFila[0] = "Total Silver";
            elementosFila[1] = "cSilver.ToString()";
            elementosFila[2] = "tSilver.ToString()";
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);
            elementosFila[0] = "Total Gold";
            elementosFila[1] = "cGold.ToString()";
            elementosFila[2] = "tGold.ToString()";
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);
        }

        private void btnNuevaFact_Click(object sender, EventArgs e)
        {
            txtNumFact.Clear();
            txtUnidades.Clear();
            cboTipo.Text = "Seleccione";
            txtNumFact.Focus();
        }
    }
}
