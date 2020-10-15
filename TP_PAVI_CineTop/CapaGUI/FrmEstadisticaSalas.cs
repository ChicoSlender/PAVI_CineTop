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
    public partial class FrmEstadisticaSalas : Form
    {
        ServSala servSala = new ServSala();
        public FrmEstadisticaSalas()
        {
            InitializeComponent();
        }

        private void FrmEstadisticaSalas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] {new ReportParameter("paramCapMin", ""), new ReportParameter("paramCapMax", "") });
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetEstadisticaSalas", servSala.obtenerEstadisticaSalas()));
            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(numCapacidadMaxima.Value<numCapacidadMinima.Value)
            {
                MessageBox.Show("La capacidad máxima debe ser mayor a la capacidad mínima", "Error de valor de capacidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int capMin = Convert.ToInt32(numCapacidadMinima.Value);
            int capMax = Convert.ToInt32(numCapacidadMaxima.Value);

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("paramCapMin", capMin.ToString()), new ReportParameter("paramCapMax", capMax.ToString()) });
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetEstadisticaSalas", servSala.obtenerEstadisticaSalasFiltrada(capMin, capMax)));
            this.reportViewer1.RefreshReport();
        }
    }
}
