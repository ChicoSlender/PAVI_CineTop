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
    public partial class FrmReportePromos : Form
    {
        public FrmReportePromos()
        {
            InitializeComponent();
        }

        private void FrmReportePromos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetInformes.Promo' Puede moverla o quitarla según sea necesario.
            this.promoTableAdapter.Fill(this.dataSetInformes.Promo);

            this.reportViewer1.RefreshReport();
        }



        private void BtnFiltrar_Click_1(object sender, EventArgs e)
        {
            {
                DateTime fechaDesde = dtpDesde.Value;
                DateTime fechaHasta = dtpHasta.Value;

                if (fechaDesde > fechaHasta)
                {
                    MessageBox.Show("La fecha de vigencia DESDE debe ser posterior a la fecha de vigencia HASTA", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetPromos", servPromos.obtenerTablaPromosFiltrada(fechaDesde, fechaHasta)));
                reportViewer1.RefreshReport();
            }

            ServPromo servPromo = new ServPromo();
        }
    }
}
