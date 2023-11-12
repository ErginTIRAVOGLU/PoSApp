using PoSApp.BLL.Repositories.Concrete;
using PoSApp.DAL;
using PoSApp.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.BLL.Repositories.Abstract
{
    public interface IPayedAmountRepository : IBaseRepository<PayedAmount>
    {
        decimal GetTotalPayedAmount(string transNo);
        IEnumerable<PayedAmountList> GetAllSelected(string transNo);
    }
}
