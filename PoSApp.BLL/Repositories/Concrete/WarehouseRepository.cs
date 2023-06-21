using PoSApp.BLL.Repositories.Abstract;
using PoSApp.DAL;
using PoSApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.BLL.Repositories.Concrete
{
    public class WarehouseRepository : BaseRepository<Warehouse, PosDbContext>, IWarehouseRepository
    {
        private PosDbContext _postDbContext;

        public virtual IEnumerable<WarehouseList> GetAllSelected()
        {
            using (_postDbContext = new PosDbContext())
            {
                var list = _postDbContext.Set<Warehouse>().Where(m => m.IsDeleted == false).Select(x => new WarehouseList
                {
                    Id = x.Id,
                    WarehouseName = x.WarehouseName

                }).ToList();

                return list;
            }
        }
        public List<Warehouse> GetAllWarehouses()
        {
            using (_postDbContext = new PosDbContext())
            {
                List<Warehouse> list = _postDbContext.Set<Warehouse>().Where(m => m.IsDeleted == false).ToList();
                return list;
            }


        }
    }
    public class WarehouseList
    {
        public int Id { get; set; }
        public string WarehouseName { get; set; }
    }
 
}
