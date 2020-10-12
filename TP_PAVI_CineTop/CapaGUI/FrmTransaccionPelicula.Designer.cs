namespace TP_PAVI_CineTop.CapaGUI
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
            this.components = new System.ComponentModel.Container();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.lblFechaFinProyeccion = new System.Windows.Forms.Label();
            this.lblArgumento = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.numDuracion = new System.Windows.Forms.NumericUpDown();
            this.lblMin = new System.Windows.Forms.Label();
            this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinProyeccion = new System.Windows.Forms.DateTimePicker();
            this.txtArgumento = new System.Windows.Forms.TextBox();
            this.dtgActores = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.lblPais = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAgregarGenero = new System.Windows.Forms.Button();
            this.btnQuitarGenero = new System.Windows.Forms.Button();
            this.btnQuitarActor = new System.Windows.Forms.Button();
            this.btnAgregarActor = new System.Windows.Forms.Button();
            this.btnQuitarPremio = new System.Windows.Forms.Button();
            this.btnAgregarPremio = new System.Windows.Forms.Button();
            this.btnBuscarTitulo = new System.Windows.Forms.Button();
            this.grpActores = new System.Windows.Forms.GroupBox();
            this.cmbApellidoActor = new System.Windows.Forms.ComboBox();
            this.lblApellidoActor = new System.Windows.Forms.Label();
            this.cmbNombreActor = new System.Windows.Forms.ComboBox();
            this.lblNombreActor = new System.Windows.Forms.Label();
            this.grpPremios = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbPremio = new System.Windows.Forms.ComboBox();
            this.lblPremio = new System.Windows.Forms.Label();
            this.dtgPremios = new System.Windows.Forms.DataGridView();
            this.idPremio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDirector = new System.Windows.Forms.ComboBox();
            this.dtgGeneros = new System.Windows.Forms.DataGridView();
            this.idGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgActores)).BeginInit();
            this.grpActores.SuspendLayout();
            this.grpPremios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPremios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGeneros)).BeginInit();
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
            this.lblGenero.Location = new System.Drawing.Point(17, 147);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Genero:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(359, 183);
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
            this.lblFechaEstreno.Location = new System.Drawing.Point(364, 108);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(46, 13);
            this.lblFechaEstreno.TabIndex = 5;
            this.lblFechaEstreno.Text = "Estreno:";
            // 
            // lblFechaFinProyeccion
            // 
            this.lblFechaFinProyeccion.AutoSize = true;
            this.lblFechaFinProyeccion.Location = new System.Drawing.Point(318, 147);
            this.lblFechaFinProyeccion.Name = "lblFechaFinProyeccion";
            this.lblFechaFinProyeccion.Size = new System.Drawing.Size(94, 13);
            this.lblFechaFinProyeccion.TabIndex = 6;
            this.lblFechaFinProyeccion.Text = "Fin de proyeccion:";
            // 
            // lblArgumento
            // 
            this.lblArgumento.AutoSize = true;
            this.lblArgumento.Location = new System.Drawing.Point(9, 256);
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
            this.toolTip1.SetToolTip(this.txtId, "ID de la película registrada");
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTitulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTitulo.Location = new System.Drawing.Point(79, 63);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(256, 20);
            this.txtTitulo.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtTitulo, "Ingresar el título de la película");
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(79, 144);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(151, 21);
            this.cmbGenero.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cmbGenero, "Seleccionar género de la película");
            // 
            // numDuracion
            // 
            this.numDuracion.Location = new System.Drawing.Point(427, 181);
            this.numDuracion.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numDuracion.Name = "numDuracion";
            this.numDuracion.Size = new System.Drawing.Size(63, 20);
            this.numDuracion.TabIndex = 13;
            this.toolTip1.SetToolTip(this.numDuracion, "Ingresar duración de la película");
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(496, 183);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(23, 13);
            this.lblMin.TabIndex = 14;
            this.lblMin.Text = "min";
            // 
            // dtpFechaEstreno
            // 
            this.dtpFechaEstreno.Location = new System.Drawing.Point(427, 105);
            this.dtpFechaEstreno.Name = "dtpFechaEstreno";
            this.dtpFechaEstreno.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEstreno.TabIndex = 15;
            this.toolTip1.SetToolTip(this.dtpFechaEstreno, "Seleccionar fecha de estreno de película");
            // 
            // dtpFechaFinProyeccion
            // 
            this.dtpFechaFinProyeccion.Location = new System.Drawing.Point(427, 144);
            this.dtpFechaFinProyeccion.Name = "dtpFechaFinProyeccion";
            this.dtpFechaFinProyeccion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinProyeccion.TabIndex = 16;
            this.toolTip1.SetToolTip(this.dtpFechaFinProyeccion, "Seleccionar fecha de fin de proyección de la película");
            // 
            // txtArgumento
            // 
            this.txtArgumento.Location = new System.Drawing.Point(6, 272);
            this.txtArgumento.Multiline = true;
            this.txtArgumento.Name = "txtArgumento";
            this.txtArgumento.Size = new System.Drawing.Size(612, 73);
            this.txtArgumento.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtArgumento, "Introduce el argumento de la película");
            // 
            // dtgActores
            // 
            this.dtgActores.AllowUserToAddRows = false;
            this.dtgActores.AllowUserToDeleteRows = false;
            this.dtgActores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgActores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.apellido});
            this.dtgActores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgActores.Location = new System.Drawing.Point(6, 53);
            this.dtgActores.Name = "dtgActores";
            this.dtgActores.ReadOnly = true;
            this.dtgActores.RowHeadersVisible = false;
            this.dtgActores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgActores.Size = new System.Drawing.Size(606, 101);
            this.dtgActores.TabIndex = 18;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::TP_PAVI_CineTop.Properties.Resources.nuevo1;
            this.btnNuevo.Location = new System.Drawing.Point(12, 685);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnNuevo, "Agregar nueva película");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::TP_PAVI_CineTop.Properties.Resources.grabar1;
            this.btnModificar.Location = new System.Drawing.Point(79, 685);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(50, 50);
            this.btnModificar.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnModificar, "Modificar película");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Image = global::TP_PAVI_CineTop.Properties.Resources.cancelar2;
            this.btnBaja.Location = new System.Drawing.Point(381, 685);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(50, 50);
            this.btnBaja.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnBaja, "Eliminar película");
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::TP_PAVI_CineTop.Properties.Resources.puerta2;
            this.btnSalir.Location = new System.Drawing.Point(568, 685);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::TP_PAVI_CineTop.Properties.Resources.grabar4;
            this.btnGuardar.Location = new System.Drawing.Point(314, 685);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar película");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::TP_PAVI_CineTop.Properties.Resources.Cancelar3;
            this.btnCancelar.Location = new System.Drawing.Point(247, 685);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar carga de película");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.Location = new System.Drawing.Point(168, 19);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarId.TabIndex = 4;
            this.btnBuscarId.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscarId, "Buscar película por id");
            this.btnBuscarId.UseVisualStyleBackColor = true;
            this.btnBuscarId.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(380, 225);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(32, 13);
            this.lblPais.TabIndex = 25;
            this.lblPais.Text = "País:";
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(427, 221);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(151, 21);
            this.cmbPais.TabIndex = 26;
            this.toolTip1.SetToolTip(this.cmbPais, "Seleccionar país de grabación");
            // 
            // btnAgregarGenero
            // 
            this.btnAgregarGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarGenero.Location = new System.Drawing.Point(236, 142);
            this.btnAgregarGenero.Name = "btnAgregarGenero";
            this.btnAgregarGenero.Size = new System.Drawing.Size(23, 23);
            this.btnAgregarGenero.TabIndex = 29;
            this.btnAgregarGenero.Text = "+";
            this.toolTip1.SetToolTip(this.btnAgregarGenero, "Agregar género a la lista");
            this.btnAgregarGenero.UseVisualStyleBackColor = true;
            this.btnAgregarGenero.Click += new System.EventHandler(this.btnAgregarGenero_Click);
            // 
            // btnQuitarGenero
            // 
            this.btnQuitarGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarGenero.Location = new System.Drawing.Point(265, 142);
            this.btnQuitarGenero.Name = "btnQuitarGenero";
            this.btnQuitarGenero.Size = new System.Drawing.Size(23, 23);
            this.btnQuitarGenero.TabIndex = 30;
            this.btnQuitarGenero.Text = "-";
            this.toolTip1.SetToolTip(this.btnQuitarGenero, "Quitar género seleccionado en la lista");
            this.btnQuitarGenero.UseVisualStyleBackColor = true;
            this.btnQuitarGenero.Click += new System.EventHandler(this.btnQuitarGenero_Click);
            // 
            // btnQuitarActor
            // 
            this.btnQuitarActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarActor.Location = new System.Drawing.Point(591, 24);
            this.btnQuitarActor.Name = "btnQuitarActor";
            this.btnQuitarActor.Size = new System.Drawing.Size(23, 23);
            this.btnQuitarActor.TabIndex = 35;
            this.btnQuitarActor.Text = "-";
            this.toolTip1.SetToolTip(this.btnQuitarActor, "Quitar actor seleccionado en la grilla");
            this.btnQuitarActor.UseVisualStyleBackColor = true;
            this.btnQuitarActor.Click += new System.EventHandler(this.btnQuitarActor_Click);
            // 
            // btnAgregarActor
            // 
            this.btnAgregarActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarActor.Location = new System.Drawing.Point(562, 24);
            this.btnAgregarActor.Name = "btnAgregarActor";
            this.btnAgregarActor.Size = new System.Drawing.Size(23, 23);
            this.btnAgregarActor.TabIndex = 34;
            this.btnAgregarActor.Text = "+";
            this.toolTip1.SetToolTip(this.btnAgregarActor, "Agregar actor a la grilla");
            this.btnAgregarActor.UseVisualStyleBackColor = true;
            this.btnAgregarActor.Click += new System.EventHandler(this.btnAgregarActor_Click);
            // 
            // btnQuitarPremio
            // 
            this.btnQuitarPremio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPremio.Location = new System.Drawing.Point(591, 24);
            this.btnQuitarPremio.Name = "btnQuitarPremio";
            this.btnQuitarPremio.Size = new System.Drawing.Size(23, 23);
            this.btnQuitarPremio.TabIndex = 35;
            this.btnQuitarPremio.Text = "-";
            this.toolTip1.SetToolTip(this.btnQuitarPremio, "Quitar premio seleccionado en la grilla");
            this.btnQuitarPremio.UseVisualStyleBackColor = true;
            this.btnQuitarPremio.Click += new System.EventHandler(this.btnQuitarPremio_Click);
            // 
            // btnAgregarPremio
            // 
            this.btnAgregarPremio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPremio.Location = new System.Drawing.Point(562, 24);
            this.btnAgregarPremio.Name = "btnAgregarPremio";
            this.btnAgregarPremio.Size = new System.Drawing.Size(23, 23);
            this.btnAgregarPremio.TabIndex = 34;
            this.btnAgregarPremio.Text = "+";
            this.toolTip1.SetToolTip(this.btnAgregarPremio, "Agregar premio a la grilla");
            this.btnAgregarPremio.UseVisualStyleBackColor = true;
            this.btnAgregarPremio.Click += new System.EventHandler(this.btnAgregarPremio_Click);
            // 
            // btnBuscarTitulo
            // 
            this.btnBuscarTitulo.Location = new System.Drawing.Point(356, 61);
            this.btnBuscarTitulo.Name = "btnBuscarTitulo";
            this.btnBuscarTitulo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTitulo.TabIndex = 39;
            this.btnBuscarTitulo.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscarTitulo, "Buscar película por titulo");
            this.btnBuscarTitulo.UseVisualStyleBackColor = true;
            this.btnBuscarTitulo.Click += new System.EventHandler(this.btnBuscarTitulo_Click);
            // 
            // grpActores
            // 
            this.grpActores.Controls.Add(this.btnQuitarActor);
            this.grpActores.Controls.Add(this.cmbApellidoActor);
            this.grpActores.Controls.Add(this.btnAgregarActor);
            this.grpActores.Controls.Add(this.lblApellidoActor);
            this.grpActores.Controls.Add(this.cmbNombreActor);
            this.grpActores.Controls.Add(this.lblNombreActor);
            this.grpActores.Controls.Add(this.dtgActores);
            this.grpActores.Location = new System.Drawing.Point(6, 351);
            this.grpActores.Name = "grpActores";
            this.grpActores.Size = new System.Drawing.Size(621, 161);
            this.grpActores.TabIndex = 33;
            this.grpActores.TabStop = false;
            this.grpActores.Text = "Actores";
            // 
            // cmbApellidoActor
            // 
            this.cmbApellidoActor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbApellidoActor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbApellidoActor.FormattingEnabled = true;
            this.cmbApellidoActor.Location = new System.Drawing.Point(291, 26);
            this.cmbApellidoActor.Name = "cmbApellidoActor";
            this.cmbApellidoActor.Size = new System.Drawing.Size(164, 21);
            this.cmbApellidoActor.TabIndex = 36;
            // 
            // lblApellidoActor
            // 
            this.lblApellidoActor.AutoSize = true;
            this.lblApellidoActor.Location = new System.Drawing.Point(238, 29);
            this.lblApellidoActor.Name = "lblApellidoActor";
            this.lblApellidoActor.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoActor.TabIndex = 35;
            this.lblApellidoActor.Text = "Apellido:";
            // 
            // cmbNombreActor
            // 
            this.cmbNombreActor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNombreActor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNombreActor.FormattingEnabled = true;
            this.cmbNombreActor.Location = new System.Drawing.Point(60, 26);
            this.cmbNombreActor.Name = "cmbNombreActor";
            this.cmbNombreActor.Size = new System.Drawing.Size(164, 21);
            this.cmbNombreActor.TabIndex = 34;
            this.cmbNombreActor.SelectedIndexChanged += new System.EventHandler(this.cmbNombreActor_SelectedIndexChanged);
            // 
            // lblNombreActor
            // 
            this.lblNombreActor.AutoSize = true;
            this.lblNombreActor.Location = new System.Drawing.Point(7, 29);
            this.lblNombreActor.Name = "lblNombreActor";
            this.lblNombreActor.Size = new System.Drawing.Size(47, 13);
            this.lblNombreActor.TabIndex = 19;
            this.lblNombreActor.Text = "Nombre:";
            // 
            // grpPremios
            // 
            this.grpPremios.Controls.Add(this.btnQuitarPremio);
            this.grpPremios.Controls.Add(this.cmbCategoria);
            this.grpPremios.Controls.Add(this.btnAgregarPremio);
            this.grpPremios.Controls.Add(this.lblCategoria);
            this.grpPremios.Controls.Add(this.cmbPremio);
            this.grpPremios.Controls.Add(this.lblPremio);
            this.grpPremios.Controls.Add(this.dtgPremios);
            this.grpPremios.Location = new System.Drawing.Point(6, 518);
            this.grpPremios.Name = "grpPremios";
            this.grpPremios.Size = new System.Drawing.Size(621, 161);
            this.grpPremios.TabIndex = 37;
            this.grpPremios.TabStop = false;
            this.grpPremios.Text = "Premios";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Enabled = false;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(301, 26);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(164, 21);
            this.cmbCategoria.TabIndex = 36;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(238, 29);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblCategoria.TabIndex = 35;
            this.lblCategoria.Text = "Categoría:";
            // 
            // cmbPremio
            // 
            this.cmbPremio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPremio.FormattingEnabled = true;
            this.cmbPremio.Location = new System.Drawing.Point(60, 26);
            this.cmbPremio.Name = "cmbPremio";
            this.cmbPremio.Size = new System.Drawing.Size(164, 21);
            this.cmbPremio.TabIndex = 34;
            this.cmbPremio.SelectedValueChanged += new System.EventHandler(this.cmbPremio_SelectedValueChanged);
            // 
            // lblPremio
            // 
            this.lblPremio.AutoSize = true;
            this.lblPremio.Location = new System.Drawing.Point(7, 29);
            this.lblPremio.Name = "lblPremio";
            this.lblPremio.Size = new System.Drawing.Size(42, 13);
            this.lblPremio.TabIndex = 19;
            this.lblPremio.Text = "Premio:";
            // 
            // dtgPremios
            // 
            this.dtgPremios.AllowUserToAddRows = false;
            this.dtgPremios.AllowUserToDeleteRows = false;
            this.dtgPremios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPremios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPremio,
            this.premio,
            this.idCategoria,
            this.categoria});
            this.dtgPremios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgPremios.Location = new System.Drawing.Point(6, 53);
            this.dtgPremios.Name = "dtgPremios";
            this.dtgPremios.ReadOnly = true;
            this.dtgPremios.RowHeadersVisible = false;
            this.dtgPremios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPremios.Size = new System.Drawing.Size(606, 102);
            this.dtgPremios.TabIndex = 18;
            // 
            // idPremio
            // 
            this.idPremio.HeaderText = "IDPremio";
            this.idPremio.Name = "idPremio";
            this.idPremio.ReadOnly = true;
            this.idPremio.Visible = false;
            // 
            // premio
            // 
            this.premio.HeaderText = "Premio";
            this.premio.Name = "premio";
            this.premio.ReadOnly = true;
            this.premio.Width = 300;
            // 
            // idCategoria
            // 
            this.idCategoria.HeaderText = "IDCategoria";
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            this.idCategoria.Visible = false;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoría";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 300;
            // 
            // cmbDirector
            // 
            this.cmbDirector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDirector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDirector.FormattingEnabled = true;
            this.cmbDirector.Location = new System.Drawing.Point(79, 104);
            this.cmbDirector.Name = "cmbDirector";
            this.cmbDirector.Size = new System.Drawing.Size(256, 21);
            this.cmbDirector.TabIndex = 38;
            // 
            // dtgGeneros
            // 
            this.dtgGeneros.AllowUserToAddRows = false;
            this.dtgGeneros.AllowUserToDeleteRows = false;
            this.dtgGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGeneros.ColumnHeadersVisible = false;
            this.dtgGeneros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGenero,
            this.genero});
            this.dtgGeneros.Location = new System.Drawing.Point(79, 171);
            this.dtgGeneros.Name = "dtgGeneros";
            this.dtgGeneros.ReadOnly = true;
            this.dtgGeneros.RowHeadersVisible = false;
            this.dtgGeneros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgGeneros.Size = new System.Drawing.Size(209, 85);
            this.dtgGeneros.TabIndex = 40;
            // 
            // idGenero
            // 
            this.idGenero.HeaderText = "ID";
            this.idGenero.Name = "idGenero";
            this.idGenero.ReadOnly = true;
            this.idGenero.Visible = false;
            // 
            // genero
            // 
            this.genero.HeaderText = "Genero";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            this.genero.Width = 200;
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
            this.nombre.Width = 300;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 300;
            // 
            // FrmTransaccionPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 747);
            this.Controls.Add(this.dtgGeneros);
            this.Controls.Add(this.btnBuscarTitulo);
            this.Controls.Add(this.cmbDirector);
            this.Controls.Add(this.grpPremios);
            this.Controls.Add(this.grpActores);
            this.Controls.Add(this.btnQuitarGenero);
            this.Controls.Add(this.btnAgregarGenero);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.btnBuscarId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtArgumento);
            this.Controls.Add(this.dtpFechaFinProyeccion);
            this.Controls.Add(this.dtpFechaEstreno);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.numDuracion);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblArgumento);
            this.Controls.Add(this.lblFechaFinProyeccion);
            this.Controls.Add(this.lblFechaEstreno);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblId);
            this.Name = "FrmTransaccionPelicula";
            this.Text = "Registrar Pelicula";
            this.Load += new System.EventHandler(this.FrmTransaccionPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgActores)).EndInit();
            this.grpActores.ResumeLayout(false);
            this.grpActores.PerformLayout();
            this.grpPremios.ResumeLayout(false);
            this.grpPremios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPremios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGeneros)).EndInit();
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
        private System.Windows.Forms.Label lblArgumento;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.NumericUpDown numDuracion;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
        private System.Windows.Forms.DateTimePicker dtpFechaFinProyeccion;
        private System.Windows.Forms.TextBox txtArgumento;
        private System.Windows.Forms.DataGridView dtgActores;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAgregarGenero;
        private System.Windows.Forms.Button btnQuitarGenero;
        private System.Windows.Forms.GroupBox grpActores;
        private System.Windows.Forms.Button btnQuitarActor;
        private System.Windows.Forms.ComboBox cmbApellidoActor;
        private System.Windows.Forms.Button btnAgregarActor;
        private System.Windows.Forms.Label lblApellidoActor;
        private System.Windows.Forms.ComboBox cmbNombreActor;
        private System.Windows.Forms.Label lblNombreActor;
        private System.Windows.Forms.GroupBox grpPremios;
        private System.Windows.Forms.Button btnQuitarPremio;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnAgregarPremio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbPremio;
        private System.Windows.Forms.Label lblPremio;
        private System.Windows.Forms.DataGridView dtgPremios;
        private System.Windows.Forms.ComboBox cmbDirector;
        private System.Windows.Forms.Button btnBuscarTitulo;
        private System.Windows.Forms.DataGridView dtgGeneros;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPremio;
        private System.Windows.Forms.DataGridViewTextBoxColumn premio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
    }
}