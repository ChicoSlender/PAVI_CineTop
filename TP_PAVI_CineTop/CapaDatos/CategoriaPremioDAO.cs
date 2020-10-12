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

        public IList<CategoriaPremio> obtenerPremiosPorPelicula(int id_pelicula)
        {
            string consultaSQL = "SELECT c.* FROM PremiosXPelicula pxp JOIN CategoriaPremio c ON pxp.id_premio=c.id_premio AND pxp.id_categoria=c.id" +
                                                                        " WHERE id_pelicula="+id_pelicula+" AND borrado=0";
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
