using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAVI_CineTop.Entidades;

namespace TP_PAVI_CineTop.CapaDatos
{
    class SalasDAO
    {
        public IList<Sala> obtenerSalas()
        {
            string consultaSQL = "SELECT nombre, capacidad, id_ubicacion, tiene3d FROM Sala WHERE borrado=0";
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();
            List<Sala> salas = new List<Sala>();

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                salas.Add(mapearSala(resultado.Rows[i]));
            }

            return salas;
        }

        internal int actualizarSala(Sala sala)
        {
            string consultaSQL = "UPDATE Sala " +
                                 "SET capacidad=" + sala.Capacidad + "," +
                                     "id_ubicacion=" + sala.Id_ubicacion + "," +
                                     "tiene3d=" + Convert.ToInt32(sala.Tiene3D) + " " +
                                 "WHERE nombre='" + sala.Nombre + "'";

            DBHelper.GetDBHelper().conectar();
            int res = DBHelper.GetDBHelper().ejecutarSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();

            return res;
        }

        internal int borrarSala(string nombre)
        {
            string consultaSQL = "UPDATE Sala " +
                                 "SET borrado=1 " +
                                 "WHERE nombre='" + nombre + "'" ;

            DBHelper.GetDBHelper().conectar();
            int res = DBHelper.GetDBHelper().ejecutarSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();

            return res;
        }

        internal int insertarSala(Sala sala)
        {
            string consultaSQL = "INSERT INTO Sala (nombre, capacidad, id_ubicacion, tiene3d, borrado) " +
                                 "VALUES ('" + sala.Nombre + "'," +
                                 sala.Capacidad + "," +
                                 sala.Id_ubicacion + "," +
                                 Convert.ToInt32(sala.Tiene3D) + ", 0)";

            DBHelper.GetDBHelper().conectar();
            int res = DBHelper.GetDBHelper().ejecutarSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();

            return res;
        }

        internal Sala obtenerSala(string nombre)
        {
            string consultaSQL = "SELECT nombre, capacidad, id_ubicacion, tiene3d FROM Sala " +
                                 "WHERE borrado=0 AND nombre='"+nombre+"'";
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();

            if (resultado.Rows.Count > 0)
                return mapearSala(resultado.Rows[0]);
            else
                return new Sala("", 0, 0, false);
        }

        public DataTable obtenerTablaSalas()
        {
            string consultaSQL = "SELECT s.nombre, u.nombre as ubicacion, s.tiene3d, s.capacidad " +
                                 "FROM Sala s JOIN Ubicacion u ON s.id_ubicacion=u.id WHERE borrado=0";
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();
            return resultado;
        }

        public DataTable obtenerTablaSalasFiltrada(int minCapacidad, int maxCapacidad, int id_ubicacion)
        {
            string consultaSQL = "SELECT s.nombre, u.nombre as ubicacion, s.tiene3d, s.capacidad " +
                                 "FROM Sala s JOIN Ubicacion u ON s.id_ubicacion=u.id " +
                                 "WHERE borrado=0 AND s.capacidad BETWEEN " + minCapacidad + " AND " + maxCapacidad;
            if (id_ubicacion != 0)
                consultaSQL = consultaSQL + " AND s.id_ubicacion=" + id_ubicacion;
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();
            return resultado;
        }

        public DataTable obtenerTablaSalasFiltrada(int minCapacidad, int maxCapacidad, int id_ubicacion, bool tiene3d)
        {
            string consultaSQL = "SELECT s.nombre, u.nombre as ubicacion, s.tiene3d, s.capacidad " +
                                 "FROM Sala s JOIN Ubicacion u ON s.id_ubicacion=u.id " +
                                 "WHERE borrado=0 AND s.capacidad BETWEEN " + minCapacidad + " AND " + maxCapacidad + " AND tiene3d=" + Convert.ToInt32(tiene3d);
            if (id_ubicacion != 0)
                consultaSQL = consultaSQL + " AND s.id_ubicacion=" + id_ubicacion;
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();
            return resultado;
        }

        private Sala mapearSala(DataRow fila)
        {
            string nombre = fila["nombre"].ToString();
            int capacidad = Convert.ToInt32(fila["capacidad"]);
            int id_ubicacion = Convert.ToInt32(fila["id_ubicacion"]);
            bool tiene3d = Convert.ToBoolean(fila["tiene3d"]);

            return new Sala(nombre, capacidad, id_ubicacion, tiene3d);
        }
    }
}
