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
    public class CategoryRepository : BaseRepository<Category, PosDbContext>, ICategoryRepository
    {

        private PosDbContext _postDbContext;

        public virtual IEnumerable<CategoryList> GetAllSelected()
        {
            using (_postDbContext = new PosDbContext())
            {
                var list =  _postDbContext.Set<Category>().Where(m => m.IsDeleted == false).Select(x => new CategoryList { Id = x.Id, CategoryName = x.CategoryName }).ToList();

                return list;
            }
        }
    }
    public class CategoryList
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

    }
}
