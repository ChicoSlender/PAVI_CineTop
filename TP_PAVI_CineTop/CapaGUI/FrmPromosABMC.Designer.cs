namespace TP_PAVI_CineTop.CapaGUI
{
    partial class FrmPromosABMC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPromosABMC));
            this.txtMayores = new System.Windows.Forms.TextBox();
            this.txtPromo = new System.Windows.Forms.TextBox();
            this.txtMenores = new System.Windows.Forms.TextBox();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblPromo = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblPrecioMenores = new System.Windows.Forms.Label();
            this.LblPrecioMayores = new System.Windows.Forms.Label();
            this.TxtVigencia = new System.Windows.Forms.Label();
            this.LblFechaDesde = new System.Windows.Forms.Label();
            this.LblFechaHasta = new System.Windows.Forms.Label();
            this.dtgPromos = new System.Windows.Forms.DataGridView();
            this.ID_Promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Menores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Mayores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cmbEpoca = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPromos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMayores
            // 
            this.txtMayores.Location = new System.Drawing.Point(124, 156);
            this.txtMayores.Name = "txtMayores";
            this.txtMayores.Size = new System.Drawing.Size(86, 20);
            this.txtMayores.TabIndex = 2;
            // 
            // txtPromo
            // 
            this.txtPromo.Location = new System.Drawing.Point(124, 22);
            this.txtPromo.Name = "txtPromo";
            this.txtPromo.Size = new System.Drawing.Size(86, 20);
            this.txtPromo.TabIndex = 3;
            this.txtPromo.TextChanged += new System.EventHandler(this.txtPromo_TextChanged);
            // 
            // txtMenores
            // 
            this.txtMenores.Location = new System.Drawing.Point(124, 111);
            this.txtMenores.Name = "txtMenores";
            this.txtMenores.Size = new System.Drawing.Size(86, 20);
            this.txtMenores.TabIndex = 5;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(339, 56);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 14;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(339, 111);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 15;
            // 
            // lblPromo
            // 
            this.lblPromo.AutoSize = true;
            this.lblPromo.Location = new System.Drawing.Point(64, 25);
            this.lblPromo.Name = "lblPromo";
            this.lblPromo.Size = new System.Drawing.Size(54, 13);
            this.lblPromo.TabIndex = 16;
            this.lblPromo.Text = "ID Promo:";
            this.lblPromo.Click += new System.EventHandler(this.lblLegajo_Click);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(64, 72);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(54, 13);
            this.LblFecha.TabIndex = 17;
            this.LblFecha.Text = "ID Fecha:";
            this.LblFecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblPrecioMenores
            // 
            this.LblPrecioMenores.AutoSize = true;
            this.LblPrecioMenores.Location = new System.Drawing.Point(34, 114);
            this.LblPrecioMenores.Name = "LblPrecioMenores";
            this.LblPrecioMenores.Size = new System.Drawing.Size(84, 13);
            this.LblPrecioMenores.TabIndex = 18;
            this.LblPrecioMenores.Text = "Precio Menores:";
            // 
            // LblPrecioMayores
            // 
            this.LblPrecioMayores.AutoSize = true;
            this.LblPrecioMayores.Location = new System.Drawing.Point(34, 159);
            this.LblPrecioMayores.Name = "LblPrecioMayores";
            this.LblPrecioMayores.Size = new System.Drawing.Size(83, 13);
            this.LblPrecioMayores.TabIndex = 19;
            this.LblPrecioMayores.Text = "Precio Mayores:";
            // 
            // TxtVigencia
            // 
            this.TxtVigencia.AutoSize = true;
            this.TxtVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVigencia.Location = new System.Drawing.Point(354, 22);
            this.TxtVigencia.Name = "TxtVigencia";
            this.TxtVigencia.Size = new System.Drawing.Size(167, 17);
            this.TxtVigencia.TabIndex = 20;
            this.TxtVigencia.Text = "VIGENCIA DE PROMO";
            this.TxtVigencia.Click += new System.EventHandler(this.label4_Click);
            // 
            // LblFechaDesde
            // 
            this.LblFechaDesde.AutoSize = true;
            this.LblFechaDesde.Location = new System.Drawing.Point(295, 60);
            this.LblFechaDesde.Name = "LblFechaDesde";
            this.LblFechaDesde.Size = new System.Drawing.Size(41, 13);
            this.LblFechaDesde.TabIndex = 21;
            this.LblFechaDesde.Text = "Desde:";
            this.LblFechaDesde.Click += new System.EventHandler(this.label5_Click);
            // 
            // LblFechaHasta
            // 
            this.LblFechaHasta.AutoSize = true;
            this.LblFechaHasta.Location = new System.Drawing.Point(297, 115);
            this.LblFechaHasta.Name = "LblFechaHasta";
            this.LblFechaHasta.Size = new System.Drawing.Size(38, 13);
            this.LblFechaHasta.TabIndex = 22;
            this.LblFechaHasta.Text = "Hasta:";
            this.LblFechaHasta.Click += new System.EventHandler(this.LblFechaHasta_Click);
            // 
            // dtgPromos
            // 
            this.dtgPromos.AllowUserToAddRows = false;
            this.dtgPromos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPromos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Promo,
            this.ID_Fecha,
            this.Precio_Menores,
            this.Precio_Mayores,
            this.Fecha_Desde,
            this.Fecha_Hasta});
            this.dtgPromos.Location = new System.Drawing.Point(12, 213);
            this.dtgPromos.Name = "dtgPromos";
            this.dtgPromos.ReadOnly = true;
            this.dtgPromos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPromos.Size = new System.Drawing.Size(599, 174);
            this.dtgPromos.TabIndex = 23;
            this.dtgPromos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmpleados_CellContentClick);
            this.dtgPromos.SelectionChanged += new System.EventHandler(this.dtgPromos_SelectionChanged);
            // 
            // ID_Promo
            // 
            this.ID_Promo.HeaderText = "ID Promo";
            this.ID_Promo.Name = "ID_Promo";
            this.ID_Promo.ReadOnly = true;
            this.ID_Promo.Width = 75;
            // 
            // ID_Fecha
            // 
            this.ID_Fecha.HeaderText = "ID Fecha";
            this.ID_Fecha.Name = "ID_Fecha";
            this.ID_Fecha.ReadOnly = true;
            this.ID_Fecha.Width = 125;
            // 
            // Precio_Menores
            // 
            this.Precio_Menores.HeaderText = "Precio Menores";
            this.Precio_Menores.Name = "Precio_Menores";
            this.Precio_Menores.ReadOnly = true;
            this.Precio_Menores.Width = 125;
            // 
            // Precio_Mayores
            // 
            this.Precio_Mayores.HeaderText = "Precio Mayores";
            this.Precio_Mayores.Name = "Precio_Mayores";
            this.Precio_Mayores.ReadOnly = true;
            this.Precio_Mayores.Width = 125;
            // 
            // Fecha_Desde
            // 
            this.Fecha_Desde.HeaderText = "Fecha Desde";
            this.Fecha_Desde.Name = "Fecha_Desde";
            this.Fecha_Desde.ReadOnly = true;
            // 
            // Fecha_Hasta
            // 
            this.Fecha_Hasta.HeaderText = "Hasta";
            this.Fecha_Hasta.Name = "Fecha_Hasta";
            this.Fecha_Hasta.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::TP_PAVI_CineTop.Properties.Resources.puerta2;
            this.btnSalir.Location = new System.Drawing.Point(561, 393);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::TP_PAVI_CineTop.Properties.Resources.grabar4;
            this.btnGuardar.Location = new System.Drawing.Point(379, 393);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar promo");
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::TP_PAVI_CineTop.Properties.Resources.Cancelar3;
            this.btnCancelar.Location = new System.Drawing.Point(312, 393);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar operacion");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBaja.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBaja.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Image = global::TP_PAVI_CineTop.Properties.Resources.cancelar2;
            this.btnBaja.Location = new System.Drawing.Point(160, 393);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(50, 50);
            this.btnBaja.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnBaja, "Borrar promo seleccionada");
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Image = global::TP_PAVI_CineTop.Properties.Resources.grabar1;
            this.btnModificar.Location = new System.Drawing.Point(87, 393);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(50, 50);
            this.btnModificar.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnModificar, "Modificar promo seleccionada");
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::TP_PAVI_CineTop.Properties.Resources.nuevo1;
            this.btnNuevo.Location = new System.Drawing.Point(12, 393);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnNuevo, "Agregar nueva promo");
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cmbEpoca
            // 
            this.cmbEpoca.FormattingEnabled = true;
            this.cmbEpoca.Location = new System.Drawing.Point(125, 63);
            this.cmbEpoca.Name = "cmbEpoca";
            this.cmbEpoca.Size = new System.Drawing.Size(85, 21);
            this.cmbEpoca.TabIndex = 30;
            // 
            // FrmPromosABMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.cmbEpoca);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtgPromos);
            this.Controls.Add(this.LblFechaHasta);
            this.Controls.Add(this.LblFechaDesde);
            this.Controls.Add(this.TxtVigencia);
            this.Controls.Add(this.LblPrecioMayores);
            this.Controls.Add(this.LblPrecioMenores);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.lblPromo);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.txtMenores);
            this.Controls.Add(this.txtPromo);
            this.Controls.Add(this.txtMayores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPromosABMC";
            this.Text = "Gestión Promos";
            this.Load += new System.EventHandler(this.FrmPromosABMC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPromos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMayores;
        private System.Windows.Forms.TextBox txtPromo;
        private System.Windows.Forms.TextBox txtMenores;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblPromo;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblPrecioMenores;
        private System.Windows.Forms.Label LblPrecioMayores;
        private System.Windows.Forms.Label TxtVigencia;
        private System.Windows.Forms.Label LblFechaDesde;
        private System.Windows.Forms.Label LblFechaHasta;
        private System.Windows.Forms.DataGridView dtgPromos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Menores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Mayores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Hasta;
        private System.Windows.Forms.ComboBox cmbEpoca;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}