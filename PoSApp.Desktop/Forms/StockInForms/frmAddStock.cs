using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PoSApp.BLL.Repositories.Concrete;
using PoSApp.Desktop.Forms.ProductForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoSApp.Desktop.Forms.StockInForms
{
    public partial class frmAddStock : Form
    {
        WarehouseRepository _warehouseRepository = new WarehouseRepository();
        public int warehouseId { get; set; }
        public string warehouseName { get; set; }
        public decimal productQuantity { get; set; }

        public decimal productArrivalPrice { get; set; }
        public decimal productDiscountPercentage { get; set; }
        public decimal productUnitDiscountAmount { get; set; }
        public decimal productTotalDiscountAmount { get; set; }
        public decimal productTotalVatAmount { get; set; }
        public decimal productLastPriceWithoutVat { get; set; }
        public decimal productLastPriceWithVat { get; set; }


        public frmAddStock()
        {

            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int tCount = 0;
            decimal tArrivalPrice = 0M;
            decimal tDiscountPercentage = 0M;
            decimal tUnitDiscountAmount = 0M;
            decimal tTotalDiscountAmount = 0M;
            decimal tTotalVatAmount = 0M;
            decimal tLastPriceWithoutVat = 0M;
            decimal tLastPriceWithVat = 0M;

            warehouseId = int.Parse(cmBoxWarehouse.SelectedValue.ToString());
            warehouseName = cmBoxWarehouse.Text;
          

            int.TryParse(txtCount.Text, out tCount);
            productQuantity = tCount;

            decimal.TryParse(txtArrivalPrice.Text, out tArrivalPrice);
            productArrivalPrice = tArrivalPrice;

            decimal.TryParse(txtDiscountPercentage.Text, out tDiscountPercentage);
            productDiscountPercentage = tDiscountPercentage;

            decimal.TryParse(txtUnitDiscountAmount.Text, out tUnitDiscountAmount);
            productUnitDiscountAmount = tUnitDiscountAmount;

            decimal.TryParse(txtTotalDiscountAmount.Text, out tTotalDiscountAmount);
            productTotalDiscountAmount = tTotalDiscountAmount;

            decimal.TryParse(txtTotalVatAmount.Text, out tTotalVatAmount);
            productTotalVatAmount = tTotalVatAmount;

            decimal.TryParse(txtLastPriceWithoutVat.Text, out tLastPriceWithoutVat);
            productLastPriceWithoutVat = tLastPriceWithoutVat;

            decimal.TryParse(txtLastPriceWithVat.Text, out tLastPriceWithVat);
            productLastPriceWithVat = tLastPriceWithVat;


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int tCount = 0;
            decimal tArrivalPrice = 0M;
            decimal tDiscountPercentage = 0M;
            decimal tUnitDiscountAmount = 0M;
            decimal tTotalDiscountAmount = 0M;
            decimal tTotalVatAmount = 0M;
            decimal tLastPriceWithoutVat = 0M;
            decimal tLastPriceWithVat = 0M;


            warehouseId = int.Parse(cmBoxWarehouse.SelectedValue.ToString());
            warehouseName = cmBoxWarehouse.Text;

            int.TryParse(txtCount.Text, out tCount);
            productQuantity = tCount;

            decimal.TryParse(txtArrivalPrice.Text, out tArrivalPrice);
            productArrivalPrice = tArrivalPrice;

            decimal.TryParse(txtDiscountPercentage.Text, out tDiscountPercentage);
            productDiscountPercentage = tDiscountPercentage;
            
            decimal.TryParse(txtUnitDiscountAmount.Text, out tUnitDiscountAmount);
            productUnitDiscountAmount = tUnitDiscountAmount;
            
            decimal.TryParse(txtTotalDiscountAmount.Text, out tTotalDiscountAmount);
            productTotalDiscountAmount = tTotalDiscountAmount;
            
            decimal.TryParse(txtTotalVatAmount.Text, out tTotalVatAmount);
            productTotalVatAmount = tTotalVatAmount;
            
            decimal.TryParse(txtLastPriceWithoutVat.Text, out tLastPriceWithoutVat);
            productLastPriceWithoutVat = tLastPriceWithoutVat;
            
            decimal.TryParse(txtLastPriceWithVat.Text, out tLastPriceWithVat);
            productLastPriceWithVat = tLastPriceWithVat;


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmAddStock_Load(object sender, EventArgs e)
        {
            var warehouse = _warehouseRepository.GetAll();
            cmBoxWarehouse.DisplayMember = "WarehouseName";
            cmBoxWarehouse.ValueMember = "Id";
            cmBoxWarehouse.DataSource = warehouse;
        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
