namespace MDIEstudiantes
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstudiantes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.GroupBox groupBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstudiantes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carnet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(101, 95);
            this.txtCarnet.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.ReadOnly = true;
            this.txtCarnet.Size = new System.Drawing.Size(199, 22);
            this.txtCarnet.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 127);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(399, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asignatura,
            this.Nota});
            this.dgvDatos.Location = new System.Drawing.Point(35, 39);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.Size = new System.Drawing.Size(539, 246);
            this.dgvDatos.TabIndex = 4;
            // 
            // Asignatura
            // 
            this.Asignatura.HeaderText = "Asignatura";
            this.Asignatura.MinimumWidth = 6;
            this.Asignatura.Name = "Asignatura";
            this.Asignatura.ReadOnly = true;
            this.Asignatura.Width = 200;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota Final";
            this.Nota.MinimumWidth = 6;
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            this.Nota.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Asignaturas Cursadas:";
            // 
            // cmbEstudiantes
            // 
            this.cmbEstudiantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudiantes.FormattingEnabled = true;
            this.cmbEstudiantes.Location = new System.Drawing.Point(101, 32);
            this.cmbEstudiantes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstudiantes.Name = "cmbEstudiantes";
            this.cmbEstudiantes.Size = new System.Drawing.Size(399, 24);
            this.cmbEstudiantes.TabIndex = 6;
            this.cmbEstudiantes.SelectedIndexChanged += new System.EventHandler(this.cmbEstudiantes_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estudiante:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(509, 30);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 28);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Promedio:";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(101, 159);
            this.txtPromedio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(132, 22);
            this.txtPromedio.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDatos);
            this.groupBox1.Location = new System.Drawing.Point(34, 247);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(600, 308);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignaturas y Notas";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(707, 585);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEstudiantes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualización de Estudiantes";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
    }
}