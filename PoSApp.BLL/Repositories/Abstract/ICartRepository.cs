using PoSApp.BLL.Repositories.Concrete;
using PoSApp.DAL;
using PoSApp.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.BLL.Repositories.Abstract
{
    public interface ICartRepository : IBaseRepository<Cart>
    {
        IEnumerable<CartList> GetAllSelected();
        ICollection<CartList> GetBetweenDates(Expression<Func<Cart, bool>> method);
        Cart GetbyTransNo(string transNo);
        Cart GetbyTransNoNoInc(string transNo);
        string GetTransNo(DateTime Tarih);

    }
}
