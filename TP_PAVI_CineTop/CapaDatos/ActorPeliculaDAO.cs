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
            string consultaSQL = "SELECT a.* FROM ActoresXPelicula axp JOIN Actor a ON axp.id_actor=a.id WHERE id_pelicula="+id_pelicula+" AND borrado=0";
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

        public IList<ActorPelicula> obtenerActores()
        {
            string consultaSQL = "SELECT * FROM Actor";
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

        public IList<ActorPelicula> obtenerNombresActoresDistintos()
        {
            string consultaSQL = "SELECT DISTINCT nombre, 0 as apellido, 0 as id FROM Actor";
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

        public IList<ActorPelicula> obtenerActoresPorNombre(string nombre)
        {
            string consultaSQL = "SELECT * FROM Actor WHERE nombre='"+nombre+"'";
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
            int id_actor = Convert.ToInt32(fila["id"]);
            string nombre = fila["nombre"].ToString();
            string apellido = fila["apellido"].ToString();

            return new ActorPelicula(id_actor, nombre, apellido);
        }
    }
}
