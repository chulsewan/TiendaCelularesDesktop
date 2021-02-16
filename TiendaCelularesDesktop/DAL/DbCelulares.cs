using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaCelularesDesktop.Modelo;

namespace TiendaCelularesDesktop.DAL
{ 
    public class DbCelulares : DbContext
    {
        public DbCelulares() : base("TiendaCelulares")
        {

        }
        public DbSet<Celular> Celulars { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<EstadoDeReparacion> EstadoDeReparacions { get; set; }
        public DbSet<MarcaCelular> MarcaCelulars { get; set; }
        public DbSet<MarcaPc> MarcaPcs { get; set; }
        public DbSet<ModeloCelular> ModeloCelulars { get; set; }
        public DbSet<ModeloPc> ModeloPcs { get; set; }
        public DbSet<OrdenDeReparacion> OrdenDeReparacions { get; set; }
        public DbSet<Pc> Pcs { get; set; }
        public DbSet<TipoEquipo> TipoEquipos { get; set; }

    }
}

