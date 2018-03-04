﻿using System.IO;
using Microsoft.AspNetCore.Hosting;

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
                       .UseSetting("detailedErrors", "true")
                       .UseIISIntegration()
                       .UseStartup<Startup>()
                       .UseEnvironment(environmentName)
                       .CaptureStartupErrors(true)
                       .Build();

            host.Run();
        }
    }
}