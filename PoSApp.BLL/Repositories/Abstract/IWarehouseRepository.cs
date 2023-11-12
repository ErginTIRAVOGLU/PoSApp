using PoSApp.BLL.Repositories.Concrete;
using PoSApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.BLL.Repositories.Abstract
{
    public interface IWarehouseRepository : IBaseRepository<Warehouse>
    {
        IEnumerable<WarehouseList> GetAllSelected();
        List<Warehouse> GetAllWarehouses();
    }
}
