using PoSApp.BLL.Repositories.Concrete;
using PoSApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.BLL.Repositories.Abstract
{
    public interface ICartDetailRepository : IBaseRepository<CartDetail>
    {
        IEnumerable<CartDetailList> GetAllSelected();
        ICollection<CartDetail> GetByCartId(int cartId);
        List<CartDetailList> GetAllSelectedbyTransNo(string transNo);
        IEnumerable<PrintDetailList> GetAllPrintbyTransNo(string transNo);
        ProductsInCartListDtoReturn GetAllProductsInCart(DateTime beginDate, DateTime endDate, string criterion);
        ProductsInCartListWithGroupDtoReturn GetAllProductsInCartWithGroup(DateTime beginDate, DateTime endDate, string criterion);
        ProductsInCartListDtoWithGroupbyMonthsReturn GetAllProductsInCartWithGroupbyMonths(int year, string criterion);
        ProductsInCartListDtoWithGroupbyMonthsPaymentReturn GetAllProductsInCartWithGroupbyPaymentMonths(int year, string criterion);

    }
}
