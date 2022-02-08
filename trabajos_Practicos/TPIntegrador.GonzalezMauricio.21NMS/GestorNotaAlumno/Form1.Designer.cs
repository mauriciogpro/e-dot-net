namespace GestorNotaAlumno
{
    partial class frmCarga
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarga));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label materiaLabel;
            System.Windows.Forms.Label cicloLectivoLabel;
            System.Windows.Forms.Label notaParcial1Label;
            System.Windows.Forms.Label notaParcial2Label;
            System.Windows.Forms.Label notaTrabajoPLabel;
            this.alumnosDataSet = new GestorNotaAlumno.AlumnosDataSet();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter = new GestorNotaAlumno.AlumnosDataSetTableAdapters.AlumnosTableAdapter();
            this.tableAdapterManager = new GestorNotaAlumno.AlumnosDataSetTableAdapters.TableAdapterManager();
            this.alumnosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.alumnosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.alumnosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.materiaTextBox = new System.Windows.Forms.TextBox();
            this.cicloLectivoTextBox = new System.Windows.Forms.TextBox();
            this.notaParcial1TextBox = new System.Windows.Forms.TextBox();
            this.notaParcial2TextBox = new System.Windows.Forms.TextBox();
            this.notaTrabajoPTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            materiaLabel = new System.Windows.Forms.Label();
            cicloLectivoLabel = new System.Windows.Forms.Label();
            notaParcial1Label = new System.Windows.Forms.Label();
            notaParcial2Label = new System.Windows.Forms.Label();
            notaTrabajoPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingNavigator)).BeginInit();
            this.alumnosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // alumnosDataSet
            // 
            this.alumnosDataSet.DataSetName = "AlumnosDataSet";
            this.alumnosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.alumnosDataSet;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnosTableAdapter = this.alumnosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = GestorNotaAlumno.AlumnosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alumnosBindingNavigator
            // 
            this.alumnosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.alumnosBindingNavigator.BindingSource = this.alumnosBindingSource;
            this.alumnosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.alumnosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.alumnosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.alumnosBindingNavigatorSaveItem});
            this.alumnosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.alumnosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.alumnosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.alumnosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.alumnosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.alumnosBindingNavigator.Name = "alumnosBindingNavigator";
            this.alumnosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.alumnosBindingNavigator.Size = new System.Drawing.Size(1255, 25);
            this.alumnosBindingNavigator.TabIndex = 0;
            this.alumnosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // alumnosBindingNavigatorSaveItem
            // 
            this.alumnosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alumnosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("alumnosBindingNavigatorSaveItem.Image")));
            this.alumnosBindingNavigatorSaveItem.Name = "alumnosBindingNavigatorSaveItem";
            this.alumnosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.alumnosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.alumnosBindingNavigatorSaveItem.Click += new System.EventHandler(this.alumnosBindingNavigatorSaveItem_Click);
            // 
            // alumnosDataGridView
            // 
            this.alumnosDataGridView.AutoGenerateColumns = false;
            this.alumnosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alumnosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.alumnosDataGridView.DataSource = this.alumnosBindingSource;
            this.alumnosDataGridView.Location = new System.Drawing.Point(286, 12);
            this.alumnosDataGridView.Name = "alumnosDataGridView";
            this.alumnosDataGridView.Size = new System.Drawing.Size(949, 389);
            this.alumnosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Matricula";
            this.dataGridViewTextBoxColumn2.HeaderText = "Matricula";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn4.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Materia";
            this.dataGridViewTextBoxColumn5.HeaderText = "Materia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CicloLectivo";
            this.dataGridViewTextBoxColumn6.HeaderText = "CicloLectivo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NotaParcial1";
            this.dataGridViewTextBoxColumn7.HeaderText = "NotaParcial1";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NotaParcial2";
            this.dataGridViewTextBoxColumn8.HeaderText = "NotaParcial2";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NotaTrabajoP";
            this.dataGridViewTextBoxColumn9.HeaderText = "NotaTrabajoP";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(39, 62);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(127, 59);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(39, 88);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(53, 13);
            matriculaLabel.TabIndex = 4;
            matriculaLabel.Text = "Matricula:";
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(127, 85);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(100, 20);
            this.matriculaTextBox.TabIndex = 5;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(39, 114);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(127, 111);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 7;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(39, 140);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 8;
            apellidoLabel.Text = "Apellido:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(127, 137);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoTextBox.TabIndex = 9;
            // 
            // materiaLabel
            // 
            materiaLabel.AutoSize = true;
            materiaLabel.Location = new System.Drawing.Point(39, 166);
            materiaLabel.Name = "materiaLabel";
            materiaLabel.Size = new System.Drawing.Size(45, 13);
            materiaLabel.TabIndex = 10;
            materiaLabel.Text = "Materia:";
            // 
            // materiaTextBox
            // 
            this.materiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Materia", true));
            this.materiaTextBox.Location = new System.Drawing.Point(127, 163);
            this.materiaTextBox.Name = "materiaTextBox";
            this.materiaTextBox.Size = new System.Drawing.Size(100, 20);
            this.materiaTextBox.TabIndex = 11;
            // 
            // cicloLectivoLabel
            // 
            cicloLectivoLabel.AutoSize = true;
            cicloLectivoLabel.Location = new System.Drawing.Point(39, 192);
            cicloLectivoLabel.Name = "cicloLectivoLabel";
            cicloLectivoLabel.Size = new System.Drawing.Size(71, 13);
            cicloLectivoLabel.TabIndex = 12;
            cicloLectivoLabel.Text = "Ciclo Lectivo:";
            // 
            // cicloLectivoTextBox
            // 
            this.cicloLectivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "CicloLectivo", true));
            this.cicloLectivoTextBox.Location = new System.Drawing.Point(127, 189);
            this.cicloLectivoTextBox.Name = "cicloLectivoTextBox";
            this.cicloLectivoTextBox.Size = new System.Drawing.Size(100, 20);
            this.cicloLectivoTextBox.TabIndex = 13;
            // 
            // notaParcial1Label
            // 
            notaParcial1Label.AutoSize = true;
            notaParcial1Label.Location = new System.Drawing.Point(39, 218);
            notaParcial1Label.Name = "notaParcial1Label";
            notaParcial1Label.Size = new System.Drawing.Size(74, 13);
            notaParcial1Label.TabIndex = 14;
            notaParcial1Label.Text = "Nota Parcial1:";
            // 
            // notaParcial1TextBox
            // 
            this.notaParcial1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "NotaParcial1", true));
            this.notaParcial1TextBox.Location = new System.Drawing.Point(127, 215);
            this.notaParcial1TextBox.Name = "notaParcial1TextBox";
            this.notaParcial1TextBox.Size = new System.Drawing.Size(100, 20);
            this.notaParcial1TextBox.TabIndex = 15;
            // 
            // notaParcial2Label
            // 
            notaParcial2Label.AutoSize = true;
            notaParcial2Label.Location = new System.Drawing.Point(39, 244);
            notaParcial2Label.Name = "notaParcial2Label";
            notaParcial2Label.Size = new System.Drawing.Size(74, 13);
            notaParcial2Label.TabIndex = 16;
            notaParcial2Label.Text = "Nota Parcial2:";
            // 
            // notaParcial2TextBox
            // 
            this.notaParcial2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "NotaParcial2", true));
            this.notaParcial2TextBox.Location = new System.Drawing.Point(127, 241);
            this.notaParcial2TextBox.Name = "notaParcial2TextBox";
            this.notaParcial2TextBox.Size = new System.Drawing.Size(100, 20);
            this.notaParcial2TextBox.TabIndex = 17;
            // 
            // notaTrabajoPLabel
            // 
            notaTrabajoPLabel.AutoSize = true;
            notaTrabajoPLabel.Location = new System.Drawing.Point(39, 270);
            notaTrabajoPLabel.Name = "notaTrabajoPLabel";
            notaTrabajoPLabel.Size = new System.Drawing.Size(82, 13);
            notaTrabajoPLabel.TabIndex = 18;
            notaTrabajoPLabel.Text = "Nota Trabajo P:";
            // 
            // notaTrabajoPTextBox
            // 
            this.notaTrabajoPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "NotaTrabajoP", true));
            this.notaTrabajoPTextBox.Location = new System.Drawing.Point(127, 267);
            this.notaTrabajoPTextBox.Name = "notaTrabajoPTextBox";
            this.notaTrabajoPTextBox.Size = new System.Drawing.Size(100, 20);
            this.notaTrabajoPTextBox.TabIndex = 19;
            // 
            // frmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 421);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(materiaLabel);
            this.Controls.Add(this.materiaTextBox);
            this.Controls.Add(cicloLectivoLabel);
            this.Controls.Add(this.cicloLectivoTextBox);
            this.Controls.Add(notaParcial1Label);
            this.Controls.Add(this.notaParcial1TextBox);
            this.Controls.Add(notaParcial2Label);
            this.Controls.Add(this.notaParcial2TextBox);
            this.Controls.Add(notaTrabajoPLabel);
            this.Controls.Add(this.notaTrabajoPTextBox);
            this.Controls.Add(this.alumnosDataGridView);
            this.Controls.Add(this.alumnosBindingNavigator);
            this.Name = "frmCarga";
            this.Text = "Ingreso de Datos de Alumno";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingNavigator)).EndInit();
            this.alumnosBindingNavigator.ResumeLayout(false);
            this.alumnosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AlumnosDataSet alumnosDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private AlumnosDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private AlumnosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator alumnosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton alumnosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView alumnosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox materiaTextBox;
        private System.Windows.Forms.TextBox cicloLectivoTextBox;
        private System.Windows.Forms.TextBox notaParcial1TextBox;
        private System.Windows.Forms.TextBox notaParcial2TextBox;
        private System.Windows.Forms.TextBox notaTrabajoPTextBox;
    }
}

