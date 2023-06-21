using Microsoft.EntityFrameworkCore;
 
using PoSApp.BLL.Repositories.Abstract;
using PoSApp.DAL;
using PoSApp.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.BLL.Repositories.Concrete
{
    public class BrandRepository : BaseRepository<Brand, PosDbContext>, IBrandRepository
    {

        private PosDbContext _postDbContext;

        public virtual IEnumerable<BrandList> GetAllSelected()
        {
            using (_postDbContext = new PosDbContext())
            {
                var list =  _postDbContext.Set<Brand>().Where(m => m.IsDeleted == false).Select(x => new BrandList { Id = x.Id, BrandName = x.BrandName }).ToList();

                return list;
            }
        }
    }
    public class BrandList{
        public int Id { get; set; }
        public string BrandName { get; set; }

    }
}
