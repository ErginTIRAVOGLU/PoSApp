using PoSApp.BLL.Repositories.Concrete;
using PoSApp.Desktop.Forms.ProductForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            warehouseId = int.Parse(cmBoxWarehouse.SelectedValue.ToString());
            warehouseName = cmBoxWarehouse.Text;
            productQuantity = int.Parse(txtCount.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            warehouseId = int.Parse(cmBoxWarehouse.SelectedValue.ToString());
            warehouseName = cmBoxWarehouse.Text;
            productQuantity = int.Parse(txtCount.Text);
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
