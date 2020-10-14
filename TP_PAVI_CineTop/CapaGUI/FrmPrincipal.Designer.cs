namespace TP_PAVI_CineTop.CapaGUI
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnSoporte = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalas = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSoporte,
            this.principalToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnSoporte
            // 
            this.btnSoporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalas,
            this.empleadosToolStripMenuItem,
            this.promosToolStripMenuItem});
            this.btnSoporte.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSoporte.Name = "btnSoporte";
            this.btnSoporte.Size = new System.Drawing.Size(60, 20);
            this.btnSoporte.Text = "Soporte";
            // 
            // btnSalas
            // 
            this.btnSalas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSalas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Size = new System.Drawing.Size(132, 22);
            this.btnSalas.Text = "Salas";
            this.btnSalas.Click += new System.EventHandler(this.btnSalas_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.empleadosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // promosToolStripMenuItem
            // 
            this.promosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.promosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.promosToolStripMenuItem.Name = "promosToolStripMenuItem";
            this.promosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.promosToolStripMenuItem.Text = "Promos";
            this.promosToolStripMenuItem.Click += new System.EventHandler(this.promosToolStripMenuItem_Click);
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peliculaToolStripMenuItem});
            this.principalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // peliculaToolStripMenuItem
            // 
            this.peliculaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.peliculaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.peliculaToolStripMenuItem.Name = "peliculaToolStripMenuItem";
            this.peliculaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.peliculaToolStripMenuItem.Text = "Pelicula";
            this.peliculaToolStripMenuItem.Click += new System.EventHandler(this.peliculaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peliculasToolStripMenuItem,
            this.salasToolStripMenuItem});
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // peliculasToolStripMenuItem
            // 
            this.peliculasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.peliculasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.peliculasToolStripMenuItem.Name = "peliculasToolStripMenuItem";
            this.peliculasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.peliculasToolStripMenuItem.Text = "Peliculas";
            this.peliculasToolStripMenuItem.Click += new System.EventHandler(this.peliculasToolStripMenuItem_Click);
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.salasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salasToolStripMenuItem.Text = "Salas";
            this.salasToolStripMenuItem.Click += new System.EventHandler(this.salasToolStripMenuItem_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::TP_PAVI_CineTop.Properties.Resources.Logo_CineTop;
            this.imgLogo.Location = new System.Drawing.Point(287, 48);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(227, 266);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Orbitron", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(264, 343);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(265, 26);
            this.lblBienvenida.TabIndex = 2;
            this.lblBienvenida.Text = "Bienvenido de nuevo";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSoporte;
        private System.Windows.Forms.ToolStripMenuItem btnSalas;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblBienvenida;
    }
}

