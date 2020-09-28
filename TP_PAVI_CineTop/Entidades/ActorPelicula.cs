using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAVI_CineTop.Entidades
{
    class ActorPelicula
    {
        int id;
        int id_pelicula;
        string nombre;
        string apellido;

        public ActorPelicula(int id_pelicula, int id, string nombre, string apellido)
        {
            this.id = id;
            this.id_pelicula = id_pelicula;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Id_pelicula { get => id_pelicula; set => id_pelicula = value; }
    }
}
