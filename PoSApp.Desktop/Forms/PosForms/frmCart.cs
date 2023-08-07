using PoSApp.BLL.Repositories.Abstract;
using PoSApp.BLL.Repositories.Concrete;
using PoSApp.Entities;
using PoSApp.Entities.Enums;
using PoSApp.Desktop.Forms.ProductForms;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoSApp.Desktop.Forms.PosForms
{
    public partial class frmCart : Form
    {
        CartRepository _cartRepository = new CartRepository();
        public string _transNo { get; set; }


        public frmCart()
        {

            InitializeComponent();


            load();

        }

         
       
        private void pBClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        public void load()
        {

            var beginDate = dTPBeginDate.Value;
            var newBeginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            var endDate = dTPEndDate.Value;
            var newEndDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 23, 59, 59);

            load(newBeginDate, newEndDate);

        }
        public void load(DateTime beginDate, DateTime endDate)
        {

            var stockInList = _cartRepository.GetBetweenDates(m => m.CartDate >= beginDate && m.CartDate <= endDate);

            dGWCart.DataSource = stockInList;
            dGWCart.Refresh();

        }


        private void dGWCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colName = dGWCart.Columns[e.ColumnIndex].Name;
            int cartId = int.Parse(dGWCart["Id", e.RowIndex].Value.ToString());
            int rowId = e.RowIndex;
            var cart = _cartRepository.GetById(cartId);
            switch (colName)
            {
                case "Edit":
                    _transNo = cart.TransNo;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                   
                    break;
                case "Delete":

                    if (MessageBox.Show("Satışı silmek istediğinizden emin misiniz?", "Satış Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _cartRepository.Delete(cart);
                        load();
                    }
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            load();
        }

        private void dGWCart_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*
            if (dGWCart.Columns[e.ColumnIndex].Name == "CartStatusType")
            {
                CartStatus enumValue = (CartStatus)e.Value;
                e.Value = (Attribute.GetCustomAttribute(enumValue.GetType().GetField(enumValue.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description;
            }
            */
        }
    }
}
