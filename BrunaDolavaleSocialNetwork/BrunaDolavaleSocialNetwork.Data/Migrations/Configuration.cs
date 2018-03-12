namespace BrunaDolavaleSocialNetwork.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BrunaDolavaleSocialNetwork.Infrastructure.Data.Context.BrunaDolavaleSocialNetworkContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BrunaDolavaleSocialNetwork.Infrastructure.Data.Context.BrunaDolavaleSocialNetworkContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
