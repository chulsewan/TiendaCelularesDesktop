using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCelularesDesktop.Modelo
{
    public class MarcaPc
    {
        public int MarcaPcId { get; set; }
        public string nombre { get; set; }
        public virtual IList<Pc> ListaPc { get; set; }
        public virtual IList<ModeloPc> ListaModeloPc { get; set; }
    }
}

