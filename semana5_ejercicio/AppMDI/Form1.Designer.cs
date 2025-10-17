namespace MDIEstudiantes
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnForm2;
        private System.Windows.Forms.ToolStripButton btnForm3;
        private System.Windows.Forms.ToolStripButton btnForm4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnForm2 = new System.Windows.Forms.ToolStripButton();
            this.btnForm3 = new System.Windows.Forms.ToolStripButton();
            this.btnForm4 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnForm2,
            this.btnForm3,
            this.btnForm4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1312, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnForm2
            // 
            this.btnForm2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(139, 24);
            this.btnForm2.Text = "Ingresar Estudiante";
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // btnForm3
            // 
            this.btnForm3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(113, 24);
            this.btnForm3.Text = "Ver Estudiantes";
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // btnForm4
            // 
            this.btnForm4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnForm4.Name = "btnForm4";
            this.btnForm4.Size = new System.Drawing.Size(65, 24);
            this.btnForm4.Text = "Gráfico ";
            this.btnForm4.Click += new System.EventHandler(this.btnForm4_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 664);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1312, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(209, 20);
            this.lblEstado.Text = "Sistema de Gestión Estudiantil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiantes";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }

    #endregion
}
