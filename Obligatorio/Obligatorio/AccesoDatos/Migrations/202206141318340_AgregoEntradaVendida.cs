namespace AccesoDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregoEntradaVendida : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EntradaVendidas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Categoria = c.Int(nullable: false),
                        Monto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EntradaVendidas");
        }
    }
}
