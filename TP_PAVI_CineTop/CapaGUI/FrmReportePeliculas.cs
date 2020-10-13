using Microsoft.Reporting.WinForms;
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
    public partial class FrmReportePeliculas : Form
    {
        ServPelicula servPelicula = new ServPelicula();
        ServDirector servDirector = new ServDirector();
        ServPais servPais = new ServPais();
        public FrmReportePeliculas()
        {
            InitializeComponent();
        }

        private void FrmReportePeliculas_Load(object sender, EventArgs e)
        {
            FrmHelper.cargarCombo(servPais.obtenerPaises(), cmbPais, "nombre", "id");
            FrmHelper.cargarCombo(servDirector.obtenerDirectores(), cmbDirector, "nombre", "id");
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ReportDataSource ds = new ReportDataSource("ReportePeliculas", servPelicula.obtenerTablaPeliculaExtendida());
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpFechaDesde.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;

            if(fechaDesde>fechaHasta)
            {
                MessageBox.Show("La fecha de estreno desde debe ser posterior a la fecha de estreno hasta", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id_director;
            if(cmbDirector.SelectedIndex == -1)
            {
                id_director = 0;
            }
            else
            {
                id_director = Convert.ToInt32(cmbDirector.SelectedValue);
            }
            int id_pais;
            if (cmbPais.SelectedIndex == -1)
            {
                id_pais = 0;
            }
            else
            {
                id_pais = Convert.ToInt32(cmbPais.SelectedValue);
            }

            ReportDataSource ds = new ReportDataSource("ReportePeliculas", servPelicula.obtenerTablaPeliculaExtendidaFiltrada(fechaDesde, fechaHasta, id_director, id_pais));
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            ReportDataSource ds = new ReportDataSource("ReportePeliculas", servPelicula.obtenerTablaPeliculaExtendida());
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }

        private void limpiarCampos()
        {
            cmbDirector.SelectedIndex = -1;
            cmbPais.SelectedIndex = -1;
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
        }
    }
}
