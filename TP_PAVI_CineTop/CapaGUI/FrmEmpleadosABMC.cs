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
    public partial class FrmEmpleadosABMC : Form
    {
        ServTipoDocumento servTipoDocumento = new ServTipoDocumento();
        ServEmpleado servEmpleado = new ServEmpleado();
        ServUsuario servUsuario = new ServUsuario();
        Empleado seleccionado;
        bool nuevo = false;
        public FrmEmpleadosABMC()
        {
            InitializeComponent();
        }

        private void cargarCampos(int legajo)
        {
            seleccionado = servEmpleado.obtenerEmpleado(legajo);
            txtLegajo.Text = seleccionado.Legajo.ToString();
            txtUsuario.Text = seleccionado.NombreUsuario;
            cmbTipoDocumento.SelectedValue = seleccionado.IdTipoDoc;
            txtDocumento.Text = seleccionado.NroDoc.ToString();
            txtNombre.Text = seleccionado.Nombre;
            txtApellido.Text = seleccionado.Apellido;
            dtpFechaIngreso.Value = seleccionado.FechaIngreso;
        }

        private void habilitarCampos(bool v)
        {
            txtLegajo.Enabled = v;
            txtUsuario.Enabled = v;
            cmbTipoDocumento.Enabled = v;
            txtDocumento.Enabled = v;
            txtNombre.Enabled = v;
            txtApellido.Enabled = v;
            dtpFechaIngreso.Enabled = v;

            btnGuardar.Enabled = v;
            btnCancelar.Enabled = v;

            btnNuevo.Enabled = !v;
            btnModificar.Enabled = !v;
            btnBaja.Enabled = !v;
        }

        private void limpiarCampos()
        {
            txtLegajo.Text = "";
            txtUsuario.Text = "";
            cmbTipoDocumento.SelectedIndex = -1;
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpFechaIngreso.Value = DateTime.Today;
        }

        private void refrescarGrilla()
        {
            FrmHelper.cargarGrilla(servEmpleado.obtenerTablaEmpleados(), dtgEmpleados);
            FrmHelper.adaptarFechasGrilla(dtgEmpleados, "fechaIngreso", true, false);
        }

        private bool validarCampos()
        {
            if(txtLegajo.Text == "")
            {
                MessageBox.Show("El legajo no puede estar vacío", "Legajo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLegajo.Focus();
                return false;
            }
            else if(txtUsuario.Text == "")
            {
                MessageBox.Show("El usuario no puede estar vacío", "Nombre incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return false;
            }
            else if(cmbTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de documento", "Tipo de documento incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbTipoDocumento.Focus();
                return false;
            }
            else if(txtDocumento.Text == "")
            {
                MessageBox.Show("El número de documento no puede estar vacío", "Número de documento incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDocumento.Focus();
                return false;
            }
            else if(txtNombre.Text == "")
            {
                MessageBox.Show("El nombre no puede estar vacío", "Nombre incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
            else if(txtApellido.Text == "")
            {
                MessageBox.Show("El apellido no puede estar vacío", "Apellido incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return false;
            }
            else if(!servUsuario.existeUsuario(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un usuario ya existente", "Error usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLegajo_Validated(object sender, EventArgs e)
        {
            if(!Int32.TryParse(txtLegajo.Text, out int res))
            {
                MessageBox.Show("El legajo debe ser un número", "Dato erróneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLegajo.Text = "";
            }
        }

        private void FrmEmpleadosABMC_Load(object sender, EventArgs e)
        {
            FrmHelper.cargarCombo(servTipoDocumento.obtenerTiposDocumento(), cmbTipoDocumento, "nombre", "id");
            FrmHelper.cargarCombo(servUsuario.obtenerUsuarios(), txtUsuario, "nombre", "nombre");
            this.refrescarGrilla();
            dtpFechaIngreso.Value = DateTime.Today;
            this.habilitarCampos(false);
        }

        private void dtgEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            this.cargarCampos(Convert.ToInt32(dtgEmpleados.CurrentRow.Cells["legajo"].Value));
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.habilitarCampos(true);
            this.limpiarCampos();
            this.nuevo = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.habilitarCampos(true);
            txtLegajo.Enabled = false;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Está seguro de querer borrar al empleado "+txtNombre.Text+" "+txtApellido.Text+"?", "Borrado de empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                string errores = servEmpleado.borrarEmpleado(Convert.ToInt32(txtLegajo.Text));
                
                if(errores != "")
                {
                    MessageBox.Show(errores, "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Empleado borrado con éxito", "Resultado de operación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.refrescarGrilla();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.habilitarCampos(false);
            MessageBox.Show("Operación cancelada", "Resultado de operación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
                return;
            string errores = "";
            int legajo = Convert.ToInt32(txtLegajo.Text);
            string usuario = txtUsuario.Text;
            int idTipoDoc = Convert.ToInt32(cmbTipoDocumento.SelectedValue);
            int nroDoc;
            if(Convert.ToInt32(cmbTipoDocumento.SelectedValue) != 2)
            {
                nroDoc = Convert.ToInt32(txtDocumento.Text);
            }
            else
            {
                nroDoc = Convert.ToInt32(txtDocumento.Text.Replace("-", ""));
            }
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fechaIngreso = dtpFechaIngreso.Value;

            Empleado oEmpleado = new Empleado(legajo, idTipoDoc, nroDoc, nombre, apellido, fechaIngreso, usuario);

            if (nuevo)
            {
                if (servEmpleado.existeEmpleado(Convert.ToInt32(txtLegajo.Text)))
                {
                    MessageBox.Show("Ya existe un empleado con ese legajo", "Error legajo duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                errores = servEmpleado.insertarEmpleado(oEmpleado);
            }
            else
            {
                errores = servEmpleado.actualizarEmpleado(oEmpleado);
            }
            if (errores != "")
            {
                MessageBox.Show(errores, "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.habilitarCampos(false);
            MessageBox.Show("Empleado registrado con éxito", "Resultado de operación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.refrescarGrilla();
            nuevo = false;
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipoDocumento.SelectedValue)
            {
                case 1:
                    txtDocumento.Mask = "99999999";
                    break;
                case 2:
                    txtDocumento.Mask = "99-99999999-9";
                    break;
                default:
                    txtDocumento.Mask = "";
                    break;
            }
        }

        private void txtUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
