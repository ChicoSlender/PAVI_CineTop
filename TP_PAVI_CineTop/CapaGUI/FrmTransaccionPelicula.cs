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
                //borrado=1
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
