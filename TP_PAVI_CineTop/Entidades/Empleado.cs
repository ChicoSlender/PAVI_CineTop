using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAVI_CineTop.Entidades
{
    class Empleado
    {
        int legajo;
        int idTipoDoc;
        int nroDoc;
        string nombre;
        string apellido;
        DateTime fechaIngreso;
        string nombreUsuario;
        bool borrado;

        public Empleado(int legajo, int idTipoDoc, int nroDoc, string nombre, string apellido, DateTime fechaIngreso, string nombreUsuario)
        {
            this.legajo = legajo;
            this.idTipoDoc = idTipoDoc;
            this.nroDoc = nroDoc;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaIngreso = fechaIngreso;
            this.nombreUsuario = nombreUsuario;
        }

        public int Legajo { get => legajo; set => legajo = value; }
        public int IdTipoDoc { get => idTipoDoc; set => idTipoDoc = value; }
        public int NroDoc { get => nroDoc; set => nroDoc = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
    }
}
