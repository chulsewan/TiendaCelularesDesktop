using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCelularesDesktop.Modelo
{
    public class Pc
    {
        public int PcId { get; set; }
        public string diagnostico { get; set; }
        public virtual MarcaPc MarcaPc { get; set; }
    }
}
