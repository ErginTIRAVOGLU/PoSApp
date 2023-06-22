using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoSApp.Desktop.Forms.PosForms
{
    public partial class frmDiscount : Form
    {
        public decimal _totalDiscount { get; set; }
        public decimal _price { get; set; }

        public frmDiscount()
        {
            InitializeComponent();

        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPercentage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalDiscount_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal dValue = 0;
            decimal dPrice = 0;
            decimal.TryParse(txtTotalDiscount.Text, out dValue);
            _totalDiscount = dValue;
            txtTotalDiscount.Text = dValue.ToString("N");

            decimal.TryParse(txtPrice.Text, out dPrice);
            _price = dPrice;


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtPercentage_KeyUp(object sender, KeyEventArgs e)
        {
            decimal initPrice = 0;
            decimal.TryParse(txtListPrice.Text, out initPrice);

            //decimal price = 0;
            //decimal.TryParse(txtPrice.Text, out price);

            decimal value = 0;
            decimal.TryParse(txtPercentage.Text, out value);

            decimal discountRatio = value / 100;
            txtTotalDiscount.Text = (initPrice - (initPrice * (1 - discountRatio))).ToString("N");
            txtPrice.Text= (initPrice * (1 - discountRatio)).ToString("N");
        }

        private void txtTotalDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            decimal initPrice = 0;
            decimal.TryParse(txtListPrice.Text, out initPrice);

            decimal price = 0;
            decimal.TryParse(txtPrice.Text, out price);

            decimal value = 0;
            decimal.TryParse(txtTotalDiscount.Text, out value);

            decimal percentageValue = (100 - (100 - ((value * 100) / initPrice)));

            int intValue = 0;
            int.TryParse(Decimal.Floor(percentageValue).ToString(), out intValue);
            txtPercentage.Text = intValue.ToString();
            txtPrice.Text = (initPrice-value).ToString("N");

        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            decimal initPrice = 0;
            decimal.TryParse(txtListPrice.Text, out initPrice);
            decimal price = 0;
            decimal.TryParse(txtPrice.Text, out price);
            var percentage = (100 * price) / initPrice;
            percentage = 100 - percentage;
            var pPercentage = 0;
            int.TryParse(Math.Floor(percentage).ToString(), out pPercentage);
            txtPercentage.Text = pPercentage.ToString();
            txtTotalDiscount.Text = (initPrice - price).ToString("N"); ;
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {
            txtListPrice.Enabled = false;
            decimal outValue = 0;
            decimal.TryParse(txtPrice.Text, out outValue);
            
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
