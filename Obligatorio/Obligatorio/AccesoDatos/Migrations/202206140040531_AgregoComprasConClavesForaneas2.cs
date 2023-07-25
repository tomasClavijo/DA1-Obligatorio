namespace AccesoDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregoComprasConClavesForaneas2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Compras", "Asistente_Id", "dbo.Asistentes");
            DropIndex("dbo.Compras", new[] { "Asistente_Id" });
            AlterColumn("dbo.Compras", "Asistente_Id", c => c.Int());
            CreateIndex("dbo.Compras", "Asistente_Id");
            AddForeignKey("dbo.Compras", "Asistente_Id", "dbo.Asistentes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Compras", "Asistente_Id", "dbo.Asistentes");
            DropIndex("dbo.Compras", new[] { "Asistente_Id" });
            AlterColumn("dbo.Compras", "Asistente_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Compras", "Asistente_Id");
            AddForeignKey("dbo.Compras", "Asistente_Id", "dbo.Asistentes", "Id", cascadeDelete: true);
        }
    }
}
