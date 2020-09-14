using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI_CineTop.CapaDatos;
using TP_PAVI_CineTop.Entidades;

namespace TP_PAVI_CineTop.CapaNegocio
{

    class ServUbicacion
    {
        UbicacionDAO ubicacionDAO;

        public ServUbicacion()
        {
            this.ubicacionDAO = new UbicacionDAO();
        }

        public IList<Ubicacion> obtenerUbicaciones()
        {
            return ubicacionDAO.obtenerTodasUbicaciones();
        }
    }
}
