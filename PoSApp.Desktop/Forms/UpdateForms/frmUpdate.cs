using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoSApp.Desktop.Forms.UpdateForms
{
    public partial class frmUpdate : Form
    {

        public frmUpdate()
        {
            InitializeComponent();
            updateBar.Minimum = 0;
            updateBar.Maximum = 100;
            updateBar.Value = 0;

        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            lblHeader.Text = "Yeni versiyonu kontrol etmek için tıklayın...";
            btnUpdate.Visible = false;
            updateBar.Visible = false;
            btnControl.Visible = true;

        }

        private void vesiyonControl()
        {
            var urlAddress = "https://ergintiravoglu.github.io/PoSApp/docs/version.txt";
            var newVersion = "";
            var currentVersion = "";
            var newVersionText = (new WebClient().DownloadString(urlAddress));
            var currentVersionText = GetType().Assembly.GetName().Version.ToString(); //Application.ProductVersion.ToString();


            newVersion = newVersionText.Replace(".", "");
            currentVersion = currentVersionText.Replace(".", "");
            lblYukluVersion.Text = currentVersionText;
            lblSonVersion.Text = newVersionText;
            if (Convert.ToInt32(newVersion) > Convert.ToInt32(currentVersion))
            {
                lblHeader.Text = "Yeni versiyon indirmeye hazır.\r\n Güncellemek için \"Güncelleme\" butonuna basın.";
                btnUpdate.Visible = true;
                updateBar.Visible = true;
                btnControl.Visible = false;
            }
            else
            {
                lblHeader.Text = "Şuan en güncel versiyona sahipsiniz.";
                btnUpdate.Visible = false;
                updateBar.Visible = false;
                btnControl.Visible = true;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            btnUpdate.Visible = false;           
            btnControl.Visible = false;
            createBackupFolder("yedek");

            WebClient web = new WebClient();
            lblHeader.Text = "Yeni versiyon indirilmeye başlandı.";

            web.DownloadFileCompleted += Web_DownloadFileCompleted;
            web.DownloadProgressChanged += Web_DownloadProgressChanged;
            web.DownloadFileAsync(new Uri("https://ergintiravoglu.github.io/PoSApp/PoSApp.Setup/Release/PoSApp.Setup.msi"), Application.StartupPath + @"\PoSApp.Setup.msi");


           
        }

        private void Web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            lblHeader.Text = "Yeni versiyon indiriliyor.";
            updateBar.Value = e.ProgressPercentage;

        }

        private void createBackupFolder(string subPath)
        {
            bool exists = Directory.Exists(subPath);

            if (!exists)
            {
                Directory.CreateDirectory(subPath);
            }

            File.Move("App.config.json", subPath + @"\App.config.json", true);
            File.Move("appsettings.json", subPath + @"\appsettings.json", true);
            File.Move("printsettings.json", subPath + @"\printsettings.json", true);
        }

        private void Web_DownloadFileCompleted(object? sender, AsyncCompletedEventArgs e)
        {
            initScript();
        }

        private void initScript()
        {
            lblHeader.Text = "Yeni versiyon yükleniyor.";
            string appPath = Application.StartupPath + @"\update.bat";

            Process p = new Process();
            p.StartInfo.FileName = appPath;
            p.StartInfo.Arguments = "";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.Verb = "runas";
            p.Start();
            Environment.Exit(1);
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            vesiyonControl();
        }
    }
}
