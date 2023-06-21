using Microsoft.EntityFrameworkCore;
using PoSApp.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.BLL.Repositories.Abstract
{
    public interface IBaseRepository<T> where T : Base
    {


        bool Insert(T p);
        bool Update(T p);
        bool Delete(T p);


        ICollection<T> GetWhere(Expression<Func<T, bool>> method);
        T GetSingle(Expression<Func<T, bool>> method);
        T GetById(int id);

        ICollection<T> GetAll();

        
         
    }
}
