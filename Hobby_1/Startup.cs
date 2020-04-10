using System;
using Logic.Services;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;
using View;
using View.Scene.Interfaces;
using View.Window.Interfaces;

namespace Hobby_1
{
    public class Startup
    {
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

            var serviceProvider = container.GetInstance<IServiceProvider>();

            var window = serviceProvider.GetRequiredService<IWindow>();

            window.Test();

            //configure file logging
            //serviceProvider
            //    .GetService<ILoggerFactory>()
            //    .add(LogLevel.Debug);

            //var logger = serviceProvider.GetService<ILoggerFactory>()
            //    .CreateLogger<Program>();
        }
    }
}
