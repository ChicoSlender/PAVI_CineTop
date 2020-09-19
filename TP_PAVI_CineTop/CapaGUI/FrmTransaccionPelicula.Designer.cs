﻿namespace TP_PAVI_CineTop.CapaGUI
{
    partial class FrmTransaccionPelicula
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.lblFechaFinProyeccion = new System.Windows.Forms.Label();
            this.lblActores = new System.Windows.Forms.Label();
            this.lblArgumento = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.numDuracion = new System.Windows.Forms.NumericUpDown();
            this.lblMin = new System.Windows.Forms.Label();
            this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinProyeccion = new System.Windows.Forms.DateTimePicker();
            this.txtArgumento = new System.Windows.Forms.TextBox();
            this.dtgActores = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoProyecciones = new System.Windows.Forms.GroupBox();
            this.dtgProyecciones = new System.Windows.Forms.DataGridView();
            this.btnEliminarProyeccion = new System.Windows.Forms.Button();
            this.btnModificarProyeccion = new System.Windows.Forms.Button();
            this.btnAgregarProyeccion = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgActores)).BeginInit();
            this.grupoProyecciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProyecciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(45, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(28, 66);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(198, 150);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Genero:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(11, 150);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(53, 13);
            this.lblDuracion.TabIndex = 3;
            this.lblDuracion.Text = "Duracion:";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(17, 108);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(47, 13);
            this.lblDirector.TabIndex = 4;
            this.lblDirector.Text = "Director:";
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(18, 192);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(46, 13);
            this.lblFechaEstreno.TabIndex = 5;
            this.lblFechaEstreno.Text = "Estreno:";
            // 
            // lblFechaFinProyeccion
            // 
            this.lblFechaFinProyeccion.AutoSize = true;
            this.lblFechaFinProyeccion.Location = new System.Drawing.Point(310, 192);
            this.lblFechaFinProyeccion.Name = "lblFechaFinProyeccion";
            this.lblFechaFinProyeccion.Size = new System.Drawing.Size(94, 13);
            this.lblFechaFinProyeccion.TabIndex = 6;
            this.lblFechaFinProyeccion.Text = "Fin de proyeccion:";
            // 
            // lblActores
            // 
            this.lblActores.AutoSize = true;
            this.lblActores.Location = new System.Drawing.Point(379, 24);
            this.lblActores.Name = "lblActores";
            this.lblActores.Size = new System.Drawing.Size(46, 13);
            this.lblActores.TabIndex = 7;
            this.lblActores.Text = "Actores:";
            // 
            // lblArgumento
            // 
            this.lblArgumento.AutoSize = true;
            this.lblArgumento.Location = new System.Drawing.Point(11, 232);
            this.lblArgumento.Name = "lblArgumento";
            this.lblArgumento.Size = new System.Drawing.Size(61, 13);
            this.lblArgumento.TabIndex = 8;
            this.lblArgumento.Text = "Argumento:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(79, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(61, 20);
            this.txtId.TabIndex = 9;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(79, 63);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(256, 20);
            this.txtTitulo.TabIndex = 10;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(79, 105);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(256, 20);
            this.txtDirector.TabIndex = 11;
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(249, 147);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(151, 21);
            this.cmbGenero.TabIndex = 12;
            // 
            // numDuracion
            // 
            this.numDuracion.Location = new System.Drawing.Point(77, 148);
            this.numDuracion.Name = "numDuracion";
            this.numDuracion.Size = new System.Drawing.Size(63, 20);
            this.numDuracion.TabIndex = 13;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(146, 150);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(23, 13);
            this.lblMin.TabIndex = 14;
            this.lblMin.Text = "min";
            // 
            // dtpFechaEstreno
            // 
            this.dtpFechaEstreno.Location = new System.Drawing.Point(79, 186);
            this.dtpFechaEstreno.Name = "dtpFechaEstreno";
            this.dtpFechaEstreno.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEstreno.TabIndex = 15;
            // 
            // dtpFechaFinProyeccion
            // 
            this.dtpFechaFinProyeccion.Location = new System.Drawing.Point(420, 186);
            this.dtpFechaFinProyeccion.Name = "dtpFechaFinProyeccion";
            this.dtpFechaFinProyeccion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinProyeccion.TabIndex = 16;
            // 
            // txtArgumento
            // 
            this.txtArgumento.Location = new System.Drawing.Point(8, 254);
            this.txtArgumento.Multiline = true;
            this.txtArgumento.Name = "txtArgumento";
            this.txtArgumento.Size = new System.Drawing.Size(735, 84);
            this.txtArgumento.TabIndex = 17;
            // 
            // dtgActores
            // 
            this.dtgActores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgActores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido});
            this.dtgActores.Location = new System.Drawing.Point(441, 12);
            this.dtgActores.Name = "dtgActores";
            this.dtgActores.RowHeadersVisible = false;
            this.dtgActores.Size = new System.Drawing.Size(300, 151);
            this.dtgActores.TabIndex = 18;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 150;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.Width = 150;
            // 
            // grupoProyecciones
            // 
            this.grupoProyecciones.Controls.Add(this.btnAgregarProyeccion);
            this.grupoProyecciones.Controls.Add(this.btnModificarProyeccion);
            this.grupoProyecciones.Controls.Add(this.btnEliminarProyeccion);
            this.grupoProyecciones.Controls.Add(this.dtgProyecciones);
            this.grupoProyecciones.Location = new System.Drawing.Point(8, 355);
            this.grupoProyecciones.Name = "grupoProyecciones";
            this.grupoProyecciones.Size = new System.Drawing.Size(732, 182);
            this.grupoProyecciones.TabIndex = 19;
            this.grupoProyecciones.TabStop = false;
            this.grupoProyecciones.Text = "Proyecciones";
            // 
            // dtgProyecciones
            // 
            this.dtgProyecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProyecciones.Location = new System.Drawing.Point(6, 19);
            this.dtgProyecciones.Name = "dtgProyecciones";
            this.dtgProyecciones.Size = new System.Drawing.Size(720, 124);
            this.dtgProyecciones.TabIndex = 0;
            // 
            // btnEliminarProyeccion
            // 
            this.btnEliminarProyeccion.Location = new System.Drawing.Point(651, 149);
            this.btnEliminarProyeccion.Name = "btnEliminarProyeccion";
            this.btnEliminarProyeccion.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProyeccion.TabIndex = 1;
            this.btnEliminarProyeccion.Text = "Eliminar";
            this.btnEliminarProyeccion.UseVisualStyleBackColor = true;
            // 
            // btnModificarProyeccion
            // 
            this.btnModificarProyeccion.Location = new System.Drawing.Point(570, 149);
            this.btnModificarProyeccion.Name = "btnModificarProyeccion";
            this.btnModificarProyeccion.Size = new System.Drawing.Size(75, 23);
            this.btnModificarProyeccion.TabIndex = 2;
            this.btnModificarProyeccion.Text = "Modificar";
            this.btnModificarProyeccion.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProyeccion
            // 
            this.btnAgregarProyeccion.Location = new System.Drawing.Point(489, 149);
            this.btnAgregarProyeccion.Name = "btnAgregarProyeccion";
            this.btnAgregarProyeccion.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProyeccion.TabIndex = 3;
            this.btnAgregarProyeccion.Text = "Agregar";
            this.btnAgregarProyeccion.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::TP_PAVI_CineTop.Properties.Resources.nuevo1;
            this.btnNuevo.Location = new System.Drawing.Point(14, 547);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::TP_PAVI_CineTop.Properties.Resources.grabar1;
            this.btnModificar.Location = new System.Drawing.Point(81, 547);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(50, 50);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBaja
            // 
            this.btnBaja.Image = global::TP_PAVI_CineTop.Properties.Resources.cancelar2;
            this.btnBaja.Location = new System.Drawing.Point(148, 547);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(50, 50);
            this.btnBaja.TabIndex = 21;
            this.btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::TP_PAVI_CineTop.Properties.Resources.puerta2;
            this.btnSalir.Location = new System.Drawing.Point(690, 547);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::TP_PAVI_CineTop.Properties.Resources.grabar4;
            this.btnGuardar.Location = new System.Drawing.Point(510, 547);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::TP_PAVI_CineTop.Properties.Resources.Cancelar3;
            this.btnCancelar.Location = new System.Drawing.Point(441, 547);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(168, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // FrmTransaccionPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 609);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grupoProyecciones);
            this.Controls.Add(this.dtgActores);
            this.Controls.Add(this.txtArgumento);
            this.Controls.Add(this.dtpFechaFinProyeccion);
            this.Controls.Add(this.dtpFechaEstreno);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.numDuracion);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblArgumento);
            this.Controls.Add(this.lblActores);
            this.Controls.Add(this.lblFechaFinProyeccion);
            this.Controls.Add(this.lblFechaEstreno);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblId);
            this.Name = "FrmTransaccionPelicula";
            this.Text = "FrmTransaccionPelicula";
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgActores)).EndInit();
            this.grupoProyecciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProyecciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.Label lblFechaFinProyeccion;
        private System.Windows.Forms.Label lblActores;
        private System.Windows.Forms.Label lblArgumento;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.NumericUpDown numDuracion;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
        private System.Windows.Forms.DateTimePicker dtpFechaFinProyeccion;
        private System.Windows.Forms.TextBox txtArgumento;
        private System.Windows.Forms.DataGridView dtgActores;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.GroupBox grupoProyecciones;
        private System.Windows.Forms.Button btnAgregarProyeccion;
        private System.Windows.Forms.Button btnModificarProyeccion;
        private System.Windows.Forms.Button btnEliminarProyeccion;
        private System.Windows.Forms.DataGridView dtgProyecciones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
    }
}