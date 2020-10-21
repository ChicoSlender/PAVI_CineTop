using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TP_PAVI_CineTop.CapaNegocio;


namespace TP_PAVI_CineTop.CapaGUI
{
    

    public partial class FrmEstadisticaEmpleados : Form
    {
        public FrmEstadisticaEmpleados()
        {
            InitializeComponent();
        }



        private void FrmEstadisticaEmpleados_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ServEmpleado servEmpleado = new ServEmpleado();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", servEmpleado.obtenerTablaTopSalariosEmpleado()));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", servEmpleado.obtenerTablaSalariosXAntiguedad()));
            reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ServEmpleado servEmpleado = new ServEmpleado();
            DateTime fechaDesde = dtpFechaIngresoDesde.Value;
            DateTime fechaHasta = dtpFechaIngresoHasta.Value;

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha de ingreso desde debe ser posterior a la fecha de ingreso hasta", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", servEmpleado.obtenerTablaFiltradaTopSalariosEmpleado(fechaDesde, fechaHasta)));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", servEmpleado.obtenerTablaFiltradaSalariosXAntiguedad(fechaDesde, fechaHasta)));
            reportViewer1.RefreshReport();
        }
    }
}
