using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI_CineTop.Entidades;
using TP_PAVI_CineTop.CapaDatos;

namespace TP_PAVI_CineTop.CapaNegocio
{
    class ServPais
    {
        PaisDAO dao = new PaisDAO();

        public IList<Pais> obtenerPaises()
        {
            return dao.obtenerPaises();
        }
    }
}
