namespace EjerciciosSem1
{
    partial class Form1
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
            this.tBUsuario = new System.Windows.Forms.TextBox();
            this.tBContraseña = new System.Windows.Forms.TextBox();
            this.ctlogin = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.login = new System.Windows.Forms.TabPage();
            this.imc_peso = new System.Windows.Forms.TabPage();
            this.tBclasificacion = new System.Windows.Forms.TextBox();
            this.tBimc = new System.Windows.Forms.TextBox();
            this.tBaltura = new System.Windows.Forms.TextBox();
            this.tBpeso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btConvertir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.count_clics = new System.Windows.Forms.TabPage();
            this.btclic = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.TabPage();
            this.bTconvert = new System.Windows.Forms.Button();
            this.cBtemps = new System.Windows.Forms.ComboBox();
            this.tBresul = new System.Windows.Forms.TextBox();
            this.tBdato = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.login.SuspendLayout();
            this.imc_peso.SuspendLayout();
            this.count_clics.SuspendLayout();
            this.temp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "contraseña:";
            // 
            // tBUsuario
            // 
            this.tBUsuario.Location = new System.Drawing.Point(107, 100);
            this.tBUsuario.Name = "tBUsuario";
            this.tBUsuario.Size = new System.Drawing.Size(100, 22);
            this.tBUsuario.TabIndex = 2;
            this.tBUsuario.TextChanged += new System.EventHandler(this.tBUsuario_TextChanged);
            // 
            // tBContraseña
            // 
            this.tBContraseña.Location = new System.Drawing.Point(107, 143);
            this.tBContraseña.Name = "tBContraseña";
            this.tBContraseña.PasswordChar = '*';
            this.tBContraseña.Size = new System.Drawing.Size(100, 22);
            this.tBContraseña.TabIndex = 3;
            // 
            // ctlogin
            // 
            this.ctlogin.Location = new System.Drawing.Point(244, 110);
            this.ctlogin.Name = "ctlogin";
            this.ctlogin.Size = new System.Drawing.Size(153, 55);
            this.ctlogin.TabIndex = 4;
            this.ctlogin.Text = "ingresar";
            this.ctlogin.UseVisualStyleBackColor = true;
            this.ctlogin.Click += new System.EventHandler(this.ctlogin_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.login);
            this.tabControl1.Controls.Add(this.imc_peso);
            this.tabControl1.Controls.Add(this.count_clics);
            this.tabControl1.Controls.Add(this.temp);
            this.tabControl1.Location = new System.Drawing.Point(12, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 477);
            this.tabControl1.TabIndex = 5;
            // 
            // login
            // 
            this.login.Controls.Add(this.ctlogin);
            this.login.Controls.Add(this.tBUsuario);
            this.login.Controls.Add(this.label2);
            this.login.Controls.Add(this.tBContraseña);
            this.login.Controls.Add(this.label1);
            this.login.Location = new System.Drawing.Point(4, 25);
            this.login.Name = "login";
            this.login.Padding = new System.Windows.Forms.Padding(3);
            this.login.Size = new System.Drawing.Size(768, 448);
            this.login.TabIndex = 0;
            this.login.Text = "iniciar sesion";
            this.login.UseVisualStyleBackColor = true;
            // 
            // imc_peso
            // 
            this.imc_peso.Controls.Add(this.tBclasificacion);
            this.imc_peso.Controls.Add(this.tBimc);
            this.imc_peso.Controls.Add(this.tBaltura);
            this.imc_peso.Controls.Add(this.tBpeso);
            this.imc_peso.Controls.Add(this.label8);
            this.imc_peso.Controls.Add(this.btConvertir);
            this.imc_peso.Controls.Add(this.label7);
            this.imc_peso.Controls.Add(this.label6);
            this.imc_peso.Controls.Add(this.label5);
            this.imc_peso.Controls.Add(this.label4);
            this.imc_peso.Location = new System.Drawing.Point(4, 25);
            this.imc_peso.Name = "imc_peso";
            this.imc_peso.Padding = new System.Windows.Forms.Padding(3);
            this.imc_peso.Size = new System.Drawing.Size(768, 448);
            this.imc_peso.TabIndex = 1;
            this.imc_peso.Text = "IMC";
            this.imc_peso.UseVisualStyleBackColor = true;
            // 
            // tBclasificacion
            // 
            this.tBclasificacion.Location = new System.Drawing.Point(509, 336);
            this.tBclasificacion.Name = "tBclasificacion";
            this.tBclasificacion.Size = new System.Drawing.Size(170, 22);
            this.tBclasificacion.TabIndex = 9;
            // 
            // tBimc
            // 
            this.tBimc.Location = new System.Drawing.Point(48, 336);
            this.tBimc.Name = "tBimc";
            this.tBimc.Size = new System.Drawing.Size(140, 22);
            this.tBimc.TabIndex = 8;
            // 
            // tBaltura
            // 
            this.tBaltura.Location = new System.Drawing.Point(509, 100);
            this.tBaltura.Name = "tBaltura";
            this.tBaltura.Size = new System.Drawing.Size(170, 22);
            this.tBaltura.TabIndex = 7;
            // 
            // tBpeso
            // 
            this.tBpeso.Location = new System.Drawing.Point(48, 101);
            this.tBpeso.Name = "tBpeso";
            this.tBpeso.Size = new System.Drawing.Size(140, 22);
            this.tBpeso.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(696, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "en Metros";
            // 
            // btConvertir
            // 
            this.btConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConvertir.Location = new System.Drawing.Point(299, 133);
            this.btConvertir.Name = "btConvertir";
            this.btConvertir.Size = new System.Drawing.Size(178, 106);
            this.btConvertir.TabIndex = 4;
            this.btConvertir.Text = "Convertir";
            this.btConvertir.UseVisualStyleBackColor = true;
            this.btConvertir.Click += new System.EventHandler(this.btConvertir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(503, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "Clasificacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(321, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Indice de Masa Corporal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(478, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ingrese su altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ingrese su peso";
            // 
            // count_clics
            // 
            this.count_clics.Controls.Add(this.btclic);
            this.count_clics.Controls.Add(this.label3);
            this.count_clics.Location = new System.Drawing.Point(4, 25);
            this.count_clics.Name = "count_clics";
            this.count_clics.Padding = new System.Windows.Forms.Padding(3);
            this.count_clics.Size = new System.Drawing.Size(768, 448);
            this.count_clics.TabIndex = 2;
            this.count_clics.Text = "Contador de clics";
            this.count_clics.UseVisualStyleBackColor = true;
            // 
            // btclic
            // 
            this.btclic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclic.Location = new System.Drawing.Point(450, 133);
            this.btclic.Name = "btclic";
            this.btclic.Size = new System.Drawing.Size(286, 97);
            this.btclic.TabIndex = 1;
            this.btclic.Text = "Da un clic!!!";
            this.btclic.UseVisualStyleBackColor = true;
            this.btclic.Click += new System.EventHandler(this.btclic_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 54);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contador de clics";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // temp
            // 
            this.temp.Controls.Add(this.bTconvert);
            this.temp.Controls.Add(this.cBtemps);
            this.temp.Controls.Add(this.tBresul);
            this.temp.Controls.Add(this.tBdato);
            this.temp.Controls.Add(this.label11);
            this.temp.Controls.Add(this.label10);
            this.temp.Controls.Add(this.label9);
            this.temp.Location = new System.Drawing.Point(4, 25);
            this.temp.Name = "temp";
            this.temp.Padding = new System.Windows.Forms.Padding(3);
            this.temp.Size = new System.Drawing.Size(768, 448);
            this.temp.TabIndex = 3;
            this.temp.Text = "Temperatura °c";
            this.temp.UseVisualStyleBackColor = true;
            // 
            // bTconvert
            // 
            this.bTconvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTconvert.Location = new System.Drawing.Point(458, 207);
            this.bTconvert.Name = "bTconvert";
            this.bTconvert.Size = new System.Drawing.Size(116, 50);
            this.bTconvert.TabIndex = 6;
            this.bTconvert.Text = "Convertir";
            this.bTconvert.UseVisualStyleBackColor = true;
            this.bTconvert.Click += new System.EventHandler(this.bTconvert_Click);
            // 
            // cBtemps
            // 
            this.cBtemps.FormattingEnabled = true;
            this.cBtemps.Items.AddRange(new object[] {
            "Fahrenheit a Celsius",
            "Celsius a Fahrenheit"});
            this.cBtemps.Location = new System.Drawing.Point(75, 243);
            this.cBtemps.Name = "cBtemps";
            this.cBtemps.Size = new System.Drawing.Size(217, 24);
            this.cBtemps.TabIndex = 5;
            this.cBtemps.SelectedIndexChanged += new System.EventHandler(this.cBtemps_SelectedIndexChanged);
            // 
            // tBresul
            // 
            this.tBresul.Location = new System.Drawing.Point(458, 294);
            this.tBresul.Name = "tBresul";
            this.tBresul.Size = new System.Drawing.Size(100, 22);
            this.tBresul.TabIndex = 4;
            // 
            // tBdato
            // 
            this.tBdato.Location = new System.Drawing.Point(461, 163);
            this.tBdato.Name = "tBdato";
            this.tBdato.Size = new System.Drawing.Size(100, 22);
            this.tBdato.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(458, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Resultado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(455, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Dato";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 42);
            this.label9.TabIndex = 0;
            this.label9.Text = "Temperaturas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 489);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "practica 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.imc_peso.ResumeLayout(false);
            this.imc_peso.PerformLayout();
            this.count_clics.ResumeLayout(false);
            this.count_clics.PerformLayout();
            this.temp.ResumeLayout(false);
            this.temp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBUsuario;
        private System.Windows.Forms.TextBox tBContraseña;
        private System.Windows.Forms.Button ctlogin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage login;
        private System.Windows.Forms.TabPage imc_peso;
        private System.Windows.Forms.TabPage count_clics;
        private System.Windows.Forms.TabPage temp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btclic;
        private System.Windows.Forms.Button btConvertir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBclasificacion;
        private System.Windows.Forms.TextBox tBimc;
        private System.Windows.Forms.TextBox tBaltura;
        private System.Windows.Forms.TextBox tBpeso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bTconvert;
        private System.Windows.Forms.ComboBox cBtemps;
        private System.Windows.Forms.TextBox tBresul;
        private System.Windows.Forms.TextBox tBdato;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

