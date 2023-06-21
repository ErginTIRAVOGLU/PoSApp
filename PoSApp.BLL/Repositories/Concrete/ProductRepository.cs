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

        public virtual  IEnumerable<ProductListDTO> GetAllSelected()
        {
            using (_postDbContext = new PosDbContext())
            {
                var list =  _postDbContext.Set<Product>().Where(m => m.IsDeleted == false)
                    .Select(x => new ProductListDTO
                    { 
                        Id = x.Id, 
                        ProductCode = x.ProductCode,
                        ProductName = x.ProductName,                        
                        ProductBarcode = x.ProductBarcode,
                        ProductPrice = x.ProductPrice,                       
                        ProductUnitType = x.ProductUnitType,
                        Vat = x.ProductVat,
                        
                        
                    }).ToList();

                return list;
            }
        }
        public virtual IEnumerable<ProductListUrunGirisDTO> GetAllUrunGiris()
        {
            using (_postDbContext = new PosDbContext())
            {
                var list =  _postDbContext.Set<Product>().Where(m => m.IsDeleted == false)
                    .Select(x => new ProductListUrunGirisDTO
                    {
                        Id = x.Id,
                        ProductCode = x.ProductCode,
                        ProductName = x.ProductName,                        
                    }).ToList();
                
                return list;
            }
        }

        public IEnumerable<ProductListUrunGirisDTO> GetWhereUrunGiris(Expression<Func<Product, bool>> method)
        {
            using (_postDbContext = new PosDbContext())
            {
                var list =  _postDbContext.Set<Product>().Where(m => m.IsDeleted == false).Where(method)
                    .Select(x => new ProductListUrunGirisDTO
                    {
                        Id = x.Id,
                        ProductCode = x.ProductCode,
                        ProductName = x.ProductName,
                    }).ToList();
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
                        ProductUnitType = x.ProductUnitType,
                        Vat = x.ProductVat
                    }).ToList();

                return list;
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
        public ProductUnitType ProductUnitType { get; set; }
        public int Vat { get; set; }
    }

    public class ProductListUrunGirisDTO
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }         

    }
}
