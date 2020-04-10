using System;
using Logic.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using StructureMap;
using View;
using View.Window.Interfaces;

namespace Hobby_1
{
    public class Startup
    {
        public static IServiceProvider serviceProvider;

        public static void RegisterServices()
        {
            // add StructureMap
            var container = new Container();
            container.Configure(config =>
            {
                // Register stuff in container, using the StructureMap APIs...
                config.Scan(_ =>
                {
                    _.AssemblyContainingType(typeof(Program));
                    _.WithDefaultConventions();
                });
                // Populate the container using the service collection
                config.Populate(WebServiceCollection.GetServiceCollection());
                config.Populate(LogicServiceCollection.GetServiceCollection());
                config.Populate(ViewServiceCollection.GetServiceCollection());
            });

            Log.Logger = new LoggerConfiguration()
                        .WriteTo.File("consoleapp.log")
                        .CreateLogger();

            serviceProvider = container.GetInstance<IServiceProvider>();

            var logger = serviceProvider.GetRequiredService<ILoggerFactory>()
                .CreateLogger<Program>();

            container.GetInstance<IWindow>().Test();
        }
    }
}
