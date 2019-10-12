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
            SeedDepartment(context);
            SeedInitMasterItem(context);
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
            context.Appusers.AddOrUpdate(a => a.Appusername,
              new AppUser
              {
                  Appusername = "admin2",
                  FirstName = "Admin",
                  LastName = "Admin",
                  MiddleName = "Admin",
                  Password = "qwer1234",
              });
            context.SaveChanges();
        }
        private static void SeedDepartment(DbContexts context)
        {
            context.Departments.AddOrUpdate(a => a.DepartmentDescription,
                new Department
                {
                    CreatedByAppUserId = 1,
                    CreatedOn = DateTime.Now,
                    IsActive = true,
                    DepartmentDescription = "Chicken",
                    DepartmentCode = "CK",
                });
             context.Departments.AddOrUpdate(a => a.DepartmentDescription,
                new Department
                {
                    CreatedByAppUserId = 1,
                    CreatedOn = DateTime.Now,
                    IsActive = true,
                    DepartmentDescription = "Pork",
                    DepartmentCode = "PK",
                });
            context.SaveChanges();
        }
        private static void SeedInitMasterItem(DbContexts context)
        {
            //Initial Items and department
            var departmentId = context.Departments.Where(x => x.DepartmentDescription == "Chicken").Select(a => a.DepartmentId).FirstOrDefault();
            context.MasterItems.AddOrUpdate(a => a.LongDescription,
                new MasterItem
                {
                    CreatedByAppUserId = 1,
                    CreatedOn = DateTime.Now,
                    IsActive = true,
                    LongDescription="Fried Chicken (1pc)",
                    ShortDescription= "Frd Chckn (1pc)",
                    UnitPrice=79,
                    DepartmentId=departmentId
                });
            context.SaveChanges();
        }
    }
}
