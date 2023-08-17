using PoSApp.BLL.Repositories.Abstract;
using PoSApp.BLL.Repositories.Concrete;
using PoSApp.Entities;
using PoSApp.Entities.Enums;
using PoSApp.Desktop.Forms.BrandForms;
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

namespace PoSApp.Desktop.Forms.PosForms
{
    public partial class frmPos : Form
    {
        private CartRepository _cartRepository = new CartRepository();
        private CartDetailRepository _cartDetailRepository = new CartDetailRepository();
        private ProductRepository _productRepository = new ProductRepository();
        private PayedAmountRepository _payedAmountRepository = new PayedAmountRepository();

        public List<CartDetailList> oldCartDetail;
        public int _cartId { get; set; } = 0;
        public decimal _priceTotal { get; set; }
        public decimal _vat { get; set; }
        public decimal _discount { get; set; }
        public decimal _price { get; set; }
        public decimal _payedAmount { get; set; }
        private string _transNo { get; set; }

        public frmPos()
        {
            InitializeComponent();
            this.KeyPreview = true;
            lblDate.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();

            oldCartDetail = new List<CartDetailList>();
        }


        private void GetTransNo(DateTime Tarih)
        {
            _transNo = _cartRepository.GetTransNo(Tarih);
            txtTransNo.Text = _transNo;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPos_Load(object sender, EventArgs e)
        {
            lockTheButtons();
        }

        private void lockTheButtons()
        {
            btnProductList.Enabled = false;
            btnDiscount.Enabled = false;
            btnSettle.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void unlockTheButtons()
        {
            btnProductList.Enabled = true;
            btnDiscount.Enabled = true;
            btnSettle.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearAll();
            GetTransNo(dTPickerCart.Value);
            unlockTheButtons();

            txtProductSearch.Enabled = true;
            txtProductSearch.Focus();
            this.ActiveControl = txtProductSearch;

            totalCalculate();

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    btnNew_Click(null, null);
                    break;
                case Keys.F2:
                    btnProductList_Click(null, null);
                    break;
                case Keys.F3:
                    btnDiscount_Click(null, null);
                    break;
                case Keys.F4:
                    btnSettle_Click(null, null);
                    break;
                case Keys.F5:
                    btnCancel_Click(null, null);
                    break;
                case Keys.F6:
                    btnSales_Click(null, null);
                    break;


                case Keys.Escape:
                    btnExit_Click(null, null);
                    break;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void txtProductSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var criterion = txtProductSearch.Text.ToLower();
                var productList = _productRepository.GetWhereUrunDialogSearchWithStock(x => x.ProductName.ToLower().Contains(criterion) || x.ProductBarcode.Contains(criterion) || x.ProductCode.Contains(criterion)).ToList();

                var count = productList.Count;

                var returnedProductId = 0;
                var returnedProductQuantity = 0;

                if (count > 0)
                {

                    frmProductList _frmProductList = new frmProductList(productList);
                    _frmProductList.dGWProduct.Columns["Edit"].Visible = false;
                    _frmProductList.dGWProduct.Columns["Delete"].Visible = false;
                    _frmProductList.StartPosition = FormStartPosition.CenterScreen;
                    _frmProductList.WindowState = FormWindowState.Normal;
                    var productReturnDialog = _frmProductList.ShowDialog();

                    if (productReturnDialog == DialogResult.OK)
                    {
                        returnedProductId = _frmProductList.returnProductId;
                        var returnedProductName = _frmProductList.returnProductName;
                        var returnedProductPrice = _frmProductList.returnProductPrice;
                        var returnedProductUnitType = _frmProductList.returnProductUnitType;
                        var returnedProductVat = _frmProductList.returnProductVat;

                        frmQuantity _frmQuantity = new frmQuantity();
                        var quantityReturnDialog = _frmQuantity.ShowDialog();

                        if (quantityReturnDialog == DialogResult.OK)
                        {
                            returnedProductQuantity = _frmQuantity.returnQuantity;
                            var total = returnedProductPrice * returnedProductQuantity;

                            oldCartDetail.Add(new CartDetailList()
                            {
                                Description = returnedProductName,
                                Quantity = returnedProductQuantity,
                                CartDetailUnitType = returnedProductUnitType == ProductUnitType.Quantity ? "Adet" : "Gram",
                                Discount = 0,
                                Price = returnedProductUnitType == ProductUnitType.Quantity ? decimal.Parse(returnedProductPrice.ToString("0.00")): returnedProductPrice,
                                Vat = returnedProductVat,
                                Total = decimal.Parse(total.ToString("0.00")),
                                ProductId = returnedProductId
                            });

                            FillGridView();
                            totalCalculate();

                        }
                        else if (quantityReturnDialog == DialogResult.Abort)
                        {
                            txtProductSearch.Focus();
                        }
                    }
                    else if (productReturnDialog == DialogResult.Abort)
                    {
                        txtProductSearch.Focus();
                    }


                    //}



                }
                else
                {
                    MessageBox.Show("Ürün Bulunamadı!");
                }

            }
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            frmProductList _frmProductList = new frmProductList(null, this);
            _frmProductList.dGWProduct.Columns["Edit"].Visible = false;
            _frmProductList.dGWProduct.Columns["Delete"].Visible = false;
            _frmProductList.StartPosition = FormStartPosition.CenterScreen;
            _frmProductList.WindowState = FormWindowState.Normal;
            _frmProductList.quickMode = false;
            var productReturnDialog = _frmProductList.ShowDialog();
        }

        public void AddToPos(int returnedProductId, string returnedProductName, decimal returnedProductPrice, decimal returnedProductQuantity, ProductUnitType returnedProductUnitType, int returnedVat)
        {
            var total = returnedProductPrice * returnedProductQuantity;
            oldCartDetail.Add(new CartDetailList()
            {
                Description = returnedProductName,
                Quantity = returnedProductQuantity,
                CartDetailUnitType = returnedProductUnitType == ProductUnitType.Quantity ? "Adet" : "Gram",
                Discount = 0,
                Price = returnedProductUnitType == ProductUnitType.Quantity ? decimal.Parse(returnedProductPrice.ToString("0.00")): returnedProductPrice,
                Vat = returnedVat,
                Total = decimal.Parse(total.ToString("0.00")),
                ProductId = returnedProductId


            });

            FillGridView();

            totalCalculate();
        }

        private void FillGridView()
        {
            var source = new BindingSource();
            source.DataSource = oldCartDetail;
            dGWCartDetail.DataSource = source;
        }


        private void totalCalculate()
        {


            var payedAmount = _payedAmountRepository.GetTotalPayedAmount(_transNo);
            _payedAmount = payedAmount;
            decimal totalPrice = 0;
            decimal totalVat = 0;
            decimal productTotalPrice = 0;
            decimal vatRatio = 0;
            decimal subPrice = 0;
            decimal totalDiscount = 0;

            foreach (var item in oldCartDetail)
            {
                productTotalPrice = item.Price * item.Quantity;
                vatRatio = decimal.Parse(item.Vat.ToString()) / 100;
                totalPrice = totalPrice + productTotalPrice;
                totalVat = totalVat + (productTotalPrice - (productTotalPrice / (1 + vatRatio)));
                totalDiscount = totalDiscount + (item.Discount * item.Quantity);
            }


            subPrice = totalPrice - totalVat;
            _price = subPrice;
            lblSubTotal.Text = subPrice.ToString("C");
            lblDiscount.Text = totalDiscount.ToString("C");
            _discount = totalDiscount;
            lblVAT.Text = totalVat.ToString("C");
            _vat = totalVat;

            lblTotal.Text = totalPrice.ToString("C");
            _priceTotal = totalPrice;
            lblDisplayTotal.Text = totalPrice.ToString("C");
            lblPayedAmount.Text = payedAmount.ToString("C");

        }

        private void dGWCartDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dGWCartDetail.Columns[e.ColumnIndex].Name;
            switch (colName)
            {
                case "Delete":
                    if (MessageBox.Show("Ürünü silmek istediğinizden emin misiniz?", "Ürün Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var selectedRowIndex = e.RowIndex;
                        if (oldCartDetail[selectedRowIndex].Id == 0)
                        {
                            oldCartDetail.RemoveAt(selectedRowIndex);
                        }
                        else
                        {
                            var cartDetail = _cartDetailRepository.GetById(oldCartDetail[selectedRowIndex].Id);
                            _cartDetailRepository.Delete(cartDetail);
                            oldCartDetail.RemoveAt(selectedRowIndex);
                        }

                        FillGridView();
                        totalCalculate();
                    }


                    break;
                default:
                    break;
            }

        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            if (dGWCartDetail.SelectedRows.Count > 0)
            {
                var selectedRowIndex = dGWCartDetail.Rows.IndexOf(dGWCartDetail.SelectedRows[0]);
                var selectedPrice = oldCartDetail[selectedRowIndex].Price;
                var selectedDiscount = oldCartDetail[selectedRowIndex].Discount;
                int outSelectedProductId = 0;
                outSelectedProductId = oldCartDetail[selectedRowIndex].ProductId;
                var productListPrice = _productRepository.GetById(outSelectedProductId).ProductPrice;
                decimal percentage = 0;
                if (selectedPrice == 0 || productListPrice == 0)
                {
                    percentage = 0;
                }
                else
                {
                    percentage = 100 - (100 * selectedPrice) / productListPrice;
                }
                var pPercentage = 0;
                int.TryParse(Math.Floor(percentage).ToString(), out pPercentage);

                frmDiscount _frmDiscount = new frmDiscount();
                _frmDiscount.txtPrice.Text = selectedPrice.ToString();

                _frmDiscount.txtPercentage.Text = pPercentage.ToString();
                _frmDiscount.txtTotalDiscount.Text = selectedDiscount.ToString();
                _frmDiscount.txtListPrice.Text = productListPrice.ToString("N4");
                DialogResult result = _frmDiscount.ShowDialog();
                if (result == DialogResult.OK)
                {

                    var discountPrice = _frmDiscount._totalDiscount;
                    var price = _frmDiscount._price;
                    oldCartDetail[selectedRowIndex].Price = price;
                    var quantity = oldCartDetail[selectedRowIndex].Quantity;
                    var totalPrice = (price * quantity);



                    oldCartDetail[selectedRowIndex].Price = decimal.Parse(price.ToString("N4"));
                    oldCartDetail[selectedRowIndex].Discount = decimal.Parse(discountPrice.ToString("N4"));
                    oldCartDetail[selectedRowIndex].Total = decimal.Parse(totalPrice.ToString("N4"));
                    totalCalculate();
                    FillGridView();
                }
                else
                {

                }

            }
            else
            {
                MessageBox.Show("Önce indirim yapılacak ürünü seçin.");
            }
        }

        private void dGWCartDetail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Ürünü silmek istediğinizden emin misiniz?", "Ürün Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var selectedRowIndex = dGWCartDetail.SelectedRows[0].Index;
                    oldCartDetail.RemoveAt(selectedRowIndex);
                    FillGridView();
                    totalCalculate();
                }
            }
        }

        private void btnSettle_Click(object sender, EventArgs e)
        {
            frmSettle _frmSettle = new frmSettle(this);
            _frmSettle._transNo = _transNo;

            //_frmSettle.txtSale.Text = decimal.Parse(_priceTotal.ToString()).ToString("N4");
            _frmSettle._saleAmount = _priceTotal;

            //_frmSettle.txtCash.Text = "";
            _frmSettle._cashAmount = 0;

            //_frmSettle.txtChange.Text = decimal.Parse("0").ToString("N4");
            _frmSettle._changeAmount = 0;

            _frmSettle.txtCash.Focus();
            _frmSettle.ShowDialog();
            FillGridView();
            totalCalculate();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var cart = _cartRepository.GetbyTransNo(_transNo);
            if (cart != null)
            {
                cart.Status = CartStatus.Canceled;
                _cartRepository.Update(cart);
            }


            txtProductSearch.Enabled = false;

            clearAll();
            lockTheButtons();

        }

        private void clearAll()
        {
            _cartId = 0;
            _priceTotal = 0;
            _payedAmount = 0;
            _transNo = "";
            txtTransNo.Clear();
            oldCartDetail.Clear();
            oldCartDetail = new List<CartDetailList>();
            FillGridView();
            totalCalculate();
        }

        internal int saveCart(CartStatus cartStatus, decimal payedAmount, PaymentType paymentType)
        {


            var totalPayment = 0;

            Cart cart = _cartRepository.GetbyTransNoNoInc(_transNo);
            if (cart == null)
            {
                cart = new Cart();
                cart.TransNo = _transNo;

                DateTime cartDate = DateTime.Now;
                DateTime.TryParse(lblDate.Text, out cartDate);
                cart.CartDate = cartDate;
                _cartRepository.Insert(cart);
            }

            cart.Status = cartStatus;

            cart.PayedAmounts.Add(new PayedAmount()
            {
                PayedType = paymentType,
                PriceTotal = payedAmount
            });


            decimal totalPrice = 0;
            decimal totalVat = 0;
            decimal productTotalPrice = 0;
            decimal vatRatio = 0;

            decimal totalDiscount = 0;
            foreach (var item in oldCartDetail)
            {
                productTotalPrice = item.Price;// *item.Quantity; //TODO kontrol
                vatRatio = decimal.Parse(item.Vat.ToString()) / 100;
                totalPrice = totalPrice + productTotalPrice;
                totalVat = totalVat + (productTotalPrice - (productTotalPrice / (1 + vatRatio)));
                totalDiscount = totalDiscount + (item.Discount * item.Quantity);
            }

            cart.PriceTotal = _priceTotal;

            cart.Vat = totalVat;
            cart.Price = totalPrice;
            cart.DiscountTotal = totalDiscount;





            foreach (var item in oldCartDetail.Where(m => m.Id == 0))
            {
                cart.CartDetails.Add(new CartDetail()
                {

                    DiscountTotal = item.Discount,
                    PriceTotal = item.Price * item.Quantity,
                    Price = item.Price,
                    Vat = item.Vat,
                    ProductUnit = item.Quantity,
                    ProductUnitType = item.CartDetailUnitType == "Adet" ? ProductUnitType.Quantity : ProductUnitType.Gram,
                    ProductDiscount = item.Discount,
                    ProductId = item.ProductId,
                    Description = item.Description


                });

            }

            CartDetail cartDetail = new CartDetail();
            foreach (var item in oldCartDetail.Where(m => m.Id != 0))
            {
                cartDetail = _cartDetailRepository.GetById(item.Id);
                cartDetail.DiscountTotal = item.Discount;
                cartDetail.ProductDiscount = item.Discount;
                cartDetail.PriceTotal = item.Price * item.Quantity;
                cartDetail.Price = item.Price;
                cartDetail.Vat = item.Vat;
                cartDetail.Description = item.Description;

                _cartDetailRepository.Update(cartDetail);
               

            }

          

            _cartRepository.Update(cart);
            oldCartDetail = _cartDetailRepository.GetAllSelectedbyTransNo(_transNo);
            if (cartStatus == CartStatus.Canceled)
            {
                lockTheButtons();
               

            }
            else if (cartStatus == CartStatus.Payed)
            {
                lockTheButtons();
                txtProductSearch.Enabled = false;
                

            }
            else if (cartStatus == CartStatus.Pending)
            {
                unlockTheButtons();
                FillGridView();
            }


            return cart.Id;
        }



        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmRecipt _frmRecipt = new frmRecipt();
            _frmRecipt._transNo = _transNo;
            _frmRecipt.LoadReport(_price.ToString("C"), _discount.ToString("C"), _vat.ToString("C"), _priceTotal.ToString("C"), _transNo);
            _frmRecipt.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmCart frm = new frmCart();
           
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                cartYukle(frm._transNo);
            }
            else if (result == DialogResult.Abort)
            {
                txtProductSearch.Focus();
            }
        }



        private void dTPickerCart_ValueChanged(object sender, EventArgs e)
        {
            lblDate.Text = dTPickerCart.Value.ToLongDateString() + " " + dTPickerCart.Value.ToLongTimeString();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            cartYukle(txtTransNo.Text);
        }

        private void cartYukle(string transNo)
        {
            _transNo = transNo;
            txtTransNo.Text = transNo;
            var cart = _cartRepository.GetbyTransNo(transNo);
            if (cart != null)
            {
                lblDate.Text = cart.CartDate.ToLongDateString() + " " + cart.CartDate.ToLongTimeString();
                dTPickerCart.Value = cart.CartDate;
                _cartId = cart.Id;
                oldCartDetail = new List<CartDetailList>();
                oldCartDetail = _cartDetailRepository.GetAllSelectedbyTransNo(transNo);
                txtProductSearch.Enabled = true;
                txtProductSearch.Focus();
                this.ActiveControl = txtProductSearch;
                FillGridView();
                totalCalculate();
                unlockTheButtons();
            }
        }



        private void btnUnLockTheButtons_Click(object sender, EventArgs e)
        {
            unlockTheButtons();
        }

        private void btnLockTheButtons_Click(object sender, EventArgs e)
        {
            lockTheButtons();
        }

        private void btnPosKaydet_Click(object sender, EventArgs e)
        {

            Cart cart = _cartRepository.GetbyTransNoNoInc(_transNo);
            if (cart == null)
            {
                cart = new Cart();
                cart.TransNo = _transNo;

                DateTime cartDate = DateTime.Now;
                DateTime.TryParse(lblDate.Text, out cartDate);
                cart.CartDate = cartDate;
                cart.Status = CartStatus.Pending;
                _cartRepository.Insert(cart);
            }
            decimal totalPrice = 0;
            decimal totalVat = 0;
            decimal productTotalPrice = 0;
            decimal vatRatio = 0;

            decimal totalDiscount = 0;
            foreach (var item in oldCartDetail)
            {
                productTotalPrice = item.Price;// *item.Quantity; //TO-DO kontrol
                vatRatio = decimal.Parse(item.Vat.ToString()) / 100;
                totalPrice = totalPrice + productTotalPrice;
                totalVat = totalVat + (productTotalPrice - (productTotalPrice / (1 + vatRatio)));
                totalDiscount = totalDiscount + (item.Discount * item.Quantity);
            }

            cart.PriceTotal = _priceTotal;

            cart.Vat = totalVat;
            cart.Price = totalPrice;
            cart.DiscountTotal = totalDiscount;





            foreach (var item in oldCartDetail.Where(m => m.Id == 0))
            {
                cart.CartDetails.Add(new CartDetail()
                {

                    DiscountTotal = item.Discount,
                    PriceTotal = item.Price * item.Quantity,
                    Price = item.Price,
                    Vat = item.Vat,
                    ProductUnit = item.Quantity,
                    ProductUnitType = item.CartDetailUnitType == "Adet" ? ProductUnitType.Quantity : ProductUnitType.Gram,
                    ProductDiscount = item.Discount,
                    ProductId = item.ProductId,
                    Description = item.Description


                });

            }

            CartDetail cartDetail = new CartDetail();
            foreach (var item in oldCartDetail.Where(m => m.Id != 0))
            {
                cartDetail = _cartDetailRepository.GetById(item.Id);
                cartDetail.DiscountTotal = item.Discount;
                cartDetail.ProductDiscount = item.Discount;
                cartDetail.PriceTotal = item.Price * item.Quantity;
                cartDetail.Price = item.Price;
                cartDetail.Vat = item.Vat;
                cartDetail.Description = item.Description;

                _cartDetailRepository.Update(cartDetail);


            }

            _cartRepository.Update(cart);
            oldCartDetail = _cartDetailRepository.GetAllSelectedbyTransNo(_transNo);

            unlockTheButtons();
            FillGridView();
        }

        private void txtProductSearch_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
