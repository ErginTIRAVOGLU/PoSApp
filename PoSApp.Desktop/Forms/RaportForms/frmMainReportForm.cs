using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoSApp.Desktop.Forms.RaportForms
{
    public partial class frmMainReportForm : Form
    {
        private frmMain _frmForm;

        public frmMainReportForm(frmMain frmForm)
        {
            InitializeComponent();
            _frmForm = frmForm;
        }

        private void btnStockInProductReports_Click(object sender, EventArgs e)
        {
            //frmStockInProductReports frm = new frmStockInProductReports((frmMain)this.Parent.Parent);
            frmStockInProductReports frm = new frmStockInProductReports(_frmForm);
            frm.Show();


            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            _frmForm.pnlMain.Controls.Clear();
            _frmForm.pnlMain.Controls.Add(frm);

            frm.BringToFront();
            frm.Show();
        }

        private void btnCartProductReports_Click(object sender, EventArgs e)
        {
            frmCartProductReports frm = new frmCartProductReports(_frmForm);
            frm.Show();


            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            _frmForm.pnlMain.Controls.Clear();
            _frmForm.pnlMain.Controls.Add(frm);

            frm.BringToFront();
            frm.Show();
        }
    }
}
