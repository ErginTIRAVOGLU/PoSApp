using PoSApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.Entities
{
    public class PayedAmount : Base
    {
        public int CartId { get; set; }
        public virtual Cart Cart { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal PriceTotal { get; set; }

        public PaymentType PayedType { get; set; }

    }
}
