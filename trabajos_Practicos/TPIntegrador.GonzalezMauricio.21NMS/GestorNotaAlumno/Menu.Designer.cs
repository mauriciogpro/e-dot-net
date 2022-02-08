namespace GestorNotaAlumno
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresoDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeDatosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeDatosToolStripMenuItem,
            this.estadisticasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresoDeDatosToolStripMenuItem
            // 
            this.ingresoDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeDatosToolStripMenuItem1,
            this.listadoDeAlumnosToolStripMenuItem});
            this.ingresoDeDatosToolStripMenuItem.Name = "ingresoDeDatosToolStripMenuItem";
            this.ingresoDeDatosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ingresoDeDatosToolStripMenuItem.Text = "Alumno";
            // 
            // ingresoDeDatosToolStripMenuItem1
            // 
            this.ingresoDeDatosToolStripMenuItem1.Name = "ingresoDeDatosToolStripMenuItem1";
            this.ingresoDeDatosToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.ingresoDeDatosToolStripMenuItem1.Text = "Ingreso de Datos";
            this.ingresoDeDatosToolStripMenuItem1.Click += new System.EventHandler(this.ingresoDeDatosToolStripMenuItem1_Click);
            // 
            // listadoDeAlumnosToolStripMenuItem
            // 
            this.listadoDeAlumnosToolStripMenuItem.Name = "listadoDeAlumnosToolStripMenuItem";
            this.listadoDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.listadoDeAlumnosToolStripMenuItem.Text = "Listado de Alumnos";
            this.listadoDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeAlumnosToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 332);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeDatosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listadoDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}