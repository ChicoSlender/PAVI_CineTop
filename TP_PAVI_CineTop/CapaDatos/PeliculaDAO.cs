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
            string consultaSQL = "SELECT * FROM Pelicula WHERE id=" + id + " AND borrado=0";
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();

            if (resultado.Rows.Count > 0)
            {
                Pelicula peli = mapearPelicula(resultado.Rows[0]);
                peli.Actores = actorDAO.obtenerActoresPorPelicula(id);
                return peli;
            }

            return null;
        }

        public string insertarPelicula(Pelicula peli)
        {
            string insercionCabecera = "INSERT INTO Pelicula" +
                "(titulo, id_genero, director, duracion, argumento, fechaEstreno, fechaFinProyeccion, id_pais, borrado) " +
                                               "VALUES ('" + peli.Titulo + "', " +
                                                        peli.Id_genero + ", " +
                                                        "'" + peli.Director + "', " +
                                                        peli.Duracion + ", " +
                                                        "'" + peli.Argumento + "', " +
                                                        "'" + peli.FechaEstreno.ToString("yyyy-MM-dd") + "', " +
                                                        "'" + peli.FechaFinProyeccion.ToString("yyyy-MM-dd") + "', " +
                                                        peli.Id_pais + ", 0)";

            DBHelper.GetDBHelper().comenzarTransaccion();
            DBHelper.GetDBHelper().ejecutarSQL(insercionCabecera);
            DataTable tablaIdPelicula = DBHelper.GetDBHelper().consultaSQL("SELECT @@IDENTITY");
            peli.Id = Convert.ToInt32(tablaIdPelicula.Rows[0][0]);

            string insercionActor;
            for (int i = 0; i < peli.Actores.Count; i++)
            {
                insercionActor = "INSERT INTO ActoresXPelicula (id_pelicula, nombreActor, apellidoActor) " +
                                        "VALUES (" + peli.Id + ", '" + peli.Actores[i].Nombre + "', '" + peli.Actores[i].Apellido + "')";
                DBHelper.GetDBHelper().ejecutarSQL(insercionActor);
            }

            return DBHelper.GetDBHelper().desconectar();

        }

        public string actualizarPelicula(Pelicula peli)
        {
            string updateCabecera = "UPDATE Pelicula SET " +
                                                        "titulo='" + peli.Titulo + "', " +
                                                        "id_genero=" + peli.Id_genero + ", " +
                                                        "director='" + peli.Director + "', " +
                                                        "duracion=" + peli.Duracion + ", " +
                                                        "argumento='" + peli.Argumento + "', " +
                                                        "fechaEstreno='" + peli.FechaEstreno.ToString("yyyy-MM-dd") + "', " +
                                                        "fechaFinProyeccion='" + peli.FechaFinProyeccion.ToString("yyyy-MM-dd") + "', " +
                                                        "id_pais=" + peli.Id_pais + " " +
                                                     "WHERE id=" + peli.Id;
            DBHelper.GetDBHelper().comenzarTransaccion();
            DBHelper.GetDBHelper().ejecutarSQL(updateCabecera);

            DBHelper.GetDBHelper().ejecutarSQL("DELETE FROM ActoresXPelicula WHERE id_pelicula=" + peli.Id);

            string insercionActor;
            for (int i = 0; i < peli.Actores.Count; i++)
            {
                insercionActor = "INSERT INTO ActoresXPelicula (id_pelicula, nombreActor, apellidoActor) " +
                                        "VALUES (" + peli.Id + ", '" + peli.Actores[i].Nombre + "', '" + peli.Actores[i].Apellido + "')";
                DBHelper.GetDBHelper().ejecutarSQL(insercionActor);
            }
            return DBHelper.GetDBHelper().desconectar();
        }

        public string borrarPelicula(int id)
        {
            string consultaSQL = "UPDATE Pelicula SET borrado=1 WHERE id=" + id;

            DBHelper.GetDBHelper().conectar();
            DBHelper.GetDBHelper().ejecutarSQL(consultaSQL);
            return DBHelper.GetDBHelper().desconectar();
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
