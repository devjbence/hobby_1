using Microsoft.Extensions.DependencyInjection;

namespace Logic.Services
{
    public static class LogicServiceCollection
    {
        public static ServiceCollection GetServiceCollection()
        {
            var serviceCollection = new ServiceCollection();

            //serviceCollection.AddSingleton<,>();

            return serviceCollection;
        }
    }
}
