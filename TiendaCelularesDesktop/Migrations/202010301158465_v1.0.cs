namespace TiendaCelularesDesktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Celulars",
                c => new
                    {
                        CelularId = c.Int(nullable: false, identity: true),
                        empresa = c.String(),
                        chip = c.Boolean(nullable: false),
                        tarjetaSd = c.Boolean(nullable: false),
                        diagnostico = c.String(),
                        pin = c.Int(nullable: false),
                        patron = c.Int(nullable: false),
                        MarcaCelular_MarcaCelularId = c.Int(),
                    })
                .PrimaryKey(t => t.CelularId)
                .ForeignKey("dbo.MarcaCelulars", t => t.MarcaCelular_MarcaCelularId)
                .Index(t => t.MarcaCelular_MarcaCelularId);
            
            CreateTable(
                "dbo.MarcaCelulars",
                c => new
                    {
                        MarcaCelularId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.MarcaCelularId);
            
            CreateTable(
                "dbo.ModeloCelulars",
                c => new
                    {
                        ModeloCelularId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        MarcaCelular_MarcaCelularId = c.Int(),
                    })
                .PrimaryKey(t => t.ModeloCelularId)
                .ForeignKey("dbo.MarcaCelulars", t => t.MarcaCelular_MarcaCelularId)
                .Index(t => t.MarcaCelular_MarcaCelularId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellido = c.String(),
                        telefono = c.String(),
                        email = c.String(),
                        dni = c.String(),
                        direccion = c.String(),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.OrdenDeReparacions",
                c => new
                    {
                        OrdenDeReparacionId = c.Int(nullable: false, identity: true),
                        fechaIngreso = c.DateTime(nullable: false),
                        fechaEgreso = c.DateTime(nullable: false),
                        detalle = c.String(),
                        precio = c.Double(nullable: false),
                        Cliente_ClienteId = c.Int(),
                        EstadoDeReparacion_EstadoDeReparacionId = c.Int(),
                        TipoEquipo_TipoEquipoId = c.Int(),
                    })
                .PrimaryKey(t => t.OrdenDeReparacionId)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ClienteId)
                .ForeignKey("dbo.EstadoDeReparacions", t => t.EstadoDeReparacion_EstadoDeReparacionId)
                .ForeignKey("dbo.TipoEquipoes", t => t.TipoEquipo_TipoEquipoId)
                .Index(t => t.Cliente_ClienteId)
                .Index(t => t.EstadoDeReparacion_EstadoDeReparacionId)
                .Index(t => t.TipoEquipo_TipoEquipoId);
            
            CreateTable(
                "dbo.EstadoDeReparacions",
                c => new
                    {
                        EstadoDeReparacionId = c.Int(nullable: false, identity: true),
                        estado = c.String(),
                    })
                .PrimaryKey(t => t.EstadoDeReparacionId);
            
            CreateTable(
                "dbo.TipoEquipoes",
                c => new
                    {
                        TipoEquipoId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        Celular_CelularId = c.Int(),
                        Pc_PcId = c.Int(),
                    })
                .PrimaryKey(t => t.TipoEquipoId)
                .ForeignKey("dbo.Celulars", t => t.Celular_CelularId)
                .ForeignKey("dbo.Pcs", t => t.Pc_PcId)
                .Index(t => t.Celular_CelularId)
                .Index(t => t.Pc_PcId);
            
            CreateTable(
                "dbo.Pcs",
                c => new
                    {
                        PcId = c.Int(nullable: false, identity: true),
                        diagnostico = c.String(),
                        MarcaPc_MarcaPcId = c.Int(),
                    })
                .PrimaryKey(t => t.PcId)
                .ForeignKey("dbo.MarcaPcs", t => t.MarcaPc_MarcaPcId)
                .Index(t => t.MarcaPc_MarcaPcId);
            
            CreateTable(
                "dbo.MarcaPcs",
                c => new
                    {
                        MarcaPcId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.MarcaPcId);
            
            CreateTable(
                "dbo.ModeloPcs",
                c => new
                    {
                        ModeloPcId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        MarcaPc_MarcaPcId = c.Int(),
                    })
                .PrimaryKey(t => t.ModeloPcId)
                .ForeignKey("dbo.MarcaPcs", t => t.MarcaPc_MarcaPcId)
                .Index(t => t.MarcaPc_MarcaPcId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TipoEquipoes", "Pc_PcId", "dbo.Pcs");
            DropForeignKey("dbo.Pcs", "MarcaPc_MarcaPcId", "dbo.MarcaPcs");
            DropForeignKey("dbo.ModeloPcs", "MarcaPc_MarcaPcId", "dbo.MarcaPcs");
            DropForeignKey("dbo.OrdenDeReparacions", "TipoEquipo_TipoEquipoId", "dbo.TipoEquipoes");
            DropForeignKey("dbo.TipoEquipoes", "Celular_CelularId", "dbo.Celulars");
            DropForeignKey("dbo.OrdenDeReparacions", "EstadoDeReparacion_EstadoDeReparacionId", "dbo.EstadoDeReparacions");
            DropForeignKey("dbo.OrdenDeReparacions", "Cliente_ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.ModeloCelulars", "MarcaCelular_MarcaCelularId", "dbo.MarcaCelulars");
            DropForeignKey("dbo.Celulars", "MarcaCelular_MarcaCelularId", "dbo.MarcaCelulars");
            DropIndex("dbo.ModeloPcs", new[] { "MarcaPc_MarcaPcId" });
            DropIndex("dbo.Pcs", new[] { "MarcaPc_MarcaPcId" });
            DropIndex("dbo.TipoEquipoes", new[] { "Pc_PcId" });
            DropIndex("dbo.TipoEquipoes", new[] { "Celular_CelularId" });
            DropIndex("dbo.OrdenDeReparacions", new[] { "TipoEquipo_TipoEquipoId" });
            DropIndex("dbo.OrdenDeReparacions", new[] { "EstadoDeReparacion_EstadoDeReparacionId" });
            DropIndex("dbo.OrdenDeReparacions", new[] { "Cliente_ClienteId" });
            DropIndex("dbo.ModeloCelulars", new[] { "MarcaCelular_MarcaCelularId" });
            DropIndex("dbo.Celulars", new[] { "MarcaCelular_MarcaCelularId" });
            DropTable("dbo.ModeloPcs");
            DropTable("dbo.MarcaPcs");
            DropTable("dbo.Pcs");
            DropTable("dbo.TipoEquipoes");
            DropTable("dbo.EstadoDeReparacions");
            DropTable("dbo.OrdenDeReparacions");
            DropTable("dbo.Clientes");
            DropTable("dbo.ModeloCelulars");
            DropTable("dbo.MarcaCelulars");
            DropTable("dbo.Celulars");
        }
    }
}
