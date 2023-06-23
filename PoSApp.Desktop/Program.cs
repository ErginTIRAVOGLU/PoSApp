using PoSApp.Desktop.Forms.BrandForms;

namespace PoSApp.Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           


            controlAndSave("App.config.json");
            controlAndSave("appsettings.json");
            controlAndSave("printsettings.json");

            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Environment.SetEnvironmentVariable("APP_BASE_DIRECTORY", AppContext.BaseDirectory);
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
           
        }

        private static void controlAndSave(string fileName)
        {
            /*
            string subPath = "yedek";
            bool exists = Directory.Exists(subPath);

            if (!exists)
            {
                Directory.CreateDirectory(subPath);
            }
            if (!File.Exists(fileName))
            {
                if (File.Exists(subPath + @"\"+ fileName))
                {
                    File.Copy(subPath + @"\"+ fileName, fileName, true);
                }
            }
            */

            string localAppData =  Environment.GetFolderPath( Environment.SpecialFolder.LocalApplicationData);
            string userFilePath= Path.Combine(localAppData, "PoSApp");

            if (!Directory.Exists(userFilePath))
            { 
                Directory.CreateDirectory(userFilePath);
            }

            
            string sourceFilePath = Path.Combine(System.Windows.Forms.Application.StartupPath, fileName);
            string destFilePath = Path.Combine(userFilePath, fileName);
            if (!File.Exists(destFilePath))
            {
                File.Copy(sourceFilePath, destFilePath);
            }
                

        }
    }
}