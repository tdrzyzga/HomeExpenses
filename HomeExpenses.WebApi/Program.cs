using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HomeExpenses.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var environmentName = "ASPNETCORE_ENVIRONMENT";

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseEnvironment(environmentName)
                .Build();

            host.Run();
        }
    }
}
