namespace TP_PAVI_CineTop.CapaGUI
{
    partial class FrmEstadisticaEmpleados
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
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblFechaIngresoDesde = new System.Windows.Forms.Label();
            this.dtpFechaIngresoDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaIngresoHasta = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_PAVI_CineTop.Reportes.EstadisticaEmpleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 108);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 330);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(411, 26);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(121, 57);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblFechaIngresoDesde
            // 
            this.lblFechaIngresoDesde.AutoSize = true;
            this.lblFechaIngresoDesde.Location = new System.Drawing.Point(37, 28);
            this.lblFechaIngresoDesde.Name = "lblFechaIngresoDesde";
            this.lblFechaIngresoDesde.Size = new System.Drawing.Size(125, 13);
            this.lblFechaIngresoDesde.TabIndex = 3;
            this.lblFechaIngresoDesde.Text = "Fecha de Ingreso desde:";
            this.lblFechaIngresoDesde.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpFechaIngresoDesde
            // 
            this.dtpFechaIngresoDesde.Location = new System.Drawing.Point(179, 26);
            this.dtpFechaIngresoDesde.Name = "dtpFechaIngresoDesde";
            this.dtpFechaIngresoDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngresoDesde.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha de Ingreso hasta:";
            // 
            // dtpFechaIngresoHasta
            // 
            this.dtpFechaIngresoHasta.Location = new System.Drawing.Point(179, 63);
            this.dtpFechaIngresoHasta.Name = "dtpFechaIngresoHasta";
            this.dtpFechaIngresoHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngresoHasta.TabIndex = 6;
            // 
            // FrmEstadisticaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpFechaIngresoHasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaIngresoDesde);
            this.Controls.Add(this.lblFechaIngresoDesde);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmEstadisticaEmpleados";
            this.Text = "Estadísticas de Salarios";
            this.Load += new System.EventHandler(this.FrmEstadisticaEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblFechaIngresoDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaIngresoDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaIngresoHasta;
    }
}