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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnSoporte = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalas = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSoporte,
            this.principalToolStripMenuItem});
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
            this.btnSoporte.Name = "btnSoporte";
            this.btnSoporte.Size = new System.Drawing.Size(60, 20);
            this.btnSoporte.Text = "Soporte";
            // 
            // btnSalas
            // 
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Size = new System.Drawing.Size(180, 22);
            this.btnSalas.Text = "Salas";
            this.btnSalas.Click += new System.EventHandler(this.btnSalas_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // promosToolStripMenuItem
            // 
            this.promosToolStripMenuItem.Name = "promosToolStripMenuItem";
            this.promosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.promosToolStripMenuItem.Text = "Promos";
            this.promosToolStripMenuItem.Click += new System.EventHandler(this.promosToolStripMenuItem_Click);
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peliculaToolStripMenuItem});
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // peliculaToolStripMenuItem
            // 
            this.peliculaToolStripMenuItem.Name = "peliculaToolStripMenuItem";
            this.peliculaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.peliculaToolStripMenuItem.Text = "Pelicula";
            this.peliculaToolStripMenuItem.Click += new System.EventHandler(this.peliculaToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

