using PoSApp.BLL;
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

namespace PoSApp.UI.Forms.BrandForms
{
    public partial class frmBrandList : Form
    {
        private BrandRepository _brandRepository = new BrandRepository();
        public frmBrandList()
        {
            InitializeComponent();
            yukle();
        }




        public void yukle()
        {

            var brandList = _brandRepository.GetAllSelected();

            dGWBrand.DataSource = brandList;
            dGWBrand.Refresh();

        }

        private void frmBrandList_Load(object sender, EventArgs e)
        {

        }

        private void dGWBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dGWBrand.Columns[e.ColumnIndex].Name;
            int brandId = int.Parse(dGWBrand["Id", e.RowIndex].Value.ToString());
            switch (colName)
            {
                case "Edit":
                    var brand = _brandRepository.GetById(brandId);
                    frmBrand frmBrand = new frmBrand(this);
                    frmBrand.txtBrand.Text = brand.BrandName;
                    frmBrand.brandId = brandId;
                    frmBrand.IsUpdate = true;
                    frmBrand.ShowDialog();

                    break;
                case "Delete":
                    if (MessageBox.Show("Markayı silmek istediğinizden emin misiniz?", "Marka Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        deleteBrand(brandId);
                        yukle();
                    }


                    break;
                default:
                    break;
            }
        }

        private void deleteBrand(int brandId)
        {
            var brand = _brandRepository.GetById(brandId);
            brand.IsDeleted = true;
            brand.DeletedDate = DateTime.Now;
            var durum = _brandRepository.Update(brand);
        }

        private void frmBrandList_FormClosed(object sender, FormClosedEventArgs e)
        {



        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            frmBrand frmBrand = new frmBrand(this);
            frmBrand.IsUpdate = false;
            frmBrand.ShowDialog();

        }
    }
}
