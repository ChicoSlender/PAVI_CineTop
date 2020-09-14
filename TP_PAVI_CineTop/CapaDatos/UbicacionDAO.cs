using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI_CineTop.Entidades;
using System.Data;

namespace TP_PAVI_CineTop.CapaDatos
{
    class UbicacionDAO
    {
        public IList<Ubicacion> obtenerTodasUbicaciones()
        {
            string consultaSQL = "SELECT * FROM Ubicacion";
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            List <Ubicacion> ubicaciones = new List<Ubicacion>();

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                ubicaciones.Add(mapearUbicacion(resultado.Rows[i]));
            }

            return ubicaciones;
        }

        private Ubicacion mapearUbicacion(DataRow fila)
        {
            int id = Convert.ToInt32(fila["id"]);
            string nombre = fila["nombre"].ToString();
            string descripcion = fila["descripcion"].ToString();

            return new Ubicacion(id, nombre, descripcion);
        }
    }
}
