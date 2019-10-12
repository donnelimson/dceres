using DBO2.Migrations;
using Models.DataModels;
using Models.DTO.Department;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{

    public class DepartmentServices
    {
        DbContexts db = new DbContexts();
        public List<DepartmentDTO> GetAllDepartment()
        {
            var data = db.Departments.Where(x => x.IsActive);
            var dataDTO = data.Select(a => new DepartmentDTO
            {
                DepartmentId = a.DepartmentId,
                DepartmentDescription = a.DepartmentDescription
            }).ToList();
            return dataDTO;
        }


    }
}
