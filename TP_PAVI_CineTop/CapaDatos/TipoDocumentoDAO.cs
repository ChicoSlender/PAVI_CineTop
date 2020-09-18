using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI_CineTop.Entidades;
using System.Data;

namespace TP_PAVI_CineTop.CapaDatos
{
    class TipoDocumentoDAO
    {
        public IList<TipoDocumento> obtenerTiposDocumento()
        {
            string consultaSQL = "SELECT * FROM TipoDocumento";
            DBHelper.GetDBHelper().conectar();
            DataTable resultado = DBHelper.GetDBHelper().consultaSQL(consultaSQL);
            DBHelper.GetDBHelper().desconectar();
            List<TipoDocumento> tiposDocumento = new List<TipoDocumento>();

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                tiposDocumento.Add(mapearTipoDocumento(resultado.Rows[i]));
            }

            return tiposDocumento;
        }

        private TipoDocumento mapearTipoDocumento(DataRow fila)
        {
            int id = Convert.ToInt32(fila["id"]);
            string nombre = fila["nombre"].ToString();
            string descripcion = fila["descripcion"].ToString();
            return new TipoDocumento(id, nombre, descripcion);
        }
    }
}
