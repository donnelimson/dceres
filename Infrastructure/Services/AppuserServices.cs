using DBO2.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    
    public class AppuserServices
    {
        DbContexts db = new DbContexts();  
        public bool CheckUsernameAndPassword(string userName, string passWord)
        {
            return db.Appusers.Any(x => x.Appusername == userName && x.Password == passWord);
        }


    }
}
