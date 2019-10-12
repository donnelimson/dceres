using Models.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ModelBase
    {
        [ForeignKey("CreatedByAppUser")]
        public int CreatedByAppUserId { get; set; }
        public virtual AppUser CreatedByAppUser { get; set; }
        public bool IsActive { get; set; } 
        public DateTime CreatedOn { get; set; }
        [ForeignKey("ModifiedByAppUser")]
        public int? UpdatedByAppUserId { get; set; }
        public virtual AppUser ModifiedByAppUser { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
