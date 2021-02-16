using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCelularesDesktop.Modelo
{
 public class Celular
        {
            public int CelularId { get; set; }
            public string empresa { get; set; }
            public bool chip { get; set; }
            public bool tarjetaSd { get; set; }
            public string diagnostico { get; set; }
            public int pin { get; set; }
            public int patron { get; set; }
            public virtual MarcaCelular MarcaCelular { get; set; }
        }
    }


