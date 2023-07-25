namespace AccesoDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregoCupones : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cupons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.Int(nullable: false),
                        Nombre = c.String(),
                        CantidadRestante = c.Int(nullable: false),
                        Codigo = c.String(),
                        PrimerValor = c.Int(),
                        SegundoValor = c.Int(),
                        Porcentaje = c.Int(),
                        ValorFijo = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cupons");
        }
    }
}
