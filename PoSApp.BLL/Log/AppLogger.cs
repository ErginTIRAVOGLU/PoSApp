using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.BLL.Log
{
    public class AppLogger
    {
        static IConfigurationRoot configuration;
        
        static Logger logger ;

       
        public AppLogger()
        {
            var printSettingsFile = GetSettingsFile("appsettings.json");
            configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(printSettingsFile).Build();
            logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();//.WriteTo.File("TheCodeBuzz.txt").CreateLogger();
           

        }

        private string GetSettingsFile(string fileName)
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string userFilePath = Path.Combine(localAppData, "PoSApp");
            string destFilePath = Path.Combine(userFilePath, fileName);
            return destFilePath;
        }

        public void WriteLog(string message)
        {
            logger.Information(message);
           
        }
    }
}
