﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCelularesDesktop.Modelo
{
    public class TipoEquipo
    {
        public int TipoEquipoId { get; set; }
        public string nombre { get; set; }
        public virtual IList<OrdenDeReparacion> ListaOrdenDeReparacion { get; set; }
        public virtual Celular Celular { get; set; }
        public virtual Pc Pc { get; set; }
    }
}
