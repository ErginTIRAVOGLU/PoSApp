﻿using Microsoft.EntityFrameworkCore;
using PoSApp.BLL.Repositories.Abstract;
using PoSApp.BLL.Repositories.Concrete;
using PoSApp.Entities;
using PoSApp.Entities.Enums;
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

namespace PoSApp.Desktop.Forms.StockInForms
{
    public partial class frmStockInDetailList : Form
    {
        private ProductRepository _productRepository = new ProductRepository();
        private StockInRepository _stockInRepository = new StockInRepository();
        private StockInDetailRepository _stockInDetailRepository = new StockInDetailRepository();

        public List<StockInDetailListDTO> stokDetay;
        public IEnumerable<StockInDetailListDTO> oldStokDetay;
        private StockIn _stockIn;
        private StockInDetail _stockInDetail;

        public int stockInListId;
        public bool IsUpdate;

        public decimal totalAmount = 0;

        public frmStockInDetailList()
        {
            InitializeComponent();
            dGWStockInDetail.AutoGenerateColumns = false;
        }

        public void yukle()
        {

            var productList = _productRepository.GetAllUrunGiris();

            dGWProduct.DataSource = productList;
            dGWProduct.Refresh();


            if (!IsUpdate)
            {
                stokDetay = new List<StockInDetailListDTO>();
            }
            else
            {
                stokDetay = (List<StockInDetailListDTO>)oldStokDetay;
            }
            dGWStockInDetail.DataSource = stokDetay;
            dGWStockInDetail.Refresh();
            lblToplamTutar.Text = totalAmount.ToString("0.00") + " TL";

        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            formClose(sender, e);
        }

        private void dGWProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dGWProduct.Columns[e.ColumnIndex].Name;
            int productId = int.Parse(dGWProduct["Id", e.RowIndex].Value.ToString());


            switch (colName)
            {
                case "Select":

                    Product _product = _productRepository.GetById(productId);
                    _stockInDetail = new StockInDetail();


                    frmAddStock _frmAddStock = new frmAddStock();
                    DialogResult dialogResult = _frmAddStock.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        var source = new BindingSource();
                        StockInDetailListDTO stockInDetailListDTO = new StockInDetailListDTO();
                        stockInDetailListDTO.ProductId = _product.Id;
                        stockInDetailListDTO.ProductName = _product.ProductName;
                        stockInDetailListDTO.ProductCode = _product.ProductCode;
                        stockInDetailListDTO.StockInDetailUnit = _frmAddStock.productQuantity;
                        stockInDetailListDTO.ProductWarehouseId = _frmAddStock.warehouseId;
                        stockInDetailListDTO.DepoAdi = _frmAddStock.warehouseName;

                        stockInDetailListDTO.ProductArrivalPrice = _frmAddStock.productArrivalPrice;
                        stockInDetailListDTO.ProductDiscountPercentage = _frmAddStock.productDiscountPercentage;
                        stockInDetailListDTO.ProductUnitDiscountAmount = _frmAddStock.productUnitDiscountAmount;
                        stockInDetailListDTO.ProductTotalDiscountAmount = _frmAddStock.productTotalDiscountAmount;
                        stockInDetailListDTO.ProductTotalVatAmount = _frmAddStock.productTotalVatAmount;
                        stockInDetailListDTO.ProductLastPriceWithoutVat = _frmAddStock.productLastPriceWithoutVat;
                        stockInDetailListDTO.ProductLastPriceWithVat = _frmAddStock.productLastPriceWithVat;

                        stokDetay.Add(stockInDetailListDTO);
                        source.DataSource = stokDetay;
                        dGWStockInDetail.DataSource = source;
                        lblToplamTutar.Text = totalAmount.ToString("0.00")+" TL";
                    }
                    break;
                default:
                    break;
            }
        }





        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStockInRefNo.Text) || int.Parse(cmBoxSupplier.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Ref numarası ve/veya tedarikçiyi kontrol edin.");
            }
            else
            {
                var stockIn = _stockInRepository.GetById(stockInListId);
                stockIn.StockInDate = dtTimeInputDate.Value;
                stockIn.SupplierId = int.Parse(cmBoxSupplier.SelectedValue.ToString());
                stockIn.StockInRefNo = txtStockInRefNo.Text;
                _stockInRepository.Update(stockIn);


                foreach (var item in stokDetay)
                {
                    if (item.Id == 0)
                    {
                        _stockInDetail = new StockInDetail();
                        _stockInDetail.StockInId = stockInListId;
                        _stockInDetail.ProductId = item.ProductId;
                        _stockInDetail.StockInDetailUnit = item.StockInDetailUnit;
                        _stockInDetail.WarehouseId = item.ProductWarehouseId;

                        _stockInDetail.ProductArrivalPrice = item.ProductArrivalPrice;
                        _stockInDetail.ProductDiscountPercentage = item.ProductDiscountPercentage;
                        _stockInDetail.ProductUnitDiscountAmount = item.ProductUnitDiscountAmount;
                        _stockInDetail.ProductTotalDiscountAmount = item.ProductTotalDiscountAmount;
                        _stockInDetail.ProductTotalVatAmount = item.ProductTotalVatAmount;
                        _stockInDetail.ProductLastPriceWithoutVat = item.ProductLastPriceWithoutVat;
                        _stockInDetail.ProductLastPriceWithVat = item.ProductLastPriceWithVat;
                        _stockInDetailRepository.Insert(_stockInDetail);
                    }
                    else
                    {
                        _stockInDetail = _stockInDetailRepository.GetById(item.Id);

                        //_stockInDetail.StockInId = stockInListId;
                        //_stockInDetail.ProductId = item.ProductId;
                        _stockInDetail.StockInDetailUnit = item.StockInDetailUnit;
                        _stockInDetail.WarehouseId = item.ProductWarehouseId;

                        _stockInDetail.ProductArrivalPrice = item.ProductArrivalPrice;
                        _stockInDetail.ProductDiscountPercentage = item.ProductDiscountPercentage;
                        _stockInDetail.ProductUnitDiscountAmount = item.ProductUnitDiscountAmount;
                        _stockInDetail.ProductTotalDiscountAmount = item.ProductTotalDiscountAmount;
                        _stockInDetail.ProductTotalVatAmount = item.ProductTotalVatAmount;
                        _stockInDetail.ProductLastPriceWithoutVat = item.ProductLastPriceWithoutVat;
                        _stockInDetail.ProductLastPriceWithVat = item.ProductLastPriceWithVat;
                        _stockInDetailRepository.Update(_stockInDetail);

                    }
                }
                var list = _stockInDetailRepository.GetStockInDetailsbyStockId(stockInListId);
                oldStokDetay = list.stockInDetailListDto;
                totalAmount = list.totalPriceAmount;


                yukle();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            formClose(sender, e);


        }
        private void formClose(object sender, EventArgs e)
        {

            if (this.Parent != null)
            {
                if (this.Parent.Parent != null)
                {
                    frmMain frm = (frmMain)this.Parent.Parent;
                    frm.btnStockIn_Click(sender, e);
                }
            }
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStockInRefNo.Text) || int.Parse(cmBoxSupplier.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Ref numarası ve/veya tedarikçiyi kontrol edin.");
            }
            else
            {
                _stockIn = new StockIn();
                _stockIn.StockInDate = dtTimeInputDate.Value;
                _stockIn.StockInRefNo = txtStockInRefNo.Text;
                _stockIn.SupplierId = int.Parse(cmBoxSupplier.SelectedValue.ToString());
                _stockInRepository.Insert(_stockIn);
                stockInListId = _stockIn.Id;

                foreach (var item in stokDetay)
                {
                    _stockInDetail = new StockInDetail();
                    _stockInDetail.StockInId = _stockIn.Id;
                    _stockInDetail.ProductId = item.ProductId;
                    _stockInDetail.StockInDetailUnit = item.StockInDetailUnit;
                    _stockInDetail.WarehouseId = item.ProductWarehouseId;
                    _stockInDetail.ProductArrivalPrice = item.ProductArrivalPrice;
                    _stockInDetail.ProductDiscountPercentage = item.ProductDiscountPercentage;
                    _stockInDetail.ProductUnitDiscountAmount = item.ProductUnitDiscountAmount;
                    _stockInDetail.ProductTotalDiscountAmount = item.ProductTotalDiscountAmount;
                    _stockInDetail.ProductTotalVatAmount = item.ProductTotalVatAmount;
                    _stockInDetail.ProductLastPriceWithoutVat = item.ProductLastPriceWithoutVat;
                    _stockInDetail.ProductLastPriceWithVat = item.ProductLastPriceWithVat;
                    _stockInDetailRepository.Insert(_stockInDetail);
                }
                IsUpdate = true;
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                var list = _stockInDetailRepository.GetStockInDetailsbyStockId(stockInListId);
                oldStokDetay = list.stockInDetailListDto;
                totalAmount = list.totalPriceAmount;
                yukle();

            }

        }

        private void dGWStockInDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dGWStockInDetail.Columns[e.ColumnIndex].Name;
            int rowId = e.RowIndex;
            if (rowId > 0)
            {
                var stockInDetailId = int.Parse(dGWStockInDetail.Rows[e.RowIndex].Cells["detailId"].Value.ToString());

                switch (colName)
                {

                    case "detailDelete":

                        if (stockInDetailId != 0)
                        {
                            var stockInDetail = _stockInDetailRepository.GetById(stockInDetailId);
                            _stockInDetailRepository.Delete(stockInDetail);


                            oldStokDetay = oldStokDetay.Where(m => m.Id != stockInDetail.Id).ToList();

                            yukle();
                        }
                        else
                        {
                            dGWStockInDetail.Rows.RemoveAt(rowId);
                        }

                        break;
                    default:
                        break;
                }
            }
        }




        private void frmStockInDetailList_Load(object sender, EventArgs e)
        {

            yukle();
        }



        private void txtProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var criterion = txtProductSearch.Text.ToLower();
                var productList = _productRepository.GetWhereUrunGiris(x => x.ProductName.ToLower().Contains(criterion) || x.ProductBarcode.Contains(criterion) || x.ProductCode.Contains(criterion));


                dGWProduct.DataSource = productList;
                dGWProduct.Refresh();
            }
        }
    }
}
