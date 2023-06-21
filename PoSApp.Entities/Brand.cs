using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.Entities
{
    public class Brand :Base
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        [Required]
        [StringLength(50,ErrorMessage ="Marka ismi 50 karakterden fazla olamaz",MinimumLength = 2)]
        public string BrandName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
