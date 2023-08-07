using Microsoft.EntityFrameworkCore;
 
using PoSApp.BLL.Repositories.Abstract;
using PoSApp.DAL;
using PoSApp.Entities;
using PoSApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.BLL.Repositories.Concrete
{
    public class CartRepository : BaseRepository<Cart, PosDbContext>, ICartRepository
    {

        private PosDbContext _postDbContext;

        public virtual IEnumerable<CartList> GetAllSelected()
        {
            using (_postDbContext = new PosDbContext())
            {
                var list =  _postDbContext.Set<Cart>().Where(m => m.IsDeleted == false).OrderByDescending(m => m.CartDate).Select(x => new CartList { 
                    Id = x.Id, 
                    CartRefNo = x.TransNo, 
                    CartPrice = x.Price,
                    CartDiscount =x.DiscountTotal,
                    CartVat =x.Vat,
                    CartPriceTotal =x.PriceTotal,                    
                    CartStatusType = x.Status == CartStatus.Pending ? "Ödeme Bekliyor" : x.Status == CartStatus.Payed ? "Ödendi" : "İptal Edildi",
                    CartDate =x.CartDate
                }).ToList();

                return list;
            }
        }
        public ICollection<CartList> GetBetweenDates(Expression<Func<Cart, bool>> method)
        {
            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<Cart>().Where(method).Where(m => m.IsDeleted == false).OrderByDescending(m => m.CartDate).Select(x => new CartList
                {
                    Id = x.Id,
                    CartRefNo = x.TransNo,
                    CartPrice = x.Price,
                    CartDiscount = x.DiscountTotal,
                    CartVat = x.Vat,
                    CartPriceTotal = x.PriceTotal,
                    CartStatusType = x.Status== CartStatus.Pending?"Ödeme Bekliyor": x.Status == CartStatus.Payed?"Ödendi":"İptal Edildi",
                    CartDate = x.CartDate
                }).ToList();

                return list;
            }

        }
        public Cart GetbyTransNo(string transNo)
        {
            Cart cart= new Cart();
            using (_postDbContext = new PosDbContext())
            {
                cart= _postDbContext.Set<Cart>().Where(m=>m.TransNo==transNo).Include(m=>m.CartDetails).Include(m=>m.PayedAmounts).FirstOrDefault();
                
            }
            return cart;
        }
        public Cart GetbyTransNoNoInc(string transNo)
        {
            Cart cart = new Cart();
            using (_postDbContext = new PosDbContext())
            {
                cart = _postDbContext.Set<Cart>().Where(m => m.TransNo == transNo).Include(m => m.PayedAmounts).FirstOrDefault();

            }
            return cart;
        }
        public string GetTransNo()
        {
            var transNo = "";
            using (_postDbContext = new PosDbContext())
            {
                var firstDateOfToday = DateTime.Now.ToString("ddMMyyyy");             
                int count = 0;
                var transNoValue = _postDbContext.Set<Cart>().Where(m => m.TransNo.StartsWith(firstDateOfToday) && m.IsDeleted == false).OrderByDescending(m => m.TransNo).Select(m => m.TransNo).FirstOrDefault();
                if (!string.IsNullOrEmpty(transNoValue))
                {
                    transNo = transNoValue;
                    count = int.Parse(transNo.Substring(8, 4));
                    return firstDateOfToday + (count + 1);
                }
                else
                {
                    transNo = firstDateOfToday + "1001";
                }
            }
            return transNo;
        }
    }
    public class CartList{
        public int Id { get; set; }
        public string CartRefNo { get; set; }
        public decimal CartPrice { get; set; }
        public decimal CartDiscount { get; set; }
        public decimal CartVat { get; set; }
        public decimal CartPriceTotal { get; set; }       
        public string CartStatusType { get; set; }
        public DateTime CartDate { get; set; }
       


    }
}
