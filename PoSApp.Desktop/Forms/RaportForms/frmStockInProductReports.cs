using PoSApp.BLL.Repositories.Abstract;
using PoSApp.BLL.Repositories.Concrete;
using PoSApp.Desktop.Forms.ProductForms;
using PoSApp.Desktop.Forms.StockInForms;
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

        private StockInRepository _stockInRepository = new StockInRepository();

        private ProductRepository _productRepository = new ProductRepository();
        private StockInDetailRepository _stockInDetailRepository = new StockInDetailRepository();
        private SupplierRepository _supplierRepository = new SupplierRepository();
        private frmMain _frmForm;

        public frmStockInProductReports(frmMain frmForm)
        {
            InitializeComponent();

            dGWProduct.AutoGenerateColumns = false;
            dGWProduct.Columns["Edit"].Visible = false;
            dGWProduct.Columns["Delete"].Visible = false;
            _frmForm = frmForm;
        }

        private void txtProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var criterion = txtProductSearch.Text.ToLower();
                //var productList = _productRepository.GetWhereUrunDialogSearchWithStock(x => x.ProductName.ToLower().Contains(criterion) || x.ProductBarcode.Contains(criterion) || x.ProductCode.Contains(criterion));
                var beginDate = dTPBeginDate.Value;
                var newBeginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
                var endDate = dTPEndDate.Value;
                var newEndDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 23, 59, 59);

                var stockInList = _stockInRepository.GetAllProductsInStock(beginDate, endDate, criterion);

                dGWProduct.DataSource = stockInList;
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

            //var stockInList = _stockInRepository.GetBetweenDates(m => m.StockInDate >= beginDate && m.StockInDate <= endDate);
            var criterion = txtProductSearch.Text.ToLower();
            var stockInList = _stockInRepository.GetAllProductsInStock(beginDate, endDate, criterion);
            dGWProduct.DataSource = stockInList;
            dGWProduct.Refresh();

        }

        private void frmStockInProductReports_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            dTPBeginDate.Value = new DateTime(today.Year, today.Month, 1);
            dTPEndDate.Value = today;
        }



        private void tSMIProductStockInDetail_Click(object sender, EventArgs e)
        {
            int stockInId = int.Parse(dGWProduct["StockInId", dGWProduct.SelectedRows[0].Index].Value.ToString());
            int rowId = dGWProduct.SelectedRows[0].Index;
            var stockIn = _stockInRepository.GetById(stockInId);

            var products = _productRepository.GetAllUrunGiris();
            var suppliers = _supplierRepository.GetAllSupplier();

            var stockInDetails = _stockInDetailRepository.GetStockInDetailsbyStockId(stockInId);

            frmStockInDetailList _frmStockInDetailList = new frmStockInDetailList();
            _frmStockInDetailList.cmBoxSupplier.DisplayMember = "SupplierName";
            _frmStockInDetailList.cmBoxSupplier.ValueMember = "Id";
            _frmStockInDetailList.cmBoxSupplier.DataSource = suppliers;

            _frmStockInDetailList.cmBoxSupplier.SelectedValue = stockIn.SupplierId;
            _frmStockInDetailList.txtStockInRefNo.Text = stockIn.StockInRefNo;
            _frmStockInDetailList.dtTimeInputDate.Value = stockIn.StockInDate;


            _frmStockInDetailList.dGWProduct.DataSource = products;
            _frmStockInDetailList.oldStokDetay = stockInDetails;
            _frmStockInDetailList.dGWStockInDetail.DataSource = _frmStockInDetailList.oldStokDetay;

            _frmStockInDetailList.btnSave.Enabled = false;
            _frmStockInDetailList.btnUpdate.Enabled = true;
            _frmStockInDetailList.IsUpdate = true;
            //_frmStockInDetailList.TopLevel = false;
            //_frmStockInDetailList.Dock = DockStyle.Fill;
            _frmStockInDetailList.stockInListId = stockInId;

            //_frmForm.pnlMain.Controls.Clear();
            //_frmForm.pnlMain.Controls.Add(_frmStockInDetailList);
            _frmStockInDetailList.FormBorderStyle = FormBorderStyle.FixedSingle;
            _frmStockInDetailList.ControlBox = true;
            //_frmStockInDetailList.
            _frmStockInDetailList.BringToFront();
            _frmStockInDetailList.Show();


        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
