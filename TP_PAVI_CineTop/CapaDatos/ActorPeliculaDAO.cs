using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAVI_CineTop.Entidades;

namespace TP_PAVI_CineTop.CapaDatos
{
    class ActorPeliculaDAO
    {
        public IList<ActorPelicula> obtenerActoresPorPelicula(int id_pelicula)
        {
            string consultaSQL = "SELECT * FROM ActoresXPelicula WHERE id_pelicula="+id_pelicula;
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();
            List<ActorPelicula> actores = new List<ActorPelicula>();

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                actores.Add(mapearActor(resultado.Rows[i]));
            }

            return actores;
        }

        private ActorPelicula mapearActor(DataRow fila)
        {
            int id_pelicula = Convert.ToInt32(fila["id_pelicula"]);
            string nombre = fila["nombreActor"].ToString();
            string apellido = fila["apellidoActor"].ToString();

            return new ActorPelicula(id_pelicula, nombre, apellido);
        }
    }
}
