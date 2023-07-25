namespace AccesoDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregoEventoTicketFuncionConID : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Eventoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Categoria = c.Int(nullable: false),
                        Formato = c.Int(nullable: false),
                        Descripcion = c.String(),
                        Direccion = c.String(),
                        Imagen = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Funcions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        MostrarDisponibles = c.Boolean(nullable: false),
                        Evento_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Eventoes", t => t.Evento_Id)
                .Index(t => t.Evento_Id);
            
            CreateTable(
                "dbo.ParTicketCantidads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Ticket_Id = c.Int(),
                        Funcion_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tickets", t => t.Ticket_Id)
                .ForeignKey("dbo.Funcions", t => t.Funcion_Id)
                .Index(t => t.Ticket_Id)
                .Index(t => t.Funcion_Id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Precio = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Evento_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Eventoes", t => t.Evento_Id)
                .Index(t => t.Evento_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "Evento_Id", "dbo.Eventoes");
            DropForeignKey("dbo.Funcions", "Evento_Id", "dbo.Eventoes");
            DropForeignKey("dbo.ParTicketCantidads", "Funcion_Id", "dbo.Funcions");
            DropForeignKey("dbo.ParTicketCantidads", "Ticket_Id", "dbo.Tickets");
            DropIndex("dbo.Tickets", new[] { "Evento_Id" });
            DropIndex("dbo.ParTicketCantidads", new[] { "Funcion_Id" });
            DropIndex("dbo.ParTicketCantidads", new[] { "Ticket_Id" });
            DropIndex("dbo.Funcions", new[] { "Evento_Id" });
            DropTable("dbo.Tickets");
            DropTable("dbo.ParTicketCantidads");
            DropTable("dbo.Funcions");
            DropTable("dbo.Eventoes");
        }
    }
}
