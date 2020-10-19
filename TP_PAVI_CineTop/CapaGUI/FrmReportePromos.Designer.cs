namespace TP_PAVI_CineTop.CapaGUI
{
    partial class FrmReportePromos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportePromos));
            this.promoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInformesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInformes = new TP_PAVI_CineTop.FuentesDatos.DataSetInformes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.promoTableAdapter = new TP_PAVI_CineTop.FuentesDatos.DataSetInformesTableAdapters.PromoTableAdapter();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.LblFechaHasta = new System.Windows.Forms.Label();
            this.LblFechaDesde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.promoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInformesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInformes)).BeginInit();
            this.SuspendLayout();
            // 
            // promoBindingSource
            // 
            this.promoBindingSource.DataMember = "Promo";
            this.promoBindingSource.DataSource = this.dataSetInformesBindingSource;
            // 
            // dataSetInformesBindingSource
            // 
            this.dataSetInformesBindingSource.DataSource = this.dataSetInformes;
            this.dataSetInformesBindingSource.Position = 0;
            // 
            // dataSetInformes
            // 
            this.dataSetInformes.DataSetName = "DataSetInformes";
            this.dataSetInformes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "TablaPromo";
            reportDataSource1.Value = this.promoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_PAVI_CineTop.Reportes.ReportePromos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 155);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 283);
            this.reportViewer1.TabIndex = 0;
            // 
            // promoTableAdapter
            // 
            this.promoTableAdapter.ClearBeforeFill = true;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnFiltrar.Location = new System.Drawing.Point(397, 46);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrar.TabIndex = 10;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = false;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click_1);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(159, 93);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 9;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(159, 49);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 8;
            // 
            // LblFechaHasta
            // 
            this.LblFechaHasta.AutoSize = true;
            this.LblFechaHasta.Location = new System.Drawing.Point(18, 93);
            this.LblFechaHasta.Name = "LblFechaHasta";
            this.LblFechaHasta.Size = new System.Drawing.Size(115, 13);
            this.LblFechaHasta.TabIndex = 7;
            this.LblFechaHasta.Text = "Fecha vigencia hasta: ";
            // 
            // LblFechaDesde
            // 
            this.LblFechaDesde.AutoSize = true;
            this.LblFechaDesde.Location = new System.Drawing.Point(18, 49);
            this.LblFechaDesde.Name = "LblFechaDesde";
            this.LblFechaDesde.Size = new System.Drawing.Size(118, 13);
            this.LblFechaDesde.TabIndex = 6;
            this.LblFechaDesde.Text = "Fecha vigencia desde: ";
            // 
            // FrmReportePromos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.LblFechaHasta);
            this.Controls.Add(this.LblFechaDesde);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportePromos";
            this.Text = "Reporte de Promociones";
            this.Load += new System.EventHandler(this.FrmReportePromos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.promoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInformesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInformes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FuentesDatos.DataSetInformes dataSetInformes;
        private System.Windows.Forms.BindingSource dataSetInformesBindingSource;
        private System.Windows.Forms.BindingSource promoBindingSource;
        private FuentesDatos.DataSetInformesTableAdapters.PromoTableAdapter promoTableAdapter;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label LblFechaHasta;
        private System.Windows.Forms.Label LblFechaDesde;
    }
}