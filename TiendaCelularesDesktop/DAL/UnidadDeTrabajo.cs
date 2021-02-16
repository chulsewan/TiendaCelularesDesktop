using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaCelularesDesktop.DAL.Interfaces;
using TiendaCelularesDesktop.DAL.Repositorios;

namespace TiendaCelularesDesktop.DAL
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        //atributo para utilizar un solo Contexto
        private readonly DbCelulares iDbContext;
        private static volatile UnidadDeTrabajo cInstancia = null;
        private static readonly object cPadlock = new object();

        private UnidadDeTrabajo()
        {
            this.iDbContext = new DbCelulares();
            this.RepositorioCelular = new RepositorioCelular(this.iDbContext);
            this.RepositorioCliente = new RepositorioCliente(this.iDbContext);
            this.RepositorioEstadoDeReparacion = new RepositorioEstadoDeReparacion(this.iDbContext);
            this.RepositorioMarcaCelular = new RepositorioMarcaCelular(this.iDbContext);
            this.RepositorioMarcaPc = new RepositorioMarcaPc(this.iDbContext);
            this.RepositorioModeloCelular = new RepositorioModeloCelular(this.iDbContext);
            this.RepositorioModeloPc = new RepositorioModeloPc(this.iDbContext);
            this.RepositorioOrdenDeReparacion = new RepositorioOrdenDeReparacion(this.iDbContext);
            this.RepositorioPc = new RepositorioPc(this.iDbContext);
            this.RepositorioTipoEquipo = new RepositorioTipoEquipo(this.iDbContext);

        }

        //Implementacion de las interfaces en la unidad de trabajo

        public IRepositorioCelular RepositorioCelular { get; private set; }
        public IRepositorioCliente RepositorioCliente { get; private set; }
        public IRepositorioEstadoDeReparacion RepositorioEstadoDeReparacion { get; private set; }
        public IRepositorioMarcaCelular RepositorioMarcaCelular { get; private set; }
        public IRepositorioMarcaPc RepositorioMarcaPc { get; private set; }
        public IRepositorioModeloCelular RepositorioModeloCelular { get; private set; }
        public IRepositorioModeloPc RepositorioModeloPc { get; private set; }
        public IRepositorioOrdenDeReparacion RepositorioOrdenDeReparacion { get; private set; }
        public IRepositorioPc RepositorioPc { get; private set; }
        public IRepositorioTipoEquipo RepositorioTipoEquipo { get; private set; }



        /// <summary>
        /// Patron singleton para usar el mismo contexto en todo el sistema
        /// </summary>
        public static UnidadDeTrabajo Instancia
        {
            get
            {
                if (cInstancia == null)
                {
                    lock (cPadlock)
                    {
                        if (cInstancia == null)
                        {
                            cInstancia = new UnidadDeTrabajo();
                        }
                    }
                }

                return cInstancia;
            }
        }
        /// <summary>
        ///Implementación de IDisposable: Define el método Dispose para liberar recursos no administrados.
        /// </summary>
        public void Dispose()
        {
            iDbContext.Dispose();
        }
        public void Guardar()
        {
            iDbContext.SaveChanges();
        }
    }
}

