using System;
using System.IO;
using Autofac;
using Microsoft.Extensions.Configuration;

namespace HomeExpenses.Host
{
    public class Bootstraper : IDisposable
    {
        public IContainer DiContainer { get; private set; }

        public void Dispose()
        {
            DiContainer?.Dispose();
        }

        public void Bootstrap()
        {
            var configuration = LoadConfiguration();
            RegisterDependencies(configuration);
        }

        private IConfigurationRoot LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .AddEnvironmentVariables();

            return builder.Build();
        }

        private void RegisterDependencies(IConfiguration configuration)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<HomeExpensesHostModule>();
            builder.RegisterInstance(configuration).AsImplementedInterfaces();
            DiContainer = builder.Build();
        }
    }
}