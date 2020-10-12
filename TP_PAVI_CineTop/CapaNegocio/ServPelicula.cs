using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAVI_CineTop.CapaDatos;
using TP_PAVI_CineTop.Entidades;

namespace TP_PAVI_CineTop.CapaNegocio
{
    class ServPelicula
    {
        PeliculaDAO dao = new PeliculaDAO();
        public Pelicula obtenerPelicula(int id)
        {
            return dao.obtenerPelicula(id);
        }

        public string insertarPelicula(Pelicula peli)
        {
            return dao.insertarPelicula(peli);
        }

        public string actualizarPelicula(Pelicula peli)
        {
            return dao.actualizarPelicula(peli);
        }

        public string borrarPelicula(int id) => dao.borrarPelicula(id);
        public AutoCompleteStringCollection obtenerNombresPeliculasVigentes() => dao.obtenerNombresPeliculasVigentes();
        public Pelicula obtenerPeliculaPorTitulo(string titulo) => dao.obtenerPeliculaPorTitulo(titulo);
    }
}
