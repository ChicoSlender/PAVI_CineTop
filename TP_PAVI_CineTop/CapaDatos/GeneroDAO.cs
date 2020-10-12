using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI_CineTop.Entidades;
using System.Data;

namespace TP_PAVI_CineTop.CapaDatos
{
    class GeneroDAO
    {
        public IList<Genero> obtenerGeneros()
        {
            string consultaSQL = "SELECT * FROM Genero";
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();
            List<Genero> generos = new List<Genero>();

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                generos.Add(mapearGenero(resultado.Rows[i]));
            }

            return generos;
        }

        public IList<Genero> obtenerGeneroPorPelicula(int id_pelicula)
        {
            string consultaSQL = "SELECT g.* FROM GenerosXPelicula gxp JOIN Genero g ON gxp.id_genero=g.id WHERE id_pelicula="+id_pelicula+" AND borrado=0";
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();
            List<Genero> generos = new List<Genero>();

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                generos.Add(mapearGenero(resultado.Rows[i]));
            }

            return generos;
        }

        private Genero mapearGenero(DataRow fila)
        {
            int id = Convert.ToInt32(fila["id"]);
            string nombre = fila["nombre"].ToString();
            string descripcion = fila["descripcion"].ToString();

            return new Genero(id, nombre, descripcion);
        }
    }
}
