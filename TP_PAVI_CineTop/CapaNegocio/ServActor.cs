using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI_CineTop.CapaDatos;
using TP_PAVI_CineTop.Entidades;

namespace TP_PAVI_CineTop.CapaNegocio
{
    class ServActor
    {
        ActorPeliculaDAO dao = new ActorPeliculaDAO();

        public IList<ActorPelicula> obtenerActores() => dao.obtenerActores();
        public IList<ActorPelicula> obtenerActoresPorNombre(string nombre) => dao.obtenerActoresPorNombre(nombre);
        public IList<ActorPelicula> obtenerNombresActoresDistintos() => dao.obtenerNombresActoresDistintos();
    }
}
