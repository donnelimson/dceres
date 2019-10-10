namespace Contexts.Migrations
{
    using Models.DataModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DbContexts>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Contexts.Migrations.DbInitial";
        }

        protected override void Seed(DbContexts context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            SeedUsers(context);
        }
        private static void SeedUsers(DbContexts context)
        {
            context.Appusers.AddOrUpdate(a => a.Appusername,
                new AppUser
                {
                    Appusername = "admin",
                    FirstName = "Admin",
                    LastName = "Admin",
                    MiddleName = "Admin",
                    Password = "asdf1234",
                });
            context.SaveChanges();
        }
    }
}
