using Akka.DI.AutoFac;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Core.Akka.ActorAutostart;
using Core.Akka.ActorSystem;
using HomeExpenses.Infrastructure.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HomeExpenses.Host
{
    public class Startup
    {
        public Autofac.IContainer DiContainer { get; private set; }

        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // Configuration.
            services.AddSingleton<IConfiguration>(Configuration);

            services.AddDbContext<HomeExpensesDbContext>(options =>
                                                         options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            var builder = new ContainerBuilder();
            builder.RegisterModule<HomeExpensesHostModule>();
            builder.Populate(services);
            DiContainer = builder.Build();

            new AutoFacDependencyResolver(DiContainer, DiContainer.Resolve<ILocalActorSystemManager>().ActorSystem);

            return new AutofacServiceProvider(DiContainer);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IServiceProvider serviceProvider, IApplicationBuilder app, IHostingEnvironment env, IAutostartActorInitializer autostartActorInitializer)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            using (var serviceScope = serviceProvider.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<HomeExpensesDbContext>();
                context.Database.Migrate();
            }

            autostartActorInitializer.FindAndStartActors();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"Hello World!");
            });
        }
    }
}
