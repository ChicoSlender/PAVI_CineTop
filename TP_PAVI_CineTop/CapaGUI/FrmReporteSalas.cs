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
using System.Data;

namespace TP_PAVI_CineTop.CapaGUI
{
    public partial class FrmReporteSalas : Form
    {
        ServUbicacion servUbicacion = new ServUbicacion();
        ServSala servSala = new ServSala();
        public FrmReporteSalas()
        {
            InitializeComponent();
        }

        private void FrmReporteSalas_Load(object sender, EventArgs e)
        {
            FrmHelper.cargarCombo(servUbicacion.obtenerUbicaciones(), cmbUbicacion, "nombre", "id");
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ReportDataSource ds = new ReportDataSource("DataSetReporteSalas", servSala.obtenerTablaSalas());
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }

        private void actualizarReporte(DataTable tablaReporte)
        {
            ReportDataSource ds = new ReportDataSource("DataSetReporteSalas", tablaReporte);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }

        private void limpiarCampos()
        {
            cmbUbicacion.SelectedIndex = -1;
            numMinCapacidad.Value = 0;
            numMaxCapacidad.Value = 0;
            chkFiltro3d.Checked = false;
        }

        private void chkFiltro3d_CheckedChanged(object sender, EventArgs e)
        {
            chk3d.Enabled = chkFiltro3d.Checked;
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            actualizarReporte(servSala.obtenerTablaSalas());
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(numMaxCapacidad.Value<numMinCapacidad.Value)
            {
                MessageBox.Show("La capacidad máxima debe ser mayor a la capacidad mínima", "Error en rango de capacidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable tablaReporte;
            int minCapacidad = Convert.ToInt32(numMinCapacidad.Value);
            int maxCapacidad = Convert.ToInt32(numMaxCapacidad.Value);
            int id_ubicacion;
            if (cmbUbicacion.SelectedIndex == -1)
                id_ubicacion = 0;
            else
                id_ubicacion = Convert.ToInt32(cmbUbicacion.SelectedValue);

            if (chkFiltro3d.Checked)
            {
                bool tiene3d = chk3d.Checked;
                tablaReporte = servSala.obtenerTablaSalasFiltrada(minCapacidad, maxCapacidad, id_ubicacion, tiene3d);
            }
            else
                tablaReporte = servSala.obtenerTablaSalasFiltrada(minCapacidad, maxCapacidad, id_ubicacion);

            actualizarReporte(tablaReporte);
        }
    }
}
