using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCelularesDesktop.Modelo
{
    public class MarcaCelular
    {
        public int MarcaCelularId { get; set; }
        public string nombre { get; set; }
        public virtual IList<Celular> ListaCelular { get; set; }
        public virtual IList<ModeloCelular> ListaModeloCelular { get; set; }
    }
}

