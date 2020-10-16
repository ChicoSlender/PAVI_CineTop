namespace TP_PAVI_CineTop.CapaGUI
{
    partial class FrmEstadisticaPeliculas
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
            this.lblEstrenoDesde = new System.Windows.Forms.Label();
            this.dtpEstrenoDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpEstrenoHasta = new System.Windows.Forms.DateTimePicker();
            this.lblEstrenoHasta = new System.Windows.Forms.Label();
            this.grpDirectores = new System.Windows.Forms.GroupBox();
            this.cmbDirectores = new System.Windows.Forms.ComboBox();
            this.dtgDirectores = new System.Windows.Forms.DataGridView();
            this.btnAgregarDirector = new System.Windows.Forms.Button();
            this.btnQuitarDirector = new System.Windows.Forms.Button();
            this.grpGeneros = new System.Windows.Forms.GroupBox();
            this.btnQuitarGenero = new System.Windows.Forms.Button();
            this.btnAgregarGenero = new System.Windows.Forms.Button();
            this.dtgGeneros = new System.Windows.Forms.DataGridView();
            this.cmbGeneros = new System.Windows.Forms.ComboBox();
            this.lblDuracionMax = new System.Windows.Forms.Label();
            this.numDuracionMax = new System.Windows.Forms.NumericUpDown();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDirectores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDirectores)).BeginInit();
            this.grpGeneros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGeneros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracionMax)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstrenoDesde
            // 
            this.lblEstrenoDesde.AutoSize = true;
            this.lblEstrenoDesde.Location = new System.Drawing.Point(12, 23);
            this.lblEstrenoDesde.Name = "lblEstrenoDesde";
            this.lblEstrenoDesde.Size = new System.Drawing.Size(125, 13);
            this.lblEstrenoDesde.TabIndex = 0;
            this.lblEstrenoDesde.Text = "Fecha de estreno desde:";
            // 
            // dtpEstrenoDesde
            // 
            this.dtpEstrenoDesde.Location = new System.Drawing.Point(143, 21);
            this.dtpEstrenoDesde.Name = "dtpEstrenoDesde";
            this.dtpEstrenoDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpEstrenoDesde.TabIndex = 1;
            // 
            // dtpEstrenoHasta
            // 
            this.dtpEstrenoHasta.Location = new System.Drawing.Point(498, 21);
            this.dtpEstrenoHasta.Name = "dtpEstrenoHasta";
            this.dtpEstrenoHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpEstrenoHasta.TabIndex = 3;
            // 
            // lblEstrenoHasta
            // 
            this.lblEstrenoHasta.AutoSize = true;
            this.lblEstrenoHasta.Location = new System.Drawing.Point(367, 23);
            this.lblEstrenoHasta.Name = "lblEstrenoHasta";
            this.lblEstrenoHasta.Size = new System.Drawing.Size(122, 13);
            this.lblEstrenoHasta.TabIndex = 2;
            this.lblEstrenoHasta.Text = "Fecha de estreno hasta:";
            // 
            // grpDirectores
            // 
            this.grpDirectores.Controls.Add(this.btnQuitarDirector);
            this.grpDirectores.Controls.Add(this.btnAgregarDirector);
            this.grpDirectores.Controls.Add(this.dtgDirectores);
            this.grpDirectores.Controls.Add(this.cmbDirectores);
            this.grpDirectores.Location = new System.Drawing.Point(34, 60);
            this.grpDirectores.Name = "grpDirectores";
            this.grpDirectores.Size = new System.Drawing.Size(293, 138);
            this.grpDirectores.TabIndex = 4;
            this.grpDirectores.TabStop = false;
            this.grpDirectores.Text = "Filtrar por directores";
            // 
            // cmbDirectores
            // 
            this.cmbDirectores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirectores.FormattingEnabled = true;
            this.cmbDirectores.Location = new System.Drawing.Point(6, 19);
            this.cmbDirectores.Name = "cmbDirectores";
            this.cmbDirectores.Size = new System.Drawing.Size(224, 21);
            this.cmbDirectores.TabIndex = 5;
            // 
            // dtgDirectores
            // 
            this.dtgDirectores.AllowUserToAddRows = false;
            this.dtgDirectores.AllowUserToDeleteRows = false;
            this.dtgDirectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDirectores.ColumnHeadersVisible = false;
            this.dtgDirectores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre});
            this.dtgDirectores.Location = new System.Drawing.Point(6, 46);
            this.dtgDirectores.Name = "dtgDirectores";
            this.dtgDirectores.ReadOnly = true;
            this.dtgDirectores.RowHeadersVisible = false;
            this.dtgDirectores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDirectores.Size = new System.Drawing.Size(281, 85);
            this.dtgDirectores.TabIndex = 5;
            // 
            // btnAgregarDirector
            // 
            this.btnAgregarDirector.Location = new System.Drawing.Point(236, 19);
            this.btnAgregarDirector.Name = "btnAgregarDirector";
            this.btnAgregarDirector.Size = new System.Drawing.Size(23, 23);
            this.btnAgregarDirector.TabIndex = 5;
            this.btnAgregarDirector.Text = "+";
            this.btnAgregarDirector.UseVisualStyleBackColor = true;
            this.btnAgregarDirector.Click += new System.EventHandler(this.btnAgregarDirector_Click);
            // 
            // btnQuitarDirector
            // 
            this.btnQuitarDirector.Location = new System.Drawing.Point(264, 19);
            this.btnQuitarDirector.Name = "btnQuitarDirector";
            this.btnQuitarDirector.Size = new System.Drawing.Size(23, 23);
            this.btnQuitarDirector.TabIndex = 6;
            this.btnQuitarDirector.Text = "-";
            this.btnQuitarDirector.UseVisualStyleBackColor = true;
            this.btnQuitarDirector.Click += new System.EventHandler(this.btnQuitarDirector_Click);
            // 
            // grpGeneros
            // 
            this.grpGeneros.Controls.Add(this.btnQuitarGenero);
            this.grpGeneros.Controls.Add(this.btnAgregarGenero);
            this.grpGeneros.Controls.Add(this.dtgGeneros);
            this.grpGeneros.Controls.Add(this.cmbGeneros);
            this.grpGeneros.Location = new System.Drawing.Point(370, 60);
            this.grpGeneros.Name = "grpGeneros";
            this.grpGeneros.Size = new System.Drawing.Size(293, 138);
            this.grpGeneros.TabIndex = 7;
            this.grpGeneros.TabStop = false;
            this.grpGeneros.Text = "Excluir géneros";
            // 
            // btnQuitarGenero
            // 
            this.btnQuitarGenero.Location = new System.Drawing.Point(264, 19);
            this.btnQuitarGenero.Name = "btnQuitarGenero";
            this.btnQuitarGenero.Size = new System.Drawing.Size(23, 23);
            this.btnQuitarGenero.TabIndex = 6;
            this.btnQuitarGenero.Text = "-";
            this.btnQuitarGenero.UseVisualStyleBackColor = true;
            this.btnQuitarGenero.Click += new System.EventHandler(this.btnQuitarGenero_Click);
            // 
            // btnAgregarGenero
            // 
            this.btnAgregarGenero.Location = new System.Drawing.Point(236, 19);
            this.btnAgregarGenero.Name = "btnAgregarGenero";
            this.btnAgregarGenero.Size = new System.Drawing.Size(23, 23);
            this.btnAgregarGenero.TabIndex = 5;
            this.btnAgregarGenero.Text = "+";
            this.btnAgregarGenero.UseVisualStyleBackColor = true;
            this.btnAgregarGenero.Click += new System.EventHandler(this.btnAgregarGenero_Click);
            // 
            // dtgGeneros
            // 
            this.dtgGeneros.AllowUserToAddRows = false;
            this.dtgGeneros.AllowUserToDeleteRows = false;
            this.dtgGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGeneros.ColumnHeadersVisible = false;
            this.dtgGeneros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_genero,
            this.nombre_genero});
            this.dtgGeneros.Location = new System.Drawing.Point(6, 46);
            this.dtgGeneros.Name = "dtgGeneros";
            this.dtgGeneros.ReadOnly = true;
            this.dtgGeneros.RowHeadersVisible = false;
            this.dtgGeneros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgGeneros.Size = new System.Drawing.Size(281, 85);
            this.dtgGeneros.TabIndex = 5;
            // 
            // cmbGeneros
            // 
            this.cmbGeneros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneros.FormattingEnabled = true;
            this.cmbGeneros.Location = new System.Drawing.Point(6, 19);
            this.cmbGeneros.Name = "cmbGeneros";
            this.cmbGeneros.Size = new System.Drawing.Size(224, 21);
            this.cmbGeneros.TabIndex = 5;
            // 
            // lblDuracionMax
            // 
            this.lblDuracionMax.AutoSize = true;
            this.lblDuracionMax.Location = new System.Drawing.Point(12, 214);
            this.lblDuracionMax.Name = "lblDuracionMax";
            this.lblDuracionMax.Size = new System.Drawing.Size(91, 13);
            this.lblDuracionMax.TabIndex = 8;
            this.lblDuracionMax.Text = "Duración máxima:";
            // 
            // numDuracionMax
            // 
            this.numDuracionMax.Location = new System.Drawing.Point(109, 212);
            this.numDuracionMax.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numDuracionMax.Name = "numDuracionMax";
            this.numDuracionMax.Size = new System.Drawing.Size(58, 20);
            this.numDuracionMax.TabIndex = 9;
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(173, 214);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(23, 13);
            this.lblMinutos.TabIndex = 10;
            this.lblMinutos.Text = "min";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_PAVI_CineTop.Reportes.EstadisticaPeliculasXGenero.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 238);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(686, 303);
            this.reportViewer1.TabIndex = 11;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(623, 209);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 12;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 275;
            // 
            // id_genero
            // 
            this.id_genero.HeaderText = "ID";
            this.id_genero.Name = "id_genero";
            this.id_genero.ReadOnly = true;
            this.id_genero.Visible = false;
            // 
            // nombre_genero
            // 
            this.nombre_genero.HeaderText = "Nombre";
            this.nombre_genero.Name = "nombre_genero";
            this.nombre_genero.ReadOnly = true;
            this.nombre_genero.Width = 275;
            // 
            // FrmEstadisticaPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 553);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.numDuracionMax);
            this.Controls.Add(this.lblDuracionMax);
            this.Controls.Add(this.grpGeneros);
            this.Controls.Add(this.grpDirectores);
            this.Controls.Add(this.dtpEstrenoHasta);
            this.Controls.Add(this.lblEstrenoHasta);
            this.Controls.Add(this.dtpEstrenoDesde);
            this.Controls.Add(this.lblEstrenoDesde);
            this.Name = "FrmEstadisticaPeliculas";
            this.Text = "Estadistica de peliculas por género";
            this.Load += new System.EventHandler(this.FrmEstadisticaPeliculas_Load);
            this.grpDirectores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDirectores)).EndInit();
            this.grpGeneros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGeneros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracionMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstrenoDesde;
        private System.Windows.Forms.DateTimePicker dtpEstrenoDesde;
        private System.Windows.Forms.DateTimePicker dtpEstrenoHasta;
        private System.Windows.Forms.Label lblEstrenoHasta;
        private System.Windows.Forms.GroupBox grpDirectores;
        private System.Windows.Forms.ComboBox cmbDirectores;
        private System.Windows.Forms.DataGridView dtgDirectores;
        private System.Windows.Forms.Button btnQuitarDirector;
        private System.Windows.Forms.Button btnAgregarDirector;
        private System.Windows.Forms.GroupBox grpGeneros;
        private System.Windows.Forms.Button btnQuitarGenero;
        private System.Windows.Forms.Button btnAgregarGenero;
        private System.Windows.Forms.DataGridView dtgGeneros;
        private System.Windows.Forms.ComboBox cmbGeneros;
        private System.Windows.Forms.Label lblDuracionMax;
        private System.Windows.Forms.NumericUpDown numDuracionMax;
        private System.Windows.Forms.Label lblMinutos;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_genero;
    }
}