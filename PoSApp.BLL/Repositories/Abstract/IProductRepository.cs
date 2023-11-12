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
    public interface IProductRepository : IBaseRepository<Product>
    {
        ProductWithStock GetByIdWithStockNumber(int id);
        IEnumerable<ProductListDTO> GetAllSelected();
        IEnumerable<ProductListDTOWithStock> GetAllSelectedWithStock();
        IEnumerable<ProductListUrunGirisDTO> GetAllUrunGiris();
        IEnumerable<ProductListUrunGirisDTO> GetWhereUrunGiris(Expression<Func<Product, bool>> method);
        IEnumerable<ProductListDTO> GetWhereUrunDialogSearch(Expression<Func<Product, bool>> method);
        IEnumerable<ProductListDTOWithStock> GetWhereUrunDialogSearchWithStock(Expression<Func<Product, bool>> method);       
    }
}
