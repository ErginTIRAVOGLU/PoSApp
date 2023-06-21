using PoSApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.Entities
{
    public class CartDetail : Base
    {
        
        

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,3)")]
        public decimal ProductUnit { get; set; }

        public ProductUnitType ProductUnitType { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PriceTotal { get; set; }

        public string Description { get; set; }

        public int Vat { get; set; }

        public decimal ProductDiscount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DiscountTotal { get; set; }

        public int CartId { get; set; }
        public virtual Cart Cart { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }


    }
}
