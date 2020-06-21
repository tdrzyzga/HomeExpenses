using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace HomeExpenses.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var environmentName = "Development";

            WebHost.CreateDefaultBuilder()
                   .UseKestrel()
                   .UseContentRoot(Directory.GetCurrentDirectory())
                   .UseUrls("http://localhost:60440")
                   .UseIISIntegration()
                   .UseStartup<Startup>()
                   .UseEnvironment(environmentName)
                   .Build()
                   .Run();
        }
    }
}