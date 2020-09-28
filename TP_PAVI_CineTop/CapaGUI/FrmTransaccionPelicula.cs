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
        Modo modo = Modo.modificar;

        public FrmTransaccionPelicula()
        {
            InitializeComponent();
        }

        private void habilitarCampos(bool v)
        {
            if(modo == Modo.modificar)
            {
                txtId.Enabled = v;
                btnBuscar.Enabled = v;
                btnBaja.Enabled = v;
            }
            txtTitulo.Enabled = v;
            txtDirector.Enabled = v;
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
            txtDirector.Clear();
            numDuracion.Value = 0;
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
                MessageBox.Show("El titulo no puede estar vacio", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtDirector.Text == "")
            {
                MessageBox.Show("El director no puede estar vacio", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(numDuracion.Value<=0)
            {
                MessageBox.Show("La duracion debe ser mayor a 0", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Debe elegir un genero", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cmbPais.SelectedIndex == -1)
            {
                MessageBox.Show("Debe elegir un pais", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(dtpFechaEstreno.Value > dtpFechaFinProyeccion.Value)
            {
                MessageBox.Show("La fecha de estreno debe ser anterior a la fecha de fin de proyeccion", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtArgumento.Text == "")
            {
                MessageBox.Show("El argumento no puede estar vacio", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(dtgActores.Rows.Count==0)
            {
                MessageBox.Show("Debe haber por lo menos un actor", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void FrmTransaccionPelicula_Load(object sender, EventArgs e)
        {
            FrmHelper.cargarCombo(servGenero.obtenerGeneros(), cmbGenero, "nombre", "id");
            FrmHelper.cargarCombo(servPais.obtenerPaises(), cmbPais, "nombre", "id");
            habilitarCampos(false);
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
            DialogResult eleccion = MessageBox.Show("Seguro que quiere eliminar la pelicula elegida?", "Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(eleccion == DialogResult.Yes)
            {
                string errores = servPelicula.borrarPelicula(Convert.ToInt32(txtId.Text));
                if(errores != "")
                {
                    MessageBox.Show(errores, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Pelicula eliminada", "Resultado operacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                habilitarCampos(false);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operacion cancelada", "Resultado operacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string director = txtDirector.Text;
            int duracion = Convert.ToInt32(numDuracion.Value);
            int id_genero = Convert.ToInt32(cmbGenero.SelectedValue);
            int id_pais = Convert.ToInt32(cmbPais.SelectedValue);
            DateTime fechaEstreno = dtpFechaEstreno.Value;
            DateTime fechaFin = dtpFechaFinProyeccion.Value;
            string argumento = txtArgumento.Text;

            Pelicula peli = new Pelicula(id, titulo, id_genero, director, duracion, fechaEstreno, fechaFin, argumento, id_pais, false);

            string nombreActor, apellidoActor;
            ActorPelicula actor;
            List<ActorPelicula> actores = new List<ActorPelicula>();
            for (int i = 0; i < dtgActores.Rows.Count-1; i++)
            {
                nombreActor = dtgActores.Rows[i].Cells["nombre"].Value.ToString();
                apellidoActor = dtgActores.Rows[i].Cells["apellido"].Value.ToString();
                actor = new ActorPelicula(id, i+1, nombreActor, apellidoActor);
                actores.Add(actor);
            }
            peli.Actores = actores;

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

            if(errores != "Transaccion realizada con exito")
            {
                MessageBox.Show(errores, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Pelicula registrada exitosamente", "Resultado operacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Pelicula no encontrada", "Resultado de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtTitulo.Text = peliEncontrada.Titulo;
                txtDirector.Text = peliEncontrada.Director;
                numDuracion.Value = peliEncontrada.Duracion;
                cmbGenero.SelectedValue = peliEncontrada.Id_genero;
                cmbPais.SelectedValue = peliEncontrada.Id_pais;
                dtpFechaEstreno.Value = peliEncontrada.FechaEstreno;
                dtpFechaFinProyeccion.Value = peliEncontrada.FechaFinProyeccion;
                txtArgumento.Text = peliEncontrada.Argumento;
                for (int i = 0; i < peliEncontrada.Actores.Count; i++)
                {
                    dtgActores.Rows.Add(peliEncontrada.Actores[i].Nombre, peliEncontrada.Actores[i].Apellido);
                }
            }
            else
            {
                MessageBox.Show("El id no puede estar vacio", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
