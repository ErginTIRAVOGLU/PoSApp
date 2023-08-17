using PoSApp.BLL.Repositories.Abstract;
using PoSApp.BLL.Repositories.Concrete;
using PoSApp.Desktop.Forms.ProductForms;
using PoSApp.Desktop.Forms.StockInForms;
using PoSApp.Entities.Enums;
using PoSApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoSApp.Desktop.Forms.RaportForms
{
    public partial class frmStockInProductReports : Form
    {

        private StockInRepository _stockInRepository = new StockInRepository();
        private BrandRepository _brandRepository = new BrandRepository();
        private CategoryRepository _categoryRepository = new CategoryRepository();
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
                filtrele();
            }
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            filtrele();
        }

        public void filtrele()
        {
            var criterion = txtProductSearch.Text.ToLower();
            //var productList = _productRepository.GetWhereUrunDialogSearchWithStock(x => x.ProductName.ToLower().Contains(criterion) || x.ProductBarcode.Contains(criterion) || x.ProductCode.Contains(criterion));
            var beginDate = dTPBeginDate.Value;
            var newBeginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            var endDate = dTPEndDate.Value;
            var newEndDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 23, 59, 59);

            if (chkBProductGroup.Checked)
            {

            }
            else
            {
                var stockInList = _stockInRepository.GetAllProductsInStock(beginDate, endDate, criterion);

                dGWProduct.DataSource = stockInList.ProductsInStockListDto;
                dGWProduct.Refresh();
                lblTotalAmount.Text = stockInList.TotalAmount.ToString("0.00") + " TL";
            }


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
            _frmStockInDetailList.oldStokDetay = stockInDetails.stockInDetailListDto;
            _frmStockInDetailList.totalAmount = stockInDetails.totalPriceAmount;
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

        private void tSMIProductDetail_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(dGWProduct.SelectedRows[0].Cells["ProductId"].Value.ToString());

            var p = _productRepository.GetByIdWithStockNumber(productId);
            var brands = _brandRepository.GetAll();
            var categories = _categoryRepository.GetAll();

            frmProduct _frmProduct = new frmProduct(this);
            _frmProduct.txtProduct.Text = p.product.ProductName;
            _frmProduct.txtCode.Text = p.product.ProductCode;
            _frmProduct.txtDescription.Text = p.product.ProductDescription;
            _frmProduct.txtBarcode.Text = p.product.ProductBarcode;
            decimal totalStock = 0.0M;
            decimal.TryParse(p.NetProductAmountInStock.ToString(), out totalStock);
            _frmProduct.lblStok.Text = p.product.ProductUnitType == ProductUnitType.Quantity ? totalStock.ToString("0") : totalStock.ToString("0.0000");
            _frmProduct.txtProductPrice.Text = p.product.ProductUnitType == ProductUnitType.Quantity ? p.product.ProductPrice.ToString("0.00") : p.product.ProductPrice.ToString("0.0000");// p.product.ProductPrice.ToString("N4", CultureInfo.CreateSpecificCulture("tr-TR"));

            _frmProduct.cmBoxBrand.DisplayMember = "BrandName";
            _frmProduct.cmBoxBrand.ValueMember = "Id";
            _frmProduct.cmBoxBrand.DataSource = brands;
            _frmProduct.cmBoxBrand.SelectedValue = p.product.BrandId;

            _frmProduct.cmBoxCategory.DisplayMember = "CategoryName";
            _frmProduct.cmBoxCategory.ValueMember = "Id";
            _frmProduct.cmBoxCategory.DataSource = categories;
            _frmProduct.cmBoxCategory.SelectedValue = p.product.CategoryID;

            _frmProduct.txtVat.Text = p.product.ProductVat.ToString();

            _frmProduct.cmBoxProductUnitType.DataSource = Enum.GetValues(typeof(ProductUnitType))
                    .Cast<Enum>()
                    .Select(value => new
                    {
                        (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                        value
                    })
                    .OrderBy(item => item.value)
                    .ToList();
            _frmProduct.cmBoxProductUnitType.DisplayMember = "Description";
            _frmProduct.cmBoxProductUnitType.ValueMember = "value";

            _frmProduct.cmBoxProductUnitType.SelectedValue = p.product.ProductUnitType;

            _frmProduct.productId = productId;
            _frmProduct.IsUpdate = true;
            _frmProduct.ShowDialog();
        }
    }

}
