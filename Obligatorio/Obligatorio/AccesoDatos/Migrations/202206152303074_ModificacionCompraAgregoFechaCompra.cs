namespace AccesoDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificacionCompraAgregoFechaCompra : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Compras", "FechaEfectuada", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Compras", "FechaEfectuada");
        }
    }
}
