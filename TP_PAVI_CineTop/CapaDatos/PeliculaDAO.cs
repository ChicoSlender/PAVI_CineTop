using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAVI_CineTop.Entidades;

namespace TP_PAVI_CineTop.CapaDatos
{
    class PeliculaDAO
    {
        ActorPeliculaDAO actorDAO = new ActorPeliculaDAO();
        public Pelicula obtenerPelicula(int id)
        {
            string consultaSQL = "SELECT * FROM Pelicula WHERE id="+id;
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();

            if(resultado.Rows.Count > 0)
            {
                Pelicula peli = mapearPelicula(resultado.Rows[0]);
                peli.Actores = actorDAO.obtenerActoresPorPelicula(id);
                return peli;
            }

            return null;
        }

        private Pelicula mapearPelicula(DataRow fila)
        {
            int id = Convert.ToInt32(fila["id"]);
            string titulo = fila["titulo"].ToString();
            int id_genero = Convert.ToInt32(fila["id_genero"]);
            string director = fila["director"].ToString();
            int duracion = Convert.ToInt32(fila["duracion"]);
            DateTime fechaEstreno = Convert.ToDateTime(fila["fechaEstreno"]);
            DateTime fechaFinProyeccion = Convert.ToDateTime(fila["fechaFinProyeccion"]);
            string argumento = fila["argumento"].ToString();
            int id_pais = Convert.ToInt32(fila["id_pais"]);

            return new Pelicula(id, titulo, id_genero, director, duracion, fechaEstreno, fechaFinProyeccion, argumento, id_pais, false);
        }
    }
}
