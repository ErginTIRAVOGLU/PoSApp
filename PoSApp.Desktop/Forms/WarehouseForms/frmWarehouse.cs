using PoSApp.BLL.Repositories.Abstract;
using PoSApp.BLL.Repositories.Concrete;
using PoSApp.DAL;
using PoSApp.Entities;
using PoSApp.Desktop.Forms.CategoryForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoSApp.Desktop.Forms.WarehouseForms
{
    public partial class frmWarehouse : Form
    {
        private WarehouseRepository _warehouseRepository = new WarehouseRepository();
        private frmWarehouseList _frmWarehouseList;
        public int warehouseId;
        public bool IsUpdate;

        public frmWarehouse(frmWarehouseList frmWarehouseList)
        {
            InitializeComponent();

            _frmWarehouseList = frmWarehouseList;
        }

        private void frmWarehouse_Load(object sender, EventArgs e)
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

        private void temizle()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;            
            txtDepo.Clear();
            txtDepo.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var durum = _warehouseRepository.Insert(new Warehouse()
            {
                WarehouseName = txtDepo.Text,
              
            });
            temizle();
            _frmWarehouseList.yukle();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var warehouse = _warehouseRepository.GetById(warehouseId);
            warehouse.WarehouseName = txtDepo.Text;
            
            var durum = _warehouseRepository.Update(warehouse);
            temizle();
            _frmWarehouseList.yukle();
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
    }
}
