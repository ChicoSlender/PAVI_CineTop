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
    public partial class FrmReporteEmpleados : Form
    {
        public FrmReporteEmpleados()
        {
            InitializeComponent();
        }

        private void FrmReporteEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.dataSet1.Empleado);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpDesde.Value;
            DateTime fechaHasta = dtpHasta.Value;

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha de ingreso DESDE debe ser posterior a la fecha de ingreso HASTA", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetEmpleados", servEmpleado.obtenerTablaEmpleadosFiltrada(fechaDesde, fechaHasta)));
            reportViewer1.RefreshReport();
        }

        ServEmpleado servEmpleado = new ServEmpleado();

        private void LblFechaAltasHasta_Click(object sender, EventArgs e)
        {

        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
