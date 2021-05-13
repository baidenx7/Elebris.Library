
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.IO;
namespace Elebris.Configuration
{
    public static class Application
    {
        public static void Run()
        { 
            ConfigurationBuilder builder = new ConfigurationBuilder();
            ConfigureBuilder(builder);

            #region Logging
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())
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
        }

        private static void ConfigureBuilder(IConfigurationBuilder configBuilder)
        {
            configBuilder
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
                .AddEnvironmentVariables();
            //https://www.youtube.com/watch?v=GAOCe-2nXqc
            //https://stackoverflow.com/questions/47154870/configurationmodule-passed-into-module-and-context-dotnet-core

            configBuilder.Build();

            //https://alex-klaus.com/webapi-proj-without-autofac/
        }


    }
}

//builder.RegisterType<Application>().As<IApplication>();
//builder.RegisterType<UnitLogic>().As<IUnitLogic>();

//builder.RegisterType<SqlDataAccess>().As<ISqlDataAccess>();
//builder.RegisterType<StatData>().As<IStatData>();


////nameof(Library.Units) fails, but the string below works.
////Could not load file or assembly 'Units, Culture=neutral, PublicKeyToken=null'. The system cannot find the file specified.
//builder.RegisterAssemblyTypes(Assembly.Load("Elebris.Library.Units"))
//    .Where(t => t.Namespace.Contains("Creation"))
//    .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));
//return builder;