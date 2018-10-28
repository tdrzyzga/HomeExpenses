using System;
using Akka.DI.AutoFac;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Core.Akka.ActorAutostart;
using Core.Akka.ActorSystem;
using Core.Application.Actors;
using Core.Presentation.Actors;
using HomeExpenses.Infrastructure.Databases;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;

namespace HomeExpenses.Host
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
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // Configuration.
            services.AddSingleton<IConfiguration>(Configuration);

            services.AddDbContext<HomeExpensesDbContext>(options =>
                                                             options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddLocalization(opt => opt.ResourcesPath = "Resources");
            services.AddTransient<IStringLocalizer>(ctx => ctx.GetService<IStringLocalizer<Program>>());

            var builder = new ContainerBuilder();
            builder.RegisterModule<HomeExpensesHostModule>();
            builder.Register(ctx => ctx.Resolve<HomeExpensesDbContext>()).As<DbContext>();
            builder.Populate(services);
            DiContainer = builder.Build();

            new AutoFacDependencyResolver(DiContainer, DiContainer.Resolve<ILocalActorSystemManager>().ActorSystem);

            return new AutofacServiceProvider(DiContainer);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IServiceProvider serviceProvider,
                              IApplicationBuilder app,
                              IHostingEnvironment env,
                              IAutostartActorInitializer autostartActorInitializer,
                              ILoggerFactory loggerFactory,
                              ICommandForwarderActorInitializer commandForwarderActorInitializer,
                              IQueryForwarderActorInitializer queryForwarderActorInitializer)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            using (var serviceScope = serviceProvider.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<HomeExpensesDbContext>();
                context.Database.Migrate();
            }

            autostartActorInitializer.FindAndStartActors();
            commandForwarderActorInitializer.StartCommandForwarderActor(autostartActorInitializer.AutostartedActors);
            queryForwarderActorInitializer.StartQueryForwarderActor(autostartActorInitializer.AutostartedActors);

            app.Run(async context => { await context.Response.WriteAsync("Hello World!"); });
        }
    }
}