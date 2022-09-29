using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ValueService.Lib;

namespace ValueGUI
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((services) =>
                {
                    services.AddSingleton<IValueService, ValueServices>();
                })
                .Build();
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(host.Services.GetRequiredService<IValueService>()));
        }
    }
}