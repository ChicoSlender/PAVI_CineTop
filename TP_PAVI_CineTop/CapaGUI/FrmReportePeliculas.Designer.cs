namespace TP_PAVI_CineTop.CapaGUI
{
    partial class FrmReportePeliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportePeliculas));
            this.dataSetInformesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInformes = new TP_PAVI_CineTop.FuentesDatos.DataSetInformes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.cmbDirector = new System.Windows.Forms.ComboBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInformesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInformes)).BeginInit();
            this.SuspendLayout();
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
            reportDataSource1.Name = "ReportePeliculas";
            reportDataSource1.Value = this.dataSetInformesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_PAVI_CineTop.Reportes.ReportePeliculas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 97);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(739, 369);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(23, 27);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(110, 13);
            this.lblFechaHasta.TabIndex = 1;
            this.lblFechaHasta.Text = "Fecha estreno desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(139, 21);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 2;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(139, 58);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 4;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(26, 64);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(107, 13);
            this.lblFechaDesde.TabIndex = 3;
            this.lblFechaDesde.Text = "Fecha estreno hasta:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(396, 27);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(32, 13);
            this.lblPais.TabIndex = 5;
            this.lblPais.Text = "País:";
            // 
            // cmbPais
            // 
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(433, 21);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 21);
            this.cmbPais.TabIndex = 6;
            // 
            // cmbDirector
            // 
            this.cmbDirector.FormattingEnabled = true;
            this.cmbDirector.Location = new System.Drawing.Point(433, 58);
            this.cmbDirector.Name = "cmbDirector";
            this.cmbDirector.Size = new System.Drawing.Size(121, 21);
            this.cmbDirector.TabIndex = 8;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(381, 64);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(47, 13);
            this.lblDirector.TabIndex = 7;
            this.lblDirector.Text = "Director:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(593, 56);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Mostrar todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmReportePeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(763, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cmbDirector);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportePeliculas";
            this.Text = "Reporte de Peliculas";
            this.Load += new System.EventHandler(this.FrmReportePeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInformesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInformes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetInformesBindingSource;
        private FuentesDatos.DataSetInformes dataSetInformes;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.ComboBox cmbDirector;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button button1;
    }
}