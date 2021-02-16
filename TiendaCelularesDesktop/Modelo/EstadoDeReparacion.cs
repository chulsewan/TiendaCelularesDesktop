using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCelularesDesktop.Modelo
{
    public class EstadoDeReparacion
    {
        public int EstadoDeReparacionId { get; set; }
        public string estado { get; set; }
        public virtual IList<OrdenDeReparacion> ListaOrdenDeReparacion { get; set; }
    }
}

