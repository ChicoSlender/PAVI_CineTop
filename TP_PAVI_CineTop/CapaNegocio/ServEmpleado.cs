using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI_CineTop.CapaDatos;
using TP_PAVI_CineTop.Entidades;
using System.Data;

namespace TP_PAVI_CineTop.CapaNegocio
{
    class ServEmpleado
    {
        EmpleadoDAO dao = new EmpleadoDAO();
        public IList<Empleado> obtenerEmpleados()
        {
            return dao.obtenerEmpleados();
        }

        public DataTable obtenerTablaEmpleados()
        {
            return dao.obtenerTablaEmpleados();
        }

        public Empleado obtenerEmpleado(int legajo)
        {
            return dao.obtenerEmpleado(legajo);
        }

        public bool existeEmpleado(int legajo)
        {
            return obtenerEmpleado(legajo).Nombre != "";
        }
    }
}
