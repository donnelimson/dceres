using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DataModels
{
    public class Department:ModelBase
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentDescription { get; set; }
        public string DepartmentCode { get; set; }

    }
}
