using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
