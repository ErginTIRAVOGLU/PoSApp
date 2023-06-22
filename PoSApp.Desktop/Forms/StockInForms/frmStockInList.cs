using PoSApp.BLL.Repositories.Abstract;
using PoSApp.BLL.Repositories.Concrete;
using PoSApp.Entities;
using PoSApp.Desktop.Forms.ProductForms;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoSApp.Desktop.Forms.StockInForms
{
    public partial class frmStockInList : Form
    {
        private StockInRepository _stockInRepository = new StockInRepository();
        private StockInDetailRepository _stockInDetailRepository = new StockInDetailRepository();
        private ProductRepository _productRepository = new ProductRepository();
        private SupplierRepository _supplierRepository = new SupplierRepository();
        private frmMain _frmForm;

        public frmStockInList(frmMain frmForm)
        {

            InitializeComponent();
            var beginDate = dTPBeginDate.Value;
            var newBeginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            var endDate = dTPEndDate.Value;
            var newEndDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 23, 59, 59);

            yukle(newBeginDate, newEndDate);
            _frmForm = frmForm;
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            var products = _productRepository.GetAllUrunGiris();
            var suppliers = _supplierRepository.GetAllSupplier();

            frmStockInDetailList _frmStockInDetailList = new frmStockInDetailList();
            suppliers.Insert(0, new Supplier() { Id = 0, SupplierName = "Seç" });
            _frmStockInDetailList.cmBoxSupplier.DisplayMember = "SupplierName";
            _frmStockInDetailList.cmBoxSupplier.ValueMember = "Id";
            _frmStockInDetailList.cmBoxSupplier.DataSource = suppliers;

            _frmStockInDetailList.dGWProduct.DataSource = products;

            _frmStockInDetailList.btnSave.Enabled = true;
            _frmStockInDetailList.btnUpdate.Enabled = false;
            /*
            _frmStockInDetailList.dGWProduct.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle()
            {
                BackColor = Color.Gray,
                SelectionBackColor = Color.Gray
            };
            _frmStockInDetailList.dGWProduct.DefaultCellStyle = new DataGridViewCellStyle()
            {
                BackColor = Color.Gray,
                SelectionBackColor = Color.Gray
            };
            _frmStockInDetailList.dGWProduct.Enabled= false;
            _frmStockInDetailList.txtProductSearch.Enabled= false;
            */
            _frmStockInDetailList.IsUpdate = false;
            _frmStockInDetailList.TopLevel = false;
            _frmStockInDetailList.Dock = DockStyle.Fill;

            _frmForm.pnlMain.Controls.Clear();
            _frmForm.pnlMain.Controls.Add(_frmStockInDetailList);

            _frmStockInDetailList.BringToFront();
            _frmStockInDetailList.Show();
        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void yukle()
        {

            var stockInList = _stockInRepository.GetAllSelected();

            dGWStockIn.DataSource = stockInList;
            dGWStockIn.Refresh();

        }
        public void yukle(DateTime beginDate, DateTime endDate)
        {

            var stockInList = _stockInRepository.GetBetweenDates(m => m.StockInDate >= beginDate && m.StockInDate <= endDate);

            dGWStockIn.DataSource = stockInList;
            dGWStockIn.Refresh();

        }


        private void dGWStockIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colName = dGWStockIn.Columns[e.ColumnIndex].Name;
            int stockInId = int.Parse(dGWStockIn["Id", e.RowIndex].Value.ToString());
            int rowId = e.RowIndex;
            var stockIn = _stockInRepository.GetById(stockInId);
            switch (colName)
            {
                case "Edit":
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
                    _frmStockInDetailList.TopLevel = false;
                    _frmStockInDetailList.Dock = DockStyle.Fill;
                    _frmStockInDetailList.stockInListId = stockInId;

                    _frmForm.pnlMain.Controls.Clear();
                    _frmForm.pnlMain.Controls.Add(_frmStockInDetailList);

                    _frmStockInDetailList.BringToFront();
                    _frmStockInDetailList.Show();
                    break;
                case "Delete":

                    if (MessageBox.Show("Ürünü silmek istediğinizden emin misiniz?", "Ürün Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _stockInRepository.Delete(stockIn);
                        yukle();
                    }
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            var beginDate = dTPBeginDate.Value;
            var newBeginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            var endDate = dTPEndDate.Value;
            var newEndDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 23, 59, 59);

            yukle(newBeginDate, newEndDate);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
