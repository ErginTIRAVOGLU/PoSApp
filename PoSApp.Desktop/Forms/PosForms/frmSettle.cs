using PoSApp.BLL.Repositories.Concrete;
using PoSApp.Entities.Enums;
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
    public partial class frmSettle : Form
    {
        frmPos _frmPos;
        public string _transNo { get; set; } = "";

        public decimal _cashAmount { get; set; }
        public decimal _saleAmount { get; set; }
        public decimal _changeAmount { get; set; }
        public decimal _payedAmount { get; set; }
        public decimal _pendingPayment { get; set; }

        private PayedAmountRepository _payedAmountRepository = new PayedAmountRepository();
        public frmSettle(frmPos frmPos)
        {
            InitializeComponent();
            _frmPos = frmPos;
            this.KeyDown += new KeyEventHandler(frmSettle_KeyUp);
        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCash_KeyUp(object sender, KeyEventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {

            //decimal textSale = 0;
            decimal textPayedAmount = 0;
            decimal textCash = 0;
            decimal textChange = 0;
            //decimal.TryParse(txtSale.Text, out textSale);
            //decimal.TryParse(txtPayedAmount.Text, out textPayedAmount);
            textPayedAmount = _pendingPayment;

            decimal.TryParse(txtCash.Text, out textCash);

            _changeAmount = textPayedAmount - textCash;

            textChange = _changeAmount;
            txtChange.Text = textChange.ToString("C");

            if (textChange < 0)
            {
                txtChange.Text = textChange.ToString("C");
                txtCash.Focus();
                txtCash.SelectionStart = txtCash.Text.Length;
                txtCash.SelectionLength = 0;
            }
            else
            {
                _changeAmount = 0;
                textChange = _changeAmount;
                txtChange.Text = textChange.ToString("C");
            }


            //this.ActiveControl = txtCash;
        }
        private void cashControl()
        {

        }
        private void cashControl(string btnText)
        {
            string cashAmount = "";
            cashAmount = btnText;
            if (_cashAmount == 0)
            {
                txtCash.Clear();

            }

            _cashAmount += decimal.Parse(cashAmount);
            txtCash.Text += cashAmount;

        }


        private void btn_Click(object sender, EventArgs e)
        {

            cashControl(((Button)sender).Text);
            Calculate();
        }

        private void btnC_Click(object sender, EventArgs e)
        {

            txtCash.Clear();
            txtCash.Focus();
            Calculate();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            cashControl(btn0.Text);
            Calculate();
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            cashControl(btn00.Text);
            Calculate();
        }

        private void frmSettle_Load(object sender, EventArgs e)
        {
            txtSale.Text = _saleAmount.ToString("C");
            txtCash.Text = _cashAmount.ToString("N4");
            txtChange.Text = _changeAmount.ToString("C");
            pendingPayment();
            payedTotal();
            fillPayedDetailGV();
            //txtCash.Clear();
            txtCash.Focus();
            this.ActiveControl = txtCash;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool closeForm = false;
            //sale
            //cash
            //change

            decimal change = 0;
            decimal cash = 0;
            //decimal.TryParse(txtChange.Text, out change);
            change = _changeAmount;
            decimal.TryParse(txtCash.Text, out cash);

            _cashAmount = cash;


            if (cash == 0)
            {
                MessageBox.Show("Lütfen Ödeme Tutarını Giriniz!");
                txtCash.Focus();
                this.ActiveControl = txtCash;
                return;
            }



            if (btnCash.Checked)
            {
                if (_pendingPayment > cash)
                {
                    _frmPos.saveCart(CartStatus.Pending, cash, PaymentType.Cash);
                }
                else
                {
                    _frmPos.saveCart(CartStatus.Payed, cash, PaymentType.Cash);
                    closeForm = true;
                }
                btnCash.Checked = false;
            }
            else if (btnCreditCard.Checked)
            {
                if (_pendingPayment > cash)
                {
                    _frmPos.saveCart(CartStatus.Pending, cash, PaymentType.CreditCard);
                }
                else
                {
                    _frmPos.saveCart(CartStatus.Payed, cash, PaymentType.CreditCard);
                    closeForm = true;
                }
                btnCreditCard.Checked = false;
            }
            else if (btnBankPayment.Checked)
            {
                if (_pendingPayment > cash)
                {
                    _frmPos.saveCart(CartStatus.Pending, cash, PaymentType.BankTransfer);
                }
                else
                {
                    _frmPos.saveCart(CartStatus.Payed, cash, PaymentType.BankTransfer);
                    closeForm = true;
                }
                btnBankPayment.Checked = false;
            }
            else if (btnMealCard.Checked)
            {
                if (_pendingPayment > cash)
                {
                    //if (change > 0)
                    //{
                    _frmPos.saveCart(CartStatus.Pending, cash, PaymentType.MealCard);
                    //}
                }
                else
                {
                    _frmPos.saveCart(CartStatus.Payed, cash, PaymentType.MealCard);
                    closeForm = true;
                }
                btnMealCard.Checked = false;

            }
            else if (btnTrendyolHizliMarket.Checked)
            {
                if (_pendingPayment > cash)
                {
                    _frmPos.saveCart(CartStatus.Pending, cash, PaymentType.TrendyolHizliMarket);
                }
                else
                {
                    _frmPos.saveCart(CartStatus.Payed, cash, PaymentType.TrendyolHizliMarket);
                    closeForm = true;
                }
                btnBankPayment.Checked = false;
            }
            else
            {
                MessageBox.Show("Lütfen Ödeme Yöntemi Seçin", "Ödeme Yöntemi Seçimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtCash.Clear();
            txtChange.Clear();
            pendingPayment();
            fillPayedDetailGV();
            payedTotal();
            txtCash.Focus();
            this.ActiveControl = txtCash;
            if (closeForm)
            {
                this.Close();
            }
        }
        private void payedTotal()
        {
            var payedAmount = _payedAmountRepository.GetTotalPayedAmount(_transNo);
            _payedAmount = payedAmount;
            txtTotalPayed.Text = _payedAmount.ToString("C");
        }
        private void pendingPayment()
        {
            var payedAmount = _payedAmountRepository.GetTotalPayedAmount(_transNo);
            _payedAmount = payedAmount;
            decimal saleAmount = 0;
            //decimal.TryParse(txtSale.Text, out saleAmount);
            saleAmount = _saleAmount;
            _pendingPayment = saleAmount - _payedAmount;
            txtPayedAmount.Text = _pendingPayment.ToString("C");
        }

        private void fillPayedDetailGV()
        {
            var payedList = _payedAmountRepository.GetAllSelected(_transNo);
            dGWPayedDetail.DataSource = payedList;
            dGWPayedDetail.Refresh();
        }

        private void dGWPayedDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dGWPayedDetail.Columns[e.ColumnIndex].Name;
            var rowId = int.Parse(dGWPayedDetail["Id", e.RowIndex].Value.ToString());
            switch (colName)
            {
                case "Delete":
                    if (MessageBox.Show("Ödemeyi silmek istediğinizden emin misiniz?", "Ödeme Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var selectedRowIndex = e.RowIndex;
                        deleteRow(rowId);
                        txtCash.Clear();

                        payedTotal();
                        fillPayedDetailGV();
                        Calculate();
                        pendingPayment();
                        txtChange.Clear();
                    }


                    break;
                default:
                    break;
            }
        }

        private void deleteRow(int rowId)
        {
            var payedAmount = _payedAmountRepository.GetById(rowId);
            _payedAmountRepository.Delete(payedAmount);

        }

        private void frmSettle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
