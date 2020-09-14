using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAVI_CineTop.Entidades
{
    class Sala
    {
        string nombre;
        bool tiene3D;
        int id_ubicacion;
        int capacidad;

        public Sala(string nombre, int capacidad, int id_ubicacion, bool tiene3D)
        {
            this.nombre = nombre;
            this.tiene3D = tiene3D;
            this.id_ubicacion = id_ubicacion;
            this.capacidad = capacidad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public bool Tiene3D { get => tiene3D; set => tiene3D = value; }
        public int Id_ubicacion { get => id_ubicacion; set => id_ubicacion = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
    }
}
