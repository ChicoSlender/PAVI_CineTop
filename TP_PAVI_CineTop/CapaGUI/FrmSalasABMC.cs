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
    public partial class FrmSalasABMC : Form
    {
        ServUbicacion servUbicacion;
        ServSala servSala;
        bool nuevo;
        Sala salaSeleccionada;
        public FrmSalasABMC()
        {
            InitializeComponent();
            servUbicacion = new ServUbicacion();
            servSala = new ServSala();
            nuevo = false;
        }

        private void cargarCampos(string nombre)
        {
            salaSeleccionada = servSala.obtenerSala(nombre);
            txtNombre.Text = salaSeleccionada.Nombre;
            numCapacidad.Value = salaSeleccionada.Capacidad;
            cmbUbicacion.SelectedValue = salaSeleccionada.Id_ubicacion;
            ch3D.Checked = salaSeleccionada.Tiene3D;
        }

        private void habilitarCampos(bool v)
        {
            txtNombre.Enabled = v;
            numCapacidad.Enabled = v;
            cmbUbicacion.Enabled = v;
            ch3D.Enabled = v;
            btnGuardar.Enabled = v;
            btnCancelar.Enabled = v;

            btnNuevo.Enabled = !v;
            btnModificar.Enabled = !v;
            btnBaja.Enabled = !v;
            dtgSalas.Enabled = !v;
        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            numCapacidad.Value = 0;
            cmbUbicacion.SelectedIndex = -1;
            ch3D.Checked = false;
        }

        private void FrmSalasABMC_Load(object sender, EventArgs e)
        {
            habilitarCampos(false);
            FrmHelper.cargarCombo(servUbicacion.obtenerUbicaciones(), cmbUbicacion, "Nombre", "Id");
            FrmHelper.cargarGrilla(servSala.obtenerTablaSalas(), dtgSalas);
        }

        private void dtgSalas_SelectionChanged(object sender, EventArgs e)
        {
            cargarCampos(dtgSalas.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.nuevo = true;
            this.habilitarCampos(true);
            this.limpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.habilitarCampos(true);
            this.txtNombre.Enabled = false;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Está seguro de querer borrar la sala "+salaSeleccionada.Nombre,
                "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(res == DialogResult.Yes)
            {
                int resSql = servSala.borrarSala(txtNombre.Text);

                if(resSql != 0)
                    MessageBox.Show("Sala eliminada exitosamente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Hubo un error en el borrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                FrmHelper.cargarGrilla(servSala.obtenerTablaSalas(), dtgSalas);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("El nombre no puede estar vacío", "ERROR - Falta nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numCapacidad.Value <= 0)
            {
                MessageBox.Show("La capacidad debe ser mayor a 0", "ERROR - Capacidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbUbicacion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una ubicación", "ERROR - Ubicación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int res = 0;
            if(nuevo)
            {
                //insert
                string nombre = txtNombre.Text;

                if(servSala.existeSala(nombre))
                {
                    MessageBox.Show("Ya existe una sala registrada con ese nombre", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int capacidad = Convert.ToInt32(numCapacidad.Value);
                int idUbicacion = Convert.ToInt32(cmbUbicacion.SelectedValue);
                bool tiene3d = ch3D.Checked;
                res = servSala.agregarSala(new Sala(nombre, capacidad, idUbicacion, tiene3d));
            }
            else
            {
                //update
                string nombre = txtNombre.Text;
                int capacidad = Convert.ToInt32(numCapacidad.Value);
                int idUbicacion = Convert.ToInt32(cmbUbicacion.SelectedValue);
                bool tiene3d = ch3D.Checked;
                res = servSala.actualizarSala(new Sala(nombre, capacidad, idUbicacion, tiene3d));
            }

            this.habilitarCampos(false);
            this.nuevo = false;
            if(res != 0)
                MessageBox.Show("Sala guardada", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Hubo un error en el guardado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            FrmHelper.cargarGrilla(servSala.obtenerTablaSalas(), dtgSalas);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.habilitarCampos(false);
            MessageBox.Show("Operacion cancelada", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
