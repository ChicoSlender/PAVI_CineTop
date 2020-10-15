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
    public partial class FrmPromosABMC : Form
    {
           
        ServEpoca servEpoca = new ServEpoca();

        ServPromo servPromo = new ServPromo();

        bool nuevo = false;

        public FrmPromosABMC()
        {
            InitializeComponent();
        }

        private void lblLegajo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmPromosABMC_Load(object sender, EventArgs e)
        {
            
            FrmHelper.cargarCombo(servEpoca.ObtenerEpocas(), cmbEpoca, "nombre", "id");
            this.refrescarGrilla();
            HabilitarCampos(false);
        }

        private void refrescarGrilla()
        {
            FrmHelper.cargarGrilla(servPromo.obtenerTabla(), dtgPromos);
            FrmHelper.adaptarFechasGrilla(dtgPromos, "Fecha_Desde", true, false);
            FrmHelper.adaptarFechasGrilla(dtgPromos, "Fecha_Hasta", true, false);
        }

        private void dtgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LblFechaHasta_Click(object sender, EventArgs e)
        {

        }

        private void HabilitarCampos(bool x)
        {
            txtMayores.Enabled = x;
            txtMenores.Enabled = x;
            cmbEpoca.Enabled = x;
            txtPromo.Enabled = x;
            dtpFechaDesde.Enabled = x;
            dtpFechaHasta.Enabled = x;
            btnGuardar.Enabled = x;
            btnCancelar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnModificar.Enabled = !x; 
            btnBaja.Enabled = !x;
        }

        private bool ValidarCampos()
        {
            if (txtPromo.Text == "")
            {
                MessageBox.Show("El ID no puede estar vacío.");
                return false;
            }
            else if (txtMayores.Text == "")
            {
                MessageBox.Show("El precio para mayores no puede estar vacío.");
                return false;
            }
            else if (txtMenores.Text == "")
            {
                MessageBox.Show("El precio para menores no puede estar vacío.");
                return false;
            }
            else if (cmbEpoca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una época.");
                return false;
            }
            else if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("La fecha inicial no puede ser posterior a fecha final.");
                return false;
            }
            else if (!Int32.TryParse(txtPromo.Text, out int valor))
            {
                MessageBox.Show("El ID de promo debe ser un número entero.");
                return false;
            }
            else if (!float.TryParse(txtMayores.Text, out float valor2))
            {
                MessageBox.Show("El precio para mayores debe ser un valor con decimales.");
                return false;
            }
            else if (!float.TryParse(txtMenores.Text, out float valor3))
            {
                MessageBox.Show("El precio para menores debe ser un valor con decimales.");
                return false;
            }
            return true;
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);
            nuevo = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);
            txtPromo.Enabled = (false);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea borrar esta promoción?", "Borrar promo", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtPromo.Text);
                string error = servPromo.borrar_promo(id);

                if (error != "")
                {
                    MessageBox.Show(error);
                    return;
                }
                MessageBox.Show("Promo borrada","OK");
                this.refrescarGrilla();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarCampos(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            int id = Convert.ToInt32(txtPromo.Text);
            int id_epoca = Convert.ToInt32(cmbEpoca.SelectedValue);
            float precio_menores = Convert.ToSingle(txtMenores.Text);
            float precio_mayores = Convert.ToSingle(txtMayores.Text);
            DateTime vigencia_desde = dtpFechaDesde.Value;
            DateTime vigencia_hasta = dtpFechaHasta.Value;

            Promo nuevaPromo = new Promo(id, id_epoca, precio_menores, precio_mayores, vigencia_desde, vigencia_hasta);
            string error = "";

            if (nuevo)
            {
                if (servPromo.existe_promo(id))
                {
                    MessageBox.Show("Ya existe una promo con la id " + id);
                    return;
                }

                error = servPromo.insertar_promo(nuevaPromo);

            }
            else
            {
                error = servPromo.actualizar_promo(nuevaPromo);
            }

            if (error != "")
            {
                MessageBox.Show(error);
            }

            MessageBox.Show("Operacion realizada con éxito.");
            this.refrescarGrilla();

            HabilitarCampos(false);
            nuevo = false;
        }

        private void txtPromo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtgPromos_SelectionChanged(object sender, EventArgs e)
        {
            int id_seleccionado = Convert.ToInt32(dtgPromos.CurrentRow.Cells["ID_Promo"].Value);
            Promo promo_seleccionada = servPromo.obtenerPromoID(id_seleccionado);

            txtPromo.Text = promo_seleccionada.Id.ToString();
            cmbEpoca.SelectedValue = promo_seleccionada.Id_epoca;
            txtMayores.Text = promo_seleccionada.Precio_mayores.ToString();
            txtMenores.Text = promo_seleccionada.Precio_menores.ToString();
            dtpFechaDesde.Value = promo_seleccionada.Vigencia_desde;
            dtpFechaHasta.Value = promo_seleccionada.Vigencia_hasta;
        }


    }
}
