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
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.BLL.Repositories.Concrete
{
    public class StockInRepository : BaseRepository<StockIn, PosDbContext>, IStockInRepository
    {
        private PosDbContext _postDbContext;

        public virtual IEnumerable<StockInListDTO> GetAllSelected()
        {
            using (_postDbContext = new PosDbContext())
            {
                var list =  _postDbContext.Set<StockIn>().Where(m => m.IsDeleted == false).Include(m=>m.Supplier).OrderByDescending(m=>m.StockInDate).AsNoTracking().Select(x => new StockInListDTO
                {
                    Id = x.Id,
                    StockInRefNo = x.StockInRefNo,
                    SupplierName = x.Supplier.SupplierName,
                    StockInDate = x.StockInDate.ToShortDateString(),
                        
                 


                }).Take(10).ToList();

                return list;
            }
        }

        public ICollection<StockInListDTO> GetBetweenDates(Expression<Func<StockIn, bool>> method)
        {
            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<StockIn>().Where(method).Where(m => m.IsDeleted == false).Include(m => m.Supplier).OrderByDescending(m => m.StockInDate).AsNoTracking().Select(x => new StockInListDTO
                {
                    Id = x.Id,
                    StockInRefNo = x.StockInRefNo,
                    SupplierName = x.Supplier.SupplierName,
                    StockInDate = x.StockInDate.ToShortDateString(),




                }).ToList();
                return list;
            }


        }

        
        public ICollection<ProductsInStockListDto> GetAllProductsInStock(DateTime beginDate, DateTime endDate, string criterion)
        {
            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<StockInDetail>()
                    .Include(m => m.StockIn)
                    .Include(m => m.Product)
                    .OrderByDescending(m => m.StockIn.StockInDate)
                    .AsNoTracking()
                    .Where(m => m.IsDeleted == false)
                    .Where(m => m.Product.IsDeleted == false)
                    .Where(m => m.StockIn.IsDeleted == false)
                    .Where(m => m.StockIn.StockInDate >= beginDate && m.StockIn.StockInDate <= endDate)
                    .Where(m => m.Product.ProductName.ToLower().Contains(criterion) || m.Product.ProductBarcode.Contains(criterion) || m.Product.ProductCode.Contains(criterion)).AsNoTracking().Select(x => new ProductsInStockListDto
                    {
                        Id = x.Id,
                        StockInId= x.StockIn.Id,
                        ProductCode=x.Product.ProductCode,
                        ProductBarcode = x.Product.ProductBarcode,
                        ProductName = x.Product.ProductName,
                        onePrice=(x.ProductLastPriceWithVat/x.StockInDetailUnit).ToString("0.00"),
                        StockInDetailUnit = x.Product.ProductUnitType == ProductUnitType.Quantity ? Decimal.ToInt32(x.StockInDetailUnit) : x.StockInDetailUnit,
                        StockInDetailUnitType = x.Product.ProductUnitType == ProductUnitType.Quantity ? "Adet" : "Gram",
                        ProductPrice =x.Product.ProductPrice.ToString("0.00"),
                        StockInDate=x.StockIn.StockInDate,
                        
                    }
                    ).ToList();
                return list;
            }
                
        }

    }

    public class StockInListDTO
    {
        public int Id { get; set; }
        public string StockInRefNo { get; set; }
        public string SupplierName { get; set; }
        public string StockInDate { get; set; }
       
      
      
    }

    public class ProductsInStockListDto
    {
        public int Id { get; set; }
        public int StockInId { get; set; }
        public string ProductCode { get; set; }
        public string ProductBarcode { get; set; }
        public string ProductName { get; set; }
        public decimal StockInDetailUnit { get; set; }
        public string StockInDetailUnitType { get; set; }
        public string onePrice { get; set; }
         
        public string ProductPrice { get; set; }
        public DateTime StockInDate { get; set; }



    }
}
