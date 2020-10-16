using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAVI_CineTop.CapaDatos;
using TP_PAVI_CineTop.Entidades;
using System.Data;

namespace TP_PAVI_CineTop.CapaNegocio
{
    class ServPelicula
    {
        PeliculaDAO dao = new PeliculaDAO();
        public Pelicula obtenerPelicula(int id)
        {
            return dao.obtenerPelicula(id);
        }

        public string insertarPelicula(Pelicula peli, bool UsaDBHelper)
        {
            if(UsaDBHelper)
                return dao.insertarPelicula(peli);
            else
            {
                dao.insertarPeliculaDataManager(peli);
                return "Transaccion realizada con exito";
            }
        }

        public string actualizarPelicula(Pelicula peli)
        {
            return dao.actualizarPelicula(peli);
        }

        public string borrarPelicula(int id) => dao.borrarPelicula(id);
        public AutoCompleteStringCollection obtenerNombresPeliculasVigentes() => dao.obtenerNombresPeliculasVigentes();
        public Pelicula obtenerPeliculaPorTitulo(string titulo) => dao.obtenerPeliculaPorTitulo(titulo);

        public DataTable obtenerTablaPeliculaExtendida() => dao.obtenerTablaPeliculaExtendida(); //nuevo

        public DataTable obtenerTablaPeliculaExtendidaFiltrada(DateTime fechaDesde, DateTime fechaHasta, int id_director, int id_pais) //nuevo
        {
            string fechaDesdeStr = fechaDesde.ToString("yyyy-MM-dd");
            string fechaHastaStr = fechaHasta.ToString("yyyy-MM-dd");
            return dao.obtenerTablaPeliculaExtendidaFiltrada(fechaDesdeStr, fechaHastaStr, id_director, id_pais);
        }

        public DataTable obtenerEstadisticaPeliculasPorGenero(DateTime estrenoDesde, DateTime estrenoHasta, IList<int> directores, IList<int> generos, int duracionMax)
        {
            string estrenoDesdeStr = estrenoDesde.ToString("yyyy-MM-dd");
            string estrenoHastaStr = estrenoHasta.ToString("yyyy-MM-dd");
            return dao.obtenerEstadisticaPeliculasPorGenero(estrenoDesdeStr, estrenoHastaStr, directores, generos, duracionMax);
        }

        public DataTable obtenerEstadisticaPeliculasPorGeneroYDirector(DateTime estrenoDesde, DateTime estrenoHasta, IList<int> directores, IList<int> generos, int duracionMax)
        {
            string estrenoDesdeStr = estrenoDesde.ToString("yyyy-MM-dd");
            string estrenoHastaStr = estrenoHasta.ToString("yyyy-MM-dd");
            return dao.obtenerEstadisticaPeliculasPorGeneroYDirector(estrenoDesdeStr, estrenoHastaStr, directores, generos, duracionMax);
        }
    }
}
