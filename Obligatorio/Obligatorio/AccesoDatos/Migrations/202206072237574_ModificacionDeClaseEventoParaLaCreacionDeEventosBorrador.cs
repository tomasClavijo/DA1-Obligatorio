namespace AccesoDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificacionDeClaseEventoParaLaCreacionDeEventosBorrador : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Eventoes", "EsBorrador", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Eventoes", "EsBorrador");
        }
    }
}
