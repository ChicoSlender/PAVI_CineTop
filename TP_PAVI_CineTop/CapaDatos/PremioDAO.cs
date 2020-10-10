using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAVI_CineTop.Entidades;

namespace TP_PAVI_CineTop.CapaDatos
{
    class PremioDAO
    {
        public IList<Premio> obtenerPremios()
        {
            string consultaSQL = "SELECT * FROM Premio";
            DBHelper.GetDBHelper().conectar();
            DataTable tabla = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();
            List<Premio> premios = new List<Premio>();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                premios.Add(mapearPremio(tabla.Rows[i]));
            }

            return premios;
        }

        private Premio mapearPremio(DataRow fila)
        {
            int id = Convert.ToInt32(fila["id"]);
            string nombre = fila["nombre"].ToString();
            string descripcion = fila["descripcion"].ToString();

            return new Premio(id, nombre, descripcion);
        }
    }
}
