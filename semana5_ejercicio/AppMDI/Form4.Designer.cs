namespace MDIEstudiantes
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblTotalEstudiantes;
        private System.Windows.Forms.Label lblMejorPromedio;
        private System.Windows.Forms.Label lblPromedioGeneral;
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblTotalEstudiantes = new System.Windows.Forms.Label();
            this.lblMejorPromedio = new System.Windows.Forms.Label();
            this.lblPromedioGeneral = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Silver;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(20, 23);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Promedios";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(800, 431);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(727, 18);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 37);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblTotalEstudiantes
            // 
            this.lblTotalEstudiantes.AutoSize = true;
            this.lblTotalEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEstudiantes.Location = new System.Drawing.Point(57, 21);
            this.lblTotalEstudiantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalEstudiantes.Name = "lblTotalEstudiantes";
            this.lblTotalEstudiantes.Size = new System.Drawing.Size(142, 18);
            this.lblTotalEstudiantes.TabIndex = 2;
            this.lblTotalEstudiantes.Text = "Total estudiantes:";
            this.lblTotalEstudiantes.Click += new System.EventHandler(this.lblTotalEstudiantes_Click);
            // 
            // lblMejorPromedio
            // 
            this.lblMejorPromedio.AutoSize = true;
            this.lblMejorPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMejorPromedio.Location = new System.Drawing.Point(280, 21);
            this.lblMejorPromedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMejorPromedio.Name = "lblMejorPromedio";
            this.lblMejorPromedio.Size = new System.Drawing.Size(132, 18);
            this.lblMejorPromedio.TabIndex = 3;
            this.lblMejorPromedio.Text = "Mejor promedio:";
            // 
            // lblPromedioGeneral
            // 
            this.lblPromedioGeneral.AutoSize = true;
            this.lblPromedioGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioGeneral.Location = new System.Drawing.Point(484, 21);
            this.lblPromedioGeneral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedioGeneral.Name = "lblPromedioGeneral";
            this.lblPromedioGeneral.Size = new System.Drawing.Size(146, 18);
            this.lblPromedioGeneral.TabIndex = 4;
            this.lblPromedioGeneral.Text = "Promedio general:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(26, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(853, 447);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gráfico de Mejores Promedios";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(979, 619);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblTotalEstudiantes);
            this.Controls.Add(this.lblPromedioGeneral);
            this.Controls.Add(this.lblMejorPromedio);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráfico de Promedios";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}