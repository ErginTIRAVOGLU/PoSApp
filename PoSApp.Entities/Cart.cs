using PoSApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.Entities
{
    public class Cart : Base
    {

        public Cart()
        {
            CartDetails = new HashSet<CartDetail>();
            PayedAmounts = new HashSet<PayedAmount>();
        }

        public string TransNo { get; set; }         

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }        

        [Column(TypeName = "decimal(18,2)")]
        public decimal PriceTotal { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DiscountTotal { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Vat { get; set; }

        public virtual ICollection<CartDetail> CartDetails { get; set; }
        public virtual ICollection<PayedAmount> PayedAmounts { get; set; }

        public DateTime CartDate { get; set; }
        public CartStatus Status { get; set; }
    }
}
