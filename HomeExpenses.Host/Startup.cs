using Autofac;
using Autofac.Extensions.DependencyInjection;
using Core.Infrastructure.MessageBus;
using HomeExpenses.Infrastructure.Databases;
using MassTransit;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;

namespace HomeExpenses.Host
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }
        public IContainer DiContainer { get; private set; }

        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                          .SetBasePath(env.ContentRootPath)
                          .AddJsonFile("appsettings.json", false, true)
                          .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
                          .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // Configuration.
            services.AddSingleton<IConfiguration>(Configuration);

            services.AddDbContext<HomeExpensesDbContext>(options => options.UseLazyLoadingProxies()
                                                                           .UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddLocalization(opt => opt.ResourcesPath = "Resources");
            services.AddSingleton<IStringLocalizer>(ctx => ctx.GetService<IStringLocalizer<Program>>());
            services.AddMassTransit(x =>
            {
                x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(cfg =>
                {
                    var host = cfg.Host("localhost", "/", hostConfigurator =>
                    {
                        hostConfigurator.Username("guest");
                        hostConfigurator.Password("guest");
                    });

                    //cfg.ReceiveEndpoint(host, "Consumer1.MessageToFirstConsumerHandler", ep =>
                    //{
                    //    ep.ConfigureConsumer<MessageToFirstConsumerHandler>(provider);
                    //});


                    //cfg.ReceiveEndpoint(host, "Consumer1.MessageToAllConsumersHandler", ep =>
                    //{
                    //    ep.ConfigureConsumer<MessageToAllConsumersHandler>(provider);
                    //});

                    cfg.UseExtensionsLogging(new LoggerFactory());
                }));
            });

            services.AddSingleton<IBus>(provider => provider.GetRequiredService<IBusControl>());
            services.AddSingleton<IPublishEndpoint>(provider => provider.GetRequiredService<IBusControl>());
            services.AddSingleton<ISendEndpointProvider>(provider => provider.GetRequiredService<IBusControl>());
            services.AddSingleton<IHostedService, BusHostedService>();

            var builder = new ContainerBuilder();
            builder.RegisterModule<HomeExpensesHostModule>();
            builder.Register(ctx => ctx.Resolve<HomeExpensesDbContext>()).As<DbContext>();
            builder.Populate(services);
            DiContainer = builder.Build();

            return new AutofacServiceProvider(DiContainer);
        }

        public void Configure(IServiceProvider serviceProvider,
                              IApplicationBuilder app,
                              Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            using (var serviceScope = serviceProvider.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<HomeExpensesDbContext>();
                context.Database.Migrate();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
                var hostedService = serviceProvider.GetService<Microsoft.Extensions.Hosting.IHostedService>();
                await hostedService.StartAsync(CancellationToken.None);
            });
        }
    }
}