namespace AccesoDatos.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AccesoDatos.ContextoEvento>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AccesoDatos.ContextoEvento";
        }

        protected override void Seed(AccesoDatos.ContextoEvento context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
