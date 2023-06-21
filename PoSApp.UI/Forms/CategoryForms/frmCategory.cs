using PoSApp.BLL.Repositories.Abstract;
using PoSApp.BLL.Repositories.Concrete;
using PoSApp.DAL;
using PoSApp.Entities;
using PoSApp.UI.Forms.CategoryForms;
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
    public partial class frmCategory : Form
    {
        private CategoryRepository _categoryRepository = new CategoryRepository();
        private frmCategoryList _frmCategoryList;
        public int categoryId;
        public bool IsUpdate;

        public frmCategory(frmCategoryList frmCategoryList)
        {
            InitializeComponent();

            _frmCategoryList = frmCategoryList;
        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private  void btnUpdate_Click(object sender, EventArgs e)
        {
            var category =  _categoryRepository.GetById(categoryId);
            category.CategoryName = txtCategory.Text;
            var durum =  _categoryRepository.Update(category);
            temizle();
            _frmCategoryList.yukle();
            this.Close();
        }

        private  void btnSave_Click(object sender, EventArgs e)
        {
            var durum =  _categoryRepository.Insert(new Category() { CategoryName = txtCategory.Text });
            temizle();
            _frmCategoryList.yukle();
        }

        private void temizle()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtCategory.Clear();
            txtCategory.Focus();
        }

        private void frmCategory_Load(object sender, EventArgs e)
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
    }
}
