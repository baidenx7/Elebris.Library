using Autofac;
using System.Linq;
using System.Reflection;
using Elebris.Database.Manager;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using Serilog;
using Microsoft.Extensions.Hosting;

namespace Elebris
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            ContainerBuilder builder = BuildContainer();//Autofac
            IConfigurationBuilder configBuilder = BuildConfig();//Microsoft
            #region Logging
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configBuilder.Build())
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();
            #endregion
            Log.Logger.Information("Application Starting");
            #region Hosting
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    //services.AddTransient<interface, concrete class>();
                })
                .UseSerilog()
                .Build();

            #endregion
            var config = configBuilder.Build();

            builder.Register(context => config).As<IConfiguration>(); //Bind Microsoft Config to Autofac
            builder.Register(context => host).As<IHostBuilder>(); //Bind Microsoft Hosting to Autofac
            return builder.Build();
            //https://alex-klaus.com/webapi-proj-without-autofac/
        }

        private static ContainerBuilder BuildContainer()
        {
            var builder = new ContainerBuilder();
            ////store definitions

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<UnitLogic>().As<IUnitLogic>();

            builder.RegisterType<SqlDataAccess>().As<ISqlDataAccess>();
            builder.RegisterType<StatData>().As<IStatData>();


            //nameof(Library.Units) fails, but the string below works.
            //Could not load file or assembly 'Units, Culture=neutral, PublicKeyToken=null'. The system cannot find the file specified.
            builder.RegisterAssemblyTypes(Assembly.Load("Elebris.Library.Units"))
                .Where(t => t.Namespace.Contains("Creation"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));
            return builder;
        }

        private static IConfigurationBuilder BuildConfig()
        {
            //could do .Where(t => t.Name.Contains("Factory"))//Builder

            IConfigurationBuilder configBuilder = new ConfigurationBuilder();
            configBuilder
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
                .AddEnvironmentVariables();
            //https://www.youtube.com/watch?v=GAOCe-2nXqc
            //https://stackoverflow.com/questions/47154870/configurationmodule-passed-into-module-and-context-dotnet-core

            return configBuilder;
        }
    }
}