using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCelularesDesktop.Modelo
{
    public class OrdenDeReparacion
    {
        public int OrdenDeReparacionId { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaEgreso { get; set; }
        public string detalle { get; set; }
        public double precio { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual EstadoDeReparacion EstadoDeReparacion { get; set; }
        public virtual TipoEquipo TipoEquipo { get; set; }
    }
}
