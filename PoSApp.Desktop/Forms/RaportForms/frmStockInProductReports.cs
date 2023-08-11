using PoSApp.BLL.Repositories.Abstract;
using PoSApp.BLL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoSApp.Desktop.Forms.RaportForms
{
    public partial class frmStockInProductReports : Form
    {
        private ProductRepository _productRepository = new ProductRepository();
        private StockInRepository _stockInRepository = new StockInRepository();

        public frmStockInProductReports()
        {
            InitializeComponent();
        }

        private void txtProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var criterion = txtProductSearch.Text.ToLower();
                var productList = _productRepository.GetWhereUrunDialogSearchWithStock(x => x.ProductName.ToLower().Contains(criterion) || x.ProductBarcode.Contains(criterion) || x.ProductCode.Contains(criterion));


                dGWProduct.DataSource = productList;
                dGWProduct.Refresh();
            }
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            var beginDate = dTPBeginDate.Value;
            var newBeginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            var endDate = dTPEndDate.Value;
            var newEndDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 23, 59, 59);

            yukle(newBeginDate, newEndDate);
        }
        public void yukle(DateTime beginDate, DateTime endDate)
        {

            var stockInList = _stockInRepository.GetBetweenDates(m => m.StockInDate >= beginDate && m.StockInDate <= endDate);

            dGWProduct.DataSource = stockInList;
            dGWProduct.Refresh();

        }
    }
}
