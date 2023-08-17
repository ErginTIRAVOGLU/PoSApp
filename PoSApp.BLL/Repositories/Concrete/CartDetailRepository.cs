using Microsoft.EntityFrameworkCore;

using PoSApp.BLL.Repositories.Abstract;
using PoSApp.DAL;
using PoSApp.Entities;
using PoSApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.BLL.Repositories.Concrete
{
    public class CartDetailRepository : BaseRepository<CartDetail, PosDbContext>, ICartDetailRepository
    {

        private PosDbContext _postDbContext;

        public virtual IEnumerable<CartDetailList> GetAllSelected()
        {
            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<CartDetail>().Include(m => m.Product).Include(m => m.Cart).Where(m => m.IsDeleted == false).Select(x => new CartDetailList
                {
                    Id = x.Id,
                    Description = x.Description,//x.Product.ProductName,
                    CartDetailUnitType = x.ProductUnitType == ProductUnitType.Quantity ? "Adet" : "Gram",
                    Vat = x.Product.ProductVat,
                    Discount = x.ProductDiscount,
                    Price = x.Price,
                    Quantity = x.ProductUnitType == ProductUnitType.Quantity ? Decimal.ToInt32(x.ProductUnit) : x.ProductUnit,
                    Total = x.PriceTotal,
                    ProductId = x.ProductId
                }).ToList();

                return list;
            }
        }
        public ICollection<CartDetail> GetByCartId(int cartId)
        {
            using (_postDbContext = new PosDbContext())
            {
                List<CartDetail> list = _postDbContext.Set<CartDetail>().Include(m => m.Cart).Where(m => m.CartId == cartId).Where(m => m.IsDeleted == false).AsNoTracking().ToList();
                return list;
            }


        }

        public virtual List<CartDetailList> GetAllSelectedbyTransNo(string transNo)
        {
            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<CartDetail>().Include(m => m.Product).Include(m => m.Cart).Where(m => m.IsDeleted == false).Where(m => m.Cart.TransNo == transNo).AsNoTracking().Select(x => new CartDetailList
                {
                    Id = x.Id,
                    Description = x.Description, //x.Product.ProductName,
                    CartDetailUnitType = x.ProductUnitType == ProductUnitType.Quantity ? "Adet" : "Gram",
                    Vat = x.Product.ProductVat,
                    Discount = x.Product.ProductUnitType == ProductUnitType.Quantity ? decimal.Parse(x.ProductDiscount.ToString("0.00")) : decimal.Parse(x.ProductDiscount.ToString("0.0000")),
                    Price = x.Product.ProductUnitType == ProductUnitType.Quantity ? decimal.Parse(x.Price.ToString("0.00")) : decimal.Parse(x.Price.ToString("0.0000")),
                    //Quantity = x.ProductUnitType == ProductUnitType.Quantity ? Decimal.ToInt32(x.ProductUnit) : x.ProductUnit,
                    Quantity = Decimal.ToInt32(x.ProductUnit),
                    Total = decimal.Parse(x.PriceTotal.ToString("0.00")),
                    ProductId = x.ProductId
                }).ToList();

                return list;
            }
        }
        public virtual IEnumerable<PrintDetailList> GetAllPrintbyTransNo(string transNo)
        {

            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<CartDetail>().Include(m => m.Product).Include(m => m.Cart).Where(m => m.IsDeleted == false).Where(m => m.Cart.TransNo == transNo).Select(x => new PrintDetailList
                {
                    ProductCode = x.Product.ProductCode,
                    Description = x.Description,//x.Product.ProductName,                     
                    Vat = x.Product.ProductVat,
                    Discount = x.Product.ProductUnitType == ProductUnitType.Quantity ? decimal.Parse(x.ProductDiscount.ToString("0.00")) : decimal.Parse(x.ProductDiscount.ToString("0.0000")),
                    Price = x.Product.ProductUnitType == ProductUnitType.Quantity ? decimal.Parse(x.Price.ToString("0.00")) : decimal.Parse(x.Price.ToString("0.0000")),
                    CartDetailUnitTypeName = x.ProductUnitType == ProductUnitType.Quantity ? "Adet" : "Gram",
                    Quantity = x.ProductUnitType == ProductUnitType.Quantity ? Decimal.ToInt32(x.ProductUnit) : x.ProductUnit,
                    Total = x.ProductUnitType == ProductUnitType.Quantity ? x.Price * Decimal.ToInt32(x.ProductUnit) : x.ProductUnit,

                }).ToList();

                return list;
            }
        }

    }
    public class CartDetailList
    {
        public int Id { get; set; } = 0;
        public int ProductId { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public string CartDetailUnitType { get; set; }

        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public int Vat { get; set; }
        public decimal Total { get; set; }

    }
    public class PrintDetailList
    {
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public string CartDetailUnitTypeName { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public int Vat { get; set; }
        public decimal Total { get; set; }

    }
}
