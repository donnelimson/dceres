using Contexts.Migrations;
using Models.DTO.MasterItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MasterItemServices
    {
        DbContexts db = new DbContexts();
        public List<MasterItemDTO> GetAllMasterItemPerDepartment(int departmentId)
        {
            return db.MasterItems.Where(x => x.DepartmentId == departmentId).Select(a => new MasterItemDTO
            {
                MasterItemId = a.MasterItemId,
                LongDescription = a.LongDescription,
                ShortDescription = a.ShortDescription,
                UnitPrice = a.UnitPrice
            }).ToList();
        }
    }
}
