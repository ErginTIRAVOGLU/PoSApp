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

namespace PoSApp.UI.Forms.UpdateForms
{
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            var urlAddress = "https://ergintiravoglu.github.io/PoSApp/version.txt";
            var newVersion = "";
            var currentVersion = "";
            var newVersionText = (new WebClient().DownloadString(urlAddress));
            var currentVersionText = Application.ProductVersion.ToString();


            newVersion = newVersionText.Replace(".", "");
            currentVersion = currentVersionText.Replace(".", "");
            lblYukluVersion.Text = currentVersionText;
            lblSonVersion.Text = newVersionText;
            if (Convert.ToInt32(newVersion) > Convert.ToInt32(currentVersion))
            {
                lblHeader.Text = "Yeni versiyon indirmeye hazır.\r\n Güncellemek için \"Güncelleme\" butonuna basın.";
                btnUpdate.Enabled = true;
            }
            else
            {
                lblHeader.Text = "Şuan en güncel versiyona sahipsiniz.";
                btnUpdate.Enabled = false;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            WebClient web = new WebClient();
            web.DownloadFileCompleted += Web_DownloadFileCompleted;
            web.DownloadFileAsync(new Uri("https://ergintiravoglu.github.io/PoSApp/version.txt"), "path");
        }

        private void Web_DownloadFileCompleted(object? sender, AsyncCompletedEventArgs e)
        {
            initScript();
        }

        private void initScript()
        {
            string appPath = Application.StartupPath + @"\bat";

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
    }
}
