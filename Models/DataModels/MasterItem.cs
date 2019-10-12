using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DataModels
{
    public class MasterItem:ModelBase
    {
        [Key]
        public int MasterItemId { get; set; }
        //Will classify here the maxlength later on
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }
        public double? UnitPrice { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

    }
}
