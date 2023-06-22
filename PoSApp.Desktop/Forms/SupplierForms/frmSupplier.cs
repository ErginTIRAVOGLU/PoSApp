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

namespace PoSApp.Desktop.Forms.SupplierForms
{
    public partial class frmSupplier : Form
    {
        private SupplierRepository _supplierRepository = new SupplierRepository();
        private frmSupplierList _frmSupplierList;
        public int supplierId;
        public bool IsUpdate;

        public frmSupplier(frmSupplierList frmSupplierList)
        {
            InitializeComponent();

            _frmSupplierList = frmSupplierList;
        }

        private void frmSupplier_Load(object sender, EventArgs e)
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
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtManager.Clear();
            txtNote.Clear();
            txtPhone1.Clear();
            txtPhone2.Clear();
            txtTaxAdministrator.Clear();
            txtTaxNumber.Clear();
            txtSupplier.Clear();
            txtSupplier.Focus();
        }

        private  void btnSave_Click(object sender, EventArgs e)
        {
            var durum =  _supplierRepository.Insert(new Supplier()
            {
                SupplierName = txtSupplier.Text,
                SupplierAddress1 = txtAddress1.Text,
                SupplierAddress2 = txtAddress2.Text,
                SupplierManager = txtManager.Text,
                SupplierNote = txtNote.Text,
                SupplierPhone1 = txtPhone1.Text,
                SupplierPhone2 = txtPhone2.Text,
                SupplierTaxAdministrator = txtTaxAdministrator.Text,
                SupplierTaxNumber = txtTaxNumber.Text
            });
            temizle();
            _frmSupplierList.yukle();
        }

        private  void btnUpdate_Click(object sender, EventArgs e)
        {
            var supplier =  _supplierRepository.GetById(supplierId);
            supplier.SupplierName = txtSupplier.Text;
            supplier.SupplierAddress1 = txtAddress1.Text;
            supplier.SupplierAddress2 = txtAddress2.Text;
            supplier.SupplierManager = txtManager.Text;
            supplier.SupplierNote = txtNote.Text;
            supplier.SupplierPhone1 = txtPhone1.Text;
            supplier.SupplierPhone2 = txtPhone2.Text;
            supplier.SupplierTaxAdministrator = txtTaxAdministrator.Text;
            supplier.SupplierTaxNumber = txtTaxNumber.Text;
            var durum =  _supplierRepository.Update(supplier);
            temizle();
            _frmSupplierList.yukle();
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
