using Autofac;
using Autofac.Extensions.DependencyInjection;
using HomeExpenses.Infrastructure.Databases;
using HomeExpenses.WebApi.Infrastructure.Controller;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Globalization;

namespace HomeExpenses.WebApi
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

        public void Configure(IServiceProvider serviceProvider, IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            var supportedCultures = new[]
            {
                new CultureInfo("pl-PL"),
                new CultureInfo("en-US")
            };

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("pl-PL"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            app.UseMvc();

            using (var serviceScope = serviceProvider.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<HomeExpensesDbContext>();
                context.Database.Migrate();
            }
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(Configuration);

            services.AddDbContext<HomeExpensesDbContext>(options => options.UseLazyLoadingProxies()
                                                                           .UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            services.AddCors();

            services.AddMvc()
                    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix,
                                         options => options.ResourcesPath = "Resources");

            var builder = new ContainerBuilder();

            builder.RegisterModule<HomeExpensesWebApiModule>();
            builder.Register(ctx => ctx.Resolve<HomeExpensesDbContext>()).As<DbContext>();
            builder.RegisterType<BaseControllerPayload>().AsSelf().SingleInstance();

            builder.Populate(services);
            DiContainer = builder.Build();

            return new AutofacServiceProvider(DiContainer);
        }
    }
}