using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAVI_CineTop.Entidades;

namespace TP_PAVI_CineTop.CapaGUI
{
    public partial class FrmPrincipal : Form
    {
        FrmLogin login = new FrmLogin();
        Usuario usuarioLogueado;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //Muestra el formulario de login al cargarse el formulario principal
            login.ShowDialog();
            /*Al cerrarse la pantalla obtiene la propiedad usuario del login y comprueba si corresponde a un objeto
            usuario "vacio" o "lleno" */
            usuarioLogueado = login.Usuario;

            if(usuarioLogueado == null)
            {
                this.Close();
            }
            else
            {
                this.Text = this.Text + " - USUARIO: " + usuarioLogueado.Nombre;
            }

            login.Dispose();
        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            FrmSalasABMC abmcSalas = new FrmSalasABMC();
            abmcSalas.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleadosABMC abmcEmpleados = new FrmEmpleadosABMC();
            abmcEmpleados.ShowDialog();
        }
    }
}
