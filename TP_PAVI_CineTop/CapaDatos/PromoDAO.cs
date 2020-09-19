using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAVI_CineTop.Entidades;

namespace TP_PAVI_CineTop.CapaDatos
{
    class PromoDAO
    {
        public DataTable obtenerTabla()
        {
            string consultaEpoca = "SELECT id,id_epoca,precio_menores,precio_mayores,vigencia_desde,vigencia_hasta FROM Promo WHERE borrado=0";
            DBHelper.GetDBHelper().conectar();
            DataTable TablaPromo = DBHelper.GetDBHelper().consultaSQL(consultaEpoca);
            DBHelper.GetDBHelper().desconectar();
            return TablaPromo;
        }

        public Promo obtenerPromoID(int id)
        {
            string Consulta = "SELECT * FROM Promo WHERE id=" + id;
            DBHelper.GetDBHelper().conectar();
            DataTable TablaPromo = DBHelper.GetDBHelper().consultaSQL(Consulta);
            DBHelper.GetDBHelper().desconectar();
            if (TablaPromo.Rows.Count > 0)
            {
                int id_promo = Convert.ToInt32(TablaPromo.Rows[0]["id"]);
                int id_epoca = Convert.ToInt32(TablaPromo.Rows[0]["id_epoca"]);
                float precio_menores = Convert.ToSingle(TablaPromo.Rows[0]["precio_menores"]);
                float precio_mayores = Convert.ToSingle(TablaPromo.Rows[0]["precio_mayores"]);
                DateTime vigencia_desde = Convert.ToDateTime(TablaPromo.Rows[0]["vigencia_desde"]);
                DateTime vigencia_hasta = Convert.ToDateTime(TablaPromo.Rows[0]["vigencia_hasta"]);


                return new Promo(id_promo, id_epoca, precio_menores, precio_mayores, vigencia_desde, vigencia_hasta);
            }
            return null;
 
        }
        public string insertar_promo(Promo promo)
        {
            string consulta = "INSERT INTO Promo VALUES("  + promo.Id + ","+ promo.Id_epoca +"," + promo.Precio_menores.ToString().Replace(",", ".") + ","+ promo.Precio_menores.ToString().Replace(",",".") + ",'"
                + promo.Vigencia_desde.ToString("yyyy-MM-dd") +"','" + promo.Vigencia_hasta.ToString("yyyy-MM-dd") + "',0)";
            DBHelper.GetDBHelper().conectar();
            DBHelper.GetDBHelper().ejecutarSQL(consulta);
            string errores = DBHelper.GetDBHelper().desconectar();

            return errores;
        }

        public string actualizar_promo(Promo promo)
        {

            string consulta = "UPDATE Promo SET id_epoca=" + promo.Id_epoca + ",precio_menores=" + promo.Precio_menores.ToString().Replace(",", ".") + ",precio_mayores=" + promo.Precio_mayores.ToString().Replace(",", ".") + ",vigencia_desde='"
                + promo.Vigencia_desde.ToString("yyyy-MM-dd") + "',vigencia_hasta='" + promo.Vigencia_hasta.ToString("yyyy-MM-dd") + "' WHERE id="+ promo.Id;

            DBHelper.GetDBHelper().conectar();
            DBHelper.GetDBHelper().ejecutarSQL(consulta);
            string errores = DBHelper.GetDBHelper().desconectar();

            return errores;
        }

        public string borrar_promo(int id)
        {
            string consulta = "UPDATE Promo SET borrado=1 WHERE id=" + id;

            DBHelper.GetDBHelper().conectar();
            DBHelper.GetDBHelper().ejecutarSQL(consulta);
            string errores = DBHelper.GetDBHelper().desconectar();

            return errores;
        }

    }
}
