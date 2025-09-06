namespace semana3_gestordetareas
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.TxCodigotarea = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.TxNombretarea = new System.Windows.Forms.TextBox();
            this.TxDescripciontarea = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.DtpFechas = new System.Windows.Forms.DateTimePicker();
            this.lblLugar = new System.Windows.Forms.Label();
            this.TxLugar = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.BtAgregartarea = new System.Windows.Forms.Button();
            this.BtEditartarea = new System.Windows.Forms.Button();
            this.BtEliminartarea = new System.Windows.Forms.Button();
            this.DgvMostrartareas = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.CmbBusqueda = new System.Windows.Forms.ComboBox();
            this.TxTBuscartareas = new System.Windows.Forms.TextBox();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.BtRecargar = new System.Windows.Forms.Button();
            this.CbEstadoBusqueda = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrartareas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(33, 84);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 23);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // TxCodigotarea
            // 
            this.TxCodigotarea.BackColor = System.Drawing.SystemColors.Info;
            this.TxCodigotarea.Location = new System.Drawing.Point(137, 86);
            this.TxCodigotarea.Name = "TxCodigotarea";
            this.TxCodigotarea.Size = new System.Drawing.Size(273, 22);
            this.TxCodigotarea.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(33, 129);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 23);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // TxNombretarea
            // 
            this.TxNombretarea.BackColor = System.Drawing.SystemColors.Info;
            this.TxNombretarea.Location = new System.Drawing.Point(137, 131);
            this.TxNombretarea.Name = "TxNombretarea";
            this.TxNombretarea.Size = new System.Drawing.Size(273, 22);
            this.TxNombretarea.TabIndex = 3;
            // 
            // TxDescripciontarea
            // 
            this.TxDescripciontarea.BackColor = System.Drawing.SystemColors.Info;
            this.TxDescripciontarea.Location = new System.Drawing.Point(137, 171);
            this.TxDescripciontarea.Multiline = true;
            this.TxDescripciontarea.Name = "TxDescripciontarea";
            this.TxDescripciontarea.Size = new System.Drawing.Size(273, 60);
            this.TxDescripciontarea.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(33, 169);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(98, 23);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(41, 258);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(170, 23);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de Realización";
            // 
            // DtpFechas
            // 
            this.DtpFechas.CalendarTitleForeColor = System.Drawing.SystemColors.Info;
            this.DtpFechas.Location = new System.Drawing.Point(219, 258);
            this.DtpFechas.Name = "DtpFechas";
            this.DtpFechas.Size = new System.Drawing.Size(200, 22);
            this.DtpFechas.TabIndex = 7;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.Location = new System.Drawing.Point(41, 303);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(53, 23);
            this.lblLugar.TabIndex = 8;
            this.lblLugar.Text = "Lugar";
            // 
            // TxLugar
            // 
            this.TxLugar.BackColor = System.Drawing.SystemColors.Info;
            this.TxLugar.Location = new System.Drawing.Point(137, 303);
            this.TxLugar.Name = "TxLugar";
            this.TxLugar.Size = new System.Drawing.Size(273, 22);
            this.TxLugar.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(41, 338);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(61, 23);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado";
            // 
            // CmbEstado
            // 
            this.CmbEstado.BackColor = System.Drawing.SystemColors.Info;
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "No realizada",
            "En Proceso",
            "Terminada"});
            this.CmbEstado.Location = new System.Drawing.Point(103, 337);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(307, 24);
            this.CmbEstado.TabIndex = 11;
            // 
            // BtAgregartarea
            // 
            this.BtAgregartarea.AllowDrop = true;
            this.BtAgregartarea.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtAgregartarea.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAgregartarea.Location = new System.Drawing.Point(37, 369);
            this.BtAgregartarea.Name = "BtAgregartarea";
            this.BtAgregartarea.Size = new System.Drawing.Size(161, 97);
            this.BtAgregartarea.TabIndex = 12;
            this.BtAgregartarea.Text = "Agregar Tarea";
            this.BtAgregartarea.UseVisualStyleBackColor = false;
            this.BtAgregartarea.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // BtEditartarea
            // 
            this.BtEditartarea.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtEditartarea.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEditartarea.Location = new System.Drawing.Point(204, 368);
            this.BtEditartarea.Name = "BtEditartarea";
            this.BtEditartarea.Size = new System.Drawing.Size(161, 98);
            this.BtEditartarea.TabIndex = 13;
            this.BtEditartarea.Text = "Editar Tarea";
            this.BtEditartarea.UseVisualStyleBackColor = false;
            this.BtEditartarea.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // BtEliminartarea
            // 
            this.BtEliminartarea.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtEliminartarea.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminartarea.Location = new System.Drawing.Point(371, 368);
            this.BtEliminartarea.Name = "BtEliminartarea";
            this.BtEliminartarea.Size = new System.Drawing.Size(161, 98);
            this.BtEliminartarea.TabIndex = 14;
            this.BtEliminartarea.Text = "Eliminar Tarea";
            this.BtEliminartarea.UseVisualStyleBackColor = false;
            this.BtEliminartarea.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // DgvMostrartareas
            // 
            this.DgvMostrartareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMostrartareas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvMostrartareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMostrartareas.Location = new System.Drawing.Point(532, 8);
            this.DgvMostrartareas.MultiSelect = false;
            this.DgvMostrartareas.Name = "DgvMostrartareas";
            this.DgvMostrartareas.RowHeadersWidth = 51;
            this.DgvMostrartareas.RowTemplate.Height = 24;
            this.DgvMostrartareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMostrartareas.Size = new System.Drawing.Size(705, 353);
            this.DgvMostrartareas.TabIndex = 15;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(551, 369);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(251, 23);
            this.lblBuscar.TabIndex = 16;
            this.lblBuscar.Text = "Seleccione su tipo de busqueda";
            // 
            // CmbBusqueda
            // 
            this.CmbBusqueda.BackColor = System.Drawing.SystemColors.Info;
            this.CmbBusqueda.FormattingEnabled = true;
            this.CmbBusqueda.Items.AddRange(new object[] {
            "Por código",
            "Por Estado",
            "Por Rangos de Fecha"});
            this.CmbBusqueda.Location = new System.Drawing.Point(826, 392);
            this.CmbBusqueda.Name = "CmbBusqueda";
            this.CmbBusqueda.Size = new System.Drawing.Size(338, 24);
            this.CmbBusqueda.TabIndex = 17;
            this.CmbBusqueda.SelectedIndexChanged += new System.EventHandler(this.cmbBuscar_SelectedIndexChanged);
            // 
            // TxTBuscartareas
            // 
            this.TxTBuscartareas.BackColor = System.Drawing.SystemColors.Info;
            this.TxTBuscartareas.Location = new System.Drawing.Point(826, 422);
            this.TxTBuscartareas.Name = "TxTBuscartareas";
            this.TxTBuscartareas.Size = new System.Drawing.Size(338, 22);
            this.TxTBuscartareas.TabIndex = 18;
            // 
            // BtBuscar
            // 
            this.BtBuscar.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtBuscar.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscar.Location = new System.Drawing.Point(1056, 450);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(108, 69);
            this.BtBuscar.TabIndex = 19;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = false;
            this.BtBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(580, 397);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(108, 22);
            this.dtpDesde.TabIndex = 20;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(694, 397);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(108, 22);
            this.dtpHasta.TabIndex = 21;
            // 
            // BtRecargar
            // 
            this.BtRecargar.BackColor = System.Drawing.SystemColors.Info;
            this.BtRecargar.Location = new System.Drawing.Point(451, 337);
            this.BtRecargar.Name = "BtRecargar";
            this.BtRecargar.Size = new System.Drawing.Size(75, 23);
            this.BtRecargar.TabIndex = 22;
            this.BtRecargar.Text = "Recargar";
            this.BtRecargar.UseVisualStyleBackColor = false;
            this.BtRecargar.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // CbEstadoBusqueda
            // 
            this.CbEstadoBusqueda.BackColor = System.Drawing.SystemColors.Info;
            this.CbEstadoBusqueda.FormattingEnabled = true;
            this.CbEstadoBusqueda.Location = new System.Drawing.Point(826, 422);
            this.CbEstadoBusqueda.Name = "CbEstadoBusqueda";
            this.CbEstadoBusqueda.Size = new System.Drawing.Size(338, 24);
            this.CbEstadoBusqueda.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1290, 524);
            this.Controls.Add(this.CbEstadoBusqueda);
            this.Controls.Add(this.BtRecargar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.TxTBuscartareas);
            this.Controls.Add(this.CmbBusqueda);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.DgvMostrartareas);
            this.Controls.Add(this.BtEliminartarea);
            this.Controls.Add(this.BtEditartarea);
            this.Controls.Add(this.BtAgregartarea);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.TxLugar);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.DtpFechas);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.TxDescripciontarea);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.TxNombretarea);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.TxCodigotarea);
            this.Controls.Add(this.lblCodigo);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gestor de Tareas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrartareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox TxCodigotarea;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox TxNombretarea;
        private System.Windows.Forms.TextBox TxDescripciontarea;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker DtpFechas;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox TxLugar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Button BtAgregartarea;
        private System.Windows.Forms.Button BtEditartarea;
        private System.Windows.Forms.Button BtEliminartarea;
        private System.Windows.Forms.DataGridView DgvMostrartareas;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox CmbBusqueda;
        private System.Windows.Forms.TextBox TxTBuscartareas;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button BtRecargar;
        private System.Windows.Forms.ComboBox CbEstadoBusqueda;
    }
}

