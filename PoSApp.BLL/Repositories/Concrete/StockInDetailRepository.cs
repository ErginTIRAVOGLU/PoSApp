using Microsoft.EntityFrameworkCore;
 
using PoSApp.BLL.Repositories.Abstract;
using PoSApp.DAL;
using PoSApp.Entities;
using PoSApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
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
                var list =  _postDbContext.Set<StockInDetail>().Where(m => m.IsDeleted == false).Include(m=>m.Warehouse).Select(x => new StockInDetailListDTO
                {
                    Id = x.Id,        
                    StockInDetailUnit = x.Product.ProductUnitType == ProductUnitType.Quantity ? Decimal.ToInt32(x.StockInDetailUnit) : x.StockInDetailUnit,                  
                    StockInDetailUnitType = x.Product.ProductUnitType == ProductUnitType.Quantity ? "Adet" : "Gram",
                    ProductCode = x.Product.ProductCode,
                    ProductName = x.Product.ProductName,
                    ProductId = x.Product.Id,
                    ProductWarehouseId=x.WarehouseId,
                    DepoAdi=x.Warehouse.WarehouseName,


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
        public IEnumerable<StockInDetailListDTO> GetStockInDetailsbyStockId(int id)
        {
            using (_postDbContext=new PosDbContext())
            {
                var list = _postDbContext.Set<StockInDetail>().Where(m => m.StockInId == id && m.IsDeleted==false).Include(m => m.Warehouse).Select(x => new StockInDetailListDTO
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
}
