﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.Entities
{
    public class StockInDetail : Base
    {
        
        [Column(TypeName = "decimal(18,3)")]
        public decimal StockInDetailUnit { get; set; }



        public int WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; }

        public int StockInId { get; set; }
        public virtual StockIn StockIn { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
