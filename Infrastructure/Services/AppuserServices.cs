using DBO2.Migrations;
using Models.DTO.AppUser;
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
        public AppUserDTO CheckUsernameAndPassword(string userName, string passWord)
        {
            return db.Appusers.Where(x => x.Appusername == userName && x.Password == passWord).Select(a => new AppUserDTO
            {
                AppUserId = a.AppUserId,
                FullName = a.LastName + ", " + a.FirstName + " " + a.MiddleName
            }).FirstOrDefault();
        }
    }
}
