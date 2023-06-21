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
            configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();//.WriteTo.File("TheCodeBuzz.txt").CreateLogger();
           

        }

        public void WriteLog(string message)
        {
            logger.Information(message);
           
        }
    }
}
