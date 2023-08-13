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
    public class BaseRepository<T, Context> : IDisposable, IBaseRepository<T> where T : Base, new() where Context : DbContext, new()
    {
        protected Context _postDbContext;

        /*
        public BaseRepository(Context postDbContext)
        {
            _postDbContext = postDbContext;
        }
        */

        public bool Insert(T p)
        {
            using (_postDbContext = new Context())
            {   p.CreatedDate = DateTime.Now;
                var T = _postDbContext.Set<T>().Add(p);
                var result =  _postDbContext.SaveChanges();
                return result > 0 ? true : false;
            }
        }

        public bool Update(T p)
        {
            using (_postDbContext = new Context())
            {
                p.UpdatedDate = DateTime.Now;
                var T = _postDbContext.Set<T>().Update(p);
                var result =  _postDbContext.SaveChanges();
                return result > 0 ? true : false;
            }
        }

        public bool Delete(T p)
        {
            using (_postDbContext = new Context())
            {
                p.DeletedDate = DateTime.Now;
                p.IsDeleted = true;
                var T = _postDbContext.Set<T>().Update(p);
                var result =  _postDbContext.SaveChanges();
                return result > 0 ? true : false;
            }
        }

        public ICollection<T> GetAll()
        {
            using (_postDbContext = new Context())
            {
                List<T> list =  _postDbContext.Set<T>().Where(m => m.IsDeleted == false).AsNoTracking().ToList();
                return list;
            }

          
        }

        public ICollection<T> GetWhere(Expression<Func<T, bool>> method)
        {
            using (_postDbContext = new Context())
            {
                List<T> list =  _postDbContext.Set<T>().Where(method).ToList();
                return list;
            }

           
        }

        public T GetSingle(Expression<Func<T, bool>> method)
        {
            using (_postDbContext = new Context())
            {
                T p =  _postDbContext.Set<T>().Where(method).FirstOrDefault();
                return p;
            }
            
        }

        public T GetById(int id)
        {
            using (_postDbContext = new Context())
            {
                T p =  _postDbContext.Set<T>().Where(m => m.Id == id && m.IsDeleted == false).FirstOrDefault();
                return p;
            }
            
        }
        public bool SaveNow()
        {
            using (_postDbContext = new Context())
            {
                var result = _postDbContext.SaveChanges();
                return result > 0 ? true : false;
            }
        }

        public void Dispose()
        {
            using (_postDbContext = new Context())
            {
                _postDbContext.Dispose();
            }
        }
    }
}
