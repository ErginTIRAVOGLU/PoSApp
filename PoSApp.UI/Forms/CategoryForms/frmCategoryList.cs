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

namespace PoSApp.UI.Forms.CategoryForms
{
    public partial class frmCategoryList : Form
    {
        private CategoryRepository _categoryRepository = new CategoryRepository();
        public frmCategoryList()
        {
            InitializeComponent();

            yukle();
        }

        public void yukle()
        {

            var categoryList = _categoryRepository.GetAllSelected();

            dGWCategory.DataSource = categoryList;
            dGWCategory.Refresh();

        }



        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            frmCategory frmCategory = new frmCategory(this);
            frmCategory.IsUpdate = false;
            frmCategory.ShowDialog();
        }

        private void dGWCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dGWCategory.Columns[e.ColumnIndex].Name;
            int categoryId = int.Parse(dGWCategory["Id", e.RowIndex].Value.ToString());
            switch (colName)
            {
                case "Edit":
                    var category = _categoryRepository.GetById(categoryId);
                    frmCategory frmCategory = new frmCategory(this);
                    frmCategory.txtCategory.Text = category.CategoryName;
                    frmCategory.categoryId = categoryId;
                    frmCategory.IsUpdate = true;
                    frmCategory.ShowDialog();

                    break;
                case "Delete":
                    if (MessageBox.Show("Kategoriyi silmek istediğinizden emin misiniz?", "Kategori Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        deleteCategory(categoryId);
                        yukle();
                    }


                    break;
                default:
                    break;
            }
        }

        private void deleteCategory(int categoryId)
        {
            var category = _categoryRepository.GetById(categoryId);
            category.IsDeleted = true;
            category.DeletedDate = DateTime.Now;
            var durum = _categoryRepository.Update(category);
        }
    }
}
