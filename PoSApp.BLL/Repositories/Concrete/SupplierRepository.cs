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
    public class SupplierRepository : BaseRepository<Supplier, PosDbContext>, ISupplierRepository
    {
        private PosDbContext _postDbContext;

        public virtual IEnumerable<SupplierList> GetAllSelected()
        {
            using (_postDbContext = new PosDbContext())
            {
                var list =  _postDbContext.Set<Supplier>().Where(m => m.IsDeleted == false).Select(x => new SupplierList
                {
                    Id = x.Id,
                    SupplierName = x.SupplierName,
                    SupplierAddress1 = x.SupplierAddress1,
                    SupplierAddress2 = x.SupplierAddress2,                 
                    SupplierPhone1 = x.SupplierPhone1,
                    SupplierPhone2 = x.SupplierPhone2


                }).ToList();

                return list;
            }
        }
        public List<Supplier> GetAllSupplier()
        {
            using (_postDbContext = new PosDbContext())
            {
                List<Supplier> list = _postDbContext.Set<Supplier>().Where(m => m.IsDeleted == false).ToList();
                return list;
            }


        }
    }
    public class SupplierList{
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress1 { get; set; }
        public string SupplierAddress2 { get; set; }
        public string SupplierPhone1 { get; set; }
        public string SupplierPhone2 { get; set; }
      
    }
}
