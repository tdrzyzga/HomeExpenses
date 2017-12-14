using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;

namespace HomeExpenses.Host
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
