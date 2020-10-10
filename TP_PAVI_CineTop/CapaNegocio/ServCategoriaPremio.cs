﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI_CineTop.CapaDatos;
using TP_PAVI_CineTop.Entidades;

namespace TP_PAVI_CineTop.CapaNegocio
{
    class ServCategoriaPremio
    {
        CategoriaPremioDAO dao = new CategoriaPremioDAO();
        public IList<CategoriaPremio> obtenerCategoriasPorPremio(int idPremio) => dao.obtenerCategoriasPorPremio(idPremio);
    }
}
