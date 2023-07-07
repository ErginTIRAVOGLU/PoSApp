using Microsoft.EntityFrameworkCore;
 
using PoSApp.BLL.Repositories.Abstract;
using PoSApp.DAL;
using PoSApp.Entities;
using PoSApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.BLL.Repositories.Concrete
{
    public class PayedAmountRepository : BaseRepository<PayedAmount, PosDbContext>, IPayedAmountRepository
    {

        private PosDbContext _postDbContext;

        public virtual IEnumerable<PayedAmountList> GetAllSelected(string transNo)
        {
            List<PayedAmountList> list =new List<PayedAmountList>();
            using (_postDbContext = new PosDbContext())
            {
                list =  _postDbContext.Set<PayedAmount>().Where(m => m.IsDeleted == false).Where(m=>m.Cart.TransNo == transNo).Include(m=>m.Cart).Select(x => new PayedAmountList { Id = x.Id, PriceTotal = x.PriceTotal, PaymentType=x.PayedType }).ToList();

              
            }
            return list;
        }

        public decimal GetTotalPayedAmount(string transNo)
        {
            decimal totalPayed = 0;
            using (_postDbContext = new PosDbContext())
            {
                totalPayed=_postDbContext.Set<PayedAmount>().Where(m=>m.IsDeleted==false).Where(m => m.Cart.TransNo == transNo).Include(m => m.Cart).Select(m=>m.PriceTotal).Sum();
            }
            return totalPayed;
        }
    }

    public class PayedAmountList
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal PriceTotal { get; set; }
        public PaymentType PaymentType { get; set; }

    }
}
