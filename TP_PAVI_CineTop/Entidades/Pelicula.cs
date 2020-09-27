using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAVI_CineTop.Entidades
{
    class Pelicula
    {
        int id;
        string titulo;
        int id_genero;
        string director;
        int duracion;
        DateTime fechaEstreno;
        DateTime fechaFinProyeccion;
        string argumento;
        int id_pais;
        bool borrado;
        IList<ActorPelicula> actores;

        public Pelicula(int id, string titulo, int id_genero, string director, int duracion,
            DateTime fechaEstreno, DateTime fechaFinProyeccion, string argumento, int id_pais, bool borrado)
        {
            this.id = id;
            this.titulo = titulo;
            this.id_genero = id_genero;
            this.director = director;
            this.duracion = duracion;
            this.fechaEstreno = fechaEstreno;
            this.fechaFinProyeccion = fechaFinProyeccion;
            this.argumento = argumento;
            this.id_pais = id_pais;
            this.borrado = borrado;
        }

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int Id_genero { get => id_genero; set => id_genero = value; }
        public string Director { get => director; set => director = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public DateTime FechaEstreno { get => fechaEstreno; set => fechaEstreno = value; }
        public DateTime FechaFinProyeccion { get => fechaFinProyeccion; set => fechaFinProyeccion = value; }
        public int Id_pais { get => id_pais; set => id_pais = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
        public string Argumento { get => argumento; set => argumento = value; }
        internal IList<ActorPelicula> Actores { get => actores; set => actores = value; }

        public void agregarActor(ActorPelicula actor)
        {
            actores.Add(actor);
        }

        public void quitarActor(int index)
        {
            actores.RemoveAt(index);
        }
    }
}
