namespace AccesoDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregoComprasConClavesForaneas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Codigoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodigoCompra = c.String(),
                        Compra_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Compras", t => t.Compra_Id, cascadeDelete: true)
                .Index(t => t.Compra_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Codigoes", "Compra_Id", "dbo.Compras");
            DropIndex("dbo.Codigoes", new[] { "Compra_Id" });
            DropTable("dbo.Codigoes");
        }
    }
}
