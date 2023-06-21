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

namespace PoSApp.UI.Forms.BrandForms
{
    public partial class frmBrand : Form
    {
        private BrandRepository _brandRepository = new BrandRepository();
        private frmBrandList _frmBrandList;
        public int brandId;
        public bool IsUpdate;

        public frmBrand(frmBrandList frmBrandList)
        {
            InitializeComponent();


            _frmBrandList = frmBrandList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var durum = _brandRepository.Insert(new Brand() { BrandName = txtBrand.Text });
            temizle();
            _frmBrandList.yukle();
        }

        private void temizle()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtBrand.Clear();
            txtBrand.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();

        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var brand = _brandRepository.GetById(brandId);
            brand.BrandName = txtBrand.Text;
            var durum = _brandRepository.Update(brand);
            temizle();
            _frmBrandList.yukle();
            this.Close();
            //this.Dispose();
        }

        private void frmBrand_Load(object sender, EventArgs e)
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

        private void frmBrand_FormClosed(object sender, FormClosedEventArgs e)
        {
            // this.Dispose();
        }
    }
}
