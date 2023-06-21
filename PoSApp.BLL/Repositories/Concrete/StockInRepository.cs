using Microsoft.EntityFrameworkCore;
 
using PoSApp.BLL.Repositories.Abstract;
using PoSApp.DAL;
using PoSApp.Entities;
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
    public class StockInRepository : BaseRepository<StockIn, PosDbContext>, IStockInRepository
    {
        private PosDbContext _postDbContext;

        public virtual IEnumerable<StockInListDTO> GetAllSelected()
        {
            using (_postDbContext = new PosDbContext())
            {
                var list =  _postDbContext.Set<StockIn>().Where(m => m.IsDeleted == false).Include(m=>m.Supplier).OrderByDescending(m=>m.StockInDate).Select(x => new StockInListDTO
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
                var list = _postDbContext.Set<StockIn>().Where(method).Where(m => m.IsDeleted == false).Include(m => m.Supplier).OrderByDescending(m => m.StockInDate).Select(x => new StockInListDTO
                {
                    Id = x.Id,
                    StockInRefNo = x.StockInRefNo,
                    SupplierName = x.Supplier.SupplierName,
                    StockInDate = x.StockInDate.ToShortDateString(),




                }).ToList();
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
}
