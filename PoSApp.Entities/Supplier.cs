using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.Entities
{
    public class Supplier : Base
    {

        public Supplier()
        {
            StockIns = new HashSet<StockIn>();
        }

        [Required]
        [StringLength(50,ErrorMessage ="Tedarikçi ismi 50 karakterden fazla olamaz",MinimumLength = 2)]
        public string SupplierName { get; set; }

        [StringLength(350, MinimumLength = 2)]
        public string SupplierAddress1 { get; set; }

        [StringLength(350, MinimumLength = 2)]
        public string SupplierAddress2 { get; set; }

        [StringLength(30, MinimumLength = 2)]
        public string SupplierPhone1 { get; set; }
        
        [StringLength(30, MinimumLength = 2)]
        public string SupplierPhone2 { get; set; }

        [StringLength(30, MinimumLength = 2)]
        public string SupplierManager { get; set; }

        [StringLength(30, MinimumLength = 2)]
        public string SupplierTaxAdministrator { get; set; }

        [StringLength(30, MinimumLength = 2)]
        public string SupplierTaxNumber { get; set; }

        [StringLength(500, MinimumLength = 2)]
        public string SupplierNote { get; set; }

        public virtual ICollection<StockIn> StockIns { get; set; }
    }
}
