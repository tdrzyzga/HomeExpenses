using System;
using System.Globalization;
using Akka.DI.AutoFac;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Core.Akka.ActorSystem;
using HomeExpenses.WebApi.Infrastructure.Controller;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HomeExpenses.WebApi
{
    public class Startup
    {
        public IContainer DiContainer { get; private set; }

        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                          .SetBasePath(env.ContentRootPath)
                          .AddJsonFile("appsettings.json", false, true)
                          .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
                          .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(Configuration);

            services.AddMvc()
                    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix,
                                         options => options.ResourcesPath = "Resources");

            services.AddSingleton<BaseControllerPayload>();

            var builder = new ContainerBuilder();
            builder.RegisterModule<HomeExpensesWebApiModule>();
            builder.Register(ctx => Configuration.GetSection("ActorSystemConfiguration").Get<ActorSystemConfiguration>()).AsSelf().SingleInstance();
            builder.Populate(services);
            DiContainer = builder.Build();

            new AutoFacDependencyResolver(DiContainer, DiContainer.Resolve<ILocalActorSystemManager>().ActorSystem);

            return new AutofacServiceProvider(DiContainer);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
 
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
    }
}