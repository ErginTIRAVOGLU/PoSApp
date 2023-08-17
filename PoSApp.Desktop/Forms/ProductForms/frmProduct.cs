using PoSApp.BLL.Repositories.Abstract;
using PoSApp.BLL.Repositories.Concrete;
using PoSApp.Entities;
using PoSApp.Desktop.Forms.BrandForms;
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
using PoSApp.Entities.Enums;
using PoSApp.Desktop.Forms.RaportForms;

namespace PoSApp.Desktop.Forms.ProductForms
{
    public partial class frmProduct : Form
    {
        private ProductRepository _productRepository = new ProductRepository();
        private BrandRepository _brandRepository = new BrandRepository();
        private CategoryRepository _categoryRepository = new CategoryRepository();
        private frmProductList _frmProductList;
        frmStockInProductReports _frmStockInProductReports;
        public int productId;
        public bool IsUpdate;

        public frmProduct(frmProductList frmProductList)
        {
            InitializeComponent();
            _frmProductList = frmProductList;
        }

        public frmProduct(frmStockInProductReports frmStockInProductReports)
        {
            InitializeComponent();
            _frmStockInProductReports = frmStockInProductReports;
        }

        public frmProduct()
        {
            InitializeComponent();

        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                btnUpdate.Visible = true;
                btnSave.Visible = false;
            }
            else
            {
                btnUpdate.Visible = false;
                btnSave.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal pprice = 0;
            decimal.TryParse(txtProductPrice.Text, out pprice);

            int Vat = 0;
            int.TryParse(txtVat.Text, out Vat);


            var durum = _productRepository.Insert(new Product()
            {
                ProductName = txtProduct.Text,
                BrandId = int.Parse(cmBoxBrand.SelectedValue.ToString()),
                CategoryID = int.Parse(cmBoxCategory.SelectedValue.ToString()),
                ProductUnitType = (Entities.Enums.ProductUnitType)cmBoxProductUnitType.SelectedValue,
                ProductBarcode = txtBarcode.Text,
                ProductCode = txtCode.Text,
                ProductPrice = pprice,
                ProductDescription = txtDescription.Text,
                ProductVat = Vat

                //ProductUnitType = int.Parse(cmBoxProductUnitType.SelectedValue.ToString())

            });
            temizle();
            if (_frmProductList != null)
            {
                _frmProductList.yukle();
            }
            if (_frmStockInProductReports != null)
            {
                _frmStockInProductReports.filtrele();
            }
            this.Close();
        }

        private void temizle()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtProduct.Clear();
            txtProduct.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal pprice = 0;
            decimal.TryParse(txtProductPrice.Text, out pprice);

            int Vat = 0;
            int.TryParse(txtVat.Text, out Vat);

            var product = _productRepository.GetById(productId);

            product.ProductName = txtProduct.Text;
            product.BrandId = int.Parse(cmBoxBrand.SelectedValue.ToString());
            product.CategoryID = int.Parse(cmBoxCategory.SelectedValue.ToString());
            product.ProductUnitType = (ProductUnitType)cmBoxProductUnitType.SelectedValue;
            product.ProductBarcode = txtBarcode.Text;
            product.ProductCode = txtCode.Text;
            product.ProductPrice = pprice;
            product.ProductDescription = txtDescription.Text;
            product.ProductVat = Vat;
            var durum = _productRepository.Update(product);
            temizle();
            if (_frmProductList != null)
            {
                _frmProductList.yukle();
            }
            if (_frmStockInProductReports != null)
            {
                _frmStockInProductReports.filtrele();
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtProductPrice_Validating(object sender, CancelEventArgs e)
        {
            decimal value = 0;
            decimal.TryParse(txtProductPrice.Text, NumberStyles.Currency, null, out value);

            if (!string.IsNullOrEmpty(value.ToString()))
            {
                txtProductPrice.Text = value.ToString();
            }
            else
            {
                // Notify the user somehow
                e.Cancel = true;
            }
        }
    }
}
