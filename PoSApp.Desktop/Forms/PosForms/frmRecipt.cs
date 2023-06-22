using Microsoft.Extensions.Configuration;
using Microsoft.Reporting.WinForms;
using PoSApp.BLL.Repositories.Concrete;
using PoSApp.Desktop.Dataset;
using PoSApp.Desktop.Dataset;
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
    public partial class frmRecipt : Form
    {
        private CartDetailRepository _cartDetailRepository = new CartDetailRepository();
        public string _transNo { get; set; }
        public List<PrintDetailList> oldCartDetail;
        static IConfigurationRoot configuration;
        public string _store { get; set; }
        public string _address { get; set; }
        public frmRecipt()
        {
            InitializeComponent();
            configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("printsettings.json").Build();
            _store=configuration.GetValue<string>("pStore");
            _address=configuration.GetValue<string>("pAddress");
            var data = "";
        }

        private void frmRecipt_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();


        }

        public void LoadReport(string price, string discount, string vat, string total, string transNo)
        {
            ReportDataSource _reportDataSource;


            PosResultDataSet _posResultDataSet = new PosResultDataSet();
            oldCartDetail = new List<PrintDetailList>();
            oldCartDetail = _cartDetailRepository.GetAllPrintbyTransNo(_transNo).ToList();
            var source = new BindingSource();
            source.DataSource = oldCartDetail;

            ReportParameter pPrice = new ReportParameter("pPrice", price);
            ReportParameter pDiscount = new ReportParameter("pDiscount", discount);
            ReportParameter pVat = new ReportParameter("pVat", vat);
            ReportParameter pTotal = new ReportParameter("pTotal", total);
            ReportParameter pStore = new ReportParameter("pStore", _store);
            ReportParameter pAddress = new ReportParameter("pAddress", _address);
            ReportParameter pTransaction = new ReportParameter("pTransaction", "TransNo : "+ transNo);



            _reportDataSource = new ReportDataSource("reportPosDataset", source);
            this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\PosResultReport.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(_reportDataSource);
            this.reportViewer1.LocalReport.SetParameters(pPrice);
            this.reportViewer1.LocalReport.SetParameters(pDiscount);
            this.reportViewer1.LocalReport.SetParameters(pVat);
            this.reportViewer1.LocalReport.SetParameters(pTotal);
            this.reportViewer1.LocalReport.SetParameters(pStore);
            this.reportViewer1.LocalReport.SetParameters(pAddress);
            this.reportViewer1.LocalReport.SetParameters(pTransaction);

            this.reportViewer1.SetDisplayMode(DisplayMode.Normal);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            //this.reportViewer1.ZoomPercent = 100;
            //this.reportViewer1.RefreshReport();
        }
    }
}
