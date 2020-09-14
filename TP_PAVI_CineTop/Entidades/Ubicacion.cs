using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAVI_CineTop.Entidades
{
    class Ubicacion
    {
        int id;
        string nombre;
        string descipcion;

        public Ubicacion(int id, string nombre, string descipcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.descipcion = descipcion;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descipcion { get => descipcion; set => descipcion = value; }
    }
}
