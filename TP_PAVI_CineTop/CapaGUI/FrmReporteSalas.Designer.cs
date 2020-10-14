namespace TP_PAVI_CineTop.CapaGUI
{
    partial class FrmReporteSalas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteSalas));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblMinCapacidad = new System.Windows.Forms.Label();
            this.numMinCapacidad = new System.Windows.Forms.NumericUpDown();
            this.numMaxCapacidad = new System.Windows.Forms.NumericUpDown();
            this.lblMaxCapacidad = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.cmbUbicacion = new System.Windows.Forms.ComboBox();
            this.chk3d = new System.Windows.Forms.CheckBox();
            this.chkFiltro3d = new System.Windows.Forms.CheckBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMinCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_PAVI_CineTop.Reportes.ReporteSalas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 104);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(602, 275);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // lblMinCapacidad
            // 
            this.lblMinCapacidad.AutoSize = true;
            this.lblMinCapacidad.Location = new System.Drawing.Point(12, 20);
            this.lblMinCapacidad.Name = "lblMinCapacidad";
            this.lblMinCapacidad.Size = new System.Drawing.Size(98, 13);
            this.lblMinCapacidad.TabIndex = 1;
            this.lblMinCapacidad.Text = "Mínima capacidad:";
            // 
            // numMinCapacidad
            // 
            this.numMinCapacidad.Location = new System.Drawing.Point(114, 18);
            this.numMinCapacidad.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numMinCapacidad.Name = "numMinCapacidad";
            this.numMinCapacidad.Size = new System.Drawing.Size(57, 20);
            this.numMinCapacidad.TabIndex = 2;
            // 
            // numMaxCapacidad
            // 
            this.numMaxCapacidad.Location = new System.Drawing.Point(114, 58);
            this.numMaxCapacidad.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numMaxCapacidad.Name = "numMaxCapacidad";
            this.numMaxCapacidad.Size = new System.Drawing.Size(57, 20);
            this.numMaxCapacidad.TabIndex = 4;
            // 
            // lblMaxCapacidad
            // 
            this.lblMaxCapacidad.AutoSize = true;
            this.lblMaxCapacidad.Location = new System.Drawing.Point(12, 60);
            this.lblMaxCapacidad.Name = "lblMaxCapacidad";
            this.lblMaxCapacidad.Size = new System.Drawing.Size(99, 13);
            this.lblMaxCapacidad.TabIndex = 3;
            this.lblMaxCapacidad.Text = "Máxima capacidad:";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(226, 20);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(58, 13);
            this.lblUbicacion.TabIndex = 5;
            this.lblUbicacion.Text = "Ubicación:";
            // 
            // cmbUbicacion
            // 
            this.cmbUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUbicacion.FormattingEnabled = true;
            this.cmbUbicacion.Location = new System.Drawing.Point(290, 17);
            this.cmbUbicacion.Name = "cmbUbicacion";
            this.cmbUbicacion.Size = new System.Drawing.Size(121, 21);
            this.cmbUbicacion.TabIndex = 6;
            // 
            // chk3d
            // 
            this.chk3d.AutoSize = true;
            this.chk3d.Enabled = false;
            this.chk3d.Location = new System.Drawing.Point(349, 60);
            this.chk3d.Name = "chk3d";
            this.chk3d.Size = new System.Drawing.Size(40, 17);
            this.chk3d.TabIndex = 7;
            this.chk3d.Text = "3D";
            this.chk3d.UseVisualStyleBackColor = true;
            // 
            // chkFiltro3d
            // 
            this.chkFiltro3d.AutoSize = true;
            this.chkFiltro3d.Location = new System.Drawing.Point(229, 60);
            this.chkFiltro3d.Name = "chkFiltro3d";
            this.chkFiltro3d.Size = new System.Drawing.Size(100, 17);
            this.chkFiltro3d.TabIndex = 8;
            this.chkFiltro3d.Text = "Filtrar según 3D";
            this.chkFiltro3d.UseVisualStyleBackColor = true;
            this.chkFiltro3d.CheckedChanged += new System.EventHandler(this.chkFiltro3d_CheckedChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(522, 56);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(522, 15);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(75, 23);
            this.btnTodo.TabIndex = 10;
            this.btnTodo.Text = "Mostrar todo";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // FrmReporteSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(626, 391);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.chkFiltro3d);
            this.Controls.Add(this.chk3d);
            this.Controls.Add(this.cmbUbicacion);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.numMaxCapacidad);
            this.Controls.Add(this.lblMaxCapacidad);
            this.Controls.Add(this.numMinCapacidad);
            this.Controls.Add(this.lblMinCapacidad);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteSalas";
            this.Text = "FrmReporteSalas";
            this.Load += new System.EventHandler(this.FrmReporteSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMinCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCapacidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblMinCapacidad;
        private System.Windows.Forms.NumericUpDown numMinCapacidad;
        private System.Windows.Forms.NumericUpDown numMaxCapacidad;
        private System.Windows.Forms.Label lblMaxCapacidad;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.ComboBox cmbUbicacion;
        private System.Windows.Forms.CheckBox chk3d;
        private System.Windows.Forms.CheckBox chkFiltro3d;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnTodo;
    }
}