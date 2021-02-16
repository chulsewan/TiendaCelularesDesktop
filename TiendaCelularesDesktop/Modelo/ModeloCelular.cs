using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCelularesDesktop.Modelo
{
    public class ModeloCelular
    {
        public int ModeloCelularId { get; set; }
        public string nombre { get; set; }
        public virtual MarcaCelular MarcaCelular { get; set; }
    }
}


