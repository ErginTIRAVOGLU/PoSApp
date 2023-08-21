using PoSApp.BLL.Repositories.Concrete;
using PoSApp.Desktop.Forms.ProductForms;
using PoSApp.Entities.Enums;
using PoSApp.Entities.Models;
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
    public partial class frmCartProductReports : Form
    {
        private StockInRepository _stockInRepository = new StockInRepository();
        private BrandRepository _brandRepository = new BrandRepository();
        private CategoryRepository _categoryRepository = new CategoryRepository();
        private ProductRepository _productRepository = new ProductRepository();
        private StockInDetailRepository _stockInDetailRepository = new StockInDetailRepository();
        private SupplierRepository _supplierRepository = new SupplierRepository();
        private CartDetailRepository _cartDetailRepository = new CartDetailRepository();
        private frmMain _frmForm;

        public frmCartProductReports(frmMain frmForm)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint |
               ControlStyles.ResizeRedraw |
               ControlStyles.ContainerControl |
               ControlStyles.OptimizedDoubleBuffer |
               ControlStyles.SupportsTransparentBackColor
               , true);
            dGWProduct.AutoGenerateColumns = false;
            dGWProductWithGroup.AutoGenerateColumns = false;
            List<ReportType> reportTypes = new List<ReportType>();
            reportTypes.Add(new ReportType() { Id = 1, Name = "Ürünleri Listele" });
            reportTypes.Add(new ReportType() { Id = 2, Name = "Ürünleri Grupla" });
            reportTypes.Add(new ReportType() { Id = 3, Name = "Aylara Göre Grupla" });
            cmBoxReportType.DisplayMember = "Name";
            cmBoxReportType.ValueMember = "Id";
            cmBoxReportType.DataSource = reportTypes;
            cmBoxReportType.SelectedIndex = 0;

            List<YearList> yearLists = new List<YearList>();
            for (int i = 2023; i < 2053; i++)
            {
                yearLists.Add(new YearList() { Id = i, Name = i.ToString() });
            }


            cmBoxYears.DisplayMember = "Name";
            cmBoxYears.ValueMember = "Id";
            cmBoxYears.DataSource = yearLists;
            cmBoxYears.SelectedIndex = 0;

            cmBoxYears.SelectedValue = DateTime.UtcNow.Year;

            _frmForm = frmForm;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter();
        }

        private void txtProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filter();
            }
        }
        public void filter()
        {
            var criterion = txtProductSearch.Text.ToLower();
            //var productList = _productRepository.GetWhereUrunDialogSearchWithStock(x => x.ProductName.ToLower().Contains(criterion) || x.ProductBarcode.Contains(criterion) || x.ProductCode.Contains(criterion));
            var beginDate = dTPBeginDate.Value;
            var newBeginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            var endDate = dTPEndDate.Value;
            var newEndDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 23, 59, 59);

            switch (cmBoxReportType.SelectedValue)
            {
                case 1:

                    var cartList = _cartDetailRepository.GetAllProductsInCart(beginDate, endDate, criterion);
                    dGWProduct.Visible = true;
                    dGWProductWithGroup.Visible = false;
                    dGWProductWithGroupbyMonth.Visible = false;
                    dGWProduct.Dock = DockStyle.Fill;
                    dGWProduct.DataSource = cartList.productsInCartListDto;
                    dGWProduct.Refresh();
                    lblTotalAmount.Text = cartList.TotalAmount.ToString("0.00") + " TL";
                    break;
                case 2:

                    var cartListWithGroup = _cartDetailRepository.GetAllProductsInCartWithGroup(beginDate, endDate, criterion);
                    dGWProduct.Visible = false;
                    dGWProductWithGroup.Visible = true;
                    dGWProductWithGroupbyMonth.Visible = false;
                    dGWProductWithGroup.Dock = DockStyle.Fill;
                    dGWProductWithGroup.DataSource = cartListWithGroup.ProductsInCartListDtoWithGroup;
                    dGWProductWithGroup.Refresh();
                    lblTotalAmount.Text = cartListWithGroup.TotalAmount.ToString("0.00") + " TL";
                    break;

                case 3:
                    var cartListWithGroupbyMonth = _cartDetailRepository.GetAllProductsInCartWithGroupbyMonths(int.Parse(cmBoxYears.SelectedValue.ToString()), criterion);

                    dGWProduct.Visible = false;
                    dGWProductWithGroup.Visible = false;
                    dGWProductWithGroupbyMonth.Visible = true;
                    dGWProductWithGroupbyMonth.Dock = DockStyle.Fill;
                    dGWProductWithGroupbyMonth.DataSource = cartListWithGroupbyMonth.ProductsInCartListDtoWithGroupbyMonths;
                    dGWProductWithGroupbyMonth.Refresh();
                    lblTotalAmount.Text = cartListWithGroupbyMonth.TotalAmount.ToString("0.00") + " TL";
                    break;
                default:
                    break;
            }


        }
        private void frmCartProductReports_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            dTPBeginDate.Value = new DateTime(today.Year, today.Month, 1);
            dTPEndDate.Value = today;
        }

        private void cmBoxReportType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmBoxReportType.SelectedIndex == 2)
            {
                lblYearSelect.Visible = true;
                cmBoxYears.Visible = true;

                dTPBeginDate.Visible = false;
                dTPEndDate.Visible = false;
                lblPickDate.Visible = false;
            }
            else
            {
                lblYearSelect.Visible = false;
                cmBoxYears.Visible = false;

                dTPBeginDate.Visible = true;
                dTPEndDate.Visible = true;
                lblPickDate.Visible = true;
            }
        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tSMIProductCartDetail_Click(object sender, EventArgs e)
        {

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
