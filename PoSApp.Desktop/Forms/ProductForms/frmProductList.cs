﻿using PoSApp.BLL.Repositories.Abstract;
using PoSApp.BLL.Repositories.Concrete;
using PoSApp.Entities;
using PoSApp.Entities.Enums;
using PoSApp.Desktop.Forms.PosForms;
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
    public partial class frmProductList : Form
    {
        private ProductRepository _productRepository = new ProductRepository();
        private BrandRepository _brandRepository = new BrandRepository();
        private CategoryRepository _categoryRepository = new CategoryRepository();

        private frmPos frmPos;
        public int returnProductId { get; set; }
        public string returnProductName { get; set; }
        public decimal returnProductPrice { get; set; }
        public int returnProductVat { get; set; }
        public ProductUnitType returnProductUnitType { get; set; }

        public bool productMode=false;

        public bool quickMode = true;

        public frmProductList(IEnumerable<ProductListDTOWithStock> _productListDTOs = null, frmPos _frmPos = null)
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

            if (_frmPos != null)
            {
                frmPos = _frmPos;
            }
            if (_productListDTOs != null)
            {


                yukle(_productListDTOs);
            }
            else
            {
                yukle();
            }
        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            var brands = _brandRepository.GetAll();
            var categories = _categoryRepository.GetAll();
            frmProduct _frmProduct = new frmProduct(this);
            _frmProduct.cmBoxBrand.DisplayMember = "BrandName";
            _frmProduct.cmBoxBrand.ValueMember = "Id";
            _frmProduct.cmBoxBrand.DataSource = brands;

            _frmProduct.cmBoxCategory.DisplayMember = "CategoryName";
            _frmProduct.cmBoxCategory.ValueMember = "Id";
            _frmProduct.cmBoxCategory.DataSource = categories;

            _frmProduct.cmBoxProductUnitType.DisplayMember = "Description";
            _frmProduct.cmBoxProductUnitType.ValueMember = "Value";
            _frmProduct.cmBoxProductUnitType.DataSource = Enum.GetValues(typeof(ProductUnitType))
                    .Cast<Enum>()
                    .Select(value => new
                    {
                        (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                        value
                    })
                    .OrderBy(item => item.value)
                    .ToList();
            _frmProduct.IsUpdate = false;
            _frmProduct.ShowDialog();
        }
        private void deleteProduct(int productId)
        {
            var product = _productRepository.GetById(productId);
            product.IsDeleted = true;
            product.DeletedDate = DateTime.Now;
            var durum = _productRepository.Update(product);
        }
        private void dGWProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dGWProduct.Columns[e.ColumnIndex].Name;
            int productId = int.Parse(dGWProduct["Id", e.RowIndex].Value.ToString());
            switch (colName)
            {
                case "Edit":
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
                    _frmProduct.txtProductPrice.Text = p.product.ProductPrice.ToString("N4", CultureInfo.CreateSpecificCulture("tr-TR"));

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
                    //_frmProduct.cmBoxProductUnitType.SelectedValue = ProductUnitType.Quantity;

                    _frmProduct.productId = productId;
                    _frmProduct.IsUpdate = true;
                    _frmProduct.ShowDialog();

                    break;
                case "Delete":
                    if (MessageBox.Show("Ürünü silmek istediğinizden emin misiniz?", "Ürün Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        deleteProduct(productId);
                        yukle();
                    }


                    break;
                default:
                    break;
            }
        }

        public void yukle()
        {

            var productList = _productRepository.GetAllSelectedWithStock();

            dGWProduct.DataSource = productList;
            dGWProduct.Refresh();

        }
        public void yukle(IEnumerable<ProductListDTOWithStock> productList)
        {


            dGWProduct.DataSource = productList;
            dGWProduct.Refresh();

        }

        private void dGWProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (!productMode)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    //this.DialogResult = DialogResult.OK;
                    dGWProduct.CurrentRow.Selected = true;
                    var productId = dGWProduct.SelectedRows[0].Cells["Id"].Value.ToString();
                    returnProductId = int.Parse(productId);
                    var product = _productRepository.GetById(returnProductId);
                    returnProductName = product.ProductName;
                    returnProductPrice = product.ProductPrice;
                    returnProductUnitType = product.ProductUnitType;
                    returnProductVat = product.ProductVat;
                    //productTotalPrice = item.Total;
                    //vatRatio = decimal.Parse(item.Vat.ToString()) / 100;
                    //productTotalPrice - (productTotalPrice / (1 + vatRatio))
                    e.Handled = true;
                    if (quickMode)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {

                        frmQuantity _frmQuantity = new frmQuantity();
                        var quantityReturnDialog = _frmQuantity.ShowDialog();
                        var returnedProductQuantity = 0;
                        if (quantityReturnDialog == DialogResult.OK)
                        {
                            returnedProductQuantity = _frmQuantity.returnQuantity;
                            frmPos.AddToPos(returnProductId, returnProductName, returnProductPrice, returnedProductQuantity, returnProductUnitType, returnProductVat);
                        }



                    }
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.DialogResult = DialogResult.Abort;
                    e.Handled = true;
                    this.Close();
                }
            }

        }

        private void dGWProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!productMode)
            { 
                dGWProduct.CurrentRow.Selected = true;
                var productId = dGWProduct.SelectedRows[0].Cells["Id"].Value.ToString();
                returnProductId = int.Parse(productId);
                var product = _productRepository.GetById(returnProductId);
                returnProductName = product.ProductName;
                returnProductPrice = product.ProductPrice;
                returnProductUnitType = product.ProductUnitType;
                returnProductVat = product.ProductVat;

                if (quickMode)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {

                    frmQuantity _frmQuantity = new frmQuantity();
                    var quantityReturnDialog = _frmQuantity.ShowDialog();
                    var returnedProductQuantity = 0;
                    if (quantityReturnDialog == DialogResult.OK)
                    {
                        returnedProductQuantity = _frmQuantity.returnQuantity;
                        frmPos.AddToPos(returnProductId, returnProductName, returnProductPrice, returnedProductQuantity, returnProductUnitType, returnProductVat);
                    }



                }
            }
        }

        private void dGWProduct_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int productId = int.Parse(dGWProduct["Id", dGWProduct.SelectedRows[0].Index].Value.ToString());
                if (MessageBox.Show("Ürünü silmek istediğinizden emin misiniz?", "Ürün Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    deleteProduct(productId);
                    yukle();
                }
            }
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
    }
}
