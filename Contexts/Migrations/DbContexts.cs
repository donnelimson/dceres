using Models.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contexts.Migrations
{
    public class DbContexts : DbContext
    {
        public DbContexts() : base("DCERES"){
        }

        public DbSet<AppUser> Appusers { get; set; }
    }

}
