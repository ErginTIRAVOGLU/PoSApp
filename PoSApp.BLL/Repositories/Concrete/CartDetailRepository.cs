using Microsoft.EntityFrameworkCore;

using PoSApp.BLL.Repositories.Abstract;
using PoSApp.DAL;
using PoSApp.Entities;
using PoSApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Globalization;
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

        public ProductsInCartListDtoReturn GetAllProductsInCart(DateTime beginDate, DateTime endDate, string criterion)
        {
            ProductsInCartListDtoReturn productsInCartListDtoReturn = new();
            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<CartDetail>()
                    .Include(m => m.Cart)
                    .Include(m => m.Product)
                    .OrderByDescending(m => m.Cart.CartDate)
                    .Where(m => m.IsDeleted == false)
                    .Where(m => m.Product.IsDeleted == false)
                    .Where(m => m.Cart.IsDeleted == false)
                    .Where(m => m.Cart.CartDate >= beginDate && m.Cart.CartDate <= endDate)
                    .Where(m => m.Product.ProductName.ToLower().Contains(criterion) || m.Product.ProductBarcode.Contains(criterion) || m.Product.ProductCode.Contains(criterion)).AsNoTracking()
                    .Select(x => new ProductsInCartListDto
                    {
                        Id = x.Id,
                        CartId=x.Cart.Id,
                        ProductId = x.Product.Id,
                        TransNo=x.Cart.TransNo,                        
                        ProductCode = x.Product.ProductCode,
                        Description = x.Description,
                        ProductBarcode = x.Product.ProductBarcode,
                        ProductUnit = x.ProductUnitType == ProductUnitType.Quantity ? Decimal.ToInt32(x.ProductUnit).ToString("0.00") : Decimal.ToInt32(x.ProductUnit).ToString("0.00"),
                        ProductUnitType = x.ProductUnitType == ProductUnitType.Quantity ? "Adet" : "Gram",
                        ProductDiscount =x.ProductDiscount.ToString("0.00"),
                        Price=x.Price.ToString("0.00"),
                        DiscountTotal=x.DiscountTotal.ToString("0.00"),
                        PriceTotal=x.PriceTotal.ToString("0.00"),
                        CartDate=x.Cart.CartDate,
                        
                      
                    }
                    ).ToList();
                var TotalAmount = list.Sum(x => decimal.Parse(x.PriceTotal));
                productsInCartListDtoReturn.productsInCartListDto = list;
                productsInCartListDtoReturn.TotalAmount = TotalAmount;
                return productsInCartListDtoReturn;
            }
        }

        public ProductsInCartListWithGroupDtoReturn GetAllProductsInCartWithGroup(DateTime beginDate, DateTime endDate, string criterion)
        {
            ProductsInCartListWithGroupDtoReturn productsInStockListWithGroupDtoReturn = new();
            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<CartDetail>();

                var query = list
                    .Join(_postDbContext.Set<Cart>(), sd => sd.CartId, s => s.Id, (sd, s) => new { sd, s })
                    .Join(_postDbContext.Set<Product>(), combined => combined.sd.ProductId, p => p.Id, (combined, p) => new { combined, p })
                    .Where(result => result.combined.sd.IsDeleted == false)
                    .Where(result => result.combined.s.IsDeleted == false)
                    .Where(result => result.p.IsDeleted == false)
                    .OrderByDescending(m => m.combined.s.CartDate)
                    .Where(m => m.combined.s.CartDate >= beginDate && m.combined.s.CartDate <= endDate)
                    .Where(m => m.p.ProductName.ToLower().Contains(criterion) || m.p.ProductBarcode.Contains(criterion) || m.p.ProductCode.Contains(criterion)).AsNoTracking()
                    .GroupBy(result => new
                    {
                        result.p.Id,
                        result.p.ProductName,
                        result.p.ProductCode,
                        result.p.ProductBarcode,
                        result.p.ProductUnitType
                    })
                    .OrderBy(grouped => grouped.Key.ProductName)
                    .Select(grouped => new ProductsInCartListDtoWithGroup
                    {
                        Id = grouped.Key.Id,
                        ProductCode = grouped.Key.ProductCode,
                        ProductBarcode = grouped.Key.ProductBarcode,
                        ProductName = grouped.Key.ProductName,
                        alimsayisi = grouped.Count(),
                        StockInDetailUnit = grouped.Key.ProductUnitType == ProductUnitType.Quantity ? Decimal.ToInt32(grouped.Sum(x => x.combined.sd.ProductUnit)) : Decimal.ToInt32(grouped.Sum(x => x.combined.sd.ProductUnit)),
                        StockInDetailUnitType = grouped.Key.ProductUnitType == ProductUnitType.Quantity ? "Adet" : "Gram",
                        LastPriceWithVat = grouped.Sum(x => x.combined.sd.PriceTotal).ToString("0.00")
                    });

                var results = query.ToList();
                productsInStockListWithGroupDtoReturn.ProductsInCartListDtoWithGroup = results;
                productsInStockListWithGroupDtoReturn.TotalAmount = results.Sum(x => decimal.Parse(x.LastPriceWithVat));
                return productsInStockListWithGroupDtoReturn;

            }

        }


        public ProductsInCartListDtoWithGroupbyMonthsReturn GetAllProductsInCartWithGroupbyMonths(int year, string criterion)
        {
            ProductsInCartListDtoWithGroupbyMonthsReturn productsInCartListWithGroupDtoReturn = new();
            using (_postDbContext = new PosDbContext())
            {

                var result = _postDbContext.Set<Cart>()
                    .Where(si => !si.IsDeleted)
                    .Join(_postDbContext.Set<CartDetail>().Where(sd=>!sd.IsDeleted),
                        si => si.Id,
                        sd => sd.CartId,
                        (si, sd) => new { Cart = si, CartDetail = sd })
                    .Join(_postDbContext.Set<Product>().Where(p=> !p.IsDeleted),
                        s => s.CartDetail.ProductId,
                        p => p.Id,
                        (s, p) => new { Cart = s.Cart, CartDetail = s.CartDetail, Product = p })
                    .GroupBy(s => new
                    {
                        Year = s.Cart.CartDate.Year,
                        Month = s.Cart.CartDate.Month
                    })
                    .Select(g => new ProductsInCartListDtoWithGroupbyMonths
                    {
                        Year = g.Key.Year,
                        Month = g.Key.Month,
                        TotalSellProducts = g.Count(),
                        TotalPriceWithVat = g.Sum(p => p.CartDetail.PriceTotal).ToString("0.00"),
                        MonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(g.Key.Month)
                    })
                    .Where(r => r.Year == year)
                    .OrderBy(r => r.Year)
                    .ThenBy(r => r.Month)
                    .ToList();


                var results = result;
                productsInCartListWithGroupDtoReturn.ProductsInCartListDtoWithGroupbyMonths = results;
                productsInCartListWithGroupDtoReturn.TotalAmount = results.Sum(x => decimal.Parse(x.TotalPriceWithVat));
                return productsInCartListWithGroupDtoReturn;

            }

        }
    }

    public class ProductsInCartListDtoWithGroupbyMonthsReturn
    {
        public ICollection<ProductsInCartListDtoWithGroupbyMonths> ProductsInCartListDtoWithGroupbyMonths { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalAmount { get; set; }
    }

    public class ProductsInCartListDtoWithGroupbyMonths
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int TotalSellProducts { get; set; }
        public string TotalPriceWithVat { get; set; }
        public string MonthName { get; set; }
    }

    public class ProductsInCartListWithGroupDtoReturn
    {
        public ICollection<ProductsInCartListDtoWithGroup> ProductsInCartListDtoWithGroup { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalAmount { get; set; }
    }

    public class ProductsInCartListDtoWithGroup
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductBarcode { get; set; }
        public string ProductName { get; set; }
        public int alimsayisi { get; set; }
        public string StockInDetailUnitType { get; set; }
        public decimal StockInDetailUnit { get; set; }
        public string LastPriceWithVat { get; set; }
    }

    public class ProductsInCartListDtoReturn
    {
        public ICollection<ProductsInCartListDto> productsInCartListDto { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }
    }

    public class ProductsInCartListDto
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public string TransNo { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public string ProductBarcode { get; set; }

        public string ProductUnit { get; set; }
        public string ProductUnitType { get; set; }
        public string ProductDiscount { get; set; }
        public string Price { get; set; }
        public string DiscountTotal { get; set; }
        public string PriceTotal { get; set; }

        public DateTime CartDate { get; set; }

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
