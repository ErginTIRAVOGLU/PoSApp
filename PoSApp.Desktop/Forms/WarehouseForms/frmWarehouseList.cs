using PoSApp.BLL.Repositories.Abstract;
using PoSApp.BLL.Repositories.Concrete;
using PoSApp.DAL;
using PoSApp.Entities;
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
    public partial class frmWarehouseList : Form
    {
        private WarehouseRepository _warehouseRepository = new WarehouseRepository();
        public frmWarehouseList()
        {
            InitializeComponent();

            yukle();
        }

        public void yukle()
        {

            var warehouseList = _warehouseRepository.GetAllSelected();

            dGWWarehouse.DataSource = warehouseList;
            dGWWarehouse.Refresh();

        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {

            frmWarehouse frmWarehouse = new frmWarehouse(this);
            frmWarehouse.IsUpdate = false;
            frmWarehouse.ShowDialog();
        }


        private void deleteSupplier(int warehouseId)
        {
            var warehouse = _warehouseRepository.GetById(warehouseId);
            warehouse.IsDeleted = true;
            warehouse.DeletedDate = DateTime.Now;
            var durum = _warehouseRepository.Update(warehouse);
        }

        private void dGWWarehouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colName = dGWWarehouse.Columns[e.ColumnIndex].Name;
            int warehouseId = int.Parse(dGWWarehouse["Id", e.RowIndex].Value.ToString());
            switch (colName)
            {
                case "Edit":
                    var warehouse = _warehouseRepository.GetById(warehouseId);
                    frmWarehouse frmWarehouse = new frmWarehouse(this);
                    frmWarehouse.txtDepo.Text = warehouse.WarehouseName;
                    frmWarehouse.warehouseId = warehouseId;


                    frmWarehouse.IsUpdate = true;
                    frmWarehouse.ShowDialog();

                    break;
                case "Delete":
                    if (MessageBox.Show("Depoyu silmek istediğinizden emin misiniz?", "Depo Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        deleteSupplier(warehouseId);
                        yukle();
                    }


                    break;
                default:
                    break;
            }
        }
    }
}
