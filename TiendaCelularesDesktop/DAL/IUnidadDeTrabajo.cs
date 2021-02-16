using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaCelularesDesktop.DAL.Interfaces;
using TiendaCelularesDesktop.DAL.Repositorios;

namespace TiendaCelularesDesktop.DAL
{
    public interface IUnidadDeTrabajo : IDisposable
    {
            IRepositorioCelular RepositorioCelular { get; }
            IRepositorioCliente RepositorioCliente { get; }
            IRepositorioEstadoDeReparacion RepositorioEstadoDeReparacion { get; }
            IRepositorioMarcaCelular RepositorioMarcaCelular { get; }
            IRepositorioMarcaPc RepositorioMarcaPc { get; }
            IRepositorioModeloCelular RepositorioModeloCelular { get; }
            IRepositorioModeloPc RepositorioModeloPc { get; }
            IRepositorioOrdenDeReparacion RepositorioOrdenDeReparacion { get; }
            IRepositorioPc RepositorioPc { get; }
            IRepositorioTipoEquipo RepositorioTipoEquipo { get; }


        /// <summary>
        /// Guardar en memoria (savechanges)
        /// </summary>
        void Guardar();
    }
}
