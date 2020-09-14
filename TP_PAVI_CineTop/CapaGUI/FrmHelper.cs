using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace TP_PAVI_CineTop.CapaGUI
{
    class FrmHelper
    {
        public static void cargarCombo(Object fuente, ComboBox combo, string display, string value)
        {
            combo.DataSource = fuente;
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.SelectedIndex = -1;
        }

        public static void cargarGrilla(DataTable fuente, DataGridView grilla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < fuente.Rows.Count; i++)
            {
                grilla.Rows.Add(fuente.Rows[i].ItemArray);
            }
        }
    }
}
