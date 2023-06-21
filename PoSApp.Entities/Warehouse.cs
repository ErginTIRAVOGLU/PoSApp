using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.Entities
{
    public class Warehouse : Base
    {
        public Warehouse()
        {
            StockInDetails = new HashSet<StockInDetail>();
        }

        public string WarehouseName { get; set; }

        public virtual ICollection<StockInDetail> StockInDetails { get; set; }
    }
}
