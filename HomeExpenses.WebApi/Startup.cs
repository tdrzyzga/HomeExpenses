using Autofac;
using Autofac.Extensions.DependencyInjection;
using HomeExpenses.WebApi.Infrastructure.Controller;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
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

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
                // Formatting numbers, dates, etc.
                SupportedCultures = supportedCultures,
                // UI strings that we have localized.
                SupportedUICultures = supportedCultures
            });

            app.UseMvc();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(Configuration);

            services.AddCors();

            services.AddMvc()
                    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix,
                                         options => options.ResourcesPath = "Resources");

            services.AddSingleton<BaseControllerPayload>();

            var builder = new ContainerBuilder();
            builder.RegisterModule<HomeExpensesWebApiModule>();

            builder.Populate(services);
            DiContainer = builder.Build();

            return new AutofacServiceProvider(DiContainer);
        }
    }
}