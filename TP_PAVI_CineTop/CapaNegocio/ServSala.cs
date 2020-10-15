using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI_CineTop.CapaDatos;
using System.Data;
using TP_PAVI_CineTop.Entidades;

namespace TP_PAVI_CineTop.CapaNegocio
{
    class ServSala
    {
        SalasDAO salasDAO;

        public ServSala()
        {
            this.salasDAO = new SalasDAO();
        }

        public DataTable obtenerTablaSalas()
        {
            return salasDAO.obtenerTablaSalas();
        }

        public Sala obtenerSala(string nombre)
        {
            return salasDAO.obtenerSala(nombre);
        }

        public int actualizarSala(Sala sala)
        {
            return salasDAO.actualizarSala(sala);
        }

        public int agregarSala(Sala sala)
        {
            return salasDAO.insertarSala(sala);
        }

        public int borrarSala(string nombre)
        {
            return salasDAO.borrarSala(nombre);
        }

        public bool existeSala(string nombre)
        {
            return salasDAO.obtenerSala(nombre).Nombre != "";
        }
        public DataTable obtenerEstadisticaSalas() => salasDAO.obtenerEstadisticaSalas();

        public DataTable obtenerTablaSalasFiltrada(int minCapacidad, int maxCapacidad, int id_ubicacion) => salasDAO.obtenerTablaSalasFiltrada(minCapacidad, maxCapacidad, id_ubicacion);
        public DataTable obtenerTablaSalasFiltrada(int minCapacidad, int maxCapacidad, int id_ubicacion, bool tiene3d) => salasDAO.obtenerTablaSalasFiltrada(minCapacidad, maxCapacidad, id_ubicacion, tiene3d);

        internal object obtenerEstadisticaSalasFiltrada(int capMin, int capMax)
        {
            return salasDAO.obtenerEstadisticaSalasFiltrada(capMin, capMax);
        }
    }
}
