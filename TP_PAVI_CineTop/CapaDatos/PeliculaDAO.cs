using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAVI_CineTop.Entidades;
using System.Windows.Forms;

namespace TP_PAVI_CineTop.CapaDatos
{
    class PeliculaDAO
    {
        ActorPeliculaDAO actorDAO = new ActorPeliculaDAO();
        GeneroDAO generoDAO = new GeneroDAO();
        CategoriaPremioDAO categoriaPremioDAO = new CategoriaPremioDAO();
        public Pelicula obtenerPelicula(int id)
        {
            string consultaSQL = "SELECT * FROM Pelicula WHERE id=" + id + " AND borrado=0";
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();

            if (resultado.Rows.Count > 0)
            {
                Pelicula peli = mapearPelicula(resultado.Rows[0]);
                peli.Actores = actorDAO.obtenerActoresPorPelicula(peli.Id);
                peli.Generos = generoDAO.obtenerGeneroPorPelicula(peli.Id);
                peli.Premios = categoriaPremioDAO.obtenerPremiosPorPelicula(peli.Id);
                return peli;
            }

            return null;
        }

        public Pelicula obtenerPeliculaPorTitulo(string titulo)
        {
            string consultaSQL = "SELECT * FROM Pelicula WHERE titulo='" + titulo + "'";
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();

            if(resultado.Rows.Count>0)
            {
                Pelicula peli = mapearPelicula(resultado.Rows[0]);
                peli.Actores = actorDAO.obtenerActoresPorPelicula(peli.Id);
                peli.Generos = generoDAO.obtenerGeneroPorPelicula(peli.Id);
                peli.Premios = categoriaPremioDAO.obtenerPremiosPorPelicula(peli.Id);
                return peli;
            }

            return null;
        }

        public AutoCompleteStringCollection obtenerNombresPeliculasVigentes()
        {
            string consultaSQL = "SELECT DISTINCT titulo FROM Pelicula WHERE fechaFinProyeccion>='"+DateTime.Today.ToString("yyyy-MM-dd")+"'";
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();
            AutoCompleteStringCollection nombres = new AutoCompleteStringCollection();

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                nombres.Add(resultado.Rows[i][0].ToString());
            }

            return nombres;
        }

        public string insertarPelicula(Pelicula peli)
        {
            DBHelper.GetDBHelper().comenzarTransaccion();
            //Verificar si existe el director y sino insertarlo en la tabla Director y asignar el Id al objeto peli
            if(peli.Director.Id == 0)
            {
                DBHelper.GetDBHelper().ejecutarSQL("INSERT INTO Director VALUES ('"+peli.Director.Nombre+"')");
                DataTable tablaIdDirector = DBHelper.GetDBHelper().consultaSQL("SELECT @@IDENTITY");
                peli.Director.Id = Convert.ToInt32(tablaIdDirector.Rows[0][0]);
            }
            string insercionCabecera = "INSERT INTO Pelicula" +
                "(titulo, id_director, duracion, argumento, fechaEstreno, fechaFinProyeccion, id_pais, borrado) " +
                                               "VALUES ('" + peli.Titulo + "', " +
                                                        peli.Director.Id + ", " +
                                                        peli.Duracion + ", " +
                                                        "'" + peli.Argumento + "', " +
                                                        "'" + peli.FechaEstreno.ToString("yyyy-MM-dd") + "', " +
                                                        "'" + peli.FechaFinProyeccion.ToString("yyyy-MM-dd") + "', " +
                                                        peli.Id_pais + ", 0)";

            DBHelper.GetDBHelper().ejecutarSQL(insercionCabecera);
            DataTable tablaIdPelicula = DBHelper.GetDBHelper().consultaSQL("SELECT @@IDENTITY");
            peli.Id = Convert.ToInt32(tablaIdPelicula.Rows[0][0]);

            //insertar actores (insertando en la tabla Actores los no existentes)
            DataTable tablaIdActor;
            string insercionActor;
            for (int i = 0; i < peli.Actores.Count; i++)
            {
                if (peli.Actores[i].Id == 0)
                {
                    DBHelper.GetDBHelper().ejecutarSQL("INSERT INTO Actor (nombre, apellido) VALUES ('" +
                                                                                                    peli.Actores[i].Nombre + "', '" +
                                                                                                    peli.Actores[i].Apellido + "')");
                    tablaIdActor = DBHelper.GetDBHelper().consultaSQL("SELECT @@IDENTITY");
                    peli.Actores[i].Id = Convert.ToInt32(tablaIdActor.Rows[0][0]);
                }
                insercionActor = "INSERT INTO ActoresXPelicula (id_pelicula, id_actor, borrado) " +
                                                        "VALUES (" + peli.Id + ", " + peli.Actores[i].Id + ", 0)";
                DBHelper.GetDBHelper().ejecutarSQL(insercionActor);
            }
            //insertar generos
            string insercionGenero;
            for (int i = 0; i < peli.Generos.Count; i++)
            {
                insercionGenero = "INSERT INTO GenerosXPelicula (id_pelicula, id_genero, borrado)" +
                                                         "VALUES (" + peli.Id + ", "+ peli.Generos[i].Id + ", 0)";
                DBHelper.GetDBHelper().ejecutarSQL(insercionGenero);
            }
            //insertar premios
            string insercionPremios;
            for (int i = 0; i < peli.Premios.Count; i++)
            {
                insercionPremios = "INSERT INTO PremiosXPelicula (id_pelicula, id_premio, id_categoria, borrado)" +
                                                         "VALUES (" + peli.Id + ", " + peli.Premios[i].Id_premio + ", " + peli.Premios[i].Id_categoria + ", 0)";
                DBHelper.GetDBHelper().ejecutarSQL(insercionPremios);
            }

            return DBHelper.GetDBHelper().desconectar();

        }

        public string actualizarPelicula(Pelicula peli)
        {
            DBHelper.GetDBHelper().comenzarTransaccion();
            if (peli.Director.Id == 0)
            {
                DBHelper.GetDBHelper().ejecutarSQL("INSERT INTO Director VALUES ('" + peli.Director.Nombre + "')");
                DataTable tablaIdDirector = DBHelper.GetDBHelper().consultaSQL("SELECT @@IDENTITY");
                peli.Director.Id = Convert.ToInt32(tablaIdDirector.Rows[0][0]);
            }
            string updateCabecera = "UPDATE Pelicula SET " +
                                                        "titulo='" + peli.Titulo + "', " +
                                                        "id_director=" + peli.Director.Id + ", " +
                                                        "duracion=" + peli.Duracion + ", " +
                                                        "argumento='" + peli.Argumento + "', " +
                                                        "fechaEstreno='" + peli.FechaEstreno.ToString("yyyy-MM-dd") + "', " +
                                                        "fechaFinProyeccion='" + peli.FechaFinProyeccion.ToString("yyyy-MM-dd") + "', " +
                                                        "id_pais=" + peli.Id_pais + " " +
                                                     "WHERE id=" + peli.Id;
            DBHelper.GetDBHelper().ejecutarSQL(updateCabecera);

            //actualizar actores
            DataTable tablaActoresYaInsertados = DBHelper.GetDBHelper().consultaSQL("SELECT id_actor, borrado FROM ActoresXPelicula WHERE id_pelicula="+peli.Id);
            int[] parIdBorrado = {0,0};
            List<int[]> actoresYaInsertados = new List<int[]>();
            bool insertado;
            for (int i = 0; i < tablaActoresYaInsertados.Rows.Count; i++)
            {
                parIdBorrado[0] = Convert.ToInt32(tablaActoresYaInsertados.Rows[i]["id_actor"]);
                parIdBorrado[1] = Convert.ToInt32(tablaActoresYaInsertados.Rows[i]["borrado"]);
                actoresYaInsertados.Add((int[])parIdBorrado.Clone());
            }
            DataTable tablaIdActor;
            string consultaActor;
            for (int i = 0; i < peli.Actores.Count; i++)
            {
                insertado = false;
                if (peli.Actores[i].Id == 0)
                {
                    DBHelper.GetDBHelper().ejecutarSQL("INSERT INTO Actor (nombre, apellido) VALUES ('" +
                                                                                                    peli.Actores[i].Nombre + "', '" +
                                                                                                    peli.Actores[i].Apellido + "')");
                    tablaIdActor = DBHelper.GetDBHelper().consultaSQL("SELECT @@IDENTITY");
                    peli.Actores[i].Id = Convert.ToInt32(tablaIdActor.Rows[0][0]);
                }
                else {
                    for (int j = 0; j < actoresYaInsertados.Count; j++)
                    {
                        if (actoresYaInsertados[j][0] == peli.Actores[i].Id)
                        {
                            if (actoresYaInsertados[j][1] == 1)
                            {
                                consultaActor = "UPDATE ActoresXPelicula SET borrado=0 WHERE id_actor=" + peli.Actores[i].Id + " AND id_pelicula=" + peli.Id;
                                DBHelper.GetDBHelper().ejecutarSQL(consultaActor);
                            }
                            actoresYaInsertados.RemoveAt(j);
                            insertado = true;
                            break;
                        }
                    }
                }
                if (!insertado)
                {
                    consultaActor = "INSERT INTO ActoresXPelicula (id_pelicula, id_actor, borrado) " +
                                                            "VALUES (" + peli.Id + ", " + peli.Actores[i].Id + ", 0)";
                    DBHelper.GetDBHelper().ejecutarSQL(consultaActor);
                }
            }

            for (int i = 0; i < actoresYaInsertados.Count; i++)
            {
                if(actoresYaInsertados[i][1]==0)
                {
                    consultaActor = "UPDATE ActoresXPelicula SET borrado=1 WHERE id_pelicula=" + peli.Id + " AND id_actor=" + actoresYaInsertados[i][0];
                    DBHelper.GetDBHelper().ejecutarSQL(consultaActor);
                }
            }
            //actualizar generos
            DataTable tablaGenerosYaInsertados = DBHelper.GetDBHelper().consultaSQL("SELECT id_genero, borrado FROM GenerosXPelicula WHERE id_pelicula="+peli.Id);
            int[] parIdGeneroBorrado = {0,0};
            List<int[]> generosYaInsertados = new List<int[]>();
            bool generoInsertado;
            string consultaGenero;
            for (int i = 0; i < tablaGenerosYaInsertados.Rows.Count; i++)
            {
                parIdGeneroBorrado[0] = Convert.ToInt32(tablaGenerosYaInsertados.Rows[i]["id_genero"]);
                parIdGeneroBorrado[1] = Convert.ToInt32(tablaGenerosYaInsertados.Rows[i]["borrado"]);
                generosYaInsertados.Add((int[])parIdGeneroBorrado.Clone());
            }

            for (int i = 0; i < peli.Generos.Count; i++)
            {
                generoInsertado = false;
                for (int j = 0; j < generosYaInsertados.Count; j++)
                {
                    if(generosYaInsertados[j][0]==peli.Generos[i].Id)
                    {
                        if(generosYaInsertados[j][1]==1)
                        {
                            consultaGenero = "UPDATE GenerosXPelicula SET borrado=0 WHERE id_pelicula=" + peli.Id + " AND id_genero=" + peli.Generos[i].Id;
                            DBHelper.GetDBHelper().ejecutarSQL(consultaGenero);
                        }
                        generosYaInsertados.RemoveAt(j);
                        generoInsertado = true;
                        break;
                    }
                }
                if(!generoInsertado)
                {
                    consultaGenero = "INSERT INTO GenerosXPelicula (id_pelicula, id_genero, borrado)" +
                                                         "VALUES (" + peli.Id + ", " + peli.Generos[i].Id + ", 0)";
                    DBHelper.GetDBHelper().ejecutarSQL(consultaGenero);
                }
            }

            for (int i = 0; i < generosYaInsertados.Count; i++)
            {
                if(generosYaInsertados[i][1]==0)
                {
                    consultaGenero = "UPDATE GenerosXPelicula SET borrado=1 WHERE id_pelicula=" + peli.Id + " AND id_genero=" + generosYaInsertados[i][0];
                    DBHelper.GetDBHelper().ejecutarSQL(consultaGenero);
                }
            }
            //actualizar premios
            DataTable tablaPremiosYaInsertados = DBHelper.GetDBHelper().consultaSQL("SELECT id_premio, id_categoria, borrado FROM PremiosXPelicula WHERE id_pelicula=" + peli.Id);
            int[] trioIdPremioIdCategoriaBorrado = { 0, 0 ,0};
            List<int[]> premiosYaInsertados = new List<int[]>();
            bool premioInsertado;
            string consultaPremio;
            for (int i = 0; i < tablaPremiosYaInsertados.Rows.Count; i++)
            {
                trioIdPremioIdCategoriaBorrado[0] = Convert.ToInt32(tablaPremiosYaInsertados.Rows[i]["id_premio"]);
                trioIdPremioIdCategoriaBorrado[1] = Convert.ToInt32(tablaPremiosYaInsertados.Rows[i]["id_categoria"]);
                trioIdPremioIdCategoriaBorrado[2] = Convert.ToInt32(tablaPremiosYaInsertados.Rows[i]["borrado"]);
                premiosYaInsertados.Add((int[])trioIdPremioIdCategoriaBorrado.Clone());
            }

            for (int i = 0; i < peli.Premios.Count; i++)
            {
                premioInsertado = false;
                for (int j = 0; j < premiosYaInsertados.Count; j++)
                {
                    if (premiosYaInsertados[j][0] == peli.Premios[i].Id_premio && premiosYaInsertados[j][1] == peli.Premios[i].Id_categoria)
                    {
                        if (premiosYaInsertados[j][2] == 1)
                        {
                            consultaPremio = "UPDATE PremiosXPelicula SET borrado=0 WHERE id_pelicula=" + peli.Id + " AND id_premio=" + peli.Premios[i].Id_premio+" AND id_categoria="+ peli.Premios[i].Id_categoria;
                            DBHelper.GetDBHelper().ejecutarSQL(consultaPremio);
                        }
                        premiosYaInsertados.RemoveAt(j);
                        premioInsertado = true;
                        break;
                    }
                }
                if (!premioInsertado)
                {
                    consultaPremio = "INSERT INTO PremiosXPelicula (id_pelicula, id_premio, id_categoria, borrado)" +
                                                         "VALUES (" + peli.Id + ", " + peli.Premios[i].Id_premio + ", " + peli.Premios[i].Id_categoria + ", 0)";
                    DBHelper.GetDBHelper().ejecutarSQL(consultaPremio);
                }
            }

            for (int i = 0; i < premiosYaInsertados.Count; i++)
            {
                if (premiosYaInsertados[i][2] == 0)
                {
                    consultaPremio = "UPDATE PremiosXPelicula SET borrado=1 WHERE id_pelicula=" + peli.Id + " AND id_premio=" + premiosYaInsertados[i][0] + " AND id_categoria=" + premiosYaInsertados[i][1];
                    DBHelper.GetDBHelper().ejecutarSQL(consultaPremio);
                }
            }

            return DBHelper.GetDBHelper().desconectar();
        }

        public string borrarPelicula(int id)
        {
            string consultaSQL = "UPDATE Pelicula SET borrado=1 WHERE id=" + id;

            //agregar el borrado de entradas de las tablas ActoresXPelicula, GenerosXPelicula y PremiosXPelicula

            DBHelper.GetDBHelper().conectar();
            DBHelper.GetDBHelper().ejecutarSQL(consultaSQL);
            return DBHelper.GetDBHelper().desconectar();
        }

        private Pelicula mapearPelicula(DataRow fila)
        {
            int id = Convert.ToInt32(fila["id"]);
            string titulo = fila["titulo"].ToString();
            Director director = new Director(Convert.ToInt32(fila["id_director"]), "");
            int duracion = Convert.ToInt32(fila["duracion"]);
            DateTime fechaEstreno = Convert.ToDateTime(fila["fechaEstreno"]);
            DateTime fechaFinProyeccion = Convert.ToDateTime(fila["fechaFinProyeccion"]);
            string argumento = fila["argumento"].ToString();
            int id_pais = Convert.ToInt32(fila["id_pais"]);

            return new Pelicula(id, titulo, director, duracion, fechaEstreno, fechaFinProyeccion, argumento, id_pais, false);
        }
    }
}
