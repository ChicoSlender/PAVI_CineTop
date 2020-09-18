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

namespace TP_PAVI_CineTop.CapaGUI
{
    public partial class FrmEmpleadosABMC : Form
    {
        ServTipoDocumento servTipoDocumento = new ServTipoDocumento();
        public FrmEmpleadosABMC()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLegajo_Validated(object sender, EventArgs e)
        {
            if(!Int32.TryParse(txtLegajo.Text, out int res))
            {
                MessageBox.Show("El legajo debe ser un numero", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLegajo.Text = "";
            }
        }

        private void FrmEmpleadosABMC_Load(object sender, EventArgs e)
        {
            FrmHelper.cargarCombo(servTipoDocumento.obtenerTiposDocumento(), cmbTipoDocumento, "nombre", "id");
        }
    }
}
