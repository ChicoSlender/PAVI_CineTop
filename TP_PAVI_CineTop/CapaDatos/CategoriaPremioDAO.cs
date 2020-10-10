using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAVI_CineTop.Entidades;

namespace TP_PAVI_CineTop.CapaDatos
{
    class CategoriaPremioDAO
    {
        public IList<CategoriaPremio> obtenerCategoriasPorPremio(int idPremio)
        {
            string consultaSQL = "SELECT * FROM CategoriaPremio WHERE id_premio="+idPremio;
            DBHelper.GetDBHelper().conectar();
            DataTable tabla = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();
            List<CategoriaPremio> categorias = new List<CategoriaPremio>();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                categorias.Add(mapearCategoria(tabla.Rows[i]));
            }

            return categorias;
        }

        private CategoriaPremio mapearCategoria(DataRow fila)
        {
            int id_premio = Convert.ToInt32(fila["id_premio"]);
            int id_categoria = Convert.ToInt32(fila["id"]);
            string categoria = fila["categoria"].ToString();

            return new CategoriaPremio(id_premio, id_categoria, categoria);
        }
    }
}
