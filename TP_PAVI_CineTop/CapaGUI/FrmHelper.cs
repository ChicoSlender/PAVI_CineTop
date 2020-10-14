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

        public static void adaptarBooleanosGrilla(DataGridView grilla, string columna, string valorTrue, string valorFalse)
        {
            for (int i = 0; i < grilla.Rows.Count; i++)
            {
                if (Convert.ToBoolean(grilla.Rows[i].Cells[columna].Value))
                    grilla.Rows[i].Cells[columna].Value = valorTrue;
                else
                    grilla.Rows[i].Cells[columna].Value = valorFalse;
            }
        }

        public static void adaptarFechasGrilla(DataGridView grilla, string columna, bool fecha, bool hora)
        {
            if(fecha && hora)
            {
                for (int i = 0; i < grilla.Rows.Count; i++)
                {
                    grilla.Rows[i].Cells[columna].Value = Convert.ToDateTime(grilla.Rows[i].Cells[columna].Value).ToString();
                }
            }
            else if(fecha && !hora)
            {
                for (int i = 0; i < grilla.Rows.Count; i++)
                {
                    grilla.Rows[i].Cells[columna].Value = Convert.ToDateTime(grilla.Rows[i].Cells[columna].Value).ToShortDateString();
                }
            }
            else
            {
                for (int i = 0; i < grilla.Rows.Count; i++)
                {
                    grilla.Rows[i].Cells[columna].Value = Convert.ToDateTime(grilla.Rows[i].Cells[columna].Value).ToShortTimeString();
                }
            }
        }
    }
}
