namespace TP_PAVI_CineTop.CapaGUI
{
    partial class FrmEstadisticaSalas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblCapacidadMinima = new System.Windows.Forms.Label();
            this.numCapacidadMinima = new System.Windows.Forms.NumericUpDown();
            this.numCapacidadMaxima = new System.Windows.Forms.NumericUpDown();
            this.lblCapacidadMaxima = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidadMinima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidadMaxima)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_PAVI_CineTop.Reportes.EstadisticaSalas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(670, 334);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // lblCapacidadMinima
            // 
            this.lblCapacidadMinima.AutoSize = true;
            this.lblCapacidadMinima.Location = new System.Drawing.Point(12, 21);
            this.lblCapacidadMinima.Name = "lblCapacidadMinima";
            this.lblCapacidadMinima.Size = new System.Drawing.Size(98, 13);
            this.lblCapacidadMinima.TabIndex = 1;
            this.lblCapacidadMinima.Text = "Capacidad mínima:";
            // 
            // numCapacidadMinima
            // 
            this.numCapacidadMinima.Location = new System.Drawing.Point(116, 19);
            this.numCapacidadMinima.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numCapacidadMinima.Name = "numCapacidadMinima";
            this.numCapacidadMinima.Size = new System.Drawing.Size(62, 20);
            this.numCapacidadMinima.TabIndex = 2;
            // 
            // numCapacidadMaxima
            // 
            this.numCapacidadMaxima.Location = new System.Drawing.Point(311, 19);
            this.numCapacidadMaxima.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numCapacidadMaxima.Name = "numCapacidadMaxima";
            this.numCapacidadMaxima.Size = new System.Drawing.Size(62, 20);
            this.numCapacidadMaxima.TabIndex = 4;
            // 
            // lblCapacidadMaxima
            // 
            this.lblCapacidadMaxima.AutoSize = true;
            this.lblCapacidadMaxima.Location = new System.Drawing.Point(207, 21);
            this.lblCapacidadMaxima.Name = "lblCapacidadMaxima";
            this.lblCapacidadMaxima.Size = new System.Drawing.Size(99, 13);
            this.lblCapacidadMaxima.TabIndex = 3;
            this.lblCapacidadMaxima.Text = "Capacidad máxima:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(598, 16);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // FrmEstadisticaSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 409);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.numCapacidadMaxima);
            this.Controls.Add(this.lblCapacidadMaxima);
            this.Controls.Add(this.numCapacidadMinima);
            this.Controls.Add(this.lblCapacidadMinima);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmEstadisticaSalas";
            this.Text = "Estadisticas de salas";
            this.Load += new System.EventHandler(this.FrmEstadisticaSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidadMinima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidadMaxima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblCapacidadMinima;
        private System.Windows.Forms.NumericUpDown numCapacidadMinima;
        private System.Windows.Forms.NumericUpDown numCapacidadMaxima;
        private System.Windows.Forms.Label lblCapacidadMaxima;
        private System.Windows.Forms.Button btnFiltrar;
    }
}