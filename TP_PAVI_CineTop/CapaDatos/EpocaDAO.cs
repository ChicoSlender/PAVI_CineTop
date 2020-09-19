using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAVI_CineTop.Entidades;

namespace TP_PAVI_CineTop.CapaDatos
{
    class EpocaDAO
    {
        public IList<Epoca> obtenerEpocas()
        {
            string consultaEpoca = "SELECT * FROM Epoca";
            DBHelper.GetDBHelper().conectar();
            DataTable TablaEpocas = DBHelper.GetDBHelper().consultaSQL(consultaEpoca);
            DBHelper.GetDBHelper().desconectar();
            List<Epoca> ListaEpocas = new List<Epoca>();
            for (int i = 0; i < TablaEpocas.Rows.Count; i++)
            {
                ListaEpocas.Add(mapearEpocas(TablaEpocas.Rows[i]));
            }
            return ListaEpocas;
        }

        private Epoca mapearEpocas(DataRow Fila)
        {
            int id = Convert.ToInt32(Fila["id"]);
            string nombre = (Fila["nombre"]).ToString();
            string descripcion = (Fila["descripcion"]).ToString();
            return new Epoca(id, nombre, descripcion);
        }

    }
}
