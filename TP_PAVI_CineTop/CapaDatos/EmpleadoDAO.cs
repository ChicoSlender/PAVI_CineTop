using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI_CineTop.Entidades;
using System.Data;
using System.Windows.Forms;

namespace TP_PAVI_CineTop.CapaDatos
{
    class EmpleadoDAO
    {
        public IList<Empleado> obtenerEmpleados()
        {
            string consultaSQL = "SELECT * from Empleado WHERE borrado=0";
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();
            List<Empleado> empleados = new List<Empleado>();

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                empleados.Add(mapearEmpleado(resultado.Rows[i]));
            }

            return empleados;
        }

        internal Empleado obtenerEmpleado(int legajo)
        {
            string consultaSQL = "SELECT * FROM Empleado WHERE borrado=0 AND legajo=" + legajo;
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();

            if (resultado.Rows.Count > 0)
            {
                return mapearEmpleado(resultado.Rows[0]);
            }
            else
            {
                return new Empleado(0, 1, 0, "", "", DateTime.Today, "");
            }
        }

        internal DataTable obtenerTablaEmpleados()
        {
            string consultaSQL = "SELECT legajo, nombre, apellido, nombreUsuario, fechaIngreso from Empleado WHERE borrado=0";
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();

            return resultado;
        }

        public string insertarEmpleado(Empleado empleado)
        {
            string consultaSQL = "INSERT INTO Empleado (legajo, id_tipoDoc, nroDoc, nombre, apellido, fechaIngreso, nombreUsuario, borrado)" +
                                        "VALUES (" + empleado.Legajo + ", " +
                                                empleado.IdTipoDoc + ", " +
                                                empleado.NroDoc + ", " +
                                                "'" + empleado.Nombre + "', " +
                                                "'" + empleado.Apellido + "', " +
                                                "'" + empleado.FechaIngreso.ToString("yyyy-MM-dd") + "', " +
                                                "'" + empleado.NombreUsuario + "', 0)";
            DBHelper.GetDBHelper().conectar();
            DBHelper.GetDBHelper().ejecutarSQL(consultaSQL);
            return DBHelper.GetDBHelper().desconectar();
        }

        public string actualizarEmpleado(Empleado empleado)
        {
            string consultaSQL = "UPDATE Empleado " +
                                 "SET id_tipoDoc=" + empleado.IdTipoDoc + ", " +
                                     "nroDoc=" + empleado.NroDoc + ", " +
                                     "nombre='" + empleado.Nombre + "', " +
                                     "apellido='" + empleado.Apellido + "', " +
                                     "fechaIngreso='" + empleado.FechaIngreso.ToString("yyyy-MM-dd") + "', " +
                                     "nombreUsuario='" + empleado.NombreUsuario + "' " +
                                 "WHERE legajo=" + empleado.Legajo;
            DBHelper.GetDBHelper().conectar();
            DBHelper.GetDBHelper().ejecutarSQL(consultaSQL);
            return DBHelper.GetDBHelper().desconectar();
        }

        public string borrarEmpleado(int legajo)
        {
            string consultaSQL = "UPDATE Empleado " +
                                 "SET borrado=1 " +
                                 "WHERE legajo=" + legajo;
            DBHelper.GetDBHelper().conectar();
            DBHelper.GetDBHelper().ejecutarSQL(consultaSQL);
            return DBHelper.GetDBHelper().desconectar();
        }

        private Empleado mapearEmpleado(DataRow fila)
        {
            int legajo = Convert.ToInt32(fila["legajo"]);
            int idTipoDoc = Convert.ToInt32(fila["id_tipoDoc"]);
            int dni = Convert.ToInt32(fila["nroDoc"]);
            string nombre = fila["nombre"].ToString();
            string apellido = fila["apellido"].ToString();
            DateTime fechaIngreso = Convert.ToDateTime(fila["fechaIngreso"]);
            string nombreUsuario = fila["nombreUsuario"].ToString();

            return new Empleado(legajo, idTipoDoc, dni, nombre, apellido, fechaIngreso, nombreUsuario);
        }

        public DataTable obtenerTablaEmpleadosFiltrada(DateTime fechaDesde, DateTime fechaHasta)
        {
            string consultaSQL = "SELECT legajo, nombre, apellido, nombreUsuario, fechaIngreso from Empleado WHERE borrado=0 AND fechaIngreso BETWEEN '" + fechaDesde.ToString("yyyy-MM-dd") + "' AND '" + fechaHasta.ToString("yyyy-MM-dd")+"'";
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();

            return resultado;
        }


    }
}
