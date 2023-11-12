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
    public interface IStockInRepository : IBaseRepository<StockIn>
    {
        IEnumerable<StockInListDTO> GetAllSelected();
        ICollection<StockInListDTO> GetBetweenDates(Expression<Func<StockIn, bool>> method);

    }
}
