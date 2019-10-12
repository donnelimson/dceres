using Models.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBO2.Migrations
{
    public class DbContexts : DbContext
    {
        public DbContexts() : base("DCERES")
        {
        }
        //Dbsets
        public DbSet<AppUser> Appusers { get; set; }
        public DbSet<MasterItem> MasterItems { get; set; }
        public DbSet<Department> Departments { get; set; }
    }

}
