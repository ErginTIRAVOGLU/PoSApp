using Microsoft.EntityFrameworkCore;

using PoSApp.BLL.Repositories.Abstract;
using PoSApp.DAL;
using PoSApp.Entities;
using PoSApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.BLL.Repositories.Concrete
{
    public class StockInDetailRepository : BaseRepository<StockInDetail, PosDbContext>, IStockInDetailRepository
    {
        private PosDbContext _postDbContext;

        public virtual IEnumerable<StockInDetailListDTO> GetAllSelected()
        {
            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<StockInDetail>().Where(m => m.IsDeleted == false).Include(m => m.Warehouse).Select(x => new StockInDetailListDTO
                {
                    Id = x.Id,
                    StockInDetailUnit = x.Product.ProductUnitType == ProductUnitType.Quantity ? Decimal.ToInt32(x.StockInDetailUnit) : x.StockInDetailUnit,
                    StockInDetailUnitType = x.Product.ProductUnitType == ProductUnitType.Quantity ? "Adet" : "Gram",
                    ProductCode = x.Product.ProductCode,
                    ProductName = x.Product.ProductName,
                    ProductId = x.Product.Id,
                    ProductWarehouseId = x.WarehouseId,
                    DepoAdi = x.Warehouse.WarehouseName,


                    ProductArrivalPrice = x.ProductArrivalPrice,
                    ProductDiscountPercentage = x.ProductDiscountPercentage,
                    ProductUnitDiscountAmount = x.ProductUnitDiscountAmount,
                    ProductTotalDiscountAmount = x.ProductTotalDiscountAmount,
                    ProductTotalVatAmount = x.ProductTotalVatAmount,
                    ProductLastPriceWithoutVat = x.ProductLastPriceWithoutVat,
                    ProductLastPriceWithVat = x.ProductLastPriceWithVat



                }).ToList();

                return list;
            }
        }
        public StockInDetail GetByStockInId(int id)
        {
            using (_postDbContext = new PosDbContext())
            {
                StockInDetail p = _postDbContext.Set<StockInDetail>().Where(m => m.StockInId == id && m.IsDeleted == false).SingleOrDefault();
                return p;
            }

        }

        public StockInDetailWithTotalAmount GetStockInDetailsbyStockId(int id)
        {
            StockInDetailWithTotalAmount stockInDetailWithTotalAmount = new StockInDetailWithTotalAmount();
            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<StockInDetail>().Where(m => m.StockInId == id && m.IsDeleted == false).Include(m => m.Warehouse).AsNoTracking().Select(x => new StockInDetailListDTO
                {
                    Id = x.Id,
                    StockInDetailUnit = x.Product.ProductUnitType == ProductUnitType.Quantity ? Decimal.ToInt32(x.StockInDetailUnit) : x.StockInDetailUnit,
                    StockInDetailUnitType = x.Product.ProductUnitType == ProductUnitType.Quantity ? "Adet" : "Gram",
                    ProductCode = x.Product.ProductCode,
                    ProductName = x.Product.ProductName,
                    ProductId = x.Product.Id,
                    ProductWarehouseId = x.WarehouseId,
                    DepoAdi = x.Warehouse.WarehouseName,

                    ProductArrivalPrice = x.Product.ProductUnitType == ProductUnitType.Quantity ? decimal.Parse(x.ProductArrivalPrice.ToString("0.00")) : decimal.Parse(x.ProductArrivalPrice.ToString("0.0000")),
                    ProductDiscountPercentage = x.ProductDiscountPercentage,
                    ProductUnitDiscountAmount = x.Product.ProductUnitType == ProductUnitType.Quantity ? decimal.Parse(x.ProductUnitDiscountAmount.ToString("0.00")) : decimal.Parse(x.ProductUnitDiscountAmount.ToString("0.0000")),
                    ProductTotalDiscountAmount = x.Product.ProductUnitType == ProductUnitType.Quantity ? decimal.Parse(x.ProductTotalDiscountAmount.ToString("0.00")) : decimal.Parse(x.ProductTotalDiscountAmount.ToString("0.0000")),
                    ProductTotalVatAmount = x.Product.ProductUnitType == ProductUnitType.Quantity ? decimal.Parse(x.ProductTotalVatAmount.ToString("0.00")) : decimal.Parse(x.ProductTotalVatAmount.ToString("0.0000")),
                    ProductLastPriceWithoutVat = x.Product.ProductUnitType == ProductUnitType.Quantity ? decimal.Parse(x.ProductLastPriceWithoutVat.ToString("0.00")) : decimal.Parse(x.ProductLastPriceWithoutVat.ToString("0.0000")),
                    ProductLastPriceWithVat = decimal.Parse(x.ProductLastPriceWithVat.ToString("0.00"))



                }).ToList();
                

                stockInDetailWithTotalAmount.stockInDetailListDto = list;
                stockInDetailWithTotalAmount.totalPriceAmount= list.Sum(x => x.ProductLastPriceWithVat);

            }
            return stockInDetailWithTotalAmount;
        }

        public ProductsInStockListDtoReturn GetAllProductsInStock(DateTime beginDate, DateTime endDate, string criterion)
        {
            ProductsInStockListDtoReturn productsInStockListDtoReturn = new();
            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<StockInDetail>()
                    .Include(m => m.StockIn)
                    .Include(m => m.Product)
                    .OrderByDescending(m => m.StockIn.StockInDate)                   
                    .Where(m => m.IsDeleted == false)
                    .Where(m => m.Product.IsDeleted == false)
                    .Where(m => m.StockIn.IsDeleted == false)
                    .Where(m => m.StockIn.StockInDate >= beginDate && m.StockIn.StockInDate <= endDate)
                    .Where(m => m.Product.ProductName.ToLower().Contains(criterion) || m.Product.ProductBarcode.Contains(criterion) || m.Product.ProductCode.Contains(criterion)).AsNoTracking()
                    .Select(x => new ProductsInStockListDto
                    {
                        Id = x.Id,
                        StockInId = x.StockIn.Id,
                        ProductCode = x.Product.ProductCode,
                        ProductBarcode = x.Product.ProductBarcode,
                        ProductName = x.Product.ProductName,
                        onePrice = (x.ProductLastPriceWithVat / x.StockInDetailUnit).ToString("0.00"),
                        StockInDetailUnit = x.Product.ProductUnitType == ProductUnitType.Quantity ? Decimal.ToInt32(x.StockInDetailUnit) : Decimal.ToInt32(x.StockInDetailUnit),
                        StockInDetailUnitType = x.Product.ProductUnitType == ProductUnitType.Quantity ? "Adet" : "Gram",
                        ProductPrice = x.Product.ProductPrice.ToString("0.00"),
                        StockInDate = x.StockIn.StockInDate,
                        ProductId = x.Product.Id,
                        LastPriceWithVat = x.ProductLastPriceWithVat.ToString("0.00")
                    }
                    ).ToList();
                var TotalAmount = list.Sum(x => decimal.Parse(x.LastPriceWithVat));
                productsInStockListDtoReturn.ProductsInStockListDto = list;
                productsInStockListDtoReturn.TotalAmount = TotalAmount;
                return productsInStockListDtoReturn;
            }

        }

        public ProductsInStockListWithGroupDtoReturn GetAllProductsInStockWithGroup(DateTime beginDate, DateTime endDate, string criterion)
        {
            ProductsInStockListWithGroupDtoReturn productsInStockListWithGroupDtoReturn = new();
            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<StockInDetail>();

                var query = list
                    .Join(_postDbContext.Set<StockIn>(), sd => sd.StockInId, s => s.Id, (sd, s) => new { sd, s })
                    .Join(_postDbContext.Set<Product>(), combined => combined.sd.ProductId, p => p.Id, (combined, p) => new { combined, p })
                    .Where(result => result.combined.sd.IsDeleted == false)
                    .Where(result => result.combined.s.IsDeleted == false)
                    .Where(result => result.p.IsDeleted == false)
                    .OrderByDescending(m => m.combined.s.StockInDate)                   
                    .Where(m => m.combined.s.StockInDate >= beginDate && m.combined.s.StockInDate <= endDate)
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
                    .Select(grouped => new ProductsInStockListDtoWithGroup
                    {
                        Id = grouped.Key.Id,
                        ProductCode = grouped.Key.ProductCode,
                        ProductBarcode = grouped.Key.ProductBarcode,
                        ProductName = grouped.Key.ProductName,
                        alimsayisi = grouped.Count(),
                        StockInDetailUnit = grouped.Key.ProductUnitType == ProductUnitType.Quantity ? Decimal.ToInt32(grouped.Sum(x => x.combined.sd.StockInDetailUnit)) : Decimal.ToInt32(grouped.Sum(x => x.combined.sd.StockInDetailUnit)),
                        StockInDetailUnitType = grouped.Key.ProductUnitType == ProductUnitType.Quantity ? "Adet" : "Gram",                       
                        LastPriceWithVat = grouped.Sum(x => x.combined.sd.ProductLastPriceWithVat).ToString("0.00")
                    });

                var results = query.ToList();
                productsInStockListWithGroupDtoReturn.ProductsInStockListDtoWithGroup = results;
                productsInStockListWithGroupDtoReturn.TotalAmount = results.Sum(x => decimal.Parse(x.LastPriceWithVat));
                return productsInStockListWithGroupDtoReturn;

            }

        }

        public ProductsInStockListDtoWithGroupbyMonthsReturn GetAllProductsInStockWithGroupbyMonths(int year, string criterion)
        {
            ProductsInStockListDtoWithGroupbyMonthsReturn productsInStockListWithGroupDtoReturn = new();
            using (_postDbContext = new PosDbContext())
            {




                var result = _postDbContext.Set<StockIn>()
                    .Where(si => !si.IsDeleted)
                    .Join(_postDbContext.Set<StockInDetail>().Where(sd => !sd.IsDeleted),
                        si => si.Id,
                        sd => sd.StockInId,
                        (si, sd) => new { StockIn = si, StockInDetail = sd })
                    .Join(_postDbContext.Set<Product>().Where(p => !p.IsDeleted),
                        s => s.StockInDetail.ProductId,
                        p => p.Id,
                        (s, p) => new { StockIn = s.StockIn, StockInDetail = s.StockInDetail, Product = p })
                    .GroupBy(s => new 
                    { 
                        Year = s.StockIn.StockInDate.Year, 
                        Month = s.StockIn.StockInDate.Month 
                    })
                    .Select(g => new ProductsInStockListDtoWithGroupbyMonths
                    {
                        Year = g.Key.Year,
                        Month = g.Key.Month,
                        TotalStockedProducts = g.Count(),
                        TotalPriceWithVat = g.Sum(p => p.StockInDetail.ProductLastPriceWithVat).ToString("0.00"),
                        MonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(g.Key.Month)
                    })
                    .Where(r=>r.Year==year)
                    .OrderBy(r => r.Year)
                    .ThenBy(r => r.Month)
                    .ToList();


                var results = result;
                productsInStockListWithGroupDtoReturn.ProductsInStockListDtoWithGroupbyMonths = results;
                productsInStockListWithGroupDtoReturn.TotalAmount = results.Sum(x => decimal.Parse(x.TotalPriceWithVat));
                return productsInStockListWithGroupDtoReturn;

            }

        }

    }

    public class ProductsInStockListDtoWithGroupbyMonthsReturn
    {
        public ICollection<ProductsInStockListDtoWithGroupbyMonths> ProductsInStockListDtoWithGroupbyMonths { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalAmount { get; set; }
    }

    public class ProductsInStockListDtoWithGroupbyMonths
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int TotalStockedProducts { get; set; }
        public string TotalPriceWithVat { get; set; }
        public string MonthName { get; set; }
    }

    public class ProductsInStockListWithGroupDtoReturn
    {
        public ICollection<ProductsInStockListDtoWithGroup> ProductsInStockListDtoWithGroup { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalAmount { get; set; }
    }

    public class ProductsInStockListDtoWithGroup
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
     
    public class StockInDetailWithTotalAmount
    {
        public IEnumerable<StockInDetailListDTO> stockInDetailListDto { get; set; }
        public decimal totalPriceAmount { get; set; }
    }

    public class StockInDetailListDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }

        public decimal StockInDetailUnit { get; set; }
        public string StockInDetailUnitType { get; set; }

        public decimal ProductArrivalPrice { get; set; }
        public decimal ProductDiscountPercentage { get; set; }
        public decimal ProductUnitDiscountAmount { get; set; }
        public decimal ProductTotalDiscountAmount { get; set; }
        public decimal ProductTotalVatAmount { get; set; }
        public decimal ProductLastPriceWithoutVat { get; set; }
        public decimal ProductLastPriceWithVat { get; set; }


        public int ProductWarehouseId { get; set; }
        public string DepoAdi { get; set; }
    }

    public class ProductsInStockListDtoReturn
    {
        public ICollection<ProductsInStockListDto> ProductsInStockListDto { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalAmount { get; set; }
    }

    public class ProductsInStockListDto
    {
        public int Id { get; set; }
        public int StockInId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductBarcode { get; set; }
        public string ProductName { get; set; }
        public decimal StockInDetailUnit { get; set; }
        public string StockInDetailUnitType { get; set; }
        public string onePrice { get; set; }
        public string LastPriceWithVat { get; set; }
        public string ProductPrice { get; set; }
        public DateTime StockInDate { get; set; }

    }
    

    

}
