using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAVI_CineTop.Entidades;
using TP_PAVI_CineTop.CapaDatos;

namespace TP_PAVI_CineTop.CapaNegocio
{
    class ServPromo
    {
        PromoDAO dao = new PromoDAO();
        
        public DataTable obtenerTabla()
        {
            return dao.obtenerTabla();
        }

        public Promo obtenerPromoID(int id)
        {
            return dao.obtenerPromoID(id);
        }

        public string insertar_promo(Promo promo)
        {
            return dao.insertar_promo(promo);
        }

        public string actualizar_promo(Promo promo)
        {
            return dao.actualizar_promo(promo);
        }

        public string borrar_promo(int id)
        {
            return dao.borrar_promo(id);
        }

        public bool existe_promo(int id)
        {
            return dao.obtenerPromoID(id) != null;
        }

        public DataTable obtenerTablaPromosFiltrada(DateTime fechaDesde, DateTime fechaHasta)
        {
            return dao.obtenerTablaPromosFiltrada(fechaDesde, fechaHasta);
        }

    }
}
