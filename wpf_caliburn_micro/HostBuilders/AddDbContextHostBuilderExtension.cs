using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_caliburn_micro.HostBuilders
{
    public static class AddDbContextHostBuilderExtension
    {
        public static IHostBuilder AddDbContextHostBuilder(this IHostBuilder host)
        {
            host.ConfigureServices((context, services) =>
            {
                services.AddDbContext<Core.Data.DataContext>();
            });

            return host;
        }
    }
}
