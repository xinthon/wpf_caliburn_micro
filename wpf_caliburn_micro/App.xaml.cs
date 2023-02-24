using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using wpf_caliburn_micro.Core.Data;
using wpf_caliburn_micro.HostBuilders;

namespace wpf_caliburn_micro
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IHost host;

        public App()
        {
            host = CreateHostBuilder().Build();
        }

        private static IHostBuilder CreateHostBuilder(string[] args = null)
        {
            return Host.CreateDefaultBuilder(args).AddDbContextHostBuilder();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            host.Start();
            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await host.StopAsync();
            host.Dispose();

            base.OnExit(e);
        }
    }
}
