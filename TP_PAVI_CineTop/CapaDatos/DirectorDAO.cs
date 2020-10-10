using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI_CineTop.Entidades;
using System.Data;

namespace TP_PAVI_CineTop.CapaDatos
{
    class DirectorDAO
    {
        public IList<Director> obtenerDirectores()
        {
            string consultaSQL = "SELECT * FROM Director";
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();
            List<Director> directores = new List<Director>();

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                directores.Add(mapearDirector(resultado.Rows[i]));
            }

            return directores;
        }

        private Director mapearDirector(DataRow fila)
        {
            int id = Convert.ToInt32(fila["id"]);
            string nombre = fila["nombre"].ToString();
            return new Director(id, nombre);
        }
    }
}
