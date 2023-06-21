using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.Entities
{
    public class StockIn : Base
    {
        public StockIn()
        {
            StockInDetails = new HashSet<StockInDetail>();
        }

        [Required]
        [StringLength(30,ErrorMessage ="Referans Numarası ismi 30 karakterden fazla olamaz",MinimumLength = 2)]
        public string StockInRefNo { get; set; }

        public DateTime StockInDate { get; set; }

        public int SupplierId { get; set; }
        public virtual  Supplier Supplier { get; set; }
        
        public virtual ICollection<StockInDetail> StockInDetails { get; set; }
    }
}
