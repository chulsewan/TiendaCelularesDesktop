using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaCelularesDesktop.Modelo;
using TiendaCelularesDesktop.DAL.Interfaces;

namespace TiendaCelularesDesktop.DAL.Repositorios
{
    public class RepositorioCelular : RepositorioGenerico<Celular, DbCelulares>, IRepositorioCelular
    {

        public RepositorioCelular(DbCelulares pContext) : base(pContext)
        {

        }
    }
}



