namespace AccesoDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregoClavesYCascadeOnDelete : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Funcions", "Evento_Id", "dbo.Eventoes");
            DropForeignKey("dbo.Tickets", "Evento_Id", "dbo.Eventoes");
            DropForeignKey("dbo.ParTicketCantidads", "Funcion_Id", "dbo.Funcions");
            DropIndex("dbo.Funcions", new[] { "Evento_Id" });
            DropIndex("dbo.ParTicketCantidads", new[] { "Funcion_Id" });
            DropIndex("dbo.Tickets", new[] { "Evento_Id" });
            AlterColumn("dbo.Funcions", "Evento_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.ParTicketCantidads", "Funcion_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Tickets", "Evento_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Funcions", "Evento_Id");
            CreateIndex("dbo.ParTicketCantidads", "Funcion_Id");
            CreateIndex("dbo.Tickets", "Evento_Id");
            AddForeignKey("dbo.Funcions", "Evento_Id", "dbo.Eventoes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Tickets", "Evento_Id", "dbo.Eventoes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ParTicketCantidads", "Funcion_Id", "dbo.Funcions", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParTicketCantidads", "Funcion_Id", "dbo.Funcions");
            DropForeignKey("dbo.Tickets", "Evento_Id", "dbo.Eventoes");
            DropForeignKey("dbo.Funcions", "Evento_Id", "dbo.Eventoes");
            DropIndex("dbo.Tickets", new[] { "Evento_Id" });
            DropIndex("dbo.ParTicketCantidads", new[] { "Funcion_Id" });
            DropIndex("dbo.Funcions", new[] { "Evento_Id" });
            AlterColumn("dbo.Tickets", "Evento_Id", c => c.Int());
            AlterColumn("dbo.ParTicketCantidads", "Funcion_Id", c => c.Int());
            AlterColumn("dbo.Funcions", "Evento_Id", c => c.Int());
            CreateIndex("dbo.Tickets", "Evento_Id");
            CreateIndex("dbo.ParTicketCantidads", "Funcion_Id");
            CreateIndex("dbo.Funcions", "Evento_Id");
            AddForeignKey("dbo.ParTicketCantidads", "Funcion_Id", "dbo.Funcions", "Id");
            AddForeignKey("dbo.Tickets", "Evento_Id", "dbo.Eventoes", "Id");
            AddForeignKey("dbo.Funcions", "Evento_Id", "dbo.Eventoes", "Id");
        }
    }
}
