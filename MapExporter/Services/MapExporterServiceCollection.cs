using Microsoft.Extensions.DependencyInjection;

namespace MapExporter.Services
{
    public class MapExporterServiceCollection
    {
        public static ServiceCollection GetServiceCollection()
        {
            var serviceCollection = new ServiceCollection();

            //serviceCollection.AddSingleton<,>();

            return serviceCollection;
        }
    }
}
