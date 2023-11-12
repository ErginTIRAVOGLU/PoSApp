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
    public interface IStockInDetailRepository : IBaseRepository<StockInDetail>
    {
        IEnumerable<StockInDetailListDTO> GetAllSelected();
        StockInDetail GetByStockInId(int id);
        StockInDetailWithTotalAmount GetStockInDetailsbyStockId(int id);
        ProductsInStockListDtoReturn GetAllProductsInStock(DateTime beginDate, DateTime endDate, string criterion);
        ProductsInStockListWithGroupDtoReturn GetAllProductsInStockWithGroup(DateTime beginDate, DateTime endDate, string criterion);
        ProductsInStockListDtoWithGroupbyMonthsReturn GetAllProductsInStockWithGroupbyMonths(int year, string criterion);

    }
}
