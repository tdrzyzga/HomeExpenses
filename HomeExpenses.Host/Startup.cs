using Autofac;
using Autofac.Extensions.DependencyInjection;
using HomeExpenses.Infrastructure.Databases;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using System;

namespace HomeExpenses.Host
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }
        public IContainer DiContainer { get; private set; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                          .SetBasePath(env.ContentRootPath)
                          .AddJsonFile("appsettings.json", false, true)
                          .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
                          .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IServiceProvider serviceProvider,
                              IApplicationBuilder app,
                              IHostingEnvironment env)
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

            app.Run(async context => { await context.Response.WriteAsync("Hello World!"); });
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // Configuration.
            services.AddSingleton<IConfiguration>(Configuration);

            services.AddDbContext<HomeExpensesDbContext>(options => options.UseLazyLoadingProxies()
                                                                                        .UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddLocalization(opt => opt.ResourcesPath = "Resources");
            services.AddSingleton<IStringLocalizer>(ctx => ctx.GetService<IStringLocalizer<Program>>());

            var builder = new ContainerBuilder();
            builder.RegisterModule<HomeExpensesHostModule>();
            builder.Register(ctx => ctx.Resolve<HomeExpensesDbContext>()).As<DbContext>();
            builder.Populate(services);
            DiContainer = builder.Build();

            return new AutofacServiceProvider(DiContainer);
        }
    }
}