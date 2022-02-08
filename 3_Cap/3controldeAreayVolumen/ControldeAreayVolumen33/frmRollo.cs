﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControldeAreayVolumen33
{
    public partial class frmRollo : Form
    {
        public frmRollo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura = double.Parse(txtAltura.Text);
            double diametro = double.Parse(txtDiametro.Text);

            //realizando calculo
            double radio = diametro / 2;
            double area = (2 * Math.PI * radio) * (radio + altura);
            double volumen = Math.PI * Math.Pow(radio, 2) * altura;

            //Mostrando los resultados en el cuadro de texto
            txtR.Text = "**RESUMEN DE VOLUMEN Y AREAS**";
            txtR.Text += "\r\nValor Altura: " + altura.ToString("0.00");
            txtR.Text += "\r\nValor Diametro: " + diametro.ToString("0.00");
            txtR.Text += "\r\n-------------------------------";
            txtR.Text += "\r\nRADIO: " + radio.ToString("0.00");
            txtR.Text += "\r\nAREA: " + area.ToString("0.00");
            txtR.Text += "\r\nVOLUMEN: " + volumen.ToString("0.00");


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtDiametro.Clear();
            txtR.Clear();
            txtAltura.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Medidas", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes) this.Close();
        }
    }
}
