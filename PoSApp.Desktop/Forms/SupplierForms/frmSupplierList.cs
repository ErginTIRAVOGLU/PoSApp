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

namespace PoSApp.Desktop.Forms.SupplierForms
{
    public partial class frmSupplierList : Form
    {
        private SupplierRepository _supplierRepository = new SupplierRepository();
        public frmSupplierList()
        {
            InitializeComponent();

            yukle();
        }

        public void yukle()
        {

            var supplierList = _supplierRepository.GetAllSelected();

            dGWSupplier.DataSource = supplierList;
            dGWSupplier.Refresh();

        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {

            frmSupplier frmSupplier = new frmSupplier(this);
            frmSupplier.IsUpdate = false;
            frmSupplier.ShowDialog();
        }


        private void deleteSupplier(int supplierId)
        {
            var supplier = _supplierRepository.GetById(supplierId);
            supplier.IsDeleted = true;
            supplier.DeletedDate = DateTime.Now;
            var durum = _supplierRepository.Update(supplier);
        }

        private void dGWSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colName = dGWSupplier.Columns[e.ColumnIndex].Name;
            int supplierId = int.Parse(dGWSupplier["Id", e.RowIndex].Value.ToString());
            switch (colName)
            {
                case "Edit":
                    var supplier = _supplierRepository.GetById(supplierId);
                    frmSupplier frmSupplier = new frmSupplier(this);
                    frmSupplier.txtSupplier.Text = supplier.SupplierName;
                    frmSupplier.txtAddress1.Text = supplier.SupplierAddress1;
                    frmSupplier.txtAddress2.Text = supplier.SupplierAddress2;
                    frmSupplier.txtPhone1.Text = supplier.SupplierPhone1;
                    frmSupplier.txtPhone2.Text = supplier.SupplierPhone2;
                    frmSupplier.txtManager.Text = supplier.SupplierManager;
                    frmSupplier.txtTaxAdministrator.Text = supplier.SupplierTaxAdministrator;
                    frmSupplier.txtTaxNumber.Text = supplier.SupplierTaxNumber;
                    frmSupplier.txtNote.Text = supplier.SupplierNote;

                    frmSupplier.supplierId = supplierId;
                    frmSupplier.IsUpdate = true;
                    frmSupplier.ShowDialog();

                    break;
                case "Delete":
                    if (MessageBox.Show("Tedarikçiyi silmek istediğinizden emin misiniz?", "Kategori Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        deleteSupplier(supplierId);
                        yukle();
                    }


                    break;
                default:
                    break;
            }
        }
    }
}
