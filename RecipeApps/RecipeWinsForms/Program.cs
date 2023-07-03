using CPUFramework;

namespace RecipeWinsForms
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
            ApplicationConfiguration.Initialize();
            SQLUtility.ConnectionString = "Server=.\\SQLExpress;Database=HeartyHearthDB;Trusted_Connection=true;TrustServerCertificate=True";
            Application.Run(new frmSearch());
        }
    }
}