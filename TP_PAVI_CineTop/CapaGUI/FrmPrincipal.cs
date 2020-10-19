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
                this.lblBienvenida.Text = this.lblBienvenida.Text + "\n" + usuarioLogueado.Nombre;
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

        private void promosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPromosABMC abmcPromos = new FrmPromosABMC();
            abmcPromos.ShowDialog();
        }

        private void peliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransaccionPelicula frmPelicula = new FrmTransaccionPelicula();
            frmPelicula.ShowDialog();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportePeliculas frmReportePeliculas = new FrmReportePeliculas();
            frmReportePeliculas.ShowDialog();
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteSalas frmReporteSalas = new FrmReporteSalas();
            frmReporteSalas.ShowDialog();
        }

        private void capacidadDeSalasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstadisticaSalas frmEstadisticaSalas = new FrmEstadisticaSalas();
            frmEstadisticaSalas.ShowDialog();
        }

        private void promosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReportePromos frmReportePromos = new FrmReportePromos();
            frmReportePromos.ShowDialog();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReporteEmpleados frmReporteEmpleados = new FrmReporteEmpleados();
            frmReporteEmpleados.ShowDialog();
        }

        private void peliculasPorGéneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstadisticaPeliculas frmEstadisticaPeliculas = new FrmEstadisticaPeliculas();
            frmEstadisticaPeliculas.ShowDialog();
        }
    }
}
