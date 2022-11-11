using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;

namespace Nile.Windows
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static IConfiguration Configuration { get; private set; }
    }
}
