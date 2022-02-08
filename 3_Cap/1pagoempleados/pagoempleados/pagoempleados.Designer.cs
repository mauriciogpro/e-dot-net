namespace pagoempleados
{
    partial class formPagoEmpleado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMontoBruto = new System.Windows.Forms.Label();
            this.LlMontoBruto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LMontobruto = new System.Windows.Forms.Label();
            this.bntProcesar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de pago de empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "EMPLEADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "HORAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "COSTO HORAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "MONTO BRUTO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "MONTO DESCUENTO";
            // 
            // lblMontoBruto
            // 
            this.lblMontoBruto.AutoSize = true;
            this.lblMontoBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMontoBruto.Location = new System.Drawing.Point(54, 85);
            this.lblMontoBruto.Name = "lblMontoBruto";
            this.lblMontoBruto.Size = new System.Drawing.Size(2, 15);
            this.lblMontoBruto.TabIndex = 6;
            // 
            // LlMontoBruto
            // 
            this.LlMontoBruto.AutoSize = true;
            this.LlMontoBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LlMontoBruto.Location = new System.Drawing.Point(207, 85);
            this.LlMontoBruto.Name = "LlMontoBruto";
            this.LlMontoBruto.Size = new System.Drawing.Size(2, 15);
            this.LlMontoBruto.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "MONTO NETO";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // LMontobruto
            // 
            this.LMontobruto.AutoSize = true;
            this.LMontobruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LMontobruto.Location = new System.Drawing.Point(405, 85);
            this.LMontobruto.Name = "LMontobruto";
            this.LMontobruto.Size = new System.Drawing.Size(2, 15);
            this.LMontobruto.TabIndex = 9;
            // 
            // bntProcesar
            // 
            this.bntProcesar.Location = new System.Drawing.Point(52, 153);
            this.bntProcesar.Name = "bntProcesar";
            this.bntProcesar.Size = new System.Drawing.Size(75, 23);
            this.bntProcesar.TabIndex = 10;
            this.bntProcesar.Text = "PROCESAR";
            this.bntProcesar.UseVisualStyleBackColor = true;
            this.bntProcesar.Click += new System.EventHandler(this.bntProcesar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(509, 153);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(40, 370);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 44);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LMontobruto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.LlMontoBruto);
            this.groupBox1.Controls.Add(this.lblMontoBruto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(52, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 131);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUADRO RESUMEN";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(121, 45);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(482, 20);
            this.txtEmpleado.TabIndex = 14;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(121, 91);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(211, 20);
            this.txtHoras.TabIndex = 14;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(429, 91);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(173, 20);
            this.txtCosto.TabIndex = 14;
            // 
            // formPagoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 413);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.bntProcesar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formPagoEmpleado";
            this.Text = "Control de pago de empleados";
            this.Load += new System.EventHandler(this.pagoempleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMontoBruto;
        private System.Windows.Forms.Label LlMontoBruto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LMontobruto;
        private System.Windows.Forms.Button bntProcesar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtCosto;
    }
}

