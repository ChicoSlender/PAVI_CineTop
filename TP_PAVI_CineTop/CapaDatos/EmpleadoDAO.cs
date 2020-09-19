using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI_CineTop.Entidades;
using System.Data;

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
            string consultaSQL = "SELECT * FROM Empleado WHERE borrado=0 AND legajo="+legajo;
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();

            if(resultado.Rows.Count>0)
            {
                return mapearEmpleado(resultado.Rows[0]);
            }
            else
            {
                return new Empleado(0,1,0,"","",DateTime.Today,"");
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
    }
}
