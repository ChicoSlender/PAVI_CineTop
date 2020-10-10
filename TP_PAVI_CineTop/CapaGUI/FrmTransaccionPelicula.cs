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
        Modo modo = Modo.modificar;
        bool camposInicializados = false;

        public FrmTransaccionPelicula()
        {
            InitializeComponent();
        }

        private void habilitarCampos(bool v)
        {
            if(modo == Modo.modificar)
            {
                txtId.Enabled = v;
                btnBuscarId.Enabled = v;
                btnBaja.Enabled = v;
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

            btnGuardar.Enabled = v;
            btnCancelar.Enabled = v;

            btnNuevo.Enabled = !v;
            btnModificar.Enabled = !v;
        }

        private void limpiarCampos()
        {
            txtId.Clear();
            txtTitulo.Clear();
            numDuracion.Value = 0;
            cmbDirector.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
            cmbPais.SelectedIndex = -1;
            dtpFechaEstreno.Value = DateTime.Today;
            dtpFechaFinProyeccion.Value = DateTime.Today;
            txtArgumento.Clear();
            dtgActores.Rows.Clear();
        }

        private bool validarCampos()
        {
            if(txtTitulo.Text == "")
            {
                MessageBox.Show("El campo de título no puede estar vacío", "ERROR - Título vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cmbDirector.Text == "")
            {
                MessageBox.Show("El campo de director no puede estar vacío", "ERROR - Director vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(numDuracion.Value<=0)
            {
                MessageBox.Show("La duración de la película debe ser mayor a 0 minutos", "ERROR - Duración incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Debe elegir un género", "ERROR - Género vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cmbPais.SelectedIndex == -1)
            {
                MessageBox.Show("Debe elegir un país", "ERROR - País vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(dtpFechaEstreno.Value > dtpFechaFinProyeccion.Value)
            {
                MessageBox.Show("La fecha de estreno debe ser anterior a la fecha de fin de proyección", "ERROR - Fecha incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtArgumento.Text == "")
            {
                MessageBox.Show("El campo del argumento no puede estar vacío", "ERROR - Argumento vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(dtgActores.Rows.Count==0)
            {
                MessageBox.Show("La película debe tener por lo menos un actor", "ERROR - Actores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void FrmTransaccionPelicula_Load(object sender, EventArgs e)
        {
            FrmHelper.cargarCombo(servGenero.obtenerGeneros(), cmbGenero, "nombre", "id");
            FrmHelper.cargarCombo(servPais.obtenerPaises(), cmbPais, "nombre", "id");
            FrmHelper.cargarCombo(servDirector.obtenerDirectores(), cmbDirector, "nombre", "id");
            FrmHelper.cargarCombo(servPremio.obtenerPremios(), cmbPremio, "nombre", "id");
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
            if(eleccion == DialogResult.Yes)
            {
                string errores = servPelicula.borrarPelicula(Convert.ToInt32(txtId.Text));
                if(errores != "")
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
            int id_director = 0;
            if (cmbDirector.SelectedIndex != -1)
                id_director = Convert.ToInt32(cmbDirector.SelectedValue);
            int duracion = Convert.ToInt32(numDuracion.Value);
            int id_pais = Convert.ToInt32(cmbPais.SelectedValue);
            DateTime fechaEstreno = dtpFechaEstreno.Value;
            DateTime fechaFin = dtpFechaFinProyeccion.Value;
            string argumento = txtArgumento.Text;

            Pelicula peli = new Pelicula(id, titulo, id_director, duracion, fechaEstreno, fechaFin, argumento, id_pais, false);

            //crear lista de actores y agregarla
            //crear lista de generos y agregarla
            //crear lista de premios y agregarla

            string errores = "";
            switch (modo)
            {
                case Modo.nuevo:
                    errores = servPelicula.insertarPelicula(peli);
                    break;
                case Modo.modificar:
                    errores = servPelicula.actualizarPelicula(peli);
                    break;
            }

            if(errores != "Transacción realizada con éxito")
            {
                MessageBox.Show(errores, "Error de guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Película registrada exitosamente", "Resultado operación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            habilitarCampos(false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                int id = Convert.ToInt32(txtId.Text);
                Pelicula peliEncontrada = servPelicula.obtenerPelicula(id);
                if(peliEncontrada == null)
                {
                    MessageBox.Show("Película no encontrada", "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtTitulo.Text = peliEncontrada.Titulo;
                cmbDirector.SelectedValue = peliEncontrada.Id_director;
                numDuracion.Value = peliEncontrada.Duracion;
                cmbPais.SelectedValue = peliEncontrada.Id_pais;
                dtpFechaEstreno.Value = peliEncontrada.FechaEstreno;
                dtpFechaFinProyeccion.Value = peliEncontrada.FechaFinProyeccion;
                txtArgumento.Text = peliEncontrada.Argumento;
                //cargar grilla de actores
                //cargar grilla de premios
                //cargar lista de generos
            }
            else
            {
                MessageBox.Show("El campo de id no puede estar vacío", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtArgumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFechaEstreno_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaEstreno_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFechaFinProyeccion_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaFinProyeccion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarGenero_Click(object sender, EventArgs e)
        {
            dtgGeneros.Rows.Add(cmbGenero.SelectedValue, cmbGenero.Text);
        }

        private void btnQuitarGenero_Click(object sender, EventArgs e)
        {
            dtgGeneros.Rows.RemoveAt(dtgGeneros.CurrentRow.Index);
        }

        private void cmbPremio_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbPremio.SelectedIndex!=1 && camposInicializados)
            {
                cmbCategoria.Enabled = true;
                FrmHelper.cargarCombo(servCategoriaPremio.obtenerCategoriasPorPremio(Convert.ToInt32(cmbPremio.SelectedValue)), cmbCategoria, "categoria", "id_categoria");
            }
        }

        private void btnAgregarPremio_Click(object sender, EventArgs e)
        {
            dtgPremios.Rows.Add(cmbPremio.SelectedValue, cmbPremio.Text, cmbCategoria.SelectedValue, cmbCategoria.Text);
        }

        private void btnQuitarPremio_Click(object sender, EventArgs e)
        {
            dtgPremios.Rows.RemoveAt(dtgPremios.CurrentRow.Index);
        }
    }
}
