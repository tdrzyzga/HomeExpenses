using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace HomeExpenses.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var environmentName = "ASPNETCORE_ENVIRONMENT";

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