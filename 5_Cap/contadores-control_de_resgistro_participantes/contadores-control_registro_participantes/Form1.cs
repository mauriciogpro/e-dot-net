using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contadores_control_registro_participantes
{
    public partial class Form1 : Form
    {

        int num;
        int cJefe, cOperario, cAdministrativo, cPracticante;


        public Form1()
        {

            InitializeComponent();
            //@mau: activa al componente forms timer. que con un evento
            // que se activa cada segundo es posible marcar la hora con
            // segundos para mostrarla usando el evento tick
            tHora.Enabled = true;
                
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            //capturando los datos
            //@se vuelven a declarar las variables pero ahora toman el 
            // valor que se estaba asignando con el load y el tick
            // y los valores selecionados del cbobox
            DateTime fecha, hora;
            string participante, cargo;
            int numero;
            participante = txtParticipante.Text;
            numero = int.Parse(lblNumero.Text);
            fecha = DateTime.Parse(lblFecha.Text);
            hora = DateTime.Parse(lblHora.Text);
            cargo = cboCArgo.Text;

            //contabilizar la cantidad segun los cargos
            //@mau: se usa el switch para contar los cargos
            switch (cargo)
            {
                case "Jefe": cJefe++; break;
                case "Operario": cOperario++; break;
                case "Administrativo": cAdministrativo++; break;
                case "Practicante": cPracticante++; break;
            }

            //imprimiendo el registro
            // metodo tradicional para registrar datos en el list view

            
            ListViewItem fila = new ListViewItem(numero.ToString());
            fila.SubItems.Add(participante);
            fila.SubItems.Add(cargo);
            fila.SubItems.Add(fecha.ToString("d"));
            fila.SubItems.Add(hora.ToString("hh:mm:ss"));
            lvParticipantes.Items.Add(fila);

            // Imprimiendo estadisticas

                //@mau: se limpia el campo
            lvEstadisticas.Items.Clear();
                //@mau: se declara un array
            string[] elementosFila = new string[2];
                //@mau: se declara un fila
            ListViewItem row;

            //Añadimos la primera fial al lvEstadisticas
                // se indica el nombre de la fila
            elementosFila[0] = "Jefe";
                //@mau: se guardan los numero del contador que estaba
                // en el switch
            elementosFila[1] = cJefe.ToString();
                // se agrega el listado al row
            row = new ListViewItem(elementosFila);
                // se agrega el row al list view
            lvEstadisticas.Items.Add(row);

            // Añadimos segunda fila al lvEstadisticas
            elementosFila[0] = "Operario";
            elementosFila[1] = cOperario.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            // Añadimos tercera fila al lvEstadisticas
            elementosFila[0] = "Administrativo";
            elementosFila[1] = cAdministrativo.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            // Añadimos cuarta fila al lvEstadisticas
            elementosFila[0] = "Practicante";
            elementosFila[1] = cPracticante.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            //Mostrando el nuevo numero de registro
            num++;
            lblNumero.Text = num.ToString("D4");
            //limpiando los controles
            txtParticipante.Clear();
            cboCArgo.SelectedIndex = -1;
            txtParticipante.Focus();
        }

        private void tHora_Tick_1(object sender, EventArgs e)
        {
           lblHora.Text = DateTime.Now.ToString("hh:mm:ss");            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Participantes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            num++;
            lblFecha.Text = DateTime.Now.Date.ToString("d");
            lblNumero.Text = num.ToString("D4");
        }

      


    }
}
