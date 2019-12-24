using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO.MasterItem
{
    public class MasterItemDTO
    {
        public int MasterItemId { get; set; }
        public string LongDescription { get; set; }
        public double? UnitPrice { get; set; }
        public string ShortDescription { get; set; }
    }
    
}
