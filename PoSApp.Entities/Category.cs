using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.Entities
{
    public class Category :Base
    {

        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Required]
        [StringLength(50,ErrorMessage ="Kategori ismi 50 karakterden fazla olamaz",MinimumLength = 2)]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
