using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaCelularesDesktop.Modelo;
using TiendaCelularesDesktop.DAL.Interfaces;

namespace TiendaCelularesDesktop.DAL.Repositorios
{
    public class RepositorioModeloPc : RepositorioGenerico<ModeloPc, DbCelulares>, IRepositorioModeloPc
    {

        public RepositorioModeloPc(DbCelulares pContext) : base(pContext)
        {

        }
    }
}
