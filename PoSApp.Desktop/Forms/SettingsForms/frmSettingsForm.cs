using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using PoSApp.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoSApp.Desktop.Forms.SettingsForms
{
    public partial class frmSettingsForm : Form
    {
        public frmSettingsForm()
        {
            InitializeComponent();
        }
        public sealed class Settings
        {

            public required string connectionString { get; set; }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var databaseSettingsFile = GetSettingsFile("App.config.json");
            IConfiguration Configuration = new ConfigurationBuilder()
              .AddJsonFile(databaseSettingsFile, optional: true, reloadOnChange: true)
              .AddEnvironmentVariables()
              .Build();


            Settings section = Configuration.GetSection("Settings").Get<Settings>();
            //optionsBuilder.UseSqlServer(section.connectionString);
            BackupService backupService = new BackupService(section.connectionString, "./");
            backupService.BackupAllUserDatabases(); 
        }
        private string GetSettingsFile(string fileName)
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string userFilePath = Path.Combine(localAppData, "PoSApp");
            string destFilePath = Path.Combine(userFilePath, fileName);
            return destFilePath;
        }
    }
}
