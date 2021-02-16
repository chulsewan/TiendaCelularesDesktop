using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCelularesDesktop.Modelo
{
    public class ModeloPc
    {
        public int ModeloPcId { get; set; }
        public string nombre { get; set; }
        public virtual MarcaPc MarcaPc { get; set; }
    }
}

