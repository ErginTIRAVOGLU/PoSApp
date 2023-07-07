using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoSApp.Entities.Enums;

namespace PoSApp.Entities
{
    public class Product:Base
    {
        public Product()
        {
            StockInDetails = new HashSet<StockInDetail>();
        }

        [Required]
        [StringLength(150, ErrorMessage = "Ürün ismi 150 karakterden fazla olamaz", MinimumLength = 2)]
        public string ProductName { get; set; }

        public string ProductCode { get; set; }
        
        public string ProductBarcode { get; set; }


        public string ProductDescription { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal ProductPrice { get; set; }

        public int ProductVat { get; set; } = 18;

        //[Column(TypeName = "decimal(18,4)")]
        //public decimal ProductUnit { get; set; }

        public ProductUnitType ProductUnitType { get; set; }

        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<StockInDetail> StockInDetails { get; set; }


    }
}
