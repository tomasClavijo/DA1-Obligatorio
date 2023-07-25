namespace AccesoDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregoComprasAlContexto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Compras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Monto = c.Int(nullable: false),
                        Asistente_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Asistentes", t => t.Asistente_Id, cascadeDelete: true)
                .Index(t => t.Asistente_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Compras", "Asistente_Id", "dbo.Asistentes");
            DropIndex("dbo.Compras", new[] { "Asistente_Id" });
            DropTable("dbo.Compras");
        }
    }
}
