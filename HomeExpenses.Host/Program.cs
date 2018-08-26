using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace HomeExpenses.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var environmentName = "Development";

            WebHost.CreateDefaultBuilder()
                   .UseKestrel()
                   .UseContentRoot(Directory.GetCurrentDirectory())
                   .UseIISIntegration()
                   .UseStartup<Startup>()
                   .UseEnvironment(environmentName)
                   .Build()
                   .Run();
        }
    }
}