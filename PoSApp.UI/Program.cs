using PoSApp.UI.Forms.BrandForms;

namespace PoSApp.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Environment.SetEnvironmentVariable("APP_BASE_DIRECTORY", AppContext.BaseDirectory);
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
           
        }
    }
}