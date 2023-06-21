using PoSApp.BLL.Log;
using PoSApp.DAL;
using PoSApp.UI.Forms.BrandForms;
using PoSApp.UI.Forms.CategoryForms;
using PoSApp.UI.Forms.PosForms;
using PoSApp.UI.Forms.ProductForms;
using PoSApp.UI.Forms.StockInForms;
using PoSApp.UI.Forms.SupplierForms;
using PoSApp.UI.Forms.UpdateForms;
using PoSApp.UI.Forms.WarehouseForms;
using System.Net;
using System.Windows.Forms;

namespace PoSApp.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();


        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            frmBrandList frm = new frmBrandList();
            frm.TopLevel = false;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {

            frmCategoryList frm = new frmCategoryList();
            frm.TopLevel = false;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmSupplierList frm = new frmSupplierList();
            frm.TopLevel = false;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        public void btnStockIn_Click(object sender, EventArgs e)
        {
            frmStockInList frm = new frmStockInList(this);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);

            frm.BringToFront();
            frm.Show();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProductList frm = new frmProductList();
            frm.TopLevel = false;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            frmPos frm = new frmPos();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            AppLogger appLogger = new AppLogger();
            appLogger.WriteLog("Program ba�lad�");
            using (var context = new PosDbContext())
            {
                context.Database.EnsureCreated();
            }
        }

        private void pnlSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            frmWarehouseList frm = new frmWarehouseList();
            frm.TopLevel = false;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    btnDashboard_Click(null, null);
                    break;
                case Keys.F2:
                    btnPos_Click(null, null);
                    break;
                case Keys.F3:
                    btnStockIn_Click(null, null);
                    break;
                case Keys.F4:
                    btnProduct_Click(null, null);
                    break;
                case Keys.F5:
                    btnCategory_Click(null, null);
                    break;
                case Keys.F6:
                    btnWarehouse_Click(null, null);
                    break;
                case Keys.F7:
                    btnBrand_Click(null, null);
                    break;
                case Keys.F8:
                    btnSupplier_Click(null, null);
                    break;
                case Keys.F9:
                    btnRecords_Click(null, null);
                    break;
                case Keys.F10:
                    btnReports_Click(null, null);
                    break;
                case Keys.F11:
                    btnSettings_Click(null, null);
                    break;


                case Keys.Escape:
                    btnExit_Click(null, null);
                    break;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnRecords_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate frmUpdate = new frmUpdate();
            frmUpdate.ShowDialog();

        }
    }
}