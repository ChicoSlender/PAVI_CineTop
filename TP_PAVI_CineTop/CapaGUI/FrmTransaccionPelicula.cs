using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAVI_CineTop.CapaNegocio;
using TP_PAVI_CineTop.Entidades;

namespace TP_PAVI_CineTop.CapaGUI
{
    public partial class FrmTransaccionPelicula : Form
    {
        enum Modo
        {
            nuevo, modificar
        }
        ServGenero servGenero = new ServGenero();
        ServPais servPais = new ServPais();
        ServPelicula servPelicula = new ServPelicula();
        ServDirector servDirector = new ServDirector();
        ServPremio servPremio = new ServPremio();
        ServCategoriaPremio servCategoriaPremio = new ServCategoriaPremio();
        ServActor servActor = new ServActor();
        List<Premio> premios = new List<Premio>();
        Modo modo = Modo.modificar;
        bool camposInicializados = false;

        public FrmTransaccionPelicula()
        {
            InitializeComponent();
        }

        private void habilitarCampos(bool v)
        {
            if (modo == Modo.modificar)
            {
                txtId.Enabled = v;
                btnBuscarId.Enabled = v;
                btnBaja.Enabled = v;
                btnBuscarTitulo.Enabled = v;
                txtTitulo.AutoCompleteCustomSource = servPelicula.obtenerNombresPeliculasVigentes(); //Decision de arquitectura
            }
            txtTitulo.Enabled = v;
            cmbDirector.Enabled = v;
            numDuracion.Enabled = v;
            cmbGenero.Enabled = v;
            cmbPais.Enabled = v;
            dtpFechaEstreno.Enabled = v;
            dtpFechaFinProyeccion.Enabled = v;
            txtArgumento.Enabled = v;
            dtgActores.Enabled = v;
            btnAgregarActor.Enabled = v;
            btnQuitarActor.Enabled = v;
            cmbNombreActor.Enabled = v;
            cmbApellidoActor.Enabled = v;
            dtgGeneros.Enabled = v;
            btnAgregarGenero.Enabled = v;
            btnQuitarGenero.Enabled = v;
            dtgPremios.Enabled = v;
            btnAgregarPremio.Enabled = v;
            btnQuitarPremio.Enabled = v;
            cmbPremio.Enabled = v;
            cmbCategoria.Enabled = v;

            btnGuardar.Enabled = v;
            btnCancelar.Enabled = v;
            radDBHelper.Enabled = v;
            radDataManager.Enabled = v;

            btnNuevo.Enabled = !v;
            btnModificar.Enabled = !v;
        }

        private void limpiarCampos()
        {
            txtId.Clear();
            txtTitulo.Clear();
            txtTitulo.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            numDuracion.Value = 0;
            cmbDirector.SelectedIndex = -1;
            cmbDirector.Text = "";
            cmbGenero.SelectedIndex = -1;
            dtgGeneros.Rows.Clear();
            cmbPais.SelectedIndex = -1;
            dtpFechaEstreno.Value = DateTime.Today;
            dtpFechaFinProyeccion.Value = DateTime.Today;
            txtArgumento.Clear();
            dtgActores.Rows.Clear();
            cmbNombreActor.SelectedIndex = -1;
            cmbNombreActor.Text = "";
            cmbApellidoActor.DataSource = null;
            cmbApellidoActor.Text = "";
            cmbPremio.SelectedIndex = -1;
            cmbCategoria.DataSource = null;
            cmbCategoria.Enabled = false;
            dtgPremios.Rows.Clear();
        }

        private bool validarCampos()
        {
            if (txtTitulo.Text == "")
            {
                MessageBox.Show("El campo de título no puede estar vacío", "ERROR - Título vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbDirector.Text == "")
            {
                MessageBox.Show("El campo de director no puede estar vacío", "ERROR - Director vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (numDuracion.Value <= 0)
            {
                MessageBox.Show("La duración de la película debe ser mayor a 0 minutos", "ERROR - Duración incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbPais.SelectedIndex == -1)
            {
                MessageBox.Show("Debe elegir un país", "ERROR - País vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dtpFechaEstreno.Value > dtpFechaFinProyeccion.Value)
            {
                MessageBox.Show("La fecha de estreno debe ser anterior a la fecha de fin de proyección", "ERROR - Fecha incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtArgumento.Text == "")
            {
                MessageBox.Show("El campo del argumento no puede estar vacío", "ERROR - Argumento vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dtgActores.Rows.Count == 0)
            {
                MessageBox.Show("La película debe tener por lo menos un actor", "ERROR - Actores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dtgGeneros.Rows.Count == 0)
            {
                MessageBox.Show("La película debe tener por lo menos un género", "ERROR - Generos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void FrmTransaccionPelicula_Load(object sender, EventArgs e)
        {
            inicializarCampos();
        }

        private void inicializarCampos()
        {
            camposInicializados = false;
            FrmHelper.cargarCombo(servGenero.obtenerGeneros(), cmbGenero, "nombre", "id");
            FrmHelper.cargarCombo(servPais.obtenerPaises(), cmbPais, "nombre", "id");
            FrmHelper.cargarCombo(servDirector.obtenerDirectores(), cmbDirector, "nombre", "id");
            premios = servPremio.obtenerPremios().ToList();
            FrmHelper.cargarCombo(premios, cmbPremio, "nombre", "id");
            FrmHelper.cargarCombo(servActor.obtenerNombresActoresDistintos(), cmbNombreActor, "nombre", "id");
            habilitarCampos(false);
            camposInicializados = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            modo = Modo.nuevo;
            habilitarCampos(true);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            modo = Modo.modificar;
            habilitarCampos(true);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult eleccion = MessageBox.Show("Seguro que quiere eliminar la película elegida?", "Confirmar borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (eleccion == DialogResult.Yes)
            {
                string errores = servPelicula.borrarPelicula(Convert.ToInt32(txtId.Text));
                if (errores != "Transaccion realizada con exito")
                {
                    MessageBox.Show(errores, "Error de borrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Película eliminada", "Resultado operación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                habilitarCampos(false);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación cancelada", "Resultado operación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            habilitarCampos(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
                return;

            int id;
            if (txtId.Text == "")
                id = 0;
            else
                id = Convert.ToInt32(txtId.Text);
            string titulo = txtTitulo.Text;
            Director director;
            if (cmbDirector.SelectedIndex != -1) {
                director = new Director(Convert.ToInt32(cmbDirector.SelectedValue), cmbDirector.Text);
            }
            else
            {
                director = new Director(0, cmbDirector.Text);
            }
                
            int duracion = Convert.ToInt32(numDuracion.Value);
            int id_pais = Convert.ToInt32(cmbPais.SelectedValue);
            DateTime fechaEstreno = dtpFechaEstreno.Value;
            DateTime fechaFin = dtpFechaFinProyeccion.Value;
            string argumento = txtArgumento.Text;

            Pelicula peli = new Pelicula(id, titulo, director, duracion, fechaEstreno, fechaFin, argumento, id_pais, false);

            //crear lista de actores y agregarla
            int idActor;
            string nombreActor;
            string apellidoActor;
            List<ActorPelicula> actores = new List<ActorPelicula>();
            for (int i = 0; i < dtgActores.Rows.Count; i++)
            {
                idActor = Convert.ToInt32(dtgActores.Rows[i].Cells["id"].Value);
                nombreActor = dtgActores.Rows[i].Cells["nombre"].Value.ToString();
                apellidoActor = dtgActores.Rows[i].Cells["apellido"].Value.ToString();
                actores.Add(new ActorPelicula(idActor, nombreActor, apellidoActor));
            }
            peli.Actores = actores;
            //crear lista de generos y agregarla
            int idGenero;
            string nombreGenero;
            List<Genero> generosAGuardar = new List<Genero>();
            for (int i = 0; i < dtgGeneros.Rows.Count; i++)
            {
                idGenero = Convert.ToInt32(dtgGeneros.Rows[i].Cells["idGenero"].Value);
                nombreGenero = dtgGeneros.Rows[i].Cells["genero"].Value.ToString();
                generosAGuardar.Add(new Genero(idGenero, nombreGenero, ""));
            }
            peli.Generos = generosAGuardar;
            //crear lista de premios y agregarla
            int idPremio;
            int idCategoria;
            string nombreCategoria;
            List<CategoriaPremio> categoriasAGuardar = new List<CategoriaPremio>();
            for (int i = 0; i < dtgPremios.Rows.Count; i++)
            {
                idPremio = Convert.ToInt32(dtgPremios.Rows[i].Cells["idPremio"].Value);
                idCategoria = Convert.ToInt32(dtgPremios.Rows[i].Cells["idCategoria"].Value);
                nombreCategoria = dtgPremios.Rows[i].Cells["idCategoria"].Value.ToString();
                categoriasAGuardar.Add(new CategoriaPremio(idPremio, idCategoria, nombreCategoria));
            }
            peli.Premios = categoriasAGuardar;

            string errores = "";
            switch (modo)
            {
                case Modo.nuevo:
                    errores = servPelicula.insertarPelicula(peli, radDBHelper.Checked);
                    break;
                case Modo.modificar:
                    errores = servPelicula.actualizarPelicula(peli);
                    break;
            }

            if (errores != "Transaccion realizada con exito")
            {
                MessageBox.Show(errores, "Error de guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Película registrada exitosamente", "Resultado operación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            habilitarCampos(false);
            inicializarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                int id = Convert.ToInt32(txtId.Text);
                Pelicula peliEncontrada = servPelicula.obtenerPelicula(id);
                if (peliEncontrada == null)
                {
                    MessageBox.Show("Película no encontrada", "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtTitulo.Text = peliEncontrada.Titulo;
                cmbDirector.SelectedValue = peliEncontrada.Director.Id;
                numDuracion.Value = peliEncontrada.Duracion;
                cmbPais.SelectedValue = peliEncontrada.Id_pais;
                dtpFechaEstreno.Value = peliEncontrada.FechaEstreno;
                dtpFechaFinProyeccion.Value = peliEncontrada.FechaFinProyeccion;
                txtArgumento.Text = peliEncontrada.Argumento;
                //cargar grilla de actores
                for (int i = 0; i < peliEncontrada.Actores.Count; i++)
                {
                    dtgActores.Rows.Add(peliEncontrada.Actores[i].Id, peliEncontrada.Actores[i].Nombre, peliEncontrada.Actores[i].Apellido);
                }
                //cargar grilla de premios
                string nombrePremio = "";
                for (int i = 0; i < peliEncontrada.Premios.Count; i++)
                {
                    for (int j = 0; j < premios.Count; j++)
                    {
                        if (premios[j].Id == peliEncontrada.Premios[i].Id_premio)
                        {
                            nombrePremio = premios[j].Nombre;
                            break;
                        }
                    }
                    dtgPremios.Rows.Add(peliEncontrada.Premios[i].Id_premio, nombrePremio, peliEncontrada.Premios[i].Id_categoria, peliEncontrada.Premios[i].Categoria);
                    nombrePremio = "Valor debug";
                }
                //cargar lista de generos
                for (int i = 0; i < peliEncontrada.Generos.Count; i++)
                {
                    dtgGeneros.Rows.Add(peliEncontrada.Generos[i].Id, peliEncontrada.Generos[i].Nombre);
                }
            }
            else
            {
                MessageBox.Show("El campo de id no puede estar vacío", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarTitulo_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text != "")
            {
                string titulo = txtTitulo.Text;
                Pelicula peliEncontrada = servPelicula.obtenerPeliculaPorTitulo(titulo);
                if (peliEncontrada == null)
                {
                    MessageBox.Show("Película no encontrada", "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtId.Text = peliEncontrada.Id.ToString();
                cmbDirector.SelectedValue = peliEncontrada.Director.Id;
                numDuracion.Value = peliEncontrada.Duracion;
                cmbPais.SelectedValue = peliEncontrada.Id_pais;
                dtpFechaEstreno.Value = peliEncontrada.FechaEstreno;
                dtpFechaFinProyeccion.Value = peliEncontrada.FechaFinProyeccion;
                txtArgumento.Text = peliEncontrada.Argumento;
                //cargar grilla de actores
                for (int i = 0; i < peliEncontrada.Actores.Count; i++)
                {
                    dtgActores.Rows.Add(peliEncontrada.Actores[i].Id, peliEncontrada.Actores[i].Nombre, peliEncontrada.Actores[i].Apellido);
                }
                //cargar grilla de premios
                string nombrePremio = "";
                for (int i = 0; i < peliEncontrada.Premios.Count; i++)
                {
                    for (int j = 0; j < premios.Count; j++)
                    {
                        if (premios[j].Id == peliEncontrada.Premios[i].Id_premio)
                        {
                            nombrePremio = premios[j].Nombre;
                            break;
                        }
                    }
                    dtgPremios.Rows.Add(peliEncontrada.Premios[i].Id_premio, nombrePremio, peliEncontrada.Premios[i].Id_categoria, peliEncontrada.Premios[i].Categoria);
                }
                //cargar lista de generos
                for (int i = 0; i < peliEncontrada.Generos.Count; i++)
                {
                    dtgGeneros.Rows.Add(peliEncontrada.Generos[i].Id, peliEncontrada.Generos[i].Nombre);
                }
            }
            else
            {
                MessageBox.Show("El campo de título no puede estar vacío", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarGenero_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgGeneros.Rows.Count; i++)
            {
                if(Convert.ToInt32(cmbGenero.SelectedValue) == Convert.ToInt32(dtgGeneros.Rows[i].Cells["idGenero"].Value))
                {
                    MessageBox.Show("No se puede agregar 2 veces el mismo género a una misma película", "Error de género duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            dtgGeneros.Rows.Add(cmbGenero.SelectedValue, cmbGenero.Text);
        }

        private void btnQuitarGenero_Click(object sender, EventArgs e)
        {
            dtgGeneros.Rows.RemoveAt(dtgGeneros.CurrentRow.Index);
        }

        private void cmbPremio_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbPremio.SelectedIndex!=-1 && camposInicializados)
            {
                cmbCategoria.Enabled = true;
                FrmHelper.cargarCombo(servCategoriaPremio.obtenerCategoriasPorPremio(Convert.ToInt32(cmbPremio.SelectedValue)), cmbCategoria, "categoria", "id_categoria");
            }
        }

        private void btnAgregarPremio_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgPremios.Rows.Count; i++)
            {
                if(Convert.ToInt32(cmbPremio.SelectedValue)==Convert.ToInt32(dtgPremios.Rows[i].Cells["idPremio"].Value)
                    && Convert.ToInt32(cmbCategoria.SelectedValue) == Convert.ToInt32(dtgPremios.Rows[i].Cells["idCategoria"].Value))
                {
                    MessageBox.Show("No se puede agregar 2 veces el mismo premio a una misma película", "Error de premio duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            dtgPremios.Rows.Add(cmbPremio.SelectedValue, cmbPremio.Text, cmbCategoria.SelectedValue, cmbCategoria.Text);
        }

        private void btnQuitarPremio_Click(object sender, EventArgs e)
        {
            dtgPremios.Rows.RemoveAt(dtgPremios.CurrentRow.Index);
        }

        private void cmbNombreActor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbNombreActor.SelectedIndex!=-1 && camposInicializados)
            {
                FrmHelper.cargarCombo(servActor.obtenerActoresPorNombre(cmbNombreActor.Text), cmbApellidoActor, "apellido", "id");
            }
        }

        private void btnAgregarActor_Click(object sender, EventArgs e)
        {
            if(cmbApellidoActor.SelectedIndex==-1 || cmbNombreActor.SelectedIndex==-1)
            {
                for (int i = 0; i < dtgActores.Rows.Count; i++)
                {
                    if(cmbNombreActor.Text==dtgActores.Rows[i].Cells["nombre"].Value.ToString() &&
                        cmbApellidoActor.Text == dtgActores.Rows[i].Cells["apellido"].Value.ToString())
                    {
                        MessageBox.Show("No se puede agregar 2 veces el mismo actor a una misma película", "Error de actor duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                dtgActores.Rows.Add(0, cmbNombreActor.Text, cmbApellidoActor.Text);
            }
            else
            {
                for (int i = 0; i < dtgActores.Rows.Count; i++)
                {
                    if (Convert.ToInt32(cmbApellidoActor.SelectedValue) == Convert.ToInt32(dtgActores.Rows[i].Cells["id"].Value))
                    {
                        MessageBox.Show("No se puede agregar 2 veces el mismo actor a una misma película", "Error de actor duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                dtgActores.Rows.Add(cmbApellidoActor.SelectedValue, cmbNombreActor.Text, cmbApellidoActor.Text);
            }
        }

        private void btnQuitarActor_Click(object sender, EventArgs e)
        {
            dtgActores.Rows.RemoveAt(dtgActores.CurrentRow.Index);
        }
    }
}
