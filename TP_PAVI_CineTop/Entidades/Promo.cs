using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAVI_CineTop.Entidades
{
    class Promo
    {
        int id;
        int id_epoca;
        float precio_menores;
        float precio_mayores;
        DateTime vigencia_desde;
        DateTime vigencia_hasta;

        public Promo(int id, int id_epoca, float precio_menores, float precio_mayores, DateTime vigencia_desde, DateTime vigencia_hasta)
        {
            this.id = id;
            this.id_epoca = id_epoca;
            this.precio_menores = precio_menores;
            this.precio_mayores = precio_mayores;
            this.vigencia_desde = vigencia_desde;
            this.vigencia_hasta = vigencia_hasta;
        }

        public int Id { get => id; set => id = value; }
        public int Id_epoca { get => id_epoca; set => id_epoca = value; }
        public float Precio_menores { get => precio_menores; set => precio_menores = value; }
        public float Precio_mayores { get => precio_mayores; set => precio_mayores = value; }
        public DateTime Vigencia_desde { get => vigencia_desde; set => vigencia_desde = value; }
        public DateTime Vigencia_hasta { get => vigencia_hasta; set => vigencia_hasta = value; }
    }
}
