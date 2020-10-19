namespace TP_PAVI_CineTop.CapaGUI
{
    partial class FrmReporteEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteEmpleados));
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TP_PAVI_CineTop.FuentesDatos.DataSetInformes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.empleadoTableAdapter = new TP_PAVI_CineTop.FuentesDatos.DataSetInformesTableAdapters.EmpleadoTableAdapter();
            this.LblFechaAltasDesde = new System.Windows.Forms.Label();
            this.LblFechaAltasHasta = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetEmpleados";
            reportDataSource1.Value = this.empleadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_PAVI_CineTop.Reportes.ReporteEmpleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 170);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 268);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // LblFechaAltasDesde
            // 
            this.LblFechaAltasDesde.AutoSize = true;
            this.LblFechaAltasDesde.Location = new System.Drawing.Point(32, 52);
            this.LblFechaAltasDesde.Name = "LblFechaAltasDesde";
            this.LblFechaAltasDesde.Size = new System.Drawing.Size(115, 13);
            this.LblFechaAltasDesde.TabIndex = 1;
            this.LblFechaAltasDesde.Text = "Fecha de altas desde: ";
            this.LblFechaAltasDesde.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblFechaAltasHasta
            // 
            this.LblFechaAltasHasta.AutoSize = true;
            this.LblFechaAltasHasta.Location = new System.Drawing.Point(32, 96);
            this.LblFechaAltasHasta.Name = "LblFechaAltasHasta";
            this.LblFechaAltasHasta.Size = new System.Drawing.Size(112, 13);
            this.LblFechaAltasHasta.TabIndex = 2;
            this.LblFechaAltasHasta.Text = "Fecha de altas hasta: ";
            this.LblFechaAltasHasta.Click += new System.EventHandler(this.LblFechaAltasHasta_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(173, 52);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 3;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(173, 96);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 4;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnFiltrar.Location = new System.Drawing.Point(411, 49);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrar.TabIndex = 5;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = false;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // FrmReporteEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.LblFechaAltasHasta);
            this.Controls.Add(this.LblFechaAltasDesde);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteEmpleados";
            this.Text = "Reporte de Empleados";
            this.Load += new System.EventHandler(this.FrmReporteEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FuentesDatos.DataSetInformes dataSet1;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private FuentesDatos.DataSetInformesTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.Label LblFechaAltasDesde;
        private System.Windows.Forms.Label LblFechaAltasHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button BtnFiltrar;
    }
}