using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAVI_CineTop.Entidades
{
    class CategoriaPremio
    {
        int id_premio;
        int id_categoria;
        string categoria;

        public CategoriaPremio(int id_premio, int id_categoria, string categoria)
        {
            this.id_premio = id_premio;
            this.id_categoria = id_categoria;
            this.categoria = categoria;
        }

        public int Id_premio { get => id_premio; set => id_premio = value; }
        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }
}
