using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaCelularesDesktop.Modelo;
using TiendaCelularesDesktop.DAL.Interfaces;

namespace TiendaCelularesDesktop.DAL.Repositorios
{
    public class RepositorioMarcaPc : RepositorioGenerico<MarcaPc, DbCelulares>, IRepositorioMarcaPc
    {

        public RepositorioMarcaPc(DbCelulares pContext) : base(pContext)
        {

        }
    }
}
