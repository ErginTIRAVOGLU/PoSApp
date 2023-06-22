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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PoSApp.Desktop.Forms.ProductForms
{
    public partial class frmProduct : Form
    {
        private ProductRepository _productRepository = new ProductRepository();
        private BrandRepository _brandRepository = new BrandRepository();
        private CategoryRepository _categoryRepository = new CategoryRepository();
        private frmProductList _frmProductList;
        public int productId;
        public bool IsUpdate;

        public frmProduct(frmProductList frmProductList)
        {
            InitializeComponent();
            _frmProductList = frmProductList;
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

            var durum = _productRepository.Insert(new Product()
            {
                ProductName = txtProduct.Text,
                BrandId = int.Parse(cmBoxBrand.SelectedValue.ToString()),
                CategoryID = int.Parse(cmBoxCategory.SelectedValue.ToString()),
                ProductUnitType = (Entities.Enums.ProductUnitType)cmBoxProductUnitType.SelectedValue,
                CreatedDate = DateTime.Now,
                ProductBarcode = txtBarcode.Text,
                ProductCode = txtCode.Text,
                ProductPrice = pprice,
                ProductDescription = txtDescription.Text,
                IsDeleted = false,
                //ProductUnitType = int.Parse(cmBoxProductUnitType.SelectedValue.ToString())

            });
            temizle();
            _frmProductList.yukle();
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
            var product = _productRepository.GetById(productId);
            product.ProductName = txtProduct.Text;
            var durum = _productRepository.Update(product);
            temizle();
            _frmProductList.yukle();
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
