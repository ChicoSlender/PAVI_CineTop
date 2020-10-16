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
    public partial class FrmEstadisticaPeliculas : Form
    {
        ServDirector servDirector = new ServDirector();
        ServGenero servGenero = new ServGenero();
        ServPelicula servPelicula = new ServPelicula();
        public FrmEstadisticaPeliculas()
        {
            InitializeComponent();
        }

        private void FrmEstadisticaPeliculas_Load(object sender, EventArgs e)
        {
            FrmHelper.cargarCombo(servGenero.obtenerGeneros(), cmbGeneros, "nombre", "id");
            FrmHelper.cargarCombo(servDirector.obtenerDirectores(), cmbDirectores, "nombre", "id");
            dtpEstrenoDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEstrenoHasta.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
            generarReporte();
        }

        private void generarReporte()
        {
            DateTime estrenoDesde = dtpEstrenoDesde.Value;
            DateTime estrenoHasta = dtpEstrenoHasta.Value;
            int maxDuracion = Convert.ToInt32(numDuracionMax.Value);
            List<int> directores = new List<int>();
            string nombresDirectores = "";
            for (int i = 0; i < dtgDirectores.Rows.Count; i++)
            {
                directores.Add(Convert.ToInt32(dtgDirectores.Rows[i].Cells["id"].Value));
                nombresDirectores = nombresDirectores + dtgDirectores.Rows[i].Cells["nombre"].Value.ToString() + "\n";
            }
            List<int> generos = new List<int>();
            string nombresGeneros = "";
            for (int i = 0; i < dtgGeneros.Rows.Count; i++)
            {
                generos.Add(Convert.ToInt32(dtgGeneros.Rows[i].Cells["id_genero"].Value));
                nombresGeneros = nombresGeneros + dtgGeneros.Rows[i].Cells["nombre_genero"].Value.ToString() + "\n";
            }

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] {new ReportParameter("paramDurMax", maxDuracion.ToString()+" min"),
                                                                           new ReportParameter("paramDir", nombresDirectores),
                                                                           new ReportParameter("paramGen", nombresGeneros)});

            ReportDataSource ds1 = new ReportDataSource("DataSetCantPelisXGeneroXDirector", servPelicula.obtenerEstadisticaPeliculasPorGeneroYDirector(estrenoDesde, estrenoHasta, directores, generos, maxDuracion));
            ReportDataSource ds2 = new ReportDataSource("DataSetCantPelisXGenero", servPelicula.obtenerEstadisticaPeliculasPorGenero(estrenoDesde, estrenoHasta, directores, generos, maxDuracion));
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds1);
            reportViewer1.LocalReport.DataSources.Add(ds2);
            reportViewer1.RefreshReport();
        }

        private void btnAgregarDirector_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgDirectores.Rows.Count; i++)
            {
                if(Convert.ToInt32(cmbDirectores.SelectedValue)==Convert.ToInt32(dtgDirectores.Rows[i].Cells["id"].Value))
                {
                    MessageBox.Show("No se puede agregar al mismo director 2 veces", "Error de director repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            dtgDirectores.Rows.Add(cmbDirectores.SelectedValue, cmbDirectores.Text);
        }

        private void btnQuitarDirector_Click(object sender, EventArgs e)
        {
            dtgDirectores.Rows.RemoveAt(dtgDirectores.CurrentRow.Index);
        }

        private void btnAgregarGenero_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgGeneros.Rows.Count; i++)
            {
                if (Convert.ToInt32(cmbGeneros.SelectedValue) == Convert.ToInt32(dtgGeneros.Rows[i].Cells["id"].Value))
                {
                    MessageBox.Show("No se puede agregar el mismo género 2 veces", "Error de género repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            dtgGeneros.Rows.Add(cmbGeneros.SelectedValue, cmbGeneros.Text);
        }

        private void btnQuitarGenero_Click(object sender, EventArgs e)
        {
            dtgGeneros.Rows.RemoveAt(dtgGeneros.CurrentRow.Index);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
     
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            generarReporte();
        }
    }
}
