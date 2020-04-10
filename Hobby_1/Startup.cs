using Logic.Services;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;
using View;

namespace Hobby_1
{
    public class Startup
    {
        public void RegisterServices()
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

            //configure file logging
            //serviceProvider
            //    .GetService<ILoggerFactory>()
            //    .add(LogLevel.Debug);

            //var logger = serviceProvider.GetService<ILoggerFactory>()
            //    .CreateLogger<Program>();
        }
    }
}
