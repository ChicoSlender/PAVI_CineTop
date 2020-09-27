using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI_CineTop.Entidades;
using System.Data;

namespace TP_PAVI_CineTop.CapaDatos
{
    class PaisDAO
    {
        public IList<Pais> obtenerPaises()
        {
            string consultaSQL = "SELECT * FROM Pais";
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();
            List<Pais> paises = new List<Pais>();

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                paises.Add(mapearPais(resultado.Rows[i]));
            }

            return paises;
        }

        private Pais mapearPais(DataRow fila)
        {
            int id = Convert.ToInt32(fila["id"]);
            string nombre = fila["nombre"].ToString();
            string descripcion = fila["descripcion"].ToString();

            return new Pais(id, nombre, descripcion);
        }
    }
}
