namespace AccesoDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregoAsistenteCuponEvento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AsistenteCuponEventoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CedulaAsistente = c.String(),
                        NombreEvento = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AsistenteCuponEventoes");
        }
    }
}
