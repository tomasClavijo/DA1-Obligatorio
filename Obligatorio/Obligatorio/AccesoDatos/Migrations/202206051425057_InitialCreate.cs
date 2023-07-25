namespace AccesoDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asistentes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cedula = c.String(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Productors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Productors");
            DropTable("dbo.Asistentes");
        }
    }
}
