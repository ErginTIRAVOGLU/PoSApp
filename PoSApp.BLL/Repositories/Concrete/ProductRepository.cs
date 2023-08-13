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
    public class ProductRepository : BaseRepository<Product, PosDbContext>, IProductRepository
    {

        private PosDbContext _postDbContext;

        public virtual IEnumerable<ProductListDTO> GetAllSelected()
        {
            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<Product>().Where(m => m.IsDeleted == false)
                    .Select(x => new ProductListDTO
                    {
                        Id = x.Id,
                        ProductCode = x.ProductCode,
                        ProductName = x.ProductName,
                        ProductBarcode = x.ProductBarcode,
                        ProductPrice = x.ProductPrice,
                        ProductUnitType = x.ProductUnitType == ProductUnitType.Quantity ? "Adet" : "Gram",
                        Vat = x.ProductVat,


                    }).AsNoTracking().ToList();

                return list;
            }
        }
        public virtual IEnumerable<ProductListDTOWithStock> GetAllSelectedWithStock()
        {
            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<Product>().Where(m => m.IsDeleted == false).Include(m => m.StockInDetails).Include(m => m.CartDetails).AsNoTracking()
                    .Select(x => new ProductListDTOWithStock
                    {
                        Id = x.Id,
                        ProductCode = x.ProductCode,
                        ProductName = x.ProductName,
                        ProductBarcode = x.ProductBarcode,
                        ProductPrice = x.ProductUnitType == ProductUnitType.Quantity ? x.ProductPrice.ToString("0.00") : x.ProductPrice.ToString("0.0000"),
                        ProductUnitType = x.ProductUnitType == ProductUnitType.Quantity ? "Adet" : "Gram",
                        Vat = x.ProductVat,
                        NetProductAmountInStock =(x.StockInDetails.Sum(sd => sd.StockInDetailUnit) - x.CartDetails.Sum(cd => cd.ProductUnit)).ToString("0")

                    }).AsNoTracking().ToList();

                return list;
            }
        }
        public virtual IEnumerable<ProductListUrunGirisDTO> GetAllUrunGiris()
        {
            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<Product>().Where(m => m.IsDeleted == false)
                    .Select(x => new ProductListUrunGirisDTO
                    {
                        Id = x.Id,
                        ProductCode = x.ProductCode,
                        ProductName = x.ProductName,
                    }).AsNoTracking().ToList();

                return list;
            }
        }

        public IEnumerable<ProductListUrunGirisDTO> GetWhereUrunGiris(Expression<Func<Product, bool>> method)
        {
            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<Product>().Where(m => m.IsDeleted == false).Where(method)
                    .Select(x => new ProductListUrunGirisDTO
                    {
                        Id = x.Id,
                        ProductCode = x.ProductCode,
                        ProductName = x.ProductName,
                    }).AsNoTracking().ToList();
                return list;
            }


        }

        public virtual IEnumerable<ProductListDTO> GetWhereUrunDialogSearch(Expression<Func<Product, bool>> method)
        {
            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<Product>().Where(m => m.IsDeleted == false).Where(method)
                    .Select(x => new ProductListDTO
                    {
                        Id = x.Id,
                        ProductCode = x.ProductCode,
                        ProductName = x.ProductName,
                        ProductBarcode = x.ProductBarcode,
                        ProductPrice = x.ProductPrice,
                        ProductUnitType = x.ProductUnitType == ProductUnitType.Quantity ? "Adet" : "Gram",
                        Vat = x.ProductVat
                    }).AsNoTracking().ToList();

                return list;
            }
        }
        public virtual IEnumerable<ProductListDTOWithStock> GetWhereUrunDialogSearchWithStock(Expression<Func<Product, bool>> method)
        {
            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<Product>().Where(m => m.IsDeleted == false).Where(method)
                    .Select(x => new ProductListDTOWithStock
                    {
                        Id = x.Id,
                        ProductCode = x.ProductCode,
                        ProductName = x.ProductName,
                        ProductBarcode = x.ProductBarcode,
                        ProductPrice = x.ProductUnitType == ProductUnitType.Quantity ? x.ProductPrice.ToString("0.00") : x.ProductPrice.ToString("0.0000"),
                        ProductUnitType = x.ProductUnitType == ProductUnitType.Quantity ? "Adet" : "Gram",
                        Vat = x.ProductVat,
                        NetProductAmountInStock = (x.StockInDetails.Sum(sd => sd.StockInDetailUnit) - x.CartDetails.Sum(cd => cd.ProductUnit)).ToString("0")
                    }).AsNoTracking().ToList();

                return list;
            }
        }
        public ProductWithStock GetByIdWithStockNumber(int id)
        {
            using (_postDbContext = new PosDbContext())
            {
                var p = _postDbContext.Set<Product>().Where(m => m.Id == id && m.IsDeleted == false).Include(m => m.StockInDetails).Include(m => m.CartDetails)
                    .Select(product => new ProductWithStock
                    {
                        product = product,
                        NetProductAmountInStock = product.StockInDetails.Sum(sd => sd.StockInDetailUnit)
                                              - product.CartDetails.Sum(cd => cd.ProductUnit)


                    }).FirstOrDefault();
                return p;
            }

        }

        
    } 
    public class ProductListDTO
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductBarcode { get; set; }

        public decimal ProductPrice { get; set; }
        public string ProductUnitType { get; set; }
        public int Vat { get; set; }
    }

    public class ProductListUrunGirisDTO
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }

    }

    public class ProductWithStock
    {
        public Product product { get; set; }
        public decimal NetProductAmountInStock { get; set; }
    }

    public class ProductListDTOWithStock
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductBarcode { get; set; }

        public string ProductPrice { get; set; }
        public string ProductUnitType { get; set; }
        public int Vat { get; set; }
        public string NetProductAmountInStock { get; set; }

    }
}
